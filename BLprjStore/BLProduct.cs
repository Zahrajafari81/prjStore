using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALprjStore;

namespace BLprjStore
{
    public class BLProduct
    {
        DALClassProduct objClassproduct = new DALClassProduct();
        public void InsertProduct(object Barcode, object Name, object Unit, object Price, object Number, object tarikhtTolid, object TarikhEngheza, object Garanty,out string message)
        {
            if (objClassproduct.InsertProduct(Barcode, Name, Unit, Price, Number, tarikhtTolid, TarikhEngheza, Garanty) == true)
            {
                message = "عملیات ثبت با موفقیت انجام شد";
            }
            else
                message = "عملیات ثبت با شکست مواجه شد";
        }
        public void UpdateProduct(object Barcode, object Name, object Unit, object Price, object Number, object tarikhtTolid, object TarikhEngheza, object Garanty, out string message)
        {
            if (objClassproduct.UpdateProduct(Barcode, Name, Unit, Price, Number, tarikhtTolid, TarikhEngheza, Garanty) == true)
            {
                message = "عملیات ویرایش با موفقیت انجام شد";
            }
            else
                message = "عملیات ویرایش با شکست مواجه شد";
        }
        public DataTable searchInfoAll()
        {
            DataTable dt = new DataTable();
            dt = objClassproduct.searchInfoAll();
            return dt;
        }
        public void DeleteInfo(object Barcode,out string messsage)
        {
            if (objClassproduct.DeleteInfo(Barcode) == true)
            {
                messsage = "عملیات حذف با موفقیت انجام شد";
            }
            else
                messsage = "عملیات حذف با شکست مواجه شد";
        }

        public DataTable searchByName(object ProductName)
        {
            DataTable dt = new DataTable();
            dt = objClassproduct.searchByName(ProductName);
            return dt;
        }
    }
}
