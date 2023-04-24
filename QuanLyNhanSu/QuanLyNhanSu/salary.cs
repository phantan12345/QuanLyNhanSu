using QuanLyNhanSu.BUS_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class salary : Form
    {
        BUS_Luong busluong;
        public salary()
        {
            InitializeComponent();
            busluong = new BUS_Luong();
        }
        private void HienThiDSNV()
        {
            gvLuong.DataSource = null;
            busluong.LayDSL(gvLuong);

        }
        
        String total;
        private void gvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //busluong.TimL();
            txtMa.Text=gvLuong.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txtThang.Text = gvLuong.Rows[e.RowIndex].Cells["Thang"].Value.ToString();
            txtNam.Text= gvLuong.Rows[e.RowIndex].Cells["Nam"].Value.ToString();
            total= gvLuong.Rows[e.RowIndex].Cells["LuongTotal"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int d = int.Parse(txtThang.Text);
            int h = int.Parse(txtNam.Text);

            if (busluong.TinhLuong(txtMa.Text, d, h))
            {
                MessageBox.Show("Thực hiện thành công");
            }
            else return;
            //Tạo bảo hiểm

            BangLuong bl = busluong.LayBL(txtMa.Text, d, h);
            BaoHiem bh = new BaoHiem();
            bh.MaBH= Guid.NewGuid().ToString().Substring(0, 10);
            bh.MaNV = txtMa.Text;
            bh.TiLe = 10;
            bh.ThangDong = d;
            bh.NamDong = h;
            bh.TienBH = bl.BaoHiem.ToString();
            busluong.TaoBH(bh);
            HienThiDSNV();
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            busluong.loadTxtLuongCu(txtLuongCu, cbMaNV.SelectedItem.ToString());
        }
        private void txtTim_Click(object sender, EventArgs e)
        {
            busluong.TimL(gvLuong, txtMa.Text, txtThang.Text, txtNam.Text);
        }
        private void HienThicbMaNV()
        {
            cbMaNV.DataSource = busluong.LayDSMaNV();
        }
        private void FormLoad(object sender, EventArgs e)
        {
            HienThiDSNV();
            HienThicbMaNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TangLuong tl=new TangLuong();
            tl.MaPhieu= Guid.NewGuid().ToString().Substring(0, 10);
            tl.MaNV= cbMaNV.SelectedItem.ToString();
            try { tl.LCB = int.Parse(txtLuongCu.Text); 
            }catch(Exception e)
            {
                tl.LCB = 0;
            }
            tl.LCBMoi = int.Parse(txtLuongMoi.Text);
            tl.GhiChu = txtLiDo.Text;
            tl.NgaySua = DateTime.Now;
            busluong.ThemTangLuong(tl);
            busluong.HienThiDSTangLuong(gvTangLuong,tl.MaNV);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            busluong.HienThiDSTangLuong(gvTangLuong, cbMaNV.SelectedItem.ToString());
        }
    }
}