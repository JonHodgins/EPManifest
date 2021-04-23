﻿using EPManifest.Core;
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
            modelBuilder.Entity<Consignor>()
                .HasMany(c => c.Addresses)
                .WithOne(a => a.Consignor)
                .HasForeignKey(a => a.ConsignorId);

            modelBuilder.Entity<Consignee>()
                .HasMany(c => c.Addresses)
                .WithOne(a => a.Consignee)
                .HasForeignKey(a => a.ConsigneeId);

            modelBuilder.Entity<Carrier>()
                .HasMany(c => c.Addresses)
                .WithOne(a => a.Carrier)
                .HasForeignKey(a => a.CarrierId);

            //modelBuilder.Entity<Item>()
            //    .Property(i => i.Description)
            //    .IsRequired();
        }
    }
}