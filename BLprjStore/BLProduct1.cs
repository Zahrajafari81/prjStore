using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALprjStore;

namespace BLprjStore
{
    public class BLProduct1
    {
        DALClassProduct1 objClassproduct = new DALClassProduct1();
        public void InsertProduct(object Barcode, object Name, object Unit, object Price, object Number, object tarikhtTolid, object TarikhEngheza, object Garanty,object image,object BoothNumber_fk, out string message)
        {
            if (objClassproduct.Insert(Barcode, Name, Unit, Price, Number, tarikhtTolid, TarikhEngheza, Garanty, image, BoothNumber_fk) == true)
            {
                message = "عملیات ثبت با موفقیت انجام شد";
            }
            else
                message = "عملیات ثبت با شکست مواجه شد";
        }
        public DataTable searchAllInfo()
        {
            DataTable dt= new DataTable();
            dt = objClassproduct.searchAllinfo();
            return dt;
        }

        public void UpdateProduct1(object Barcode, object Name, object Unit, object Price, object Number, object tarikhtTolid, object TarikhEngheza, object Garanty,object image,object BoothNumber_fk, out string message)
        {
            if (objClassproduct.UpdateProduct1(Barcode, Name, Unit, Price, Number, tarikhtTolid, TarikhEngheza, Garanty,image, BoothNumber_fk) == true)
            {
                message = "عملیات ویرایش با موفقیت انجام شد";
            }
            else
                message = "عملیات ویرایش با شکست مواجه شد";
        }

        public void DeleteInfo(object Barcode, out string messsage)
        {
            if (objClassproduct.DeleteInfo1(Barcode) == true)
            {
                messsage = "عملیات حذف با موفقیت انجام شد";
            }
            else
                messsage = "عملیات حذف با شکست مواجه شد";
        }
        public DataTable SearchGoogle(object ProductName)
        {
            DataTable dt = new DataTable();
            dt = objClassproduct.searchGoogle(ProductName);
            return dt;
        }
    }
}
