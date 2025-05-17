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
    public partial class cuUserInfo : UserControl
    {
        int _UserID = -1;
        clsUsersBusiness UserInfo;
        public cuUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            UserInfo = clsUsersBusiness.GetUserInfoByID(_UserID);


        }
        public cuUserInfo()
        {
            InitializeComponent();

        }

        private void cuUserInfo_Load(object sender, EventArgs e)
        {

            if(UserInfo!=null)
            {
                ucLoginInformation cuLoginInfo = new ucLoginInformation(UserInfo.UserID);

                cuDetailsPersonInfo cuDePerson = new cuDetailsPersonInfo(UserInfo.PersonID);
                panPersonInfo.Controls.Clear();
                panPersonInfo.Controls.Add(cuDePerson);

                panLoginInfo.Controls.Clear();
                panLoginInfo.Controls.Add(cuLoginInfo);
            }
            
        }
    }
}
