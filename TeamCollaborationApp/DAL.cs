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
        string constr = "Server = HP-NOTEBOOK; database = Team; uid = Lab; Pwd = 123; ";


        public void SignUpUser_StoredProcedure(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spSignUpUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fullname", u.fullname);
                    cmd.Parameters.AddWithValue("@Email", u.email);
                    cmd.Parameters.AddWithValue("@Username", u.username);
                    cmd.Parameters.AddWithValue("@Password", u.password);
             

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

        public bool Authentication_StoredProcedure( string username , string password)
        {
           
            try
            {

                using (SqlConnection con = new SqlConnection(constr))
                {
                     
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spAuthenticationUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username",username);
                    cmd.Parameters.AddWithValue("@Password",password);
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

       
    }
}
