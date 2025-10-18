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

            int[] Array = { -5, -3, 7, 3, -9, -3, 1 };
            Console.Write("Масив: ");

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i]);
                if (i < Array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
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
