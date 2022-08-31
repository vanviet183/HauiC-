using System;
using System.Collections.Generic;

namespace De_16720.Models
{
    public partial class Xuat
    {
        public string Sohdx { get; set; } = null!;
        public string? Masp { get; set; }
        public int? Soluongx { get; set; }

        public virtual Sanpham? MaspNavigation { get; set; }
        public virtual Pxuat SohdxNavigation { get; set; } = null!;
    }
}
