using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class Shelf<T> where T : Item 
    {
        public int numshelf { get; set; }
        public int column { get; set; }
        public double mishkal { get; set; }
        public int capacity { get; set; }
        public List<T> items { get; set; } = new List<T>(); 
        public Shelf(int capacity,int numshelf, int column, double mishkal)
        {
            this.numshelf = numshelf;
            this.column = column;
            this.mishkal = mishkal;
            this.capacity = capacity;
        }

    }
}
