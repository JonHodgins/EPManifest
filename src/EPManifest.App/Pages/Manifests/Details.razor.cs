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

namespace EPManifest.App.Pages.Manifests
{
    public partial class Details : IDisposable
    {
        private bool _isLoaded;
        private ManifestRepository repo;
        private Manifest manifest;

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public ILogger<Create> Logger { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new ManifestRepository(ContextFactory.CreateDbContext());
                manifest = await repo.GetManifestById(Id);
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private string ConsignorsToString()
        {
            var temp = new List<string>();
            foreach (var consignor in manifest.Consignors)
            {
                temp.Add(consignor.Name);
            }
            return string.Join(",", temp);
        }

        private void Edit()
        {
            Logger.LogInformation($"Started editing manifest id:{manifest.Id}");
            Navigation.NavigateTo("/manifests/edit/" + manifest.Id);
        }

        public void Dispose()
        {
            Logger.LogInformation($"Disposing details {manifest.Id}");
            repo.Dispose();
        }
    }
}
