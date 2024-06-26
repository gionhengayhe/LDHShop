﻿using System;
using System.Collections.Generic;

namespace LDHShop.Models;

public partial class HinhThucVanChuyen
{
    public int Id { get; set; }

    public string HinhThucVanChuyen1 { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
