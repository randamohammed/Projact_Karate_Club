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

namespace KarateClubProjact.Instructors
{
    public partial class ctrlShowInstructorscardWithFilter : UserControl
    {
        public ctrlShowInstructorscardWithFilter()
        {
            InitializeComponent();
        }


        public event Action<int> OninstructorsSelect;

        void MemberSelect(int instructorsID)
        {
            Action<int> Hender = OninstructorsSelect;

            if (Hender != null)
            {
                Hender(instructorsID);
            }
        }

        int _InstructorID;
        int _PeopleID;
        public clsInstructors SelectInstructorInfo
        {
            get
            {
                return cltrShowInstructorsCard1.SelectInstructorInfo;
            }
        }
        bool _EnableFilter;
        public bool FilterEnable
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

        private void texFlter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

            if(e.KeyChar == (char)13)
                btFind.PerformClick();
        }

        private void texFlter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(texFlter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(texFlter, "this is Valied");
            }
            else
                errorProvider1.SetError(texFlter, null);
        }

        public void LoadInstructorsinfo(int InstructorID)
        {
            texFlter.Text = InstructorID.ToString();
            comFlter.SelectedIndex = 0;
            LoadInstructorsinfo();
        }
        void LoadInstructorsinfo()
        {
            switch(comFlter.Text)
            {
                case "Instructors ID":
                    {
                        _InstructorID = int.Parse(texFlter.Text);
                        cltrShowInstructorsCard1.Loadinstructors(_InstructorID);
                        break;
                    }
                case "People ID":
                    {
                        _PeopleID = int.Parse(texFlter.Text);
                        cltrShowInstructorsCard1.LoadinstructorByPersonID(_PeopleID);
                        break;
                    }
            }
            if(OninstructorsSelect != null && FilterEnable)
                OninstructorsSelect.Invoke(cltrShowInstructorsCard1.InstructorsID);
        }
        private void btAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateInstructors frm = new frmAddUpdateInstructors();
            frm.BackinstructorsID += BackEvent;
            frm.ShowDialog();
        }

        private void BackEvent(int instructorsID)
        {
            texFlter.Text = instructorsID.ToString();
            comFlter.SelectedIndex = 0;
            LoadInstructorsinfo();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadInstructorsinfo();
        }

        private void ctrlShowInstructorscardWithFilter_Load(object sender, EventArgs e)
        {
            comFlter.SelectedIndex = 0;
        }
    }
}
