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
using System.Windows.Shapes;


namespace Inventr
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {

        public static int PRole;
        protected override void OnClosed(EventArgs e) //Функция для завершеия отладки программы
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TBox_Login.Text == "Admin" && PBox_Pass.Password == "123")
            {
                PRole = 1;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else if (TBox_Login.Text == "User" && PBox_Pass.Password == "qwe")
            {
                PRole = 2;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            TBox_Login.Clear();
            PBox_Pass.Clear();          
        }


        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Button_Click(sender, e);
            }
        }
    }
}
