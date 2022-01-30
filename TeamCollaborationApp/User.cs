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
        Form1 obj;
        internal int id;
        internal string fullname="";
        internal string firstname="";
        internal string lastname="";
        internal string email="";
        internal string username="";
        internal string phonenumber="";
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
        public void GetUserDetails( string username, string Fname,string lname, string phone, string email , string password )
        {
            //this.id = id;
            this.username = username;
            this.firstname = Fname;
            this.lastname = lname;
            this.phonenumber = phone;
            this.email = email;
            this.password = password;
            this.fullname = Fname + " " + lname;
        }
        public void initalizeUserDetail()
        {
          //This method will specify UserDetail
          //obj.LblUserName = username;
            
        }
        public void initalizeUserDetailEditPage(Form1 obj)
        {
            obj.TxtbEditFirstname = firstname;
            obj.TxtbEditLastname = lastname;
            obj.TxtbEditEmail = email;
            obj.TxtbEditUsername = username;
            obj.TxtbEditPhone = phonenumber;
        }
        public bool checkChange(Form1 obj)
        {
            if (obj.TxtbEditFirstname != firstname ||
                obj.TxtbEditLastname != lastname   ||
                obj.TxtbEditEmail != email         ||
                obj.TxtbEditUsername != username   ||
                obj.TxtbEditPhone != phonenumber   
                )
            return true;
            return false;
        }

        public  void authentication(string username , string password,frmlogin LoginPage)
        {
            bool value = OBJ.Authentication_StoredProcedure(username, password);
            if (value == true)
            {
                OBJ.GetUserDetails_StoredProcedure(username, this );
                initalizeUserDetail();
                {
                    id = OBJ.fetchUserID(username);
                    obj = new Form1(id);
                    LoginPage.Hide();
                    obj.Show();
                }
            }
            else
                MessageBox.Show("Invalid Username or Password");



            

        }
        

        public void saveUser()
        {
            OBJ.SaveSignUp_StoredProcedure(this);
        }

    }
}
