using System;

namespace Task05
{
    class Program
    {
        public static bool IsTriangle(double a, double b, double c)
        {
            bool logic = (a + b > c) && (b + c > a) && (c + a > b) ? true : false;
            return logic;
        }  
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(IsTriangle(a, b, c));
        }
    }
}
