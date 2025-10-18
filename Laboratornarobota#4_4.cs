using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] Array = { -1, 2, 3, -4, 5, 6, 7, 8, 9, -10 };
            Console.WriteLine("Array elements: " + string.Join(", ", Array));
            int positiveSum = 0;
            foreach (int number in Array)
            {
                if (number > 0)
                {
                    positiveSum += number;
                }
            }
            Console.WriteLine("Sum of positive elements: " + positiveSum);
            Console.ReadLine();


        }
    }
}
