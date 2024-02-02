using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO.Net.WinForm
{
    public partial class Form1 : Form
    {
        private SqlConnectionStringBuilder? connectionStringBuilder;
        private SqlDataAdapter? adapter;
        private DataTable? dt;


        public Form1()
        {
            InitializeComponent();
            InitializeConnectionString();
            InitializeDataGridView();
        }

        private void InitializeConnectionString()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "Ado,netDb",
                UserID = "sa",
                Password = "091537"
            };
        }

        private void InitializeDataGridView()
        {
            // Set up DataGridView properties
            dgvEntities.AutoGenerateColumns = true;
            dgvEntities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSlect_Click(object sender, EventArgs e)
        {
            if (connectionStringBuilder != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ToString()))
                {
                    connection.Open();
                    string query = @"
                    SELECT [Id]
                          ,[FirstName]
                          ,[LastName]
                          ,[Gender]
                          ,[City]
                          ,[IsActive]
                      FROM [dbo].[Employees]";
                    SqlCommand command = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(command);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing columns
                    dgvEntities.Columns.Clear();
                    // Set the DataGridView DataSource
                    dgvEntities.DataSource = dt;
                    connection.Close();
                }
            }
              
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected
            if (dgvEntities.SelectedCells.Count > 0)
            {
                // Get the selected cell's row index
                int selectedRowIndex = dgvEntities.SelectedCells[0].RowIndex;

                // Get the 'Id' value from the 'Id' column in the selected row
                int selectedId = Convert.ToInt32(dgvEntities.Rows[selectedRowIndex].Cells["Id"].Value);

                // Get the user-updated values from the selected cell
                string updatedFirstName = dgvEntities.Rows[selectedRowIndex].Cells["FirstName"].EditedFormattedValue?.ToString() ?? "";
                string updatedLastName = dgvEntities.Rows[selectedRowIndex].Cells["LastName"].EditedFormattedValue?.ToString() ?? "";
                string updatedGender = dgvEntities.Rows[selectedRowIndex].Cells["Gender"].EditedFormattedValue?.ToString() ?? "";
                string updatedCity = dgvEntities.Rows[selectedRowIndex].Cells["City"].EditedFormattedValue?.ToString() ?? "";
                string updatedIsActive = dgvEntities.Rows[selectedRowIndex].Cells["IsActive"].EditedFormattedValue?.ToString() ?? "";


                // Update the database with the modified data
                if (connectionStringBuilder != null)
                {
                    using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ToString()))
                    {
                        connection.Open();
                        string updateQuery = @"
                UPDATE [dbo].[Employees]
                SET [FirstName] = @FirstName,
                    [LastName] = @LastName,
                    [Gender] = @Gender,
                    [City] = @City,
                    [IsActive] = @IsActive
                WHERE [Id] = @Id";

                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@FirstName", updatedFirstName);
                        updateCommand.Parameters.AddWithValue("@LastName", updatedLastName);
                        updateCommand.Parameters.AddWithValue("@Gender", updatedGender);
                        updateCommand.Parameters.AddWithValue("@City", updatedCity);
                        updateCommand.Parameters.AddWithValue("@IsActive", updatedIsActive);
                        updateCommand.Parameters.AddWithValue("@Id", selectedId);

                        updateCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please select a cell before updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (connectionStringBuilder != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ToString()))
                {
                    string Ifirstname = txtFirstName.Text;
                    string Ilastname = txtLastName.Text;
                    string Igender = txtGender.Text;
                    string Icity = txtCity.Text;
                    string Iisactive = txtIsActive.Text;

                    connection.Open();

                    string query = @"
            INSERT INTO [dbo].[Employees]
            ([FirstName], [LastName], [Gender], [City], [IsActive])
            VALUES
            (@FirstName, @LastName, @Gender, @City, @IsActive)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use parameters for all fields
                        command.Parameters.AddWithValue("@FirstName", Ifirstname);
                        command.Parameters.AddWithValue("@LastName", Ilastname);
                        command.Parameters.AddWithValue("@Gender", Igender);
                        command.Parameters.AddWithValue("@City", Icity);
                        command.Parameters.AddWithValue("@IsActive", Iisactive);

                        // Execute the query
                        int result = command.ExecuteNonQuery();

                        // Display result message
                        string message = result > 0 ? "Saving Successful." : "Saving Failed";
                        MessageBox.Show(message);
                    }
                }
            }
           
        }

    }
}
