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
    public partial class Admin_02_Club : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null; // conn đại điện sever
        public Admin_02_Club()
        {
            InitializeComponent();
        }

        private void Admin_02_Club_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlconnect);
            conn.Open();
        }

        private void btExit_Click(object sender, EventArgs e)// After clicking "Back" the program will run the following commands.
        {
            // Close current page.
            this.Close();
            // Open the page you want to go to.
            this.Hide();
            Admin_Choose Admin_Choose = new Admin_Choose();
            Admin_Choose.ShowDialog();
        }

        private void btResert_Click(object sender, EventArgs e)// After clicking "Refresh" the program will run the following commands.
        {
            using (SqlConnection sqlCon = new SqlConnection(sqlconnect))
            {
                // Open connection
                sqlCon.Open();
                // Database query
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From Club", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                // Dump data from database.
                dgvStudent.AutoGenerateColumns = false;
                dgvStudent.DataSource = dtbl;
            }
        }

        private void btStudent_Click(object sender, EventArgs e)
        {
        }

        private void btAdd_Click(object sender, EventArgs e) // After clicking "ADD" the program will run the following commands.
        {
            try
            {
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into Club values(@sName,@cPublicDate," + " @cManager,@cCreator)";
                // Create parameter and assign value to parameter.
                cmd.Parameters.Add("@sName", SqlDbType.NVarChar, 40).Value = txtName.Text;
                cmd.Parameters.Add("@cPublicDate", SqlDbType.Date).Value = dtpPublicDate.Value;
                cmd.Parameters.Add("@cManager", SqlDbType.Int).Value = txtManager.Text;
                cmd.Parameters.Add("@cCreator", SqlDbType.Int).Value = txtCreator.Text;
                // Query execution.
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add success!", "Add");
            }
            catch (SqlException ex) // Notice errors to avoid interrupting the running system.
            {
                MessageBox.Show(ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btEdit_Click(object sender, EventArgs e) // After clicking "Edit" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                int id = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells[0].Value);
                // Database query
                cmd.CommandText = "UPDATE Club SET sName = @sName, cPublicDate =@cPublicDate,cManager = @cManager," +
                    "cCreator= @cCreator WHERE cID ='" + id + "'"; 
                // Get information from input data
                cmd.Parameters.AddWithValue("@sName", txtName.Text);
                cmd.Parameters.AddWithValue("@cPublicDate", dtpPublicDate.Value);
                cmd.Parameters.AddWithValue("@cManager", txtManager.Text);
                cmd.Parameters.AddWithValue("@cCreator", txtCreator.Text);
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

        private void btDelete_Click(object sender, EventArgs e) // After clicking "Delete" the program will run the following commands.
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
                // Database query
                cmd.CommandText = "Delete from Club where cID= '" + id + "'";
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
            }
        }

        private void btLogout_Click(object sender, EventArgs e)// After clicking "Log out" the program will run the following commands.
        {
            // Close current page.
            this.Close();
            // Open the page you want to go to.
            this.Hide();
            Login login_form = new Login();
            login_form.ShowDialog();
        }

        private void btRemove_Click(object sender, EventArgs e)// After clicking "Refresh Input" the program will run the following commands.
        {
            // Delete information available on textbox.
            txtName.Text = txtManager.Text = txtCreator.Text = "";
        }

        // After clicking "Data girt view" the program will run the following commands.
        private void dgvA_ClubM_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Database query
                cmd.CommandText = "SELECT * FROM Club";
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

        private void btSearch_Click(object sender, EventArgs e) // After clicking "Search" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Database query
                cmd.CommandText = "SELECT * FROM Club Where cID like @cID or sName like @sName";
                cmd.Parameters.AddWithValue("cID", string.Format("%{0}%", txtSearch.Text));
                cmd.Parameters.AddWithValue("sName", string.Format("%{0}%", txtSearch.Text));
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
