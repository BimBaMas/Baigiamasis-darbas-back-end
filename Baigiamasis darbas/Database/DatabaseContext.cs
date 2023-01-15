using Baigiamasis_darbas.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Baigiamasis_darbas.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> Addresses { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}
