using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALprjStore;
using System.Data;

namespace BLPrjSturee
{
    public class BLNewUser
    {
        ClassNewUser objClassNewUser = new ClassNewUser();

        public void insert(object username, object password, object Access,object PersonnelCode,out string message)
        {
            message = objClassNewUser.Insert(username, password, Access, PersonnelCode);
        }

        public void update(object username, object password, object Access,object PersonnelCode, out string message)
        {
            if (objClassNewUser.update(username, password, Access, PersonnelCode) == true)
            {
                message = "عملیات ویرایش با موفقیت انجام شد";
            }
            else
            {
                message = "عملیات ویرایش با شکست مواجه شد";
            }
        }
        public DataTable search(object username)
        {
            DataTable dt = new DataTable();
            dt=objClassNewUser.search(username);
            return dt;
        }
        public DataTable search()
        {
            DataTable dt = new DataTable();
            dt = objClassNewUser.search();
            return dt;
        }
        public bool Delete(object username)
        {
            if (objClassNewUser.Delete(username) == true)
            {
                return true;
            }
            else
                return false;
        }
    }
}
