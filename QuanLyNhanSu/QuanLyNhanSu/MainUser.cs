
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu;
using QuanLyNhanSu.BUS;

namespace GUI
{
    public partial class MainUser : Form
    {

        BUS_NhanVienUser nv1;
        NhanVien nhanVien;
        public MainUser()
        {
            InitializeComponent();
            nv1 = new BUS_NhanVienUser();

        }

        public MainUser(string username) :this() 
        {
            
            nv1 = new BUS_NhanVienUser();
            nhanVien = nv1.getNv(username);

        }


        private Form curentFormChild;

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }


        //public MainUser(NhanVien nv) : this()
        //{



        //    _nv = nvBLL.nhanVienBLL(nv.username);

        //    OpenChildForm(new TTCN(_nv));

        //}


      
        

        
        
        private void MainUser_Load(object sender, EventArgs e)
        {
           
            
            nv1.getUser(lb_user, lb_name, lb_email, lb_manv, lb_ngaysinh, lb_cccd, lb_sdt, lb_pb, lb_cv, lb_hopdong, pb_imgnv, nhanVien.MaNV);
        }

        private void OpenChildForm(Form childForm)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        

        private void btn_ttcn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TtcnUser(nhanVien));
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalaryUser(nhanVien));
        }

        private void btn_baohiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InsuranceUser(nhanVien));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DepartmentUser(nhanVien));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateSalaryUser(nhanVien));
        }

        private void btn_exit_Enter(object sender, EventArgs e)
        {

        }
    }
}
