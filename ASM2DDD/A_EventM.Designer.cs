namespace ASM2DDD
{
    partial class A_EventM
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPublicDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btResert = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.eID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Coral;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(166, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(487, 31);
            this.label11.TabIndex = 70;
            this.label11.Text = "You are on the Event Management page!";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(224, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 69;
            this.label10.Text = "Creator ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(234, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 68;
            this.label9.Text = "Location";
            // 
            // dtpPublicDate
            // 
            this.dtpPublicDate.Location = new System.Drawing.Point(323, 122);
            this.dtpPublicDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPublicDate.Name = "dtpPublicDate";
            this.dtpPublicDate.Size = new System.Drawing.Size(238, 22);
            this.dtpPublicDate.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(263, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Day";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c.Location = new System.Drawing.Point(252, 90);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(46, 18);
            this.c.TabIndex = 65;
            this.c.Text = "Name";
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogout.Location = new System.Drawing.Point(672, 83);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(81, 30);
            this.btLogout.TabIndex = 64;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRemove.Location = new System.Drawing.Point(570, 241);
            this.btRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(111, 30);
            this.btRemove.TabIndex = 63;
            this.btRemove.Text = "Refresh Input";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btResert
            // 
            this.btResert.BackColor = System.Drawing.Color.Orchid;
            this.btResert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btResert.Location = new System.Drawing.Point(224, 514);
            this.btResert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResert.Name = "btResert";
            this.btResert.Size = new System.Drawing.Size(84, 30);
            this.btResert.TabIndex = 62;
            this.btResert.Text = "Refresh";
            this.btResert.UseVisualStyleBackColor = false;
            this.btResert.Click += new System.EventHandler(this.btResert_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Orchid;
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBack.Location = new System.Drawing.Point(469, 514);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(92, 30);
            this.btBack.TabIndex = 61;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.Location = new System.Drawing.Point(417, 241);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(84, 30);
            this.btDelete.TabIndex = 60;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eID,
            this.eName,
            this.eDay,
            this.eLocation,
            this.eCreator});
            this.dgvStudent.Location = new System.Drawing.Point(45, 343);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(722, 150);
            this.dgvStudent.TabIndex = 59;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvA_EventM_CellClick);
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // eID
            // 
            this.eID.DataPropertyName = "eID";
            this.eID.HeaderText = "ID";
            this.eID.MinimumWidth = 8;
            this.eID.Name = "eID";
            this.eID.Width = 150;
            // 
            // eName
            // 
            this.eName.DataPropertyName = "eName";
            this.eName.HeaderText = "Name";
            this.eName.MinimumWidth = 8;
            this.eName.Name = "eName";
            this.eName.Width = 150;
            // 
            // eDay
            // 
            this.eDay.DataPropertyName = "eDay";
            this.eDay.HeaderText = "Day";
            this.eDay.MinimumWidth = 8;
            this.eDay.Name = "eDay";
            this.eDay.Width = 150;
            // 
            // eLocation
            // 
            this.eLocation.DataPropertyName = "eLocation";
            this.eLocation.HeaderText = "Location";
            this.eLocation.MinimumWidth = 8;
            this.eLocation.Name = "eLocation";
            this.eLocation.Width = 150;
            // 
            // eCreator
            // 
            this.eCreator.DataPropertyName = "eCreator";
            this.eCreator.HeaderText = "Creator";
            this.eCreator.MinimumWidth = 8;
            this.eCreator.Name = "eCreator";
            this.eCreator.Width = 150;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEdit.Location = new System.Drawing.Point(263, 241);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(85, 30);
            this.btEdit.TabIndex = 58;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdd.Location = new System.Drawing.Point(125, 241);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(81, 30);
            this.btAdd.TabIndex = 57;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(323, 191);
            this.txtCreator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(190, 22);
            this.txtCreator.TabIndex = 56;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(323, 156);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(190, 22);
            this.txtLocation.TabIndex = 55;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(323, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 22);
            this.txtName.TabIndex = 54;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.Location = new System.Drawing.Point(673, 294);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(95, 29);
            this.btSearch.TabIndex = 72;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(466, 297);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 22);
            this.txtSearch.TabIndex = 71;
            // 
            // A_EventM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(810, 563);
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
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "A_EventM";
            this.Text = "A_EventM";
            this.Load += new System.EventHandler(this.A_EventM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpPublicDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btResert;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn eID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eName;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCreator;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}