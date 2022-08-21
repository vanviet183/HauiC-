using De1.Models;
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
using System.Text.RegularExpressions;

namespace De1
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

        // Tao doi tuong Context
        static QLNhanvienContext db = new QLNhanvienContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            showData();
            showComboBox();
        }

        private void showData()
        {
            // Su dung LinQ
            var queryNV = from nv in db.Nhanviens
                          where nv.Luong > 5000
                          orderby nv.Luong 
                          select new
                          {
                              nv.MaPhong,
                              nv.MaNv,
                              nv.Hoten,
                              nv.Luong,
                              nv.Thuong,
                              ThanhTien = nv.Thuong + nv.Luong
                          };

            // hien thi du lieu  
            data.ItemsSource = queryNV.ToList();
        }

        private void showComboBox()
        {
            var query = from phong in db.PhongBans
                        select phong;
            rooms.ItemsSource = query.ToList();
            rooms.DisplayMemberPath = "TenPhong";
            rooms.SelectedValuePath = "MaPhong";
            rooms.SelectedIndex = 0;
        }


        // Them
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // check manv trung
            var query = db.Nhanviens.SingleOrDefault(nv => nv.MaNv.Equals(manvI.Text));
            if (query != null)
            {
                MessageBox.Show("Manv bi trung");
                showData();
            }
            else
            {
                try
                {
                    if (CheckDL())
                    {
                        Nhanvien nv = new Nhanvien();
                        nv.MaNv = manvI.Text;
                        nv.Hoten = nameI.Text;
                        nv.Luong = int.Parse(salaryI.Text);
                        nv.Thuong = int.Parse((thuongI.Text));
                        PhongBan phongBan = (PhongBan)rooms.SelectedItem;
                        nv.MaPhong = phongBan.MaPhong;
                        db.Nhanviens.Add(nv);

                        // Save changes to database
                        db.SaveChanges();
                        MessageBox.Show("Them nhan vien thanh cong");
                        showData();

                        manvI.Clear();
                        nameI.Clear();
                        salaryI.Clear();
                        thuongI.Clear();
                        rooms.SelectedIndex = -1;
                        manvI.Focus();
                    }
                    else
                        return;

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        // Check data
        private bool CheckDL()
        {
            string tb = "";
            if (manvI.Text == "" || nameI.Text == "" || salaryI.Text == "" || thuongI.Text == "")
                tb += "\nBan can nhap day du du lieu!";
            //int a;
            //if (!int.TryParse(salaryI.Text, out a)) // Nếu đơn giá nhập vào không phải là số
            //    tb += "\nLuong nhập vào phải là số!";

            //if (!int.TryParse(thuongI.Text, out a)) // Nếu đơn giá nhập vào không phải là số
            //    tb += "\nThuong nhập vào phải là số!";

            //int salary = int.Parse(salaryI.Text);
            //int thuong = int.Parse(thuongI.Text);
            //if (salary < 0 || thuong < 0)
            //    tb += "\nLuong nhap vao phai la so duong!";

            //if (thuong < 0)
            //    tb += "\nThuong nhap vao phai la so duong!";

            if (!tb.Equals(""))
            {
                MessageBox.Show(tb, "Thong Bao");
                return false;
            }
            return true;
        }


        // Sua
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nvChange = db.Nhanviens.SingleOrDefault(nv => nv.MaNv.Equals(manvI.Text));
            if(nvChange != null)
            {
                nvChange.MaNv = manvI.Text;
                nvChange.Hoten = nameI.Text;
                nvChange.Luong = int.Parse(salaryI.Text);
                nvChange.Thuong = int.Parse(thuongI.Text);
                PhongBan phongban = (PhongBan) rooms.SelectedItem;
                nvChange.MaPhong = phongban.MaPhong;

                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                showData();
            }
        }

        // Xoa
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var itemDel = db.Nhanviens.SingleOrDefault(nv => nv.MaNv.Equals(manvI.Text));
            if(itemDel != null)
            {
                MessageBoxResult result = MessageBox.Show("Vui long xac nhan xoa", "Thong bao", MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {
                    db.Nhanviens.Remove(itemDel);
                    db.SaveChanges();
                    MessageBox.Show("Xoa thanh cong");
                    showData();
                }
            } else
            {
                MessageBox.Show("Khong co item de xoa");
            }
        }

        // Tim
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowSearch window2 = new WindowSearch();
            window2.Show();
        }

        // Choose Item in DataGrid
        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (data.SelectedItem != null)
            {
                try
                {
                    Type type = data.SelectedItem.GetType();
                    PropertyInfo[] properties = type.GetProperties();
                    rooms.SelectedValue = properties[0].GetValue(data.SelectedValue);
                    manvI.Text = properties[1].GetValue(data.SelectedValue).ToString();
                    nameI.Text = properties[2].GetValue(data.SelectedValue).ToString();
                    salaryI.Text = properties[3].GetValue(data.SelectedValue).ToString();
                    thuongI.Text = properties[4].GetValue(data.SelectedValue).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
