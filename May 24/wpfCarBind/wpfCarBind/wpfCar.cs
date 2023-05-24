using System;

namespace wpfCarBind
{
    public class wpfCar
    {

        public string Brand {
            get;
            set;
        }

        public int Year {
            get;
            set;
        }

        public wpfCar()
        {
            this.Brand = "";
            this.Year = 0000;
        }

        public wpfCar(String Brand, int Year)
        {
            this.Brand = Brand;
            this.Year = Year;
        }
    }
}
