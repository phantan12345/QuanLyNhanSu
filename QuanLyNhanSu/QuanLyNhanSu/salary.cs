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