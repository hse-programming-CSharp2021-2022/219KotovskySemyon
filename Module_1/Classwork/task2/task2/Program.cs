using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(553)); 
        }
        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return Factorial(n - 1) * n;
            }
            
        }
    }
}
