using Baigiamasis_darbas.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace Baigiamasis_darbas.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne<UserAddress>(s => s.UserAddress).WithOne(ad => ad.User).HasForeignKey<UserAddress>(ad => ad.UserId);

            modelBuilder.Entity<User>().HasOne<UserInfo>(s => s.UserInfo).WithOne(ad => ad.User).HasForeignKey<UserInfo>(ad => ad.UserId);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            

        }
    }
}
