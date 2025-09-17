using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<List<Book>> bookShelves = new List<List<Book>>();
            List<Book> shelfs1 = new List<Book>();
            List<Book> shelfs2 = new List<Book>();
            Book book1 = new Book("shimshon", "yeled", 30, 20, 15);
            shelfs1.Add(book1);
            Book book2 = new Book("simcha", "home", 40, 10, 20);
            shelfs1.Add(book2);
            bookShelves.Add(shelfs1);
            Book book3 = new Book("shalom", "yad", 60, 15, 60);
            shelfs2.Add(book3);
            Book book4 = new Book("simcha", "home", 55, 7, 10);
            shelfs2.Add(book4);
            bookShelves.Add(shelfs2);







        }
    }
}
