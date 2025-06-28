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
    public partial class frmAddUpdateInstructors : Form
    {

        public delegate void EventBact(int instructorsID);
        public event EventBact BackinstructorsID;

        public frmAddUpdateInstructors(int InstructorsID)
        {
            InitializeComponent();
            _InstructorsID = InstructorsID;
             Mode = _Mode.Update;
        }

        public frmAddUpdateInstructors()
        {
            InitializeComponent();
             Mode = _Mode.Addnew;
        }

        enum _Mode { Addnew =0, Update = 1 }
        _Mode Mode = _Mode.Addnew;

        int _InstructorsID = -1;
        clsInstructors _Instructors = new clsInstructors();

        void _RefreshDeflutValues()
        {
            _Instructors = new clsInstructors();
            if (_InstructorsID == -1)
            {
                lbTitle.Text = "Add New Instructors";
                this.Text = lbTitle.Text;
                lbInstructorsID.Text = "[???]";
                txtQualification.Text = " ";
            }
            else
            {
                lbTitle.Text = "Update Instructors";
                this.Text = lbTitle.Text;
            }
        }

        void LoadInstructorsInfo()
        {
            _Instructors = clsInstructors.FindByID(_InstructorsID);

            if(_Instructors != null)
            {
                lbInstructorsID.Text = _Instructors.InstructorsID.ToString();
                txtQualification.Text = _Instructors.Qualification;
                ctrlPersonCardWithFilter1.LoadPersonInfo(_Instructors.PersonID);
                ctrlPersonCardWithFilter1.EnableFilter =false;
            }
        }
        private void frmAddUpdateInstructors_Load(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.TxtFoucsinText();
            _RefreshDeflutValues();

            if (Mode == _Mode.Update)
                LoadInstructorsInfo();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Same validat is not validated,put mouse over in icon(s) to see erroe", "Not Validat",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _Instructors.InstructorsID = _InstructorsID;
            _Instructors.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Instructors.Qualification = txtQualification.Text.Trim();

            if(_Instructors.Save())
            {
                MessageBox.Show("Data Save Successfully","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lbInstructorsID.Text = _Instructors.InstructorsID.ToString();
                lbTitle.Text = "Update Instructor";
                this.Text = lbTitle.Text;
                _InstructorsID = _Instructors.InstructorsID;
                BackinstructorsID.Invoke(_InstructorsID);
            }
            else
            {
                MessageBox.Show("Not Save  Successfully", "Error Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQualification_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtQualification.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQualification, "this is vailed");
            }
            else
            {
                errorProvider1.SetError(txtQualification, null);
            }
        }

        private void ctrlPersonCardWithFilter1_BackPersonID(int PersonID)
        {
            if (Mode == _Mode.Addnew)
            {
                if (clsInstructors.ISInteructorExistByPersonID(PersonID))
                {
                    MessageBox.Show("Select Person already Instructors,chooes anather Person", "Person already Instructors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btSave.Enabled = false;
                    return;
                }
                else
                {
                    clsMembers members = clsMembers.FindByPersonID(PersonID);

                    if (members != null)
                    {
                        if (!clsMembers.IsPersonHasBeltBlack(PersonID))
                        {
                            return;
                        }
                    }
                    
                        btSave.Enabled = true;
                  
                }
            }
            btSave.Enabled = true;
        }
    }
}
