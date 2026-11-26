using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALprjStore
{
    public class ClassNewUser
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MCAOB13\\SQL2019;Initial Catalog=DbStore;Integrated Security=True");
        //public Boolean Insert(object username, object password , object Access, object PersonnelCode)
        //{

        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("Insert into TblLogin (UserName,Password, Access, PersonnelCode) Values (@UserName,@Password, @Access, @PersonnelCode)", con);
        //    cmd.Parameters.AddWithValue("@UserName", username);
        //    cmd.Parameters.AddWithValue("@Password", password);
        //    cmd.Parameters.AddWithValue("@Access", Access);
        //    cmd.Parameters.AddWithValue("@PersonnelCode", PersonnelCode);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    return true;
        //}
        public string Insert(object username, object password, object access, object personnelCode)
        {
            con.Open();

            // بررسی تکراری بودن شماره پرسنلی در جدول
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM TblLogin WHERE PersonnelCode = @PersonnelCode", con);
            checkCmd.Parameters.AddWithValue("@PersonnelCode", personnelCode);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                con.Close();
                return "این کارمند قبلاً دارای نام کاربری ثبت شده است.";
            }

            // ثبت اطلاعات جدید
            SqlCommand cmd = new SqlCommand("INSERT INTO TblLogin (UserName, Password, Access, PersonnelCode) VALUES (@UserName, @Password, @Access, @PersonnelCode)", con);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Access", access);
            cmd.Parameters.AddWithValue("@PersonnelCode", personnelCode);

            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return "عملیات ثبت با موفقیت انجام شد";
            }
            catch 
            {
                con.Close();
                return "عملیات ثبت با شکست مواجه شد";
            }
        }

        public Boolean update(object username, object password, object Access, object PersonnelCode)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update TblLogin set  Password=@Password, Access=@Access, PersonnelCode= @PersonnelCode where UserName=@UserName", con);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Access", Access);
            cmd.Parameters.AddWithValue("@PersonnelCode", PersonnelCode);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public DataTable search(object username)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblLogin where UserName Like N'" + username.ToString()+ "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable search()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblLogin", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public Boolean Delete(object username)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from TblLogin where UserName=@UserName", con);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
