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
    public partial class frmWrittenTestAppointments : Form
    {
        int _LocalAppID;
        public frmWrittenTestAppointments(int LocalAppID)
        {
            InitializeComponent();
            _LocalAppID = LocalAppID;
        }

        private void GetAllWrittenTestAppointments()
        {
            dataGridView1.DataSource = clsTestAppointmentsBusiness.GetAllTestAppointmentsByLocalAppID(_LocalAppID,2);
            lblTotalRecord.Text = dataGridView1.RowCount.ToString();
        }

       

        private void frmWrittenTestAppointments_Load(object sender, EventArgs e)
        {
            
                ucDetalisLocalApplicationInfo cuD = new ucDetalisLocalApplicationInfo(_LocalAppID);
                cuD.Dock = DockStyle.Fill;
                panel1.Controls.Add(cuD);
            GetAllWrittenTestAppointments();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (clsLocalDrivingLicenseApplicationsBusiness.GetTotalPassedTestByID(_LocalAppID) > 1)
            {

                MessageBox.Show("You have passed this exam. You cannot add another exam.", "Error");
                return;

            }
            if (clsTestAppointmentsBusiness.CheckTestIsActive(_LocalAppID, 2))
            {
                MessageBox.Show("You cannot add a new exam if you have an active exam.", "Error");
                return;
            }

            frmScheduleWrittenTest frm = new frmScheduleWrittenTest(_LocalAppID,-1);
            frm.ShowDialog();
            GetAllWrittenTestAppointments();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleWrittenTest frm = new frmScheduleWrittenTest(_LocalAppID, (int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            GetAllWrittenTestAppointments();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTetakeTest frm = new frmTetakeTest((int)dataGridView1.CurrentRow.Cells[0].Value, -1, 2);
            frm.ShowDialog();
            GetAllWrittenTestAppointments();
        }
    }
}
