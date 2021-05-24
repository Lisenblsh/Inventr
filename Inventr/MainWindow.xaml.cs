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

        private void Chair_Click(object sender, MouseButtonEventArgs e)
        {
            List<TableDG> table = new List<TableDG> {new TableDG { Num = 1, InvNum = 1235412}};
            dg_cab1.ItemsSource = table;
        }

        private void Table_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void Lock_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void PC_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void Monitor_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void Keyboard_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void Mouse_Click(object sender, MouseButtonEventArgs e)
        {

        }

        public class TableDG
        {
            public int Num { get; set; }
            public int InvNum { get; set; }
        }
    }
}
