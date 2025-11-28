using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_13_1
{
    class Document
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public Document(string name, string content)
        {
            Name = name;
            Content = content;
        }

        Stack<string> stack = new Stack<string>();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("SampleDoc", "This is a sample document content.");
            Console.WriteLine("Document Name: " + doc.Name);
            Console.WriteLine("Document Content: " + doc.Content);
                
        }
    }
}
