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
    public partial class frmAddEditPerson : Form
    {
        public int _PersonID;
        public int i;
        public frmAddEditPerson(int PersonID, int i)
        {
            _PersonID = PersonID;
            InitializeComponent();
            this.i = i;
        }


        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            if (i == 1)
            {
               
                cuAddNewPerson ctrl = new cuAddNewPerson(_PersonID);
                ctrl.Dock = DockStyle.Fill;
                this.Controls.Add(ctrl);

               

            }
            else if (i == 2)
            {
                cuDetailsPersonInfo ctrl = new cuDetailsPersonInfo(_PersonID);
                ctrl.Dock = DockStyle.Fill;

                
                this.Controls.Add(ctrl);
            }
        }

       
    }
}