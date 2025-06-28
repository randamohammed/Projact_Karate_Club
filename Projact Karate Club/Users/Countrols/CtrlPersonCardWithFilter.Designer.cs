namespace KarateClubProjact
{
    partial class CtrlPersonCardWithFilter
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
            this.groFilter = new System.Windows.Forms.GroupBox();
            this.picAddPopele = new System.Windows.Forms.PictureBox();
            this.picSearchPeople = new System.Windows.Forms.PictureBox();
            this.texFlter = new System.Windows.Forms.TextBox();
            this.comFlter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showPeopleInfo3 = new KarateClubProjact.ShowPeopleInfo();
            this.groFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPopele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // groFilter
            // 
            this.groFilter.Controls.Add(this.picAddPopele);
            this.groFilter.Controls.Add(this.picSearchPeople);
            this.groFilter.Controls.Add(this.texFlter);
            this.groFilter.Controls.Add(this.comFlter);
            this.groFilter.Controls.Add(this.label1);
            this.groFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groFilter.Location = new System.Drawing.Point(3, 3);
            this.groFilter.Name = "groFilter";
            this.groFilter.Size = new System.Drawing.Size(830, 82);
            this.groFilter.TabIndex = 0;
            this.groFilter.TabStop = false;
            this.groFilter.Text = "Filter :";
            // 
            // picAddPopele
            // 
            this.picAddPopele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAddPopele.Image = global::KarateClubProjact.Properties.Resources.Add;
            this.picAddPopele.Location = new System.Drawing.Point(507, 19);
            this.picAddPopele.Name = "picAddPopele";
            this.picAddPopele.Size = new System.Drawing.Size(57, 50);
            this.picAddPopele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddPopele.TabIndex = 4;
            this.picAddPopele.TabStop = false;
            this.picAddPopele.Click += new System.EventHandler(this.picAddPopele_Click);
            // 
            // picSearchPeople
            // 
            this.picSearchPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearchPeople.Image = global::KarateClubProjact.Properties.Resources.login;
            this.picSearchPeople.Location = new System.Drawing.Point(425, 19);
            this.picSearchPeople.Name = "picSearchPeople";
            this.picSearchPeople.Size = new System.Drawing.Size(57, 50);
            this.picSearchPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchPeople.TabIndex = 3;
            this.picSearchPeople.TabStop = false;
            this.picSearchPeople.Click += new System.EventHandler(this.picSearchPeople_Click);
            // 
            // texFlter
            // 
            this.texFlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texFlter.Location = new System.Drawing.Point(242, 34);
            this.texFlter.Name = "texFlter";
            this.texFlter.Size = new System.Drawing.Size(165, 26);
            this.texFlter.TabIndex = 2;
            this.texFlter.TextChanged += new System.EventHandler(this.texFlter_TextChanged);
            this.texFlter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texFlter_KeyPress);
            // 
            // comFlter
            // 
            this.comFlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comFlter.FormattingEnabled = true;
            this.comFlter.Items.AddRange(new object[] {
            "People ID",
            "Natoinal No"});
            this.comFlter.Location = new System.Drawing.Point(75, 34);
            this.comFlter.Name = "comFlter";
            this.comFlter.Size = new System.Drawing.Size(161, 28);
            this.comFlter.TabIndex = 1;
            this.comFlter.SelectedIndexChanged += new System.EventHandler(this.comFlter_SelectedIndexChanged);
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
            // showPeopleInfo3
            // 
            this.showPeopleInfo3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.showPeopleInfo3.Location = new System.Drawing.Point(3, 91);
            this.showPeopleInfo3.Name = "showPeopleInfo3";
            this.showPeopleInfo3.Size = new System.Drawing.Size(825, 242);
            this.showPeopleInfo3.TabIndex = 1;
            this.showPeopleInfo3.Load += new System.EventHandler(this.showPeopleInfo3_Load);
            // 
            // CtrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.showPeopleInfo3);
            this.Controls.Add(this.groFilter);
            this.Name = "CtrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(838, 345);
            this.Load += new System.EventHandler(this.CtrlPersonCardWithFilter_Load);
            this.groFilter.ResumeLayout(false);
            this.groFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPopele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groFilter;
        private System.Windows.Forms.PictureBox picSearchPeople;
        private System.Windows.Forms.TextBox texFlter;
        private System.Windows.Forms.ComboBox comFlter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAddPopele;
        private ShowPeopleInfo showPeopleInfo1;
        private ShowPeopleInfo showPeopleInfo2;
        private ShowPeopleInfo showPeopleInfo3;
    }
}
