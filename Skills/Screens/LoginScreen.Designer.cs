namespace Skills.Screens
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.AppLogo = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.LoginFormWrapper = new System.Windows.Forms.GroupBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).BeginInit();
            this.LoginFormWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppLogo
            // 
            this.AppLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppLogo.BackgroundImage = global::Skills.Properties.Resources.app_logo;
            this.AppLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AppLogo.Location = new System.Drawing.Point(205, 22);
            this.AppLogo.Name = "AppLogo";
            this.AppLogo.Size = new System.Drawing.Size(135, 105);
            this.AppLogo.TabIndex = 0;
            this.AppLogo.TabStop = false;
            // 
            // AppName
            // 
            this.AppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(146, 130);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(255, 31);
            this.AppName.TabIndex = 1;
            this.AppName.Text = "Skills International";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginFormWrapper
            // 
            this.LoginFormWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginFormWrapper.Controls.Add(this.BtnSubmit);
            this.LoginFormWrapper.Controls.Add(this.BtnClear);
            this.LoginFormWrapper.Controls.Add(this.InputPassword);
            this.LoginFormWrapper.Controls.Add(this.LabelPassword);
            this.LoginFormWrapper.Controls.Add(this.InputUsername);
            this.LoginFormWrapper.Controls.Add(this.LabelUsername);
            this.LoginFormWrapper.Location = new System.Drawing.Point(80, 179);
            this.LoginFormWrapper.Name = "LoginFormWrapper";
            this.LoginFormWrapper.Size = new System.Drawing.Size(374, 231);
            this.LoginFormWrapper.TabIndex = 2;
            this.LoginFormWrapper.TabStop = false;
            this.LoginFormWrapper.Text = "Login";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSubmit.Location = new System.Drawing.Point(261, 167);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(89, 34);
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "Login";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(27, 167);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(89, 34);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // InputPassword
            // 
            this.InputPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPassword.Location = new System.Drawing.Point(134, 108);
            this.InputPassword.MaxLength = 50;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(216, 26);
            this.InputPassword.TabIndex = 3;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(23, 110);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(78, 20);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Password";
            // 
            // InputUsername
            // 
            this.InputUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsername.Location = new System.Drawing.Point(134, 50);
            this.InputUsername.MaxLength = 50;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(216, 26);
            this.InputUsername.TabIndex = 1;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(23, 53);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(83, 20);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Username";
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExit.Location = new System.Drawing.Point(12, 437);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(89, 34);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 483);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LoginFormWrapper);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.AppLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginScreen";
            this.Text = "Login - Skills International";
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).EndInit();
            this.LoginFormWrapper.ResumeLayout(false);
            this.LoginFormWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AppLogo;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.GroupBox LoginFormWrapper;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
    }
}