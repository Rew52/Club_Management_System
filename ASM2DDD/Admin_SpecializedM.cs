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
    public partial class Admin_SpecializedM : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null; // conn đại điện sever
        public Admin_SpecializedM()
        {
            InitializeComponent();
        }

        private void Admin_SpecializedM_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlconnect);
            conn.Open();
        }

        private void btResert_Click(object sender, EventArgs e)// After clicking "Refresh" the program will run the following commands.
        {
            using (SqlConnection sqlCon = new SqlConnection(sqlconnect))
            {
                // Open connection
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From Major", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvStudent.AutoGenerateColumns = false;
                dgvStudent.DataSource = dtbl;
            }
        }

        // After clicking "Data grit view" the program will run the following commands.
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "SELECT * FROM Major";
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
        // After clicking "Search" the program will run the following commands.
        // Open connection
        // Create command object.
        // Create command
        // Query execution.
        // Close connection
        // Notice errors to avoid interrupting the running system.

        // Delete information available on textbox.
        // After clicking "Data girt view" the program will run the following commands.
        private void btAdd_Click(object sender, EventArgs e)// After clicking "Add" the program will run the following commands.
        {
            try
            {
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "insert into Major values(@mName)";
                cmd.Parameters.Add("@mName", SqlDbType.NVarChar, 40).Value = txtName.Text;
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
                cmd.CommandText = "UPDATE Major SET mName = @mName WHERE mID ='" + id + "'";
                cmd.Parameters.AddWithValue("@mName", txtName.Text);
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
                cmd.CommandText = "Delete from Major where mID= '" + id + "'";
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
            }
        }

        private void btRemove_Click(object sender, EventArgs e)// After clicking "Refresh Input" the program will run the following commands.
        {
            // Delete information available on textbox.
            txtName.Text = "";
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
                cmd.CommandText = "SELECT * FROM Major where mName like @mName";
                cmd.Parameters.AddWithValue("mName", string.Format("%{0}%", txtSearch.Text));
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
