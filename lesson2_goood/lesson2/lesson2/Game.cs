using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class Game : Item 
    {
        public double timeofplay { get; set; }

        public Game(double timeofplay,string name, int price, int count, int age) : base(name, price, count, age)
        {
            this.timeofplay = timeofplay;
        }
        public override string ToString()
        {
            return base.ToString() + "timeofplay: " + timeofplay;
        }
    }
}
