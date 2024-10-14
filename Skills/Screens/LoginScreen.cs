using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skills.Screens;
using Skills.Panels;

namespace Skills.Screens
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            InputUsername.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            InputUsername.Text = "";
            InputPassword.Text = "";
            InputPassword.UseSystemPasswordChar = true;
            BtnPasswordToggle.BackgroundImage = Skills.Properties.Resources.visibility;
            InputUsername.Focus();
        }

        private void BtnPasswordToggle_Click(object sender, EventArgs e)
        {
            if (InputPassword.UseSystemPasswordChar == true)
            {
                BtnPasswordToggle.BackgroundImage = Skills.Properties.Resources.visibility_off;
                InputPassword.UseSystemPasswordChar = false;
            }
            else
            {
                BtnPasswordToggle.BackgroundImage = Skills.Properties.Resources.visibility;
                InputPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            String username = InputUsername.Text;
            String password = InputPassword.Text;

            if (username == "" || password == "")
            {
                if (MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    InputUsername.Focus();
                    return;
                }
            }

            if(username == "Admin" && password == "Skills@123")
            {
                MainScreen mainScreen = new MainScreen();
                mainScreen.FormClosed += MainScreen_Close;
                mainScreen.Show();
                this.Hide();
                return;
            }

            if (MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {
                InputUsername.Text = "";
                InputPassword.Text = "";
                InputUsername.Focus();
                return;
            }
        }

        private void MainScreen_Close(object sender, EventArgs e) { 
            Application.Exit();
        }
    }
}