using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть букву англійського алфавіту:");
            char c = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            switch (c)
            {
                case 'A':
                    Console.WriteLine("Це голосна буква.");
                    break;
                case 'E':
                   Console.WriteLine("Це голосна буква.");
                   break;
                case 'I':
                    Console.WriteLine("Це голосна буква.");
                    break;
                case 'O':
                Console.WriteLine("Це голосна буква.");
                    break;
                case 'U':
                Console.WriteLine("Це голосна буква.");
                    break;
                default:
                    Console.WriteLine("Це приголосна буква.");
                    break;

            }
        }
    }
}
