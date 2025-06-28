using DVLDSluotion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClubProjact
{
    public partial class FormSetPremissons : Form
    {
        public FormSetPremissons(int _Permission)
        {
            InitializeComponent();
            _Permissions = _Permission;
        }
        int _Permissions = 0;

      public  enum enPermissions { All= -1 ,ManagePeople =2,manageMemmbers=4,ManageUsr=8,ManageBletTest =16,ManageBeltRanke=32,
            ManagePayments =64, ManageInstructors =128, ManageSubscriptionPeriods = 256,ManageMemmberInstructors =512
        }
      public  enPermissions permissions;
      int countPermissions = 0;

        public delegate void PermissionSet(int NumberPermistion);
        public event PermissionSet OnPermissionSet;
        private void FormSetPremissons_Load(object sender, EventArgs e)
        {
            if(_Permissions != 0)
            {
                if (_Permissions == -1)
                {
                    chAllPermission.Checked = true;
                    return;
                }
                //if (_Permissions == (int)enPermissions.All)
                //    AllCheke();

              
                if ((_Permissions &(int) enPermissions.ManagePeople) == (int)enPermissions.ManagePeople)
                {
                   chManagePeople.Checked = true;
                }

                if ((_Permissions & (int)enPermissions.manageMemmbers) == (int)enPermissions.manageMemmbers)
                {
                    chManageMemmbers.Checked = true;
                }

                if ((_Permissions & (int)enPermissions.ManageBeltRanke) == (int)enPermissions.ManageBeltRanke)
                {
                    chManagBeltRanks.Checked = true;
                }

                if ((_Permissions & (int)enPermissions.ManageBletTest) == (int)enPermissions.ManageBletTest)
                {
                    chManageBeltTests.Checked = true;
                }

                if ((_Permissions & (int)enPermissions.ManageMemmberInstructors) == (int)enPermissions.ManageMemmberInstructors)
                {
                    chManageMemmberInstructors.Checked = true;
                }
                if ((_Permissions & (int)enPermissions.ManageSubscriptionPeriods) == (int)enPermissions.ManageSubscriptionPeriods)
                {
                    chManageMemmberInstructors.Checked = true;
                }

                if ((_Permissions & (int)enPermissions.ManagePayments) == (int)enPermissions.ManagePayments)
                {
                    chManagePayments.Checked = true;
                }
                if ((_Permissions & (int)enPermissions.ManageInstructors) == (int)enPermissions.ManageInstructors)
                {
                    chbManageInstructors.Checked = true;
                }

                if ((_Permissions & (int)enPermissions.ManageUsr) == (int)enPermissions.ManageUsr)
                {
                    chManageUser.Checked = true;
                }
            }
        }

        void SetPermissions(enPermissions permissions ,int CountPermission)
        {
            if (enPermissions.All == permissions)
            {
                countPermissions = -1;
                return;
            }

            if (enPermissions.ManagePeople == permissions)
                countPermissions += CountPermission;

            if(enPermissions.manageMemmbers == permissions)
                countPermissions += CountPermission;

            if(enPermissions.ManageUsr == permissions)
                countPermissions += CountPermission;

            if(enPermissions.ManageBletTest == permissions)
                countPermissions += CountPermission;

            if(enPermissions.ManageBeltRanke == permissions)
                countPermissions += CountPermission;

            if(enPermissions.ManagePayments == permissions)
                countPermissions += CountPermission;

            if(enPermissions.ManageMemmberInstructors == permissions)
                countPermissions += CountPermission;

            if(enPermissions.ManageSubscriptionPeriods == permissions)
                countPermissions += CountPermission;



        }

       

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
            OnPermissionSet?.Invoke(countPermissions);
        }

        void AllCheke()
        {
            chbManageInstructors.Checked = true;
            chManagBeltRanks.Checked = true;
            chManageBeltTests.Checked = true;
            chManageMemmberInstructors.Checked = true;
            chManagePayments.Checked = true;
            chManagePeople.Checked = true;
            chManageSubscriptionPeriods.Checked = true;
            chManageUser.Checked = true;
            chManageMemmbers.Checked = true;
        }

        private void chAllPermission_CheckedChanged(object sender, EventArgs e)
        {
            if(chAllPermission.Checked ==true)
            {
                AllCheke();

                SetPermissions(enPermissions.All,Convert.ToInt32( enPermissions.All));
            }
        }

        private void chManagePeople_CheckedChanged(object sender, EventArgs e)
        {
            if(chManagePeople.Checked ==true) 
               SetPermissions(enPermissions.ManagePeople, Convert.ToInt32(enPermissions.ManagePeople));
        }

        private void chbManageInstructors_CheckedChanged(object sender, EventArgs e)
        {
            if(chbManageInstructors.Checked ==true)
                SetPermissions(enPermissions.ManageMemmberInstructors, Convert.ToInt32(enPermissions.ManageMemmberInstructors));
        }

        private void chManageMemmbers_CheckedChanged(object sender, EventArgs e)
        {
            if (chManageMemmbers.Checked == true)
                SetPermissions(enPermissions.manageMemmbers, Convert.ToInt32(enPermissions.manageMemmbers));
        }

        private void chManageBeltTests_CheckedChanged(object sender, EventArgs e)
        {
            if (chManageBeltTests.Checked == true)
                SetPermissions(enPermissions.ManageBletTest, Convert.ToInt32(enPermissions.ManageBletTest));
        }

        private void chManagBeltRanks_CheckedChanged(object sender, EventArgs e)
        {
            if (chManagBeltRanks.Checked == true)
                SetPermissions(enPermissions.ManageBeltRanke, Convert.ToInt32(enPermissions.ManageBeltRanke));
        }

        private void chManagePayments_CheckedChanged(object sender, EventArgs e)
        {
            if (chManagePayments.Checked == true)
                SetPermissions(enPermissions.ManagePayments, Convert.ToInt32(enPermissions.ManagePayments));
        }

        private void chManageSubscriptionPeriods_CheckedChanged(object sender, EventArgs e)
        {
            if (chManageSubscriptionPeriods.Checked == true)
                SetPermissions(enPermissions.ManageSubscriptionPeriods, Convert.ToInt32(enPermissions.ManageSubscriptionPeriods));
        }

        private void chManageMemmberInstructors_CheckedChanged(object sender, EventArgs e)
        {
            if (chManageMemmberInstructors.Checked == true)
                SetPermissions(enPermissions.ManageMemmberInstructors, Convert.ToInt32(enPermissions.ManageMemmberInstructors));
        }

        private void chManageUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chManageUser.Checked == true)
                SetPermissions(enPermissions.ManageUsr, Convert.ToInt32(enPermissions.ManageUsr));
        }
    }
}
