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
    public partial class User_Choose : Form
    {
        public User_Choose()
        {
            InitializeComponent();
        }
        private void btViewClub_Click(object sender, EventArgs e)// After clicking "View Clubs information!" the program will run the following commands.
        {
            // Close current page.
            this.Close();
            // Open the page you want to go
            this.Hide();
            User_V_Club User_V_Club = new User_V_Club();
            User_V_Club.ShowDialog();
        }

        private void btViewEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_V_Event User_V_Event = new User_V_Event();
            User_V_Event.ShowDialog();
            this.Close();
        }

        private void btViewClubEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_ClubEvent User_ClubEvent = new User_ClubEvent();
            User_ClubEvent.ShowDialog();
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
