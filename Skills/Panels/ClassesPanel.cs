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
        public ClassesPanel()
        {
            conn = new Database();
            InitializeComponent();
            showBtns();
            loadData();
        }

        private void loadData()
        {
            try
            {
                String query = "SELECT * FROM Class";
                DataTable res = conn.GetData(query);

                // Init DataGrid source
                DataTable src = new DataTable();
                src.Columns.Add("ID", typeof(int));
                src.Columns.Add("Class name", typeof(String));
                src.Columns.Add("Teacher name", typeof(String));
                src.Columns.Add("Student count", typeof(int));

                // Fill Data in the src DataTable
                foreach(DataRow r in res.Rows)
                {
                    String q = $"SELECT firstName,lastName FROM Teacher WHERE regNo={(int)r["teacherId"]}";
                    DataTable thData = conn.GetData(q);
                    q = $"SELECT regNo FROM Student WHERE classId={(int)r["id"]}";
                    DataTable stData = conn.GetData(q);

                    src.Rows.Add(
                        (int)r["id"], 
                        (String)r["name"], 
                        $"{(String)thData.Rows[0]["firstName"]} {(String)thData.Rows[0]["lastName"]}",
                        stData.Rows.Count
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

        private void showBtns(Boolean selected = false)
        {
            BtnUpdate.Visible = selected;
            BtnDelete.Visible = selected;
            BtnAdd.Visible = !selected;
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
    }
}
