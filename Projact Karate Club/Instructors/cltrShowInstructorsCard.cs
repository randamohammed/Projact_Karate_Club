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

namespace KarateClubProjact
{
    public partial class cltrShowInstructorsCard : UserControl
    {
        public cltrShowInstructorsCard()
        {
            InitializeComponent();
           
        }

      public  int _InstructorsID = -1;
        clsInstructors instructors;
   
        public int InstructorsID
        {
            get {
                return _InstructorsID;
                    }
        }
        public clsInstructors SelectInstructorInfo
        {
            get { return instructors; }
        }

        private void LoadData()
        {
            lbInstructorsID.Text = instructors.InstructorsID.ToString();
            lbQualification.Text = instructors.Qualification;
            _InstructorsID = instructors.InstructorsID;
        }
      public void Loadinstructors(int instructorsID)
        {
            instructors = clsInstructors.FindByID(instructorsID);

            if (instructors == null)
            {
                MessageBox.Show("Select member is not found,Chooes one member", "Error dont Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            showPeopleInfo1.LoadpersonData(instructors.PersonID);
            LoadData();
        }
        public void LoadinstructorByPersonID(int PersonID)
        {
            instructors = clsInstructors.FindByPersonID(PersonID);

            if (instructors == null)
            {
                MessageBox.Show("Select member is not found,Chooes one member", "Error dont Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            showPeopleInfo1.LoadpersonData(instructors.PersonID);
            LoadData();
        }

        private void cltrShowInstructorsCard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
