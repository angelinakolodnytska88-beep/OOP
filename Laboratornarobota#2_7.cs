using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Число парне");
            }
            else
            {
                Console.WriteLine("Число непарне");
            }
             if (number % 3 == 0)
            {
                Console.WriteLine("Число кратне трьом");
            }
             else
            {
                Console.WriteLine("Число не кратне трьом");
            }
        }
    }
}
