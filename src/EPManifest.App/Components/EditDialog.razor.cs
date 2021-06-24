using System;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace EPManifest.App.Components
{
    public partial class EditDialog : IDisposable
    {
        private IEntityRepository<Carrier> _carrierRepo;

        private IEntityRepository<Consignee> _consigneeRepo;

        private IEntityRepository<Consignor> _consignorRepo;

        private ICompany _entity;

        private bool _isLoaded;

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
                    await _consignorRepo.Update((Consignor)_entity);
                    break;

                case Consignee:
                    await _consigneeRepo.Update((Consignee)_entity);
                    break;

                case Carrier:
                    await _carrierRepo.Update((Carrier)_entity);
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
                        _entity = _consignorRepo.GetById(Entity.Id);
                        break;

                    case Consignee:
                        _consigneeRepo = new ConsigneeRepository(ContextFactory.CreateDbContext());
                        _entity = _consigneeRepo.GetById(Entity.Id);
                        break;

                    case Carrier:
                        _carrierRepo = new CarrierRepository(ContextFactory.CreateDbContext());
                        _entity = _carrierRepo.GetById(Entity.Id);
                        break;
                }
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
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
