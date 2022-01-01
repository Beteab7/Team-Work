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
        static bool change = false;
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
            u.authentication(txtUserName.Text, txtPassword.Text,this);

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
           
                if (txtSignupFullName.Text == " " || txtSignupFullName.Text.Length < 1)
                    txtSignupFullName.LineIdleColor = Color.Red;
                if (txtSignUpEmail.Text == " ")
                    txtSignUpEmail.LineIdleColor = Color.Red;
                if (txtSignUpUserName.Text == " ")
                    txtSignUpUserName.LineIdleColor = Color.Red;
                if (txtSignUpPassword.Text == " ")
                    txtSignUpPassword.LineIdleColor = Color.Red;
                if (txtSignUpRepeatPassword.Text == " ")
                    txtSignUpRepeatPassword.LineIdleColor = Color.Red;

           

            if (txtSignupFullName.Text != "")
                txtSignupFullName.LineIdleColor = Color.DarkGray;
            if (txtSignUpEmail.Text != "")
                txtSignUpEmail.LineIdleColor = Color.DarkGray;
            if (txtSignUpUserName.Text != "")
                txtSignUpUserName.LineIdleColor = Color.DarkGray;
            if (txtSignUpPassword.Text != "")
                txtSignUpPassword.LineIdleColor = Color.DarkGray;
            if (txtSignUpRepeatPassword.Text != "")
                txtSignUpRepeatPassword.LineIdleColor = Color.DarkGray;

            if (txtSignUpPassword.Text.CompareTo(txtSignUpRepeatPassword.Text) != 0)
                MessageBox.Show("Incorrect Password");
            else
            {
                User u = new User(txtSignupFullName.Text, txtSignUpEmail.Text, txtSignUpUserName.Text, txtSignUpPassword.Text);
                u.saveUser();
            }
        }
    }
}
