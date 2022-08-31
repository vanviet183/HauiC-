using de16720.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace de16720
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Window2_Loaded(object sender, RoutedEventArgs e)
        {
            showData();
        }

        QLBanHang2Context db = new QLBanHang2Context();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private void showData()
        {
            var danhMucs = from dm in db.DanhMucHangs
                           join hang in db.Hangs
                           on dm.MaDm equals hang.MaDm
                           select new
                           {
                               dm.MaDm,
                               dm.TenDm,
                               TongTien = hang.DonGiaBan * hang.SoLuongCon
                           };

            var result = danhMucs.GroupBy(dm => new { dm.MaDm, dm.TenDm })
                .Select(n => new
                {
                    n.Key.MaDm,
                    n.Key.TenDm,
                    TongTienDM = n.Sum(n => n.TongTien)
                }).ToList();

            

            data.ItemsSource = result.ToList();
        }
    }
}
