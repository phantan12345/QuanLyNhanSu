using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class DAO_Luong
    {
        NhanSuEntities dbo;
        public DAO_Luong() { 
            dbo= new NhanSuEntities();
        }
        public dynamic getLuong()
        {
            var ds = dbo.BangLuong.Select(s => new
            {
                s.PCChucVu,
                s.PCPhongBan,
                s.SoNgayLam,
                s.Thang,
                s.Nam,
                s.Thuong,
                s.KyLuat,
                s.SoGioTangCa,
                s.LCB,
                s.LuongTotal
            }).ToList();
            return ds;
        }

        public void addLuong(BangLuong bl)
        {
            dbo.BangLuong.Add(bl);
            dbo.SaveChanges();
        }
    }
}
