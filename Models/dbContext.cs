using Microsoft.EntityFrameworkCore;

namespace TypingWebApp.Models
{
    public class dbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
            
         

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
