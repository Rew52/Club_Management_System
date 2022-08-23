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
    public partial class Admin_Choose : Form
    {
        public Admin_Choose()
        {
            InitializeComponent();
        }

        private void btStudentM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_01 Admin_01 = new Admin_01();
            Admin_01.ShowDialog();
            this.Close();
        }

        private void btClubManage_Click(object sender, EventArgs e) //After clicking "Club Manage" the program will run the following commands.
        {
            this.Hide(); // Open Club Magage.
            Admin_02_Club Admin_02_Club = new Admin_02_Club();
            Admin_02_Club.ShowDialog(); 
            this.Close(); // Close current page.
        }
        private void btManageMem_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_MemberClub A_MemberClub = new A_MemberClub();
            A_MemberClub.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //After clicking "Log out" the program will run the following commands.
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

        private void btManageEvent_Click(object sender, EventArgs e) //After clicking "Log Out" the program will run the following commands
        {
            this.Close(); // Close the function selection page for Administrator.
            this.Hide(); // Open account login page.
            A_EventM A_EventM = new A_EventM();
            A_EventM.ShowDialog();
        }
        
        private void btManageStudentE_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_StudentEvent A_StudentEvent = new A_StudentEvent();
            A_StudentEvent.ShowDialog();
            this.Close();
        }
        
        private void btSpecializedManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_SpecializedM Admin_SpecializedM = new Admin_SpecializedM();
            Admin_SpecializedM.ShowDialog();
            this.Close();
        }
        private void btClubEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_ClubEvent A_ClubEvent = new A_ClubEvent();
            A_ClubEvent.ShowDialog();
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_Active_Report A_Active_Report = new A_Active_Report();
            A_Active_Report.ShowDialog();
            this.Close();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
