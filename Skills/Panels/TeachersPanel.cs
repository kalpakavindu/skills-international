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
    public partial class TeachersPanel : Form
    {
        private Database conn;
        private int selectedId;

        public TeachersPanel()
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
                String query = "SELECT * FROM Teacher";
                DataTable res = conn.GetData(query);
                
                DataTable src = new DataTable();
                src.Columns.Add("Reg no.",typeof(int));
                src.Columns.Add("NIC",typeof(String));
                src.Columns.Add("Full name",typeof(String));
                src.Columns.Add("Gender",typeof(String));
                src.Columns.Add("Date of birth",typeof(String));
                src.Columns.Add("Civil status",typeof(String));
                src.Columns.Add("Email address",typeof(String));
                src.Columns.Add("Home address",typeof(String));
                src.Columns.Add("Mobile phone", typeof(Int64));
                src.Columns.Add("Classes", typeof(int));

                foreach(DataRow r in res.Rows)
                {
                    String q = $"SELECT classId FROM ClassToTeacher WHERE teacherId={(int)r["regNo"]}";
                    DataTable clCountData = conn.GetData(q);

                    src.Rows.Add(
                        (int)r["regNo"],
                        (String)r["nic"],
                        $"{(String)r["firstName"]} {(String)r["lastName"]}",
                        (String)r["gender"],
                        ((DateTime)r["dateOfBirth"]).ToString("yyyy-MM-dd"),
                        (String)r["civilStatus"],
                        (String)r["email"],
                        (String)r["address"],
                        Convert.ToUInt64(r["mobilePhone"]),
                        clCountData.Rows.Count
                    );
                }

                DataGrid.DataSource = src;
            }
            catch (Exception ex) 
            {
                if(MessageBox.Show(ex.Message,"Internal Error",MessageBoxButtons.OK,MessageBoxIcon.Error) == DialogResult.OK)
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
            TeacherDataPopup teacherDataPopup = new TeacherDataPopup();
            teacherDataPopup.FormClosed += TeacherDataPopup_FormClosed;
            teacherDataPopup.ShowDialog();
        }

        private void TeacherDataPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedId = selectedId = e.RowIndex != -1 ? (int)DataGrid.Rows[e.RowIndex].Cells[0].Value : -1;
            showBtns();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            TeacherDataPopup teacherDataPopup = new TeacherDataPopup(selectedId);
            teacherDataPopup.FormClosed += TeacherDataPopup_FormClosed;
            teacherDataPopup.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Clean foreign keys
                    String query = $"DELETE FROM ClassToTeacher WHERE teacherId={selectedId}";
                    conn.SetData(query);

                    // Delete the Teacher
                    query = $"DELETE FROM Teacher WHERE regNo={selectedId}";
                    conn.SetData(query);
                    if (MessageBox.Show("Record deleted succesfully", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        selectedId = -1;
                        loadData();
                    }
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
