using System;
using System.Collections.Generic;

namespace De_16720.Models
{
    public partial class Pnhap
    {
        public string Sohdn { get; set; } = null!;
        public DateTime? Ngaynhap { get; set; }
        public string? Manv { get; set; }

        public virtual Nhanvien? ManvNavigation { get; set; }
        public virtual Nhap Nhap { get; set; } = null!;
    }
}
