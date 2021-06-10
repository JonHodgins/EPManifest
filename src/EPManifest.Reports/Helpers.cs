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
            var locatorTask = new LocatorTask(new Uri("https://geocode-api.arcgis.com/arcgis/rest/services/World/GeocodeServer"))
            {
                ApiKey = ""
            };

            var results = await locatorTask.GeocodeAsync(address.ToString());

            return results?.FirstOrDefault() is GeocodeResult firstResult
                ? $"{firstResult.DisplayLocation.X}, {firstResult.DisplayLocation.Y}"
                : "Location not found";
        }
    }
}
