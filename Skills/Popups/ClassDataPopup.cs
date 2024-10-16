using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills.Popups
{
    public partial class ClassDataPopup : Form
    {
        // Custom ComboBox item class to store both Teacher ID and Name
        private class ComboItem
        {
            public ComboItem(object value, string label = "")
            {
                this.Label = label;
                this.Value = value;
            }
            public String Label { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return this.Label;
            }
        }

        private Database conn;
        private int id;

        public ClassDataPopup(int id=-1)
        {
            conn = new Database();
            this.id = id;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            BtnUpdate.Visible = id != -1;
            BtnRegister.Visible = id == -1;

            try
            {
                // Get teacher data for combo box
                String query = "SELECT regNo,firstName,lastName FROM Teacher";
                DataTable thData = conn.GetData(query);

                foreach (DataRow r in thData.Rows)
                {
                    InputTeacher.Items.Add(new ComboItem(
                        (int)r["regNo"],
                        $"{(String)r["firstName"]} {(String)r["lastName"]}"
                    ));
                }

                if (id != -1)
                {
                    query = $"SELECT * FROM Class WHERE id={id}";
                    DataTable res = conn.GetData(query);
                    if (res.Rows.Count <= 0)
                    {
                        if (MessageBox.Show($"Class {id} not found in the database", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    InputName.Text = res.Rows[0]["name"].ToString();

                    if (res.Rows[0]["teacherId"] == DBNull.Value)
                    {
                        InputTeacher.SelectedIndex = -1;
                    }
                    else
                    {
                        int i = -1;
                        foreach(ComboItem ci in InputTeacher.Items)
                        {
                            if((int)ci.Value == (int)res.Rows[0]["teacherId"])
                            {
                                i = InputTeacher.Items.IndexOf(ci);
                            }
                        }
                        InputTeacher.SelectedIndex = i;
                    }
                }
                else
                {
                    InputName.Text = "";
                    InputTeacher.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                if(MessageBox.Show(ex.Message,"Internal Error",MessageBoxButtons.OK,MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if(InputName.Text == "" || InputTeacher.Text == "")
            {
                MessageBox.Show("Invalid credentials, please fillout all the feilds", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                String query = $"INSERT INTO Class (name,teacherId) VALUES ('{InputName.Text}',{(int)((ComboItem)InputTeacher.SelectedItem).Value})";
                conn.SetData(query);
                if (MessageBox.Show("Record added successfully", "Register Class", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (InputName.Text == "" || InputTeacher.Text == "")
            {
                MessageBox.Show("Invalid credentials, please fillout all the feilds", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                String query = $"UPDATE Class SET name='{InputName.Text}',teacherId={(int)((ComboItem)InputTeacher.SelectedItem).Value} WHERE id={id}";
                conn.SetData(query);
                if (MessageBox.Show("Record updated succesfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
