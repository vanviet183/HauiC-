using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void getThiSinhByTotalMark(List<ThiSinhA> listThiSinhA, double mark)
        {
            foreach (ThiSinhA thiSinhA in listThiSinhA)
            {
                if (thiSinhA.tongDiem >= mark)
                    thiSinhA.Output();
            }
        }

        static void getThiSinhByTotalSoBD(List<ThiSinhA> listThiSinhA, string soBD)
        {
            foreach (ThiSinhA thiSinhA in listThiSinhA)
            {
                if (thiSinhA.sobd.Equals(soBD))
                    thiSinhA.Output();
            }
            Console.WriteLine("Không tồn tại thí sinh có số báo danh: " + soBD);
        }

        static void getThiSinhByTotalAddress(List<ThiSinhA> listThiSinhA, string address)
        {
            foreach (ThiSinhA thiSinhA in listThiSinhA)
            {
                if (thiSinhA.diachi.Equals(address))
                    thiSinhA.Output();
            }
        }

        static void showTitle()
        {
            Console.WriteLine("SoBD" + "\t" + "HoTen" + "\t" + "Địa chỉ" + "\t" + "Toán" + "\t" + "Lý" + "\t" + "Hóa" + "\t" + "Điểm ƯT" + "\t" + "Tổng điểm");
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            List<ThiSinhA> listThiSinhA = new List<ThiSinhA>();

            do
            {
                Console.WriteLine("1. Nhập 1 thí sinh");
                Console.WriteLine("2. Hiển thị toàn bộ danh sách");
                Console.WriteLine("3. Hiển thị thí sinh theo điểm");
                Console.WriteLine("4. Hiển thị thí sinh theo địa chỉ");
                Console.WriteLine("5. Hiển thị thí sinh theo số báo danh");
                Console.WriteLine("6. Exit");

                Console.Write("Nhập lựa chọn: ");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1: 
                        ThiSinhA a = new ThiSinhA();
                        a.Input();
                        listThiSinhA.Add(a);
                        break;

                    case 2:
                        Console.WriteLine("\t\tTHÔNG TIN DANH SÁCH THÍ SINH");
                        showTitle();
                        foreach(ThiSinhA thiSinhA in listThiSinhA)
                        {
                            thiSinhA.Output();
                        }
                        break;

                    case 3:
                        Console.Write("Nhập số điểm cần tìm: ");
                        double mark = double.Parse(Console.ReadLine());

                        Console.WriteLine("\t\tTHÔNG TIN DANH SÁCH THÍ SINH");
                        showTitle();
                        getThiSinhByTotalMark(listThiSinhA, mark);
                        break;

                    case 4:
                        Console.Write("Nhập địa chỉ cần tìm: ");
                        string address = Console.ReadLine();

                        Console.WriteLine("\t\tTHÔNG TIN DANH SÁCH THÍ SINH");
                        showTitle();
                        getThiSinhByTotalAddress(listThiSinhA, address);
                        break;

                    case 5:
                        Console.Write("Nhập số báo danh cần tìm: ");
                        string sobd = Console.ReadLine();

                        Console.WriteLine("\t\tTHÔNG TIN DANH SÁCH THÍ SINH");
                        showTitle();
                        getThiSinhByTotalSoBD(listThiSinhA, sobd);
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }

            } while (true);
        }
    }
}
