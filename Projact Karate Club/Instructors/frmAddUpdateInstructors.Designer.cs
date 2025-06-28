namespace KarateClubProjact
{
    partial class frmAddUpdateInstructors
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
            this.label1 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.lbInstructorsID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCardWithFilter1 = new KarateClubProjact.CtrlPersonCardWithFilter();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(344, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(188, 24);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Add New Instructor";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instructor Info:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(12, 454);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(120, 20);
            this.lable.TabIndex = 3;
            this.lable.Text = "InstructorsID:";
            // 
            // lbInstructorsID
            // 
            this.lbInstructorsID.AutoSize = true;
            this.lbInstructorsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructorsID.Location = new System.Drawing.Point(175, 454);
            this.lbInstructorsID.Name = "lbInstructorsID";
            this.lbInstructorsID.Size = new System.Drawing.Size(38, 20);
            this.lbInstructorsID.TabIndex = 4;
            this.lbInstructorsID.Text = "A/N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Qualification:";
            // 
            // txtQualification
            // 
            this.txtQualification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQualification.Location = new System.Drawing.Point(499, 449);
            this.txtQualification.Multiline = true;
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(194, 31);
            this.txtQualification.TabIndex = 7;
            this.txtQualification.Validating += new System.ComponentModel.CancelEventHandler(this.txtQualification_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ctrlPersonCardWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlPersonCardWithFilter1.EnableFilter = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(4, 64);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(841, 345);
            this.ctrlPersonCardWithFilter1.TabIndex = 1;
            this.ctrlPersonCardWithFilter1.BackPersonID += new KarateClubProjact.CtrlPersonCardWithFilter.OpnersonSelet(this.ctrlPersonCardWithFilter1_BackPersonID);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(348, 515);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(98, 32);
            this.btClose.TabIndex = 10;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::KarateClubProjact.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(730, 515);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(98, 32);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::KarateClubProjact.Properties.Resources.contact_page1;
            this.pictureBox2.Location = new System.Drawing.Point(459, 454);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(137, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddUpdateInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 555);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbInstructorsID);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmAddUpdateInstructors";
            this.Text = "frmAddUpdateInstructors";
            this.Load += new System.EventHandler(this.frmAddUpdateInstructors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private CtrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lbInstructorsID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}