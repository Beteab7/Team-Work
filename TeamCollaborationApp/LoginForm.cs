using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamCollaborationApp
{
    public partial class frmlogin : Form
    {
         
        static bool check = false;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.authentication(txtUserName.Text, txtPassword.Text, this);

        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuLoginPage.SetPage("SignUpPage");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {

        }

        private void txtUserName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bunifuLoginPage.SetPage("LoginPage");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            User u = new User();

            if (txtbSignUpFullName.Text == " " || txtbSignUpFullName.Text.Length < 1)
            {

                txtbSignUpFullName.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpEmail.Text == " " || txtbSignUpEmail.Text.Length < 1)
            {

                txtbSignUpEmail.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpUsername.Text == "" || txtbSignUpUsername.Text.Length < 1)
            {
                txtbSignUpUsername.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpPassword.Text == " " || txtbSignUpPassword.Text.Length < 1)
            {
                txtbSignUpPassword.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpRePassword.Text == " " || txtbSignUpRePassword.Text.Length < 1)
            {
                txtbSignUpRePassword.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpFullName.Text != " " && txtbSignUpFullName.Text.Length > 0)
            {
                txtbSignUpFullName.BorderColorIdle = Color.DarkGray;
                check = false;
            }
            if (txtbSignUpEmail.Text != " " && txtbSignUpEmail.Text.Length > 0)
            {
                txtbSignUpEmail.BorderColorIdle = Color.DarkGray;
                check = false;
            }
            if (txtbSignUpUsername.Text != " " && txtbSignUpUsername.Text.Length > 0)
            {
                txtbSignUpUsername.BorderColorIdle = Color.DarkGray;
                check = false;
            }
            if (txtbSignUpPassword.Text != " " && txtbSignUpPassword.Text.Length > 0)
            {
                txtbSignUpPassword.BorderColorIdle = Color.DarkGray;
                check = false;
            }
            if (txtbSignUpRePassword.Text != " " && txtbSignUpRePassword.Text.Length > 0)
            {
                txtbSignUpRePassword.BorderColorIdle = Color.DarkGray;
                check = false;
            }


          


            if (check == false)
            {

                if (txtbSignUpPassword.Text.CompareTo(txtbSignUpRePassword.Text) != 0)
                    MessageBox.Show("Incorrect Password");
                else
                {
                    u = new User(txtbSignUpFullName.Text, txtbSignUpEmail.Text, txtbSignUpUsername.Text, txtbSignUpPassword.Text);
                    u.saveUser("signup");
                }
            }
        }
 
        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtbSignUpFullName.Text == " " || txtbSignUpFullName.Text.Length < 1)
            {
                txtbSignUpFullName.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpFullName.Text != " " && txtbSignUpFullName.Text.Length > 0)
            {
                txtbSignUpFullName.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtbSignUpEmail.Text == " " || txtbSignUpEmail.Text.Length < 1)
            {

                txtbSignUpEmail.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpEmail.Text != " " && txtbSignUpEmail.Text.Length > 0)
            {
                txtbSignUpEmail.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtbSignUpUsername.Text == "" || txtbSignUpUsername.Text.Length < 1)
            {
                txtbSignUpUsername.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpUsername.Text != " " && txtbSignUpUsername.Text.Length > 0)
            {
                txtbSignUpUsername.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (txtbSignUpPassword.Text == " " || txtbSignUpPassword.Text.Length < 1)
            {
                txtbSignUpPassword.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpPassword.Text != " " && txtbSignUpPassword.Text.Length > 0)
            {
                txtbSignUpPassword.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (txtbSignUpRePassword.Text == " " || txtbSignUpRePassword.Text.Length < 1)
            {
                txtbSignUpRePassword.BorderColorIdle = Color.Red;
                check = true;
            }
            if (txtbSignUpRePassword.Text != " " && txtbSignUpRePassword.Text.Length > 0)
            {
                txtbSignUpRePassword.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }
    }
}
