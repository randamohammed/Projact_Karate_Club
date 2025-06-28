namespace KarateClubProjact
{
    partial class frmShowinstructorsInfo
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
            this.btClose = new System.Windows.Forms.Button();
            this.cltrShowInstructorsCard1 = new KarateClubProjact.cltrShowInstructorsCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(335, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "instructors Details";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(718, 435);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(107, 37);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // cltrShowInstructorsCard1
            // 
            this.cltrShowInstructorsCard1.BackColor = System.Drawing.Color.White;
            this.cltrShowInstructorsCard1.Location = new System.Drawing.Point(5, 80);
            this.cltrShowInstructorsCard1.Name = "cltrShowInstructorsCard1";
            this.cltrShowInstructorsCard1.Size = new System.Drawing.Size(827, 379);
            this.cltrShowInstructorsCard1.TabIndex = 1;
            // 
            // frmShowinstructorsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 482);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.cltrShowInstructorsCard1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowinstructorsInfo";
            this.Text = "frmShowinstructorsInfo";
            this.Load += new System.EventHandler(this.frmShowinstructorsInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private cltrShowInstructorsCard cltrShowInstructorsCard1;
        private System.Windows.Forms.Button btClose;
    }
}