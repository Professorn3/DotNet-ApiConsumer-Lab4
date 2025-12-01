Personlig Reflektion: WebAPI-uppgiften

Den här laborationen handlade om att lära sig hur våra program kan hämta och använda information från internettjänster. Vi arbetade med två olika webb-API:er: GitHub, som gav oss kodprojektdata, och Zippopotam.us, som gav oss geografisk information.

Vad jag har lärt mig:

    Att vara snabb: Jag fick träna på att använda async och await med HttpClient. Detta betyder att programmet kan skicka ut en förfrågan till nätet och sedan fortsätta göra annat medan det väntar på svaret, vilket gör programmet effektivare.

    Dataklasser: Vi behövde bygga egna mallar (GitHubRepo, LocationData) för att passa den data vi fick från API:erna. Genom att använda [JsonPropertyName] kunde jag "översätta" namnen från API:ets format till de namn jag ville använda i C#. Det var ett viktigt steg för att få datan att fungera i koden.

    API-regler: Jag lärde mig att varje API har egna regler. Till exempel krävde GitHub att jag skickade med en speciell (User-Agent) för att ens få hämta datan. Det visar att man alltid måste läsa dokumentationen.

    Ordning och reda: Den största utmaningen var att dela upp koden i olika filer. Detta ledde till fel när klasser definierades dubbelt. Det var en bra påminnelse om hur viktigt det är att ha en ren och logisk filstruktur i stora projekt.

Sammanfattningsvis känner jag att jag nu har en stabil grund i hur man integrerar och hanterar riktig data från webben, vilket är en grundläggande färdighet.

Den här SQL-kursen har verkligen överträffat mina förväntningar. Jag vill verkligen lyfta fram hur otroligt intressant det har blivit att använda SQL och lära mig grunderna i databashantering. Det som tidigare kändes som en ren teknisk skyldighet har nu blivit ett av de mest lärorika områdena jag har stött på. Jag har fått en djupare förståelse för hur man effektivt hanterar och strukturerar data.

En del som jag tyckte var särskilt engagerande var att lära mig om optimering av sökfrågor. Det var fascinerande att se hur man kan formulera frågor som inte bara ger rätt svar, utan som också är supersnabba genom att använda index och analysera exekveringsplaner. Dessutom tyckte jag att avsnitten om databasdesign och normalisering var mycket givande. Att förstå hur man bygger en databas från grunden för att säkerställa dataintegritet och undvika onödig upprepning av information (redundans) känns som en helt avgörande färdighet.

Det mest betydelsefulla är hur jag direkt har kunnat tillämpa dessa kunskaper i praktiken. Jag har faktiskt använt det jag lärt mig för att skapa en databas för min egen personliga e-handel som jag driver. Dessutom har jag kunnat använda SQL i flera andra projekt jag jobbar med på min hemmaserver. Kursen har på så sätt inte bara gett mig teori, utan också verktygen att verkligen genomföra egna tekniska lösningar.
