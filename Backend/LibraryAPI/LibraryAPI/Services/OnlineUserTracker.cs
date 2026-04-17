using LibraryAPI.Services.IServices;
using System.Collections.Concurrent;

namespace LibraryAPI.Services;

public class OnlineUserTracker : IOnlineUserTracker
{
    private readonly ConcurrentDictionary<string, HashSet<string>> _connections = new();
    private readonly object _syncRoot = new();

    public bool AddConnection(string userId, string connectionId)
    {
        lock (_syncRoot)
        {
            if (!_connections.TryGetValue(userId, out var userConnections))
            {
                userConnections = new HashSet<string>(StringComparer.Ordinal);
                userConnections.Add(connectionId);
                _connections[userId] = userConnections;
                return true;
            }

            userConnections.Add(connectionId);
            return userConnections.Count == 1;
        }
    }

    public bool RemoveConnection(string userId, string connectionId)
    {
        lock (_syncRoot)
        {
            if (!_connections.TryGetValue(userId, out var userConnections))
            {
                return false;
            }

            userConnections.Remove(connectionId);

            if (userConnections.Count == 0)
            {
                _connections.TryRemove(userId, out _);
                return true;
            }

            return false;
        }
    }

    public bool IsOnline(string userId)
    {
        return _connections.ContainsKey(userId);
    }
}
