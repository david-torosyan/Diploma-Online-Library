using Library.DAL.IRepositories;
using Library.DAL.Models;
using LibraryAPI.Models;
using LibraryAPI.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace LibraryAPI.Services;

public class ChatService : IChatService
{
    private const int MaxMessageLength = 2000;

    private readonly IConversationRepository _conversationRepository;
    private readonly IChatMessageRepository _chatMessageRepository;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IOnlineUserTracker _onlineUserTracker;

    public ChatService(
        IConversationRepository conversationRepository,
        IChatMessageRepository chatMessageRepository,
        UserManager<ApplicationUser> userManager,
        IHttpContextAccessor httpContextAccessor,
        IOnlineUserTracker onlineUserTracker)
    {
        _conversationRepository = conversationRepository;
        _chatMessageRepository = chatMessageRepository;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
        _onlineUserTracker = onlineUserTracker;
    }

    public async Task<List<ConversationSummaryDto>> GetMyConversationsAsync()
    {
        var currentUserId = GetCurrentUserId();
        var conversations = await _conversationRepository.GetUserConversationsAsync(currentUserId);

        var result = new List<ConversationSummaryDto>(conversations.Count);

        foreach (var conversation in conversations)
        {
            var unreadCount = await _chatMessageRepository.GetUnreadCountForConversationAsync(conversation.Id, currentUserId);
            result.Add(MapConversationSummary(conversation, currentUserId, unreadCount));
        }

        return result;
    }

    public async Task<ConversationSummaryDto> StartPrivateConversationAsync(string recipientUserId)
    {
        var currentUserId = GetCurrentUserId();

        if (string.IsNullOrWhiteSpace(recipientUserId))
        {
            throw new ArgumentException("Recipient user is required.");
        }

        if (recipientUserId == currentUserId)
        {
            throw new ArgumentException("You cannot start a conversation with yourself.");
        }

        var recipient = await _userManager.FindByIdAsync(recipientUserId);
        if (recipient == null)
        {
            throw new KeyNotFoundException("Recipient user was not found.");
        }

        var existingConversation = await _conversationRepository.GetPrivateConversationAsync(currentUserId, recipientUserId);
        if (existingConversation != null)
        {
            var existingDetails = await _conversationRepository.GetByIdWithDetailsAsync(existingConversation.Id);
            if (existingDetails == null)
            {
                throw new KeyNotFoundException("Conversation was not found.");
            }

            var existingUnreadCount = await _chatMessageRepository.GetUnreadCountForConversationAsync(existingDetails.Id, currentUserId);
            return MapConversationSummary(existingDetails, currentUserId, existingUnreadCount);
        }

        var nowUtc = DateTime.UtcNow;
        var conversation = new Conversation
        {
            Id = Guid.NewGuid(),
            IsGroup = false,
            CreatedByUserId = currentUserId,
            CreatedAtUtc = nowUtc,
            LastMessageAtUtc = nowUtc,
            Participants = new List<ConversationParticipant>
            {
                new()
                {
                    ApplicationUserId = currentUserId,
                    JoinedAtUtc = nowUtc,
                    LastReadAtUtc = nowUtc
                },
                new()
                {
                    ApplicationUserId = recipientUserId,
                    JoinedAtUtc = nowUtc,
                    LastReadAtUtc = nowUtc
                }
            }
        };

        await _conversationRepository.AddAsync(conversation);
        await _conversationRepository.SaveChangesAsync();

        var createdConversation = await _conversationRepository.GetByIdWithDetailsAsync(conversation.Id)
            ?? throw new KeyNotFoundException("Conversation was not found.");

        return MapConversationSummary(createdConversation, currentUserId, 0);
    }

