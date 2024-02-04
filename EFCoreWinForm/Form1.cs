using EFCoreWinForm.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace EFCoreWinForm
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _dbContext = new AppDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSlect_Click(object sender, EventArgs e)
        {
            var entitiesList = _dbContext.Employees.ToList();
            dgvEntities.Columns.Clear();
            dgvEntities.DataSource = entitiesList;
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

                // Get the user-updated value from the input field
                string updatedFirstName = txtFirstName.Text;
                string updatedLastName = txtLastName.Text;
                string updatedGender = txtGender.Text;
                string updatedCity = txtCity.Text;
                string updatedIsActive = txtIsActive.Text;
                // Find the employee in the database
                var employeeToUpdate = _dbContext.Employees.Find(selectedId);

                // Check if the employee is found
                if (employeeToUpdate != null)
                {
                    // Update the FirstName property
                    employeeToUpdate.FirstName = updatedFirstName;
                    // Update the properties

                    employeeToUpdate.LastName = updatedLastName;
                    employeeToUpdate.Gender = updatedGender;
                    employeeToUpdate.City = updatedCity;
                    employeeToUpdate.IsActive = updatedIsActive;
                    // Save changes to the database
                    _dbContext.SaveChanges();

                    // Refresh the DataGridView
                    btnSlect_Click(sender, e);

                    MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a cell before updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Entities blog = new Entities()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Gender = txtGender.Text,
                IsActive = txtIsActive.Text,
            };
            _dbContext.Employees.Add(blog);

            int result = _dbContext.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed";

            Console.WriteLine(message);
        }
    }
}
