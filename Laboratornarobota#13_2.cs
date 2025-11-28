using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_13_2
{
    class Order
    {
        public string Customer { get; set; }
        public string Orderdish { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> orderQueue = new Queue<Order>();
            orderQueue.Enqueue(new Order { Customer = "Аліна", Orderdish = "Борщ" });
            orderQueue.Enqueue(new Order { Customer = "Віталік", Orderdish = "Паста з креветками" });
            orderQueue.Enqueue(new Order { Customer = "Богдан", Orderdish = "Деруни" });
            Order order1 = orderQueue.Peek();
            Console.WriteLine("Перше замовлення:");
            Console.WriteLine(order1.Customer + " - " + order1.Orderdish);
            Console.WriteLine("Інші замовлення:");
            while (orderQueue.Count > 0)
            {
                Order currentOrder = orderQueue.Dequeue();
                Console.WriteLine(currentOrder.Customer + " - " + currentOrder.Orderdish);
            }

            Console.ReadLine();
        }
    }
}
