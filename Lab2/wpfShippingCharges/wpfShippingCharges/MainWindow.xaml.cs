using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media.Media3D;

namespace wpfShippingCharges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
            double charges = 0.0;

            if (var1 <= 2.0)
                charges = Math.Ceiling(var2 / 500) * 1.10;
            else if (var1 < 6.0)
                charges = Math.Ceiling(var2 / 500) * 2.20;
            else if (var1 < 10.0)
                charges = Math.Ceiling(var2 / 500) * 3.70;
            else
                charges = Math.Ceiling(var2 / 500) * 4.80;

            if (charges == 0.0)
            {
                return "Error! Fill-in all parameters!";
            }
            else
            {
                return "The total calculated fee is: $" + charges;
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
