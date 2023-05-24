namespace BankCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank Charges Calculator!");

            Console.WriteLine("Enter ending balance of account: ");
            double var1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of checks written: ");
            int var2 = int.Parse(Console.ReadLine());

            BankCharges acc1 = new BankCharges(var1, var2);
            acc1.calculateCharges();

            Console.WriteLine("Charges for the month: " + acc1.getCharges());
            Console.WriteLine("Balance minus charges: " + (acc1.getBalance() - acc1.getCharges()));
        }
    }
}
