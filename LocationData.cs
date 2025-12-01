using System.Text.Json.Serialization;
using System.Collections.Generic;

// Plats i API svaret från Zippopotam.us.
public class Place
{
    [JsonPropertyName("place name")]
    public string City { get; set; } = string.Empty;

    [JsonPropertyName("state abbreviation")]
    public string StateAbbreviation { get; set; } = string.Empty;

    [JsonPropertyName("post code")]
    public string PostCode { get; set; } = string.Empty;

    public string Latitude { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
}

// API svar från Zippopotam.us.
public class LocationData
{
    [JsonPropertyName("post code")]
    public string PostCode { get; set; } = string.Empty;

    [JsonPropertyName("places")]
    public List<Place> Places { get; set; } = new List<Place>();
    
    [JsonPropertyName("country abbreviation")]
    public string CountryAbbreviation { get; set; } = string.Empty;
    
    public string State { get; set; } = string.Empty;
}