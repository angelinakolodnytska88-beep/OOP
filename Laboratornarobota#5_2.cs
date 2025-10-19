using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            double num1 = double.Parse(Console.ReadLine());
            if (ProsteChisla(num1) == 1)
            { 
            Console.WriteLine("Число є простим");
            }
            else
            {
                Console.WriteLine("Число не є простим");
            }
        }
        
     
    static int ProsteChisla(double num1)
            {
            int count = 0;
            for (int i = 2; i <= num1; i++)
            {
                if (num1 % i == 0)
                {
                    count++;
                }
            }
            return count;
        }

        

    }

}
