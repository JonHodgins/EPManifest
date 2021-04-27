using EPManifest.Data;
using System;
using Xunit;
using EPManifest.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using FluentAssertions;

namespace EPManifest.Tests
{
    public class DatabaseTests : DatabaseTestsBase
    {
        public DatabaseTests() : base(
                    new DbContextOptionsBuilder<EPManifestDbContext>()
                        .UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=EPManifestTest")
                        .Options)
        {
        }

        [Fact]
        public void CanAddManifest()
        {
            //Arrange
            using var context = new EPManifestDbContext(ContextOptions);
            var consignor = new Consignor { Name = "Dawson Health Clinic" };
            var consignee = new Consignee { Name = "Whitehorse Municipal Dump" };
            var carrier = new Carrier { Name = "Frank's Delivery" };
            var manifest = new Manifest(DateTime.Now, consignor, consignee, carrier);

            //Act
            context.Add(manifest);
            context.SaveChanges();
            var actual = context.Manifests.Find(3);

            //Assert
            actual.Should().BeEquivalentTo(manifest);
        }

        [Fact]
        public void CanAddManifestUsingExistingEntities()
        {
            using var context = new EPManifestDbContext(ContextOptions);

            var consignor = context.Consignors.Find(1);
            var consignee = context.Consignees.Find(1);
            var carrier = context.Carriers.Find(1);

            var manifest = new Manifest(DateTime.Now, consignor, consignee, carrier);

            context.Add(manifest);
            context.SaveChanges();

            manifest.Id.Should().NotBe(0);
        }

        [Fact]
        public void CanAddItemToExistingManifest()
        {
            using var context = new EPManifestDbContext(ContextOptions);
            var itemOne = new Item(State.Liquid, "Petroleum", 575, Unit.L);
            var manifest = context.Manifests.Find(1);
            manifest.Items.Add(itemOne);

            context.SaveChanges();
            var actual = manifest.Items[0];

            actual.Should().BeEquivalentTo(itemOne);
        }

        [Fact]
        public void CanAddMultipleItemsToExistingManifest()
        {
            using var context = new EPManifestDbContext(ContextOptions);
            var itemOne = new Item(State.Liquid, "Petroleum", 575, Unit.L);
            var itemTwo = new Item(State.Gas, "Florohexane", 20, Unit.L);
            var manifest = context.Manifests.Find(1);
            manifest.Items.Add(itemOne);
            manifest.Items.Add(itemTwo);

            context.SaveChanges();

            var expected = new List<Item>() { itemOne, itemTwo };
            var actual = manifest.Items;

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void CanAddConsignorAddress()
        {
            using var context = new EPManifestDbContext(ContextOptions);

            var manifest = context.Manifests.Find(1);
            var address = new Address("21 Centre St", "Mayo", Provinces.YT, "Y0B 1M0");
            manifest.ConsignorAddress = address;

            context.SaveChanges();

            manifest.ConsignorAddress.Should().BeEquivalentTo(address);
        }

        [Fact]
        public void CanAddConsigneeAddress()
        {
            using var context = new EPManifestDbContext(ContextOptions);

            var manifest = context.Manifests.Find(1);
            var address = new Address("11 Front Street", "Dawson", Provinces.YT, "Y0B 3C9");
            manifest.ConsigneeAddress = address;

            context.SaveChanges();

            manifest.ConsigneeAddress.Should().BeEquivalentTo(address);
        }

        [Fact]
        public void CanModifyConsigneeAddress()
        {
            using var context = new EPManifestDbContext(ContextOptions);

            var manifest = context.Manifests.Find(1);
            var expected = new Address("59 Archer Street", "Haines Junction", Provinces.YT, "Y0B 1D9");
            manifest.ConsigneeAddress = expected;

            context.SaveChanges();

            using var contextTwo = new EPManifestDbContext(ContextOptions);

            var actual = contextTwo.Manifests.Find(1).ConsigneeAddress;

            //value-based equality
            actual.Should().BeEquivalentTo(expected);

            //reference-based equality
            //Assert.Equal(expected, actual);
        }
    }
}
