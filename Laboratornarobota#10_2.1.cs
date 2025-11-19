using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_10_2_1
{
    internal class Program
    {
        interface IPrintable
        {
                void Print();
        }
        interface IBorrowable 
        {
            void BorrowItem();
            void ReturnItem();
            bool IsAvailable();
        }
        class Book : IPrintable, IBorrowable
        {
            private string title;
            private string author;
            private bool available;
            public Book(string title, string author)
            {
                this.title = title;
                this.author = author;
                this.available = true;
            }
            public void Print()
            {
                Console.WriteLine($"Title: {title}, Author: {author}, Available: {available}");
            }
            public void BorrowItem()
            {
                if (available)
                {
                    available = false;
                    Console.WriteLine($"You have borrowed '{title}'.");
                }
                else
                {
                    Console.WriteLine($"Sorry, '{title}' is currently not available.");
                }
            }
            public void ReturnItem()
            {
                available = true;
                Console.WriteLine($"You have returned '{title}'.");
            }
            public bool IsAvailable()
            {
                return available;
            }
        }
        static void Main(string[] args)
        {
            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
            Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            book1.Print();
            book1.BorrowItem();
            book2.Print();
            book2.ReturnItem();
            book3.Print();
            book3.BorrowItem();
        }
    }
}

