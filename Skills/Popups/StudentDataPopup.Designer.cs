namespace Skills.Popups
{
    partial class StudentDataPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDataPopup));
            this.AppName = new System.Windows.Forms.Label();
            this.RegistrationFormWrapper = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BasicDataWrapper = new System.Windows.Forms.GroupBox();
            this.InputGender1 = new System.Windows.Forms.RadioButton();
            this.InputGender0 = new System.Windows.Forms.RadioButton();
            this.LabelGender = new System.Windows.Forms.Label();
            this.InputDOB = new System.Windows.Forms.DateTimePicker();
            this.LabelDOB = new System.Windows.Forms.Label();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.ParentDataWrapper = new System.Windows.Forms.GroupBox();
            this.InputParentContact = new System.Windows.Forms.TextBox();
            this.LabelParentContact = new System.Windows.Forms.Label();
            this.InputParentNIC = new System.Windows.Forms.TextBox();
            this.LabelParentNIC = new System.Windows.Forms.Label();
            this.InputParentName = new System.Windows.Forms.TextBox();
            this.LabelParentName = new System.Windows.Forms.Label();
            this.ContactDataWrapper = new System.Windows.Forms.GroupBox();
            this.InputHomePhone = new System.Windows.Forms.TextBox();
            this.LabelHomePhone = new System.Windows.Forms.Label();
            this.InputMobilePhone = new System.Windows.Forms.TextBox();
            this.LabelMobilePhone = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.InputRegNo = new System.Windows.Forms.ComboBox();
            this.LabelRegNo = new System.Windows.Forms.Label();
            this.RegistrationFormWrapper.SuspendLayout();
            this.BasicDataWrapper.SuspendLayout();
            this.ParentDataWrapper.SuspendLayout();
            this.ContactDataWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(192, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(255, 31);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Skills International";
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
            this.RegistrationFormWrapper.Controls.Add(this.ParentDataWrapper);
            this.RegistrationFormWrapper.Controls.Add(this.ContactDataWrapper);
            this.RegistrationFormWrapper.Controls.Add(this.InputRegNo);
            this.RegistrationFormWrapper.Controls.Add(this.LabelRegNo);
            this.RegistrationFormWrapper.Location = new System.Drawing.Point(11, 48);
            this.RegistrationFormWrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationFormWrapper.Name = "RegistrationFormWrapper";
            this.RegistrationFormWrapper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationFormWrapper.Size = new System.Drawing.Size(587, 589);
            this.RegistrationFormWrapper.TabIndex = 3;
            this.RegistrationFormWrapper.TabStop = false;
            this.RegistrationFormWrapper.Text = "Student Registration";
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.Location = new System.Drawing.Point(31, 543);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 35);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(481, 543);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 35);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegister.Location = new System.Drawing.Point(481, 543);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 35);
            this.BtnRegister.TabIndex = 10;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // BasicDataWrapper
            // 
            this.BasicDataWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BasicDataWrapper.Size = new System.Drawing.Size(525, 174);
            this.BasicDataWrapper.TabIndex = 0;
            this.BasicDataWrapper.TabStop = false;
            this.BasicDataWrapper.Text = "Basic Details";
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
            this.InputDOB.CustomFormat = "dd/MM/yyyy";
            this.InputDOB.Location = new System.Drawing.Point(138, 98);
            this.InputDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputDOB.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.InputDOB.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.InputDOB.Name = "InputDOB";
            this.InputDOB.Size = new System.Drawing.Size(251, 22);
            this.InputDOB.TabIndex = 5;
            this.InputDOB.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
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
            // ParentDataWrapper
            // 
            this.ParentDataWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentDataWrapper.Controls.Add(this.InputParentContact);
            this.ParentDataWrapper.Controls.Add(this.LabelParentContact);
            this.ParentDataWrapper.Controls.Add(this.InputParentNIC);
            this.ParentDataWrapper.Controls.Add(this.LabelParentNIC);
            this.ParentDataWrapper.Controls.Add(this.InputParentName);
            this.ParentDataWrapper.Controls.Add(this.LabelParentName);
            this.ParentDataWrapper.Location = new System.Drawing.Point(31, 397);
            this.ParentDataWrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParentDataWrapper.Name = "ParentDataWrapper";
            this.ParentDataWrapper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParentDataWrapper.Size = new System.Drawing.Size(525, 135);
            this.ParentDataWrapper.TabIndex = 9;
            this.ParentDataWrapper.TabStop = false;
            this.ParentDataWrapper.Text = "Parent Details";
            // 
            // InputParentContact
            // 
            this.InputParentContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputParentContact.Location = new System.Drawing.Point(138, 97);
            this.InputParentContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputParentContact.MaxLength = 20;
            this.InputParentContact.Name = "InputParentContact";
            this.InputParentContact.Size = new System.Drawing.Size(126, 22);
            this.InputParentContact.TabIndex = 6;
            // 
            // LabelParentContact
            // 
            this.LabelParentContact.AutoSize = true;
            this.LabelParentContact.Location = new System.Drawing.Point(16, 98);
            this.LabelParentContact.Name = "LabelParentContact";
            this.LabelParentContact.Size = new System.Drawing.Size(103, 16);
            this.LabelParentContact.TabIndex = 5;
            this.LabelParentContact.Text = "Contact Number";
            // 
            // InputParentNIC
            // 
            this.InputParentNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputParentNIC.Location = new System.Drawing.Point(138, 62);
            this.InputParentNIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputParentNIC.MaxLength = 50;
            this.InputParentNIC.Name = "InputParentNIC";
            this.InputParentNIC.Size = new System.Drawing.Size(126, 22);
            this.InputParentNIC.TabIndex = 4;
            // 
            // LabelParentNIC
            // 
            this.LabelParentNIC.AutoSize = true;
            this.LabelParentNIC.Location = new System.Drawing.Point(16, 64);
            this.LabelParentNIC.Name = "LabelParentNIC";
            this.LabelParentNIC.Size = new System.Drawing.Size(29, 16);
            this.LabelParentNIC.TabIndex = 2;
            this.LabelParentNIC.Text = "NIC";
            // 
            // InputParentName
            // 
            this.InputParentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputParentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputParentName.Location = new System.Drawing.Point(138, 27);
            this.InputParentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputParentName.MaxLength = 50;
            this.InputParentName.Name = "InputParentName";
            this.InputParentName.Size = new System.Drawing.Size(382, 22);
            this.InputParentName.TabIndex = 1;
            // 
            // LabelParentName
            // 
            this.LabelParentName.AutoSize = true;
            this.LabelParentName.Location = new System.Drawing.Point(16, 29);
            this.LabelParentName.Name = "LabelParentName";
            this.LabelParentName.Size = new System.Drawing.Size(68, 16);
            this.LabelParentName.TabIndex = 0;
            this.LabelParentName.Text = "Full Name";
            // 
            // ContactDataWrapper
            // 
            this.ContactDataWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactDataWrapper.Controls.Add(this.InputHomePhone);
            this.ContactDataWrapper.Controls.Add(this.LabelHomePhone);
            this.ContactDataWrapper.Controls.Add(this.InputMobilePhone);
            this.ContactDataWrapper.Controls.Add(this.LabelMobilePhone);
            this.ContactDataWrapper.Controls.Add(this.InputEmail);
            this.ContactDataWrapper.Controls.Add(this.LabelEmail);
            this.ContactDataWrapper.Controls.Add(this.InputAddress);
            this.ContactDataWrapper.Controls.Add(this.LabelAddress);
            this.ContactDataWrapper.Location = new System.Drawing.Point(31, 233);
            this.ContactDataWrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactDataWrapper.Name = "ContactDataWrapper";
            this.ContactDataWrapper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactDataWrapper.Size = new System.Drawing.Size(525, 159);
            this.ContactDataWrapper.TabIndex = 3;
            this.ContactDataWrapper.TabStop = false;
            this.ContactDataWrapper.Text = "Contact Details";
            // 
            // InputHomePhone
            // 
            this.InputHomePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputHomePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputHomePhone.Location = new System.Drawing.Point(394, 122);
            this.InputHomePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputHomePhone.MaxLength = 20;
            this.InputHomePhone.Name = "InputHomePhone";
            this.InputHomePhone.Size = new System.Drawing.Size(126, 22);
            this.InputHomePhone.TabIndex = 8;
            // 
            // LabelHomePhone
            // 
            this.LabelHomePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHomePhone.AutoSize = true;
            this.LabelHomePhone.Location = new System.Drawing.Point(292, 123);
            this.LabelHomePhone.Name = "LabelHomePhone";
            this.LabelHomePhone.Size = new System.Drawing.Size(86, 16);
            this.LabelHomePhone.TabIndex = 7;
            this.LabelHomePhone.Text = "Home Phone";
            // 
            // InputMobilePhone
            // 
            this.InputMobilePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputMobilePhone.Location = new System.Drawing.Point(138, 122);
            this.InputMobilePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputMobilePhone.MaxLength = 20;
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
            // InputRegNo
            // 
            this.InputRegNo.FormattingEnabled = true;
            this.InputRegNo.Location = new System.Drawing.Point(169, 24);
            this.InputRegNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputRegNo.Name = "InputRegNo";
            this.InputRegNo.Size = new System.Drawing.Size(179, 24);
            this.InputRegNo.TabIndex = 2;
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
            // StudentDataPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 648);
            this.Controls.Add(this.RegistrationFormWrapper);
            this.Controls.Add(this.AppName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 687);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(624, 687);
            this.Name = "StudentDataPopup";
            this.Text = "Student Registration - Skills International";
            this.RegistrationFormWrapper.ResumeLayout(false);
            this.RegistrationFormWrapper.PerformLayout();
            this.BasicDataWrapper.ResumeLayout(false);
            this.BasicDataWrapper.PerformLayout();
            this.ParentDataWrapper.ResumeLayout(false);
            this.ParentDataWrapper.PerformLayout();
            this.ContactDataWrapper.ResumeLayout(false);
            this.ContactDataWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.GroupBox RegistrationFormWrapper;
        private System.Windows.Forms.ComboBox InputRegNo;
        private System.Windows.Forms.Label LabelRegNo;
        private System.Windows.Forms.GroupBox BasicDataWrapper;
        private System.Windows.Forms.TextBox InputFirstName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.DateTimePicker InputDOB;
        private System.Windows.Forms.Label LabelDOB;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.RadioButton InputGender1;
        private System.Windows.Forms.RadioButton InputGender0;
        private System.Windows.Forms.GroupBox ContactDataWrapper;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox InputMobilePhone;
        private System.Windows.Forms.Label LabelMobilePhone;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox InputAddress;
        private System.Windows.Forms.Label LabelHomePhone;
        private System.Windows.Forms.TextBox InputHomePhone;
        private System.Windows.Forms.GroupBox ParentDataWrapper;
        private System.Windows.Forms.TextBox InputParentContact;
        private System.Windows.Forms.Label LabelParentContact;
        private System.Windows.Forms.TextBox InputParentNIC;
        private System.Windows.Forms.Label LabelParentNIC;
        private System.Windows.Forms.TextBox InputParentName;
        private System.Windows.Forms.Label LabelParentName;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClear;
    }
}