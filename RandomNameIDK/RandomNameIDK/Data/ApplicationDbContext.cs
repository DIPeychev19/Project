using Microsoft.EntityFrameworkCore;
using RandomNameIDK.Models;

namespace RandomNameIDK.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserForm> UserForms { get; set; }
    }
}
