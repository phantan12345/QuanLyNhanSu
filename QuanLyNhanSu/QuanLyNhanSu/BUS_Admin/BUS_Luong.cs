using QuanLyNhanSu.DAO_ADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS_Admin
{

    internal class BUS_Luong
    {
        DAO_Luong dLuong;

        public BUS_Luong()
        {
            dLuong = new DAO_Luong();
        }
        public void LayDSL(DataGridView dg)
        {
            dg.DataSource = dLuong.LayDSBL();
        }
        public void TimL(DataGridView dg, String ma, String thang, String nam)
        {
            if (thang == "" && nam == "")
            {
                dg.DataSource = dLuong.TimDSBL(ma);
                return;
            }
            if (thang == "" && ma=="")
            {
                dg.DataSource = dLuong.TimDSBL(ma,int.Parse(nam));
                return;
            }
            if (nam == ""&& ma=="")
            {
                dg.DataSource = dLuong.TimDSBL(int.Parse(thang));
                return;
            }
            if (thang == "")
            {
                dg.DataSource = dLuong.TimDSBL(ma,0, int.Parse(nam));
                return;
            }
            if (nam == "")
            {
                dg.DataSource = dLuong.TimDSBL(ma,int.Parse(thang),0);
                return;
            }
            if(ma=="")
            {
                dg.DataSource = dLuong.TimDSBL(ma, int.Parse(thang), int.Parse(nam));
            }
            dg.DataSource = dLuong.TimDSBL(ma, int.Parse(thang), int.Parse(nam));
        }

        public BangLuong LayBL(String ma,int thang,int nam)
        {
            return dLuong.LayBL(ma, thang, nam);
        }
        public NhanVien LayNV(String ma)
        {
            return dLuong.LayNV(ma);
        }

        public Boolean TinhLuong(String ma,int thang,int nam)
        {
            if (LayBL(ma, thang, nam) != null)
            {
                MessageBox.Show("Đã tính lương cho" + ma);
                return false;
            }
            try 
            {
                dLuong.TinhLuong(ma, thang, nam);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hệ thống lỗi");
                return false;
            }
            return true;
        }

        public void TaoBH(BaoHiem bh)
        {
            dLuong.TaoBH(bh);
        }

        public List<string> LayDSMaNV()
        {
            return dLuong.LayDSMaNV();
        }
        public void loadTxtLuongCu(TextBox lc,String ma)
        {
            lc.Text =dLuong.LayNV(ma).LCB.ToString();
        }
        public void ThemTangLuong(TangLuong tl)
        {
            dLuong.ThemTangLuong(tl);
        }
        public void HienThiDSTangLuong(DataGridView dg,String ma)
        {
            dg.DataSource = dLuong.LayDSTangLuong(ma);
        }
    }
        
}