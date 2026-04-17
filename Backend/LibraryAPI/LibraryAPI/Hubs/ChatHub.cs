using LibraryAPI.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace LibraryAPI.Hubs;

[Authorize]
public class ChatHub : Hub
{
    private readonly IChatService _chatService;
    private readonly IOnlineUserTracker _onlineUserTracker;

    public ChatHub(IChatService chatService, IOnlineUserTracker onlineUserTracker)
    {
        _chatService = chatService;
        _onlineUserTracker = onlineUserTracker;
    }

    public override async Task OnConnectedAsync()
    {
        var userId = GetCurrentUserId();
        if (!string.IsNullOrWhiteSpace(userId))
        {
            var firstConnection = _onlineUserTracker.AddConnection(userId, Context.ConnectionId);
            if (firstConnection)
            {
                await Clients.Others.SendAsync("UserOnline", userId);
            }
        }

        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        var userId = GetCurrentUserId();
        if (!string.IsNullOrWhiteSpace(userId))
        {
            var becameOffline = _onlineUserTracker.RemoveConnection(userId, Context.ConnectionId);
            if (becameOffline)
            {
                await Clients.Others.SendAsync("UserOffline", userId);
            }
        }

        await base.OnDisconnectedAsync(exception);
    }

    public async Task JoinConversation(Guid conversationId)
    {
        if (!await _chatService.CanAccessConversationAsync(conversationId))
        {
            throw new HubException("Unauthorized conversation access.");
        }

        await Groups.AddToGroupAsync(Context.ConnectionId, BuildConversationGroup(conversationId));
    }

    public async Task LeaveConversation(Guid conversationId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, BuildConversationGroup(conversationId));
    }

    public async Task SendTyping(Guid conversationId, bool isTyping)
    {
        if (!await _chatService.CanAccessConversationAsync(conversationId))
        {
            throw new HubException("Unauthorized conversation access.");
        }

        var me = await _chatService.GetCurrentUserInfoAsync();

        await Clients.GroupExcept(BuildConversationGroup(conversationId), new[] { Context.ConnectionId })
            .SendAsync("Typing", new
            {
                conversationId,
                userId = me.Id,
                userName = me.DisplayName,
                isTyping
            });
    }

    public async Task SendMessage(Guid conversationId, string content)
    {
        var message = await _chatService.SendMessageAsync(conversationId, content);

        await Clients.Group(BuildConversationGroup(conversationId)).SendAsync("MessageReceived", message);
    }

    private static string BuildConversationGroup(Guid conversationId) => $"conversation:{conversationId}";

    private string? GetCurrentUserId()
    {
        return Context.User?.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
            ?? Context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value
            ?? Context.User?.FindFirst("sub")?.Value;
    }
}
