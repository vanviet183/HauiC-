using System;
using System.Collections.Generic;

namespace De_16720.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Nhaps = new HashSet<Nhap>();
            Xuats = new HashSet<Xuat>();
        }

        public string Masp { get; set; } = null!;
        public string? Mahangsx { get; set; }
        public string? Tensp { get; set; }
        public int? Soluong { get; set; }
        public string? Mausac { get; set; }
        public decimal? Giaban { get; set; }
        public string? Donvitinh { get; set; }
        public string? Mota { get; set; }

        public virtual Hangsx? MahangsxNavigation { get; set; }
        public virtual ICollection<Nhap> Nhaps { get; set; }
        public virtual ICollection<Xuat> Xuats { get; set; }
    }
}
