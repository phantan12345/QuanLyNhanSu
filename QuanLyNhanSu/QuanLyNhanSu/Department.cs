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
    public partial class Department : Form
    {
        BUS_PhongBan ds;
        public Department()
        {
            InitializeComponent();
            ds = new BUS_PhongBan();
        }

        public void load()
        {
            dg_phongban.DataSource = null;
            ds.getPhongBan(dg_phongban);
        }



        private void Department_Load(object sender, EventArgs e)
        {
            dg_phongban.DataSource = null;
            ds.getPhongBan(dg_phongban);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PhongBan p = new PhongBan();
            p.MaPhongBan = txt_maphongban.Text;
            p.TenPhongBan = txt_tenphongban.Text;
            p.GhiChu = txt_ghichu.Text;
            p.NgayThanhLap = Convert.ToDateTime(dt_ngaythanhlap.Value.ToString());


            ds.addPhongBan(p);
            load();
        }



        private void btn_delete_Click_1(object sender, EventArgs e)
        {

            if (this.dg_phongban.SelectedRows.Count == 0)
            {
                int index = dg_phongban.CurrentCell.RowIndex;
                string ma = dg_phongban.Rows[index].Cells[0].Value.ToString();
                ma = ma.Trim();

                if (ds.deletePhongBan(ma))
                {
                    load();
                }
            }
            else
            {
                MessageBox.Show("Xoa khong thanh cong");
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (this.dg_phongban.SelectedRows.Count == 0)
            {


                int index = dg_phongban.CurrentCell.RowIndex;
                string ma = dg_phongban.Rows[index].Cells[0].Value.ToString();
                ma = ma.Trim();
                PhongBan p = ds.check(ma);

                p.TenPhongBan = txt_tenphongban.Text;
                p.GhiChu = txt_ghichu.Text;
                p.NgayThanhLap = Convert.ToDateTime(dt_ngaythanhlap.Value.ToString());

                if (ds.updatePhongBan(p))
                {
                    load();
                }
            }
            else
            {
                MessageBox.Show("cap nhat khong thanh cong");
            }

        }

        private void dg_phongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dg_phongban.CurrentCell.RowIndex;
            txt_tenphongban.Text = dg_phongban.Rows[index].Cells[1].Value.ToString(); ;
            dt_ngaythanhlap.Value = Convert.ToDateTime(dg_phongban.Rows[index].Cells[2].Value.ToString());
            txt_ghichu.Text = dg_phongban.Rows[index].Cells[3].Value.ToString(); ;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.gb_De.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }
    }

}
