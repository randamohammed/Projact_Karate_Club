namespace KarateClubProjact
{
    partial class ManageUsers
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
            this.label2 = new System.Windows.Forms.Label();
            this.comFilter = new System.Windows.Forms.ComboBox();
            this.texFilter = new System.Windows.Forms.TextBox();
            this.laRecode = new System.Windows.Forms.Label();
            this.comISActive = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tosAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tosShowUserinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tosEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tosDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.chanageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.davManageUser = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buClose = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.davManageUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(432, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comFilter
            // 
            this.comFilter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comFilter.FormattingEnabled = true;
            this.comFilter.Items.AddRange(new object[] {
            "User ID",
            "Preson ID",
            "National No",
            "User Name",
            "Full name",
            "IS Active"});
            this.comFilter.Location = new System.Drawing.Point(106, 171);
            this.comFilter.Name = "comFilter";
            this.comFilter.Size = new System.Drawing.Size(153, 26);
            this.comFilter.TabIndex = 4;
            this.comFilter.SelectedIndexChanged += new System.EventHandler(this.comFilter_SelectedIndexChanged);
            // 
            // texFilter
            // 
            this.texFilter.Location = new System.Drawing.Point(265, 169);
            this.texFilter.Multiline = true;
            this.texFilter.Name = "texFilter";
            this.texFilter.Size = new System.Drawing.Size(150, 28);
            this.texFilter.TabIndex = 5;
            this.texFilter.Visible = false;
            this.texFilter.TextChanged += new System.EventHandler(this.texFilter_TextChanged);
            // 
            // laRecode
            // 
            this.laRecode.AutoSize = true;
            this.laRecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRecode.ForeColor = System.Drawing.Color.Black;
            this.laRecode.Location = new System.Drawing.Point(129, 13);
            this.laRecode.Name = "laRecode";
            this.laRecode.Size = new System.Drawing.Size(36, 25);
            this.laRecode.TabIndex = 6;
            this.laRecode.Text = "??";
            // 
            // comISActive
            // 
            this.comISActive.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comISActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comISActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comISActive.FormattingEnabled = true;
            this.comISActive.Items.AddRange(new object[] {
            "None",
            "Yes",
            "No"});
            this.comISActive.Location = new System.Drawing.Point(264, 170);
            this.comISActive.Name = "comISActive";
            this.comISActive.Size = new System.Drawing.Size(111, 26);
            this.comISActive.TabIndex = 8;
            this.comISActive.Visible = false;
            this.comISActive.SelectedIndexChanged += new System.EventHandler(this.comISActive_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tosAddUser,
            this.tosShowUserinfo,
            this.tosEditUser,
            this.tosDeleteUser,
            this.chanageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 236);
            // 
            // tosAddUser
            // 
            this.tosAddUser.BackColor = System.Drawing.Color.White;
            this.tosAddUser.Image = global::KarateClubProjact.Properties.Resources.Add;
            this.tosAddUser.Name = "tosAddUser";
            this.tosAddUser.Size = new System.Drawing.Size(231, 42);
            this.tosAddUser.Text = "Add User";
            this.tosAddUser.Click += new System.EventHandler(this.tosAddUser_Click);
            // 
            // tosShowUserinfo
            // 
            this.tosShowUserinfo.BackColor = System.Drawing.Color.White;
            this.tosShowUserinfo.Image = global::KarateClubProjact.Properties.Resources.diskette;
            this.tosShowUserinfo.Name = "tosShowUserinfo";
            this.tosShowUserinfo.Size = new System.Drawing.Size(231, 42);
            this.tosShowUserinfo.Text = "Show User Info";
            this.tosShowUserinfo.Click += new System.EventHandler(this.tosShowUserinfo_Click);
            // 
            // tosEditUser
            // 
            this.tosEditUser.BackColor = System.Drawing.Color.White;
            this.tosEditUser.Image = global::KarateClubProjact.Properties.Resources.edit;
            this.tosEditUser.Name = "tosEditUser";
            this.tosEditUser.Size = new System.Drawing.Size(231, 42);
            this.tosEditUser.Text = "Edit User";
            this.tosEditUser.Click += new System.EventHandler(this.tosEditUser_Click);
            // 
            // tosDeleteUser
            // 
            this.tosDeleteUser.BackColor = System.Drawing.Color.White;
            this.tosDeleteUser.Image = global::KarateClubProjact.Properties.Resources.delete_column;
            this.tosDeleteUser.Name = "tosDeleteUser";
            this.tosDeleteUser.Size = new System.Drawing.Size(231, 42);
            this.tosDeleteUser.Text = "Delete User";
            this.tosDeleteUser.Click += new System.EventHandler(this.tosDeleteUser_Click);
            // 
            // chanageToolStripMenuItem
            // 
            this.chanageToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.chanageToolStripMenuItem.Image = global::KarateClubProjact.Properties.Resources.password;
            this.chanageToolStripMenuItem.Name = "chanageToolStripMenuItem";
            this.chanageToolStripMenuItem.Size = new System.Drawing.Size(231, 42);
            this.chanageToolStripMenuItem.Text = "Chanage Password";
            this.chanageToolStripMenuItem.Click += new System.EventHandler(this.chanageToolStripMenuItem_Click);
            // 
            // davManageUser
            // 
            this.davManageUser.AllowUserToAddRows = false;
            this.davManageUser.AllowUserToDeleteRows = false;
            this.davManageUser.AllowUserToOrderColumns = true;
            this.davManageUser.BackgroundColor = System.Drawing.Color.White;
            this.davManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.davManageUser.ContextMenuStrip = this.contextMenuStrip1;
            this.davManageUser.GridColor = System.Drawing.Color.Black;
            this.davManageUser.Location = new System.Drawing.Point(12, 204);
            this.davManageUser.Name = "davManageUser";
            this.davManageUser.ReadOnly = true;
            this.davManageUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.davManageUser.Size = new System.Drawing.Size(978, 325);
            this.davManageUser.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buClose);
            this.panel1.Controls.Add(this.laRecode);
            this.panel1.Location = new System.Drawing.Point(12, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 47);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "# Recordes:";
            // 
            // buClose
            // 
            this.buClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buClose.Image = global::KarateClubProjact.Properties.Resources.cross_32;
            this.buClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buClose.Location = new System.Drawing.Point(796, 5);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(116, 38);
            this.buClose.TabIndex = 7;
            this.buClose.Text = "Close";
            this.buClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNew.Image = global::KarateClubProjact.Properties.Resources.Add_New_User_32;
            this.btAddNew.Location = new System.Drawing.Point(921, 154);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(69, 45);
            this.btAddNew.TabIndex = 13;
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClubProjact.Properties.Resources.Add_New_User_72;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(12, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 5);
            this.panel2.TabIndex = 15;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(995, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.davManageUser);
            this.Controls.Add(this.comISActive);
            this.Controls.Add(this.texFilter);
            this.Controls.Add(this.comFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageUsers";
            this.ShowIcon = false;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load_2);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.davManageUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comFilter;
        private System.Windows.Forms.TextBox texFilter;
        private System.Windows.Forms.Label laRecode;
        private System.Windows.Forms.Button buClose;
        private System.Windows.Forms.ComboBox comISActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tosAddUser;
        private System.Windows.Forms.ToolStripMenuItem tosShowUserinfo;
        private System.Windows.Forms.ToolStripMenuItem tosEditUser;
        private System.Windows.Forms.ToolStripMenuItem tosDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem chanageToolStripMenuItem;
        private System.Windows.Forms.DataGridView davManageUser;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}