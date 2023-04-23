
using QuanLyNhanSu.DAO;
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
using QuanLyNhanSu;
using System.Xml.Linq;

namespace GUI
{
   
    public partial class TtcnUser : Form
    {

        BUS_NhanVienUser user;
        public TtcnUser()
        {
            InitializeComponent();
            user = new BUS_NhanVienUser();
        }

        public TtcnUser(NhanVien nv) : this()
        {
            user.getUser(lb_user, lb_name, lb_email, lb_manv, lb_ngaysinh, lb_cccd, lb_sdt, lb_pb, lb_cv, lb_hopdong, pb_imgnv, nv.MaNV);
            


        }


        private void TTCN_Load(object sender, EventArgs e)
        {
            user.getUser(lb_user, lb_name, lb_email, lb_manv, lb_ngaysinh, lb_cccd, lb_sdt, lb_pb, lb_cv, lb_hopdong, pb_imgnv, "");
            
        }

        private void lb_pb_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Enter(object sender, EventArgs e)
        {

        }
    }
}
