using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Inventr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Authorization authorization = new Authorization();
        public MainWindow()
        {
            InitializeComponent();
            this.Show();
            authorization.Owner = this;
            authorization.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            this.Show();
            authorization.Owner = this;
            authorization.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1Kab1.Height = 418;
            Page1Kab1.Width = 792;
            Page1Kab1.Navigate(new Page1Kab1());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page2Kab2.Height = 418;
            Page2Kab2.Width = 792;
            Page2Kab2.Navigate(new Page2Kab2());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Page3Kab3.Height = 418;
            Page3Kab3.Width = 792;
            Page3Kab3.Navigate(new Page3Kab3());
        }
    }
}
