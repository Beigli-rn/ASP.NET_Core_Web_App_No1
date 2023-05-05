using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentManagerSteps.Model;

namespace StudentManagerSteps.Data
{
    public class AuthDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
