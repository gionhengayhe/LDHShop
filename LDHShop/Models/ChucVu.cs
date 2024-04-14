using System;
using System.Collections.Generic;

namespace LDHShop.Models;

public partial class ChucVu
{
    public string MaCv { get; set; } = null!;

    public string TenChucVu { get; set; } = null!;

    public string? ThongTin { get; set; }

    public virtual ICollection<PhanCong> PhanCongs { get; set; } = new List<PhanCong>();

    public virtual ICollection<PhanQuyen> PhanQuyens { get; set; } = new List<PhanQuyen>();
}
