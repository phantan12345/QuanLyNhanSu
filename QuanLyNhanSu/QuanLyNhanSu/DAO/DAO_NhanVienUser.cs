using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyNhanSu.DAO
{
    
    public class DAO_NhanVienUser
    {
        NhanSuEntities1 dbo;
        public DAO_NhanVienUser ()
        {
            dbo = new NhanSuEntities1 ();
        }

        public dynamic getUser(string id)
        {
            var user = dbo.NhanViens
                .Join(dbo.PhongBans,
                      nv => nv.MaPhong,
                      pb => pb.MaPhongBan,
                      (nv, pb) => new
                      {
                          nv.MaNV,
                          nv.username,
                          nv.HoTen,
                          nv.email,
                          nv.NgaySinh,
                          nv.CCCD,
                          nv.SoDienThoai,
                          pb.TenPhongBan,
                          nv.ChucVu,
                          nv.NgayKy,
                          nv.GioiTinh
                      }
                      ).Where(s => s.MaNV == id).ToList();

            var firstUser = user.FirstOrDefault();
            return firstUser;
        }

        public NhanVien getNv (string username)
        {

            return dbo.NhanViens.SingleOrDefault(nv => nv.username == username);

        }

        
    }
}
