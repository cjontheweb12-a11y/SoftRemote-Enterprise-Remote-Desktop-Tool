namespace SoftRemote.Shared.DTOs;

public class ScreenFrameDto
{
    public string SessionId { get; set; } = string.Empty;
    public byte[] ImageData { get; set; } = Array.Empty<byte>();
    public int Width { get; set; }
    public int Height { get; set; }
    public long Timestamp { get; set; }
    public int SequenceNumber { get; set; }
    public bool IsKeyFrame { get; set; }
    public string Region { get; set; } = string.Empty; // "x,y,w,h" for partial updates
}
