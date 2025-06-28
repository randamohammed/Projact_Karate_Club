using DVLDSluotion;
using KarateClubProjact.MemberInstructor;
using KarateClubProjact.Payments;
using KarateClubProjact.Subscription_Periods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KarateClubProjact.FormSetPremissons;

namespace KarateClubProjact
{
    public partial class ShowItemsInSysetem : Form
    {
        Form _loganfrm;
        public ShowItemsInSysetem(Form loganfrm)
        {
            InitializeComponent();
            _loganfrm = loganfrm;
        }

        private void labMemberInstructors_MouseEnter(object sender, EventArgs e)
        {
            pMemberInstructors.BackColor = Color.White;

        }

        private void labMemberInstructors_MouseLeave(object sender, EventArgs e)
        {
            pMemberInstructors.BackColor = Color.Salmon;

        }   

        private void laUsers_Click_1(object sender, EventArgs e)
        {
            if (!CheakAccessPermissio(enPermissions.ManageUsr))
            {
                SaundMessageforPermission();
                return;
            }

            ManageUsers manageUsers = new ManageUsers();
            this.Hide();
            manageUsers.ShowDialog();
            this.Show();
        }

      
        private void lbBeltRanks_Click(object sender, EventArgs e)
        {
            if (!CheakAccessPermissio(enPermissions.ManageBeltRanke))
            {
                SaundMessageforPermission();
                return;
            }
            frmLastBeltRank frm = new frmLastBeltRank();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void laPeople_Click(object sender, EventArgs e)
        {
            if (!CheakAccessPermissio(enPermissions.ManagePeople))
            {
                SaundMessageforPermission();
                return;
            }
            ManagePeople frm = new ManagePeople();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

      
        private void lbInstructors_Click(object sender, EventArgs e)
        {

            if (!CheakAccessPermissio(enPermissions.ManageInstructors))
            {
                SaundMessageforPermission();
                return;
            }
            frmLastInteructor frm = new frmLastInteructor();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void labMemberInstructors_Click(object sender, EventArgs e)
        {
            if (!CheakAccessPermissio(enPermissions.ManageMemmberInstructors))
            {
                SaundMessageforPermission();
                return;
            }

            frmLastMemberInstructor frm = new frmLastMemberInstructor();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void labLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            _loganfrm.Show();
        }

        private void labPayments_Click(object sender, EventArgs e)
        {
            if (!CheakAccessPermissio(enPermissions.ManagePayments))
            {
                SaundMessageforPermission();
                return;
            }

            frmListPayments frm = new frmListPayments();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void lbSubscriptionperiod_Click(object sender, EventArgs e)
        {
            if (!CheakAccessPermissio(enPermissions.ManageSubscriptionPeriods))
            {
                SaundMessageforPermission();
                return;
            }

            frmListSubscriptionPeriods frm = new frmListSubscriptionPeriods();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void labBeltTests_Click(object sender, EventArgs e)
        {
            if(!CheakAccessPermissio(enPermissions.ManageBletTest))
            {
                SaundMessageforPermission();
                return;
            }

            frmListBeltTests frm = new frmListBeltTests();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        bool CheakAccessPermissio(enPermissions permissions)
        {
            if(clsGlobal.CurrentUser.Permissions == (int)enPermissions.All)
                return true;

            int Numpermissions =(int) permissions;
            if ((Numpermissions & clsGlobal.CurrentUser.Permissions ) == Numpermissions)
            {
                return true;
            }
            return false;
        }


        void SaundMessageforPermission()
        {

            MessageBox.Show("you doesnt have Porgission to do this. please Comact your Adamin", 
                "Comact your Adamin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ShowItemsInSysetem_Load(object sender, EventArgs e)
        {
            lbUesName.Text = clsGlobal.CurrentUser.UserName;
        }

        private void lbMember_Click(object sender, EventArgs e)
        {
            if (!CheakAccessPermissio(enPermissions.manageMemmbers))
            {
                SaundMessageforPermission();
                return;
            }

            frmLastMember frm = new frmLastMember();
                this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
