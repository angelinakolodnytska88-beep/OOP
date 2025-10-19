using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_5_4
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть фігуру (Kolo, Pryamokutnyk, Kuba, Tsylindr):");
            string figure = Console.ReadLine();

            Console.WriteLine("Оберіть операцію (Ploshcha, Obyem):");
            string op = Console.ReadLine();

            double result = 0;

            switch (figure)
            {
                case "Kolo":
                    Console.WriteLine("Введіть радіус:");
                    double r = double.Parse(Console.ReadLine());
                    if (op == "Ploshcha")
                        result = PloshchaKola(r);
                    else
                        Console.WriteLine("Коло не має об’єму!");
                    break;

                case "Pryamokutnyk":
                    Console.WriteLine("Введіть довжину:");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть ширину:");
                    double b = double.Parse(Console.ReadLine());
                    if (op == "Ploshcha")
                        result = PloshchaPryamokutnyka(a, b);
                    else
                        Console.WriteLine("Прямокутник — це площинна фігура, об’єм не обчислюється!");
                    break;

                case "Kuba":
                    Console.WriteLine("Введіть довжину ребра:");
                    double x = double.Parse(Console.ReadLine());
                    if (op == "Ploshcha")
                        result = PloshchaKuba(x);
                    else if (op == "Obyem")
                        result = ObyemKuba(x);
                    break;

                case "Tsylindr":
                    Console.WriteLine("Введіть радіус основи:");
                    double r1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть висоту:");
                    double h1 = double.Parse(Console.ReadLine());
                    if (op == "Ploshcha")
                        result = PloshchaTsylindra(r1, h1);
                    else if (op == "Obyem")
                        result = ObyemTsylindra(r1, h1);
                    break;

                default:
                    Console.WriteLine("Невідома фігура.");
                    return;
            }

            Console.WriteLine($"\nРезультат ({op} фігури {figure}) = {result:F2}");
        }
        static double PloshchaKola(double r)
        {
            return Math.PI * r * r;
        }

        static double PloshchaPryamokutnyka(double a, double b)
        {
            return a * b;
        }

        static double PloshchaKuba(double a)
        {
            return 6 * a * a;
        }
        static double ObyemKuba(double a)
        {
            return Math.Pow(a, 3);
        }
        static double PloshchaTsylindra(double r, double h)
        {
            return 2 * Math.PI * r * (r + h);
        }
        static double ObyemTsylindra(double r, double h)
        {
        return Math.PI * r * r * h;
        }       
        }
    }

