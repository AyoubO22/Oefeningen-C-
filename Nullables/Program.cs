namespace Nullables;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Geef de naam van de werknemer:");
        string naam = Console.ReadLine();

        Console.WriteLine("Hoeveel jaar heeft de werknemer in de afdeling Verkoop gewerkt?");
        int? jarenVerkoop = GetNullableInt(Console.ReadLine());

        Console.WriteLine("Hoeveel jaar heeft de werknemer in de afdeling Ondersteuning gewerkt?");
        int? jarenOndersteuning = GetNullableInt(Console.ReadLine());

        Console.WriteLine("Hoeveel jaar heeft de werknemer in de afdeling Administratie gewerkt?");
        int? jarenAdministratie = GetNullableInt(Console.ReadLine());

        int afdelingenGewerkt = CountAfdelingen(jarenVerkoop, jarenOndersteuning, jarenAdministratie);
        int totaleDienstjaren = (jarenVerkoop ?? 0) + (jarenOndersteuning ?? 0) + (jarenAdministratie ?? 0);
        double bonusPercentage = (afdelingenGewerkt >= 2) ? totaleDienstjaren * 2 : 0;

        Console.WriteLine($"Werknemer {naam} heeft {totaleDienstjaren} jaar gewerkt en zijn bonuspercentage is {bonusPercentage}%.");
    }

    static int? GetNullableInt(string input) => string.IsNullOrEmpty(input) ? (int?)null : int.Parse(input);

    static int CountAfdelingen(params int?[] jaren) => jaren.Count(j => j.HasValue && j.Value > 0);
}