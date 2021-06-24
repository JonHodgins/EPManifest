using System;
using System.IO;
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
    }
}
