using de2.Models;
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

namespace de2
{
    /// <summary>
    /// Interaction logic for FindWindow.xaml
    /// </summary>
    public partial class FindWindow : Window
    {
        public FindWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            showData();
        }

        QuanLySanPhamDBContext db = new QuanLySanPhamDBContext();


        private void showData()
        {
            var query = from sp in db.SanPhams
                        orderby sp.SoLuongBan descending
                        where sp.MaNhomHang == 1
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
    }
}
