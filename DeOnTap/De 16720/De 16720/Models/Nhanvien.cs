using System;
using System.Collections.Generic;

namespace De_16720.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Pnhaps = new HashSet<Pnhap>();
            Pxuats = new HashSet<Pxuat>();
        }

        public string Manv { get; set; } = null!;
        public string? Tennv { get; set; }
        public string? Gioitinh { get; set; }
        public string? Diachi { get; set; }
        public string? Sodt { get; set; }
        public string? Email { get; set; }
        public string? Tenphong { get; set; }

        public virtual ICollection<Pnhap> Pnhaps { get; set; }
        public virtual ICollection<Pxuat> Pxuats { get; set; }
    }
}
