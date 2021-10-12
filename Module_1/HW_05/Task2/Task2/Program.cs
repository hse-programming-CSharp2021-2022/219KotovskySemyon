using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] str = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int len1 = str.Length;
            for (int j = 0; j < len1; j++)
            {
                if (str[j].Length >= 4)
                {
                    Console.Write(str[j] + " ");
                }
            }
        }
    }
}
