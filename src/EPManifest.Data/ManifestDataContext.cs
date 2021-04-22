using EPManifest.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Data
{
    internal class ManifestDataContext : DbContext
    {
        public DbSet<Manifest> Manifests { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                "Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=EPManifest");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manifest>()
                .HasOne(m => m.Consignor)
                .WithMany()
                .IsRequired();

            modelBuilder.Entity<Manifest>()
                .HasOne(m => m.Consignee)
                .WithMany()
                .IsRequired();

            modelBuilder.Entity<Manifest>()
                .HasOne(m => m.Carrier)
                .WithMany()
                .IsRequired();

            modelBuilder.Entity<Company>()
                .HasOne(c => c.Address)
                .WithOne(a => a.Company)
                .IsRequired();

            modelBuilder.Entity<Item>()
                .HasOne(i => i.Manifest)
                .WithMany(m => m.Items)
                .HasForeignKey("ManifestId")
                .IsRequired();
        }
    }
}