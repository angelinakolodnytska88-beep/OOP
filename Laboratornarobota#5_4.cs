using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_5_4
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
            int min = MinNumber(Array);
            int max = MaxNumber(Array);
            Console.WriteLine("Мінімальне число: " + min);
            Console.WriteLine("Максимальне число: " + max);
        }

        static int MinNumber(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int MaxNumber(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
