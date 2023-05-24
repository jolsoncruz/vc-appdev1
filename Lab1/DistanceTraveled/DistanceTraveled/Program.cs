namespace DistanceTraveled
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Distance Traveled Calculator!");

            Console.WriteLine("Enter speed traveled (mph): ");
            double var1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter time traveled: ");
            int var2 = int.Parse(Console.ReadLine());

            DistanceTraveled dist1 = new DistanceTraveled(var1, var2);
            dist1.calculateDistance();
            dist1.printDistance();
            Console.ReadKey();
        }
    }
}
