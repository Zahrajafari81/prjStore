using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALprjStore
{
    public class DALClassBooth
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MCAOB13\\SQL2019;Initial Catalog=DbStore;Integrated Security=True");

        public bool Insert(object BoothNumber, object BoothName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into TblBooth (BoothNumber,BoothName) Values (@BoothNumber,@BoothName)", con);
                cmd.Parameters.AddWithValue("@BoothNumber", BoothNumber);
                cmd.Parameters.AddWithValue("@BoothName", BoothName);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch 
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool update(object BoothNumber, object BoothName)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update TblBooth set BoothName=@BoothName where BoothNumber=@BoothNumber", con);
                cmd.Parameters.AddWithValue("@BoothNumber", BoothNumber);
                cmd.Parameters.AddWithValue("@BoothName", BoothName);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool Delete(object BoothNumber)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From TblBooth where BoothNumber=@BoothNumber", con);
            cmd.Parameters.AddWithValue("@BoothNumber", BoothNumber);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public DataTable Search()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblBooth", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable Search(object BoothName)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblBooth where BoothName Like N'"+BoothName+ "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
