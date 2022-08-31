using de16720.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace de16720
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
            showComboBox();
            showData();
        }

        QLBanHang2Context db = new QLBanHang2Context();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private void showData()
        {
                var query = from hang in db.Hangs
                            where hang.SoLuongCon <= 200
                            orderby hang.TenHang descending
                            select new
                            {
                                hang.MaHang,
                                hang.TenHang,
                                hang.MaDm,
                                DonGiaBan = int.Parse(hang.DonGiaBan.ToString()).ToString("#,###", cul.NumberFormat),
                                SoLuongCon = int.Parse(hang.SoLuongCon.ToString()).ToString("#,###", cul.NumberFormat),
                                ThanhTien = int.Parse((hang.DonGiaBan * hang.SoLuongCon).ToString()).ToString("#,###", cul.NumberFormat)
                            };
            data.ItemsSource = query.ToList();
        }

        private void showComboBox()
        {
            var query = from dm in db.DanhMucHangs
                        select dm;
            danhMuc.ItemsSource = query.ToList();
            danhMuc.DisplayMemberPath = "TenDm";
            danhMuc.SelectedValuePath = "MaDm";
            danhMuc.SelectedIndex = -1;
        }

        private bool checkDataInput()
        {
            try
            {
                string tb = "";
                if (maHang.Text.Trim().Equals(""))
                    tb += "Ban chua nhap ma hang";
                if (tenHang.Text.Trim().Equals(""))
                    tb += "Ban chua nhap ten hang";
                if (danhMuc.SelectedIndex < 0)
                    tb += "Ban chua chon danh muc";
                int a;
                if (donGia.Text.Trim().Equals(""))
                    tb += "Ban chua nhap don gia";
                else if (!int.TryParse(donGia.Text, out a) && int.Parse(donGia.Text) > 0)
                    tb += "Don gia yeu cau nhap kieu so va > 0";

                int b;
                if (soLuong.Text.Trim().Equals(""))
                    tb += "Ban chua nhap so luong";
                else if (!int.TryParse(soLuong.Text, out b) && int.Parse(soLuong.Text) > 0)
                    tb += "So luong yeu cau nhap kieu so va > 0";

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

        private void Them_Click(object sender, RoutedEventArgs e)
        {
            var query = db.Hangs.SingleOrDefault(hang => hang.MaHang.Equals(maHang.Text));
            if(query != null)
            {
                MessageBox.Show("Trung ma hang");
                showData();
            } else
            {
                try
                {
                    if(checkDataInput())
                    {
                        Hang hang = new Hang();
                        hang.MaHang = maHang.Text;
                        hang.TenHang = tenHang.Text;
                        DanhMucHang danhMucHang = (DanhMucHang) danhMuc.SelectedItem;
                        hang.MaDm = danhMucHang.MaDm;
                        hang.DonGiaBan = int.Parse(donGia.Text);
                        hang.SoLuongCon = int.Parse(soLuong.Text);

                        db.Hangs.Add(hang);
                        db.SaveChanges();
                        MessageBox.Show("Them hang thanh cong");
                        showData();

                        maHang.Clear();
                        tenHang.Clear();
                        donGia.Clear();
                        soLuong.Clear();
                        danhMuc.SelectedIndex = -1;

                        maHang.Focus();
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Sua_Click(object sender, RoutedEventArgs e)
        {
            var hangChange = db.Hangs.SingleOrDefault(hang => hang.MaHang.Equals(maHang.Text));
            if (hangChange == null)
            {
                MessageBox.Show("Ma hang khong dung");
                showData();
            } else
            {
                if(checkDataInput())
                {
                    hangChange.TenHang = tenHang.Text;
                    DanhMucHang danhMucHang = (DanhMucHang)danhMuc.SelectedItem;
                    hangChange.MaDm = danhMucHang.MaDm;
                    hangChange.DonGiaBan = int.Parse(donGia.Text);
                    hangChange.SoLuongCon = int.Parse(soLuong.Text);

                    db.SaveChanges();
                    MessageBox.Show("Sua thanh cong");
                    showData();

                }
            }
        }

        private void Xoa_Click(object sender, RoutedEventArgs e)
        {
            var hangDel = db.Hangs.SingleOrDefault(hang => hang.MaHang.Equals(maHang.Text));
            MessageBoxResult result = MessageBox.Show("Ban co chan chan xoa hang nay khong", "Thong bao", MessageBoxButton.YesNo);

            if (hangDel != null && result == MessageBoxResult.Yes)
            {
                db.Hangs.Remove(hangDel);
                db.SaveChanges();
                MessageBox.Show("Xoa thanh cong");
                showData();
            } else
            {
                MessageBox.Show("Xoa khong hop le");
            }
        }

        private void Tim_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(data.SelectedItem != null)
            {
                try
                {
                    Type type = data.SelectedItem.GetType();
                    PropertyInfo[] properties = type.GetProperties();
                    maHang.Text = properties[0].GetValue(data.SelectedValue).ToString();
                    tenHang.Text = properties[1].GetValue(data.SelectedValue).ToString();
                    danhMuc.SelectedValue = properties[2].GetValue(data.SelectedValue);
                    donGia.Text = properties[3].GetValue(data.SelectedValue).ToString();
                    soLuong.Text = properties[4].GetValue(data.SelectedValue).ToString();
                    maHang.IsReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }
    }
}
