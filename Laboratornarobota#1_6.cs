using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = (number%2==0)? "Число парне" : "Число непарне";
            Console.WriteLine($"Число { number} є {result}");
        }
    }
}
