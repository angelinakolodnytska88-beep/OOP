using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Який ваш вік?:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 13 && age <=18)
            {
                Console.WriteLine("Ви підліток.");
            }
            else
            {
                Console.WriteLine("Ви не підліток.");
            }
        }
    }
}
