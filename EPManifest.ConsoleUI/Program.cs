using EPManifest.Data;
using System;

namespace EPManifest.ConsoleUI
{
    internal static class Program
    {
        private static EPManifestContext _context = new EPManifestContext();

        static void Main(string[] args)
        {
            AddCompaniesByName("A1", "Pacific Northwest", "Mayo Health Clinic");
        }

        private static void AddCompaniesByName(params string[] names)
        {
            throw new NotImplementedException();
        }
    }
}
