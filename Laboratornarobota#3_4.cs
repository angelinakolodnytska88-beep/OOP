using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            int i=number;
            do
            {
                factorial = factorial * i;
                --i;
            }
            while (i > 1);

            Console.WriteLine($"{number}! = {factorial}");

            Console.ReadLine();
        }
    }
}
