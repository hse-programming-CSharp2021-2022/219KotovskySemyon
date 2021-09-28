using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            double x = double.Parse(a);
            double y = double.Parse(b);
            Console.WriteLine((Math.Sqrt(x * x + y * y)));
        }
    }
}
