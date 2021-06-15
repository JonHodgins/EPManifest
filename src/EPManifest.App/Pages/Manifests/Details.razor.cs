using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using BlazorDownloadFile;
using EPManifest.Core;
using EPManifest.Data;
using EPManifest.Data.Repositories;
using EPManifest.Reports;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EPManifest.App.Pages.Manifests
{
    public partial class Details : IDisposable
    {
        private bool _isLoaded;
        private Manifest manifest;
        private AuthenticationState _principal;
        private ManifestRepository repo;
        private string _message = string.Empty;

        [Inject]
        private IBlazorDownloadFileService BlazorDownloadFileService { get; set; }

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public ILogger<Create> Logger { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> AuthState { get; set; }

        public void Dispose()
        {
            Logger.LogInformation($"Disposing manifest {manifest.Id} details");
            repo.Dispose();
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _principal = AuthState.Result;
                repo = new ManifestRepository(ContextFactory.CreateDbContext());
                manifest = await repo.GetManifestById(Id);
            }
            finally
            {
                _isLoaded = true;
            }

            await base.OnInitializedAsync();
        }

        private string ConsignorsToString()
        {
            var temp = new List<string>();
            foreach (var consignor in manifest.Consignors)
            {
                temp.Add(consignor.Name.Replace(",", ""));
            }
            return string.Join(", ", temp);
        }

        private void Edit()
        {
            Logger.LogInformation($"{_principal.User.FindFirst("name").Value} started editing manifest {manifest.Id} : {manifest.Code}");
            Navigation.NavigateTo("/manifests/edit/" + manifest.Id);
        }

        private async Task GeneratePDFAsync()
        {
            Logger.LogInformation($"Generating report PDF for manifest {manifest.Id}");
            await Generator.GenerateManifestPDFAsync(manifest.Id);
            Logger.LogInformation($"Generated report PDF for manifest {manifest.Id}");
            await DownloadPDF();
        }

        public async Task DownloadPDF()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"Reports/manifest{manifest.Id}.pdf");
            var bytes = File.ReadAllBytes(path);
            var task = await BlazorDownloadFileService.DownloadFile($"manifest{manifest.Id}.pdf", bytes.ToList(), CancellationToken.None, "application/octet-stream");
            if (task.Succeeded)
            {
                _message = "Successful download!";
                Logger.LogInformation($"{_principal.User.FindFirst("name").Value} successfully downloaded report PDF for manifest {manifest.Id} : {manifest.Code}");
            }
            else
            {
                _message = task.ErrorMessage;
                Logger.LogInformation($"There was an error downloading the PDF: {_message}");
            }
        }
    }
}
