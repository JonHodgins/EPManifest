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

namespace EPManifest.App.Pages.Consignees
{
    public partial class Index : IDisposable
    {
        private bool _isLoaded;
        private bool _mayRender = true;
        private List<Consignee> _consignees;
        private ConsigneeRepository _repo;

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
                _repo = new ConsigneeRepository(ContextFactory.CreateDbContext());
                _consignees = await _repo.GetAllConsignees().ConfigureAwait(false);
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
                { "Entity", new Consignee() }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
            var dialog = DialogService.Show<CreateDialog>("New consignee", parameters, options);
            var result = await dialog.Result.ConfigureAwait(false);

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    _consignees.Add((Consignee)result.Data);
                    Snackbar.Add($"Created consignee:{((Consignee)result.Data).Id}", Severity.Success);
                }
                finally
                {
                    _mayRender = true;
                }
            }
        }

        private async Task Delete(Consignee consignee)
        {
            var parameters = new DialogParameters
            {
                { "ContentText", $"Are you sure that you want to delete {consignee.Name}? This action cannot be undone." },
                { "ButtonText", "Delete" },
                { "Color", Color.Error }
            };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = DialogService.Show<ConfirmationDialog>("Delete consignee", parameters, options);
            var result = await dialog.Result.ConfigureAwait(false);

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    await _repo.Delete(consignee).ConfigureAwait(false);
                    _consignees.Remove(consignee);
                    Logger.LogInformation($"consignee: {consignee.Id}, Code: {consignee.Code}, Name: {consignee.Name}, was deleted.");
                    Snackbar.Add($"Deleted consignee {consignee.Code}: {consignee.Name}", Severity.Success);
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
            var result = await dialog.Result.ConfigureAwait(false);

            if (!result.Cancelled)
            {
                //Prevents mid-method rerendering of the component, which avoids overlapping threads
                _mayRender = false;
                try
                {
                    _consignees[_consignees.IndexOf(consignee)].Code = ((Consignee)result.Data).Code;
                    _consignees[_consignees.IndexOf(consignee)].Name = ((Consignee)result.Data).Name;
                    Snackbar.Add($"Updated consignee id:{consignee.Id}", Severity.Success);
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
