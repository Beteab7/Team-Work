using System;
using System.Data;
namespace TTa{
        class Project{
                public string ID;
                public string UserID;
                public string Name;
                public string Description;
                public DateTime BeginDate;
                public DateTime EndDate;
                ProjectDAL pd;
                public Project(string UserID){
                        this.UserID = UserID;
                        pd = new ProjectDAL();
                }
                public Project(string ID, string UserID, string Name, string Description, DateTime BeginDate, DateTime EndDate){
                        this.ID = ID;
                        this.UserID = UserID;
                        this.Name = Name;
                        this.Description = Description;
                        this.BeginDate = BeginDate;
                        this.EndDate = EndDate;
                        pd = new ProjectDAL();
                }
                public Project(string UserID, string Name, string Description, DateTime BeginDate, DateTime EndDate){
                        this.UserID = UserID;
                        this.Name = Name;
                        this.Description = Description;
                        this.BeginDate = BeginDate;
                        this.EndDate = EndDate;
                        pd = new ProjectDAL();
                }
                public void InsertProject(){
                        pd.InsertProject(this);
                }
                public DataTable getProject(){
                        return pd.getProject(UserID);
                }



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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