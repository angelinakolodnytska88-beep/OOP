using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 5, 6, 8 };
            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
                sum += myArray[i];
            }
            double average = (double)sum / myArray.Length;
            Console.WriteLine("Середнє значення: " + average);

            Console.ReadKey();
        }
    }
}
