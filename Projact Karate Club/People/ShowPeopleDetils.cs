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
    public partial class ShowPeopleDetils : Form
    {
        public ShowPeopleDetils(int PeopleID)
        {
            InitializeComponent();
            this.PeopleID = PeopleID;
        }
        int PeopleID = -1;


        private void ShowPeopleDetils_Load(object sender, EventArgs e)
        {

        }

        private void showPeopleInfo1_Load(object sender, EventArgs e)
        {
            showPeopleInfo1.LoadpersonData(PeopleID);
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
