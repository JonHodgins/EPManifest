using System;
using System.Linq;
using Bogus;
using EPManifest.Core;
using Microsoft.EntityFrameworkCore;

namespace EPManifest.Data
{
    internal class BogusDataGenerator
    {
        private ModelBuilder modelBuilder;
        private readonly int numManifests;

        public BogusDataGenerator(ModelBuilder modelBuilder, int numManifests)
        {
            this.modelBuilder = modelBuilder;
            this.numManifests = numManifests;
        }

        public void Init()
        {
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 1, Code = "YG41-235", Name = "Carmacks Health Clinic" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 2, Code = "YG42-501", Name = "Mayo Health Centre" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 3, Code = "YG42-890", Name = "Whitehorse General Hospital" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 4, Code = "YG81-153", Name = "Teslin Health Centre" });
            modelBuilder.Entity<Consignor>().HasData(new Consignor { Id = 5, Code = "44-041", Name = "Whistle Bend Place" });

            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 1, Code = "YG80-120", Name = "Pete's Disposal" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 2, Code = "YG81-301", Name = "ATI Environmental" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 3, Code = "YG42-757", Name = "EQ Enviro" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 4, Code = "YG81-486", Name = "Whitehorse Landfill" });
            modelBuilder.Entity<Consignee>().HasData(new Consignee { Id = 5, Code = "YG41-309", Name = "YAE" });

            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 1, Code = "YG80-899", Name = "A1 Delivery" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 2, Code = "YG81-671", Name = "Pacific Northwest Freight" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 3, Code = "YG80-909", Name = "AP Freight" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 4, Code = "YG42-554", Name = "NM Shipping Inc" });
            modelBuilder.Entity<Carrier>().HasData(new Carrier { Id = 5, Code = "YG81-241", Name = "Frank's Freight" });

            //Ensures faker data is deterministic
            //Randomizer.Seed = new Random(29034025);

            var consignorId = 6;
            var consignors = new Faker<Consignor>("en_CA")
                .RuleFor(c => c.Id, _ => consignorId++)
                .RuleFor(c => c.Code, _ => _.Random.Replace("44-###"))
                .RuleFor(c => c.Name, _ => _.Company.CompanyName());
            modelBuilder.Entity<Consignor>().HasData(consignors.Generate(10));

            var manifestId = 1;
            var manifests = new Faker<Manifest>("en_CA")
                .RuleFor(m => m.Id, _ => manifestId++)
                .RuleFor(m => m.Code, _ => _.Random.Replace("YT#####-#"))
                .RuleFor(m => m.ConsigneeId, _ => _.Random.Number(1, 5))
                .RuleFor(m => m.CarrierId, _ => _.Random.Number(1, 5))
                .RuleFor(m => m.DateShipped, _ => _.Date.Between(new DateTime(2021, 05, 08), new DateTime(2021, 08, 31)))
                .RuleFor(m => m.DateScheduledArrival, _ => _.Date.Between(new DateTime(2021, 09, 01), new DateTime(2021, 12, 31)));
            modelBuilder.Entity<Manifest>().HasData(manifests.Generate(numManifests));

            var f = new Faker("en_CA");

            manifestId = 1;
            var consigneeAddresses = Enumerable.Range(1, numManifests)
                                        .Select(_ => new
                                        {
                                            ManifestId = manifestId++,
                                            AddressLine1 = f.Address.StreetAddress(),
                                            City = f.Address.City(),
                                            Province = f.PickRandom<Provinces>(),
                                            PostalCode = f.Address.ZipCode()
                                        }).ToList();
            modelBuilder.Entity<Manifest>().OwnsOne(m => m.ConsigneeAddress).HasData(consigneeAddresses);

            manifestId = 1;
            var consignorAddresses = Enumerable.Range(1, numManifests)
                                        .Select(_ => new
                                        {
                                            ManifestId = manifestId++,
                                            AddressLine1 = f.Address.StreetAddress(),
                                            City = f.Address.City(),
                                            Province = f.PickRandom<Provinces>(),
                                            PostalCode = f.Address.ZipCode()
                                        }).ToList();
            modelBuilder.Entity<Manifest>().OwnsOne(m => m.ConsignorAddress).HasData(consignorAddresses);

            var itemId = 1;
            manifestId = 1;
            //Guarantee each manifest has at least 1 item
            var items = new Faker<Item>("en_CA")
                .RuleFor(i => i.Id, _ => itemId++)
                .RuleFor(i => i.State, _ => _.PickRandom<State>())
                .RuleFor(i => i.Description, _ => _.Lorem.Sentence(3, 4))
                .RuleFor(i => i.Quantity, _ => _.Random.Number(1, 20000))
                .RuleFor(i => i.Unit, _ => _.PickRandom<Unit>())
                .RuleFor(i => i.ManifestId, _ => manifestId++);
            modelBuilder.Entity<Item>().HasData(items.Generate(numManifests));

            //Generate additional items on random manifests
            items = new Faker<Item>("en_CA")
                .RuleFor(i => i.Id, _ => itemId++)
                .RuleFor(i => i.State, _ => _.PickRandom<State>())
                .RuleFor(i => i.Description, _ => _.Lorem.Sentence(3, 4))
                .RuleFor(i => i.Quantity, _ => _.Random.Number(1, 20000))
                .RuleFor(i => i.Unit, _ => _.PickRandom<Unit>())
                .RuleFor(i => i.ManifestId, _ => _.Random.Number(1, numManifests));
            modelBuilder.Entity<Item>().HasData(items.Generate(numManifests * 2));

            var rnd = new Random();
            manifestId = 1;
            //Guarantee each manifest has at least 1 consignor
            var consignorManifests = Enumerable.Range(1, numManifests)
                .Select(_ => new
                {
                    ConsignorId = rnd.Next(1, 5),
                    ManifestId = manifestId++
                }).ToList();
            modelBuilder.Entity<ConsignorManifest>().HasData(consignorManifests);

            manifestId = 1;
            //Generate additional consignors on random manifests
            consignorManifests = Enumerable.Range(1, numManifests / 10)
                .Select(_ => new
                {
                    ConsignorId = rnd.Next(6, 15),
                    ManifestId = manifestId += rnd.Next(3, 10)
                }).ToList();
            modelBuilder.Entity<ConsignorManifest>().HasData(consignorManifests);
        }
    }
}
