using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2DVLDBusinessLayer;

namespace DVLDAnwar
{
    public partial class frmPeople : Form
    {
        private void SearchFromDataBase(string SearchText)
        {
           
            SearchText = txtSearchPeople.Text;
            DGVPeople.DataSource = clsPeople.GetAllPeople(SearchText);
        }
        public frmPeople()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string SearchText = "";
            DGVPeople.DataSource = clsPeople.GetAllPeople(SearchText);
        }

        private void DGVPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SearchText = "";
            SearchFromDataBase(SearchText);
           
        }

        private void btnCloseFrmPeople_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople(-1);
            frm.ShowDialog();
        }
    }
}
