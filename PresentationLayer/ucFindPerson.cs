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
    public partial class ucFindPerson : UserControl
    {
        public int _PersonID =-1;
        public string _NationalNo;
        public ucFindPerson()
        {
            InitializeComponent();
        }
        public ucFindPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void txtFindPeerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtFindPeerson.Text != "")
            {
                PeopleBusiness PersonInfo;
                if (comFilter.SelectedIndex == 1)
                {
                    PersonInfo = PeopleBusiness.GetPersonInfoByID(Convert.ToInt32(txtFindPeerson.Text));
                    if (PersonInfo != null)
                    {
                        pnlContainer.Controls.Clear();
                        _PersonID = PersonInfo.PersonID;
                        _NationalNo = PersonInfo.NationalNo;
                        cuDetailsPersonInfo uc = new cuDetailsPersonInfo(PersonInfo.PersonID);


                        uc.Dock = DockStyle.Fill;
                        pnlContainer.Controls.Add(uc);


                    }
                    else
                    {
                        MessageBox.Show("IS Not Fond By PersonID = " + txtFindPeerson.Text, "Not Fond Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pnlContainer.Controls.Clear();
                        cuDetailsPersonInfo uc = new cuDetailsPersonInfo();

                        _PersonID = PersonInfo.PersonID;
                        _NationalNo = PersonInfo.NationalNo;
                        uc.Dock = DockStyle.Fill;
                        pnlContainer.Controls.Add(uc);
                    }
                }


                else if (comFilter.SelectedIndex == 2)
                {
                    PersonInfo = PeopleBusiness.GetPersonInfoByNationalNo(txtFindPeerson.Text);
                    if (PersonInfo != null)
                    {
                        pnlContainer.Controls.Clear();
                        _PersonID = PersonInfo.PersonID;

                        cuDetailsPersonInfo uc = new cuDetailsPersonInfo(PersonInfo.PersonID);


                        uc.Dock = DockStyle.Fill;
                        pnlContainer.Controls.Add(uc);

                    }
                    else
                    {
                        MessageBox.Show("IS Not Fond By NationalNo  = " + txtFindPeerson.Text, "Not Fond Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pnlContainer.Controls.Clear();
                        cuDetailsPersonInfo uc = new cuDetailsPersonInfo();


                        uc.Dock = DockStyle.Fill;
                        pnlContainer.Controls.Add(uc);
                    }
                }




            }
        }

        private void ucFindPerson_Load(object sender, EventArgs e)
        {
            if(_PersonID!=-1)
            {
                grFilter.Enabled = false;
                comFilter.SelectedIndex = 1;
                txtFindPeerson.Text = _PersonID.ToString();
                pnlContainer.Controls.Clear();
                cuDetailsPersonInfo uc = new cuDetailsPersonInfo(_PersonID);
                uc.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(uc);
                return;
            }
            comFilter.SelectedIndex = 2;
            this.BeginInvoke((MethodInvoker)delegate
            {
                txtFindPeerson.Focus();
            });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1,1);
            frm.ShowDialog();
        }
    }
}
