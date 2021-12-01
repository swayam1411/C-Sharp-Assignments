using System.Data.Entity;

namespace AtmManagement.Models
{
    public class AdminContext : DbContext
    {
        public AdminContext()
            : base("DatabaseConnection")
        {
            
        }
        public DbSet<Admin> AdminTable { get; set; }
    }
}