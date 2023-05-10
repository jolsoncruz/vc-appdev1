using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calculator.Model
{
    class model
    {
        // Variables
        private double var1;
        private double var2;

        // Parameterized Constructor
        public model(double var1, double var2)
        {
            this.var1 = var1;
            this.var2 = var2;
        }

        // Arithmetic Methods
        public double addition()
        {
            return this.var1 + this.var2;
        }

        public double subtraction()
        {
            return this.var1 - this.var2;
        }

        public double multiplication()
        {
            return this.var1 * this.var2;
        }

        public double division()
        {
            try
            {
                return this.var1 / this.var2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }
    }
}
