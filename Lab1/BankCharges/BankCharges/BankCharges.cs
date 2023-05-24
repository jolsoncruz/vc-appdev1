namespace BankCharges
{
    internal class BankCharges
    {
        double balance = 0.0;
        int numDep = 0;
        double charges = 0.0;

        public BankCharges(double balance, int numDep)
        {
            this.balance = balance;
            this.numDep = numDep;
        }

        public void calculateCharges()
        {
            if (numDep < 20)
                charges = 0.10 * numDep;
            else if (numDep < 40)
                charges = 0.08 * numDep;
            else if (numDep < 60)
                charges = 0.06 * numDep;
            else
                charges = 0.04 * numDep;

            if (balance < 400)
                charges += 15;
        }

        public double getBalance()
        {
            return balance;
        }

        public int getNumDep()
        {
            return numDep;
        }

        public double getCharges()
        {
            return charges;
        }

    }
}
