using System;
using System.Collections.Generic;

namespace De_16720.Models
{
    public partial class Hangsx
    {
        public Hangsx()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public string Mahangsx { get; set; } = null!;
        public string? Tenhang { get; set; }
        public string? Diachi { get; set; }
        public string? Sodt { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
