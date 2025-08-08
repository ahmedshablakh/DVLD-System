using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void _LoadAppTypesData()
        {
            DataTable dt = clsTestType.GetAllTestTypes();
            dgvTestTypes.DataSource = dt;
           
            dgvTestTypes.Columns["TestTypeID"].HeaderText = "ID";
            dgvTestTypes.Columns["TestTypeTitle"].HeaderText = "Title";
            dgvTestTypes.Columns["TestTypeDescription"].HeaderText = "Description";
            dgvTestTypes.Columns["TestTypeFees"].HeaderText = "Pees";



            dgvTestTypes.Columns["TestTypeID"].Width = 40;
            dgvTestTypes.Columns["TestTypeTitle"].Width = 100;
            dgvTestTypes.Columns["TestTypeDescription"].Width = 420;
            dgvTestTypes.Columns["TestTypeFees"].Width = 70;
            dgvTestTypes.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lbltotalRecord.Text = dgvTestTypes.RowCount.ToString();

        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadAppTypesData();
        }

        private void frmManageTestTypes_Activated(object sender, EventArgs e)
        {
            _LoadAppTypesData();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
