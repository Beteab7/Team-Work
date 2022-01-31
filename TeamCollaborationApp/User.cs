using System;
using System.Collections.Generic;
using System.Data;
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
        internal static int id;
        public int Id { get { return id; } }

        internal static string fullname = "";
        internal static string firstname = "";
        internal static string lastname = "";
        internal static string email = "";
        internal static string username = "";
        internal static string phonenumber = "";
        // internal byte[] photo;
        internal static string password = "";

        public User()
        {

        }
       
        public User(string a, string b, string c, string d)
        {

            fullname = a;
            email = b;
            username = c;
            password = d;


        }
        public bool CheckNewPasswordValidity(string newpassword, string repeatPassword)
        {
            if (newpassword != repeatPassword)
                return false;
            return true;
        }
        public bool checkOldPasswordValidity(string oldPassword)
        {
            if (oldPassword != password)
                return false;
            return true;
        }
        public void changePassword(string newPassword)
        {
            OBJ.ChangePassword_StoredProcedure(newPassword);
        }
        public void GetUserDetails(int a, string b, string c, string d, string e, string f, string g)
        {
            id = a;
            username = b;
            firstname = c;
            lastname = d;
            phonenumber = e;
            email = f;
            password = g;
            fullname = c + " " + d;


        }

        
        public void GetUserDetails(int a, string b, string c, string d, string e, string f)
        {
            id = a;
            username = b;
            firstname = c;
            lastname = d;
            phonenumber = f;
            email = e;

            fullname = c + " " + d;


        }
        public void initalizeUserDetail()
        {
            
            obj.UserToolStripMenuItem = username;
        }
        public void initalizeUserDetailEditPage(Form1 obj)
        {

            obj.TxtbEditFirstname = firstname;

            obj.TxtbEditLastname = lastname;
            obj.TxtbEditEmail = email;
            obj.TxtbEditUsername = username;
            obj.TxtbEditPhone = phonenumber;
            obj.TxtbEditPageId = Convert.ToString(id);
            obj.BunifuLabel2 = username;
        }
        public bool checkChange(Form1 obj)
        {
           
            if (obj.TxtbEditFirstname != firstname ||
                obj.TxtbEditLastname != lastname ||
                obj.TxtbEditEmail != email ||
                obj.TxtbEditUsername != username ||
                obj.TxtbEditPhone != phonenumber
                )
                return true;
            return false;
        }

        public void authentication(string username, string password, frmlogin LoginPage)
        {

            bool value = OBJ.Authentication_StoredProcedure(username, password);
            if (value == true)
            {
                OBJ.GetUserDetails_StoredProcedure(username, this);
                {
                  
                    obj = new Form1();
                    LoginPage.Hide();
                    obj.Show();
                }
                initalizeUserDetail();
            }
            else
                MessageBox.Show("Invalid Username or Password");
        }
        public void saveUser(string par)
        {
            
            if (par == "signup")
                OBJ.SaveSignUp_StoredProcedure();
            else if (par == "editUser")
                OBJ.SaveUser_StoredProcedure();
        }
        public DataTable getUsers()
        {
            return OBJ.getUsers();
        }

    }
}
