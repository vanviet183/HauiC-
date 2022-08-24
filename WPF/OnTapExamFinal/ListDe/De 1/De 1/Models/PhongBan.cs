using System;
using System.Collections.Generic;

namespace De_1.Models
{
    public partial class PhongBan
    {
        public PhongBan()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public string Mapb { get; set; } = null!;
        public string? Tenphong { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
