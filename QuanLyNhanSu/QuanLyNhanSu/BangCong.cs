//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanSu
{
    using System;
    using System.Collections.Generic;
    
    public partial class BangCong
    {
        public string MaBangCong { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> NgayLam { get; set; }
        public Nullable<int> ThangLam { get; set; }
        public Nullable<int> NamLam { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> SoGioTangCa { get; set; }
        public string MaNV { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
