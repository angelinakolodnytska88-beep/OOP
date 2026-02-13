using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рік:");
            int year = int.Parse(Console.ReadLine());
            if((year%4==0 && year%100!=0) || (year%400==0))
                            {
                Console.WriteLine($"{year} є високосним роком.");
            }
            else
            {
                Console.WriteLine($"{year} не є високосним роком.");
            }
        }
    }
}
