using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Calculator.Model;

namespace MVC_Calculator.Controller
{
    class controller
    {
        public model model;

        public controller(double var1, double var2)
        {
            model = new model(var1, var2);
        }
    }
}
