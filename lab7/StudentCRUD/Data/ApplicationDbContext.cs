using Microsoft.EntityFrameworkCore;
using StudentCRUD.Models;

namespace StudentCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {

        }
        public DbSet<Student> Students { get; set; } 
    }
}
