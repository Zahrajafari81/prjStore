using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALprjStore;

namespace BLprjStore
{
    public class blLogin
    {
        
        ClassLogin objLogin = new ClassLogin();
        public DataTable Login(object username, object password)
        {
            DataTable dt = new DataTable();
            dt=objLogin.Login(username, password);
            return dt;
        }
        public DataTable Gender(object userName)
        {
            DataTable dt = new DataTable();
            dt = objLogin.Gender(userName);
            return dt;
        }
    }
}
