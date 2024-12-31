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
    public partial class frmAddUpdatePeople : Form
    {
        private int _PersonID=-1;
        public frmAddUpdatePeople( int PersonID )
        {
            InitializeComponent();
            _PersonID = PersonID;

        }

        private void frmAddUpdatePeople_Load(object sender, EventArgs e)
        {

        }

        private void frmAddUpdatePeople_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text= _PersonID.ToString();
        }
    }
}
