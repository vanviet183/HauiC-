using de2.Models;
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

namespace de2
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            showData();
            showComboBox();
        }

        QuanLySanPhamDBContext db = new QuanLySanPhamDBContext();

        private void showComboBox()
        {
            var query = from nhom in db.NhomHangs
                        select nhom;

            nhomCb.ItemsSource = query.ToList();
            nhomCb.DisplayMemberPath = "TenNhomHang";
            nhomCb.SelectedValuePath = "MaNhomHang";
            nhomCb.SelectedIndex = -1;
        }

        private void showData()
        {
            var query = from sp in db.SanPhams
                        orderby sp.SoLuongBan descending
                        select new
                        {
                            sp.MaSp,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.SoLuongBan,
                            TenNhomHang = sp.MaNhomHangNavigation.TenNhomHang,
                            TienBan = sp.DonGia * sp.SoLuongBan,
                        };

            data.ItemsSource = query.ToList();
        }

        private void find_Click(object sender, RoutedEventArgs e)
        {
            
            FindWindow findWindow = new FindWindow();
            findWindow.Show();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.SingleOrDefault(sp => sp.MaSp.Equals(masp.Text));

            if(query != null)
            {
                MessageBox.Show("Trung ma sp");
                showData();
            } else
            {
                try 
                { 
                    if(checkDataInput())
                    {
                        SanPham sp = new SanPham();
                        sp.MaSp = int.Parse(masp.Text);
                        sp.TenSanPham = tensp.Text;
                        sp.DonGia = double.Parse(dongia.Text);
                        sp.SoLuongBan = int.Parse(soluong.Text);
                        NhomHang nhomHang = (NhomHang)nhomCb.SelectedItem;
                        sp.MaNhomHang = nhomHang.MaNhomHang;
                        sp.TienBan = sp.DonGia * sp.SoLuongBan;

                        db.SanPhams.Add(sp);
                        db.SaveChanges();

                        MessageBox.Show("Add thanh cong", "Thong bao");
                        showData();

                        masp.Clear();
                        tensp.Clear();
                        dongia.Clear();
                        soluong.Clear();
                        nhomCb.SelectedIndex = -1;

                        masp.Focus();

                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool checkDataInput()
        {
            try
            {
                string tb = "";
                int c;
                if (masp.Text.Trim().Equals(""))
                    tb += "Ban chua nhap ma sp";
                else if (!int.TryParse(masp.Text, out c))
                    tb += "Ma sp yeu cau nhap kieu so";

                if (tensp.Text.Trim().Equals(""))
                    tb += "Ban chua nhap ten sp";
                if (nhomCb.SelectedIndex < 0)
                    tb += "Ban chua chon nhom hang";
                double a;
                if (dongia.Text.Trim().Equals(""))
                    tb += "Ban chua nhap don gia";
                else if (!double.TryParse(dongia.Text, out a))
                    tb += "Don gia yeu cau nhap kieu so";

                int b;
                if (soluong.Text.Trim().Equals(""))
                    tb += "Ban chua nhap so luong";
                else if (!int.TryParse(soluong.Text, out b) && int.Parse(soluong.Text) >= 1)
                    tb += "So luong yeu cau nhap kieu so và >= 1";

                if (!tb.Equals(""))
                {
                    MessageBox.Show(tb, "Thong bao");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(data.SelectedItems.Count > 0)
            {
                try
                {
                    Type type = data.SelectedItem.GetType();
                    PropertyInfo[] propertyInfos = type.GetProperties();
                    masp.Text = propertyInfos[0].GetValue(data.SelectedValue).ToString();
                    tensp.Text = propertyInfos[1].GetValue(data.SelectedValue).ToString();
                    dongia.Text = propertyInfos[2].GetValue(data.SelectedValue).ToString();
                    soluong.Text = propertyInfos[3].GetValue(data.SelectedValue).ToString();
                    nhomCb.SelectedValue = propertyInfos[4].GetValue(data.SelectedValue).ToString();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   

        }
    }
}
