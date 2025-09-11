using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace lesson1
{
    public class main
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[4];
            Rectangle[] rectangles = new Rectangle[4];
            
            int y = 0;
            foreach (Rectangle item in rectangles) {
                if (item.width > 5)
                    Console.WriteLine(item.length+" "+item.width);
            }
            var circle2 =from item in circles
                         where item.Scope>7
                         select item;

        }
    }
    }

