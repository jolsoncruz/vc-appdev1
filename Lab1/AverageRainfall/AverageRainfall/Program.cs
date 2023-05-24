namespace AverageRainfall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Average Rainfall Calculator!");

            Console.WriteLine("Enter number of years: ");
            int var1 = int.Parse(Console.ReadLine());

            while (var1 < 1)
            {
                Console.WriteLine("INVALID VALUE! Enter number of years: ");
                var1 = int.Parse(Console.ReadLine());
            }

            AverageRainfall data1 = new AverageRainfall(var1);
            data1.calculateRainfall();
            data1.printRainfall();
            Console.ReadKey();
        }
    }
}
