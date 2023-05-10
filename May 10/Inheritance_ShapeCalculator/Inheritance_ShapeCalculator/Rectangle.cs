using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ShapeCalculator
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width) : base(length, width)
        {
        }
        public override double CalculateArea()
        {
            return length * height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (length + height);
        }
    }
}
