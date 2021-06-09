using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPManifest.Reports.Data;
using EPManifest.Reports.Templates;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using QuestPDF.Fluent;

namespace EPManifest.Reports
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ManifestsDataSource myData = new ManifestsDataSource();
            Console.WriteLine("Hi");

            var filePath = "invoice.pdf";

            var model = myData.GetManifestDetails(1);
            var document = new ManifestDocument(model);
            document.GeneratePdf(filePath);

            Process.Start("explorer.exe", filePath);
        }
    }
}
