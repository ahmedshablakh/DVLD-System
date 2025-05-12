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
    public partial class frmUsersList : Form
    {
        DataTable dt = clsUsersBusiness.GetAllUsers();
        public frmUsersList()
        {
            InitializeComponent();
            comIsActiv.Visible = false;
            txtFilter.Visible = false;
            comUserFilterData.SelectedIndex = 0;
            comIsActiv.SelectedIndex = 0;

        }

        private void lblRecordText_Click(object sender, EventArgs e)
        {

        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = clsUsersBusiness.GetAllUsers();
            lblTotalRecords.Text = dataGridViewUsers.RowCount.ToString();

            dataGridViewUsers.Columns["FullName"].Width = 200;
        }

        private void comUserFilterData_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text ="";
            if(comUserFilterData.SelectedIndex == 0)
            {
                comIsActiv.Visible = false;
                txtFilter.Visible = false;
                DataView dv = new DataView(dt);
                dataGridViewUsers.DataSource = dv;
                lblTotalRecords.Text = dataGridViewUsers.RowCount.ToString();

                return;
            }

            if(comUserFilterData.SelectedIndex == 5)
            {
                comIsActiv.Visible = true;
                comIsActiv.SelectedIndex = 0;
                txtFilter.Visible=false;
                return;
            }
            else
            {
                comIsActiv.Visible = false;
            }
            txtFilter.Visible = true;
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comUserFilterData.SelectedIndex == 1 || comUserFilterData.SelectedIndex == 3)
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }



            }
        }
        private void comIsActiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comUserFilterData.SelectedIndex == 5)
            {
                DataView dv = new DataView(dt);
                if (comIsActiv.Visible == true)
                {

                    if (comIsActiv.SelectedIndex == 1)
                    {
                        dv.RowFilter = "IsActive = " + 1;
                    }
                    else if (comIsActiv.SelectedIndex == 2)
                    {
                        dv.RowFilter = "IsActive = " + 0;
                    }
                    else
                    {
                        dv.RowFilter = "";
                    }


                }
                dataGridViewUsers.DataSource = dv;
                lblTotalRecords.Text = dataGridViewUsers.RowCount.ToString();

            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {


            DataView dv = new DataView(dt);
            
            if (comUserFilterData.SelectedIndex == 1)
            {

                if (txtFilter.Text != "")
                    dv.RowFilter = "UserID = " + Convert.ToInt32(txtFilter.Text);

            }

            if (comUserFilterData.SelectedIndex == 2)
            {
                if (txtFilter.Text != "")
                    dv.RowFilter = $"UserName LIKE '*{txtFilter.Text}*'";
            }

            if (comUserFilterData.SelectedIndex == 3)
            {
                if (txtFilter.Text != "")
                    dv.RowFilter = "PersonID=" + Convert.ToInt32(txtFilter.Text);
            }
            if (comUserFilterData.SelectedIndex == 4)
            {
                if (txtFilter.Text != "")
                    dv.RowFilter = $"FullName LIKE '*{txtFilter.Text}*'";
            }

            dataGridViewUsers.DataSource = dv;
            lblTotalRecords.Text = dataGridViewUsers.RowCount.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
        }
    }
}
