using clsBussinsKarateClubProjacjat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClubProjact
{
    public partial class ChenagePassword : Form
    {
        public ChenagePassword(int UserID )
        {
            InitializeComponent();
            ShowUserInfo.UserID = UserID;
           this.UserID = UserID;
        }
        int UserID = 0;
        clsUser ManageUser;
        private void ChenagePassword_Load(object sender, EventArgs e)
        {
            ManageUser = clsUser.Find(UserID);
            if (ManageUser != null)
            {
                showUserInfo1.FullDate();

            }
        }


        private void showUserInfo1_Load(object sender, EventArgs e)
        {

        }

        private void showUserInfo1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void teLastPassword_Validating(object sender, CancelEventArgs e)
        {
            ManageUser = clsUser.Find(UserID);

            if (ManageUser.Password != teLastPassword.Text)
            {
                teLastPassword.Focus();
                errorProvider1.SetError(teLastPassword, "Error in Last Password");
                e.Cancel = true; ; 
            }
            else
            {
                errorProvider1.SetError(teLastPassword, "");
                e.Cancel = false; 
            }
        }

        private void teConfigerPassword_Validating(object sender, CancelEventArgs e)
        {
            if(teNewPassword.Text != teConfigerPassword.Text)
            {
                teConfigerPassword.Focus();
                errorProvider1.SetError(teConfigerPassword, "Error Configer Password is not same with new password");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(teConfigerPassword, "");
                e.Cancel = false;
            }
        }

        private void buSave_Click(object sender, EventArgs e)
        {
            if (ManageUser.Password == teLastPassword.Text)
            {
                if (MessageBox.Show("Are you sure you wante to chanage password?", "Configer chanage password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManageUser.Password = teNewPassword.Text;
                    if (ManageUser.Save())
                    {
                        MessageBox.Show("Password Chanage sussfully", "Chanage password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Do not save New password","Not Save",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
            }
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
