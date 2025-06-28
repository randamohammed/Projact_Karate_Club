namespace KarateClubProjact.Belt_Test
{
    partial class frmShowTestHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgMemberTestHistoy = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecorde = new System.Windows.Forms.Label();
            this.ctrlShowMemberInfo1 = new KarateClubProjact.ctrlShowMemberInfo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberTestHistoy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "# Recordes:";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(767, 640);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(112, 34);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dgMemberTestHistoy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History:";
            // 
            // dgMemberTestHistoy
            // 
            this.dgMemberTestHistoy.AllowUserToAddRows = false;
            this.dgMemberTestHistoy.AllowUserToDeleteRows = false;
            this.dgMemberTestHistoy.AllowUserToOrderColumns = true;
            this.dgMemberTestHistoy.BackgroundColor = System.Drawing.Color.White;
            this.dgMemberTestHistoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemberTestHistoy.Location = new System.Drawing.Point(6, 22);
            this.dgMemberTestHistoy.Name = "dgMemberTestHistoy";
            this.dgMemberTestHistoy.ReadOnly = true;
            this.dgMemberTestHistoy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMemberTestHistoy.Size = new System.Drawing.Size(854, 135);
            this.dgMemberTestHistoy.TabIndex = 0;
            this.dgMemberTestHistoy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMemberTestHistoy_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(393, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Test History";
            // 
            // lbRecorde
            // 
            this.lbRecorde.AutoSize = true;
            this.lbRecorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecorde.Location = new System.Drawing.Point(124, 640);
            this.lbRecorde.Name = "lbRecorde";
            this.lbRecorde.Size = new System.Drawing.Size(39, 20);
            this.lbRecorde.TabIndex = 10;
            this.lbRecorde.Text = "???";
            // 
            // ctrlShowMemberInfo1
            // 
            this.ctrlShowMemberInfo1.AllowDrop = true;
            this.ctrlShowMemberInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlShowMemberInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlShowMemberInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShowMemberInfo1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ctrlShowMemberInfo1.Location = new System.Drawing.Point(25, 37);
            this.ctrlShowMemberInfo1.Name = "ctrlShowMemberInfo1";
            this.ctrlShowMemberInfo1.Size = new System.Drawing.Size(837, 425);
            this.ctrlShowMemberInfo1.TabIndex = 0;
            // 
            // frmShowTestHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 679);
            this.Controls.Add(this.lbRecorde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlShowMemberInfo1);
            this.Name = "frmShowTestHistory";
            this.Text = "Show Test History";
            this.Load += new System.EventHandler(this.frmShowTestHistory_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberTestHistoy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlShowMemberInfo ctrlShowMemberInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgMemberTestHistoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecorde;
    }
}