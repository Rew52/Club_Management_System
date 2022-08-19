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
    public partial class A_StudentEvent : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null; // conn đại điện sever
        public A_StudentEvent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btResert_Click(object sender, EventArgs e) // After clicking "Refresh" the program will run the following commands.
        {
            // Open connection
            conn = new SqlConnection(sqlconnect);
            conn.Open();
            // Create command object.
            SqlCommand cmd = conn.CreateCommand();
            // Create command
            cmd.CommandText = "Select StudentEvent.seID,Event.eName,Student.sfullName From StudentEvent,Student,Event where" +
                " StudentEvent.eID = Event.eID and StudentEvent.sID=Student.sID ";
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            // Dump data from database.
            dgvStudent.DataSource = dtbl;
            // Query execution.
            cmd.ExecuteNonQuery();
            // Close connection
            conn.Close();
        }

        private void A_StudentEvent_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlconnect);
            conn.Open();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Login login_form = new Login();
            login_form.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Admin_Choose Admin_Choose = new Admin_Choose();
            Admin_Choose.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)// After clicking "Add" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                int id1 = Convert.ToInt32(dtGVStudent.SelectedRows[0].Cells[0].Value);
                int id2 = Convert.ToInt32(dtGVEvent.SelectedRows[0].Cells[0].Value);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student WHERE sID='" + id1 + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Event WHERE eID='" + id2 + "'", conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                // Create command
                cmd.CommandText = "Insert into StudentEvent values(@sID,@eID)";
                cmd.Parameters.AddWithValue("@sID", dt.Rows[0]["sID"].ToString());
                cmd.Parameters.AddWithValue("@eID", dt1.Rows[0]["eID"].ToString());
                // Query execution.
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Add the Student to the Event successfully!");
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

        // After clicking "Data girt view" the program will run the following commands
        // Dump data from database.

        // After clicking "Data girt view Student" the program will run the following commands
        private void dtGVStudent_CellClick(object sender, DataGridViewCellEventArgs e)
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

        // After clicking "Data girt view Event" the program will run the following commands
        private void dtGVEvent_CellClick(object sender, DataGridViewCellEventArgs e)
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

        // After clicking "Search Student" the program will run the following commands.
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
                cmd.CommandText = "SELECT * FROM Student where sfullName like @sfullName";
                cmd.Parameters.AddWithValue("sfullName", string.Format("%{0}%", txtSearchStudent.Text));
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

        // After clicking "Search Event" the program will run the following commands.
        private void btSearchEvent_Click(object sender, EventArgs e)// After clicking "Search Event" the program will run the following commands.
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
                cmd.Parameters.AddWithValue("eName", string.Format("%{0}%", txtSearchEvent.Text));
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
                cmd.CommandText = "Delete from StudentEvent where seID= '" + idDelete + "'";
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
            }
        }
    }
}
