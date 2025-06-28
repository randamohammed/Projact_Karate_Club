using clsBussinsKarateClubProjacjat;
using KarateClubProjact.Belt_Test;
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
    public partial class frmListBeltTests : Form
    {
        public frmListBeltTests()
        {
            InitializeComponent();
        }

        DataTable dtAllBeltTest;
        private void frmListBeltTests_Load(object sender, EventArgs e)
        {
            cmFindBy.SelectedIndex = 0;

            dtAllBeltTest =   clsBeltTests.GetAllBeltTests();
            dvBeltTest.DataSource = dtAllBeltTest;
            lbRecord.Text = dvBeltTest.RowCount.ToString();

            if(dvBeltTest.Rows.Count > 0 )
            {
                dvBeltTest.Columns[0].HeaderText = "Test ID";
                dvBeltTest.Columns[0].Width = 100;

                dvBeltTest.Columns[1].HeaderText = "Member Name";
                dvBeltTest.Columns[1].Width = 220;

                dvBeltTest.Columns[2].HeaderText = "Instructor Name";
                dvBeltTest.Columns[2].Width = 220;

                dvBeltTest.Columns[3].HeaderText = "Fees";
                dvBeltTest.Columns[3].Width = 100;

                dvBeltTest.Columns[4].HeaderText = "RankName";
                dvBeltTest.Columns[4].Width = 150;

                dvBeltTest.Columns[5].HeaderText = "Result";
                dvBeltTest.Columns[5].Width = 100;

                dvBeltTest.Columns[6].HeaderText = "Date";
                dvBeltTest.Columns[6].Width = 140;

            }

        }
        void _FullBeltRank()
        {
            DataTable dtAllRank = clsBeltRanks.GetAllRank();

            foreach(DataRow rank in dtAllRank.Rows)
            {
                cmBeltRank.Items.Add(rank["RankName"]);
            }
        }
        private void cmFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmFindBy.Text)
            {
                case "Rank Name":
                    {
                        _FullBeltRank();
                        cmBeltRank.Visible = true;
                        cmBeltRank.SelectedIndex = 0;
                        cmReslut.Visible = false;
                        txtFiltervalues.Visible = false;
                       
                        return;
                    }
                case "Result":
                    {
                        cmReslut.Visible = true;
                        cmReslut.SelectedIndex = 0;
                        cmBeltRank.Visible = false;
                        txtFiltervalues.Visible = false;
                        break;
                    }
                case "Member Name":
                    {
                        cmReslut.Visible = false;
                        cmBeltRank.Visible = false;
                        txtFiltervalues.Visible = true;
                        txtFiltervalues.Focus();
                        break;
                    }
                case "Instructor Name":
                    {
                        cmReslut.Visible = false;
                        cmBeltRank.Visible = false;
                        txtFiltervalues.Visible = true;
                        txtFiltervalues.Focus();
                        break;
                    }
                    default:
                    {
                        cmBeltRank.Visible = false;
                        cmReslut.Visible = false;
                        txtFiltervalues.Visible = false;
                        break;
                    }

            }
        }

        private void txtFiltervalues_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

           switch(cmFindBy.Text )
            {
                case "Member Name":
                    FilterColumn = "MemberName";
                    break;
                case "Instructor Name":
                    FilterColumn = "InstructorName";
                    break; ;
                default:
                    FilterColumn = "None";
                    break;
            }

            if(txtFiltervalues.Text == "" || FilterColumn == "None")
            {
                dtAllBeltTest.DefaultView.RowFilter = "";
                lbRecord.Text = dvBeltTest.RowCount.ToString();
                return;
            }

            dtAllBeltTest.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'",FilterColumn,txtFiltervalues.Text.Trim());
            lbRecord.Text = dvBeltTest.RowCount.ToString();
        }

        private void cmReslut_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterCloumn = "Result";
            string FilterValue = "";

            switch(cmReslut.Text)
            {
                case "All":
                    FilterValue = "All";
                    break;
                case "Passed":
                    FilterValue = "passed";
                    break;
                case "Failed":
                    FilterValue = "Failed";
                    break;
                    
            }

            if(FilterValue == "All")
            {
                dtAllBeltTest.DefaultView.RowFilter = "";
                lbRecord.Text = dvBeltTest.RowCount.ToString();
                return;
            }

            dtAllBeltTest.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterCloumn, FilterValue);
            lbRecord.Text = dvBeltTest.RowCount.ToString();
        }

        private void cmBeltRank_SelectedIndexChanged(object sender, EventArgs e)


        { 
            string FilterCloumn = "RankName";
            string FilterValue = cmBeltRank.Text;

            cmBeltRank.SelectedIndex = 0;
            dtAllBeltTest.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterCloumn, FilterValue.Trim());
            lbRecord.Text = dvBeltTest.RowCount.ToString();
        }

        private void btTakeTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTakeTestfromNextBelt frm = new frmTakeTestfromNextBelt();
            frm.ShowDialog();
            this.Show();
            frmListBeltTests_Load(null, null);
        }
    }
}
