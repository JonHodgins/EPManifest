using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPManifest.App.Extensions;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MudBlazor;

namespace EPManifest.App.Pages.Manifests
{
    public partial class Edit : IDisposable
    {
        private readonly Converter<string> _toTitleCase = new()
        {
            SetFunc = value => value?.ToTitleCase(),
            GetFunc = text => text?.ToTitleCase(),
        };

        private readonly Converter<string> _toUpper = new()
        {
            SetFunc = value => value?.ToUpper(),
            GetFunc = text => text?.ToUpper(),
        };

        private readonly Converter<string> _formatPostalCode = new()
        {
            SetFunc = value => value?.FormatPostalCode(),
            GetFunc = text => text?.FormatPostalCode(),
        };

        private readonly Provinces[] provinces = (Provinces[])Enum.GetValues(typeof(Provinces));
        private readonly string _itemPlaceholderDescription = "Click me";
        private bool _isLoaded;
        private Manifest manifest;
        private AuthenticationState _principal;
        private ManifestRepository repo;
        private HashSet<Consignor> selectedConsignors = new();
        public IEnumerable<Consignor> Consignors { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public ILogger<Edit> Logger { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> AuthState { get; set; }

        private HashSet<Consignor> SelectedConsignors
        {
            get => selectedConsignors;
            set
            {
                selectedConsignors = value;
                manifest.Consignors.RemoveAll(_ => true);
                foreach (var consignor in selectedConsignors)
                {
                    manifest.Consignors.Add(consignor);
                }
            }
        }

        public void Dispose()
        {
            repo.Dispose();
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _principal = AuthState.Result;
                repo = new ManifestRepository(ContextFactory.CreateDbContext());
                manifest = await repo.GetManifestById(Id);
                PopulateSelectedConsignors();
                Consignors = await repo.GetAllConsignors();

                if (manifest.ConsigneeAddress is null)
                {
                    manifest.ConsigneeAddress = new Address();
                }

                if (manifest.ConsignorAddress is null)
                {
                    manifest.ConsignorAddress = new Address();
                }
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        //The item methods modify the manifest field instead of the repository so that invalid changes are not persisted to the database.
        private void CreateItemPlaceholder()
        {
            manifest.Items.Add(new Item() { Description = "", ManifestId = manifest.Id });
        }

        private void DeleteItem(Item item)
        {
            manifest.Items.Remove(item);
        }

        private void PopulateSelectedConsignors()
        {
            foreach (var consignor in manifest.Consignors)
            {
                SelectedConsignors.Add(consignor);
            }
        }

        private async Task<IEnumerable<Provinces>> SearchProvinces(string value)
        {
            return provinces.Where(p => p.ToString().StartsWith(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private async Task Update()
        {
            await repo.Update();
            Snackbar.Add($"Successfully updated manifest {manifest.Code} (Id: {manifest.Id})", Severity.Success);
            Logger.LogInformation($"{_principal.User.FindFirst("name").Value} updated manifest {manifest.Code} (Id: {manifest.Id})");
            Navigation.NavigateTo($"/manifests/details/{manifest.Id}");
        }
    }
}
