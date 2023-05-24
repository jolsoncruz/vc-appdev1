namespace DistanceTraveled
{
    internal class DistanceTraveled
    {
        double distance = 0.0;
        double speed = 0.0;
        double time = 0.0;
        
        public DistanceTraveled(double speed, double time)
        {
            this.speed = speed;
            this.time = time;
        }

        public void calculateDistance()
        {
            distance = speed * time;
        }

        public void printDistance()
        {
            for (int i = 1; i <= Math.Ceiling(time); i++)
            {
                Console.WriteLine("Hour " + i + ": Travelled " + speed*i + " miles!");
            }
        }

        public double getDistance()
        {
            return distance;
        }

        public double getSpeed()
        {
            return speed;
        }

        public double getTime()
        {
            return time;
        }
    }
}
