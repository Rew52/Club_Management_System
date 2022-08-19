namespace ASM2DDD
{
    partial class Admin_02_Club
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
            this.btLogout = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btResert = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpPublicDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPublicDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogout.Location = new System.Drawing.Point(696, 70);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(81, 30);
            this.btLogout.TabIndex = 46;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRemove.Location = new System.Drawing.Point(560, 236);
            this.btRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(116, 30);
            this.btRemove.TabIndex = 45;
            this.btRemove.Text = "Refresh Input";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btResert
            // 
            this.btResert.BackColor = System.Drawing.Color.DarkOrchid;
            this.btResert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btResert.Location = new System.Drawing.Point(266, 505);
            this.btResert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResert.Name = "btResert";
            this.btResert.Size = new System.Drawing.Size(81, 28);
            this.btResert.TabIndex = 44;
            this.btResert.Text = "Refresh";
            this.btResert.UseVisualStyleBackColor = false;
            this.btResert.Click += new System.EventHandler(this.btResert_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBack.Location = new System.Drawing.Point(494, 505);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(81, 28);
            this.btBack.TabIndex = 43;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.Location = new System.Drawing.Point(422, 236);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(82, 30);
            this.btDelete.TabIndex = 42;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.sName,
            this.cPublicDate,
            this.cManager,
            this.cCreator});
            this.dgvStudent.Location = new System.Drawing.Point(53, 332);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(732, 150);
            this.dgvStudent.TabIndex = 41;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvA_ClubM_CellClick);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEdit.Location = new System.Drawing.Point(283, 236);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(81, 30);
            this.btEdit.TabIndex = 40;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdd.Location = new System.Drawing.Point(153, 236);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(81, 30);
            this.btAdd.TabIndex = 39;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-101, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-101, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-101, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Major";
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(337, 185);
            this.txtCreator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(190, 22);
            this.txtCreator.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-101, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Email";
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(337, 150);
            this.txtManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(190, 22);
            this.txtManager.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-101, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-101, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(337, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 22);
            this.txtName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-101, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Full Name";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c.Location = new System.Drawing.Point(266, 84);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(46, 18);
            this.c.TabIndex = 48;
            this.c.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(231, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "Public Date";
            // 
            // dtpPublicDate
            // 
            this.dtpPublicDate.Location = new System.Drawing.Point(337, 116);
            this.dtpPublicDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPublicDate.Name = "dtpPublicDate";
            this.dtpPublicDate.Size = new System.Drawing.Size(238, 22);
            this.dtpPublicDate.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(231, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "Manager ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(240, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Creator ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Coral;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(179, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(476, 31);
            this.label11.TabIndex = 53;
            this.label11.Text = "You are on the Club Management page!";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.Location = new System.Drawing.Point(682, 285);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(95, 29);
            this.btSearch.TabIndex = 76;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(475, 288);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 22);
            this.txtSearch.TabIndex = 75;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cID
            // 
            this.cID.DataPropertyName = "cID";
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 8;
            this.cID.Name = "cID";
            this.cID.Width = 150;
            // 
            // sName
            // 
            this.sName.DataPropertyName = "sName";
            this.sName.HeaderText = "Name";
            this.sName.MinimumWidth = 8;
            this.sName.Name = "sName";
            this.sName.Width = 150;
            // 
            // cPublicDate
            // 
            this.cPublicDate.DataPropertyName = "cPublicDate";
            this.cPublicDate.HeaderText = "Public Date";
            this.cPublicDate.MinimumWidth = 8;
            this.cPublicDate.Name = "cPublicDate";
            this.cPublicDate.Width = 150;
            // 
            // cManager
            // 
            this.cManager.DataPropertyName = "cManager";
            this.cManager.HeaderText = "Manager";
            this.cManager.MinimumWidth = 8;
            this.cManager.Name = "cManager";
            this.cManager.Width = 150;
            // 
            // cCreator
            // 
            this.cCreator.DataPropertyName = "cCreator";
            this.cCreator.HeaderText = "Creator";
            this.cCreator.MinimumWidth = 8;
            this.cCreator.Name = "cCreator";
            this.cCreator.Width = 150;
            // 
            // Admin_02_Club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(817, 571);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpPublicDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.c);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btResert);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_02_Club";
            this.Text = "Admin_02_Club";
            this.Load += new System.EventHandler(this.Admin_02_Club_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btResert;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpPublicDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPublicDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCreator;
    }
}