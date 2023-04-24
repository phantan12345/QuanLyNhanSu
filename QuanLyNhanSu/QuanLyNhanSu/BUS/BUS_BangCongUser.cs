using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS
{
    internal class BUS_BangCongUser
    {
        DAO_BangCongUser bangCongUser;
        public BUS_BangCongUser()
        {
            bangCongUser = new DAO_BangCongUser();
        }

        public void getBangCong(DataGridView dg, string manv)
        {
            dg.DataSource = bangCongUser.getDsBangCong(manv);

        }

        public void searchBangCong(DataGridView dg, string manv, int t, int n)
        {
            if (n != 0 && t != 0)
            {
                dg.DataSource = bangCongUser.searchBangCong(manv, t, n);


            }
            else if (n != 0)
            {
                dg.DataSource = bangCongUser.searchInsuranceY(manv, n);
            }
            else if (t != 0)
            {
                dg.DataSource = bangCongUser.searchBangCongM(manv, t);
            }
            else
            {
                dg.DataSource = bangCongUser.getDsBangCong(manv);
            }
        }

        public bool addBangCong(BangCong c)
        {

            return bangCongUser.addBangCong(c);
        }
    }
}
