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
    public partial class frmUpdateAppliacitonType : Form
    {
        int _ID;
        clsApplicationType AppTypeInfo;
        public frmUpdateAppliacitonType(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(txtFees.Text !=""&& txtTitle.Text!="")
            {
                AppTypeInfo.Title = txtTitle.Text;
                AppTypeInfo.Fees = decimal.Parse(txtFees.Text);
                if(AppTypeInfo.Save())
                {
                    MessageBox.Show("Update Successffuly..", "Successffuly");
                    _loodData();
                }
                else
                {
                    MessageBox.Show("Update Falid..", "Falid");
                }
            }
        }

        private void frmUpdateAppliacitonType_Load(object sender, EventArgs e)
        {
            _loodData();
        }
        private void _loodData()
        {
            AppTypeInfo = clsApplicationType.GetApplicationTypeByID(_ID);
            if(AppTypeInfo != null)
            {
                lblID.Text = AppTypeInfo.Id.ToString();
                txtTitle.Text = AppTypeInfo.Title;
                txtFees.Text = AppTypeInfo.Fees.ToString();
            }
            
           
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
