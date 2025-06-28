using clsBussinsKarateClubProjacjat;
using KarateClubProjact.Belt_Test;
using KarateClubProjact.Payments;
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
    public partial class frmLastMember : Form
    {
        public frmLastMember()
        {
            InitializeComponent();
        }

   private   static   DataTable _dtMember = new DataTable();
        string ColumnsFilter = "";
        private void frmLastMember_Load(object sender, EventArgs e)
        {
            _dtMember = clsMembers.GetAllMembers();

            dvMembers.DataSource = _dtMember;
            lbRecord.Text = dvMembers.RowCount.ToString();
            cmFilter.SelectedIndex = 0;

            if(dvMembers.Rows.Count > 0 )
            {
                dvMembers.Columns[0].HeaderText = "Membber ID";
                dvMembers.Columns[0].Width = 100;

                dvMembers.Columns[1].HeaderText = "Person ID";
                dvMembers.Columns[1].Width = 100;

                dvMembers.Columns[2].HeaderText = "Naame";
                dvMembers.Columns[2].Width = 250;

                dvMembers.Columns[3].HeaderText = "IS ACtive";
                dvMembers.Columns[3].Width = 100;

                dvMembers.Columns[4].HeaderText = "Gender";
                dvMembers.Columns[4].Width = 100;

                dvMembers.Columns[5].HeaderText = "Rank Name";
                dvMembers.Columns[5].Width = 180;

                dvMembers.Columns[6].HeaderText = "Emergency Contact Info";
                dvMembers.Columns[6].Width = 180;

            }
        }


        void _RefrshDeflutvaluse()
        {
            _dtMember = clsMembers.GetAllMembers();

            dvMembers.DataSource = _dtMember;
            lbRecord.Text = dvMembers.RowCount.ToString();
        }

        void _FilterGernderAndISActive()
        {
            switch (cmFilter.Text)
            {
                case "All":
                    {
                        _dtMember.DefaultView.RowFilter = "";
                        _RefrshDeflutvaluse();
                        break;
                    }
                case "Yes":
                    {
                        ColumnsFilter = "1";
                        break;
                    }
                default:

                    ColumnsFilter = "0";
                    break;

            }
        }


        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmFilter.Text =="None" )
            {
                txtFilter.Visible = false;
                cmISActive.Visible = false;
                cmGendere.Visible = false;
                return;
            }

            if(cmFilter.Text == "Gender")
            {
                cmGendere.SelectedIndex = 0;
                cmGendere.Visible = true;
                txtFilter.Visible = false;
                cmISActive.Visible = false;
                return;
            }
            if (cmFilter.Text == "IS Active")
            {
                cmISActive.SelectedIndex = 0;
                cmGendere.Visible = false;
                txtFilter.Visible = false;
                cmISActive.Visible = true;
                return;
            }
            
                cmISActive.Visible = false;
                cmGendere.Visible = false;
                txtFilter.Visible = cmFilter.Text != "None";
                txtFilter.Text = "";
           

        }



        private void cmGendere_SelectedIndexChanged(object sender, EventArgs e)
        {
              _FilterGernderAndISActive();
            _dtMember.DefaultView.RowFilter = string.Format("[{0}] = {1}", "Gander", ColumnsFilter);
            lbRecord.Text = dvMembers.RowCount.ToString();
        }

        private void cmISActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterGernderAndISActive();
            _dtMember.DefaultView.RowFilter = string.Format("[{0}] = {1}", "IsActive", ColumnsFilter);
            lbRecord.Text = dvMembers.RowCount.ToString();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string ColumnsFilter = "";
            switch(cmFilter.Text)
            {
                case "Person ID":
                    ColumnsFilter = "PersonID";
                    break;
                case "Member ID":
                    ColumnsFilter = "MembersID";
                    break;
                case "Full Name":
                    ColumnsFilter = "fullname";
                    break;
                case "None":
                    ColumnsFilter = "None";
                    break;
                default:
                    ColumnsFilter = "";
                    break;
            }

            if(txtFilter.Text == "" || ColumnsFilter =="None")
            {
                txtFilter.Visible = false;
                _dtMember.DefaultView.RowFilter = "";
                txtFilter.Text = "";
                //_RefrshDeflutvaluse();
                return;
            }
            if(ColumnsFilter == "fullname")
            {
                _dtMember.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", ColumnsFilter, txtFilter.Text);
                lbRecord.Text = dvMembers.RowCount.ToString();
            }
            else
            _dtMember.DefaultView.RowFilter = string.Format("[{0}] = {1}",ColumnsFilter,txtFilter.Text);
            lbRecord.Text = dvMembers.RowCount.ToString();
        }

        private void meToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID =(int) dvMembers.CurrentRow.Cells[0].Value;
            this.Hide();
            frmAddUpdatMembers frm = new frmAddUpdatMembers(MemberID);
            frm.ShowDialog();
            this.Show();
            frmLastMember_Load(null, null);
        }

        private void showMemberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID =(int)dvMembers.CurrentRow.Cells[0].Value;
            frmMemberDetiles frm = new frmMemberDetiles(MemberID);
            this.Hide();
            frm.ShowDialog();
                this.Show();

        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID = (int)dvMembers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want delete Member "+ MemberID,"Confrim",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                if(clsMembers.DetelteMember(MemberID))
                {
                    MessageBox.Show("Member delete successfully","Delete Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(" Not Member delete Member "  + MemberID, " Not Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            frmLastMember_Load(null,null);
        }

        private void btAddNewMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUpdatMembers frm = new frmAddUpdatMembers();
            frm.ShowDialog();
            this.Show();
            frmLastMember_Load(null, null);
           
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUpdatMembers frm = new frmAddUpdatMembers();
            frm.ShowDialog();
            this.Show();
            frmLastMember_Load(null, null);
        }

        private void testHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID = (int)dvMembers.CurrentRow.Cells[0].Value;
            frmShowTestHistory frm = new frmShowTestHistory(MemberID);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID = (int)dvMembers.CurrentRow.Cells[0].Value;
            frmPaymentHistory frm = new frmPaymentHistory(MemberID);
                    this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void csMember_Opening(object sender, CancelEventArgs e)
        {
            int MemberID = (int)dvMembers.CurrentRow.Cells[0].Value;
            paymentToolStripMenuItem.Enabled = clsPayments.IsMemberBayAnyFees(MemberID);

            testHistoryToolStripMenuItem.Enabled = clsBeltTests.IsMemberTakeAnyTest(MemberID);
        }
    }
}
