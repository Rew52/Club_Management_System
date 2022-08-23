using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2DDD
{
    public partial class ClubManager_Choose : Form
    {
        public ClubManager_Choose()
        {
            InitializeComponent();
        }

        private void btViewClub_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            ClubManager_V_Club ClubManager_V_Club = new ClubManager_V_Club();
            ClubManager_V_Club.ShowDialog();
        }

        //After clicking "View Clubs information" the program will run the following commands.
        private void btViewClubM_Click(object sender, EventArgs e) 
        {
            // Close current page.
            this.Close();
            // Open View Clubs information.
            this.Hide();
            ClubM_V_CMember ClubM_V_CMember = new ClubM_V_CMember();
            ClubM_V_CMember.ShowDialog();
        }

        private void btViewStudentEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClubM_StudentE ClubM_StudentE = new ClubM_StudentE();
            ClubM_StudentE.ShowDialog();
            this.Close();
        }

        private void btViewClubEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClubM_ClubEvent ClubM_ClubEvent = new ClubM_ClubEvent();
            ClubM_ClubEvent.ShowDialog();
            this.Close();
        }

        private void btViewEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClubM_Event ClubM_Event = new ClubM_Event();
            ClubM_Event.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to exit your account?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {   // Close current page.
                this.Close();
                // Open the page you want to go to.
                this.Hide();
                Login login_form = new Login();
                login_form.ShowDialog();
            }
        }
    }
}
