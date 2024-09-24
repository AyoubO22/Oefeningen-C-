namespace Generics;

public class TestStapel
{
    public static void Main(string[] args)
    {
        
        Stapel<int> intStapel = new Stapel<int>();
        intStapel.ZetOp(10);
        intStapel.ZetOp(20);
        intStapel.ZetOp(30);
        Console.WriteLine("Integer Stapel:");
        Console.WriteLine(intStapel.ToString());

        
        Stapel<string> stringStapel = new Stapel<string>();
        stringStapel.ZetOp("Eerste");
        stringStapel.ZetOp("Tweede");
        stringStapel.ZetOp("Derde");
        Console.WriteLine("String Stapel:");
        Console.WriteLine(stringStapel.ToString());

        
        Stapel<Persoon> persoonStapel = new Stapel<Persoon>();
        persoonStapel.ZetOp(new Persoon("Jan", 25));
        persoonStapel.ZetOp(new Persoon("Els", 30));
        Console.WriteLine("Persoon Stapel:");
        Console.WriteLine(persoonStapel.ToString());
    }
}