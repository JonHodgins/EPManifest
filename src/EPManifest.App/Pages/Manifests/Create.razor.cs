using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace EPManifest.App.Pages.Manifests
{
    public partial class Create : IDisposable
    {
        private bool _isLoaded;
        private ManifestRepository repo;
        private Manifest manifest;
        private Consignee consignee;
        public IList<Consignor> Consignors { get; set; }
        public IList<Consignee> Consignees { get; set; }
        public IList<Carrier> Carriers { get; set; }

        public Provinces Provinces { get; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public ILogger<Create> Logger { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        private HashSet<Consignor> SelectedConsignors { get; set; } = new HashSet<Consignor>();

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new ManifestRepository(ContextFactory.CreateDbContext());
                Consignors = await repo.GetAllConsignors();
                Consignees = await repo.GetAllConsignees();
                Carriers = await repo.GetAllCarriers();
                manifest = new Manifest
                {
                    Code = "",
                    Carrier = Carriers[0],
                    ConsigneeAddress = new Address(),
                    ConsignorAddress = new Address()
                };
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private void AddSelectedConsignorsToManifest()
        {
            manifest.Consignors.RemoveAll(_ => true);
            foreach (var consignor in SelectedConsignors)
            {
                manifest.Consignors.Add(consignor);
            }
        }

        private async Task CreateManifest(EditContext context)
        {
            manifest.ConsigneeId = manifest.Consignee.Id;
            AddSelectedConsignorsToManifest();
            await repo.Create(manifest);
            Logger.LogInformation($"Successfully created manifest id:{manifest.Id}");
            Navigation.NavigateTo("/manifests");
        }

        //The item methods modify the manifest field instead of the repository so that invalid changes are not persisted to the database.
        private void CreateItemPlaceholder()
        {
            manifest.Items.Add(new Item() { Description = "", ManifestId = manifest.Id });
        }

        private Task<IEnumerable<Consignee>> SearchConsignees(string value)
        {
            return repo.SearchConsignees(value);
        }

        private void DeleteItem(Item item)
        {
            manifest.Items.Remove(item);
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
