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
                .Include(m => m.Consignors)
                .Include(m => m.Consignee)
                .Include(m => m.Carrier)
                .Include(m => m.Items)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Manifest> GetManifestById(int manifestId)
        {
            return await _context.Manifests
                .Include(m => m.Consignors)
                .Include(m => m.Consignee)
                .Include(m => m.Carrier)
                .Include(m => m.ConsignorAddress)
                .Include(m => m.ConsigneeAddress)
                .Include(m => m.Items)
                .FirstOrDefaultAsync(m => m.Id == manifestId);
        }

        public async Task<IEnumerable<Carrier>> SearchCarriers(string value)
        {
            if (value == null)
            {
                value = "";
            }
            return await _context.Carriers.Where(c => c.Name.StartsWith(value)).ToListAsync();
        }

        public async Task<IEnumerable<Consignee>> SearchConsignees(string value)
        {
            if (value == null)
            {
                value = "";
            }
            return await _context.Consignees.Where(c => c.Name.StartsWith(value)).ToListAsync();
        }

        public async Task<List<Consignor>> GetAllConsignors()
        {
            return await _context.Consignors.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<Manifest> Create(Manifest manifest)
        {
            var newManifest = _context.Manifests.Add(manifest);
            await _context.SaveChangesAsync();
            return newManifest.Entity;
        }

        public async Task Update()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Manifest manifest)
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
