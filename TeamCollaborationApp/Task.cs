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
    [Serializable]

    internal class Task
    {
        // Data memebers of the class Task
        int id;
        String name;
        String description;
        int projectId;
        int priority;
        bool completion;
        DateTime dateCreated;
        DateTime deadLine;
        TaskDAL op;
    
        internal Task() { }
        //A normal conventional constructor to create a Task object. 
        internal Task(
            int id,
            String name, 
            String description, 
            int priority,
            bool completion,
            int projectId,
            DateTime deadLine
            )
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.priority = priority;
            this.completion = completion;
            this.projectId = projectId;
            this.deadLine = deadLine;
        }

        internal Task(
            String name,
            String description,
            int priority,
            bool completion,
            int projectId,
            DateTime deadLine
            )
        {
            this.name = name;
            this.description = description;
            this.priority = priority;
            this.completion = completion;
            this.projectId = projectId;
            this.deadLine = deadLine;
        }

       

        /*
         * A constructor to copy one task
         * to another.
         */
        internal Task(Task that)
        {
            this.name = that.name;
            this.description = that.description;
            this.priority = that.priority;
            this.completion = that.completion;
            this.projectId = that.projectId;
            this.deadLine = that.deadLine;
        }

        internal Task(DataTable table)
        {
            DataRow[] dr = table.Select();
            foreach (DataRow row in dr)
            {
                this.id = Convert.ToInt32(row["tid"].ToString());
                this.name = row["Name"].ToString();
                this.description = row["Description"].ToString();
                this.priority = Convert.ToInt32(row["Priority"].ToString());
                this.completion = Convert.ToBoolean(row["Completion"].ToString());
                this.projectId = Convert.ToInt32(row["projectId"].ToString());
                this.dateCreated = Convert.ToDateTime(row["dateCreated"].ToString());
                this.deadLine = Convert.ToDateTime(row["Deadline"].ToString());
            }
        }

        public static int taskIsValid(Task t)
        {
            
            return TaskDAL.taskIsValid(t);
        }

        public static void showErrorMessage(int errorCode)
        {
            TaskDAL.showErrorMessage(errorCode);
        }

        public static void saveTask(Task t)
        {
            TaskDAL.saveTask(t);
        }

        static public DataTable getUserId(string userName)
        {
            return TaskDAL.getUserId(userName);
        }

        static public DataTable getTaskId(string taskName)
        {
            return TaskDAL.getTaskId(taskName);
        }

        static public DataTable getTask(int param)
        {
            return TaskDAL.getTask(param);
        }

        static public DataTable getRecentProjectMembers(int projectID)
        {
            return TaskDAL.getRecentProjectMembers(projectID);
        }

        static public DataTable getTasks()
        {
            return TaskDAL.getTasks();
        }

        static public DataTable FetchTaskByProject(int projectId)
        {
            return TaskDAL.FetchTaskByProject(projectId);
        }

        static public void deleteTask(int taskId)
        {
            TaskDAL.deleteTask(taskId);
        }

        static public void updateTask(Task t)
        {
            TaskDAL.updateTask(t);
        }

        static public void assignTaskToUser(int taskId, int userId)
        {
            TaskDAL.assignTaskToUser(taskId, userId);
        }

        static public DataTable getTaskAndUser(int param)
        {
            return TaskDAL.getTaskAndUser(param);
        }



        public int Id
        {
            get
            {
                return id;
            } set
            {
                id = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public int ProjectId
        {
            get
            {
                return projectId;
            }
            set
            {
                projectId = value;
            }
        }

        public int Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }

        public bool Completion
        {
            get
            {
                return completion;
            }
            set
            {
                completion = value;
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }
            set
            {
                dateCreated = value;
            }
        }

        public DateTime DeadLine
        {
            get
            {
                return deadLine;
            }
            set
            {
                deadLine = value;
            }
        }
        
    }
}
