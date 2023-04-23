using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.BUS
{
    internal class BUS_Luong
    {
        DAO_Luong dsLuong;
        public BUS_Luong()
        {
            dsLuong = new DAO_Luong();
        }
        public void getLuong(DataGridView dg)
        {
            dg.DataSource = dsLuong.getLuong();

        }
        public bool addLuong(BangLuong bl)
        {
            try
            {
                dsLuong.addLuong(bl);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}
