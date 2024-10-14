namespace Skills.Screens
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.NavigationWrapper = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnClassManagement = new System.Windows.Forms.Button();
            this.BtnTeacherManagement = new System.Windows.Forms.Button();
            this.BtnStudentManagement = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.NavigationWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationWrapper
            // 
            this.NavigationWrapper.BackColor = System.Drawing.Color.Lavender;
            this.NavigationWrapper.Controls.Add(this.BtnLogout);
            this.NavigationWrapper.Controls.Add(this.BtnClassManagement);
            this.NavigationWrapper.Controls.Add(this.BtnTeacherManagement);
            this.NavigationWrapper.Controls.Add(this.BtnStudentManagement);
            this.NavigationWrapper.Controls.Add(this.BtnHome);
            this.NavigationWrapper.Controls.Add(this.AppName);
            this.NavigationWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationWrapper.Location = new System.Drawing.Point(0, 0);
            this.NavigationWrapper.Name = "NavigationWrapper";
            this.NavigationWrapper.Size = new System.Drawing.Size(234, 551);
            this.NavigationWrapper.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogout.BackColor = System.Drawing.Color.Lavender;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(3, 514);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnLogout.Size = new System.Drawing.Size(231, 34);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnClassManagement
            // 
            this.BtnClassManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClassManagement.BackColor = System.Drawing.Color.Lavender;
            this.BtnClassManagement.FlatAppearance.BorderSize = 0;
            this.BtnClassManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClassManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClassManagement.Location = new System.Drawing.Point(3, 172);
            this.BtnClassManagement.Name = "BtnClassManagement";
            this.BtnClassManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnClassManagement.Size = new System.Drawing.Size(231, 34);
            this.BtnClassManagement.TabIndex = 4;
            this.BtnClassManagement.Text = "Class Management";
            this.BtnClassManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClassManagement.UseVisualStyleBackColor = false;
            this.BtnClassManagement.Click += new System.EventHandler(this.BtnClassManagement_Click);
            // 
            // BtnTeacherManagement
            // 
            this.BtnTeacherManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTeacherManagement.BackColor = System.Drawing.Color.Lavender;
            this.BtnTeacherManagement.FlatAppearance.BorderSize = 0;
            this.BtnTeacherManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacherManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeacherManagement.Location = new System.Drawing.Point(3, 132);
            this.BtnTeacherManagement.Name = "BtnTeacherManagement";
            this.BtnTeacherManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnTeacherManagement.Size = new System.Drawing.Size(231, 34);
            this.BtnTeacherManagement.TabIndex = 3;
            this.BtnTeacherManagement.Text = "Teacher Management";
            this.BtnTeacherManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTeacherManagement.UseVisualStyleBackColor = false;
            this.BtnTeacherManagement.Click += new System.EventHandler(this.BtnTeacherManagement_Click);
            // 
            // BtnStudentManagement
            // 
            this.BtnStudentManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStudentManagement.BackColor = System.Drawing.Color.Lavender;
            this.BtnStudentManagement.FlatAppearance.BorderSize = 0;
            this.BtnStudentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentManagement.Location = new System.Drawing.Point(3, 92);
            this.BtnStudentManagement.Name = "BtnStudentManagement";
            this.BtnStudentManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnStudentManagement.Size = new System.Drawing.Size(231, 34);
            this.BtnStudentManagement.TabIndex = 2;
            this.BtnStudentManagement.Text = "Student Management";
            this.BtnStudentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStudentManagement.UseVisualStyleBackColor = false;
            this.BtnStudentManagement.Click += new System.EventHandler(this.BtnStudentManagement_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHome.BackColor = System.Drawing.SystemColors.Control;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(3, 52);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(231, 34);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // AppName
            // 
            this.AppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(13, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(207, 25);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Skills International";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.Location = new System.Drawing.Point(240, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(827, 551);
            this.ContentPanel.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 551);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.NavigationWrapper);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Dashboard - Skills International";
            this.NavigationWrapper.ResumeLayout(false);
            this.NavigationWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationWrapper;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Button BtnClassManagement;
        private System.Windows.Forms.Button BtnTeacherManagement;
        private System.Windows.Forms.Button BtnStudentManagement;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnLogout;
    }
}