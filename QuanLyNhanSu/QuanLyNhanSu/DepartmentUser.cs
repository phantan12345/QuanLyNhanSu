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
    public partial class DepartmentUser : Form
    {

        BUS_DepartmentUser departmentUser;
        BUS_NhanVienUser nhanVienUser;
        public DepartmentUser()
        {
            InitializeComponent();
            departmentUser = new BUS_DepartmentUser();
            nhanVienUser    = new BUS_NhanVienUser();
        }

        private void DepartmentUser_Load(object sender, EventArgs e)
        {

        }

        public DepartmentUser(NhanVien nv) : this()
        {
            dGDepartment.DataSource = null;
            departmentUser.getEmployee(dGDepartment, nv.MaPhong);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
