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
    /// Логика взаимодействия для Page3Kab3.xaml
    /// </summary>
    public partial class Page3Kab3 : Page
    {
        public Page3Kab3()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Height = 1;
            this.Width = 1;
        }

        private void Chair_Click(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
