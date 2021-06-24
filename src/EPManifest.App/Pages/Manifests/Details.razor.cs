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
        private Manifest _manifest;
        private string _message = string.Empty;
        private AuthenticationState _principal;
        private string _userName;
        private ManifestRepository _repo;

        [Inject]
        public IDbContextFactory<EPManifestDbContext> ContextFactory { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public ILogger<Create> Logger { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> AuthStateTask { get; set; }

        [Inject]
        private IBlazorDownloadFileService BlazorDownloadFileService { get; set; }

        public async Task DownloadPDF()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"Reports/manifest{_manifest.Id}.pdf");
            var bytes = File.ReadAllBytes(path);
            var task = await BlazorDownloadFileService.DownloadFile($"manifest{_manifest.Id}.pdf", bytes.ToList(), CancellationToken.None, "application/octet-stream");
            if (task.Succeeded)
            {
                _message = "Successful download!";
                Logger.LogInformation("{UserName} successfully downloaded report PDF for manifest {ManifestId}, {ManifestCode}", _userName, _manifest.Id, _manifest.Code);
            }
            else
            {
                _message = task.ErrorMessage;
                Logger.LogInformation("There was an error downloading the PDF: {ErrorMessage}", _message);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _principal = await AuthStateTask;
                _userName = _principal.User.FindFirst("name").Value;
                _repo = new ManifestRepository(ContextFactory.CreateDbContext());
                _manifest = await _repo.GetManifestById(Id);
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
            foreach (var consignor in _manifest.Consignors)
            {
                temp.Add(consignor.Name.Replace(",", ""));
            }
            return string.Join(", ", temp);
        }

        private void Edit()
        {
            Logger.LogInformation("{UserName} is editing manifest {ManifestId}, {ManifestCode}", _userName, _manifest.Id, _manifest.Code);
            Navigation.NavigateTo("/manifests/edit/" + _manifest.Id);
        }

        private async Task GeneratePDFAsync()
        {
            Logger.LogInformation("Generating report PDF for manifest {ManifestId}", _manifest.Id);
            await Generator.GenerateManifestPDFAsync(_manifest.Id);
            Logger.LogInformation("Generated report PDF for manifest {ManifestId}", _manifest.Id);
            await DownloadPDF();
        }

        public void Dispose()
        {
            Logger.LogDebug("Disposing manifest {ManifestId} details", _manifest.Id);
            _repo.Dispose();
        }
    }
}
