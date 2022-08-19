namespace ASM2DDD
{
    partial class A_ClubEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.ceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBack = new System.Windows.Forms.Button();
            this.dtGVClub = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPublicDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGVEvent = new System.Windows.Forms.DataGridView();
            this.eID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchClub = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogout.Location = new System.Drawing.Point(1066, 56);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(87, 30);
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
            this.label1.Location = new System.Drawing.Point(401, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "Club Manager participates in Event!";
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Orchid;
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRefresh.Location = new System.Drawing.Point(877, 451);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 30);
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
            this.ceID,
            this.eName,
            this.sName});
            this.dgvStudent.Location = new System.Drawing.Point(694, 254);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(459, 174);
            this.dgvStudent.TabIndex = 53;
            // 
            // ceID
            // 
            this.ceID.DataPropertyName = "ceID";
            this.ceID.HeaderText = "ID";
            this.ceID.MinimumWidth = 8;
            this.ceID.Name = "ceID";
            this.ceID.Width = 150;
            // 
            // eName
            // 
            this.eName.DataPropertyName = "eName";
            this.eName.HeaderText = "Event";
            this.eName.MinimumWidth = 8;
            this.eName.Name = "eName";
            this.eName.Width = 150;
            // 
            // sName
            // 
            this.sName.DataPropertyName = "sName";
            this.sName.HeaderText = "Club";
            this.sName.MinimumWidth = 8;
            this.sName.Name = "sName";
            this.sName.Width = 150;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Orchid;
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBack.Location = new System.Drawing.Point(589, 593);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(87, 30);
            this.btBack.TabIndex = 57;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // dtGVClub
            // 
            this.dtGVClub.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dtGVClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.dataGridViewTextBoxColumn1,
            this.cPublicDate,
            this.cManager});
            this.dtGVClub.Location = new System.Drawing.Point(55, 140);
            this.dtGVClub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGVClub.Name = "dtGVClub";
            this.dtGVClub.RowHeadersWidth = 62;
            this.dtGVClub.RowTemplate.Height = 28;
            this.dtGVClub.Size = new System.Drawing.Size(590, 150);
            this.dtGVClub.TabIndex = 60;
            this.dtGVClub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVClub_CellClick_1);
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
            this.dtGVEvent.Location = new System.Drawing.Point(55, 404);
            this.dtGVEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGVEvent.Name = "dtGVEvent";
            this.dtGVEvent.RowHeadersWidth = 62;
            this.dtGVEvent.RowTemplate.Height = 28;
            this.dtGVEvent.Size = new System.Drawing.Size(590, 150);
            this.dtGVEvent.TabIndex = 61;
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
            // txtSearchClub
            // 
            this.txtSearchClub.Location = new System.Drawing.Point(211, 93);
            this.txtSearchClub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchClub.Name = "txtSearchClub";
            this.txtSearchClub.Size = new System.Drawing.Size(108, 22);
            this.txtSearchClub.TabIndex = 63;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orchid;
            this.button2.Location = new System.Drawing.Point(357, 88);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 30);
            this.button2.TabIndex = 62;
            this.button2.Text = "Search Club";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(211, 363);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(108, 22);
            this.txtEvent.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.Location = new System.Drawing.Point(357, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 64;
            this.button1.Text = "Search Event";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Orchid;
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdd.Location = new System.Drawing.Point(717, 451);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(95, 30);
            this.btAdd.TabIndex = 66;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(890, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Manage";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Orchid;
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.Location = new System.Drawing.Point(1028, 451);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(95, 30);
            this.btDelete.TabIndex = 68;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // A_ClubEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1193, 636);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearchClub);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtGVEvent);
            this.Controls.Add(this.dtGVClub);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.dgvStudent);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "A_ClubEvent";
            this.Text = "A_ClubEvent";
            this.Load += new System.EventHandler(this.A_ClubEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridView dtGVClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPublicDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cManager;
        private System.Windows.Forms.DataGridView dtGVEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn eID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCreator;
        private System.Windows.Forms.TextBox txtSearchClub;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDelete;
    }
}