using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 1;
            int fib0=0, fib1=1, fibNext=0;
            for (int i = 0; i < number; i++)
            {
                if (i <= 1)
                    fibNext = i;
                   
                else
                {
                    fibNext = fib0 + fib1;
                    fib0 = fib1;
                    fib1 = fibNext;
                    count ++;
                }
                sum += fibNext;
            }
            Console.WriteLine("Сума цифр Фібоначчі: " + sum);
            Console.WriteLine("Кількість елементів: " + count);

        }
    }
}
