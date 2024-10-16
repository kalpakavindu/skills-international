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
    public partial class ClassDataPopup : Form
    {
        // Custom ComboBox item class to store both ID and Label
        private class ComboItem
        {
            public ComboItem(string label,object value)
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
        private List<int> selectedIds;

        public ClassDataPopup(int id=-1)
        {
            conn = new Database();
            this.selectedIds = new List<int>();
            this.id = id;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            InputYear.Items.Clear();
            selectedIds.Clear();
            BtnUpdate.Visible = id != -1;
            BtnRegister.Visible = id == -1;
            SelectCount.Text = selectedIds.Count.ToString();
            InputName.Text = "";

            try
            {
                // Set 'InputYear' data
                for(int i= DateTime.Now.Year-20;i<= DateTime.Now.Year-10; i++)
                {
                    InputYear.Items.Add(i.ToString());
                }
                InputYear.SelectedIndex = 0;

                // Set 'InputTeacher' data
                String query = "SELECT regNo,firstName,lastName FROM Teacher";
                DataTable thData = conn.GetData(query);

                foreach (DataRow r in thData.Rows)
                {
                    InputTeacher.Items.Add(new ComboItem(
                        $"{r["firstName"]} {r["lastName"]}",
                        (int)r["regNo"]
                    ));
                }
                InputTeacher.SelectedIndex = -1;

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
                    InputYear.Text = res.Rows[0]["year"].ToString();

                    query = $"SELECT teacherId FROM ClassToTeacher WHERE classId={id}";
                    DataTable thIdRes = conn.GetData(query);
                    if(thIdRes.Rows.Count > 0)
                    {
                        int thInSId = -1;
                        foreach(ComboItem i in InputTeacher.Items)
                        {
                            if((int)i.Value == (int)thIdRes.Rows[0]["teacherId"])
                            {
                                thInSId = InputTeacher.Items.IndexOf(i);
                            }
                        }
                        InputTeacher.SelectedIndex = thInSId;
                    }

                    query = $"SELECT studentId FROM ClassToStudent WHERE classId={id}";
                    DataTable stIdRes = conn.GetData(query);
                    foreach (DataRow r in stIdRes.Rows)
                    {
                        selectedIds.Add((int)r["studentId"]);
                    }
                }

                // Set 'GridStudent' data
                setStudentsGridData(InputYear.Text);
            }
            catch (Exception ex)
            {
                if(MessageBox.Show(ex.Message,"Internal Error",MessageBoxButtons.OK,MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void setStudentsGridData(String year)
        {
            try
            {
                SelectCount.Text = selectedIds.Count.ToString();

                String query = $"SELECT regNo,firstName,lastName,dateOfBirth,gender FROM Student WHERE dateOfBirth BETWEEN '{year}-1-1' AND '{year}-12-31'";
                DataTable stData = conn.GetData(query);
                GridStudents.DataSource = stData;

                if (selectedIds.Count > 0)
                {
                    foreach (DataGridViewRow r in GridStudents.Rows)
                    {
                        if (selectedIds.Contains((int)(r.Cells[0].Value)))
                        {
                            r.DefaultCellStyle.BackColor = Color.Aquamarine;
                        }
                    }
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if(InputName.Text == "" || InputTeacher.Text == ""||InputYear.Text == "")
            {
                MessageBox.Show("Invalid credentials, please fillout all the feilds", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(InputYear.Text, @"^([0-9]*)$"))
            {
                if (MessageBox.Show("Education year is invalid", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return;
                }
            }

            try
            {
                String query = $"INSERT INTO Class (name,year) VALUES ('{InputName.Text}',{InputYear.Text})";
                conn.SetData(query);

                query = $"SELECT id FROM Class WHERE name='{InputName.Text}'";
                DataTable cId = conn.GetData(query);

                foreach (int sid in selectedIds)
                {
                    query = $"INSERT INTO ClassToStudent (classId,studentId) VALUES ({cId.Rows[0]["id"]},{sid})";
                    conn.SetData(query);
                }

                query = $"INSERT INTO ClassToTeacher (classId,teacherId) VALUES ({cId.Rows[0]["id"]},{((ComboItem)InputTeacher.SelectedItem).Value})";
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
            if (InputName.Text == "" || InputTeacher.Text == ""||InputYear.Text == "")
            {
                if (MessageBox.Show("Invalid credentials, please fillout all the feilds", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return;
                }
            }
            if (!Regex.IsMatch(InputYear.Text, @"^([0-9]*)$"))
            {
                if (MessageBox.Show("Education year is invalid", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return;
                }
            }

            try
            {
                String query = $"DELETE FROM ClassToStudent WHERE classId={id}";
                conn.SetData(query);
                foreach(int sid in selectedIds)
                {
                    query = $"INSERT INTO ClassToStudent (classId,studentId) VALUES ({id},{sid})";
                    conn.SetData(query);
                }

                query = $"DELETE FROM ClassToTeacher WHERE classId={id}";
                conn.SetData(query);
                query = $"INSERT INTO ClassToTeacher (classId,teacherId) VALUES ({id},{((ComboItem)InputTeacher.SelectedItem).Value})";
                conn.SetData(query);

                query = $"UPDATE Class SET name='{InputName.Text}',year={InputYear.Text} WHERE id={id}";
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

        private void InputYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIds.Clear();
            if (InputYear.Items.Contains(InputYear.Text))
            {
                setStudentsGridData(InputYear.Text);
            }
        }

        private void GridStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                if(selectedIds.Contains((int)GridStudents.Rows[e.RowIndex].Cells[0].Value))
                {
                    selectedIds.Remove((int)GridStudents.Rows[e.RowIndex].Cells[0].Value);
                    GridStudents.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Control;
                }
                else
                {
                    selectedIds.Add((int)GridStudents.Rows[e.RowIndex].Cells[0].Value);
                    GridStudents.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
                }
            }
            SelectCount.Text = selectedIds.Count.ToString();
        }
    }
}
