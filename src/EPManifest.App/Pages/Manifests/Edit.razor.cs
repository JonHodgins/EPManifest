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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MudBlazor;

namespace EPManifest.App.Pages.Manifests
{
    public partial class Edit : IDisposable
    {
        private readonly Converter<string> _formatPostalCode = new()
        {
            SetFunc = value => value?.FormatPostalCode(),
            GetFunc = text => text?.FormatPostalCode(),
        };

        private readonly string _itemPlaceholderDescription = "Click me";

        private readonly Provinces[] _provinces = (Provinces[])Enum.GetValues(typeof(Provinces));

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

        private bool _isLoaded;
        private Manifest _manifest;
        private AuthenticationState _principal;
        private ManifestRepository _repo;
        private HashSet<Consignor> _selectedConsignors = new();
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
        private Task<AuthenticationState> AuthStateTask { get; set; }

        private HashSet<Consignor> SelectedConsignors
        {
            get => _selectedConsignors;
            set
            {
                _selectedConsignors = value;
                _manifest.Consignors.RemoveAll(_ => true);
                foreach (var consignor in _selectedConsignors)
                {
                    _manifest.Consignors.Add(consignor);
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _principal = await AuthStateTask;
                _repo = new ManifestRepository(ContextFactory.CreateDbContext());
                _manifest = await _repo.GetManifestById(Id);
                PopulateSelectedConsignors();
                Consignors = await _repo.GetAllConsignors();

                if (_manifest.ConsigneeAddress is null)
                {
                    _manifest.ConsigneeAddress = new Address();
                }

                if (_manifest.ConsignorAddress is null)
                {
                    _manifest.ConsignorAddress = new Address();
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
            _manifest.Items.Add(new Item() { Description = "", ManifestId = _manifest.Id });
        }

        private void DeleteItem(Item item)
        {
            _manifest.Items.Remove(item);
        }

        private void PopulateSelectedConsignors()
        {
            foreach (var consignor in _manifest.Consignors)
            {
                SelectedConsignors.Add(consignor);
            }
        }

        private Task<IEnumerable<Provinces>> SearchProvinces(string value)
        {
            return Task.FromResult(_provinces.Where(p => p.ToString().StartsWith(value, StringComparison.InvariantCultureIgnoreCase)));
        }

        private async Task Update()
        {
            await _repo.Update();
            Snackbar.Add($"Successfully updated manifest {_manifest.Code} (Id: {_manifest.Id})", Severity.Success);
            Logger.LogInformation($"{_principal.User.FindFirst("name").Value} updated manifest {_manifest.Code} (Id: {_manifest.Id})");
            Navigation.NavigateTo($"/manifests/details/{_manifest.Id}");
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
