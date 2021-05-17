using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace EPManifest.App.Pages
{
    public partial class EditManifest : IDisposable
    {
        private bool _isLoaded;
        private ManifestRepository repo;
        private Manifest manifest;
        public IEnumerable<Consignor> AllConsignors { get; set; }
        public IEnumerable<Consignee> AllConsignees { get; set; }
        public IEnumerable<Carrier> AllCarriers { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        private HashSet<Consignor> SelectedConsignors { get; set; } = new HashSet<Consignor>();
        private string value { get; set; } = "Nothing selected";

        public void Dispose()
        {
            repo.Dispose();
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new ManifestRepository(ContextFactory.CreateDbContext());
                manifest = await repo.GetManifestById(Id);
                PopulateSelectedConsignors();
                AllConsignors = await repo.GetConsignors();
                AllConsignees = await repo.GetConsignees();
                AllCarriers = await repo.GetCarriers();
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private void PopulateSelectedConsignors()
        {
            foreach (var consignor in manifest.Consignors)
            {
                SelectedConsignors.Add(consignor);
            }
        }

        private void PopulateManifestConsignors()
        {
            manifest.Consignors.RemoveAll(_ => true);
            foreach (var consignor in SelectedConsignors)
            {
                manifest.Consignors.Add(consignor);
            }
        }

        private async Task Update()
        {
            PopulateManifestConsignors();
            await repo.UpdateManifest(manifest);
            Navigation.NavigateTo("/manifests/list");
        }
    }
}
