using System;
using System.Data.SqlClient;
using System.Data;

namespace TTa{
   class ProjectDAL{
        string constr = "Server = (local); database = Team; uid = abc; pwd = 123";
        public void getProject(Project p){
            using (SqlConnection con = new SqlConnection(constr)){
                    Console.WriteLine("Works");
                }
            }
    }
}