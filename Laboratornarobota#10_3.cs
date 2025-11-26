using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_10_3
{
    internal class Program
    {
        interface IProduct
        {
            void DisplayInfo();
        }
        interface IShoppable
        {
            void AddToCart();
        }
        class ElectronicDevice: IProduct
        {
             private string name;
             private double price;
             private string brand;
            public ElectronicDevice(string name, double price, string brand)
            {
                this.name = name;
                this.price = price;
                this.brand = brand;
            }
             public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name}, Price: {price}, Brand: {brand}");
            }
        }
        class Smartphone : ElectronicDevice
            {
            private string operatingSystem;
            public Smartphone(string name, double price, string brand, string operatingSystem)
               : base(name, price, brand) 
            {
                this.operatingSystem = operatingSystem;
            }
        }
        class Laptop : ElectronicDevice
        {
            private int ramSize;
            public Laptop(string name, double price, string brand, int ramSize)
                : base(name, price, brand)
            {
                this.ramSize = ramSize;
            }
        }
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Galaxy S21", 799.99, "Samsung", "Android");
            Laptop laptop = new Laptop("XPS 13", 999.99, "Dell", 16);
            laptop.DisplayInfo();
            smartphone.DisplayInfo();
        }
    }
}
