using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TeamCollaborationApp
{
    internal class TaskDAL
    {
        const string CONSTR = "Server = (local); database = Team; uid = lab; pwd = 123";
       

        public int taskIsValid(Task t)
        {
            if (t.Name.Length > 50 || t.Name.Length == 0) return -1;
            if (t.Description.Length > 200) return -2;
            if (t.Priority < 1 || t.Priority > 4) return -3;
            if (t.DeadLine < DateTime.Now) return -4;
            return 0;
        }

        public void showErrorMessage(int errorCode)
        {
            switch (errorCode)
            {
                case -1:
                    MessageBox.Show("Name is either empty or greater than 50 Error Code: " + errorCode);
                    break;
                case -2:
                    MessageBox.Show("Description can not contain more than 200 characters. Error Code: " + errorCode);
                    break;
                case -3:
                    MessageBox.Show("You've entered a wrong priority value. Error Code: " + errorCode);
                    break;
                case -4:
                    MessageBox.Show("Your date value is wrong! You can't not time travel. Error Code: " + errorCode);
                    break;
                default:
                    MessageBox.Show("Unkown error have occured. Error Code: " + errorCode);
                    break;
            }
            
        }

        public void saveTask(Task t)
        {
            if(t == null) throw new ArgumentNullException("The task entered is null");
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertTask", con);
                    // Calling an overloaded method saveTaskSp to execute the query.
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", t.Name);
                    cmd.Parameters.AddWithValue("@description", t.Description);
                    cmd.Parameters.AddWithValue("@priority", t.Priority);
                    cmd.Parameters.AddWithValue("@completion", t.Completion);
                    cmd.Parameters.AddWithValue("@projectId", t.ProjectId);
                    cmd.Parameters.AddWithValue("@deadline", t.DeadLine);
                    if(cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Save Successful");
                       
                    con.Close();
                }
            }catch(SqlException ex)
            {
                /*
                 *  Instead of handling the exception here it'll be 
                 *  transferred back to the caller
                 */
                throw;
            }

        }


        public DataTable getUserId(string userName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spSelectUserId", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@fname", userName);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtUser");
                        DataTable dt = ds.Tables["dtUser"];
                        return dt;
                    }
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public DataTable getTaskId(string taskName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spSelectTaskId", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@tname", taskName);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtTask");
                        DataTable dt = ds.Tables["dtTask"];
                        return dt;
                    }
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public DataTable getTask(int param)
        {
            using (SqlConnection con = new SqlConnection(CONSTR))
            {
                 con.Open();
                 using (SqlDataAdapter da = new SqlDataAdapter())
                 {
                    
                    da.SelectCommand = new SqlCommand("spFetchSingleTaskById", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@taskId", param);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtTask");
                    DataTable dt = ds.Tables["dtTask"];
                    return dt;
                 }
            }
          
        }

        public DataTable getRecentProjectMembers(int projectID)
        {
            using (SqlConnection con = new SqlConnection(CONSTR))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spFetchAllProjectMembers", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ProjectId", projectID);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtProjectMember");
                    DataTable dt = ds.Tables["dtProjectMember"];
                    return dt;
                }
            }
        }

        public DataTable getTasks()
        {
            try
            { 
            using (SqlConnection con = new SqlConnection(CONSTR))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spFetchTasks", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtTask");
                    DataTable dt = ds.Tables["dtTask"];
                    return dt;
                }
            }
            }catch(SqlException e)
            {
                throw;
            }
        }

        public DataTable getTasksOrderedByPriority()
        {
            using (SqlConnection con = new SqlConnection(CONSTR))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spFetchTasksOrderedByPriority", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtTask");
                    DataTable dt = ds.Tables["dtTask"];
                    return dt;
                }
            }
        }

        public DataTable getTasksOrderedByName()
        {
            using (SqlConnection con = new SqlConnection(CONSTR))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spFetchTasksOrderedByName", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtTask");
                    DataTable dt = ds.Tables["dtTask"];
                    return dt;
                }
            }
        }

        public DataTable FetchTaskByProject(int projectId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spFetchTasksByProject", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@projectId", projectId);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtTask");
                        DataTable dt = ds.Tables["dtTask"];
                        return dt;
                    }
                }
            }catch(SqlException e)
            {
                throw;
            }
        }

        public void deleteTask(int taskId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    
                    SqlCommand cmd = new SqlCommand("spDeleteTask", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Delete Succesful");
                    else
                        MessageBox.Show("Delete Failed");
                    con.Close();
                }
            }catch(SqlException e)
            {
                /*
                 *  Instead of handling the exception here it'll be 
                 *  transferred back to the caller
                 */
                MessageBox.Show(e.Message);
            }

        }

        public void updateTask(Task t)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateTask", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", t.Name);
                    cmd.Parameters.AddWithValue("@description", t.Description);
                    cmd.Parameters.AddWithValue("@priority", t.Priority);
                    cmd.Parameters.AddWithValue("@completion", t.Completion);
                    cmd.Parameters.AddWithValue("@projectId", t.ProjectId);
                    cmd.Parameters.AddWithValue("@deadline", t.DeadLine);
                    updateTaskName(t.Id, t.Name);
                    updateTaskDescription(t.Id, t.Description);
                    updateTaskPriority(t.Id, t.Priority);
                    updateTaskCompletion(t.Id, t.Completion);
                    updateTaskDeadLine(t.Id, t.DeadLine);
                }
            }catch(SqlException e)
            {
                throw;
            }
        }

        public void updateTaskName(int taskId, String name)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateTaskName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    cmd.Parameters.AddWithValue("@name", name);
                    if (cmd.ExecuteNonQuery() > 1)
                        MessageBox.Show("Updated Succesfully");
                    con.Close();
                }
            }catch(SqlException e)
            {
                throw;
            }
        }

        public void updateTaskDescription(int taskId, String description)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateTaskDescription", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    cmd.Parameters.AddWithValue("@description", description);
                    if (cmd.ExecuteNonQuery() > 1)
                        MessageBox.Show("Updated Succesfully");
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void updateTaskDeadLine(int taskId, DateTime deadline)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateTaskDeadLine", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    cmd.Parameters.AddWithValue("@deadline", deadline);
                    if (cmd.ExecuteNonQuery() > 1)
                        MessageBox.Show("Updated Succesfully");
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void updateTaskPriority(int taskId, int priority)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateTaskPriority", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    cmd.Parameters.AddWithValue("@priority", priority);
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                        MessageBox.Show("Update Succesfull");
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }


        public void updateTaskCompletion(int taskId, bool completion)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateTaskCompletion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    cmd.Parameters.AddWithValue("@completion", completion);
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                        MessageBox.Show("Update Succesfull");
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void assignTaskToUser(int taskId, int userId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertTaskAndMember", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaskId", taskId);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Assigned Successfully");
                    con.Close();
                }
            }catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getTasksAndUsers()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spFetchTasksAndUsers", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtTaskMember");
                        DataTable dt = ds.Tables["dtTaskMember"];
                        return dt;
                    }
                }
    
            }catch(SqlException e)
            {
                throw;
            }
        }

        public DataTable getTaskAndUser(int param)
        {
            try
            { 
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spFetchTaskAndUserById", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@id", param);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtTaskMember");
                        DataTable dt = ds.Tables["dtTaskMember"];
                        return dt;
                    }
                }
            }catch(SqlException e)
            {
                throw;
            }
        }

        public void updateUserTask(int userId, int taskId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    SqlCommand cmd = new SqlCommand("spUpdateTask", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Updated Successfully");
                    con.Close();

                }
            }catch(SqlException e)
            {
                throw;
            }
        }

        public void deleteUserFromTask(int userId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteTaskMemberUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", userId);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Updated Successfully");
                    con.Close();
                }

            }catch(SqlException e)
            {
                throw;
            }
        }

        public void deleteAssignedTask(int taskId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONSTR))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteTaskMemberTask", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Updated Successfully");
                    con.Close();
                }
            }
            catch(SqlException e)
            {
                throw;
            }
        }
    }
}