    public async Task<ConversationSummaryDto> CreateGroupConversationAsync(CreateGroupConversationRequestDto request)
    {
        var currentUserId = GetCurrentUserId();

        if (request == null)
        {
            throw new ArgumentException("Request body is required.");
        }

        if (string.IsNullOrWhiteSpace(request.Name))
        {
            throw new ArgumentException("Group name is required.");
        }

        var normalizedParticipants = request.ParticipantUserIds
            .Where(id => !string.IsNullOrWhiteSpace(id))
            .Select(id => id.Trim())
            .Distinct(StringComparer.Ordinal)
            .ToList();

        if (!normalizedParticipants.Contains(currentUserId, StringComparer.Ordinal))
        {
            normalizedParticipants.Add(currentUserId);
        }

        if (normalizedParticipants.Count < 2)
        {
            throw new ArgumentException("A group chat must include at least two participants.");
        }

        var existingUsers = await _userManager.Users
            .Where(u => normalizedParticipants.Contains(u.Id))
            .Select(u => u.Id)
            .ToListAsync();

        var missingUsers = normalizedParticipants.Except(existingUsers, StringComparer.Ordinal).ToList();
        if (missingUsers.Count > 0)
        {
            throw new KeyNotFoundException("One or more selected users were not found.");
        }

        var nowUtc = DateTime.UtcNow;

        var conversation = new Conversation
        {
            Id = Guid.NewGuid(),
            IsGroup = true,
            Name = request.Name.Trim(),
            CreatedByUserId = currentUserId,
            CreatedAtUtc = nowUtc,
            LastMessageAtUtc = nowUtc,
            Participants = normalizedParticipants.Select(userId => new ConversationParticipant
            {
                ApplicationUserId = userId,
                JoinedAtUtc = nowUtc,
                LastReadAtUtc = nowUtc
            }).ToList()
        };

        await _conversationRepository.AddAsync(conversation);
        await _conversationRepository.SaveChangesAsync();

        var createdConversation = await _conversationRepository.GetByIdWithDetailsAsync(conversation.Id)
            ?? throw new KeyNotFoundException("Conversation was not found.");

        return MapConversationSummary(createdConversation, currentUserId, 0);
    }

    public async Task<List<ChatMessageDto>> GetMessagesAsync(Guid conversationId, int pageSize = 50, long? beforeMessageId = null)
    {
        var currentUserId = GetCurrentUserId();

        var hasAccess = await _conversationRepository.IsParticipantAsync(conversationId, currentUserId);
        if (!hasAccess)
        {
            throw new UnauthorizedAccessException("You are not allowed to access this conversation.");
        }

        var messages = await _chatMessageRepository.GetConversationMessagesAsync(conversationId, pageSize, beforeMessageId);
        return messages.Select(MapMessage).ToList();
    }

    public async Task<ChatMessageDto> SendMessageAsync(Guid conversationId, string content)
    {
        var currentUserId = GetCurrentUserId();

        if (!await _conversationRepository.IsParticipantAsync(conversationId, currentUserId))
        {
            throw new UnauthorizedAccessException("You are not allowed to send messages to this conversation.");
        }

        var sanitized = (content ?? string.Empty).Trim();
        if (string.IsNullOrWhiteSpace(sanitized))
        {
            throw new ArgumentException("Message cannot be empty.");
        }

        if (sanitized.Length > MaxMessageLength)
        {
            throw new ArgumentException($"Message cannot exceed {MaxMessageLength} characters.");
        }

        var sender = await _userManager.FindByIdAsync(currentUserId)
            ?? throw new KeyNotFoundException("Sender user was not found.");

        var conversation = await _conversationRepository.GetByIdWithParticipantsAsync(conversationId)
            ?? throw new KeyNotFoundException("Conversation was not found.");

        var nowUtc = DateTime.UtcNow;
        var message = new ChatMessage
        {
            ConversationId = conversationId,
            SenderUserId = currentUserId,
            Content = sanitized,
            SentAtUtc = nowUtc
        };

        conversation.LastMessageAtUtc = nowUtc;

        await _chatMessageRepository.AddAsync(message);
        await _chatMessageRepository.SaveChangesAsync();

        return new ChatMessageDto
        {
            Id = message.Id,
            ConversationId = conversationId,
            SenderUserId = currentUserId,
            SenderName = BuildDisplayName(sender),
            Content = message.Content,
            SentAtUtc = message.SentAtUtc
        };
    }

    public async Task MarkConversationAsReadAsync(Guid conversationId)
    {
        var currentUserId = GetCurrentUserId();

        var participant = await _conversationRepository.GetParticipantAsync(conversationId, currentUserId)
            ?? throw new UnauthorizedAccessException("You are not allowed to access this conversation.");

        participant.LastReadAtUtc = DateTime.UtcNow;
        await _conversationRepository.SaveChangesAsync();
    }

    public async Task AddParticipantAsync(Guid conversationId, string participantUserId)
    {
        var currentUserId = GetCurrentUserId();

        if (string.IsNullOrWhiteSpace(participantUserId))
        {
            throw new ArgumentException("Participant user is required.");
        }

        var conversation = await _conversationRepository.GetByIdWithParticipantsAsync(conversationId)
            ?? throw new KeyNotFoundException("Conversation was not found.");

        if (!conversation.IsGroup)
        {
            throw new InvalidOperationException("Participants can only be added to group chats.");
        }

        if (!conversation.Participants.Any(p => p.ApplicationUserId == currentUserId))
        {
            throw new UnauthorizedAccessException("You are not allowed to modify this conversation.");
        }

        if (conversation.Participants.Any(p => p.ApplicationUserId == participantUserId))
        {
            return;
        }

        var user = await _userManager.FindByIdAsync(participantUserId);
        if (user == null)
        {
            throw new KeyNotFoundException("Participant user was not found.");
        }

        await _conversationRepository.AddParticipantAsync(new ConversationParticipant
        {
            ConversationId = conversationId,
            ApplicationUserId = participantUserId,
            JoinedAtUtc = DateTime.UtcNow,
            LastReadAtUtc = DateTime.UtcNow
        });

        await _conversationRepository.SaveChangesAsync();
    }

