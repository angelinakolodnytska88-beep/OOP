using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_9
{
    using System;

    namespace Lab6
    {
        public abstract class Shape
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Shape(string name)
            {
                Name = name;
            }

            public abstract double Area();
            public abstract double Perimeter();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(string name, double radius) : base(name)
            {
                Radius = radius;
            }

            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }

            public override double Perimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }

        public class Square : Shape
        {
            public double Side { get; set; }

            public Square(string name, double side) : base(name)
            {
                Side = side;
            }

            public override double Area()
            {
                return Side * Side;
            }

            public override double Perimeter()
            {
                return 4 * Side;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Circle circle1 = new Circle("Коло 1", 3);
                Circle circle2 = new Circle("Коло 2", 5);
                Square square1 = new Square("Квадрат 1", 2);
                Square square2 = new Square("Квадрат 2", 4);

                Console.WriteLine($"{circle1.Name}: Площа = {circle1.Area()}, Периметр = {circle1.Perimeter()}");
                Console.WriteLine($"{circle2.Name}: Площа = {circle2.Area()}, Периметр = {circle2.Perimeter()}");
                Console.WriteLine($"{square1.Name}: Площа = {square1.Area()}, Периметр = {square1.Perimeter()}");
                Console.WriteLine($"{square2.Name}: Площа = {square2.Area()}, Периметр = {square2.Perimeter()}");
                Console.WriteLine();

                double maxCircleArea = Math.Max(circle1.Area(), circle2.Area());
                double maxSquareArea = Math.Max(square1.Area(), square2.Area());

                Console.WriteLine($"Найбільша площа серед кіл: {maxCircleArea}");
                Console.WriteLine($"Найбільша площа серед квадратів: {maxSquareArea}");
            }
        }
    }

}
