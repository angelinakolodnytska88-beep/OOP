using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter small letters: ");
            string input = Console.ReadLine();
            Console.WriteLine(CountGolosniy(input));
            Console.WriteLine(CountPrigolosniy(input));

        }
        static string CountGolosniy(string str)
        {
            char[] golosniy = { 'a', 'e', 'i', 'o', 'u', 'y' };
            int count = 0;
            foreach (char c in str)
            {
                if (golosniy.Contains(c))
                {
                    count++;
                }
            }
            return $"Кількість голосних літер: {count}";

        }

        static string CountPrigolosniy(string str)
        {
            char[] prigolosniy = {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l',
                           'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            int count = 0;
            foreach (char c in str)
            {
                if (prigolosniy.Contains(c))
                {
                    count++;
                }
            }
            return $"Кількість приголосних літер: {count}";
        }
    }
}
