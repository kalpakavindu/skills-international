using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills.Popups
{
    public partial class TeacherDataPopup : Form
    {
        private Database conn;
        private int id;

        public TeacherDataPopup(int id=-1)
        {
            conn = new Database();
            this.id = id;

            InitializeComponent();
            showBtns(id != -1);
            setRegNo();

            // Set DateTimePicker Min-Max dates
            int currentYear = (int)Convert.ToDecimal(DateTime.Now.ToString("yyyy"));
            InputDOB.CustomFormat = "dd/MM/yyyy";
            InputDOB.MinDate = DateTime.Parse($"{currentYear - 60}/01/01");
            InputDOB.MaxDate = DateTime.Parse($"{currentYear - 22}/12/31");
        }

        private Boolean validateForm()
        {
            if (InputFirstName.Text == "" || InputLastName.Text == "" || InputAddress.Text == "" || InputEmail.Text == ""|| InputMobilePhone.Text == "" || InputCivilStatus.Text == "" || InputRegNo.Text == "" || InputNIC.Text == "")
            {
                if (MessageBox.Show("Invalid credentials, please fillout all the feilds", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return false;
                }
            }

            String validateDigitsRegex = @"/^\d+$/";
            String validateEmailRegex = @"/^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/";

            Dictionary<String, String> mustBeDigits = new Dictionary<String, String>();
            mustBeDigits.Add("Registration number", InputRegNo.Text);
            mustBeDigits.Add("Contact number", InputMobilePhone.Text);

            // Check digits
            foreach (KeyValuePair<String, String> i in mustBeDigits)
            {
                if (!Regex.IsMatch(i.Value, validateDigitsRegex))
                {
                    if (MessageBox.Show($"{i.Key} must be a valid integer", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return false;
                    }
                }
            }
            // Check Email
            if (!Regex.IsMatch(InputEmail.Text, validateEmailRegex))
            {
                if (MessageBox.Show("Email adders is not valid", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return false;
                }
            }
            return true;
        }

        private void showBtns(Boolean edit = false)
        {
            BtnUpdate.Visible = edit;
            BtnRegister.Visible = !edit;
        }

        private void setRegNo()
        {
            InputRegNo.Items.Clear();
            if (id == -1)
            {
                try
                {
                    // Get last Student RegNo
                    String query = "SELECT TOP 1 regNo FROM Teacher ORDER BY regNo DESC";
                    DataTable res = conn.GetData(query);
                    if (res.Rows.Count > 0)
                    {
                        InputRegNo.Items.Insert(0, (int)(res.Rows[0]["regNo"]) + 1);
                    }
                    else
                    {
                        InputRegNo.Items.Insert(0, 240001);
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Application.Exit();
                        return;
                    }
                }
            }
            else
            {
                InputRegNo.Items.Insert(0, id);
            }
            InputRegNo.SelectedIndex = 0;
        }
    }
}
