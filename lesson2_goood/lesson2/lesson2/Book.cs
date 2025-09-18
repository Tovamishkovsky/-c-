using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public  class Book:Item
    {

        public string author { get; set; }
        public Book(string author, string name, int price, int count, int age) : base(name, price, count, age)
        {
            this.author= author;
        }
        public override string ToString()
        {
            return base.ToString()+"author: "+author;
        }




    }
}
