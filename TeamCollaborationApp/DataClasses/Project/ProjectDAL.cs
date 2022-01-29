using System;
using System.Data.SqlClient;
using System.Data;

namespace TTa{
   class ProjectDAL{
        string constr = "Server = (local); database = Team; Integrated Security=True;";
        public void InsertProject(Project p){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();

                SqlCommand cmd =new SqlCommand("spInsertProject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", p.UserID);
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Description", p.Description);
                cmd.Parameters.AddWithValue("@BeginDate", p.BeginDate.ToString());
                cmd.Parameters.AddWithValue("@EndDate", p.EndDate.ToString());
                cmd.Parameters.Add("@ProjectID", SqlDbType.VarChar, 22).Direction = ParameterDirection.Output;
                cmd.Parameters["@ProjectID"].Value= p.ID;
                p.ID=Convert.ToString(cmd.Parameters["@ProjectID"].Value);
                cmd.ExecuteNonQuery();
                Console.WriteLine(p.ID);
            }
        }
        public DataTable getProject(string userID){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();
                using(SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spGetProject", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@userID", userID);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtProjects");
                    DataTable dt = ds.Tables[0];
                    return dt;
                }
            }
        }
    }
}
