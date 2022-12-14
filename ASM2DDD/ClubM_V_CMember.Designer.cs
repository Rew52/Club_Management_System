namespace ASM2DDD
{
    partial class ClubM_V_CMember
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
            this.btBack = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btResert = new System.Windows.Forms.Button();
            this.dtGVStudent = new System.Windows.Forms.DataGridView();
            this.sID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGVClub = new System.Windows.Forms.DataGridView();
            this.txtSearchStudent = new System.Windows.Forms.MaskedTextBox();
            this.txtSearchClub = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btSearchStudent = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.cmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPublicDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Crimson;
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBack.Location = new System.Drawing.Point(590, 558);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(87, 30);
            this.btBack.TabIndex = 62;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.SlateGray;
            this.btLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogout.Location = new System.Drawing.Point(1003, 89);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(87, 30);
            this.btLogout.TabIndex = 61;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(330, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 31);
            this.label1.TabIndex = 60;
            this.label1.Text = "Club member management information page!";
            // 
            // btResert
            // 
            this.btResert.BackColor = System.Drawing.Color.Crimson;
            this.btResert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btResert.Location = new System.Drawing.Point(858, 428);
            this.btResert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResert.Name = "btResert";
            this.btResert.Size = new System.Drawing.Size(95, 29);
            this.btResert.TabIndex = 59;
            this.btResert.Text = "Refresh";
            this.btResert.UseVisualStyleBackColor = false;
            this.btResert.Click += new System.EventHandler(this.btResert_Click);
            // 
            // dtGVStudent
            // 
            this.dtGVStudent.BackgroundColor = System.Drawing.Color.Peru;
            this.dtGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sID,
            this.dataGridViewTextBoxColumn2,
            this.sEmail,
            this.sSex});
            this.dtGVStudent.Location = new System.Drawing.Point(44, 371);
            this.dtGVStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGVStudent.Name = "dtGVStudent";
            this.dtGVStudent.RowHeadersWidth = 62;
            this.dtGVStudent.RowTemplate.Height = 28;
            this.dtGVStudent.Size = new System.Drawing.Size(591, 154);
            this.dtGVStudent.TabIndex = 68;
            this.dtGVStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVStudent_CellClick);
            // 
            // sID
            // 
            this.sID.DataPropertyName = "sID";
            this.sID.HeaderText = "ID";
            this.sID.MinimumWidth = 8;
            this.sID.Name = "sID";
            this.sID.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sfullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // sEmail
            // 
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.MinimumWidth = 8;
            this.sEmail.Name = "sEmail";
            this.sEmail.Width = 150;
            // 
            // sSex
            // 
            this.sSex.DataPropertyName = "sSex";
            this.sSex.HeaderText = "Sex";
            this.sSex.MinimumWidth = 8;
            this.sSex.Name = "sSex";
            this.sSex.Width = 150;
            // 
            // dtGVClub
            // 
            this.dtGVClub.BackgroundColor = System.Drawing.Color.Peru;
            this.dtGVClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.dataGridViewTextBoxColumn1,
            this.cPublicDate,
            this.cManager,
            this.aFullName});
            this.dtGVClub.Location = new System.Drawing.Point(45, 139);
            this.dtGVClub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGVClub.Name = "dtGVClub";
            this.dtGVClub.RowHeadersWidth = 62;
            this.dtGVClub.RowTemplate.Height = 28;
            this.dtGVClub.Size = new System.Drawing.Size(590, 150);
            this.dtGVClub.TabIndex = 67;
            this.dtGVClub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVClub_CellClick);
            this.dtGVClub.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVClub_CellContentClick);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(204, 333);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(109, 22);
            this.txtSearchStudent.TabIndex = 66;
            // 
            // txtSearchClub
            // 
            this.txtSearchClub.Location = new System.Drawing.Point(205, 93);
            this.txtSearchClub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchClub.Name = "txtSearchClub";
            this.txtSearchClub.Size = new System.Drawing.Size(108, 22);
            this.txtSearchClub.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orchid;
            this.button2.Location = new System.Drawing.Point(351, 88);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 30);
            this.button2.TabIndex = 64;
            this.button2.Text = "Search Club";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSearchStudent
            // 
            this.btSearchStudent.BackColor = System.Drawing.Color.Orchid;
            this.btSearchStudent.Location = new System.Drawing.Point(351, 329);
            this.btSearchStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearchStudent.Name = "btSearchStudent";
            this.btSearchStudent.Size = new System.Drawing.Size(132, 30);
            this.btSearchStudent.TabIndex = 63;
            this.btSearchStudent.Text = "Search Student";
            this.btSearchStudent.UseVisualStyleBackColor = false;
            this.btSearchStudent.Click += new System.EventHandler(this.btSearchStudent_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Crimson;
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.Location = new System.Drawing.Point(995, 428);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(95, 29);
            this.btDelete.TabIndex = 69;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Crimson;
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdd.Location = new System.Drawing.Point(717, 428);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(95, 29);
            this.btAdd.TabIndex = 70;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(858, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Club member";
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmID,
            this.sName,
            this.sfullName});
            this.dgvStudent.Location = new System.Drawing.Point(702, 236);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(442, 174);
            this.dgvStudent.TabIndex = 72;
            // 
            // cmID
            // 
            this.cmID.DataPropertyName = "cmID";
            this.cmID.HeaderText = "ID";
            this.cmID.MinimumWidth = 8;
            this.cmID.Name = "cmID";
            this.cmID.Width = 150;
            // 
            // sName
            // 
            this.sName.DataPropertyName = "sName";
            this.sName.HeaderText = "Club";
            this.sName.MinimumWidth = 8;
            this.sName.Name = "sName";
            this.sName.Width = 150;
            // 
            // sfullName
            // 
            this.sfullName.DataPropertyName = "sfullName";
            this.sfullName.HeaderText = "Student";
            this.sfullName.MinimumWidth = 8;
            this.sfullName.Name = "sfullName";
            this.sfullName.Width = 150;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "cID";
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 8;
            this.cID.Name = "cID";
            this.cID.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
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
            // aFullName
            // 
            this.aFullName.DataPropertyName = "aFullName";
            this.aFullName.HeaderText = "Creator";
            this.aFullName.MinimumWidth = 6;
            this.aFullName.Name = "aFullName";
            this.aFullName.Width = 125;
            // 
            // ClubM_V_CMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1175, 607);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dtGVStudent);
            this.Controls.Add(this.dtGVClub);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.txtSearchClub);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSearchStudent);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btResert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClubM_V_CMember";
            this.Text = "ClubM_V_CMember";
            this.Load += new System.EventHandler(this.ClubM_V_CMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btResert;
        private System.Windows.Forms.DataGridView dtGVStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn sID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSex;
        private System.Windows.Forms.DataGridView dtGVClub;
        private System.Windows.Forms.MaskedTextBox txtSearchStudent;
        private System.Windows.Forms.TextBox txtSearchClub;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSearchStudent;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPublicDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFullName;
    }
}