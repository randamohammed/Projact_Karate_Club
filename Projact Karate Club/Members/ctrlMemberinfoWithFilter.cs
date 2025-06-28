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

namespace KarateClubProjact.Members
{
    public partial class ctrlMemberinfoWithFilter : UserControl
    {
        public ctrlMemberinfoWithFilter()
        {
            InitializeComponent();
        }

        int _PersonID = -1;
        int _MemberID = -1;
        bool _EnableFilter;
        clsMembers _Member;


        public event Action<int> OnMemberSelect;

        void MemberSelect(int MemberID)
        {
            Action<int> Hender = OnMemberSelect;

            if (Hender != null)
            {
                Hender(MemberID);
            }
        }

        public clsMembers SelectMemberInfo
        {
            get
            {
                return ctrlShowMemberInfo1.SelectMemberInfo;
            }
        }

        public bool EnableFilter
        {
            get { return _EnableFilter; }

            set
            {
                _EnableFilter = value;
                groFilter.Enabled = _EnableFilter;
            }
        }
        public void TextValuseFocus()
        {
            texFlter.Focus();
            texFlter.Text = "";
        }

        public void LoadMemberInfo(int MemberInd)
        {
            texFlter.Text = MemberInd.ToString();
            comFlter.SelectedIndex = 0;
            LoadMemberinfo();
        }

        void LoadMemberinfo()
        {

            switch(comFlter.Text)
            {
                case "Mmber ID":
                    {

                        _MemberID = int.Parse(texFlter.Text);
                        texFlter.Text = _MemberID.ToString();
                        ctrlShowMemberInfo1.LoadMemberInfo(_MemberID);
                        break;
                    }
                case "People ID":
                    {
                        _PersonID = int.Parse(texFlter.Text);
                        ctrlShowMemberInfo1.LoadMemberInfoByPesonID(_PersonID);
                        break;
                    }
            }

            if (OnMemberSelect != null && EnableFilter)
                OnMemberSelect.Invoke(_MemberID);
        }

        private void ctrlMemberinfoWithFilter_Load(object sender, EventArgs e)
        {
            if(_MemberID !=-1)
            texFlter.Text = _MemberID.ToString();
           comFlter.SelectedIndex = 0;
            TextValuseFocus();
        }

        private void BackMemberID(int MemberID)
        {
            texFlter.Text = MemberID.ToString();
            LoadMemberinfo();
            EnableFilter = false;
        }

        private void texFlter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    {
                e.Handled = true;
            }

            if(e.KeyChar == (char)Keys.Enter)
            {
                btFind.PerformClick();
            }

        }
        private void btFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadMemberinfo();
        }

        private void ctrlShowMemberInfo1_Load(object sender, EventArgs e)
        {
            TextValuseFocus();
            comFlter.SelectedIndex = 0;

        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdatMembers frm = new frmAddUpdatMembers();
            frm.BackMemberID += BackMemberID;
            frm.ShowDialog();
        }

        private void texFlter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(texFlter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(texFlter, "this is Failed");
            }
            else
                errorProvider1.SetError(texFlter, null);
        }

        private void texFlter_TextChanged(object sender, EventArgs e)
        {

        }

        private void comFlter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
