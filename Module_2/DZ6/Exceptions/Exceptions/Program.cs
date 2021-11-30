using System;
using System.IO;
namespace Task1
{
    public class MyException : Exception
    {
        public MyException() : base() { }
        public MyException(string message) : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            int a = 12;
            int b = 0;
            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                int[,] arr2 = new int[7, 345];
                Array.Sort(arr2);
            }
            catch (RankException)
            {
                Console.WriteLine("RankException");
            }

            int[] array = new int[1];
            try
            {
                Console.WriteLine(array[10]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            string test = "test";
            try
            {
                int.Parse(test);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }

            string str;
            try
            {
                str = "test";
                str.IndexOf("a", 100);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ArgumentOutOfRangeException");

            }

            str = null;
            try
            {

                str.Split(" ");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }

            try
            {
                str = null;
                "str".IndexOf(str);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException");
            }

            try
            {
                object num = 1;
                string s = (string)num;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("InvalidCastException");
            }

            try
            {
                Directory.SetCurrentDirectory("hello!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("DirectoryNotFoundException");
            }

            

            try
            {
                Directory.GetLastAccessTime("?");
            }
            catch (IOException)
            {
                Console.WriteLine("IOException");
            }


            try
            {
                throw new MyException("Ха-ха, ты словил exception! Работа зануляется. До свидания.");
            }
            catch (MyException my)
            {
                Console.WriteLine(my.Message);
            }

        }
    }
}