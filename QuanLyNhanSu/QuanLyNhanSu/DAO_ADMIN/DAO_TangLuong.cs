using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO_ADMIN
{
    internal class DAO_TangLuong
    {
        NhanSuEntities1 dbo;

        public DAO_TangLuong()
        {
            dbo = new NhanSuEntities1();
        }

        public dynamic getTangLuong()
        {
            var ds = dbo.TangLuongs.Select(s => new
            {
                s.MaPhieu,
                s.MaNV,
                s.LCB,
                s.LCBMoi,
                s.NgaySua,
                s.GhiChu
            }).ToList();
            return ds;
        }

        public dynamic getTangLuongcb()
        {
            var ds = dbo.TangLuongs.Select(s => new
            {
             
                s.MaNV
               
            }).ToList();
            return ds;
        }

    }
}
