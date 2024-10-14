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
        public ClassesPanel()
        {
            InitializeComponent();
            showBtns();
        }
        private void showBtns(Boolean selected = false)
        {
            BtnUpdate.Visible = selected;
            BtnDelete.Visible = selected;
            BtnAdd.Visible = !selected;
        }
    }
}
