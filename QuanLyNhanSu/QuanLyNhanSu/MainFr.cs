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
    public partial class MainFr : Form
    {
        public MainFr()
        {
            InitializeComponent();
            btn_ttcn_Click();
        }

        private void btn_ttcn_Click()
        {
            Employee em = new Employee();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            em.TopLevel = false;
            em.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(em);
            em.Show();
        }
        private void btn_ttcn_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            em.TopLevel = false;
            em.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(em);
            em.Show();
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            salary sa = new salary();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            sa.TopLevel = false;
            sa.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(sa);
            sa.Show();
        }



        private void btn_chedo_Click(object sender, EventArgs e)
        {
            regime re = new regime();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            re.TopLevel = false;
            re.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(re);
            re.Show();
        }

        private void btn_phongban_Click(object sender, EventArgs e)
        {

            Department de = new Department();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            de.TopLevel = false;
            de.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(de);
            de.Show();
        }
    }
}
