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
    
    public partial class BangLuong
    {
        public string MaLuong { get; set; }
        public Nullable<double> PCPhongBan { get; set; }
        public string GhiChu { get; set; }
        public string MaNV { get; set; }
        public Nullable<double> PCChucVu { get; set; }
        public Nullable<int> SoNgayNghi { get; set; }
        public Nullable<int> SoNgayLam { get; set; }
        public Nullable<int> Thang { get; set; }
        public Nullable<int> Nam { get; set; }
        public Nullable<double> Thuong { get; set; }
        public Nullable<double> KyLuat { get; set; }
        public Nullable<int> SoGioTangCa { get; set; }
        public Nullable<double> LuongTotal { get; set; }
        public Nullable<double> BaoHiem { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
