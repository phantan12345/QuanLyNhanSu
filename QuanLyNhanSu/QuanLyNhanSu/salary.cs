using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.BUS;

namespace QuanLyNhanSu
{
    public partial class salary : Form
    {
        BUS_Luong luong;
        public salary()
        {
            InitializeComponent();
            luong = new BUS_Luong();

        }

       

        private void panel_ThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salary_Load(object sender, EventArgs e)
        {
            dGLuong.DataSource = null;
            luong.getLuong(dGLuong);
        }
    }
}
