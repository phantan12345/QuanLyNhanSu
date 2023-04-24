using QuanLyNhanSu.DAO_ADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS_Admin
{
    internal class BUS_CheDo
    {
        DAO_CheDo ds;
        public BUS_CheDo()
        {
            ds = new DAO_CheDo();
        }
        public void getCheDo(DataGridView dg)
        {
            dg.DataSource=ds.getCheDo();
        }
    }
}
