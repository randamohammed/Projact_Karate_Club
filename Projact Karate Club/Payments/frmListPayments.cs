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

namespace KarateClubProjact.Payments
{
    public partial class frmListPayments : Form
    {
        public frmListPayments()
        {
            InitializeComponent();
        }

        DataTable dtAllPayments;
        private void frmListPayments_Load(object sender, EventArgs e)
        {
            cmFilter.SelectedIndex = 0;

            dtAllPayments = clsPayments.GetAllPayments();
            dvPayments.DataSource = dtAllPayments;
            lbRecordes.Text = dvPayments.RowCount.ToString();

            if (dvPayments.Rows.Count > 0)
            {
                dvPayments.Columns[0].HeaderText = "Payment ID";
                dvPayments.Columns[0].Width = 100;

                dvPayments.Columns[1].HeaderText = "Member Name";
                dvPayments.Columns[1].Width = 240;

                dvPayments.Columns[2].HeaderText = "Amount";
                dvPayments.Columns[2].Width = 110;

                dvPayments.Columns[3].HeaderText = "Payment Date";
                dvPayments.Columns[3].Width = 140;

                dvPayments.Columns[4].HeaderText = "Last date modified";
                dvPayments.Columns[4].Width = 140;


            }

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmFilter.Text == "Payment ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = cmFilter.Text != "None";

            if (cmFilter.Text == "None")
            {
                txtFilterValue.Visible = false;
            }
            txtFilterValue.Enabled = true;
            txtFilterValue.Text = "";
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string ColumnFilter = "";

            switch (cmFilter.Text)
            {
                case "Payment ID":
                    {
                        ColumnFilter = "PaymentID";
                        break;
                    }
                case "Member name":
                    {

                        ColumnFilter = "FullName";
                        break;
                    }
                default:
                    ColumnFilter = "None";
                    break;
            }

            if(txtFilterValue.Text  == "" ||ColumnFilter == "None")
            {
                dtAllPayments.DefaultView.RowFilter = "";
                lbRecordes.Text = dvPayments.RowCount.ToString();
                return;
            }

            if(ColumnFilter == "PaymentID")
                dtAllPayments.DefaultView.RowFilter = string.Format("[{0}] = {1}",ColumnFilter,txtFilterValue.Text.Trim());
            else
                dtAllPayments.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", ColumnFilter, txtFilterValue.Text.Trim());

            lbRecordes.Text = dvPayments.RowCount.ToString();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
