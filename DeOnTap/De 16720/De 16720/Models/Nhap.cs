using System;
using System.Collections.Generic;

namespace De_16720.Models
{
    public partial class Nhap
    {
        public string Sohdn { get; set; } = null!;
        public string? Masp { get; set; }
        public int? Soluongn { get; set; }
        public decimal? Dongian { get; set; }

        public virtual Sanpham? MaspNavigation { get; set; }
        public virtual Pnhap SohdnNavigation { get; set; } = null!;
    }
}
