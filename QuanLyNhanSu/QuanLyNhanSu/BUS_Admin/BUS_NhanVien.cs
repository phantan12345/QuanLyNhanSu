using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO_ADMIN;
namespace QuanLyNhanSu.BUS_Admin
{
    internal class BUS_NhanVien
    {
        DAO_NhanVien dNhanVien;

        public BUS_NhanVien()
        {
            dNhanVien = new DAO_NhanVien();
        }
        public void LayDSPB(ComboBox com)
        {
            com.DataSource = dNhanVien.LayDSPB();
        }
        public String TenPB(String ma)
        {
            return dNhanVien.LayTenPB(ma);
        }
        public void LayDSNV(DataGridView dg)
        {
            dg.DataSource = dNhanVien.LayDSNV();
        }
        public Boolean ThemNV(NhanVien nv)
        {
            try
            {
                dNhanVien.ThemNV(nv);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean KiemTraNV(String CCCD)
        {
            if (dNhanVien.KiemTraNV(CCCD))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Nhan vien không tồn tại");
                return false;
            }
        }
        public Boolean SuaNV(NhanVien nv)
        {
            try
            {
                dNhanVien.SuaNV(nv);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa không thành công");

            }
            return false;
        }
        public NhanVien LayNV(String CCCD)
        {
            return dNhanVien.LayNV(CCCD);
        }
        public Boolean XoaNV(String CCCD)
        {
            try
            {
                dNhanVien.XoaNV(dNhanVien.LayNV(CCCD));
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
            return false;
        }
    }
}