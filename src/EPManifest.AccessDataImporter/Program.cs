using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using EPManifest.Core;

namespace EPManifest.AccessDataImporter
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the path to the .csv file: ");
            var path = Console.ReadLine().Trim('"');
            using var reader = new StreamReader(path);

            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var manifestRecords = new List<Manifest>();
                csv.Read();
                csv.ReadHeader();
                var id = 1;

                while (csv.Read())
                {
                    var temp = csv.GetField<string>("Date Shipped");
                    DateTime? dateShipped = null;
                    if (!string.IsNullOrWhiteSpace(temp))
                    {
                        dateShipped = DateTime.Parse(temp);
                    }

                    var temp2 = csv.GetField<string>("Scheduled Arrival Date");
                    DateTime? dateScheduledArrival = null;
                    if (!string.IsNullOrWhiteSpace(temp2))
                    {
                        dateScheduledArrival = DateTime.Parse(temp2);
                    }

                    var record = new Manifest
                    {
                        Id = id,
                        Code = csv.GetField<string>("MANIFEST ."),
                        DateShipped = dateShipped,
                        DateScheduledArrival = dateScheduledArrival
                    };
                    id++;
                    manifestRecords.Add(record);
                };

                foreach (var record in manifestRecords)
                {
                    Console.WriteLine($"Manifest Id:{record.Id}, Code:{record.Code}, Date Shipped:{record.DateShipped}, Scheduled Arrival:{record.DateScheduledArrival}");
                }
            }
        }
    }
}
