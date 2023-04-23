using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class DAO_UpdateSalary
    {
        NhanSuEntities1 dbo;
        public DAO_UpdateSalary()
        {
            dbo = new NhanSuEntities1();
        }

        public dynamic getUpdateSalary(string maNV)
        {
            var updateSalary = dbo.TangLuongs
                .Where(s => s.MaNV == maNV)
                .Select(s => new { s.MaNV, s.LCB, s.LCBMoi, s.NgaySua, s.GhiChu}).ToList();

            return updateSalary;
        }

        //public dynamic searchSalary(string id, int t, int n)
        //{
        //    var salary = dbo.BangLuongs
        //        .Where(s => s.MaNV == id && s.Thang == t && s.Nam == n)
        //        .Select(s => new { s.MaNV, s.Thang, s.Nam, s.LCB, s.PCChucVu, s.Thuong, s.KyLuat, s.SoNgayNghi, s.BaoHiem, s.LuongTotal }).ToList();

        //    return salary;
        //}

        //public dynamic searchSalaryM(string id, int t)
        //{
        //    var salary = dbo.BangLuongs
        //        .Where(s => s.MaNV == id && s.Thang == t)
        //        .Select(s => new { s.MaNV, s.Thang, s.Nam, s.LCB, s.PCChucVu, s.Thuong, s.KyLuat, s.SoNgayNghi, s.BaoHiem, s.LuongTotal }).ToList();

        //    return salary;
        //}

        //public dynamic searchSalaryY(string id, int n)
        //{
        //    var salary = dbo.BangLuongs
        //        .Where(s => s.MaNV == id && s.Nam == n)
        //        .Select(s => new { s.MaNV, s.Thang, s.Nam, s.LCB, s.PCChucVu, s.Thuong, s.KyLuat, s.SoNgayNghi, s.BaoHiem, s.LuongTotal }).ToList();

        //    return salary;
        //}
    }
}
