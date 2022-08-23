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
    public partial class ClubM_V_CMember : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null;
        public ClubM_V_CMember()
        {
            InitializeComponent();
        }

        private void ClubM_V_CMember_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlconnect);
            conn.Open();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btResert_Click(object sender, EventArgs e)// After clicking "Refresh" the program will run the following commands.
        {
            // Open connection
            conn = new SqlConnection(sqlconnect);
            conn.Open();
            // Create command object.
            SqlCommand cmd = conn.CreateCommand();
            // Create command
            cmd.CommandText = "Select ClubMember.cmID,Club.sName,Student.sfullName From ClubMember,Student,Club where " +
                "ClubMember.cID = Club.cID and ClubMember.sID=Student.sID ";
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvStudent.DataSource = dtbl;
            // Query execution.
            cmd.ExecuteNonQuery();
            // Close connection
            conn.Close();
        }

        private void btLogout_Click(object sender, EventArgs e)
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
        private void btBack_Click(object sender, EventArgs e)// After clicking "Back" the program will run the following commands.
        {
            // Close current page.
            this.Close();
            // Open the page you want to go to.
            this.Hide();
            ClubManager_Choose ClubManager_Choose = new ClubManager_Choose();
            ClubManager_Choose.ShowDialog();
        }
        // After clicking "Data Grit View Club" the program will run the following commands.
        private void dtGVClub_CellClick(object sender, DataGridViewCellEventArgs e)// After clicking "Data Grit View Club" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "SELECT * FROM Club";
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dtGVClub.Rows[index];
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
        // After clicking "Data Grit View Student" the program will run the following commands.
        private void dtGVStudent_CellClick(object sender, DataGridViewCellEventArgs e)// After clicking "Data Grit View Student" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "SELECT * FROM Student";
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dtGVStudent.Rows[index];
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
        // After clicking "Search" the program will run the following commands.
        // Open connection
        // Create command object.
        // Create command
        // Query execution.
        // Close connection
        // Notice errors to avoid interrupting the running system.

        // Delete information available on textbox.
        // After clicking "Data Grit View Club" the program will run the following commands.
        private void button2_Click(object sender, EventArgs e)// After clicking "Search Club" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "SELECT Club.cID,Club.sName,Club.cPublicDate,Club.cManager,Admin.aFullName FROM " +
                    "Club,Admin Where Club.cCreator = Admin.aID AND cID like @cID or aFullName like @aFullName or sName like @sName";
                cmd.Parameters.AddWithValue("cID", string.Format("%{0}%", txtSearchClub.Text));
                cmd.Parameters.AddWithValue("sName", string.Format("%{0}%", txtSearchClub.Text));
                cmd.Parameters.AddWithValue("aFullName", string.Format("%{0}%", txtSearchClub.Text));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtGVClub.DataSource = dt;
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

        private void btSearchStudent_Click(object sender, EventArgs e)// After clicking "Search Student" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "SELECT Student.sID,Student.sfullName,Student.sEmail,Student.sSex FROM Student where " +
                    "sfullName like @sfullName or sSex like @sSex or sID like @sID or sEmail like @sEmail";
                cmd.Parameters.AddWithValue("sfullName", string.Format("%{0}%", txtSearchStudent.Text));
                cmd.Parameters.AddWithValue("sID", string.Format("%{0}%", txtSearchStudent.Text));
                cmd.Parameters.AddWithValue("sEmail", string.Format("%{0}%", txtSearchStudent.Text));
                cmd.Parameters.AddWithValue("sSex", string.Format("%{0}%", txtSearchStudent.Text));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtGVStudent.DataSource = dt;
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

        private void btAdd_Click(object sender, EventArgs e)// After clicking "ADD" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                int id1 = Convert.ToInt32(dtGVClub.SelectedRows[0].Cells[0].Value);
                int id2 = Convert.ToInt32(dtGVStudent.SelectedRows[0].Cells[0].Value);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Club WHERE cID='" + id1 + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Student WHERE sID='" + id2 + "'", conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                // Create command
                cmd.CommandText = "Insert into ClubMember values(@cID,@sID)";
                cmd.Parameters.AddWithValue("@cID", dt.Rows[0]["cID"].ToString());
                cmd.Parameters.AddWithValue("@sID", dt1.Rows[0]["sID"].ToString());
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
                MessageBox.Show("Add Successful");
            }
            // Notice errors to avoid interrupting the running system.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)// After clicking "Delete" the program will run the following commands.
        {
            if (MessageBox.Show("Do you want to delete?", "Delete data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                int idDelete = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells[0].Value);
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "Delete from ClubMember where cmID= '" + idDelete + "'";
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
            }
        }

        private void dgvClubMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtGVClub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
