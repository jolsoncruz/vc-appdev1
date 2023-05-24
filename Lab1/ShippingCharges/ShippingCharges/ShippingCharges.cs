using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCharges
{
    internal class ShippingCharges
    {
        double weight = 0.0;
        double distance = 0.0;
        double charges = 0.0;

        public ShippingCharges(double weight, double distance)
        {
            this.weight = weight;
            this.distance = distance;
        }

        public void calculateCharges()
        {
            if (weight <= 2.0)
                charges = Math.Ceiling(distance / 500) * 1.10;
            else if (weight < 6.0)
                charges = Math.Ceiling(distance / 500) * 2.20;
            else if (weight < 10.0)
                charges = Math.Ceiling(distance / 500) * 3.70;
            else
                charges = Math.Ceiling(distance / 500) * 4.80;
        }

        public double getWeight()
        {
            return weight;
        }

        public double getDistance() { 
            return distance;
        }

        public double getCharges()
        {
            return charges;
        }

    }
}
