using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Core;
using Microsoft.EntityFrameworkCore;

namespace EPManifest.Data.Repositories
{
    public class ConsigneeRepository : IDisposable
    {
        private readonly EPManifestDbContext _context;

        public ConsigneeRepository(EPManifestDbContext context)
        {
            _context = context;
        }

        public async Task<List<Consignee>> GetAllConsignees()
        {
            return await _context.Consignees.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<Consignee> Create(Consignee consignee)
        {
            var newConsignee = _context.Consignees.Add(consignee);
            await _context.SaveChangesAsync();
            return newConsignee.Entity;
        }

        public async Task Update(Consignee consignee)
        {
            _context.Consignees.Update(consignee);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Consignee consignee)
        {
            _context.Consignees.Remove(consignee);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
