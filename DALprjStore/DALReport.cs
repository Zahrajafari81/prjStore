using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALprjStore
{
    public class DALReport
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MCAOB13\\SQL2019;Initial Catalog=DbSture;Integrated Security=True");
        public DataTable search(object IDFactor)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select NameProducts,ProductType,Number,Unit,Price,FinalPrice From TblSelling where IDFactor=@IDFactor", con);
            cmd.Parameters.AddWithValue("@IDFactor", IDFactor);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
