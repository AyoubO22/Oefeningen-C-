using System;

class Program
{
    static void Main()
    {
        Stapel<string> mijnStapel = new Stapel<string>();

        // Event handler die een bericht toont wanneer de stapel wijzigt
        mijnStapel.StapelGewijzigd += (actie, item) =>
        {
            if (actie == "Leegmaken")
            {
                Console.WriteLine($"De stapel is geleegd.");
            }
            else
            {
                Console.WriteLine($"Actie: {actie}, Object: {item?.ToString() ?? "N/A"}");
            }
        };

        // Testen van de Stapel en het event
        mijnStapel.Toevoegen("Item 1");
        mijnStapel.Toevoegen("Item 2");
        mijnStapel.Verwijderen();
        mijnStapel.Leegmaken();
    }
}