using EPManifest.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Data
{
    public class EPManifestContext : DbContext
    {
        public EPManifestContext()
        {
        }

        public EPManifestContext(DbContextOptions<EPManifestContext> options) : base(options)
        {
        }

        public DbSet<Manifest> Manifests { get; set; }
        public DbSet<Company> Companies { get; set; }
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
            modelBuilder.Entity<Manifest>()
                .HasMany(m => m.Companies)
                .WithMany(c => c.Manifests);

            modelBuilder.Entity<Item>()
                .Property(i => i.Description)
                .IsRequired();

            modelBuilder.Entity<Company>()
                .Property(c => c.Name)
                .IsRequired();
        }
    }
}