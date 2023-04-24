using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO_ADMIN;

namespace QuanLyNhanSu.BUS_Admin
{
    internal class BUS_TangLuong
    {
        DAO_TangLuong ds;
        public BUS_TangLuong()
        {
            ds=new DAO_TangLuong();
        }
        public void getTangLuong(DataGridView dg)
        {
            dg.DataSource= ds.getTangLuong();
        }

        public void getTangLuongcb(ComboBox cb)
        {
            cb.DataSource = ds.getTangLuongcb();
        }
    }
}
