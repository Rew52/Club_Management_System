﻿using System;
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
    public partial class User_ClubEvent : Form
    {
        string sqlconnect = ("server=DESKTOP-3PJUBR3;database=ClubManagementSystem;uid=sa;pwd=1234567890"); // kết nối sever
        SqlConnection conn = null;
        public User_ClubEvent()
        {
            InitializeComponent();
        }

        private void User_ClubEvent_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlconnect);
            conn.Open();
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

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            User_Choose User_Choose = new User_Choose();
            User_Choose.ShowDialog();
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
        private void btResert_Click(object sender, EventArgs e)// After clicking "Refresh" the program will run the following commands.
        {
            // Open connection
            conn = new SqlConnection(sqlconnect);
            conn.Open();
            // Create command object.
            SqlCommand cmd = conn.CreateCommand();
            // Create command
            cmd.CommandText = "Select ClubEvent.ceID, Event.eName,Club.sName From ClubEvent,Event,Club where" +
                " ClubEvent.eID = Event.eID and ClubEvent.cID= Club.cID ";
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvStudent.DataSource = dtbl;
            // Query execution.
            cmd.ExecuteNonQuery();
            // Close connection
            conn.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Open connection
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                // Create command object.
                SqlCommand cmd = conn.CreateCommand();
                // Create command
                cmd.CommandText = "Select ClubEvent.ceID,Event.eName,Club.sName From ClubEvent,Event,Club where" +
                " ClubEvent.eID = Event.eID and ClubEvent.cID= Club.cID and sName like @sName or eName like @eName ";
                cmd.Parameters.AddWithValue("sName", string.Format("%{0}%", txtSearch.Text));
                cmd.Parameters.AddWithValue("eName", string.Format("%{0}%", txtSearch.Text));
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
