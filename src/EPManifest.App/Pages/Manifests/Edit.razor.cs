using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EPManifest.App.Pages.Manifests
{
    public partial class Edit : IDisposable
    {
        private bool _isLoaded;
        private ManifestRepository repo;
        private Manifest manifest;
        public IEnumerable<Consignor> Consignors { get; set; }
        public IEnumerable<Consignee> Consignees { get; set; }
        public IEnumerable<Carrier> Carriers { get; set; }

        private readonly Provinces[] provinces = (Provinces[])Enum.GetValues(typeof(Provinces));

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public ILogger<Edit> Logger { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        private HashSet<Consignor> selectedConsignors;
        private HashSet<Consignor> SelectedConsignors
        {
            get => selectedConsignors;
            set
            {
                selectedConsignors = value;
                manifest.Consignors.RemoveAll(_ => true);
                foreach (var consignor in selectedConsignors)
                {
                    manifest.Consignors.Add(consignor);
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new ManifestRepository(ContextFactory.CreateDbContext());
                manifest = await repo.GetManifestById(Id);
                PopulateSelectedConsignors();
                Consignors = await repo.GetAllConsignors();
                Consignees = await repo.GetAllConsignees();
                Carriers = await repo.GetAllCarriers();
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private async Task<IEnumerable<Provinces>> SearchProvinces(string value)
        {
            return provinces.Where(p => p.ToString().StartsWith(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private void PopulateSelectedConsignors()
        {
            foreach (var consignor in manifest.Consignors)
            {
                SelectedConsignors.Add(consignor);
            }
        }

        private async Task Update(EditContext context)
        {
            await repo.Update(manifest);
            Logger.LogInformation($"Successfully updated manifest id:{manifest.Id}");
            Navigation.NavigateTo("/manifests");
        }

        //The item methods modify the manifest field instead of the repository so that invalid changes are not persisted to the database.
        private void CreateItemPlaceholder()
        {
            manifest.Items.Add(new Item() { Description = "", ManifestId = manifest.Id });
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
