using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALprjStore
{
    public class ClassLogin
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MCAOB13\\SQL2019;Initial Catalog=DbStore;Integrated Security=True");

        public DataTable Login(object username, object password)
        {
            try
            {
             con.Open();
             SqlCommand cmd = new SqlCommand("Select * from TblLogin where UserName=@UserName and Password=@Password", con);
             cmd.Parameters.AddWithValue("@UserName", username);
             cmd.Parameters.AddWithValue("@Password", password);
             SqlDataAdapter da= new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             con.Close();
             return dt;
            }
            catch
            {
                DataTable dt = new DataTable();
                return dt;
            }
        }
        public DataTable Gender(object userName)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT FName,LName,sex FROM tblLogin L JOIN tblEmployee E on L.PersonnelCode=E.ID WHERE UserName=@UserName", con);
                cmd.Parameters.AddWithValue("@UserName", userName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                DataTable dt = new DataTable();
                return dt;
            }
        }
    }
}
