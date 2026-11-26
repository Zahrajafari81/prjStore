using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALprjStore
{
    public class DALClassEmployee
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MCAOB13\\SQL2019;Initial Catalog=DbStore;Integrated Security=True");
        public bool Insert(object id, object codeMeli, object Fname, object Lname, object NumberTelHouse, object NumberTelHamrah, object Masoliate, object sex, object address)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("saveInfoForTblEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@CodeMeli", codeMeli);
            cmd.Parameters.AddWithValue("@Fname ", Fname);
            cmd.Parameters.AddWithValue("@Lname", Lname);
            cmd.Parameters.AddWithValue("@NumberTelHouse", NumberTelHouse);
            cmd.Parameters.AddWithValue("@NumberTelHamrah", NumberTelHamrah);
            cmd.Parameters.AddWithValue("@Masoleate", Masoliate);
            cmd.Parameters.AddWithValue("@Sex", sex);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@result", SqlDbType.Int);
            cmd.Parameters["@result"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            con.Close();
            int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
            if (res == 1)
                return false;
            else
                return true;
        }
        public DataTable Search()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SearchInfoFromTblEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable Search(object fname)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SearchGoogleTblEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", fname);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Update(object id, object codeMeli, object Fname, object Lname, object NumberTelHouse, object NumberTelHamrah, object Masoliate, object sex, object address)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EditInfoForEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@CodeMeli", codeMeli);
            cmd.Parameters.AddWithValue("@Fname ", Fname);
            cmd.Parameters.AddWithValue("@Lname", Lname);
            cmd.Parameters.AddWithValue("@NumberTelHouse", NumberTelHouse);
            cmd.Parameters.AddWithValue("@NumberTelHamrah", NumberTelHamrah);
            cmd.Parameters.AddWithValue("@Masoleate", Masoliate);
            cmd.Parameters.AddWithValue("@Sex", sex);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool delete(object id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DeleteinfoTblEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
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
    }
}