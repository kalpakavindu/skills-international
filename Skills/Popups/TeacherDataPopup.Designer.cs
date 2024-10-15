namespace Skills.Popups
{
    partial class TeacherDataPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDataPopup));
            this.InputRegNo = new System.Windows.Forms.ComboBox();
            this.ContactDataWrapper = new System.Windows.Forms.GroupBox();
            this.InputMobilePhone = new System.Windows.Forms.TextBox();
            this.LabelMobilePhone = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.BasicDataWrapper = new System.Windows.Forms.GroupBox();
            this.InputCivilStatus = new System.Windows.Forms.ComboBox();
            this.LabelCivilStatus = new System.Windows.Forms.Label();
            this.InputNIC = new System.Windows.Forms.TextBox();
            this.LabelNIC = new System.Windows.Forms.Label();
            this.InputGender1 = new System.Windows.Forms.RadioButton();
            this.InputGender0 = new System.Windows.Forms.RadioButton();
            this.LabelGender = new System.Windows.Forms.Label();
            this.InputDOB = new System.Windows.Forms.DateTimePicker();
            this.LabelDOB = new System.Windows.Forms.Label();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelRegNo = new System.Windows.Forms.Label();
            this.RegistrationFormWrapper = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.ContactDataWrapper.SuspendLayout();
            this.BasicDataWrapper.SuspendLayout();
            this.RegistrationFormWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputRegNo
            // 
            this.InputRegNo.FormattingEnabled = true;
            this.InputRegNo.Location = new System.Drawing.Point(169, 24);
            this.InputRegNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputRegNo.Name = "InputRegNo";
            this.InputRegNo.Size = new System.Drawing.Size(179, 24);
            this.InputRegNo.TabIndex = 2;
            // 
            // ContactDataWrapper
            // 
            this.ContactDataWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactDataWrapper.Controls.Add(this.InputMobilePhone);
            this.ContactDataWrapper.Controls.Add(this.LabelMobilePhone);
            this.ContactDataWrapper.Controls.Add(this.InputEmail);
            this.ContactDataWrapper.Controls.Add(this.LabelEmail);
            this.ContactDataWrapper.Controls.Add(this.InputAddress);
            this.ContactDataWrapper.Controls.Add(this.LabelAddress);
            this.ContactDataWrapper.Location = new System.Drawing.Point(31, 315);
            this.ContactDataWrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactDataWrapper.Name = "ContactDataWrapper";
            this.ContactDataWrapper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactDataWrapper.Size = new System.Drawing.Size(525, 166);
            this.ContactDataWrapper.TabIndex = 3;
            this.ContactDataWrapper.TabStop = false;
            this.ContactDataWrapper.Text = "Contact Details";
            // 
            // InputMobilePhone
            // 
            this.InputMobilePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputMobilePhone.Location = new System.Drawing.Point(138, 122);
            this.InputMobilePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputMobilePhone.MaxLength = 50;
            this.InputMobilePhone.Name = "InputMobilePhone";
            this.InputMobilePhone.Size = new System.Drawing.Size(126, 22);
            this.InputMobilePhone.TabIndex = 6;
            // 
            // LabelMobilePhone
            // 
            this.LabelMobilePhone.AutoSize = true;
            this.LabelMobilePhone.Location = new System.Drawing.Point(16, 123);
            this.LabelMobilePhone.Name = "LabelMobilePhone";
            this.LabelMobilePhone.Size = new System.Drawing.Size(90, 16);
            this.LabelMobilePhone.TabIndex = 5;
            this.LabelMobilePhone.Text = "Mobile Phone";
            // 
            // InputEmail
            // 
            this.InputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEmail.Location = new System.Drawing.Point(138, 82);
            this.InputEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputEmail.MaxLength = 50;
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(382, 22);
            this.InputEmail.TabIndex = 4;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(16, 84);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(41, 16);
            this.LabelEmail.TabIndex = 2;
            this.LabelEmail.Text = "Email";
            // 
            // InputAddress
            // 
            this.InputAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputAddress.Location = new System.Drawing.Point(138, 29);
            this.InputAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputAddress.MaxLength = 50;
            this.InputAddress.Multiline = true;
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Size = new System.Drawing.Size(382, 42);
            this.InputAddress.TabIndex = 1;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(16, 29);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(58, 16);
            this.LabelAddress.TabIndex = 0;
            this.LabelAddress.Text = "Address";
            // 
            // BasicDataWrapper
            // 
            this.BasicDataWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasicDataWrapper.Controls.Add(this.InputCivilStatus);
            this.BasicDataWrapper.Controls.Add(this.LabelCivilStatus);
            this.BasicDataWrapper.Controls.Add(this.InputNIC);
            this.BasicDataWrapper.Controls.Add(this.LabelNIC);
            this.BasicDataWrapper.Controls.Add(this.InputGender1);
            this.BasicDataWrapper.Controls.Add(this.InputGender0);
            this.BasicDataWrapper.Controls.Add(this.LabelGender);
            this.BasicDataWrapper.Controls.Add(this.InputDOB);
            this.BasicDataWrapper.Controls.Add(this.LabelDOB);
            this.BasicDataWrapper.Controls.Add(this.InputLastName);
            this.BasicDataWrapper.Controls.Add(this.LabelLastName);
            this.BasicDataWrapper.Controls.Add(this.InputFirstName);
            this.BasicDataWrapper.Controls.Add(this.LabelFirstName);
            this.BasicDataWrapper.Location = new System.Drawing.Point(31, 54);
            this.BasicDataWrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BasicDataWrapper.Name = "BasicDataWrapper";
            this.BasicDataWrapper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BasicDataWrapper.Size = new System.Drawing.Size(525, 257);
            this.BasicDataWrapper.TabIndex = 0;
            this.BasicDataWrapper.TabStop = false;
            this.BasicDataWrapper.Text = "Basic Details";
            // 
            // InputCivilStatus
            // 
            this.InputCivilStatus.FormattingEnabled = true;
            this.InputCivilStatus.Location = new System.Drawing.Point(138, 216);
            this.InputCivilStatus.Name = "InputCivilStatus";
            this.InputCivilStatus.Size = new System.Drawing.Size(126, 24);
            this.InputCivilStatus.TabIndex = 12;
            // 
            // LabelCivilStatus
            // 
            this.LabelCivilStatus.AutoSize = true;
            this.LabelCivilStatus.Location = new System.Drawing.Point(16, 219);
            this.LabelCivilStatus.Name = "LabelCivilStatus";
            this.LabelCivilStatus.Size = new System.Drawing.Size(72, 16);
            this.LabelCivilStatus.TabIndex = 11;
            this.LabelCivilStatus.Text = "Civil Status";
            // 
            // InputNIC
            // 
            this.InputNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputNIC.Location = new System.Drawing.Point(138, 176);
            this.InputNIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputNIC.MaxLength = 50;
            this.InputNIC.Name = "InputNIC";
            this.InputNIC.Size = new System.Drawing.Size(126, 22);
            this.InputNIC.TabIndex = 10;
            // 
            // LabelNIC
            // 
            this.LabelNIC.AutoSize = true;
            this.LabelNIC.Location = new System.Drawing.Point(16, 178);
            this.LabelNIC.Name = "LabelNIC";
            this.LabelNIC.Size = new System.Drawing.Size(29, 16);
            this.LabelNIC.TabIndex = 9;
            this.LabelNIC.Text = "NIC";
            // 
            // InputGender1
            // 
            this.InputGender1.AutoSize = true;
            this.InputGender1.Location = new System.Drawing.Point(223, 138);
            this.InputGender1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputGender1.Name = "InputGender1";
            this.InputGender1.Size = new System.Drawing.Size(71, 20);
            this.InputGender1.TabIndex = 8;
            this.InputGender1.Text = "Female";
            this.InputGender1.UseVisualStyleBackColor = true;
            // 
            // InputGender0
            // 
            this.InputGender0.AutoSize = true;
            this.InputGender0.Checked = true;
            this.InputGender0.Location = new System.Drawing.Point(138, 138);
            this.InputGender0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputGender0.Name = "InputGender0";
            this.InputGender0.Size = new System.Drawing.Size(55, 20);
            this.InputGender0.TabIndex = 7;
            this.InputGender0.TabStop = true;
            this.InputGender0.Text = "Male";
            this.InputGender0.UseVisualStyleBackColor = true;
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.Location = new System.Drawing.Point(16, 140);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(52, 16);
            this.LabelGender.TabIndex = 6;
            this.LabelGender.Text = "Gender";
            // 
            // InputDOB
            // 
            this.InputDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputDOB.CustomFormat = "dd/mm/yyyy";
            this.InputDOB.Location = new System.Drawing.Point(138, 98);
            this.InputDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputDOB.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.InputDOB.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.InputDOB.Name = "InputDOB";
            this.InputDOB.Size = new System.Drawing.Size(251, 22);
            this.InputDOB.TabIndex = 5;
            this.InputDOB.Value = new System.DateTime(2024, 10, 8, 0, 0, 0, 0);
            // 
            // LabelDOB
            // 
            this.LabelDOB.AutoSize = true;
            this.LabelDOB.Location = new System.Drawing.Point(16, 102);
            this.LabelDOB.Name = "LabelDOB";
            this.LabelDOB.Size = new System.Drawing.Size(81, 16);
            this.LabelDOB.TabIndex = 4;
            this.LabelDOB.Text = "Date Of Birth";
            // 
            // InputLastName
            // 
            this.InputLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputLastName.Location = new System.Drawing.Point(138, 62);
            this.InputLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputLastName.MaxLength = 50;
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(382, 22);
            this.InputLastName.TabIndex = 3;
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(16, 63);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(72, 16);
            this.LabelLastName.TabIndex = 2;
            this.LabelLastName.Text = "Last Name";
            // 
            // InputFirstName
            // 
            this.InputFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputFirstName.Location = new System.Drawing.Point(138, 26);
            this.InputFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputFirstName.MaxLength = 50;
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(382, 22);
            this.InputFirstName.TabIndex = 1;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(16, 27);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(72, 16);
            this.LabelFirstName.TabIndex = 0;
            this.LabelFirstName.Text = "First Name";
            // 
            // LabelRegNo
            // 
            this.LabelRegNo.AutoSize = true;
            this.LabelRegNo.Location = new System.Drawing.Point(47, 26);
            this.LabelRegNo.Name = "LabelRegNo";
            this.LabelRegNo.Size = new System.Drawing.Size(54, 16);
            this.LabelRegNo.TabIndex = 1;
            this.LabelRegNo.Text = "Reg No";
            // 
            // RegistrationFormWrapper
            // 
            this.RegistrationFormWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationFormWrapper.Controls.Add(this.BtnClear);
            this.RegistrationFormWrapper.Controls.Add(this.BtnUpdate);
            this.RegistrationFormWrapper.Controls.Add(this.BtnRegister);
            this.RegistrationFormWrapper.Controls.Add(this.BasicDataWrapper);
            this.RegistrationFormWrapper.Controls.Add(this.ContactDataWrapper);
            this.RegistrationFormWrapper.Controls.Add(this.InputRegNo);
            this.RegistrationFormWrapper.Controls.Add(this.LabelRegNo);
            this.RegistrationFormWrapper.Location = new System.Drawing.Point(10, 48);
            this.RegistrationFormWrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationFormWrapper.Name = "RegistrationFormWrapper";
            this.RegistrationFormWrapper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationFormWrapper.Size = new System.Drawing.Size(587, 553);
            this.RegistrationFormWrapper.TabIndex = 5;
            this.RegistrationFormWrapper.TabStop = false;
            this.RegistrationFormWrapper.Text = "Teacher Registration";
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.Location = new System.Drawing.Point(31, 499);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 35);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(481, 499);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 35);
            this.BtnUpdate.TabIndex = 15;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegister.Location = new System.Drawing.Point(481, 499);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 35);
            this.BtnRegister.TabIndex = 14;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(185, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(255, 31);
            this.AppName.TabIndex = 4;
            this.AppName.Text = "Skills International";
            // 
            // TeacherDataPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 612);
            this.Controls.Add(this.RegistrationFormWrapper);
            this.Controls.Add(this.AppName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 651);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(624, 629);
            this.Name = "TeacherDataPopup";
            this.Text = "Teacher Registration - Skills International";
            this.ContactDataWrapper.ResumeLayout(false);
            this.ContactDataWrapper.PerformLayout();
            this.BasicDataWrapper.ResumeLayout(false);
            this.BasicDataWrapper.PerformLayout();
            this.RegistrationFormWrapper.ResumeLayout(false);
            this.RegistrationFormWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox InputRegNo;
        private System.Windows.Forms.GroupBox ContactDataWrapper;
        private System.Windows.Forms.TextBox InputMobilePhone;
        private System.Windows.Forms.Label LabelMobilePhone;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox InputAddress;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.GroupBox BasicDataWrapper;
        private System.Windows.Forms.RadioButton InputGender1;
        private System.Windows.Forms.RadioButton InputGender0;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.DateTimePicker InputDOB;
        private System.Windows.Forms.Label LabelDOB;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox InputFirstName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelRegNo;
        private System.Windows.Forms.GroupBox RegistrationFormWrapper;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.ComboBox InputCivilStatus;
        private System.Windows.Forms.Label LabelCivilStatus;
        private System.Windows.Forms.TextBox InputNIC;
        private System.Windows.Forms.Label LabelNIC;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnRegister;
    }
}