using System;
using System.Collections.Generic;

namespace De_16720.Models
{
    public partial class Pxuat
    {
        public string Sohdx { get; set; } = null!;
        public DateTime? Ngayxuat { get; set; }
        public string? Manv { get; set; }

        public virtual Nhanvien? ManvNavigation { get; set; }
        public virtual Xuat Xuat { get; set; } = null!;
    }
}
