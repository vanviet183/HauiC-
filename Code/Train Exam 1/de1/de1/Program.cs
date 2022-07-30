using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1
{
    internal class Program
    {
        public static void showListNhanVIen(List<NhanVien> nhanViens)
        {
            showTitle();

            foreach(NhanVien nhanVien in nhanViens)
            {
                Console.WriteLine($"{nhanVien.IdNhanVien,20}" + $"{nhanVien.Name,20}" + $"{nhanVien.ChucVu,20}" + $"{nhanVien.Address,20}" + $"{nhanVien.LuongCoBan,20}");
            }
        }

        public static bool checkIdNhanVien(List<NhanVien> nhanViens, string idNhanVien)
        {
            foreach (NhanVien nhanVien in nhanViens)
            {
                if(nhanVien.IdNhanVien == idNhanVien)
                {
                    Console.WriteLine("Id nhan vien da ton tai vui long nhap lai.");
                    return false;
                }
            }
            return true;
        }

        public static void sortListNhanVien(List<NhanVien> nhanViens)
        {
            for(int i = 0; i < nhanViens.Count - 1; i++)
                for (int j = i + 1; j < nhanViens.Count; j++)
                    if (nhanViens[i].tinhHeSoCV()  > nhanViens[j].tinhHeSoCV())
                    {
                        NhanVien temp = nhanViens[i];
                        nhanViens[i] = nhanViens[j];
                        nhanViens[j] = temp;
                    } else if (nhanViens[i].tinhHeSoCV() == nhanViens[j].tinhHeSoCV()) {
                        if (nhanViens[i].LuongCoBan > nhanViens[j].LuongCoBan)
                        {
                            NhanVien temp = nhanViens[i];
                            nhanViens[i] = nhanViens[j];
                            nhanViens[j] = temp;
                        }
                    }
        }

        public static void showTitle()
        {
            Console.WriteLine($"{"Id Nhan Vien",20}" + $"{"Ten",20}" + $"{"Chuc vu",20}" + $"{"Dia chi",20}" + $"{"Luong co ban",20}");

        }

        static void Main(string[] args)
        {
                
            List<NhanVien> nhanViens = new List<NhanVien>();

            int choose;
            do
            {
                Console.WriteLine("1. Them nhan vien");
                Console.WriteLine("2. Hien thi danh sach nhan vien");
                Console.WriteLine("3. Sap xep danh sach nhan vien");
                Console.WriteLine("4. Exit");
                Console.Write("Nhap vao lua chon: ");
                choose = int.Parse(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                        NhanVien nhanVien = new NhanVien();
                        Console.WriteLine("Nhap thong tin nhan vien: ");
                        nhanVien.Input();
                        if(checkIdNhanVien(nhanViens, nhanVien.IdNhanVien)) 
                            nhanViens.Add(nhanVien);

                        break;

                    case 2:
                        showListNhanVIen(nhanViens);
                        break;

                    case 3:
                        sortListNhanVien(nhanViens);
                        Console.WriteLine("Danh sach sau khi sap xep");

                        showListNhanVIen(nhanViens);
                        break;

                    case 4:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
            } while (true);
        }
    }
}
