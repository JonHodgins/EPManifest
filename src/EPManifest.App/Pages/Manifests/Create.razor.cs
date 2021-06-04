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
using MudBlazor;

namespace EPManifest.App.Pages.Manifests
{
    public partial class Create : IDisposable
    {
        private readonly Provinces[] provinces = (Provinces[])Enum.GetValues(typeof(Provinces));
        private readonly string itemPlaceholderDescription = "Click me";
        private bool _isLoaded;
        private Manifest manifest;
        private ManifestRepository repo;
        private HashSet<Consignor> selectedConsignors;
        public IList<Consignor> Consignors { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public ILogger<Create> Logger { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

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

        public void Dispose()
        {
            repo.Dispose();
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new ManifestRepository(ContextFactory.CreateDbContext());
                Consignors = await repo.GetAllConsignors();
                manifest = new Manifest
                {
                    Code = "",
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

        //The item methods modify the manifest field instead of the repository so that invalid changes are not persisted to the database.
        private void CreateItemPlaceholder()
        {
            manifest.Items.Add(new Item() { Description = "", ManifestId = manifest.Id });
        }

        private async Task CreateManifest()
        {
            await repo.Create(manifest);
            Snackbar.Add($"Successfully created manifest:{manifest.Code}", Severity.Success);
            Logger.LogInformation($"Successfully created manifest id:{manifest.Id}");
            Navigation.NavigateTo("/manifests");
        }

        private void DeleteItem(Item item)
        {
            manifest.Items.Remove(item);
        }

        private async Task<IEnumerable<Provinces>> SearchProvinces(string value)
        {
            return provinces.Where(p => p.ToString().StartsWith(value, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
