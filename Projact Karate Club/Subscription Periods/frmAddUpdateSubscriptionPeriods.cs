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

namespace KarateClubProjact.Subscription_Periods
{
    public partial class frmAddUpdateSubscriptionPeriods : Form
    {
        public frmAddUpdateSubscriptionPeriods()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddUpdateSubscriptionPeriods(int PeriodID)
        {
            InitializeComponent();
            _PeriodID = PeriodID;
            Mode = enMode.Update;
        }

        enum enMode { AddNew =0,Update =1}
        enMode Mode = enMode.AddNew;

        int _PeriodID = -1;
        int _MemberId = -1;

        clsSubscriptionPeriods _SubscriptionPeriods;

        void _RefreshData()
        {
            if(Mode == enMode.AddNew)
            {
                _SubscriptionPeriods = new clsSubscriptionPeriods();

                lbTitel.Text = "Add New Subscription Periods";

                this.Text = lbTitel.Text;
              btSave .Enabled = false;
              tpPeriodInfo.Enabled = false;

                dtpStartDate.MinDate = DateTime.Now;
                dtpStartDate.Value = DateTime.Now;

                dtpEnddDate.MinDate = DateTime.Now.AddMonths(1);
                dtpEnddDate.Value = DateTime.Now.AddMonths(1);
            }
            else
            {
                lbTitel.Text = "Update Subscription Periods";
                this.Text = lbTitel.Text;
                btSave.Enabled = true;
                tpPeriodInfo.Enabled = true;
                txtFees.Enabled = false;
                dtpEnddDate.Enabled = false;
                dtpStartDate.Enabled = false;
                txtFees.Focus();
            }
        }

        void Loaddata()
        {
            _SubscriptionPeriods =  clsSubscriptionPeriods.Find(_PeriodID);
            if(_SubscriptionPeriods == null )
            {
                MessageBox.Show("Error Not foun Subscription Period with id = " + _PeriodID ,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(DateTime.Compare(DateTime.Now,_SubscriptionPeriods.StartDate) < 0)
               dtpStartDate.MinDate = DateTime.Now;
            else
                dtpStartDate.MinDate = _SubscriptionPeriods.StartDate;

            if (DateTime.Compare(DateTime.Now, _SubscriptionPeriods.EndDate) > 0)
            {

                dtpEnddDate.Enabled = false;
            }
            dtpEnddDate.MinDate = _SubscriptionPeriods.EndDate;

            dtpStartDate.Value = _SubscriptionPeriods.StartDate;

            lbPaymentID.Text = _SubscriptionPeriods.PaymentID.ToString();
            lbMembrId.Text = _SubscriptionPeriods.MemberID.ToString();
            lbPeriodID.Text = _SubscriptionPeriods.PeriodID.ToString();
            cbIspaid.Checked = _SubscriptionPeriods.isPaid;
            txtFees.Text = _SubscriptionPeriods.Fees.ToString();
            ctrlMemberinfoWithFilter1.LoadMemberInfo(_SubscriptionPeriods.MemberID);

        }
        private void frmAddUpdateSubscriptionPeriods_Load(object sender, EventArgs e)
        {
            _RefreshData();
            if(Mode == enMode.Update)
            {
                Loaddata();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if(!this.ValidateChildren())
            {
                MessageBox.Show("Same valied is not validat, put moucs over red Icon(s) to see Error","not invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _SubscriptionPeriods.PeriodID = _PeriodID;
            _SubscriptionPeriods.MemberID = ctrlMemberinfoWithFilter1.SelectMemberInfo.MembersID;
            _SubscriptionPeriods.Fees = Convert.ToInt32(txtFees.Text);
            _SubscriptionPeriods.isPaid = cbIspaid.Checked ? true : false;
            _SubscriptionPeriods.StartDate = dtpStartDate.Value;
            _SubscriptionPeriods.EndDate = dtpEnddDate.Value;
            
            if(!_SubscriptionPeriods.Save())
            {
              MessageBox.Show("Error datat not save successfully","Error : Not Save",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lbTitel.Text = "Update Subscription Period";
            this.Text = lbTitel.Text;
            lbPaymentID.Text = _SubscriptionPeriods.PaymentID.ToString();
            lbPeriodID.Text = _SubscriptionPeriods.PeriodID.ToString();

            MessageBox.Show("Data save successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Enter fees for this Subscription");
            }
            else
                errorProvider1.SetError(txtFees,null);

            if(!clsVildation.ISNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Enter number fees for this Subscription");
            }
            errorProvider1.SetError(txtFees, null);
        }

        private void ctrlMemberinfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void byPeriodIinfo_Click(object sender, EventArgs e)
        {
            tbSubscription.SelectedTab = tbSubscription.TabPages["tpPeriodInfo"];
            lbMembrId.Text = _MemberId.ToString();
            btSave.Enabled = true;
            tpPeriodInfo.Enabled = true;
        }

        private void ctrlMemberinfoWithFilter1_OnMemberSelect(int obj)
        {
            _MemberId = obj; 
            btSave.Enabled = true;
        }

        private void frmAddUpdateSubscriptionPeriods_Activated(object sender, EventArgs e)
        {
            ctrlMemberinfoWithFilter1.TextValuseFocus();
        }
    }
}
