using System;
using System.Collections.Generic;

namespace De_1.Models
{
    public partial class NhanVien
    {
        public string Manv { get; set; } = null!;
        public string? Hoten { get; set; }
        public string? Mapb { get; set; }
        public double? Luong { get; set; }

        public virtual PhongBan? MapbNavigation { get; set; }
    }
}
