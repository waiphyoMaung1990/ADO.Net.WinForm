using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using DapperWinForm.Models;

namespace DapperWinForm
{
    public partial class Form1 : Form
    {
        private readonly IDbConnection dbConnection;
       

        public Form1()
        {
            InitializeComponent();
            dbConnection = InitializeDbConnection();
            InitializeDataGridView();
        }

        private IDbConnection InitializeDbConnection()
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "Ado,netDb",
                UserID = "sa",
                Password = "091537"
            };

            return new SqlConnection(connectionStringBuilder.ConnectionString);
        }

        private void InitializeDataGridView()
        {
            // Set up DataGridView properties
            dgvEntities.AutoGenerateColumns = true;
            dgvEntities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSlect_Click(object sender, EventArgs e)
        {
            dbConnection.Open();
            string query = @"
                SELECT [Id]
                      ,[FirstName]
                      ,[LastName]
                      ,[Gender]
                      ,[City]
                      ,[IsActive]
                  FROM [dbo].[Employees]";

            List<Entities> entitiesList = dbConnection.Query<Entities>(query).ToList();

            dgvEntities.Columns.Clear();
            dgvEntities.DataSource = entitiesList;

            dbConnection.Close();
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

                // Update the database with the modified data using Dapper
                dbConnection.Open();
                string updateQuery = @"
                    UPDATE [dbo].[Employees]
                    SET [FirstName] = @FirstName,
                        [LastName] = @LastName,
                        [Gender] = @Gender,
                        [City] = @City,
                        [IsActive] = @IsActive
                    WHERE [Id] = @Id";

                // Use Dapper to execute the query with parameters
                dbConnection.Execute(updateQuery, new
                {
                    FirstName = updatedFirstName,
                    LastName = updatedLastName,
                    Gender = updatedGender,
                    City = updatedCity,
                    IsActive = updatedIsActive,
                    Id = selectedId
                });

                dbConnection.Close();
                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a cell before updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Refresh the DataGridView after deletion
            btnSlect_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = @"
            INSERT INTO [dbo].[Employees]
            ([FirstName], [LastName], [Gender], [City], [IsActive])
            VALUES
            (@FirstName, @LastName, @Gender, @City, @IsActive)";
            Entities blog = new Entities()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Gender = txtGender.Text,
                IsActive = txtIsActive.Text,
            };
            //      dbConnection= new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);


            int result = dbConnection.Execute(query, blog);
            string message = result > 0 ? "Saving Successful." : "Saving Failed";
            MessageBox.Show("Insert successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Refresh the DataGridView after deletion
            btnSlect_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected
            if (dgvEntities.SelectedCells.Count > 0)
            {
                // Get the selected cell's row index
                int selectedRowIndex = dgvEntities.SelectedCells[0].RowIndex;

                // Get the 'Id' value from the 'Id' column in the selected row
                int selectedId = Convert.ToInt32(dgvEntities.Rows[selectedRowIndex].Cells["Id"].Value);

                // Delete the record from the database using Dapper
                dbConnection.Open();
                string deleteQuery = "DELETE FROM [dbo].[Employees] WHERE [Id] = @Id";

                // Use Dapper to execute the query with parameters
                dbConnection.Execute(deleteQuery, new { Id = selectedId });

                dbConnection.Close();
                MessageBox.Show("Delete successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView after deletion
                btnSlect_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a cell before deleting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
