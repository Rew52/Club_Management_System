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
    public partial class Admin_01 : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null; // conn đại điện sever
        public Admin_01()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// After clicking "Edit" the program will run the following commands.
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                int id = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells[0].Value);
                cmd.CommandText = "UPDATE Student SET sfullName = @sfullName, sAge =@sAge,sPhoneN = @sPhoneN,sEmail= @sEmail," +
                    "sMajor =@sMajor,sSex=@sSex,sAddress=@sAddress WHERE sID ='"+id+"'";
                // Get information from input data
                cmd.Parameters.AddWithValue("@sfullName", txtFullname.Text);
                cmd.Parameters.AddWithValue("@sAge", txtAge.Text);
                cmd.Parameters.AddWithValue("@sPhoneN", txtPhoneN.Text);
                cmd.Parameters.AddWithValue("@sEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@sMajor", txtMajor.Text);
                cmd.Parameters.AddWithValue("@sSex", txtSex.Text);
                cmd.Parameters.AddWithValue("@sAddress", txtAddress.Text);
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                MessageBox.Show("Update Successfull");
                conn.Close();
            }
            // Notice errors to avoid interrupting the running system.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Admin_01_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlconnect);
            conn.Open();
        }

        private void btAdd_Click(object sender, EventArgs e)// After clicking "ADD" the program will run the following commands.
        {
            try
            {
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into Student values(@sfullName,@sAge," + " @sPhoneN,@sEmail,@sMajor,@sSex,@sAddress)";
                // Create parameter and assign value to parameter.
                cmd.Parameters.Add("@sfullName", SqlDbType.NVarChar, 40).Value = txtFullname.Text;
                cmd.Parameters.Add("@sAge", SqlDbType.Int).Value = txtAge.Text;
                cmd.Parameters.Add("@sPhoneN", SqlDbType.Int).Value = txtPhoneN.Text;
                cmd.Parameters.Add("@sEmail", SqlDbType.NVarChar,30).Value = txtEmail.Text;
                cmd.Parameters.Add("@sMajor", SqlDbType.Int).Value = txtMajor.Text;
                cmd.Parameters.Add("@sSex", SqlDbType.NVarChar, 10).Value = txtSex.Text;
                cmd.Parameters.Add("@sAddress", SqlDbType.NVarChar, 255).Value = txtAddress.Text;
                // Query execution.
                cmd.ExecuteNonQuery();
                MessageBox.Show("New added success!", "Add new error!");
            }
            // Notice errors to avoid interrupting the running system.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Add new!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btResert_Click(object sender, EventArgs e)// After clicking "Refresh" the program will run the following commands.
        {
            using(SqlConnection sqlCon = new SqlConnection(sqlconnect))
            {
                // Open connection
                sqlCon.Open();
                // Database query
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Student", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                // Dump data from database.
                dgvStudent.AutoGenerateColumns = false;
                dgvStudent.DataSource = dtbl;
            }
        }
        // After clicking "Data girt view" the program will run the following commands.
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Student";
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

        private void btDelete_Click(object sender, EventArgs e) // After clicking "Delete" the program will run the following commands.
        {
            if (MessageBox.Show("Do you want to delete?", "Delete data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                int id = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells[0].Value);
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Delete from Student where sID= '"+id+"'";
                // Query execution.
                cmd.ExecuteNonQuery();
                // Close connection
                conn.Close();
            }
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

        private void btRemove_Click(object sender, EventArgs e) // After clicking "Refresh Input" the program will run the following commands.
        {
            // Delete information available on textbox.
            txtFullname.Text = txtPhoneN.Text = txtEmail.Text = txtMajor.Text = txtAge.Text= txtSex.Text = txtAddress.Text = "";
        }

        private void btClubManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Admin_Choose Admin_Choose = new Admin_Choose();
            Admin_Choose.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

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
                cmd.CommandText = "SELECT * FROM Student where sfullName like @sfullName";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
