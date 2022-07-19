// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

internal class Program
{
    private static void Main(string[] args)
    {
Console.Clear();
Console.WriteLine();        
        int[] CreateRandomArray(int start, int end)
        {
            int[] RandomArray = new int[6];
            for (int i = 0; i < 6; i++)
            {
                RandomArray[i] = new Random().Next(start, end);
            }
            return RandomArray;  
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

        int[] myRandomArray = CreateRandomArray(-5, 20);
        
        int SearchNumbers(int[] array)
        {
            int count = 0;
                for (int i = 0; i < myRandomArray.Length; i++)
                {
                    if(myRandomArray[i] > 0) 
                    count += 1; 
                }
                return count;
        }

        ShowArray(myRandomArray);

        int count = SearchNumbers(myRandomArray);
        Console.WriteLine($" -> {count} (quantity of numbers > 0 in array)");

        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    }
}    