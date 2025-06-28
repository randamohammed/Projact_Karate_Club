namespace KarateClubProjact.MemberInstructor
{
    partial class frmLastMemberInstructor
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgMemberInstructor = new System.Windows.Forms.DataGridView();
            this.cmTrainedt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.memberInstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMemberInstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberInstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTrainedMembersByThisInstructorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmFindBy = new System.Windows.Forms.ComboBox();
            this.txtFiltrValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btAddNewMemberInstructor = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberInstructor)).BeginInit();
            this.cmTrainedt.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(429, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(301, 28);
            this.lbTitle.TabIndex = 24;
            this.lbTitle.Text = "List Instructor_ Member";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 3);
            this.panel1.TabIndex = 23;
            // 
            // dgMemberInstructor
            // 
            this.dgMemberInstructor.AllowUserToAddRows = false;
            this.dgMemberInstructor.AllowUserToDeleteRows = false;
            this.dgMemberInstructor.AllowUserToOrderColumns = true;
            this.dgMemberInstructor.BackgroundColor = System.Drawing.Color.White;
            this.dgMemberInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemberInstructor.ContextMenuStrip = this.cmTrainedt;
            this.dgMemberInstructor.Location = new System.Drawing.Point(6, 179);
            this.dgMemberInstructor.Name = "dgMemberInstructor";
            this.dgMemberInstructor.ReadOnly = true;
            this.dgMemberInstructor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMemberInstructor.Size = new System.Drawing.Size(1156, 385);
            this.dgMemberInstructor.TabIndex = 26;
            // 
            // cmTrainedt
            // 
            this.cmTrainedt.AutoSize = false;
            this.cmTrainedt.BackColor = System.Drawing.Color.White;
            this.cmTrainedt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmTrainedt.ImageScalingSize = new System.Drawing.Size(33, 33);
            this.cmTrainedt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberInstructorsToolStripMenuItem,
            this.editMemberInstructorsToolStripMenuItem,
            this.deleteMemberInstructorsToolStripMenuItem,
            this.showTrainedMembersByThisInstructorListToolStripMenuItem});
            this.cmTrainedt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.cmTrainedt.Name = "cmTrainedt";
            this.cmTrainedt.Size = new System.Drawing.Size(411, 186);
            // 
            // memberInstructorsToolStripMenuItem
            // 
            this.memberInstructorsToolStripMenuItem.AutoSize = false;
            this.memberInstructorsToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.AddNew;
            this.memberInstructorsToolStripMenuItem.Name = "memberInstructorsToolStripMenuItem";
            this.memberInstructorsToolStripMenuItem.Size = new System.Drawing.Size(410, 40);
            this.memberInstructorsToolStripMenuItem.Text = "Add Member_Instructors";
            this.memberInstructorsToolStripMenuItem.Click += new System.EventHandler(this.memberInstructorsToolStripMenuItem_Click);
            // 
            // editMemberInstructorsToolStripMenuItem
            // 
            this.editMemberInstructorsToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.edit;
            this.editMemberInstructorsToolStripMenuItem.Name = "editMemberInstructorsToolStripMenuItem";
            this.editMemberInstructorsToolStripMenuItem.Size = new System.Drawing.Size(410, 40);
            this.editMemberInstructorsToolStripMenuItem.Text = "Edit Membe_rInstructors";
            this.editMemberInstructorsToolStripMenuItem.Click += new System.EventHandler(this.editMemberInstructorsToolStripMenuItem_Click);
            // 
            // deleteMemberInstructorsToolStripMenuItem
            // 
            this.deleteMemberInstructorsToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.Delete_32;
            this.deleteMemberInstructorsToolStripMenuItem.Name = "deleteMemberInstructorsToolStripMenuItem";
            this.deleteMemberInstructorsToolStripMenuItem.Size = new System.Drawing.Size(410, 40);
            this.deleteMemberInstructorsToolStripMenuItem.Text = "Delete MemberI_nstructors";
            this.deleteMemberInstructorsToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberInstructorsToolStripMenuItem_Click);
            // 
            // showTrainedMembersByThisInstructorListToolStripMenuItem
            // 
            this.showTrainedMembersByThisInstructorListToolStripMenuItem.AutoSize = false;
            this.showTrainedMembersByThisInstructorListToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.List_32;
            this.showTrainedMembersByThisInstructorListToolStripMenuItem.Name = "showTrainedMembersByThisInstructorListToolStripMenuItem";
            this.showTrainedMembersByThisInstructorListToolStripMenuItem.Size = new System.Drawing.Size(410, 40);
            this.showTrainedMembersByThisInstructorListToolStripMenuItem.Text = "Show Trained Members By this Instructor List";
            this.showTrainedMembersByThisInstructorListToolStripMenuItem.Click += new System.EventHandler(this.showTrainedMembersByThisInstructorListToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbRecord);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(6, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 43);
            this.panel2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Recorde ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "# Recordes :";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(412, 6);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(40, 24);
            this.lbRecord.TabIndex = 5;
            this.lbRecord.Text = "???";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(1030, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(112, 37);
            this.btClose.TabIndex = 28;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Find By:";
            // 
            // cmFindBy
            // 
            this.cmFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFindBy.FormattingEnabled = true;
            this.cmFindBy.Items.AddRange(new object[] {
            "None",
            "MemberInstructor ID",
            "Instructor Name",
            "Member Name",
            "Member Rnke"});
            this.cmFindBy.Location = new System.Drawing.Point(105, 146);
            this.cmFindBy.Name = "cmFindBy";
            this.cmFindBy.Size = new System.Drawing.Size(181, 26);
            this.cmFindBy.TabIndex = 30;
            this.cmFindBy.SelectedIndexChanged += new System.EventHandler(this.cmFindBy_SelectedIndexChanged);
            // 
            // txtFiltrValue
            // 
            this.txtFiltrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrValue.Location = new System.Drawing.Point(295, 148);
            this.txtFiltrValue.Name = "txtFiltrValue";
            this.txtFiltrValue.Size = new System.Drawing.Size(185, 24);
            this.txtFiltrValue.TabIndex = 31;
            this.txtFiltrValue.Visible = false;
            this.txtFiltrValue.TextChanged += new System.EventHandler(this.txtFiltrValues_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1100, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 47);
            this.button1.TabIndex = 33;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAddNewMemberInstructor
            // 
            this.btAddNewMemberInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNewMemberInstructor.Image = global::KarateClubProjact.Properties.Resources.invite_friends;
            this.btAddNewMemberInstructor.Location = new System.Drawing.Point(1086, 119);
            this.btAddNewMemberInstructor.Name = "btAddNewMemberInstructor";
            this.btAddNewMemberInstructor.Size = new System.Drawing.Size(76, 49);
            this.btAddNewMemberInstructor.TabIndex = 32;
            this.btAddNewMemberInstructor.UseVisualStyleBackColor = true;
            this.btAddNewMemberInstructor.Click += new System.EventHandler(this.btAddNewMemberInstructor_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KarateClubProjact.Properties.Resources.judo__1_;
            this.pictureBox4.Location = new System.Drawing.Point(24, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // frmLastMemberInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 649);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAddNewMemberInstructor);
            this.Controls.Add(this.txtFiltrValue);
            this.Controls.Add(this.cmFindBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgMemberInstructor);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLastMemberInstructor";
            this.Text = "List Member Instructor";
            this.Load += new System.EventHandler(this.frmLastMemberInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberInstructor)).EndInit();
            this.cmTrainedt.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgMemberInstructor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmFindBy;
        private System.Windows.Forms.TextBox txtFiltrValue;
        private System.Windows.Forms.Button btAddNewMemberInstructor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmTrainedt;
        private System.Windows.Forms.ToolStripMenuItem memberInstructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMemberInstructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberInstructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTrainedMembersByThisInstructorListToolStripMenuItem;
    }
}