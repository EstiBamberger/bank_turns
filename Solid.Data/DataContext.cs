using Microsoft.EntityFrameworkCore;
using Solid.Core.Enteties;


namespace Solid.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Turn> Turns { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Official> Officials { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample3_db");
        }
    }
}
