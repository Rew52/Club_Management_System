namespace ASM2DDD
{
    partial class User_V_Event
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
            this.btLogout = new System.Windows.Forms.Button();
            this.btResert = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.eName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkMagenta;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(213, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 31);
            this.label11.TabIndex = 92;
            this.label11.Text = "Information Events!";
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogout.Location = new System.Drawing.Point(534, 52);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(81, 30);
            this.btLogout.TabIndex = 91;
            this.btLogout.Text = "Log Out";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click_1);
            // 
            // btResert
            // 
            this.btResert.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btResert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btResert.Location = new System.Drawing.Point(175, 314);
            this.btResert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResert.Name = "btResert";
            this.btResert.Size = new System.Drawing.Size(81, 28);
            this.btResert.TabIndex = 90;
            this.btResert.Text = "Refresh";
            this.btResert.UseVisualStyleBackColor = false;
            this.btResert.Click += new System.EventHandler(this.btResert_Click_1);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBack.Location = new System.Drawing.Point(380, 314);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(81, 28);
            this.btBack.TabIndex = 89;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click_1);
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eName,
            this.aFullName,
            this.eLocation,
            this.eDay});
            this.dgvStudent.Location = new System.Drawing.Point(34, 129);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(581, 165);
            this.dgvStudent.TabIndex = 88;
            // 
            // eName
            // 
            this.eName.DataPropertyName = "eName";
            this.eName.HeaderText = "Name";
            this.eName.MinimumWidth = 8;
            this.eName.Name = "eName";
            this.eName.Width = 150;
            // 
            // aFullName
            // 
            this.aFullName.DataPropertyName = "aFullName";
            this.aFullName.HeaderText = "Creator";
            this.aFullName.MinimumWidth = 8;
            this.aFullName.Name = "aFullName";
            this.aFullName.Width = 150;
            // 
            // eLocation
            // 
            this.eLocation.DataPropertyName = "eLocation";
            this.eLocation.HeaderText = "Location";
            this.eLocation.MinimumWidth = 8;
            this.eLocation.Name = "eLocation";
            this.eLocation.Width = 150;
            // 
            // eDay
            // 
            this.eDay.DataPropertyName = "eDay";
            this.eDay.HeaderText = "Day";
            this.eDay.MinimumWidth = 8;
            this.eDay.Name = "eDay";
            this.eDay.Width = 150;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.Location = new System.Drawing.Point(381, 86);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(95, 29);
            this.btSearch.TabIndex = 94;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(175, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 22);
            this.txtSearch.TabIndex = 93;
            // 
            // User_V_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(650, 363);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btResert);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.dgvStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_V_Event";
            this.Text = "User_V_Event";
            this.Load += new System.EventHandler(this.User_V_Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btResert;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn eName;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDay;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}