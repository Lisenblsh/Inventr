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
        Func func = new Func();
        public int PRole;
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
            PRole = func.Authorez(TBox_Login.Text, PBox_Pass.Password);
            TBox_Login.Clear();
            PBox_Pass.Clear();
            if (PRole != 0)
                this.Hide();
        }


        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Button_Click(sender, e);
            }
        }
    }
    public class Func
    {
        public int Authorez(string Login, string Pass)
        {
            int role = 1;

            //if (Login == "log" && Pass == "pass")
            //{
            //    role = 1;
            //}
            //else
            //{
            //    MessageBox.Show("Неверный логин или пароль");
            //}
            return role;
        }
    }
}
