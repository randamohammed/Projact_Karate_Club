namespace KarateClubProjact.Payments
{
    partial class frmPaymentHistory
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
            this.ctrlFindMemberInfo1 = new KarateClubProjact.Members.ctrlFindMemberInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRecordes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.lbTotalPayments = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbTestFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSubscriptionPeriodsFees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlFindMemberInfo1
            // 
            this.ctrlFindMemberInfo1.Location = new System.Drawing.Point(12, 43);
            this.ctrlFindMemberInfo1.Name = "ctrlFindMemberInfo1";
            this.ctrlFindMemberInfo1.Size = new System.Drawing.Size(913, 224);
            this.ctrlFindMemberInfo1.TabIndex = 0;
            this.ctrlFindMemberInfo1.Load += new System.EventHandler(this.ctrlFindMemberInfo1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRecordes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dvPaymentHistory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment History:";
            // 
            // lbRecordes
            // 
            this.lbRecordes.AutoSize = true;
            this.lbRecordes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordes.ForeColor = System.Drawing.Color.Black;
            this.lbRecordes.Location = new System.Drawing.Point(124, 181);
            this.lbRecordes.Name = "lbRecordes";
            this.lbRecordes.Size = new System.Drawing.Size(40, 24);
            this.lbRecordes.TabIndex = 2;
            this.lbRecordes.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Recordes:";
            // 
            // dvPaymentHistory
            // 
            this.dvPaymentHistory.AllowUserToAddRows = false;
            this.dvPaymentHistory.AllowUserToDeleteRows = false;
            this.dvPaymentHistory.AllowUserToOrderColumns = true;
            this.dvPaymentHistory.BackgroundColor = System.Drawing.Color.White;
            this.dvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPaymentHistory.Location = new System.Drawing.Point(6, 28);
            this.dvPaymentHistory.Name = "dvPaymentHistory";
            this.dvPaymentHistory.ReadOnly = true;
            this.dvPaymentHistory.Size = new System.Drawing.Size(901, 150);
            this.dvPaymentHistory.TabIndex = 0;
            // 
            // lbTotalPayments
            // 
            this.lbTotalPayments.AutoSize = true;
            this.lbTotalPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPayments.Location = new System.Drawing.Point(199, 489);
            this.lbTotalPayments.Name = "lbTotalPayments";
            this.lbTotalPayments.Size = new System.Drawing.Size(44, 20);
            this.lbTotalPayments.TabIndex = 49;
            this.lbTotalPayments.Text = "[???]";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::KarateClubProjact.Properties.Resources.smartphone__1_;
            this.pictureBox9.Location = new System.Drawing.Point(167, 483);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 29);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 48;
            this.pictureBox9.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 486);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 24);
            this.label16.TabIndex = 47;
            this.label16.Text = "Totale Payments:";
            // 
            // lbTestFees
            // 
            this.lbTestFees.AutoSize = true;
            this.lbTestFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestFees.Location = new System.Drawing.Point(444, 489);
            this.lbTestFees.Name = "lbTestFees";
            this.lbTestFees.Size = new System.Drawing.Size(44, 20);
            this.lbTestFees.TabIndex = 52;
            this.lbTestFees.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Test Fees:";
            // 
            // lbSubscriptionPeriodsFees
            // 
            this.lbSubscriptionPeriodsFees.AutoSize = true;
            this.lbSubscriptionPeriodsFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubscriptionPeriodsFees.Location = new System.Drawing.Point(786, 487);
            this.lbSubscriptionPeriodsFees.Name = "lbSubscriptionPeriodsFees";
            this.lbSubscriptionPeriodsFees.Size = new System.Drawing.Size(44, 20);
            this.lbSubscriptionPeriodsFees.TabIndex = 55;
            this.lbSubscriptionPeriodsFees.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Subscriptions Fees:";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(823, 559);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(96, 31);
            this.btClose.TabIndex = 56;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(376, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Payment History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.smartphone__1_;
            this.pictureBox1.Location = new System.Drawing.Point(408, 485);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KarateClubProjact.Properties.Resources.smartphone__1_;
            this.pictureBox2.Location = new System.Drawing.Point(750, 483);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // frmPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 602);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbSubscriptionPeriodsFees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTestFees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotalPayments);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlFindMemberInfo1);
            this.Name = "frmPaymentHistory";
            this.Text = "Payment History";
            this.Load += new System.EventHandler(this.frmPaymentHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Members.ctrlFindMemberInfo ctrlFindMemberInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvPaymentHistory;
        private System.Windows.Forms.Label lbRecordes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalPayments;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbTestFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSubscriptionPeriodsFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}