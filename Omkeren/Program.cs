namespace Oefening_1
{
    // static werd aangeraden door rider
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een string in:");

            // Rider heeft dit aangeraden, omdat het readline null kan zijn 
            string input = Console.ReadLine() ?? throw new InvalidOperationException("Input mag niet null zijn.");

            Console.WriteLine("Kies een methode om de string om te keren:");
            Console.WriteLine("1. For-loop");
            Console.WriteLine("2. While-loop");
            Console.WriteLine("3. Do-while-loop");
            Console.WriteLine("4. Recursie");
            Console.Write("Uw keuze: ");

            // Rider heeft dit aangeraden, omdat het readline null kan zijn 
            int keuze = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Keuze mag niet null zijn."));

            string omgekeerd;

            // Een switch statement om basis van user 
            switch (keuze)
            {
                case 1:
                    omgekeerd = OmkerenMetForLoop(input);
                    break;
                case 2:
                    omgekeerd = OmkerenMetWhileLoop(input);
                    break;
                case 3:
                    omgekeerd = OmkerenMetDoWhileLoop(input);
                    break;
                case 4:
                    omgekeerd = OmkerenMetRecursie(input);
                    break;
                default:
                    
                    Console.WriteLine("Ongeldige keuze.");
                    return;
            }

            // Het resultaat van de gekozen omkeer-methode wordt weergegeven.
            Console.WriteLine($"Omgekeerde string: {omgekeerd}");
        }

        // Methode om een string om te keren met een for-loop.
        static string OmkerenMetForLoop(string input)
        {
            char[] omgekeerd = new char[input.Length];
            for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
            {
                omgekeerd[i] = input[j];
            }
            return new string(omgekeerd);
        }

        // Methode om een string om te keren met een while-loop.
        static string OmkerenMetWhileLoop(string input)
        {
            char[] omgekeerd = new char[input.Length];
            int i = 0, j = input.Length - 1;
            while (i < input.Length)
            {
                omgekeerd[i] = input[j];
                i++;
                j--;
            }
            return new string(omgekeerd);
        }

        // Methode om een string om te keren met een do-while-loop.
        static string OmkerenMetDoWhileLoop(string input)
        {
            char[] omgekeerd = new char[input.Length];
            int i = 0, j = input.Length - 1;
            do
            {
                omgekeerd[i] = input[j];
                i++;
                j--;
            } while (i < input.Length);
            return new string(omgekeerd);
        }

        // Methode om een string om te keren met recursie.
        static string OmkerenMetRecursie(string input)
        {
            if (input.Length <= 1)
                return input;
            // Het laatste karakter wordt toegevoegd, gevolgd door een recursieve oproep, en dan het eerste karakter.
            return input.Last() + OmkerenMetRecursie(input.Substring(1, input.Length - 2)) + input.First();
        }
    }
}