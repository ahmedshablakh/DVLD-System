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
    public partial class frmShowDetalisLocalAppInfo : Form
    {
        int _LocalAppID;
        public frmShowDetalisLocalAppInfo(int LocalAppID)
        {
            InitializeComponent();
            _LocalAppID = LocalAppID;
        }

        private void frmShowDetalisLocalAppInfo_Load(object sender, EventArgs e)
        {
            ucDetalisLocalApplicationInfo ctrl = new ucDetalisLocalApplicationInfo(_LocalAppID);
            ctrl.Dock = DockStyle.Fill;
            this.Controls.Add(ctrl);
        }
    }
}
