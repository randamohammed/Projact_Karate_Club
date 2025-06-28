namespace KarateClubProjact.Payments
{
    partial class frmListPayments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dvPayments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.lbRecordes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvPayments)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(341, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Payments";
            // 
            // dvPayments
            // 
            this.dvPayments.AllowUserToAddRows = false;
            this.dvPayments.AllowUserToDeleteRows = false;
            this.dvPayments.AllowUserToOrderColumns = true;
            this.dvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPayments.Location = new System.Drawing.Point(12, 200);
            this.dvPayments.Name = "dvPayments";
            this.dvPayments.ReadOnly = true;
            this.dvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvPayments.Size = new System.Drawing.Size(807, 379);
            this.dvPayments.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.lbRecordes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 48);
            this.panel1.TabIndex = 3;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(699, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(94, 39);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbRecordes
            // 
            this.lbRecordes.AutoSize = true;
            this.lbRecordes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordes.Location = new System.Drawing.Point(113, 13);
            this.lbRecordes.Name = "lbRecordes";
            this.lbRecordes.Size = new System.Drawing.Size(40, 24);
            this.lbRecordes.TabIndex = 1;
            this.lbRecordes.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "# Recordes:";
            // 
            // cmFilter
            // 
            this.cmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFilter.FormattingEnabled = true;
            this.cmFilter.Items.AddRange(new object[] {
            "None",
            "Payment ID",
            "Member name"});
            this.cmFilter.Location = new System.Drawing.Point(101, 166);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.Size = new System.Drawing.Size(180, 28);
            this.cmFilter.TabIndex = 4;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(287, 168);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(189, 26);
            this.txtFilterValue.TabIndex = 5;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "FilterBy:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.smartphone;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(6, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 5);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.button1.Location = new System.Drawing.Point(764, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 48);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmListPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 654);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvPayments);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmListPayments";
            this.Text = "List Payments";
            this.Load += new System.EventHandler(this.frmListPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvPayments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dvPayments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbRecordes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmFilter;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}