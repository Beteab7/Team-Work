using System;
using System.Data;
//namespace created for testing purposes
//After testing all in this directory except Project.cs and ProjectDAL.cs will be removed
//the namespace will be renamed to TeamCollaborationApp
namespace TTa{
    class Program{
        public static void Main(){
                Project p = new Project("U-000000001","Contact Book","Contact Book made with cpp, tracks contacts", new DateTime(2021,1,1), new DateTime(2021,3,4));
                p.InsertProject();




                // Project p = new Project("U-000000001");
                // p.ShowTable(p.getProject());
            }
        }
}