using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyNhanSu.BUS
{
    public class BUS_NhanVienUser
    {
        DAO_NhanVienUser nv;
        public BUS_NhanVienUser() 
        { 
            nv = new DAO_NhanVienUser();
        }

        public void getUser(Label tk, Label name, Label email, Label maNv, Label ns, Label cccd, Label sdt, Label pb, Label cv, Label hd, PictureBox p, string manv)
        {
            var user = nv.getUser(manv);
            
            if (user != null)
            {
                tk.Text = "Tài khoản: " + user.username;
                name.Text = "Họ tên: " + user.HoTen;
                email.Text = "Email: " + user.email;
                maNv.Text = "Mã NV:: " + user.MaNV;
                ns.Text = "Ngày sinh: " + user.NgaySinh?.ToString("dd/MM/yyyy");
                cccd.Text = "CCCD: " + user.CCCD;
                sdt.Text = "SĐT: " + user.SoDienThoai;
                //pb.Text = "Phòng ban: " + user.TenPhongBan;
                cv.Text = "Chức vụ: " + user.ChucVu;
                hd.Text = "Hợp đồng: " + user.NgayKy?.ToString("dd/MM/yyyy");
                if (user.GioiTinh)
                {
                    p.Image = Image.FromFile(Application.StartupPath + @"\female.png");
                }
                else
                {
                    p.Image = Image.FromFile(Application.StartupPath + @"\male.png");
                }
            }
            else
            {

                MessageBox.Show(user);
            }

        }

        public void getUser2 (Label ma, Label name, Label cv, Label pb, string manv)
        {
            var user = nv.getUser(manv);
            if (user != null)
            {
               
                name.Text = "Họ tên: " + user.HoTen;
                //pb.Text = "Phòng ban: " + user.TenPhongBan;
                cv.Text = "Chức vụ: " + user.ChucVu;
                ma.Text = user.MaNV;
            }
        }

        public NhanVien getNv (string username)
        {
            return nv.getNv(username);
        }
    }
}
