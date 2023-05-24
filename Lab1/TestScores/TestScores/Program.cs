namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Welcome to Test Score Calculator!");

            Console.WriteLine("Enter three values: ");
            double var1 = double.Parse(Console.ReadLine());
            double var2 = double.Parse(Console.ReadLine());
            double var3 = double.Parse(Console.ReadLine());

            TestScores test1 = new TestScores(var1, var2, var3);
            test1.calculateAverage();
            test1.calculateLetterGrade();
            Console.WriteLine(test1.getAverage() + " is equal to: " + test1.getLetterGrade());
        }
    }
}
