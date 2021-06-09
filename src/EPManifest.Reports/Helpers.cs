using System;
using System.IO;
using EPManifest.Reports.Data;
using GoogleMaps.LocationServices;
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

        public static string GetCoordinates(AddressData addressData)
        {
            var gls = new GoogleLocationService(apikey: "");

            try
            {
                var latlong = gls.GetLatLongFromAddress(addressData);
                var latitude = latlong.Latitude;
                var longitude = latlong.Longitude;
                return $"{latitude},{longitude}";
            }
            catch (System.Net.WebException ex)
            {
                return $"Google Maps API Error: {ex.Message}";
            }
        }
    }
}
