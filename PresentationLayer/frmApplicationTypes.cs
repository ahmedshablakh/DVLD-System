using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD_System
{
    public partial class frmApplicationTypes : Form
    {
        public frmApplicationTypes()
        {
            InitializeComponent();
        }

        private void _LoadAppTypesData()
        {
            DataTable dt = clsApplicationType.GetAllAppType();
            dgvAppTypes.DataSource = dt;

            dgvAppTypes.Columns["ApplicationTypeID"].HeaderText = "ID";
            dgvAppTypes.Columns["ApplicationTypeTitle"].HeaderText = "Title";
            dgvAppTypes.Columns["ApplicationFees"].HeaderText = "Pees";

            dgvAppTypes.Columns["ApplicationTypeID"].Width = 50;
            dgvAppTypes.Columns["ApplicationTypeTitle"].Width = 310;
            dgvAppTypes.Columns["ApplicationFees"].Width = 80;
            dgvAppTypes.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lbltotalRecord.Text = dgvAppTypes.RowCount.ToString();

        }
        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadAppTypesData();
        }

        private void frmApplicationTypes_Activated(object sender, EventArgs e)
        {
            _LoadAppTypesData();
        }

        private void editApplicaitonTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateAppliacitonType frm = new frmUpdateAppliacitonType((int)dgvAppTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
