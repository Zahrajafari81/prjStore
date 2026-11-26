using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALprjStore
{
    public class DALClassProduct1
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-MCAOB13\\SQL2019;Initial Catalog=DbStore;Integrated Security=True");

        public bool Insert(object Barcode, object Name, object Unit, object Price, object Number, object tarikhtTolid, object TarikhEngheza, object Garanty,object image,object BoothNumber_fk)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("saveInfoProduct", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Barcode", Barcode);
                cmd.Parameters.AddWithValue("@ProductName", Name);
                cmd.Parameters.AddWithValue("@Number", Number);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Unit", Unit);
                cmd.Parameters.AddWithValue("@TarikhTolid", tarikhtTolid);
                cmd.Parameters.AddWithValue("@TarikhEngheza", TarikhEngheza);
                cmd.Parameters.AddWithValue("@Garanty", Garanty);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@BoothNumber_fk", BoothNumber_fk);
                cmd.Parameters.AddWithValue("@result", SqlDbType.Int);
                cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                if (res == 1)
                    return false;
                else
                    return true;
            }
            finally
            {
                connect.Close();
            }

        }
        public DataTable searchAllinfo()
        {
            DataTable dt = new DataTable();
            connect.Open();
            SqlCommand cmd = new SqlCommand("searchInfo", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            connect.Close();
            return dt;
        }

        public bool UpdateProduct1(object Barcode, object Name, object Unit, object Price, object Number, object tarikhtTolid, object TarikhEngheza, object Garanty,object image, object BoothNumber_fk)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EditInfoProduct", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Barcode", Barcode);
                cmd.Parameters.AddWithValue("@ProductName", Name);
                cmd.Parameters.AddWithValue("@Number", Number);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Unit", Unit);
                cmd.Parameters.AddWithValue("@TarikhTolid", tarikhtTolid);
                cmd.Parameters.AddWithValue("@TarikhEngheza", TarikhEngheza);
                cmd.Parameters.AddWithValue("@Garanty", Garanty);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@BoothNumber_fk", BoothNumber_fk);

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
        public bool DeleteInfo1(object Barcode)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("DeleteInfo", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Barcode", Barcode);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public DataTable searchGoogle(object ProductName)
        {
            connect.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SearchGoogle", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connect.Close();
            return dt;
        }
    }
}