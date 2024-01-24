using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.CLASSES_AND_OBJECTS
{
    internal class book
    {
        public string title;
        public string author;
        public int pages;

        static void Main(string[] args)
        {
            book book1 = new book();

            book1.title = "harry potter";
            book1.author = "jk rowling";
            book1.pages = 400;

            book book2 = new book();
            book2.title = "only the pot knows how hot the fire is";
            book2.author = "tolkien";
            book2.pages = 900;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Console.Read();

        }
    }
}
