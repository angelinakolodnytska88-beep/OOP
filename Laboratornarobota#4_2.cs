using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Array elements:");
            bool isPalindrome = true;
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
                if (Array[i] != Array[Array.Length - 1 - i])
                {
                    isPalindrome = false;
                }
             }
            Console.WriteLine();
            if (isPalindrome)
                Console.WriteLine("Результат: Масив Є паліндромом");
            else
                Console.WriteLine("Результат: Масив НЕ є паліндромом");
        }

    }
}
