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

namespace KarateClubProjact.Subscription_Periods
{
    public partial class frmListSubscriptionPeriods : Form
    {
        public frmListSubscriptionPeriods()
        {
            InitializeComponent();
        }

        DataTable dtAllSubscriptionPeriods;

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListSubscriptionPeriods_Load(object sender, EventArgs e)
        {
            dtAllSubscriptionPeriods = clsSubscriptionPeriods.GetAllSubscriptionPeriods();
            dvSubscriptionPeriods.DataSource = dtAllSubscriptionPeriods;

            lbRecordes.Text = dvSubscriptionPeriods.RowCount.ToString();

            if(dvSubscriptionPeriods.Rows.Count > 0 )
            {
                dvSubscriptionPeriods.Columns[0].HeaderText = "Period ID";
                dvSubscriptionPeriods.Columns[0].Width = 120;


                dvSubscriptionPeriods.Columns[1].HeaderText = "Member Name";
                dvSubscriptionPeriods.Columns[1].Width = 220;


                dvSubscriptionPeriods.Columns[2].HeaderText = "Fees";
                dvSubscriptionPeriods.Columns[2].Width = 120;


                dvSubscriptionPeriods.Columns[3].HeaderText = "Is Paid";
                dvSubscriptionPeriods.Columns[3].Width = 120;


                dvSubscriptionPeriods.Columns[4].HeaderText = "Start Date";
                dvSubscriptionPeriods.Columns[4].Width = 140;


                dvSubscriptionPeriods.Columns[5].HeaderText = "End Date";
                dvSubscriptionPeriods.Columns[5].Width = 140;


            }
        }

        private void cmFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmFindBy.Text == "is Paid")
            {
                txtFilterValue.Visible = false;
                cmIsPaid.Visible = true;
                cmIsPaid.SelectedIndex = 0;
                cmIsPaid.Focus();
            }
            else
            {
                txtFilterValue.Visible = cmFindBy.Text != "None";

                if (cmFindBy.Text == "None")
                {
                    txtFilterValue.Visible = false;
                    return;
                }
                else
                    txtFilterValue.Enabled = true;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string CloumnsFilter = "";

            switch(cmFindBy.Text)
            {
                case "Period ID":
                    {
                        CloumnsFilter = "PeriodID";
                        break;
                    }
                case "Member name":
                    {
                        CloumnsFilter = "FullName";
                        break;
                    }
                default:
                    CloumnsFilter = "None";
                    break;
            }

            if(txtFilterValue.Text == "" || CloumnsFilter == "None")
            {
                dtAllSubscriptionPeriods.DefaultView.RowFilter = "";
                lbRecordes.Text = dvSubscriptionPeriods.RowCount.ToString();
                return;
            }

            if (CloumnsFilter == "PeriodID")
                dtAllSubscriptionPeriods.DefaultView.RowFilter = string.Format("[{0}] = {1}", CloumnsFilter, txtFilterValue.Text.Trim());
            else
                dtAllSubscriptionPeriods.DefaultView.RowFilter = string.Format("[{0}]  Like '{1}%'", CloumnsFilter, txtFilterValue.Text.Trim());

            lbRecordes.Text = dvSubscriptionPeriods.RowCount.ToString();
        }

        private void cmIsPaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ColuumnsValue = "";
            string ColumnFilter = "isPaid";

            switch(cmIsPaid.Text)
            {
                case "All":
                    ColuumnsValue = "All";
                    break;
                case "Yes":
                    ColuumnsValue = "1";
                    break;
                case "No":
                    ColuumnsValue = "0";
                    break;
            }

            if (ColuumnsValue == "All")
            {
                dtAllSubscriptionPeriods.DefaultView.RowFilter = "";
            }
            else
                dtAllSubscriptionPeriods.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnFilter, ColuumnsValue);

            lbRecordes.Text = dvSubscriptionPeriods.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmFindBy.Text == "Period ID")
            e.Handled = !char.IsDigit (e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscriptionPeriods frm = new frmAddUpdateSubscriptionPeriods();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            frmListSubscriptionPeriods_Load(null,null);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscriptionPeriods frm = new frmAddUpdateSubscriptionPeriods();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            frmListSubscriptionPeriods_Load(null, null);
           
        }

   

        private void cmPeriods_Opening(object sender, CancelEventArgs e)
        {
            int PeriodId = (int)dvSubscriptionPeriods.CurrentRow.Cells[0].Value;
            tsmBaySubscriptionPeriod.Enabled = !clsSubscriptionPeriods.IsMemberPaaid(PeriodId);
        }

        private void tsmBaySubscriptionPeriod_Click(object sender, EventArgs e)
        {

            int PeriodId = (int)dvSubscriptionPeriods.CurrentRow.Cells[0].Value;

            frmAddUpdateSubscriptionPeriods frm = new frmAddUpdateSubscriptionPeriods(PeriodId);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            frmListSubscriptionPeriods_Load(null, null);
        }

        private void tsmDeleteSubscriptionPeriod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to delete this Subscription Period?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int PeriodId = (int)dvSubscriptionPeriods.CurrentRow.Cells[0].Value;


            if (!clsSubscriptionPeriods.DeleteSubscriptionPeriod(PeriodId))
            {
                MessageBox.Show("Subscription Period is not delete succfully", "Error: Not deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Subscription Period delete succfully", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmListSubscriptionPeriods_Load(null, null);
        }

        private void tsmEditSubscriptionPeriod_Click(object sender, EventArgs e)
        {
            int PeriodId = (int)dvSubscriptionPeriods.CurrentRow.Cells[0].Value;

            frmAddUpdateSubscriptionPeriods frm = new frmAddUpdateSubscriptionPeriods(PeriodId);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            frmListSubscriptionPeriods_Load(null, null);
        }

        private void dvSubscriptionPeriods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsmShowPerioedHistory_Click(object sender, EventArgs e)

        {
            int PeriodId = (int)dvSubscriptionPeriods.CurrentRow.Cells[0].Value;
           int PersonID = clsSubscriptionPeriods.Find(PeriodId).MemberInfo.PersonID;
            frmShowTrainedMemberbyInstructor frm = new frmShowTrainedMemberbyInstructor(PersonID);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
    
    
}
