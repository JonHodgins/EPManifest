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
using Microsoft.Extensions.Logging;
using MudBlazor;

namespace EPManifest.App.Pages
{
    public partial class CarrierList : IDisposable
    {
        [Inject]
        public ILogger<CarrierList> Logger { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public IDialogService DialogService { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        private bool _isLoaded;
        private bool _mayRender = true;

        private CarrierRepository repo;
        private List<Carrier> carriers;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new CarrierRepository(ContextFactory.CreateDbContext());
                carriers = await repo.GetAllCarriers();
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private async Task Delete(Carrier carrier)
        {
            var parameters = new DialogParameters
            {
                { "ContentText", $"Are you sure that you want to delete carrier #{carrier.Id}? This action cannot be undone." },
                { "ButtonText", "Delete" },
                { "Color", Color.Error }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = DialogService.Show<ConfirmationDialog>("Delete Carrier", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    await repo.Delete(carrier);
                    carriers.Remove(carrier);
                    Logger.LogInformation($"Carrier: {carrier.Code} was deleted.");
                    Snackbar.Add($"Deleted carrier id:{carrier.Id}", Severity.Success);
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
                { "ContentText", $"Editing {carrier.Id}" },
                { "ButtonText", "Update" },
                { "Color", Color.Success },
                { "Entity", carrier }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
            var dialog = DialogService.Show<EditDialog>("Edit Carrier", parameters, options);
            var result = await dialog.Result;

            //TODO: Changes are not visible on component re-render
            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
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
            repo.Dispose();
        }
    }
}
