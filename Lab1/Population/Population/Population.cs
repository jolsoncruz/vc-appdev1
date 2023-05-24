namespace Population
{
    internal class Population
    {
        int startingNum = 0;
        int dailyPop = 0;
        double percentage = 0.0;
        int numDays = 0;

        public Population(int startingNum, double percentage, int numDays)
        {
            this.startingNum = startingNum;
            this.percentage = percentage;
            this.numDays = numDays;
        }

        public void calculatePercentage()
        {
            percentage = percentage / 100;
        }

        public void printPopulation()
        {
            dailyPop = startingNum;
            Console.WriteLine("Day " + 1 + ": " + dailyPop);
            for (int i = 1; i < numDays; i++)
            {
                dailyPop = (int)(dailyPop + (dailyPop* percentage));
                Console.WriteLine("Day " + (i+1) + ": " + dailyPop);
            }
        }

        public int getStartingNum()
        { 
            return startingNum; 
        }

        public double getPercentage()
        {
            return percentage;
        }

        public int getNumDays()
        {
            return numDays;
        }
    }
}
