using System;
using System.Data.SqlClient;
using System.Data;

namespace TeamCollaborationApp{
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
                cmd.Parameters.Add("@ProjectID", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@ProjectID"].Value= p.ID;
                cmd.ExecuteNonQuery();

                //Does'nt read output data unless the connection is closed
                con.Close();
                p.ID =  Convert.ToInt32(cmd.Parameters["@ProjectID"].Value);
            }
        }
        public DataTable getProject(int userID){
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
        public void DeleteProject(int userID, int projectID){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();

                SqlCommand cmd =new SqlCommand("spDeleteProject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@projectID", projectID);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateProject(Project p){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();
                SqlCommand cmd =new SqlCommand("spUpdateProject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projectID", p.ID);
                cmd.Parameters.AddWithValue("@userID", p.UserID);
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Description", p.Description);
                cmd.Parameters.AddWithValue("@BeginDate", p.BeginDate.ToString());
                cmd.Parameters.AddWithValue("@EndDate", p.EndDate.ToString());

                cmd.ExecuteNonQuery();
            }
        }
        public DataTable searchProject(int id, string nameQuery){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();
                using(SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spSearchProject", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@userID", id);
                    da.SelectCommand.Parameters.AddWithValue("@Name", nameQuery);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtProjects");
                    DataTable dt = ds.Tables[0];
                    return dt;
                }
            }
        }
    }
}
