using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        // DbSet for Category
        public DbSet<Category> Categories { get; set; }
        // DbSet for Transactions
        public DbSet<Transaction> Transactions { get; set; }
    }
}
