using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.DAO
{

    internal class DAO_PhongBan
    {
        NhanSuEntities dbo;
        public DAO_PhongBan() { 
        dbo=new NhanSuEntities();                       
       }
        public dynamic getPhongBan()
        {
            var ds = dbo.PhongBan.Select(s => new
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
            dbo.PhongBan.Add(p);
            dbo.SaveChanges();
        }


        public List<NhanVien> getListNV(string ma)
        {
           
            
            return dbo.NhanVien.Where(s => s.MaPhong.Contains(ma)).ToList(); ;

        }


        public void deletePhongBan(string ma)
        {
           
           
            PhongBan p = dbo.PhongBan.Find(ma);
            dbo.PhongBan.Remove(p);
            dbo.SaveChanges();
          
        }


        public void updatePhongBan(PhongBan pb)
        {

            PhongBan p = dbo.PhongBan.Find(pb.MaPhongBan);
            p.TenPhongBan=pb.TenPhongBan;
            p.NgayThanhLap=pb.NgayThanhLap;
            p.GhiChu=pb.GhiChu;
            
            dbo.SaveChanges();

        }
        public bool checkPhongBan(string ma)
        {
            PhongBan p = dbo.PhongBan.Find(ma);
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
            PhongBan p = dbo.PhongBan.Find(ma);
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
