using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД= , {GCD(num1, num2)}");
            Console.WriteLine($"НОК=, {LCM(num1, num2)}");
        }
        static double GCD(double num1, double num2)
        {
            if (num2 < 0)
                num2 = Math.Abs(num2);
            if (num1 < 0)
                num1 = Math.Abs(num1);
            while (num2 > 0)
            {
                double temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }
        static double LCM(double num1, double num2)
        {
            return Math.Abs(num1 * num2) / GCD(num1, num2);
        }
    }
}
}
