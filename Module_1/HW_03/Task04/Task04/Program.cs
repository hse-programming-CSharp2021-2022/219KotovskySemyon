using System;

namespace Task04
{
    class Program
    {
        public static int MinNum(out int b, int dig1, int dig2, int dig3)
        {
            if ((dig1 <= dig2) && (dig1 <= dig3))
            {
                b = 1;
                return dig1;
            }
            if ((dig2 <= dig1) && (dig1 <= dig3))
            {
                b = 2;
                return dig2;
            }
            if ((dig3 <= dig1) && (dig1 <= dig2))
            {
                b = 3;
                return dig3;
            }
            else
            {
                b = 0;
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int b;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int dig1 = num1 % 100;
            int dig2 = num2 % 100;
            int dig3 = num3 % 100;
            MinNum(out b, dig1, dig2, dig3);
            if (b == 1)
            {
                Console.WriteLine(num1);
            }
            if (b == 2)
            {
                Console.WriteLine(num2);
            }
            if (b == 3)
            {
                Console.WriteLine(num3);
            }
        }
    }
}
