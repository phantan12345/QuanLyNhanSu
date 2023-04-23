using QuanLyNhanSu.DAO_ADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS_Admin
{

    internal class BUS_Luong
    {
        DAO_Luong dLuong;

        public BUS_Luong()
        {
            dLuong = new DAO_Luong();
        }
        public void LayDSL(DataGridView dg)
        {
            dg.DataSource = dLuong.LayDSBL();
        }
        public void TimL(DataGridView dg, String ma, String thang, String nam)
        {
            if (thang == "" && nam == "")
            {
                dg.DataSource = dLuong.TimDSBL(ma);
            }
            else
             if (thang == "")
            {
                dg.DataSource = dLuong.TimDSBL(ma, 0, int.Parse(nam));
            }
            else if (nam == "")
            {
                dg.DataSource = dLuong.TimDSBL(ma, int.Parse(thang), 0);
            }
            else if (ma == "" && thang == "")
            {
                dg.DataSource = dLuong.TimDSBL(ma, int.Parse(nam));
            }
            else if (ma == "" && nam == "")
            {
                dg.DataSource = dLuong.TimDSBL(int.Parse(thang));
            }
            else
            {
                dg.DataSource = dLuong.TimDSBL(ma, int.Parse(thang), int.Parse(nam));
            }
        }

    }
}