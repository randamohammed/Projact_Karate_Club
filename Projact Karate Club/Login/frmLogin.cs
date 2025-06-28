using clsBussinsKarateClubProjacjat;
using DVLDSluotion;
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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        clsUser _User;
        private void LoginScreen_Load(object sender, EventArgs e)
        {

            string Usernam = "", Password = "";
           if(clsGlobal.GetStoredCredentil(ref Usernam,ref Password))
            {
                tebPassword.Text = Password;
                tebUsername.Text = Usernam;
                chbRemminderMe.Checked = true;
                clsGlobal.CurrentUser = clsUser.FindByUsernameAndPassword(Usernam,Password);
           }
           else
            chbRemminderMe.Checked = false;
        }

        private void butLogin_Click_2(object sender, EventArgs e)
        {
            _User = clsUser.FindByUsernameAndPassword(tebUsername.Text,tebPassword.Text);

            if(_User != null)
            {
                if(chbRemminderMe.Checked == true)
                {
                    clsGlobal.RememberUsernameAndPassword(tebUsername.Text, tebPassword.Text);

                }
                else
                    clsGlobal.RememberUsernameAndPassword("", "");

                if (!_User.IsActive)
                {
                    tebUsername.Focus();
                    MessageBox.Show("your acounted is not Actve,Contact Adamin", "In Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                clsGlobal.CurrentUser = _User;
                ShowItemsInSysetem showItems = new ShowItemsInSysetem(this);
                this.Hide();
                showItems.ShowDialog();
            }
            else
            {
                tebUsername.Focus();
                MessageBox.Show("Invalid Username/Passsword.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        private void tebPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tebPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tebPassword, "Passwored musct be Empte");
            }
            else
                errorProvider1.SetError(tebPassword, null);
        }

        private void tebUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tebUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tebUsername, "Passwored musct be Empte");
            }
            else
                errorProvider1.SetError(tebUsername, null);
        }
    }
}
