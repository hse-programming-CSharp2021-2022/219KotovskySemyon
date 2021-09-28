using System;

namespace Task07
{
    class Program
    {
        public static void NumPart1(double a) 
        {
            int b = Convert.ToInt32(a);
            double part = a - b;
            Console.WriteLine($"Целое: {b}");
            Console.WriteLine($"Дробная: {part}");
        }
        public static void NumPart2(double a)
        {
            double pow = Math.Pow(a, 2);
            double sqrt = Math.Sqrt(a);
            Console.WriteLine($"Квадрат: {pow}");
            if (a > 0)
            {
                Console.WriteLine($"Квадрат: {sqrt}");
            }
            else
            {
                Console.WriteLine($"Невозможно вычислить корень из отрицательного числа");
            }
            
        }
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            double a;
            bool f = double.TryParse(b, out a);
            if (f)
            {
                NumPart1(a);
                NumPart2(a);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }

        }
    }
}
