namespace KarateClubProjact
{
    partial class frmListBeltTests
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvBeltTest = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.cmFindBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltervalues = new System.Windows.Forms.TextBox();
            this.cmReslut = new System.Windows.Forms.ComboBox();
            this.cmBeltRank = new System.Windows.Forms.ComboBox();
            this.btTakeTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvBeltTest)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(434, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "List   Belt Tests";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 5);
            this.panel1.TabIndex = 15;
            // 
            // dvBeltTest
            // 
            this.dvBeltTest.AllowUserToAddRows = false;
            this.dvBeltTest.AllowUserToDeleteRows = false;
            this.dvBeltTest.AllowUserToOrderColumns = true;
            this.dvBeltTest.BackgroundColor = System.Drawing.Color.White;
            this.dvBeltTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBeltTest.Location = new System.Drawing.Point(6, 177);
            this.dvBeltTest.Name = "dvBeltTest";
            this.dvBeltTest.ReadOnly = true;
            this.dvBeltTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBeltTest.Size = new System.Drawing.Size(982, 336);
            this.dvBeltTest.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbRecord);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(6, 529);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 39);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Recorde ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "# Recordes :";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(412, 4);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(30, 24);
            this.lbRecord.TabIndex = 5;
            this.lbRecord.Text = "??";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(868, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(97, 30);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // cmFindBy
            // 
            this.cmFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFindBy.FormattingEnabled = true;
            this.cmFindBy.Items.AddRange(new object[] {
            "None",
            "Member Name",
            "Instructor Name",
            "Rank Name",
            "Result"});
            this.cmFindBy.Location = new System.Drawing.Point(117, 145);
            this.cmFindBy.Name = "cmFindBy";
            this.cmFindBy.Size = new System.Drawing.Size(154, 26);
            this.cmFindBy.TabIndex = 18;
            this.cmFindBy.SelectedIndexChanged += new System.EventHandler(this.cmFindBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Find By:";
            // 
            // txtFiltervalues
            // 
            this.txtFiltervalues.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtFiltervalues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltervalues.Location = new System.Drawing.Point(289, 145);
            this.txtFiltervalues.Name = "txtFiltervalues";
            this.txtFiltervalues.Size = new System.Drawing.Size(175, 24);
            this.txtFiltervalues.TabIndex = 20;
            this.txtFiltervalues.UseWaitCursor = true;
            this.txtFiltervalues.Visible = false;
            this.txtFiltervalues.TextChanged += new System.EventHandler(this.txtFiltervalues_TextChanged);
            // 
            // cmReslut
            // 
            this.cmReslut.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmReslut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmReslut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmReslut.FormattingEnabled = true;
            this.cmReslut.Items.AddRange(new object[] {
            "All",
            "Passed",
            "Failed"});
            this.cmReslut.Location = new System.Drawing.Point(289, 145);
            this.cmReslut.Name = "cmReslut";
            this.cmReslut.Size = new System.Drawing.Size(109, 26);
            this.cmReslut.TabIndex = 21;
            this.cmReslut.Visible = false;
            this.cmReslut.SelectedIndexChanged += new System.EventHandler(this.cmReslut_SelectedIndexChanged);
            // 
            // cmBeltRank
            // 
            this.cmBeltRank.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cmBeltRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBeltRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBeltRank.FormattingEnabled = true;
            this.cmBeltRank.Location = new System.Drawing.Point(289, 145);
            this.cmBeltRank.Name = "cmBeltRank";
            this.cmBeltRank.Size = new System.Drawing.Size(154, 26);
            this.cmBeltRank.TabIndex = 22;
            this.cmBeltRank.Visible = false;
            this.cmBeltRank.SelectedIndexChanged += new System.EventHandler(this.cmBeltRank_SelectedIndexChanged);
            // 
            // btTakeTest
            // 
            this.btTakeTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTakeTest.Image = global::KarateClubProjact.Properties.Resources.Test_32;
            this.btTakeTest.Location = new System.Drawing.Point(922, 132);
            this.btTakeTest.Name = "btTakeTest";
            this.btTakeTest.Size = new System.Drawing.Size(51, 39);
            this.btTakeTest.TabIndex = 23;
            this.btTakeTest.UseVisualStyleBackColor = true;
            this.btTakeTest.Click += new System.EventHandler(this.btTakeTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.testing;
            this.pictureBox1.Location = new System.Drawing.Point(35, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmListBeltTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 597);
            this.Controls.Add(this.btTakeTest);
            this.Controls.Add(this.cmBeltRank);
            this.Controls.Add(this.cmReslut);
            this.Controls.Add(this.txtFiltervalues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmFindBy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dvBeltTest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListBeltTests";
            this.Text = "List Belt Tests";
            this.Load += new System.EventHandler(this.frmListBeltTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvBeltTest)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvBeltTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ComboBox cmFindBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltervalues;
        private System.Windows.Forms.ComboBox cmReslut;
        private System.Windows.Forms.ComboBox cmBeltRank;
        private System.Windows.Forms.Button btTakeTest;
    }
}