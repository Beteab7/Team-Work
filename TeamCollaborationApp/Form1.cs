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
        
        public Form1()
        {
            InitializeComponent();
            // bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            //bunifuFormDock1.SubscribeControlToDragEvents(panel2);
            for (int i = 0; i < 50; i++)
            {
                grid.Rows.Add(new object[]{ 
                 });
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void StartEvent(object sender, EventArgs e)
        {
           
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Welcome");
        }

        private void ProjectEvent(object sender, EventArgs e)
        {
           
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Project");
        }

        private void JournalEvent(object sender, EventArgs e)
        {
          
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Journal");
          
        }

        private void ReferenceEvent(object sender, EventArgs e)
        {
           
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Reference");

        }

        private void SettingEvent(object sender, EventArgs e)
        {
            
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
           
            
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
             
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            
           
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
          
            BunifuPage.SetPage("ProjectCreation");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

   
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
