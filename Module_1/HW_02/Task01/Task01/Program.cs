using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double x = Convert.ToDouble(a);
            double result = (x * (12 * x * x * x + 9 * x * x - 3 * x + 2) - 4);
            Console.WriteLine(result);
        }
    }
}
