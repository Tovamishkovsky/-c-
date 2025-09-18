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
            List<Shelf<Book>> shelves = new List<Shelf<Book>>();

            // יצירת מדף ראשון
            var shelf1 = new Shelf<Book>(capacity: 5, numshelf: 1, column: 1, mishkal: 0);
            shelf1.items.Add(new Book("shimshon", "yeled", 30, 20, 15));
            shelf1.items.Add(new Book("simcha", "home", 40, 10, 20));
            shelves.Add(shelf1);

            // יצירת מדף שני
            var shelf2 = new Shelf<Book>(capacity: 5, numshelf: 2, column: 1, mishkal: 0);
            shelf2.items.Add(new Book("shalom", "yad", 60, 15, 60));
            shelf2.items.Add(new Book("simcha", "home", 55, 7, 10));
            shelves.Add(shelf2);
            //שאילתות
            var resuit=from s in shelves
                       where s.items.Count ==s.capacity
                       select s;
            var result2 =from s in shelves
                         where s.items.Any(b => b.age < 12)
                         select s;
            var result3 = from s in shelves
                          where s.items.Any(b => b.price > 70)
                          select s;

           


        }
    }
}
