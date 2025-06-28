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

namespace KarateClubProjact.MemberInstructor
{
    public partial class frmLastMemberInstructor : Form
    {
        public frmLastMemberInstructor()
        {
            InitializeComponent();
        }

        DataTable _dtAlltMemberInstructor;

        private void frmLastMemberInstructor_Load(object sender, EventArgs e)
        {
            _dtAlltMemberInstructor = clsMemberInstructors.GetAllMemberInstructor();
            dgMemberInstructor.DataSource = _dtAlltMemberInstructor;
            lbRecord.Text = dgMemberInstructor.RowCount.ToString();

            
            if(dgMemberInstructor.Rows.Count > 0 )
            {
                dgMemberInstructor.Columns[0].HeaderText = "ID";
                dgMemberInstructor.Columns[0].Width = 120;

                dgMemberInstructor.Columns[1].HeaderText = "MemberName";
                dgMemberInstructor.Columns[1].Width = 220;

                dgMemberInstructor.Columns[2].HeaderText = "Member phone";
                dgMemberInstructor.Columns[2].Width = 120;

                dgMemberInstructor.Columns[3].HeaderText = "Member Rnke";
                dgMemberInstructor.Columns[3].Width = 150;

                dgMemberInstructor.Columns[4].HeaderText = "InstructorName";
                dgMemberInstructor.Columns[4].Width = 220;

                dgMemberInstructor.Columns[5].HeaderText = "Instructor ContactInfo";
                dgMemberInstructor.Columns[5].Width = 140;

                dgMemberInstructor.Columns[6].HeaderText = "Assign Date";
                dgMemberInstructor.Columns[6].Width = 120;
            }

        }

        private void txtFiltrValues_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch(cmFindBy.Text)
            {
                case "MemberInstructor ID":
                    FilterColumn = "MemberInstructorID";
                    break;
                case "Instructor Name":
                    FilterColumn = "InstructorName";
                    break;
                case "Member Name":
                    FilterColumn = "MemberName";
                    break;
                case "Member Rnke":
                    FilterColumn = "MemberRnke";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if(txtFiltrValue.Text == "" || FilterColumn == "None")
            {
                _dtAlltMemberInstructor.DefaultView.RowFilter = "";
                lbRecord.Text = dgMemberInstructor.RowCount.ToString();
                return;
            }
           
            if(FilterColumn == "MemberInstructorID")
                _dtAlltMemberInstructor.DefaultView.RowFilter =   string.Format("[{0}] = {1}",FilterColumn,txtFiltrValue.Text.Trim());
            else
                _dtAlltMemberInstructor.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFiltrValue.Text.Trim());

            lbRecord.Text = dgMemberInstructor.RowCount.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btAddNewMemberInstructor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUpdateMemberInstructor frm = new frmAddUpdateMemberInstructor();
            frm.ShowDialog();
            this.Show();
            frmLastMemberInstructor_Load(null, null);
        }

        private void cmFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmFindBy.Text == "None")
            {
                txtFiltrValue.Visible = false;  
            }
            else
            {
                txtFiltrValue.Visible = true;
                txtFiltrValue.Text = "";
                txtFiltrValue.Focus();
            }
        }

        private void memberInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUpdateMemberInstructor frm = new frmAddUpdateMemberInstructor();
            frm.ShowDialog();
            this.Show();
            frmLastMemberInstructor_Load(null, null);
        }

        private void showTrainedMembersByThisInstructorListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int memberInstructorsID = (int)dgMemberInstructor.CurrentRow.Cells[0].Value;

          int InstructorsID  = clsMemberInstructors.Find(memberInstructorsID).InstructorID;
            int PersonId = clsInstructors.FindByID(InstructorsID).PersonID;
            this.Hide();
            frmShowTrainedMemberbyInstructor frm = new frmShowTrainedMemberbyInstructor(PersonId);
            frm.ShowDialog();
            this.Show();
        }

        private void editMemberInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int memberInstructorsID = (int)dgMemberInstructor.CurrentRow.Cells[0].Value;
            frmAddUpdateMemberInstructor frm = new frmAddUpdateMemberInstructor(memberInstructorsID);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            frmLastMemberInstructor_Load(null, null);

        }

        private void deleteMemberInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int memberInstructorsID = (int)dgMemberInstructor.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you wante to delete this Member_Instructor?","Confrim",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if(!clsMemberInstructors.DeleteMemberInstructor(memberInstructorsID))
            {
                MessageBox.Show("Error : not delete Member_Instructor successfully", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Member_Instructor? delete successfully", "Delete successfuully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLastMemberInstructor_Load(null, null);
        }
    }
}
