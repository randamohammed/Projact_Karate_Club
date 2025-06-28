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
    public partial class frmShowinstructorsInfo : Form
    {
        public frmShowinstructorsInfo(int instructorsID)
        {
            InitializeComponent();
            _instructorsID = instructorsID;
        }

        int _instructorsID = 0;
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowinstructorsInfo_Load(object sender, EventArgs e)
        {
            cltrShowInstructorsCard1.Loadinstructors(_instructorsID);
        }
    }
}
