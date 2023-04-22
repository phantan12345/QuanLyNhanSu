using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class DAO_SalaryUser
    {
        NhanSuEntities1 dbo;
        public DAO_SalaryUser()
        {
            dbo = new NhanSuEntities1();
        }

        public dynamic getDsSalary(string id)
        {
            var salary = dbo.BangLuongs
                .Where(s => s.MaNV == id)
                .Select(s => new { s.MaNV, s.Thang, s.Nam, s.LCB, s.PCChucVu, s.Thuong, s.KyLuat, s.SoNgayNghi, s.BaoHiem, s.LuongTotal }).ToList();

            return salary;
        }

        public dynamic searchSalary(string id, int t, int n) 
        {
            var salary = dbo.BangLuongs
                .Where(s => s.MaNV == id && s.Thang == t && s.Nam == n)
                .Select(s => new { s.MaNV, s.Thang, s.Nam, s.LCB, s.PCChucVu, s.Thuong, s.KyLuat, s.SoNgayNghi, s.BaoHiem, s.LuongTotal }).ToList();

            return salary;
        }

        public dynamic searchSalaryM(string id, int t)
        {
            var salary = dbo.BangLuongs
                .Where(s => s.MaNV == id && s.Thang == t )
                .Select(s => new { s.MaNV, s.Thang, s.Nam, s.LCB, s.PCChucVu, s.Thuong, s.KyLuat, s.SoNgayNghi, s.BaoHiem, s.LuongTotal }).ToList();

            return salary;
        }

        public dynamic searchSalaryY(string id, int n)
        {
            var salary = dbo.BangLuongs
                .Where(s => s.MaNV == id && s.Nam == n)
                .Select(s => new { s.MaNV, s.Thang, s.Nam, s.LCB, s.PCChucVu, s.Thuong, s.KyLuat, s.SoNgayNghi, s.BaoHiem, s.LuongTotal }).ToList();

            return salary;
        }
    }
}
