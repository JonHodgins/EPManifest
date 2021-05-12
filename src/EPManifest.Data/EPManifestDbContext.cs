using System;
using EPManifest.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EPManifest.Data
{
    public class EPManifestDbContext : DbContext
    {
        //    public EPManifestDbContext()
        //    {
        //    }

        public EPManifestDbContext(DbContextOptions<EPManifestDbContext> options) : base(options)
        {
        }

        public DbSet<Manifest> Manifests { get; set; }
        public DbSet<Consignor> Consignors { get; set; }
        public DbSet<Consignee> Consignees { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Address> Addresses { get; set; }
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

            modelBuilder.Entity<Consignor>().Property(c => c.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Consignee>().Property(c => c.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Carrier>().Property(c => c.Name).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 1, Name = "A1 Delivery" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 2, Name = "Frank's Shipping" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 3, Name = "Whitehorse General Hospital" });

            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 1, ConsignorId = 1, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 2, ConsignorId = 2, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 3, ConsignorId = 2, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 4, ConsignorId = 2, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 5, ConsignorId = 2, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 6, ConsignorId = 2, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 7, ConsignorId = 3, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 8, ConsignorId = 3, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 9, ConsignorId = 3, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 10, ConsignorId = 3, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 11, ConsignorId = 3, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 12, ConsignorId = 1, DateShipped = DateTime.Now });
            modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 13, ConsignorId = 1, DateShipped = DateTime.Now });
        }
    }
}
