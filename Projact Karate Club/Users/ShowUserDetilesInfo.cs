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
    public partial class ShowUserDetilesInfo : Form
    {
        public ShowUserDetilesInfo(int _UserID)
        {
            InitializeComponent();
            UserID = _UserID;
            ShowUserInfo.UserID = _UserID;
        }

        int UserID = 0;
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showUserInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ShowUserDetilesInfo_Load(object sender, EventArgs e)
        {
            showUserInfo1.FullDate();
        }
    }
}
