using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO_ADMIN
{
    public class DAO_PhongBan
    {
        NhanSuEntities1 dbo;
        public DAO_PhongBan()
        {
            dbo = new NhanSuEntities1();
        }
        public dynamic getPhongBan()
        {
            var ds = dbo.PhongBans.Select(s => new
            {
                s.MaPhongBan,
                s.TenPhongBan,
                s.NgayThanhLap,
                s.GhiChu

            }).ToList();
            return ds;
        }
        public void addPhongban(PhongBan p)
        {
            dbo.PhongBans.Add(p);
            dbo.SaveChanges();
        }


        public List<NhanVien> getListNV(string ma)
        {


            return dbo.NhanViens.Where(s => s.MaPhong.Contains(ma)).ToList(); ;

        }


        public void deletePhongBan(string ma)
        {


            PhongBan p = dbo.PhongBans.Find(ma);
            dbo.PhongBans.Remove(p);
            dbo.SaveChanges();

        }


        public void updatePhongBan(PhongBan pb)
        {

            PhongBan p = dbo.PhongBans.Find(pb.MaPhongBan);
            p.TenPhongBan = pb.TenPhongBan;
            p.NgayThanhLap = pb.NgayThanhLap;
            p.GhiChu = pb.GhiChu;

            dbo.SaveChanges();

        }
        public bool checkPhongBan(string ma)
        {
            PhongBan p = dbo.PhongBans.Find(ma);
            if (p != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public PhongBan checkPhongBanByoj(string ma)
        {
            PhongBan p = dbo.PhongBans.Find(ma);
            if (p != null)
            {
                return p;
            }
            else
            {
                return null;
            }
        }
    }
}
