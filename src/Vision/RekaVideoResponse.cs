using System.Text.Json.Serialization;

namespace Reka.SDK.Vision;

/// <summary>
/// Response model for the Reka API videos/get endpoint (DTO)
/// </summary>
public class RekaVideoResponse
{
    /// <summary>
    /// List of videos returned by the API. Cannot be null, may be empty.
    /// </summary>
    [JsonPropertyName("results")]
    public List<Video> Results { get; set; } = new();
}