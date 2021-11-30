using System;

namespace Task04
{
    class Shape
    {
        public const double PI = Math.PI;
        protected double xdata, ydata;
        public Shape()
        {
        }
        public Shape(double x, double y)
        {
            xdata = x;
            ydata = y;
        }
        public virtual double Area()
        {
            return xdata * ydata;
        }
    }
    class Circle : Shape
    {
        public Circle(double r)
        {
            xdata = r;
        }
        public override double Area()
        {
            return PI * this.xdata * this.xdata;
        }
        public override string ToString()
        {
            return $"Информация о фигуре: {this.Area()}";
        }
    }
    class Cylinder : Shape
    {
        public Cylinder(double r, double h)
        {
            xdata = r;
            ydata = h;
        }
        public override double Area()
        {
            return 2 * PI * this.xdata * this.xdata + 2 * PI * this.xdata * this.ydata;
        }
        public override string ToString()
        {
            return $"Информация о фигуре: {this.Area()}";
        }
    }
    class Sphere : Shape
    {
        public Sphere(double r)
        {
            xdata = r;
        }
        public override double Area()
        {
            return 4 * PI * this.xdata * this.xdata;
        }
        public override string ToString()
        {
            return $"Информация о фигуре: {this.Area()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n1 = random.Next(3, 6);
            int n2 = random.Next(3, 6);
            int n3 = random.Next(3, 6);
            Shape[] shapes = new Shape[n1 + n2 + n3];
            for (int i = 0; i < n1; i++)
            {
                shapes[i] = new Circle(random.Next(5, 15));
            }
            for (int i = n1; i < n1 + n2; i++)
            {
                shapes[i] = new Cylinder(random.Next(5, 15), random.Next(5, 15));
            }
            for (int i = n1 + n2; i < shapes.Length; i++)
            {
                shapes[i] = new Sphere(random.Next(5, 15));
            }
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Фигура {i + 1}, площадь: {shapes[i].Area()}.");
            }
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Shape a)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}