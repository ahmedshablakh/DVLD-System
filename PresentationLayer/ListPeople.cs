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
    public partial class ListPeople : Form
    {

        public void _RefreshPeopleList()
        {
            dataGridView1.DataSource = PeopleBusiness.GetAllPeople();
            labtotalRecord.Text= dataGridView1.RowCount.ToString();
        }
        public ListPeople()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();

           // dataGridView1.DataSource = DVLDBusinessLayer.PeopleBusiness.GetAllContacts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addNewPerson = new frmAddEditPerson(-1);
            addNewPerson.ShowDialog();
            _RefreshPeopleList();
        }

        private void eidrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dataGridView1.CurrentRow.Cells[0].Value);
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
    }
}
