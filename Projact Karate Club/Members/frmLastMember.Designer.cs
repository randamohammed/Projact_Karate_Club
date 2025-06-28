namespace KarateClubProjact
{
    partial class frmLastMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.dvMembers = new System.Windows.Forms.DataGridView();
            this.csMember = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmISActive = new System.Windows.Forms.ComboBox();
            this.cmGendere = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btAddNewMember = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMemberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvMembers)).BeginInit();
            this.csMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(463, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Members";
            // 
            // dvMembers
            // 
            this.dvMembers.AllowUserToAddRows = false;
            this.dvMembers.AllowUserToDeleteRows = false;
            this.dvMembers.AllowUserToOrderColumns = true;
            this.dvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMembers.ContextMenuStrip = this.csMember;
            this.dvMembers.Location = new System.Drawing.Point(16, 214);
            this.dvMembers.Name = "dvMembers";
            this.dvMembers.ReadOnly = true;
            this.dvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvMembers.Size = new System.Drawing.Size(950, 370);
            this.dvMembers.TabIndex = 2;
            // 
            // csMember
            // 
            this.csMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csMember.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.csMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.meToolStripMenuItem,
            this.deleteMemberToolStripMenuItem,
            this.showMemberInfoToolStripMenuItem,
            this.testHistoryToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.csMember.Name = "csMember";
            this.csMember.Size = new System.Drawing.Size(222, 256);
            this.csMember.Opening += new System.ComponentModel.CancelEventHandler(this.csMember_Opening);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "# Recorde :";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(112, 5);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(30, 24);
            this.lbRecord.TabIndex = 5;
            this.lbRecord.Text = "??";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(288, 181);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(186, 29);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cmFilter
            // 
            this.cmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFilter.FormattingEnabled = true;
            this.cmFilter.Items.AddRange(new object[] {
            "None",
            "Member ID",
            "Person ID",
            "Full Name",
            "Gender",
            "IS Active"});
            this.cmFilter.Location = new System.Drawing.Point(97, 180);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.Size = new System.Drawing.Size(185, 26);
            this.cmFilter.TabIndex = 7;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Find By:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmISActive
            // 
            this.cmISActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmISActive.FormattingEnabled = true;
            this.cmISActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmISActive.Location = new System.Drawing.Point(288, 184);
            this.cmISActive.Name = "cmISActive";
            this.cmISActive.Size = new System.Drawing.Size(130, 26);
            this.cmISActive.TabIndex = 10;
            this.cmISActive.Visible = false;
            this.cmISActive.SelectedIndexChanged += new System.EventHandler(this.cmISActive_SelectedIndexChanged);
            // 
            // cmGendere
            // 
            this.cmGendere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmGendere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmGendere.FormattingEnabled = true;
            this.cmGendere.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmGendere.Location = new System.Drawing.Point(288, 181);
            this.cmGendere.Name = "cmGendere";
            this.cmGendere.Size = new System.Drawing.Size(130, 26);
            this.cmGendere.TabIndex = 11;
            this.cmGendere.Visible = false;
            this.cmGendere.SelectedIndexChanged += new System.EventHandler(this.cmGendere_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbRecord);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(17, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 39);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Recorde ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 5);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.button1.Location = new System.Drawing.Point(912, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 43);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAddNewMember
            // 
            this.btAddNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNewMember.Image = global::KarateClubProjact.Properties.Resources.karate_add;
            this.btAddNewMember.Location = new System.Drawing.Point(873, 136);
            this.btAddNewMember.Name = "btAddNewMember";
            this.btAddNewMember.Size = new System.Drawing.Size(83, 71);
            this.btAddNewMember.TabIndex = 13;
            this.btAddNewMember.UseVisualStyleBackColor = true;
            this.btAddNewMember.Click += new System.EventHandler(this.btAddNewMember_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(846, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(97, 30);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.AddNew;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(221, 42);
            this.addToolStripMenuItem.Text = "Add Member";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // meToolStripMenuItem
            // 
            this.meToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.edit;
            this.meToolStripMenuItem.Name = "meToolStripMenuItem";
            this.meToolStripMenuItem.Size = new System.Drawing.Size(221, 42);
            this.meToolStripMenuItem.Text = "Edit Member";
            this.meToolStripMenuItem.Click += new System.EventHandler(this.meToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.Delete_32;
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(221, 42);
            this.deleteMemberToolStripMenuItem.Text = "Delete Member";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // showMemberInfoToolStripMenuItem
            // 
            this.showMemberInfoToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.MemberLast;
            this.showMemberInfoToolStripMenuItem.Name = "showMemberInfoToolStripMenuItem";
            this.showMemberInfoToolStripMenuItem.Size = new System.Drawing.Size(221, 42);
            this.showMemberInfoToolStripMenuItem.Text = "Show Member Info";
            this.showMemberInfoToolStripMenuItem.Click += new System.EventHandler(this.showMemberInfoToolStripMenuItem_Click);
            // 
            // testHistoryToolStripMenuItem
            // 
            this.testHistoryToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.TestType_32;
            this.testHistoryToolStripMenuItem.Name = "testHistoryToolStripMenuItem";
            this.testHistoryToolStripMenuItem.Size = new System.Drawing.Size(221, 42);
            this.testHistoryToolStripMenuItem.Text = "Test History";
            this.testHistoryToolStripMenuItem.Click += new System.EventHandler(this.testHistoryToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.smartphone;
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(221, 42);
            this.paymentToolStripMenuItem.Text = "Payments history";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.kung_fu;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmLastMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btAddNewMember);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmGendere);
            this.Controls.Add(this.cmISActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dvMembers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLastMember";
            this.Text = "Last Member";
            this.Load += new System.EventHandler(this.frmLastMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvMembers)).EndInit();
            this.csMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dvMembers;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cmFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmGendere;
        private System.Windows.Forms.ComboBox cmISActive;
        private System.Windows.Forms.ContextMenuStrip csMember;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMemberInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAddNewMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}