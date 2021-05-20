using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bogus;
using EPManifest.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EPManifest.Data
{
    public class EPManifestDbContext : DbContext
    {
        public EPManifestDbContext(DbContextOptions<EPManifestDbContext> options) : base(options)
        {
        }

        public DbSet<Manifest> Manifests { get; set; }
        public DbSet<Consignor> Consignors { get; set; }
        public DbSet<Consignee> Consignees { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        internal Task<List<Consignor>> FirstOrDefaultAsync(int manifestId)
        {
            throw new NotImplementedException();
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder
            //        .UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=EPManifest")
            //        .LogTo(Console.WriteLine, new[] {
            //               DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
            //        .EnableSensitiveDataLogging();
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ManifestEntityTypeConfiguration().Configure(modelBuilder.Entity<Manifest>());
            new ItemEntityTypeConfiguration().Configure(modelBuilder.Entity<Item>());

            modelBuilder.Entity<Consignor>().Property(c => c.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Consignee>().Property(c => c.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Carrier>().Property(c => c.Name).IsRequired().HasMaxLength(50);

            //var shipperRecieverList = new[] { "Whitehorse General Hospital", "Teslin Health Centre", "Frank's Disposal", "EQ Environmental", "Faro Nurse Station", };
            //var carrierList = new[] { "A1 Delivery", "Pacific Northwest", "EQ Environmental", "LP Waste Management Inc" };

            //var consigorId = 1;
            //var consignors = new Faker<Consignor>()
            //    .RuleFor(c => c.Id, _ => consigorId++)
            //    .RuleFor(c => c.Name, _ => _.PickRandom(shipperRecieverList));

            //modelBuilder.Entity<Consignor>().HasData(consignors.Generate(100));

            //var consigeeId = 1;
            //var consignees = new Faker<Consignee>()
            //    .RuleFor(c => c.Id, _ => consigeeId++)
            //    .RuleFor(c => c.Name, _ => _.PickRandom(shipperRecieverList));

            //modelBuilder.Entity<Consignee>().HasData(consignees.Generate(100));

            //var carrierId = 1;
            //var carriers = new Faker<Carrier>()
            //    .RuleFor(c => c.Id, _ => carrierId++)
            //    .RuleFor(c => c.Name, _ => _.PickRandom(carrierList));

            //modelBuilder.Entity<Carrier>().HasData(carriers.Generate(100));

            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 1, Name = "Carmacks Health Clinic" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 2, Name = "Mayo Health Centre" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 3, Name = "Whitehorse General Hospital" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 4, Name = "Teslin Health Centre" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 5, Name = "Whistle Bend Place" });

            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 1, Name = "Pete's Disposal" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 2, Name = "ATI Environmental" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 3, Name = "EQ Enviro" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 4, Name = "Whitehorse Landfill" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 5, Name = "YAE" });

            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 1, Name = "A1 Delivery" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 2, Name = "Pacific Northwest Freight" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 3, Name = "AP Freight" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 4, Name = "NM Shipping Inc" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 5, Name = "Frank's Freight" });

            //modelBuilder.Entity<Address>().HasData(new Address
            //{
            //    AddressLine1 = "1 Main Street",
            //    City = "Whitehorse",
            //    Province = Provinces.YT,
            //    PostalCode = "Y1A 3M5"
            //});

            var manifestId = 1;
            var manifests = new Faker<Manifest>()
                .RuleFor(m => m.Id, _ => manifestId++)
                .RuleFor(m => m.ConsigneeId, _ => _.Random.Number(1, 5))
                .RuleFor(m => m.CarrierId, _ => _.Random.Number(1, 5))
                .RuleFor(m => m.DateShipped, _ => _.Date.Between(new DateTime(2021, 05, 08), new DateTime(2021, 08, 31)))
                .RuleFor(m => m.DateScheduledArrival, _ => _.Date.Between(new DateTime(2021, 09, 01), new DateTime(2021, 12, 31)));
            modelBuilder.Entity<Manifest>().HasData(manifests.Generate(100));

            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 1, ConsignorId = 1, ConsigneeId = 1, CarrierId = 1, DateShipped = DateTime. });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 2, ConsignorId = 2, ConsigneeId = 1, CarrierId = 1, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 3, ConsignorId = 2, ConsigneeId = 2, CarrierId = 1, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 4, ConsignorId = 2, ConsigneeId = 2, CarrierId = 1, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 5, ConsignorId = 2, ConsigneeId = 2, CarrierId = 2, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 6, ConsignorId = 2, ConsigneeId = 2, CarrierId = 2, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 7, ConsignorId = 3, ConsigneeId = 2, CarrierId = 2, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 8, ConsignorId = 3, ConsigneeId = 1, CarrierId = 2, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 9, ConsignorId = 3, ConsigneeId = 1, CarrierId = 2, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 10, ConsignorId = 3, ConsigneeId = 2, CarrierId = 2, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 11, ConsignorId = 3, ConsigneeId = 2, CarrierId = 1, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 13, ConsignorId = 1, ConsigneeId = 2, CarrierId = 1, DateShipped = DateTime.Now });
            //modelBuilder.Entity<Manifest>().HasData(new Manifest { Id = 12, ConsignorId = 1, ConsigneeId = 2, CarrierId = 1, DateShipped = DateTime.Now });
        }
    }
}
