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
        static private bool Passchange = false;
        int ProjectResultSet;
        
        int currentUserID;
        int projectID;
        int taskId;
        Project p;
        Task t;
        User u;
        public Form1(User user)
        {
            InitializeComponent();
            u = user;
            currentUserID = u.Id;

        }
       
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
            User u = new User();
            label3.Text = "Project";
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Project");
            

            p = new Project(currentUserID);
            dgvProject.DataSource = p.getProject();
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
            panel12.Visible = true;
           
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
        public void Editprofile()
        {
            BunifuPage.SetPage("Edit Profile");

            User u = new User();
            u.initalizeUserDetailEditPage(this);
        }
        private void profileSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editprofile();
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

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Editprofile();
           

        }
       

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            BunifuPage.SetPage("Edit Project");
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            BunifuPage.SetPage("Edit Task");
        }

         

    

        private void dgvProject_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //next tab- task list
            TaskDAL op = new TaskDAL();
            projectID = Convert.ToInt32(dgvProject.CurrentRow.Cells[0].Value);
            txtProjectNameList.Text = dgvProject.CurrentRow.Cells[1].Value.ToString();
            txtDescListTask.Text = dgvProject.CurrentRow.Cells[2].Value.ToString();
            
            dataGridView1.DataSource = op.FetchTaskByProject(projectID);
            //edit tab, found in settings
            txtProjectNameEdit.Text = dgvProject.CurrentRow.Cells[1].Value.ToString();
            txtDescriptionProjectEdit.Text = dgvProject.CurrentRow.Cells[2].Value.ToString();
            dateTimeStartProjectEdit.Value = Convert.ToDateTime(dgvProject.CurrentRow.Cells[3].Value);
            dateTimeEndProjectEdit.Value = Convert.ToDateTime(dgvProject.CurrentRow.Cells[4].Value);
        }

        private void dgvProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvProject_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TaskDAL op = new TaskDAL();
            dataGridView1.DataSource = op.FetchTaskByProject(projectID);
            BunifuPage.SetPage("ListTask");
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            //reload project data grid view
            p = new Project(currentUserID);
            dgvProject.DataSource = p.getProject();
            ProjectResultSet = p.getProject().Rows.Count;
            if (ProjectResultSet > 0)
                 label11.Text = Convert.ToString(ProjectResultSet) + " Results ";
            

        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            //save new project
            p = new Project(currentUserID, txtProjectName.Text, txtDescription.Text, dateTimeStartProject.Value, dateTimeEndProject.Value);
            p.InsertProject();
        }

        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            p = new Project(currentUserID);
            dgvProject.DataSource = p.searchProject(txtProjectSearch.Text);
        }

        private void btnSaveProjectEdit_Click(object sender, EventArgs e)
        {
            dgvProject.DataSource = p.getProject();
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("UserInfo");
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("ChangePassword");
        }

        private void bunifuButton17_Click(object sender, EventArgs e)
        {

            User u = new User();

            if (u.checkOldPasswordValidity(txtbOldPassword.Text))
            {
                if (u.CheckNewPasswordValidity(txtbNewPassword.Text, txtbRePassword.Text))
                    u.changePassword(txtbNewPassword.Text);
                else
                    MessageBox.Show("Password not the same!!");

            }
            else
                MessageBox.Show("Incorrect Password");
        }

        private void bunifuButton15_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton8_Click_1(object sender, EventArgs e)
        {
            User u = new User();
            bool value = u.checkChange( this);


            if (value == true)
            {
                u.GetUserDetails(Convert.ToInt32(txtbEditPageId.Text), txtbEditUsername.Text, txtbEditFirstname.Text, txtbEditLastname.Text, txtbEditPhone.Text, txtbEditEmail.Text );
                u.saveUser("editUser");
            }
            else
                MessageBox.Show("No Change has been made");
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            User u = new User();
            bool value = u.checkChange(this);


            if (value == true)
            {
                u.initalizeUserDetailEditPage(this);
            }
            else
                MessageBox.Show("No change have been made!!");
        }

        private void btnSaveProjectEdit_Click_1(object sender, EventArgs e)
        {
            //save on project edit tab
            p = new Project(projectID, currentUserID, txtProjectNameEdit.Text, txtDescriptionProjectEdit.Text, dateTimeStartProjectEdit.Value, dateTimeEndProjectEdit.Value);
            p.UpdateProject();
            BunifuPage.SetPage("Project");
        }

        private void btnCancelProjectEdit_Click(object sender, EventArgs e)
        {
            //cancel on project edit tab
            BunifuPage.SetPage("Project");
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            p = new Project(projectID, currentUserID, txtProjectNameEdit.Text, txtDescriptionProjectEdit.Text, dateTimeStartProjectEdit.Value, dateTimeEndProjectEdit.Value);
            p.DeleteProject();
            BunifuPage.SetPage("Project");
        }

        private void txtProjectNameList_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveTaskEdit_Click(object sender, EventArgs e)
        {
            int id = t.Id;
            t = new Task();
            t.Id = id;
            t.Name = txtTaskNameEdit.Text;
            t.Description = txtTaskDescriptionEdit.Text;
            t.Priority = cmbPriorityEdit.SelectedIndex + 1;
            t.Completion = tskStat.Checked;
            t.ProjectId = projectID;
            t.DeadLine = Convert.ToDateTime(dateTimeDeadlineEdit.Text);
            TaskDAL op = new TaskDAL();
            int cd = op.taskIsValid(t);
            if (cd != 0)
                op.showErrorMessage(cd);
            else
            {
                try
                {
                    op.updateTask(t);
                    btnSaveTaskEdit.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void createTask_Click(object sender, EventArgs e)
        {
            t = new Task();
            t.Name = richTextBox3.Text;
            t.Description = richTextBox2.Text;
            t.Completion = false;
            t.DeadLine = Convert.ToDateTime(dateTimePicker1.Text);
            t.Priority = comboBox2.SelectedIndex + 1;
            t.ProjectId = projectID;
            TaskDAL op = new TaskDAL();
            int cd = op.taskIsValid(t);
            if (cd != 0)
                op.showErrorMessage(cd);
            else
            {
                try
                {
                    op.saveTask(t);
                    richTextBox3.Text = "";
                    richTextBox2.Text = "";
                    dataGridView1.DataSource = op.FetchTaskByProject(projectID);
                    BunifuPage.SetPage("ListTask");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            TaskDAL op = new TaskDAL();
            for (int i = 0; i < (personsToGetAssigned.SelectedCells.Count); i++)
            {
                string fullName = personsToGetAssigned.SelectedCells[i].EditedFormattedValue.ToString();
                string firstName = fullName.Split(' ')[0];
                int id = Convert.ToInt32(op.getUserId(firstName).Rows[0][0]);
                t.Id = Convert.ToInt32(op.getTaskId(t.Name).Rows[0][0]);
                op.assignTaskToUser(t.Id, id);
            }
        }
        */

        private void btnCancelTaskEdit_Click(object sender, EventArgs e)
        {
             txtTaskNameEdit.Text = "";
             txtTaskDescriptionEdit.Text = "";
             t.Priority = cmbPriorityEdit.SelectedIndex + 1;
             dateTimeDeadlineEdit.Text = Convert.ToString(DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskDAL tsk = new TaskDAL();
            dataGridView1.DataSource = tsk.FetchTaskByProject(projectID);
            BunifuPage.SetPage("ListTask");
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            TaskDAL tsk = new TaskDAL();
            dataGridView1.DataSource = tsk.FetchTaskByProject(projectID);
            BunifuPage.SetPage("ListTask");
        }

        private void back_Click(object sender, EventArgs e)
        {
            TaskDAL tsk = new TaskDAL();
            dataGridView1.DataSource = tsk.FetchTaskByProject(projectID);
            BunifuPage.SetPage("ListTask");
        }

        private void cmbProjectColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton19_Click(object sender, EventArgs e)
        {
            TaskDAL tsk = new TaskDAL();
            dataGridView1.DataSource = tsk.FetchTaskByProject(projectID);
            BunifuPage.SetPage("ListTask");
        }

        private void bunifuButton20_Click(object sender, EventArgs e)
        {
            TaskDAL tsk = new TaskDAL();
            dataGridView1.DataSource = tsk.FetchTaskByProject(projectID);
            BunifuPage.SetPage("ListTask");
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            TaskDAL tsk = new TaskDAL();
            dataGridView1.DataSource = tsk.getTasks();
            BunifuPage.SetPage("Edit Task");
        }

        private void bunifuButton3_Click_2(object sender, EventArgs e)
        {
            BunifuPage.SetPage("AddTask");
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            t = new Task();
            t.Name = richTextBox3.Text;
            t.Description = richTextBox2.Text;
            t.Completion = false;
            t.DeadLine = Convert.ToDateTime(dateTimePicker1.Text);
            t.Priority = comboBox2.SelectedIndex + 1;
            t.ProjectId = projectID;
            TaskDAL op = new TaskDAL();
            int cd = op.taskIsValid(t);
            if (cd != 0)
                op.showErrorMessage(cd);
            else
            {
                try
                {
                    op.saveTask(t);
                    richTextBox3.Text = "";
                    richTextBox2.Text = "";
                    dataGridView1.DataSource = op.FetchTaskByProject(projectID);
                    BunifuPage.SetPage("ListTask");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }           

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TaskDAL op = new TaskDAL();
            DataTable table = op.getTask(Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()));
            
            t = new Task(table);
            txtTaskNameEdit.Text = t.Name;
            txtTaskDescriptionEdit.Text = t.Description;
            dateTimeDeadlineEdit.Text = t.DeadLine.ToString();
            cmbPriorityEdit.SelectedIndex = t.Priority - 1;
            tskStat.Checked = t.Completion;
            BunifuPage.SetPage("Edit Task");
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            TaskDAL op = new TaskDAL();
            dataGridView6.DataSource = op.getTaskAndUser(t.Id);
            dataGridView7.DataSource = op.getRecentProjectMembers(projectID);
            BunifuPage.SetPage("AddTaskMember");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TaskDAL ts = new TaskDAL();
            try{
                ts.deleteTask(t.Id);
                dataGridView1.DataSource = ts.FetchTaskByProject(projectID);
                BunifuPage.SetPage("ListTask");
             }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tskStat_CheckedChanged(object sender, EventArgs e)
        {
            btnSaveTaskEdit.Enabled = true;
        }

        private void dataGridView7_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView6.DataSource = dataGridView7.SelectedRows;
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            TaskDAL op = new TaskDAL();
            for (int i = 0; i < (dataGridView7.SelectedCells.Count); i++)
            {
                string fullName = dataGridView7.SelectedCells[i].EditedFormattedValue.ToString();
                string firstName = fullName.Split(' ')[0];
                int id = Convert.ToInt32(op.getUserId(firstName).Rows[0][0]);
                t.Id = Convert.ToInt32(op.getTaskId(t.Name).Rows[0][0]);
                op.assignTaskToUser(t.Id, id);
            }
            dataGridView6.DataSource = op.getTaskAndUser(t.Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BunifuPage.SetPage("Edit Task");
        }

        private void bunifuButton2_Click_2(object sender, EventArgs e)
        {
            BunifuPage.SetPage("Project");
        }
    }
}
