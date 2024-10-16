using Skills.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills.Panels
{
    public partial class StudentsPanel : Form
    {
        private Database conn;
        private int selectedId;

        public StudentsPanel()
        {
            conn = new Database();
            InitializeComponent();
            selectedId = -1;
            loadData();
        }

        private void loadData()
        {
            try
            {
                showBtns();
                String query = "SELECT * FROM Student";
                DataTable res = conn.GetData(query);

                DataTable src = new DataTable();
                src.Columns.Add("Reg no.", typeof(int));
                src.Columns.Add("Full name",typeof(String));
                src.Columns.Add("Gender",typeof(String));
                src.Columns.Add("Date of birth",typeof(String));
                src.Columns.Add("Email address",typeof(String));
                src.Columns.Add("Home address",typeof(String));
                src.Columns.Add("Mobile phone",typeof(Int64));
                src.Columns.Add("Home phone",typeof(Int64));
                src.Columns.Add("Parent name",typeof(String));
                src.Columns.Add("Parent NIC",typeof(String));
                src.Columns.Add("Parent phone",typeof(Int64));
                src.Columns.Add("Class name",typeof(String));

                foreach(DataRow r in res.Rows)
                {
                    query = $"SELECT classId FROM ClassToStudent WHERE studentId={(int)r["regNo"]}";
                    DataTable clRes = conn.GetData(query);
                    DataTable clData = new DataTable();
                    if (clRes.Rows.Count > 0)
                    {
                        String q = $"SELECT name FROM Class WHERE id={(int)clRes.Rows[0]["classId"]}";
                        clData = conn.GetData(q);
                    }
                    else
                    {
                        clData.Columns.Add("name", typeof(String));
                        clData.Rows.Add("Not assigned");
                    }

                    src.Rows.Add(
                        (int)r["regNo"],
                        $"{(String)r["firstName"]} {(String)r["lastName"]}",
                        (String)r["gender"],
                        ((DateTime)r["dateOfBirth"]).ToString("yyyy-MM-dd"),
                        (String)r["email"],
                        (String)r["address"],
                        Convert.ToUInt64(r["mobilePhone"]),
                        Convert.ToUInt64(r["homePhone"]),
                        (String)r["parentName"],
                        (String)r["parentNic"],
                        Convert.ToUInt64(r["parentPhone"]),
                        (String)clData.Rows[0]["name"]
                    );
                }

                DataGrid.DataSource = src;
            }
            catch(Exception ex)
            {
                if(MessageBox.Show(ex.Message,"Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void showBtns()
        {
            BtnUpdate.Visible = selectedId != -1;
            BtnDelete.Visible = selectedId != -1;
            BtnAdd.Visible = selectedId == -1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            StudentDataPopup studentDataPopup = new StudentDataPopup();
            studentDataPopup.FormClosed += StudentDataPopup_FormClosed;
            studentDataPopup.ShowDialog();
        }

        private void StudentDataPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedId = e.RowIndex != -1?(int)DataGrid.Rows[e.RowIndex].Cells[0].Value:-1;
            showBtns();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            StudentDataPopup studentDataPopup = new StudentDataPopup(selectedId);
            studentDataPopup.FormClosed += StudentDataPopup_FormClosed;
            studentDataPopup.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Clear foreign keys
                    String query = $"DELETE FROM ClassToStudent WHERE studentId={selectedId}";
                    conn.SetData(query);

                    // Delete Student
                    query = $"DELETE FROM Student WHERE regNo={selectedId}";
                    conn.SetData(query);
                    if (MessageBox.Show("Record deleted succesfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        selectedId = -1;
                        loadData();
                    }
                }
            }
            catch(Exception ex)
            {
                if(MessageBox.Show(ex.Message,"Internal Error",MessageBoxButtons.OK,MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
