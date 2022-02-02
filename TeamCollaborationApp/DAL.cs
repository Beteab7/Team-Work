using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
 



namespace TeamCollaborationApp
{
   
    class DAL
    {
        bool value = false;

        string constr = "Server = (local); database = Team; Integrated Security=True;";


        public DataTable getLog(int userID)
        {
            
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spGetLog", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@userID", userID);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    return dt;
                }
            }
        }



        public void GetUserDetails_StoredProcedure(string username, User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {

                    SqlCommand cmd = new SqlCommand("spUserInfoRetrival", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spUserInfoRetrival";

                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.Add("@userid", SqlDbType.VarChar, 22);
                    cmd.Parameters["@userid"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 100);
                    cmd.Parameters["@firstname"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@lastname", SqlDbType.VarChar, 50);
                    cmd.Parameters["@lastname"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar, 20);
                    cmd.Parameters["@phone"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 30);
                    cmd.Parameters["@email"].Direction = ParameterDirection.Output;
                    //cmd.Parameters.Add("@photo", SqlDbType.Image);
                    // cmd.Parameters["@photo"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar, 30);
                    cmd.Parameters["@password"].Direction = ParameterDirection.Output;

                    try
                    {
                        con.Open();
                        int i = cmd.ExecuteNonQuery();

                        int id = Convert.ToInt32(cmd.Parameters["@userid"].Value);
                        string Fname = Convert.ToString(cmd.Parameters["@firstname"].Value);
                        string lname = Convert.ToString(cmd.Parameters["@lastname"].Value);
                        string phone = Convert.ToString(cmd.Parameters["@phone"].Value);
                        string email = Convert.ToString(cmd.Parameters["@email"].Value);
                        //string photo = Convert.ToString(cmd.Parameters["@photo"].Value);
                        string password = Convert.ToString(cmd.Parameters["@password"].Value);

                        u.GetUserDetails(id, username, Fname, lname, phone, email, password);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {

                        con.Close();
                    }



                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChangePassword_StoredProcedure(string newPassword)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("spChangePassword", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", User.id);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    int rowAffected = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SaveUser_StoredProcedure()
        {
            
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spSaveUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", User.id);
                    cmd.Parameters.AddWithValue("@Firstname", User.firstname);
                    cmd.Parameters.AddWithValue("@Lastname", User.lastname);
                    cmd.Parameters.AddWithValue("@Email", User.email);
                    cmd.Parameters.AddWithValue("@Username", User.username);
                    cmd.Parameters.AddWithValue("@Phone", User.phonenumber);



                    int rowAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowAffected > 0)
                        MessageBox.Show("Save succesfully !");

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        public void SaveSignUp_StoredProcedure()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spSignUpUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fullname", User.fullname);
                    cmd.Parameters.AddWithValue("@Email", User.email);
                    cmd.Parameters.AddWithValue("@Username", User.username);
                    cmd.Parameters.AddWithValue("@Password", User.password);


                    int rowAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowAffected > 0)
                        MessageBox.Show("Registered succesfully !");

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool Authentication_StoredProcedure(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("spAuthenticationUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int rowAffected = Convert.ToInt32(cmd.ExecuteScalar());
                    if (rowAffected == 1)
                        value = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return value;
        }
        public int getLoggedInUserID()
        {
            int uid = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spFetchUserID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@userID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters["@userID"].Value = uid;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    uid = Convert.ToInt32(cmd.Parameters["@userID"].Value);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return uid;
        }
     
        public DataTable getUsers()
        {
            DataTable dt = null;
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spGetUsers", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtProjects");
                        dt = ds.Tables[0];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }

    }
}
