using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO_ADMIN
{
    internal class DAO_Luong
    {
        NhanSuEntities1 db;

        public DAO_Luong()
        {
            db = new NhanSuEntities1();
        }
        public dynamic LayDSBL()
        {
            var ds = db.BangLuongs.Select(s => new
            {
                s.MaNV,
                s.SoNgayLam,
                s.SoNgayNghi,
                s.Thang,
                s.Nam,
                s.BaoHiem,
                s.LuongTotal
            }).ToList();
            return ds;
        }
        public dynamic TimDSBL(String ma, int thang, int nam)
        {
            if (nam == 0)
            {
                return db.BangLuongs
                .Where(s => s.MaNV == ma && s.Thang == thang)
                .Select(s => new
                {
                    s.MaNV,
                    s.SoNgayLam,
                    s.SoNgayNghi,
                    s.Thang,
                    s.Nam,
                    s.LuongTotal
                }).ToList();
            }
            if (thang == 0)
            {
                return db.BangLuongs
                        .Where(s => s.MaNV == ma && s.Thang == thang)
                        .Select(s => new
                        {
                            s.MaNV,
                            s.SoNgayLam,
                            s.SoNgayNghi,
                            s.Thang,
                            s.Nam,
                            s.LuongTotal
                        }).ToList();
            }
            if (ma == "")
            {
                return db.BangLuongs
                    .Where(s => s.Thang == thang && s.Nam == nam)
                    .Select(s => new
                    {
                        s.MaNV,
                        s.SoNgayLam,
                        s.SoNgayNghi,
                        s.Thang,
                        s.Nam,
                        s.LuongTotal
                    }).ToList();
            }
            var ds = db.BangLuongs
                .Where(s => s.MaNV == ma && s.Thang == thang && s.Nam == nam)
                .Select(s => new
                {
                    s.MaNV,
                    s.SoNgayLam,
                    s.SoNgayNghi,
                    s.Thang,
                    s.Nam,
                    s.LuongTotal
                }).ToList();
            return ds;
        }
        public dynamic TimDSBL(String ma, int nam)
        {
            var ds = db.BangLuongs
                .Where(s => s.Nam == nam)
                .Select(s => new
                {
                    s.MaNV,
                    s.SoNgayLam,
                    s.SoNgayNghi,
                    s.Thang,
                    s.Nam,
                    s.LuongTotal
                }).ToList();
            return ds;
        }
        public dynamic TimDSBL(int thang)
        {
            var ds = db.BangLuongs
                .Where(s => s.Thang == thang)
                .Select(s => new
                {
                    s.MaNV,
                    s.SoNgayLam,
                    s.SoNgayNghi,
                    s.Thang,
                    s.Nam,
                    s.LuongTotal
                }).ToList();
            return ds;
        }
        public dynamic TimDSBL(String ma)
        {
            var ds = db.BangLuongs
                .Where(s => s.MaNV == ma)
                .Select(s => new
                {
                    s.MaNV,
                    s.SoNgayLam,
                    s.SoNgayNghi,
                    s.Thang,
                    s.Nam,
                    s.LuongTotal
                }).ToList();
            return ds;
        }
        public BangLuong LayBL(String ma,int thang,int nam)
        {
            return db.BangLuongs.SingleOrDefault(nv => nv.MaNV == ma && nv.Thang==thang&&nv.Nam==nam);
        }
        public NhanVien LayNV(string ma)
        {
            return db.NhanViens.SingleOrDefault(nv => nv.MaNV == ma);
        }

        public int NgayLam(String ma,int thang,int nam)
        {
            return db.BangCongs.Where(b=>b.MaNV==ma&&b.ThangLam==thang&&b.NamLam==nam).Count();
        }
        public void TinhLuong(String ma,int thang,int nam)
        {
            BangLuong bl = new BangLuong();
            bl.MaLuong= Guid.NewGuid().ToString().Substring(0, 10);
            bl.MaNV = ma;
            bl.Thang = thang;
            bl.Nam = nam;
            bl.SoNgayLam = NgayLam(ma, thang, nam);
            bl.PCChucVu = 200;
            if (bl.SoNgayLam > 22)
            {
                bl.Thuong = 100;
                bl.KyLuat = 0;
            }
            else {
                bl.Thuong = 0;
                bl.KyLuat = 50; 
            }
            NhanVien nv = LayNV(ma);
            bl.LuongTotal = nv.LCB/26 * bl.SoNgayLam +bl.PCChucVu+bl.Thuong-bl.KyLuat;
            bl.BaoHiem = bl.LuongTotal * 0.1;
            db.BangLuongs.Add(bl);
            db.SaveChanges();
        }
        public void TaoBH(BaoHiem bh)
        {
            db.BaoHiems.Add(bh);
            db.SaveChanges();
        }
        public List<string> LayDSMaNV()
        {
            return db.NhanViens.Select(nv => nv.MaNV).ToList();
        }
        public void ThemTangLuong(TangLuong tl)
        {
            NhanVien nv = new NhanVien();
            nv = LayNV(tl.MaNV);
            nv.LCB = tl.LCBMoi;
            db.TangLuongs.Add(tl);
            db.SaveChanges();
        }
        public dynamic LayDSTangLuong(String ma)
        {
            return db.TangLuongs.Where(s=>s.MaNV==ma)
                .Select(s => new
            {
                s.MaNV,
                s.LCB,
                s.LCBMoi,
                s.GhiChu,
                s.NgaySua,
            }).ToList();
        }
    }
}
