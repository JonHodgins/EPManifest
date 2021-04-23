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
            InsertManifestWithCompanies();
        }

        private static void AddCompaniesByName(params string[] names)
        {
            foreach (string name in names)
            {
                _context.Companies.Add(new Company { Name = name });
            }
            _context.SaveChanges();
        }

        private static void InsertManifestWithCompanies()
        {
            var manifest = new Manifest
            {
                DateShipped = DateTime.Now,
                Companies = new List<Company>
                {
                    new Company { Name = "A1" },
                    new Company { Name = "Whitehorse General Hospital" },
                    new Company { Name = "Northwest Freight" }
                }
            };
            _context.Manifests.Add(manifest);
            _context.SaveChanges();
        }
    }
}
