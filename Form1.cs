using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTLearningUsersRoles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(1);
            List<string> usersRoles = new List<string>(); // Admin:1, moderators:2, instructors:3, students:4
            usersRoles.Add("Admin");
            usersRoles.Add("Moderators");
            usersRoles.Add("Instructors");
            usersRoles.Add("Students");

            foreach (string role in usersRoles)
            {
                await Task.Delay(1);
                metroSetComboBoxRolesByNames.Items.Add(role.ToString());
            }
        }

        private async void metroSetButtonFilterUsersById_Click(object sender, EventArgs e)
        {
            await Task.Delay(1);
            string connectionString = "datasource=localhost;port=3306;database=ytlearning;username=root;password=;";
            //Admin: 1, moderators: 2, instructors: 3, students: 4

            if (metroSetComboBoxRolesByNames.Text == "Admin")
            {
                // Load Form With Id of User And With Updated Role As Admin 
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString.ToString()))
                {
                    string update = "UPDATE users SET role_id = '1' WHERE id = '" + metroSetTextBoxUserId.Text.ToString() + "';";
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(update, mySqlConnection);
                    //MySqlDataReader mySqlDataReader;
                    await Task.Delay(1);
                    mySqlCommand.ExecuteReader();
                    mySqlConnection.Close();
                }
            }
            if (metroSetComboBoxRolesByNames.Text == "Moderators")
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString.ToString()))
                {
                    string update = "UPDATE users SET role_id = '2' WHERE id = '" + metroSetTextBoxUserId.Text.ToString() + "';";
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(update, mySqlConnection);
                    //MySqlDataReader mySqlDataReader;
                    await Task.Delay(1);
                    mySqlCommand.ExecuteReader();
                    mySqlConnection.Close();
                }
            }
            if (metroSetComboBoxRolesByNames.Text == "Instructors")
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString.ToString()))
                {
                    string update = "UPDATE users SET role_id = '3' WHERE id = '" + metroSetTextBoxUserId.Text.ToString() + "';";
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(update, mySqlConnection);
                    //MySqlDataReader mySqlDataReader;
                    await Task.Delay(1);
                    mySqlCommand.ExecuteReader();
                    mySqlConnection.Close();
                }
            }
            if (metroSetComboBoxRolesByNames.Text == "Students")
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString.ToString()))
                {
                    string update = "UPDATE users SET role_id = '4' WHERE id = '" + metroSetTextBoxUserId.Text.ToString() + "';";
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(update, mySqlConnection);
                    //MySqlDataReader mySqlDataReader;
                    await Task.Delay(1);
                    mySqlCommand.ExecuteReader();
                    mySqlConnection.Close();
                }
            }
            await Task.Delay(3);
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string select = "SELECT id,name,email,created_at,role_id FROM users WHERE id = '" + metroSetTextBoxUserId.Text + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(select.ToString(), connection);
                using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand))
                {
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    await Task.Delay(1);
                    dataGridViewUsers.DataSource = dataTable;
                }
                connection.Close();
            }
        }
    }
}
