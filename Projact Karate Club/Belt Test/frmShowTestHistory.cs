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

namespace KarateClubProjact.Belt_Test
{
    public partial class frmShowTestHistory : Form
    {
        public frmShowTestHistory(int MemberID)
        {
            InitializeComponent();
            _Memberid = MemberID;
        }
        clsMembers _Member;
        int _Memberid = -1;
        DataTable dtAllMemberTest;
        private void frmShowTestHistory_Load(object sender, EventArgs e)
        {
            _Member = clsMembers.FindByID(_Memberid);

            if (_Member != null)
            {
                ctrlShowMemberInfo1.LoadMemberInfo(_Memberid);
                dtAllMemberTest = clsBeltTests.GetAllTestforBeltRank(_Memberid);
                dgMemberTestHistoy.DataSource = dtAllMemberTest;
                lbRecorde.Text = dgMemberTestHistoy.RowCount.ToString();

                if(dgMemberTestHistoy.RowCount > 0)
                {  
                        dgMemberTestHistoy.Columns[0].HeaderText = "Test ID";
                        dgMemberTestHistoy.Columns[0].Width = 100;
                      
                        dgMemberTestHistoy.Columns[1].HeaderText = "Member Name";
                        dgMemberTestHistoy.Columns[1].Width = 220;
                        
                        dgMemberTestHistoy.Columns[2].HeaderText = "RankName";
                        dgMemberTestHistoy.Columns[2].Width = 150;
                       
                        dgMemberTestHistoy.Columns[3].HeaderText = "Fees";
                        dgMemberTestHistoy.Columns[3].Width = 100;
    

                        dgMemberTestHistoy.Columns[4].HeaderText = "Instructor Name";
                        dgMemberTestHistoy.Columns[4].Width = 150;

                        dgMemberTestHistoy.Columns[5].HeaderText = "Result";
                        dgMemberTestHistoy.Columns[5].Width = 100;

                        dgMemberTestHistoy.Columns[6].HeaderText = "Date";
                         dgMemberTestHistoy.Columns[6].Width = 140;
       
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgMemberTestHistoy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
