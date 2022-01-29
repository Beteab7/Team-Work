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

            if (bunifuTextBox1.Text == " " || bunifuTextBox1.Text.Length < 1)
            {

                bunifuTextBox1.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox2.Text == " " || bunifuTextBox2.Text.Length < 1)
            {

                bunifuTextBox2.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox3.Text == "" || bunifuTextBox3.Text.Length < 1)
            {
                bunifuTextBox3.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox4.Text == " " || bunifuTextBox4.Text.Length < 1)
            {
                bunifuTextBox4.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox5.Text == " " || bunifuTextBox5.Text.Length < 1)
            {
                bunifuTextBox5.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox1.Text != " " && bunifuTextBox1.Text.Length > 0)
            {
                bunifuTextBox1.BorderColorIdle = Color.DarkGray;
                check = false;
            }
            if (bunifuTextBox2.Text != " " && bunifuTextBox2.Text.Length > 0)
            {
                bunifuTextBox2.BorderColorIdle = Color.DarkGray;
                check = false;
            }
            if (bunifuTextBox3.Text != " " && bunifuTextBox3.Text.Length > 0)
            {
                bunifuTextBox3.BorderColorIdle = Color.DarkGray;
                check = false;
            }
            if (bunifuTextBox4.Text != " " && bunifuTextBox4.Text.Length > 0)
            {
                bunifuTextBox4.BorderColorIdle = Color.DarkGray;
                check = false;
            }
            if (bunifuTextBox5.Text != " " && bunifuTextBox5.Text.Length > 0)
            {
                bunifuTextBox5.BorderColorIdle = Color.DarkGray;
                check = false;
            }


          


            if (check == false)
            {

                if (bunifuTextBox4.Text.CompareTo(bunifuTextBox5.Text) != 0)
                    MessageBox.Show("Incorrect Password");
                else
                {
                    u = new User(bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, bunifuTextBox4.Text);
                    u.saveUser();
                }
            }
        }
 
        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == " " || bunifuTextBox1.Text.Length < 1)
            {
                bunifuTextBox1.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox1.Text != " " && bunifuTextBox1.Text.Length > 0)
            {
                bunifuTextBox1.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (bunifuTextBox2.Text == " " || bunifuTextBox2.Text.Length < 1)
            {

                bunifuTextBox2.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox2.Text != " " && bunifuTextBox2.Text.Length > 0)
            {
                bunifuTextBox2.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (bunifuTextBox3.Text == "" || bunifuTextBox3.Text.Length < 1)
            {
                bunifuTextBox3.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox3.Text != " " && bunifuTextBox3.Text.Length > 0)
            {
                bunifuTextBox3.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (bunifuTextBox4.Text == " " || bunifuTextBox4.Text.Length < 1)
            {
                bunifuTextBox4.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox4.Text != " " && bunifuTextBox4.Text.Length > 0)
            {
                bunifuTextBox4.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (bunifuTextBox5.Text == " " || bunifuTextBox5.Text.Length < 1)
            {
                bunifuTextBox5.BorderColorIdle = Color.Red;
                check = true;
            }
            if (bunifuTextBox5.Text != " " && bunifuTextBox5.Text.Length > 0)
            {
                bunifuTextBox5.BorderColorIdle = Color.DarkGray;
                check = false;
            }
        }
    }
}
