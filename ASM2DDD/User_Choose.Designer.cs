namespace ASM2DDD
{
    partial class User_Choose
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
            this.btViewEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btViewClubEvent = new System.Windows.Forms.Button();
            this.btViewClub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btViewEvent
            // 
            this.btViewEvent.BackColor = System.Drawing.Color.Brown;
            this.btViewEvent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btViewEvent.Location = new System.Drawing.Point(265, 109);
            this.btViewEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btViewEvent.Name = "btViewEvent";
            this.btViewEvent.Size = new System.Drawing.Size(161, 59);
            this.btViewEvent.TabIndex = 26;
            this.btViewEvent.Text = "View Event information!";
            this.btViewEvent.UseVisualStyleBackColor = false;
            this.btViewEvent.Click += new System.EventHandler(this.btViewEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(221, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Please choose the function!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(559, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 24;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btViewClubEvent
            // 
            this.btViewClubEvent.BackColor = System.Drawing.Color.Chocolate;
            this.btViewClubEvent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btViewClubEvent.Location = new System.Drawing.Point(496, 109);
            this.btViewClubEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btViewClubEvent.Name = "btViewClubEvent";
            this.btViewClubEvent.Size = new System.Drawing.Size(180, 59);
            this.btViewClubEvent.TabIndex = 23;
            this.btViewClubEvent.Text = "View information about the Club participating in the Event!";
            this.btViewClubEvent.UseVisualStyleBackColor = false;
            this.btViewClubEvent.Click += new System.EventHandler(this.btViewClubEvent_Click);
            // 
            // btViewClub
            // 
            this.btViewClub.BackColor = System.Drawing.Color.SaddleBrown;
            this.btViewClub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btViewClub.Location = new System.Drawing.Point(38, 109);
            this.btViewClub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btViewClub.Name = "btViewClub";
            this.btViewClub.Size = new System.Drawing.Size(158, 59);
            this.btViewClub.TabIndex = 20;
            this.btViewClub.Text = "View Clubs information!";
            this.btViewClub.UseVisualStyleBackColor = false;
            this.btViewClub.Click += new System.EventHandler(this.btViewClub_Click);
            // 
            // User_Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(699, 209);
            this.Controls.Add(this.btViewEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btViewClubEvent);
            this.Controls.Add(this.btViewClub);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_Choose";
            this.Text = "User_Choose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btViewEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btViewClubEvent;
        private System.Windows.Forms.Button btViewClub;
    }
}