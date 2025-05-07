using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_System
{
    public partial class Form1 : Form
    {

        public void RefreshPeopleList()
        {
            dataGridView1.DataSource = DVLDBusinessLayer.PeopleBusiness.GetAllContacts();
            labtotalRecord.Text= dataGridView1.RowCount.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPeopleList();

           // dataGridView1.DataSource = DVLDBusinessLayer.PeopleBusiness.GetAllContacts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addNewPerson = new frmAddEditPerson(-1);
            addNewPerson.ShowDialog();
            RefreshPeopleList();
        }

        private void eidrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = ((int)dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Detete y /n  for id is "+Id, "Delete Person", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                PeopleBusiness.DeletePerson(Id);
                RefreshPeopleList();
            }
    

        }
    }
}
