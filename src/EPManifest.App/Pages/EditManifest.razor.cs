using System;
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

        [Parameter]
        public int Id { get; set; }

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

        private async Task Update()
        {
            await repo.UpdateManifest(manifest);
            Navigation.NavigateTo("/manifests/list");
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
