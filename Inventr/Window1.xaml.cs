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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Database2Entities db = new Database2Entities();

        public Window1()
        {
            InitializeComponent();
            cb_type.ItemsSource = db.Types_furniture.ToList();
            cb_room_ch.ItemsSource = new List<int> { 1, 2, 3 };
            dg_cab.ItemsSource = db.Room_furniture.ToList();
        }

        private void Bt_Add_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(tb_count_f.Text);
            for (int i = 0; i < count; i++)
            {
                int temp = (cb_type.SelectedItem as Types_furniture).Id_type;
                string num = db.Furnitures.Where(j => j.FK_type_furniture == temp).Select(j => j.Number_furniture).OrderByDescending(j => j).FirstOrDefault();
                num = num.Remove(0, 7);
                int n = Convert.ToInt32(num) + 1;
                num = Convert.ToString(n);
                for (int j = 0; j < 6; j++)
                {
                    if (num.Length != 6)
                        num = "0" + num;
                }
                string date = DateTime.Now.ToString("yyyy");
                num = "00" + temp + date + num;
                Furniture furniture = new Furniture()
                {
                    Number_furniture = num,
                    FK_type_furniture = temp
                };
                db.Furnitures.Add(furniture);
                db.SaveChanges();

                int id = db.Furnitures.FirstOrDefault(j => j.Number_furniture == num).Id_furniture;
                Room_furniture room_Furniture = new Room_furniture()
                {
                    Number_room = Convert.ToInt32(cb_room_ch.SelectedItem),
                    FK_id_furniture = id
                };

                db.Room_furniture.Add(room_Furniture);
                db.SaveChanges();
            }
        }
    }
}
