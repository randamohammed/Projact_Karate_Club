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
    public partial class CtrlPersonCardWithFilter : UserControl
    {
        public CtrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public delegate void OpnersonSelet(int PersonID);
        public event OpnersonSelet BackPersonID ;
        public  int PersonID =-1;

        public clsBussinesManagePeople SelectPersonInfo;

         bool _EnableFilter =true;

         public bool EnableFilter 
         { 
            get { return _EnableFilter; }

            set{ _EnableFilter = value;
                groFilter.Enabled = _EnableFilter;
            }
         }



       public void LoadPersonInfo(int PersonID )
        {
           
            this.PersonID = PersonID;
            if (PersonID != -1)
            {
                comFlter.Text = "People ID";
                texFlter.Text = PersonID.ToString();
                groFilter.Enabled = false;
            }

            if(comFlter.Text == "People ID")
            {
              
                PersonID = int.Parse(texFlter.Text);
                showPeopleInfo3.LoadpersonData(PersonID);
               BackPersonID?.Invoke(PersonID);
            }
            else
            {
                if (comFlter.Text == "Natoinal No")
                {
                    SelectPersonInfo = clsBussinesManagePeople.FindByNatonalNo(texFlter.Text);
                    if (SelectPersonInfo != null)
                    {
                        PersonID = SelectPersonInfo.PresonID;
                        showPeopleInfo3.Loaddate(texFlter.Text);
                        BackPersonID.Invoke(PersonID);

                    }
                    else
                    {
                        MessageBox.Show("This People s not fond Chooes anther people", "Not Fouund", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
        private void picSearchPeople_Click(object sender, EventArgs e)
        {
            LoadPersonInfo(-1);
        }


        private void picAddPopele_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateNewPeople addAndUpdateNew = new frmAddAndUpdateNewPeople(-1);
            addAndUpdateNew.ShowDialog();
        }


        private void texFlter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comFlter.Text == "People ID")
            {
                if (!char.IsDigit(e.KeyChar) &&  e.KeyChar!= (char) Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void texFlter_TextChanged(object sender, EventArgs e)
        {
            if(texFlter.Text == "")
                showPeopleInfo3.RefrshDate();
        }

        private void comFlter_SelectedIndexChanged(object sender, EventArgs e)
        {
            texFlter.Focus();
            texFlter.Text = "";
        }

        public void TxtFoucsinText()
        {
            comFlter.SelectedIndex = 0;
            texFlter.Focus();
        }
        private void CtrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            TxtFoucsinText();
            comFlter.SelectedIndex = 0;
        }

        private void showPeopleInfo3_Load(object sender, EventArgs e)
        {

        }
    }
}
