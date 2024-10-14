namespace Skills.Panels
{
    partial class HomePanel
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
            this.PanelTitle = new System.Windows.Forms.Label();
            this.WrapperCountStudents = new System.Windows.Forms.Panel();
            this.CountStudent = new System.Windows.Forms.Label();
            this.LabelStudent = new System.Windows.Forms.Label();
            this.WrapperCountTeachers = new System.Windows.Forms.Panel();
            this.CountTeacher = new System.Windows.Forms.Label();
            this.LabelTeacher = new System.Windows.Forms.Label();
            this.WrapperCountClasses = new System.Windows.Forms.Panel();
            this.CountClass = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WrapperCountStudents.SuspendLayout();
            this.WrapperCountTeachers.SuspendLayout();
            this.WrapperCountClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.AutoSize = true;
            this.PanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTitle.Location = new System.Drawing.Point(12, 17);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(126, 25);
            this.PanelTitle.TabIndex = 20;
            this.PanelTitle.Text = "Dashboard";
            // 
            // WrapperCountStudents
            // 
            this.WrapperCountStudents.BackColor = System.Drawing.Color.Wheat;
            this.WrapperCountStudents.Controls.Add(this.CountStudent);
            this.WrapperCountStudents.Controls.Add(this.LabelStudent);
            this.WrapperCountStudents.Location = new System.Drawing.Point(155, 152);
            this.WrapperCountStudents.Name = "WrapperCountStudents";
            this.WrapperCountStudents.Size = new System.Drawing.Size(200, 116);
            this.WrapperCountStudents.TabIndex = 21;
            // 
            // CountStudent
            // 
            this.CountStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CountStudent.AutoSize = true;
            this.CountStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountStudent.Location = new System.Drawing.Point(91, 57);
            this.CountStudent.Name = "CountStudent";
            this.CountStudent.Size = new System.Drawing.Size(91, 37);
            this.CountStudent.TabIndex = 1;
            this.CountStudent.Text = "1200";
            this.CountStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelStudent
            // 
            this.LabelStudent.AutoSize = true;
            this.LabelStudent.Location = new System.Drawing.Point(13, 12);
            this.LabelStudent.Name = "LabelStudent";
            this.LabelStudent.Size = new System.Drawing.Size(93, 16);
            this.LabelStudent.TabIndex = 0;
            this.LabelStudent.Text = "Total Students";
            // 
            // WrapperCountTeachers
            // 
            this.WrapperCountTeachers.BackColor = System.Drawing.Color.LightGreen;
            this.WrapperCountTeachers.Controls.Add(this.CountTeacher);
            this.WrapperCountTeachers.Controls.Add(this.LabelTeacher);
            this.WrapperCountTeachers.Location = new System.Drawing.Point(448, 152);
            this.WrapperCountTeachers.Name = "WrapperCountTeachers";
            this.WrapperCountTeachers.Size = new System.Drawing.Size(200, 116);
            this.WrapperCountTeachers.TabIndex = 22;
            // 
            // CountTeacher
            // 
            this.CountTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CountTeacher.AutoSize = true;
            this.CountTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTeacher.Location = new System.Drawing.Point(91, 57);
            this.CountTeacher.Name = "CountTeacher";
            this.CountTeacher.Size = new System.Drawing.Size(91, 37);
            this.CountTeacher.TabIndex = 1;
            this.CountTeacher.Text = "1200";
            this.CountTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelTeacher
            // 
            this.LabelTeacher.AutoSize = true;
            this.LabelTeacher.Location = new System.Drawing.Point(13, 12);
            this.LabelTeacher.Name = "LabelTeacher";
            this.LabelTeacher.Size = new System.Drawing.Size(99, 16);
            this.LabelTeacher.TabIndex = 0;
            this.LabelTeacher.Text = "Total Teachers";
            // 
            // WrapperCountClasses
            // 
            this.WrapperCountClasses.BackColor = System.Drawing.Color.Violet;
            this.WrapperCountClasses.Controls.Add(this.CountClass);
            this.WrapperCountClasses.Controls.Add(this.LabelClass);
            this.WrapperCountClasses.Location = new System.Drawing.Point(291, 306);
            this.WrapperCountClasses.Name = "WrapperCountClasses";
            this.WrapperCountClasses.Size = new System.Drawing.Size(200, 116);
            this.WrapperCountClasses.TabIndex = 23;
            // 
            // CountClass
            // 
            this.CountClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CountClass.AutoSize = true;
            this.CountClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountClass.Location = new System.Drawing.Point(91, 57);
            this.CountClass.Name = "CountClass";
            this.CountClass.Size = new System.Drawing.Size(91, 37);
            this.CountClass.TabIndex = 1;
            this.CountClass.Text = "1200";
            this.CountClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Location = new System.Drawing.Point(13, 12);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(90, 16);
            this.LabelClass.TabIndex = 0;
            this.LabelClass.Text = "Total Classes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Welcome to the Skills International Learning Management System.";
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WrapperCountClasses);
            this.Controls.Add(this.WrapperCountTeachers);
            this.Controls.Add(this.WrapperCountStudents);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(827, 551);
            this.Name = "HomePanel";
            this.Text = "HomePanel";
            this.WrapperCountStudents.ResumeLayout(false);
            this.WrapperCountStudents.PerformLayout();
            this.WrapperCountTeachers.ResumeLayout(false);
            this.WrapperCountTeachers.PerformLayout();
            this.WrapperCountClasses.ResumeLayout(false);
            this.WrapperCountClasses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PanelTitle;
        private System.Windows.Forms.Panel WrapperCountStudents;
        private System.Windows.Forms.Label CountStudent;
        private System.Windows.Forms.Label LabelStudent;
        private System.Windows.Forms.Panel WrapperCountTeachers;
        private System.Windows.Forms.Label CountTeacher;
        private System.Windows.Forms.Label LabelTeacher;
        private System.Windows.Forms.Panel WrapperCountClasses;
        private System.Windows.Forms.Label CountClass;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.Label label1;
    }
}