using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Reports.Data;
using EPManifest.Reports.Templates;
using QuestPDF.Fluent;

namespace EPManifest.Reports
{
    public static class Generator
    {
        public static async Task GenerateManifestPDFAsync(int manifestId)
        {
            ManifestsDataSource myData = new ManifestsDataSource();
            Console.WriteLine("Generating report...");

            Directory.CreateDirectory("Reports");
            var filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"Reports/manifest{manifestId}.pdf");

            var model = await myData.GetManifestDetailsAsync(manifestId);
            var document = new ManifestDocument(model);
            document.GeneratePdf(filePath);
        }
    }
}
