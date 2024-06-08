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

namespace DHVSU_Student_Information_System
{
    public partial class RegisterFrame : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=group0;");
        public RegisterFrame()
        {
            InitializeComponent();
        }

        private void RegisterFrame_Load(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string username = registerUsernameBox.Text;
            string password = registerPasswordBox.Text;
            string confirmPassword = confirmPasswordBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error");
                return;
            }

            try
            {
                connection.Open();
                string insertQuery = "INSERT INTO accounttable (username, password) VALUES (@Username, @Password)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!");
                    this.Hide();
                    LoginFrame login = new LoginFrame();
                    login.ShowDialog();

                    // Clear the text boxes after successful sign-up
                    registerUsernameBox.Clear();
                    registerPasswordBox.Clear();
                    confirmPasswordBox.Clear();

                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrame login = new LoginFrame();
            login.ShowDialog();
        }
    }
}
