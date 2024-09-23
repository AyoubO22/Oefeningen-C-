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

            
            numbers = AddElement(numbers, 5);

            
            numbers = AddElement(numbers, 6);
            numbers = AddElement(numbers, 7);
            numbers = AddElement(numbers, 8);

            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static int[] AddElement(int[] array, int element)
        {
         
            int[] newArray = new int[array.Length + 1]; 
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            
            newArray[array.Length] = element;

            return newArray;
        }
    }
}