using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть ваш річний дохід (грн): ");
        double income = Convert.ToDouble(Console.ReadLine());
        double taxRate;
        double taxAmount;

        if (income <= 100000)
        {
            taxRate = 0.10; // 10%
        }
        else if (income <= 300000)
        {
            taxRate = 0.15; // 15%
        }
        else if (income <= 1000000)
        {
            taxRate = 0.20; // 20%
        }
        else
        {
            taxRate = 0.25; // 25%
        }
        taxAmount = income * taxRate;

        Console.WriteLine($"Ваш дохід: {income} грн");
        Console.WriteLine($"Ставка податку: {taxRate * 100}%");
        Console.WriteLine($"Сума податку: {taxAmount} грн");
    }
}
