using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALprjStore;
using System.Data;

namespace BLPrjSturee
{
    public class BLEmployee
    {
        DALClassEmployee objEmployee = new DALClassEmployee();
        public void Insert(object id, object codeMeli, object Fname, object Lname, object NumberTelHouse, object NumberTelHamrah, object Masoliate, object sex, object address, out string message)
        {
            if (objEmployee.Insert(id, codeMeli, Fname, Lname, NumberTelHouse, NumberTelHamrah, Masoliate, sex, address) == true)
            {
                message = "عملیات ثبت با موفقیت انجام شد";
            }
            else
                message = "عملیات ثبت با شکست مواجه شد";
        }

        public void Update(object id, object codeMeli, object Fname, object Lname, object NumberTelHouse, object NumberTelHamrah, object Masoliate, object sex, object address, out string message)
        {
            if (objEmployee.Update(id, codeMeli, Fname, Lname, NumberTelHouse, NumberTelHamrah, Masoliate, sex, address) == true)
            {
                message = "عملیات ویرایش با موفقیت انجام شد";
            }
            else
                message = "عملیات ویرایش با شکست مواجه شد";
        }
        public DataTable Search()
        {
            DataTable dt = new DataTable();
            dt = objEmployee.Search();
            return dt;
        }
        public DataTable Search(object searchGoogle)
        {
            DataTable dt = new DataTable();
            dt = objEmployee.Search(searchGoogle);
            return dt;
        }
        public void Delete(object id, out string message)
        {
            if (objEmployee.delete(id) == true)
            {
                message = "عملیات حذف با موفقیت انجام شد";
            }
            else
                message = "عملیات حذف با شکست مواجه شد";
        }
       

    }
}
