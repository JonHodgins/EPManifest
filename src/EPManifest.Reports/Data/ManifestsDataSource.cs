using System.Threading.Tasks;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EPManifest.Reports.Data
{
    public class ManifestsDataSource : DataSourceBase
    {
        private ManifestRepository _repo;

        public ManifestsDataSource() : base(
                                            new DbContextOptionsBuilder<EPManifestDbContext>()
                                                .UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=EPManifest")
                                                .EnableSensitiveDataLogging()
                                                .Options)
        {
        }

        public async Task<ManifestModel> GetManifestDetailsAsync(int id)
        {
            using var _context = new EPManifestDbContext(ContextOptions);
            _repo = new ManifestRepository(_context);

            var manifest = await _repo.GetManifestById(id);

            return new ManifestModel
            {
                LogoData = Helpers.GetImage("logo.png"),
                Code = manifest.Code,
                DateShipped = manifest.DateShipped,
                DateScheduledArrival = manifest.DateScheduledArrival,
                Consignors = manifest.Consignors,
                Consignee = manifest.Consignee,
                Carrier = manifest.Carrier,
                Items = manifest.Items,
                ConsignorAddress = manifest.ConsignorAddress,
                ConsigneeAddress = manifest.ConsigneeAddress
            };
        }
    }
}
