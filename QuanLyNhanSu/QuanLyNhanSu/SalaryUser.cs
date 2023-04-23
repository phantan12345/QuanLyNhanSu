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
    public partial class SalaryUser : Form
    {

        BUS_SalaryUser salaryUser;
        BUS_NhanVienUser nhanVienUser;
        public SalaryUser()
        {
            InitializeComponent();
            salaryUser = new BUS_SalaryUser();
            nhanVienUser = new BUS_NhanVienUser();
        }

        public SalaryUser(NhanVien nv): this()
        {
            dGSalary.DataSource = null;
            salaryUser.getSalary(dGSalary, nv.MaNV);
            //dGSalary.Columns[0].Name = "Mã Nhân Viên";
            //dGSalary.Columns[1].Name = "Tháng";
            //dGSalary.Columns[2].Name = "Năm";
            //dGSalary.Columns[3].Name = "Lương cơ bản";
            //dGSalary.Columns[4].Name = "Phụ cấp";
            //dGSalary.Columns[5].Name = "Thưởng";
            //dGSalary.Columns[6].Name = "Kỷ luật";
            //dGSalary.Columns[7].Name = "Vắng";
            //dGSalary.Columns[8].Name = "Bảo hiểm";
            //dGSalary.Columns[9].Name = "Thực lãnh";
            //dGSalary.Columns[0].Width = (int)(dGSalary.Width * 0.1);
            //dGSalary.Columns[01].Width = (int)(dGSalary.Width * 0.1);
            //dGSalary.Columns[02].Width = (int)(dGSalary.Width * 0.1);
            //dGSalary.Columns[03].Width = (int)(dGSalary.Width * 0.1);
            //dGSalary.Columns[04].Width = (int)(dGSalary.Width * 0.1);
            //dGSalary.Columns[05].Width = (int)(dGSalary.Width * 0.1);
            //dGSalary.Columns[06].Width = (int)(dGSalary.Width * 0.1);
            //dGSalary.Columns[07].Width = (int)(dGSalary.Width * 0.1);
            //dGSalary.Columns[08].Width = (int)(dGSalary.Width * 0.1);
            //dGSalary.Columns[09].Width = (int)(dGSalary.Width * 0.1);
            nhanVienUser.getUser2(lbMaNv, lbName, lbChucVu, lbPhongBan, nv.MaNV);
        }
        
        private void SalaryUser_Load(object sender, EventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            

        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            dGSalary.DataSource = null;
            if( txtNam.Text == "")
            {
                txtNam.Text = "0";
            }
            if (txtThang.Text == "")
            {
                txtThang.Text = "0";
            }

            salaryUser.searchSalary(dGSalary, lbMaNv.Text, Int32.Parse(txtThang.Text), Int32.Parse(txtNam.Text));
            txtNam.Text = "";
            txtThang.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
