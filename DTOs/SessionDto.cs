using SoftRemote.Shared.Enums;

namespace SoftRemote.Shared.DTOs;

public class SessionDto
{
    public string SessionId { get; set; } = string.Empty;
    public string DeviceId { get; set; } = string.Empty;
    public string DeviceName { get; set; } = string.Empty;
    public string AccessPassword { get; set; } = string.Empty;
    public SessionStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public string HostOS { get; set; } = string.Empty;
    public int ScreenWidth { get; set; }
    public int ScreenHeight { get; set; }
}

public class ConnectionRequestDto
{
    public string DeviceId { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string ViewerName { get; set; } = string.Empty;
    public ConnectionQuality Quality { get; set; } = ConnectionQuality.Medium;
}

public class ConnectionResponseDto
{
    public bool Accepted { get; set; }
    public string SessionId { get; set; } = string.Empty;
    public string Reason { get; set; } = string.Empty;
}
