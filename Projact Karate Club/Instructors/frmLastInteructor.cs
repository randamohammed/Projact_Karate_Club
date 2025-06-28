using clsBussinsKarateClubProjacjat;
using KarateClubProjact.Instructors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClubProjact
{
    public partial class frmLastInteructor : Form
    {
        public frmLastInteructor()
        {
            InitializeComponent();
        }

        private void btInteructor_Click(object sender, EventArgs e)
        {
            frmAddUpdateInstructors frm =  new frmAddUpdateInstructors();
            frm.ShowDialog();
        }

       DataTable dtAllInteructor = clsInstructors.GetAllInteructor();
        private void frmLastInteructor_Load(object sender, EventArgs e)
        {
            cmFilter.SelectedIndex = 0;
            txtFilterValues.Focus();

            dvInteructor.DataSource = dtAllInteructor.DefaultView.ToTable();
            lbRecorde.Text = dvInteructor.RowCount.ToString();

            if(dvInteructor.RowCount > 0)
            {
                dvInteructor.Columns[0].HeaderText = "Inteructor ID";
                dvInteructor.Columns[0].Width = 100;

                dvInteructor.Columns[1].HeaderText = "Full Name";
                dvInteructor.Columns[1].Width = 200;

                dvInteructor.Columns[2].HeaderText = "Qualification";
                dvInteructor.Columns[2].Width = 170;

                dvInteructor.Columns[3].HeaderText = "Gender";
                dvInteructor.Columns[3].Width = 90;

                dvInteructor.Columns[4].HeaderText = "Date Of Birth";
                dvInteructor.Columns[4].Width = 120;             

                dvInteructor.Columns[5].HeaderText = "Phone";
                dvInteructor.Columns[5].Width = 100;
            }


        }

        void _RefrshDeflutvaluse()
        {
            dtAllInteructor = clsInstructors.GetAllInteructor();

            dvInteructor.DataSource = dtAllInteructor;
            lbRecorde.Text = dvInteructor.RowCount.ToString();
        }
        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cmFilter.Text == "None")
                {
                    txtFilterValues.Visible = false;
                    
                }
                else
            txtFilterValues.Visible = cmFilter.Text != "None";
            txtFilterValues.Text = "";

        }
        private void txtFilterValues_TextChanged(object sender, EventArgs e)
        {

            string ColumnsFilter = "";
            switch (cmFilter.Text)
            {
                case "Inteructor ID":
                    ColumnsFilter = "InstructorsID";
                    break;
                case "Full Name":
                    ColumnsFilter = "Fullname";
                    break;
                case "Gender":
                    ColumnsFilter = "Gender";
                    break;
                default:
                    ColumnsFilter = "None";
                    break;
            }

            if (txtFilterValues.Text == "" || ColumnsFilter == "None")
            {
                txtFilterValues.Visible = false;
                dtAllInteructor.DefaultView.RowFilter = "";
                txtFilterValues.Text = "";
                _RefrshDeflutvaluse();
                return;
            }
            if (ColumnsFilter == "Fullname" || ColumnsFilter == "Gender")
            {
                dtAllInteructor.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", ColumnsFilter, txtFilterValues.Text);
                lbRecorde.Text = dvInteructor.RowCount.ToString();
            }
            else
                dtAllInteructor.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnsFilter, txtFilterValues.Text);
            lbRecorde.Text = dvInteructor.RowCount.ToString();
        }

        private void showInstructorDelatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InstructorID =(int) dvInteructor.CurrentRow.Cells[0].Value;
            this.Hide();
            frmShowinstructorsInfo frm = new frmShowinstructorsInfo(InstructorID);
            frm.ShowDialog();
            this.Show();
        }

        private void editInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InstructorID = (int)dvInteructor.CurrentRow.Cells[0].Value;
            this.Hide();
            frmAddUpdateInstructors frm = new frmAddUpdateInstructors(InstructorID);
            frm.ShowDialog();
            this.Show();

            frmLastInteructor_Load(null, null);
        }

        private void addInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InstructorID = (int)dvInteructor.CurrentRow.Cells[0].Value;
            this.Hide();
            frmAddUpdateInstructors frm = new frmAddUpdateInstructors();
            frm.ShowDialog();
            this.Show();
            frmLastInteructor_Load(null, null);
        }

        private void deleteInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InstructorID = (int)dvInteructor.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you wante to delete this Instructor? ","Confrim",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(clsInstructors.DeleteInstructors(InstructorID))
                {
                    MessageBox.Show("Delete Data successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                frmLastInteructor_Load(null, null);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trainedMemberByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InstructorID = (int)dvInteructor.CurrentRow.Cells[0].Value;
            int PersonID = clsInstructors.FindByID(InstructorID).PersonID;
            this.Hide();
            frmShowTrainedMemberbyInstructor frm = new frmShowTrainedMemberbyInstructor(PersonID);
            frm.ShowDialog();
            this.Show();
        }

        private void dvInteructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
