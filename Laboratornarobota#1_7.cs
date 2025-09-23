using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть температуру в градусах Цельсія: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        }
    }
}
