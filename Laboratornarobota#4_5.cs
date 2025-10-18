using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 5, 3, 7, 3, 9, 3, 1 };
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

            int El = 3;
            int index = Array.ToList().IndexOf(El);
            if (index != -1)
            {
                Console.WriteLine($"Елемент {El} знайдено на позиції {index}");
            }
            else
            {
                Console.WriteLine($"Елемент {El} не знайдено в масиві.");
            }
            Console.ReadLine();

        }
    }
}
