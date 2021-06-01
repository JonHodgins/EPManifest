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

namespace EPManifest.App.Pages.Consignees
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

        private ConsigneeRepository repo;
        private List<Consignee> consignees;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                repo = new ConsigneeRepository(ContextFactory.CreateDbContext());
                consignees = await repo.GetAllConsignees();
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private async Task Delete(Consignee consignee)
        {
            var parameters = new DialogParameters
            {
                { "ContentText", $"Are you sure that you want to delete Consignee: {consignee.Name}? This action cannot be undone." },
                { "ButtonText", "Delete" },
                { "Color", Color.Error }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = DialogService.Show<ConfirmationDialog>("Delete consignee", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    await repo.Delete(consignee);
                    consignees.Remove(consignee);
                    Logger.LogInformation($"consignee: {consignee.Code} was deleted.");
                    Snackbar.Add($"Deleted consignee id:{consignee.Id}", Severity.Success);
                }
                catch (DbUpdateException)
                {
                    Logger.LogInformation($"Failed to delete consignee id:{consignee.Id}.");
                    Snackbar.Add($"Unable to delete consignee: {consignee.Code}, as it is associated with a manifest", Severity.Error);
                }
                finally
                {
                    _mayRender = true;
                }
            }
        }

        private async Task Edit(Consignee consignee)
        {
            var parameters = new DialogParameters
            {
                { "ButtonText", "Update" },
                { "Color", Color.Success },
                { "Entity", consignee }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
            var dialog = DialogService.Show<EditDialog>("Edit consignee", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    consignees[consignees.IndexOf(consignee)].Code = ((Consignee)result.Data).Code;
                    consignees[consignees.IndexOf(consignee)].Name = ((Consignee)result.Data).Name;
                    Snackbar.Add($"Updated consignee id:{consignee.Id}", Severity.Success);
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
                { "Entity", new Consignee() }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
            var dialog = DialogService.Show<CreateDialog>("New consignee", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    consignees.Add((Consignee)result.Data);
                    Snackbar.Add($"Created consignee:{((Consignee)result.Data).Id}", Severity.Success);
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
