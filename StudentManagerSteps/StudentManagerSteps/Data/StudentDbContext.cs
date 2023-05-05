using Microsoft.EntityFrameworkCore;
using StudentManagerSteps.Model;

namespace StudentManagerSteps.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> option) : base(option)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
