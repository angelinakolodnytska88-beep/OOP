using System;

namespace Laboratornarobota_7_1_
{
    abstract class Figure
    {
        public abstract string GetName();
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    class Circle : Figure
    {
        double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override string GetName()
        {
            return "Коло";
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Square : Figure
    {
        double width;
        double height;

        public Square(double w, double h)
        {
            width = w;
            height = h;
        }

        public override string GetName()
        {
            return "Прямокутник";
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (width + height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figure circle = new Circle(5);
            Figure square = new Square(4, 6);

            Console.WriteLine($"{circle.GetName()}: Площа = {circle.CalculateArea()}, Периметр= {circle.CalculatePerimeter()}");
            Console.WriteLine($"{square.GetName()}: Площа = {square.CalculateArea()}, Периметр = {square.CalculatePerimeter()}");
        }
    }
}
