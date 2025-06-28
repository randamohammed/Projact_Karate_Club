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
    public partial class AddOrUpdateUser : Form
    {
        public AddOrUpdateUser(int _UserID)
        {
            InitializeComponent();
            this.UserID = _UserID;
            if (_UserID == -1)
                Mode = _Mode.Add;
            else
                Mode = _Mode.Update;
        }
        int UserID = 0;
        clsUser ManageUser = new clsUser();
        enum _Mode { Add=0,Update=1}
        _Mode Mode;
        int Permission = 0;
        private void AddOrUpdateUser_Load(object sender, EventArgs e)
        {
            tabUserInformaiton.Enabled = false;
            if (UserID != -1)
            {
                ManageUser = clsUser.Find(UserID);
                 ctrlPersonCardWithFilter1.PersonID = ManageUser.PersonID;
                ctrlPersonCardWithFilter1.LoadPersonInfo(ManageUser.PersonID);
                LodaUser();
            }
           
        }

        private void cotrolAddOrUpdateUsers1_Load(object sender, EventArgs e)
        {
            
        }
        void LodaUser()
        {
            if(Mode  == _Mode.Add)
            {
                Permission = -1;
                ManageUser = new clsUser();
                return;
            }
            ctrlPersonCardWithFilter1.PersonID = clsUser.Find(UserID).PersonID;

            laPermissons.Text = ManageUser.Permissions.ToString();
            teuserName.Text = ManageUser.UserName;
            laUserID.Text = ManageUser.UserID.ToString();
            tePassword.Text = ManageUser.Password.ToString();
            teconfigerpassword.Text = tePassword.Text;
            Permission = ManageUser.Permissions;
            tePassword.Enabled = false;
            teconfigerpassword.Enabled = false;

        }
        private void butNaxt_Click(object sender, EventArgs e)
        {
            tabUserInformaiton.Enabled = true;
            tabControl1.SelectedIndex = 1;
            LodaUser();
        }

        private void tabUserInformaiton_Click(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teconfigerpassword_Validating(object sender, CancelEventArgs e)
        {
            if(teconfigerpassword.Text != tePassword.Text)
            {
                e.Cancel = true;
                teconfigerpassword.Focus();
                errorProvider1.SetError(teconfigerpassword, "Not Configer Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(teconfigerpassword, "");
            }
        }

        private void buSave_Click(object sender, EventArgs e)
        {
            ManageUser.UserID = UserID;
            ManageUser.UserName = teuserName.Text;
            ManageUser.Password = tePassword.Text;
            ManageUser.IsActive = true;
            ManageUser.PersonID = ctrlPersonCardWithFilter1.PersonID;
            ManageUser.Permissions = Permission;

            if(ManageUser.Save())
            {
                MessageBox.Show("Date Save Successfullt", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                laUserID.Text = ManageUser.UserID.ToString();
            }

        }

        private void likPermisson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSetPremissons SetPermissoin = new FormSetPremissons(Permission);
            SetPermissoin.OnPermissionSet += NumSetPermissoin;
            SetPermissoin.ShowDialog();
           
        }

        private void NumSetPermissoin(int NumberPermistion)
        {
            Permission = NumberPermistion;
            laPermissons.Text = NumberPermistion.ToString();
        }

       
    }
}
