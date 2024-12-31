using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDAnwar
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void msHomePage_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
     
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        frmPeople frm = new frmPeople();
        frm.MdiParent = this;
            frm.Show();
            
        }
    }
}
