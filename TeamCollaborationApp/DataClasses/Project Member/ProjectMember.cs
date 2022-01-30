using System;
using System.Data;
namespace TeamCollaborationApp{
    class ProjectMember{
        public int projectID;
        public int userID;
        public DateTime dateAdded;
        ProjectMemberDAL pmd;
        public ProjectMember(int projectID, int userID){
            this.projectID = projectID;
            this.userID = userID;
            pmd = new ProjectMemberDAL();
        }
        public void insertProjectMember(){
            pmd.insertProjectMember(projectID, userID);
        }
        public void deleteProjectMember(){
            pmd.deleteProjectMember(projectID, userID);
        }
        public DataTable getRecentProjectMembers(){
            return pmd.getRecentProjectMembers(projectID);
        }
        public DataTable getOldProjectMembers(){
            return pmd.getOldProjectMembers(projectID);
        }
        public DataTable searchProjectMembers(string query){
            return pmd.searchProjectMembers(projectID, query);
        }
        ////////////////////////////////////////////////////////////////////////////////////
        public void ShowTable(DataTable table) {
            foreach (DataColumn col in table.Columns) {
                Console.Write("{0,-14}", col.ColumnName);
            }
            Console.WriteLine();

            foreach (DataRow row in table.Rows) {
                foreach (DataColumn col in table.Columns) {
                    if (col.DataType.Equals(typeof(DateTime)))
                    Console.Write("{0,-14:d}", row[col]);
                    else if (col.DataType.Equals(typeof(Decimal)))
                    Console.Write("{0,-14:C}", row[col]);
                    else
                    Console.Write("{0,-14}", row[col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
