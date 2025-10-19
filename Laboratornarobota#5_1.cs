using System;

namespace Laboratornarobota_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Оберіть операцію (+, -, *, /):");
            string op = Console.ReadLine();

            double result = 0;

            switch (op)
            {
                case "+":
                    result = Dodavannya((int)num1, (int)num2);
                    break;
                case "-":
                    result = Vidnimannya((int)num1, (int)num2);
                    break;
                case "*":
                    result = Mnozhennya((int)num1, (int)num2);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = Dilenya((int)num1, (int)num2);
                    }
                    else
                    {
                        Console.WriteLine("Помилка: ділення на нуль неможливе.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Невідома операція.");
                    return;
            }

            Console.WriteLine($"Результат {num1} {op} {num2} = {result}");
        }

        static int Dodavannya(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Vidnimannya(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Mnozhennya(int num1, int num2)
        {
            return num1 * num2;
        }

        static double Dilenya(int num1, int num2)
        {
            return (double)num1 / num2;
        }
    }
}



