using DynamicManager.Database.Mapping;
using DynamicManager.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicManager.Database
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<DbUser> Users { get; set; }
        public virtual DbSet<DbForm> Forms { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DbUserMap());
            modelBuilder.ApplyConfiguration(new DbFormMap(modelBuilder.Entity<DbForm>()));
        }
    }
}
