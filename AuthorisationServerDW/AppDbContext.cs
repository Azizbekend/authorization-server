using AuthorisationServerDW.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthorisationServerDW
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BaseRole> BaseRoles { get; set; }
        public DbSet<CreateUserDTO> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<UserCompany> UsersCompany { get; set; }
    }
}
