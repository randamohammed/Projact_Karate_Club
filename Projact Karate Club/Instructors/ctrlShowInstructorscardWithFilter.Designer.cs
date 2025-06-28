namespace KarateClubProjact.Instructors
{
    partial class ctrlShowInstructorscardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groFilter = new System.Windows.Forms.GroupBox();
            this.texFlter = new System.Windows.Forms.TextBox();
            this.comFlter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cltrShowInstructorsCard1 = new KarateClubProjact.cltrShowInstructorsCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btAddNew = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.groFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groFilter
            // 
            this.groFilter.Controls.Add(this.btAddNew);
            this.groFilter.Controls.Add(this.btFind);
            this.groFilter.Controls.Add(this.texFlter);
            this.groFilter.Controls.Add(this.comFlter);
            this.groFilter.Controls.Add(this.label1);
            this.groFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groFilter.Location = new System.Drawing.Point(3, 3);
            this.groFilter.Name = "groFilter";
            this.groFilter.Size = new System.Drawing.Size(842, 82);
            this.groFilter.TabIndex = 2;
            this.groFilter.TabStop = false;
            this.groFilter.Text = "Filter :";
            // 
            // texFlter
            // 
            this.texFlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texFlter.Location = new System.Drawing.Point(242, 36);
            this.texFlter.Name = "texFlter";
            this.texFlter.Size = new System.Drawing.Size(165, 26);
            this.texFlter.TabIndex = 2;
            this.texFlter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texFlter_KeyPress);
            this.texFlter.Validating += new System.ComponentModel.CancelEventHandler(this.texFlter_Validating);
            // 
            // comFlter
            // 
            this.comFlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comFlter.FormattingEnabled = true;
            this.comFlter.Items.AddRange(new object[] {
            "Instructors ID",
            "People ID"});
            this.comFlter.Location = new System.Drawing.Point(75, 34);
            this.comFlter.Name = "comFlter";
            this.comFlter.Size = new System.Drawing.Size(161, 28);
            this.comFlter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By";
            // 
            // cltrShowInstructorsCard1
            // 
            this.cltrShowInstructorsCard1.BackColor = System.Drawing.Color.White;
            this.cltrShowInstructorsCard1.Location = new System.Drawing.Point(9, 91);
            this.cltrShowInstructorsCard1.Name = "cltrShowInstructorsCard1";
            this.cltrShowInstructorsCard1.Size = new System.Drawing.Size(836, 379);
            this.cltrShowInstructorsCard1.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btAddNew
            // 
            this.btAddNew.Image = global::KarateClubProjact.Properties.Resources.add_user;
            this.btAddNew.Location = new System.Drawing.Point(527, 19);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(65, 51);
            this.btAddNew.TabIndex = 6;
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btFind
            // 
            this.btFind.Image = global::KarateClubProjact.Properties.Resources.SearchPerson;
            this.btFind.Location = new System.Drawing.Point(436, 19);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(65, 51);
            this.btFind.TabIndex = 5;
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // ctrlShowInstructorscardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cltrShowInstructorsCard1);
            this.Controls.Add(this.groFilter);
            this.Name = "ctrlShowInstructorscardWithFilter";
            this.Size = new System.Drawing.Size(854, 487);
            this.Load += new System.EventHandler(this.ctrlShowInstructorscardWithFilter_Load);
            this.groFilter.ResumeLayout(false);
            this.groFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groFilter;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TextBox texFlter;
        private System.Windows.Forms.ComboBox comFlter;
        private System.Windows.Forms.Label label1;
        private cltrShowInstructorsCard cltrShowInstructorsCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
