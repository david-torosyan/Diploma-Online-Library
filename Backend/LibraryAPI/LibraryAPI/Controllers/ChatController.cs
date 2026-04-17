using LibraryAPI.Hubs;
using LibraryAPI.Models;
using LibraryAPI.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ChatController : ControllerBase
{
    private readonly IChatService _chatService;
    private readonly IHubContext<ChatHub> _hubContext;

    public ChatController(IChatService chatService, IHubContext<ChatHub> hubContext)
    {
        _chatService = chatService;
        _hubContext = hubContext;
    }

    [HttpGet("users")]
    [ProducesResponseType(typeof(IEnumerable<ChatUserDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<ChatUserDto>>> GetUsers()
    {
        var users = await _chatService.GetUsersAsync();
        return Ok(users);
    }

    [HttpGet("conversations")]
    [ProducesResponseType(typeof(IEnumerable<ConversationSummaryDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<ConversationSummaryDto>>> GetConversations()
    {
        var conversations = await _chatService.GetMyConversationsAsync();
        return Ok(conversations);
    }

    [HttpPost("conversations/private")]
    [ProducesResponseType(typeof(ConversationSummaryDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ConversationSummaryDto>> StartPrivateConversation([FromBody] CreatePrivateConversationRequestDto request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var conversation = await _chatService.StartPrivateConversationAsync(request.RecipientUserId);
        return Ok(conversation);
    }

    [HttpPost("conversations/group")]
    [ProducesResponseType(typeof(ConversationSummaryDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ConversationSummaryDto>> CreateGroupConversation([FromBody] CreateGroupConversationRequestDto request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var conversation = await _chatService.CreateGroupConversationAsync(request);
        return Ok(conversation);
    }

    [HttpGet("conversations/{conversationId:guid}/messages")]
    [ProducesResponseType(typeof(IEnumerable<ChatMessageDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<ChatMessageDto>>> GetMessages(
        Guid conversationId,
        [FromQuery] int pageSize = 50,
        [FromQuery] long? beforeMessageId = null)
    {
        var messages = await _chatService.GetMessagesAsync(conversationId, pageSize, beforeMessageId);
        return Ok(messages);
    }

    [HttpPost("conversations/{conversationId:guid}/messages")]
    [ProducesResponseType(typeof(ChatMessageDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ChatMessageDto>> SendMessage(Guid conversationId, [FromBody] SendMessageRequestDto request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var message = await _chatService.SendMessageAsync(conversationId, request.Content);

        await _hubContext.Clients.Group($"conversation:{conversationId}")
            .SendAsync("MessageReceived", message);

        return Ok(message);
    }

    [HttpPost("conversations/{conversationId:guid}/read")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> MarkConversationRead(Guid conversationId)
    {
        await _chatService.MarkConversationAsReadAsync(conversationId);
        return NoContent();
    }

    [HttpPost("conversations/{conversationId:guid}/participants")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AddParticipant(Guid conversationId, [FromBody] AddConversationParticipantRequestDto request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _chatService.AddParticipantAsync(conversationId, request.UserId);
        return NoContent();
    }

    [HttpGet("unread-count")]
    [ProducesResponseType(typeof(long), StatusCodes.Status200OK)]
    public async Task<ActionResult<long>> GetUnreadCount()
    {
        var count = await _chatService.GetUnreadCountAsync();
        return Ok(count);
    }
}
