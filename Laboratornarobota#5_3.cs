using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть суму:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть валюту (USD, EUR, GBP):");
            string currency = Console.ReadLine();
            double result = ConvertToUAH(num1, currency);
            if (result != 0)
            {
                Console.WriteLine($"{num1} {currency.ToUpper()} = {result} UAH");
            }
        }
        static double ConvertToUAH(double amount, string currency)
        {
            double rate = 0;
            switch (currency.ToUpper())
            {
                case "USD":
                    rate = 41.35;
                    break;
                case "EUR":
                    rate = 48.21;
                    break;
                case "GBP":
                    rate = 55.47;
                    break;
                default:
                    Console.WriteLine("Невідома валюта.");
                    return 0;
            }
            return amount * rate;
        }   
    }
}
