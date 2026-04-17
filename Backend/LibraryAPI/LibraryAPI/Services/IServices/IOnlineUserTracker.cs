namespace LibraryAPI.Services.IServices;

public interface IOnlineUserTracker
{
    bool AddConnection(string userId, string connectionId);
    bool RemoveConnection(string userId, string connectionId);
    bool IsOnline(string userId);
}
