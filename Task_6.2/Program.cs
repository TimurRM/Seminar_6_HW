// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        string Point(double b1, double k1, double b2, double k2)
        {
            string result = string.Empty;
            double x = 0d;
            double y = 0d;
            x = (b2 - b1) / (k1 - k2);
            y = k1 * (b2 - b1) / (k1 - k2) + b1;
            result = $"({x}, {y})";
            return result;
        }
        Console.Write("Input b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        if (k1 == k2 & b1 == b2) 
        {
            Console.WriteLine($"k1 = k2 = {k1}, b1 = b2 = {b1}-> On one line)"); 
        }
        else if (k1 == k2 & b1 != b2) 
        {
            Console.WriteLine($"k1 = k2 = {k1}, b1 = {b1}, b2 = {b2} ->  Parallel");
        }
        else 
        {
            Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {Point(b1, k1, b2, k2)}");    
        }
        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    }
}