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
        public dynamic TimDSBL(String ma, int thang)
        {
            var ds = db.BangLuongs
                .Where(s => s.Nam == thang)
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
        public dynamic TimDSBL(int ma)
        {
            var ds = db.BangLuongs
                .Where(s => s.Thang == ma)
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
    }
}
