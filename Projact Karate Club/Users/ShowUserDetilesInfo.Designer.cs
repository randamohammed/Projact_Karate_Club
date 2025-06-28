namespace KarateClubProjact
{
    partial class ShowUserDetilesInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUserDetilesInfo));
            this.butClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.showUserInfo1 = new KarateClubProjact.ShowUserInfo();
            this.SuspendLayout();
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.White;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.butClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butClose.Location = new System.Drawing.Point(678, 451);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(103, 42);
            this.butClose.TabIndex = 1;
            this.butClose.Text = "     Close";
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close - Copy.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show User Info";
            // 
            // showUserInfo1
            // 
            this.showUserInfo1.Location = new System.Drawing.Point(1, 46);
            this.showUserInfo1.Name = "showUserInfo1";
            this.showUserInfo1.Size = new System.Drawing.Size(813, 373);
            this.showUserInfo1.TabIndex = 0;
            this.showUserInfo1.Load += new System.EventHandler(this.showUserInfo1_Load);
            // 
            // ShowUserDetilesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(813, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.showUserInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowUserDetilesInfo";
            this.ShowIcon = false;
            this.Text = "ShowUserDetilesInfo";
            this.Load += new System.EventHandler(this.ShowUserDetilesInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShowUserInfo showUserInfo1;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}