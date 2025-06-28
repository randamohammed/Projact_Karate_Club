using clsBussinsKarateClubProjacjat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClubProjact
{
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
        }

        DataTable dtAllPeopple;
        DataTable dtPeopple;
        void RefershDate()
        {
            dtAllPeopple = clsBussinesManagePeople.GetallPeopleInSystem();
            davManagePeople.DataSource = dtAllPeopple;
            laRecorde.Text =  davManagePeople.RowCount.ToString();
        }

        string TypeFiilter = "";
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            comFilter.SelectedIndex = 0;

            dtAllPeopple = clsBussinesManagePeople.GetallPeopleInSystem();
             dtPeopple = dtAllPeopple;
             
             davManagePeople.DataSource = dtPeopple .DefaultView.ToTable(false, "PresonID", "NatiionalNo", "FirestName", "SecoundName", "ThirdName", "LastName",
                "DateBirth", "Gender", "Phone", "Adress", "Emil");
            laRecorde.Text = davManagePeople.RowCount.ToString();

            if(davManagePeople.RowCount >0)
            {
                davManagePeople.Columns[0].HeaderText = "People ID";         
                davManagePeople.Columns[0].Width = 100;

                davManagePeople.Columns[1].HeaderText = "National No.";
                davManagePeople.Columns[1].Width = 100;

                davManagePeople.Columns[2].HeaderText = "First Name";
                davManagePeople.Columns[2].Width = 120;

                davManagePeople.Columns[3].HeaderText = "Secound Name";
                davManagePeople.Columns[3].Width = 120;

                davManagePeople.Columns[4].HeaderText = "Third Name";
                davManagePeople.Columns[4].Width = 120;

                davManagePeople.Columns[5].HeaderText = "Laste Name";
                davManagePeople.Columns[5].Width = 120;

                davManagePeople.Columns[6].HeaderText = "Date Birth";
                davManagePeople.Columns[6].Width = 120;

                davManagePeople.Columns[7].HeaderText = "Gender";
                davManagePeople.Columns[7].Width = 120;

                davManagePeople.Columns[8].HeaderText = "Phone";
                davManagePeople.Columns[8].Width = 120;

                davManagePeople.Columns[9].HeaderText = "Address";
                davManagePeople.Columns[9].Width = 150;


                davManagePeople.Columns[10].HeaderText = "Emil";
                davManagePeople.Columns[10].Width = 150;


            }
        }

        private void davManagePeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comFilter.Text == "People ID")
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void teFilter_TextChanged(object sender, EventArgs e)
        {
            string FlterColumns = "";
            
            switch(comFilter.Text)
            {
                case "People ID":
                    FlterColumns = "PresonID";
                    break;

                case "Naional No":
                    FlterColumns = "NatiionalNo";
                    break;
                case "Full Name":
                    FlterColumns = "FullName";
                    break;
                case "Gender":
                    FlterColumns = "Gender";
                    break;
                default:
                    FlterColumns = "None";
                    break;

            }

            if(teFilter.Text =="" || FlterColumns =="None")
            {
                dtPeopple.DefaultView.RowFilter = "";
                laRecorde.Text = davManagePeople.RowCount.ToString();
                return;
            }

            if(FlterColumns == "PresonID")
                dtAllPeopple.DefaultView.RowFilter = string.Format("[{0}] ={1}",FlterColumns,teFilter.Text.Trim());
            else
                dtPeopple.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'",FlterColumns,teFilter.Text.Trim());

            laRecorde.Text = davManagePeople.RowCount.ToString();

        }

        private void comFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comFilter.Text == "None")
            {
                teFilter.Visible = false;
                return;
            }
            else
            {
                teFilter.Visible = true;
            }
            teFilter.Focus();
            teFilter.Text = "";
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pichAddNewPeople_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateNewPeople newUpdatePeople = new frmAddAndUpdateNewPeople(-1);
            newUpdatePeople.ShowDialog();
            RefershDate();
        }

        private void tosEditPeople_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateNewPeople newUpdatePeople = new frmAddAndUpdateNewPeople(Convert.ToInt32(davManagePeople.CurrentRow.Cells[0].Value));
            newUpdatePeople.ShowDialog();
            RefershDate();
        }

        private void tosAddNewPeople_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateNewPeople newUpdatePeople = new frmAddAndUpdateNewPeople(-1);
            newUpdatePeople.ShowDialog();
            RefershDate();
        }

        private void tosShowDetiles_Click(object sender, EventArgs e)
        {
            ShowPeopleDetils showPeople = new ShowPeopleDetils(Convert.ToInt32(davManagePeople.CurrentRow.Cells[0].Value));
            showPeople.ShowDialog();
            RefershDate();
        }

        private void tosDeletePeople_Click(object sender, EventArgs e)
        {
            int personIId =(int) davManagePeople.CurrentRow.Cells[0].Value;


                if (MessageBox.Show("Are you sure you wante to delete this Person?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!clsBussinesManagePeople.DelectPeople(personIId))
            {
                MessageBox.Show("Error : Person not delete  successfully", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Member_Instructor? delete successfully", "Delete successfuully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ManagePeople_Load(null, null);
        }
    }
}
