using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skills.Panels;

namespace Skills.Screens
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            resetColors();
            BtnHome.BackColor = SystemColors.Control;
            HomePanel home = new HomePanel
            {
                TopLevel = false
            };
            ContentPanel.Controls.Add(home);
            home.Show();
        }

        private void resetColors()
        {
            ContentPanel.Controls.Clear();
            BtnHome.BackColor = Color.Lavender;
            BtnStudentManagement.BackColor = Color.Lavender;
            BtnTeacherManagement.BackColor = Color.Lavender;
            BtnClassManagement.BackColor = Color.Lavender;
            BtnLogout.BackColor = Color.Lavender;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            resetColors();
            BtnHome.BackColor = SystemColors.Control;
            HomePanel home = new HomePanel
            {
                TopLevel = false
            };
            ContentPanel.Controls.Add(home);
            home.Show();
        }

        private void BtnStudentManagement_Click(object sender, EventArgs e)
        {
            resetColors();
            BtnStudentManagement.BackColor= SystemColors.Control;
            StudentsPanel students = new StudentsPanel
            {
                TopLevel = false
            };
            ContentPanel.Controls.Add(students);
            students.Show();
        }

        private void BtnTeacherManagement_Click(object sender, EventArgs e)
        {
            resetColors();
            BtnTeacherManagement.BackColor = SystemColors.Control;
            TeachersPanel teachers = new TeachersPanel
            {
                TopLevel = false
            };
            ContentPanel.Controls.Add(teachers);
            teachers.Show();
        }

        private void BtnClassManagement_Click(object sender, EventArgs e)
        {
            resetColors();
            BtnClassManagement.BackColor =SystemColors.Control;
            ClassesPanel classes = new ClassesPanel
            {
                TopLevel = false
            };
            ContentPanel.Controls.Add(classes);
            classes.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
