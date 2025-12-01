using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Representerar en specifik plats (stad, stat, latitud och longitud)
/// i svaret från Zippopotam.us API:et.
/// </summary>
public class Place
{
    [JsonPropertyName("place name")]
    public string City { get; set; } = string.Empty;

    [JsonPropertyName("state abbreviation")]
    public string StateAbbreviation { get; set; } = string.Empty;
    
    // KORRIGERING: Postnumret finns i Place-objektet vid denna typ av sökning.
    [JsonPropertyName("post code")]
    public string PostCode { get; set; } = string.Empty; 

    [JsonPropertyName("latitude")]
    public string Latitude { get; set; } = string.Empty;

    [JsonPropertyName("longitude")]
    public string Longitude { get; set; } = string.Empty;
}

/// <summary>
/// Representerar hela det övergripande svaret från Zippopotam.us API:et.
/// </summary>
public class LocationData
{
    // Vi behåller detta fält, även om det kan vara tomt vid sökning på stad.
    [JsonPropertyName("post code")]
    public string PostCode { get; set; } = string.Empty;

    [JsonPropertyName("places")]
    public List<Place> Places { get; set; } = new List<Place>();
}