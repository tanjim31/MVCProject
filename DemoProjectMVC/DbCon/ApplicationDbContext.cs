using DemoProjectMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProjectMVC.DbCon
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
