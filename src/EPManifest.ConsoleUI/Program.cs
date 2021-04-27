using EPManifest.Core;
using EPManifest.Data;
using System;
using System.Collections.Generic;

namespace EPManifest.ConsoleUI
{
    internal static class Program
    {
        private static readonly EPManifestDbContext s_context = new();

        private static void Main(string[] args)
        {
            //AddCompaniesByName("A1", "Pacific Northwest", "Mayo Health Clinic", "Watson Lake Hospital");
            //AddManifest();
        }

        private static void AddConsignorByName(params string[] names)
        {
            foreach (var name in names)
            {
                s_context.Consignors.Add(new Consignor { Name = name });
            }
            s_context.SaveChanges();
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

        //private static void AddManifest()
        //{
        //    var manifest = new Manifest
        //    {
        //        DateShipped = DateTime.Now,
        //        Consignor = new Consignor { Name = "A1" },
        //        Consignee = new Consignee { Name = "Whitehorse General Hospital" },
        //        Carrier = new Carrier { Name = "Northwest Freight" }
        //     };
        //    manifest.ConsignorAddress = new Address
        //    { AddressLine1 = "1 Alsek Road", City = "Whitehorse", Province = Provinces.YT, PostalCode = "Y1A 5H9" };
        //    manifest.ConsigneeAddress = new Address
        //    { AddressLine1 = "248 Lewes Blvd", City = "Whitehorse", Province = Provinces.YT, PostalCode = "Y1A 1X9" };
        //    _context.Manifests.Add(manifest);
        //    _context.SaveChanges();
        //}
    }
}
