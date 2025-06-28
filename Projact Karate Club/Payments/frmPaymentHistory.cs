using clsBussinsKarateClubProjacjat;
using KarateClubProjact.Members;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClubProjact.Payments
{
    public partial class frmPaymentHistory : Form
    {
        public frmPaymentHistory(int MemberID)
        {
            InitializeComponent();
            _MemberID = MemberID;
        }
        int _MemberID = -1;

        DataTable dtAllPayments;

        void LoadHistoryinfo()
        {

            dtAllPayments = clsPayments.GetAllPaymentsbyMemberD(_MemberID);
            dvPaymentHistory.DataSource = dtAllPayments;
            lbRecordes.Text = dvPaymentHistory.RowCount.ToString();

            if (dvPaymentHistory.RowCount > 0)
            {
                dvPaymentHistory.Columns[0].HeaderText = "Payment ID";
                dvPaymentHistory.Columns[0].Width = 120;

                dvPaymentHistory.Columns[1].HeaderText = "Full Name";
                dvPaymentHistory.Columns[1].Width = 250;

                dvPaymentHistory.Columns[2].HeaderText = "Amount";
                dvPaymentHistory.Columns[2].Width = 140;

                dvPaymentHistory.Columns[3].HeaderText = "Payment Date";
                dvPaymentHistory.Columns[3].Width = 160;

                dvPaymentHistory.Columns[4].HeaderText = "Lastmodi Date fied";
                dvPaymentHistory.Columns[4].Width = 160;

            }
        }
        private void frmPaymentHistory_Load(object sender, EventArgs e)
        {
            ctrlFindMemberInfo1.LoadMemberInfo(_MemberID);
            LoadHistoryinfo();
            float TestFees = clsPayments.CountMemberBayInTest(_MemberID);
            float PeriodsFees = clsPayments.CountMemberBayInSubscriptionPeriods(_MemberID);

            lbTestFees.Text = TestFees.ToString();
            lbSubscriptionPeriodsFees.Text = PeriodsFees.ToString();
            lbTotalPayments.Text = (PeriodsFees + TestFees).ToString();


        }

        private void ctrlFindMemberInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
