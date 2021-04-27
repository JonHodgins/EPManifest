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
            using var _context = new EPManifestDbContext(ContextOptions);
            var consignor = new Consignor { Name = "Dawson Health Clinic" };
            var consignee = new Consignee { Name = "Whitehorse Municipal Dump" };
            var carrier = new Carrier { Name = "Frank's Delivery" };
            var manifest = new Manifest(DateTime.Now, consignor, consignee, carrier);

            //Act
            _context.Add(manifest);
            _context.SaveChanges();
            var actual = _context.Manifests.Find(3);

            //Assert
            Assert.Equal(manifest, actual);
        }

        [Fact]
        public void CanAddManifestUsingExistingEntities()
        {
            using var _context = new EPManifestDbContext(ContextOptions);

            var consignor = _context.Consignors.Find(1);
            var consignee = _context.Consignees.Find(1);
            var carrier = _context.Carriers.Find(1);

            var manifest = new Manifest(DateTime.Now, consignor, consignee, carrier);

            _context.Add(manifest);
            _context.SaveChanges();

            Assert.NotEqual(0, manifest.Id);
        }

        [Fact]
        public void CanAddItemToExistingManifest()
        {
            using var _context = new EPManifestDbContext(ContextOptions);
            var itemOne = new Item(State.Liquid, "Petroleum", 575, Unit.L);
            var manifest = _context.Manifests.Find(1);
            manifest.Items.Add(itemOne);

            _context.SaveChanges();
            var actual = manifest.Items[0];

            Assert.Equal(itemOne, actual);
        }

        [Fact]
        public void CanAddMultipleItemsToExistingManifest()
        {
            using var _context = new EPManifestDbContext(ContextOptions);
            var itemOne = new Item(State.Liquid, "Petroleum", 575, Unit.L);
            var itemTwo = new Item(State.Gas, "Florohexane", 20, Unit.L);
            var manifest = _context.Manifests.Find(1);
            manifest.Items.Add(itemOne);
            manifest.Items.Add(itemTwo);

            _context.SaveChanges();

            var expected = new List<Item>() { itemOne, itemTwo };
            var actual = manifest.Items;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanAddConsignorAddress()
        {
            using var _context = new EPManifestDbContext(ContextOptions);

            var manifest = _context.Manifests.Find(1);
            var address = new Address("21 Centre St", "Mayo", Provinces.YT, "Y0B 1M0");
            manifest.ConsignorAddress = address;

            _context.SaveChanges();

            Assert.Equal(address, manifest.ConsignorAddress);
        }

        [Fact]
        public void CanAddConsigneeAddress()
        {
            using var _context = new EPManifestDbContext(ContextOptions);

            var manifest = _context.Manifests.Find(1);
            var address = new Address("11 Front Street", "Dawson", Provinces.YT, "Y0B 3C9");
            manifest.ConsigneeAddress = address;

            _context.SaveChanges();

            Assert.Equal(address, manifest.ConsigneeAddress);
        }

        [Fact]
        public void CanModifyConsigneeAddress()
        {
            using var _context = new EPManifestDbContext(ContextOptions);

            var manifest = _context.Manifests.Find(1);
            var expected = new Address("59 Archer Street", "Haines Junction", Provinces.YT, "Y0B 1D9");
            manifest.ConsigneeAddress = expected;

            _context.SaveChanges();

            using var _contextTwo = new EPManifestDbContext(ContextOptions);

            var actual = _contextTwo.Manifests.Find(1).ConsigneeAddress;

            //value-based equality
            actual.Should().BeEquivalentTo(expected);

            //reference-based equality
            Assert.Equal(expected, actual);
        }
    }
}
