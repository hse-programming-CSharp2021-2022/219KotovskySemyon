using System;

namespace HW_04
{
    class Program
    {
        static bool Shift(ref char ch)
        {
            if(ch >= 97 && ch <= 118)
            {
                int num = Convert.ToInt32(ch);
                num += 4;
                char ans = Convert.ToChar(num);
                Console.WriteLine(ans);
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            bool flag = char.TryParse(Console.ReadLine(), out char b);
            if (flag)
            {
                Shift(ref b);
            }
            else
            {
                Console.WriteLine("Неверные данные");
            }
        }


    }
}
