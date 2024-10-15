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
        private int id;

        public StudentDataPopup(int id=-1)
        {
            conn = new Database();
            this.id = id;

            InitializeComponent();
            loadData(id == -1);
        }

        private void loadData(Boolean newUser=true)
        {
            try 
            {
                // Set DateTimePicker Min-Max dates
                int currentYear = (int)Convert.ToDecimal(DateTime.Now.ToString("yyyy"));
                InputDOB.CustomFormat = "dd/MM/yyyy";
                InputDOB.MinDate = DateTime.Parse($"{currentYear - 20}/01/01");
                InputDOB.MaxDate = DateTime.Parse($"{currentYear - 10}/12/31");

                // Set Action Button Visibility
                BtnUpdate.Visible = !newUser;
                BtnRegister.Visible = newUser;

                if (!newUser)
                {
                    InputRegNo.Enabled = false;
                    String query = $"SELECT * FROM Student WHERE regNo={id}";
                    DataTable res = conn.GetData(query);
                    if (res.Rows.Count > 0)
                    {
                        InputRegNo.Items.Insert(0, id);
                        InputFirstName.Text = (String)res.Rows[0]["firstName"];
                        InputLastName.Text = (String)res.Rows[0]["lastName"];
                        InputDOB.Value = (DateTime)res.Rows[0]["dateOfBirth"];
                        InputAddress.Text = (String)res.Rows[0]["address"];
                        InputEmail.Text = (String)res.Rows[0]["email"];
                        InputHomePhone.Text = res.Rows[0]["homePhone"].ToString();
                        InputMobilePhone.Text = res.Rows[0]["mobilePhone"].ToString();
                        InputParentName.Text = (String)res.Rows[0]["parentName"];
                        InputParentNIC.Text = (String)res.Rows[0]["parentNic"];
                        InputParentContact.Text = res.Rows[0]["parentPhone"].ToString();

                        if ((String)res.Rows[0]["gender"] == "Male")
                        {
                            InputGender0.Checked = true;
                            InputGender1.Checked = false;
                        }
                        else
                        {
                            InputGender0.Checked = false;
                            InputGender1.Checked = true;
                        }
                    }
                    else
                    {
                        if(MessageBox.Show($"Student {id} not registered in the database","Student not found",MessageBoxButtons.OK,MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    // Get last Student RegNo
                    String query = "SELECT TOP 1 regNo FROM Student ORDER BY regNo DESC";
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

                InputRegNo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
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
            loadData(id == -1);
            InputFirstName.Focus();
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
                        this.Close();
                    }
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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

                    String query = "UPDATE Student SET firstName='{0}',lastName='{1}',dateOfBirth='{2}',gender='{3}',address='{4}',email='{5}',mobilePhone={6},homePhone={7},parentName='{8}',parentNic='{9}',parentPhone={10} WHERE regNo={11}";

                    query = String.Format(
                        query,
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
                        InputParentContact.Text,
                        id
                    );

                    conn.SetData(query);
                    if(MessageBox.Show("Record updated succesfully","Update Student",MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
