using System.Data.Entity;

namespace AtmManagement.Models
{
    public class CustomersContext : DbContext
    {
        public CustomersContext()
            :base("DatabaseConnection")
        {

        }
        public DbSet<Customers> CustomersTable { get; set; }
    }
}