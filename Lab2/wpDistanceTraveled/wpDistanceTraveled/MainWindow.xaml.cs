using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media.Media3D;

namespace wpDistanceTraveled
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
        }

        public void CalculateDistance()
        {
            var3 = var1 * var2;
        }
        private void calculateResult()
        {
            for (int i = 1; i <= Math.Ceiling(var2); i++)
            {
                str += "Hour " + i + ": Travelled " + var1 * i + " miles!\n";
            }
        }

        private void resultBtn_Click(object sender, RoutedEventArgs e)
        {
            PullInput();
            result.Clear();
            calculateResult();
            Console.WriteLine(str);
            result.Text = str;
        }

    }
}
