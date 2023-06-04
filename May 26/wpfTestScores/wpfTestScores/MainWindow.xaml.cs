using System;
using System.Windows;

namespace wpfTestScores
{

    public partial class MainWindow : Window
    {

        private double var1 = 0;
        private double var2 = 0;
        private double var3 = 0;
        private String str = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PullInput()
        {
            var1 = double.Parse(input1.Text);
            var2 = double.Parse(input2.Text);
            var3 = double.Parse(input3.Text);
        }

        private String calculateResult()
        {
            double average = (var1 + var2 + var3) / 3;
            String letterGrade = "";

            if (average < 60)
                letterGrade = "F";
            else if (average < 70)
                letterGrade = "D";
            else if (average < 80)
                letterGrade = "C";
            else if (average < 90)
                letterGrade = "B";
            else if (average <= 100)
                letterGrade = "A";

            if (letterGrade == "")
            {
                return "Error! Fill-in all parameters!";
            }
            else
            {
                return "The calculated letter average is: " + letterGrade;
            }
        }


        private void avgButton_Click(object sender, RoutedEventArgs e)
        {
            PullInput();
            str = calculateResult();
            result.Content = str;
        }
    }
}
