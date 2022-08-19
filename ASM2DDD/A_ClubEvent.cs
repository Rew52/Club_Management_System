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
    public partial class A_ClubEvent : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null; // conn đại điện sever
        public A_ClubEvent()
        {
            InitializeComponent();
        }

        private void btResert_Click(object sender, EventArgs e)// After clicking "Refresh" the program will run the following commands.
        {
            // Open connection
            conn = new SqlConnection(sqlconnect);
            conn.Open();
            // Create command object.
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select ClubEvent.ceID,Event.eName,Club.sName From ClubEvent,Event,Club where" +
                " ClubEvent.eID = Event.eID and ClubEvent.cID= Club.cID ";
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvStudent.DataSource = dtbl;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void A_ClubEvent_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlconnect);
            conn.Open();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Admin_Choose Admin_Choose = new Admin_Choose();
            Admin_Choose.ShowDialog();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Login login_form = new Login();
            login_form.ShowDialog();
        }

        // After clicking "Data Grit View Event" the program will run the following commands.
        private void dtGVClub_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "SELECT * FROM Event";
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dtGVEvent.Rows[index];
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
                cmd.CommandText = "SELECT * FROM Club where sName like @sName";
                cmd.Parameters.AddWithValue("sName", string.Format("%{0}%", txtSearchClub.Text));
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
        // After clicking "Data Grit View Club" the program will run the following commands.
        private void dtGVClub_CellClick_1(object sender, DataGridViewCellEventArgs e)// After clicking "Data Grit View Club" the program will run the following commands.
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
        // After clicking "Data Grit View Event" the program will run the following commands.
        private void dtGVEvent_CellClick(object sender, DataGridViewCellEventArgs e)// After clicking "Data Grit View Event" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "SELECT * FROM Event";
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dtGVEvent.Rows[index];
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

        private void button1_Click(object sender, EventArgs e)// After clicking "Search Event" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "SELECT * FROM Event where eName like @eName";
                cmd.Parameters.AddWithValue("eName", string.Format("%{0}%", txtEvent.Text));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtGVEvent.DataSource = dt;
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

        private void btAdd_Click(object sender, EventArgs e)// After clicking "Add" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                int id1 = Convert.ToInt32(dtGVClub.SelectedRows[0].Cells[0].Value);
                int id2 = Convert.ToInt32(dtGVEvent.SelectedRows[0].Cells[0].Value);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Club WHERE cID='" + id1 + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Event WHERE eID='" + id2 + "'", conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                // Create command
                cmd.CommandText = "Insert into ClubEvent values(@cID,@eID)";
                cmd.Parameters.AddWithValue("@cID", dt.Rows[0]["cID"].ToString());
                cmd.Parameters.AddWithValue("@eID", dt1.Rows[0]["eID"].ToString());
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
                MessageBox.Show("Add the club to the Event successfully!");
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
                cmd.CommandText = "Delete from ClubEvent where ceID= '" + idDelete + "'";
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
            }
        }
    }
}
