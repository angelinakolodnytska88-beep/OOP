using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 5, 3, 7, -3, 9, -3, 1 };
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
            int negativedob = 1;
            foreach (int number in Array)
            {
                if (number < 0)
                {
                    negativedob *= number;
                }
            }
            Console.WriteLine("Dobutok of negative elements: " + negativedob);
            Console.ReadLine();

        }
    }
}
