using De1.Models;
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

namespace De1
{
    /// <summary>
    /// Interaction logic for WindowSearch.xaml
    /// </summary>
    public partial class WindowSearch : Window
    {
        public WindowSearch()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            showData();
        }

        QLNhanvienContext db = new QLNhanvienContext();
        private void showData()
        {
            // Su dung LinQ
            var phongs = from phong in db.PhongBans
                        join nv in db.Nhanviens
                        on phong.MaPhong equals nv.MaPhong
                        select new
                        {
                            phong.MaPhong,
                            phong.TenPhong,
                            nv.MaNv,
                            nv.Luong

                        };

            // hien thi du lieu  
            var results = phongs.GroupBy(n => new { n.MaPhong, n.TenPhong })
                .Select(g => new {
                    g.Key.MaPhong,
                    g.Key.TenPhong,
                    SoLuong = g.Count(),
                    TongLuong = g.Sum(g => g.Luong)
                }).ToList();

        data.ItemsSource = results.ToList();
        }

    }
}
