namespace ShippingCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Shipping Charges Calculator!");

            Console.WriteLine("Enter weight of package: ");
            double var1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter distance of shipping: ");
            double var2 = double.Parse(Console.ReadLine());

            ShippingCharges pkg1 = new ShippingCharges(var1, var2);
            pkg1.calculateCharges();
            Console.WriteLine("Shipping charge: " + pkg1.getCharges());
            Console.ReadKey();
        }
    }
}
