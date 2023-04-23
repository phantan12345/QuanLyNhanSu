using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class DAO_Luong
    {
        NhanSuEntities1 dbo;
        public DAO_Luong() 
        { 
            dbo = new NhanSuEntities1();
           
        }
        public dynamic getLuong()
        {
            var ds = dbo.BangLuongs.Select(s => new
            {
                s.MaNV,
                s.PCChucVu,
                s.PCPhongBan,
                s.SoNgayLam,
                s.Thang,
                s.Nam,
                s.Thuong,
                s.KyLuat,
                s.SoGioTangCa,
                //s.LCB,
                s.LuongTotal
            }).ToList();
            return ds;
        }
    }
}
