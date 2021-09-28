using System;

namespace Task04
{
    class Program
    {
        public static string NumDigits(int a)
        {
            int num4 = (a % 10);
            int num3 = ((a / 10) % 10);
            int num2 = ((a / 100) % 10);
            int num1 = ((a / 1000) % 10);
            string answer = (num4.ToString() + num3.ToString() + num2.ToString() + num1.ToString());
            return answer;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(NumDigits(a));
        }
    }
}
