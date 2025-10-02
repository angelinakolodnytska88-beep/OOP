using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 0)
            {
                Console.WriteLine("Число є нулем");
            }
            else if (num1 < 0)
            { 
                Console.WriteLine("Число є від'ємним");
            }
           else 
                {
                Console.WriteLine("Число є додатнім");
            }
        }
    }
}
