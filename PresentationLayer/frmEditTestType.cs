using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class frmEditTestType : Form
    {
        int _ID;
        clsTestType TestInfo;
        public frmEditTestType(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _loodData()
        {
            TestInfo = clsTestType.GetTestTypeByID(_ID);
            if (TestInfo != null)
            {
                lblID.Text = TestInfo.Id.ToString();
                txtTitle.Text = TestInfo.Title;
                txtDescription.Text = TestInfo.Description;
                txtFees.Text = TestInfo.Fees.ToString();
            }


        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _loodData();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            if (txtFees.Text != "" && txtTitle.Text != ""&& txtDescription.Text!="")
            {
                TestInfo.Title = txtTitle.Text;
                TestInfo.Description = txtDescription.Text;
                TestInfo.Fees = float.Parse(txtFees.Text);
                if (TestInfo.Save())
                {
                    MessageBox.Show("Update Successffuly..", "Successffuly");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Falid..", "Falid");
                }
            }
            else
            {
                MessageBox.Show("Empy Data..");
            }
        }

        
        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
