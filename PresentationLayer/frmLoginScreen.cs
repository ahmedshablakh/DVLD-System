using BusinessLayer;
using System;
using System.Windows.Forms;
using System.IO;

namespace DVLD_System
{
    public partial class frmLoginScreen : Form
    {
       

        public frmLoginScreen()
        {
            InitializeComponent();
        }
        public string path = "user_credentials.txt";
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string[] data = File.ReadAllText(path).Split(',');
                txtUsernmae.Text = data[0];
                txtPassword.Text = data[1];
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsGlobal.CurrentUser = clsUser.GetUserInfoByUsernameAndPassword(txtUsernmae.Text, txtPassword.Text);

            if (clsGlobal.CurrentUser != null)
            {
                if (clsGlobal.CurrentUser.IsActive)
                {
                    if(checkBox1.Checked)
                    {
                        

                        string username = txtUsernmae.Text;
                        string password = txtPassword.Text;

                        File.WriteAllText(path, $"{username},{password}");
                    }
                    else
                    {
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                   
                    frmHome frm = new frmHome();
                    this.Hide(); 
                    frm.ShowDialog(); 
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("This user is not active. Please contact the administrator.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
