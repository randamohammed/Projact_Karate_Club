namespace KarateClubProjact
{
    partial class frmAddAndUpdateNewPeople
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
            this.labMode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labPeopleID = new System.Windows.Forms.Label();
            this.addOrUpdatePeople1 = new KarateClubProjact.AddOrUpdatePeople();
            this.buClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labMode
            // 
            this.labMode.AutoSize = true;
            this.labMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labMode.Location = new System.Drawing.Point(375, 118);
            this.labMode.Name = "labMode";
            this.labMode.Size = new System.Drawing.Size(154, 24);
            this.labMode.TabIndex = 0;
            this.labMode.Text = "Add New People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "People ID";
            // 
            // labPeopleID
            // 
            this.labPeopleID.AutoSize = true;
            this.labPeopleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPeopleID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labPeopleID.Location = new System.Drawing.Point(124, 139);
            this.labPeopleID.Name = "labPeopleID";
            this.labPeopleID.Size = new System.Drawing.Size(45, 18);
            this.labPeopleID.TabIndex = 2;
            this.labPeopleID.Text = "[###]";
            // 
            // addOrUpdatePeople1
            // 
            this.addOrUpdatePeople1.Location = new System.Drawing.Point(2, 160);
            this.addOrUpdatePeople1.Name = "addOrUpdatePeople1";
            this.addOrUpdatePeople1.Size = new System.Drawing.Size(919, 302);
            this.addOrUpdatePeople1.TabIndex = 4;
            this.addOrUpdatePeople1.GetPersonID += new System.Action<int>(this.addOrUpdatePeople1_GetPersonID);
            // 
            // buClose
            // 
            this.buClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buClose.Location = new System.Drawing.Point(374, 427);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(98, 35);
            this.buClose.TabIndex = 5;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.Add;
            this.pictureBox1.Location = new System.Drawing.Point(374, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddAndUpdateNewPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.addOrUpdatePeople1);
            this.Controls.Add(this.labPeopleID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labMode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndUpdateNewPeople";
            this.ShowIcon = false;
            this.Text = "Add And Update People";
            this.Load += new System.EventHandler(this.AddAndUpdateNewPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPeopleID;
        private AddOrUpdatePeople addOrUpdatePeople1;
        private System.Windows.Forms.Button buClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}