    public async Task<long> GetUnreadCountAsync()
    {
        var currentUserId = GetCurrentUserId();
        return await _chatMessageRepository.GetUnreadCountAsync(currentUserId);
    }

    public async Task<bool> CanAccessConversationAsync(Guid conversationId)
    {
        var currentUserId = GetCurrentUserId();
        return await _conversationRepository.IsParticipantAsync(conversationId, currentUserId);
    }

    public async Task<List<ChatUserDto>> GetUsersAsync()
    {
        var currentUserId = GetCurrentUserId();

        var users = await _userManager.Users
            .AsNoTracking()
            .Where(u => u.Id != currentUserId)
            .OrderBy(u => u.FirstName)
            .ThenBy(u => u.LastName)
            .ThenBy(u => u.Email)
            .ToListAsync();

        return users.Select(u => new ChatUserDto
        {
            Id = u.Id,
            DisplayName = BuildDisplayName(u),
            Email = u.Email,
            IsOnline = _onlineUserTracker.IsOnline(u.Id)
        }).ToList();
    }

    public async Task<ChatUserDto> GetCurrentUserInfoAsync()
    {
        var currentUserId = GetCurrentUserId();
        var user = await _userManager.FindByIdAsync(currentUserId)
            ?? throw new KeyNotFoundException("Current user was not found.");

        return new ChatUserDto
        {
            Id = user.Id,
            DisplayName = BuildDisplayName(user),
            Email = user.Email,
            IsOnline = _onlineUserTracker.IsOnline(user.Id)
        };
    }

    private string GetCurrentUserId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        if (user == null || user.Identity?.IsAuthenticated != true)
        {
            throw new UnauthorizedAccessException("Unauthorized user.");
        }

        var userId = user.FindFirstValue(JwtRegisteredClaimNames.Sub)
            ?? user.FindFirstValue(ClaimTypes.NameIdentifier)
            ?? user.FindFirstValue("sub");

        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new UnauthorizedAccessException("Unauthorized user.");
        }

        return userId;
    }

    private ConversationSummaryDto MapConversationSummary(Conversation conversation, string currentUserId, int unreadCount)
    {
        var lastMessage = conversation.Messages
            .OrderByDescending(m => m.SentAtUtc)
            .FirstOrDefault();

        var title = conversation.IsGroup
            ? (conversation.Name ?? "Untitled group")
            : BuildPrivateConversationTitle(conversation, currentUserId);

        return new ConversationSummaryDto
        {
            Id = conversation.Id,
            IsGroup = conversation.IsGroup,
            Title = title,
            LastMessageAtUtc = conversation.LastMessageAtUtc,
            UnreadCount = unreadCount,
            Participants = conversation.Participants.Select(p => new ChatUserDto
            {
                Id = p.ApplicationUserId,
                DisplayName = BuildDisplayName(p.User),
                Email = p.User.Email,
                IsOnline = _onlineUserTracker.IsOnline(p.ApplicationUserId)
            }).ToList(),
            LastMessage = lastMessage == null ? null : MapMessage(lastMessage)
        };
    }

    private string BuildPrivateConversationTitle(Conversation conversation, string currentUserId)
    {
        var partner = conversation.Participants
            .FirstOrDefault(p => p.ApplicationUserId != currentUserId)?.User;

        return partner == null ? "Direct chat" : BuildDisplayName(partner);
    }

    private static string BuildDisplayName(ApplicationUser user)
    {
        var fullName = string.Join(" ", new[] { user.FirstName, user.LastName }
            .Where(part => !string.IsNullOrWhiteSpace(part)))
            .Trim();

        if (!string.IsNullOrWhiteSpace(fullName))
        {
            return fullName;
        }

        return user.Email ?? user.UserName ?? user.Id;
    }

    private static ChatMessageDto MapMessage(ChatMessage message)
    {
        return new ChatMessageDto
        {
            Id = message.Id,
            ConversationId = message.ConversationId,
            SenderUserId = message.SenderUserId,
            SenderName = message.SenderUser == null ? "Unknown" : BuildDisplayName(message.SenderUser),
            Content = message.Content,
            SentAtUtc = message.SentAtUtc
        };
    }
}
