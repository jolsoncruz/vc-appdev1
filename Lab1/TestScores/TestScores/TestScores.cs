namespace TestScores
{
    internal class TestScores
    {
        double score1 = 0.0;
        double score2 = 0.0;
        double score3 = 0.0;
        double average = 0.0;
        char letterGrade = 'Z';

        public TestScores(double score1, double score2, double score3)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }
        
        public void calculateAverage()
        {
            average = (score1 + score2 + score3) / 3;
        }

        public void calculateLetterGrade()
        {
            if (average < 60)
                letterGrade = 'F';
            else if (average < 70)
                letterGrade = 'D';
            else if (average < 80)
                letterGrade = 'C';
            else if (average < 90)
                letterGrade = 'B';
            else if (average <= 100)
                letterGrade = 'A';
        }

        public double getAverage()
        {
            return average;
        }

        public double getScore1()
        {
            return score1;
        }

        public double getScore2()
        {
            return score2;
        }

        public double getScore3()
        {
            return score3;
        }

        public char getLetterGrade()
        {
            return letterGrade;
        }
    }
}