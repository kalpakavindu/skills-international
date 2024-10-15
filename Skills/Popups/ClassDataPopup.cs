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
        private Database conn;
        private int id;

        public ClassDataPopup(int id=-1)
        {
            conn = new Database();
            this.id = id;
            InitializeComponent();
            showBtns(id != -1);
        }

        private void showBtns(Boolean edit = false)
        {
            BtnUpdate.Visible = edit;
            BtnRegister.Visible = !edit;
        }
    }
}
