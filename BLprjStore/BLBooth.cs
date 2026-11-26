using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALprjStore;

namespace BLPrjSturee
{
    public class BLBooth
    {
        DALClassBooth objAddBooth = new DALClassBooth();
        public void Insert(object BoothNumber,object BoothName, out string message)
        {
            if (objAddBooth.Insert(BoothNumber, BoothName) == true)
            {
                message = "اطلاعات با موفقیت ثبت شد";
            }
            else
                message = "عملیات ثبت با شکست مواجه شد";
        }
        public void Update(object BoothNumber, object BoothName, out string message)
        {
            if (objAddBooth.update(BoothNumber, BoothName) == true)
            {
                message = "اطلاعات با موفقیت ویرایش شد";
            }
            else
                message = "عملیات ویرایش با شکست مواجه شد";
        }
        public void Delete(object BoothNumber, out string message)
        {
            if (objAddBooth.Delete(BoothNumber) == true)
            {
                message = "اطلاعات با موفقیت حذف شد";
            }
            else
                message = "عملیات حذف با شکست مواجه شد";
        }
        public DataTable Search()
        {
            DataTable dt = new DataTable();
            dt=objAddBooth.Search();
            return dt;
        }
        public DataTable Search(object BoothName)
        {
            DataTable dt = new DataTable();
            dt = objAddBooth.Search(BoothName);
            return dt;
        }

    }
}
