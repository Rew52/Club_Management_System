using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ASM2DDD
{
    public partial class Login : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null; // conn đại điện sever

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlconnect);
            conn.Open();
        }

        private void btExit_Click(object sender, EventArgs e) //After clicking "Exit" the program will run the following commands.
        {
            Application.Exit(); // Close program
        }

        private void btLogin_Click(object sender, EventArgs e) //After clicking "Login" the program will run the following commands.
        {
            try 
            {
                // Database query statement.
                SqlDataAdapter da = new SqlDataAdapter("SELECT (CASE role WHEN 1 THEN 'Admin' WHEN 2 THEN 'ClubManager' WHEN 3 THEN 'User' END) " +
                    "AS Role FROM users WHERE username ='" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1) //Database with data will run the cases.
                {
                    this.Hide();
                    switch (dt.Rows[0]["Role"] as string)
                    {
                        case "Admin": // Notice and move to Administrator rights and close the Login page.
                            MessageBox.Show("Admin login successfully!");
                            Admin_Choose Admin_Choose = new Admin_Choose();
                            Admin_Choose.ShowDialog();
                            this.Close();
                            break;
                        case "ClubManager": // Notice and move to Club Manager rights and close the Login page.
                            MessageBox.Show("Club Manager login successfully!");
                            ClubManager_Choose ClubManager_Choose = new ClubManager_Choose();
                            ClubManager_Choose.ShowDialog();
                            this.Close();
                            break;
                        case "User": // Notice and move to Student rights and close the Login page.
                            MessageBox.Show("User login successfully!");
                            User_Choose User_Choose = new User_Choose();
                            User_Choose.ShowDialog();
                            this.Close();
                            break;
                    }
                }
                else // If you enter incorrect information, you will be notified
                {
                    MessageBox.Show("Invalid Username or password"); 
                }
            }
            catch (SqlException ex) // Notice errors to avoid interrupting the running system.
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRemove_Click(object sender, EventArgs e) // After clicking "Refresh" the program will run the following commands.
        {
            txtPassword.Text = txtUsername.Text = ""; // Delete information available on textbox.
        }
    }
}
