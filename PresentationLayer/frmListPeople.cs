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
    public partial class frmListPeople : Form
    {

        DataTable dt = PeopleBusiness.GetAllPeople();

        public void _RefreshPeopleList()
        {
            dt = PeopleBusiness.GetAllPeople();
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            labtotalRecord.Text= dataGridView1.RowCount.ToString();
        }
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
            comFilter.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox1.Visible = false;

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

            // dataGridView1.DataSource = DVLDBusinessLayer.PeopleBusiness.GetAllContacts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addNewPerson = new frmAddEditPerson(-1,1);
            addNewPerson.ShowDialog();
            _RefreshPeopleList();
        }

        private void eidrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dataGridView1.CurrentRow.Cells[0].Value,1);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = ((int)dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Detete y /n  for id is "+Id, "Delete Person", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                PeopleBusiness.DeletePerson(Id);
                _RefreshPeopleList();
            }
    

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addNewPerson = new frmAddEditPerson(-1, 1);
            addNewPerson.ShowDialog();
            _RefreshPeopleList();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dataGridView1.CurrentRow.Cells[0].Value,2);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void comFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comFilter.SelectedIndex == 0)
            {
                txtFilterData.Visible = false;
                comboBox1.Visible= false;
                DataView dv1 = new DataView(dt);
                dataGridView1.DataSource = dv1;
                labtotalRecord.Text= dataGridView1.RowCount.ToString();
                return;
            }
            else
            {
                comboBox1.Visible = false;
                txtFilterData.Visible = true;
            }
            if (comFilter.SelectedIndex==8)
            {
                comboBox1.Visible = true;
                txtFilterData.Visible = false;
            }

            


        }



        private void txtFilterData_KeyPress_1(object sender, KeyPressEventArgs e)
        {


            if (comFilter.SelectedIndex == 1 || comFilter.SelectedIndex==7) 
            {
                
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }



            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Gendor" && e.Value != null)
            {
                int gender = Convert.ToInt32(e.Value);
                e.Value = (gender == 0) ? "Male" : "Female";
                e.FormattingApplied = true;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);

            if (comboBox1.SelectedIndex == 1)
            {
                dv.RowFilter = $"Gendor=" + 0;

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                dv.RowFilter = $"Gendor=" + 1;

            }
            else
            {
                dataGridView1.DataSource = dv;
                labtotalRecord.Text = dataGridView1.RowCount.ToString();
            }
            dataGridView1.DataSource = dv;
            labtotalRecord.Text = dataGridView1.RowCount.ToString();
        }

        private void txtFilterData_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            
            if (comFilter.SelectedIndex == 1) // فلترة بالرقم
            {

                if (txtFilterData.Text != "")
                    dv.RowFilter = "PersonID = " + Convert.ToInt32(txtFilterData.Text);

            }

            if (comFilter.SelectedIndex == 2)
            {
                if (txtFilterData.Text != "")
                    dv.RowFilter = $"NationalNo LIKE '*{txtFilterData.Text}*'";
            }

            if (comFilter.SelectedIndex == 3)
            {
                if (txtFilterData.Text != "")
                    dv.RowFilter = $"FirstName LIKE '*{txtFilterData.Text}*'";
            }
            if (comFilter.SelectedIndex == 4)
            {
                if (txtFilterData.Text != "")
                    dv.RowFilter = $"SecondName LIKE '*{txtFilterData.Text}*'";
            }
            if (comFilter.SelectedIndex == 5)
            {
                if (txtFilterData.Text != "")
                    dv.RowFilter = $"ThirdName LIKE '*{txtFilterData.Text}*'";
            }

            if (comFilter.SelectedIndex == 6)
            {
                if (txtFilterData.Text != "")
                    dv.RowFilter = $"LastName LIKE '*{txtFilterData.Text}*'";
            }
            if (comFilter.SelectedIndex == 7)
            {
                if (txtFilterData.Text != "")
                    dv.RowFilter = $"NationalityCountryID=" + Convert.ToInt32(txtFilterData.Text);
            }

            if (comFilter.SelectedIndex == 9)
            {
                if (txtFilterData.Text != "")
                    dv.RowFilter = $"Phone LIKE '*{txtFilterData.Text}*'";
            }
            if (comFilter.SelectedIndex == 10)
            {
                if (txtFilterData.Text != "")
                    dv.RowFilter = $"Email LIKE '*{txtFilterData.Text}*'";
            }
            dataGridView1.DataSource = dv;
            labtotalRecord.Text= dataGridView1.RowCount.ToString();
        }
    }
}
