using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS
{
    public class BUS_InsuranceUser
    {
        DAO_InsuranceUser insuranceUser;
        public BUS_InsuranceUser()
        {
            insuranceUser = new DAO_InsuranceUser();
        }

        public void getInsurance(DataGridView dg, string manv)
        {
            dg.DataSource = insuranceUser.getDsInsurance(manv);

        }

        public void searchInsurance(DataGridView dg, string manv, int t, int n)
        {
            if (n != 0 && t != 0)
            {
                dg.DataSource = insuranceUser.searchInsurance(manv, t, n);


            }
            else if (n != 0)
            {
                dg.DataSource = insuranceUser.searchInsuranceY(manv, n);
            }
            else if (t != 0)
            {
                dg.DataSource = insuranceUser.searchInsuranceM(manv, t);
            }
            else
            {
                dg.DataSource = insuranceUser.getDsInsurance(manv);
            }

        }

    }
}
