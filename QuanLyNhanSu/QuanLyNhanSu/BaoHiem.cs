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
    
    public partial class BaoHiem
    {
        public string MaBH { get; set; }
        public string MaNV { get; set; }
        public Nullable<int> ThangDong { get; set; }
        public Nullable<int> NamDong { get; set; }
        public string GhiChu { get; set; }
        public Nullable<double> TiLe { get; set; }
        public string TienBH { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
