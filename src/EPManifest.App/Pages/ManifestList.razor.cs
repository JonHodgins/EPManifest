using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPManifest.App.Components;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace EPManifest.App.Pages
{
    public partial class ManifestList : IDisposable
    {
        private bool dense;
        private bool hover = true;
        private bool striped;
        private bool bordered;
        private string searchString = "";

        private ManifestRepository repo;
        private Manifest selectedItem;
        private List<Manifest> manifests;

        private bool _isLoaded;
        private bool _mayRender = true;

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public IDialogService DialogService { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        public void Dispose()
        {
            repo.Dispose();
        }

        protected override bool ShouldRender() => _mayRender;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new ManifestRepository(ContextFactory.CreateDbContext());
                manifests = await repo.GetAllManifests();
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private async Task Delete(Manifest manifest)
        {
            var parameters = new DialogParameters
            {
                { "ContentText", $"Are you sure that you want to delete manifest #{manifest.Id}? This action cannot be undone." },
                { "ButtonText", "Delete" },
                { "Color", Color.Error }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = DialogService.Show<DeleteManifestDialog>("Delete Manifest", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                //Need to prevent mid-method rerendering of the component to avoid overlapping threads
                _mayRender = false;
                try
                {
                    await repo.DeleteManifest(manifest);
                }
                finally
                {
                    manifests.Remove(manifest);
                    _mayRender = true;
                    Snackbar.Add($"Deleted manifest #{manifest.Id}", Severity.Success);
                }
            }
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
