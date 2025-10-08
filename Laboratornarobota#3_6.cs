using System;

namespace Laboratornarobota_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("0");
                return;
            }

            string binary = "";
            bool isNegative = false;

            if (num < 0)
            {
                isNegative = true;
                num = Math.Abs(num);
            }

            while (num > 0)
            {
                binary = (num % 2) + binary;
                num /= 2;
            }

            if (isNegative)
            {
                binary = "-" + binary;
            }

            Console.WriteLine("Двійкове представлення: " + binary);
        }
    }
}