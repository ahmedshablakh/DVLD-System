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
    public partial class frmMangageDrivers : Form
    {
        public frmMangageDrivers()
        {
            InitializeComponent();
        }
         private void _loadData()
        {
            dataGridViewLicense.DataSource = clsLocalDrivingLicenseApplicationsBusiness.GetAllDrivers();
            lblTotalRecords.Text = dataGridViewLicense.RowCount.ToString();
        }

        private void frmMangageDrivers_Load(object sender, EventArgs e)
        {
            _loadData();
        }
    }
}
