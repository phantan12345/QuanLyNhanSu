using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.BUS
{
    public class BUS_SalaryUser
    {
        DAO_SalaryUser salaryUser;
        public BUS_SalaryUser()
        {
            salaryUser = new DAO_SalaryUser();
        }

        public void getSalary(DataGridView dg, string manv)
        {
            dg.DataSource = salaryUser.getDsSalary(manv);
            
        }

        public void searchSalary(DataGridView dg, string manv, int t, int n)
        {
            if(n != 0 && t != 0)
            {
                dg.DataSource = salaryUser.searchSalary(manv, t, n);

                
            }
            else if (n != 0)
            {
                dg.DataSource = salaryUser.searchSalaryY(manv, n);
            }
            else if (t != 0) 
            {
                dg.DataSource = salaryUser.searchSalaryM(manv, t);
            }    
            else
            {
                dg.DataSource = salaryUser.getDsSalary(manv);
            }
           
        }
    }
}
