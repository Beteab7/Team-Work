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

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            if (txtSignUpEmail.Text == " " || txtSignUpEmail.Text.Length < 1)
            {

                txtSignUpEmail.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignUpEmail.Text != " " && txtSignUpEmail.Text.Length > 0)
            {
                txtSignUpEmail.LineIdleColor = Color.DarkGray;
                check = false;
            }
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

            if (txtSignupFullName.Text == " " || txtSignupFullName.Text.Length < 1)
            {

                txtSignupFullName.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignUpEmail.Text == " " || txtSignUpEmail.Text.Length < 1)
            {
               
                txtSignUpEmail.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignUpUserName.Text == "" || txtSignUpUserName.Text.Length < 1)
            {
                txtSignUpUserName.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignUpPassword.Text == " " || txtSignUpPassword.Text.Length < 1)
            {
                txtSignUpPassword.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignUpRepeatPassword.Text == " " || txtSignUpRepeatPassword.Text.Length < 1)
            {
                txtSignUpRepeatPassword.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignupFullName.Text != " " && txtSignupFullName.Text.Length > 0)
            {
                txtSignupFullName.LineIdleColor = Color.DarkGray;
                check = false;
            }
            if (txtSignUpEmail.Text != " " && txtSignUpEmail.Text.Length > 0)
            {
                txtSignUpEmail.LineIdleColor = Color.DarkGray;
                check = false;
            }
            if (txtSignUpUserName.Text != " " && txtSignUpUserName.Text.Length > 0)
            {
                txtSignUpUserName.LineIdleColor = Color.DarkGray;
                check = false;
            }
            if (txtSignUpPassword.Text != " " && txtSignUpPassword.Text.Length > 0)
            {
                txtSignUpPassword.LineIdleColor = Color.DarkGray;
                check = false;
            }
            if (txtSignUpRepeatPassword.Text != " " && txtSignUpRepeatPassword.Text.Length > 0)
            {
                txtSignUpRepeatPassword.LineIdleColor = Color.DarkGray;
                check = false;
            }


          


            if (check = false)
            {

                if (txtSignUpPassword.Text.CompareTo(txtSignUpRepeatPassword.Text) != 0)
                    MessageBox.Show("Incorrect Password");
                else
                {
                    u = new User(txtSignupFullName.Text, txtSignUpEmail.Text, txtSignUpUserName.Text, txtSignUpPassword.Text);
                   // u.saveUser();
                }
            }
        }

        private void txtSignupFullName_OnValueChanged(object sender, EventArgs e)
        {
            if (txtSignupFullName.Text == " " || txtSignupFullName.Text.Length < 1)
            {

                txtSignupFullName.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignupFullName.Text != " " && txtSignupFullName.Text.Length > 0)
            {
                txtSignupFullName.LineIdleColor = Color.DarkGray;
                check = false;
            }
        }

        private void txtSignUpUserName_OnValueChanged(object sender, EventArgs e)
        {
            if (txtSignUpUserName.Text == "" || txtSignUpUserName.Text.Length < 1)
            {
                txtSignUpUserName.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignUpUserName.Text != " " && txtSignUpUserName.Text.Length > 0)
            {
                txtSignUpUserName.LineIdleColor = Color.DarkGray;
                check = false;
            }
        }

        private void txtSignUpPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (txtSignUpPassword.Text == " " || txtSignUpPassword.Text.Length < 1)
            {
                txtSignUpPassword.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignUpPassword.Text != " " && txtSignUpPassword.Text.Length > 0)
            {
                txtSignUpPassword.LineIdleColor = Color.DarkGray;
                check = false;
            }
        }

        private void txtSignUpRepeatPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (txtSignUpRepeatPassword.Text == " " || txtSignUpRepeatPassword.Text.Length < 1)
            {
                txtSignUpRepeatPassword.LineIdleColor = Color.Red;
                check = true;
            }
            if (txtSignUpRepeatPassword.Text != " " && txtSignUpRepeatPassword.Text.Length > 0)
            {
                txtSignUpRepeatPassword.LineIdleColor = Color.DarkGray;
                check = false;
            }
        }
    }
}
