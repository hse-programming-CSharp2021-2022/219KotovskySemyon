using System;

namespace Task2
{
    class Program
    {
        private static int Factorial(int value)
        {
            int ans = 1;
            int i = 1;
            if (value == 0)
            {
                return 1;
            }
            else
            {
                while (i <= value)
                {
                    ans *= i;
                    i += 1;
                }
            }
            return ans;
        }
        static double Row1(ref double x)
        {
            int n = 3;
            int m = 4;
            int k = 4;
            double s = (1 - x*x + (Math.Pow(2,n)*Math.Pow(x,4))/ Factorial(k));
            do
            {
                n += 2;
                m += 2;
                k += 2;
                s += ((Math.Pow(2, n) * Math.Pow(x, 4)) / Factorial(k));
            }
            while (s <= (s + ((Math.Pow(2, n) * Math.Pow(x, 4)) / Factorial(k))));
            return s;
        }
        static void Main(string[] args)
        {
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Row1(ref num));
        }
    }
}
