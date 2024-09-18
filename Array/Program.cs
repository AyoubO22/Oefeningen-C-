namespace Array
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;

            // Probeer een waarde toe te voegen aan een vijfde element
            numbers = AddElement(numbers, 5);

            // Voeg nog enkele extra elementen toe om de array te testen
            numbers = AddElement(numbers, 6);
            numbers = AddElement(numbers, 7);
            numbers = AddElement(numbers, 8);

            // Print de array om te controleren of de elementen correct zijn toegevoegd
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static int[] AddElement(int[] array, int element)
        {
            // Maak een nieuwe array met een grotere grootte
            int[] newArray = new int[array.Length + 1];

            // Kopieer de oude elementen naar de nieuwe array
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            // Voeg het nieuwe element toe
            newArray[array.Length] = element;

            return newArray;
        }
    }
}