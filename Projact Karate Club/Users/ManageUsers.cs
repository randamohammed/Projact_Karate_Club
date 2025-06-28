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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        string TextFilter = "";

        void LoadDate()
        {
            davManageUser.DataSource = clsUser.GetAllUser();
            laRecode.Text =  davManageUser.RowCount.ToString();
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void ManageUsers_Load_2(object sender, EventArgs e)
        {
            LoadDate();
        }

        private void comFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comFilter.Text == "None")
            {
                texFilter.Visible = false;
                comISActive.Visible = false;
                LoadDate();
                return;
            }
            if (comFilter.Text == "Is Active")
            {
                texFilter.Visible = false;
                comISActive.Visible = true;
            }
            else
            {
                texFilter.  Visible = true;
                comISActive.Visible = false;
            
            }
        }

        void FilterDate()
        {
            davManageUser.DataSource = clsUser.GetFilterDate(comFilter.Text,TextFilter);
            laRecode.Text = davManageUser.RowCount.ToString();
        }

        private void texFilter_TextChanged(object sender, EventArgs e)
        {
            TextFilter =texFilter.Text;
            FilterDate();
        }

        private void piAddUser_Click(object sender, EventArgs e)
        {
            AddOrUpdateUser AddUser = new AddOrUpdateUser(-1);
            AddUser.ShowDialog();
            LoadDate();
        }

        private void comISActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comISActive.Text =="None")
            {
                LoadDate();
                return;
            }
            if (comISActive.Text == "Yes")
                TextFilter = "1";
            else
                TextFilter = "0";
            FilterDate();
        }

       
        private void tosAddUser_Click(object sender, EventArgs e)
        {
            AddOrUpdateUser AddUser = new AddOrUpdateUser(-1);
            this.Hide();
            AddUser.ShowDialog();
            this.Show();
           LoadDate();
        }

        private void tosEditUser_Click(object sender, EventArgs e)
        {
            int UserID =Convert.ToInt32(davManageUser.CurrentRow.Cells[0].Value);
            AddOrUpdateUser AddUser = new AddOrUpdateUser(UserID);
            this.Hide();
            AddUser.ShowDialog();
            this.Show();
            LoadDate();
        }

        private void tosShowUserinfo_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(davManageUser.CurrentRow.Cells[0].Value);
            ShowUserDetilesInfo userDetilesInfo = new ShowUserDetilesInfo(UserID);
            this.Hide();
            userDetilesInfo.ShowDialog();
        this.Show();
        }

        private void chanageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(davManageUser.CurrentRow.Cells[0].Value);
            ChenagePassword chenagePassword = new ChenagePassword(UserID);
            this.Hide();
            chenagePassword.ShowDialog();
            this.Show();
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddOrUpdateUser AddUser = new AddOrUpdateUser(-1);
            this.Hide();
            AddUser.ShowDialog();
            this.Show();
            LoadDate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tosDeleteUser_Click(object sender, EventArgs e)
        {


            int UserID = Convert.ToInt32(davManageUser.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure you wante to delete this Users?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!clsUser.DelectUser(UserID))
            {
                MessageBox.Show("Error : Users not delete  successfully", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Member_Instructor? delete successfully", "Delete successfuully", MessageBoxButtons.OK, MessageBoxIcon.Information);
           ManageUsers_Load_2(null, null);
        }
    }
}
