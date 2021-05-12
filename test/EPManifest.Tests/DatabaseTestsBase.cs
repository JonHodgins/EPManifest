//using EPManifest.Core;
//using EPManifest.Data;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EPManifest.Tests
//{
//    public class DatabaseTestsBase
//    {
//        protected DatabaseTestsBase(DbContextOptions<EPManifestDbContext> contextOptions)
//        {
//            ContextOptions = contextOptions;

//            Seed();
//        }

//        protected DbContextOptions<EPManifestDbContext> ContextOptions { get; }

//        private void Seed()
//        {
//            using var context = new EPManifestDbContext(ContextOptions);

//            context.Database.EnsureDeleted();
//            context.Database.EnsureCreated();

//            var consignor = new Consignor { Name = "Mayo Health Centre" };
//            var consignee = new Consignee { Name = "Pete's Disposal" };
//            var carrier = new Carrier { Name = "A1 Delivery" };

//            var consignorTwo = new Consignor { Name = "Whitehorse General Hospital" };
//            var consigneeTwo = new Consignee { Name = "ATI Environmental" };
//            var carrierTwo = new Carrier { Name = "Pacific Northwest Freight" };

//            var consignorAddress = new Address("1 Main Street", "Whitehorse", Provinces.YT, "Y1A 5M3");
//            var consigneeAddress = new Address("35 1st Avenue", "Dawson", Provinces.YT, "Y0B 3M7");

//            var manifest = new Manifest(DateTime.Now, consignor, consignee, carrierTwo);

//            var manifestTwo = new Manifest(DateTime.Now, consignor, consigneeTwo, carrier)
//            {
//                ConsignorAddress = consignorAddress,
//                ConsigneeAddress = consigneeAddress
//            };

//            context.AddRange(consignor, consignee, carrier, consignorTwo, consigneeTwo, carrierTwo, manifest, manifestTwo);

//            context.SaveChanges();
//        }
//    }
//}
