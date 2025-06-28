namespace KarateClubProjact
{
    partial class cltrShowInstructorsCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbInstructorsID = new System.Windows.Forms.Label();
            this.lbQualification = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showPeopleInfo1 = new KarateClubProjact.ShowPeopleInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(825, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instructors Info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instructors ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(146, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbInstructorsID
            // 
            this.lbInstructorsID.AutoSize = true;
            this.lbInstructorsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructorsID.Location = new System.Drawing.Point(188, 303);
            this.lbInstructorsID.Name = "lbInstructorsID";
            this.lbInstructorsID.Size = new System.Drawing.Size(50, 24);
            this.lbInstructorsID.TabIndex = 4;
            this.lbInstructorsID.Text = "[???]";
            // 
            // lbQualification
            // 
            this.lbQualification.AutoSize = true;
            this.lbQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQualification.Location = new System.Drawing.Point(576, 302);
            this.lbQualification.Name = "lbQualification";
            this.lbQualification.Size = new System.Drawing.Size(50, 24);
            this.lbQualification.TabIndex = 7;
            this.lbQualification.Text = "[???]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KarateClubProjact.Properties.Resources.contact_page;
            this.pictureBox2.Location = new System.Drawing.Point(538, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qualification:";
            // 
            // showPeopleInfo1
            // 
            this.showPeopleInfo1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.showPeopleInfo1.Location = new System.Drawing.Point(5, 3);
            this.showPeopleInfo1.Name = "showPeopleInfo1";
            this.showPeopleInfo1.Size = new System.Drawing.Size(825, 242);
            this.showPeopleInfo1.TabIndex = 0;
            // 
            // cltrShowInstructorsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbQualification);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbInstructorsID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPeopleInfo1);
            this.Name = "cltrShowInstructorsCard";
            this.Size = new System.Drawing.Size(836, 379);
            this.Load += new System.EventHandler(this.cltrShowInstructorsCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShowPeopleInfo showPeopleInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbInstructorsID;
        private System.Windows.Forms.Label lbQualification;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}
