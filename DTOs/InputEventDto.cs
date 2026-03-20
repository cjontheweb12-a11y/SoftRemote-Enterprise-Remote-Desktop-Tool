using SoftRemote.Shared.Enums;

namespace SoftRemote.Shared.DTOs;

public class InputEventDto
{
    public string SessionId { get; set; } = string.Empty;
    public InputType Type { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public int KeyCode { get; set; }
    public MouseButton Button { get; set; }
    public int ScrollDelta { get; set; }
    public long Timestamp { get; set; }
    public bool CtrlKey { get; set; }
    public bool AltKey { get; set; }
    public bool ShiftKey { get; set; }
}
