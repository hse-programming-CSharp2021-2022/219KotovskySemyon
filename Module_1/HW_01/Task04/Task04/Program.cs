using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            double U = double.Parse(a);
            double R = double.Parse(b);
            double p = ((U * U) / R);
            double i = (U / R);
            Console.WriteLine("Сила тока: " + i + " Мощность: " + p);
        }
    }
}
