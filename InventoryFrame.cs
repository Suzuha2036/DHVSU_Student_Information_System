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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DHVSU_Student_Information_System
{
    public partial class InventoryFrame : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=group0;");

        public InventoryFrame()
        {
            InitializeComponent();
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventoryFrame_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void maritalStatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM mytable";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string ageText = ageBox.Text;
            int age;

            // Try to parse the age
            if (!int.TryParse(ageText, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            string streetNumberText = streetNumberBox.Text;
            int streetNumber;

            if (!int.TryParse(streetNumberText, out streetNumber))
            {
                MessageBox.Show("Please enter a valid street number.");
                return;
            }

            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string middleInitial = middleInitialBox.Text;
            string maritalStatus = maritalStatusBox.Text;
            string street = streetBox.Text;
            string barangay = barangayBox.Text;
            string municipality = municipalBox.Text;
            string province = provinceBox.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please input Name", "Error");
                return;
            }

            try
            {
                connection.Open();
                string insertQuery = "INSERT INTO mytable (First_Name, Last_Name, Middle_Initial, Age, Marital_Status,Street, Street_Number, Barangay,Municipality, Province) VALUES (@firstName, @lastName, @middleInitial,@age, @maritalStatus, @street, @streetNumber,@barangay,@municipality,@province )";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@middleInitial", middleInitial);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@maritalStatus", maritalStatus);
                    command.Parameters.AddWithValue("@street", street);
                    command.Parameters.AddWithValue("@streetNumber", streetNumber);
                    command.Parameters.AddWithValue("@barangay", barangay);
                    command.Parameters.AddWithValue("@municipality", municipality);
                    command.Parameters.AddWithValue("@province", province);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully");


                    firstNameBox.Text = "";
                    lastNameBox.Text = "";
                    middleInitialBox.Text = "";
                    ageBox.Text = "";
                    maritalStatusBox.Text = "";
                    streetBox.Text = "";
                    streetNumberBox.Text = "";
                    barangayBox.Text = "";
                    municipalBox.Text = "";
                    provinceBox.Text = "";


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
            LoadData();

        }




        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                firstNameBox.Text = selectedRow.Cells["First_Name"].Value.ToString();
                lastNameBox.Text = selectedRow.Cells["Last_Name"].Value.ToString();
                middleInitialBox.Text = selectedRow.Cells["Middle_Initial"].Value.ToString();
                ageBox.Text = selectedRow.Cells["Age"].Value.ToString();
                maritalStatusBox.Text = selectedRow.Cells["Marital_Status"].Value.ToString();
                streetBox.Text = selectedRow.Cells["Street"].Value.ToString();
                streetNumberBox.Text = selectedRow.Cells["Street_Number"].Value.ToString();
                barangayBox.Text = selectedRow.Cells["Barangay"].Value.ToString();
                municipalBox.Text = selectedRow.Cells["Municipality"].Value.ToString();
                provinceBox.Text = selectedRow.Cells["Province"].Value.ToString();
            }
        }



        private void editBTN_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Retrieve data from textboxes
                string firstName = firstNameBox.Text;
                string lastName = lastNameBox.Text;
                string middleInitial = middleInitialBox.Text;
                int age = Convert.ToInt32(ageBox.Text);
                string maritalStatus = maritalStatusBox.Text;
                string street = streetBox.Text;
                int streetNumber = Convert.ToInt32(streetNumberBox.Text);
                string barangay = barangayBox.Text;
                string municipality = municipalBox.Text;
                string province = provinceBox.Text;

                try
                {
                    // Open connection
                    connection.Open();

                    // Update query
                    string updateQuery = "UPDATE mytable SET First_Name = @FirstName, Last_Name = @LastName, Middle_Initial = @MiddleInitial, Age = @Age, Marital_Status = @MaritalStatus, Street = @Street, Street_Number = @StreetNumber, Barangay = @Barangay, Municipality = @Municipality, Province = @Province WHERE ID = @ID";

                    // Create command with parameters
                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                        command.Parameters.AddWithValue("@Street", street);
                        command.Parameters.AddWithValue("@StreetNumber", streetNumber);
                        command.Parameters.AddWithValue("@Barangay", barangay);
                        command.Parameters.AddWithValue("@Municipality", municipality);
                        command.Parameters.AddWithValue("@Province", province);

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Show success message
                        MessageBox.Show("Record updated successfully!");

                        firstNameBox.Text = "";
                        lastNameBox.Text = "";
                        middleInitialBox.Text = "";
                        ageBox.Text = "";
                        maritalStatusBox.Text = "";
                        streetBox.Text = "";
                        streetNumberBox.Text = "";
                        barangayBox.Text = "";
                        municipalBox.Text = "";
                        provinceBox.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Close connection
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
            LoadData();
        }

        private void studentNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Get the ID value of the selected row
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Prompt the user for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's response
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Open connection
                        connection.Open();

                        // Delete query
                        string deleteQuery = "DELETE FROM mytable WHERE ID = @ID";

                        // Create command with parameters
                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Row deleted successfully!");

                                
                            }
                            else
                            {
                                MessageBox.Show("No rows deleted.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        // Close connection
                        connection.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
            // Reload data after deletion
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            middleInitialBox.Text = "";
            ageBox.Text = "";
            maritalStatusBox.Text = "";
            streetBox.Text = "";
            streetNumberBox.Text = "";
            barangayBox.Text = "";
            municipalBox.Text = "";
            provinceBox.Text = "";
            LoadData();
        }

        

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrame login = new LoginFrame();
            login.ShowDialog();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            // Get the search keyword from the textbox
            string keyword = searchBox.Text.Trim();

            // Check if the keyword is empty
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a search keyword.");
                return;
            }

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Check if any cell in the row contains the search keyword
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(keyword))
                    {
                        row.Selected = true;
                        dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
    }
}
