using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class guaranteeAtLeastOneItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 8, 19 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 21 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 11, 22 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 28 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 30 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 31 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 7, 31 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 32 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 33 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 35 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 37 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 38 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 39 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 8, 40 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 41 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 42 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 43 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 44 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 45 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 14, 45 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 47 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 48 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 13, 48 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 49 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 50 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 51 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 52 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 53 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 54 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 56 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 12, 56 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 58 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 59 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 60 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 61 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 62 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 63 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 65 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 10, 65 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 66 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 68 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 69 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 70 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 11, 70 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 71 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 72 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 74 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 75 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 8, 76 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 77 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 79 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 80 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 81 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 82 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 83 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 85 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 7, 85 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 86 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 87 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 88 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 13, 88 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 90 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 14, 92 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 93 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 95 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 96 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 97 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 98 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 99 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 101 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 12, 101 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 102 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 103 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 8, 105 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 107 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 108 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 9, 108 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 109 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 111 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 112 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 113 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 7, 117 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 118 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 119 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 120 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 121 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 123 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 124 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 125 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 11, 125 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 126 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 127 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 129 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 130 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 131 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 134 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 136 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 137 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 138 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 139 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 142 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 144 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 145 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 146 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 148 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 149 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 150 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 152 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 155 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 156 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 158 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 159 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 160 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 161 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 163 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 164 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 165 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 168 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 169 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 170 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 171 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 172 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 174 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 175 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 176 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 178 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 179 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 180 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 181 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 183 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 184 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 188 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 189 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 190 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 191 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 194 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 195 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 196 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 197 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 198 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 199 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 200 });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 1,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3302 Augustus Via", "Walshton", "B9Q 1Z8", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 2,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "064 Harvey Village", "Koelpinland", "E7F 1S7", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 3,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7214 Collier Stream", "Monahanstad", "X1K 4L2", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 4,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "55097 Derek Views", "West Trenton", "T0P 2T9", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 5,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "82827 Nolan Stream", "Goyettemouth", "K5C 1P6", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 6,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "463 Gregg Cliffs", "Stiedemannmouth", "R5D 1L3", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 7,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "20069 Mellie Station", "Grantside", "R1R 3X3", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 8,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3265 Rocio Causeway", "Lake Denaton", "R4I 5X0", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 9,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "59046 Parisian Mountains", "Sawaynburgh", "V0Y 4Q4", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 10,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5227 Grace Expressway", "Lake Barryview", "Y5N 4H5", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 11,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "09086 Vern Key", "Sallyside", "A0O 4M9", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 12,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "733 Cheyenne Street", "West Juanaport", "B9U 1N0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 13,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7919 Euna Court", "Wolfshire", "Y3G 7W0", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 14,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5107 Mohr Village", "Littelberg", "A4I 3D3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 15,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4034 Lueilwitz Landing", "Raoulhaven", "X1K 3M9", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 16,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "336 Rau Field", "Port Marafurt", "C3R 5F0", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 17,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "58932 Gaylord River", "Linaton", "J8P 2S7", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 18,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "78878 West Islands", "New Cleora", "G8J 5H2", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 19,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3586 Gabriella Mews", "Lake Jacquelyn", "M9F 2X8", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 20,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "0048 Domenico Mills", "Jamelport", "X5J 7Z4" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 21,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "40876 Alessandra Divide", "North Lilyan", "P3N 2D5", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 22,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1765 Rosenbaum Ford", "North Brennon", "T4W 7Q9", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 23,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4580 Dominique Rue", "New Zander", "P4D 9D4", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 24,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "452 Hoeger Glen", "Simonistown", "M8I 3C1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 25,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "71939 Maryse Hills", "Lake Margie", "S3V 9D0" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 26,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "007 Electa Roads", "North Peggieborough", "Y8Y 1C6", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 27,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "70150 Callie Parkways", "North Graysonville", "G3A 9Z3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 28,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1476 Emmerich Extensions", "Emardmouth", "C8O 6P5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 29,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "031 Mariam Track", "Lake Howard", "E1I 3S5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 30,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "8293 Mohr Locks", "North Brentchester", "K3H 4E8" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 31,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "92806 Wolf Cove", "Schillerville", "S2Z 0K5", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 32,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "107 Grimes Cliffs", "Paulinehaven", "C8N 7O6", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 33,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "7129 Kiehn Views", "Zenaville", "E0P 3C4" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 34,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "227 Upton Mill", "New Eltonport", "P3P 9X9", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 35,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "47336 Prudence Forges", "Marksport", "H0S 5P1", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 36,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "610 Wilkinson Points", "Aminafurt", "P4D 4I0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 37,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1308 Wiza Throughway", "New Kieranfurt", "H7V 2C2", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 38,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3969 Marlon Shoal", "East Syblechester", "V0K 1V7", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 39,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9468 Bauch Junction", "Metzhaven", "B9B 2C2", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 40,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "87891 Cronin Shores", "West Madelyn", "H6P 8F3", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 41,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "435 Oran Wells", "Michealfort", "H9H 6U4", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 42,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "45594 Crooks Land", "West Eraberg", "T4Q 7A1", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 43,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3407 Coby Gateway", "New Stanleyville", "A6P 4W2", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 44,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3584 Lubowitz Ferry", "New Roderick", "G7V 4Z1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 45,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "35140 Feeney Isle", "Port Busterside", "S7N 6Z8" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 46,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8190 Fritsch Lane", "East Linaborough", "A9H 5E6", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 47,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "59959 Hermiston Park", "Port Wayne", "L6Y 9Y5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 48,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "28277 Ramona Walks", "Port Hipolito", "P5S 2R8", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 49,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "26024 Ally Trail", "Hagenesstad", "H0R 0J2", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 50,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "346 Mossie Mill", "Ryanside", "H0Q 1U4", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 51,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "371 Quitzon Wells", "Lake Adella", "X6V 4E2", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 52,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "943 Lindgren Stream", "Denatown", "Y1H 2C6", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 53,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "39660 Schmidt Viaduct", "Erdmanside", "V4E 0W3", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 54,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5188 Lexus Streets", "Gradyfurt", "C7D 5G7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 55,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4331 Enrico Light", "Kaleshire", "K7V 0U0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 56,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7726 Camille Spur", "Corkerychester", "X3Q 8R3", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 57,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "13902 Effertz Brook", "Hammeschester", "L2J 0K4", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 58,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "996 Maddison Oval", "Port Othoside", "R9X 4E1", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 59,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7443 Pagac Cliffs", "New Vivien", "K2T 1A8", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 60,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "24910 Madelynn Valleys", "New Salvador", "V4Y 7Z0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 61,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "38148 McLaughlin Gateway", "Strackehaven", "M1U 8W4", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 62,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "777 Graciela Wall", "Yoshikoborough", "C9A 5M6", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 63,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3057 Deonte Mall", "New Nils", "C8N 4A8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 64,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4459 Morar Coves", "Serenaport", "P1L 3D3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 65,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "409 Jammie Burg", "East Arianna", "N9T 3A8" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 66,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "17887 Wolff Spur", "South Miraclemouth", "A6W 8D4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 67,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "81352 Breana Isle", "East Keeley", "X5J 1F6" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 68,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4525 Rowland Valley", "Port Jana", "K7E 2W4", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 69,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7211 Hartmann Mission", "West Elda", "P4I 5Q6", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 70,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "138 Tina Spur", "East Mathias", "H5T 0B5", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 71,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "471 Lucile Gateway", "East Rodrigobury", "C5Q 6M8", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 72,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "904 Celestine Union", "Bradymouth", "P4S 3U5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 73,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1108 Daugherty Prairie", "South Damionfurt", "H1I 8D7", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 74,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "922 Wilber Causeway", "Port Friedahaven", "B0V 8O1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 75,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "84486 Bernier Via", "North Sim", "B4X 3Z1", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 76,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "764 Schumm Underpass", "Robbieview", "T7D 6H6", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 77,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "67846 Langosh Knolls", "Marianeville", "X4L 1C0", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 78,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "01131 Adrianna Unions", "West Bonitaburgh", "X5E 4H0", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 79,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "69332 Niko Tunnel", "New Dagmarview", "V5P 3K5", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 80,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "84982 Haley Oval", "Rachaelshire", "Y2G 0J2", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 81,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "988 Becker Station", "Port Khalilton", "M4Y 4L3", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 82,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3722 Jarrod Bridge", "New Emeliamouth", "E7Q 4O5", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 83,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "65947 Waters Valley", "Lake Rashadchester", "R3M 8R0", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 84,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0077 Kautzer Ports", "Legroshaven", "R8Y 4O3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 85,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "858 Lind Cliff", "South George", "M8M 9K8", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 86,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "79598 Kihn Ferry", "Lake Ofeliaside", "N8E 9B6", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 87,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "36094 Letitia Falls", "Glendaton", "H6K 6Z5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 88,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "742 Stokes Route", "Beierburgh", "J1X 1O8", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 89,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4336 Justina Wall", "Murrayside", "M9L 1T5", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 90,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "091 Shirley Keys", "Alejandrinhaven", "E0P 6O2", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 91,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "056 Kay Isle", "New Nilstown", "B1P 2Y5", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 92,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "638 Angelica Ford", "Koepphaven", "V4E 1W3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 93,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "0246 Gene Squares", "Lake Timmothystad", "P1A 3N8" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 94,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "118 Cyrus Plaza", "Moorechester", "G2P 4B1" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 95,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2098 Schulist Vista", "East Nolabury", "N0I 7L2", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 96,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0486 Jones Orchard", "East Curtis", "V2B 0E9", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 97,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "61283 Gerhold Club", "Port Pinkieshire", "K4Q 3G9", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 98,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "97565 Kim Tunnel", "East Rahulstad", "B3T 7L8" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 99,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2247 Garrett Keys", "New Stephan", "B0J 6F7", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 100,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "793 Roosevelt Drive", "Haleyton", "P8C 2S8", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 101,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8142 Kuvalis Bridge", "Lindshire", "R5B 0C2", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 102,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "31650 Jaskolski Trace", "Port Patsyborough", "L7Z 8S4", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 103,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "863 Dana Streets", "New Petra", "A0O 5C8", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 104,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "287 Kristoffer Junctions", "Charleneberg", "A1K 8X5", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 105,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "32429 Kamille Parkway", "Gislasonshire", "P1U 8G1", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 106,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "41456 Austen Fields", "Camilleville", "L9V 5G8", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 107,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "323 Torp Vista", "Port Feliciamouth", "S1W 7Y3", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 108,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "36094 Waelchi Plain", "Elvaberg", "K7L 3N1", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 109,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "30549 Gerlach Plain", "Bettyeside", "C6R 0I5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 110,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "51919 Shayna Mills", "Jerelburgh", "L9L 4I3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 111,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "64948 Anderson Streets", "West Alfredoshire", "N9X 7A1", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 112,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8172 Clemens Courts", "East Michelletown", "G6H 0X1", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 113,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4298 Shanie Groves", "Lednerchester", "C2T 2V7", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 114,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "96075 Dulce Plaza", "Nitzschehaven", "T9Q 9O8", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 115,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6448 Sidney Falls", "Kutchview", "H1X 0E7", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 116,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9368 Jerel Lake", "North Lionel", "P9B 2E2", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 117,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "804 Domingo Crossing", "South Mekhiside", "K2P 2F0", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 118,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "973 Zulauf Plains", "Otiliamouth", "X7T 1U5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 119,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "11151 Hauck Mall", "South Americafurt", "C4J 2Z8", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 120,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6271 Harber Road", "West Ivahton", "X4J 4R8", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 121,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7837 Champlin Flat", "West Stephan", "R0X 1A7", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 122,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "809 Greta Via", "Theresemouth", "X5C 3Y8", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 123,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "98846 Satterfield Underpass", "Port Alexandra", "J6D 0C9", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 124,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "40243 Neha Cove", "Florenceton", "R9U 7X3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 125,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "88462 Hiram Plaza", "North Domenic", "E1Y 2R4", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 126,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0895 Amparo Valley", "Port Gillian", "R4P 7S1", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 127,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9600 MacGyver Ford", "Marquardtshire", "B4L 9Q4", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 128,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2308 Toney Trace", "Kenstad", "G1K 8J0", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 129,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "00532 Tanya Springs", "Doyleport", "K2N 2Q7", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 130,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "532 Schuppe Mount", "Herthachester", "B8M 3H7", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 131,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "722 Prosacco View", "New Verlietown", "C2Q 7G1", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 132,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7950 Noe Square", "New Jaysonton", "T0U 8Q9", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 133,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2785 Iliana Ramp", "South Carrie", "E8I 9C0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 134,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "418 Carson Cliff", "Lake Braulioview", "B2W 7E8", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 135,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6742 Brendan Canyon", "Ankundingview", "R8S 9D4", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 136,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "94960 Howe Path", "Harberland", "C0O 8W0" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 137,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "03079 Terry Wells", "East Michale", "Y8O 1N1", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 138,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5939 Gaston Hill", "Domenicaside", "B9W 0Q3", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 139,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7667 Demarcus Spring", "West Jackiebury", "S4X 2P5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 140,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "64164 Chandler Cliffs", "Lake Taylormouth", "L2J 3Q6" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 141,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "85460 Kristoffer Falls", "Javonteton", "H5E 1C3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 142,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "563 Aglae Parkway", "East Josefinaside", "V5B 9P8", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 143,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "528 Wolff Lakes", "Raynorhaven", "E1H 1Y8", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 144,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "14465 Donnelly Glen", "South Dedricfurt", "H3M 8A9", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 145,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "30376 Stokes Passage", "Kayleighberg", "N2P 5O4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 146,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "425 Mayert Islands", "Toyfort", "X8Q 7Y3", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 147,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "858 Claudia View", "Torphyshire", "R9G 5A6", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 148,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "53883 Bernardo Crescent", "Gabriellaland", "G2W 7B7", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 149,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "358 Jayson Manors", "Port Ashleybury", "A1U 8P7", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 150,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "267 Albert Coves", "Lake Holdenton", "L2R 6C0", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 151,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "922 Lubowitz Ports", "North Marjory", "K2Z 1X8", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 152,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "407 Sabryna Path", "Lindside", "J5S 8Z9", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 153,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "01643 Annie Stream", "Lake Katrinebury", "T7D 7T2", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 154,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2871 Corkery Shores", "McDermottburgh", "C6K 7D1", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 155,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "995 Powlowski Shoals", "South Muhammad", "A2R 3S5", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 156,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "25454 Ferry Trail", "New Hardyshire", "P0G 6V1" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 157,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "425 Nienow Falls", "West Naomiside", "V0J 4C6", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 158,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "51754 Julien Harbors", "South Ottiliehaven", "S2B 6R8", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 159,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "751 Amani Mews", "Goodwinmouth", "Y6V 7G4", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 160,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "99904 O'Connell Creek", "Lake Edisonside", "T8L 9M8", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 161,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6282 Morissette Crest", "Allentown", "M5E 6T5", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 162,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "1967 Bauch Alley", "Lake Ginachester", "N2M 0A9" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 163,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "076 Rollin Via", "Lake Lessie", "R4K 2C5", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 164,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6313 Zita Mount", "North Dexter", "C6U 2J4", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 165,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "29577 Koss Isle", "West Eldora", "X4P 8H1", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 166,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5175 Roob Lights", "Silasville", "V2L 6Z7", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 167,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0981 Lysanne Locks", "New Alvinaside", "E9J 3E0", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 168,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "80349 Amani Extensions", "Lake Loren", "M5J 8H7", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 169,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "491 Julio Street", "Welchhaven", "M9X 5J0", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 170,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1694 McGlynn Junctions", "Kiehnstad", "M0M 5D1", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 171,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "44042 Terry Tunnel", "Candiceshire", "H3R 7Y3", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 172,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "723 Beahan Cliffs", "Port Amara", "S4R 8S7", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 173,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "67744 Conroy Fork", "East Gregoria", "N8J 8H6", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 174,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "42235 Benton Roads", "Ikefurt", "R8K 6P2", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 175,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1538 Reed Cliff", "Beckerhaven", "A9Y 8V4", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 176,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8844 Esmeralda Trail", "Lake Hayleyfurt", "Y3L 8L0", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 177,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "568 Kihn Lock", "Webstermouth", "N2T 8X0", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 178,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "305 Marlon Cove", "New Lamar", "M0K 7W9", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 179,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "985 Hettinger Ford", "Lake Reina", "M1L 4L5", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 180,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "910 Lubowitz Inlet", "Port Jaida", "N8J 7G9", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 181,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "60379 Fritsch Street", "South Daphneeland", "V9A 2A6", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 182,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "05100 Mekhi Turnpike", "Skyemouth", "K8O 0C5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 183,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "73078 Zita Street", "South Dakota", "E8N 5Y5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 184,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "56820 Torp Island", "Port Casimer", "P7A 1W1", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 185,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2620 Chad Ramp", "Ellsworthtown", "M0V 5I6", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 186,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "34366 Sauer Ridge", "Lake Garret", "S8X 7N2", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 187,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "748 Olga Ridge", "Jaylenfort", "R5P 1E7", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 188,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "667 Shania Way", "Harveyburgh", "C0A 1N4", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 189,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "572 Virgie Vista", "Funkville", "B6S 1B7", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 190,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "98059 Schinner Dale", "Lake Clay", "A1N 4R7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 191,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "350 Ona Square", "New Travon", "Y2E 2N8", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 192,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "78006 Sarina Views", "Trantowland", "K3Y 1C1", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 193,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "903 Morton Streets", "Watersbury", "R6W 5P9", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 194,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9235 Reynolds Grove", "Kierastad", "A1K 8U7", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 195,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "21202 Madge Oval", "West Shanel", "A3Q 2H4", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 196,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7163 Gerald Junctions", "Dorothyhaven", "V1X 7U3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 197,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "02683 Cartwright Crest", "Kearaville", "H2X 5Q2", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 198,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "95305 Swaniawski Motorway", "South Rainahaven", "H7K 3H1", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 199,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "03752 Mitchel Brook", "East Kamille", "L6W 6E5", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 200,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7379 Cydney Circles", "Julietville", "C7T 2D4", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 1,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "74233 Kuhic Island", "Sagemouth", "T2K 0B6", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 2,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "718 Satterfield Way", "Lake Mitchell", "R1I 2J1", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 3,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4377 Kris Wells", "South Trudieborough", "C4F 0Q7", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 4,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5521 Moore Trafficway", "Remingtonport", "G0P 9U7", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 5,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2449 Vincenza Club", "East Shyann", "P5R 2W0", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 6,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0200 Bernier Oval", "New Kaydenport", "H5I 2R5", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 7,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9759 Leila Way", "South Novella", "Y1I 2K7", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 8,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "377 Frank Groves", "Port Betsy", "K6J 6F3", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 9,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "18598 Gorczany Radial", "Dejashire", "X5U 6C0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 10,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "57011 Delpha Highway", "East Yoshiko", "A3D 6E1", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 11,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "299 Sheldon Dale", "Port Raquel", "N1P 9U3", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 12,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "74220 Mylene Light", "New Gerhardville", "Y4A 8K0", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 13,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "3668 Schaden Fall", "North Jess", "R1V 8I6" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 14,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "656 West Rue", "New Maciemouth", "K2V 4L9" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 15,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7016 Nader Knolls", "West Brook", "R2Y 2D6", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 16,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "01700 Prosacco Lodge", "Rolandofurt", "V0G 6G5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 17,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "859 Tobin Curve", "Sengerview", "R8H 8O6", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 18,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0067 Vida Burg", "Schillerfurt", "G9P 4M6", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 19,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8264 Kunde Ferry", "Lake Artton", "M3P 3G6", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 20,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "128 Cassandre Shoal", "North Arturobury", "C8D 7D9", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 21,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "867 Leora Mews", "South Sandrabury", "C8F 8B4", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 22,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "40429 Hirthe Lakes", "Guschester", "J2V 0F9", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 23,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "36829 Ashly Knoll", "Westton", "J9J 4A1", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 24,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0198 Reuben Loop", "Abernathyville", "B1R 5P9", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 25,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "973 Dolly Glens", "North Frederick", "K9B 5Y6", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 26,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9297 Carter Route", "North Carmel", "K7M 9J1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 27,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "78516 Roob Road", "New Jaylanville", "X9P 9B2", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 28,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "23909 Isabell Gateway", "New Ginafort", "S8R 4X4", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 29,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9658 Nolan Orchard", "Bartolettiburgh", "B8S 3L4", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 30,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9034 Marjorie Extension", "North Trentport", "V8Y 6U7", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 31,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "944 Daniella Center", "Murrayton", "G9L 8A6", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 32,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "469 Lon Drives", "Autumntown", "V0N 6F7", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 33,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "567 Dietrich Motorway", "South Mckenziestad", "B8G 3C2", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 34,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4345 Legros Crescent", "Bartolettitown", "R6P 1B1", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 35,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "129 Haskell Hill", "Port Ena", "R4K 5F2", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 36,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0805 Doyle Corners", "Port Audreyport", "E1X 4Q1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 37,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5233 Lind Wall", "Blancaland", "J8O 4Z7", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 38,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0246 Linnie Center", "South Kaia", "X1P 9P1", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 39,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8076 Marvin Roads", "Port Luellamouth", "P6O 3T8", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 40,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "701 Lesly Via", "West Nicholehaven", "G7F 0Z5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 41,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "77763 Lauriane Greens", "South Derickville", "R4K 2Q9", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 42,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "065 Haag Junctions", "West Laruestad", "A8F 1V9" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 43,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "846 Noe Vista", "South Edwinafort", "H6Y 0T2", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 44,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "969 Dolly Mount", "East Tatum", "J5I 4Z3", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 45,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4986 Sienna Inlet", "Eleanoraland", "S4W 9G1", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 46,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "053 Hamill Tunnel", "Port Dakotaport", "P5X 1U0", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 47,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9630 Marty Harbors", "North Jaycefurt", "H2L 3G6", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 48,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "324 Terrance Trail", "South Roscoe", "B8X 5L2", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 49,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1045 Lori Lodge", "South Giuseppe", "N8E 1M4", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 50,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "853 Powlowski Extension", "Harmonymouth", "T8F 8W3", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 51,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8780 Stoltenberg Lake", "East Hank", "S4A 0L5", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 52,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "30727 Waters Street", "Trentchester", "T8D 5N3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 53,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "025 Raina Crossroad", "Lake Oniemouth", "G1H 5L1", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 54,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5453 Justyn Crest", "Port Elwinport", "A5U 7Y7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 55,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "97149 Ritchie Mission", "Fritzchester", "A0Z 3E2", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 56,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4227 Kovacek Crossing", "Ethelynport", "P3L 8J0", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 57,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "556 Angelo Lodge", "South Wilfordmouth", "N6C 3E0", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 58,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "75070 Lesch Lake", "New Daphnefurt", "A5K 4L9", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 59,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "199 Maxime Springs", "Maggiotown", "S7Y 4F8" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 60,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "097 Michelle Pike", "Binsmouth", "R9S 0Z2", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 61,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "084 Maggio Prairie", "West Janiehaven", "M2N 1O4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 62,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "38378 Myrtis Brook", "New Makaylamouth", "V3G 7G4", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 63,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "06081 Lysanne Gardens", "Collierstad", "B5C 6G8", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 64,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "81769 West Rue", "West Ernie", "B0Z 0T3", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 65,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4075 Rempel Greens", "West Letha", "K6T 5C9", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 66,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "848 Hand Via", "Wilsonshire", "A8Y 6I1", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 67,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1466 Nico Isle", "Walkerbury", "M8E 2K2", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 68,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "57662 Tillman Point", "Juliamouth", "P6M 6S5" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 69,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "816 Cheyanne Mount", "Lake Ricardo", "M3H 0Z7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 70,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "39310 Macejkovic Route", "Shakirabury", "N8O 1S6", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 71,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "941 Annette Drives", "Huelton", "R6Y 4X1", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 72,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "105 Camilla Roads", "East Amelia", "T1J 3K9", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 73,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8379 Raheem Trace", "East Mathiasstad", "Y3Y 7L2", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 74,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "10358 Lincoln Orchard", "West Eldredtown", "H7J 1L7", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 75,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "69642 Hermann Ranch", "Rustyville", "M4T 2R7" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 76,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "35465 Vinnie Stravenue", "Lemueltown", "B1F 2W5" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 77,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5111 Madelyn Mount", "Baileyland", "R6T 0X5", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 78,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "60877 Zulauf Street", "West Jerald", "C6M 0K4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 79,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "54137 Effie Terrace", "North Edison", "N4N 6I9", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 80,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "557 Gavin Ridge", "North Claude", "P4G 9R2" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 81,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "94307 Shany Mission", "Prosaccoland", "S4Y 6Y0" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 82,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2663 Maud Summit", "Kutchstad", "E4B 7P1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 83,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "969 Jerrod Springs", "Port Damien", "P0Q 7U2", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 84,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "91219 Ephraim Spur", "Hermanchester", "J4M 0G8", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 85,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "713 Florida Fork", "Lueilwitzland", "R8E 5Y1", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 86,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6902 Jordon Spring", "Burdetteville", "N4Y 9U7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 87,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "36846 Reginald Trail", "Lueilwitzfort", "J9X 5T9", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 88,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1795 Jaiden Prairie", "Lake Sarinaborough", "B0C 5K1", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 89,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "936 Harris Isle", "New Jovanbury", "T2N 8P1", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 90,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9010 Grimes Highway", "West Roberto", "C6V 7U9", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 91,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "953 Beatty Square", "Kademouth", "G4J 7M5" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 92,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "32871 Garrett Shores", "New Winfield", "S8N 4X6", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 93,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6481 Nitzsche Highway", "North Herminia", "J2N 5S9", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 94,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "005 Brekke Landing", "Lake Eulashire", "T8R 1M7", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 95,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "41846 Hammes Shore", "East Felicitafort", "K7X 2J6", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 96,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "31626 Aurelie Spring", "North Phoebefurt", "P5E 6I1", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 97,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "144 Mayer Ways", "Lake Santaland", "T9N 2Z0", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 98,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "15167 Vern Crossing", "Lake Leta", "L6F 4N7", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 99,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "286 Cathrine Village", "Swaniawskiland", "E6I 9K9", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 100,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6802 Yvonne Springs", "New Brodymouth", "R2U 2B0", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 101,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "769 Shad Freeway", "Adelbertchester", "G2T 1I2", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 102,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "7070 Timmy Vista", "New Willafort", "V3Y 8C5" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 103,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "231 Reyna Manor", "Legrosburgh", "V5J 5R0" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 104,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5452 Legros Ranch", "Martinahaven", "X0U 5Y5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 105,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8580 Jacobson Union", "East Martyborough", "V8P 6F3", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 106,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4023 Bashirian Rue", "Arlenetown", "Y1Q 2C9", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 107,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "99324 Jast Loaf", "South Augustusborough", "A1N 6R4", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 108,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2235 Jerome Burgs", "New Jeffreymouth", "E8A 4C7", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 109,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "968 Greenfelder Bypass", "Bechtelarland", "K4W 7G9", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 110,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "249 Wintheiser Rapids", "Lake Halle", "B0P 9K0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 111,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "43410 Alysha Passage", "East Mackenzieview", "B0K 0D1", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 112,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "379 Lorena Street", "Port Jovanyton", "C0L 3C2", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 113,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "01960 Heloise Valleys", "Douglashaven", "V1I 4K7", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 114,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5272 Bashirian Circle", "Louiechester", "T5X 3K1", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 115,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0767 Brycen Valleys", "Andersonchester", "Y3E 9S1", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 116,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1329 Homenick Ramp", "Lake Vincentfort", "H8C 6M5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 117,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "27579 Kertzmann Station", "Kieranville", "A7S 2T0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 118,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "027 O'Reilly Camp", "Boscoburgh", "M1E 0N4", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 119,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0317 Patsy Mills", "Sofiamouth", "T8L 0D4", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 120,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8661 Blanda Wells", "North Alyciashire", "H7J 6T3", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 121,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "82946 Gibson Plains", "North Alvertastad", "A7I 3Z8", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 122,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "93815 Marcus Mountains", "Haagfort", "V5N 4C5", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 123,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "03929 Bartell Bypass", "West Pansyport", "C7P 0Z9", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 124,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "29452 Dayana Shoals", "Franeckiborough", "C6B 6O5", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 125,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "5317 Janie Mills", "Tonibury", "R6W 4U2" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 126,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1043 Napoleon Port", "South Modesto", "M4N 4D6", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 127,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "73416 Stark Ranch", "West Dayton", "J7D 9W5" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 128,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3098 Thora Stream", "Carrollberg", "T0B 8O7", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 129,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "90246 Watsica Route", "Hanemouth", "N3H 1A0", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 130,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "515 Lucile Lock", "East Efren", "N1X 2O5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 131,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "303 Casper Oval", "Marinaville", "S9V 5L1", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 132,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "47237 Clinton Shores", "Germainefurt", "T7T 0F2", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 133,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "539 Bradtke Via", "West Camila", "S7H 4A1", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 134,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "26208 Emely Canyon", "Adalbertoville", "H1Z 9N3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 135,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "96669 Paolo Square", "West Muhammadstad", "X8X 9G4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 136,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2375 Hansen Lights", "Erynshire", "X9G 5N0", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 137,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "325 Christiansen Squares", "Jacobiborough", "A2X 5T5", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 138,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0173 Gibson Track", "New Rubenfurt", "J8P 5D3", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 139,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "326 Louvenia Light", "New Natasha", "E7C 1J3", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 140,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1807 Botsford Village", "New Chancefurt", "K4U 4E1", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 141,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6336 Ledner Key", "Dickinsonberg", "E4Q 3R0", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 142,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "910 Lonie Fall", "Port Orlo", "P9G 5P6" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 143,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "488 Roderick Mountain", "New Iva", "T0D 4F3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 144,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "694 Marvin Fork", "Yostmouth", "G6V 9Y9" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 145,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "34454 Stacy Squares", "Lake Reneeberg", "X0T 9W4", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 146,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "224 King Streets", "Boscofort", "C6B 1P0", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 147,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "31134 Breitenberg Mountain", "South Arvilla", "B5G 2D3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 148,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "33666 Adella Spring", "Olgaport", "R7Q 4I7", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 149,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "207 Rowe Corners", "O'Connellbury", "Y2C 1X7", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 150,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "67503 Jared Mill", "West Santa", "X3W 2C4", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 151,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0297 Judge Ranch", "New Joliehaven", "C1T 9E3", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 152,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6768 Lincoln Loop", "Ginafort", "K8V 8M7", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 153,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7850 Schinner Throughway", "Orrinstad", "B8M 3J7", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 154,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "18844 Maiya Circle", "Hahnborough", "E6X 0T2", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 155,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "0947 Norberto Vista", "Port Jessika", "B4T 2T8" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 156,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "03437 Hickle Corner", "Port Gladys", "B8K 9M6", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 157,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "44827 Aurelie Drives", "South Carlo", "B2W 3A7", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 158,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3583 Romaguera Grove", "North Patriciamouth", "T5R 8E6", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 159,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9715 Lacey Green", "Yostton", "S0K 5P7", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 160,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "766 Kutch Way", "South Kyleestad", "C3D 1K0", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 161,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5298 King Glens", "Port Hayleeshire", "B3S 9Z2", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 162,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9299 Luciano Plaza", "Leifside", "M1L 2M3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 163,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "106 Schiller Port", "Port Nathan", "E2D 1V0", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 164,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "934 Ezequiel Gateway", "West Jacintheshire", "C2Q 0N0", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 165,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7028 Macejkovic Inlet", "New Rory", "H3G 6A5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 166,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "615 Cynthia Centers", "New Hudson", "E6D 9K4", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 167,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "403 Feest Spring", "Braedenfurt", "V5P 4B2", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 168,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1764 Terrence Expressway", "Langoshville", "J9U 3B9", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 169,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "00807 Coby Rapid", "Wizamouth", "V5Z 0I7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 170,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "8392 Adelia Extension", "North Courtney", "L8G 3G7" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 171,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "58763 Neoma Valleys", "Ziememouth", "G5T 8A0", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 172,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "664 Leonie Route", "Lake Kristy", "S2M 6E7", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 173,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5523 Bertram Shore", "East Vadaton", "H2Y 1A6", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 174,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "87525 Kertzmann Manor", "Lucyborough", "R6R 6Y5", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 175,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "3629 Jacklyn Crescent", "Emilborough", "L6X 4X6" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 176,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "665 Allison Square", "New Marlonmouth", "G4P 5Z5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 177,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "71208 Kian Orchard", "Lake Candido", "B0V 0K5", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 178,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2900 Marvin Motorway", "Port Audreyside", "N4P 1M3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 179,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9571 Rice Road", "New Jessycaberg", "R8K 6B2", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 180,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "28215 Ryann Village", "New Liam", "X4W 0W5", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 181,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "48527 Volkman Oval", "Port Bridgetville", "L2T 7L1" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 182,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8152 Pfannerstill Ways", "Jaskolskifort", "M6G 2H5", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 183,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "54454 Hoppe Meadows", "North Curtisbury", "K5G 2O5", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 184,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "06691 Rowan Ramp", "Kilbackberg", "T4G 1D4" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 185,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1401 Alejandrin Squares", "North Adelemouth", "P3W 5V4", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 186,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "693 Graham Falls", "Aaronburgh", "B0C 1Z0", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 187,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8197 Nienow Mountains", "South Judymouth", "H6R 6Y7", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 188,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "17896 Boyd Knoll", "Kingborough", "L3V 1G8", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 189,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "04584 Reinger Street", "West Darren", "E9G 5G4", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 190,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "02629 Alessandro Harbor", "Kohlerview", "P6D 4H3", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 191,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "52065 Ian Fort", "West Vincenzofort", "T1Y 4V8", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 192,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9065 O'Conner Village", "Runteberg", "S8G 6T7", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 193,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "55638 Manley Underpass", "East Art", "K8V 2U3", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 194,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "30008 Angelo Springs", "Javonteville", "A7T 6Y1", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 195,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "66758 Romaguera Court", "North Sabrinaview", "R6Z 8P4", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 196,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9446 Emmanuelle Alley", "East Dominicfurt", "G4S 9E6", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 197,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "6743 Shyann Mews", "Lake Percivalborough", "Y7F 4C6" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 198,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "72592 Roberts Terrace", "Auerchester", "E9J 6V3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 199,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "39984 Kiarra Island", "East Romainemouth", "Y6L 0S4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 200,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "0340 Brayan Shores", "New Leo", "J1E 2J5" });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 10 },
                    { 4, 125 },
                    { 2, 126 },
                    { 3, 127 },
                    { 3, 129 },
                    { 4, 130 },
                    { 2, 131 },
                    { 4, 124 },
                    { 1, 134 },
                    { 3, 137 },
                    { 2, 138 },
                    { 4, 139 },
                    { 2, 142 },
                    { 4, 144 },
                    { 2, 145 },
                    { 1, 136 },
                    { 2, 146 },
                    { 3, 123 },
                    { 4, 120 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 3, 97 },
                    { 1, 98 },
                    { 3, 99 },
                    { 1, 101 },
                    { 1, 102 },
                    { 1, 103 },
                    { 3, 121 },
                    { 4, 107 },
                    { 1, 109 },
                    { 3, 111 },
                    { 1, 112 },
                    { 1, 113 },
                    { 4, 118 },
                    { 1, 119 },
                    { 4, 108 },
                    { 2, 96 },
                    { 1, 148 },
                    { 1, 150 },
                    { 4, 178 },
                    { 2, 179 },
                    { 3, 180 },
                    { 4, 181 },
                    { 4, 183 },
                    { 3, 184 },
                    { 1, 176 },
                    { 4, 188 },
                    { 2, 190 },
                    { 4, 191 },
                    { 4, 194 },
                    { 2, 195 },
                    { 2, 196 },
                    { 1, 197 },
                    { 4, 189 },
                    { 3, 149 },
                    { 1, 175 },
                    { 4, 172 },
                    { 4, 152 },
                    { 1, 155 },
                    { 2, 156 },
                    { 1, 158 },
                    { 4, 159 },
                    { 1, 160 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 4, 174 },
                    { 3, 161 },
                    { 2, 164 },
                    { 2, 165 },
                    { 4, 168 },
                    { 4, 169 },
                    { 2, 170 },
                    { 1, 171 },
                    { 1, 163 },
                    { 3, 198 },
                    { 4, 95 },
                    { 1, 90 },
                    { 4, 29 },
                    { 1, 30 },
                    { 2, 31 },
                    { 4, 32 },
                    { 1, 33 },
                    { 3, 34 },
                    { 1, 28 },
                    { 4, 35 },
                    { 2, 38 },
                    { 2, 39 },
                    { 2, 41 },
                    { 1, 42 },
                    { 3, 43 },
                    { 1, 44 },
                    { 2, 37 },
                    { 3, 45 },
                    { 3, 27 },
                    { 2, 25 },
                    { 1, 6 },
                    { 1, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 4, 13 },
                    { 4, 14 },
                    { 3, 26 },
                    { 4, 15 },
                    { 3, 17 },
                    { 1, 18 },
                    { 4, 19 },
                    { 1, 21 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 3, 22 },
                    { 2, 24 },
                    { 2, 16 },
                    { 4, 93 },
                    { 2, 47 },
                    { 1, 49 },
                    { 4, 71 },
                    { 2, 72 },
                    { 3, 74 },
                    { 1, 75 },
                    { 1, 77 },
                    { 4, 79 },
                    { 3, 70 },
                    { 4, 80 },
                    { 3, 82 },
                    { 4, 83 },
                    { 2, 85 },
                    { 3, 86 },
                    { 2, 87 },
                    { 1, 88 },
                    { 2, 81 },
                    { 1, 48 },
                    { 1, 69 },
                    { 3, 67 },
                    { 3, 50 },
                    { 3, 51 },
                    { 3, 52 },
                    { 3, 53 },
                    { 1, 54 },
                    { 3, 56 },
                    { 2, 68 },
                    { 4, 58 },
                    { 4, 60 },
                    { 2, 61 },
                    { 1, 62 },
                    { 2, 63 },
                    { 3, 65 },
                    { 4, 66 },
                    { 2, 59 },
                    { 4, 4 },
                    { 2, 199 },
                    { 14, 8 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 4, 200 },
                    { 9, 114 },
                    { 8, 110 },
                    { 11, 103 },
                    { 12, 98 },
                    { 7, 91 },
                    { 10, 88 },
                    { 9, 80 },
                    { 11, 77 },
                    { 6, 71 },
                    { 2, 3 },
                    { 13, 58 },
                    { 7, 12 },
                    { 7, 17 },
                    { 14, 26 },
                    { 12, 29 },
                    { 12, 64 },
                    { 13, 38 },
                    { 11, 49 },
                    { 13, 34 },
                    { 8, 42 }
                });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "Name" },
                values: new object[] { "NJ-KAV", "Stark Inc" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "Name" },
                values: new object[] { "57-M1S", "Jacobson LLC" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "Name" },
                values: new object[] { "BS-29O", "Beer, Waters and Thiel" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "Name" },
                values: new object[] { "13-I8C", "Gaylord, Altenwerth and Effertz" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CU-LW0", "Wunsch - Satterfield" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "Name" },
                values: new object[] { "82-XAV", "Connelly - Beer" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "Name" },
                values: new object[] { "U5-G84", "Armstrong, Braun and Kunde" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Name" },
                values: new object[] { "4A-8U7", "Frami, Hayes and Johns" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "Name" },
                values: new object[] { "54-XXV", "Bruen LLC" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "Name" },
                values: new object[] { "U3-54F", "Hilll, Frami and Kulas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Libero qui dicta soluta.", 1, 3562m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quaerat rerum sunt aut.", 2, 19384m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dignissimos id nostrum.", 3, 11596m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui libero aut.", 4, 4041m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Illo non rerum adipisci excepturi voluptatem.", 5, 18904m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Placeat modi repellendus molestiae eaque molestias omnis quis et et.", 6, 16665m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Optio illum voluptas quas aut.", 7, 1320m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Vero necessitatibus ipsa eius est iste.", 8, 10805m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ea eum exercitationem.", 9, 1338m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aliquid repudiandae error impedit.", 10, 11344m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolores optio optio dignissimos odio excepturi et.", 11, 6895m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Asperiores nostrum maiores minus sunt eveniet quo.", 12, 15059m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Placeat et tenetur pariatur quo illo.", 13, 16797m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quisquam deserunt minima eos nulla est iste.", 14, 10289m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eos nesciunt iste officiis consequatur sit voluptatum.", 15, 16215m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Adipisci sunt rerum et corrupti officia quibusdam.", 16, 17289m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestiae enim optio impedit officiis dolore quia veniam.", 17, 4770m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Est rem in reiciendis ut officiis commodi hic error.", 18, 1817m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Repudiandae omnis ut delectus.", 19, 14320m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quas ut veniam quia distinctio enim incidunt.", 20, 12698m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolore tempora laboriosam mollitia.", 21, 1773m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Qui quae quasi fugiat et ullam occaecati a rem earum.", 22, 6349m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem odit ut fugit et nobis natus dolores ipsam sed.", 23, 16123m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "In dolor ratione aliquid voluptatem fuga quo et et in.", 24, 4311m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Omnis eligendi consequuntur omnis atque.", 25, 5673m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut vel voluptas molestiae aut.", 26, 14605m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ratione natus eum.", 27, 5853m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Vitae consequuntur illum tempore fugiat.", 28, 18019m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quis dolorum doloribus ipsa.", 29, 10534m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Illum quia ut dolores adipisci.", 30, 16611m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nesciunt qui culpa ut totam.", 31, 18011m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nesciunt dicta natus non quasi saepe.", 32, 4399m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sapiente voluptatibus non.", 33, 5646m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolorum molestiae omnis rerum exercitationem ab.", 34, 3886m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Delectus et et quisquam.", 35, 16593m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Delectus dolor quis aut facilis minima reiciendis adipisci.", 36, 13204m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ducimus architecto molestiae doloribus veniam id quod occaecati.", 37, 17219m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sit cumque aliquam.", 38, 19578m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dignissimos voluptate sunt ut.", 39, 5206m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Atque voluptates aspernatur iure cum quasi aut maxime saepe.", 40, 6299m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quibusdam id pariatur.", 41, 18540m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum accusantium repellat totam enim eum hic tempora officiis.", 42, 10625m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Tenetur quaerat laborum omnis est est repellat modi a.", 43, 7179m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eaque facilis aut est laborum nulla delectus maxime quo praesentium.", 44, 18206m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quia rerum accusamus commodi est.", 45, 2267m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Doloribus dicta minima qui modi omnis maiores.", 46, 13310m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut corporis quam voluptatem sint.", 47, 16435m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quibusdam cumque consequuntur.", 48, 10618m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sunt asperiores perferendis cumque minima.", 49, 17950m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Suscipit fugit maxime consectetur at autem in reiciendis.", 50, 16017m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quisquam ducimus dolorem minima et voluptatem.", 51, 14835m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit ut numquam eveniet libero voluptatem tenetur eaque.", 52, 8985m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Culpa nihil sunt eum voluptatem consequatur consequuntur.", 53, 2956m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Officiis quis unde.", 54, 3753m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi cupiditate cum deserunt repellendus in reiciendis tenetur quia.", 55, 5154m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et at quia et quia amet.", 56, 16415m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Vel sit rerum veniam.", 57, 6813m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Provident velit in quo.", 58, 1745m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eligendi at enim aut et quia ut hic ducimus voluptatem.", 59, 3238m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut fugit fuga ex.", 60, 17291m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quidem molestiae consequatur.", 61, 2530m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Omnis voluptas quis debitis velit dolores delectus ducimus vero ullam.", 62, 13804m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem commodi iusto et ullam id praesentium numquam qui.", 63, 19400m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eius aut debitis quod et dolorum doloremque.", 64, 13405m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et quod voluptas nam assumenda inventore quia non delectus.", 65, 5494m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Veritatis adipisci maxime praesentium natus aperiam ea.", 66, 9274m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Similique voluptatibus iste veritatis molestiae ut dolorem veritatis.", 67, 11528m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptas autem ducimus tempore quibusdam rerum illo.", 68, 6098m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Soluta iusto debitis similique aut.", 69, 4391m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolorem sunt aspernatur temporibus et fugit aspernatur et.", 70, 2123m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eos quidem reiciendis libero fugit commodi est in quia est.", 71, 16951m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Fuga omnis sit inventore nulla consectetur quis excepturi minus cum.", 72, 13905m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Temporibus doloribus velit est sit consequatur illum quibusdam.", 73, 17979m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Omnis voluptas error numquam et aliquid fugit fuga corrupti.", 74, 10957m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Exercitationem est aliquid et corporis ut.", 75, 9120m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolores velit velit quam corporis inventore eum et et.", 76, 1309m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum sint et nisi perspiciatis perspiciatis adipisci.", 77, 4796m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aperiam quisquam totam saepe.", 78, 11933m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "At reiciendis et aut quae recusandae consequatur error.", 79, 13207m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quam aut consequuntur ea reprehenderit accusamus fuga voluptates est minus.", 80, 10988m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eum qui deserunt itaque illo et non sit natus unde.", 81, 10293m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Id voluptatibus provident nisi tenetur ipsum.", 82, 16471m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et est corporis.", 83, 12556m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Omnis perspiciatis dicta unde modi aut.", 84, 14481m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dicta voluptatem in necessitatibus soluta atque.", 85, 4276m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sed et dicta dolores.", 86, 4589m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sit adipisci eveniet quia dignissimos quia.", 87, 19223m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Excepturi aut consequatur quas sequi porro id fugiat sit.", 88, 3449m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Blanditiis laboriosam sint.", 89, 4440m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem ut dignissimos quis molestias id iste voluptas debitis blanditiis.", 90, 18580m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Distinctio distinctio reprehenderit cumque assumenda.", 91, 7425m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ex laborum dicta odit dignissimos voluptatibus cupiditate eveniet sit nihil.", 92, 6908m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Occaecati asperiores unde neque ut tenetur natus.", 93, 4869m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Autem soluta non cupiditate eos dicta iste molestiae.", 94, 5261m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et aut repellendus aliquid natus animi.", 95, 16197m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Explicabo accusamus nihil eius quia molestiae.", 96, 8828m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Accusantium consequatur et corporis asperiores.", 97, 7526m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et perferendis deleniti nulla sunt ab illo amet animi.", 98, 21m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Non voluptate qui expedita.", 99, 16378m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Atque pariatur ut consequatur.", 100, 7890m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ex sit magni consectetur ab consectetur.", 101, 7427m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolorem sequi et quo.", 102, 8238m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iusto et porro laboriosam iste dolorem quod distinctio dolores.", 103, 3270m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et mollitia nihil dolore.", 104, 16376m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quod eaque aut harum.", 105, 13770m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Facilis odio et iste officia eligendi non omnis sit fuga.", 106, 6081m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quia aut unde.", 107, 19034m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Deserunt deserunt tenetur molestias quidem optio quia.", 108, 14922m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sit est quos est aut.", 109, 18462m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Earum tempora adipisci non vero dolor.", 110, 13695m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Id tempora dolorem.", 111, 6990m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quae hic repellat alias sit enim possimus.", 112, 19047m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Atque sunt fuga ea voluptatem ipsum mollitia.", 113, 7354m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Vero perferendis vel officiis fuga magni consequuntur at.", 114, 8469m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Debitis facilis incidunt eum molestiae repudiandae.", 115, 8758m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia ut dolor blanditiis.", 116, 7545m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Soluta ducimus aut qui explicabo maiores fuga qui nobis.", 117, 12479m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sed id et placeat.", 118, 14334m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui sapiente atque tempora eligendi necessitatibus aperiam explicabo.", 119, 3387m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Libero omnis iusto expedita atque omnis dolore omnis dolor.", 120, 4583m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut alias maxime voluptatem nihil distinctio velit sed vitae.", 121, 4581m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "In explicabo officia quae.", 122, 10331m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cupiditate ea dolorem ut ut dolorem unde doloremque.", 123, 17773m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vel est necessitatibus.", 124, 5814m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Molestias expedita officia.", 125, 10644m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem voluptatem ipsum id quo.", 126, 18898m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Facilis in dolor odio dolores et.", 127, 3474m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem repellendus cum quia ullam.", 128, 2011m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Veritatis recusandae dolorem eius harum tenetur.", 129, 300m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Excepturi sed provident magnam.", 130, 5526m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem animi rerum atque qui non laborum architecto non.", 131, 9499m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Distinctio ipsum quia et excepturi illum ex unde.", 132, 9747m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ipsa dolores dolores minus provident.", 133, 8001m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Doloremque quia omnis in ut.", 134, 5990m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut ducimus maiores sint at aperiam.", 135, 8134m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ea eius sed quia dolorem dolorem.", 136, 7077m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Repellat architecto voluptatibus nostrum corporis.", 137, 12561m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ut occaecati placeat asperiores et itaque.", 138, 477m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut voluptas ut quidem ut modi fugit dolores.", 139, 1086m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ut magni non nihil.", 140, 9303m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Modi eaque ipsa optio.", 141, 15873m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rem sit qui voluptas.", 142, 16578m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Est odio dignissimos.", 143, 1345m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Assumenda vitae repellendus magnam dolorum dolor rerum voluptatum iste harum.", 144, 6224m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et voluptas harum laborum necessitatibus.", 145, 478m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ea debitis facere velit omnis accusantium voluptatem.", 146, 12590m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ad et aut.", 147, 13087m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Impedit qui non sint ut enim minus repellat mollitia.", 148, 16243m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et voluptatem excepturi.", 149, 8542m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eos ducimus sed alias veniam voluptas ut.", 150, 171m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolorum dignissimos consectetur dolorem et ea voluptas et dignissimos totam.", 151, 15603m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui voluptatibus doloremque a.", 152, 2054m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eos ut quaerat ab.", 153, 4141m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Est a voluptas fugiat quo.", 154, 17063m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem officia totam quam sed vitae.", 155, 424m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nisi earum illo recusandae magnam optio quos.", 156, 11686m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sequi est voluptatem aut maxime qui distinctio autem laboriosam.", 157, 17496m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Hic asperiores vel impedit maxime rerum labore.", 158, 14448m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "In libero voluptatem sint dolores.", 159, 6857m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quidem repellat reiciendis quia ipsam autem quaerat ea hic corrupti.", 160, 13647m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Maiores aliquam rerum repellendus voluptas suscipit libero.", 161, 1866m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nihil architecto quibusdam ratione labore asperiores id quis dolores et.", 162, 19031m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quis fuga debitis assumenda necessitatibus asperiores.", 163, 375m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quaerat magnam iste.", 164, 8565m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempora quae dolore laborum ullam laudantium non.", 165, 14255m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Soluta nobis aperiam et minima reprehenderit rem quo autem quia.", 166, 17691m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tenetur omnis necessitatibus.", 167, 19762m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur voluptatem est.", 168, 19334m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Neque libero inventore.", 169, 7903m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iusto consequatur sit ut dolorem a facilis provident modi laboriosam.", 170, 2195m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cumque voluptatem est inventore eveniet.", 171, 17919m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ad et laborum ea unde.", 172, 2497m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Fugiat non sint.", 173, 15094m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eius consequatur minima aspernatur eum.", 174, 17139m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Praesentium ut suscipit laboriosam sit numquam aperiam et.", 175, 13969m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iste aspernatur voluptate a at dicta totam.", 176, 5667m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nihil repellendus cum non deserunt enim.", 177, 18433m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Soluta dicta omnis non voluptatem.", 178, 67m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Inventore magni ut porro nam enim.", 179, 17434m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Officia alias necessitatibus excepturi eveniet et omnis laboriosam nobis.", 180, 8804m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Amet incidunt officiis aut et.", 181, 545m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Odit vel necessitatibus ipsam id et perferendis quaerat quisquam.", 182, 2629m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem autem sunt aut corporis.", 183, 11944m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et minima aut repellendus corrupti autem quaerat et.", 184, 2228m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eveniet molestias dolorum culpa necessitatibus atque voluptas molestiae.", 185, 14361m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Repudiandae voluptates beatae iusto placeat est aut quam.", 186, 18212m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Molestias tenetur culpa eius repellat deleniti sit.", 187, 11088m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quis tenetur ullam esse aut suscipit.", 188, 10168m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Magni accusamus in quo dolorem dolores iure qui voluptatem fugiat.", 189, 10565m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Itaque et odit.", 190, 8603m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Impedit eum corrupti autem atque qui nemo asperiores dicta.", 191, 8044m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Autem vitae consequatur molestias quia voluptatibus harum dolorem.", 192, 14056m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Earum modi deleniti quia incidunt beatae dolor.", 193, 6792m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dicta et laboriosam ipsa beatae id.", 194, 3547m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quis optio at.", 195, 17950m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Perferendis aut consequatur est deserunt.", 196, 5700m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Repellendus at quia sunt ea nam tenetur mollitia sint.", 197, 11690m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dicta cupiditate voluptatem porro rem expedita non.", 198, 12528m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Cupiditate quia quae esse quibusdam dolores quidem et illum.", 199, 4968m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Est harum dolorum.", 200, 14829m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nihil ipsam praesentium.", 85, 18478m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Rerum cumque sed voluptatum tempora quas quae beatae dolorum.", 85, 10788m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quia corporis dolores.", 22, 4071m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Description", "Quantity", "State" },
                values: new object[] { "Repellendus quis sit.", 12259m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Recusandae autem dolorum.", 24, 16467m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Explicabo id natus iste alias sed.", 14, 9114m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nesciunt temporibus minima ut.", 171, 15329m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Qui laborum odit voluptas numquam et id nihil aut.", 1, 2491m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odit omnis unde veniam doloremque qui sint est.", 3, 10894m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Expedita aut at pariatur veritatis.", 67, 4117m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quisquam laboriosam et mollitia doloremque facere earum.", 180, 5480m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quo eius est qui.", 74, 6552m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum molestias dolorem.", 191, 19002m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quibusdam ab voluptatem.", 167, 12515m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Doloribus rerum voluptatem animi minus qui consequatur.", 80, 3895m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et debitis exercitationem delectus.", 178, 8269m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Facilis porro et libero eius.", 164, 7837m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Iure maxime nostrum laboriosam aperiam ut totam consequatur.", 195, 149m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ipsam fugit vel et facere ex non et earum aut.", 34, 3942m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Excepturi et delectus vel earum quod magnam esse tenetur ut.", 190, 5248m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eos ea sit et corrupti omnis voluptate rem explicabo laudantium.", 90, 6643m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Repellat et consequuntur.", 116, 10709m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Cupiditate quia et cumque eos vel quos.", 124, 14691m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quo nesciunt commodi minus vel odit a accusamus sint est.", 157, 14653m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Qui dolores velit sit corporis voluptate voluptas.", 85, 13161m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sunt animi qui et reprehenderit iure distinctio.", 101, 5101m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Placeat dolorum eos cum.", 53, 18296m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptas explicabo labore vero iusto facere similique architecto quas id.", 112, 6213m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Consectetur perspiciatis nisi esse quia.", 179, 12099m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iusto nobis perspiciatis dicta maxime.", 188, 3682m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quas corrupti non tenetur harum.", 67, 1837m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Harum amet facere.", 75, 11836m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Autem qui dolores quia eos id alias et voluptatem.", 111, 19759m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut et voluptas cumque suscipit iure dolor.", 74, 620m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolorum dolore recusandae.", 75, 19061m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui sequi fugit ullam ut.", 114, 12125m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "In eius recusandae ipsa.", 166, 3541m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quo veritatis voluptas.", 17, 19426m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Facere dolores quasi reprehenderit iure totam eum dignissimos vero et.", 146, 9273m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sapiente incidunt autem et.", 14, 1763m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Consequatur suscipit quis quaerat.", 71, 7594m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Fuga velit et repellat.", 150, 16041m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem harum commodi iusto nemo minima nulla.", 195, 16022m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "In nobis suscipit.", 11, 18895m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et cum voluptatem dolore sed aut ut.", 86, 15696m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Maiores voluptatibus placeat dolorem.", 6, 15220m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Culpa odio vel eaque sed modi.", 11, 10258m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et provident provident rerum.", 63, 9638m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Inventore quo ipsam.", 9, 7302m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolorem sit quia accusantium consequatur nesciunt corrupti ut est quia.", 145, 18321m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quia totam quas qui ducimus odit nobis facilis veritatis qui.", 149, 976m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sit nesciunt aut.", 175, 11546m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Est quis quae.", 183, 8115m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem quis non odit eveniet.", 195, 10404m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut ratione quia a aut maxime.", 38, 2194m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ratione possimus eaque.", 171, 3905m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cumque aut qui nam quos qui.", 5, 19618m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Similique fugiat placeat dignissimos sit et.", 114, 18093m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Tenetur est rerum aliquam quia.", 183, 12267m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Molestias similique consequuntur molestias consequatur atque porro tempora.", 18, 16508m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Amet labore qui ipsam impedit voluptas blanditiis neque.", 82, 10303m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem ut omnis.", 23, 7352m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Inventore ut fuga itaque occaecati eum consectetur laudantium quod.", 64, 7283m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit dolor ullam sit culpa vitae.", 93, 10045m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut laudantium deleniti cum blanditiis perferendis.", 172, 19560m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Assumenda autem consectetur rerum voluptatem cumque est quod velit nihil.", 44, 19481m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Id non et.", 161, 6591m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quo et impedit repellendus veniam aliquid.", 35, 4590m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut et doloribus.", 161, 12728m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Occaecati repellendus eum eveniet voluptatem et reprehenderit ad.", 107, 8981m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et non voluptatum accusantium.", 99, 11115m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dignissimos et ut ipsum omnis ratione placeat saepe soluta non.", 78, 16896m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptatem dignissimos aut saepe architecto dolor nihil rerum ut officiis.", 104, 2939m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Necessitatibus qui suscipit unde nisi.", 19, 582m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Non iste debitis alias.", 96, 4351m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Alias aut doloremque animi ipsam consectetur id.", 60, 3178m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Incidunt minima quam quidem.", 168, 2336m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Commodi aliquid id est perspiciatis modi eum rerum ab.", 145, 15578m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptatem vero consequuntur sit ea id accusamus.", 106, 13802m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ad blanditiis commodi aut aliquid.", 148, 12784m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nostrum tenetur assumenda delectus voluptates occaecati et occaecati earum.", 134, 8592m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Doloribus est voluptatum impedit maiores tempore natus non omnis.", 75, 4969m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Molestiae doloremque assumenda sit aut reprehenderit similique quia dolore qui.", 154, 13939m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nam maiores id consectetur qui aut fuga.", 151, 3258m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vitae in cupiditate sit.", 195, 10764m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Distinctio consequuntur optio officiis non vel deleniti vitae perferendis harum.", 125, 18092m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nisi dolor est quo aut.", 87, 17372m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Atque omnis est vel.", 159, 3175m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Alias eos voluptates voluptatem autem ullam qui vitae.", 13, 4590m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Excepturi voluptatem tempore ea iste eos.", 27, 5707m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cum qui eaque possimus cumque at non aut.", 178, 2174m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eos ipsam sed nam repellendus exercitationem.", 58, 6207m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Laudantium nihil et unde expedita.", 174, 17897m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Rerum facilis voluptatem iure.", 119, 7623m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Excepturi fuga et labore dolores et id dolorum quaerat.", 149, 16749m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Assumenda exercitationem repellat illo reiciendis blanditiis numquam voluptatem.", 44, 330m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Enim ad ea et porro asperiores corrupti excepturi.", 93, 12834m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Illo enim quis doloremque repellendus.", 189, 9490m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eum voluptatem et.", 39, 9920m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Accusantium ad sunt sit nisi at repudiandae nam.", 39, 14958m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Provident placeat libero in earum rerum maiores dignissimos.", 146, 14829m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem animi aut et.", 7, 18012m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Doloremque id est molestiae occaecati sed.", 70, 2367m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Qui at sunt rerum explicabo.", 125, 12908m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ullam nulla unde neque fugiat.", 50, 6274m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Explicabo minus sunt porro recusandae cum perferendis nihil accusamus.", 126, 6522m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Repellendus dolorem doloremque nesciunt ea aliquam.", 155, 1481m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Necessitatibus quia voluptas est et omnis deleniti nisi.", 134, 17558m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut esse harum qui possimus et ut cum et.", 133, 2639m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptas placeat quibusdam nobis a recusandae.", 101, 19765m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et est sed veniam aut voluptatem quia voluptate.", 198, 3560m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Expedita voluptates necessitatibus illo accusantium.", 5, 841m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quidem mollitia vitae qui.", 173, 14153m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum dicta est sunt minus reprehenderit omnis voluptatibus aliquam quaerat.", 171, 2101m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Doloremque ab ipsa recusandae sit laudantium at.", 126, 14268m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem error velit in ipsam dolor beatae labore.", 164, 3367m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem inventore eos voluptas esse rerum dolor rem.", 132, 10730m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Hic ducimus non quis ratione totam fugiat nihil quod esse.", 159, 16814m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum autem et incidunt rerum ut facere ea porro.", 149, 18976m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Atque perferendis facere autem.", 126, 7641m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Qui aliquid voluptas sapiente occaecati facilis exercitationem vitae fuga.", 117, 16056m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Molestiae eveniet distinctio adipisci quae vel.", 146, 8445m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quaerat ea dicta necessitatibus voluptate at.", 116, 2987m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Natus nemo incidunt omnis quam et molestias itaque aut harum.", 66, 6479m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aperiam culpa eveniet autem aut fuga laborum voluptatum.", 43, 5272m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Hic vero ea culpa.", 68, 4875m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quis reprehenderit iste molestias repellendus id pariatur recusandae aut possimus.", 164, 19851m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sed odio aliquam hic fugiat.", 42, 19373m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Doloribus aliquam tempora quod minima.", 74, 15613m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quas illum exercitationem quo aut.", 72, 12482m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Cupiditate magni quis quia.", 59, 7563m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Asperiores voluptas sit rerum numquam quibusdam ut.", 121, 12451m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia placeat ad dolor eum ratione.", 42, 8314m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Possimus totam assumenda vero.", 73, 19345m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolorem nulla architecto non voluptatem non.", 133, 1597m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Possimus rem assumenda velit.", 69, 7607m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Debitis qui enim ex id nihil quam ducimus.", 104, 18825m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Corrupti ut deleniti.", 92, 13530m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Autem minima quia.", 57, 10024m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatum tenetur voluptas quis qui laborum porro.", 185, 10630m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Harum aspernatur minima atque enim harum maiores.", 141, 9975m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut deserunt et ipsum odit at adipisci qui quisquam debitis.", 151, 9279m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Debitis omnis hic a dolorem.", 87, 11287m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quisquam consectetur omnis ullam velit pariatur est eligendi aut fugiat.", 109, 4591m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Qui facere temporibus possimus quidem at minus at voluptas.", 154, 2132m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem mollitia nesciunt modi quia eum.", 169, 13284m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est minus accusamus.", 154, 12468m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aspernatur explicabo vel sequi cum rerum qui.", 91, 19757m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Vitae doloremque aliquam natus labore.", 74, 1436m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Enim voluptates ut qui.", 173, 18890m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Laboriosam itaque dolore est nisi.", 97, 10150m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui voluptas delectus.", 190, 13001m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Enim eum alias debitis rerum deleniti.", 181, 17972m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Optio voluptatem consequuntur odit velit at voluptatem fugiat vel repudiandae.", 119, 1079m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Facilis accusamus nisi quaerat alias.", 130, 15686m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolore praesentium exercitationem voluptas placeat natus id omnis provident.", 55, 17714m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quibusdam hic aut veniam error aliquam qui velit in.", 6, 6027m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Rerum neque esse quis sunt voluptatem tenetur reprehenderit.", 127, 436m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolore inventore quam voluptas autem et.", 11, 11548m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dicta exercitationem quaerat.", 200, 16706m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sed sapiente libero quis rem quidem optio a.", 186, 16296m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia consequatur laboriosam ex sequi aut praesentium autem.", 167, 17236m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quis ad alias sed quas accusantium.", 48, 2716m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est rerum est cum eligendi omnis illo.", 71, 2533m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sint deleniti qui voluptatem voluptatum ut.", 168, 5152m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aliquid quam a.", 180, 13954m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut quia voluptas nam non veniam dolor nobis.", 142, 1984m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Velit temporibus vitae.", 1, 12722m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Reiciendis cumque quod consequatur necessitatibus laboriosam quaerat.", 31, 14709m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Est et dolorem sequi vel occaecati quod optio.", 132, 13228m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Asperiores itaque harum.", 26, 17460m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolor asperiores dolorum voluptatem.", 189, 17160m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aperiam ut deleniti dolores blanditiis quas dolorum non qui aliquam.", 181, 5317m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Laborum temporibus saepe.", 173, 8018m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sit voluptatum molestiae.", 27, 18227m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quibusdam ipsum quo quia.", 177, 13764m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Perferendis rerum labore officiis et minima.", 116, 5545m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nihil ut eveniet.", 189, 1728m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Accusantium deserunt architecto quibusdam et illo totam autem.", 72, 3783m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ex delectus laborum sint omnis sequi nihil velit voluptatem id.", 178, 19371m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ad fuga explicabo maxime quas.", 169, 4510m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Autem qui nesciunt atque.", 45, 1762m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et in quis dolorem.", 89, 5357m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vero odit architecto reiciendis ad numquam occaecati error animi.", 136, 12193m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Tempore assumenda iure suscipit.", 13, 10862m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ut quisquam impedit soluta maiores praesentium dolorem a.", 129, 1242m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Architecto in perspiciatis rerum delectus cupiditate debitis laborum alias.", 90, 9761m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut qui ut placeat consequatur animi.", 52, 7210m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Provident odit omnis et reprehenderit repudiandae velit.", 140, 2840m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Mollitia placeat ut vel dolores ut incidunt atque incidunt.", 189, 7460m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit fugiat eum totam.", 196, 5373m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quam aut sapiente est in accusantium.", 141, 6151m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Corporis repellat enim eius tempora sed accusantium vitae.", 10, 6076m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Incidunt saepe consequatur possimus.", 170, 7510m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ipsam sed minima quia.", 91, 13179m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ex illo pariatur vero sit error neque.", 24, 4862m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Enim autem enim.", 137, 16388m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Reprehenderit ad ipsa nulla sed soluta voluptatem.", 176, 18815m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Vel iste est omnis nostrum quis debitis et.", 140, 11869m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Beatae quae maxime aut aliquid minima reiciendis autem quis non.", 1, 1644m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit modi consectetur at placeat.", 143, 5384m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Non aut aut eos a quaerat.", 187, 11595m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptate non cumque animi reprehenderit quo consequatur nisi.", 59, 12111m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Iure quis earum voluptas voluptatibus facilis aliquid.", 104, 6647m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ipsum recusandae esse hic quas.", 141, 13950m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nostrum corrupti aliquam.", 144, 7161m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quisquam ut vel.", 118, 5317m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptas quis est corporis aliquid velit officiis sit.", 119, 4356m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quasi modi non.", 16, 16757m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Fuga non harum sapiente aut quibusdam officia.", 93, 17795m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptas consequatur dolor perferendis qui expedita debitis et.", 107, 18473m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Reiciendis et perferendis qui molestiae sunt molestias et voluptatem cumque.", 69, 1534m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Veniam odio enim odio omnis omnis laboriosam.", 183, 14047m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit quo nam atque soluta quas doloribus repellat.", 88, 2896m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia assumenda et nam nihil.", 57, 19170m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Atque eum sunt consequatur numquam.", 115, 12810m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Commodi enim accusantium atque eius qui omnis aliquid vel rem.", 167, 14168m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Asperiores est aperiam id tenetur eum.", 101, 8863m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Deserunt dolores est ex adipisci alias ut quos.", 149, 201m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Nemo voluptate nihil ut temporibus fuga.", 5, 9616m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sint repudiandae quo culpa.", 75, 12077m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Natus et quam in voluptatem.", 21, 5540m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Molestiae magnam deserunt.", 110, 11740m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem debitis cumque distinctio sunt sed iste.", 33, 8767m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sunt rerum numquam dolorem necessitatibus molestias doloribus consequuntur aut excepturi.", 132, 18330m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Delectus quia voluptas velit aperiam molestiae vel.", 121, 4436m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Numquam voluptatem qui asperiores.", 91, 10928m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eaque assumenda cumque et natus omnis distinctio rerum sapiente.", 122, 6420m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Fugit a placeat quis sapiente impedit esse.", 198, 11422m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Odit exercitationem sint quis mollitia sed asperiores quo non.", 99, 11126m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quisquam culpa soluta veniam eveniet.", 88, 12458m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quibusdam dolores quos.", 94, 5172m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Facilis repellendus dignissimos consequatur quia deserunt est et.", 132, 12255m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quaerat illum officia doloribus fugiat.", 18, 17775m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Libero dolorem atque in aut.", 69, 14221m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Repudiandae nulla nobis.", 92, 18595m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aspernatur aut cupiditate dolor repudiandae nihil sed.", 54, 13572m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Id et asperiores cupiditate omnis ut rerum.", 18, 360m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Consectetur unde quam esse magni expedita quidem autem.", 198, 15979m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Necessitatibus repudiandae omnis eaque nihil aut totam aut.", 57, 17770m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sequi vel illum quasi.", 27, 18785m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi veniam sed unde dolore harum nesciunt.", 128, 15560m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum et eos reiciendis adipisci veniam voluptate quo corporis.", 113, 2809m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui natus qui dignissimos voluptatibus molestias vero.", 100, 5963m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Natus fugiat est aut sit facilis et quis ut sit.", 149, 19120m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ipsa quis tempora voluptatem omnis sunt quod consequatur.", 157, 12032m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Recusandae officia vitae consequatur inventore ipsam quisquam sunt consectetur.", 98, 3823m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut rerum animi harum optio aliquam dolor.", 65, 16253m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nemo illum voluptatem quae inventore.", 132, 8024m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aspernatur officia eaque molestiae alias voluptatem at aspernatur.", 99, 5350m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ipsum repellat esse vitae ea inventore sed.", 5, 11595m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et omnis ratione.", 101, 2631m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Natus ut perferendis mollitia.", 127, 5428m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Illo est debitis laboriosam enim at quae rerum voluptatem qui.", 20, 12001m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut esse aspernatur animi nihil delectus quo.", 161, 3163m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Maiores qui vel voluptatem molestiae nesciunt libero impedit.", 135, 6681m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aspernatur corrupti labore sint et pariatur praesentium sed.", 172, 8911m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aliquam rerum nisi.", 108, 10573m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Inventore qui quas iusto.", 87, 3409m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Provident quod molestias ut.", 95, 12106m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Hic corrupti molestiae ut sunt.", 81, 19133m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi aut accusantium eos tempora deleniti eaque libero.", 127, 14675m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sunt non quo.", 26, 2271m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Accusamus quis et qui debitis autem.", 110, 10399m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Magnam impedit voluptatem molestiae molestias id veniam quam error.", 152, 16163m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Blanditiis at voluptas vero voluptas.", 51, 7055m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Description", "Quantity", "Unit" },
                values: new object[] { "Occaecati non omnis ut est occaecati.", 8418m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quia nemo dolor quia molestias commodi.", 133, 14152m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nulla voluptas nihil itaque consectetur iure nihil.", 200, 1685m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptates voluptatibus illo recusandae minus quae iure omnis quo.", 27, 15837m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et suscipit doloribus error ipsum mollitia commodi.", 45, 19818m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptas doloremque deleniti sapiente commodi odio accusamus ut officiis.", 86, 4531m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Enim in vel.", 58, 1099m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Id quis explicabo recusandae eum vero voluptate sint.", 2, 6023m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ex architecto facere molestiae autem voluptatem consequatur tempore.", 113, 8495m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia repellendus dolor fuga.", 72, 14217m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut et molestiae laborum perferendis.", 186, 2646m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Doloribus quia sint quas inventore fuga.", 77, 2730m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Corrupti provident nisi cumque sed.", 136, 12438m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Fuga aperiam veritatis delectus rerum.", 50, 17m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et quaerat qui animi aut ea minima sed.", 122, 19970m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatibus dolorum sit vitae voluptates voluptatum excepturi non.", 10, 4979m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "At ut ipsum fuga quis.", 51, 15596m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Reprehenderit maxime eveniet magni.", 136, 6832m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Est quia vitae nisi omnis sint at assumenda commodi.", 152, 10153m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Excepturi unde quod rerum.", 166, 7462m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolorem iure earum laboriosam perferendis ut.", 115, 3378m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Porro ut est adipisci et.", 2, 14148m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Error voluptatum ullam molestias eum culpa animi cum.", 187, 6100m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Repudiandae a laborum culpa quo nihil adipisci sint soluta.", 105, 16012m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Perspiciatis voluptas nam soluta qui quia quo id repudiandae.", 127, 12841m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Repudiandae ut laborum aliquid provident odit vero.", 26, 4744m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Hic dolorem rerum cum corrupti doloribus quo.", 70, 16121m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Fugit eos voluptatem enim quae ut facere quia.", 2, 13191m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Praesentium doloribus odio sint.", 108, 6163m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quis rerum porro ut.", 159, 3044m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Error et rerum ut libero tenetur perspiciatis.", 76, 3824m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem qui rem atque doloremque alias in necessitatibus placeat voluptatem.", 177, 2015m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Deserunt consequatur illum repudiandae velit.", 89, 14028m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Modi voluptatem atque quis.", 33, 2339m, "Solid" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 502, "Cupiditate veniam aliquid sit nobis hic eum.", 14, 4287m, "Solid", "Kg" },
                    { 536, "Facilis esse repudiandae iusto veniam nostrum vitae cum repellat reprehenderit.", 51, 15424m, "Liquid", "L" },
                    { 537, "Eum ut nobis nihil quae et est.", 130, 19641m, "Liquid", "Kg" },
                    { 538, "Aperiam possimus dolores sit qui.", 40, 11946m, "Gas", "L" },
                    { 539, "Quibusdam voluptate voluptas et voluptatem.", 166, 18826m, "Solid", "Kg" },
                    { 540, "Repudiandae quia iure autem.", 108, 7788m, "Liquid", "L" },
                    { 541, "Et cupiditate repellendus vitae consequatur ab sint quas veritatis hic.", 36, 19370m, "Gas", "Kg" },
                    { 542, "Omnis minima aspernatur reiciendis deleniti nihil sapiente.", 3, 11275m, "Solid", "Kg" },
                    { 543, "Quis nihil earum vitae veritatis iste velit iusto id.", 64, 228m, "Liquid", "Kg" },
                    { 544, "Odio a debitis facilis.", 93, 14998m, "Gas", "L" },
                    { 545, "Aut rerum iste omnis.", 193, 5834m, "Solid", "Kg" },
                    { 546, "Quidem consectetur unde.", 174, 15957m, "Solid", "Kg" },
                    { 547, "Voluptatibus ad eum ut tenetur dolor sapiente dolore ut alias.", 53, 13724m, "Solid", "Kg" },
                    { 548, "Omnis laudantium eum odio molestias omnis.", 156, 18131m, "Liquid", "L" },
                    { 549, "Soluta dolorem nobis rerum quo.", 174, 198m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 550, "Asperiores nihil sequi eos.", 5, 11854m, "Solid", "L" },
                    { 551, "Ex consequatur repellat quibusdam repellat.", 86, 6708m, "Liquid", "Kg" },
                    { 552, "Architecto enim ab.", 20, 5543m, "Liquid", "L" },
                    { 553, "Fuga dolorem cum expedita reprehenderit rerum quia.", 136, 11172m, "Gas", "L" },
                    { 554, "Dolore aut quos quas et dignissimos nobis accusantium est nemo.", 68, 10916m, "Liquid", "L" },
                    { 555, "Aut earum nihil qui voluptas qui ut in.", 140, 6108m, "Solid", "L" },
                    { 556, "Deserunt odio in.", 98, 12315m, "Liquid", "L" },
                    { 557, "Illum perspiciatis quis quaerat.", 176, 8257m, "Solid", "Kg" },
                    { 558, "Explicabo voluptatem et quia quia et suscipit.", 93, 4430m, "Gas", "L" },
                    { 559, "Amet et quia accusantium sunt iusto.", 187, 4973m, "Gas", "L" },
                    { 560, "Et corrupti veritatis in illo adipisci aliquid laboriosam explicabo.", 101, 1598m, "Solid", "L" },
                    { 561, "Et ut qui et qui ipsa accusantium in impedit.", 34, 12636m, "Liquid", "L" },
                    { 562, "Cum et officia est consequatur totam est quisquam voluptatem.", 6, 4335m, "Gas", "Kg" },
                    { 563, "Amet ea et.", 48, 8059m, "Liquid", "L" },
                    { 564, "Nihil corrupti sed est.", 156, 16509m, "Liquid", "Kg" },
                    { 535, "Mollitia dolor odio quis facere numquam.", 34, 2806m, "Solid", "Kg" },
                    { 501, "Illo veritatis dolore facere quia.", 15, 16764m, "Liquid", "Kg" },
                    { 534, "Quidem voluptate doloribus dolor optio voluptas quis dolor incidunt est.", 166, 12340m, "Solid", "Kg" },
                    { 532, "Accusamus est quidem et omnis maxime rerum numquam et.", 75, 127m, "Solid", "L" },
                    { 503, "Vel nobis et aut.", 103, 13649m, "Gas", "L" },
                    { 504, "Itaque qui in iusto sed ut inventore optio.", 127, 1492m, "Liquid", "Kg" },
                    { 505, "Quaerat a accusamus eos et nihil id beatae cumque blanditiis.", 137, 1637m, "Liquid", "L" },
                    { 506, "Ipsam sequi deleniti iste magni consequatur officia.", 150, 2842m, "Liquid", "L" },
                    { 507, "Quia sint iure ab deserunt pariatur deleniti.", 188, 8456m, "Liquid", "Kg" },
                    { 508, "Explicabo eveniet expedita.", 99, 4746m, "Liquid", "L" },
                    { 509, "Dolor unde eum sint sed architecto eius.", 164, 1811m, "Liquid", "L" },
                    { 510, "Voluptatem illum velit natus enim ea.", 41, 9755m, "Gas", "L" },
                    { 511, "Vel est consequatur laudantium.", 71, 4730m, "Gas", "Kg" },
                    { 512, "Nesciunt sapiente dolorem est dolores.", 104, 9387m, "Liquid", "L" },
                    { 513, "Placeat totam voluptas sequi quibusdam ad.", 186, 9692m, "Liquid", "Kg" },
                    { 514, "Officia voluptatem rerum.", 62, 6522m, "Gas", "Kg" },
                    { 515, "Maiores itaque quia ea consequatur ut ex.", 86, 19831m, "Gas", "L" },
                    { 516, "Ut consequatur vel reprehenderit possimus sed blanditiis sunt amet facere.", 35, 1107m, "Solid", "Kg" },
                    { 517, "Facilis amet ducimus magni nesciunt ut voluptates.", 86, 12920m, "Gas", "Kg" },
                    { 518, "Et dignissimos veniam.", 17, 16941m, "Gas", "L" },
                    { 519, "Modi quas dolore.", 171, 11407m, "Liquid", "Kg" },
                    { 520, "Incidunt aut eveniet amet non nam.", 38, 14179m, "Liquid", "L" },
                    { 521, "Ut veritatis quisquam ea sapiente est quas sed.", 181, 2577m, "Gas", "L" },
                    { 522, "Dolor et nisi eos itaque.", 62, 17550m, "Liquid", "L" },
                    { 523, "Esse similique provident et quas aliquam.", 132, 14665m, "Solid", "Kg" },
                    { 524, "At reiciendis et ratione veniam et.", 94, 19208m, "Liquid", "Kg" },
                    { 525, "Et omnis ea quis voluptatem.", 63, 11388m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 526, "Repellendus in nemo temporibus et est.", 80, 19996m, "Liquid", "Kg" },
                    { 565, "Necessitatibus a excepturi nam laudantium quos asperiores eos repudiandae.", 1, 1270m, "Liquid", "Kg" },
                    { 528, "Doloribus quis sapiente dicta quasi voluptatibus occaecati eius.", 123, 18704m, "Solid", "Kg" },
                    { 529, "Accusantium quasi in adipisci ex at adipisci sapiente.", 20, 812m, "Liquid", "Kg" },
                    { 530, "Est voluptatum sit voluptatum in numquam.", 78, 7141m, "Gas", "L" },
                    { 531, "Modi quisquam ducimus quia dolor nisi incidunt.", 52, 16253m, "Liquid", "L" },
                    { 533, "Blanditiis officia qui doloribus.", 114, 16511m, "Gas", "L" },
                    { 566, "Consequatur culpa et reprehenderit nemo magni ut laboriosam repellat dolor.", 21, 10125m, "Liquid", "Kg" },
                    { 571, "Molestiae qui cumque laboriosam eum in maiores sunt est blanditiis.", 188, 9462m, "Liquid", "L" },
                    { 568, "Repudiandae quia voluptatum dolorem illum.", 22, 10517m, "Liquid", "Kg" },
                    { 588, "Maiores totam commodi repudiandae tenetur autem sunt iure.", 38, 3822m, "Solid", "L" },
                    { 589, "Sit dolor accusantium modi sunt veniam.", 182, 12019m, "Liquid", "Kg" },
                    { 590, "Aut aperiam reiciendis sint.", 35, 14314m, "Gas", "L" },
                    { 591, "Nisi eos voluptate voluptate perferendis ducimus quo dolorum culpa ipsa.", 155, 7412m, "Solid", "L" },
                    { 592, "Itaque sit ducimus esse numquam consequuntur voluptate architecto dignissimos.", 185, 3470m, "Gas", "L" },
                    { 593, "Tempore quidem est qui rem fugit aut quis.", 129, 12377m, "Solid", "Kg" },
                    { 587, "Deserunt vero quisquam ex.", 100, 13369m, "Solid", "L" },
                    { 594, "Omnis et et nam labore ut eos reiciendis eum odit.", 159, 15131m, "Liquid", "L" },
                    { 596, "Mollitia quasi ullam sit a similique.", 155, 14256m, "Solid", "Kg" },
                    { 597, "Est non temporibus molestias.", 135, 13285m, "Solid", "Kg" },
                    { 598, "Provident sit non cum dolor.", 78, 16400m, "Solid", "Kg" },
                    { 599, "Esse aut at.", 119, 9160m, "Gas", "Kg" },
                    { 600, "Sit velit tempore et voluptatibus placeat est nostrum pariatur dolor.", 102, 14476m, "Solid", "Kg" },
                    { 567, "Facilis qui earum fugiat blanditiis reprehenderit quasi rerum.", 183, 9083m, "Gas", "L" },
                    { 595, "Delectus incidunt fugit.", 194, 10541m, "Solid", "Kg" },
                    { 586, "Explicabo quia debitis assumenda molestiae in harum consectetur.", 64, 19408m, "Gas", "Kg" },
                    { 527, "Consequatur rerum molestiae ut.", 131, 16865m, "Liquid", "L" },
                    { 584, "Quam eaque iste eos expedita autem voluptatem quos.", 63, 18240m, "Liquid", "L" },
                    { 585, "Eveniet quia et fugiat quidem.", 137, 1442m, "Gas", "Kg" },
                    { 570, "Voluptatem sunt ullam harum.", 80, 9044m, "Gas", "L" },
                    { 572, "Laborum exercitationem blanditiis.", 162, 10461m, "Solid", "L" },
                    { 573, "Incidunt repellat libero tenetur officiis rem totam.", 135, 5382m, "Liquid", "Kg" },
                    { 574, "Eos harum qui.", 172, 17625m, "Liquid", "L" },
                    { 575, "Numquam est quidem numquam minus consectetur voluptatem.", 175, 3140m, "Solid", "Kg" },
                    { 576, "Dolor voluptatem rem nisi.", 23, 14257m, "Solid", "L" },
                    { 569, "Totam ullam cupiditate unde sapiente suscipit nesciunt voluptatem iure voluptas.", 134, 9198m, "Solid", "Kg" },
                    { 578, "Aut sint aspernatur nostrum blanditiis ea blanditiis modi.", 62, 13636m, "Liquid", "Kg" },
                    { 579, "Quo iure laboriosam qui.", 34, 3252m, "Gas", "Kg" },
                    { 580, "Temporibus quis doloremque quis omnis eum perferendis eius.", 128, 790m, "Gas", "L" },
                    { 581, "Dolore nobis doloremque perferendis.", 80, 19678m, "Gas", "Kg" },
                    { 582, "Rerum magni velit voluptatem asperiores autem voluptatem illum.", 104, 19998m, "Liquid", "Kg" },
                    { 583, "Consequatur quaerat dicta qui.", 93, 12518m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { 577, "Amet in eos eum porro.", 96, 19383m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "SS-5886", new DateTime(2021, 10, 15, 12, 21, 14, 216, DateTimeKind.Unspecified).AddTicks(1630), new DateTime(2021, 6, 12, 13, 44, 35, 514, DateTimeKind.Unspecified).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "58-9881", 4, new DateTime(2021, 10, 22, 1, 4, 6, 618, DateTimeKind.Unspecified).AddTicks(30), new DateTime(2021, 7, 31, 8, 54, 33, 745, DateTimeKind.Unspecified).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "RZ-6340", new DateTime(2021, 9, 25, 21, 47, 13, 845, DateTimeKind.Unspecified).AddTicks(2973), new DateTime(2021, 6, 2, 0, 20, 5, 931, DateTimeKind.Unspecified).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "1F-9281", 5, new DateTime(2021, 12, 13, 10, 25, 44, 410, DateTimeKind.Unspecified).AddTicks(6977), new DateTime(2021, 6, 17, 0, 47, 12, 997, DateTimeKind.Unspecified).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "69-4086", 5, new DateTime(2021, 12, 15, 23, 22, 36, 724, DateTimeKind.Unspecified).AddTicks(4177), new DateTime(2021, 5, 18, 9, 10, 26, 14, DateTimeKind.Unspecified).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "V5-7298", 2, new DateTime(2021, 12, 2, 10, 38, 44, 585, DateTimeKind.Unspecified).AddTicks(5048), new DateTime(2021, 8, 10, 20, 2, 25, 240, DateTimeKind.Unspecified).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "64-1647", 2, new DateTime(2021, 9, 1, 5, 22, 27, 593, DateTimeKind.Unspecified).AddTicks(349), new DateTime(2021, 8, 8, 15, 29, 45, 961, DateTimeKind.Unspecified).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "5I-5529", 1, new DateTime(2021, 9, 7, 23, 42, 9, 884, DateTimeKind.Unspecified).AddTicks(980), new DateTime(2021, 6, 4, 19, 45, 22, 893, DateTimeKind.Unspecified).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "37-9551", 5, new DateTime(2021, 12, 5, 22, 7, 7, 27, DateTimeKind.Unspecified).AddTicks(7215), new DateTime(2021, 8, 8, 19, 39, 17, 996, DateTimeKind.Unspecified).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "LJ-6359", 1, new DateTime(2021, 9, 22, 17, 23, 19, 343, DateTimeKind.Unspecified).AddTicks(57), new DateTime(2021, 7, 6, 10, 6, 54, 129, DateTimeKind.Unspecified).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "Q8-8873", 3, new DateTime(2021, 12, 3, 19, 52, 2, 761, DateTimeKind.Unspecified).AddTicks(2352), new DateTime(2021, 5, 30, 8, 6, 54, 30, DateTimeKind.Unspecified).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "6U-5614", 4, new DateTime(2021, 9, 15, 12, 45, 22, 343, DateTimeKind.Unspecified).AddTicks(2516), new DateTime(2021, 7, 3, 22, 27, 39, 491, DateTimeKind.Unspecified).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "V7-2301", 5, new DateTime(2021, 10, 1, 21, 15, 8, 203, DateTimeKind.Unspecified).AddTicks(5987), new DateTime(2021, 5, 20, 8, 0, 37, 507, DateTimeKind.Unspecified).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "69-8436", 2, new DateTime(2021, 9, 3, 19, 11, 7, 387, DateTimeKind.Unspecified).AddTicks(244), new DateTime(2021, 5, 30, 1, 59, 25, 543, DateTimeKind.Unspecified).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "T3-8048", 1, new DateTime(2021, 12, 27, 14, 51, 53, 898, DateTimeKind.Unspecified).AddTicks(2560), new DateTime(2021, 8, 16, 13, 15, 58, 506, DateTimeKind.Unspecified).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "A1-1099", 3, new DateTime(2021, 12, 16, 3, 16, 6, 43, DateTimeKind.Unspecified).AddTicks(5284), new DateTime(2021, 7, 5, 1, 27, 15, 777, DateTimeKind.Unspecified).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "2H-4881", 4, new DateTime(2021, 10, 31, 2, 49, 16, 296, DateTimeKind.Unspecified).AddTicks(2743), new DateTime(2021, 5, 29, 14, 31, 3, 967, DateTimeKind.Unspecified).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "Q7-7211", 5, new DateTime(2021, 12, 11, 16, 40, 27, 317, DateTimeKind.Unspecified).AddTicks(8484), new DateTime(2021, 6, 13, 17, 55, 51, 510, DateTimeKind.Unspecified).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "22-8249", 2, new DateTime(2021, 11, 13, 21, 10, 43, 486, DateTimeKind.Unspecified).AddTicks(7886), new DateTime(2021, 5, 13, 2, 48, 44, 260, DateTimeKind.Unspecified).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "12-2733", 5, new DateTime(2021, 11, 5, 6, 41, 7, 128, DateTimeKind.Unspecified).AddTicks(2105), new DateTime(2021, 5, 22, 11, 35, 54, 810, DateTimeKind.Unspecified).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "D2-4309", 5, new DateTime(2021, 9, 24, 13, 17, 46, 522, DateTimeKind.Unspecified).AddTicks(9305), new DateTime(2021, 5, 10, 8, 4, 3, 846, DateTimeKind.Unspecified).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "64-7225", 3, new DateTime(2021, 11, 15, 15, 16, 48, 627, DateTimeKind.Unspecified).AddTicks(8680), new DateTime(2021, 6, 23, 13, 15, 29, 984, DateTimeKind.Unspecified).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "VC-0906", 1, new DateTime(2021, 11, 25, 2, 3, 37, 585, DateTimeKind.Unspecified).AddTicks(8413), new DateTime(2021, 7, 11, 20, 35, 55, 512, DateTimeKind.Unspecified).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "18-4065", 1, new DateTime(2021, 11, 13, 23, 5, 19, 623, DateTimeKind.Unspecified).AddTicks(1827), new DateTime(2021, 8, 12, 20, 0, 4, 942, DateTimeKind.Unspecified).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "9O-3699", 4, new DateTime(2021, 11, 18, 21, 27, 20, 891, DateTimeKind.Unspecified).AddTicks(9605), new DateTime(2021, 6, 27, 1, 3, 41, 73, DateTimeKind.Unspecified).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "9Z-7305", new DateTime(2021, 11, 13, 18, 3, 44, 75, DateTimeKind.Unspecified).AddTicks(1778), new DateTime(2021, 6, 14, 10, 42, 8, 556, DateTimeKind.Unspecified).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "J5-0846", 5, new DateTime(2021, 9, 15, 21, 27, 50, 164, DateTimeKind.Unspecified).AddTicks(8655), new DateTime(2021, 7, 24, 0, 53, 56, 56, DateTimeKind.Unspecified).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "45-9695", new DateTime(2021, 10, 21, 23, 20, 14, 68, DateTimeKind.Unspecified).AddTicks(6233), new DateTime(2021, 6, 30, 2, 17, 27, 494, DateTimeKind.Unspecified).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "7T-1358", new DateTime(2021, 9, 3, 22, 0, 28, 532, DateTimeKind.Unspecified).AddTicks(6790), new DateTime(2021, 8, 4, 23, 4, 35, 34, DateTimeKind.Unspecified).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "KY-0761", 2, new DateTime(2021, 10, 8, 7, 46, 25, 100, DateTimeKind.Unspecified).AddTicks(812), new DateTime(2021, 7, 26, 5, 21, 14, 841, DateTimeKind.Unspecified).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "5L-6789", new DateTime(2021, 10, 11, 1, 19, 13, 181, DateTimeKind.Unspecified).AddTicks(2615), new DateTime(2021, 6, 23, 1, 40, 25, 903, DateTimeKind.Unspecified).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "TR-7852", 4, new DateTime(2021, 11, 6, 4, 2, 37, 734, DateTimeKind.Unspecified).AddTicks(8449), new DateTime(2021, 8, 28, 17, 43, 42, 870, DateTimeKind.Unspecified).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "A9-1313", 1, new DateTime(2021, 11, 8, 20, 34, 50, 339, DateTimeKind.Unspecified).AddTicks(5044), new DateTime(2021, 7, 16, 7, 5, 19, 936, DateTimeKind.Unspecified).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "C8-1718", 1, new DateTime(2021, 10, 8, 17, 1, 34, 186, DateTimeKind.Unspecified).AddTicks(9380), new DateTime(2021, 8, 23, 2, 16, 30, 332, DateTimeKind.Unspecified).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "94-2469", new DateTime(2021, 11, 13, 18, 3, 56, 898, DateTimeKind.Unspecified).AddTicks(413), new DateTime(2021, 8, 1, 15, 56, 5, 623, DateTimeKind.Unspecified).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "9O-5034", new DateTime(2021, 11, 23, 4, 33, 17, 574, DateTimeKind.Unspecified).AddTicks(7557), new DateTime(2021, 8, 25, 13, 41, 57, 35, DateTimeKind.Unspecified).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "T8-0151", new DateTime(2021, 9, 18, 23, 34, 19, 478, DateTimeKind.Unspecified).AddTicks(3210), new DateTime(2021, 7, 27, 23, 54, 57, 377, DateTimeKind.Unspecified).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "Q6-8696", 2, new DateTime(2021, 9, 24, 21, 6, 37, 826, DateTimeKind.Unspecified).AddTicks(1214), new DateTime(2021, 7, 5, 19, 50, 2, 754, DateTimeKind.Unspecified).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "O9-2412", 1, new DateTime(2021, 11, 6, 12, 30, 30, 690, DateTimeKind.Unspecified).AddTicks(5539), new DateTime(2021, 8, 6, 7, 48, 54, 122, DateTimeKind.Unspecified).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "7L-4651", new DateTime(2021, 12, 21, 17, 43, 44, 675, DateTimeKind.Unspecified).AddTicks(2053), new DateTime(2021, 7, 18, 7, 40, 56, 621, DateTimeKind.Unspecified).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "7L-9231", 2, new DateTime(2021, 11, 6, 18, 34, 11, 776, DateTimeKind.Unspecified).AddTicks(9529), new DateTime(2021, 8, 24, 15, 46, 40, 905, DateTimeKind.Unspecified).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "PR-0412", 5, new DateTime(2021, 9, 21, 21, 23, 37, 420, DateTimeKind.Unspecified).AddTicks(283), new DateTime(2021, 6, 19, 13, 2, 35, 300, DateTimeKind.Unspecified).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "N7-0392", new DateTime(2021, 11, 7, 9, 20, 15, 222, DateTimeKind.Unspecified).AddTicks(8348), new DateTime(2021, 8, 15, 17, 50, 47, 208, DateTimeKind.Unspecified).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "S7-3632", new DateTime(2021, 12, 16, 18, 46, 29, 868, DateTimeKind.Unspecified).AddTicks(4638), new DateTime(2021, 7, 14, 22, 27, 48, 239, DateTimeKind.Unspecified).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "W8-5305", 2, new DateTime(2021, 10, 24, 5, 38, 14, 615, DateTimeKind.Unspecified).AddTicks(6194), new DateTime(2021, 7, 17, 16, 46, 32, 827, DateTimeKind.Unspecified).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "68-9665", new DateTime(2021, 10, 6, 5, 10, 24, 967, DateTimeKind.Unspecified).AddTicks(205), new DateTime(2021, 8, 9, 15, 27, 24, 584, DateTimeKind.Unspecified).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "3E-1035", 5, new DateTime(2021, 9, 25, 18, 53, 0, 441, DateTimeKind.Unspecified).AddTicks(5617), new DateTime(2021, 8, 28, 22, 37, 28, 973, DateTimeKind.Unspecified).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "1P-2224", 1, new DateTime(2021, 11, 23, 20, 33, 21, 757, DateTimeKind.Unspecified).AddTicks(4059), new DateTime(2021, 7, 29, 4, 23, 36, 15, DateTimeKind.Unspecified).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "N0-6014", 1, new DateTime(2021, 10, 1, 4, 16, 3, 625, DateTimeKind.Unspecified).AddTicks(4248), new DateTime(2021, 7, 29, 3, 47, 22, 566, DateTimeKind.Unspecified).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "82-0047", new DateTime(2021, 12, 11, 3, 55, 22, 75, DateTimeKind.Unspecified).AddTicks(1679), new DateTime(2021, 7, 8, 4, 58, 25, 93, DateTimeKind.Unspecified).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "04-0312", 4, new DateTime(2021, 11, 17, 20, 57, 12, 672, DateTimeKind.Unspecified).AddTicks(1960), new DateTime(2021, 7, 11, 0, 36, 15, 276, DateTimeKind.Unspecified).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "IW-1514", 3, new DateTime(2021, 10, 20, 17, 48, 22, 857, DateTimeKind.Unspecified).AddTicks(3618), new DateTime(2021, 5, 28, 3, 48, 25, 760, DateTimeKind.Unspecified).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "Z0-3907", new DateTime(2021, 11, 12, 21, 36, 30, 758, DateTimeKind.Unspecified).AddTicks(2198), new DateTime(2021, 5, 18, 1, 36, 56, 83, DateTimeKind.Unspecified).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "R6-6461", 2, new DateTime(2021, 11, 26, 22, 54, 49, 94, DateTimeKind.Unspecified).AddTicks(8382), new DateTime(2021, 6, 28, 18, 21, 39, 429, DateTimeKind.Unspecified).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "6C-6035", new DateTime(2021, 9, 15, 3, 14, 28, 366, DateTimeKind.Unspecified).AddTicks(1664), new DateTime(2021, 7, 13, 13, 33, 50, 481, DateTimeKind.Unspecified).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "1Q-2763", 2, new DateTime(2021, 10, 30, 17, 53, 26, 641, DateTimeKind.Unspecified).AddTicks(6325), new DateTime(2021, 8, 30, 8, 58, 3, 435, DateTimeKind.Unspecified).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "5Y-7000", 3, new DateTime(2021, 11, 29, 17, 56, 7, 219, DateTimeKind.Unspecified).AddTicks(1965), new DateTime(2021, 8, 22, 8, 20, 19, 818, DateTimeKind.Unspecified).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "99-0570", new DateTime(2021, 10, 29, 19, 33, 23, 281, DateTimeKind.Unspecified).AddTicks(1672), new DateTime(2021, 7, 20, 3, 53, 43, 119, DateTimeKind.Unspecified).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "ZO-1148", new DateTime(2021, 9, 19, 15, 49, 51, 176, DateTimeKind.Unspecified).AddTicks(5602), new DateTime(2021, 8, 15, 10, 2, 54, 438, DateTimeKind.Unspecified).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "4W-7453", 2, new DateTime(2021, 10, 3, 0, 2, 26, 19, DateTimeKind.Unspecified).AddTicks(3247), new DateTime(2021, 6, 6, 18, 54, 19, 122, DateTimeKind.Unspecified).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "T7-5930", 5, new DateTime(2021, 12, 9, 2, 30, 28, 22, DateTimeKind.Unspecified).AddTicks(1281), new DateTime(2021, 6, 11, 20, 56, 45, 80, DateTimeKind.Unspecified).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "5K-1103", 1, new DateTime(2021, 11, 14, 9, 30, 15, 409, DateTimeKind.Unspecified).AddTicks(385), new DateTime(2021, 7, 27, 14, 2, 41, 505, DateTimeKind.Unspecified).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "W6-6325", 4, new DateTime(2021, 10, 14, 9, 18, 7, 323, DateTimeKind.Unspecified).AddTicks(5486), new DateTime(2021, 8, 16, 9, 31, 44, 768, DateTimeKind.Unspecified).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "U7-6828", 1, new DateTime(2021, 9, 22, 3, 7, 18, 492, DateTimeKind.Unspecified).AddTicks(8189), new DateTime(2021, 8, 3, 18, 33, 38, 314, DateTimeKind.Unspecified).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "11-0917", 1, new DateTime(2021, 11, 25, 9, 6, 32, 825, DateTimeKind.Unspecified).AddTicks(3237), new DateTime(2021, 8, 26, 19, 46, 41, 923, DateTimeKind.Unspecified).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "T5-0704", 4, new DateTime(2021, 10, 17, 4, 31, 40, 737, DateTimeKind.Unspecified).AddTicks(3811), new DateTime(2021, 7, 14, 23, 3, 58, 504, DateTimeKind.Unspecified).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "KG-6847", 1, new DateTime(2021, 10, 25, 8, 8, 3, 88, DateTimeKind.Unspecified).AddTicks(8169), new DateTime(2021, 5, 22, 9, 41, 51, 835, DateTimeKind.Unspecified).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "1U-4131", 5, new DateTime(2021, 12, 21, 17, 16, 28, 328, DateTimeKind.Unspecified).AddTicks(8599), new DateTime(2021, 5, 20, 19, 4, 0, 441, DateTimeKind.Unspecified).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "6J-8358", 3, new DateTime(2021, 11, 13, 22, 8, 12, 569, DateTimeKind.Unspecified).AddTicks(3093), new DateTime(2021, 6, 1, 23, 45, 29, 423, DateTimeKind.Unspecified).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "92-1154", 4, new DateTime(2021, 12, 21, 7, 0, 59, 441, DateTimeKind.Unspecified).AddTicks(1163), new DateTime(2021, 6, 27, 18, 38, 43, 758, DateTimeKind.Unspecified).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "3N-3453", 2, new DateTime(2021, 9, 1, 7, 30, 20, 630, DateTimeKind.Unspecified).AddTicks(9608), new DateTime(2021, 8, 5, 11, 16, 32, 961, DateTimeKind.Unspecified).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "0T-6283", 5, new DateTime(2021, 11, 5, 20, 45, 1, 495, DateTimeKind.Unspecified).AddTicks(5138), new DateTime(2021, 6, 29, 19, 9, 48, 517, DateTimeKind.Unspecified).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "1Q-9625", new DateTime(2021, 11, 4, 16, 53, 35, 929, DateTimeKind.Unspecified).AddTicks(8658), new DateTime(2021, 5, 26, 19, 46, 48, 47, DateTimeKind.Unspecified).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "9D-2836", 1, new DateTime(2021, 9, 13, 12, 20, 56, 157, DateTimeKind.Unspecified).AddTicks(7214), new DateTime(2021, 5, 22, 11, 33, 11, 381, DateTimeKind.Unspecified).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "8K-0092", new DateTime(2021, 9, 27, 5, 44, 7, 34, DateTimeKind.Unspecified).AddTicks(3477), new DateTime(2021, 6, 25, 0, 26, 49, 207, DateTimeKind.Unspecified).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "95-4272", 5, new DateTime(2021, 11, 22, 4, 3, 20, 415, DateTimeKind.Unspecified).AddTicks(5629), new DateTime(2021, 6, 14, 23, 8, 9, 843, DateTimeKind.Unspecified).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "S0-5830", 5, new DateTime(2021, 9, 14, 4, 39, 13, 564, DateTimeKind.Unspecified).AddTicks(9393), new DateTime(2021, 6, 23, 19, 20, 7, 834, DateTimeKind.Unspecified).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "X1-8860", new DateTime(2021, 10, 10, 4, 48, 52, 253, DateTimeKind.Unspecified).AddTicks(2511), new DateTime(2021, 7, 25, 19, 4, 53, 313, DateTimeKind.Unspecified).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "79-2818", 3, new DateTime(2021, 10, 14, 18, 26, 22, 598, DateTimeKind.Unspecified).AddTicks(49), new DateTime(2021, 7, 25, 6, 30, 32, 857, DateTimeKind.Unspecified).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "WA-9326", 3, new DateTime(2021, 11, 3, 7, 41, 31, 673, DateTimeKind.Unspecified).AddTicks(265), new DateTime(2021, 7, 25, 16, 26, 33, 980, DateTimeKind.Unspecified).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "P0-7213", 1, new DateTime(2021, 12, 15, 5, 5, 36, 386, DateTimeKind.Unspecified).AddTicks(9320), new DateTime(2021, 7, 24, 21, 14, 49, 432, DateTimeKind.Unspecified).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "MC-6568", 2, new DateTime(2021, 9, 2, 0, 38, 18, 847, DateTimeKind.Unspecified).AddTicks(6406), new DateTime(2021, 6, 3, 16, 10, 30, 58, DateTimeKind.Unspecified).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "62-0080", 1, new DateTime(2021, 11, 21, 17, 52, 40, 558, DateTimeKind.Unspecified).AddTicks(2775), new DateTime(2021, 5, 16, 4, 57, 43, 769, DateTimeKind.Unspecified).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "D2-9331", new DateTime(2021, 11, 4, 1, 57, 43, 737, DateTimeKind.Unspecified).AddTicks(3480), new DateTime(2021, 6, 19, 12, 41, 6, 613, DateTimeKind.Unspecified).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "EY-7837", 2, new DateTime(2021, 9, 9, 10, 50, 47, 752, DateTimeKind.Unspecified).AddTicks(916), new DateTime(2021, 8, 15, 18, 37, 57, 937, DateTimeKind.Unspecified).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "99-9589", 2, new DateTime(2021, 11, 7, 22, 38, 28, 491, DateTimeKind.Unspecified).AddTicks(3052), new DateTime(2021, 7, 9, 12, 36, 30, 14, DateTimeKind.Unspecified).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "3X-7183", 2, new DateTime(2021, 12, 23, 7, 27, 31, 51, DateTimeKind.Unspecified).AddTicks(1926), new DateTime(2021, 7, 21, 9, 5, 9, 8, DateTimeKind.Unspecified).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "81-3331", new DateTime(2021, 9, 9, 16, 9, 45, 588, DateTimeKind.Unspecified).AddTicks(5896), new DateTime(2021, 5, 9, 21, 28, 39, 205, DateTimeKind.Unspecified).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "36-9314", 4, new DateTime(2021, 10, 9, 5, 30, 2, 517, DateTimeKind.Unspecified).AddTicks(7049), new DateTime(2021, 7, 4, 19, 49, 5, 99, DateTimeKind.Unspecified).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "42-5576", 2, new DateTime(2021, 9, 12, 5, 54, 6, 398, DateTimeKind.Unspecified).AddTicks(7092), new DateTime(2021, 8, 6, 7, 52, 3, 983, DateTimeKind.Unspecified).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "6C-8333", new DateTime(2021, 10, 14, 10, 24, 37, 858, DateTimeKind.Unspecified).AddTicks(512), new DateTime(2021, 8, 16, 16, 47, 46, 850, DateTimeKind.Unspecified).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "F8-4138", new DateTime(2021, 12, 26, 17, 18, 27, 358, DateTimeKind.Unspecified).AddTicks(1479), new DateTime(2021, 5, 29, 1, 48, 55, 616, DateTimeKind.Unspecified).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "0T-2386", 3, new DateTime(2021, 10, 14, 18, 41, 35, 56, DateTimeKind.Unspecified).AddTicks(2224), new DateTime(2021, 6, 26, 1, 20, 5, 542, DateTimeKind.Unspecified).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "BG-0192", 3, new DateTime(2021, 10, 10, 15, 50, 47, 421, DateTimeKind.Unspecified).AddTicks(6786), new DateTime(2021, 6, 6, 10, 21, 15, 637, DateTimeKind.Unspecified).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "80-0971", new DateTime(2021, 11, 30, 13, 15, 29, 160, DateTimeKind.Unspecified).AddTicks(1672), new DateTime(2021, 8, 7, 11, 26, 58, 280, DateTimeKind.Unspecified).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "O0-9179", new DateTime(2021, 10, 14, 6, 5, 38, 825, DateTimeKind.Unspecified).AddTicks(8530), new DateTime(2021, 5, 20, 16, 13, 2, 450, DateTimeKind.Unspecified).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "BG-1946", 5, new DateTime(2021, 10, 16, 9, 45, 59, 633, DateTimeKind.Unspecified).AddTicks(9315), new DateTime(2021, 7, 18, 6, 8, 34, 8, DateTimeKind.Unspecified).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "7Q-3391", 2, new DateTime(2021, 10, 31, 12, 38, 6, 391, DateTimeKind.Unspecified).AddTicks(395), new DateTime(2021, 7, 13, 11, 21, 7, 328, DateTimeKind.Unspecified).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "93-8251", 4, new DateTime(2021, 12, 25, 23, 53, 18, 979, DateTimeKind.Unspecified).AddTicks(6845), new DateTime(2021, 7, 6, 0, 26, 54, 230, DateTimeKind.Unspecified).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "4M-2193", 5, new DateTime(2021, 9, 26, 9, 38, 20, 579, DateTimeKind.Unspecified).AddTicks(8531), new DateTime(2021, 8, 27, 11, 52, 0, 352, DateTimeKind.Unspecified).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "DL-0916", new DateTime(2021, 9, 28, 12, 25, 6, 291, DateTimeKind.Unspecified).AddTicks(258), new DateTime(2021, 6, 5, 14, 2, 3, 468, DateTimeKind.Unspecified).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "CN-7451", 2, new DateTime(2021, 12, 18, 14, 29, 41, 165, DateTimeKind.Unspecified).AddTicks(6733), new DateTime(2021, 6, 22, 11, 22, 21, 55, DateTimeKind.Unspecified).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "4C-9252", new DateTime(2021, 12, 1, 5, 21, 32, 548, DateTimeKind.Unspecified).AddTicks(5135), new DateTime(2021, 8, 10, 19, 10, 10, 858, DateTimeKind.Unspecified).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "C8-8849", 1, new DateTime(2021, 9, 13, 19, 0, 47, 788, DateTimeKind.Unspecified).AddTicks(8158), new DateTime(2021, 8, 7, 7, 13, 7, 606, DateTimeKind.Unspecified).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "4L-1898", 4, new DateTime(2021, 11, 22, 3, 15, 4, 770, DateTimeKind.Unspecified).AddTicks(5556), new DateTime(2021, 5, 22, 5, 19, 50, 141, DateTimeKind.Unspecified).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "0G-6926", new DateTime(2021, 11, 23, 18, 32, 0, 980, DateTimeKind.Unspecified).AddTicks(3177), new DateTime(2021, 8, 12, 23, 15, 4, 883, DateTimeKind.Unspecified).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "73-2475", 4, new DateTime(2021, 11, 1, 21, 3, 35, 721, DateTimeKind.Unspecified).AddTicks(2551), new DateTime(2021, 7, 22, 8, 1, 22, 215, DateTimeKind.Unspecified).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "D1-0009", 5, new DateTime(2021, 12, 4, 18, 15, 16, 473, DateTimeKind.Unspecified).AddTicks(5549), new DateTime(2021, 8, 3, 1, 53, 20, 81, DateTimeKind.Unspecified).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "22-4184", new DateTime(2021, 10, 14, 6, 59, 39, 154, DateTimeKind.Unspecified).AddTicks(6879), new DateTime(2021, 8, 28, 13, 47, 28, 594, DateTimeKind.Unspecified).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "5I-0502", new DateTime(2021, 11, 7, 11, 42, 56, 621, DateTimeKind.Unspecified).AddTicks(3420), new DateTime(2021, 7, 14, 16, 24, 25, 278, DateTimeKind.Unspecified).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "EG-9971", 1, new DateTime(2021, 9, 2, 9, 24, 38, 649, DateTimeKind.Unspecified).AddTicks(1671), new DateTime(2021, 6, 1, 12, 37, 25, 41, DateTimeKind.Unspecified).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "44-9297", 1, new DateTime(2021, 10, 30, 10, 59, 28, 0, DateTimeKind.Unspecified).AddTicks(5273), new DateTime(2021, 7, 19, 13, 18, 31, 920, DateTimeKind.Unspecified).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "6L-2549", new DateTime(2021, 10, 5, 10, 56, 10, 815, DateTimeKind.Unspecified).AddTicks(5979), new DateTime(2021, 6, 23, 13, 20, 27, 44, DateTimeKind.Unspecified).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "O6-1839", 2, new DateTime(2021, 11, 4, 6, 3, 25, 434, DateTimeKind.Unspecified).AddTicks(7438), new DateTime(2021, 5, 27, 22, 40, 14, 87, DateTimeKind.Unspecified).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "51-2740", 3, new DateTime(2021, 10, 6, 2, 20, 13, 289, DateTimeKind.Unspecified).AddTicks(3527), new DateTime(2021, 8, 7, 15, 28, 50, 295, DateTimeKind.Unspecified).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "2M-1234", 1, new DateTime(2021, 10, 21, 13, 15, 28, 592, DateTimeKind.Unspecified).AddTicks(6385), new DateTime(2021, 8, 19, 15, 9, 47, 166, DateTimeKind.Unspecified).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "FH-4719", 3, new DateTime(2021, 11, 27, 4, 53, 40, 337, DateTimeKind.Unspecified).AddTicks(7880), new DateTime(2021, 5, 10, 9, 34, 26, 954, DateTimeKind.Unspecified).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "2V-3375", new DateTime(2021, 12, 13, 11, 34, 20, 734, DateTimeKind.Unspecified).AddTicks(8621), new DateTime(2021, 7, 25, 14, 26, 57, 210, DateTimeKind.Unspecified).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "8D-1745", 4, new DateTime(2021, 9, 6, 2, 52, 18, 656, DateTimeKind.Unspecified).AddTicks(7417), new DateTime(2021, 6, 26, 17, 37, 22, 769, DateTimeKind.Unspecified).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "1V-9876", 2, new DateTime(2021, 12, 18, 2, 54, 26, 282, DateTimeKind.Unspecified).AddTicks(8852), new DateTime(2021, 6, 1, 1, 13, 53, 774, DateTimeKind.Unspecified).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "N7-1365", 3, new DateTime(2021, 11, 15, 8, 7, 11, 332, DateTimeKind.Unspecified).AddTicks(7106), new DateTime(2021, 6, 2, 6, 1, 58, 724, DateTimeKind.Unspecified).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "ZT-9404", 5, new DateTime(2021, 9, 23, 15, 9, 38, 847, DateTimeKind.Unspecified).AddTicks(6602), new DateTime(2021, 7, 25, 17, 55, 22, 350, DateTimeKind.Unspecified).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "XW-4059", 4, new DateTime(2021, 11, 17, 14, 38, 22, 106, DateTimeKind.Unspecified).AddTicks(9236), new DateTime(2021, 7, 17, 6, 40, 53, 834, DateTimeKind.Unspecified).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "T2-1843", 5, new DateTime(2021, 12, 29, 14, 23, 14, 293, DateTimeKind.Unspecified).AddTicks(5008), new DateTime(2021, 8, 22, 9, 24, 46, 855, DateTimeKind.Unspecified).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "0V-0708", 5, new DateTime(2021, 9, 25, 13, 56, 38, 508, DateTimeKind.Unspecified).AddTicks(4723), new DateTime(2021, 8, 20, 22, 12, 20, 433, DateTimeKind.Unspecified).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "T4-2290", 2, new DateTime(2021, 9, 24, 22, 20, 56, 740, DateTimeKind.Unspecified).AddTicks(7834), new DateTime(2021, 5, 21, 23, 51, 59, 497, DateTimeKind.Unspecified).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "U9-1328", 5, new DateTime(2021, 10, 18, 1, 18, 23, 145, DateTimeKind.Unspecified).AddTicks(815), new DateTime(2021, 7, 29, 5, 44, 35, 494, DateTimeKind.Unspecified).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "7W-8777", 5, new DateTime(2021, 10, 22, 3, 53, 3, 860, DateTimeKind.Unspecified).AddTicks(7496), new DateTime(2021, 6, 24, 20, 4, 35, 890, DateTimeKind.Unspecified).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "A6-9960", 5, new DateTime(2021, 10, 4, 7, 55, 50, 21, DateTimeKind.Unspecified).AddTicks(4188), new DateTime(2021, 8, 11, 22, 26, 26, 684, DateTimeKind.Unspecified).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "1N-6023", 1, new DateTime(2021, 10, 24, 10, 55, 3, 6, DateTimeKind.Unspecified).AddTicks(4304), new DateTime(2021, 5, 20, 16, 53, 45, 573, DateTimeKind.Unspecified).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "16-2437", 2, new DateTime(2021, 9, 19, 21, 17, 50, 615, DateTimeKind.Unspecified).AddTicks(9546), new DateTime(2021, 5, 29, 15, 41, 41, 802, DateTimeKind.Unspecified).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "6B-9648", 5, new DateTime(2021, 11, 21, 0, 4, 34, 632, DateTimeKind.Unspecified).AddTicks(3468), new DateTime(2021, 6, 27, 0, 23, 54, 453, DateTimeKind.Unspecified).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "27-0139", new DateTime(2021, 12, 11, 12, 38, 56, 498, DateTimeKind.Unspecified).AddTicks(7541), new DateTime(2021, 6, 15, 7, 54, 57, 890, DateTimeKind.Unspecified).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "AM-1195", 5, new DateTime(2021, 9, 3, 21, 19, 7, 985, DateTimeKind.Unspecified).AddTicks(2795), new DateTime(2021, 6, 20, 5, 47, 6, 582, DateTimeKind.Unspecified).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "14-2256", 4, new DateTime(2021, 9, 5, 16, 18, 24, 700, DateTimeKind.Unspecified).AddTicks(771), new DateTime(2021, 7, 13, 0, 46, 20, 649, DateTimeKind.Unspecified).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "6G-4124", 2, new DateTime(2021, 12, 20, 22, 21, 15, 201, DateTimeKind.Unspecified).AddTicks(735), new DateTime(2021, 6, 20, 19, 53, 20, 960, DateTimeKind.Unspecified).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "AV-7875", 5, new DateTime(2021, 12, 16, 1, 22, 24, 426, DateTimeKind.Unspecified).AddTicks(2110), new DateTime(2021, 7, 13, 19, 10, 37, 62, DateTimeKind.Unspecified).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "ZR-2611", new DateTime(2021, 10, 31, 4, 27, 39, 652, DateTimeKind.Unspecified).AddTicks(4686), new DateTime(2021, 5, 26, 20, 10, 49, 549, DateTimeKind.Unspecified).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "67-2971", 4, new DateTime(2021, 10, 2, 2, 20, 5, 514, DateTimeKind.Unspecified).AddTicks(5407), new DateTime(2021, 7, 12, 19, 12, 23, 265, DateTimeKind.Unspecified).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "6V-8012", 1, new DateTime(2021, 11, 2, 11, 29, 59, 497, DateTimeKind.Unspecified).AddTicks(7756), new DateTime(2021, 7, 6, 23, 9, 19, 604, DateTimeKind.Unspecified).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "56-8240", new DateTime(2021, 9, 7, 4, 37, 0, 648, DateTimeKind.Unspecified).AddTicks(9432), new DateTime(2021, 6, 22, 2, 58, 1, 876, DateTimeKind.Unspecified).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "Y9-3412", 2, new DateTime(2021, 11, 1, 17, 56, 22, 474, DateTimeKind.Unspecified).AddTicks(1932), new DateTime(2021, 6, 1, 18, 47, 39, 177, DateTimeKind.Unspecified).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "I3-5846", 1, new DateTime(2021, 11, 25, 13, 37, 25, 673, DateTimeKind.Unspecified).AddTicks(3247), new DateTime(2021, 6, 10, 13, 40, 33, 248, DateTimeKind.Unspecified).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "C5-9441", 2, new DateTime(2021, 12, 15, 20, 53, 55, 998, DateTimeKind.Unspecified).AddTicks(5091), new DateTime(2021, 5, 16, 0, 9, 13, 710, DateTimeKind.Unspecified).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "FP-7219", 2, new DateTime(2021, 11, 7, 21, 13, 13, 565, DateTimeKind.Unspecified).AddTicks(9585), new DateTime(2021, 8, 21, 22, 40, 54, 593, DateTimeKind.Unspecified).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "D9-8781", 4, new DateTime(2021, 9, 25, 20, 27, 4, 653, DateTimeKind.Unspecified).AddTicks(2351), new DateTime(2021, 6, 4, 2, 3, 41, 7, DateTimeKind.Unspecified).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "59-0028", 2, new DateTime(2021, 10, 16, 11, 26, 0, 62, DateTimeKind.Unspecified).AddTicks(2205), new DateTime(2021, 7, 4, 5, 3, 8, 135, DateTimeKind.Unspecified).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "WX-4239", 1, new DateTime(2021, 12, 14, 4, 24, 25, 754, DateTimeKind.Unspecified).AddTicks(7876), new DateTime(2021, 7, 20, 17, 11, 57, 914, DateTimeKind.Unspecified).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "M5-0823", 5, new DateTime(2021, 9, 20, 1, 48, 40, 61, DateTimeKind.Unspecified).AddTicks(772), new DateTime(2021, 6, 17, 9, 16, 48, 802, DateTimeKind.Unspecified).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "FI-5124", 4, new DateTime(2021, 12, 22, 13, 26, 39, 214, DateTimeKind.Unspecified).AddTicks(7507), new DateTime(2021, 5, 11, 3, 12, 3, 120, DateTimeKind.Unspecified).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "AJ-1205", new DateTime(2021, 11, 11, 2, 40, 44, 491, DateTimeKind.Unspecified).AddTicks(2449), new DateTime(2021, 8, 22, 0, 51, 33, 756, DateTimeKind.Unspecified).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "RJ-2131", 3, new DateTime(2021, 10, 1, 19, 11, 30, 483, DateTimeKind.Unspecified).AddTicks(7811), new DateTime(2021, 8, 19, 17, 29, 9, 35, DateTimeKind.Unspecified).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "00-3128", 3, new DateTime(2021, 12, 30, 12, 7, 42, 583, DateTimeKind.Unspecified).AddTicks(9124), new DateTime(2021, 7, 21, 6, 26, 45, 840, DateTimeKind.Unspecified).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "87-7725", 2, new DateTime(2021, 12, 10, 17, 34, 21, 496, DateTimeKind.Unspecified).AddTicks(8475), new DateTime(2021, 7, 26, 1, 46, 18, 60, DateTimeKind.Unspecified).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "94-7841", 1, new DateTime(2021, 9, 20, 8, 12, 15, 694, DateTimeKind.Unspecified).AddTicks(854), new DateTime(2021, 5, 8, 5, 7, 22, 961, DateTimeKind.Unspecified).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "Y7-1012", 1, new DateTime(2021, 10, 17, 8, 32, 15, 581, DateTimeKind.Unspecified).AddTicks(8042), new DateTime(2021, 5, 30, 13, 37, 3, 868, DateTimeKind.Unspecified).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "R7-4390", 2, new DateTime(2021, 10, 24, 13, 43, 24, 662, DateTimeKind.Unspecified).AddTicks(5665), new DateTime(2021, 8, 4, 23, 18, 5, 244, DateTimeKind.Unspecified).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "T5-0587", 5, new DateTime(2021, 12, 6, 10, 10, 5, 61, DateTimeKind.Unspecified).AddTicks(2158), new DateTime(2021, 8, 25, 7, 59, 9, 811, DateTimeKind.Unspecified).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "N2-2474", new DateTime(2021, 9, 8, 9, 44, 45, 904, DateTimeKind.Unspecified).AddTicks(6593), new DateTime(2021, 7, 9, 6, 14, 29, 969, DateTimeKind.Unspecified).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "6U-4981", 1, new DateTime(2021, 10, 22, 17, 23, 57, 319, DateTimeKind.Unspecified).AddTicks(5850), new DateTime(2021, 8, 4, 2, 49, 16, 875, DateTimeKind.Unspecified).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "O5-9459", 4, new DateTime(2021, 12, 28, 19, 55, 38, 85, DateTimeKind.Unspecified).AddTicks(1126), new DateTime(2021, 5, 23, 14, 54, 10, 507, DateTimeKind.Unspecified).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "TV-8271", 2, new DateTime(2021, 10, 17, 7, 34, 15, 104, DateTimeKind.Unspecified).AddTicks(2013), new DateTime(2021, 5, 24, 16, 45, 41, 639, DateTimeKind.Unspecified).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "C8-1868", 4, new DateTime(2021, 11, 16, 19, 34, 29, 477, DateTimeKind.Unspecified).AddTicks(9113), new DateTime(2021, 6, 15, 5, 20, 31, 573, DateTimeKind.Unspecified).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "2G-3638", 3, new DateTime(2021, 12, 1, 11, 3, 4, 871, DateTimeKind.Unspecified).AddTicks(7711), new DateTime(2021, 8, 13, 17, 35, 36, 276, DateTimeKind.Unspecified).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "08-0628", 3, new DateTime(2021, 12, 7, 10, 32, 15, 437, DateTimeKind.Unspecified).AddTicks(219), new DateTime(2021, 7, 21, 17, 40, 59, 701, DateTimeKind.Unspecified).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "6X-0229", 3, new DateTime(2021, 11, 9, 2, 4, 29, 95, DateTimeKind.Unspecified).AddTicks(2381), new DateTime(2021, 7, 5, 3, 21, 3, 252, DateTimeKind.Unspecified).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "MO-7382", new DateTime(2021, 9, 22, 14, 3, 1, 277, DateTimeKind.Unspecified).AddTicks(3076), new DateTime(2021, 7, 24, 10, 31, 57, 198, DateTimeKind.Unspecified).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "TC-7525", 4, new DateTime(2021, 11, 16, 6, 52, 45, 837, DateTimeKind.Unspecified).AddTicks(5170), new DateTime(2021, 8, 29, 0, 2, 34, 353, DateTimeKind.Unspecified).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "LG-4830", 3, new DateTime(2021, 11, 9, 1, 31, 45, 668, DateTimeKind.Unspecified).AddTicks(5101), new DateTime(2021, 5, 27, 10, 22, 21, 16, DateTimeKind.Unspecified).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "Q0-9458", 1, new DateTime(2021, 10, 2, 6, 1, 5, 621, DateTimeKind.Unspecified).AddTicks(985), new DateTime(2021, 6, 22, 17, 0, 25, 645, DateTimeKind.Unspecified).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "18-9999", 3, new DateTime(2021, 10, 6, 11, 53, 9, 5, DateTimeKind.Unspecified).AddTicks(7495), new DateTime(2021, 7, 23, 5, 7, 13, 860, DateTimeKind.Unspecified).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "PJ-1667", 3, new DateTime(2021, 9, 14, 6, 32, 27, 302, DateTimeKind.Unspecified).AddTicks(216), new DateTime(2021, 6, 9, 10, 27, 56, 840, DateTimeKind.Unspecified).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "1F-2163", new DateTime(2021, 10, 7, 1, 0, 14, 156, DateTimeKind.Unspecified).AddTicks(2985), new DateTime(2021, 8, 6, 9, 40, 56, 378, DateTimeKind.Unspecified).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "M5-7206", 5, new DateTime(2021, 10, 8, 14, 28, 47, 806, DateTimeKind.Unspecified).AddTicks(3167), new DateTime(2021, 7, 9, 10, 3, 45, 912, DateTimeKind.Unspecified).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "EI-8662", new DateTime(2021, 12, 10, 11, 1, 15, 650, DateTimeKind.Unspecified).AddTicks(4765), new DateTime(2021, 6, 28, 8, 25, 53, 311, DateTimeKind.Unspecified).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "7H-5229", 5, new DateTime(2021, 11, 18, 5, 52, 23, 1, DateTimeKind.Unspecified).AddTicks(4426), new DateTime(2021, 7, 25, 12, 48, 39, 553, DateTimeKind.Unspecified).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "DJ-1616", 3, new DateTime(2021, 9, 7, 17, 18, 45, 511, DateTimeKind.Unspecified).AddTicks(2581), new DateTime(2021, 7, 11, 19, 49, 38, 967, DateTimeKind.Unspecified).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "2L-8545", 1, new DateTime(2021, 9, 3, 16, 57, 54, 93, DateTimeKind.Unspecified).AddTicks(9455), new DateTime(2021, 6, 3, 10, 3, 39, 691, DateTimeKind.Unspecified).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "76-5541", 3, new DateTime(2021, 11, 30, 16, 59, 55, 479, DateTimeKind.Unspecified).AddTicks(2054), new DateTime(2021, 7, 31, 4, 17, 43, 167, DateTimeKind.Unspecified).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "I1-9720", 1, new DateTime(2021, 10, 3, 18, 1, 53, 241, DateTimeKind.Unspecified).AddTicks(4196), new DateTime(2021, 8, 8, 16, 0, 55, 733, DateTimeKind.Unspecified).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "V2-0063", 5, new DateTime(2021, 10, 15, 21, 24, 37, 320, DateTimeKind.Unspecified).AddTicks(1661), new DateTime(2021, 8, 15, 21, 39, 15, 999, DateTimeKind.Unspecified).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "L0-8454", 3, new DateTime(2021, 11, 4, 15, 27, 18, 87, DateTimeKind.Unspecified).AddTicks(7814), new DateTime(2021, 8, 8, 6, 47, 42, 559, DateTimeKind.Unspecified).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "GF-9288", 5, new DateTime(2021, 11, 26, 20, 4, 40, 834, DateTimeKind.Unspecified).AddTicks(6534), new DateTime(2021, 8, 20, 7, 21, 25, 257, DateTimeKind.Unspecified).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "23-4386", 3, new DateTime(2021, 11, 3, 13, 56, 42, 881, DateTimeKind.Unspecified).AddTicks(6531), new DateTime(2021, 7, 19, 22, 38, 56, 303, DateTimeKind.Unspecified).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "F7-1370", 1, new DateTime(2021, 12, 5, 10, 13, 59, 50, DateTimeKind.Unspecified).AddTicks(4114), new DateTime(2021, 7, 30, 6, 54, 27, 663, DateTimeKind.Unspecified).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "36-1037", 3, new DateTime(2021, 11, 11, 16, 34, 24, 665, DateTimeKind.Unspecified).AddTicks(7819), new DateTime(2021, 7, 19, 2, 26, 59, 442, DateTimeKind.Unspecified).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "12-8108", 4, new DateTime(2021, 12, 3, 20, 44, 33, 709, DateTimeKind.Unspecified).AddTicks(7462), new DateTime(2021, 7, 11, 0, 56, 41, 538, DateTimeKind.Unspecified).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "0Q-0878", 3, new DateTime(2021, 9, 2, 18, 26, 13, 11, DateTimeKind.Unspecified).AddTicks(9776), new DateTime(2021, 8, 23, 20, 11, 14, 214, DateTimeKind.Unspecified).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "FK-2892", 3, new DateTime(2021, 12, 22, 8, 30, 48, 696, DateTimeKind.Unspecified).AddTicks(2163), new DateTime(2021, 6, 23, 6, 6, 31, 717, DateTimeKind.Unspecified).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "58-5813", 5, new DateTime(2021, 9, 10, 1, 30, 45, 147, DateTimeKind.Unspecified).AddTicks(5750), new DateTime(2021, 7, 16, 7, 58, 10, 953, DateTimeKind.Unspecified).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "7Q-7800", 2, new DateTime(2021, 11, 24, 5, 4, 37, 113, DateTimeKind.Unspecified).AddTicks(7874), new DateTime(2021, 6, 8, 12, 10, 38, 987, DateTimeKind.Unspecified).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "RT-1214", 4, new DateTime(2021, 11, 11, 9, 58, 21, 329, DateTimeKind.Unspecified).AddTicks(3657), new DateTime(2021, 6, 13, 3, 15, 49, 853, DateTimeKind.Unspecified).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "V6-1513", 3, new DateTime(2021, 11, 4, 17, 2, 41, 159, DateTimeKind.Unspecified).AddTicks(5782), new DateTime(2021, 5, 15, 14, 10, 26, 882, DateTimeKind.Unspecified).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "3T-5362", 2, new DateTime(2021, 12, 13, 0, 44, 26, 932, DateTimeKind.Unspecified).AddTicks(8300), new DateTime(2021, 6, 1, 17, 30, 45, 701, DateTimeKind.Unspecified).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "45-4145", 3, new DateTime(2021, 12, 14, 16, 8, 31, 175, DateTimeKind.Unspecified).AddTicks(322), new DateTime(2021, 8, 20, 9, 5, 56, 172, DateTimeKind.Unspecified).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "LQ-8902", new DateTime(2021, 12, 3, 7, 11, 41, 617, DateTimeKind.Unspecified).AddTicks(5167), new DateTime(2021, 7, 7, 9, 34, 51, 9, DateTimeKind.Unspecified).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "LI-0033", 4, new DateTime(2021, 11, 25, 7, 26, 59, 366, DateTimeKind.Unspecified).AddTicks(9146), new DateTime(2021, 6, 12, 3, 47, 59, 639, DateTimeKind.Unspecified).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "6M-0501", 3, new DateTime(2021, 9, 8, 3, 39, 7, 718, DateTimeKind.Unspecified).AddTicks(3522), new DateTime(2021, 6, 4, 0, 15, 23, 725, DateTimeKind.Unspecified).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "02-3923", 5, new DateTime(2021, 12, 30, 8, 30, 42, 587, DateTimeKind.Unspecified).AddTicks(1768), new DateTime(2021, 8, 12, 14, 7, 31, 317, DateTimeKind.Unspecified).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "04-7520", 1, new DateTime(2021, 9, 29, 11, 44, 19, 189, DateTimeKind.Unspecified).AddTicks(5121), new DateTime(2021, 6, 13, 1, 22, 29, 135, DateTimeKind.Unspecified).AddTicks(6202) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 26 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 14, 26 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 27 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 29 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 12, 29 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 31 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 13, 34 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 35 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 37 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 38 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 13, 38 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 39 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 41 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 8, 42 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 43 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 44 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 45 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 47 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 48 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 49 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 11, 49 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 50 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 51 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 52 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 53 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 54 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 56 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 58 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 13, 58 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 59 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 60 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 61 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 62 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 63 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 12, 64 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 65 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 66 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 67 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 68 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 69 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 70 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 71 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 6, 71 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 72 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 74 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 75 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 77 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 11, 77 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 79 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 80 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 9, 80 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 81 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 82 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 83 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 85 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 86 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 87 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 88 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 10, 88 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 90 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 7, 91 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 93 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 95 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 96 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 97 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 98 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 12, 98 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 99 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 101 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 102 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 103 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 11, 103 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 107 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 108 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 109 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 8, 110 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 111 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 112 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 113 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 9, 114 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 118 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 119 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 120 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 121 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 123 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 124 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 125 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 126 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 127 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 129 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 130 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 131 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 134 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 136 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 137 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 138 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 139 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 142 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 144 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 145 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 146 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 148 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 149 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 150 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 152 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 155 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 156 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 158 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 159 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 160 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 161 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 163 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 164 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 165 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 168 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 169 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 170 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 171 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 172 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 174 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 175 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 176 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 178 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 179 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 180 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 181 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 183 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 184 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 188 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 189 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 190 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 191 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 194 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 195 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 196 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 1, 197 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 3, 198 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 2, 199 });

            migrationBuilder.DeleteData(
                table: "ConsignorManifest",
                keyColumns: new[] { "ConsignorId", "ManifestId" },
                keyValues: new object[] { 4, 200 });

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 1,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "172 Fahey Junctions", "Martinastad", "R4O 7R5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 2,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "999 Daugherty Avenue", "East Gerardoview", "A2H 8P6", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 3,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1864 Ryan Heights", "New Alda", "R3Q 3A6", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 4,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "682 Glenna Courts", "South Mackbury", "Y1N 9C8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 5,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "54167 Eliseo Mount", "West Winfield", "C7S 9F2", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 6,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8090 Schmeler Course", "Caseyborough", "L7Q 7Q7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 7,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "816 Connor Mountain", "South Davidview", "T8P 8E3", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 8,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "069 King Common", "Lebsackmouth", "Y0F 3N7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 9,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "94815 Volkman Crossing", "Martahaven", "L4L 0H2", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 10,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "15923 Steuber Island", "West Eugenia", "P8I 2O6", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 11,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "16605 Bauch Lock", "Christon", "J1K 1O9", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 12,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0302 Schneider Crossroad", "Beaulahland", "P2C 1X4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 13,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6230 Torphy Rapid", "South Itzel", "S5H 5S1", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 14,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4457 Morar Locks", "North Durward", "M7I 5L5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 15,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "67184 Rowe Gardens", "Heidenreichchester", "A9B 4W4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 16,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "01494 Jayson Turnpike", "North Sandy", "T0Z 5N0", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 17,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0389 Bosco Tunnel", "Lyrichaven", "Y1R 9L8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 18,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0747 Corine Knoll", "Vincenttown", "X8T 0R0", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 19,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "485 Graham Meadows", "Port Patricia", "C5S 2O3", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 20,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "52051 Bernita Plain", "Rueckerberg", "Y8V 0L1" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 21,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "694 Kreiger Heights", "Konopelskimouth", "H3X 5A4", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 22,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "65666 Kohler Union", "West Melvinfurt", "K5I 5P7", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 23,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4348 Daugherty Camp", "South Reedborough", "G1I 8X9", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 24,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "707 Dusty Oval", "Schmittmouth", "K7F 5D2", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 25,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "46438 Damian Spur", "Delphaberg", "R6D 0I5" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 26,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "06546 Karli Pass", "Marianetown", "A6R 4E8", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 27,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "65116 Dorris Fall", "Cathrynberg", "P5X 6Q7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 28,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "92140 Maya Crossroad", "Lake Rockyport", "M8B 3Y4", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 29,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4434 Botsford Mews", "Zoeymouth", "A5B 7D2", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 30,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "8376 Christiansen Ranch", "New Roderickborough", "G2S 3P6" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 31,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "093 Bahringer Highway", "South Jewel", "X0O 1W2", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 32,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "27960 Maggie Street", "Lake Raechester", "L8Q 5Q7", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 33,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "658 Grant Drive", "East Briana", "L2J 4V9" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 34,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "17670 Francesco Track", "East Tia", "E4K 3F3", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 35,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9023 Abbey Island", "Lake Zachery", "P0J 3H0", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 36,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4026 Stamm Land", "North Russelshire", "L2W 0L0", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 37,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "34224 Einar Green", "Boganton", "K8D 8U5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 38,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "677 Anibal Highway", "Frederiqueberg", "X2C 7B2", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 39,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "23976 Schoen Vista", "Moenville", "G8S 2P4", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 40,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "815 Roob Road", "Lake Dorrisfurt", "V2S 5M7", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 41,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "891 Saige Crossroad", "North Aniyastad", "C6H 8M2", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 42,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "93283 Nathanael Springs", "Littelburgh", "M3S 5V4", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 43,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "014 Zieme Path", "Carliestad", "G3K 6G9", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 44,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "844 Mills Cove", "Jakubowskiborough", "X7B 0H3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 45,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "96673 Mason Shores", "Port Patience", "B7Y 9Q3" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 46,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "717 Cartwright Harbor", "Port Enosville", "B3G 8Y1", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 47,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "186 Chasity Bridge", "New Danny", "C4Z 6O4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 48,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4801 Schowalter Ville", "Pollichmouth", "X0T 7L2", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 49,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6090 Kovacek Drives", "Lake Baileyview", "T7O 1C9", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 50,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "99837 Bartell Walk", "New Kara", "X8B 9U1", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 51,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7270 Turner Isle", "South Kielfurt", "E3Q 9M2", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 52,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "05089 Goyette Springs", "Lupebury", "A5O 0Q2", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 53,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "80026 Fadel Hollow", "North Hailiemouth", "R8N 1I2", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 54,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "174 Gloria Squares", "Ociestad", "H5M 4L9", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 55,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "65283 Noe Field", "Lake Alfred", "H9M 2Q8", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 56,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8681 Lillie Points", "Beerberg", "N1G 7L7", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 57,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "087 Haley Locks", "Vallieburgh", "H8P 3H8", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 58,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "18213 Alexie Roads", "Lake Anne", "A4E 0Z3", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 59,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9887 Bruen Ways", "Lake Chanel", "L8I 3K1", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 60,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2980 Wilfrid Meadow", "Lake Lupestad", "Y0J 3G0", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 61,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "62864 Kuvalis Route", "Aprilmouth", "M9P 5H8", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 62,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "71794 Sporer Views", "Port Blaze", "H1L 6G8", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 63,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "78680 Kyleigh Islands", "Lake Antonette", "Y7N 1O9", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 64,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7946 Ernser Views", "South Tillman", "K8Z 7F4", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 65,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "969 Sheila Streets", "Fredrickport", "H1H 4L1" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 66,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0465 Schoen Lights", "Mariahmouth", "A3R 3C9", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 67,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "20181 Delphia Squares", "Bahringerside", "V7O 8J4" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 68,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2134 Isom Estate", "New Missouri", "M7A 7K8", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 69,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6471 O'Reilly Locks", "West Nikitafort", "P4F 8U0", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 70,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "50836 Nikolaus Mills", "Weimannville", "T0M 7U7", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 71,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5875 Candelario Drive", "New Candiceshire", "H4R 3E9", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 72,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3582 Jalyn Isle", "Agustinaview", "A3C 9O4", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 73,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "069 Eunice Grove", "Pourosburgh", "C5W 1B1", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 74,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "590 Welch Viaduct", "North Theresashire", "M1W 1F2", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 75,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "71828 Mina Knoll", "Feestside", "Y3U 6A7", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 76,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0858 Vicky Path", "West Haleigh", "X7A 2B4", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 77,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "280 Reichel Estates", "Concepcionland", "E1L 3W8", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 78,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "09546 Scot Ramp", "Lynchshire", "S2V 0H7", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 79,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "269 Auer Fork", "East Chanelstad", "E7X 0I0", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 80,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "002 Sanford Flat", "McGlynnside", "K0E 7S3", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 81,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4243 Hadley Village", "Namebury", "E5Y 7X4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 82,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7319 Deckow Cape", "Kennychester", "B5S 6S1", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 83,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "45577 Schaefer Roads", "Kuhnburgh", "H7W 3L3", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 84,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7923 Effie Rapids", "South Rogelio", "P0G 3T2", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 85,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1224 Lea Meadows", "West Maximilliaborough", "J4H 9H0", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 86,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1926 Danika Mission", "North Georgiannaton", "P7N 9T1", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 87,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5158 Boyer Bypass", "Lake Elveraland", "H3H 9C2", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 88,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "95166 DuBuque Crossing", "Haleyville", "R4Y 1E9", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 89,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7248 Frieda Mall", "South Keshawn", "L9L 8I9", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 90,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "341 Wilfrid Forest", "Wizahaven", "C7D 2V5", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 91,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "321 Lucile Crest", "South Ned", "G6Q 1B9", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 92,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6249 Alva Brooks", "Haagfort", "E1V 4P5", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 93,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "903 Price Court", "Reynoldsberg", "Y6E 2K4" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 94,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "338 Hettinger Port", "Maximusmouth", "K1B 6P1" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 95,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "247 Anita Branch", "Collierborough", "N8T 4F8", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 96,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "24378 Flavio Hill", "North Nash", "B0Z 7J2", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 97,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2531 Trantow Park", "Creolashire", "E8M 9Y3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 98,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "4739 Konopelski Mountain", "South Stellatown", "A1F 1H7" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 99,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "631 Chanelle Corners", "Ivyfurt", "A3O 5Z0", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 100,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3671 Spencer Motorway", "Ullrichshire", "H6D 2A5", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 101,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8534 Beier Parks", "Ondrickaport", "E1U 8Y2", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 102,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "425 Haley Meadows", "Herzogview", "B5A 4S5", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 103,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "19534 Yasmin Vista", "Loweport", "E9T 8Y0", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 104,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0095 Deja Skyway", "Hudsonchester", "E4R 2H7", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 105,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7286 Bernier Shores", "Bertfort", "M6F 8Y7", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 106,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "401 Verona Vista", "West Hayleymouth", "L1O 6K5", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 107,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2412 Dibbert Knoll", "Lake Adriennestad", "L0U 2L0", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 108,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "113 Boyer Oval", "North Valentin", "T2K 2R7", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 109,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "932 Halvorson Trafficway", "Stiedemannburgh", "J3G 3X8", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 110,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0712 Effertz Dale", "Doyleburgh", "E3B 4T4", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 111,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "320 Rippin Garden", "Prosaccostad", "K3M 4G1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 112,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6505 Joyce River", "Bertrandton", "V4X 5C1", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 113,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8460 Thompson Brook", "Waelchifort", "B9X 2B7", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 114,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "79847 Cleta Summit", "South Palma", "H5T 7Q4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 115,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "57393 Kurt Greens", "Framifort", "A0O 1Z1", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 116,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "21445 Sean Route", "East Lavonfurt", "V9O 8G9", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 117,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "693 Peter Bypass", "Port Korychester", "J5E 1W0", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 118,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7616 Johnston Drive", "North Zoraburgh", "E4G 0C6", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 119,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "65126 Cordia Pass", "Paulachester", "T6Q 4W0", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 120,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9392 Dee Corners", "Hagenesville", "E5H 3T8", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 121,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "43249 Treutel Causeway", "Salvadorfort", "A2B 8U1", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 122,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "25653 Stark Lock", "West Shawn", "H8W 5G7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 123,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "940 Zemlak River", "Port Jackieview", "P2G 6R4", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 124,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "429 Runolfsson Course", "Lake Daisybury", "N9I 9L5", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 125,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6807 Kuphal Plain", "West Alvera", "E1M 8D9", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 126,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2849 Adele Fords", "Loweburgh", "V1N 9Y4", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 127,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "79712 Isaias Meadows", "North Brown", "Y6B 7L5", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 128,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "299 Scotty Estate", "Port Marquiseland", "K0V 5B9", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 129,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "67403 Nathaniel Forest", "North Rebekahmouth", "C2X 3G2", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 130,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "157 Cormier Mountain", "East Bransonshire", "E2W 0Y1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 131,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "885 Nitzsche Burg", "East Reidside", "T6N 3W5", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 132,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1010 Marisa Walk", "North Donald", "Y1V 4X2", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 133,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "42291 Maggio Keys", "New Salvatoretown", "G6G 1X4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 134,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "059 Emmerich Camp", "Port Daisystad", "H3B 9U2", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 135,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "722 Troy Alley", "Quitzonport", "H9V 5O8", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 136,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "9280 Myrna Highway", "Ratketon", "R4X 2P8" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 137,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "624 Pamela Shore", "Port Leopold", "S7F 6L7", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 138,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6457 Milan Dale", "Pietroland", "T2R 7B8", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 139,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "894 Ashtyn Locks", "Port Florencio", "B0D 2A7", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 140,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "9762 Grant Ferry", "Lake Anais", "Y1T 8C8" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 141,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "053 Dickinson Fords", "Mckennaton", "M2Y 6K0", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 142,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5564 Genesis Shore", "Hoegerfort", "E0J 5B1", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 143,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1911 Mac Mountains", "Lake Augustine", "S7O 6U0", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 144,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "60738 Murray Plaza", "North Marian", "L9L 0V5", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 145,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "580 Fletcher Gateway", "New Ledaview", "L1X 7Y6", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 146,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8111 Linnie Glen", "Roobburgh", "S2W 1X3", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 147,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "72852 Waelchi Plain", "McKenzieville", "K8B 7D1", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 148,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "33063 Madelyn Harbor", "Theresatown", "N5F 6V8", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 149,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "15719 Watsica Islands", "North Alyshamouth", "G6D 6G4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 150,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "57985 Mabel Tunnel", "Port Donna", "L4M 2D8", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 151,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "825 Dach Mews", "Port Arielle", "N4T 8L2", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 152,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3717 Stroman Harbor", "Filibertomouth", "V4L 8I5", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 153,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "59543 Fabiola Ferry", "Hicklefurt", "E7N 0S5", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 154,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2572 Bailee Park", "Bradfordmouth", "H3D 4H5", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 155,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9367 Gutmann Route", "Bergstromshire", "E7E 6U9", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 156,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "922 Cummerata Green", "Hirthefurt", "H2N 3F4" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 157,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8715 Diamond Orchard", "Giannichester", "T3O 4O3", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 158,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3319 Jaiden Ports", "Nikolashaven", "M6M 1T5", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 159,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "58228 Bryon Knolls", "Nicholausmouth", "B9X 7E5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 160,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "78514 Sipes Knolls", "East Rebeka", "C1V 4Z9", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 161,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "90975 Dion Fields", "Reingerside", "P1M 5T6", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 162,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "49789 Prudence Mountain", "South Paulburgh", "T1L 6K7" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 163,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "253 Olson Path", "Pfannerstillberg", "H2M 0G7", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 164,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "42964 Brown Street", "Zemlaktown", "H8V 4N1", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 165,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "28840 Hayden Trace", "Lake Tracy", "V3M 7A1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 166,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9623 Block Mount", "West Alene", "C7N 7V2", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 167,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2003 Jalen Point", "Port Graysonton", "J7H 6H8", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 168,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6228 Kris Cape", "Hettingerfurt", "L4O 9E9", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 169,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3036 Hayes Ferry", "West Johnnyside", "X3B 0Z4", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 170,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "737 Ferry Lakes", "Adonishaven", "B6L 4A2", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 171,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "04342 Elna Point", "Austynborough", "Y7Z 8P6", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 172,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5254 Edwina Row", "North Jayme", "V6W 3R3", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 173,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "056 Dino Cove", "Lake Emmanuel", "N8J 2W0", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 174,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9122 Queen Underpass", "Joaquinhaven", "K2N 8W8", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 175,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "970 Dane Viaduct", "Isobelfurt", "M7U 6C3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 176,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "771 Ardith Underpass", "New Therese", "A9M 3Q1", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 177,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8576 Reinhold Estate", "Veronaton", "S1F 9A8", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 178,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "50124 Klocko Springs", "Juniusland", "P1T 2D6", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 179,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2331 Bryana Bypass", "Lake Antoniaport", "L1Y 8I2", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 180,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "289 Fernando Walk", "Kevonview", "T3R 6W3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 181,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0550 Lizzie Alley", "Lutherport", "V8W 5L1", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 182,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "75782 Huel Island", "Lake Revaberg", "L7B 5S3", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 183,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1351 Conor Harbors", "Rutherfordberg", "B2P 1W9", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 184,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "78273 Gutkowski Tunnel", "Lake Zackerychester", "A7R 1B5", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 185,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "62138 Hamill Keys", "Chelseastad", "A0C 2L4", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 186,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7570 Alphonso Dale", "Port Xzavier", "J1C 0Z4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 187,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4634 Haley Meadows", "Wilkinsonfurt", "S5Q 7A6", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 188,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8063 Katelin Corner", "East Trentontown", "S3Y 7E6", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 189,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1742 Antwon Vista", "Lake Harley", "J8W 0Z0", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 190,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2895 Glover Crossroad", "Hayliestad", "M3C 6F0", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 191,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "057 Karley Inlet", "O'Keefeburgh", "G9U 6F6", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 192,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "18868 Cartwright Extension", "Ritchieberg", "P0K 0L9", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 193,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "22716 Kuhic Walks", "Port Bretview", "Y2M 7X7", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 194,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3122 Toy Coves", "Novaberg", "C0P 3D9", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 195,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "96786 Bode Stream", "Weberberg", "E0V 0P8", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 196,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "26833 Swift Canyon", "Port Emma", "Y6V 2U9", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 197,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6570 Kenna Lodge", "East Laurenmouth", "A7O 8A5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 198,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "963 Jett Hill", "Joannieville", "G6I 2W9", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 199,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2071 Yost Station", "Lake Darbyland", "G2Q 7E7", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsigneeAddresses",
                keyColumn: "ManifestId",
                keyValue: 200,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5873 Brennan Estate", "Port Ofeliahaven", "K6T 3Y1", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 1,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2322 Medhurst Overpass", "Bednarmouth", "B7W 4Q8", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 2,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0035 Gerson Centers", "Luisaport", "V9J 6T4", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 3,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "404 Mallory Lock", "Rheaside", "E1M 6U0", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 4,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "866 Kutch Villages", "Lake Mavis", "R0D 9B9", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 5,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "635 Wyman Causeway", "Aliceview", "T1F 2L0", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 6,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "89275 Howe Burgs", "Lake Gustberg", "N6B 1F6", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 7,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "11959 Chanel Pike", "New Bridgette", "Y9R 6C0", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 8,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "613 Homenick Station", "South Bridgetland", "H0Z 4F4", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 9,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "722 Cindy Port", "North Laneshire", "B1X 9H0", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 10,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "973 Schmidt Radial", "Lake Arnulfo", "M4G 4G4", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 11,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "02657 Mayer Island", "North Helenton", "K8M 6A6", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 12,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "000 Sandra Locks", "Brandofurt", "L1C 3U6", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 13,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "2230 Hyman Bridge", "North Leo", "T2T 5I2" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 14,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "063 Deckow Park", "Port Santinostad", "A8R 4R7" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 15,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "70938 Beer Bypass", "Nakiafurt", "C0S 9J4", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 16,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1705 Bode Locks", "Colemouth", "T4D 1W9", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 17,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4228 Earnestine Parks", "Wintheiserville", "B2I 4G5", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 18,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "469 Williamson Island", "Rosarioburgh", "Y8Z 9X3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 19,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "81573 Frami Valleys", "Rowlandview", "X5G 0L5", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 20,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "358 McDermott Mountain", "Harveymouth", "H0J 9Y3", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 21,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "22833 Runolfsson Route", "West Leilaniside", "H5G 4Z7", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 22,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6554 Leila Junctions", "Wiltonfurt", "B3U 9C5", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 23,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "678 Ebert Spring", "Zackeryview", "L9Q 4T5", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 24,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9717 O'Reilly Gateway", "Rockyland", "N1W 6A5", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 25,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8595 Okuneva Street", "Mellieberg", "N2V 7Y7", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 26,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "09548 Nicolas Track", "Monahanburgh", "V6Z 1R8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 27,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "041 Coleman Plain", "Darrenfort", "X9P 5Q8", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 28,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1593 Grady Circles", "Patienceshire", "P0D 9S0", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 29,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "02056 Labadie Station", "North Evangeline", "C0A 9N6", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 30,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3591 Murray Union", "Lake Alan", "M3W 2D0", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 31,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "054 Adaline Ferry", "Cummingsstad", "E3A 1R3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 32,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9293 Jeanie Green", "Lake Lucindaburgh", "V8H 8W6", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 33,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7525 Toni Parkways", "Royceview", "M0O 6T5", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 34,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "639 Lorenzo Isle", "Dickiborough", "E2A 8P2", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 35,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "373 Huel Avenue", "Port Mossie", "H2O 2T8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 36,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "860 Grimes Flats", "South Louvenia", "P7M 3D8", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 37,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "023 Walker Underpass", "East Savannaton", "X5E 6P2", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 38,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "116 Reichel Ville", "West Alexaneville", "B7G 0D2", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 39,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "411 Roscoe Road", "Quigleyfurt", "B8C 9D3", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 40,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "001 Reinger Key", "Terryshire", "R4A 3N3", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 41,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "919 Fahey Spur", "Rheashire", "X1O 8A3", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 42,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "5522 Adams Spurs", "North Chrisview", "J7U 3M7" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 43,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "216 Keebler Mill", "Schroederburgh", "L7W 1U1", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 44,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0933 Kshlerin River", "Port Bradfordborough", "K2I 5V1", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 45,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4827 Rey Heights", "Toyberg", "P2C 0N1", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 46,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7840 Samir Way", "East Gerson", "H6Q 5Z8", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 47,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "63617 Mercedes Ports", "Greenholtville", "J3P 3R3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 48,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4359 Sawayn Station", "North Nicolette", "E3X 2U4", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 49,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "010 Mose Row", "Thadshire", "G8P 8R3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 50,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "777 Declan Road", "East Wilhelminebury", "A8W 4S9", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 51,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "76927 Predovic Island", "Luettgenborough", "M8X 2A9", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 52,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "114 Ruth Villages", "Ferrybury", "V8X 1S2", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 53,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9266 Randall Mill", "Tierraville", "N4T 5U1", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 54,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "903 Kirk Fords", "Maurineview", "K1R 4N9", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 55,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4457 Khalil Inlet", "Lake Vito", "H1Y 8L5", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 56,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "791 Koch Plains", "Kundetown", "C8V 0I1", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 57,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2755 Bogan Roads", "Carolinefurt", "H2W 6D7", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 58,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5070 Kertzmann Greens", "Arnoldoburgh", "T7P 0V8", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 59,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "3029 Bogan Dale", "Agustinaburgh", "R3I 6L9" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 60,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8529 Keeling Rapids", "Quitzonchester", "A8B 0H3", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 61,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "00386 Elton Bypass", "Kilbackland", "B3H 3F0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 62,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2082 Bertha Key", "New Damion", "H7V 1F6", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 63,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9455 Maiya Prairie", "New Juniorchester", "G1A 0E9", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 64,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "07384 Carmelo Land", "East Austin", "T3T 9J1", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 65,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "893 Orlando Mountain", "Crookschester", "A2X 3L3", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 66,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1854 Aliza Skyway", "Borerhaven", "A7A 9B5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 67,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5665 Christiansen Key", "Lake Rayview", "L7T 8Y9", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 68,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "297 Klocko Valley", "Alishire", "T8B 6S5" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 69,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4616 Jaden Groves", "Watsicaburgh", "C0D 1L6", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 70,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "94149 Larissa Tunnel", "Shanelmouth", "G0L 8X6", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 71,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "830 McLaughlin Burgs", "Hayesfurt", "N0Q 2R8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 72,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1001 Gutmann Divide", "Lake Arjunmouth", "G7D 2L5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 73,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "13927 Johns Fork", "Port Ferne", "P4V 2R5", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 74,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "773 Corkery Glen", "Lake Sim", "V1I 1W4", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 75,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "48879 Bergstrom Springs", "Ronshire", "N8A 5J4" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 76,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "4800 Toni Parks", "East Imamouth", "E6S 5F2" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 77,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5897 Parker Rapid", "Cartermouth", "K2P 7Y4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 78,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "7225 Rippin Meadows", "Vickieville", "J0D 6K5", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 79,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "11461 Streich Ford", "New Thadmouth", "V7N 7O0", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 80,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "76372 Eldora Street", "Christyland", "L7R 5P3" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 81,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "0444 Jaylin Course", "New Vicenta", "M8T 3O3" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 82,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4470 Selina Summit", "Carmelaton", "C1S 8D7", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 83,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "466 Breanne Valleys", "New Samantha", "K0E 2W2", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 84,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "39326 Marley Garden", "Mrazfort", "P5J 6Z3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 85,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1277 Rasheed Cape", "Runolfssonhaven", "L0V 7N5", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 86,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "87880 Denesik Vista", "Ratkemouth", "M0H 1F6", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 87,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "99339 Kim Fork", "Reillyhaven", "Y1N 2F9", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 88,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2167 Maximus Streets", "Lake Michael", "V3Y 9A9", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 89,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "218 Jaunita Trail", "West Emory", "A8F 3U7", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 90,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "592 Renner Grove", "North Abigaylechester", "E5I 1D8", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 91,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "7348 Mallory Lights", "Rodrigobury", "N1N 2Y3" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 92,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "088 Ortiz Estate", "North Amara", "R0L 9G0", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 93,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1427 Velda Bypass", "North Reyes", "E3X 5Y3", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 94,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "03701 Moen Turnpike", "North Makenna", "L2K 2P8", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 95,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "74483 Hand Islands", "Lebsackport", "K8L 9D8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 96,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "34829 Benton Lake", "Mohrside", "X6I 2G1", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 97,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "750 Powlowski Island", "New Orval", "C7F 0S8", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 98,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "831 Keely Drives", "Janessachester", "L1S 9G7", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 99,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "335 Monahan Station", "South Jacintheville", "T9N 3G8", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 100,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "203 Fidel Drive", "Candelariostad", "E4M 7X0", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 101,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "68736 Cummerata Pass", "Stantonshire", "L0E 9I4", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 102,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "4572 Baumbach Ridge", "Faeland", "L0B 9X1" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 103,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "4818 Rossie Lodge", "North Eileen", "J4M 9M8" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 104,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "62885 Archibald Meadow", "Herminialand", "S9X 1O2", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 105,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "148 Napoleon Lodge", "Keeleyshire", "N0L 0I4", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 106,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "61800 Lina Camp", "Kshlerinmouth", "J2G 6W3", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 107,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2558 Jayde Cliffs", "Port Maudiestad", "E3B 9U6", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 108,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2967 Humberto Bridge", "Lake Peter", "Y8P 0S5", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 109,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "10811 Zulauf Walk", "East Dimitrifort", "S0H 7M8", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 110,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "056 Littel Forest", "Leliaborough", "L0O 0P1", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 111,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "715 Sarah Locks", "Weissnatberg", "H2F 7N1", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 112,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2457 Bernhard Passage", "Schroederfort", "R4E 4O4", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 113,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1537 Hudson Ridges", "North Bryana", "L4F 1K2", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 114,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "37125 Stacey Camp", "East Oren", "E1P 8B0", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 115,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "66032 Purdy Forges", "Domingomouth", "E4A 6Y0", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 116,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "134 Sabina Isle", "Flaviohaven", "B3G 3F6", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 117,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0013 Osinski Station", "Jaydenfort", "A8A 0A7", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 118,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "59311 Eric Fall", "Port Shanelle", "J9O 3H1", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 119,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "972 Orpha Skyway", "Kohlertown", "G6E 3O0", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 120,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "99565 Olson Summit", "Baumbachborough", "S8L 1C3", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 121,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "61072 Renner Mountains", "North Greggview", "C3P 9H7", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 122,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "1353 Jerrell Squares", "North Destinyberg", "G3C 1D7", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 123,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "688 Keon Shoal", "Katelynfort", "T5J 8Q2", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 124,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0071 Lynch Heights", "MacGyvermouth", "L8M 9I0", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 125,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "983 Dejuan Mall", "Koeppchester", "K7W 3P9" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 126,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4938 Kassandra Well", "West Estefania", "P0V 0M5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 127,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "1247 Kuhic Shoal", "North Evieton", "M5U 7A7" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 128,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "94111 Austen Mills", "Lizethbury", "G6S 0N3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 129,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "92070 Carole Shoals", "North Angelachester", "A1O 9T6", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 130,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "92088 Lubowitz Locks", "Gleasonfurt", "N1A 3N7", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 131,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5692 Schuyler Orchard", "East Annabel", "P5U 4P2", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 132,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "47363 Timmy Divide", "Cummerataville", "B2T 2V0", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 133,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "76594 Orion Keys", "Pricebury", "L6J 4Y3", "YT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 134,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "39664 Lea Isle", "MacGyverfurt", "K7R 2N4", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 135,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "17193 Cielo Meadows", "Hartmannburgh", "G7H 7K0", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 136,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "20767 Metz Radial", "North Summerport", "M7V 1F5", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 137,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2236 Joesph Manor", "Port Shad", "R6L 8N2", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 138,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "848 Demetris Hollow", "Rempelside", "P1O 9M4", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 139,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "92124 Schmitt Lakes", "Vandervortton", "H8C 5I3", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 140,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "679 Jamel Light", "New Shanna", "G9S 3G3", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 141,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9986 Ferry Pike", "Danielmouth", "Y6C 5K1", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 142,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "8550 Dicki Gateway", "Bettieberg", "P7Z 7K7" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 143,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "78568 Kaitlyn Wall", "North Huldaborough", "R9U 3S4", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 144,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "7213 Effertz Orchard", "Lake Minamouth", "A0V 7K4" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 145,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "697 Wilderman Parks", "Smithville", "R3A 7O3", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 146,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "82360 Huels Greens", "New Beverlytown", "G1E 6Z6", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 147,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "840 Coy Loop", "East Eveline", "M3J 8X6", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 148,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "627 Abigail Trafficway", "South Jacyntheberg", "A5R 5G2", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 149,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "287 Rhiannon Islands", "New Maestad", "E5V 2M8", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 150,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "952 Rogahn Point", "West Tremayne", "T0Q 7U7", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 151,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "015 Becker Trafficway", "Blicktown", "E2F 6J4", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 152,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "04427 Roman Square", "Langoshchester", "S0L 6C8", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 153,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "410 Brown Creek", "New Letaton", "E5S 3A0", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 154,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6335 Savanna Harbors", "Bertramfort", "N4O 3L3", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 155,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "51775 Kirlin Islands", "Bechtelarmouth", "P3H 4Z3" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 156,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "980 Maci Land", "Deshaunfurt", "G0H 7W1", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 157,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "85534 Stephon Parkways", "Doyleville", "J1W 9D1", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 158,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "5887 Boyle Fords", "Brianside", "C4R 1O2", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 159,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "13058 Murphy Lake", "East Fredmouth", "C6O 0R0", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 160,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "970 Nolan Garden", "Madysonshire", "S8C 1T3", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 161,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "657 Eula Well", "Lake Agustin", "C1X 1K3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 162,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "991 Demarcus Plain", "Lake Loymouth", "Y8F 1T5", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 163,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "580 Aracely Mill", "Lehnerfort", "N4U 0T1", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 164,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "47162 Jakubowski Street", "Port Stellashire", "N8O 0X6", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 165,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "340 Conn Plaza", "Lake Velva", "A4L 0E9", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 166,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0868 Tyrel Prairie", "North Leone", "Y8O 9P5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 167,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "24078 Emory Circle", "Mitchellview", "P4O 2T0", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 168,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "07592 Lehner Creek", "South Richard", "X7M 0H6", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 169,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "559 Nona Haven", "Joanneburgh", "G5S 9F5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 170,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "53989 Treutel Corners", "Sylviashire", "Y0V 9F2" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 171,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4912 Reynolds Viaduct", "Lake Tierra", "V8H 0I8", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 172,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2757 Makenzie Parks", "East Maximus", "T9J 6N8", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 173,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "6174 Durgan Roads", "New Matttown", "E6W 8X9", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 174,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "15015 Feil Throughway", "Connermouth", "J2A 1P0", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 175,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "6115 Ila Bypass", "North Jewelchester", "K7Q 3J6" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 176,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "59719 Tremblay Passage", "Maynardburgh", "M9Y 5F2", "QC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 177,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "0418 Wuckert Keys", "Keaganchester", "A0I 8K8", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 178,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "542 Akeem Parkway", "Bayerview", "C1D 6P5", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 179,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8549 Bailey Spurs", "Gottliebfort", "A5R 6O5", "MB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 180,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "613 Willis Spur", "Kemmerstad", "J4U 2X2", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 181,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "559 Jared Divide", "Lake Hattieburgh", "K5B 2O1" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 182,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "793 Marcelo Mission", "Port Ferneview", "P3E 6C9", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 183,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "395 Rogers Mountains", "D'Amoreland", "G2A 3M0", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 184,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "307 Dibbert Garden", "New Mabelle", "G9Z 2S3" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 185,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "201 Hickle Neck", "New Bradberg", "G9B 4C1", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 186,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9388 Presley Stravenue", "Dickiborough", "M6I 5F8", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 187,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4517 Brandi Fork", "East Clara", "V1C 7Y1", "NT" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 188,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2821 Favian Coves", "Brionnaside", "V5R 6L4", "NB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 189,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "4776 Petra Port", "Lake Henderson", "K3E 4H1", "SK" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 190,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "464 Della Knoll", "Harveyshire", "K6G 0V8", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 191,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "2732 Johnson Motorway", "South Addisonfurt", "J5K 5N0", "AB" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 192,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "3723 Yolanda Turnpike", "Ritchieborough", "J8U 2Q3", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 193,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "9768 Chesley Lock", "Waelchiberg", "N7A 2L8", "NU" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 194,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "44143 Helga Wells", "New Dasia", "E3O 7E5", "ON" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 195,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "45078 Stanton Lodge", "South Ernie", "C2R 1A6", "NL" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 196,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "264 Ernie Pass", "East Cathrine", "C8V 4K6", "BC" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 197,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "6972 Harris Landing", "Oberbrunnershire", "L7M 5H7" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 198,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "65614 Olen Cliff", "South Maxime", "A1M 7S3", "PE" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 199,
                columns: new[] { "AddressLine1", "City", "PostalCode", "Province" },
                values: new object[] { "8457 Zulauf Street", "New Eleonore", "P0J 7U8", "NS" });

            migrationBuilder.UpdateData(
                table: "ConsignorAddresses",
                keyColumn: "ManifestId",
                keyValue: 200,
                columns: new[] { "AddressLine1", "City", "PostalCode" },
                values: new object[] { "739 Sipes Harbors", "New Eliasburgh", "V9B 0L2" });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 103 },
                    { 2, 118 },
                    { 4, 113 },
                    { 2, 112 },
                    { 2, 111 },
                    { 3, 109 },
                    { 3, 108 },
                    { 3, 107 },
                    { 2, 102 },
                    { 3, 101 },
                    { 2, 99 },
                    { 4, 98 },
                    { 4, 97 },
                    { 1, 96 },
                    { 3, 95 },
                    { 1, 93 },
                    { 2, 90 },
                    { 3, 88 },
                    { 3, 87 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 2, 86 },
                    { 3, 85 },
                    { 3, 83 },
                    { 1, 82 },
                    { 4, 81 },
                    { 1, 80 },
                    { 1, 79 },
                    { 4, 119 },
                    { 2, 120 },
                    { 4, 121 },
                    { 1, 123 },
                    { 2, 161 },
                    { 4, 160 },
                    { 2, 159 },
                    { 2, 158 },
                    { 4, 156 },
                    { 4, 155 },
                    { 2, 152 },
                    { 4, 150 },
                    { 4, 149 },
                    { 2, 148 },
                    { 1, 146 },
                    { 4, 145 },
                    { 3, 77 },
                    { 3, 144 },
                    { 3, 139 },
                    { 4, 138 },
                    { 1, 137 },
                    { 2, 136 },
                    { 2, 134 },
                    { 1, 131 },
                    { 3, 130 },
                    { 4, 129 },
                    { 4, 127 },
                    { 4, 126 },
                    { 2, 125 },
                    { 2, 124 },
                    { 1, 142 },
                    { 3, 75 },
                    { 2, 74 },
                    { 4, 72 },
                    { 2, 35 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 2, 34 },
                    { 4, 33 },
                    { 2, 32 },
                    { 4, 31 },
                    { 4, 30 },
                    { 2, 29 },
                    { 2, 28 },
                    { 4, 27 },
                    { 1, 26 },
                    { 3, 25 },
                    { 3, 24 },
                    { 3, 37 },
                    { 1, 22 },
                    { 3, 19 },
                    { 3, 18 },
                    { 4, 17 },
                    { 4, 16 },
                    { 2, 15 },
                    { 1, 14 },
                    { 1, 13 },
                    { 4, 11 },
                    { 4, 10 },
                    { 2, 9 },
                    { 4, 7 },
                    { 3, 6 },
                    { 4, 21 },
                    { 3, 163 },
                    { 4, 38 },
                    { 3, 41 },
                    { 2, 71 },
                    { 4, 70 },
                    { 4, 69 },
                    { 3, 68 },
                    { 1, 67 },
                    { 3, 66 },
                    { 4, 65 },
                    { 4, 63 },
                    { 3, 62 },
                    { 4, 61 },
                    { 2, 60 },
                    { 4, 59 },
                    { 4, 39 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 1, 58 },
                    { 2, 54 },
                    { 4, 53 },
                    { 2, 52 },
                    { 1, 51 },
                    { 1, 50 },
                    { 3, 49 },
                    { 4, 48 },
                    { 1, 47 },
                    { 2, 45 },
                    { 2, 44 },
                    { 2, 43 },
                    { 4, 42 },
                    { 1, 56 },
                    { 3, 4 },
                    { 1, 164 },
                    { 3, 168 },
                    { 8, 11 },
                    { 8, 19 },
                    { 11, 22 },
                    { 7, 31 },
                    { 8, 40 },
                    { 14, 45 },
                    { 13, 48 },
                    { 12, 56 },
                    { 10, 65 },
                    { 12, 4 },
                    { 11, 70 },
                    { 7, 85 },
                    { 13, 88 },
                    { 14, 92 },
                    { 12, 101 },
                    { 8, 105 },
                    { 9, 108 },
                    { 7, 117 },
                    { 11, 125 },
                    { 3, 165 },
                    { 8, 76 },
                    { 2, 200 },
                    { 3, 3 },
                    { 4, 198 },
                    { 1, 170 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 3, 171 },
                    { 1, 172 },
                    { 1, 169 },
                    { 3, 175 },
                    { 4, 176 },
                    { 2, 178 },
                    { 3, 179 },
                    { 1, 180 },
                    { 1, 181 },
                    { 3, 174 },
                    { 4, 184 },
                    { 3, 183 },
                    { 2, 197 },
                    { 3, 196 },
                    { 4, 195 },
                    { 1, 199 },
                    { 1, 191 },
                    { 3, 190 },
                    { 2, 189 },
                    { 1, 188 },
                    { 3, 194 }
                });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "Name" },
                values: new object[] { "H6-CX5", "Lubowitz - Kuvalis" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "Name" },
                values: new object[] { "16-I16", "Ankunding, Greenfelder and Ryan" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "Name" },
                values: new object[] { "89-K38", "Hirthe Group" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "Name" },
                values: new object[] { "4D-31Z", "Considine, Stracke and Schmidt" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "Name" },
                values: new object[] { "5J-H59", "Turcotte - Crooks" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "Name" },
                values: new object[] { "72-I0T", "Kautzer - Pfannerstill" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "Name" },
                values: new object[] { "58-7PV", "Kilback - Legros" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Name" },
                values: new object[] { "6J-O14", "Ryan - Kihn" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "Name" },
                values: new object[] { "MU-EZ7", "Dickens LLC" });

            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE-OZ7", "Hauck Inc" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Incidunt alias recusandae cumque est.", 9, 3329m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ea quisquam eveniet doloremque blanditiis porro cupiditate occaecati.", 176, 4190m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quam ipsum itaque quam sunt deserunt aut earum provident quo.", 173, 12172m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Perspiciatis dolorum corporis et.", 179, 7202m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nulla sint ut sint repudiandae consequatur in quis sapiente.", 107, 1829m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nihil qui eum impedit officiis aut nostrum animi.", 79, 11870m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Incidunt aut voluptates et non laborum consequuntur.", 49, 11530m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Cupiditate odio ut.", 107, 9402m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Debitis aut blanditiis non minima sit tempore occaecati.", 137, 4869m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quam dolorem in ab ipsum maiores sint impedit ipsum consequatur.", 137, 4171m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Illo magni qui magni autem ut.", 104, 14219m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Molestias earum est sit magni natus sit sunt.", 168, 2121m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Unde soluta repellat impedit excepturi dolore sequi.", 46, 11948m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut omnis sit.", 164, 13383m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Non deleniti reiciendis aut quo ut est ipsa.", 35, 11885m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eius qui aut enim alias quo enim modi.", 143, 881m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Doloremque consequatur repellat quam.", 191, 7971m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quasi nihil eveniet.", 120, 17429m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nihil illo dolore.", 194, 8037m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nihil voluptatibus est dignissimos atque quidem.", 124, 5247m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ipsa quia nulla quisquam voluptatem a ratione sint.", 27, 8124m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut ipsa quam distinctio saepe illum ratione eaque.", 139, 15547m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nemo officia et dignissimos itaque.", 191, 5121m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "In suscipit voluptatibus dignissimos id blanditiis illum accusantium sunt.", 67, 8455m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Id veritatis quibusdam veritatis.", 31, 12100m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sint et iste vitae.", 176, 19266m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eaque non nulla quia voluptates autem voluptate qui.", 25, 19241m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut ratione eius voluptas officiis praesentium.", 162, 176m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dicta et autem sit quis at.", 187, 11839m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Incidunt consequatur minima sequi quam.", 61, 13037m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit et cum.", 25, 8200m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Deleniti autem incidunt sed nihil labore.", 46, 16879m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ea molestiae fugit.", 184, 4118m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quisquam eaque ex voluptas quas sint qui.", 24, 17763m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Qui aperiam minima qui fugiat et eligendi.", 62, 18947m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur adipisci possimus id vitae exercitationem.", 3, 19974m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Vel quia quae est voluptatem accusantium aliquid minima totam.", 77, 9148m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Distinctio quis laborum modi.", 83, 18035m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Occaecati enim omnis autem aut enim sed ad quos dolorem.", 66, 3892m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempore sint est doloremque consequatur.", 163, 19324m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quam molestiae iure enim fugit ipsa.", 39, 8516m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem ut perspiciatis aut aliquid sit.", 36, 4231m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Culpa enim unde voluptatibus eum.", 194, 7633m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Autem suscipit eum nisi qui alias.", 154, 7595m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem et velit nobis.", 4, 2919m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Mollitia non non dicta nisi fugit est magni non ipsa.", 23, 6877m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut nesciunt nam dolorum dolor fugiat dicta voluptate occaecati adipisci.", 28, 6394m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ea illum sit occaecati ut dolorem consequuntur exercitationem.", 57, 19996m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Est vel sint ratione consequatur cupiditate dolor maiores ex qui.", 103, 12146m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Saepe accusantium voluptas qui fugiat cupiditate nobis non.", 4, 812m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et nam consequatur eveniet qui ipsum soluta eos ad.", 123, 3439m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur quam in praesentium reprehenderit commodi iusto in.", 140, 19508m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ipsa at debitis iste doloribus aut.", 138, 153m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Deleniti laboriosam sed unde dolorum at quam ut.", 136, 6318m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolores et ea laboriosam laudantium est.", 34, 3029m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quis in et ex consequatur molestias culpa ipsam.", 197, 556m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Necessitatibus dolor quia iusto.", 114, 14554m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Velit quam ea ducimus libero expedita repellat labore.", 113, 10183m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eius ut veritatis nesciunt aut.", 17, 4940m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "In fugit ducimus soluta.", 95, 11350m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Minima perspiciatis doloribus velit.", 168, 19916m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Temporibus ex libero atque voluptas.", 178, 12543m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Exercitationem voluptatem repellat distinctio consequatur ut repellendus.", 196, 6645m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aperiam dolore ex velit porro incidunt eaque.", 194, 1309m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Exercitationem et atque.", 165, 1848m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Nisi ut est necessitatibus minima aut dolor recusandae.", 124, 4245m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem voluptatem nihil magni error voluptates sit at nemo omnis.", 191, 6507m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolor eligendi voluptatibus qui vero facere sit.", 93, 2655m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ab aut at omnis ut vel neque doloremque molestiae.", 157, 1236m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum aperiam consequuntur ducimus saepe sit sint laborum voluptatem.", 45, 10421m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Vitae amet hic nam.", 56, 12929m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Perferendis reiciendis laborum repellendus laboriosam rerum.", 40, 14373m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestiae ratione consequatur.", 118, 515m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Tenetur sit quo consequuntur nostrum aperiam.", 23, 18930m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Fugiat molestias vitae culpa.", 57, 2221m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut et temporibus pariatur.", 42, 14729m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Molestiae aspernatur inventore possimus.", 25, 16842m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia facere reprehenderit ut est iusto veritatis est natus.", 179, 16882m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quae qui laudantium occaecati ut.", 54, 17226m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iste amet velit.", 134, 1604m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut dolorum a temporibus repellendus quasi.", 158, 16525m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi consequatur quis quis consequatur aut.", 56, 12357m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Praesentium illo molestiae vel ut quam.", 115, 4741m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut sunt recusandae sit aliquam ex qui.", 15, 13850m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Laudantium rerum enim illum reprehenderit quasi praesentium quis aut.", 33, 17481m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ea est voluptate sed aut excepturi similique aut quaerat.", 96, 3958m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatibus qui qui quis sequi.", 149, 4953m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Nulla repudiandae fugit id unde labore est.", 79, 15378m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quis et ut autem labore distinctio eum architecto.", 63, 7594m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nihil voluptatum asperiores aut expedita.", 130, 8065m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Saepe qui delectus aliquam sit.", 11, 9454m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ipsam ullam sit aut ea.", 72, 201m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Recusandae animi et ullam.", 147, 2494m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Maiores quis voluptatem atque autem autem qui ad voluptate.", 143, 7299m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Rerum doloribus consequuntur ratione necessitatibus est facilis id nemo facilis.", 59, 11565m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Magni quaerat quod voluptates minima vel accusantium exercitationem.", 146, 16255m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Reprehenderit doloribus ea excepturi quasi et aperiam nemo.", 169, 19940m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum reiciendis autem.", 17, 18127m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Minima odit vero et qui similique eos.", 123, 13954m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptates non voluptatem et et ut rerum odio.", 130, 7114m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sequi asperiores quae sint et vitae facilis quae consequuntur.", 110, 2311m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vitae quia laborum soluta alias cum.", 35, 8468m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptas consectetur dignissimos voluptatum.", 93, 5070m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestiae in vel dolor voluptate non occaecati rerum dolor explicabo.", 71, 8647m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut maxime qui rerum modi vel earum.", 157, 16366m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sed similique officiis ut nihil officia quo veritatis molestias ea.", 95, 16622m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et vitae incidunt odio atque velit rerum non molestias.", 147, 13901m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Possimus et repellat nisi rerum voluptatem.", 25, 1434m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Facilis porro ab.", 36, 18114m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Deserunt molestias id.", 117, 3091m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ex commodi ad id at.", 150, 1786m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Non fugiat quo quo cupiditate a modi voluptas voluptas.", 62, 13927m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Est nam accusantium reiciendis voluptatem ad et.", 1, 15254m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Pariatur ea aliquam iste qui corporis reiciendis.", 67, 1583m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatibus dolor recusandae perferendis id dolor deleniti ab assumenda possimus.", 13, 19100m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et sit dolorem tempore fugiat repellat voluptatibus odit.", 58, 16378m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit sint enim ipsam iusto ratione asperiores.", 128, 4800m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cupiditate nam est sunt ducimus quasi.", 115, 9853m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Beatae distinctio qui rerum alias tempore fugit earum qui tempora.", 51, 18873m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Placeat sint animi corrupti enim unde qui exercitationem.", 42, 6171m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Alias autem aut sapiente consequatur.", 132, 12398m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Asperiores similique tempora eligendi in.", 189, 3027m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Consequatur voluptatem in rerum dicta perferendis ut.", 18, 18694m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Expedita quod itaque expedita eius voluptatibus quo harum nostrum.", 132, 19639m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Vitae at similique qui est iure est voluptate error nobis.", 175, 4381m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quaerat nostrum tenetur impedit velit.", 151, 18199m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Mollitia incidunt rerum ipsam dolorem est sint laboriosam dolorem non.", 45, 9891m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odit dolore dolor aliquam.", 23, 8721m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Doloremque est possimus hic voluptate.", 21, 208m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Consequuntur nesciunt et explicabo.", 60, 14703m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Veritatis omnis saepe quasi deserunt perspiciatis sunt distinctio.", 97, 6108m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Excepturi cupiditate veniam eos at ut.", 68, 18655m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut incidunt consequatur nemo sequi dignissimos quia eos.", 131, 8727m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolorum neque ea voluptatem.", 120, 6973m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum est minima consequatur animi tempora.", 110, 6578m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia inventore ea ut dolor molestias.", 70, 17199m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Vero itaque ratione.", 114, 10323m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quae quibusdam omnis in deserunt ex doloremque ut nulla.", 130, 19027m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sed sapiente natus aut et sed voluptas et ad illum.", 159, 1902m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Vitae sed voluptas quia quod nobis officia fuga.", 37, 9694m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Perferendis quis ut eligendi.", 147, 4492m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum optio beatae delectus et occaecati minus deleniti doloremque error.", 153, 13726m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatum fugit et.", 16, 12353m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolor nobis esse ut minima ea suscipit eos.", 26, 12189m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aspernatur omnis quasi.", 1, 1317m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et rem dolore a dolores eius aut.", 170, 13758m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Perferendis exercitationem veniam velit dolorum blanditiis beatae optio cumque.", 128, 1538m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Autem laboriosam quia omnis dignissimos quasi exercitationem et quo numquam.", 157, 3378m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia dolores fuga dolore.", 161, 16070m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ducimus odio non ipsa sint doloribus quaerat laborum velit.", 154, 10341m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ea consequatur omnis hic culpa et doloremque.", 178, 13543m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Culpa officia reprehenderit a non sunt nulla.", 2, 6048m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ratione quisquam tenetur natus maxime.", 92, 5334m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eius odio magnam aut modi molestiae voluptas assumenda assumenda eaque.", 82, 11450m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et officia ut et.", 80, 4239m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et vero fugit rem recusandae.", 3, 8069m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Consequatur tenetur impedit eum aliquid quam praesentium suscipit.", 137, 4762m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Veniam laboriosam quas cum vitae.", 95, 10738m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Hic ullam commodi ipsam quis quo commodi dolores natus.", 61, 10401m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Omnis repudiandae et facere quia neque natus.", 109, 12338m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et est laudantium voluptatum.", 110, 8412m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Non maiores odit dicta et officiis est sed labore.", 15, 11113m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolorem aperiam optio aliquid distinctio numquam suscipit quaerat qui atque.", 128, 4805m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aspernatur culpa possimus.", 47, 1768m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nam dolorum quis hic dolores et.", 13, 19762m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Exercitationem odio est dolorem rerum delectus quam enim dolorem.", 20, 12451m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aperiam eos aut modi voluptatibus consectetur nobis.", 7, 4765m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem quo blanditiis fugiat quidem.", 166, 3601m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Autem possimus officiis quia ex sapiente omnis est.", 11, 16321m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Distinctio perferendis et beatae ad consequuntur.", 139, 1172m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cumque qui illum sit maiores libero sequi.", 77, 8096m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut eos fugiat quisquam.", 44, 9527m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Saepe autem autem illum aut.", 141, 2060m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Soluta nam commodi nihil est ratione molestiae repellendus ratione.", 106, 7388m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quibusdam minima eius dignissimos ea culpa molestiae voluptatum necessitatibus consectetur.", 5, 16164m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Error quos cumque dolorem provident vitae omnis voluptatibus iusto inventore.", 18, 11542m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempore commodi exercitationem ut voluptatem qui rerum modi corporis.", 42, 1895m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et error consequuntur repudiandae.", 176, 16174m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Unde vel et exercitationem dolor.", 108, 7676m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ab sint dignissimos repudiandae quia quos.", 54, 4947m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Animi debitis omnis.", 100, 16193m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ad atque a est.", 18, 19953m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odit quo voluptatum natus sunt quibusdam.", 34, 14468m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nihil natus et.", 59, 12224m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Laudantium corrupti a necessitatibus quis ea error molestiae explicabo autem.", 7, 8961m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sunt molestiae et excepturi excepturi vitae illo sequi et.", 142, 16926m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ut quia nihil quibusdam sequi ipsam rerum.", 21, 2941m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Officiis et et quisquam deleniti ut quo.", 37, 14924m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et pariatur voluptate suscipit corporis ipsa molestiae optio nulla.", 124, 6879m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Debitis qui accusamus molestiae deleniti.", 198, 16425m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nostrum recusandae consequatur deleniti asperiores ut.", 111, 5003m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Corporis et laborum voluptas voluptates.", 136, 3548m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolore reiciendis odit explicabo ipsam debitis ut nihil aut molestiae.", 197, 8902m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cum ducimus cumque debitis explicabo.", 166, 11696m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Corrupti quaerat qui sunt facilis saepe nemo.", 9, 13628m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum cum explicabo ut praesentium.", 184, 14955m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Similique totam ut qui omnis et iusto exercitationem sit voluptatem.", 166, 2005m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolores nesciunt sed dolores sapiente.", 84, 8717m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptatem repellendus placeat.", 68, 2502m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Error eligendi fugit laboriosam repudiandae dolores molestias dolore magnam vero.", 174, 16122m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Doloremque voluptas officia tenetur repellendus cumque.", 11, 9792m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Id sit est ipsum et vel perferendis est.", 41, 5311m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "In et quo amet.", 52, 2871m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Description", "Quantity", "State" },
                values: new object[] { "Nemo quisquam quibusdam qui.", 7658m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et occaecati et in.", 17, 9791m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ratione quaerat qui iste dolorem non laboriosam omnis sequi doloribus.", 89, 6087m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Error quo ut quis eos et.", 39, 14200m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ad alias alias eos.", 31, 3072m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Itaque officia facere.", 78, 17864m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eius assumenda nihil fuga.", 168, 19127m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Impedit at error iusto eos reprehenderit omnis.", 68, 13760m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Fugiat velit enim.", 108, 16449m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Architecto aut placeat animi natus dolor nihil sunt excepturi voluptatem.", 73, 4586m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ullam illo tempore beatae velit asperiores.", 10, 4105m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum similique iusto et.", 173, 10036m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Id aut sapiente officiis nobis ut libero.", 23, 3480m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ad et ut voluptas dolor praesentium omnis ut.", 141, 17399m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Autem at et quo illum doloribus.", 10, 6128m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Explicabo quibusdam qui tempora.", 17, 6436m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatum aut assumenda totam aperiam quisquam dolor dicta nulla facilis.", 129, 10385m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Fugit sit praesentium fugit sed architecto aut tempora aut est.", 13, 13462m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quo alias voluptas nihil tenetur soluta dicta sit.", 43, 13556m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "In enim quibusdam qui ex quas fugit corporis.", 164, 11396m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Rerum possimus optio commodi minus.", 41, 14317m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Harum eius corrupti non doloremque fugiat repellendus.", 171, 280m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quod aut eius harum natus iusto nisi ut aperiam.", 118, 18917m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Corrupti ipsam consequatur dolores nobis.", 152, 9954m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et exercitationem vitae totam.", 183, 15723m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Inventore sit quisquam qui aut sequi aut vero ut atque.", 181, 13760m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut totam est voluptate ipsum repudiandae ut maiores.", 154, 16168m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Debitis atque beatae aperiam quidem.", 63, 12669m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem laboriosam culpa rerum.", 96, 1070m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Debitis vel quia voluptatem nemo quas autem ipsa qui aperiam.", 67, 18286m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatibus illo ea expedita reiciendis ut cum reprehenderit.", 77, 11631m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Enim sit impedit sit consequatur et iure.", 33, 19459m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptas deserunt repudiandae minima pariatur voluptatem non.", 133, 9025m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui rerum optio sed doloribus ut accusantium molestiae iusto.", 129, 4090m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Repellendus provident et omnis tempora saepe quidem.", 135, 2547m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui enim qui.", 123, 12347m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Excepturi qui odit amet voluptatibus numquam eos nulla explicabo.", 55, 12741m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ut in hic illo iusto.", 139, 2118m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odio aut consequatur.", 164, 15102m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Blanditiis deleniti architecto inventore.", 159, 8503m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Temporibus aperiam et pariatur corrupti voluptatem laudantium eaque illo.", 36, 13356m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Illum tempora vitae placeat aut ea eum.", 39, 7443m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Deleniti adipisci quia aut harum quaerat nihil aliquid dignissimos.", 35, 13187m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut porro quam voluptatem quod reiciendis vel accusamus.", 69, 5123m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est quis quam omnis nemo dolor tempore tempore.", 17, 5330m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Possimus est dolorem nesciunt modi voluptates.", 12, 15943m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quia qui est odio est itaque nisi harum et similique.", 5, 16268m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Asperiores minima illo vitae vero laboriosam sed exercitationem.", 141, 4470m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Molestiae assumenda voluptatem omnis nihil laudantium quidem.", 47, 17161m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Occaecati ducimus delectus debitis earum.", 52, 14892m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Sint voluptatem reiciendis consequatur et consequatur sequi totam repellendus ut.", 41, 16811m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem ad natus voluptatem.", 10, 16692m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Suscipit necessitatibus voluptatem quam veniam voluptates error voluptas beatae.", 200, 10213m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Pariatur et nihil voluptatem dignissimos neque corrupti temporibus et libero.", 94, 12537m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Optio esse totam suscipit modi rem est at id amet.", 200, 17579m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quae magnam est vel quo harum magni deleniti.", 54, 12067m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Atque autem animi odio voluptatibus nulla vel explicabo.", 71, 15681m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Est ut quo.", 98, 11322m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Fuga autem asperiores sunt accusamus commodi error.", 103, 18742m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Vitae quis earum qui odio ex sequi ad mollitia quaerat.", 191, 11801m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Neque rerum eaque asperiores dolor esse explicabo vero quam.", 23, 12178m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nesciunt sint voluptatem in quas ipsa ea accusantium aliquam.", 67, 2519m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi repellendus expedita eos minima quas ea exercitationem eum sint.", 198, 3483m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut explicabo labore libero praesentium odio nisi.", 90, 8808m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eos iure voluptates cupiditate ducimus iste.", 127, 2782m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quo voluptatibus velit eos.", 45, 1804m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Rerum quas minima.", 133, 667m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem nisi quisquam eligendi qui quae ut.", 199, 18199m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Pariatur voluptatem necessitatibus voluptatem rerum ea est quae culpa magnam.", 90, 16156m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Harum odit debitis exercitationem dolor sequi fuga.", 47, 9433m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Recusandae ratione hic.", 100, 3463m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et laborum aliquam voluptatem.", 72, 16483m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sed consequatur et ut voluptatum harum aut eaque optio.", 45, 18902m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Autem consequatur ullam possimus eveniet et beatae.", 80, 3331m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptatem pariatur qui rem aut et eligendi cumque.", 55, 15087m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sint ratione dolores rerum omnis quaerat.", 3, 19619m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cupiditate eius blanditiis nemo eligendi quis temporibus nulla earum.", 191, 15499m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eos asperiores provident pariatur.", 19, 16892m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum deleniti rerum eius nam.", 77, 2822m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Hic hic qui nisi iure aut.", 86, 7695m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut adipisci dolorem est velit voluptatem qui totam.", 138, 3399m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Architecto dolorem placeat voluptatem quia nihil harum reprehenderit id error.", 111, 7235m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptas praesentium dolores nam.", 97, 10047m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolores aliquam debitis.", 168, 17210m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "At nam enim natus quaerat.", 146, 4711m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Exercitationem et laudantium ducimus eos.", 127, 12249m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Voluptatem deserunt corporis officia ut et et accusamus dolorem.", 154, 15450m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quam rerum eum.", 45, 11650m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia voluptas amet expedita expedita ab qui voluptatem iste veniam.", 48, 2522m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Soluta voluptatem harum qui dignissimos.", 164, 18014m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Commodi accusantium aut incidunt est ab atque.", 77, 18800m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Rerum ut id voluptatum natus eius.", 69, 3812m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Cupiditate nihil natus rerum.", 8, 12823m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Expedita aspernatur exercitationem voluptatem quam aperiam eum.", 159, 4678m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Iure ad eos distinctio reiciendis ut laboriosam corporis fuga rerum.", 174, 4316m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Neque aut nulla error quae optio praesentium.", 136, 14941m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Non iure a.", 142, 59m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Molestiae nihil veniam distinctio.", 77, 8147m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut autem sequi aut molestias libero magni quibusdam tempora.", 186, 2167m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Maiores qui sint vel sint.", 134, 13363m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Ipsam aspernatur quod illum sit sequi ut.", 195, 6299m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Molestiae vitae sit porro dolorem quia voluptatem mollitia odit quia.", 60, 18028m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Rerum laudantium eius saepe numquam repellat.", 82, 11487m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Laborum architecto omnis et ex.", 22, 11075m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Autem velit voluptas tempore ut velit voluptatum aut velit.", 184, 13424m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Pariatur ex vitae nobis rerum at.", 159, 8453m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolore quo et pariatur ut et adipisci.", 19, 5902m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Eius accusamus quibusdam aspernatur unde non.", 140, 5137m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Perferendis alias rem voluptas modi.", 37, 2349m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Beatae aspernatur ea ut quaerat.", 66, 16987m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quis qui aut.", 17, 17274m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "In provident est eveniet quo perspiciatis tempora pariatur debitis.", 36, 17010m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Vero illo eos assumenda odio et nostrum commodi sed praesentium.", 185, 1447m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Est tenetur dolores.", 157, 7277m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dolor quaerat illum consequatur voluptate aut sed.", 154, 7129m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et est quae est necessitatibus culpa aperiam sit.", 89, 5307m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolorem ut eveniet quo vel cumque consequuntur voluptatibus blanditiis.", 124, 19168m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Iure repellat odit et et praesentium nihil aut aut et.", 192, 9792m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit aliquid illum velit non culpa nihil.", 127, 6097m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Maxime totam voluptas sed accusantium.", 130, 543m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Velit vel nesciunt sunt.", 199, 14442m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Maxime autem iusto quia id.", 131, 13838m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Optio qui repellat iste quia sapiente quidem fugit.", 90, 7459m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Numquam ipsum sequi.", 24, 69m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ipsam quia exercitationem voluptas sapiente.", 33, 6157m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Autem qui delectus quidem in sed aliquam.", 18, 684m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut necessitatibus atque ad modi hic qui.", 107, 13769m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Vel voluptate cumque incidunt neque.", 191, 13086m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Architecto et eos culpa mollitia hic maxime consequatur doloribus.", 140, 15477m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptas est dicta qui impedit sequi.", 191, 4576m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dolorem et accusantium officiis voluptatum.", 18, 15870m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et dolores rerum ex quas earum quis perspiciatis libero.", 24, 6108m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Rem similique eveniet dolore autem et.", 107, 4618m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ducimus quisquam dolores sint voluptatibus quod.", 118, 12151m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dignissimos ipsa quia non vero ullam veniam.", 11, 5982m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "In et eveniet et quo in qui nihil.", 186, 12051m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut accusantium est error.", 142, 1567m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quia vero eaque neque assumenda non harum ut possimus autem.", 148, 4917m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempore eveniet et.", 190, 103m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptatem asperiores fuga.", 147, 5476m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolores totam deleniti repellendus.", 110, 802m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Quasi consequatur natus unde consequatur dolores et esse.", 37, 12106m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Facilis ut doloribus quod necessitatibus ipsum qui expedita.", 54, 817m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et aliquam dolorem ipsa facilis ut incidunt aliquid ducimus.", 114, 11633m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Consequuntur vero maiores nulla nemo numquam temporibus dolorem molestias.", 28, 15867m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Repellat doloremque accusamus nostrum quis inventore.", 119, 10312m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Fugiat facere aliquid velit.", 35, 7784m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit et illo et a.", 159, 19279m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Maxime molestias ut.", 84, 14906m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Adipisci veniam nisi aut voluptatem.", 95, 8510m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Fuga sed quis consequuntur deserunt et.", 196, 9356m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptate explicabo quisquam dolores natus.", 173, 16340m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolor cum qui reiciendis voluptatem ut eos sed et illo.", 105, 9739m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Distinctio et sint et minima nesciunt odio et.", 38, 18932m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Nihil est et est qui dignissimos.", 47, 16919m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aspernatur voluptas distinctio ut nesciunt.", 115, 16913m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ut velit qui a minus quo laboriosam dolor adipisci.", 70, 3745m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptatem amet debitis illo beatae quia amet molestiae laudantium.", 190, 11722m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Laboriosam aut rerum.", 104, 12287m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quae et quisquam id molestias voluptatem.", 52, 718m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eum voluptas aut delectus pariatur dolores ut.", 148, 13615m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolor laboriosam dolore voluptas.", 92, 1883m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Doloremque laborum qui tempora.", 164, 6705m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et voluptas inventore quis nam voluptas.", 8, 7312m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quo voluptas tempore vel et itaque voluptatem quaerat nihil.", 160, 18835m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et porro eum quod excepturi.", 152, 386m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Et sunt velit cum.", 193, 9646m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Dignissimos qui cumque itaque sit.", 43, 14517m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui quo non officia accusantium et.", 79, 988m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Esse beatae dolore.", 83, 8769m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Omnis hic voluptatibus in praesentium accusantium hic.", 101, 2028m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut eos voluptatem.", 76, 12647m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur et itaque error id labore.", 92, 591m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Ipsam officiis fuga dolor perspiciatis totam.", 112, 8745m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Ad aperiam vel velit exercitationem omnis vel laborum ipsa.", 29, 10659m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Perferendis esse distinctio modi repellat.", 56, 12663m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Labore sit vitae quisquam neque a nemo rerum.", 32, 6085m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Voluptas rerum voluptatum et.", 178, 16858m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nulla iusto provident illo est nulla error ducimus.", 192, 2338m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut rem explicabo ducimus.", 193, 1644m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sit odit incidunt suscipit ad occaecati magni et.", 59, 16318m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Facilis amet aut amet praesentium.", 187, 7631m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quas sequi fugiat alias voluptate reprehenderit autem distinctio dignissimos saepe.", 85, 2339m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Sunt ipsa ipsam ipsam sit voluptas.", 155, 7758m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Laboriosam eveniet assumenda qui reiciendis quibusdam voluptatem nesciunt est dolor.", 146, 8832m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Non pariatur laborum eius qui omnis.", 178, 5718m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et reiciendis sit fugit quos veritatis dolor.", 96, 9966m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sint voluptatem incidunt ut aspernatur quaerat magni cupiditate officia.", 47, 18095m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Omnis et ratione.", 177, 1076m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolor ipsa aut est est vel.", 72, 6782m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Doloribus optio ut dolorem dolores amet corrupti possimus.", 143, 16338m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Culpa odio molestias maxime aliquid alias voluptas perferendis et deleniti.", 59, 2776m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Placeat sit ea unde repellendus animi perspiciatis.", 54, 7105m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nam quia nihil deleniti totam consequatur accusantium doloremque dolore.", 175, 17406m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Fuga quis numquam omnis reiciendis quia optio sint.", 119, 187m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aliquid aperiam dicta vero deleniti nihil.", 179, 2676m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Tempore vel ut.", 176, 9197m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Adipisci sequi aut ipsum eos necessitatibus.", 34, 5752m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Autem rerum corporis.", 200, 7127m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Aut ipsum modi.", 37, 19310m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Animi itaque labore.", 9, 11885m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Exercitationem autem eos rerum delectus adipisci quaerat delectus sint dolor.", 74, 8000m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Laudantium neque et deleniti ipsam aut amet.", 186, 4880m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Molestias non voluptatem voluptatibus facere omnis suscipit inventore.", 44, 5944m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Repudiandae aliquam quae hic dolor explicabo est culpa nisi est.", 112, 8669m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Aut magni accusamus sit ipsum quas facere aperiam voluptas quibusdam.", 7, 12944m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Sit earum qui natus in.", 59, 14323m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Architecto odit neque sequi quisquam porro adipisci voluptatibus suscipit.", 53, 19015m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Velit neque eius veniam sequi dolores facere eligendi et quae.", 89, 8840m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Veniam delectus voluptas distinctio sit explicabo.", 176, 7956m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Blanditiis ex optio.", 15, 241m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ratione labore dolores eos eos beatae beatae eum quos fugit.", 56, 14284m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Illo voluptatibus voluptas animi perferendis dolor perferendis.", 47, 11481m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "In asperiores id repudiandae quis maxime et pariatur.", 22, 3069m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Odit quo et rem dolorem illum aut.", 129, 5174m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Totam qui neque dolores nam sequi fuga veritatis qui.", 178, 13599m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Atque omnis ut odio enim.", 4, 17540m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Aut aut quia.", 85, 8326m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "In aut ut sit suscipit.", 126, 14335m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Amet molestiae quia sit enim qui suscipit accusantium.", 75, 18263m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui illum sunt voluptatem.", 42, 11250m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Quae aperiam enim sunt odio laudantium odio et hic rerum.", 166, 7928m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sunt fugiat aliquid vitae et molestias corporis maiores.", 91, 8484m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Eligendi molestiae est enim.", 76, 16884m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Dolor eum accusamus officia veniam vel qui possimus.", 68, 3912m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui et consequuntur omnis totam quod ab necessitatibus dolorem doloribus.", 188, 5300m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Consequuntur qui et aut praesentium iure et ut non expedita.", 51, 4474m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dolorem et et omnis adipisci voluptatem qui exercitationem.", 49, 14863m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui id qui.", 149, 6977m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Consequatur incidunt aut.", 133, 10868m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et illum quibusdam eius et neque in quis quia eum.", 170, 19408m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Numquam sunt rerum sunt id voluptatem.", 103, 17497m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Qui harum voluptatem eius sed ea tempora in.", 90, 9976m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Incidunt sed odit quia non assumenda facilis.", 154, 4094m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Iusto dicta enim harum quis et veniam dolor facere laboriosam.", 191, 15376m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Possimus qui autem facilis assumenda aut inventore.", 32, 6856m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Maxime qui rem.", 71, 13867m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Enim repudiandae voluptas magni in neque esse dolorem.", 168, 17825m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nesciunt necessitatibus facere facere sed eveniet repellat vel maxime.", 135, 18186m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Repellendus veniam est ut repudiandae impedit accusantium.", 138, 6782m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Id iste ut.", 64, 9032m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Qui quas quisquam earum.", 50, 14958m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Consequatur quis praesentium autem fuga harum perspiciatis.", 186, 4890m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Qui ipsa et quas ab nostrum odio qui nostrum.", 39, 18861m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Minima natus nihil sequi blanditiis blanditiis est consequatur voluptas in.", 197, 15775m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia et reprehenderit sapiente iusto voluptas laudantium et.", 34, 8709m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Ut veritatis quia voluptatem.", 71, 8040m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Vel rem inventore et aut sed libero.", 63, 14332m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Dicta excepturi est incidunt ut consectetur.", 55, 16363m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Est error in omnis ad.", 62, 10474m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Libero illo sint et consequatur possimus quaerat voluptatibus.", 172, 14377m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Voluptatem omnis aliquid aperiam eos deleniti provident quasi.", 38, 5356m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et molestiae reprehenderit adipisci quasi alias earum.", 92, 14920m, "Liquid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Quia et natus molestiae omnis.", 72, 2364m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Tempora et quos molestiae eum ipsa.", 26, 12731m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et quia fugiat deserunt cupiditate ut.", 192, 17140m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Et nihil est.", 29, 972m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Possimus ab facilis consequatur velit totam cumque rerum ipsum.", 4, 17982m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Eum nemo aut.", 6, 14565m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Alias eveniet eligendi dolores nihil repellendus quod.", 99, 15590m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Aut dignissimos modi ipsam harum.", 126, 2502m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Pariatur porro voluptas vel debitis vel.", 162, 18792m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Amet quae maxime ipsam et ipsa sint ut reprehenderit eum.", 2, 12347m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Description", "Quantity", "Unit" },
                values: new object[] { "Vitae autem explicabo non sed modi.", 17749m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Quae et ea voluptas dolorem.", 74, 13645m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Deleniti alias similique vitae et qui.", 47, 5831m, "Solid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Incidunt quos exercitationem ratione voluptatem animi corrupti id ullam.", 68, 9956m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Perferendis ut omnis consequatur recusandae suscipit rerum ex maiores id.", 26, 15764m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Mollitia molestiae illum officia laborum vel.", 139, 8265m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Molestias harum quos.", 134, 18001m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Necessitatibus amet id.", 11, 12330m, "Solid", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Molestias eligendi ea dolorum rem amet et cumque sunt debitis.", 37, 14965m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Eos sit at eum consequatur et.", 25, 1723m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Voluptate nemo vero.", 108, 6212m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Et quis sit illo est voluptatem reprehenderit temporibus sit et.", 181, 18353m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Debitis veniam dignissimos modi aut aut quam accusamus.", 86, 4747m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Nulla quaerat ea non officia et eligendi odit non ad.", 124, 4893m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Repudiandae sed accusamus qui fugit mollitia voluptatibus accusantium architecto.", 186, 6326m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Explicabo explicabo dolor ut blanditiis rerum quasi.", 41, 10897m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Id ut aut velit quo dolores itaque.", 7, 13283m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Nam laboriosam et ut quis.", 64, 17860m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Et sit et ut neque consequuntur est.", 134, 7395m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Asperiores harum sit officiis animi rerum doloribus.", 13, 16426m, "Liquid", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Officiis sed vitae fugiat quaerat illum repellat laboriosam reprehenderit alias.", 27, 18312m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Consequatur reiciendis officia sed molestiae.", 70, 15966m, "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Esse nostrum voluptatem quia.", 75, 7735m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Explicabo ipsa quae at.", 135, 2248m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Asperiores porro consectetur id.", 37, 17129m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Non sunt explicabo qui est pariatur et nulla cupiditate soluta.", 189, 280m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Sapiente et nostrum voluptas quia voluptatum at possimus.", 71, 12998m, "Liquid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Description", "ManifestId", "Quantity" },
                values: new object[] { "Cum iusto voluptas.", 21, 2856m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Architecto consequatur enim adipisci ut ut nesciunt.", 25, 19822m, "Solid" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Perspiciatis est quia voluptatem.", 97, 8379m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Description", "ManifestId", "Quantity", "Unit" },
                values: new object[] { "Dignissimos impedit quam sit officia dolorem sunt repudiandae accusamus.", 141, 9230m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Veniam sit similique rerum quia optio voluptas sint saepe corporis.", 181, 6928m, "Gas", "Kg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[] { "Est qui dolorum quia autem et expedita.", 130, 17083m, "Gas", "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Description", "ManifestId", "Quantity", "State" },
                values: new object[] { "Beatae voluptatem nam.", 103, 4268m, "Gas" });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "ZW-1809", new DateTime(2021, 9, 20, 22, 43, 9, 627, DateTimeKind.Unspecified).AddTicks(164), new DateTime(2021, 8, 14, 21, 32, 44, 816, DateTimeKind.Unspecified).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "2O-8971", 1, new DateTime(2021, 11, 11, 12, 33, 43, 555, DateTimeKind.Unspecified).AddTicks(9734), new DateTime(2021, 6, 17, 4, 39, 3, 632, DateTimeKind.Unspecified).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "60-4574", new DateTime(2021, 12, 25, 17, 32, 26, 543, DateTimeKind.Unspecified).AddTicks(6589), new DateTime(2021, 6, 4, 18, 15, 28, 41, DateTimeKind.Unspecified).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "4F-1577", 4, new DateTime(2021, 10, 4, 0, 6, 57, 812, DateTimeKind.Unspecified).AddTicks(7410), new DateTime(2021, 8, 6, 10, 48, 7, 653, DateTimeKind.Unspecified).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "48-5181", 4, new DateTime(2021, 11, 2, 18, 2, 22, 946, DateTimeKind.Unspecified).AddTicks(9113), new DateTime(2021, 8, 12, 19, 9, 32, 63, DateTimeKind.Unspecified).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "BJ-5473", 1, new DateTime(2021, 10, 20, 13, 52, 15, 569, DateTimeKind.Unspecified).AddTicks(7253), new DateTime(2021, 5, 18, 23, 29, 54, 29, DateTimeKind.Unspecified).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "45-0580", 5, new DateTime(2021, 9, 6, 15, 12, 45, 502, DateTimeKind.Unspecified).AddTicks(1297), new DateTime(2021, 8, 4, 9, 49, 22, 920, DateTimeKind.Unspecified).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "9H-9135", 3, new DateTime(2021, 9, 3, 22, 15, 4, 411, DateTimeKind.Unspecified).AddTicks(1714), new DateTime(2021, 6, 18, 16, 51, 40, 614, DateTimeKind.Unspecified).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "42-2426", 2, new DateTime(2021, 9, 13, 10, 14, 47, 917, DateTimeKind.Unspecified).AddTicks(7384), new DateTime(2021, 7, 6, 20, 36, 0, 102, DateTimeKind.Unspecified).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "20-0861", 2, new DateTime(2021, 11, 15, 1, 9, 34, 683, DateTimeKind.Unspecified).AddTicks(4536), new DateTime(2021, 5, 31, 7, 27, 42, 927, DateTimeKind.Unspecified).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "L9-2582", 1, new DateTime(2021, 11, 11, 20, 43, 54, 677, DateTimeKind.Unspecified).AddTicks(3287), new DateTime(2021, 7, 5, 1, 59, 3, 559, DateTimeKind.Unspecified).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "5J-5071", 3, new DateTime(2021, 11, 20, 13, 1, 9, 144, DateTimeKind.Unspecified).AddTicks(309), new DateTime(2021, 5, 27, 12, 46, 13, 322, DateTimeKind.Unspecified).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "G7-3276", 2, new DateTime(2021, 12, 7, 13, 49, 21, 339, DateTimeKind.Unspecified).AddTicks(8918), new DateTime(2021, 7, 31, 2, 33, 8, 513, DateTimeKind.Unspecified).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "27-1290", 4, new DateTime(2021, 10, 28, 2, 35, 11, 541, DateTimeKind.Unspecified).AddTicks(2502), new DateTime(2021, 8, 5, 0, 22, 56, 873, DateTimeKind.Unspecified).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "3F-7028", 2, new DateTime(2021, 12, 26, 20, 6, 11, 105, DateTimeKind.Unspecified).AddTicks(5377), new DateTime(2021, 8, 28, 2, 44, 35, 749, DateTimeKind.Unspecified).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "0X-3836", 5, new DateTime(2021, 9, 30, 6, 31, 31, 469, DateTimeKind.Unspecified).AddTicks(6549), new DateTime(2021, 6, 16, 6, 38, 54, 88, DateTimeKind.Unspecified).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "Y1-7194", 3, new DateTime(2021, 9, 7, 11, 58, 47, 7, DateTimeKind.Unspecified).AddTicks(1350), new DateTime(2021, 7, 26, 20, 55, 16, 801, DateTimeKind.Unspecified).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "ME-4952", 2, new DateTime(2021, 9, 9, 10, 29, 12, 735, DateTimeKind.Unspecified).AddTicks(3775), new DateTime(2021, 7, 23, 9, 22, 36, 98, DateTimeKind.Unspecified).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "0W-1161", 5, new DateTime(2021, 12, 4, 1, 41, 30, 46, DateTimeKind.Unspecified).AddTicks(4712), new DateTime(2021, 7, 15, 20, 12, 58, 775, DateTimeKind.Unspecified).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "01-8540", 2, new DateTime(2021, 12, 10, 19, 52, 34, 515, DateTimeKind.Unspecified).AddTicks(8407), new DateTime(2021, 6, 8, 19, 17, 11, 223, DateTimeKind.Unspecified).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "F9-4091", 2, new DateTime(2021, 11, 21, 8, 2, 3, 333, DateTimeKind.Unspecified).AddTicks(6971), new DateTime(2021, 7, 23, 5, 40, 53, 629, DateTimeKind.Unspecified).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "03-3502", 5, new DateTime(2021, 10, 9, 14, 18, 23, 177, DateTimeKind.Unspecified).AddTicks(3971), new DateTime(2021, 5, 25, 21, 45, 31, 854, DateTimeKind.Unspecified).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "I7-0566", 5, new DateTime(2021, 12, 24, 4, 1, 40, 483, DateTimeKind.Unspecified).AddTicks(2142), new DateTime(2021, 8, 17, 1, 12, 30, 144, DateTimeKind.Unspecified).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "SX-4440", 3, new DateTime(2021, 12, 2, 23, 21, 9, 800, DateTimeKind.Unspecified).AddTicks(4071), new DateTime(2021, 8, 6, 19, 27, 17, 734, DateTimeKind.Unspecified).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "0U-7098", 1, new DateTime(2021, 9, 11, 21, 20, 5, 795, DateTimeKind.Unspecified).AddTicks(8290), new DateTime(2021, 5, 13, 13, 12, 15, 471, DateTimeKind.Unspecified).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "E7-2084", new DateTime(2021, 11, 22, 23, 23, 21, 92, DateTimeKind.Unspecified).AddTicks(8755), new DateTime(2021, 7, 7, 5, 7, 5, 53, DateTimeKind.Unspecified).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "DL-6085", 3, new DateTime(2021, 12, 20, 18, 48, 47, 970, DateTimeKind.Unspecified).AddTicks(1086), new DateTime(2021, 7, 5, 0, 57, 31, 341, DateTimeKind.Unspecified).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "WU-9089", new DateTime(2021, 9, 29, 20, 40, 52, 414, DateTimeKind.Unspecified).AddTicks(6278), new DateTime(2021, 6, 8, 14, 25, 10, 791, DateTimeKind.Unspecified).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "7L-5359", new DateTime(2021, 11, 9, 6, 18, 34, 345, DateTimeKind.Unspecified).AddTicks(6058), new DateTime(2021, 8, 16, 13, 32, 16, 618, DateTimeKind.Unspecified).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "59-0559", 4, new DateTime(2021, 10, 19, 12, 53, 2, 413, DateTimeKind.Unspecified).AddTicks(3374), new DateTime(2021, 8, 15, 12, 59, 2, 230, DateTimeKind.Unspecified).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "0E-4503", new DateTime(2021, 12, 15, 22, 39, 59, 979, DateTimeKind.Unspecified).AddTicks(8052), new DateTime(2021, 5, 17, 0, 15, 11, 155, DateTimeKind.Unspecified).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "4G-0538", 5, new DateTime(2021, 10, 25, 2, 54, 54, 887, DateTimeKind.Unspecified).AddTicks(1155), new DateTime(2021, 7, 8, 3, 57, 19, 382, DateTimeKind.Unspecified).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "XC-0351", 5, new DateTime(2021, 10, 24, 9, 5, 13, 23, DateTimeKind.Unspecified).AddTicks(3828), new DateTime(2021, 6, 19, 12, 41, 26, 559, DateTimeKind.Unspecified).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "K9-9566", 3, new DateTime(2021, 11, 12, 13, 42, 8, 986, DateTimeKind.Unspecified).AddTicks(3727), new DateTime(2021, 7, 29, 19, 47, 55, 881, DateTimeKind.Unspecified).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "HC-8046", new DateTime(2021, 11, 5, 5, 3, 35, 258, DateTimeKind.Unspecified).AddTicks(1985), new DateTime(2021, 6, 23, 14, 53, 6, 564, DateTimeKind.Unspecified).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "Y5-0998", new DateTime(2021, 11, 21, 23, 9, 22, 401, DateTimeKind.Unspecified).AddTicks(3469), new DateTime(2021, 7, 2, 9, 50, 48, 843, DateTimeKind.Unspecified).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "3M-6804", new DateTime(2021, 12, 2, 1, 27, 25, 463, DateTimeKind.Unspecified).AddTicks(1219), new DateTime(2021, 7, 12, 3, 11, 56, 534, DateTimeKind.Unspecified).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "48-0686", 1, new DateTime(2021, 9, 7, 18, 9, 16, 336, DateTimeKind.Unspecified).AddTicks(7030), new DateTime(2021, 6, 6, 17, 22, 42, 929, DateTimeKind.Unspecified).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "1N-3859", 4, new DateTime(2021, 10, 31, 7, 38, 16, 502, DateTimeKind.Unspecified).AddTicks(6507), new DateTime(2021, 8, 25, 17, 22, 13, 260, DateTimeKind.Unspecified).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "96-0934", new DateTime(2021, 11, 6, 19, 8, 11, 761, DateTimeKind.Unspecified).AddTicks(1413), new DateTime(2021, 5, 26, 14, 11, 2, 21, DateTimeKind.Unspecified).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "DK-6762", 1, new DateTime(2021, 11, 6, 7, 30, 59, 817, DateTimeKind.Unspecified).AddTicks(3908), new DateTime(2021, 6, 7, 21, 36, 17, 387, DateTimeKind.Unspecified).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "53-7592", 3, new DateTime(2021, 9, 9, 9, 15, 3, 907, DateTimeKind.Unspecified).AddTicks(6454), new DateTime(2021, 7, 23, 19, 28, 20, 274, DateTimeKind.Unspecified).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "FA-5866", new DateTime(2021, 10, 1, 9, 35, 3, 316, DateTimeKind.Unspecified).AddTicks(7106), new DateTime(2021, 8, 14, 13, 40, 35, 993, DateTimeKind.Unspecified).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "10-5734", new DateTime(2021, 11, 7, 0, 24, 57, 216, DateTimeKind.Unspecified).AddTicks(4221), new DateTime(2021, 7, 5, 23, 11, 46, 944, DateTimeKind.Unspecified).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "AU-5908", 3, new DateTime(2021, 10, 25, 18, 19, 33, 629, DateTimeKind.Unspecified).AddTicks(300), new DateTime(2021, 8, 4, 11, 57, 5, 209, DateTimeKind.Unspecified).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "6H-0650", new DateTime(2021, 11, 17, 22, 35, 9, 662, DateTimeKind.Unspecified).AddTicks(1683), new DateTime(2021, 6, 9, 14, 58, 45, 578, DateTimeKind.Unspecified).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "9U-3241", 4, new DateTime(2021, 11, 5, 15, 25, 28, 724, DateTimeKind.Unspecified).AddTicks(7454), new DateTime(2021, 5, 12, 17, 31, 10, 209, DateTimeKind.Unspecified).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "99-0072", 2, new DateTime(2021, 12, 14, 11, 43, 18, 979, DateTimeKind.Unspecified).AddTicks(9815), new DateTime(2021, 8, 12, 3, 48, 42, 768, DateTimeKind.Unspecified).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "10-8481", 4, new DateTime(2021, 11, 16, 17, 2, 29, 705, DateTimeKind.Unspecified).AddTicks(5265), new DateTime(2021, 7, 9, 12, 45, 9, 262, DateTimeKind.Unspecified).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "21-3671", new DateTime(2021, 9, 24, 12, 43, 23, 176, DateTimeKind.Unspecified).AddTicks(2053), new DateTime(2021, 5, 25, 12, 38, 0, 704, DateTimeKind.Unspecified).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "PR-9033", 1, new DateTime(2021, 10, 5, 15, 6, 10, 41, DateTimeKind.Unspecified).AddTicks(2690), new DateTime(2021, 7, 25, 7, 12, 31, 693, DateTimeKind.Unspecified).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "J2-1870", 2, new DateTime(2021, 12, 6, 1, 42, 15, 965, DateTimeKind.Unspecified).AddTicks(9969), new DateTime(2021, 7, 28, 1, 11, 45, 874, DateTimeKind.Unspecified).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "PS-1729", new DateTime(2021, 10, 7, 20, 8, 45, 261, DateTimeKind.Unspecified).AddTicks(4910), new DateTime(2021, 7, 3, 10, 24, 48, 907, DateTimeKind.Unspecified).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "27-7154", 3, new DateTime(2021, 9, 2, 19, 42, 59, 180, DateTimeKind.Unspecified).AddTicks(2364), new DateTime(2021, 6, 3, 5, 28, 34, 368, DateTimeKind.Unspecified).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "5U-3081", new DateTime(2021, 10, 17, 19, 44, 43, 914, DateTimeKind.Unspecified).AddTicks(4099), new DateTime(2021, 5, 21, 14, 19, 20, 570, DateTimeKind.Unspecified).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "53-5638", 5, new DateTime(2021, 12, 22, 11, 14, 35, 765, DateTimeKind.Unspecified).AddTicks(8715), new DateTime(2021, 8, 6, 1, 13, 26, 366, DateTimeKind.Unspecified).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "B1-9213", 2, new DateTime(2021, 11, 12, 8, 21, 35, 421, DateTimeKind.Unspecified).AddTicks(4057), new DateTime(2021, 6, 20, 12, 11, 37, 261, DateTimeKind.Unspecified).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "LX-2342", new DateTime(2021, 9, 21, 7, 27, 28, 584, DateTimeKind.Unspecified).AddTicks(9818), new DateTime(2021, 7, 15, 11, 49, 19, 696, DateTimeKind.Unspecified).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "DX-8313", new DateTime(2021, 9, 29, 10, 36, 31, 216, DateTimeKind.Unspecified).AddTicks(4031), new DateTime(2021, 5, 20, 15, 21, 32, 809, DateTimeKind.Unspecified).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "R6-0702", 1, new DateTime(2021, 9, 14, 4, 30, 11, 46, DateTimeKind.Unspecified).AddTicks(8195), new DateTime(2021, 7, 13, 20, 8, 53, 589, DateTimeKind.Unspecified).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "4N-5588", 3, new DateTime(2021, 12, 5, 0, 59, 26, 518, DateTimeKind.Unspecified).AddTicks(9387), new DateTime(2021, 6, 5, 0, 38, 35, 72, DateTimeKind.Unspecified).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "2Z-7988", 2, new DateTime(2021, 11, 14, 18, 42, 15, 190, DateTimeKind.Unspecified).AddTicks(7060), new DateTime(2021, 5, 30, 12, 24, 1, 751, DateTimeKind.Unspecified).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "73-7392", 3, new DateTime(2021, 10, 20, 20, 18, 17, 521, DateTimeKind.Unspecified).AddTicks(6342), new DateTime(2021, 8, 17, 8, 44, 51, 376, DateTimeKind.Unspecified).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "QF-1275", 3, new DateTime(2021, 11, 24, 23, 50, 41, 652, DateTimeKind.Unspecified).AddTicks(7969), new DateTime(2021, 6, 20, 18, 13, 41, 835, DateTimeKind.Unspecified).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "0F-7775", 2, new DateTime(2021, 12, 5, 14, 28, 34, 118, DateTimeKind.Unspecified).AddTicks(5616), new DateTime(2021, 6, 19, 0, 13, 25, 965, DateTimeKind.Unspecified).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "41-2924", 3, new DateTime(2021, 9, 10, 12, 58, 16, 450, DateTimeKind.Unspecified).AddTicks(2582), new DateTime(2021, 5, 31, 19, 19, 50, 814, DateTimeKind.Unspecified).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "6C-6627", 2, new DateTime(2021, 12, 4, 8, 36, 38, 64, DateTimeKind.Unspecified).AddTicks(4281), new DateTime(2021, 5, 22, 6, 33, 11, 922, DateTimeKind.Unspecified).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "TT-0318", 2, new DateTime(2021, 12, 1, 6, 49, 48, 970, DateTimeKind.Unspecified).AddTicks(4416), new DateTime(2021, 8, 25, 10, 8, 54, 776, DateTimeKind.Unspecified).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "64-1921", 5, new DateTime(2021, 9, 18, 2, 6, 34, 779, DateTimeKind.Unspecified).AddTicks(62), new DateTime(2021, 5, 17, 5, 46, 36, 673, DateTimeKind.Unspecified).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "6O-7647", 2, new DateTime(2021, 10, 24, 22, 38, 28, 828, DateTimeKind.Unspecified).AddTicks(6601), new DateTime(2021, 6, 12, 19, 35, 35, 779, DateTimeKind.Unspecified).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "41-9370", 4, new DateTime(2021, 9, 7, 23, 30, 45, 9, DateTimeKind.Unspecified).AddTicks(8000), new DateTime(2021, 8, 19, 10, 51, 30, 909, DateTimeKind.Unspecified).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "7M-2993", 4, new DateTime(2021, 10, 18, 8, 37, 43, 661, DateTimeKind.Unspecified).AddTicks(4572), new DateTime(2021, 7, 16, 2, 35, 18, 321, DateTimeKind.Unspecified).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "66-6249", new DateTime(2021, 11, 27, 14, 10, 37, 459, DateTimeKind.Unspecified).AddTicks(9471), new DateTime(2021, 5, 8, 10, 42, 29, 345, DateTimeKind.Unspecified).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "14-6043", 4, new DateTime(2021, 9, 1, 23, 32, 28, 665, DateTimeKind.Unspecified).AddTicks(7254), new DateTime(2021, 5, 27, 23, 44, 42, 980, DateTimeKind.Unspecified).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "93-3970", new DateTime(2021, 10, 8, 14, 23, 10, 926, DateTimeKind.Unspecified).AddTicks(2287), new DateTime(2021, 7, 27, 7, 47, 14, 897, DateTimeKind.Unspecified).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "14-4975", 4, new DateTime(2021, 9, 12, 15, 45, 20, 144, DateTimeKind.Unspecified).AddTicks(5963), new DateTime(2021, 8, 29, 9, 31, 31, 632, DateTimeKind.Unspecified).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "OR-9265", 3, new DateTime(2021, 11, 22, 22, 26, 7, 500, DateTimeKind.Unspecified).AddTicks(9969), new DateTime(2021, 7, 1, 9, 34, 12, 94, DateTimeKind.Unspecified).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "CJ-0984", new DateTime(2021, 10, 28, 8, 31, 33, 242, DateTimeKind.Unspecified).AddTicks(5448), new DateTime(2021, 5, 22, 11, 1, 9, 751, DateTimeKind.Unspecified).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "ZU-0623", 5, new DateTime(2021, 12, 2, 15, 32, 5, 547, DateTimeKind.Unspecified).AddTicks(7793), new DateTime(2021, 7, 10, 17, 13, 47, 674, DateTimeKind.Unspecified).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "05-4182", 4, new DateTime(2021, 10, 8, 8, 14, 36, 564, DateTimeKind.Unspecified).AddTicks(2930), new DateTime(2021, 7, 20, 5, 54, 31, 143, DateTimeKind.Unspecified).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "38-9568", 3, new DateTime(2021, 12, 20, 15, 25, 38, 494, DateTimeKind.Unspecified).AddTicks(7588), new DateTime(2021, 5, 15, 20, 18, 50, 428, DateTimeKind.Unspecified).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "87-8174", 3, new DateTime(2021, 9, 1, 13, 36, 50, 444, DateTimeKind.Unspecified).AddTicks(6282), new DateTime(2021, 5, 27, 6, 15, 51, 472, DateTimeKind.Unspecified).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "H3-0878", 2, new DateTime(2021, 11, 28, 0, 15, 41, 35, DateTimeKind.Unspecified).AddTicks(9342), new DateTime(2021, 6, 23, 6, 29, 42, 157, DateTimeKind.Unspecified).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "44-7639", new DateTime(2021, 11, 7, 6, 38, 48, 995, DateTimeKind.Unspecified).AddTicks(3448), new DateTime(2021, 5, 29, 20, 0, 6, 133, DateTimeKind.Unspecified).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "B5-0175", 1, new DateTime(2021, 11, 19, 21, 4, 55, 656, DateTimeKind.Unspecified).AddTicks(861), new DateTime(2021, 5, 19, 15, 4, 42, 818, DateTimeKind.Unspecified).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "2N-4258", 3, new DateTime(2021, 10, 16, 0, 3, 46, 288, DateTimeKind.Unspecified).AddTicks(4931), new DateTime(2021, 7, 13, 22, 34, 33, 699, DateTimeKind.Unspecified).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "HW-4294", 1, new DateTime(2021, 12, 26, 16, 21, 12, 47, DateTimeKind.Unspecified).AddTicks(7915), new DateTime(2021, 7, 30, 0, 37, 21, 944, DateTimeKind.Unspecified).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "1F-8857", new DateTime(2021, 10, 25, 23, 55, 15, 767, DateTimeKind.Unspecified).AddTicks(3834), new DateTime(2021, 8, 23, 14, 34, 59, 455, DateTimeKind.Unspecified).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "V8-7318", 3, new DateTime(2021, 11, 29, 8, 41, 51, 307, DateTimeKind.Unspecified).AddTicks(7906), new DateTime(2021, 8, 20, 12, 55, 49, 981, DateTimeKind.Unspecified).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "89-4650", 3, new DateTime(2021, 10, 7, 2, 0, 18, 320, DateTimeKind.Unspecified).AddTicks(4968), new DateTime(2021, 5, 17, 12, 18, 38, 147, DateTimeKind.Unspecified).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "3P-2709", new DateTime(2021, 11, 21, 12, 30, 37, 457, DateTimeKind.Unspecified).AddTicks(2040), new DateTime(2021, 5, 13, 9, 30, 33, 964, DateTimeKind.Unspecified).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "ES-3843", new DateTime(2021, 12, 25, 15, 59, 30, 520, DateTimeKind.Unspecified).AddTicks(9941), new DateTime(2021, 8, 6, 18, 56, 38, 827, DateTimeKind.Unspecified).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "O6-1999", 4, new DateTime(2021, 10, 14, 8, 47, 13, 241, DateTimeKind.Unspecified).AddTicks(6712), new DateTime(2021, 6, 30, 17, 10, 55, 438, DateTimeKind.Unspecified).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "5S-0931", 5, new DateTime(2021, 10, 5, 8, 38, 8, 871, DateTimeKind.Unspecified).AddTicks(7811), new DateTime(2021, 6, 6, 18, 19, 2, 379, DateTimeKind.Unspecified).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "WS-4702", new DateTime(2021, 11, 23, 1, 45, 16, 788, DateTimeKind.Unspecified).AddTicks(6331), new DateTime(2021, 8, 2, 19, 8, 42, 887, DateTimeKind.Unspecified).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "3K-3095", new DateTime(2021, 12, 12, 7, 0, 13, 381, DateTimeKind.Unspecified).AddTicks(1368), new DateTime(2021, 6, 9, 11, 15, 11, 548, DateTimeKind.Unspecified).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "72-7614", 2, new DateTime(2021, 10, 8, 16, 3, 40, 456, DateTimeKind.Unspecified).AddTicks(6733), new DateTime(2021, 8, 9, 23, 58, 58, 610, DateTimeKind.Unspecified).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "2A-1273", 4, new DateTime(2021, 11, 21, 15, 12, 53, 642, DateTimeKind.Unspecified).AddTicks(2585), new DateTime(2021, 6, 5, 3, 52, 44, 895, DateTimeKind.Unspecified).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "9T-4754", 3, new DateTime(2021, 11, 14, 18, 10, 43, 389, DateTimeKind.Unspecified).AddTicks(9424), new DateTime(2021, 7, 3, 22, 39, 5, 115, DateTimeKind.Unspecified).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "7W-8243", 3, new DateTime(2021, 9, 21, 13, 42, 23, 373, DateTimeKind.Unspecified).AddTicks(1383), new DateTime(2021, 5, 22, 19, 17, 42, 224, DateTimeKind.Unspecified).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "X4-6802", new DateTime(2021, 11, 29, 19, 32, 43, 591, DateTimeKind.Unspecified).AddTicks(6218), new DateTime(2021, 5, 8, 1, 26, 53, 915, DateTimeKind.Unspecified).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "K5-4375", 4, new DateTime(2021, 10, 20, 1, 20, 0, 0, DateTimeKind.Unspecified).AddTicks(6817), new DateTime(2021, 7, 26, 14, 15, 38, 962, DateTimeKind.Unspecified).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "XM-5818", new DateTime(2021, 11, 3, 22, 36, 37, 559, DateTimeKind.Unspecified).AddTicks(1368), new DateTime(2021, 5, 28, 23, 37, 58, 704, DateTimeKind.Unspecified).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "1S-7206", 4, new DateTime(2021, 10, 31, 1, 40, 47, 240, DateTimeKind.Unspecified).AddTicks(3465), new DateTime(2021, 8, 22, 4, 38, 29, 821, DateTimeKind.Unspecified).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "8F-6646", 2, new DateTime(2021, 11, 23, 19, 35, 38, 84, DateTimeKind.Unspecified).AddTicks(8617), new DateTime(2021, 8, 5, 17, 59, 13, 41, DateTimeKind.Unspecified).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "5R-5184", new DateTime(2021, 10, 13, 13, 24, 7, 290, DateTimeKind.Unspecified).AddTicks(466), new DateTime(2021, 6, 6, 11, 22, 0, 283, DateTimeKind.Unspecified).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "9M-8069", 5, new DateTime(2021, 11, 27, 21, 28, 7, 662, DateTimeKind.Unspecified).AddTicks(6986), new DateTime(2021, 5, 31, 1, 40, 51, 158, DateTimeKind.Unspecified).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "Y2-1533", 2, new DateTime(2021, 9, 16, 8, 44, 34, 579, DateTimeKind.Unspecified).AddTicks(8883), new DateTime(2021, 6, 16, 8, 44, 15, 645, DateTimeKind.Unspecified).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "K6-8527", new DateTime(2021, 11, 24, 11, 43, 17, 673, DateTimeKind.Unspecified).AddTicks(8933), new DateTime(2021, 7, 31, 12, 51, 53, 287, DateTimeKind.Unspecified).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "ZE-3873", new DateTime(2021, 11, 11, 10, 39, 10, 691, DateTimeKind.Unspecified).AddTicks(160), new DateTime(2021, 8, 1, 11, 12, 0, 924, DateTimeKind.Unspecified).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "R6-1902", 4, new DateTime(2021, 10, 26, 5, 54, 45, 522, DateTimeKind.Unspecified).AddTicks(7376), new DateTime(2021, 8, 18, 21, 0, 37, 955, DateTimeKind.Unspecified).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "B4-7413", 2, new DateTime(2021, 9, 15, 20, 41, 12, 473, DateTimeKind.Unspecified).AddTicks(987), new DateTime(2021, 6, 20, 4, 25, 19, 590, DateTimeKind.Unspecified).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "DL-4976", new DateTime(2021, 9, 26, 11, 36, 4, 473, DateTimeKind.Unspecified).AddTicks(3460), new DateTime(2021, 7, 21, 16, 53, 15, 20, DateTimeKind.Unspecified).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "6Q-5401", 1, new DateTime(2021, 10, 6, 2, 53, 3, 677, DateTimeKind.Unspecified).AddTicks(6201), new DateTime(2021, 6, 7, 4, 42, 47, 40, DateTimeKind.Unspecified).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "GZ-8334", 2, new DateTime(2021, 9, 5, 12, 37, 54, 893, DateTimeKind.Unspecified).AddTicks(2544), new DateTime(2021, 8, 14, 17, 9, 19, 404, DateTimeKind.Unspecified).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "OR-9283", 2, new DateTime(2021, 9, 12, 0, 22, 8, 236, DateTimeKind.Unspecified).AddTicks(9322), new DateTime(2021, 6, 7, 9, 57, 13, 198, DateTimeKind.Unspecified).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "NT-4104", 5, new DateTime(2021, 9, 30, 19, 24, 45, 621, DateTimeKind.Unspecified).AddTicks(7337), new DateTime(2021, 7, 15, 19, 41, 39, 919, DateTimeKind.Unspecified).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "7H-1190", new DateTime(2021, 12, 30, 23, 18, 2, 459, DateTimeKind.Unspecified).AddTicks(776), new DateTime(2021, 7, 29, 6, 56, 20, 214, DateTimeKind.Unspecified).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "J8-5880", 5, new DateTime(2021, 10, 7, 2, 34, 12, 492, DateTimeKind.Unspecified).AddTicks(432), new DateTime(2021, 5, 25, 20, 37, 36, 462, DateTimeKind.Unspecified).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "Q1-1312", 5, new DateTime(2021, 9, 20, 3, 9, 12, 854, DateTimeKind.Unspecified).AddTicks(2184), new DateTime(2021, 6, 13, 23, 3, 24, 489, DateTimeKind.Unspecified).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "52-8232", 4, new DateTime(2021, 9, 8, 3, 51, 26, 181, DateTimeKind.Unspecified).AddTicks(8989), new DateTime(2021, 5, 18, 2, 7, 48, 260, DateTimeKind.Unspecified).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "FA-8528", 4, new DateTime(2021, 11, 4, 3, 16, 17, 346, DateTimeKind.Unspecified).AddTicks(9875), new DateTime(2021, 7, 31, 12, 54, 45, 658, DateTimeKind.Unspecified).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "7K-4401", 1, new DateTime(2021, 12, 29, 6, 46, 7, 313, DateTimeKind.Unspecified).AddTicks(1043), new DateTime(2021, 6, 16, 3, 22, 9, 896, DateTimeKind.Unspecified).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "R7-2957", 3, new DateTime(2021, 12, 20, 21, 41, 29, 486, DateTimeKind.Unspecified).AddTicks(3924), new DateTime(2021, 5, 30, 1, 27, 56, 365, DateTimeKind.Unspecified).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "14-2559", 4, new DateTime(2021, 9, 13, 16, 8, 7, 27, DateTimeKind.Unspecified).AddTicks(1044), new DateTime(2021, 5, 24, 16, 4, 34, 96, DateTimeKind.Unspecified).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "9H-7908", 5, new DateTime(2021, 9, 18, 16, 20, 49, 137, DateTimeKind.Unspecified).AddTicks(1131), new DateTime(2021, 6, 18, 10, 17, 44, 428, DateTimeKind.Unspecified).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "5S-0090", 3, new DateTime(2021, 9, 30, 23, 56, 12, 118, DateTimeKind.Unspecified).AddTicks(7978), new DateTime(2021, 8, 29, 7, 55, 8, 281, DateTimeKind.Unspecified).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "6N-5319", 3, new DateTime(2021, 10, 8, 18, 45, 20, 948, DateTimeKind.Unspecified).AddTicks(168), new DateTime(2021, 6, 19, 10, 45, 48, 550, DateTimeKind.Unspecified).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "2O-9304", 4, new DateTime(2021, 11, 27, 8, 18, 30, 994, DateTimeKind.Unspecified).AddTicks(13), new DateTime(2021, 5, 12, 14, 6, 8, 648, DateTimeKind.Unspecified).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "WU-7053", 5, new DateTime(2021, 9, 18, 14, 49, 12, 320, DateTimeKind.Unspecified).AddTicks(2146), new DateTime(2021, 6, 2, 18, 11, 5, 283, DateTimeKind.Unspecified).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "45-7463", 1, new DateTime(2021, 12, 6, 7, 58, 35, 597, DateTimeKind.Unspecified).AddTicks(3062), new DateTime(2021, 7, 21, 2, 13, 38, 270, DateTimeKind.Unspecified).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "42-9548", 3, new DateTime(2021, 11, 25, 22, 13, 45, 760, DateTimeKind.Unspecified).AddTicks(1395), new DateTime(2021, 7, 17, 3, 32, 27, 704, DateTimeKind.Unspecified).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "44-5934", new DateTime(2021, 11, 3, 2, 27, 22, 399, DateTimeKind.Unspecified).AddTicks(6385), new DateTime(2021, 6, 27, 15, 16, 21, 749, DateTimeKind.Unspecified).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "5J-6756", 2, new DateTime(2021, 10, 4, 13, 17, 37, 364, DateTimeKind.Unspecified).AddTicks(987), new DateTime(2021, 7, 29, 8, 55, 34, 919, DateTimeKind.Unspecified).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "H3-1459", 5, new DateTime(2021, 10, 15, 1, 47, 38, 91, DateTimeKind.Unspecified).AddTicks(7493), new DateTime(2021, 5, 15, 9, 41, 14, 654, DateTimeKind.Unspecified).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "1F-8182", 5, new DateTime(2021, 10, 20, 16, 4, 50, 4, DateTimeKind.Unspecified).AddTicks(7572), new DateTime(2021, 5, 20, 5, 31, 58, 705, DateTimeKind.Unspecified).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "B8-5952", 4, new DateTime(2021, 10, 3, 23, 42, 19, 25, DateTimeKind.Unspecified).AddTicks(9917), new DateTime(2021, 7, 3, 5, 53, 14, 293, DateTimeKind.Unspecified).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "A5-2465", new DateTime(2021, 10, 27, 20, 30, 24, 261, DateTimeKind.Unspecified).AddTicks(8085), new DateTime(2021, 5, 28, 16, 26, 44, 43, DateTimeKind.Unspecified).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "IA-3423", 1, new DateTime(2021, 9, 9, 15, 50, 24, 267, DateTimeKind.Unspecified).AddTicks(5093), new DateTime(2021, 6, 29, 21, 16, 12, 456, DateTimeKind.Unspecified).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "69-0762", 4, new DateTime(2021, 12, 16, 10, 7, 2, 112, DateTimeKind.Unspecified).AddTicks(1779), new DateTime(2021, 7, 27, 8, 26, 20, 454, DateTimeKind.Unspecified).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "G5-9596", new DateTime(2021, 10, 1, 1, 27, 37, 203, DateTimeKind.Unspecified).AddTicks(3117), new DateTime(2021, 8, 20, 8, 9, 43, 366, DateTimeKind.Unspecified).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "4G-6004", 3, new DateTime(2021, 11, 7, 21, 37, 45, 595, DateTimeKind.Unspecified).AddTicks(6333), new DateTime(2021, 6, 12, 19, 48, 24, 876, DateTimeKind.Unspecified).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "7R-6974", 4, new DateTime(2021, 9, 12, 15, 59, 19, 399, DateTimeKind.Unspecified).AddTicks(5496), new DateTime(2021, 5, 25, 14, 15, 17, 259, DateTimeKind.Unspecified).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "76-1815", 4, new DateTime(2021, 11, 7, 0, 39, 7, 755, DateTimeKind.Unspecified).AddTicks(8847), new DateTime(2021, 7, 30, 10, 35, 34, 575, DateTimeKind.Unspecified).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "KP-3236", 5, new DateTime(2021, 9, 20, 17, 15, 41, 967, DateTimeKind.Unspecified).AddTicks(2928), new DateTime(2021, 7, 7, 8, 35, 14, 739, DateTimeKind.Unspecified).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "29-9462", 2, new DateTime(2021, 12, 22, 8, 37, 40, 795, DateTimeKind.Unspecified).AddTicks(72), new DateTime(2021, 8, 7, 17, 29, 24, 322, DateTimeKind.Unspecified).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "L7-0778", 1, new DateTime(2021, 9, 25, 22, 9, 58, 209, DateTimeKind.Unspecified).AddTicks(6537), new DateTime(2021, 8, 13, 11, 51, 4, 977, DateTimeKind.Unspecified).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "13-5510", 2, new DateTime(2021, 12, 10, 19, 58, 36, 408, DateTimeKind.Unspecified).AddTicks(7884), new DateTime(2021, 7, 19, 4, 12, 1, 163, DateTimeKind.Unspecified).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "FI-5429", 4, new DateTime(2021, 12, 22, 18, 10, 27, 578, DateTimeKind.Unspecified).AddTicks(2398), new DateTime(2021, 8, 29, 23, 24, 11, 410, DateTimeKind.Unspecified).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "PE-6610", 3, new DateTime(2021, 11, 26, 0, 51, 35, 999, DateTimeKind.Unspecified).AddTicks(7847), new DateTime(2021, 7, 16, 6, 8, 21, 778, DateTimeKind.Unspecified).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "2U-6772", new DateTime(2021, 12, 12, 23, 5, 29, 625, DateTimeKind.Unspecified).AddTicks(7436), new DateTime(2021, 8, 20, 20, 9, 18, 833, DateTimeKind.Unspecified).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "45-7857", 2, new DateTime(2021, 12, 25, 2, 41, 18, 873, DateTimeKind.Unspecified).AddTicks(6374), new DateTime(2021, 7, 5, 13, 10, 42, 61, DateTimeKind.Unspecified).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "Z5-1540", 4, new DateTime(2021, 10, 11, 16, 29, 43, 593, DateTimeKind.Unspecified).AddTicks(8805), new DateTime(2021, 8, 29, 0, 25, 32, 264, DateTimeKind.Unspecified).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "K8-9703", 4, new DateTime(2021, 9, 28, 15, 45, 48, 527, DateTimeKind.Unspecified).AddTicks(3834), new DateTime(2021, 5, 17, 19, 6, 6, 121, DateTimeKind.Unspecified).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "55-2852", 4, new DateTime(2021, 11, 25, 5, 5, 46, 905, DateTimeKind.Unspecified).AddTicks(7243), new DateTime(2021, 8, 11, 18, 22, 50, 455, DateTimeKind.Unspecified).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "12-1921", 3, new DateTime(2021, 10, 12, 1, 32, 15, 703, DateTimeKind.Unspecified).AddTicks(3904), new DateTime(2021, 8, 19, 12, 9, 47, 617, DateTimeKind.Unspecified).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "UM-0122", 5, new DateTime(2021, 11, 17, 2, 0, 34, 180, DateTimeKind.Unspecified).AddTicks(3584), new DateTime(2021, 5, 28, 11, 0, 23, 700, DateTimeKind.Unspecified).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "8S-4769", 3, new DateTime(2021, 12, 1, 21, 58, 50, 703, DateTimeKind.Unspecified).AddTicks(7588), new DateTime(2021, 6, 17, 16, 13, 13, 635, DateTimeKind.Unspecified).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "W7-4973", new DateTime(2021, 10, 25, 1, 11, 55, 634, DateTimeKind.Unspecified).AddTicks(8919), new DateTime(2021, 8, 30, 17, 39, 54, 358, DateTimeKind.Unspecified).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "05-5583", 5, new DateTime(2021, 10, 1, 22, 40, 16, 907, DateTimeKind.Unspecified).AddTicks(3738), new DateTime(2021, 8, 23, 1, 56, 41, 34, DateTimeKind.Unspecified).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "5R-3979", 3, new DateTime(2021, 9, 23, 20, 47, 46, 467, DateTimeKind.Unspecified).AddTicks(5823), new DateTime(2021, 8, 15, 11, 0, 23, 512, DateTimeKind.Unspecified).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "MZ-3793", 5, new DateTime(2021, 10, 21, 15, 43, 24, 92, DateTimeKind.Unspecified).AddTicks(8821), new DateTime(2021, 7, 15, 17, 35, 5, 463, DateTimeKind.Unspecified).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "B0-7971", 5, new DateTime(2021, 12, 25, 2, 42, 36, 302, DateTimeKind.Unspecified).AddTicks(5073), new DateTime(2021, 7, 23, 6, 41, 15, 885, DateTimeKind.Unspecified).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "06-1001", 1, new DateTime(2021, 9, 8, 9, 57, 31, 683, DateTimeKind.Unspecified).AddTicks(7287), new DateTime(2021, 7, 23, 23, 0, 50, 468, DateTimeKind.Unspecified).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "V2-4537", 5, new DateTime(2021, 10, 4, 7, 54, 33, 965, DateTimeKind.Unspecified).AddTicks(3839), new DateTime(2021, 5, 17, 21, 53, 10, 861, DateTimeKind.Unspecified).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "T4-2628", 5, new DateTime(2021, 9, 30, 19, 12, 41, 845, DateTimeKind.Unspecified).AddTicks(5747), new DateTime(2021, 8, 2, 9, 53, 22, 69, DateTimeKind.Unspecified).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "I8-3426", new DateTime(2021, 12, 24, 5, 22, 28, 182, DateTimeKind.Unspecified).AddTicks(8124), new DateTime(2021, 6, 5, 11, 22, 47, 96, DateTimeKind.Unspecified).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "OJ-5809", 5, new DateTime(2021, 10, 24, 15, 39, 37, 140, DateTimeKind.Unspecified).AddTicks(8239), new DateTime(2021, 5, 12, 7, 52, 18, 421, DateTimeKind.Unspecified).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "PL-7729", 1, new DateTime(2021, 9, 16, 16, 59, 48, 163, DateTimeKind.Unspecified).AddTicks(914), new DateTime(2021, 7, 4, 13, 5, 13, 11, DateTimeKind.Unspecified).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "54-0483", 3, new DateTime(2021, 11, 25, 3, 42, 43, 738, DateTimeKind.Unspecified).AddTicks(4641), new DateTime(2021, 6, 29, 21, 52, 11, 428, DateTimeKind.Unspecified).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "X9-8829", 2, new DateTime(2021, 11, 25, 8, 7, 10, 897, DateTimeKind.Unspecified).AddTicks(7099), new DateTime(2021, 8, 27, 2, 6, 52, 742, DateTimeKind.Unspecified).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "UQ-0381", 1, new DateTime(2021, 9, 3, 13, 55, 15, 667, DateTimeKind.Unspecified).AddTicks(387), new DateTime(2021, 8, 28, 23, 6, 38, 796, DateTimeKind.Unspecified).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "6N-9796", new DateTime(2021, 12, 8, 20, 4, 42, 719, DateTimeKind.Unspecified).AddTicks(4953), new DateTime(2021, 6, 30, 23, 39, 20, 882, DateTimeKind.Unspecified).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "32-5586", 4, new DateTime(2021, 9, 28, 7, 26, 59, 735, DateTimeKind.Unspecified).AddTicks(2490), new DateTime(2021, 8, 7, 12, 20, 19, 621, DateTimeKind.Unspecified).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "G1-3264", new DateTime(2021, 9, 26, 18, 41, 3, 102, DateTimeKind.Unspecified).AddTicks(4629), new DateTime(2021, 7, 7, 13, 1, 4, 655, DateTimeKind.Unspecified).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "S5-7354", 2, new DateTime(2021, 11, 28, 12, 38, 8, 870, DateTimeKind.Unspecified).AddTicks(9295), new DateTime(2021, 5, 25, 2, 46, 20, 533, DateTimeKind.Unspecified).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "5M-7346", 5, new DateTime(2021, 11, 18, 2, 21, 48, 323, DateTimeKind.Unspecified).AddTicks(4782), new DateTime(2021, 8, 28, 13, 2, 12, 633, DateTimeKind.Unspecified).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "78-4081", 5, new DateTime(2021, 12, 9, 16, 24, 6, 609, DateTimeKind.Unspecified).AddTicks(6289), new DateTime(2021, 6, 11, 6, 59, 58, 537, DateTimeKind.Unspecified).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "HG-2384", 1, new DateTime(2021, 12, 4, 22, 44, 13, 487, DateTimeKind.Unspecified).AddTicks(3822), new DateTime(2021, 8, 25, 4, 37, 12, 556, DateTimeKind.Unspecified).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "EO-8843", 4, new DateTime(2021, 9, 2, 0, 58, 7, 873, DateTimeKind.Unspecified).AddTicks(7004), new DateTime(2021, 5, 15, 16, 23, 19, 802, DateTimeKind.Unspecified).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "6H-1993", 2, new DateTime(2021, 10, 28, 1, 43, 48, 241, DateTimeKind.Unspecified).AddTicks(3765), new DateTime(2021, 8, 23, 16, 52, 25, 852, DateTimeKind.Unspecified).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "14-7559", 5, new DateTime(2021, 10, 9, 3, 31, 50, 685, DateTimeKind.Unspecified).AddTicks(5586), new DateTime(2021, 6, 3, 23, 40, 57, 109, DateTimeKind.Unspecified).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "39-4901", 2, new DateTime(2021, 11, 2, 5, 45, 19, 91, DateTimeKind.Unspecified).AddTicks(2492), new DateTime(2021, 5, 27, 17, 41, 29, 953, DateTimeKind.Unspecified).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "61-5648", 2, new DateTime(2021, 11, 27, 17, 17, 19, 341, DateTimeKind.Unspecified).AddTicks(1360), new DateTime(2021, 5, 18, 0, 43, 50, 284, DateTimeKind.Unspecified).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "9F-8016", 3, new DateTime(2021, 12, 14, 19, 37, 38, 882, DateTimeKind.Unspecified).AddTicks(4363), new DateTime(2021, 8, 18, 21, 42, 6, 786, DateTimeKind.Unspecified).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "AH-7726", 5, new DateTime(2021, 9, 20, 13, 8, 17, 122, DateTimeKind.Unspecified).AddTicks(2770), new DateTime(2021, 5, 26, 11, 17, 9, 433, DateTimeKind.Unspecified).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "32-9401", 2, new DateTime(2021, 11, 9, 2, 17, 15, 370, DateTimeKind.Unspecified).AddTicks(8648), new DateTime(2021, 6, 26, 10, 54, 50, 230, DateTimeKind.Unspecified).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "81-6506", 4, new DateTime(2021, 11, 7, 4, 51, 56, 609, DateTimeKind.Unspecified).AddTicks(4429), new DateTime(2021, 7, 8, 3, 41, 1, 533, DateTimeKind.Unspecified).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "E4-9475", 4, new DateTime(2021, 10, 27, 15, 6, 3, 448, DateTimeKind.Unspecified).AddTicks(8284), new DateTime(2021, 8, 29, 13, 30, 52, 299, DateTimeKind.Unspecified).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "ZA-5760", 3, new DateTime(2021, 12, 14, 8, 41, 20, 628, DateTimeKind.Unspecified).AddTicks(1742), new DateTime(2021, 8, 12, 16, 2, 49, 866, DateTimeKind.Unspecified).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "1L-8548", 5, new DateTime(2021, 12, 5, 7, 47, 45, 110, DateTimeKind.Unspecified).AddTicks(7516), new DateTime(2021, 6, 25, 8, 12, 9, 732, DateTimeKind.Unspecified).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "67-8880", 5, new DateTime(2021, 11, 24, 6, 30, 6, 341, DateTimeKind.Unspecified).AddTicks(9332), new DateTime(2021, 6, 27, 22, 4, 25, 447, DateTimeKind.Unspecified).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "A0-7595", 2, new DateTime(2021, 12, 5, 2, 50, 47, 717, DateTimeKind.Unspecified).AddTicks(6252), new DateTime(2021, 5, 8, 1, 21, 36, 720, DateTimeKind.Unspecified).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "3G-9168", 3, new DateTime(2021, 12, 30, 2, 9, 43, 841, DateTimeKind.Unspecified).AddTicks(9518), new DateTime(2021, 7, 25, 17, 23, 29, 126, DateTimeKind.Unspecified).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "87-4796", 4, new DateTime(2021, 12, 10, 19, 47, 43, 328, DateTimeKind.Unspecified).AddTicks(7657), new DateTime(2021, 7, 12, 12, 6, 58, 808, DateTimeKind.Unspecified).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "43-8941", new DateTime(2021, 11, 4, 6, 34, 48, 784, DateTimeKind.Unspecified).AddTicks(2959), new DateTime(2021, 6, 15, 8, 2, 6, 361, DateTimeKind.Unspecified).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "57-2619", 2, new DateTime(2021, 12, 24, 12, 25, 18, 524, DateTimeKind.Unspecified).AddTicks(8762), new DateTime(2021, 7, 11, 1, 1, 36, 95, DateTimeKind.Unspecified).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "25-2301", 4, new DateTime(2021, 10, 28, 17, 31, 44, 763, DateTimeKind.Unspecified).AddTicks(366), new DateTime(2021, 8, 10, 0, 26, 56, 106, DateTimeKind.Unspecified).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "2Q-4539", 3, new DateTime(2021, 12, 17, 18, 47, 21, 818, DateTimeKind.Unspecified).AddTicks(4133), new DateTime(2021, 7, 14, 18, 9, 34, 309, DateTimeKind.Unspecified).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "G0-1543", 5, new DateTime(2021, 11, 19, 22, 46, 27, 801, DateTimeKind.Unspecified).AddTicks(4395), new DateTime(2021, 8, 30, 19, 35, 4, 101, DateTimeKind.Unspecified).AddTicks(9038) });
        }
    }
}
