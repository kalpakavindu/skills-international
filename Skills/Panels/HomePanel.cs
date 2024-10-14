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
    public partial class HomePanel : Form
    {
        private Database conn;

        public HomePanel()
        {
            conn = new Database();
            InitializeComponent();
            loadData();
        }

        private void loadData() 
        {
            String q = "SELECT regNo FROM Student";
            DataTable stData = conn.GetData(q);
            q = "SELECT regNo FROM Teacher";
            DataTable thData = conn.GetData(q);
            q = "SELECT id FROM Class";
            DataTable clData = conn.GetData(q);

            CountStudent.Text = stData.Rows.Count.ToString();
            CountTeacher.Text = thData.Rows.Count.ToString();
            CountClass.Text = clData.Rows.Count.ToString();
        }
    }
}
