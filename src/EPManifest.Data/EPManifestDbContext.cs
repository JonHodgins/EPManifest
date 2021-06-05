using System;
using EPManifest.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EPManifest.Data
{
    public class EPManifestDbContext : DbContext
    {
        //Uncomment to allow EF Core Power Tools to generate a diagram
        //public EPManifestDbContext()
        //{
        //}

        public EPManifestDbContext(DbContextOptions<EPManifestDbContext> options) : base(options)
        {
        }

        public DbSet<Manifest> Manifests { get; set; }
        public DbSet<Consignor> Consignors { get; set; }
        public DbSet<ConsignorManifest> ConsignorManifest { get; set; }
        public DbSet<Consignee> Consignees { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=EPManifest")
                    .LogTo(Console.WriteLine, new[] {
                           DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                    .EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ManifestEntityTypeConfiguration().Configure(modelBuilder.Entity<Manifest>());
            new ItemEntityTypeConfiguration().Configure(modelBuilder.Entity<Item>());

            modelBuilder.Entity<Consignor>().Property(c => c.Code).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Consignor>().Property(c => c.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Consignee>().Property(c => c.Code).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Consignee>().Property(c => c.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Carrier>().Property(c => c.Code).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Carrier>().Property(c => c.Name).IsRequired().HasMaxLength(50);

            //Generate bogus data for testing
            new BogusDataGenerator(modelBuilder, 800).Init();
        }
    }
}
