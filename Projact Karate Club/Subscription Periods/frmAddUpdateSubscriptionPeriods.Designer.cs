namespace KarateClubProjact.Subscription_Periods
{
    partial class frmAddUpdateSubscriptionPeriods
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
            this.components = new System.ComponentModel.Container();
            this.lbTitel = new System.Windows.Forms.Label();
            this.tbSubscription = new System.Windows.Forms.TabControl();
            this.tpMemberInfo = new System.Windows.Forms.TabPage();
            this.ctrlMemberinfoWithFilter1 = new KarateClubProjact.Members.ctrlMemberinfoWithFilter();
            this.tpPeriodInfo = new System.Windows.Forms.TabPage();
            this.cbIspaid = new System.Windows.Forms.CheckBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.dtpEnddDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPaymentID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMembrId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPeriodID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.byPeriodIinfo = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbSubscription.SuspendLayout();
            this.tpMemberInfo.SuspendLayout();
            this.tpPeriodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel.ForeColor = System.Drawing.Color.Red;
            this.lbTitel.Location = new System.Drawing.Point(325, 9);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(267, 24);
            this.lbTitel.TabIndex = 2;
            this.lbTitel.Text = "Add New Subscription Periods";
            // 
            // tbSubscription
            // 
            this.tbSubscription.Controls.Add(this.tpMemberInfo);
            this.tbSubscription.Controls.Add(this.tpPeriodInfo);
            this.tbSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubscription.Location = new System.Drawing.Point(12, 68);
            this.tbSubscription.Name = "tbSubscription";
            this.tbSubscription.SelectedIndex = 0;
            this.tbSubscription.Size = new System.Drawing.Size(873, 578);
            this.tbSubscription.TabIndex = 3;
            // 
            // tpMemberInfo
            // 
            this.tpMemberInfo.Controls.Add(this.byPeriodIinfo);
            this.tpMemberInfo.Controls.Add(this.ctrlMemberinfoWithFilter1);
            this.tpMemberInfo.Location = new System.Drawing.Point(4, 27);
            this.tpMemberInfo.Name = "tpMemberInfo";
            this.tpMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemberInfo.Size = new System.Drawing.Size(865, 547);
            this.tpMemberInfo.TabIndex = 0;
            this.tpMemberInfo.Text = "Member Info";
            this.tpMemberInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlMemberinfoWithFilter1
            // 
            this.ctrlMemberinfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberinfoWithFilter1.EnableFilter = true;
            this.ctrlMemberinfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMemberinfoWithFilter1.Location = new System.Drawing.Point(7, 7);
            this.ctrlMemberinfoWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlMemberinfoWithFilter1.Name = "ctrlMemberinfoWithFilter1";
            this.ctrlMemberinfoWithFilter1.Size = new System.Drawing.Size(842, 495);
            this.ctrlMemberinfoWithFilter1.TabIndex = 0;
            this.ctrlMemberinfoWithFilter1.OnMemberSelect += new System.Action<int>(this.ctrlMemberinfoWithFilter1_OnMemberSelect);
            this.ctrlMemberinfoWithFilter1.Load += new System.EventHandler(this.ctrlMemberinfoWithFilter1_Load);
            // 
            // tpPeriodInfo
            // 
            this.tpPeriodInfo.Controls.Add(this.pictureBox5);
            this.tpPeriodInfo.Controls.Add(this.cbIspaid);
            this.tpPeriodInfo.Controls.Add(this.txtFees);
            this.tpPeriodInfo.Controls.Add(this.dtpEnddDate);
            this.tpPeriodInfo.Controls.Add(this.dtpStartDate);
            this.tpPeriodInfo.Controls.Add(this.label11);
            this.tpPeriodInfo.Controls.Add(this.label9);
            this.tpPeriodInfo.Controls.Add(this.label7);
            this.tpPeriodInfo.Controls.Add(this.lbPaymentID);
            this.tpPeriodInfo.Controls.Add(this.label5);
            this.tpPeriodInfo.Controls.Add(this.lbMembrId);
            this.tpPeriodInfo.Controls.Add(this.label3);
            this.tpPeriodInfo.Controls.Add(this.lbPeriodID);
            this.tpPeriodInfo.Controls.Add(this.label1);
            this.tpPeriodInfo.Controls.Add(this.pictureBox7);
            this.tpPeriodInfo.Controls.Add(this.pictureBox6);
            this.tpPeriodInfo.Controls.Add(this.pictureBox4);
            this.tpPeriodInfo.Controls.Add(this.pictureBox3);
            this.tpPeriodInfo.Controls.Add(this.pictureBox2);
            this.tpPeriodInfo.Location = new System.Drawing.Point(4, 27);
            this.tpPeriodInfo.Name = "tpPeriodInfo";
            this.tpPeriodInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPeriodInfo.Size = new System.Drawing.Size(865, 547);
            this.tpPeriodInfo.TabIndex = 1;
            this.tpPeriodInfo.Text = "Subscription Periods Info";
            this.tpPeriodInfo.UseVisualStyleBackColor = true;
            // 
            // cbIspaid
            // 
            this.cbIspaid.AutoSize = true;
            this.cbIspaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIspaid.Location = new System.Drawing.Point(221, 181);
            this.cbIspaid.Name = "cbIspaid";
            this.cbIspaid.Size = new System.Drawing.Size(83, 24);
            this.cbIspaid.TabIndex = 20;
            this.cbIspaid.Text = "Is Paid";
            this.cbIspaid.UseVisualStyleBackColor = true;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(629, 149);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(173, 24);
            this.txtFees.TabIndex = 19;
            this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
            // 
            // dtpEnddDate
            // 
            this.dtpEnddDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnddDate.Location = new System.Drawing.Point(629, 105);
            this.dtpEnddDate.Name = "dtpEnddDate";
            this.dtpEnddDate.Size = new System.Drawing.Size(173, 24);
            this.dtpEnddDate.TabIndex = 18;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(629, 59);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(173, 24);
            this.dtpStartDate.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(517, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Fees:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(481, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "End Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Start Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPaymentID
            // 
            this.lbPaymentID.AutoSize = true;
            this.lbPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentID.Location = new System.Drawing.Point(217, 136);
            this.lbPaymentID.Name = "lbPaymentID";
            this.lbPaymentID.Size = new System.Drawing.Size(60, 24);
            this.lbPaymentID.TabIndex = 8;
            this.lbPaymentID.Text = "[????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Payment ID:";
            // 
            // lbMembrId
            // 
            this.lbMembrId.AutoSize = true;
            this.lbMembrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMembrId.Location = new System.Drawing.Point(220, 96);
            this.lbMembrId.Name = "lbMembrId";
            this.lbMembrId.Size = new System.Drawing.Size(60, 24);
            this.lbMembrId.TabIndex = 5;
            this.lbMembrId.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Member ID:";
            // 
            // lbPeriodID
            // 
            this.lbPeriodID.AutoSize = true;
            this.lbPeriodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriodID.Location = new System.Drawing.Point(221, 56);
            this.lbPeriodID.Name = "lbPeriodID";
            this.lbPeriodID.Size = new System.Drawing.Size(60, 24);
            this.lbPeriodID.TabIndex = 2;
            this.lbPeriodID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Period ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::KarateClubProjact.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(762, 671);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(103, 33);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(468, 671);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btClose_Click);
            // 
            // byPeriodIinfo
            // 
            this.byPeriodIinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byPeriodIinfo.Image = global::KarateClubProjact.Properties.Resources.exit__1_;
            this.byPeriodIinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.byPeriodIinfo.Location = new System.Drawing.Point(746, 496);
            this.byPeriodIinfo.Name = "byPeriodIinfo";
            this.byPeriodIinfo.Size = new System.Drawing.Size(103, 45);
            this.byPeriodIinfo.TabIndex = 1;
            this.byPeriodIinfo.Text = "Next";
            this.byPeriodIinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.byPeriodIinfo.UseVisualStyleBackColor = true;
            this.byPeriodIinfo.Click += new System.EventHandler(this.byPeriodIinfo_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::KarateClubProjact.Properties.Resources.Calendar_321;
            this.pictureBox5.Location = new System.Drawing.Point(589, 62);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::KarateClubProjact.Properties.Resources.money_32___2;
            this.pictureBox7.Location = new System.Drawing.Point(589, 146);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::KarateClubProjact.Properties.Resources.Calendar_321;
            this.pictureBox6.Location = new System.Drawing.Point(589, 102);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KarateClubProjact.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(177, 136);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KarateClubProjact.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(178, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KarateClubProjact.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(179, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // frmAddUpdateSubscriptionPeriods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 716);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbSubscription);
            this.Controls.Add(this.lbTitel);
            this.Name = "frmAddUpdateSubscriptionPeriods";
            this.Text = "frmAddUpdateSubscriptionPeriods";
            this.Activated += new System.EventHandler(this.frmAddUpdateSubscriptionPeriods_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateSubscriptionPeriods_Load);
            this.tbSubscription.ResumeLayout(false);
            this.tpMemberInfo.ResumeLayout(false);
            this.tpPeriodInfo.ResumeLayout(false);
            this.tpPeriodInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.TabControl tbSubscription;
        private System.Windows.Forms.TabPage tpMemberInfo;
        private Members.ctrlMemberinfoWithFilter ctrlMemberinfoWithFilter1;
        private System.Windows.Forms.TabPage tpPeriodInfo;
        private System.Windows.Forms.Button byPeriodIinfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPaymentID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMembrId;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPeriodID;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.DateTimePicker dtpEnddDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.CheckBox cbIspaid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}