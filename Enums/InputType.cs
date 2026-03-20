namespace SoftRemote.Shared.Enums;

public enum InputType
{
    MouseMove = 0,
    MouseDown = 1,
    MouseUp = 2,
    MouseScroll = 3,
    KeyDown = 4,
    KeyUp = 5,
    MouseDoubleClick = 6
}

public enum MouseButton
{
    Left = 0,
    Right = 1,
    Middle = 2
}

public enum SessionStatus
{
    Waiting = 0,
    Connected = 1,
    Disconnected = 2,
    Expired = 3
}

public enum ConnectionQuality
{
    Low = 0,       // 5 FPS, 30% JPEG
    Medium = 1,    // 15 FPS, 50% JPEG
    High = 2,      // 30 FPS, 70% JPEG
    Ultra = 3      // 60 FPS, 90% JPEG
}
