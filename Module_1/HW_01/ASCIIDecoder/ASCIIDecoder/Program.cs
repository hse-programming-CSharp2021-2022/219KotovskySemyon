using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int numchar;
            bool f1 = int.TryParse(a, out numchar);
            Console.WriteLine((char)numchar);
        }
    }
}
