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

        public StudentsPanel()
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
                String query = "SELECT * FROM Student";
                DataTable res = conn.GetData(query);

                DataTable src = new DataTable();
                src.Columns.Add("Reg no.", typeof(int));
                src.Columns.Add("Full name",typeof(String));
                src.Columns.Add("Gender",typeof(String));
                src.Columns.Add("Date of birth",typeof(String));
                src.Columns.Add("Email address",typeof(String));
                src.Columns.Add("Home address",typeof(String));
                src.Columns.Add("Mobile phone",typeof(int));
                src.Columns.Add("Home phone",typeof(int));
                src.Columns.Add("Parent name",typeof(String));
                src.Columns.Add("Parent NIC",typeof(String));
                src.Columns.Add("Parent phone",typeof(String));
                src.Columns.Add("Class name",typeof(String));

                foreach(DataRow r in res.Rows)
                {
                    String q = $"SELECT name FROM Class WHERE id={(int)r["classId"]}";
                    DataTable clData = conn.GetData(q);
                    src.Rows.Add(
                        (int)r["regNo"],
                        $"{(String)r["firstName"]} {(String)r["lastName"]}",
                        (String)r["gender"],
                        ((DateTime)r["dateOfBirth"]).ToString("dd/MM/yyyy"),
                        (String)r["email"],
                        (String)r["address"],
                        (int)r["mobilePhone"],
                        (int)r["homePone"],
                        (String)r["parentName"],
                        (String)r["parentNic"],
                        (int)r["parentPhone"],
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

        private void showBtns(Boolean selected = false)
        {
            BtnUpdate.Visible = selected;
            BtnDelete.Visible = selected;
            BtnAdd.Visible = !selected;
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
    }
}
