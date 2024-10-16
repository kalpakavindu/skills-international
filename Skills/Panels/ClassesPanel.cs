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
    public partial class ClassesPanel : Form
    {
        private Database conn;
        private int selectedId;

        public ClassesPanel()
        {
            conn = new Database();
            selectedId = -1;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            showBtns();
            try
            {
                String query = "SELECT * FROM Class";
                DataTable res = conn.GetData(query);

                // Init DataGrid source
                DataTable src = new DataTable();
                src.Columns.Add("ID", typeof(int));
                src.Columns.Add("Class name", typeof(String));
                src.Columns.Add("Education year", typeof(int));
                src.Columns.Add("Teacher name", typeof(String));
                src.Columns.Add("Student count", typeof(int));

                // Fill Data in the src DataTable
                foreach(DataRow r in res.Rows)
                {
                    String q = $"SELECT teacherId FROM ClassToTeacher WHERE classId={(int)r["id"]}";
                    DataTable thRes = conn.GetData(q);
                    q = $"SELECT firstName,lastName FROM Teacher WHERE regNo={(int)thRes.Rows[0]["teacherId"]}";
                    DataTable thData = conn.GetData(q);
                    q = $"SELECT studentId FROM ClassToStudent WHERE classId={(int)r["id"]}";
                    DataTable stCountData = conn.GetData(q);

                    src.Rows.Add(
                        (int)r["id"], 
                        (String)r["name"],
                        (int)r["year"],
                        $"{(String)thData.Rows[0]["firstName"]} {(String)thData.Rows[0]["lastName"]}",
                        stCountData.Rows.Count
                    );
                }

                // Set DataGrid source to src
                DataGrid.DataSource = src;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
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
            ClassDataPopup classDataPopup = new ClassDataPopup();
            classDataPopup.FormClosed += ClassDataPopup_FormClosed;
            classDataPopup.ShowDialog();
        }

        private void ClassDataPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedId = e.RowIndex != -1 ? (int)DataGrid.Rows[e.RowIndex].Cells[0].Value : -1;
            showBtns();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ClassDataPopup classDataPopup = new ClassDataPopup(selectedId);
            classDataPopup.FormClosed += ClassDataPopup_FormClosed;
            classDataPopup.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // First clean the foreign keys
                    String query = $"DELETE FROM ClassToTeacher WHERE classId={selectedId}";
                    conn.SetData(query);
                    query = $"DELETE FROM ClassToStudent WHERE classId={selectedId}";
                    conn.SetData(query);

                    // And delete the class
                    query = $"DELETE FROM Class WHERE id={selectedId}";
                    conn.SetData(query);
                    if (MessageBox.Show("Record deleted succesfully", "Delete Class", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
