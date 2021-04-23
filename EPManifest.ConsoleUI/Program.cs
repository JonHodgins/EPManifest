using EPManifest.Core;
using EPManifest.Data;
using System;
using System.Collections.Generic;

namespace EPManifest.ConsoleUI
{
    internal static class Program
    {
        private static EPManifestContext _context = new EPManifestContext();

        static void Main(string[] args)
        {
            //AddCompaniesByName("A1", "Pacific Northwest", "Mayo Health Clinic", "Watson Lake Hospital");
            AddManifest();
        }

        private static void AddConsignorByName(params string[] names)
        {
            foreach (string name in names)
            {
                _context.Consignors.Add(new Consignor { Name = name });
            }
            _context.SaveChanges();
        }

        //private static void InsertManifestWithCompanies()
        //{
        //    var manifest = new Manifest
        //    {
        //        DateShipped = DateTime.Now,
        //        Companies = new List<Company>
        //        {
        //            new Company { Name = "A1" },
        //            new Company { Name = "Whitehorse General Hospital" },
        //            new Company { Name = "Northwest Freight" }
        //        }
        //    };
        //    _context.Manifests.Add(manifest);
        //    _context.SaveChanges();
        //}

        private static void AddManifest()
        {
            var manifest = new Manifest
            {
                DateShipped = DateTime.Now,
                Consignor = new Consignor { Name = "A1" },
                Consignee = new Consignee { Name = "Whitehorse General Hospital" },
                Carrier = new Carrier { Name = "Northwest Freight" }
             };
            manifest.Consignor.Addresses.Add(new Address
            { StreetNumber = 1, StreetName = "Alsek Road", City = "Whitehorse", Province = "Yukon", PostalCode = "Y1A5H9" });
            manifest.Consignee.Addresses.Add(new Address
            { StreetNumber = 105, StreetName = "Range Road", City = "Whitehorse", Province = "Yukon", PostalCode = "Y1A5M3" });
            _context.Manifests.Add(manifest);
            _context.SaveChanges();
        }
    }
}
