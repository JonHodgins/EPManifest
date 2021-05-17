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
        public IEnumerable<Consignor> Consignors { get; set; }
        public IEnumerable<Consignee> Consignees { get; set; }
        public IEnumerable<Carrier> Carriers { get; set; }

        [Parameter]
        public int Id { get; set; }

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
                manifest = await repo.GetManifestById(Id);
                PopulateSelectedConsignors();
                Consignors = await repo.GetConsignors();
                Consignees = await repo.GetConsignees();
                Carriers = await repo.GetCarriers();
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

        private void AddSelectedConsignorsToManifest()
        {
            manifest.Consignors.RemoveAll(_ => true);
            foreach (var consignor in SelectedConsignors)
            {
                manifest.Consignors.Add(consignor);
            }
        }

        private async Task Update()
        {
            AddSelectedConsignorsToManifest();
            await repo.UpdateManifest(manifest);
            Navigation.NavigateTo("/manifests/list");
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
