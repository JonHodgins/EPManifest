using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace EPManifest.App.Pages
{
    public partial class ManifestList : IDisposable
    {
        private bool isLoaded;
        private bool dense;
        private bool hover = true;
        private bool striped;
        private bool bordered;
        private ManifestRepository repo;
        private string searchString = "";
        private Manifest selectedItem = null;
        private HashSet<Manifest> selectedItems = new HashSet<Manifest>();
        private IQueryable<Manifest> manifests;

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        public void Dispose()
        {
            repo.Dispose();
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new ManifestRepository(ContextFactory.CreateDbContext());
                manifests = repo.GetAllManifests();
            }
            finally
            {
                isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private bool FilterFunc(Manifest manifest)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (manifest.Consignor.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (manifest.Consignee.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            //if ($"{element.Number} {element.Position} {element.Molar}".Contains(searchString))
            //    return true;
            return false;
        }
    }
}
