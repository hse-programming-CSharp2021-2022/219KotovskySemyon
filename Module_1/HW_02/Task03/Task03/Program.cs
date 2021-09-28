using System;

    namespace Task03
{
    class Program
    {
        public static void root(double a, double b, double c)
        {
            double x1 = 0, x2 = 0;
            double discr = Math.Pow(b, 2) - 4 * a * c;
            switch (discr)
            {
                case < 0:
                    Console.WriteLine("No roots");
                    break;
                case 0:
                    x1 = -b / (2 * a);
                    x2 = x1;
                    break;
                default:
                    x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discr)) / (2 * a);
                    Console.WriteLine($"x1 = {x1}; x2 = {x2}");
                    break;
            }    
        }
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Console.WriteLine(-c / b);
                    break;
                default:
                    root(a, b, c);
                    break;
            }

        }
    }
}

    
