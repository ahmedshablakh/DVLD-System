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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_System
{
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        DataTable dt = clsLocalDrivingLicenseApplicationsBusiness.GetAllLocalDrivingLicenseApplications();
        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }


        private void _Load()
        {

            dt = clsLocalDrivingLicenseApplicationsBusiness.GetAllLocalDrivingLicenseApplications();
            dataGridViewLocalApplications.DataSource = dt;

            dataGridViewLocalApplications.Columns["FullName"].Width = 190;

            lblTotalRecords.Text = dataGridViewLocalApplications.RowCount.ToString();

        }
        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
           
            comStatus.Visible = false;
            txtFilter.Visible = false;
            comFilterBy.SelectedIndex = 0;
            //_Load();
            _Load();
        }

        private void frmLocalDrivingLicenseApplications_Activated(object sender, EventArgs e)
        {
            //_Load();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(comFilterBy.SelectedIndex==1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void comFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comFilterBy.SelectedIndex != 0)
            {
                comStatus.Visible = false;
                txtFilter.Visible = true;

            }
            else
                txtFilter.Visible = false;

            if (comFilterBy.SelectedIndex == 4)
            {
                comStatus.Visible = true;
                txtFilter.Visible = false;
                comStatus.SelectedIndex = 0;
            }


        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);

            if (comFilterBy.SelectedIndex == 1)
            {

                if (txtFilter.Text != "")
                    dv.RowFilter = "LocalDrivingLicenseApplicationID= " + Convert.ToInt32(txtFilter.Text);

            }

            if (comFilterBy.SelectedIndex == 2)
            {
                if (txtFilter.Text != "")
                    dv.RowFilter = $"NationalNo LIKE '*{txtFilter.Text}*'";
            }

            if (comFilterBy.SelectedIndex == 3)
            {
                if (txtFilter.Text != "")
                    dv.RowFilter = $"FullName LIKE '*{txtFilter.Text}*'";
            }
           
            


            dataGridViewLocalApplications.DataSource = dv;
            lblTotalRecords.Text = dataGridViewLocalApplications.RowCount.ToString();

        }

        private void comStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comFilterBy.SelectedIndex==4)
            {

                DataView dv = new DataView(dt);
                if (comStatus.SelectedIndex==0)
                {
                    dv.RowFilter = "";
                }
                if (comStatus.SelectedIndex==1)
                {
                    dv.RowFilter = "Status ='New'";
                }
                if (comStatus.SelectedIndex == 2)
                {
                    dv.RowFilter = "Status ='Completed'";
                }
                if (comStatus.SelectedIndex == 3)
                {
                    dv.RowFilter = "Status ='Cancelled'";
                }


                dataGridViewLocalApplications.DataSource = dv;
                lblTotalRecords.Text = dataGridViewLocalApplications.RowCount.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication((int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the application?",
                                     "Delete Applicatiocn",
                                     MessageBoxButtons.OKCancel,
                                     MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                int localID = (int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value;
                clsLocalDrivingLicenseApplicationsBusiness AppInfo;
                AppInfo = clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseApplicationInfoByID(localID);
                if (clsLocalDrivingLicenseApplicationsBusiness.DeleteLocalDrivingLicenseApplicationByID(localID) &&
                    clsApplicationBusiness.DeleteApplicationByID(AppInfo.ApplicationID))
                {
                    
                        MessageBox.Show("The application was deleted successfully.", "Success");
                        _Load();
                    

                }
                else
                {
                    MessageBox.Show("Failed to delete the application.", "Error");
                }
            }

        }

        private void CancelApplication_Click_1(object sender, EventArgs e)
            {

                DialogResult result = MessageBox.Show("Do you want to cancel the application?",
                                          "Cancel Confirmation",
                                          MessageBoxButtons.OKCancel,
                                          MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    int localID = (int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value;
                    if (clsApplicationBusiness.CancelApplication(clsLocalDrivingLicenseApplicationsBusiness.GetLocalDrivingLicenseApplicationInfoByID(localID).ApplicationID))
                    {
                        MessageBox.Show("The application was cancelled successfully.", "Success");
                        _Load();
                    }
                    else
                    {
                        MessageBox.Show("You cannot delete this request because it is linked to other information.", "Falid Delete");
                    }
                }

            
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDetalisLocalAppInfo frm = new frmShowDetalisLocalAppInfo((int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Load();
        }

        private void schesuleVisoimTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisionTestAppointment frm = new frmVisionTestAppointment((int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Load();
        }

        private void schesuleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWrittenTestAppointments frm = new frmWrittenTestAppointments((int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Load();
        }

        private void schesuleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStreetTestAppointments frm = new frmStreetTestAppointments((int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Load();
        }

       

        private void SchduleTestToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            schesuleVisoimTestToolStripMenuItem.Enabled = (clsLocalDrivingLicenseApplicationsBusiness.GetTotalPassedTestByID((int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value) == 0);
            schesuleWrittenTestToolStripMenuItem.Enabled = (clsLocalDrivingLicenseApplicationsBusiness.GetTotalPassedTestByID((int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value) == 1);
            schesuleStreetTestToolStripMenuItem.Enabled = (clsLocalDrivingLicenseApplicationsBusiness.GetTotalPassedTestByID((int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value) == 2);

        }
    }
}
