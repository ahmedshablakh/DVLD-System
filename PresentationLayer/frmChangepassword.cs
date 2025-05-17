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
    public partial class frmChangepassword : Form
    {
        int _UserID;
        public frmChangepassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmChangepassword_Load(object sender, EventArgs e)
        {
            cuChangepassword cuChangepassword = new cuChangepassword(_UserID);
            cuChangepassword.Dock = DockStyle.Fill;
            this.Controls.Add(cuChangepassword);

        }
    }
}
