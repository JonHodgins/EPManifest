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
        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [CascadingParameter]
        private MudDialogInstance MudDialog { get; set; }

        [Parameter]
        public string ContentText { get; set; }

        [Parameter]
        public string ButtonText { get; set; }

        [Parameter]
        public Color Color { get; set; }

        [Parameter]
        public ICompany Entity { get; set; }

        private IEntityRepository<Consignor> consignorRepo;
        private IEntityRepository<Consignee> consigneeRepo;
        private IEntityRepository<Carrier> carrierRepo;

        private ICompany entity;

        private bool _isLoaded;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                switch (Entity)
                {
                    case Consignor:
                        consignorRepo = new ConsignorRepository(ContextFactory.CreateDbContext());
                        entity = new Consignor();
                        break;

                    case Consignee:
                        consigneeRepo = new ConsigneeRepository(ContextFactory.CreateDbContext());
                        entity = new Consignee();
                        break;

                    case Carrier:
                        carrierRepo = new CarrierRepository(ContextFactory.CreateDbContext());
                        entity = new Carrier();
                        break;
                }
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private void Submit() => MudDialog.Close(DialogResult.Ok(entity));

        private void Cancel() => MudDialog.Cancel();

        public async Task OnValidSubmit()
        {
            switch (Entity)
            {
                case Consignor:
                    await consignorRepo.Create((Consignor)entity);
                    break;

                case Consignee:
                    await consigneeRepo.Create((Consignee)entity);
                    break;

                case Carrier:
                    await carrierRepo.Create((Carrier)entity);
                    break;
            }
            Submit();
        }

        public void Dispose()
        {
            switch (Entity)
            {
                case Consignor:
                    consignorRepo.Dispose();
                    break;

                case Consignee:
                    consigneeRepo.Dispose();
                    break;

                case Carrier:
                    carrierRepo.Dispose();
                    break;
            }
        }
    }
}
