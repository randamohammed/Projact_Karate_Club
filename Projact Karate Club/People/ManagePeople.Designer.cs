namespace KarateClubProjact
{
    partial class ManagePeople
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
            this.davManagePeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tosShowDetiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tosAddNewPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tosEditPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tosDeletePeople = new System.Windows.Forms.ToolStripMenuItem();
            this.laRecorde = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comFilter = new System.Windows.Forms.ComboBox();
            this.teFilter = new System.Windows.Forms.TextBox();
            this.pichAddNewPeople = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.davManagePeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichAddNewPeople)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(418, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage people";
            // 
            // davManagePeople
            // 
            this.davManagePeople.AllowUserToAddRows = false;
            this.davManagePeople.AllowUserToDeleteRows = false;
            this.davManagePeople.AllowUserToOrderColumns = true;
            this.davManagePeople.BackgroundColor = System.Drawing.Color.White;
            this.davManagePeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.davManagePeople.ContextMenuStrip = this.contextMenuStrip1;
            this.davManagePeople.GridColor = System.Drawing.Color.Black;
            this.davManagePeople.Location = new System.Drawing.Point(12, 197);
            this.davManagePeople.Name = "davManagePeople";
            this.davManagePeople.ReadOnly = true;
            this.davManagePeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.davManagePeople.Size = new System.Drawing.Size(945, 333);
            this.davManagePeople.TabIndex = 2;
            this.davManagePeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.davManagePeople_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tosShowDetiles,
            this.tosAddNewPeople,
            this.tosEditPeople,
            this.tosDeletePeople});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 194);
            // 
            // tosShowDetiles
            // 
            this.tosShowDetiles.Image = global::KarateClubProjact.Properties.Resources.List_32;
            this.tosShowDetiles.Name = "tosShowDetiles";
            this.tosShowDetiles.Size = new System.Drawing.Size(213, 42);
            this.tosShowDetiles.Text = "Show  Detiles";
            this.tosShowDetiles.Click += new System.EventHandler(this.tosShowDetiles_Click);
            // 
            // tosAddNewPeople
            // 
            this.tosAddNewPeople.Image = global::KarateClubProjact.Properties.Resources.Add;
            this.tosAddNewPeople.Name = "tosAddNewPeople";
            this.tosAddNewPeople.Size = new System.Drawing.Size(213, 42);
            this.tosAddNewPeople.Text = "Add New People";
            this.tosAddNewPeople.Click += new System.EventHandler(this.tosAddNewPeople_Click);
            // 
            // tosEditPeople
            // 
            this.tosEditPeople.Image = global::KarateClubProjact.Properties.Resources.edit;
            this.tosEditPeople.Name = "tosEditPeople";
            this.tosEditPeople.Size = new System.Drawing.Size(213, 42);
            this.tosEditPeople.Text = "Edit People";
            this.tosEditPeople.Click += new System.EventHandler(this.tosEditPeople_Click);
            // 
            // tosDeletePeople
            // 
            this.tosDeletePeople.Image = global::KarateClubProjact.Properties.Resources.delete_column;
            this.tosDeletePeople.Name = "tosDeletePeople";
            this.tosDeletePeople.Size = new System.Drawing.Size(213, 42);
            this.tosDeletePeople.Text = "Delete People";
            this.tosDeletePeople.Click += new System.EventHandler(this.tosDeletePeople_Click);
            // 
            // laRecorde
            // 
            this.laRecorde.AutoSize = true;
            this.laRecorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRecorde.ForeColor = System.Drawing.Color.Black;
            this.laRecorde.Location = new System.Drawing.Point(141, 12);
            this.laRecorde.Name = "laRecorde";
            this.laRecorde.Size = new System.Drawing.Size(40, 24);
            this.laRecorde.TabIndex = 3;
            this.laRecorde.Text = "???";
            // 
            // butClose
            // 
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.ForeColor = System.Drawing.Color.Black;
            this.butClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.butClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butClose.Location = new System.Drawing.Point(829, 4);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(103, 36);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "Close";
            this.butClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Find By";
            // 
            // comFilter
            // 
            this.comFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comFilter.FormattingEnabled = true;
            this.comFilter.Items.AddRange(new object[] {
            "None",
            "People ID",
            "Naional No",
            "Full Name",
            "Gender"});
            this.comFilter.Location = new System.Drawing.Point(90, 163);
            this.comFilter.Name = "comFilter";
            this.comFilter.Size = new System.Drawing.Size(121, 26);
            this.comFilter.TabIndex = 6;
            this.comFilter.SelectedIndexChanged += new System.EventHandler(this.comFilter_SelectedIndexChanged);
            // 
            // teFilter
            // 
            this.teFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teFilter.Location = new System.Drawing.Point(215, 165);
            this.teFilter.Multiline = true;
            this.teFilter.Name = "teFilter";
            this.teFilter.Size = new System.Drawing.Size(147, 24);
            this.teFilter.TabIndex = 7;
            this.teFilter.Visible = false;
            this.teFilter.TextChanged += new System.EventHandler(this.teFilter_TextChanged);
            this.teFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teFilter_KeyPress);
            // 
            // pichAddNewPeople
            // 
            this.pichAddNewPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pichAddNewPeople.Image = global::KarateClubProjact.Properties.Resources.Add;
            this.pichAddNewPeople.Location = new System.Drawing.Point(888, 146);
            this.pichAddNewPeople.Name = "pichAddNewPeople";
            this.pichAddNewPeople.Size = new System.Drawing.Size(69, 45);
            this.pichAddNewPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pichAddNewPeople.TabIndex = 9;
            this.pichAddNewPeople.TabStop = false;
            this.pichAddNewPeople.Click += new System.EventHandler(this.pichAddNewPeople_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.butClose);
            this.panel1.Controls.Add(this.laRecorde);
            this.panel1.Location = new System.Drawing.Point(14, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 45);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(187, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Recorde";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "# Recordes:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(7, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 5);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.pictureBox2.Location = new System.Drawing.Point(908, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.butClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.Manage_People;
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(969, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pichAddNewPeople);
            this.Controls.Add(this.teFilter);
            this.Controls.Add(this.comFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.davManagePeople);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagePeople";
            this.ShowIcon = false;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.davManagePeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pichAddNewPeople)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView davManagePeople;
        private System.Windows.Forms.Label laRecorde;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comFilter;
        private System.Windows.Forms.TextBox teFilter;
        private System.Windows.Forms.PictureBox pichAddNewPeople;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tosShowDetiles;
        private System.Windows.Forms.ToolStripMenuItem tosAddNewPeople;
        private System.Windows.Forms.ToolStripMenuItem tosEditPeople;
        private System.Windows.Forms.ToolStripMenuItem tosDeletePeople;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}