using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO_ADMIN
{
    internal class DAO_CheDo
    {
        NhanSuEntities1 dbo;
        public DAO_CheDo() { 
            dbo= new NhanSuEntities1();
        }

        public dynamic getCheDo()
        {
            var ds = dbo.BaoHiems.Select(s => new
            {
                s.MaBH,
                s.MaNV,
                s.ThangDong,
                s.NamDong,
                s.GhiChu,
                s.TiLe        
            }).ToList();
            return ds;
        }

    }
}
