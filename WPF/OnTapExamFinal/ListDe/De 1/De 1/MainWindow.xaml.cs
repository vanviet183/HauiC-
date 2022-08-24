using De_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace De_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            showComboBox();
            showData();
        }

        De1Context db = new De1Context();

        private void showData()
        {
            var query = from nv in db.NhanViens
                        orderby nv.Luong
                        select new
                        {
                            nv.Manv,
                            nv.Hoten,
                            nv.Mapb,
                            nv.Luong,
                            ThuNhap = nv.Luong * 1.5
                        };

            data.ItemsSource = query.ToList();
        }

        private void showComboBox()
        {
            var query = from phong in db.PhongBans
                        select phong;
            cb.ItemsSource = query.ToList();
            cb.DisplayMemberPath = "Tenphong";
            cb.SelectedValuePath = "Mapb";
            cb.SelectedIndex = -1;
        }

        // them
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Check manv trung
            var query = db.NhanViens.SingleOrDefault(nv => nv.Manv.Equals(manv));
            if (query != null)
            {
                MessageBox.Show("Ma nv bi trung");
                showData();
            } else
            {
                if(checkDataInput())
                {
                    NhanVien nv = new NhanVien();
                    nv.Manv = manv.Text;
                    nv.Hoten = hoten.Text;
                    PhongBan phongBan = (PhongBan) cb.SelectedItem;
                    nv.Mapb = phongBan.Mapb;
                    nv.Luong = double.Parse(luong.Text);

                    // Add
                    db.NhanViens.Add(nv);
                    db.SaveChanges();

                    MessageBox.Show("Add nhan vien thanh cong");
                    showData();

                    // Clear data input
                    manv.Clear();
                    hoten.Clear();
                    cb.SelectedIndex = -1; ;
                    luong.Clear();
                    manv.Focus();

                } else
                {
                    return;
                }

            }
        }

        private bool checkDataInput()
        {
            try
            {
                string tb = "";
                if (manv.Text.Trim().Equals(""))
                    tb += "Ban chua nhap ma nv";
                if (hoten.Text.Trim().Equals(""))
                    tb += "Ban chua nhap ho ten";
                if (cb.SelectedIndex < 0)
                    tb += "Ban chua chon phong ban";
                double a;
                if (luong.Text.Trim().Equals(""))
                    tb += "Ban chua nhap luong";
                else if (!double.TryParse(luong.Text, out a))
                    tb += "Luong yeu cau nhap kieu so";

                if (!tb.Equals(""))
                {
                    MessageBox.Show(tb, "Thong bao");
                    return false;
                }

                return true;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        // Tim
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (manv.Text.Trim().Equals(""))
                MessageBox.Show("Ban chua nhap manv");
            else
            {
                List<NhanVien> nhanViens = new List<NhanVien>();
                NhanVien query = db.NhanViens.Single(nv => nv.Manv.Equals(manv.Text));

                nhanViens.Add(query);

                if (query != null)
                {
                    try
                    {

                        data.ItemsSource = nhanViens;

                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                else 
                    MessageBox.Show("Manv ko ton tai");
            }

        }
    }
}
