using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class DAO_InsuranceUser
    {
        NhanSuEntities1 dbo;
        public DAO_InsuranceUser()
        {
            dbo = new NhanSuEntities1();
        }

        public dynamic getDsInsurance(string id)
        {

            var insurance = dbo.BangLuongs
                .Join(dbo.BaoHiems,
                      bl => new { MaNV = bl.MaNV, Thang = bl.Thang, Nam = bl.Nam },
                      bh => new { MaNV = bh.MaNV, Thang = bh.ThangDong, Nam = bh.NamDong },
                      (bl, bh) => new
                      {
                          bl.MaNV,
                          bh.ThangDong,
                          bh.NamDong,
                          bh.TiLe,
                          bl.BaoHiem,
                          bh.GhiChu
                      }
                      ).Where(s => s.MaNV == id).ToList();

            return insurance;
        }




        public dynamic searchInsurance(string id, int t, int n)
        {
            var insurance = dbo.BangLuongs
                .Join(dbo.BaoHiems,
                      bl => new { MaNV = bl.MaNV, Thang = bl.Thang, Nam = bl.Nam },
                      bh => new { MaNV = bh.MaNV, Thang = bh.ThangDong, Nam = bh.NamDong },
                      (bl, bh) => new
                      {
                          bl.MaNV,
                          bh.ThangDong,
                          bh.NamDong,
                          bh.TiLe,
                          bl.BaoHiem,
                          bh.GhiChu
                      }
                      ).Where(s => s.MaNV == id && s.ThangDong == t && s.NamDong == n).ToList();

            return insurance;
        }

        public dynamic searchInsuranceM(string id, int t)
        {
            var insurance = dbo.BangLuongs
                .Join(dbo.BaoHiems,
                      bl => new { MaNV = bl.MaNV, Thang = bl.Thang, Nam = bl.Nam },
                      bh => new { MaNV = bh.MaNV, Thang = bh.ThangDong, Nam = bh.NamDong },
                      (bl, bh) => new { bl.MaNV, bh.ThangDong, bh.NamDong, bh.TiLe, bl.BaoHiem, bh.GhiChu }
                      ).Where(s => s.MaNV == id && s.ThangDong == t ).ToList();

            return insurance;
        }

        public dynamic searchInsuranceY(string id, int n)
        {
            var insurance = dbo.BangLuongs
                 .Join(dbo.BaoHiems,
                       bl => new { MaNV = bl.MaNV, Thang = bl.Thang, Nam = bl.Nam },
                       bh => new { MaNV = bh.MaNV, Thang = bh.ThangDong, Nam = bh.NamDong },
                       (bl, bh) => new { bl.MaNV, bh.ThangDong, bh.NamDong, bh.TiLe, bl.BaoHiem, bh.GhiChu }
                       ).Where(s => s.MaNV == id  && s.NamDong == n).ToList();

            return insurance;
        }
    }
}
