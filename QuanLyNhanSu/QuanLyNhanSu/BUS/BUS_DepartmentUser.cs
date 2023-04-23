using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS
{
    public class BUS_DepartmentUser
    {
        DAO_DepartmentUser departmentUser;
        public BUS_DepartmentUser()
        {
            departmentUser = new DAO_DepartmentUser();
        }

        public void getEmployee(DataGridView dg, string vt)
        {
            dg.DataSource = departmentUser.getDsEmployee(vt);

        }

        //public void searchSalary(DataGridView dg, string manv, int t, int n)
        //{
        //    if (n != 0 && t != 0)
        //    {
        //        dg.DataSource = salaryUser.searchSalary(manv, t, n);


        //    }
        //    else if (n != 0)
        //    {
        //        dg.DataSource = salaryUser.searchSalaryY(manv, n);
        //    }
        //    else if (t != 0)
        //    {
        //        dg.DataSource = salaryUser.searchSalaryM(manv, t);
        //    }
        //    else
        //    {
        //        dg.DataSource = salaryUser.getDsSalary(manv);
        //    }

        //}


    }
}
