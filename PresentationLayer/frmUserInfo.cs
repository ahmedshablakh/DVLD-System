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
    public partial class frmUserInfo : Form
    {
        int _UserID;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {

            cuUserInfo cuUserInfo = new cuUserInfo(_UserID);
            cuUserInfo.Dock = DockStyle.Fill;
            this.Controls.Add(cuUserInfo);


        }
    }
}
