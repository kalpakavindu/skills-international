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
    public partial class StudentDataPopup : Form
    {
        private Database conn;
        private int regNo;
        private int id;

        public StudentDataPopup(int id=-1)
        {
            conn = new Database();
            this.id = id;

            InitializeComponent();
            showBtns(id!=-1);
            setRegNo();

            // Set DateTimePicker Min-Max dates
            int currentYear = (int)Convert.ToDecimal(DateTime.Now.ToString("yyyy"));
            InputDOB.CustomFormat = "dd/MM/yyyy";
            InputDOB.MinDate = DateTime.Parse($"{currentYear-20}/01/01");
            InputDOB.MaxDate = DateTime.Parse($"{currentYear-10}/12/31");
        }

        private Boolean validateForm()
        {
            if(InputFirstName.Text == ""||InputLastName.Text == ""||InputAddress.Text == ""||InputEmail.Text == "" || InputHomePhone.Text == "" || InputMobilePhone.Text == ""||InputParentName.Text == ""||InputParentNIC.Text == ""||InputParentContact.Text == ""||InputRegNo.Text == "")
            {
                if(MessageBox.Show("Invalid credentials, please fillout all the feilds","Invalid input",MessageBoxButtons.OK,MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return false;
                }
            }

            String validateDigitRegex = @"^([0-9]*)$";
            String validateContactRegex = @"^(94(7[0-9])[\d]{7}|0(7[0-9])[\d]{7}|011[\d]{7})$";
            String validateEmailRegex = @"^(\b[\w\.-]+@[\w\.-]+\.\w{2,4}\b)$";

            Dictionary<String,Dictionary<String,String>> data = new Dictionary<String,Dictionary<String,String>>();
            data.Add(validateDigitRegex, new Dictionary<string, string>());
            data.Add(validateContactRegex, new Dictionary<string, string>());
            data.Add(validateEmailRegex, new Dictionary<string, string>());
            data[validateDigitRegex].Add("Registration number", InputRegNo.Text);
            data[validateContactRegex].Add("Mobile phone", InputMobilePhone.Text);
            data[validateContactRegex].Add("Home phone", InputHomePhone.Text);
            data[validateContactRegex].Add("Parent mobile phone", InputParentContact.Text);
            data[validateEmailRegex].Add("Email address", InputEmail.Text);

            // Validator
            foreach (KeyValuePair<String, Dictionary<String,String>> i in data)
            {
                foreach(KeyValuePair<String,String> ii in i.Value)
                {
                    String msg = "{0} must be a valid ";
                    if(i.Key == validateContactRegex)
                    {
                        msg = msg + "contact number";
                    }else if(i.Key == validateEmailRegex)
                    {
                        msg = msg + "email address";
                    }
                    else
                    {
                        msg = msg + "integer";
                    }

                    if (!Regex.IsMatch(ii.Value, i.Key))
                    {
                        msg = String.Format(msg, ii.Key);
                        if(MessageBox.Show(msg,"Register Student",MessageBoxButtons.OK,MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void clearForm()
        {
            InputFirstName.Text = "";
            InputLastName.Text = "";
            InputAddress.Text = "";
            InputMobilePhone.Text = "";
            InputHomePhone.Text = "";
            InputEmail.Text = "";
            InputParentName.Text = "";
            InputParentNIC.Text = "";
            InputParentContact.Text = "";
            InputDOB.Value = InputDOB.MaxDate;
            InputGender0.Checked = true;
            InputGender1.Checked = false;
            setRegNo();
            InputFirstName.Focus();
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
                    String query = "SELECT TOP 1 regNo FROM Student ORDER BY regNo DESC";
                    DataTable res = conn.GetData(query);
                    if (res.Rows.Count > 0)
                    {
                        InputRegNo.Items.Insert(0,(int)(res.Rows[0]["regNo"]) + 1);
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                try
                {
                    String gender = "Male";
                    if (InputGender1.Checked == true)
                    {
                        gender = "Female";
                    }

                    String query = "INSERT INTO Student (regNo,firstName,lastName,dateOfBirth,gender,address,email,mobilePhone,homePhone,parentName,parentNIC,parentPhone) VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}',{7},{8},'{9}','{10}',{11})";
                    query = String.Format(
                        query,
                        InputRegNo.Text,
                        InputFirstName.Text,
                        InputLastName.Text,
                        InputDOB.Value.ToString("yyyy-MM-dd"),
                        gender,
                        InputAddress.Text,
                        InputEmail.Text,
                        InputMobilePhone.Text,
                        InputHomePhone.Text,
                        InputParentName.Text,
                        InputParentNIC.Text,
                        InputParentContact.Text
                    );
                    conn.SetData(query);

                    if (MessageBox.Show("Record added successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }
    }
}
