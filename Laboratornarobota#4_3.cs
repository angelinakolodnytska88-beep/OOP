using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_4_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Array elements:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
            bool foundEven = false;
            Console.Write("Парні елементи: ");
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    if (foundEven)
                        Console.Write(", ");
                    Console.Write(Array[i]);
                    foundEven = true;
                }
            }
            if (!foundEven)
                Console.Write("відсутні");
            Console.WriteLine();
        }
    }
}
