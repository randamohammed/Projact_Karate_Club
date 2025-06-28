namespace KarateClubProjact.Instructors
{
    partial class frmShowTrainedMemberbyInstructor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dglMemberInstructor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecordes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cltrShowInstructorsCard1 = new KarateClubProjact.cltrShowInstructorsCard();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglMemberInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dglMemberInstructor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History:";
            // 
            // dglMemberInstructor
            // 
            this.dglMemberInstructor.AllowUserToAddRows = false;
            this.dglMemberInstructor.AllowUserToDeleteRows = false;
            this.dglMemberInstructor.AllowUserToOrderColumns = true;
            this.dglMemberInstructor.BackgroundColor = System.Drawing.Color.White;
            this.dglMemberInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglMemberInstructor.Location = new System.Drawing.Point(6, 22);
            this.dglMemberInstructor.Name = "dglMemberInstructor";
            this.dglMemberInstructor.ReadOnly = true;
            this.dglMemberInstructor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dglMemberInstructor.Size = new System.Drawing.Size(808, 135);
            this.dglMemberInstructor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "# Recordes:";
            // 
            // lbRecordes
            // 
            this.lbRecordes.AutoSize = true;
            this.lbRecordes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordes.Location = new System.Drawing.Point(124, 600);
            this.lbRecordes.Name = "lbRecordes";
            this.lbRecordes.Size = new System.Drawing.Size(39, 20);
            this.lbRecordes.TabIndex = 4;
            this.lbRecordes.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(271, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trained Members By Instructor ";
            // 
            // cltrShowInstructorsCard1
            // 
            this.cltrShowInstructorsCard1.BackColor = System.Drawing.Color.White;
            this.cltrShowInstructorsCard1.Location = new System.Drawing.Point(7, 63);
            this.cltrShowInstructorsCard1.Name = "cltrShowInstructorsCard1";
            this.cltrShowInstructorsCard1.Size = new System.Drawing.Size(836, 354);
            this.cltrShowInstructorsCard1.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(731, 593);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(112, 34);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmShowTrainedMemberbyInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRecordes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cltrShowInstructorsCard1);
            this.Name = "frmShowTrainedMemberbyInstructor";
            this.Text = "Show Trained Member by Instructor";
            this.Load += new System.EventHandler(this.frmShowTrainedMemberbyInstructor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dglMemberInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cltrShowInstructorsCard cltrShowInstructorsCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dglMemberInstructor;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRecordes;
        private System.Windows.Forms.Label label2;
    }
}