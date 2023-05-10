using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ShapeCalculator
{
    public abstract class Shape
    {
        protected double length { set; get; }
        protected double height { set; get; }

        // Default Constructor
        public Shape()
        {
            length = 0.0;
            height = 0.0;
        }

        // Parameterized Constructor
        public Shape(double length, double height)
        {
            this.length = length;
            this.height = height;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();



    }
}
