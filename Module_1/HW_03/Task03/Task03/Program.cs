﻿using System;

namespace Task03
{
    class Program
    {
        public static double MathFunc(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI / 2);
            }
            else
            {
                return Math.Sin((Math.PI * (x - 1) / 2));
            }
        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(MathFunc(x));
        }
    }
}
