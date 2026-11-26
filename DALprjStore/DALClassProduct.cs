using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DALprjStore
{
    public class DALClassProduct
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-MCAOB13\\SQL2019;Initial Catalog=DbStore;Integrated Security=True");

        public bool InsertProduct(object Barcode,object Name, object Unit,object Price,object Number,object tarikhtTolid,object TarikhEngheza,object Garanty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TblProduct (Barcode,ProductName,Number,Price,Unit,TarikhTolid,TarikhEngheza,Garanty) VALUES (@Barcode,@ProductName,@Number,@Price,@Unit,@TarikhTolid,@TarikhEngheza,@Garanty)", connect);
                cmd.Parameters.AddWithValue("@Barcode", Barcode);
                cmd.Parameters.AddWithValue("@ProductName", Name);
                cmd.Parameters.AddWithValue("@Number", Number);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Unit", Unit);
                cmd.Parameters.AddWithValue("@TarikhTolid", tarikhtTolid);
                cmd.Parameters.AddWithValue("@TarikhEngheza", TarikhEngheza);
                cmd.Parameters.AddWithValue("@Garanty", Garanty);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connect.Close();
            }
        }
        public bool UpdateProduct(object Barcode, object Name, object Unit, object Price, object Number, object tarikhtTolid, object TarikhEngheza, object Garanty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE TblProduct SET ProductName=@ProductName, Number=@Number, Price=@Price, Unit= @Unit, TarikhTolid=@TarikhTolid, TarikhEngheza=@TarikhEngheza, Garanty=@Garanty WHERE Barcode=@Barcode", connect);
                cmd.Parameters.AddWithValue("@Barcode", Barcode);
                cmd.Parameters.AddWithValue("@ProductName", Name);
                cmd.Parameters.AddWithValue("@Number", Number);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Unit", Unit);
                cmd.Parameters.AddWithValue("@TarikhTolid", tarikhtTolid);
                cmd.Parameters.AddWithValue("@TarikhEngheza", TarikhEngheza);
                cmd.Parameters.AddWithValue("@Garanty", Garanty);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connect.Close();
            }
        }

        public bool DeleteInfo(object Barcode)
        {
            try
            { 
            connect.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM TblProduct WHERE Barcode = @Barcode", connect);
            cmd.Parameters.AddWithValue("@Barcode", Barcode);
            cmd.ExecuteNonQuery();
            connect.Close();
            return true;
            }
            catch
            {
                return false;
            }

        }

        public DataTable searchInfoAll()
        {
                connect.Open();
                DataTable table = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * from TblProduct", connect);
                SqlDataAdapter sqldata = new SqlDataAdapter(cmd);
                sqldata.Fill(table);
                connect.Close();
                return table;
        }

       public DataTable searchByName(object ProductName)
        {
            DataTable dt = new DataTable();
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TblProduct WHERE ProductName LIKE N'"+ProductName.ToString()+"%'",connect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            connect.Close();
            return dt;
        }

    }
}
