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
    public partial class frmLastBeltRank : Form
    {
        public frmLastBeltRank()
        {
            InitializeComponent();
        }

        clsBeltRanks BeltRanks;
        DataTable dtBeltRanks;
     
        private void editRankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RankID = (int)dvBeltRank.CurrentRow.Cells[0].Value;
            this.Hide();
            frmEditBeltRank frm = new frmEditBeltRank(RankID);
                frm.ShowDialog();
            this.Show();
            frmLastBeltRank_Load_1(null, null);
        }

        private void frmLastBeltRank_Load_1(object sender, EventArgs e)
        {

            dtBeltRanks = clsBeltRanks.GetAllRank();
            dvBeltRank.DataSource = dtBeltRanks;

            lbRecorde.Text = dvBeltRank.RowCount.ToString();
            if (dvBeltRank.Rows.Count > 0)
            {
                dvBeltRank.Columns[0].HeaderText = "Rank ID";
                dvBeltRank.Columns[0].Width = 100;

                dvBeltRank.Columns[1].HeaderText = "Rank Name";
                dvBeltRank.Columns[1].Width = 150;

                dvBeltRank.Columns[2].HeaderText = "Tset Fees";
                dvBeltRank.Columns[2].Width = 100;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
