using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS
{
    public class BUS_UpdateSalary
    {
        DAO_UpdateSalary updateSalary;
        public BUS_UpdateSalary() 
        { 
            updateSalary = new DAO_UpdateSalary();
        }

        public void getUpdateSalary(DataGridView dg, string manv)
        {
            dg.DataSource = updateSalary.getUpdateSalary(manv);

        }
    }
}
