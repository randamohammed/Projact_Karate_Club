using clsBussinsKarateClubProjacjat;
using KarateClubProjact.Instructors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClubProjact.MemberInstructor
{
    public partial class frmAddUpdateMemberInstructor : Form
    {
        public frmAddUpdateMemberInstructor()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddUpdateMemberInstructor(int MemberInstructorID)
        {
            InitializeComponent();
            _MemberInstructorID  = MemberInstructorID;
            Mode = enMode.Update;
        }
        clsMemberInstructors _MemberInstructors;

        enum enMode { AddNew =0,Update = 1 };
        enMode Mode = enMode.AddNew;

        int _MemberInstructorID = 0;
        int _MemberID = -1;
        int _InstructorID = -1;

        void LoadData()
        {
            _MemberInstructors = clsMemberInstructors.Find(_MemberInstructorID);

            if (_MemberInstructors != null)
            {
                _MemberID = _MemberInstructors.MemberID;
                _InstructorID = _MemberInstructors.InstructorID;
                lbMemberinstructorID.Text = _MemberInstructors.MemberInstructorID.ToString();

                if(DateTime.Compare(DateTime.Now, _MemberInstructors.AssignDate) <0)
                    dtpAsseingDate.MinDate = DateTime.Now;
                else
                    dtpAsseingDate.MinDate = _MemberInstructors.AssignDate;


                if (DateTime.Compare(DateTime.Now, _MemberInstructors.TrainedEndDate) < 0)
                    dtpAsseingDate.MinDate = DateTime.Now;
                else
                    dtpTrainedDate.MinDate = _MemberInstructors.TrainedEndDate;

                dtpAsseingDate.Value = _MemberInstructors.AssignDate;
                dtpAsseingDate.Enabled = false;
                dtpTrainedDate.Value = _MemberInstructors.TrainedEndDate;


                ctrlMemberinfoWithFilter1.LoadMemberInfo(_MemberID);
                ctrlShowInstructorscardWithFilter1.LoadInstructorsinfo(_InstructorID);
            }
        }

        void Refreshdate()
        {
            _MemberInstructors = new clsMemberInstructors();
            dtpAsseingDate.Value = DateTime.Now;
            dtpTrainedDate.Value = DateTime.Now.AddMonths(1);
           // dtpTrainedDate.MinDate = dtpAsseingDate.Value;
           lbtitel.Text = "Add New Member_Instructor";
            tpTestInfo.Enabled = false;
            tpMemberiinstructInfo.SelectedTab = tpMemberiinstructInfo.TabPages["tpMemberinfo"];
            ctrlMemberinfoWithFilter1.TextValuseFocus();
            btSave.Enabled= false;
        }
        private void ctrlMemberinfoWithFilter1_OnMemberSelect(int obj)
        {

            _MemberID = obj;

           

            if(_MemberID == -1)
            {
                return;
            }
            
            if(Mode == enMode.AddNew) 
            {

                if (_InstructorID != -1 && _MemberID != -1)
                {
                    if (!clsMemberInstructors.ISInstructorMemberExsit(_InstructorID, _MemberID))
                    {
                        btSave.Enabled = true;
                        tpTestInfo.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("already Member has Instructor her Instructor with id = " + _InstructorID.ToString(), "not allwon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btSave.Enabled = false;
                        tpTestInfo.Enabled = false;
                    }
                }
                return;
            }
            btSave.Enabled = true;
            tpTestInfo.Enabled = true;


        }

        private void ctrlShowInstructorscardWithFilter1_OninstructorsSelect(int obj)
        {
             _InstructorID = obj;
            llShowTrainedMemberbyInstructor.Enabled = (_InstructorID != -1);


            if (Mode == enMode.AddNew)
            {

                    if (_InstructorID != -1 && _MemberID != -1)
                    {
                        if (!clsMemberInstructors.ISInstructorMemberExsit(_InstructorID, _MemberID))
                        {
                            btSave.Enabled = true;
                            tpTestInfo.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("already Member has Instructor her Instructor with id = " + _InstructorID.ToString(), "not allwon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btSave.Enabled = false;
                            tpTestInfo.Enabled = false;
                        }
                    }
                return;
            }
            btSave.Enabled = true;
            tpTestInfo.Enabled = true;
        }

        private void frmAddUpdateMemberInstructor_Load(object sender, EventArgs e)
        {
            Refreshdate();

            if (Mode == enMode.Update)
            LoadData();
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            _MemberInstructors.InstructorID = _InstructorID;
            _MemberInstructors.MemberID = _MemberID;
            _MemberInstructors.AssignDate = dtpAsseingDate.Value;
            _MemberInstructors.TrainedEndDate = dtpTrainedDate.Value;

            if(!_MemberInstructors.Save())
            {
                MessageBox.Show("Data Member_Instructors is not successfully", "Error : not Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbtitel.Text = "Update Member_Instructor";
            lbMemberinstructorID.Text = _MemberInstructors.MemberInstructorID.ToString();
            MessageBox.Show("Data Member_Instructors successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btSave.Enabled = false;
            ctrlMemberinfoWithFilter1.EnableFilter = false;
            ctrlShowInstructorscardWithFilter1.FilterEnable =false;
            dtpAsseingDate.Enabled = false;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        private void tpTestInfo_Click(object sender, EventArgs e)
        {
            if (_InstructorID != -1 && _MemberID != -1)
            {
                if (!clsMemberInstructors.ISInstructorMemberExsit(_InstructorID, _MemberID))
                {
                    tpTestInfo.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void llShowTrainedMemberbyInstructor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsInstructors.FindByID(_InstructorID).PersonID;
            this.Hide();
            frmShowTrainedMemberbyInstructor frm = new frmShowTrainedMemberbyInstructor(PersonID);
            frm.ShowDialog();
            this.Show();
        }
    }
}
