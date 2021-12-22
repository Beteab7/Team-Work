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
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            bunifuLoginPage.SetPage("LoginPage");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuLoginPage.SetPage("RegisterPage");
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
            
            if (change == false) {
                txtUserName.Text = "";
                change = true;
                                 }
        }

        private void txtUserName_OnValueChanged(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            txtUserName.Text = UserName;
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            txtPassword.Text = password;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            change = false;
            if (change == false)
            {
                txtPassword.Text = "";
                txtPassword.isPassword = true;
                change = true;
            }

        }
    }
}
