using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageRainfall
{

    internal class AverageRainfall
    {
        double[,] rainfall;
        int years = 0;

        public AverageRainfall(int years)
        {
            this.years = years;
            rainfall = new double[years,12];
        }

        public void calculateRainfall()
        {
            for (int i = 0; i < years; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine("Enter inches of rainfall for Year " + (i + 1) + " Month " + (j + 1));
                    double rain = double.Parse(Console.ReadLine());

                    while (rain < 0)
                    {
                        Console.WriteLine("INVALID VALUE! Enter inches of rainfall for Year " + (i + 1) + " Month " + (j + 1));
                        rain = double.Parse(Console.ReadLine());
                    }

                    rainfall[i,j] = rain;
                }
            }
        }

        public void printRainfall()
        {
            for (int i = 0; i < years; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine("Rainfall for Year" + (i + 1) + " Month " + (j + 1) + rainfall[i,j]);
                }
            }
        }
    }
}
