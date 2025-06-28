namespace KarateClubProjact.Subscription_Periods
{
    partial class frmListSubscriptionPeriods
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
            this.dvSubscriptionPeriods = new System.Windows.Forms.DataGridView();
            this.cmPeriods = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditSubscriptionPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteSubscriptionPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBaySubscriptionPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPerioedHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.lbRecordes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmFindBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmIsPaid = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvSubscriptionPeriods)).BeginInit();
            this.cmPeriods.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvSubscriptionPeriods
            // 
            this.dvSubscriptionPeriods.AllowUserToAddRows = false;
            this.dvSubscriptionPeriods.AllowUserToDeleteRows = false;
            this.dvSubscriptionPeriods.AllowUserToOrderColumns = true;
            this.dvSubscriptionPeriods.BackgroundColor = System.Drawing.Color.White;
            this.dvSubscriptionPeriods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSubscriptionPeriods.ContextMenuStrip = this.cmPeriods;
            this.dvSubscriptionPeriods.Location = new System.Drawing.Point(12, 187);
            this.dvSubscriptionPeriods.Name = "dvSubscriptionPeriods";
            this.dvSubscriptionPeriods.ReadOnly = true;
            this.dvSubscriptionPeriods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvSubscriptionPeriods.Size = new System.Drawing.Size(884, 394);
            this.dvSubscriptionPeriods.TabIndex = 0;
            this.dvSubscriptionPeriods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvSubscriptionPeriods_CellContentClick);
            // 
            // cmPeriods
            // 
            this.cmPeriods.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.cmPeriods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.tsmEditSubscriptionPeriod,
            this.tsmDeleteSubscriptionPeriod,
            this.tsmBaySubscriptionPeriod,
            this.tsmShowPerioedHistory});
            this.cmPeriods.Name = "contextMenuStrip1";
            this.cmPeriods.Size = new System.Drawing.Size(232, 204);
            this.cmPeriods.Opening += new System.ComponentModel.CancelEventHandler(this.cmPeriods_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.schedule;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(231, 40);
            this.addToolStripMenuItem.Text = "Add Subscription Period";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // tsmEditSubscriptionPeriod
            // 
            this.tsmEditSubscriptionPeriod.Image = global::KarateClubProjact.Properties.Resources.edit;
            this.tsmEditSubscriptionPeriod.Name = "tsmEditSubscriptionPeriod";
            this.tsmEditSubscriptionPeriod.Size = new System.Drawing.Size(231, 40);
            this.tsmEditSubscriptionPeriod.Text = "Edit Subscription Period";
            this.tsmEditSubscriptionPeriod.Click += new System.EventHandler(this.tsmEditSubscriptionPeriod_Click);
            // 
            // tsmDeleteSubscriptionPeriod
            // 
            this.tsmDeleteSubscriptionPeriod.Image = global::KarateClubProjact.Properties.Resources.Delete_32;
            this.tsmDeleteSubscriptionPeriod.Name = "tsmDeleteSubscriptionPeriod";
            this.tsmDeleteSubscriptionPeriod.Size = new System.Drawing.Size(231, 40);
            this.tsmDeleteSubscriptionPeriod.Text = "Delete Subscription Period";
            this.tsmDeleteSubscriptionPeriod.Click += new System.EventHandler(this.tsmDeleteSubscriptionPeriod_Click);
            // 
            // tsmBaySubscriptionPeriod
            // 
            this.tsmBaySubscriptionPeriod.Image = global::KarateClubProjact.Properties.Resources.money;
            this.tsmBaySubscriptionPeriod.Name = "tsmBaySubscriptionPeriod";
            this.tsmBaySubscriptionPeriod.Size = new System.Drawing.Size(231, 40);
            this.tsmBaySubscriptionPeriod.Text = "Bay";
            this.tsmBaySubscriptionPeriod.Click += new System.EventHandler(this.tsmBaySubscriptionPeriod_Click);
            // 
            // tsmShowPerioedHistory
            // 
            this.tsmShowPerioedHistory.Image = global::KarateClubProjact.Properties.Resources.contact_page;
            this.tsmShowPerioedHistory.Name = "tsmShowPerioedHistory";
            this.tsmShowPerioedHistory.Size = new System.Drawing.Size(231, 40);
            this.tsmShowPerioedHistory.Text = "Show Period History";
            this.tsmShowPerioedHistory.Click += new System.EventHandler(this.tsmShowPerioedHistory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.lbRecordes);
            this.panel1.Location = new System.Drawing.Point(12, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 42);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "# Recordes :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Recorde ";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(771, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(102, 34);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbRecordes
            // 
            this.lbRecordes.AutoSize = true;
            this.lbRecordes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordes.Location = new System.Drawing.Point(122, 8);
            this.lbRecordes.Name = "lbRecordes";
            this.lbRecordes.Size = new System.Drawing.Size(30, 24);
            this.lbRecordes.TabIndex = 4;
            this.lbRecordes.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find By:";
            // 
            // cmFindBy
            // 
            this.cmFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFindBy.FormattingEnabled = true;
            this.cmFindBy.Items.AddRange(new object[] {
            "None",
            "Period ID",
            "Member name",
            "is Paid"});
            this.cmFindBy.Location = new System.Drawing.Point(97, 145);
            this.cmFindBy.Name = "cmFindBy";
            this.cmFindBy.Size = new System.Drawing.Size(150, 26);
            this.cmFindBy.TabIndex = 3;
            this.cmFindBy.SelectedIndexChanged += new System.EventHandler(this.cmFindBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(253, 147);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(200, 24);
            this.txtFilterValue.TabIndex = 4;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(355, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "List Subscription Periods";
            // 
            // cmIsPaid
            // 
            this.cmIsPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmIsPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmIsPaid.FormattingEnabled = true;
            this.cmIsPaid.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmIsPaid.Location = new System.Drawing.Point(253, 147);
            this.cmIsPaid.Name = "cmIsPaid";
            this.cmIsPaid.Size = new System.Drawing.Size(128, 26);
            this.cmIsPaid.TabIndex = 8;
            this.cmIsPaid.Visible = false;
            this.cmIsPaid.SelectedIndexChanged += new System.EventHandler(this.cmIsPaid_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(5, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 5);
            this.panel2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.button1.Location = new System.Drawing.Point(842, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 34);
            this.button1.TabIndex = 19;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KarateClubProjact.Properties.Resources.schedule;
            this.pictureBox2.Location = new System.Drawing.Point(34, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btAddNew
            // 
            this.btAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNew.Image = global::KarateClubProjact.Properties.Resources.add_user;
            this.btAddNew.Location = new System.Drawing.Point(826, 135);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(70, 51);
            this.btAddNew.TabIndex = 5;
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // frmListSubscriptionPeriods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmIsPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cmFindBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvSubscriptionPeriods);
            this.Name = "frmListSubscriptionPeriods";
            this.Text = "List Subscription Periods";
            this.Load += new System.EventHandler(this.frmListSubscriptionPeriods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvSubscriptionPeriods)).EndInit();
            this.cmPeriods.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvSubscriptionPeriods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmFindBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbRecordes;
        private System.Windows.Forms.ComboBox cmIsPaid;
        private System.Windows.Forms.ContextMenuStrip cmPeriods;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEditSubscriptionPeriod;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteSubscriptionPeriod;
        private System.Windows.Forms.ToolStripMenuItem tsmBaySubscriptionPeriod;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPerioedHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}