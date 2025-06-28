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
    public partial class frmAddAndUpdateNewPeople : Form
    {
        public frmAddAndUpdateNewPeople(int presonID)
        {
            InitializeComponent();
            PeopleIdd = presonID;
            AddOrUpdatePeople.PresonID = PeopleIdd;
        }
        int PeopleIdd = 0;
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void Local()

        {
            if (PeopleIdd != -1)
            {
                labMode.Text = "Update People";
                labPeopleID.Text = PeopleIdd.ToString();
            }
            else
                labMode.Text = "Add New People";
        }
        private void AddAndUpdateNewPeople_Load(object sender, EventArgs e)
        {
            Local();
            addOrUpdatePeople1.AddOrEdit();
        }

        private void addOrUpdatePeople1_GetPersonID(int PeopelID)
        {
            PeopleIdd = PeopelID;
            Local();
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
