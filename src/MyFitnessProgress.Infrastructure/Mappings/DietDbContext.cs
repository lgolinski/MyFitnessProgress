using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyFitnessProgress.Core.Domain.Diet;
using MyFitnessProgress.Infrastructure.Extensions.EntityFramework;

namespace MyFitnessProgress.Infrastructure.Mappings
{
    public class DietDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Macro> Macros { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DietDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // set default schema for tables.
            modelBuilder.HasDefaultSchema("diet");

            // Add Entity Type Configurations.
            modelBuilder.AddMappings();

            // Add CreationDate and LastModify for all models in db.
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entityType.Name).Property<DateTime>("CreationDate").HasValueGenerator<CreationDateValueGenerator>();
                modelBuilder.Entity(entityType.Name).Property<DateTime?>("LastModify");
            }

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            var timestamp = DateTime.UtcNow;

            foreach (var entry in ChangeTracker.Entries()
                .Where(_ => _.State == EntityState.Added || _.State == EntityState.Modified))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("CreationDate").CurrentValue = timestamp;

                else if (entry.State == EntityState.Modified)
                    entry.Property("LastModify").CurrentValue = timestamp;
            }

            return base.SaveChanges();
        }
    }
}