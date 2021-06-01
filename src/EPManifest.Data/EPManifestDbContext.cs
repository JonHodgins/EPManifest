using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using CountryData.Bogus;
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

            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 1, Code = "OXP-4", Name = "Carmacks Health Clinic" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 2, Code = "A-000", Name = "Mayo Health Centre" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 3, Code = "B-5010", Name = "Whitehorse General Hospital" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 4, Code = "A1-102", Name = "Teslin Health Centre" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 5, Code = "A840", Name = "Whistle Bend Place" });

            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 1, Code = "AB-120", Name = "Pete's Disposal" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 2, Code = "AB-410", Name = "ATI Environmental" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 3, Code = "AB-019", Name = "EQ Enviro" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 4, Code = "AB-918", Name = "Whitehorse Landfill" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 5, Code = "AB-412", Name = "YAE" });

            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 1, Code = "50101", Name = "A1 Delivery" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 2, Code = "10-4010", Name = "Pacific Northwest Freight" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 3, Code = "40-020", Name = "AP Freight" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 4, Code = "60-10", Name = "NM Shipping Inc" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 5, Code = "60-05", Name = "Frank's Freight" });

            var manifestId = 1;
            var manifests = new Faker<Manifest>("en_CA")
                .RuleFor(m => m.Id, _ => manifestId++)
                .RuleFor(m => m.Code, _ => "YT" + _.Random.Int(10000, 99999) + "-" + _.Random.Number(1))
                .RuleFor(m => m.ConsigneeId, _ => _.Random.Number(1, 5))
                .RuleFor(m => m.CarrierId, _ => _.Random.Number(1, 5))
                .RuleFor(m => m.DateShipped, _ => _.Date.Between(new DateTime(2021, 05, 08), new DateTime(2021, 08, 31)))
                .RuleFor(m => m.DateScheduledArrival, _ => _.Date.Between(new DateTime(2021, 09, 01), new DateTime(2021, 12, 31)));
            modelBuilder.Entity<Manifest>().HasData(manifests.Generate(200));

            var f = new Faker("en_CA");

            manifestId = 1;
            var consigneeAddresses = Enumerable.Range(1, 200)
                                        .Select(i => new
                                        {
                                            ManifestId = manifestId++,
                                            AddressLine1 = f.Address.StreetAddress(),
                                            City = f.Address.City(),
                                            Province = f.PickRandom<Provinces>(),
                                            PostalCode = f.Address.ZipCode()
                                        }).ToList();
            modelBuilder.Entity<Manifest>().OwnsOne(m => m.ConsigneeAddress).HasData(consigneeAddresses);

            manifestId = 1;
            var consignorAddresses = Enumerable.Range(1, 200)
                                        .Select(i => new
                                        {
                                            ManifestId = manifestId++,
                                            AddressLine1 = f.Address.StreetAddress(),
                                            City = f.Address.City(),
                                            Province = f.PickRandom<Provinces>(),
                                            PostalCode = f.Address.ZipCode()
                                        }).ToList();
            modelBuilder.Entity<Manifest>().OwnsOne(m => m.ConsignorAddress).HasData(consignorAddresses);

            var itemId = 1;
            var items = new Faker<Item>()
                .RuleFor(i => i.Id, _ => itemId++)
                .RuleFor(i => i.State, _ => _.PickRandom<State>())
                .RuleFor(i => i.Description, _ => _.Lorem.Sentence())
                .RuleFor(i => i.Quantity, _ => _.Random.Number(1, 20000))
                .RuleFor(i => i.Unit, _ => _.PickRandom<Unit>())
                .RuleFor(i => i.ManifestId, _ => _.Random.Number(1, 200));
            modelBuilder.Entity<Item>().HasData(items.Generate(500));
        }
    }
}
