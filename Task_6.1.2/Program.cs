
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write($"Input quantity of numbers in array: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[] ArrayNumbers = new int[m];

        int[] CreateArray(int m)
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Input {i + 1} number: ");
                ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return ArrayNumbers;
        }

        void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
        }

        int[] myArray = CreateArray(m);

        int Compare(int[] arrayNum)
        {
            int count = 0;
            for (int i = 0; i < arrayNum.Length; i++)
            {
                if (arrayNum[i] > 0) count += 1;
            }
            return count;
        }


        ShowArray(myArray);

        int count = Compare(myArray);
        Console.WriteLine($" -> {count} (quantity of numbers > 0 in array)");

        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    }
}