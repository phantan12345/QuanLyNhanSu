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
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.BangCongs = new HashSet<BangCong>();
            this.BangLuongs = new HashSet<BangLuong>();
            this.BaoHiems = new HashSet<BaoHiem>();
            this.TangLuongs = new HashSet<TangLuong>();
        }
    
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string MaBoPhan { get; set; }
        public string MaPhong { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<bool> TTHonNhan { get; set; }
        public string CCCD { get; set; }
        public string ChucVu { get; set; }
        public string LoaiHD { get; set; }
        public Nullable<int> ThoiGian { get; set; }
        public Nullable<System.DateTime> NgayKy { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public string SoDienThoai { get; set; }
        public string MaPhieuThaiSan { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<bool> role { get; set; }
        public Nullable<bool> active { get; set; }
        public string email { get; set; }
        public Nullable<double> LCB { get; set; }
        public string NoiSinh { get; set; }
        public string HocVan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangCong> BangCongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangLuong> BangLuongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoHiem> BaoHiems { get; set; }
        public virtual PhongBan PhongBan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TangLuong> TangLuongs { get; set; }
    }
}
