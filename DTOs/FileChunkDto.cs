namespace SoftRemote.Shared.DTOs;

public class FileChunkDto
{
    public string TransferId { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public long FileSize { get; set; }
    public int ChunkIndex { get; set; }
    public int TotalChunks { get; set; }
    public byte[] Data { get; set; } = Array.Empty<byte>();
    public string Checksum { get; set; } = string.Empty;
}

public class FileTransferRequestDto
{
    public string SessionId { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public long FileSize { get; set; }
    public string Direction { get; set; } = "upload"; // upload | download
}
