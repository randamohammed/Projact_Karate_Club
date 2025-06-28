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
    public partial class frmMemberDetiles : Form
    {
        public frmMemberDetiles(int MemberID)
        {
            InitializeComponent();
            _MemberID = MemberID;
        }
        int _MemberID;
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberDetiles_Load(object sender, EventArgs e)
        {
            ctrlShowMemberInfo1.LoadMemberInfo(_MemberID);
        }

        private void ctrlShowMemberInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
