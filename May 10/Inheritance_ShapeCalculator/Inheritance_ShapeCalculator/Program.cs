using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(10, 5);
            Console.WriteLine("The area of the rectangle is: " + rec1.CalculateArea());
            Console.WriteLine("The perimeter of the rectangle is: " + rec1.CalculatePerimeter());

            Square sq1 = new Square(10);
            Console.WriteLine("\nThe area of the square is: " + sq1.CalculateArea());
            Console.WriteLine("The perimeter of the square is: " + sq1.CalculatePerimeter());

            Circle cir1 = new Circle(10);
            Console.WriteLine("\nThe area of the circle is: " + cir1.CalculateArea());
            Console.WriteLine("The perimeter of the circle is: " + cir1.CalculatePerimeter());

            Console.ReadKey();
        }
    }
}
