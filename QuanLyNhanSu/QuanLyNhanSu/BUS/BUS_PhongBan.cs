using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS
{
    internal class BUS_PhongBan
    {
        DAO_PhongBan ds;

        public BUS_PhongBan()
        {
            ds = new DAO_PhongBan();
        }

        public void getPhongBan(DataGridView dg)
        {
            dg.DataSource = ds.getPhongBan();
        }
        public void addPhongBan(PhongBan p)
        {
            try
            {
                ds.addPhongban(p);
                MessageBox.Show("Đã Thêm Vào Database", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            } catch
            {
                MessageBox.Show("Không Thêm Vào Database", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        public bool deletePhongBan(string ma)
        {
            if (ds.checkPhongBan(ma))
            {
                try
                {
                    foreach (NhanVien s in ds.getListNV(ma))
                    {
                        s.MaPhong = null;
                    }
                    ds.deletePhongBan(ma);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("ko");
                    return false;
                }
            }
            else
            {
                return false;
            }
            
           
        }

        public PhongBan check(string ma)
        {
            PhongBan p=ds.checkPhongBanByoj(ma);
            return p;
        }

        public bool updatePhongBan(PhongBan p)
        {
            if (ds.checkPhongBan(p.MaPhongBan))
            {
                try
                {
                    ds.updatePhongBan(p);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }


        }
    }
}
