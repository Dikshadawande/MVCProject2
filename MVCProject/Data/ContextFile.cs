using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject.Data
{
    public class ContextFile : DbContext
    {
        public ContextFile(DbContextOptions<ContextFile> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 
        
    }
}
