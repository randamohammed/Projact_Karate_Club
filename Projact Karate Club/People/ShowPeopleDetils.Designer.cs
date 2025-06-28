namespace KarateClubProjact
{
    partial class ShowPeopleDetils
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
            this.showPeopleInfo1 = new KarateClubProjact.ShowPeopleInfo();
            this.butClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(285, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show People Deitels";
            // 
            // showPeopleInfo1
            // 
            this.showPeopleInfo1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.showPeopleInfo1.Location = new System.Drawing.Point(3, 145);
            this.showPeopleInfo1.Name = "showPeopleInfo1";
            this.showPeopleInfo1.Size = new System.Drawing.Size(802, 231);
            this.showPeopleInfo1.TabIndex = 1;
            this.showPeopleInfo1.Load += new System.EventHandler(this.showPeopleInfo1_Load);
            // 
            // butClose
            // 
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.butClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butClose.Location = new System.Drawing.Point(348, 383);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(111, 33);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "close";
            this.butClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KarateClubProjact.Properties.Resources.human_resources;
            this.pictureBox2.Location = new System.Drawing.Point(333, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // ShowPeopleDetils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(813, 428);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.showPeopleInfo1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowPeopleDetils";
            this.ShowIcon = false;
            this.Text = "Show People Detils";
            this.Load += new System.EventHandler(this.ShowPeopleDetils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ShowPeopleInfo showPeopleInfo1;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}