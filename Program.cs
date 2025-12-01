using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System;


// ---------------------------------------------------
// START: Gemensam instans för båda uppgifterna
// ---------------------------------------------------
using HttpClient client = new();
// GitHub kräver en User-Agent header!
client.DefaultRequestHeaders.Add("User-Agent", "C# Console App - WebAPI_Lab4");
// ---------------------------------------------------
// SLUT: Gemensam instans
// ---------------------------------------------------


// ===================================================
// START: G-NIVÅ (GitHub)
// ===================================================

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("G-NIVÅ: Hämta .NET Foundation Repositories från GitHub");
Console.WriteLine("--------------------------------------------------");

string gitHubUrl = "https://api.github.com/orgs/dotnet/repos";

try
{
    string jsonResponse = await client.GetStringAsync(gitHubUrl);

    List<GitHubRepo>? repos = JsonSerializer.Deserialize<List<GitHubRepo>>(jsonResponse, new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true 
    });

    if (repos != null && repos.Any())
    {
        Console.WriteLine($"Hittade {repos.Count} repositories. Visar de 5 med flest 'watchers':\n");

        foreach (var repo in repos.OrderByDescending(r => r.Watchers).Take(5)) 
        {
            Console.WriteLine($"Repo Namn: {repo.Name}");
            Console.WriteLine($"Beskrivning: {repo.Description ?? "Ingen beskrivning tillgänglig"}");
            Console.WriteLine($"URL: {repo.HtmlUrl}");
            Console.WriteLine($"Hemsida: {repo.Homepage ?? "N/A"}");
            Console.WriteLine($"Watchers: {repo.Watchers}");
            Console.WriteLine($"Senast uppdaterad: {repo.PushedAt:yyyy-MM-dd HH:mm}");
            Console.WriteLine(new string('-', 30));
        }
    }
    else
    {
        Console.WriteLine("Deserialisering misslyckades eller inga repos hittades.");
    }
}
catch (HttpRequestException e)
{
    Console.WriteLine($"\nFel vid hämtning av GitHub data! Meddelande: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Ett oväntat fel inträffade under GitHub-anropet: {e.Message}");
}

// ===================================================
// START: VG-NIVÅ (Zippopotam.us)
// ===================================================

Console.WriteLine("\n" + new string('=', 50));
Console.WriteLine("VG UPPSALA - ZIPPOPOTAM.US");
Console.WriteLine("Hämtar data för Montvale, New Jersey");
Console.WriteLine(new string('=', 50));

string zipUrl = "https://api.zippopotam.us/us/nj/montvale";

try
{
    string zipJsonResponse = await client.GetStringAsync(zipUrl);

    LocationData? location = JsonSerializer.Deserialize<LocationData>(zipJsonResponse, new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

    if (location != null && location.Places.Any())
    {
        // KORRIGERING: Hämta postnumret från det första Place-objektet (inte det yttre location-objektet)
        var place = location.Places.First();
        
        Console.WriteLine($"Postnummer: {place.PostCode}"); 
        Console.WriteLine(new string('-', 40));

        Console.WriteLine($"Stad/Stat: {place.City}, {place.StateAbbreviation}");
        Console.WriteLine($"Latitud: {place.Latitude}");
        Console.WriteLine($"Longitud: {place.Longitude}");
        Console.WriteLine(new string('=', 50));
    }
    else
    {
        Console.WriteLine("Kunde inte hämta eller tolka data för Montvale, NJ.");
    }
}
catch (HttpRequestException e)
{
    Console.WriteLine($"\nFel vid hämtning av Zippopotam data! Meddelande: {e.Message}");
}
catch (Exception e)
{
     Console.WriteLine($"Ett oväntat fel inträffade under Zippopotam-anropet: {e.Message}");
}