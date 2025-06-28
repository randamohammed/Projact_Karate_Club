using clsBussinsKarateClubProjacjat;
using KarateClubProjact.Properties;
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
    public partial class ShowPeopleInfo : UserControl
    {
        public ShowPeopleInfo()
        {
            InitializeComponent();
        }

        public static int MangePeopleID = 0;
        clsBussinesManagePeople SelectPeersonInfo;

        public  void RefrshDate()
        {
            laPeopleID.Text = "[???]";
            laNatoinalNo.Text = "[???]";
            laName.Text = "[???]";
            laBirthDay.Text = "[???]";
            laEmil.Text = "[???]";
            laAddress.Text = "[???]";
            laPhone.Text = "[???]";
            laGender.Text = "[???]";
            piSetImage.Image= Resources.Calendar_32;
        }

        void HanadlImagePerson()
        {
            if (SelectPeersonInfo.Gander == 0)
                piSetImage.Image = Resources.Male_512;
            else
                piSetImage.Image = Resources.Female_512;

            if(SelectPeersonInfo.PathImage != "")
              piSetImage.ImageLocation = SelectPeersonInfo.PathImage;

        }

        public void FullDate()
        {
                SelectPeersonInfo = clsBussinesManagePeople.Find(MangePeopleID);

            if (SelectPeersonInfo == null)
            {
                return;
            }
                liEditpeopleinfo.Enabled = true;
                laPeopleID.Text = SelectPeersonInfo.PresonID.ToString();
                laNatoinalNo.Text = SelectPeersonInfo.NatiionalNo;
                laName.Text = SelectPeersonInfo.FirestName + " " + SelectPeersonInfo.SecoundName + " "+ SelectPeersonInfo.ThirdName + " "+SelectPeersonInfo.LastName;
                laBirthDay.Text = SelectPeersonInfo.DateBirth.ToString();
                laEmil.Text = (SelectPeersonInfo.Emil!= "") ? SelectPeersonInfo.Emil : "No Emil";
                laAddress.Text = SelectPeersonInfo.Adress;
                laPhone.Text = SelectPeersonInfo.Phone;


                 HanadlImagePerson();
                if (SelectPeersonInfo.Gander == 1)
                    laGender.Text = "Female";
                else
                    laGender.Text = "Male";
        }


        public void Loaddate(string NatoinalNo)
        {
            SelectPeersonInfo = clsBussinesManagePeople.FindByNatonalNo(NatoinalNo);
            if(SelectPeersonInfo != null)
            {
                MangePeopleID = SelectPeersonInfo.PresonID;
                FullDate();
                return;
            }
            MessageBox.Show("Select Person Not found","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public void LoadpersonData(int PersonID)
        {
            SelectPeersonInfo = clsBussinesManagePeople.Find(PersonID);
            if (SelectPeersonInfo != null)
            {
                MangePeopleID = SelectPeersonInfo.PresonID;
                FullDate();
                return;
            }
            MessageBox.Show("Select Person Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void liEditpeopleinfo_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndUpdateNewPeople frm = new frmAddAndUpdateNewPeople(MangePeopleID);
            frm.ShowDialog();
          LoadpersonData(MangePeopleID) ;
        }

        private void ShowPeopleInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
