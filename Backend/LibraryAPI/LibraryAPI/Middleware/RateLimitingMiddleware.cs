using System.Collections.Concurrent;

namespace LibraryAPI.Middleware;

public class RateLimitingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IRateLimiter _rateLimiter;

    public RateLimitingMiddleware(RequestDelegate next, IRateLimiter rateLimiter)
    {
        _next = next;
        _rateLimiter = rateLimiter;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var path = context.Request.Path.Value?.ToLower() ?? "";

        // Only apply rate limiting to registration endpoint to prevent brute force
        if (path.Contains("/api/user/register"))
        {
            var clientIp = GetClientIpAddress(context);

            var blockResult = _rateLimiter.IsAllowed(clientIp);
            if (!blockResult.IsAllowed)
            {
                context.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                context.Response.ContentType = "application/json";
                
                var message = blockResult.IsPermanentlyBlocked
                    ? "Your IP has been blocked for 10 hours due to too many registration attempts."
                    : "Too many requests. Please try again later.";

                await context.Response.WriteAsJsonAsync(new
                {
                    error = "Too many requests. Please try again later.",
                    message = message
                });
                return;
            }
        }

        await _next(context);
    }

    private string GetClientIpAddress(HttpContext context)
    {
        // Check for X-Forwarded-For header (proxy/load balancer)
        if (context.Request.Headers.TryGetValue("X-Forwarded-For", out var forwardedFor))
        {
            return forwardedFor.ToString().Split(',')[0].Trim();
        }

        // Check for X-Real-IP header
        if (context.Request.Headers.TryGetValue("X-Real-IP", out var realIp))
        {
            return realIp.ToString();
        }

        // Fall back to RemoteIpAddress
        return context.Connection.RemoteIpAddress?.ToString() ?? "unknown";
    }
}

public class RateLimitCheckResult
{
    public bool IsAllowed { get; set; }
    public bool IsPermanentlyBlocked { get; set; }
}

public interface IRateLimiter
{
    RateLimitCheckResult IsAllowed(string clientIp);
    void ClearExpiredBlocks();
}

public class RateLimiter : IRateLimiter
{
    private readonly ConcurrentDictionary<string, List<DateTime>> _requestTimestamps 
        = new ConcurrentDictionary<string, List<DateTime>>();
    
    private readonly ConcurrentDictionary<string, DateTime> _blockedIps 
        = new ConcurrentDictionary<string, DateTime>();

    private readonly int _maxRequests;
    private readonly TimeSpan _timeWindow;
    private readonly TimeSpan _blockDuration;
    private readonly Timer _cleanupTimer;

    public RateLimiter(int maxRequests = 10, int timeWindowSeconds = 60, int blockDurationHours = 10)
    {
        _maxRequests = maxRequests;
        _timeWindow = TimeSpan.FromSeconds(timeWindowSeconds);
        _blockDuration = TimeSpan.FromHours(blockDurationHours);

        // Run cleanup every 30 minutes
        _cleanupTimer = new Timer(_ => ClearExpiredBlocks(), null, TimeSpan.FromMinutes(30), TimeSpan.FromMinutes(30));
    }

    public RateLimitCheckResult IsAllowed(string clientIp)
    {
        var now = DateTime.UtcNow;

        // Check if IP is permanently blocked
        if (_blockedIps.TryGetValue(clientIp, out var blockedUntil))
        {
            if (now < blockedUntil)
            {
                // Still blocked
                return new RateLimitCheckResult 
                { 
                    IsAllowed = false, 
                    IsPermanentlyBlocked = true 
                };
            }
            else
            {
                // Block duration expired, remove from blocked list and reset counter
                _blockedIps.TryRemove(clientIp, out _);
                _requestTimestamps.TryRemove(clientIp, out _);
            }
        }

        var windowStart = now.Subtract(_timeWindow);

        var timestamps = _requestTimestamps.AddOrUpdate(clientIp,
            new List<DateTime> { now },
            (key, existing) =>
            {
                // Remove timestamps outside the time window
                existing.RemoveAll(t => t < windowStart);

                // Add current request
                existing.Add(now);

                // Check if we've reached the limit
                if (existing.Count >= _maxRequests)
                {
                    // Block this IP for 10 hours
                    _blockedIps.AddOrUpdate(clientIp, now.Add(_blockDuration), (k, v) => now.Add(_blockDuration));
                }

                return existing;
            });

        // Remove outdated entries
        timestamps.RemoveAll(t => t < windowStart);

        // If we just hit the limit, block it
        if (timestamps.Count >= _maxRequests && _blockedIps.ContainsKey(clientIp))
        {
            return new RateLimitCheckResult 
            { 
                IsAllowed = false, 
                IsPermanentlyBlocked = true 
            };
        }

        return new RateLimitCheckResult 
        { 
            IsAllowed = true, 
            IsPermanentlyBlocked = false 
        };
    }

    public void ClearExpiredBlocks()
    {
        var now = DateTime.UtcNow;
        var keysToRemove = new List<string>();

        foreach (var kvp in _blockedIps)
        {
            if (now >= kvp.Value)
            {
                keysToRemove.Add(kvp.Key);
            }
        }

        foreach (var key in keysToRemove)
        {
            _blockedIps.TryRemove(key, out _);
            _requestTimestamps.TryRemove(key, out _);
        }
    }
}
