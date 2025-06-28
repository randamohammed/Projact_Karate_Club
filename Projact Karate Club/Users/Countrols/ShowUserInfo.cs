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
    public partial class ShowUserInfo : UserControl
    {
        public ShowUserInfo()
        {
            InitializeComponent();
        }
        public static int UserID = 0;
        clsUser _ManageUser;
       public void FullDate()
        {
            _ManageUser = clsUser.Find(UserID);

            if (_ManageUser != null)
            {
                showPeopleInfo1.LoadpersonData(_ManageUser.PersonID);
                laUserID.Text = _ManageUser.UserID.ToString();
                laUsername.Text = _ManageUser.UserName;

                if (_ManageUser.IsActive == true)
                    laISActive.Text = "Yes";
                else
                    laISActive.Text = "No";
            }
        }

        private void linShowAlPermissions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSetPremissons setPremissons = new FormSetPremissons(_ManageUser.Permissions);
            setPremissons.ShowDialog();
        }

        private void ShowUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
