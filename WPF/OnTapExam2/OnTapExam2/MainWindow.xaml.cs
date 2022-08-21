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

namespace OnTapExam2
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

        private void nhap_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (fullName.Text.Trim().CompareTo("") == 0)
                    throw new Exception("Bạn chưa nhập họ tên");
                if (date.Text.CompareTo("") == 0)
                    throw new Exception("Bạn không đưuọc để trống ngày sinh");
                else if (getAge() < 19 || getAge() > 60)
                    throw new Exception("Tuổi của bạn phải 19 <= a <= 60");

                if (sellMoney.Text.Trim().CompareTo("") == 0)
                    throw new Exception("Số tiền bán không được để trống");
                double a;
                if (!double.TryParse(sellMoney.Text, out a))
                    throw new Exception("Số tiền bán phải là kiểu số thực");

                ListBoxItem item = new ListBoxItem();
                item.Content = fullName.Text + " - " + typeEmployee.Text + " - " + getAge() + " - " + "Tiền bán hàng: " +  sellMoney.Text + " - Hoa hồng: " + hoaHong(double.Parse(sellMoney.Text));
                listBox.Items.Add(item);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int getAge()
        {
            DateTime today = DateTime.Today;
            DateTime dateChose = Convert.ToDateTime(date.SelectedDate);
            int age = today.Year - dateChose.Year;
            if (today.Month > dateChose.Month || (today.Month == dateChose.Month && today.Day > dateChose.Day))
                age--;
            return age;
        }

        private double hoaHong(double sellMoney)
        {
            if (sellMoney < 1000)
                return sellMoney;
            else if (sellMoney >= 1000 && sellMoney <= 5000)
                return sellMoney * 0.05;
            else 
                return sellMoney * 0.1;

        }

        private void window2_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Height = 400;
            window.Width = 400;
            if (listBox.SelectedItems.Count == 0)
                throw new Exception("Không có item nào được chọn");
            string str = "";
            foreach (ListBoxItem item in listBox.SelectedItems)
                str += item.Content;
            window.Content = str;
            window.Show();
        }

        private void xoa_Click(object sender, RoutedEventArgs e)
        {
            fullName.Text = "";
            typeEmployee.SelectedIndex = -1;
            date.SelectedDate = DateTime.Now;
            sellMoney.Text = "";
            fullName.Focus();
        }
    }
}
