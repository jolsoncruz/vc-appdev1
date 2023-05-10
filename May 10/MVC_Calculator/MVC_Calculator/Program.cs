using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Calculator.Controller;

namespace MVC_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two values: ");
            double var1 = double.Parse(Console.ReadLine());
            double var2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your choice (1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division)");
            int choice = int.Parse(Console.ReadLine());

            controller ctrl = new controller(var1, var2);
            switch (choice)
            {
                case 1: Console.WriteLine(ctrl.model.addition()); break;
                case 2: Console.WriteLine(ctrl.model.subtraction()); break;
                case 3: Console.WriteLine(ctrl.model.multiplication()); break;
                case 4: Console.WriteLine(ctrl.model.division()); break;
                default: break;
            }

            Console.ReadKey();
        }
    }
}
