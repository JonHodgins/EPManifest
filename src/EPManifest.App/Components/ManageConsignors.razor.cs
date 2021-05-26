//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using EPManifest.Core;
//using EPManifest.Data;
//using EPManifest.Data.Repositories;
//using Microsoft.AspNetCore.Components;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;

//namespace EPManifest.App.Components
//{
//    public partial class ManageConsignors : IDisposable
//    {
//        [Parameter]
//        public int Id { get; set; }

//        [Inject]
//        public ILogger<EditConsignorDialog> Logger { get; set; }

//        [Inject]
//        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

//        private bool _isLoaded;
//        private ConsignorRepository repo;
//        private Consignor consignor;

//        protected override async Task OnInitializedAsync()
//        {
//            try
//            {
//                repo = new ConsignorRepository(ContextFactory.CreateDbContext());
//                consignor = await repo.GetById(Id);
//            }
//            finally
//            {
//                _isLoaded = true;
//            }

//            await base.OnInitializedAsync();
//        }

//        public async Task Update()
//        {
//            await repo.Update(consignor);
//            Logger.LogInformation($"Successfully updated consignor id:{consignor.Id}");
//        }

//        public void Dispose()
//        {
//            repo.Dispose();
//        }
//    }
//}
