using System;

namespace Task3
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
                if (str[j][0] == 97 || str[j][0] == 101 || str[j][0] == 105 || str[j][0] == 111 || str[j][0] == 117 || str[j][0] == 121)
                {
                    Console.WriteLine(str[j]);
                }
            }
        }
    }
}
