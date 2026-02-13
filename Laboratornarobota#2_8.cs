using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину сторони а:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть довжину сторони b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть довжину сторони c:");
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("Найдовша сторона: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Найдовша сторона: " + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Найдовша сторона: " + c);
            }
            else
            {
                Console.WriteLine("Є дві або три рівні за довжиною сторони");
            }
        }
    }
}
