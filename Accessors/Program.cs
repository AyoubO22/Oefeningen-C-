namespace Accessors;

class Accessors
{
    public string Getal
    {
        get => getal;
        set => getal = string.IsNullOrEmpty(value) || !int.TryParse(value, out _) ? new string(value.Where(c => char.IsDigit(c) || c == '-').ToArray()) : value;
    }
    private string getal = "0";
}

class Program
{
    static void Main()
    {
        Accessors testje = new Accessors();
        testje.Getal = "a-53en nog 2iets5";
        Console.WriteLine(testje.Getal);  
    }
}