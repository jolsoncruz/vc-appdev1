using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace April21
{
    class Program
    {
        public static void Main(String[] args)
        {
/*            int _variableOne;
            Console.Write("Enter the value for the variableOne: ");
            _variableOne = int.Parse(Console.ReadLine());
            Console.WriteLine("The variable we inserted is: " + _variableOne);

            decimal _variableTwo;
            _variableTwo = 25.75m;
            Console.WriteLine("\nThe const decimal variable is: " + _variableTwo);
            Console.Write("Enter value for variable two / decimal variable: ");
            _variableTwo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The value we inserted for decimal variable is: " + _variableTwo);

            double _variableThree;
            _variableThree = 789.856;
            Console.WriteLine("\nThe double variable we fixed is: " + _variableThree);
            Console.Write("Enter values for variable three / double variable: ");
            _variableThree = double.Parse(Console.ReadLine());
            Console.WriteLine("The values you inserted is: " + _variableThree);

            String _variableFour;
            _variableFour = "This is the value for a String variable";
            Console.WriteLine("\nThe string value is: " + _variableFour);
            Console.Write("Enter any values for your String variable: ");
            _variableFour = Console.ReadLine();
            Console.WriteLine("The string value is: " + _variableFour);*/

            double num1, num2, total, difference, product, quotient, remainder;
            Console.Write("\nEnter value for Number 1: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter value for Number 2: ");
            num2 = double.Parse(Console.ReadLine());

            total = num1 + num2;
            difference = num1 - num2;
            product = num1 * num2;
            quotient = num1 / num2;
            remainder = num1 % num2;

            Console.WriteLine("\nThe total of the two variables are: " + total);
            Console.WriteLine("The difference of the two variables are: " + difference);
            Console.WriteLine("The product of the two variables are: " + product);
            Console.WriteLine("The quotient of the two variables are: " + quotient);
            Console.WriteLine("The remainder of the two variables are: " + remainder);

            int num3 = 25;
            try
            {
                Console.Write("\nEnter the value for num3: ");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("The values you inserted: " + num3);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message); 
            }

            decimal marks;
            Console.WriteLine("Enter marks for the student: ");
            marks = decimal.Parse(Console.ReadLine());

            try
            {
                if (marks >= 90 && marks <= 100)
                    Console.WriteLine("The Grade is: A");
                else if (marks >= 80 && marks < 90)
                    Console.WriteLine("The Grade is: B");
                else if (marks >= 70 && marks < 80)
                    Console.WriteLine("The Grade is: C");
                else if (marks >= 60 && marks < 70)
                    Console.WriteLine("The Grade is: D");
                else
                    Console.WriteLine("The Student failed");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}