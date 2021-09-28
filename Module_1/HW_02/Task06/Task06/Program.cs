using System;

namespace Task06
{
    class Program
    {
        public static decimal BudgetCount(decimal budget, int percent)
        {
            decimal answer = (budget * percent / 100);
            return answer;
        }
        static void Main(string[] args) 
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:C2}", BudgetCount(budget, percent));

        }
    }
}
