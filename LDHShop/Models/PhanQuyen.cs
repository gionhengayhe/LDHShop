using System;
using System.Collections.Generic;

namespace LDHShop.Models;

public partial class PhanQuyen
{
    public int MaPq { get; set; }

    public string? MaCv { get; set; }

    public int? MaTrang { get; set; }

    public bool Them { get; set; }

    public bool Sua { get; set; }

    public bool Xoa { get; set; }

    public bool Xem { get; set; }

    public virtual ChucVu? MaCvNavigation { get; set; }

    public virtual TrangWeb? MaTrangNavigation { get; set; }
}
