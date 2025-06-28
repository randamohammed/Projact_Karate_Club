using clsBussinsKarateClubProjacjat;
using DVLDSluotion;
using KarateClubProjact.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClubProjact
{
    public partial class AddOrUpdatePeople : UserControl
    {
        public AddOrUpdatePeople()
        {
            InitializeComponent();
            datbBiirthDay.MaxDate = DateTime.Now;
        }

        public static int PresonID;
        public event Action<int> GetPersonID;
        public virtual void PersonID(int PresonID)
        {
            Action<int> Sender = GetPersonID;
            if (Sender != null)
            {
                Sender(PresonID);
            }

        }


        clsBussinesManagePeople ManagePeople = new clsBussinesManagePeople();
        enum _Mode
        {
            _AddDate = 0, _UpdateDate = 1
        };

        string PathImages = "";
        private _Mode Mode;
         public  void SetMode()
         {
            if (PresonID == -1)
                Mode = _Mode._AddDate;
            else
                Mode = _Mode._UpdateDate;
         }

       public void AddOrEdit()
        {
            SetMode();
            if (Mode == _Mode._AddDate)
            {
                ManagePeople = new clsBussinesManagePeople();
                return;
            }
            ManagePeople = clsBussinesManagePeople.Find(PresonID);

            if(ManagePeople != null)
            {
                teFirstname.Text = ManagePeople.FirestName;
                teSconedname.Text = ManagePeople.SecoundName;
                teThirdname.Text = ManagePeople.ThirdName;
                texLastename.Text = ManagePeople.LastName;
                teNationalNo.Text = ManagePeople.NatiionalNo;
                tePhone.Text = ManagePeople.Phone;
                teEmil.Text = ManagePeople.Emil;
                richAdress.Text = ManagePeople.Adress;
                datbBiirthDay.Value = ManagePeople.DateBirth;

                if (ManagePeople.Gander == 1)
                    chFemale.Checked = true;
                else
                    chMale.Checked = true;


                if (ManagePeople.PathImage !="")
                   pitPathImage.ImageLocation = ManagePeople.PathImage;

               likRemoveImage.Visible =  (ManagePeople.PathImage != "") ;
            }
        }

        private void teNationalNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void teFirstname_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(teFirstname.Text) == true)
            {
                teFirstname.Focus();
                e.Cancel = true;
                errorProvider1.SetError(teFirstname, "Set First name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(teFirstname, "");
            }
        }

        private void teSconedname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(teSconedname.Text) == true)
            {
                teSconedname.Focus();
                e.Cancel = true;
                errorProvider1.SetError(teSconedname, "Set Sconed name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(teSconedname, "");
            }
        }

        private void teThirdname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(teThirdname.Text) == true)
            {
                teThirdname.Focus();
                e.Cancel = true;
                errorProvider1.SetError(teThirdname, "Set Third name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(teThirdname, "");
            }
        }

        private void texLastename_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(texLastename.Text) == true)
            {
                texLastename.Focus();
                e.Cancel = true;
                errorProvider1.SetError(texLastename, "Set Laste name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(texLastename, "");
            }
        }

        private void teNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(teNationalNo.Text) == true)
            {
                teNationalNo.Focus();
                e.Cancel = true;
                errorProvider1.SetError(teNationalNo, "Set National No");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(teNationalNo, "");
            }
        }

        private void tePhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tePhone.Text) == true)
            {
                tePhone.Focus();
                e.Cancel = true;
                errorProvider1.SetError(tePhone, "Set Phone");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tePhone, "");
            }
        }

        private void richAdress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(richAdress.Text) == true)
            {
                richAdress.Focus();
                e.Cancel = true;
                errorProvider1.SetError(richAdress, "Set First name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(richAdress, "");
            }
        }


       
        bool _HandleImagePerson()
        {
            if (ManagePeople.PathImage != pitPathImage.ImageLocation)
            {
                if (ManagePeople.PathImage != "")
                {
                    try
                    {
                        File.Delete(ManagePeople.PathImage);
                    }
                    catch (IOException)
                    {
                        return false;
                    }
                }

                if (pitPathImage.ImageLocation != null)
                {
                    string SourceImageFile = pitPathImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageinFloder(ref SourceImageFile))
                    {
                        pitPathImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }
        private void groupBox1_Validating(object sender, CancelEventArgs e)
        {
        }

        private void AddOrUpdatePeople_Load(object sender, EventArgs e)
        {
           
        }

        private void butSave_Click(object sender, EventArgs e)
        {
           if(!_HandleImagePerson())
            {
                return;
            }
            
            
            ManagePeople.PresonID = PresonID;
            ManagePeople.FirestName = teFirstname.Text;
            ManagePeople.SecoundName = teSconedname.Text;
            ManagePeople.ThirdName = teThirdname.Text;
            ManagePeople.LastName = texLastename.Text;
            ManagePeople.Emil = teEmil.Text;
            ManagePeople.NatiionalNo = teNationalNo.Text;
            ManagePeople.Phone = tePhone.Text;
            ManagePeople.Adress = richAdress.Text;
            ManagePeople.DateBirth = datbBiirthDay.Value;
            ManagePeople.PathImage = pitPathImage.ImageLocation == null ? "" : pitPathImage.ImageLocation;


            if (chMale.Checked == true)
                ManagePeople.Gander = 0;
            else
                ManagePeople.Gander = 1;

            if(ManagePeople.Save())
            {
                MessageBox.Show("Date Save Sucsseccfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            PresonID = ManagePeople.PresonID;
            Mode = _Mode._UpdateDate;

           if(GetPersonID !=null)
           {
                GetPersonID.Invoke(ManagePeople.PresonID);
           }
        }

        private void likSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.if;*.bmp";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {         
                PathImages = fileDialog.FileName;

                pitPathImage.ImageLocation = PathImages;
            }
           
        }

        private void chFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(PathImages =="")
            {
                pitPathImage.Image = Resources.student_girl;
            }
        }

        private void chMale_CheckedChanged(object sender, EventArgs e)
        {
            if (PathImages == "")
            {
                pitPathImage.Image = Resources.flight_attendant_male;
            }
        }

        private void datbBiirthDay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
