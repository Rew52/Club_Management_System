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
    public partial class A_EventM : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null; // conn đại điện sever
        public A_EventM()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void A_EventM_Load(object sender, EventArgs e)
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

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btResert_Click(object sender, EventArgs e)// After clicking "Refresh" the program will run the following commands.
        {
            using (SqlConnection sqlCon = new SqlConnection(sqlconnect))
            {
                // Create command object.
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From Event", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                // Dump data from database.
                dgvStudent.AutoGenerateColumns = false;
                dgvStudent.DataSource = dtbl;
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Login login_form = new Login();
            login_form.ShowDialog();
        }

        private void btRemove_Click(object sender, EventArgs e)// After clicking "Refresh Input" the program will run the following commands.
        {
            // Delete information available on textbox.
            txtName.Text = txtLocation.Text = txtCreator.Text = "";
        }

        private void btAdd_Click(object sender, EventArgs e)// After clicking "ADD" the program will run the following commands.
        {
            try
            {
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "insert into Event values(@eName,@eDay," + " @eLocation,@eCreator)";
                cmd.Parameters.Add("@eName", SqlDbType.NVarChar, 50).Value = txtName.Text;
                cmd.Parameters.Add("@eDay", SqlDbType.Date).Value = dtpPublicDate.Value;
                cmd.Parameters.Add("@eLocation", SqlDbType.NVarChar, 255).Value = txtLocation.Text;
                cmd.Parameters.Add("@eCreator", SqlDbType.Int).Value = txtCreator.Text;
                // Query execution.
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add success!", "Add");
            }
            // Notice errors to avoid interrupting the running system.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // After clicking "Data girt view" the program will run the following commands
        private void dgvA_EventM_CellClick(object sender, DataGridViewCellEventArgs e)
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
                DataGridViewRow selectedRow = dgvStudent.Rows[index];
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

        private void btEdit_Click(object sender, EventArgs e)// After clicking "Edit" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                int id = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells[0].Value);
                // Create command
                cmd.CommandText = "UPDATE Event SET eName = @eName, eDay =@eDay,eLocation = @eLocation," +
                    "eCreator= @eCreator WHERE eID ='" + id + "'";
                cmd.Parameters.AddWithValue("@eName", txtName.Text);
                cmd.Parameters.AddWithValue("@eDay", dtpPublicDate.Value);
                cmd.Parameters.AddWithValue("@eLocation", txtLocation.Text);
                cmd.Parameters.AddWithValue("@eCreator", txtCreator.Text);
                // Query execution.
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfull");
                // Close connection
                conn.Close();
            }
            // Notice errors to avoid interrupting the running system.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)// After clicking "Delete" the program will run the following commands.
        {
            if (MessageBox.Show("Are you want to delete?", "Delete data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                int id = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells[0].Value);
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "Delete from Event where eID= '" + id + "'";
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
            }
        }

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
                cmd.CommandText = "SELECT * FROM Event where eName like @eName or eLocation like @eLocation";
                cmd.Parameters.AddWithValue("eName", string.Format("%{0}%", txtSearch.Text));
                cmd.Parameters.AddWithValue("eLocation", string.Format("%{0}%", txtSearch.Text));
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
