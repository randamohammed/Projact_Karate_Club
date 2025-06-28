using clsBussinsKarateClubProjacjat;
using DVLDSluotion;
using KarateClubProjact.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClubProjact
{
    public partial class frmAddUpdatMembers : Form
    {
        public frmAddUpdatMembers()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public delegate void EventBact(int MemberID);
        public event EventBact BackMemberID;

        public frmAddUpdatMembers(int MemberID)
        {
            InitializeComponent();
             _MemberID = MemberID;
            Mode = enMode.Update;
        }

        int _MemberID = -1;
        int _PersonID = -1;
        enum enMode { AddNew =0 ,Update =1};
        enMode Mode;

        clsMembers _Member;
        void _FullRankBelt()
        {
            DataTable dtAlRankBelt = clsBeltRanks.GetAllRank();

            foreach(DataRow rankBelt in dtAlRankBelt.Rows)
            {
                cmLastBeltRank.Items.Add(rankBelt["RankName"]);
            }
        }

        bool _HandleImagePerson()
        {
            if (_Member.Certificate != pbCertificate.ImageLocation)
            {

                if (pbCertificate.ImageLocation != null)
                {
                    string SourceCertificateFile = pbCertificate.ImageLocation.ToString();

                    if (clsUtil.CopyCertificateinFloder(ref SourceCertificateFile))
                    {
                        pbCertificate.ImageLocation = SourceCertificateFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Certificate File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }


        void _LoadMemberinfo()
        {
            _Member = clsMembers.FindByID(_MemberID);
            _MemberID = _Member.MembersID;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Member.PersonID);
            lbLastBeltRank.Text = clsBeltRanks.Find((clsBeltRanks.enBeltRank)_Member.LastBeltRank).RankName;
            lbMemberID.Text = _Member.MembersID.ToString();
            txtEmergencyContactInfo.Text = _Member.EmergencyContactInfo;

        }


        void RefreshData()
        {
            if (Mode == enMode.AddNew)
            {
                _Member = new clsMembers();

                lbTitle.Text = "Add New Member";

                tbMemberinfo.SelectedTab = tbMemberinfo.TabPages["tpExperinceInfo"];
                rbbeginner.Checked = true;
                llRemoveCertificate.Visible = false;
                lbLastBeltRank.Text = "White Belt";
                lbLastBeltRank.Visible = true;
                cmLastBeltRank.Visible = false;
            }
            else
            {
                lbTitle.Text = "Update New Member";
                btSave.Enabled = true;
                rbhaveexperience.Checked = true;
                rbbeginner.Enabled = false;
                cmLastBeltRank.Visible = false;

            }
            tpMemberInfo.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClsoe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdatMembers_Load(object sender, EventArgs e)
        {
            RefreshData();
            if(Mode == enMode.Update)
            {
                _LoadMemberinfo();
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Same vailed is not validat, put meuces over red icon(s) to see error", "Not ivalied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandleImagePerson())
                return;

            _Member.MembersID = _MemberID;
            _Member.PersonID =_PersonID;
            _Member.EmergencyContactInfo = txtEmergencyContactInfo.Text;
            _Member.IsActive = cbISActive.Checked ? true : false;


            if(cmLastBeltRank.Visible)
            _Member.LastBeltRank =(int) clsBeltRanks.FindByName(cmLastBeltRank.Text).RankID;
            else
                _Member.LastBeltRank =(int) clsBeltRanks.FindByName(lbLastBeltRank.Text).RankID;

            if(pbCertificate.ImageLocation !=  null)
                _Member.Certificate = pbCertificate.ImageLocation;

            if(!_Member.Save())
            {
                 MessageBox.Show("Data is not Save successfully","Not Save",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbTitle.Text = "Update Member";
            this.Text = "Update Member";

            MessageBox.Show("Data Save successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Mode = enMode.Update;
            lbMemberID.Text = _Member.MembersID.ToString();

            if(cmLastBeltRank.Enabled == true)
                cmLastBeltRank.Enabled = false;

            if(BackMemberID != null)
            BackMemberID.Invoke(_Member.MembersID);
        }

        private void rbhaveexperience_CheckedChanged(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                _FullRankBelt();
                cmLastBeltRank.Visible = true;
                lbLastBeltRank.Visible = false;
            }
            else
            {
                pbCertificate.Enabled = true;
                llAddCertificate.Visible = true;
                lbLastBeltRank.Visible = true;
                llRemoveCertificate.Visible = pbCertificate.ImageLocation != null;
            }
        }

        private void rbbeginner_CheckedChanged(object sender, EventArgs e)
        {

            cmLastBeltRank.Visible = false;
            lbLastBeltRank.Visible = true;
            pbCertificate.Enabled = false;
            llAddCertificate.Visible = false;
        }

        private void ctrlPersonCardWithFilter1_BackPersonID(int PersonID)
        {
            _PersonID  = PersonID;
            if (Mode == enMode.AddNew)
            {
                if (clsMembers.ISMemberexistByPersonID(PersonID))
                {
                    MessageBox.Show("Member already found, With id = " + PersonID + "Chooes anther on", "not allwon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            btSave.Enabled = true;
        }

        private void txtEmergencyContactInfo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmergencyContactInfo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmergencyContactInfo, "this is invaliad");
            }
            else
            {
                errorProvider1.SetError(txtEmergencyContactInfo, null);
            }
        }

        private void llRemoveCertificate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbCertificate.ImageLocation = null;

            pbCertificate.Image = Resources.closeBlack32;
        }

        private void llAddCertificate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string PathCertificate = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PathCertificate = openFileDialog.FileName;
                pbCertificate.ImageLocation = PathCertificate;
                llRemoveCertificate.Visible = true;
            }
             
        }

        private void btClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void btNaxt_Click(object sender, EventArgs e)
        {
            tbMemberinfo.SelectedTab = tbMemberinfo.TabPages["tpMemberInfo"];
            tpMemberInfo.Enabled = true;
        }

        private void frmAddUpdatMembers_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.TxtFoucsinText();
        }
    }
}
