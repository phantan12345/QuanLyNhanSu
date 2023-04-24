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
        BUS_TangLuong ds;
        public salary()
        {
            InitializeComponent();
            busluong = new BUS_Luong();
            ds= new BUS_TangLuong();
        }

        public void loadLuong()
        {
            gvLuong.DataSource = null;
            busluong.LayDSL(gvLuong);
            gvLuong.Columns[0].Width = (int)(gvLuong.Width * 0.08);
            gvLuong.Columns[1].Width = (int)(gvLuong.Width * 0.12);
            gvLuong.Columns[2].Width = (int)(gvLuong.Width * 0.1);
            gvLuong.Columns[3].Width = (int)(gvLuong.Width * 0.08);
            gvLuong.Columns[4].Width = (int)(gvLuong.Width * 0.12);
            gvLuong.Columns[5].Width = (int)(gvLuong.Width * 0.2);
            gvLuong.Columns[6].Width = (int)(gvLuong.Width * 0.3);
        }

        public void loadTangLuong()
        {
            dg_tangluong.DataSource = null;
            ds.getTangLuong(dg_tangluong);

            cb_maNv.DataSource = null;
            ds.getTangLuongcb(cb_maNv);
            //cb_maNv.DisplayMember = "TenPhongBan";
            cb_maNv.ValueMember = "MaNV";

            dg_tangluong.Columns[0].Width = (int)(dg_tangluong.Width * 0.08);
            dg_tangluong.Columns[1].Width = (int)(dg_tangluong.Width * 0.22);
            dg_tangluong.Columns[2].Width = (int)(dg_tangluong.Width * 0.1);
            dg_tangluong.Columns[3].Width = (int)(dg_tangluong.Width * 0.08);
            dg_tangluong.Columns[4].Width = (int)(dg_tangluong.Width * 0.22);
            dg_tangluong.Columns[5].Width = (int)(dg_tangluong.Width * 0.3);
        }
        private void HienThiDSNV()
        {
            loadLuong();
            loadTangLuong();

        }
        private void FormLoad(object sender, EventArgs e)
        {
            HienThiDSNV();
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            busluong.TimL(gvLuong, txtMa.Text, txtThang.Text, txtNam.Text);
        }
    }
}