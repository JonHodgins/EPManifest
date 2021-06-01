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

namespace EPManifest.App.Pages.Consignors
{
    public partial class Index : IDisposable
    {
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

        private bool _isLoaded;
        private bool _mayRender = true;

        private ConsignorRepository repo;
        private List<Consignor> consignors;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new ConsignorRepository(ContextFactory.CreateDbContext());
                consignors = await repo.GetAllConsignors();
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private async Task Delete(Consignor consignor)
        {
            var parameters = new DialogParameters
            {
                { "ContentText", $"Are you sure that you want to delete Consignor: {consignor.Name}? This action cannot be undone." },
                { "ButtonText", "Delete" },
                { "Color", Color.Error }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = DialogService.Show<ConfirmationDialog>("Delete consignor", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    await repo.Delete(consignor);
                    consignors.Remove(consignor);
                    Logger.LogInformation($"consignor: {consignor.Code} was deleted.");
                    Snackbar.Add($"Deleted consignor id:{consignor.Id}", Severity.Success);
                }
                catch (DbUpdateException)
                {
                    Logger.LogInformation($"Failed to delete consignor id:{consignor.Id}.");
                    Snackbar.Add($"Unable to delete consignor: {consignor.Code}, as it is associated with a manifest", Severity.Error);
                }
                finally
                {
                    _mayRender = true;
                }
            }
        }

        private async Task Edit(Consignor consignor)
        {
            var parameters = new DialogParameters
            {
                { "ButtonText", "Update" },
                { "Color", Color.Success },
                { "Entity", consignor }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
            var dialog = DialogService.Show<EditDialog>("Edit consignor", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    consignors[consignors.IndexOf(consignor)].Code = ((Consignor)result.Data).Code;
                    consignors[consignors.IndexOf(consignor)].Name = ((Consignor)result.Data).Name;
                    Snackbar.Add($"Updated consignor id:{consignor.Id}", Severity.Success);
                }
                finally
                {
                    _mayRender = true;
                }
            }
        }

        private async Task Create()
        {
            var parameters = new DialogParameters
            {
                { "ButtonText", "Create" },
                { "Color", Color.Success },
                { "Entity", new Consignor() }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
            var dialog = DialogService.Show<CreateDialog>("New consignor", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    consignors.Add((Consignor)result.Data);
                    Snackbar.Add($"Created consignor:{((Consignor)result.Data).Id}", Severity.Success);
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
