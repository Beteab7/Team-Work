using System;
using System.Data.SqlClient;
using System.Data;

namespace TeamCollaborationApp{
    class OrganizationDal{
        string constr = "Server = HP-NOTEBOOK; database = Team; uid = Lab; Pwd = 123; ";
        public void getOrganization(Organization org){
            try {
                using (SqlConnection con = new SqlConnection(constr)){
                    
                }

            }
            catch (SqlException ex) {
                    MessageBox.Show(ex.Message);

                }
            }
    }
}