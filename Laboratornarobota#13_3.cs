using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_13_3
{
    internal class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<int, Book> library = new Dictionary<int, Book>();
            library.Add(1, new Book { Title = "Кобзар", Author = "Тарас Шевченко" });
            library.Add(2, new Book { Title = "Тіні забутих предків", Author = "Михайло Коцюбинський" });
            library.Add(3, new Book { Title = "Захар Беркут", Author = "Іван Франко" });
            Console.WriteLine("Пошук книги з ID 2:");
            Book foundBook = library[2];
            Console.WriteLine(foundBook.Title + " - " + foundBook.Author);
            Console.WriteLine("Видалення книги з ID 1:");
            library.Remove(1);
            Console.WriteLine("Книгу видалено");
            Console.WriteLine("Всі книги в бібліотеці:");
            foreach (var entry in library)
            {
                Console.WriteLine("ID: " + entry.Key + " - " + entry.Value.Title + " - " + entry.Value.Author);
            }
            Console.WriteLine("Всього книг: " + library.Count);
            Console.ReadLine();
        }
    }
}
