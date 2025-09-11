using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle
    {
        public double Scope { get; set; }
        public string color { get; set; }

        public Circle(double scope, string color)
        {
            Scope = scope;
            this.color = color;
        }

        public static implicit operator Circle(Rectangle v)
        {
            throw new NotImplementedException();
        }
    }
}
