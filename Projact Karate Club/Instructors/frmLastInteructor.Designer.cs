namespace KarateClubProjact
{
    partial class frmLastInteructor
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
            this.btInteructor = new System.Windows.Forms.Button();
            this.txtFilterValues = new System.Windows.Forms.TextBox();
            this.dvInteructor = new System.Windows.Forms.DataGridView();
            this.cmInstructor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInstructorDelatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainedMemberByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRecorde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvInteructor)).BeginInit();
            this.cmInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(430, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Inteructor";
            // 
            // btInteructor
            // 
            this.btInteructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInteructor.Image = global::KarateClubProjact.Properties.Resources.Add;
            this.btInteructor.Location = new System.Drawing.Point(873, 137);
            this.btInteructor.Name = "btInteructor";
            this.btInteructor.Size = new System.Drawing.Size(84, 58);
            this.btInteructor.TabIndex = 1;
            this.btInteructor.UseVisualStyleBackColor = true;
            this.btInteructor.Click += new System.EventHandler(this.btInteructor_Click);
            // 
            // txtFilterValues
            // 
            this.txtFilterValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValues.Location = new System.Drawing.Point(269, 164);
            this.txtFilterValues.Multiline = true;
            this.txtFilterValues.Name = "txtFilterValues";
            this.txtFilterValues.Size = new System.Drawing.Size(173, 31);
            this.txtFilterValues.TabIndex = 2;
            this.txtFilterValues.Visible = false;
            this.txtFilterValues.TextChanged += new System.EventHandler(this.txtFilterValues_TextChanged);
            // 
            // dvInteructor
            // 
            this.dvInteructor.AllowUserToAddRows = false;
            this.dvInteructor.AllowUserToDeleteRows = false;
            this.dvInteructor.AllowUserToOrderColumns = true;
            this.dvInteructor.BackgroundColor = System.Drawing.Color.White;
            this.dvInteructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvInteructor.ContextMenuStrip = this.cmInstructor;
            this.dvInteructor.Location = new System.Drawing.Point(5, 201);
            this.dvInteructor.Name = "dvInteructor";
            this.dvInteructor.ReadOnly = true;
            this.dvInteructor.RowHeadersWidth = 50;
            this.dvInteructor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInteructor.Size = new System.Drawing.Size(964, 333);
            this.dvInteructor.TabIndex = 3;
            this.dvInteructor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvInteructor_CellContentClick);
            // 
            // cmInstructor
            // 
            this.cmInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmInstructor.ImageScalingSize = new System.Drawing.Size(33, 33);
            this.cmInstructor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInstructorToolStripMenuItem,
            this.editInstructorToolStripMenuItem,
            this.deleteInstructorToolStripMenuItem,
            this.showInstructorDelatiToolStripMenuItem,
            this.trainedMemberByToolStripMenuItem});
            this.cmInstructor.Name = "cmInstructor";
            this.cmInstructor.Size = new System.Drawing.Size(305, 204);
            // 
            // addInstructorToolStripMenuItem
            // 
            this.addInstructorToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.karate_add;
            this.addInstructorToolStripMenuItem.Name = "addInstructorToolStripMenuItem";
            this.addInstructorToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.addInstructorToolStripMenuItem.Text = "Add Instructor";
            this.addInstructorToolStripMenuItem.Click += new System.EventHandler(this.addInstructorToolStripMenuItem_Click);
            // 
            // editInstructorToolStripMenuItem
            // 
            this.editInstructorToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.edit;
            this.editInstructorToolStripMenuItem.Name = "editInstructorToolStripMenuItem";
            this.editInstructorToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.editInstructorToolStripMenuItem.Text = "Edit Instructor";
            this.editInstructorToolStripMenuItem.Click += new System.EventHandler(this.editInstructorToolStripMenuItem_Click);
            // 
            // deleteInstructorToolStripMenuItem
            // 
            this.deleteInstructorToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.Delete_32;
            this.deleteInstructorToolStripMenuItem.Name = "deleteInstructorToolStripMenuItem";
            this.deleteInstructorToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.deleteInstructorToolStripMenuItem.Text = "Delete Instructor";
            this.deleteInstructorToolStripMenuItem.Click += new System.EventHandler(this.deleteInstructorToolStripMenuItem_Click);
            // 
            // showInstructorDelatiToolStripMenuItem
            // 
            this.showInstructorDelatiToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.List_32;
            this.showInstructorDelatiToolStripMenuItem.Name = "showInstructorDelatiToolStripMenuItem";
            this.showInstructorDelatiToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.showInstructorDelatiToolStripMenuItem.Text = "Show Instructor Delails";
            this.showInstructorDelatiToolStripMenuItem.Click += new System.EventHandler(this.showInstructorDelatiToolStripMenuItem_Click);
            // 
            // trainedMemberByToolStripMenuItem
            // 
            this.trainedMemberByToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.AddAppointment_32;
            this.trainedMemberByToolStripMenuItem.Name = "trainedMemberByToolStripMenuItem";
            this.trainedMemberByToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.trainedMemberByToolStripMenuItem.Text = "Trained Member By Instructor";
            this.trainedMemberByToolStripMenuItem.Click += new System.EventHandler(this.trainedMemberByToolStripMenuItem_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(858, 5);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(97, 36);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.karate;
            this.pictureBox1.Location = new System.Drawing.Point(16, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbRecorde);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Location = new System.Drawing.Point(2, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 47);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Recordes ";
            // 
            // lbRecorde
            // 
            this.lbRecorde.AutoSize = true;
            this.lbRecorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecorde.Location = new System.Drawing.Point(125, 12);
            this.lbRecorde.Name = "lbRecorde";
            this.lbRecorde.Size = new System.Drawing.Size(40, 24);
            this.lbRecorde.TabIndex = 1;
            this.lbRecorde.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "# Recordes :";
            // 
            // cmFilter
            // 
            this.cmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFilter.FormattingEnabled = true;
            this.cmFilter.Items.AddRange(new object[] {
            "None",
            "Inteructor ID",
            "Full Name",
            "Gender"});
            this.cmFilter.Location = new System.Drawing.Point(103, 167);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.Size = new System.Drawing.Size(160, 26);
            this.cmFilter.TabIndex = 7;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Find By:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(2, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 5);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(908, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 47);
            this.button1.TabIndex = 34;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmLastInteructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvInteructor);
            this.Controls.Add(this.txtFilterValues);
            this.Controls.Add(this.btInteructor);
            this.Controls.Add(this.label1);
            this.Name = "frmLastInteructor";
            this.Text = "Last Inteructor";
            this.Load += new System.EventHandler(this.frmLastInteructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvInteructor)).EndInit();
            this.cmInstructor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInteructor;
        private System.Windows.Forms.TextBox txtFilterValues;
        private System.Windows.Forms.DataGridView dvInteructor;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRecorde;
        private System.Windows.Forms.ComboBox cmFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmInstructor;
        private System.Windows.Forms.ToolStripMenuItem addInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInstructorDelatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainedMemberByToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}