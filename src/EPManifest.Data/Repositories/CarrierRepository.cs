using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Core;
using Microsoft.EntityFrameworkCore;

namespace EPManifest.Data.Repositories
{
    public class CarrierRepository : IDisposable, IEntityRepository<Carrier>
    {
        private readonly EPManifestDbContext _context;

        public CarrierRepository(EPManifestDbContext context)
        {
            _context = context;
        }

        public async Task<List<Carrier>> GetAllCarriers()
        {
            return await _context.Carriers.OrderBy(c => c.Name).Include(c => c.Manifests).ToListAsync();
        }

        public Carrier GetById(int id)
        {
            return _context.Carriers.FirstOrDefault(c => c.Id == id);
        }

        public async Task<Carrier> Create(Carrier carrier)
        {
            var newCarrier = _context.Carriers.Add(carrier);
            await _context.SaveChangesAsync();
            return newCarrier.Entity;
        }

        public async Task Update(Carrier carrier)
        {
            _context.Carriers.Update(carrier);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Carrier carrier)
        {
            _context.Carriers.Remove(carrier);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
