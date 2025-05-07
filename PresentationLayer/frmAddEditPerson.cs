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
        public frmAddEditPerson(int PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent(PersonID);
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            cuAddNewPerson ctrl = new cuAddNewPerson(_PersonID);
            ctrl.Dock = DockStyle.Fill;

            // إضافة الكنترول إلى الفورم (يفترض أن يكون هناك Panel أو Container)
            this.Controls.Add(ctrl);
        }
    }
}
