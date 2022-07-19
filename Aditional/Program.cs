// 43. Написать программу преобразования десятичного числа в двоичное

internal class Program
{
    private static void Main(string[] args)
    {
        string a = string.Empty;
        int b = 19;

        for (; b > 0; b /= 2)
            a = b % 2 + a;
        Console.WriteLine(a);
    }
}