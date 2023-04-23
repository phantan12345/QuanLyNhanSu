using GUI;
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
    public partial class LoginUser : Form
    {
        BUS_LoginUser loginUser;
        public LoginUser()
        {
            InitializeComponent();
            loginUser = new BUS_LoginUser();
        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            if (loginUser.checkLogin(txtTaiKhoan.Text, txtMatKhau.Text, true))
            {
                MainUser mainUser = new MainUser(txtTaiKhoan.Text);
                mainUser.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            if (loginUser.checkLogin(txtTaiKhoan.Text, txtMatKhau.Text, false))
            {
                MainUser mainUser = new MainUser(txtTaiKhoan.Text);
                mainUser.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
        }
    }
}
