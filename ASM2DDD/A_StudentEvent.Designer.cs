namespace ASM2DDD
{
    partial class A_StudentEvent
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
            this.btRefresh = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.seID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchEvent = new System.Windows.Forms.TextBox();
            this.btSearchEvent = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btSearchStudent = new System.Windows.Forms.Button();
            this.dtGVEvent = new System.Windows.Forms.DataGridView();
            this.eID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtGVStudent = new System.Windows.Forms.DataGridView();
            this.sID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhoneN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Orchid;
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBack.Location = new System.Drawing.Point(594, 614);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(88, 30);
            this.btBack.TabIndex = 57;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogout.Location = new System.Drawing.Point(1098, 94);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(88, 30);
            this.btLogout.TabIndex = 56;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(359, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "Manage students participating in the Event!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Orchid;
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRefresh.Location = new System.Drawing.Point(901, 430);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(96, 29);
            this.btRefresh.TabIndex = 54;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btResert_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seID,
            this.eName,
            this.sfullName});
            this.dgvStudent.Location = new System.Drawing.Point(711, 230);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(475, 174);
            this.dgvStudent.TabIndex = 53;
            // 
            // seID
            // 
            this.seID.DataPropertyName = "seID";
            this.seID.HeaderText = "ID";
            this.seID.MinimumWidth = 8;
            this.seID.Name = "seID";
            this.seID.Width = 150;
            // 
            // eName
            // 
            this.eName.DataPropertyName = "eName";
            this.eName.HeaderText = "Event";
            this.eName.MinimumWidth = 8;
            this.eName.Name = "eName";
            this.eName.Width = 150;
            // 
            // sfullName
            // 
            this.sfullName.DataPropertyName = "sfullName";
            this.sfullName.HeaderText = "Student";
            this.sfullName.MinimumWidth = 8;
            this.sfullName.Name = "sfullName";
            this.sfullName.Width = 150;
            // 
            // txtSearchEvent
            // 
            this.txtSearchEvent.Location = new System.Drawing.Point(213, 379);
            this.txtSearchEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchEvent.Name = "txtSearchEvent";
            this.txtSearchEvent.Size = new System.Drawing.Size(108, 22);
            this.txtSearchEvent.TabIndex = 71;
            // 
            // btSearchEvent
            // 
            this.btSearchEvent.BackColor = System.Drawing.Color.Orchid;
            this.btSearchEvent.Location = new System.Drawing.Point(359, 374);
            this.btSearchEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearchEvent.Name = "btSearchEvent";
            this.btSearchEvent.Size = new System.Drawing.Size(108, 30);
            this.btSearchEvent.TabIndex = 70;
            this.btSearchEvent.Text = "Search Event";
            this.btSearchEvent.UseVisualStyleBackColor = false;
            this.btSearchEvent.Click += new System.EventHandler(this.btSearchEvent_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(213, 94);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(108, 22);
            this.txtSearchStudent.TabIndex = 69;
            // 
            // btSearchStudent
            // 
            this.btSearchStudent.BackColor = System.Drawing.Color.Orchid;
            this.btSearchStudent.Location = new System.Drawing.Point(359, 90);
            this.btSearchStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearchStudent.Name = "btSearchStudent";
            this.btSearchStudent.Size = new System.Drawing.Size(133, 30);
            this.btSearchStudent.TabIndex = 68;
            this.btSearchStudent.Text = "Search Student";
            this.btSearchStudent.UseVisualStyleBackColor = false;
            this.btSearchStudent.Click += new System.EventHandler(this.btSearchStudent_Click);
            // 
            // dtGVEvent
            // 
            this.dtGVEvent.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dtGVEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eID,
            this.dataGridViewTextBoxColumn2,
            this.eDay,
            this.eLocation,
            this.eCreator});
            this.dtGVEvent.Location = new System.Drawing.Point(54, 430);
            this.dtGVEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGVEvent.Name = "dtGVEvent";
            this.dtGVEvent.RowHeadersWidth = 62;
            this.dtGVEvent.RowTemplate.Height = 28;
            this.dtGVEvent.Size = new System.Drawing.Size(590, 150);
            this.dtGVEvent.TabIndex = 67;
            this.dtGVEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVEvent_CellClick);
            // 
            // eID
            // 
            this.eID.DataPropertyName = "eID";
            this.eID.HeaderText = "ID";
            this.eID.MinimumWidth = 8;
            this.eID.Name = "eID";
            this.eID.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "eName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
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
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Orchid;
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.Location = new System.Drawing.Point(1065, 430);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 29);
            this.btDelete.TabIndex = 72;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Orchid;
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdd.Location = new System.Drawing.Point(733, 430);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 29);
            this.btAdd.TabIndex = 73;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtGVStudent
            // 
            this.dtGVStudent.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dtGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sID,
            this.dataGridViewTextBoxColumn1,
            this.sAge,
            this.sPhoneN,
            this.sEmail,
            this.sMajor,
            this.sSex,
            this.sAddress});
            this.dtGVStudent.Location = new System.Drawing.Point(54, 145);
            this.dtGVStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGVStudent.Name = "dtGVStudent";
            this.dtGVStudent.RowHeadersWidth = 62;
            this.dtGVStudent.RowTemplate.Height = 28;
            this.dtGVStudent.Size = new System.Drawing.Size(590, 190);
            this.dtGVStudent.TabIndex = 74;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sfullName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // sAge
            // 
            this.sAge.DataPropertyName = "sAge";
            this.sAge.HeaderText = "Age";
            this.sAge.MinimumWidth = 8;
            this.sAge.Name = "sAge";
            this.sAge.Width = 150;
            // 
            // sPhoneN
            // 
            this.sPhoneN.DataPropertyName = "sPhoneN";
            this.sPhoneN.HeaderText = "Phone Number";
            this.sPhoneN.MinimumWidth = 8;
            this.sPhoneN.Name = "sPhoneN";
            this.sPhoneN.Width = 150;
            // 
            // sEmail
            // 
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.MinimumWidth = 8;
            this.sEmail.Name = "sEmail";
            this.sEmail.Width = 150;
            // 
            // sMajor
            // 
            this.sMajor.DataPropertyName = "sMajor";
            this.sMajor.HeaderText = "Major";
            this.sMajor.MinimumWidth = 8;
            this.sMajor.Name = "sMajor";
            this.sMajor.Width = 150;
            // 
            // sSex
            // 
            this.sSex.DataPropertyName = "sSex";
            this.sSex.HeaderText = "Sex";
            this.sSex.MinimumWidth = 8;
            this.sSex.Name = "sSex";
            this.sSex.Width = 150;
            // 
            // sAddress
            // 
            this.sAddress.DataPropertyName = "sAddress";
            this.sAddress.HeaderText = "Address";
            this.sAddress.MinimumWidth = 8;
            this.sAddress.Name = "sAddress";
            this.sAddress.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(923, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "Manage";
            // 
            // A_StudentEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1234, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGVStudent);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.txtSearchEvent);
            this.Controls.Add(this.btSearchEvent);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.btSearchStudent);
            this.Controls.Add(this.dtGVEvent);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.dgvStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "A_StudentEvent";
            this.Text = "A_StudentEvent";
            this.Load += new System.EventHandler(this.A_StudentEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn seID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfullName;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.TextBox txtSearchEvent;
        private System.Windows.Forms.Button btSearchEvent;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btSearchStudent;
        private System.Windows.Forms.DataGridView dtGVEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn eID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCreator;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dtGVStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn sID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhoneN;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddress;
        private System.Windows.Forms.Label label2;
    }
}