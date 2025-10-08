using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            for (i = 2; i <= 50; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Сума простих чисел від 1 до 50: " + sum);

        }
        }
    }

