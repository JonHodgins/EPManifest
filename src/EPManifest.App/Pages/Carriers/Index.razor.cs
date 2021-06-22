using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EPManifest.App.Components;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MudBlazor;

namespace EPManifest.App.Pages.Carriers
{
    public partial class Index : IDisposable
    {
        private List<Carrier> _carriers;
        private bool _isLoaded;
        private bool _mayRender = true;
        private CarrierRepository _repo;

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

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _repo = new CarrierRepository(ContextFactory.CreateDbContext());
                _carriers = await _repo.GetAllCarriers().ConfigureAwait(false);
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync().ConfigureAwait(false);
        }

        protected override bool ShouldRender() => _mayRender;

        private async Task Create()
        {
            var parameters = new DialogParameters
            {
                { "ButtonText", "Create" },
                { "Color", Color.Success },
                { "Entity", new Carrier() }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
            var dialog = DialogService.Show<CreateDialog>("New Carrier", parameters, options);
            var result = await dialog.Result.ConfigureAwait(false);

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    _carriers.Add((Carrier)result.Data);
                    Snackbar.Add($"Created carrier:{((Carrier)result.Data).Id}", Severity.Success);
                }
                finally
                {
                    _mayRender = true;
                }
            }
        }

        private async Task Delete(Carrier carrier)
        {
            var parameters = new DialogParameters
            {
                { "ContentText", $"Are you sure that you want to delete {carrier.Name}? This action cannot be undone." },
                { "ButtonText", "Delete" },
                { "Color", Color.Error }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = DialogService.Show<ConfirmationDialog>("Delete Carrier", parameters, options);
            var result = await dialog.Result.ConfigureAwait(false);

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    await _repo.Delete(carrier).ConfigureAwait(false);
                    _carriers.Remove(carrier);
                    Logger.LogInformation($"Carrier: {carrier.Id}, Code: {carrier.Code}, Name: {carrier.Name}, was deleted.");
                    Snackbar.Add($"Deleted carrier {carrier.Code}: {carrier.Name}", Severity.Success);
                }
                catch (DbUpdateException)
                {
                    Logger.LogInformation($"Failed to delete carrier id:{carrier.Id}.");
                    Snackbar.Add($"Unable to delete carrier: {carrier.Code}, as it is associated with a manifest", Severity.Error);
                }
                finally
                {
                    _mayRender = true;
                }
            }
        }

        private async Task Edit(Carrier carrier)
        {
            var parameters = new DialogParameters
            {
                { "ButtonText", "Update" },
                { "Color", Color.Success },
                { "Entity", carrier }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
            var dialog = DialogService.Show<EditDialog>("Edit Carrier", parameters, options);
            var result = await dialog.Result.ConfigureAwait(false);

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    _carriers[_carriers.IndexOf(carrier)].Code = ((Carrier)result.Data).Code;
                    _carriers[_carriers.IndexOf(carrier)].Name = ((Carrier)result.Data).Name;
                    Snackbar.Add($"Updated carrier id:{carrier.Id}", Severity.Success);
                }
                finally
                {
                    _mayRender = true;
                }
            }
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
