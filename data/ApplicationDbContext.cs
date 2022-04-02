using MVCPROJ.Models;
using Microsoft.EntityFrameworkCore;
namespace MVCPROJ              
{
   public class ApplicationDbContext: DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
             
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Subject>  Subject { get; set; }
    }
}
