using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaborationApp
{
    class User
    {
        DAL OBJ = new DAL();

        internal string fullname;
        internal string email;
        internal string username; 
        internal byte[] photo;
        internal string password;

        public User()
        {

        }
        public User(string fullname, string email, string username, string password)
        {

            this.fullname = fullname;
            this.email = email;
            this.username = username;
            this.password = password;
         

        }

        public bool authentication(string username , string password )
        {
            bool value = OBJ.Authentication_StoredProcedure(username, password);
            return value;
                
            
        }

        public void saveUser()
        {
            OBJ.SignUpUser_StoredProcedure(this);
        }

    }
}
