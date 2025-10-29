using System;

namespace CarApp
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public const string CompanyName = "AutoCompany";

        public Car()
        {
            Name = "NoName";
            Color = "NoColor";
            Price = 0;
        }

        public Car(string name, string color, double price)
        {
            Name = name;
            Color = color;
            Price = price;
        }

        public void Input()
        {
            Console.Write("Введіть назву авто: ");
            Name = Console.ReadLine();

            Console.Write("Введіть колір авто: ");
            Color = Console.ReadLine();

            Console.Write("Введіть ціну авто: ");
            Price = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Компанія: " + CompanyName);
            Console.WriteLine("Назва: " + Name);
            Console.WriteLine("Колір: " + Color);
            Console.WriteLine("Ціна: " + Price + " грн");
            Console.WriteLine();
        }

        public void ChangePrice(double x)
        {
            Price = Price - Price * x / 100;
        }

        public string PrintInfo()
        {
            return CompanyName + " " + Name + ", колір: " + Color + ", ціна: " + Price + " грн";
        }

        static void Main()
        {
            Car[] cars = new Car[3];

            Console.WriteLine("Введення даних про 3 авто");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nАвто #" + (i + 1));
                cars[i] = new Car();
                cars[i].Input();
            }

            Console.WriteLine("\nЗменшення ціни на 10%");
            for (int i = 0; i < 3; i++)
            {
                cars[i].ChangePrice(10);
                cars[i].Print();
            }

            Console.Write("\nВведіть новий колір для авто білого кольору: ");
            string newColor = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (cars[i].Color.ToLower() == "білий" || cars[i].Color.ToLower() == "white")
                {
                    cars[i].Color = newColor;
                }
            }

            Console.WriteLine("\nДані про авто після перекрашування");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(cars[i].PrintInfo());
            }
        }
    }
}

