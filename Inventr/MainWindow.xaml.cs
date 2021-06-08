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
        Database2Entities db = new Database2Entities();
        Authorization authorization = new Authorization();
        public MainWindow()
        {
            InitializeComponent();
            if (Authorization.PRole == 1)
            ad_btn();

            Chair.MouseLeftButtonUp += (sender, e) => ADd(1, 1);
            Table.MouseLeftButtonUp += (sender, e) => ADd(1, 2);
            Lock.MouseLeftButtonUp += (sender, e) => ADd(1, 3);
            PC.MouseLeftButtonUp += (sender, e) => ADd(1, 4);
            Monitor.MouseLeftButtonUp += (sender, e) => ADd(1, 5);
            Keyboard.MouseLeftButtonUp += (sender, e) => ADd(1, 6);
            Mouse.MouseLeftButtonUp += (sender, e) => ADd(1, 7);

            Chair2.MouseLeftButtonUp += (sender, e) => ADd(2, 1);
            Table2.MouseLeftButtonUp += (sender, e) => ADd(2, 2);
            Lock2.MouseLeftButtonUp += (sender, e) => ADd(2, 3);
            PC2.MouseLeftButtonUp += (sender, e) => ADd(2, 4);
            Monitor2.MouseLeftButtonUp += (sender, e) => ADd(2, 5);
            Keyboard2.MouseLeftButtonUp += (sender, e) => ADd(2, 6);
            Mouse2.MouseLeftButtonUp += (sender, e) => ADd(2, 7);

            Chair3.MouseLeftButtonUp += (sender, e) => ADd(3, 1);
            Table3.MouseLeftButtonUp += (sender, e) => ADd(3, 2);
            Lock3.MouseLeftButtonUp += (sender, e) => ADd(3, 3);
            PC3.MouseLeftButtonUp += (sender, e) => ADd(3, 4);
            Monitor3.MouseLeftButtonUp += (sender, e) => ADd(3, 5);
            Keyboard3.MouseLeftButtonUp += (sender, e) => ADd(3, 6);
            Mouse3.MouseLeftButtonUp += (sender, e) => ADd(3, 7);
        }

        public void ad_btn()
        {
            Button button = new Button();
            button.Content = "Добавить";
            button.Height = 40;
            button.Width = 100;
            button.Margin = new Thickness(393, 240, 68, 100);
            button.Click += (sender, e) => btn_click();
            gr1.Children.Add(button);
        }

        public void btn_click()
        {
            Window1 window1 = new Window1();
            window1.Show();
            
        }

        public void ADd(int room, int type)
        {
            DataGrid dataGrid = new DataGrid();
            if (room == 1)
                dataGrid = dg_cab1;
            else if (room == 2)
                dataGrid = dg_cab2;
            else if (room == 3)
                dataGrid = dg_cab3;
            dataGrid.ItemsSource = db.Room_furniture.Where(i => i.Number_room == room && i.Furniture.Types_furniture.Id_type == type).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            authorization.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int asd = db.Furnitures.Select(i => i.Id_furniture).LastOrDefault();
        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            dg_cab1.ItemsSource = db.Room_furniture.Where(i => i.Number_room == 1).ToList();
            Quantity_Chair.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 1 && i.Furniture.Types_furniture.Id_type == 1).Count());
            Quantity_Table.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 1 && i.Furniture.Types_furniture.Id_type == 2).Count());
            Quantity_Lock.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 1 && i.Furniture.Types_furniture.Id_type == 3).Count());
            Quantity_PC.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 1 && i.Furniture.Types_furniture.Id_type == 4).Count());
            Quantity_Monitor.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 1 && i.Furniture.Types_furniture.Id_type == 5).Count());
            Quantity_Keyboard.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 1 && i.Furniture.Types_furniture.Id_type == 6).Count());
            Quantity_Mouse.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 1 && i.Furniture.Types_furniture.Id_type == 7).Count());
        }

        private void TabItem_Loaded_1(object sender, RoutedEventArgs e)
        {
            dg_cab2.ItemsSource = db.Room_furniture.Where(i => i.Number_room == 2).ToList();
            Quantity_Chair2.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 2 && i.Furniture.Types_furniture.Id_type == 1).Count());
            Quantity_Table2.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 2 && i.Furniture.Types_furniture.Id_type == 2).Count());
            Quantity_Lock2.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 2 && i.Furniture.Types_furniture.Id_type == 3).Count());
            Quantity_PC2.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 2 && i.Furniture.Types_furniture.Id_type == 4).Count());
            Quantity_Monitor2.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 2 && i.Furniture.Types_furniture.Id_type == 5).Count());
            Quantity_Keyboard2.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 2 && i.Furniture.Types_furniture.Id_type == 6).Count());
            Quantity_Mouse2.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 2 && i.Furniture.Types_furniture.Id_type == 7).Count());
        }

        private void TabItem_Loaded_2(object sender, RoutedEventArgs e)
        {
            dg_cab3.ItemsSource = db.Room_furniture.Where(i => i.Number_room == 3).ToList();
            Quantity_Chair3.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 3 && i.Furniture.Types_furniture.Id_type == 1).Count());
            Quantity_Table3.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 3 && i.Furniture.Types_furniture.Id_type == 2).Count());
            Quantity_Lock3.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 3 && i.Furniture.Types_furniture.Id_type == 3).Count());
            Quantity_PC3.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 3 && i.Furniture.Types_furniture.Id_type == 4).Count());
            Quantity_Monitor3.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 3 && i.Furniture.Types_furniture.Id_type == 5).Count());
            Quantity_Keyboard3.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 3 && i.Furniture.Types_furniture.Id_type == 6).Count());
            Quantity_Mouse3.Text = Convert.ToString(db.Room_furniture.Where(i => i.Number_room == 3 && i.Furniture.Types_furniture.Id_type == 7).Count());
        }
    }
}
