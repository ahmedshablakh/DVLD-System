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
    
    public partial class frmVisionTestAppointment : Form
    {
        int _LocalAppID;
        DataTable dt;
        public frmVisionTestAppointment(int localAppID)
        {
            InitializeComponent();
            _LocalAppID = localAppID;
            
        }

        private void GetAllVisionTestAppointments()
        {
            dt = clsTestAppointmentsBusiness.GetAllTestAppointmentsByLocalAppID(_LocalAppID, 1);
            dataGridView1.DataSource = dt;
            lblTotalRecord.Text=dataGridView1.RowCount.ToString();
        }

        private void frmVisionTestAppointment_Load(object sender, EventArgs e)
        {
            ucDetalisLocalApplicationInfo cuD = new ucDetalisLocalApplicationInfo(_LocalAppID);
            cuD.Dock = DockStyle.Fill;
            panel1.Controls.Add(cuD);
            GetAllVisionTestAppointments();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(clsLocalDrivingLicenseApplication.GetTotalPassedTestByID(_LocalAppID)>0)
            {

                MessageBox.Show("You have passed this exam. You cannot add another exam.", "Error");
                return;

            }
            if (clsTestAppointmentsBusiness.CheckTestIsActive(_LocalAppID, 1))
            {
                MessageBox.Show("You cannot add a new exam if you have an active exam.", "Error");
                return;
            }

            frmScheduleVisionTest frm = new frmScheduleVisionTest(_LocalAppID,-1);
            frm.ShowDialog();
            GetAllVisionTestAppointments();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTetakeTest frm = new frmTetakeTest((int)dataGridView1.CurrentRow.Cells[0].Value,-1,1);
            frm.ShowDialog();
            GetAllVisionTestAppointments();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleVisionTest frm = new frmScheduleVisionTest(_LocalAppID, (int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            GetAllVisionTestAppointments();
        }
    }
}
