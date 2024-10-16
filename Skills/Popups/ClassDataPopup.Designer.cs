namespace Skills.Popups
{
    partial class ClassDataPopup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RegistrationFormWrapper = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputTeacher = new System.Windows.Forms.ComboBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelTeacher = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.LabelYear = new System.Windows.Forms.Label();
            this.InputYear = new System.Windows.Forms.ComboBox();
            this.LabelStudents = new System.Windows.Forms.Label();
            this.text_selected = new System.Windows.Forms.Label();
            this.SelectCount = new System.Windows.Forms.Label();
            this.GridStudents = new System.Windows.Forms.DataGridView();
            this.RegistrationFormWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrationFormWrapper
            // 
            this.RegistrationFormWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationFormWrapper.Controls.Add(this.GridStudents);
            this.RegistrationFormWrapper.Controls.Add(this.SelectCount);
            this.RegistrationFormWrapper.Controls.Add(this.text_selected);
            this.RegistrationFormWrapper.Controls.Add(this.LabelStudents);
            this.RegistrationFormWrapper.Controls.Add(this.InputYear);
            this.RegistrationFormWrapper.Controls.Add(this.LabelYear);
            this.RegistrationFormWrapper.Controls.Add(this.BtnClear);
            this.RegistrationFormWrapper.Controls.Add(this.BtnUpdate);
            this.RegistrationFormWrapper.Controls.Add(this.BtnRegister);
            this.RegistrationFormWrapper.Controls.Add(this.InputName);
            this.RegistrationFormWrapper.Controls.Add(this.InputTeacher);
            this.RegistrationFormWrapper.Controls.Add(this.LabelName);
            this.RegistrationFormWrapper.Controls.Add(this.LabelTeacher);
            this.RegistrationFormWrapper.Location = new System.Drawing.Point(11, 54);
            this.RegistrationFormWrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationFormWrapper.Name = "RegistrationFormWrapper";
            this.RegistrationFormWrapper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationFormWrapper.Size = new System.Drawing.Size(529, 509);
            this.RegistrationFormWrapper.TabIndex = 7;
            this.RegistrationFormWrapper.TabStop = false;
            this.RegistrationFormWrapper.Text = "Class Registration";
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.Location = new System.Drawing.Point(31, 465);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 35);
            this.BtnClear.TabIndex = 20;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(424, 465);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 35);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegister.Location = new System.Drawing.Point(424, 465);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 35);
            this.BtnRegister.TabIndex = 18;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // InputName
            // 
            this.InputName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputName.Location = new System.Drawing.Point(243, 41);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(256, 22);
            this.InputName.TabIndex = 17;
            // 
            // InputTeacher
            // 
            this.InputTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTeacher.FormattingEnabled = true;
            this.InputTeacher.Location = new System.Drawing.Point(243, 77);
            this.InputTeacher.Name = "InputTeacher";
            this.InputTeacher.Size = new System.Drawing.Size(256, 24);
            this.InputTeacher.TabIndex = 16;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(28, 43);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(81, 16);
            this.LabelName.TabIndex = 15;
            this.LabelName.Text = "Class Name";
            // 
            // LabelTeacher
            // 
            this.LabelTeacher.AutoSize = true;
            this.LabelTeacher.Location = new System.Drawing.Point(28, 80);
            this.LabelTeacher.Name = "LabelTeacher";
            this.LabelTeacher.Size = new System.Drawing.Size(95, 16);
            this.LabelTeacher.TabIndex = 14;
            this.LabelTeacher.Text = "Class Teacher";
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(155, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(255, 31);
            this.AppName.TabIndex = 6;
            this.AppName.Text = "Skills International";
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Location = new System.Drawing.Point(28, 118);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(99, 16);
            this.LabelYear.TabIndex = 21;
            this.LabelYear.Text = "Education Year";
            // 
            // InputYear
            // 
            this.InputYear.FormattingEnabled = true;
            this.InputYear.Location = new System.Drawing.Point(243, 115);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(256, 24);
            this.InputYear.TabIndex = 22;
            this.InputYear.SelectedIndexChanged += new System.EventHandler(this.InputYear_SelectedIndexChanged);
            // 
            // LabelStudents
            // 
            this.LabelStudents.AutoSize = true;
            this.LabelStudents.Location = new System.Drawing.Point(28, 158);
            this.LabelStudents.Name = "LabelStudents";
            this.LabelStudents.Size = new System.Drawing.Size(100, 16);
            this.LabelStudents.TabIndex = 23;
            this.LabelStudents.Text = "Select Students";
            // 
            // text_selected
            // 
            this.text_selected.AutoSize = true;
            this.text_selected.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.text_selected.Location = new System.Drawing.Point(440, 158);
            this.text_selected.Name = "text_selected";
            this.text_selected.Size = new System.Drawing.Size(59, 16);
            this.text_selected.TabIndex = 24;
            this.text_selected.Text = "selected";
            // 
            // SelectCount
            // 
            this.SelectCount.AutoSize = true;
            this.SelectCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SelectCount.Location = new System.Drawing.Point(414, 158);
            this.SelectCount.Name = "SelectCount";
            this.SelectCount.Size = new System.Drawing.Size(28, 16);
            this.SelectCount.TabIndex = 25;
            this.SelectCount.Text = "100";
            // 
            // GridStudents
            // 
            this.GridStudents.AllowUserToAddRows = false;
            this.GridStudents.AllowUserToDeleteRows = false;
            this.GridStudents.AllowUserToOrderColumns = true;
            this.GridStudents.AllowUserToResizeRows = false;
            this.GridStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridStudents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridStudents.Location = new System.Drawing.Point(31, 181);
            this.GridStudents.MultiSelect = false;
            this.GridStudents.Name = "GridStudents";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridStudents.RowHeadersVisible = false;
            this.GridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridStudents.Size = new System.Drawing.Size(468, 278);
            this.GridStudents.TabIndex = 4;
            this.GridStudents.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridStudents_CellMouseClick);
            // 
            // ClassDataPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 574);
            this.Controls.Add(this.RegistrationFormWrapper);
            this.Controls.Add(this.AppName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassDataPopup";
            this.Text = "Class Registration - Skills International";
            this.RegistrationFormWrapper.ResumeLayout(false);
            this.RegistrationFormWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RegistrationFormWrapper;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.ComboBox InputTeacher;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelTeacher;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.ComboBox InputYear;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label SelectCount;
        private System.Windows.Forms.Label text_selected;
        private System.Windows.Forms.Label LabelStudents;
        private System.Windows.Forms.DataGridView GridStudents;
    }
}