using clsBussinsKarateClubProjacjat;
using KarateClubProjact.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClubProjact.Members
{
    public partial class ctrlFindMemberInfo : UserControl
    {
        public ctrlFindMemberInfo()
        {
            InitializeComponent();
        }

        int MemberID = -1;
        clsMembers Members;

        private void HandelImage()
        {
            if (Members.SelectpersonInfo.Gander == 1)
                pbMemberImage.Image = Resources.Female_512;
            else
                pbMemberImage.Image = Resources.Male_512;

            if (Members.SelectpersonInfo.PathImage != "")
                pbMemberImage.ImageLocation = Members.SelectpersonInfo.PathImage;
        }
        public void LoadMemberInfo(int MemberID)
        {
            Members = clsMembers.FindByID(MemberID);

            if (Members != null)
            {
                lbBirthOfDate.Text = Members.SelectpersonInfo.DateBirth.ToString();
                lbAddress.Text = Members.SelectpersonInfo.Adress;
                lbEmergencyInfo.Text = Members.EmergencyContactInfo;
                lbLastBeltRank.Text = Members.LastBeltRank.ToString();
                lbIsActive.Text = Members.IsActive == true ? "Yes" : "No";
                lbGender.Text = Members.SelectpersonInfo.Gander == 0 ? "Male" : "Female";
                lbName.Text = Members.Membername;

                HandelImage();
            }

        }

        private void ctrlFindMemberInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
