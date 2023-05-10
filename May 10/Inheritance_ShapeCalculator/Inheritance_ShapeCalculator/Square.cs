using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ShapeCalculator
{
    class Square : Shape
    {
        public Square(double length) : base(length, 0.0)
        {
        }

        public override double CalculateArea()
        {
            return length * length;
        }

        public override double CalculatePerimeter()
        {
            return 4 * length;
        }
    }
}
