namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Population Calculator!");

            Console.WriteLine("Enter starting number of organisms: ");
            int var1 = int.Parse(Console.ReadLine());
            
            while(var1 < 2)
            {
                Console.WriteLine("INVALID VALUE! Enter starting number of organisms: ");
                var1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter average daily population increage (percentage): ");
            double var2 = double.Parse(Console.ReadLine());

            while (var2 < 0)
            {
                Console.WriteLine("INVALID VALUE! Enter average daily population increage (percentage): ");
                var2 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter number of days they will multiply: ");
            int var3 = int.Parse(Console.ReadLine());

            while (var3 < 1)
            {
                Console.WriteLine("INVALID VALUE! Enter number of days they will multiply: ");
                var3 = int.Parse(Console.ReadLine());
            }

            Population organism1 = new Population(var1, var2, var3);
            organism1.calculatePercentage();
            organism1.printPopulation();
            Console.ReadKey();
        }
    }
}
