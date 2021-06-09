using System.Collections.Generic;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EPManifest.Reports.Data
{
    public class ManifestsDataSource : DataSourceBase
    {
        private EPManifestDbContext _context;
        private ManifestRepository _repo;
        private List<Manifest> _manifests;
        private List<ManifestModel> _models;
        private ManifestModel _model;

        public ManifestsDataSource() : base(
                                            new DbContextOptionsBuilder<EPManifestDbContext>()
                                                .UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=EPManifest")
                                                .EnableSensitiveDataLogging()
                                                .Options)
        {
            using var _context = new EPManifestDbContext(ContextOptions);
            _repo = new ManifestRepository(_context);
            var init = Init();
            while (!init.IsCompleted)
            {
            }
        }

        public async Task Init()
        {
            _manifests = await _repo.GetAllManifests();
        }

        public List<ManifestModel> GetManifestsDetails()
        {
            List<ManifestModel> manifestModels = new List<ManifestModel>();
            for (var i = 0; i < _manifests.Count; i++)
            {
                var manifest = _manifests[i];
                manifestModels.Add(new ManifestModel
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
                });
            }
            return manifestModels;
        }

        public ManifestModel GetManifestDetails(int id)
        {
            var manifest = _manifests[id - 1];
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
