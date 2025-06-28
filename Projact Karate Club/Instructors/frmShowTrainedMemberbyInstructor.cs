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
using System.Xml;

namespace KarateClubProjact.Instructors
{
    public partial class frmShowTrainedMemberbyInstructor : Form
    {
        public frmShowTrainedMemberbyInstructor(int personID)
        {
            InitializeComponent();
            _personID = personID;
        }
        int _personID;
        int InstructorsID =-1;
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable dtAllInstructorMember;
        private void frmShowTrainedMemberbyInstructor_Load(object sender, EventArgs e)
        {
            cltrShowInstructorsCard1.LoadinstructorByPersonID(_personID);
            InstructorsID = cltrShowInstructorsCard1.SelectInstructorInfo.InstructorsID;
            if (InstructorsID !=  -1)
            {
                dtAllInstructorMember = clsMemberInstructors.GetAllMemberInstructorByInstructorID(InstructorsID);
                dglMemberInstructor.DataSource = dtAllInstructorMember;
                lbRecordes.Text = dglMemberInstructor.RowCount.ToString();

                if (dglMemberInstructor.RowCount > 0)
                {
                    dglMemberInstructor.Columns[0].HeaderText = "Instructors ID";
                    dglMemberInstructor.Columns[0].Width = 120;

                    dglMemberInstructor.Columns[1].HeaderText = "Member ID";
                    dglMemberInstructor.Columns[1].Width = 120;

                    dglMemberInstructor.Columns[2].HeaderText = "Member Name";
                    dglMemberInstructor.Columns[2].Width = 250;

                    dglMemberInstructor.Columns[3].HeaderText = "Rank Name";
                    dglMemberInstructor.Columns[3].Width = 120;

                    dglMemberInstructor.Columns[4].HeaderText = "Is Active";
                    dglMemberInstructor.Columns[4].Width = 100;
                }
            }
            else
            {
                dtAllInstructorMember.Clear();
            }
        }
    }
}
