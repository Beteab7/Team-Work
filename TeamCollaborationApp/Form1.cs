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
    public partial class Form1 : Form
    {
        static bool minMenu = false;
        public Form1()
        {
            InitializeComponent();
           // bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            //bunifuFormDock1.SubscribeControlToDragEvents(panel2);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void StartEvent(object sender, EventArgs e)
        {
            if(minMenu == true)
            {
                this.BunifuPage.Location = new System.Drawing.Point(41, 12);
                this.BunifuPage.Size = new System.Drawing.Size(762, 438);
            }
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Welcome");
        }

        private void ProjectEvent(object sender, EventArgs e)
        {
            if (minMenu == true)
            {
                this.BunifuPage.Location = new System.Drawing.Point(41, 12);
                this.BunifuPage.Size = new System.Drawing.Size(762, 438);
            }
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Project");
        }

        private void JournalEvent(object sender, EventArgs e)
        {
            if (minMenu == true)
            {
                this.BunifuPage.Location = new System.Drawing.Point(41, 12);
                this.BunifuPage.Size = new System.Drawing.Size(762, 438);
            }
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Journal");
          
        }

        private void ReferenceEvent(object sender, EventArgs e)
        {
            if (minMenu == true)
            {
                this.BunifuPage.Location = new System.Drawing.Point(41, 12);
                this.BunifuPage.Size = new System.Drawing.Size(762, 438);
            }
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Reference");

        }

        private void SettingEvent(object sender, EventArgs e)
        {
            if (minMenu == true)
            {
                this.BunifuPage.Location = new System.Drawing.Point(41, 12);
                this.BunifuPage.Size = new System.Drawing.Size(762, 438);
            }
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Setting");
        }

        private void indicator_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
                   
           
             


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void JournalPage_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (minMenu == false)
            {
               this.panel1.Size = new System.Drawing.Size(41, 450);
                shadowPanelMenu.Width = 45;
                shadowPanelMenu.Height = 561;


    
                this.BunifuPage.Location = new System.Drawing.Point(45, 12);
                this.BunifuPage.Size = new System.Drawing.Size(952, 549);
              



                minMenu = true;

            }
            else
            {
                this.panel1.Size = new System.Drawing.Size(173, 362);
                shadowPanelMenu.Width = 179;
                shadowPanelMenu.Height = 561;
                this.BunifuPage.Location = new System.Drawing.Point(166, 12);
                this.BunifuPage.Size = new System.Drawing.Size(822, 549);
              
                minMenu = false;
            }
        }
    }
}
