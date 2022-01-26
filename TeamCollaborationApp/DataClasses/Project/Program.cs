using System;
//namespace created for testing purposes
//After testing all in this directory except Project.cs and ProjectDAL.cs will be removed
//the namespace will be renamed to TeamCollaborationApp
namespace TTa{
    class Program{
        public static void Main(){
                ProjectDAL pd = new ProjectDAL();
                pd.getProject(new Project("123","244","C#","Final Project"));
            }
        }
}