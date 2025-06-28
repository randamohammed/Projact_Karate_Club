namespace KarateClubProjact
{
    partial class frmLastBeltRank
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
            this.dvBeltRank = new System.Windows.Forms.DataGridView();
            this.cmBeltRank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecorde = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.editRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvBeltRank)).BeginInit();
            this.cmBeltRank.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(192, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Belt Ranks";
            // 
            // dvBeltRank
            // 
            this.dvBeltRank.AllowUserToAddRows = false;
            this.dvBeltRank.AllowUserToDeleteRows = false;
            this.dvBeltRank.AllowUserToOrderColumns = true;
            this.dvBeltRank.BackgroundColor = System.Drawing.Color.White;
            this.dvBeltRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBeltRank.ContextMenuStrip = this.cmBeltRank;
            this.dvBeltRank.Location = new System.Drawing.Point(12, 145);
            this.dvBeltRank.Name = "dvBeltRank";
            this.dvBeltRank.ReadOnly = true;
            this.dvBeltRank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBeltRank.Size = new System.Drawing.Size(470, 441);
            this.dvBeltRank.TabIndex = 2;
            // 
            // cmBeltRank
            // 
            this.cmBeltRank.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBeltRank.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cmBeltRank.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRankToolStripMenuItem});
            this.cmBeltRank.Name = "contextMenuStrip1";
            this.cmBeltRank.Size = new System.Drawing.Size(160, 46);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "# Recordes:";
            // 
            // lbRecorde
            // 
            this.lbRecorde.AutoSize = true;
            this.lbRecorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecorde.Location = new System.Drawing.Point(121, 12);
            this.lbRecorde.Name = "lbRecorde";
            this.lbRecorde.Size = new System.Drawing.Size(40, 24);
            this.lbRecorde.TabIndex = 6;
            this.lbRecorde.Text = "???";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.lbRecorde);
            this.panel1.Location = new System.Drawing.Point(12, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 46);
            this.panel1.TabIndex = 7;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(383, 6);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(89, 36);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // editRankToolStripMenuItem
            // 
            this.editRankToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.edit;
            this.editRankToolStripMenuItem.Name = "editRankToolStripMenuItem";
            this.editRankToolStripMenuItem.Size = new System.Drawing.Size(159, 42);
            this.editRankToolStripMenuItem.Text = "Edit Rank";
            this.editRankToolStripMenuItem.Click += new System.EventHandler(this.editRankToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.belt1;
            this.pictureBox1.Location = new System.Drawing.Point(196, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmLastBeltRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvBeltRank);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmLastBeltRank";
            this.Text = "Belt Rank";
            this.Load += new System.EventHandler(this.frmLastBeltRank_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvBeltRank)).EndInit();
            this.cmBeltRank.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dvBeltRank;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ContextMenuStrip cmBeltRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecorde;
        private System.Windows.Forms.ToolStripMenuItem editRankToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}