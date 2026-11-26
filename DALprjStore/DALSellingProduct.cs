using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DALprjStore
{
    public class DALSellingProduct
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MCAOB13\\SQL2019;Initial Catalog=DbSture;Integrated Security=True");
        public DataTable searchMaxID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Max(IDFactor) From TblSelling", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable SearchNumberProduct(object IDProduct)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Number from TblProducts where IDProduct=@IDProduct", con);
            cmd.Parameters.AddWithValue("@IDProduct", IDProduct);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Update(object IDProduct,object Number)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update TblProducts set Number=@Number where IDProduct=@IDProduct", con);
            cmd.Parameters.AddWithValue("@IDProduct", IDProduct);
            cmd.Parameters.AddWithValue("@Number", Number);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool Insert(object IDFactor, object IDProduct, object NameProducts, object ProductType, object Number, object Unit, object Price, object DarsadeTakhfif, object FinalPrice, object FNameEmployee, object LNameEmployee,object Time,object Date)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into TblSelling (IDFactor,IDProduct,NameProducts,ProductType,Number,Unit, Price,DarsadeTakhfif, FinalPrice,FNameEmployee,LNameEmployee,Time,Date) Values (@IDFactor,@IDProduct,@NameProducts,@ProductType,@Number,@Unit, @Price,@DarsadeTakhfif, @FinalPrice,@FNameEmployee,@LNameEmployee,@Time,@Date)", con);
            cmd.Parameters.AddWithValue("@IDFactor", IDFactor);
            cmd.Parameters.AddWithValue("@IDProduct", IDProduct);
            cmd.Parameters.AddWithValue("@NameProducts", NameProducts);
            cmd.Parameters.AddWithValue("@ProductType", ProductType);
            cmd.Parameters.AddWithValue("@Number", Number);
            cmd.Parameters.AddWithValue("@Unit", Unit);
            cmd.Parameters.AddWithValue("@DarsadeTakhfif", DarsadeTakhfif);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@FinalPrice", FinalPrice);
            cmd.Parameters.AddWithValue("@FNameEmployee", FNameEmployee);
            cmd.Parameters.AddWithValue("@LNameEmployee", LNameEmployee);
            cmd.Parameters.AddWithValue("@Time", Time);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
