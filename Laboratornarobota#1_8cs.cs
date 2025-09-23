using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_1_8
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = n * (n + 1) / 2;
            Console.WriteLine($"Сума перших {n} натуральних чисел = {sum}");
        }
    }
}
