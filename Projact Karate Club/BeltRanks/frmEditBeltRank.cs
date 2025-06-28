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

namespace KarateClubProjact
{
    public partial class frmEditBeltRank : Form
    {
        public frmEditBeltRank(int RankIID )
        {
            InitializeComponent();
            _RankID = RankIID;
        }
        int _RankID = -1;
        clsBeltRanks _BeltRanks;
 
        private void btClsoe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditBeltRank_Load(object sender, EventArgs e)
        {
            _BeltRanks = clsBeltRanks.Find((clsBeltRanks.enBeltRank)_RankID);
           lbRankID.Text = _RankID.ToString();

            if(_BeltRanks != null )
            {
                txtRankName.Text = _BeltRanks.RankName;
                txtFees.Text = _BeltRanks.TestFees.ToString();
                txtRankName.Focus();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Same vailed is not validat,put moues over red icon(s) to see Error", "Not Validat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;             
            }
            _BeltRanks.TestFees =int.Parse(txtFees.Text.Trim());
            _BeltRanks.RankName = txtRankName.Text.Trim();

            if(_BeltRanks.Save())
            {
                MessageBox.Show("Data Save Successfully","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Not Data Save Successfully", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtRankName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtRankName.Text))
            {
            e.Cancel = true;
                errorProvider1.SetError(txtRankName, "this is invailed");
            }
            else
            {
                errorProvider1.SetError(txtRankName, null);
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "this is invailed");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }

            if(!clsVildation.ISNumber(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "this is invailed");
            }
            else
                errorProvider1.SetError(txtFees, null);
        }
    }
}
