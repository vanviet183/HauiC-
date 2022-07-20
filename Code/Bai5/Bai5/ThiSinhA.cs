using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class ThiSinhA
    {
        public string sobd { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public double toan { get; set; }
        public double ly { get; set; }
        public double hoa { get; set; }
        public double diemUuTien { get; set; }
        public double tongDiem { get; set; }

        public void Input()
        {
            Console.Write("Nhập số báo danh: ");
            sobd = Console.ReadLine();

            Console.Write("Nhập họ tên: ");
            hoten = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            diachi = Console.ReadLine();

            Console.Write("Nhập điểm toán: ");
            toan = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm ly: ");
            ly = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm hoa: ");
            hoa = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm ưu tiên: ");
            diemUuTien = double.Parse(Console.ReadLine());

            tongDiem = toan + ly + hoa + diemUuTien;
        }

        public void Output()
        {

            Console.WriteLine(sobd + "\t" + hoten + "\t" + diachi + "\t" + toan + "\t" + ly + "\t" + hoa + "\t" + diemUuTien + "\t" + tongDiem);
            
        }

    }
}
