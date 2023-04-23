using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{

    
    public class DAO_LoginUser
    {
        NhanSuEntities1 dbo;
        public DAO_LoginUser ()
        {
            dbo =new NhanSuEntities1 ();
        }

        public bool Login(string username, string password, bool? role)
        {
            var result = dbo.proc_logic(username, password, role).FirstOrDefault();

            // xử lý kết quả đăng nhập ở đây, ví dụ:
            if (result != null)
            {
                return true;
            }

            return false;
        }


    }


}
