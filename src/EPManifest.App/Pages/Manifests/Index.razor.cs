using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPManifest.App.Components;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MudBlazor;

namespace EPManifest.App.Pages.Manifests
{
    public partial class Index : IDisposable
    {
        private bool dense = true;
        private bool hover = true;
        private bool striped = true;
        private bool bordered;
        private string searchString = "";

        private AuthenticationState _principal;
        private ManifestRepository repo;
        private Manifest selectedItem;
        private List<Manifest> manifests;

        private bool _isLoaded;
        private bool _mayRender = true;

        [Inject]
        public ILogger<Index> Logger { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public IDialogService DialogService { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> AuthState { get; set; }

        public void Dispose()
        {
            repo.Dispose();
        }

        protected override bool ShouldRender() => _mayRender;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _principal = AuthState.Result;
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

            var dialog = DialogService.Show<ConfirmationDialog>("Delete Manifest", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    await repo.Delete(manifest);
                    //Recreate DbContext after deleting to prevent change tracking errors on subsequent deletes
                    Dispose();
                    repo = new ManifestRepository(ContextFactory.CreateDbContext());
                    manifests.Remove(manifest);
                    Logger.LogInformation($"{_principal.User.FindFirst("name").Value} deleted manifest {manifest.Id} : {manifest.Code}");
                    Snackbar.Add($"Deleted manifest id:{manifest.Id}", Severity.Success);
                }
                finally
                {
                    _mayRender = true;
                }
            }
        }

        private void Edit(int manifestId)
        {
            Logger.LogInformation($"{_principal.User.FindFirst("name").Value} started editing manifest {manifestId}");
            Navigation.NavigateTo("/manifests/edit/" + manifestId);
        }

        private void Create()
        {
            Logger.LogInformation($"{_principal.User.FindFirst("name").Value} started creating a new manifest");
            Navigation.NavigateTo("/manifests/create/");
        }

        private void Details(int manifestId)
        {
            Logger.LogInformation($"{_principal.User.FindFirst("name").Value} is viewing manifest {manifestId}");
            Navigation.NavigateTo("/manifests/details/" + manifestId);
        }

        private bool FilterFunc(Manifest manifest)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (manifest.Consignors.Any(c => c.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)))
                return true;
            if (manifest.Consignee.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (manifest.Carrier.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }
    }
}
