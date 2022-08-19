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
    public partial class ClubManager_V_Club : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null; // conn đại điện sever
        public ClubManager_V_Club()
        {
            InitializeComponent();
        }

        private void ClubManager_V_Club_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlconnect);
            conn.Open();
        }

        private void btResert_Click(object sender, EventArgs e)// After clicking "Refesh" the program will run the following commands.
        {
            // Open connection
            conn = new SqlConnection(sqlconnect);
            conn.Open();
            // Create command object.
            SqlCommand cmd = conn.CreateCommand();
            // Create command
            cmd.CommandText = "Select Club.sName,Admin.aFullName,Student.sfullName,Club.cPublicDate From Club,Student,Admin where" +
                " Club.cID = Student.sID and Club.cID = Admin.aID ";
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvStudent.DataSource = dtbl;
            // Query execution.
            cmd.ExecuteNonQuery();
            // Close connection
            conn.Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            ClubManager_Choose ClubManager_Choose = new ClubManager_Choose();
            ClubManager_Choose.ShowDialog();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Login login_form = new Login();
            login_form.ShowDialog();
        }
        // After clicking "Search" the program will run the following commands.
        // Open connection
        // Create command object.
        // Create command
        // Query execution.
        // Close connection
        // Notice errors to avoid interrupting the running system.

        // Delete information available on textbox.
        // After clicking "Data Grit View Club" the program will run the following commands.
        private void btSearch_Click(object sender, EventArgs e)// After clicking "Search" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "Select Club.sName,Admin.aFullName,Student.sfullName,Club.cPublicDate From Club,Student,Admin where" +
                " Club.cID = Student.sID and Club.cID = Admin.aID and sName like @sName or aFullName like @aFullName or sfullName like @sfullName";
                cmd.Parameters.AddWithValue("sName", string.Format("%{0}%", txtSearch.Text));
                cmd.Parameters.AddWithValue("aFullName", string.Format("%{0}%", txtSearch.Text));
                cmd.Parameters.AddWithValue("sfullName", string.Format("%{0}%", txtSearch.Text));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStudent.DataSource = dt;
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
            }
            // Notice errors to avoid interrupting the running system.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
