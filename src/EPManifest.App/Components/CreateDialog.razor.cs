using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace EPManifest.App.Components
{
    public partial class CreateDialog : IDisposable
    {
        private bool _isLoaded;

        private IEntityRepository<Carrier> _carrierRepo;

        private IEntityRepository<Consignee> _consigneeRepo;

        private IEntityRepository<Consignor> _consignorRepo;

        private ICompany _entity;

        [Parameter]
        public string ButtonText { get; set; }

        [Parameter]
        public Color Color { get; set; }

        [Parameter]
        public string ContentText { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Parameter]
        public ICompany Entity { get; set; }

        [CascadingParameter]
        private MudDialogInstance MudDialog { get; set; }

        public async Task OnValidSubmit()
        {
            switch (Entity)
            {
                case Consignor:
                    await _consignorRepo.Create((Consignor)_entity).ConfigureAwait(false);
                    break;

                case Consignee:
                    await _consigneeRepo.Create((Consignee)_entity).ConfigureAwait(false);
                    break;

                case Carrier:
                    await _carrierRepo.Create((Carrier)_entity).ConfigureAwait(false);
                    break;
            }
            Submit();
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                switch (Entity)
                {
                    case Consignor:
                        _consignorRepo = new ConsignorRepository(ContextFactory.CreateDbContext());
                        _entity = new Consignor();
                        break;

                    case Consignee:
                        _consigneeRepo = new ConsigneeRepository(ContextFactory.CreateDbContext());
                        _entity = new Consignee();
                        break;

                    case Carrier:
                        _carrierRepo = new CarrierRepository(ContextFactory.CreateDbContext());
                        _entity = new Carrier();
                        break;
                }
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync().ConfigureAwait(false);
        }

        private void Cancel() => MudDialog.Cancel();

        private void Submit() => MudDialog.Close(DialogResult.Ok(_entity));

        public void Dispose()
        {
            switch (Entity)
            {
                case Consignor:
                    _consignorRepo.Dispose();
                    break;

                case Consignee:
                    _consigneeRepo.Dispose();
                    break;

                case Carrier:
                    _carrierRepo.Dispose();
                    break;
            }
        }
    }
}
