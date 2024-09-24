namespace Generics;

public class Persoon
{
    public string Naam { get; set; }
    public int Leeftijd { get; set; }

    public Persoon(string naam, int leeftijd)
    {
        Naam = naam;
        Leeftijd = leeftijd;
    }

    public override string ToString()
    {
        return $"Naam: {Naam}, Leeftijd: {Leeftijd}";
    }
}