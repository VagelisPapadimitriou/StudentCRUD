using Microsoft.EntityFrameworkCore;
using StudentCRUD.Models.Entities;

namespace StudentCRUD.MyDatabase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
