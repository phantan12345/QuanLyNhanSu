using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class DAO_NhanVien
    {
        NhanSuEntities db;

        public DAO_NhanVien()
        {
            db = new NhanSuEntities();
        }
        public dynamic LayDSPB()
        {
            var ds = db.PhongBans.Select(s => new
            {
                s.MaPhongBan,
                s.TenPhongBan
            }).ToList();
            return ds;
        }
        public String LayTenPB(String ma)
        {
            PhongBan p = db.PhongBans.SingleOrDefault(nv => nv.MaPhongBan == ma);
            return p.TenPhongBan;
        }
        public dynamic LayDSNV()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.HoTen,
                s.NgaySinh,
                s.NoiSinh,
                s.SoDienThoai,
                s.ChucVu,
                s.CCCD
            }).ToList();
            return ds;
        }
        public void ThemNV(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }
        public Boolean KiemTraNV(String CCCD)
        {
            NhanVien nvm = db.NhanViens.SingleOrDefault(nv => nv.CCCD == CCCD);
            if (nvm!=null)
                return true;
            return false;
        }
        public void SuaNV(NhanVien nv)
        {
            NhanVien n = db.NhanViens.SingleOrDefault(nvc => nvc.CCCD == nv.CCCD);
            n.HoTen = nv.HoTen;
            n.NgaySinh=nv.NgaySinh ;
            n.NoiSinh=nv.NoiSinh ;
            n.email = nv.email;
            n.ChucVu = nv.ChucVu ;
            n.SoDienThoai = nv.SoDienThoai ;
            n.HocVan = nv.HocVan;
            n.GioiTinh = nv.GioiTinh;
            n.MaPhong = nv.MaPhong;
            db.SaveChanges();
        }
        public NhanVien LayNV(String CCCD)
        {
            return db.NhanViens.SingleOrDefault(nv => nv.CCCD == CCCD);
        }

        public void XoaNV(NhanVien nv)
        {
            db.NhanViens.Remove(nv);
            db.SaveChanges();
        }

    }
}
