using System.Diagnostics;

namespace AuthServiceIN6BM.Api.Models;

public class ErrorResponse
{
    public int StatusCode { get; set; }

    public string Title { get; set; }

    public string Detail { get; set; }
    public string? ErrorCode { get; set; }    
    public string TraceId { get; set; } = Activity.Current?.Id ?? string.Empty;
    public DateTime Timestamps { get; set; } = DateTime.UtcNow;
}