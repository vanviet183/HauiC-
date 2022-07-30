using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1
{
    internal class NhanVien : Person
    {
        private string idNhanVien;
        private string chucVu;
        private double luongCoBan;

        public string IdNhanVien
        {
            get { return idNhanVien; }
            set { idNhanVien = value; }
        }

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap id nhan vien: ");
            idNhanVien = Console.ReadLine();

            Console.Write("Nhap chuc vu: ");
            chucVu = Console.ReadLine();

            Console.Write("Nhap luong co ban: ");
            luongCoBan = double.Parse(Console.ReadLine());

            int heSoLuong = tinhHeSoCV();
            
        }

        public int tinhHeSoCV()
        {
            switch(chucVu)
            {
                case "giam doc":
                    return 10;

                case "truong phong":
                case "pho giam doc":
                    return 6;

                case "pho phong":
                    return 4;

                default:
                    return 2;
            }
        }

    }
}
