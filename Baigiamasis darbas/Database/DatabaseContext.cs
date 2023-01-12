using Baigiamasis_darbas.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Baigiamasis_darbas.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<UserAddress> addresses { get; set; }
        public DbSet<UserInfo> userInfo { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}
