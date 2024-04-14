using System;
using System.Collections.Generic;

namespace LDHShop.Models;

public partial class ChiTietGioHang
{
    public int MaGioHang { get; set; }

    public int MaHh { get; set; }

    public decimal DonGia { get; set; }

    public int SoLuong { get; set; }

    public decimal? SoTien { get; set; }

    public decimal? GiamGia { get; set; }

    public virtual GioHang MaGioHangNavigation { get; set; } = null!;

    public virtual HangHoa MaHhNavigation { get; set; } = null!;
}
