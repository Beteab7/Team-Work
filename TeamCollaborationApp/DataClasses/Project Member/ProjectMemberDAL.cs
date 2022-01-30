using System;
using System.Data.SqlClient;
using System.Data;
namespace TeamCollaborationApp{
    class ProjectMemberDAL{
        string constr = "Server = (local); database = Team; Integrated Security=True;";
        public void insertProjectMember(int projectID, int userID){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();

                SqlCommand cmd =new SqlCommand("spInsertProjectMember", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProjectId", projectID);
                cmd.Parameters.AddWithValue("@UserId", userID);

                cmd.ExecuteNonQuery();
            }
        }
        public void deleteProjectMember(int projectID, int userID){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();

                SqlCommand cmd =new SqlCommand("spDeleteProjectMember", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProjectId", projectID);
                cmd.Parameters.AddWithValue("@UserId", userID);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable getRecentProjectMembers(int projectID){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();
                using(SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spGetRecentProjectMembers", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ProjectId", projectID);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtProjects");
                    DataTable dt = ds.Tables[0];
                    return dt;
                }
            }
        }
        public DataTable getOldProjectMembers(int projectID){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();
                using(SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spGetOldProjectMembers", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ProjectId", projectID);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtProjects");
                    DataTable dt = ds.Tables[0];
                    return dt;
                }
            }
        }
        public DataTable searchProjectMembers(int projectID, string query){
            using (SqlConnection con = new SqlConnection(constr)){
                con.Open();
                using(SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spSearchProjectMember", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ProjectId", projectID);
                    da.SelectCommand.Parameters.AddWithValue("@query", query);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtProjects");
                    DataTable dt = ds.Tables[0];
                    return dt;
                }
            }
        }
    }
}
