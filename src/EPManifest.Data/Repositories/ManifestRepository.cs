using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace EPManifest.Data.Repositories
{
    public class ManifestRepository : IDisposable
    {
        private readonly EPManifestDbContext _context;

        public ManifestRepository(EPManifestDbContext context)
        {
            _context = context;
        }

        public async Task<List<Manifest>> GetAllManifests()
        {
            return await _context.Manifests
                .Include(m => m.Consignor)
                .Include(m => m.Consignee)
                .Include(m => m.Carrier)
                .Include(m => m.ConsignorAddress)
                .Include(m => m.ConsigneeAddress)
                .ToListAsync();
        }

        public async Task<Manifest> GetManifestById(int manifestId)
        {
            return await _context.Manifests
                .Include(m => m.Consignor)
                .Include(m => m.Consignee)
                .Include(m => m.Carrier)
                .Include(m => m.ConsignorAddress)
                .Include(m => m.ConsigneeAddress)
                .FirstOrDefaultAsync(m => m.Id == manifestId);
        }

        public async Task<Manifest> AddManifest(Manifest manifest)
        {
            var newManifest = _context.Manifests.Add(manifest);
            await _context.SaveChangesAsync();
            return newManifest.Entity;
        }

        public async Task UpdateManifest(Manifest manifest)
        {
            _context.Manifests.Update(manifest);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteManifest(Manifest manifest)
        {
            _context.Manifests.Remove(manifest);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
