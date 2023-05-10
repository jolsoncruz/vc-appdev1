using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ShapeCalculator
{
    class Circle : Shape
    {
        private readonly double PI = 3.14;

        public Circle(double length) : base(length/2, 0.0)
        {
        }

        public override double CalculateArea()
        {
            return PI * (length * length);
        }

        public override double CalculatePerimeter()
        {
            return 2 * PI * (length);
        }
    }
}
