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
    public partial class ctrlShowMemberInfo : UserControl
    {
        public ctrlShowMemberInfo()
        {
            InitializeComponent();
         
        }

        int _MemberID;
        clsMembers _Members;
        public clsMembers SelectMemberInfo
        {
            get { return _Members; }
        }

        private void LoadData()
        {
            ShowPeopleInfo.MangePeopleID = _Members.PersonID;
            showPeopleInfo1.FullDate();
            lbLastBeltRank.Text = clsBeltRanks.Find((clsBeltRanks.enBeltRank)_Members.LastBeltRank).RankName;
            lbMemberID.Text = _MemberID.ToString();
            lbEmergencyContactInfo.Text = (_Members.EmergencyContactInfo != "") ? _Members.EmergencyContactInfo : "No Emergency Contact Info";
            lbISActive.Text = (_Members.IsActive) ? "Yse" : "No";

        }
        public void LoadMemberInfo(int MemberID)
        {
            _MemberID = MemberID;
            _Members = clsMembers.FindByID(_MemberID);
            if (_Members == null)
            {
                MessageBox.Show("Select member is not found,Chooes one member", "Error dont Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;        
            }
            LoadData();
        }

        public void LoadMemberInfoByPesonID(int PersonId)
        {
           
            _Members = clsMembers.FindByPersonID(PersonId);
            if (_Members == null)
            {
             MessageBox.Show("Select member is not found,Chooes one member","Error dont Select",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadData();
            _MemberID = _Members.MembersID;
        }


        private void ctrlShowMemberInfo_Load(object sender, EventArgs e)
        {
        }
    }
}
