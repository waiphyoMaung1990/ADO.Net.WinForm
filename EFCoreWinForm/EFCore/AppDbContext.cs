using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWinForm.EFCore
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "Ado,netDb",
                UserID = "sa",
                Password = "091537"
            };

            optionsBuilder.UseSqlServer(connectionStringBuilder.ConnectionString + ";TrustServerCertificate=true");

          //  optionsBuilder.UseSqlServer(connectionStringBuilder.ConnectionString);
        }
            public DbSet<Entities> Employees { get; set; }
    }
}
