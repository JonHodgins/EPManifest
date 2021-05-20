using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Core;
using Microsoft.EntityFrameworkCore;

namespace EPManifest.Data.Repositories
{
    public class ConsignorRepository : IDisposable
    {
        private readonly EPManifestDbContext _context;

        public ConsignorRepository(EPManifestDbContext context)
        {
            _context = context;
        }

        public async Task<Consignor> GetById(int manifestId)
        {
            return await _context.Consignors.FirstOrDefaultAsync(c => c.Id == manifestId);
        }

        public async Task<Consignor> Create(Consignor consignor)
        {
            var newConsignor = _context.Consignors.Add(consignor);
            await _context.SaveChangesAsync();
            return newConsignor.Entity;
        }

        public async Task Update(Consignor consignor)
        {
            _context.Consignors.Update(consignor);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Consignor consignor)
        {
            _context.Consignors.Remove(consignor);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
