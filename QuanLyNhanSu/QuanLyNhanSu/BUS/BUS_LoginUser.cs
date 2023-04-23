using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.BUS
{
    public class BUS_LoginUser
    {
        DAO_LoginUser loginUser;

        public BUS_LoginUser ()
        {
            loginUser = new DAO_LoginUser ();
        }

        public bool checkLogin (string username, string password, bool role)
        {
            return loginUser.Login(username, password, role);
        }
    }
}
