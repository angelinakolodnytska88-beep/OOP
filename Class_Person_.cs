using System;
namespace PersonApp
{
    class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name
        {
            get { return name; }
        }
        public DateTime BirthYear
        {
            get { return birthYear; }
        }
        public Person()
        {
            name = "NoName";
            birthYear = DateTime.Now;
        }
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }

        public void Input()
        {
            Console.Write("Введіть ім'я: ");
            name = Console.ReadLine();
            Console.Write("Введіть рік народження: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введіть місяць народження (1-12): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Введіть день народження (1-31): ");
            int day = int.Parse(Console.ReadLine());
            birthYear = new DateTime(year, month, day);
        }
        public void ChangeName(string newName)
        {
            name = newName;
        }
        public string ToString()
        {
            return $"Ім'я: {name}, Дата народження: {birthYear.ToShortDateString()}, Вік: {Age()}";
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.name == p2.name;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
        static void Main()
        {
            Person[] people = new Person[6];
            Console.WriteLine("Введіть дані про 6 осіб:\n");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Особа #{i + 1}:");
                people[i] = new Person();
                people[i].Input();
                Console.WriteLine();
            }
            Console.WriteLine("\nІм'я та вік кожної особи");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{people[i].Name} - {people[i].Age()} років");
            }
            for (int i = 0; i < 6; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }
            Console.WriteLine("\nІнформація про всіх людей");
            for (int i = 0; i < 6; i++)
            {
                people[i].Output();
            }
            Console.WriteLine("\nЛюди з однаковими іменами");
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"\nОсоба #{i + 1} та Особа #{j + 1} мають однакові імена:");
                        people[i].Output();
                        people[j].Output();
                    }
                }
            }
        }
    }
}
