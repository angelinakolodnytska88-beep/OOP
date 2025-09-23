using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratirna_1_2
{
    internal class Program
    {
        static void Main()
        { 
            Console.Write("Введіть дійсне число: ");
            double number = double.Parse(Console.ReadLine());

            number = Math.Abs(number);
            double fractionalPart = number - Math.Floor(number);

            int twoDigits = (int)(fractionalPart * 100);
            int firstDigit = twoDigits / 10;
            int secondDigit = twoDigits % 10;

        Console.WriteLine($"{firstDigit} + {secondDigit} = {firstDigit + secondDigit}");
        }
    }
}
