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

namespace KarateClubProjact.Belt_Test
{
    public partial class frmTakeTestfromNextBelt : Form
    {
        public frmTakeTestfromNextBelt(int MemberID)
        {
            InitializeComponent();
            _MemberID = MemberID;
        }
        int InstructorscarID = -1;
        clsMembers _Member;
        clsBeltTests _BeltTest;
        
        public frmTakeTestfromNextBelt()
        {
            InitializeComponent();
        }

        void LoadMemberInfo()
        {
           ctrlMemberinfoWithFilter1.LoadMemberInfo(_MemberID);
            ctrlMemberinfoWithFilter1.EnableFilter = false;
            lbCurrentBelt.Text = clsBeltRanks.Find((clsBeltRanks.enBeltRank)ctrlMemberinfoWithFilter2.SelectMemberInfo.LastBeltRank).RankName;
            lbNextBelt.Text = clsBeltRanks.Find((clsBeltRanks.enBeltRank)ctrlMemberinfoWithFilter2.SelectMemberInfo.LastBeltRank + 1).RankName;
        }

        int _MemberID = -1;
        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees must be paid");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }

            if(!clsVildation.ISNumber(txtFees.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees must be number");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }
        }

      
        private void frmTakeTestfromNextBelt_Load(object sender, EventArgs e)
        {
            lbCurrentBelt.Text = "Whiat";
            lbCurrentBelt.Text = "Not Pass Yet";
            dtpTestDate.MinDate = DateTime.Now;
            dtpTestDate.Value = DateTime.Now;
            tpBeltTestInfo.Enabled = false;
            btSave.Enabled = false;
            rbPassed.Checked = true;

            if (_MemberID != -1)
                LoadMemberInfo();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Same vailed is not valdat put moues over red icon(s) to see Error", "Not invalad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            _BeltTest = new clsBeltTests();
            _BeltTest.RankID = (clsBeltRanks.enBeltRank)ctrlMemberinfoWithFilter2.SelectMemberInfo.LastBeltRank;
            _BeltTest.Result = rbPassed.Checked ==  true ? true: false;
            _BeltTest.Date = DateTime.Now;
            _BeltTest.MemberID = _MemberID;
            _BeltTest.TestedByInstructorID = InstructorscarID;

            if(!_BeltTest.TakeTest(Convert.ToSingle(txtFees.Text)))
            {
                MessageBox.Show("Date is not Save","Error : Not Save",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbTestID.Text = _BeltTest.TestID.ToString();
            lbPaymentID.Text = _BeltTest.PaymentID.ToString();
            lbNextBelt.Text =clsBeltRanks.Find( (clsBeltRanks.enBeltRank)ctrlMemberinfoWithFilter2.SelectMemberInfo.LastBeltRank+1).RankName;


            if (rbPassed.Checked == true)
            {
                clsMembers Member = clsMembers.FindByID(ctrlMemberinfoWithFilter2.SelectMemberInfo.MembersID);
                Member.LastBeltRank = (int)clsBeltRanks.Find((clsBeltRanks.enBeltRank)ctrlMemberinfoWithFilter2.SelectMemberInfo.LastBeltRank + 1).RankID;

                if (Member.Save())
                {
                    MessageBox.Show("Date Save successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbNextBelt.Text ="take test to be :"+ clsBeltRanks.Find((clsBeltRanks.enBeltRank)Member.LastBeltRank + 1).RankName;
                    lbCurrentBelt.Text = clsBeltRanks.Find((clsBeltRanks.enBeltRank)Member.LastBeltRank ).RankName;
                    btSave.Enabled = false;
                    gbReslut.Enabled = false;
                }
            }
            


        }

        private void ctrlMemberinfoWithFilter2_OnMemberSelect(int obj)
        {
            _MemberID = obj; 
            lbCurrentBelt.Text = clsBeltRanks.Find((clsBeltRanks.enBeltRank)ctrlMemberinfoWithFilter2.SelectMemberInfo.LastBeltRank).RankName;
            lbNextBelt.Text = clsBeltRanks.Find((clsBeltRanks.enBeltRank)ctrlMemberinfoWithFilter2.SelectMemberInfo.LastBeltRank+1).RankName;

            llShowTestHistory.Enabled = true;
            if (InstructorscarID != -1 && _MemberID != -1)
            {
                btSave.Enabled = true;
                tpBeltTestInfo.Enabled = true;
               
            }
        }

        private void ctrlShowInstructorscardWithFilter2_OninstructorsSelect(int obj)
        {
            InstructorscarID = obj;
            if(InstructorscarID != -1 && _MemberID != -1)
            {
                tpBeltTestInfo.Enabled = true;
                btSave.Enabled = true;
            }
        }

        private void rbPassed_CheckedChanged(object sender, EventArgs e)
        {
            if (_MemberID != -1)
            {

               
            }
        }

        private void rbFailed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void llShowTestHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmShowTestHistory frm = new frmShowTestHistory(_MemberID);
            frm.ShowDialog();
            this.Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
