namespace Team_Collaboration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnResources = new System.Windows.Forms.Button();
            this.btnJournal = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pointBtn = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.settings1 = new Team_Collaboration.Settings();
            this.resources1 = new Team_Collaboration.Resources();
            this.journal1 = new Team_Collaboration.Journal();
            this.projects1 = new Team_Collaboration.Projects();
            this.start1 = new Team_Collaboration.Start();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResources
            // 
            this.btnResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResources.FlatAppearance.BorderSize = 0;
            this.btnResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResources.Image = ((System.Drawing.Image)(resources.GetObject("btnResources.Image")));
            this.btnResources.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResources.Location = new System.Drawing.Point(0, 279);
            this.btnResources.Name = "btnResources";
            this.btnResources.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResources.Size = new System.Drawing.Size(112, 74);
            this.btnResources.TabIndex = 4;
            this.btnResources.Text = "Resources";
            this.btnResources.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResources.UseVisualStyleBackColor = true;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnJournal
            // 
            this.btnJournal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJournal.FlatAppearance.BorderSize = 0;
            this.btnJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJournal.Image = ((System.Drawing.Image)(resources.GetObject("btnJournal.Image")));
            this.btnJournal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJournal.Location = new System.Drawing.Point(0, 205);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnJournal.Size = new System.Drawing.Size(112, 74);
            this.btnJournal.TabIndex = 3;
            this.btnJournal.Text = "Journal";
            this.btnJournal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // btnProject
            // 
            this.btnProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Image = ((System.Drawing.Image)(resources.GetObject("btnProject.Image")));
            this.btnProject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProject.Location = new System.Drawing.Point(0, 131);
            this.btnProject.Name = "btnProject";
            this.btnProject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProject.Size = new System.Drawing.Size(112, 74);
            this.btnProject.TabIndex = 2;
            this.btnProject.Text = "Projects";
            this.btnProject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.Location = new System.Drawing.Point(0, 57);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(112, 74);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Getting Started";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.panelLeft.Controls.Add(this.pointBtn);
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnResources);
            this.panelLeft.Controls.Add(this.btnJournal);
            this.panelLeft.Controls.Add(this.btnProject);
            this.panelLeft.Controls.Add(this.btnStart);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(112, 689);
            this.panelLeft.TabIndex = 1;
            // 
            // pointBtn
            // 
            this.pointBtn.BackColor = System.Drawing.Color.Black;
            this.pointBtn.Location = new System.Drawing.Point(97, 82);
            this.pointBtn.Name = "pointBtn";
            this.pointBtn.Size = new System.Drawing.Size(6, 24);
            this.pointBtn.TabIndex = 6;
            this.pointBtn.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(0, 615);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSettings.Size = new System.Drawing.Size(112, 74);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 57);
            this.panel2.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(112, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1278, 56);
            this.panelTop.TabIndex = 2;
            // 
            // settings1
            // 
            this.settings1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings1.Location = new System.Drawing.Point(112, 56);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(1278, 633);
            this.settings1.TabIndex = 7;
            this.settings1.Load += new System.EventHandler(this.settings1_Load);
            // 
            // resources1
            // 
            this.resources1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resources1.Location = new System.Drawing.Point(112, 56);
            this.resources1.Name = "resources1";
            this.resources1.Size = new System.Drawing.Size(1278, 633);
            this.resources1.TabIndex = 6;
            // 
            // journal1
            // 
            this.journal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journal1.Location = new System.Drawing.Point(112, 56);
            this.journal1.Name = "journal1";
            this.journal1.Size = new System.Drawing.Size(1278, 633);
            this.journal1.TabIndex = 5;
            // 
            // projects1
            // 
            this.projects1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projects1.Location = new System.Drawing.Point(112, 56);
            this.projects1.Name = "projects1";
            this.projects1.Size = new System.Drawing.Size(1278, 633);
            this.projects1.TabIndex = 4;
            // 
            // start1
            // 
            this.start1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start1.Location = new System.Drawing.Point(112, 56);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(1278, 633);
            this.start1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 689);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.resources1);
            this.Controls.Add(this.journal1);
            this.Controls.Add(this.projects1);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.Text = "Team Collaboration";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTop;
        private Start start1;
        private Projects projects1;
        private Journal journal1;
        private Resources resources1;
        private Settings settings1;
        private System.Windows.Forms.PictureBox pointBtn;
    }
}

