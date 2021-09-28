using System;

namespace Task01
{
    class Program
    {
        public static bool IsInCircle(double x, double y)
        {
            if (((x * x + y * y) <= 4) && y <= Math.Sqrt(2) && x >= 0 && x <= 2 && x >= y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(IsInCircle(x, y));
        }
    }
}
