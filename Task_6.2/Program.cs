// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine();

// double[,] coeff = new double[2, 2];
// double[] crossPoint = new double[2];

// void InputCoefficients(){
//   for (int i = 0; i < coeff.GetLength(0); i++)
//   {
//     Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
//     for (int j = 0; j < coeff.GetLength(1); j++)
//     {
//       if(j==0) Console.Write($"Введите коэффициент k: ");
//       else Console.Write($"Введите коэффициент b: ");
//       coeff[i,j] = Convert.ToInt32(Console.ReadLine());
//     }
//   }
// }

// double[] Decision(double[,] coeff)
// {
//   crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
//   crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
//   return crossPoint;
// }

// void OutputResponse(double[,] coeff)
// {
//   if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
//   {
//     Console.WriteLine($"\nПрямые совпадают");
//   }
//   else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
//   {
//     Console.WriteLine($"\nПрямые параллельны");
//   }
//   else 
//   {
//     Decision(coeff);
//     Console.WriteLine($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
//   }
// }
     // InputCoefficients();
        // OutputResponse(coeff);



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
            Console.WriteLine($"k1 = k2 = {k1}, b1 = b2 = {b1}-> Прямые на одной линии)"); 
        }
        else if (k1 == k2 & b1 != b2) 
        {
            Console.WriteLine($"k1 = k2 = {k1}, b1 = {b1}, b2 = {b2} ->  Прямые параллельны");
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