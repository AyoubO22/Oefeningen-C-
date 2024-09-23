namespace Stapel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            
            Console.WriteLine("Eerste array:");

            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }

            // Probeer een waarde toe te voegen aan een vijfde element
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            
            Console.WriteLine("Tweede array:");

            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }
            

            // Verwijder het laatste element
            numbers.RemoveAt(numbers.Count - 1);


            // Print de array om te controleren of het laatste element correct is verwijderd

            Console.WriteLine("Derde array:");
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}