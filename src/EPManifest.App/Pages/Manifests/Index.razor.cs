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
        private bool _bordered;
        private bool _dense = true;
        private bool _hover = true;
        private bool _isLoaded;
        private List<Manifest> _manifests;
        private bool _mayRender = true;
        private AuthenticationState _principal;
        private ManifestRepository _repo;
        private string _searchString = "";
        private Manifest _selectedItem;
        private bool _striped = true;

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Inject]
        public IDialogService DialogService { get; set; }

        [Inject]
        public ILogger<Index> Logger { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> AuthStateTask { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _principal = await AuthStateTask;
                _repo = new ManifestRepository(ContextFactory.CreateDbContext());
                _manifests = await _repo.GetAllManifests();
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        protected override bool ShouldRender() => _mayRender;

        private void Create()
        {
            Logger.LogInformation($"{_principal.User.FindFirst("name").Value} started creating a new manifest");
            Navigation.NavigateTo("/manifests/create/");
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
                    await _repo.Delete(manifest);
                    //Recreate DbContext after deleting to prevent change tracking errors on subsequent deletes
                    Dispose();
                    _repo = new ManifestRepository(ContextFactory.CreateDbContext());
                    _manifests.Remove(manifest);
                    Logger.LogInformation($"{_principal.User.FindFirst("name").Value} deleted manifest {manifest.Id} : {manifest.Code}");
                    Snackbar.Add($"Deleted manifest id:{manifest.Id}", Severity.Success);
                }
                finally
                {
                    _mayRender = true;
                }
            }
        }

        private void Details(int manifestId)
        {
            Logger.LogInformation($"{_principal.User.FindFirst("name").Value} is viewing manifest {manifestId}");
            Navigation.NavigateTo("/manifests/details/" + manifestId);
        }

        private void Edit(int manifestId)
        {
            Logger.LogInformation($"{_principal.User.FindFirst("name").Value} started editing manifest {manifestId}");
            Navigation.NavigateTo("/manifests/edit/" + manifestId);
        }

        private bool FilterFunc(Manifest manifest)
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;
            if (manifest.Consignors.Any(c => c.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase)))
                return true;
            if (manifest.Consignee.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (manifest.Carrier.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
