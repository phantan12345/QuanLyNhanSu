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
    public partial class Employee : Form
    {
        BUS_NhanVien busNhanVien;
        public Employee()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }

        private void HienThi()
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nu");
            cbGioiTinh.DisplayMember = "Nam";
            cbGioiTinh.ValueMember = "Nam";
        }
        private void HienThiDSPB()
        {
            cbPhongBan.DataSource = null;
            busNhanVien.LayDSPB(cbPhongBan);
            cbPhongBan.DisplayMember = "TenPhongBan";
            cbPhongBan.ValueMember = "MaPhongBan";
        }
        private void HienThiDSNV()
        {
            gvNhanVien.DataSource = null;
            busNhanVien.LayDSNV(gvNhanVien);

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = Guid.NewGuid().ToString().Substring(0, 10);
            nv.HoTen = txtTen.Text;
            nv.NgaySinh = tpNgaySinh.Value;
            //nv.NoiSinh = txtNoiSinh.Text;
            nv.email = txtEmail.Text;
            nv.CCCD = txtCCCD.Text;
            nv.ChucVu = txtChucVu.Text;
            nv.SoDienThoai = txtSDT.Text;
            //nv.HocVan = txtHocVan.Text;
            //nv.GioiTinh = cbGioiTinh.SelectedItem.ToString();
            nv.MaBoPhan = cbPhongBan.SelectedValue.ToString();
            if (busNhanVien.ThemNV(nv))
            {
                MessageBox.Show("Thêm thành công");
                busNhanVien.LayDSNV(gvNhanVien);
                clear();
            }
            else
                MessageBox.Show("Thêm không thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = Guid.NewGuid().ToString().Substring(0, 10);
            nv.HoTen = txtTen.Text;
            nv.NgaySinh = tpNgaySinh.Value;
            //nv.NoiSinh = txtNoiSinh.Text;
            nv.email = txtEmail.Text;
            nv.CCCD = txtCCCD.Text;
            nv.ChucVu = txtChucVu.Text;
            nv.SoDienThoai = txtSDT.Text;
            //nv.HocVan = txtHocVan.Text;
            //nv.GioiTinh = cbGioiTinh.SelectedItem.ToString();
            nv.MaPhong = cbPhongBan.SelectedValue.ToString();

            if (busNhanVien.KiemTraNV(txtCCCD.Text) && busNhanVien.SuaNV(nv))
            {
                busNhanVien.LayDSNV(gvNhanVien);
                MessageBox.Show("Sửa thành công");
                clear();
            }
        }
        private void FormLoad(object sender, EventArgs e)
        {
            HienThiDSNV();
            HienThiDSPB();
            HienThi();
        }

        private void gvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String c = gvNhanVien.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
            c = c.Replace(" ", "");
            if (e.RowIndex >= 0 && e.RowIndex < gvNhanVien.Rows.Count &&
                busNhanVien.KiemTraNV(c))
            {
                NhanVien nv = busNhanVien.LayNV(c);
                txtTen.Text = nv.HoTen;
                tpNgaySinh.Value = Convert.ToDateTime(nv.NgaySinh);
                txtSDT.Text = nv.SoDienThoai;
                txtChucVu.Text = nv.ChucVu;
                txtEmail.Text = nv.email;
                txtCCCD.Text = nv.CCCD;
                //txtNoiSinh.Text = nv.NoiSinh;
                //txtHocVan.Text = nv.HocVan;
                //int index = cbGioiTinh.FindStringExact(nv.GioiTinh);
                //cbGioiTinh.SelectedIndex = index;
                //if (nv.MaPhong != null)
                //{
                //    String name = busNhanVien.TenPB(nv.MaPhong);
                //    int indexs = cbPhongBan.FindStringExact(name);
                //    cbPhongBan.SelectedIndex = indexs;
                //}
            }
        }
        private void clear()
        {
            txtTen.Text = "";
            txtCCCD.Text = "";
            txtChucVu.Text = "";
            txtEmail.Text = "";
            txtHocVan.Text = "";
            txtNoiSinh.Text = "";
            txtSDT.Text = "";
            tpNgaySinh.ResetText();
            cbGioiTinh.SelectedIndex = 0;

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busNhanVien.KiemTraNV(txtCCCD.Text)
                && busNhanVien.XoaNV(txtCCCD.Text))
            {
                busNhanVien.LayDSNV(gvNhanVien);
                MessageBox.Show("Xóa thành công");
                clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}