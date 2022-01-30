using System;
using System.Data;
namespace TeamCollaborationApp{
        class Project{
                public int ID;
                public int UserID;
                public string Name;
                public string Description;
                public DateTime BeginDate;
                public DateTime EndDate;
                ProjectDAL pd;
                
                //----------------------------------------------------------------//
                //Constructors
                public Project(int UserID){
                        //Fetching Tables
                        this.UserID = UserID;
                        pd = new ProjectDAL();

                    }
                public Project(int UserID, int ID){
                        
                        //
                        
                        this.UserID = UserID;
                        this.ID = ID;
                        pd = new ProjectDAL();
                }
                public Project(int ID, int UserID, string Name, string Description, DateTime BeginDate, DateTime EndDate){
                        
                        //manipulate existing project
            
                        this.ID = ID;
                        this.UserID = UserID;
                        this.Name = Name;
                        this.Description = Description;
                        this.BeginDate = BeginDate;
                        this.EndDate = EndDate;
                        pd = new ProjectDAL();
                }
                public Project(int UserID, string Name, string Description, DateTime BeginDate, DateTime EndDate){
                        
                        //insert new project
                        
                        this.UserID = UserID;
                        this.Name = Name;
                        this.Description = Description;
                        this.BeginDate = BeginDate;
                        this.EndDate = EndDate;
                        pd = new ProjectDAL();
                }

                //----------------------------------------------------------------//
                //Methods
                public void InsertProject(){
                        pd.InsertProject(this);
                }
                public DataTable getProject(){
                        return pd.getProject(UserID);
                }
                public void DeleteProject(){
                        pd.DeleteProject(UserID,ID);
                }
                public void UpdateProject(){
                        pd.UpdateProject(this);
                }
                public DataTable searchProject(string nameQuery){
                        return pd.searchProject(UserID, nameQuery);
                }
        }
}