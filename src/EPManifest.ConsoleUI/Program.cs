using EPManifest.Core;
using EPManifest.Data;
using System;
using System.Collections.Generic;

namespace EPManifest.ConsoleUI
{
    internal static class Program
    {
        private static readonly EPManifestDbContext s_context = new();

        private static void Main(string[] args)
        {
            //AddConsignorByName("Bob's Disposal");
        }

        //private static void AddConsignorByName(params string[] names)
        //{
        //    foreach (var name in names)
        //    {
        //        s_context.Consignors.Add(new Consignor { Name = name });
        //    }
        //    s_context.SaveChanges();
        //}
    }
}
