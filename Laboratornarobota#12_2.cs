using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_12_2
{
    public delegate void StatusChange(string status);
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public override string ToString()
        {
            return $"OrderID: {OrderID}, CustomerName: {CustomerName}, OrderDate: {OrderDate}, TotalAmount: {TotalAmount}";
        }
    }
    class OrderProcessor
    {
        public List<Order> Orders { get; set; }
        public OrderProcessor()
        {
            Orders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public IEnumerable<Order> GetOrdersByCustomer(string customerName)
        {
            return Orders.Where(o => o.CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase));
        }
        public decimal GetTotalSales()
        {
            return Orders.Sum(o => o.TotalAmount);
        }
    }
    class NotificationService
    {
        public void SendNotification(string customerName, string message)
        {
            Console.WriteLine($"Notification sent to {customerName}: {message}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Order order=new Order {
              OrderID = 1, 
              CustomerName = "Alice", 
              OrderDate = DateTime.Now, 
              TotalAmount = 250.75m
          };
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.AddOrder(order);
            var aliceOrders = orderProcessor.GetOrdersByCustomer("Alice");
            foreach (var ord in aliceOrders)
            {
                Console.WriteLine(ord);
            }
        }
    }
}
