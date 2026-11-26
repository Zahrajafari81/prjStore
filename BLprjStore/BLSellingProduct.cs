using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALprjStore;
using System.Data;


namespace BLprjStore
{
    public class BLSellingProduct
    {
        DALSellingProduct objSellingP = new DALSellingProduct();
        public DataTable searchMaxID()
        {
            DataTable dt = new DataTable();
            dt= objSellingP.searchMaxID();
            return dt;
        }
        public DataTable SearchNumberProduct(object IDProduct)
        {
            
            DataTable dt = new DataTable();
            dt=objSellingP.SearchNumberProduct(IDProduct);
            return dt;
        }
        public void Update(object IDProduct, object Number)
        {
            objSellingP.Update(IDProduct, Number);
        }
        public void Insert(object IDFactor, object IDProduct, object NameProducts, object ProductType, object Number, object Unit, object Price, object DarsadeTakhfif, object FinalPrice, object FNameEmployee, object LNameEmployee,object Time,object Date, out string message)
        {
            if (objSellingP.Insert(IDFactor, IDProduct, NameProducts, ProductType, Number, Unit, Price, DarsadeTakhfif, FinalPrice, FNameEmployee, LNameEmployee,Time,Date) == true)
            {
                message = "عملیات با موفقیت ثبت شد";
            }
            else
                message = "عملیات با شکست مواجه شد";
        }
    }
}
