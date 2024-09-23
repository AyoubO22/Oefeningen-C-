﻿namespace Stapel
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

            // Probeer een waarde toe te voegen aan een vijfde element
            numbers.Add(5);

            // Voeg nog enkele extra elementen toe om de array te testen
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);

            // Print de array om te controleren of de elementen correct zijn toegevoegd
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Verwijder het laatste element
            numbers.RemoveAt(numbers.Count - 1);


            // Print de array om te controleren of het laatste element correct is verwijderd

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}