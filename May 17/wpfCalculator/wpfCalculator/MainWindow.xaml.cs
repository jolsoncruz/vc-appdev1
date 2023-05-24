using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int num1txt = 0;
        private int num2txt = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void pullNums()
        {
            num1txt = int.Parse(num1.Text);
            num2txt = int.Parse(num2.Text);
        }
        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            pullNums();
            int resultNum = num1txt + num2txt;
            result.Content = resultNum;
        }

        private void num1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void multiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            pullNums();
            int resultNum = num1txt * num2txt;
            result.Content = resultNum;
        }

        private void divideBtn_Click(object sender, RoutedEventArgs e)
        {
            pullNums();
            int resultNum = num1txt / num2txt;
            result.Content = resultNum;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pullNums();
            int resultNum = num1txt - num2txt;
            result.Content = resultNum;
        }
    }
}
