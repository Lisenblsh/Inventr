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
    /// Логика взаимодействия для Page2Kab2.xaml
    /// </summary>
    public partial class Page2Kab2 : Page
    {
        public Page2Kab2()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Height = 1;
            this.Width = 1;
            this.NavigationService.GoBack();
        }
    }
}
