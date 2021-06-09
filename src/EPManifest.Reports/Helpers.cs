using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EPManifest.Core;
using EPManifest.Reports.Data;
using Esri.ArcGISRuntime;
using Esri.ArcGISRuntime.Tasks.Geocoding;
using SkiaSharp;

namespace EPManifest.Reports
{
    public static class Helpers
    {
        public static Random Random { get; } = new Random();

        public static string GetTestItem(string path) => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", path);

        public static byte[] GetImage(string name)
        {
            var photoPath = GetTestItem(name);
            return SKImage.FromEncodedData(photoPath).EncodedData.ToArray();
        }

        public static async Task<string> GetCoordinates(Address address)
        {
            ArcGISRuntimeEnvironment.ApiKey = "";

            var locatorTask = new LocatorTask(new Uri("https://geocode-api.arcgis.com/arcgis/rest/services/World/GeocodeServer"));
            // Or set an APIKey on the Locator Task:
            // locatorTask.ApiKey = "YOUR_API_KEY";

            var results = await locatorTask.GeocodeAsync($"{address.AddressLine1} {address.City} {address.Province} {address.PostalCode}");

            if (results?.FirstOrDefault() is GeocodeResult firstResult)
            {
                return $"{firstResult.DisplayLocation.X}, {firstResult.DisplayLocation.Y}";
            }
            else
            {
                return "Location not found.";
            }
        }
    }
}
