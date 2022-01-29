using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeamCollaborationApp
{
    public partial class Form1 : Form
    {
        // Dialogs
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog = new FontDialog();
        static private bool save = false;

        private void NewFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    MessageBox.Show("You need to save first! ");
                }
                else
                {
                    this.richTextBox1.Text = string.Empty;

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        private void SaveFile()
        {
            try
            {
                if(!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                       File.WriteAllText(saveFileDialog.FileName, this.richTextBox1.Text);
                }
                else
                {
                    MessageBox.Show("There's no text!");
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                save = true;
            }
        }
        private void OpenFile()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error While trying to open file!");
            }
            finally
            {
                openFileDialog = null;
                save = false;
            }
        }

        private void SaveFileAs()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text File (*.txt) | *.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        File.WriteAllText(saveFileDialog.FileName, this.richTextBox1.Text);
                }
                else
                {
                    MessageBox.Show("There's no text!");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                save = true;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            // bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            // bunifuFormDock1.SubscribeControlToDragEvents(panel2);
            for (int i = 0; i < 10; i++)
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
            label3.Text = "Getting Started";
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Welcome");
        }

        private void ProjectEvent(object sender, EventArgs e)
        {
            label3.Text = "Project";
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Project");
        }

        private void JournalEvent(object sender, EventArgs e)
        {
            label3.Text = "Journal";
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Journal");
          
        }

        private void ReferenceEvent(object sender, EventArgs e)
        {
            label3.Text = "Reference";
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Reference");

        }

        private void SettingEvent(object sender, EventArgs e)
        {
            label3.Text = "Setting";
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

      

        private void bunifuPictureBox1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            //bunifuUserControl1.Visible = true;
        }

        private void bunifuUserControl1_Click(object sender, EventArgs e)
        {

        }

        private void userNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                 if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Font = fontDialog.Font;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }

        private void profileSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BunifuPage.SetPage("Edit Profile");
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmlogin Login = new frmlogin();
            Login.Show();
            
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
