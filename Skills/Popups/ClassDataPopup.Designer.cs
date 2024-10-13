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
            this.RegistrationFormWrapper = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.LabelTeacher = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.InputTeacher = new System.Windows.Forms.ComboBox();
            this.InputName = new System.Windows.Forms.TextBox();
            this.RegistrationFormWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationFormWrapper
            // 
            this.RegistrationFormWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationFormWrapper.Controls.Add(this.InputName);
            this.RegistrationFormWrapper.Controls.Add(this.InputTeacher);
            this.RegistrationFormWrapper.Controls.Add(this.LabelName);
            this.RegistrationFormWrapper.Controls.Add(this.LabelTeacher);
            this.RegistrationFormWrapper.Controls.Add(this.BtnClear);
            this.RegistrationFormWrapper.Controls.Add(this.BtnDelete);
            this.RegistrationFormWrapper.Controls.Add(this.BtnUpdate);
            this.RegistrationFormWrapper.Controls.Add(this.BtnRegister);
            this.RegistrationFormWrapper.Location = new System.Drawing.Point(11, 54);
            this.RegistrationFormWrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationFormWrapper.Name = "RegistrationFormWrapper";
            this.RegistrationFormWrapper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationFormWrapper.Size = new System.Drawing.Size(444, 169);
            this.RegistrationFormWrapper.TabIndex = 7;
            this.RegistrationFormWrapper.TabStop = false;
            this.RegistrationFormWrapper.Text = "Class Registration";
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(339, 131);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(339, 131);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUpdate.Location = new System.Drawing.Point(31, 131);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRegister.Location = new System.Drawing.Point(31, 131);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 10;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(116, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(255, 31);
            this.AppName.TabIndex = 6;
            this.AppName.Text = "Skills International";
            // 
            // LabelTeacher
            // 
            this.LabelTeacher.AutoSize = true;
            this.LabelTeacher.Location = new System.Drawing.Point(28, 87);
            this.LabelTeacher.Name = "LabelTeacher";
            this.LabelTeacher.Size = new System.Drawing.Size(95, 16);
            this.LabelTeacher.TabIndex = 14;
            this.LabelTeacher.Text = "Class Teacher";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(31, 44);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(81, 16);
            this.LabelName.TabIndex = 15;
            this.LabelName.Text = "Class Name";
            // 
            // InputTeacher
            // 
            this.InputTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTeacher.FormattingEnabled = true;
            this.InputTeacher.Location = new System.Drawing.Point(158, 84);
            this.InputTeacher.Name = "InputTeacher";
            this.InputTeacher.Size = new System.Drawing.Size(256, 24);
            this.InputTeacher.TabIndex = 16;
            // 
            // InputName
            // 
            this.InputName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputName.Location = new System.Drawing.Point(158, 41);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(256, 22);
            this.InputName.TabIndex = 17;
            // 
            // ClassDataPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 234);
            this.Controls.Add(this.RegistrationFormWrapper);
            this.Controls.Add(this.AppName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassDataPopup";
            this.Text = "Class Registration - Skills International";
            this.RegistrationFormWrapper.ResumeLayout(false);
            this.RegistrationFormWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RegistrationFormWrapper;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.ComboBox InputTeacher;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelTeacher;
    }
}