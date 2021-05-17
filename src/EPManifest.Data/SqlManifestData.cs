using EPManifest.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPManifest.Data
{
    public class SqlManifestData
    {
        private readonly EPManifestDbContext _context;

        public SqlManifestData(EPManifestDbContext context)
        {
            _context = context;
        }

        public Manifest Add(Manifest newManifest)
        {
            _context.Manifests.Add(newManifest);
            return newManifest;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public Manifest Delete(int id)
        {
            var manifest = GetManifestById(id);
            if (manifest != null)
            {
                _context.Manifests.Remove(manifest);
            }
            return manifest;
        }

        public int GetCountOfManifests()
        {
            return _context.Manifests.Count();
        }

        public Manifest GetManifestById(int id)
        {
            return _context.Manifests.Find(id);
        }

        //public IEnumerable<Manifest> GetManifestsByConsignorName(string name)
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        return _context.Manifests;
        //    }
        //    return _context.Manifests.Where(m => m.Consignor.Name.StartsWith(name)).OrderBy(m => m.Consignor.Name);
        //}

        public IEnumerable<Manifest> GetManifestsByConsigneeName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _context.Manifests;
            }
            return _context.Manifests.Where(m => m.Consignee.Name.StartsWith(name)).OrderBy(m => m.Consignee.Name);
        }

        public IEnumerable<Manifest> GetManifestsByCarrierName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _context.Manifests;
            }
            return _context.Manifests.Where(m => m.Carrier.Name.StartsWith(name)).OrderBy(m => m.Carrier.Name);
        }

        public Manifest Update(Manifest updatedManifest)
        {
            var manifest = _context.Manifests.Attach(updatedManifest);
            manifest.State = EntityState.Modified;
            return updatedManifest;
        }
    }
}
