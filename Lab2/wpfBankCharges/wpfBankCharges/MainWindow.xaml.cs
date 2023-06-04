using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace wpfBankCharges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        private double var1 = 0;
        private double var2 = 0;
        private String str = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PullInput()
        {
            var1 = double.Parse(input1.Text);
            var2 = double.Parse(input2.Text);
        }

        private String calculateResult()
        {
            double charges = 0;

            if (var1 < 20)
                charges = 0.10 * var1;
            else if (var1 < 40)
                charges = 0.08 * var1;
            else if (var1 < 60)
                charges = 0.06 * var1;
            else
                charges = 0.04 * var1;

            if (var2 < 400)
                charges += 15;

            if (charges == 0)
            {
                return "Error! Fill-in all parameters!";
            }
            else
            {
                return "The total inncurred service fees are: $" + charges;
            }
        }

        private void resultBtn_Click(object sender, RoutedEventArgs e)
        {
            PullInput();
            str = calculateResult();
            result.Content = str;
        }
    }
}
