using System;

namespace Task02
{
    class Program
    {
        public static string maxDigits(int number)
        {
            int num1;
            int num2;
            int num3;
            int maximum = 0;
            int avg;
            int min = 0;
            int summ = 0;
            num3 = number % 10;
            number /= 10;
            num2 = number % 10;
            number /= 10;
            num1 = number % 10;
            summ += (num1 + num2 + num3);
            if ((num1 >= num2) && (num1 >= num3))
            {
                maximum = num1;
            }
            if ((num2 >= num1) && (num2 >= num3))
            {
                maximum = num2; 
            }
            if ((num3 >= num2) && (num3 >= num1))
            {
                maximum = num3;
            }

            if ((num1 <= num2) && (num1 <= num3))
            {
                min = num1;
            }
            if ((num2 <= num1) && (num2 <= num3))
            {
                min = num2;
            }
            if ((num3 <= num2) && (num3 <= num1))
            {
                min = num3;
            }
            avg = summ - (maximum + min);
            return (maximum.ToString() + avg.ToString() + min.ToString());
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int number = Convert.ToInt32(a);
            Console.WriteLine(maxDigits(number));
        }

    }
}