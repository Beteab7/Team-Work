using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamCollaborationApp
{
    class User
    {
        DAL OBJ = new DAL();
        Form1 obj = new Form1();
        internal int id;
        internal string fullname;
        internal string firstname;
        internal string lastname;
        internal string email;
        internal string username;
        internal string phonenumber;
       // internal byte[] photo;
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
        public void GetUserDetails(int id,string username, string Fname,string lname, string phone, string email , string password )
        {
            this.id = id;
            this.username = username;
            this.firstname = Fname;
            this.lastname = lname;
            this.phonenumber = phone;
            this.email = email;
            this.password = password;
 }
        public void initalizeUserDetail()
        {
          //This method will specify UserDetail
          //obj.LblUserName = username;
            
        }
        public void initalizeUserDetailEditPage(Form1 obj)
        {  
           
        }

        public  void authentication(string username , string password,frmlogin LoginPage)
        {
            bool value = OBJ.Authentication_StoredProcedure(username, password);
            if (value == true)
            {
                OBJ.GetUserDetails_StoredProcedure(username, this );
                initalizeUserDetail();
                {
                    LoginPage.Hide();
                    obj.Show();
                }
            }
            else
                MessageBox.Show("Invalid Username or Password");



            

        }
        

        public void saveUser()
        {
            OBJ.SignUpUser_StoredProcedure(this);
        }

    }
}
