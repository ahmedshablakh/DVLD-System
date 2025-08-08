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
    public partial class frmStreetTestAppointments : Form
    {
        int _LocalAppID;
        public frmStreetTestAppointments(int LocalAppID)
        {
            InitializeComponent();
            _LocalAppID = LocalAppID;
        }
        private void GetAllStreetTestAppointments()
        {
            dataGridView1.DataSource = clsTestAppointment.GetAllTestAppointmentsByLocalAppID(_LocalAppID, 3);
            lblTotalRecord.Text = dataGridView1.RowCount.ToString();
        }
        private void frmStreetTestAppointments_Load(object sender, EventArgs e)
        {
           

           
            ucDetalisLocalApplicationInfo cuD = new ucDetalisLocalApplicationInfo(_LocalAppID);
            cuD.Dock = DockStyle.Fill;
            panel1.Controls.Add(cuD);
            GetAllStreetTestAppointments();

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (clsLocalDrivingLicenseApplication.GetTotalPassedTestByID(_LocalAppID) > 2)
            {

                MessageBox.Show("You have passed this exam. You cannot add another exam.", "Error");
                return;

            }
            if (clsTestAppointment.CheckTestIsActive(_LocalAppID, 3))
            {
                MessageBox.Show("You cannot add a new exam if you have an active exam.", "Error");
                return;
            }

            frmScheduleStreetTest frm = new frmScheduleStreetTest(_LocalAppID,-1);
            frm.ShowDialog();
            GetAllStreetTestAppointments();

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTetakeTest frm = new frmTetakeTest((int)dataGridView1.CurrentRow.Cells[0].Value, -1, 3);
            frm.ShowDialog();
            GetAllStreetTestAppointments();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleStreetTest frm = new frmScheduleStreetTest(_LocalAppID,(int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            GetAllStreetTestAppointments();
        }
    }
}
