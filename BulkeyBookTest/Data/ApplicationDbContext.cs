using BulkeyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkeyBookWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
