using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть введіть довжину прямокутника: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть ширину прямокутника: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            Console.WriteLine($"Площа прямокутника: {area}");
        }
    }
}
