using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть число 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть число 3:");          
            int c = Convert.ToInt32(Console.ReadLine());
            
            if (a > b && a > c)
            {
                Console.WriteLine("Найбільше число: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Найбільше число: " + b);
            }
            else
            {
                Console.WriteLine("Найбільше число: " + c);
            }       
        }
    }
}
