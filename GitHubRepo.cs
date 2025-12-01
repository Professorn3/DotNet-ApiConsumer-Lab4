using System;
using System.Text.Json.Serialization;

/// <summary>
/// Representerar de intressanta egenskaperna i ett repository (projekt)
/// från GitHubs API för .NET Foundation.
/// </summary>
public class GitHubRepo
{
    // Mappar det JSON-fältet "name" (gemener) till C#-egenskapen Name (stor bokstav),
    // vilket uppgiften krävde.
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    // Fältet "description"
    public string? Description { get; set; }

    // Mappar JSON-fältet "html_url" (projektets länk)
    [JsonPropertyName("html_url")]
    public string? HtmlUrl { get; set; }

    // Fältet "homepage" (om projektet har en dedikerad hemsida)
    public string? Homepage { get; set; }

    // Mappar JSON-fältet "watchers_count" till Watchers.
    // (Fältet "watchers" kan vara föråldrat i vissa API:er, "watchers_count" är säkrare).
    [JsonPropertyName("watchers_count")]
    public int Watchers { get; set; }

    // Mappar JSON-fältet "pushed_at" (datum/tid för senaste push)
    [JsonPropertyName("pushed_at")]
    public DateTime PushedAt { get; set; }
}