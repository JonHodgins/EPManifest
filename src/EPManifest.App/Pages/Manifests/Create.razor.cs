using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPManifest.App.Extensions;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MudBlazor;

namespace EPManifest.App.Pages.Manifests
{
    public partial class Create : IDisposable
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
        private ManifestRepository _repo;
        private HashSet<Consignor> _selectedConsignors;

        public IList<Consignor> Consignors { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public ILogger<Create> Logger { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

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
                _repo = new ManifestRepository(ContextFactory.CreateDbContext());
                Consignors = await _repo.GetAllConsignors();
                _manifest = new Manifest
                {
                    Code = "",
                    ConsigneeAddress = new Address(),
                    ConsignorAddress = new Address()
                };
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

        private async Task CreateManifest()
        {
            await _repo.Create(_manifest);
            Snackbar.Add($"Successfully created manifest {_manifest.Code} (Id: {_manifest.Id})", Severity.Success);
            Logger.LogInformation($"Successfully created manifest {_manifest.Code} (Id: {_manifest.Id})");
            Navigation.NavigateTo($"/manifests/details/{_manifest.Id}");
        }

        private void DeleteItem(Item item)
        {
            _manifest.Items.Remove(item);
        }

        private async Task<IEnumerable<Provinces>> SearchProvinces(string value)
        {
            return _provinces.Where(p => p.ToString().StartsWith(value, StringComparison.InvariantCultureIgnoreCase));
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
