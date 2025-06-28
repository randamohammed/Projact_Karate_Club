namespace KarateClubProjact.MemberInstructor
{
    partial class frmAddUpdateMemberInstructor
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
            this.llShowTrainedMemberbyInstructor = new System.Windows.Forms.LinkLabel();
            this.tpTestInfo = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTrainedDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAsseingDate = new System.Windows.Forms.DateTimePicker();
            this.lbMemberinstructorID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpInstructorsInfo = new System.Windows.Forms.TabPage();
            this.ctrlShowInstructorscardWithFilter1 = new KarateClubProjact.Instructors.ctrlShowInstructorscardWithFilter();
            this.tpMemberinfo = new System.Windows.Forms.TabPage();
            this.ctrlMemberinfoWithFilter1 = new KarateClubProjact.Members.ctrlMemberinfoWithFilter();
            this.tpMemberiinstructInfo = new System.Windows.Forms.TabControl();
            this.lbtitel = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tpTestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpInstructorsInfo.SuspendLayout();
            this.tpMemberinfo.SuspendLayout();
            this.tpMemberiinstructInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // llShowTrainedMemberbyInstructor
            // 
            this.llShowTrainedMemberbyInstructor.AutoSize = true;
            this.llShowTrainedMemberbyInstructor.Enabled = false;
            this.llShowTrainedMemberbyInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowTrainedMemberbyInstructor.Location = new System.Drawing.Point(15, 629);
            this.llShowTrainedMemberbyInstructor.Name = "llShowTrainedMemberbyInstructor";
            this.llShowTrainedMemberbyInstructor.Size = new System.Drawing.Size(328, 20);
            this.llShowTrainedMemberbyInstructor.TabIndex = 2;
            this.llShowTrainedMemberbyInstructor.TabStop = true;
            this.llShowTrainedMemberbyInstructor.Text = "Show Trained Members By this Instructor List";
            this.llShowTrainedMemberbyInstructor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowTrainedMemberbyInstructor_LinkClicked);
            // 
            // tpTestInfo
            // 
            this.tpTestInfo.Controls.Add(this.pictureBox3);
            this.tpTestInfo.Controls.Add(this.label2);
            this.tpTestInfo.Controls.Add(this.dtpTrainedDate);
            this.tpTestInfo.Controls.Add(this.label3);
            this.tpTestInfo.Controls.Add(this.dtpAsseingDate);
            this.tpTestInfo.Controls.Add(this.lbMemberinstructorID);
            this.tpTestInfo.Controls.Add(this.label1);
            this.tpTestInfo.Controls.Add(this.pictureBox2);
            this.tpTestInfo.Controls.Add(this.pictureBox1);
            this.tpTestInfo.Location = new System.Drawing.Point(4, 29);
            this.tpTestInfo.Name = "tpTestInfo";
            this.tpTestInfo.Size = new System.Drawing.Size(892, 528);
            this.tpTestInfo.TabIndex = 2;
            this.tpTestInfo.Text = "Test info";
            this.tpTestInfo.UseVisualStyleBackColor = true;
            this.tpTestInfo.Click += new System.EventHandler(this.tpTestInfo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KarateClubProjact.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(215, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trained  Date:";
            // 
            // dtpTrainedDate
            // 
            this.dtpTrainedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTrainedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTrainedDate.Location = new System.Drawing.Point(261, 135);
            this.dtpTrainedDate.Name = "dtpTrainedDate";
            this.dtpTrainedDate.Size = new System.Drawing.Size(166, 24);
            this.dtpTrainedDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asseing  Date:";
            // 
            // dtpAsseingDate
            // 
            this.dtpAsseingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAsseingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAsseingDate.Location = new System.Drawing.Point(261, 95);
            this.dtpAsseingDate.Name = "dtpAsseingDate";
            this.dtpAsseingDate.Size = new System.Drawing.Size(166, 24);
            this.dtpAsseingDate.TabIndex = 2;
            // 
            // lbMemberinstructorID
            // 
            this.lbMemberinstructorID.AutoSize = true;
            this.lbMemberinstructorID.Location = new System.Drawing.Point(257, 48);
            this.lbMemberinstructorID.Name = "lbMemberinstructorID";
            this.lbMemberinstructorID.Size = new System.Drawing.Size(44, 20);
            this.lbMemberinstructorID.TabIndex = 1;
            this.lbMemberinstructorID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member_Instructor ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KarateClubProjact.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(215, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(215, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tpInstructorsInfo
            // 
            this.tpInstructorsInfo.Controls.Add(this.ctrlShowInstructorscardWithFilter1);
            this.tpInstructorsInfo.Location = new System.Drawing.Point(4, 29);
            this.tpInstructorsInfo.Name = "tpInstructorsInfo";
            this.tpInstructorsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInstructorsInfo.Size = new System.Drawing.Size(892, 528);
            this.tpInstructorsInfo.TabIndex = 1;
            this.tpInstructorsInfo.Text = "Instructors Info";
            this.tpInstructorsInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlShowInstructorscardWithFilter1
            // 
            this.ctrlShowInstructorscardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlShowInstructorscardWithFilter1.FilterEnable = true;
            this.ctrlShowInstructorscardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShowInstructorscardWithFilter1.Location = new System.Drawing.Point(4, 4);
            this.ctrlShowInstructorscardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlShowInstructorscardWithFilter1.Name = "ctrlShowInstructorscardWithFilter1";
            this.ctrlShowInstructorscardWithFilter1.Size = new System.Drawing.Size(882, 511);
            this.ctrlShowInstructorscardWithFilter1.TabIndex = 0;
            this.ctrlShowInstructorscardWithFilter1.OninstructorsSelect += new System.Action<int>(this.ctrlShowInstructorscardWithFilter1_OninstructorsSelect);
            // 
            // tpMemberinfo
            // 
            this.tpMemberinfo.Controls.Add(this.ctrlMemberinfoWithFilter1);
            this.tpMemberinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpMemberinfo.Location = new System.Drawing.Point(4, 29);
            this.tpMemberinfo.Name = "tpMemberinfo";
            this.tpMemberinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemberinfo.Size = new System.Drawing.Size(892, 528);
            this.tpMemberinfo.TabIndex = 0;
            this.tpMemberinfo.Text = "Member Info";
            this.tpMemberinfo.UseVisualStyleBackColor = true;
            // 
            // ctrlMemberinfoWithFilter1
            // 
            this.ctrlMemberinfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberinfoWithFilter1.EnableFilter = true;
            this.ctrlMemberinfoWithFilter1.Location = new System.Drawing.Point(4, 8);
            this.ctrlMemberinfoWithFilter1.Name = "ctrlMemberinfoWithFilter1";
            this.ctrlMemberinfoWithFilter1.Size = new System.Drawing.Size(882, 511);
            this.ctrlMemberinfoWithFilter1.TabIndex = 0;
            this.ctrlMemberinfoWithFilter1.OnMemberSelect += new System.Action<int>(this.ctrlMemberinfoWithFilter1_OnMemberSelect);
            // 
            // tpMemberiinstructInfo
            // 
            this.tpMemberiinstructInfo.Controls.Add(this.tpMemberinfo);
            this.tpMemberiinstructInfo.Controls.Add(this.tpInstructorsInfo);
            this.tpMemberiinstructInfo.Controls.Add(this.tpTestInfo);
            this.tpMemberiinstructInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpMemberiinstructInfo.Location = new System.Drawing.Point(12, 55);
            this.tpMemberiinstructInfo.Name = "tpMemberiinstructInfo";
            this.tpMemberiinstructInfo.SelectedIndex = 0;
            this.tpMemberiinstructInfo.Size = new System.Drawing.Size(900, 561);
            this.tpMemberiinstructInfo.TabIndex = 0;
            // 
            // lbtitel
            // 
            this.lbtitel.AutoSize = true;
            this.lbtitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitel.ForeColor = System.Drawing.Color.Red;
            this.lbtitel.Location = new System.Drawing.Point(331, 9);
            this.lbtitel.Name = "lbtitel";
            this.lbtitel.Size = new System.Drawing.Size(276, 24);
            this.lbtitel.TabIndex = 1;
            this.lbtitel.Text = "Add New Member_Instructor";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.Save_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(579, 622);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(94, 34);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::KarateClubProjact.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(807, 622);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 34);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmAddUpdateMemberInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 668);
            this.Controls.Add(this.lbtitel);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.llShowTrainedMemberbyInstructor);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tpMemberiinstructInfo);
            this.Name = "frmAddUpdateMemberInstructor";
            this.Text = "frmAddUpdateMemberInstructor";
            this.Load += new System.EventHandler(this.frmAddUpdateMemberInstructor_Load);
            this.tpTestInfo.ResumeLayout(false);
            this.tpTestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpInstructorsInfo.ResumeLayout(false);
            this.tpMemberinfo.ResumeLayout(false);
            this.tpMemberiinstructInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.LinkLabel llShowTrainedMemberbyInstructor;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TabPage tpTestInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAsseingDate;
        private System.Windows.Forms.Label lbMemberinstructorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpInstructorsInfo;
        private Instructors.ctrlShowInstructorscardWithFilter ctrlShowInstructorscardWithFilter1;
        private System.Windows.Forms.TabPage tpMemberinfo;
        private Members.ctrlMemberinfoWithFilter ctrlMemberinfoWithFilter1;
        private System.Windows.Forms.TabControl tpMemberiinstructInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTrainedDate;
        private System.Windows.Forms.Label lbtitel;
    }
}