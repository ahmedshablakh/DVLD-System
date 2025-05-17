using BusinessLayer;
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
    public partial class ucLoginInformation : UserControl
    {
        
        public int _UserID =-1;
        public ucLoginInformation()
        {
            InitializeComponent();
        }
        public ucLoginInformation(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;

        }
        private void ucLoginInformation_Load(object sender, EventArgs e)
        {
            
            if(_UserID !=-1)
            {
                clsUsersBusiness UserInfo = clsUsersBusiness.GetUserInfoByID(_UserID);
                lblUserID.Text = _UserID.ToString();
                lblUsername.Text = UserInfo.Username;
                lblIsActive.Text = UserInfo.IsActive ? "True" : "False";
            }
            

        }
    }
}
