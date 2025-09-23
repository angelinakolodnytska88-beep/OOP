using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введіть третє число: ");
            int c = int.Parse(Console.ReadLine());

            int maximum = Math.Max(a, Math.Max(b, c));
            int minimum = Math.Min(a, Math.Min(b, c));

            Console.WriteLine($"Максимум = {maximum}");
            Console.WriteLine($"Мінімум = {minimum}");
        }
    }
}
