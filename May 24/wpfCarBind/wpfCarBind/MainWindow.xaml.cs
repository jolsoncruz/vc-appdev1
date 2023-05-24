using System.Collections.Generic;
using System.Windows;


namespace wpfCarBind
{
    public partial class MainWindow : Window
    {
        public List<wpfCar> MyCars
        {
            get;
            set;
        }

        public MainWindow()
        {
            InitializeComponent();

            wpfCar Car1 = new wpfCar("Toyota", 2010);
            wpfCar Car2 = new wpfCar("Nissan", 2014);
            wpfCar Car3 = new wpfCar("Cadillac", 2015);

            MyCars = new List<wpfCar>();

            MyCars.Add(Car1);
            MyCars.Add(Car2);
            MyCars.Add(Car3);

            DataContext = this;
        }
    }
}
