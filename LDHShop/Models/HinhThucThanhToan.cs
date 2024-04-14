using System;
using System.Collections.Generic;

namespace LDHShop.Models;

public partial class HinhThucThanhToan
{
    public int Id { get; set; }

    public string CachThanhToan { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
