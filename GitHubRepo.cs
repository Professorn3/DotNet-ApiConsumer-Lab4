using System;
using System.Text.Json.Serialization;

// Repo från GitHubs API.
public class GitHubRepo
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; } = string.Empty;

    public string? Homepage { get; set; }

    [JsonPropertyName("watchers_count")]
    public int Watchers { get; set; }

    [JsonPropertyName("pushed_at")]
    public DateTime PushedAt { get; set; }
}