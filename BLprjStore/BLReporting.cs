using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALprjStore;

namespace BLprjStore
{
    public class BLReporting
    {
        DALReport objReport = new DALReport();

        public DataTable search(object IDFactor)
        {
            DataTable dt= new DataTable();
            dt = objReport.search(IDFactor);
            return dt;
        }
    }
}
