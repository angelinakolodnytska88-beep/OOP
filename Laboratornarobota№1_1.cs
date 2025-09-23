using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число (день):");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть друге число (місяць):");
            int num2=int.Parse(Console.ReadLine());

            int[] daysInMoth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            bool validDay = num1 > 0 && num1 <= 31;
            bool validMonth = num2 > 0 && num2 <= 12;

            Console.WriteLine(validDay && validMonth && num1 <= daysInMoth[num2] ? "Ці числа можуть бути днем та місяцем" : "Ці числа не можуть бути днем та місяцем");
            Console.ReadKey();

        }
    }
}
