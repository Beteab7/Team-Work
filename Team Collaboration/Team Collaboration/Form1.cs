using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Collaboration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start1.BringToFront();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start1.BringToFront();
            pointBtn.Top = ((Control)sender).Top+25;
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            projects1.BringToFront();
            pointBtn.Top = ((Control)sender).Top+25;
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            journal1.BringToFront();
            pointBtn.Top = ((Control)sender).Top+25;
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            resources1.BringToFront();
            pointBtn.Top = ((Control)sender).Top+25;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings1.BringToFront();
            pointBtn.Top = ((Control)sender).Top+25;
        }

        private void settings1_Load(object sender, EventArgs e)
        {

        }
    }
}
