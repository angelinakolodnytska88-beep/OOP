using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_3_3
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Введіть число:");
                    int i = 1;
                    int number = Convert.ToInt32(Console.ReadLine());
            while (i <= 10)
                    {
                        int result = number * i;
                        Console.WriteLine($"{number} × {i} = {result}");
                        i++;
                    }
            Console.ReadLine();
        }
    }
}
