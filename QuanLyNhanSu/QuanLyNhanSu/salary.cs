using QuanLyNhanSu.BUS;
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
        BUS_Luong dsLuong;
        public salary()
        {
            InitializeComponent();
            dsLuong= new BUS_Luong();
        }

        private void salary_Load(object sender, EventArgs e)
        {
            dg_luong.DataSource = null;
            dsLuong.getLuong(dg_luong);
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.gr_luong.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BangLuong b=new BangLuong();
            b.MaLuong=txt_maluong.Text;
            b.LCB = double.Parse(txt_lcb.Text);
            //b.PCPhongBan = txt_phongban.Text;
            if (dsLuong.addLuong(b))
            {
                MessageBox.Show("ko them vao duoc","thong bao",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("ko them vao duoc", "thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


            }

        }
    }
}
