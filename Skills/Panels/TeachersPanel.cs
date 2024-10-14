﻿using System;
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
        public TeachersPanel()
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
                src.Columns.Add("Mobile phone", typeof(int));
                src.Columns.Add("Classes", typeof(int));

                foreach(DataRow r in res.Rows)
                {
                    String q = $"SELECT id FROM Class WHERE teacherId={(int)r["regNo"]}";
                    DataTable clData = conn.GetData(q);

                    src.Rows.Add(
                        (int)r["regNo"],
                        (String)r["nic"],
                        $"{(String)r["firstName"]} {(String)r["lastName"]}",
                        (String)r["gender"],
                        ((DateTime)r["dateOfBirth"]).ToString("dd/MM/yyyy"),
                        (String)r["civilStatus"],
                        (String)r["email"],
                        (String)r["address"],
                        (int)r["mobilePhone"],
                        clData.Rows.Count
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

        private void showBtns(Boolean selected = false)
        {
            BtnUpdate.Visible = selected;
            BtnDelete.Visible = selected;
            BtnAdd.Visible = !selected;
        }
    }
}
