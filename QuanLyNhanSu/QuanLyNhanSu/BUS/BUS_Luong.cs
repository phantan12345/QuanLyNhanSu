using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.BUS
{
    public class BUS_Luong
    {
        DAO_Luong luong;
        public BUS_Luong ()
        {
            luong = new DAO_Luong ();
        }

        public void getLuong(DataGridView dg)
        {
            dg.DataSource = luong.getLuong();

        }

    }
}
