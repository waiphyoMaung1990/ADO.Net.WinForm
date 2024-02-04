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

                // Get the user-updated values from the input fields

                // Get the user-updated values from the selected cell
                string updatedFirstName = dgvEntities.Rows[selectedRowIndex].Cells["FirstName"].EditedFormattedValue?.ToString() ?? "";
                string updatedLastName = dgvEntities.Rows[selectedRowIndex].Cells["LastName"].EditedFormattedValue?.ToString() ?? "";
                string updatedGender = dgvEntities.Rows[selectedRowIndex].Cells["Gender"].EditedFormattedValue?.ToString() ?? "";
                string updatedCity = dgvEntities.Rows[selectedRowIndex].Cells["City"].EditedFormattedValue?.ToString() ?? "";
                string updatedIsActive = dgvEntities.Rows[selectedRowIndex].Cells["IsActive"].EditedFormattedValue?.ToString() ?? "";


                Entities? item = _dbContext.Employees.FirstOrDefault(x => x.Id == selectedId);
                if (item is null)
                {
                    Console.WriteLine("No Data found");
                    return;
                }
                item.FirstName = updatedFirstName;
                item.LastName = updatedLastName;
                item.Gender = updatedGender;
                item.City = updatedCity;
                item.IsActive = updatedIsActive;
                int result = _dbContext.SaveChanges();
                string message = result > 0 ? "Updating Successful." : "Updating Failed";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedCells.Count > 0)
            {
                // Get the selected cell's row index
                int selectedRowIndex = dgvEntities.SelectedCells[0].RowIndex;

                // Get the 'Id' value from the 'Id' column in the selected row
                int selectedId = Convert.ToInt32(dgvEntities.Rows[selectedRowIndex].Cells["Id"].Value);

                // Get the user-updated values from the input fields

               

                Entities? item = _dbContext.Employees.FirstOrDefault(x => x.Id == selectedId);
                if (item is null)
                {
                    Console.WriteLine("No Data found");
                    return;
                }
                _dbContext.Employees.Remove(item);
                int result = _dbContext.SaveChanges();
                string message = result > 0 ? "Deleting  Successful." : "Deleting Failed";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
