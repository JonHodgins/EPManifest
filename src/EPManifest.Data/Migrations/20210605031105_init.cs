using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carriers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consignees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consignees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consignors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consignors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manifests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DateShipped = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateScheduledArrival = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsigneeId = table.Column<int>(type: "int", nullable: false),
                    CarrierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manifests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manifests_Carriers_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Manifests_Consignees_ConsigneeId",
                        column: x => x.ConsigneeId,
                        principalTable: "Consignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsigneeAddresses",
                columns: table => new
                {
                    ManifestId = table.Column<int>(type: "int", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Province = table.Column<string>(type: "char(2)", nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsigneeAddresses", x => x.ManifestId);
                    table.ForeignKey(
                        name: "FK_ConsigneeAddresses_Manifests_ManifestId",
                        column: x => x.ManifestId,
                        principalTable: "Manifests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsignorAddresses",
                columns: table => new
                {
                    ManifestId = table.Column<int>(type: "int", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Province = table.Column<string>(type: "char(2)", nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsignorAddresses", x => x.ManifestId);
                    table.ForeignKey(
                        name: "FK_ConsignorAddresses_Manifests_ManifestId",
                        column: x => x.ManifestId,
                        principalTable: "Manifests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsignorManifest",
                columns: table => new
                {
                    ConsignorId = table.Column<int>(type: "int", nullable: false),
                    ManifestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsignorManifest", x => new { x.ManifestId, x.ConsignorId });
                    table.ForeignKey(
                        name: "FK_ConsignorManifest_Consignors_ConsignorId",
                        column: x => x.ConsignorId,
                        principalTable: "Consignors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsignorManifest_Manifests_ManifestId",
                        column: x => x.ManifestId,
                        principalTable: "Manifests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(16,2)", precision: 16, scale: 2, nullable: false),
                    Unit = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    ManifestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Manifests_ManifestId",
                        column: x => x.ManifestId,
                        principalTable: "Manifests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carriers",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "50101", "A1 Delivery" },
                    { 2, "10-4010", "Pacific Northwest Freight" },
                    { 3, "40-020", "AP Freight" },
                    { 4, "60-10", "NM Shipping Inc" },
                    { 5, "60-05", "Frank's Freight" }
                });

            migrationBuilder.InsertData(
                table: "Consignees",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "AB-120", "Pete's Disposal" },
                    { 2, "AB-410", "ATI Environmental" },
                    { 3, "AB-019", "EQ Enviro" },
                    { 4, "AB-918", "Whitehorse Landfill" },
                    { 5, "AB-412", "YAE" }
                });

            migrationBuilder.InsertData(
                table: "Consignors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 13, "6J-O14", "Ryan - Kihn" },
                    { 12, "58-7PV", "Kilback - Legros" },
                    { 11, "72-I0T", "Kautzer - Pfannerstill" },
                    { 10, "5J-H59", "Turcotte - Crooks" },
                    { 9, "4D-31Z", "Considine, Stracke and Schmidt" },
                    { 8, "89-K38", "Hirthe Group" },
                    { 3, "B-5010", "Whitehorse General Hospital" },
                    { 6, "H6-CX5", "Lubowitz - Kuvalis" },
                    { 5, "A840", "Whistle Bend Place" },
                    { 4, "A1-102", "Teslin Health Centre" },
                    { 14, "MU-EZ7", "Dickens LLC" },
                    { 2, "A-000", "Mayo Health Centre" },
                    { 1, "OXP-4", "Carmacks Health Clinic" },
                    { 7, "16-I16", "Ankunding, Greenfelder and Ryan" },
                    { 15, "CE-OZ7", "Hauck Inc" }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 2, 4, "2O-8971", 1, new DateTime(2021, 11, 11, 12, 33, 43, 555, DateTimeKind.Unspecified).AddTicks(9734), new DateTime(2021, 6, 17, 4, 39, 3, 632, DateTimeKind.Unspecified).AddTicks(7863) },
                    { 93, 1, "O6-1999", 4, new DateTime(2021, 10, 14, 8, 47, 13, 241, DateTimeKind.Unspecified).AddTicks(6712), new DateTime(2021, 6, 30, 17, 10, 55, 438, DateTimeKind.Unspecified).AddTicks(3700) },
                    { 96, 2, "3K-3095", 4, new DateTime(2021, 12, 12, 7, 0, 13, 381, DateTimeKind.Unspecified).AddTicks(1368), new DateTime(2021, 6, 9, 11, 15, 11, 548, DateTimeKind.Unspecified).AddTicks(1759) },
                    { 98, 5, "2A-1273", 4, new DateTime(2021, 11, 21, 15, 12, 53, 642, DateTimeKind.Unspecified).AddTicks(2585), new DateTime(2021, 6, 5, 3, 52, 44, 895, DateTimeKind.Unspecified).AddTicks(8554) },
                    { 102, 5, "K5-4375", 4, new DateTime(2021, 10, 20, 1, 20, 0, 0, DateTimeKind.Unspecified).AddTicks(6817), new DateTime(2021, 7, 26, 14, 15, 38, 962, DateTimeKind.Unspecified).AddTicks(335) },
                    { 104, 4, "1S-7206", 4, new DateTime(2021, 10, 31, 1, 40, 47, 240, DateTimeKind.Unspecified).AddTicks(3465), new DateTime(2021, 8, 22, 4, 38, 29, 821, DateTimeKind.Unspecified).AddTicks(5837) },
                    { 111, 4, "R6-1902", 4, new DateTime(2021, 10, 26, 5, 54, 45, 522, DateTimeKind.Unspecified).AddTicks(7376), new DateTime(2021, 8, 18, 21, 0, 37, 955, DateTimeKind.Unspecified).AddTicks(9348) },
                    { 113, 3, "DL-4976", 4, new DateTime(2021, 9, 26, 11, 36, 4, 473, DateTimeKind.Unspecified).AddTicks(3460), new DateTime(2021, 7, 21, 16, 53, 15, 20, DateTimeKind.Unspecified).AddTicks(9871) },
                    { 118, 3, "7H-1190", 4, new DateTime(2021, 12, 30, 23, 18, 2, 459, DateTimeKind.Unspecified).AddTicks(776), new DateTime(2021, 7, 29, 6, 56, 20, 214, DateTimeKind.Unspecified).AddTicks(1857) },
                    { 121, 5, "52-8232", 4, new DateTime(2021, 9, 8, 3, 51, 26, 181, DateTimeKind.Unspecified).AddTicks(8989), new DateTime(2021, 5, 18, 2, 7, 48, 260, DateTimeKind.Unspecified).AddTicks(9653) },
                    { 122, 3, "FA-8528", 4, new DateTime(2021, 11, 4, 3, 16, 17, 346, DateTimeKind.Unspecified).AddTicks(9875), new DateTime(2021, 7, 31, 12, 54, 45, 658, DateTimeKind.Unspecified).AddTicks(8446) },
                    { 125, 4, "14-2559", 4, new DateTime(2021, 9, 13, 16, 8, 7, 27, DateTimeKind.Unspecified).AddTicks(1044), new DateTime(2021, 5, 24, 16, 4, 34, 96, DateTimeKind.Unspecified).AddTicks(6157) },
                    { 129, 2, "2O-9304", 4, new DateTime(2021, 11, 27, 8, 18, 30, 994, DateTimeKind.Unspecified).AddTicks(13), new DateTime(2021, 5, 12, 14, 6, 8, 648, DateTimeKind.Unspecified).AddTicks(6913) },
                    { 137, 5, "B8-5952", 4, new DateTime(2021, 10, 3, 23, 42, 19, 25, DateTimeKind.Unspecified).AddTicks(9917), new DateTime(2021, 7, 3, 5, 53, 14, 293, DateTimeKind.Unspecified).AddTicks(7413) },
                    { 140, 3, "69-0762", 4, new DateTime(2021, 12, 16, 10, 7, 2, 112, DateTimeKind.Unspecified).AddTicks(1779), new DateTime(2021, 7, 27, 8, 26, 20, 454, DateTimeKind.Unspecified).AddTicks(8226) },
                    { 143, 5, "7R-6974", 4, new DateTime(2021, 9, 12, 15, 59, 19, 399, DateTimeKind.Unspecified).AddTicks(5496), new DateTime(2021, 5, 25, 14, 15, 17, 259, DateTimeKind.Unspecified).AddTicks(331) },
                    { 144, 1, "76-1815", 4, new DateTime(2021, 11, 7, 0, 39, 7, 755, DateTimeKind.Unspecified).AddTicks(8847), new DateTime(2021, 7, 30, 10, 35, 34, 575, DateTimeKind.Unspecified).AddTicks(688) },
                    { 149, 4, "FI-5429", 4, new DateTime(2021, 12, 22, 18, 10, 27, 578, DateTimeKind.Unspecified).AddTicks(2398), new DateTime(2021, 8, 29, 23, 24, 11, 410, DateTimeKind.Unspecified).AddTicks(2449) },
                    { 153, 5, "Z5-1540", 4, new DateTime(2021, 10, 11, 16, 29, 43, 593, DateTimeKind.Unspecified).AddTicks(8805), new DateTime(2021, 8, 29, 0, 25, 32, 264, DateTimeKind.Unspecified).AddTicks(292) },
                    { 154, 4, "K8-9703", 4, new DateTime(2021, 9, 28, 15, 45, 48, 527, DateTimeKind.Unspecified).AddTicks(3834), new DateTime(2021, 5, 17, 19, 6, 6, 121, DateTimeKind.Unspecified).AddTicks(7905) },
                    { 155, 4, "55-2852", 4, new DateTime(2021, 11, 25, 5, 5, 46, 905, DateTimeKind.Unspecified).AddTicks(7243), new DateTime(2021, 8, 11, 18, 22, 50, 455, DateTimeKind.Unspecified).AddTicks(4419) },
                    { 159, 5, "W7-4973", 4, new DateTime(2021, 10, 25, 1, 11, 55, 634, DateTimeKind.Unspecified).AddTicks(8919), new DateTime(2021, 8, 30, 17, 39, 54, 358, DateTimeKind.Unspecified).AddTicks(2488) },
                    { 80, 4, "05-4182", 4, new DateTime(2021, 10, 8, 8, 14, 36, 564, DateTimeKind.Unspecified).AddTicks(2930), new DateTime(2021, 7, 20, 5, 54, 31, 143, DateTimeKind.Unspecified).AddTicks(4955) },
                    { 174, 4, "32-5586", 4, new DateTime(2021, 9, 28, 7, 26, 59, 735, DateTimeKind.Unspecified).AddTicks(2490), new DateTime(2021, 8, 7, 12, 20, 19, 621, DateTimeKind.Unspecified).AddTicks(8101) },
                    { 76, 4, "14-4975", 4, new DateTime(2021, 9, 12, 15, 45, 20, 144, DateTimeKind.Unspecified).AddTicks(5963), new DateTime(2021, 8, 29, 9, 31, 31, 632, DateTimeKind.Unspecified).AddTicks(7249) },
                    { 72, 2, "7M-2993", 4, new DateTime(2021, 10, 18, 8, 37, 43, 661, DateTimeKind.Unspecified).AddTicks(4572), new DateTime(2021, 7, 16, 2, 35, 18, 321, DateTimeKind.Unspecified).AddTicks(4991) },
                    { 156, 5, "12-1921", 3, new DateTime(2021, 10, 12, 1, 32, 15, 703, DateTimeKind.Unspecified).AddTicks(3904), new DateTime(2021, 8, 19, 12, 9, 47, 617, DateTimeKind.Unspecified).AddTicks(4326) },
                    { 158, 3, "8S-4769", 3, new DateTime(2021, 12, 1, 21, 58, 50, 703, DateTimeKind.Unspecified).AddTicks(7588), new DateTime(2021, 6, 17, 16, 13, 13, 635, DateTimeKind.Unspecified).AddTicks(4194) },
                    { 161, 1, "5R-3979", 3, new DateTime(2021, 9, 23, 20, 47, 46, 467, DateTimeKind.Unspecified).AddTicks(5823), new DateTime(2021, 8, 15, 11, 0, 23, 512, DateTimeKind.Unspecified).AddTicks(7991) },
                    { 170, 2, "54-0483", 3, new DateTime(2021, 11, 25, 3, 42, 43, 738, DateTimeKind.Unspecified).AddTicks(4641), new DateTime(2021, 6, 29, 21, 52, 11, 428, DateTimeKind.Unspecified).AddTicks(3946) },
                    { 185, 4, "9F-8016", 3, new DateTime(2021, 12, 14, 19, 37, 38, 882, DateTimeKind.Unspecified).AddTicks(4363), new DateTime(2021, 8, 18, 21, 42, 6, 786, DateTimeKind.Unspecified).AddTicks(7333) },
                    { 190, 2, "ZA-5760", 3, new DateTime(2021, 12, 14, 8, 41, 20, 628, DateTimeKind.Unspecified).AddTicks(1742), new DateTime(2021, 8, 12, 16, 2, 49, 866, DateTimeKind.Unspecified).AddTicks(2416) },
                    { 194, 5, "3G-9168", 3, new DateTime(2021, 12, 30, 2, 9, 43, 841, DateTimeKind.Unspecified).AddTicks(9518), new DateTime(2021, 7, 25, 17, 23, 29, 126, DateTimeKind.Unspecified).AddTicks(8995) },
                    { 199, 4, "2Q-4539", 3, new DateTime(2021, 12, 17, 18, 47, 21, 818, DateTimeKind.Unspecified).AddTicks(4133), new DateTime(2021, 7, 14, 18, 9, 34, 309, DateTimeKind.Unspecified).AddTicks(1262) },
                    { 4, 5, "4F-1577", 4, new DateTime(2021, 10, 4, 0, 6, 57, 812, DateTimeKind.Unspecified).AddTicks(7410), new DateTime(2021, 8, 6, 10, 48, 7, 653, DateTimeKind.Unspecified).AddTicks(7042) },
                    { 5, 5, "48-5181", 4, new DateTime(2021, 11, 2, 18, 2, 22, 946, DateTimeKind.Unspecified).AddTicks(9113), new DateTime(2021, 8, 12, 19, 9, 32, 63, DateTimeKind.Unspecified).AddTicks(9848) },
                    { 14, 3, "27-1290", 4, new DateTime(2021, 10, 28, 2, 35, 11, 541, DateTimeKind.Unspecified).AddTicks(2502), new DateTime(2021, 8, 5, 0, 22, 56, 873, DateTimeKind.Unspecified).AddTicks(7233) },
                    { 28, 3, "WU-9089", 4, new DateTime(2021, 9, 29, 20, 40, 52, 414, DateTimeKind.Unspecified).AddTicks(6278), new DateTime(2021, 6, 8, 14, 25, 10, 791, DateTimeKind.Unspecified).AddTicks(8027) },
                    { 30, 2, "59-0559", 4, new DateTime(2021, 10, 19, 12, 53, 2, 413, DateTimeKind.Unspecified).AddTicks(3374), new DateTime(2021, 8, 15, 12, 59, 2, 230, DateTimeKind.Unspecified).AddTicks(9795) },
                    { 39, 2, "1N-3859", 4, new DateTime(2021, 10, 31, 7, 38, 16, 502, DateTimeKind.Unspecified).AddTicks(6507), new DateTime(2021, 8, 25, 17, 22, 13, 260, DateTimeKind.Unspecified).AddTicks(4029) },
                    { 44, 3, "10-5734", 4, new DateTime(2021, 11, 7, 0, 24, 57, 216, DateTimeKind.Unspecified).AddTicks(4221), new DateTime(2021, 7, 5, 23, 11, 46, 944, DateTimeKind.Unspecified).AddTicks(3570) },
                    { 46, 4, "6H-0650", 4, new DateTime(2021, 11, 17, 22, 35, 9, 662, DateTimeKind.Unspecified).AddTicks(1683), new DateTime(2021, 6, 9, 14, 58, 45, 578, DateTimeKind.Unspecified).AddTicks(8235) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 47, 1, "9U-3241", 4, new DateTime(2021, 11, 5, 15, 25, 28, 724, DateTimeKind.Unspecified).AddTicks(7454), new DateTime(2021, 5, 12, 17, 31, 10, 209, DateTimeKind.Unspecified).AddTicks(95) },
                    { 49, 1, "10-8481", 4, new DateTime(2021, 11, 16, 17, 2, 29, 705, DateTimeKind.Unspecified).AddTicks(5265), new DateTime(2021, 7, 9, 12, 45, 9, 262, DateTimeKind.Unspecified).AddTicks(6145) },
                    { 50, 1, "21-3671", 4, new DateTime(2021, 9, 24, 12, 43, 23, 176, DateTimeKind.Unspecified).AddTicks(2053), new DateTime(2021, 5, 25, 12, 38, 0, 704, DateTimeKind.Unspecified).AddTicks(858) },
                    { 59, 1, "DX-8313", 4, new DateTime(2021, 9, 29, 10, 36, 31, 216, DateTimeKind.Unspecified).AddTicks(4031), new DateTime(2021, 5, 20, 15, 21, 32, 809, DateTimeKind.Unspecified).AddTicks(9920) },
                    { 71, 5, "41-9370", 4, new DateTime(2021, 9, 7, 23, 30, 45, 9, DateTimeKind.Unspecified).AddTicks(8000), new DateTime(2021, 8, 19, 10, 51, 30, 909, DateTimeKind.Unspecified).AddTicks(6527) },
                    { 74, 5, "14-6043", 4, new DateTime(2021, 9, 1, 23, 32, 28, 665, DateTimeKind.Unspecified).AddTicks(7254), new DateTime(2021, 5, 27, 23, 44, 42, 980, DateTimeKind.Unspecified).AddTicks(6324) },
                    { 150, 5, "PE-6610", 3, new DateTime(2021, 11, 26, 0, 51, 35, 999, DateTimeKind.Unspecified).AddTicks(7847), new DateTime(2021, 7, 16, 6, 8, 21, 778, DateTimeKind.Unspecified).AddTicks(168) },
                    { 180, 2, "EO-8843", 4, new DateTime(2021, 9, 2, 0, 58, 7, 873, DateTimeKind.Unspecified).AddTicks(7004), new DateTime(2021, 5, 15, 16, 23, 19, 802, DateTimeKind.Unspecified).AddTicks(3591) },
                    { 189, 2, "E4-9475", 4, new DateTime(2021, 10, 27, 15, 6, 3, 448, DateTimeKind.Unspecified).AddTicks(8284), new DateTime(2021, 8, 29, 13, 30, 52, 299, DateTimeKind.Unspecified).AddTicks(5579) },
                    { 126, 5, "9H-7908", 5, new DateTime(2021, 9, 18, 16, 20, 49, 137, DateTimeKind.Unspecified).AddTicks(1131), new DateTime(2021, 6, 18, 10, 17, 44, 428, DateTimeKind.Unspecified).AddTicks(1471) },
                    { 130, 3, "WU-7053", 5, new DateTime(2021, 9, 18, 14, 49, 12, 320, DateTimeKind.Unspecified).AddTicks(2146), new DateTime(2021, 6, 2, 18, 11, 5, 283, DateTimeKind.Unspecified).AddTicks(4467) },
                    { 133, 5, "44-5934", 5, new DateTime(2021, 11, 3, 2, 27, 22, 399, DateTimeKind.Unspecified).AddTicks(6385), new DateTime(2021, 6, 27, 15, 16, 21, 749, DateTimeKind.Unspecified).AddTicks(2771) },
                    { 135, 3, "H3-1459", 5, new DateTime(2021, 10, 15, 1, 47, 38, 91, DateTimeKind.Unspecified).AddTicks(7493), new DateTime(2021, 5, 15, 9, 41, 14, 654, DateTimeKind.Unspecified).AddTicks(3868) },
                    { 136, 3, "1F-8182", 5, new DateTime(2021, 10, 20, 16, 4, 50, 4, DateTimeKind.Unspecified).AddTicks(7572), new DateTime(2021, 5, 20, 5, 31, 58, 705, DateTimeKind.Unspecified).AddTicks(7290) },
                    { 141, 4, "G5-9596", 5, new DateTime(2021, 10, 1, 1, 27, 37, 203, DateTimeKind.Unspecified).AddTicks(3117), new DateTime(2021, 8, 20, 8, 9, 43, 366, DateTimeKind.Unspecified).AddTicks(7683) },
                    { 145, 3, "KP-3236", 5, new DateTime(2021, 9, 20, 17, 15, 41, 967, DateTimeKind.Unspecified).AddTicks(2928), new DateTime(2021, 7, 7, 8, 35, 14, 739, DateTimeKind.Unspecified).AddTicks(7945) },
                    { 151, 3, "2U-6772", 5, new DateTime(2021, 12, 12, 23, 5, 29, 625, DateTimeKind.Unspecified).AddTicks(7436), new DateTime(2021, 8, 20, 20, 9, 18, 833, DateTimeKind.Unspecified).AddTicks(4675) },
                    { 157, 1, "UM-0122", 5, new DateTime(2021, 11, 17, 2, 0, 34, 180, DateTimeKind.Unspecified).AddTicks(3584), new DateTime(2021, 5, 28, 11, 0, 23, 700, DateTimeKind.Unspecified).AddTicks(8086) },
                    { 160, 3, "05-5583", 5, new DateTime(2021, 10, 1, 22, 40, 16, 907, DateTimeKind.Unspecified).AddTicks(3738), new DateTime(2021, 8, 23, 1, 56, 41, 34, DateTimeKind.Unspecified).AddTicks(872) },
                    { 162, 2, "MZ-3793", 5, new DateTime(2021, 10, 21, 15, 43, 24, 92, DateTimeKind.Unspecified).AddTicks(8821), new DateTime(2021, 7, 15, 17, 35, 5, 463, DateTimeKind.Unspecified).AddTicks(8993) },
                    { 163, 5, "B0-7971", 5, new DateTime(2021, 12, 25, 2, 42, 36, 302, DateTimeKind.Unspecified).AddTicks(5073), new DateTime(2021, 7, 23, 6, 41, 15, 885, DateTimeKind.Unspecified).AddTicks(8376) },
                    { 165, 2, "V2-4537", 5, new DateTime(2021, 10, 4, 7, 54, 33, 965, DateTimeKind.Unspecified).AddTicks(3839), new DateTime(2021, 5, 17, 21, 53, 10, 861, DateTimeKind.Unspecified).AddTicks(234) },
                    { 166, 5, "T4-2628", 5, new DateTime(2021, 9, 30, 19, 12, 41, 845, DateTimeKind.Unspecified).AddTicks(5747), new DateTime(2021, 8, 2, 9, 53, 22, 69, DateTimeKind.Unspecified).AddTicks(3513) },
                    { 168, 4, "OJ-5809", 5, new DateTime(2021, 10, 24, 15, 39, 37, 140, DateTimeKind.Unspecified).AddTicks(8239), new DateTime(2021, 5, 12, 7, 52, 18, 421, DateTimeKind.Unspecified).AddTicks(7215) },
                    { 175, 2, "G1-3264", 5, new DateTime(2021, 9, 26, 18, 41, 3, 102, DateTimeKind.Unspecified).AddTicks(4629), new DateTime(2021, 7, 7, 13, 1, 4, 655, DateTimeKind.Unspecified).AddTicks(9039) },
                    { 177, 4, "5M-7346", 5, new DateTime(2021, 11, 18, 2, 21, 48, 323, DateTimeKind.Unspecified).AddTicks(4782), new DateTime(2021, 8, 28, 13, 2, 12, 633, DateTimeKind.Unspecified).AddTicks(6483) },
                    { 178, 5, "78-4081", 5, new DateTime(2021, 12, 9, 16, 24, 6, 609, DateTimeKind.Unspecified).AddTicks(6289), new DateTime(2021, 6, 11, 6, 59, 58, 537, DateTimeKind.Unspecified).AddTicks(1215) },
                    { 182, 3, "14-7559", 5, new DateTime(2021, 10, 9, 3, 31, 50, 685, DateTimeKind.Unspecified).AddTicks(5586), new DateTime(2021, 6, 3, 23, 40, 57, 109, DateTimeKind.Unspecified).AddTicks(4374) },
                    { 186, 5, "AH-7726", 5, new DateTime(2021, 9, 20, 13, 8, 17, 122, DateTimeKind.Unspecified).AddTicks(2770), new DateTime(2021, 5, 26, 11, 17, 9, 433, DateTimeKind.Unspecified).AddTicks(7968) },
                    { 191, 5, "1L-8548", 5, new DateTime(2021, 12, 5, 7, 47, 45, 110, DateTimeKind.Unspecified).AddTicks(7516), new DateTime(2021, 6, 25, 8, 12, 9, 732, DateTimeKind.Unspecified).AddTicks(3797) },
                    { 120, 3, "Q1-1312", 5, new DateTime(2021, 9, 20, 3, 9, 12, 854, DateTimeKind.Unspecified).AddTicks(2184), new DateTime(2021, 6, 13, 23, 3, 24, 489, DateTimeKind.Unspecified).AddTicks(1863) },
                    { 188, 3, "81-6506", 4, new DateTime(2021, 11, 7, 4, 51, 56, 609, DateTimeKind.Unspecified).AddTicks(4429), new DateTime(2021, 7, 8, 3, 41, 1, 533, DateTimeKind.Unspecified).AddTicks(5064) },
                    { 119, 3, "J8-5880", 5, new DateTime(2021, 10, 7, 2, 34, 12, 492, DateTimeKind.Unspecified).AddTicks(432), new DateTime(2021, 5, 25, 20, 37, 36, 462, DateTimeKind.Unspecified).AddTicks(9245) },
                    { 107, 1, "9M-8069", 5, new DateTime(2021, 11, 27, 21, 28, 7, 662, DateTimeKind.Unspecified).AddTicks(6986), new DateTime(2021, 5, 31, 1, 40, 51, 158, DateTimeKind.Unspecified).AddTicks(4504) },
                    { 195, 2, "87-4796", 4, new DateTime(2021, 12, 10, 19, 47, 43, 328, DateTimeKind.Unspecified).AddTicks(7657), new DateTime(2021, 7, 12, 12, 6, 58, 808, DateTimeKind.Unspecified).AddTicks(4910) },
                    { 196, 3, "43-8941", 4, new DateTime(2021, 11, 4, 6, 34, 48, 784, DateTimeKind.Unspecified).AddTicks(2959), new DateTime(2021, 6, 15, 8, 2, 6, 361, DateTimeKind.Unspecified).AddTicks(2807) },
                    { 198, 5, "25-2301", 4, new DateTime(2021, 10, 28, 17, 31, 44, 763, DateTimeKind.Unspecified).AddTicks(366), new DateTime(2021, 8, 10, 0, 26, 56, 106, DateTimeKind.Unspecified).AddTicks(5839) },
                    { 1, 2, "ZW-1809", 5, new DateTime(2021, 9, 20, 22, 43, 9, 627, DateTimeKind.Unspecified).AddTicks(164), new DateTime(2021, 8, 14, 21, 32, 44, 816, DateTimeKind.Unspecified).AddTicks(536) },
                    { 7, 4, "45-0580", 5, new DateTime(2021, 9, 6, 15, 12, 45, 502, DateTimeKind.Unspecified).AddTicks(1297), new DateTime(2021, 8, 4, 9, 49, 22, 920, DateTimeKind.Unspecified).AddTicks(2158) },
                    { 16, 5, "0X-3836", 5, new DateTime(2021, 9, 30, 6, 31, 31, 469, DateTimeKind.Unspecified).AddTicks(6549), new DateTime(2021, 6, 16, 6, 38, 54, 88, DateTimeKind.Unspecified).AddTicks(9401) },
                    { 19, 2, "0W-1161", 5, new DateTime(2021, 12, 4, 1, 41, 30, 46, DateTimeKind.Unspecified).AddTicks(4712), new DateTime(2021, 7, 15, 20, 12, 58, 775, DateTimeKind.Unspecified).AddTicks(2237) },
                    { 22, 1, "03-3502", 5, new DateTime(2021, 10, 9, 14, 18, 23, 177, DateTimeKind.Unspecified).AddTicks(3971), new DateTime(2021, 5, 25, 21, 45, 31, 854, DateTimeKind.Unspecified).AddTicks(8225) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 23, 5, "I7-0566", 5, new DateTime(2021, 12, 24, 4, 1, 40, 483, DateTimeKind.Unspecified).AddTicks(2142), new DateTime(2021, 8, 17, 1, 12, 30, 144, DateTimeKind.Unspecified).AddTicks(9039) },
                    { 31, 3, "0E-4503", 5, new DateTime(2021, 12, 15, 22, 39, 59, 979, DateTimeKind.Unspecified).AddTicks(8052), new DateTime(2021, 5, 17, 0, 15, 11, 155, DateTimeKind.Unspecified).AddTicks(663) },
                    { 32, 2, "4G-0538", 5, new DateTime(2021, 10, 25, 2, 54, 54, 887, DateTimeKind.Unspecified).AddTicks(1155), new DateTime(2021, 7, 8, 3, 57, 19, 382, DateTimeKind.Unspecified).AddTicks(1559) },
                    { 33, 3, "XC-0351", 5, new DateTime(2021, 10, 24, 9, 5, 13, 23, DateTimeKind.Unspecified).AddTicks(3828), new DateTime(2021, 6, 19, 12, 41, 26, 559, DateTimeKind.Unspecified).AddTicks(7386) },
                    { 43, 1, "FA-5866", 5, new DateTime(2021, 10, 1, 9, 35, 3, 316, DateTimeKind.Unspecified).AddTicks(7106), new DateTime(2021, 8, 14, 13, 40, 35, 993, DateTimeKind.Unspecified).AddTicks(2339) },
                    { 53, 1, "PS-1729", 5, new DateTime(2021, 10, 7, 20, 8, 45, 261, DateTimeKind.Unspecified).AddTicks(4910), new DateTime(2021, 7, 3, 10, 24, 48, 907, DateTimeKind.Unspecified).AddTicks(2369) },
                    { 55, 1, "5U-3081", 5, new DateTime(2021, 10, 17, 19, 44, 43, 914, DateTimeKind.Unspecified).AddTicks(4099), new DateTime(2021, 5, 21, 14, 19, 20, 570, DateTimeKind.Unspecified).AddTicks(8496) },
                    { 56, 5, "53-5638", 5, new DateTime(2021, 12, 22, 11, 14, 35, 765, DateTimeKind.Unspecified).AddTicks(8715), new DateTime(2021, 8, 6, 1, 13, 26, 366, DateTimeKind.Unspecified).AddTicks(5664) },
                    { 69, 3, "64-1921", 5, new DateTime(2021, 9, 18, 2, 6, 34, 779, DateTimeKind.Unspecified).AddTicks(62), new DateTime(2021, 5, 17, 5, 46, 36, 673, DateTimeKind.Unspecified).AddTicks(2465) },
                    { 75, 1, "93-3970", 5, new DateTime(2021, 10, 8, 14, 23, 10, 926, DateTimeKind.Unspecified).AddTicks(2287), new DateTime(2021, 7, 27, 7, 47, 14, 897, DateTimeKind.Unspecified).AddTicks(8397) },
                    { 79, 2, "ZU-0623", 5, new DateTime(2021, 12, 2, 15, 32, 5, 547, DateTimeKind.Unspecified).AddTicks(7793), new DateTime(2021, 7, 10, 17, 13, 47, 674, DateTimeKind.Unspecified).AddTicks(80) },
                    { 94, 2, "5S-0931", 5, new DateTime(2021, 10, 5, 8, 38, 8, 871, DateTimeKind.Unspecified).AddTicks(7811), new DateTime(2021, 6, 6, 18, 19, 2, 379, DateTimeKind.Unspecified).AddTicks(9136) },
                    { 103, 3, "XM-5818", 5, new DateTime(2021, 11, 3, 22, 36, 37, 559, DateTimeKind.Unspecified).AddTicks(1368), new DateTime(2021, 5, 28, 23, 37, 58, 704, DateTimeKind.Unspecified).AddTicks(5309) },
                    { 117, 4, "NT-4104", 5, new DateTime(2021, 9, 30, 19, 24, 45, 621, DateTimeKind.Unspecified).AddTicks(7337), new DateTime(2021, 7, 15, 19, 41, 39, 919, DateTimeKind.Unspecified).AddTicks(9944) },
                    { 142, 2, "4G-6004", 3, new DateTime(2021, 11, 7, 21, 37, 45, 595, DateTimeKind.Unspecified).AddTicks(6333), new DateTime(2021, 6, 12, 19, 48, 24, 876, DateTimeKind.Unspecified).AddTicks(1968) },
                    { 138, 2, "A5-2465", 3, new DateTime(2021, 10, 27, 20, 30, 24, 261, DateTimeKind.Unspecified).AddTicks(8085), new DateTime(2021, 5, 28, 16, 26, 44, 43, DateTimeKind.Unspecified).AddTicks(8183) },
                    { 132, 1, "42-9548", 3, new DateTime(2021, 11, 25, 22, 13, 45, 760, DateTimeKind.Unspecified).AddTicks(1395), new DateTime(2021, 7, 17, 3, 32, 27, 704, DateTimeKind.Unspecified).AddTicks(9514) },
                    { 10, 3, "20-0861", 2, new DateTime(2021, 11, 15, 1, 9, 34, 683, DateTimeKind.Unspecified).AddTicks(4536), new DateTime(2021, 5, 31, 7, 27, 42, 927, DateTimeKind.Unspecified).AddTicks(887) },
                    { 13, 4, "G7-3276", 2, new DateTime(2021, 12, 7, 13, 49, 21, 339, DateTimeKind.Unspecified).AddTicks(8918), new DateTime(2021, 7, 31, 2, 33, 8, 513, DateTimeKind.Unspecified).AddTicks(3116) },
                    { 15, 4, "3F-7028", 2, new DateTime(2021, 12, 26, 20, 6, 11, 105, DateTimeKind.Unspecified).AddTicks(5377), new DateTime(2021, 8, 28, 2, 44, 35, 749, DateTimeKind.Unspecified).AddTicks(1337) },
                    { 18, 3, "ME-4952", 2, new DateTime(2021, 9, 9, 10, 29, 12, 735, DateTimeKind.Unspecified).AddTicks(3775), new DateTime(2021, 7, 23, 9, 22, 36, 98, DateTimeKind.Unspecified).AddTicks(8762) },
                    { 20, 4, "01-8540", 2, new DateTime(2021, 12, 10, 19, 52, 34, 515, DateTimeKind.Unspecified).AddTicks(8407), new DateTime(2021, 6, 8, 19, 17, 11, 223, DateTimeKind.Unspecified).AddTicks(2326) },
                    { 21, 5, "F9-4091", 2, new DateTime(2021, 11, 21, 8, 2, 3, 333, DateTimeKind.Unspecified).AddTicks(6971), new DateTime(2021, 7, 23, 5, 40, 53, 629, DateTimeKind.Unspecified).AddTicks(8847) },
                    { 40, 3, "96-0934", 2, new DateTime(2021, 11, 6, 19, 8, 11, 761, DateTimeKind.Unspecified).AddTicks(1413), new DateTime(2021, 5, 26, 14, 11, 2, 21, DateTimeKind.Unspecified).AddTicks(7531) },
                    { 48, 5, "99-0072", 2, new DateTime(2021, 12, 14, 11, 43, 18, 979, DateTimeKind.Unspecified).AddTicks(9815), new DateTime(2021, 8, 12, 3, 48, 42, 768, DateTimeKind.Unspecified).AddTicks(5828) },
                    { 52, 3, "J2-1870", 2, new DateTime(2021, 12, 6, 1, 42, 15, 965, DateTimeKind.Unspecified).AddTicks(9969), new DateTime(2021, 7, 28, 1, 11, 45, 874, DateTimeKind.Unspecified).AddTicks(9770) },
                    { 57, 5, "B1-9213", 2, new DateTime(2021, 11, 12, 8, 21, 35, 421, DateTimeKind.Unspecified).AddTicks(4057), new DateTime(2021, 6, 20, 12, 11, 37, 261, DateTimeKind.Unspecified).AddTicks(7786) },
                    { 62, 3, "2Z-7988", 2, new DateTime(2021, 11, 14, 18, 42, 15, 190, DateTimeKind.Unspecified).AddTicks(7060), new DateTime(2021, 5, 30, 12, 24, 1, 751, DateTimeKind.Unspecified).AddTicks(2833) },
                    { 65, 5, "0F-7775", 2, new DateTime(2021, 12, 5, 14, 28, 34, 118, DateTimeKind.Unspecified).AddTicks(5616), new DateTime(2021, 6, 19, 0, 13, 25, 965, DateTimeKind.Unspecified).AddTicks(2928) },
                    { 67, 3, "6C-6627", 2, new DateTime(2021, 12, 4, 8, 36, 38, 64, DateTimeKind.Unspecified).AddTicks(4281), new DateTime(2021, 5, 22, 6, 33, 11, 922, DateTimeKind.Unspecified).AddTicks(8217) },
                    { 68, 1, "TT-0318", 2, new DateTime(2021, 12, 1, 6, 49, 48, 970, DateTimeKind.Unspecified).AddTicks(4416), new DateTime(2021, 8, 25, 10, 8, 54, 776, DateTimeKind.Unspecified).AddTicks(9863) },
                    { 70, 2, "6O-7647", 2, new DateTime(2021, 10, 24, 22, 38, 28, 828, DateTimeKind.Unspecified).AddTicks(6601), new DateTime(2021, 6, 12, 19, 35, 35, 779, DateTimeKind.Unspecified).AddTicks(9858) },
                    { 73, 5, "66-6249", 2, new DateTime(2021, 11, 27, 14, 10, 37, 459, DateTimeKind.Unspecified).AddTicks(9471), new DateTime(2021, 5, 8, 10, 42, 29, 345, DateTimeKind.Unspecified).AddTicks(5411) },
                    { 83, 3, "H3-0878", 2, new DateTime(2021, 11, 28, 0, 15, 41, 35, DateTimeKind.Unspecified).AddTicks(9342), new DateTime(2021, 6, 23, 6, 29, 42, 157, DateTimeKind.Unspecified).AddTicks(1519) },
                    { 88, 4, "1F-8857", 2, new DateTime(2021, 10, 25, 23, 55, 15, 767, DateTimeKind.Unspecified).AddTicks(3834), new DateTime(2021, 8, 23, 14, 34, 59, 455, DateTimeKind.Unspecified).AddTicks(7998) },
                    { 91, 2, "3P-2709", 2, new DateTime(2021, 11, 21, 12, 30, 37, 457, DateTimeKind.Unspecified).AddTicks(2040), new DateTime(2021, 5, 13, 9, 30, 33, 964, DateTimeKind.Unspecified).AddTicks(6007) },
                    { 92, 1, "ES-3843", 2, new DateTime(2021, 12, 25, 15, 59, 30, 520, DateTimeKind.Unspecified).AddTicks(9941), new DateTime(2021, 8, 6, 18, 56, 38, 827, DateTimeKind.Unspecified).AddTicks(600) },
                    { 97, 1, "72-7614", 2, new DateTime(2021, 10, 8, 16, 3, 40, 456, DateTimeKind.Unspecified).AddTicks(6733), new DateTime(2021, 8, 9, 23, 58, 58, 610, DateTimeKind.Unspecified).AddTicks(1499) },
                    { 9, 1, "42-2426", 2, new DateTime(2021, 9, 13, 10, 14, 47, 917, DateTimeKind.Unspecified).AddTicks(7384), new DateTime(2021, 7, 6, 20, 36, 0, 102, DateTimeKind.Unspecified).AddTicks(9965) },
                    { 105, 5, "8F-6646", 2, new DateTime(2021, 11, 23, 19, 35, 38, 84, DateTimeKind.Unspecified).AddTicks(8617), new DateTime(2021, 8, 5, 17, 59, 13, 41, DateTimeKind.Unspecified).AddTicks(5643) },
                    { 179, 3, "HG-2384", 1, new DateTime(2021, 12, 4, 22, 44, 13, 487, DateTimeKind.Unspecified).AddTicks(3822), new DateTime(2021, 8, 25, 4, 37, 12, 556, DateTimeKind.Unspecified).AddTicks(200) },
                    { 172, 3, "UQ-0381", 1, new DateTime(2021, 9, 3, 13, 55, 15, 667, DateTimeKind.Unspecified).AddTicks(387), new DateTime(2021, 8, 28, 23, 6, 38, 796, DateTimeKind.Unspecified).AddTicks(2395) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 6, 3, "BJ-5473", 1, new DateTime(2021, 10, 20, 13, 52, 15, 569, DateTimeKind.Unspecified).AddTicks(7253), new DateTime(2021, 5, 18, 23, 29, 54, 29, DateTimeKind.Unspecified).AddTicks(6299) },
                    { 11, 1, "L9-2582", 1, new DateTime(2021, 11, 11, 20, 43, 54, 677, DateTimeKind.Unspecified).AddTicks(3287), new DateTime(2021, 7, 5, 1, 59, 3, 559, DateTimeKind.Unspecified).AddTicks(8884) },
                    { 25, 5, "0U-7098", 1, new DateTime(2021, 9, 11, 21, 20, 5, 795, DateTimeKind.Unspecified).AddTicks(8290), new DateTime(2021, 5, 13, 13, 12, 15, 471, DateTimeKind.Unspecified).AddTicks(2156) },
                    { 26, 2, "E7-2084", 1, new DateTime(2021, 11, 22, 23, 23, 21, 92, DateTimeKind.Unspecified).AddTicks(8755), new DateTime(2021, 7, 7, 5, 7, 5, 53, DateTimeKind.Unspecified).AddTicks(3592) },
                    { 36, 3, "Y5-0998", 1, new DateTime(2021, 11, 21, 23, 9, 22, 401, DateTimeKind.Unspecified).AddTicks(3469), new DateTime(2021, 7, 2, 9, 50, 48, 843, DateTimeKind.Unspecified).AddTicks(9501) },
                    { 37, 2, "3M-6804", 1, new DateTime(2021, 12, 2, 1, 27, 25, 463, DateTimeKind.Unspecified).AddTicks(1219), new DateTime(2021, 7, 12, 3, 11, 56, 534, DateTimeKind.Unspecified).AddTicks(8032) },
                    { 38, 5, "48-0686", 1, new DateTime(2021, 9, 7, 18, 9, 16, 336, DateTimeKind.Unspecified).AddTicks(7030), new DateTime(2021, 6, 6, 17, 22, 42, 929, DateTimeKind.Unspecified).AddTicks(7250) },
                    { 41, 4, "DK-6762", 1, new DateTime(2021, 11, 6, 7, 30, 59, 817, DateTimeKind.Unspecified).AddTicks(3908), new DateTime(2021, 6, 7, 21, 36, 17, 387, DateTimeKind.Unspecified).AddTicks(2604) },
                    { 51, 5, "PR-9033", 1, new DateTime(2021, 10, 5, 15, 6, 10, 41, DateTimeKind.Unspecified).AddTicks(2690), new DateTime(2021, 7, 25, 7, 12, 31, 693, DateTimeKind.Unspecified).AddTicks(4471) },
                    { 58, 5, "LX-2342", 1, new DateTime(2021, 9, 21, 7, 27, 28, 584, DateTimeKind.Unspecified).AddTicks(9818), new DateTime(2021, 7, 15, 11, 49, 19, 696, DateTimeKind.Unspecified).AddTicks(7135) },
                    { 60, 4, "R6-0702", 1, new DateTime(2021, 9, 14, 4, 30, 11, 46, DateTimeKind.Unspecified).AddTicks(8195), new DateTime(2021, 7, 13, 20, 8, 53, 589, DateTimeKind.Unspecified).AddTicks(8305) },
                    { 84, 2, "44-7639", 1, new DateTime(2021, 11, 7, 6, 38, 48, 995, DateTimeKind.Unspecified).AddTicks(3448), new DateTime(2021, 5, 29, 20, 0, 6, 133, DateTimeKind.Unspecified).AddTicks(2263) },
                    { 85, 3, "B5-0175", 1, new DateTime(2021, 11, 19, 21, 4, 55, 656, DateTimeKind.Unspecified).AddTicks(861), new DateTime(2021, 5, 19, 15, 4, 42, 818, DateTimeKind.Unspecified).AddTicks(1654) },
                    { 87, 3, "HW-4294", 1, new DateTime(2021, 12, 26, 16, 21, 12, 47, DateTimeKind.Unspecified).AddTicks(7915), new DateTime(2021, 7, 30, 0, 37, 21, 944, DateTimeKind.Unspecified).AddTicks(1472) },
                    { 114, 2, "6Q-5401", 1, new DateTime(2021, 10, 6, 2, 53, 3, 677, DateTimeKind.Unspecified).AddTicks(6201), new DateTime(2021, 6, 7, 4, 42, 47, 40, DateTimeKind.Unspecified).AddTicks(3455) },
                    { 123, 1, "7K-4401", 1, new DateTime(2021, 12, 29, 6, 46, 7, 313, DateTimeKind.Unspecified).AddTicks(1043), new DateTime(2021, 6, 16, 3, 22, 9, 896, DateTimeKind.Unspecified).AddTicks(8759) },
                    { 131, 2, "45-7463", 1, new DateTime(2021, 12, 6, 7, 58, 35, 597, DateTimeKind.Unspecified).AddTicks(3062), new DateTime(2021, 7, 21, 2, 13, 38, 270, DateTimeKind.Unspecified).AddTicks(105) },
                    { 139, 1, "IA-3423", 1, new DateTime(2021, 9, 9, 15, 50, 24, 267, DateTimeKind.Unspecified).AddTicks(5093), new DateTime(2021, 6, 29, 21, 16, 12, 456, DateTimeKind.Unspecified).AddTicks(8008) },
                    { 147, 5, "L7-0778", 1, new DateTime(2021, 9, 25, 22, 9, 58, 209, DateTimeKind.Unspecified).AddTicks(6537), new DateTime(2021, 8, 13, 11, 51, 4, 977, DateTimeKind.Unspecified).AddTicks(6553) },
                    { 164, 5, "06-1001", 1, new DateTime(2021, 9, 8, 9, 57, 31, 683, DateTimeKind.Unspecified).AddTicks(7287), new DateTime(2021, 7, 23, 23, 0, 50, 468, DateTimeKind.Unspecified).AddTicks(4968) },
                    { 169, 4, "PL-7729", 1, new DateTime(2021, 9, 16, 16, 59, 48, 163, DateTimeKind.Unspecified).AddTicks(914), new DateTime(2021, 7, 4, 13, 5, 13, 11, DateTimeKind.Unspecified).AddTicks(6682) },
                    { 173, 1, "6N-9796", 1, new DateTime(2021, 12, 8, 20, 4, 42, 719, DateTimeKind.Unspecified).AddTicks(4953), new DateTime(2021, 6, 30, 23, 39, 20, 882, DateTimeKind.Unspecified).AddTicks(775) },
                    { 106, 3, "5R-5184", 2, new DateTime(2021, 10, 13, 13, 24, 7, 290, DateTimeKind.Unspecified).AddTicks(466), new DateTime(2021, 6, 6, 11, 22, 0, 283, DateTimeKind.Unspecified).AddTicks(744) },
                    { 108, 1, "Y2-1533", 2, new DateTime(2021, 9, 16, 8, 44, 34, 579, DateTimeKind.Unspecified).AddTicks(8883), new DateTime(2021, 6, 16, 8, 44, 15, 645, DateTimeKind.Unspecified).AddTicks(81) },
                    { 110, 5, "ZE-3873", 2, new DateTime(2021, 11, 11, 10, 39, 10, 691, DateTimeKind.Unspecified).AddTicks(160), new DateTime(2021, 8, 1, 11, 12, 0, 924, DateTimeKind.Unspecified).AddTicks(9490) },
                    { 45, 4, "AU-5908", 3, new DateTime(2021, 10, 25, 18, 19, 33, 629, DateTimeKind.Unspecified).AddTicks(300), new DateTime(2021, 8, 4, 11, 57, 5, 209, DateTimeKind.Unspecified).AddTicks(9804) },
                    { 54, 1, "27-7154", 3, new DateTime(2021, 9, 2, 19, 42, 59, 180, DateTimeKind.Unspecified).AddTicks(2364), new DateTime(2021, 6, 3, 5, 28, 34, 368, DateTimeKind.Unspecified).AddTicks(1529) },
                    { 61, 1, "4N-5588", 3, new DateTime(2021, 12, 5, 0, 59, 26, 518, DateTimeKind.Unspecified).AddTicks(9387), new DateTime(2021, 6, 5, 0, 38, 35, 72, DateTimeKind.Unspecified).AddTicks(6985) },
                    { 63, 5, "73-7392", 3, new DateTime(2021, 10, 20, 20, 18, 17, 521, DateTimeKind.Unspecified).AddTicks(6342), new DateTime(2021, 8, 17, 8, 44, 51, 376, DateTimeKind.Unspecified).AddTicks(4981) },
                    { 64, 3, "QF-1275", 3, new DateTime(2021, 11, 24, 23, 50, 41, 652, DateTimeKind.Unspecified).AddTicks(7969), new DateTime(2021, 6, 20, 18, 13, 41, 835, DateTimeKind.Unspecified).AddTicks(3637) },
                    { 66, 1, "41-2924", 3, new DateTime(2021, 9, 10, 12, 58, 16, 450, DateTimeKind.Unspecified).AddTicks(2582), new DateTime(2021, 5, 31, 19, 19, 50, 814, DateTimeKind.Unspecified).AddTicks(6422) },
                    { 77, 1, "OR-9265", 3, new DateTime(2021, 11, 22, 22, 26, 7, 500, DateTimeKind.Unspecified).AddTicks(9969), new DateTime(2021, 7, 1, 9, 34, 12, 94, DateTimeKind.Unspecified).AddTicks(554) },
                    { 78, 5, "CJ-0984", 3, new DateTime(2021, 10, 28, 8, 31, 33, 242, DateTimeKind.Unspecified).AddTicks(5448), new DateTime(2021, 5, 22, 11, 1, 9, 751, DateTimeKind.Unspecified).AddTicks(7356) },
                    { 81, 2, "38-9568", 3, new DateTime(2021, 12, 20, 15, 25, 38, 494, DateTimeKind.Unspecified).AddTicks(7588), new DateTime(2021, 5, 15, 20, 18, 50, 428, DateTimeKind.Unspecified).AddTicks(7983) },
                    { 82, 5, "87-8174", 3, new DateTime(2021, 9, 1, 13, 36, 50, 444, DateTimeKind.Unspecified).AddTicks(6282), new DateTime(2021, 5, 27, 6, 15, 51, 472, DateTimeKind.Unspecified).AddTicks(4196) },
                    { 86, 4, "2N-4258", 3, new DateTime(2021, 10, 16, 0, 3, 46, 288, DateTimeKind.Unspecified).AddTicks(4931), new DateTime(2021, 7, 13, 22, 34, 33, 699, DateTimeKind.Unspecified).AddTicks(7402) },
                    { 89, 1, "V8-7318", 3, new DateTime(2021, 11, 29, 8, 41, 51, 307, DateTimeKind.Unspecified).AddTicks(7906), new DateTime(2021, 8, 20, 12, 55, 49, 981, DateTimeKind.Unspecified).AddTicks(3684) },
                    { 90, 5, "89-4650", 3, new DateTime(2021, 10, 7, 2, 0, 18, 320, DateTimeKind.Unspecified).AddTicks(4968), new DateTime(2021, 5, 17, 12, 18, 38, 147, DateTimeKind.Unspecified).AddTicks(3655) },
                    { 95, 1, "WS-4702", 3, new DateTime(2021, 11, 23, 1, 45, 16, 788, DateTimeKind.Unspecified).AddTicks(6331), new DateTime(2021, 8, 2, 19, 8, 42, 887, DateTimeKind.Unspecified).AddTicks(6271) },
                    { 99, 4, "9T-4754", 3, new DateTime(2021, 11, 14, 18, 10, 43, 389, DateTimeKind.Unspecified).AddTicks(9424), new DateTime(2021, 7, 3, 22, 39, 5, 115, DateTimeKind.Unspecified).AddTicks(857) },
                    { 100, 3, "7W-8243", 3, new DateTime(2021, 9, 21, 13, 42, 23, 373, DateTimeKind.Unspecified).AddTicks(1383), new DateTime(2021, 5, 22, 19, 17, 42, 224, DateTimeKind.Unspecified).AddTicks(4324) },
                    { 101, 4, "X4-6802", 3, new DateTime(2021, 11, 29, 19, 32, 43, 591, DateTimeKind.Unspecified).AddTicks(6218), new DateTime(2021, 5, 8, 1, 26, 53, 915, DateTimeKind.Unspecified).AddTicks(7975) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 109, 3, "K6-8527", 3, new DateTime(2021, 11, 24, 11, 43, 17, 673, DateTimeKind.Unspecified).AddTicks(8933), new DateTime(2021, 7, 31, 12, 51, 53, 287, DateTimeKind.Unspecified).AddTicks(175) },
                    { 124, 1, "R7-2957", 3, new DateTime(2021, 12, 20, 21, 41, 29, 486, DateTimeKind.Unspecified).AddTicks(3924), new DateTime(2021, 5, 30, 1, 27, 56, 365, DateTimeKind.Unspecified).AddTicks(9114) },
                    { 127, 5, "5S-0090", 3, new DateTime(2021, 9, 30, 23, 56, 12, 118, DateTimeKind.Unspecified).AddTicks(7978), new DateTime(2021, 8, 29, 7, 55, 8, 281, DateTimeKind.Unspecified).AddTicks(4722) },
                    { 128, 1, "6N-5319", 3, new DateTime(2021, 10, 8, 18, 45, 20, 948, DateTimeKind.Unspecified).AddTicks(168), new DateTime(2021, 6, 19, 10, 45, 48, 550, DateTimeKind.Unspecified).AddTicks(8980) },
                    { 42, 4, "53-7592", 3, new DateTime(2021, 9, 9, 9, 15, 3, 907, DateTimeKind.Unspecified).AddTicks(6454), new DateTime(2021, 7, 23, 19, 28, 20, 274, DateTimeKind.Unspecified).AddTicks(1201) },
                    { 35, 1, "HC-8046", 3, new DateTime(2021, 11, 5, 5, 3, 35, 258, DateTimeKind.Unspecified).AddTicks(1985), new DateTime(2021, 6, 23, 14, 53, 6, 564, DateTimeKind.Unspecified).AddTicks(458) },
                    { 34, 2, "K9-9566", 3, new DateTime(2021, 11, 12, 13, 42, 8, 986, DateTimeKind.Unspecified).AddTicks(3727), new DateTime(2021, 7, 29, 19, 47, 55, 881, DateTimeKind.Unspecified).AddTicks(6246) },
                    { 29, 1, "7L-5359", 3, new DateTime(2021, 11, 9, 6, 18, 34, 345, DateTimeKind.Unspecified).AddTicks(6058), new DateTime(2021, 8, 16, 13, 32, 16, 618, DateTimeKind.Unspecified).AddTicks(3925) },
                    { 112, 3, "B4-7413", 2, new DateTime(2021, 9, 15, 20, 41, 12, 473, DateTimeKind.Unspecified).AddTicks(987), new DateTime(2021, 6, 20, 4, 25, 19, 590, DateTimeKind.Unspecified).AddTicks(7458) },
                    { 115, 1, "GZ-8334", 2, new DateTime(2021, 9, 5, 12, 37, 54, 893, DateTimeKind.Unspecified).AddTicks(2544), new DateTime(2021, 8, 14, 17, 9, 19, 404, DateTimeKind.Unspecified).AddTicks(4913) },
                    { 116, 5, "OR-9283", 2, new DateTime(2021, 9, 12, 0, 22, 8, 236, DateTimeKind.Unspecified).AddTicks(9322), new DateTime(2021, 6, 7, 9, 57, 13, 198, DateTimeKind.Unspecified).AddTicks(1319) },
                    { 134, 1, "5J-6756", 2, new DateTime(2021, 10, 4, 13, 17, 37, 364, DateTimeKind.Unspecified).AddTicks(987), new DateTime(2021, 7, 29, 8, 55, 34, 919, DateTimeKind.Unspecified).AddTicks(6986) },
                    { 146, 5, "29-9462", 2, new DateTime(2021, 12, 22, 8, 37, 40, 795, DateTimeKind.Unspecified).AddTicks(72), new DateTime(2021, 8, 7, 17, 29, 24, 322, DateTimeKind.Unspecified).AddTicks(6798) },
                    { 148, 2, "13-5510", 2, new DateTime(2021, 12, 10, 19, 58, 36, 408, DateTimeKind.Unspecified).AddTicks(7884), new DateTime(2021, 7, 19, 4, 12, 1, 163, DateTimeKind.Unspecified).AddTicks(504) },
                    { 152, 1, "45-7857", 2, new DateTime(2021, 12, 25, 2, 41, 18, 873, DateTimeKind.Unspecified).AddTicks(6374), new DateTime(2021, 7, 5, 13, 10, 42, 61, DateTimeKind.Unspecified).AddTicks(9053) },
                    { 167, 2, "I8-3426", 2, new DateTime(2021, 12, 24, 5, 22, 28, 182, DateTimeKind.Unspecified).AddTicks(8124), new DateTime(2021, 6, 5, 11, 22, 47, 96, DateTimeKind.Unspecified).AddTicks(4193) },
                    { 171, 4, "X9-8829", 2, new DateTime(2021, 11, 25, 8, 7, 10, 897, DateTimeKind.Unspecified).AddTicks(7099), new DateTime(2021, 8, 27, 2, 6, 52, 742, DateTimeKind.Unspecified).AddTicks(9804) },
                    { 176, 1, "S5-7354", 2, new DateTime(2021, 11, 28, 12, 38, 8, 870, DateTimeKind.Unspecified).AddTicks(9295), new DateTime(2021, 5, 25, 2, 46, 20, 533, DateTimeKind.Unspecified).AddTicks(1157) },
                    { 192, 5, "67-8880", 5, new DateTime(2021, 11, 24, 6, 30, 6, 341, DateTimeKind.Unspecified).AddTicks(9332), new DateTime(2021, 6, 27, 22, 4, 25, 447, DateTimeKind.Unspecified).AddTicks(3064) },
                    { 181, 5, "6H-1993", 2, new DateTime(2021, 10, 28, 1, 43, 48, 241, DateTimeKind.Unspecified).AddTicks(3765), new DateTime(2021, 8, 23, 16, 52, 25, 852, DateTimeKind.Unspecified).AddTicks(6358) },
                    { 184, 1, "61-5648", 2, new DateTime(2021, 11, 27, 17, 17, 19, 341, DateTimeKind.Unspecified).AddTicks(1360), new DateTime(2021, 5, 18, 0, 43, 50, 284, DateTimeKind.Unspecified).AddTicks(2659) },
                    { 187, 4, "32-9401", 2, new DateTime(2021, 11, 9, 2, 17, 15, 370, DateTimeKind.Unspecified).AddTicks(8648), new DateTime(2021, 6, 26, 10, 54, 50, 230, DateTimeKind.Unspecified).AddTicks(5592) },
                    { 193, 2, "A0-7595", 2, new DateTime(2021, 12, 5, 2, 50, 47, 717, DateTimeKind.Unspecified).AddTicks(6252), new DateTime(2021, 5, 8, 1, 21, 36, 720, DateTimeKind.Unspecified).AddTicks(1733) },
                    { 197, 1, "57-2619", 2, new DateTime(2021, 12, 24, 12, 25, 18, 524, DateTimeKind.Unspecified).AddTicks(8762), new DateTime(2021, 7, 11, 1, 1, 36, 95, DateTimeKind.Unspecified).AddTicks(3029) },
                    { 3, 4, "60-4574", 3, new DateTime(2021, 12, 25, 17, 32, 26, 543, DateTimeKind.Unspecified).AddTicks(6589), new DateTime(2021, 6, 4, 18, 15, 28, 41, DateTimeKind.Unspecified).AddTicks(4664) },
                    { 8, 1, "9H-9135", 3, new DateTime(2021, 9, 3, 22, 15, 4, 411, DateTimeKind.Unspecified).AddTicks(1714), new DateTime(2021, 6, 18, 16, 51, 40, 614, DateTimeKind.Unspecified).AddTicks(7801) },
                    { 12, 4, "5J-5071", 3, new DateTime(2021, 11, 20, 13, 1, 9, 144, DateTimeKind.Unspecified).AddTicks(309), new DateTime(2021, 5, 27, 12, 46, 13, 322, DateTimeKind.Unspecified).AddTicks(538) },
                    { 17, 1, "Y1-7194", 3, new DateTime(2021, 9, 7, 11, 58, 47, 7, DateTimeKind.Unspecified).AddTicks(1350), new DateTime(2021, 7, 26, 20, 55, 16, 801, DateTimeKind.Unspecified).AddTicks(6114) },
                    { 24, 2, "SX-4440", 3, new DateTime(2021, 12, 2, 23, 21, 9, 800, DateTimeKind.Unspecified).AddTicks(4071), new DateTime(2021, 8, 6, 19, 27, 17, 734, DateTimeKind.Unspecified).AddTicks(4070) },
                    { 27, 4, "DL-6085", 3, new DateTime(2021, 12, 20, 18, 48, 47, 970, DateTimeKind.Unspecified).AddTicks(1086), new DateTime(2021, 7, 5, 0, 57, 31, 341, DateTimeKind.Unspecified).AddTicks(9331) },
                    { 183, 5, "39-4901", 2, new DateTime(2021, 11, 2, 5, 45, 19, 91, DateTimeKind.Unspecified).AddTicks(2492), new DateTime(2021, 5, 27, 17, 41, 29, 953, DateTimeKind.Unspecified).AddTicks(3851) },
                    { 200, 1, "G0-1543", 5, new DateTime(2021, 11, 19, 22, 46, 27, 801, DateTimeKind.Unspecified).AddTicks(4395), new DateTime(2021, 8, 30, 19, 35, 4, 101, DateTimeKind.Unspecified).AddTicks(9038) }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 90, "341 Wilfrid Forest", null, "Wizahaven", null, "C7D 2V5", "NL" },
                    { 33, "658 Grant Drive", null, "East Briana", null, "L2J 4V9", "NL" },
                    { 47, "186 Chasity Bridge", null, "New Danny", null, "C4Z 6O4", "PE" },
                    { 13, "6230 Torphy Rapid", null, "South Itzel", null, "S5H 5S1", "BC" },
                    { 197, "6570 Kenna Lodge", null, "East Laurenmouth", null, "A7O 8A5", "MB" },
                    { 32, "27960 Maggie Street", null, "Lake Raechester", null, "L8Q 5Q7", "AB" },
                    { 49, "6090 Kovacek Drives", null, "Lake Baileyview", null, "T7O 1C9", "ON" },
                    { 31, "093 Bahringer Highway", null, "South Jewel", null, "X0O 1W2", "BC" },
                    { 15, "67184 Rowe Gardens", null, "Heidenreichchester", null, "A9B 4W4", "NL" },
                    { 193, "22716 Kuhic Walks", null, "Port Bretview", null, "Y2M 7X7", "NB" },
                    { 50, "99837 Bartell Walk", null, "New Kara", null, "X8B 9U1", "NL" },
                    { 23, "4348 Daugherty Camp", null, "South Reedborough", null, "G1I 8X9", "QC" },
                    { 18, "0747 Corine Knoll", null, "Vincenttown", null, "X8T 0R0", "NT" },
                    { 187, "4634 Haley Meadows", null, "Wilkinsonfurt", null, "S5Q 7A6", "NL" },
                    { 22, "65666 Kohler Union", null, "West Melvinfurt", null, "K5I 5P7", "PE" },
                    { 59, "9887 Bruen Ways", null, "Lake Chanel", null, "L8I 3K1", "QC" },
                    { 20, "52051 Bernita Plain", null, "Rueckerberg", null, "Y8V 0L1", "AB" },
                    { 184, "78273 Gutkowski Tunnel", null, "Lake Zackerychester", null, "A7R 1B5", "PE" },
                    { 19, "485 Graham Meadows", null, "Port Patricia", null, "C5S 2O3", "AB" },
                    { 71, "5875 Candelario Drive", null, "New Candiceshire", null, "H4R 3E9", "NB" },
                    { 21, "694 Kreiger Heights", null, "Konopelskimouth", null, "H3X 5A4", "NU" },
                    { 183, "1351 Conor Harbors", null, "Rutherfordberg", null, "B2P 1W9", "NS" },
                    { 16, "01494 Jayson Turnpike", null, "North Sandy", null, "T0Z 5N0", "SK" },
                    { 40, "815 Roob Road", null, "Lake Dorrisfurt", null, "V2S 5M7", "PE" },
                    { 72, "3582 Jalyn Isle", null, "Agustinaview", null, "A3C 9O4", "AB" },
                    { 7, "816 Connor Mountain", null, "South Davidview", null, "T8P 8E3", "NS" },
                    { 46, "717 Cartwright Harbor", null, "Port Enosville", null, "B3G 8Y1", "YT" },
                    { 3, "1864 Ryan Heights", null, "New Alda", null, "R3Q 3A6", "ON" },
                    { 10, "15923 Steuber Island", null, "West Eugenia", null, "P8I 2O6", "PE" },
                    { 43, "014 Zieme Path", null, "Carliestad", null, "G3K 6G9", "NL" },
                    { 4, "682 Glenna Courts", null, "South Mackbury", null, "Y1N 9C8", "NU" },
                    { 103, "19534 Yasmin Vista", null, "Loweport", null, "E9T 8Y0", "PE" },
                    { 27, "65116 Dorris Fall", null, "Cathrynberg", null, "P5X 6Q7", "NS" },
                    { 94, "338 Hettinger Port", null, "Maximusmouth", null, "K1B 6P1", "SK" },
                    { 5, "54167 Eliseo Mount", null, "West Winfield", null, "C7S 9F2", "MB" },
                    { 164, "42964 Brown Street", null, "Zemlaktown", null, "H8V 4N1", "SK" },
                    { 79, "269 Auer Fork", null, "East Chanelstad", null, "E7X 0I0", "QC" },
                    { 169, "3036 Hayes Ferry", null, "West Johnnyside", null, "X3B 0Z4", "NL" },
                    { 24, "707 Dusty Oval", null, "Schmittmouth", null, "K7F 5D2", "QC" },
                    { 14, "4457 Morar Locks", null, "North Durward", null, "M7I 5L5", "SK" },
                    { 172, "5254 Edwina Row", null, "North Jayme", null, "V6W 3R3", "NB" },
                    { 75, "71828 Mina Knoll", null, "Feestside", null, "Y3U 6A7", "NB" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 48, "4801 Schowalter Ville", null, "Pollichmouth", null, "X0T 7L2", "QC" },
                    { 17, "0389 Bosco Tunnel", null, "Lyrichaven", null, "Y1R 9L8", "NU" },
                    { 69, "6471 O'Reilly Locks", null, "West Nikitafort", null, "P4F 8U0", "YT" },
                    { 173, "056 Dino Cove", null, "Lake Emmanuel", null, "N8J 2W0", "NU" },
                    { 129, "67403 Nathaniel Forest", null, "North Rebekahmouth", null, "C2X 3G2", "NB" },
                    { 56, "8681 Lillie Points", null, "Beerberg", null, "N1G 7L7", "NB" },
                    { 39, "23976 Schoen Vista", null, "Moenville", null, "G8S 2P4", "YT" },
                    { 179, "2331 Bryana Bypass", null, "Lake Antoniaport", null, "L1Y 8I2", "NS" },
                    { 12, "0302 Schneider Crossroad", null, "Beaulahland", null, "P2C 1X4", "NL" },
                    { 55, "65283 Noe Field", null, "Lake Alfred", null, "H9M 2Q8", "QC" },
                    { 9, "94815 Volkman Crossing", null, "Martahaven", null, "L4L 0H2", "QC" },
                    { 8, "069 King Common", null, "Lebsackmouth", null, "Y0F 3N7", "NS" },
                    { 44, "844 Mills Cove", null, "Jakubowskiborough", null, "X7B 0H3", "PE" },
                    { 53, "80026 Fadel Hollow", null, "North Hailiemouth", null, "R8N 1I2", "NS" },
                    { 28, "92140 Maya Crossroad", null, "Lake Rockyport", null, "M8B 3Y4", "SK" },
                    { 181, "0550 Lizzie Alley", null, "Lutherport", null, "V8W 5L1", "MB" },
                    { 74, "590 Welch Viaduct", null, "North Theresashire", null, "M1W 1F2", "BC" },
                    { 1, "172 Fahey Junctions", null, "Martinastad", null, "R4O 7R5", "SK" },
                    { 104, "0095 Deja Skyway", null, "Hudsonchester", null, "E4R 2H7", "NL" },
                    { 154, "2572 Bailee Park", null, "Bradfordmouth", null, "H3D 4H5", "NL" },
                    { 111, "320 Rippin Garden", null, "Prosaccostad", null, "K3M 4G1", "ON" },
                    { 83, "45577 Schaefer Roads", null, "Kuhnburgh", null, "H7W 3L3", "MB" },
                    { 153, "59543 Fabiola Ferry", null, "Hicklefurt", null, "E7N 0S5", "YT" },
                    { 88, "95166 DuBuque Crossing", null, "Haleyville", null, "R4Y 1E9", "AB" },
                    { 116, "21445 Sean Route", null, "East Lavonfurt", null, "V9O 8G9", "BC" },
                    { 115, "57393 Kurt Greens", null, "Framifort", null, "A0O 1Z1", "PE" },
                    { 91, "321 Lucile Crest", null, "South Ned", null, "G6Q 1B9", "AB" },
                    { 113, "8460 Thompson Brook", null, "Waelchifort", null, "B9X 2B7", "ON" },
                    { 149, "15719 Watsica Islands", null, "North Alyshamouth", null, "G6D 6G4", "PE" },
                    { 118, "7616 Johnston Drive", null, "North Zoraburgh", null, "E4G 0C6", "ON" },
                    { 73, "069 Eunice Grove", null, "Pourosburgh", null, "C5W 1B1", "NL" },
                    { 144, "60738 Murray Plaza", null, "North Marian", null, "L9L 0V5", "QC" },
                    { 92, "6249 Alva Brooks", null, "Haagfort", null, "E1V 4P5", "ON" },
                    { 143, "1911 Mac Mountains", null, "Lake Augustine", null, "S7O 6U0", "MB" },
                    { 121, "43249 Treutel Causeway", null, "Salvadorfort", null, "A2B 8U1", "AB" },
                    { 140, "9762 Grant Ferry", null, "Lake Anais", null, "Y1T 8C8", "YT" },
                    { 97, "2531 Trantow Park", null, "Creolashire", null, "E8M 9Y3", "SK" },
                    { 110, "0712 Effertz Dale", null, "Doyleburgh", null, "E3B 4T4", "MB" },
                    { 122, "25653 Stark Lock", null, "West Shawn", null, "H8W 5G7", "NS" },
                    { 137, "624 Pamela Shore", null, "Port Leopold", null, "S7F 6L7", "MB" },
                    { 105, "7286 Bernier Shores", null, "Bertfort", null, "M6F 8Y7", "BC" },
                    { 108, "113 Boyer Oval", null, "North Valentin", null, "T2K 2R7", "SK" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 106, "401 Verona Vista", null, "West Hayleymouth", null, "L1O 6K5", "ON" },
                    { 125, "6807 Kuphal Plain", null, "West Alvera", null, "E1M 8D9", "AB" },
                    { 112, "6505 Joyce River", null, "Bertrandton", null, "V4X 5C1", "MB" },
                    { 147, "72852 Waelchi Plain", null, "McKenzieville", null, "K8B 7D1", "NT" },
                    { 134, "059 Emmerich Camp", null, "Port Daisystad", null, "H3B 9U2", "AB" },
                    { 70, "50836 Nikolaus Mills", null, "Weimannville", null, "T0M 7U7", "SK" },
                    { 52, "05089 Goyette Springs", null, "Lupebury", null, "A5O 0Q2", "QC" },
                    { 176, "771 Ardith Underpass", null, "New Therese", null, "A9M 3Q1", "NB" },
                    { 76, "0858 Vicky Path", null, "West Haleigh", null, "X7A 2B4", "NU" },
                    { 198, "963 Jett Hill", null, "Joannieville", null, "G6I 2W9", "NT" },
                    { 57, "087 Haley Locks", null, "Vallieburgh", null, "H8P 3H8", "AB" },
                    { 80, "002 Sanford Flat", null, "McGlynnside", null, "K0E 7S3", "NB" },
                    { 196, "26833 Swift Canyon", null, "Port Emma", null, "Y6V 2U9", "QC" },
                    { 171, "04342 Elna Point", null, "Austynborough", null, "Y7Z 8P6", "NT" },
                    { 62, "71794 Sporer Views", null, "Port Blaze", null, "H1L 6G8", "NB" },
                    { 93, "903 Price Court", null, "Reynoldsberg", null, "Y6E 2K4", "PE" },
                    { 195, "96786 Bode Stream", null, "Weberberg", null, "E0V 0P8", "NT" },
                    { 65, "969 Sheila Streets", null, "Fredrickport", null, "H1H 4L1", "NS" },
                    { 155, "9367 Gutmann Route", null, "Bergstromshire", null, "E7E 6U9", "NL" },
                    { 167, "2003 Jalen Point", null, "Port Graysonton", null, "J7H 6H8", "NL" },
                    { 152, "3717 Stroman Harbor", null, "Filibertomouth", null, "V4L 8I5", "BC" },
                    { 188, "8063 Katelin Corner", null, "East Trentontown", null, "S3Y 7E6", "AB" },
                    { 67, "20181 Delphia Squares", null, "Bahringerside", null, "V7O 8J4", "NL" },
                    { 96, "24378 Flavio Hill", null, "North Nash", null, "B0Z 7J2", "NB" },
                    { 180, "289 Fernando Walk", null, "Kevonview", null, "T3R 6W3", "SK" },
                    { 148, "33063 Madelyn Harbor", null, "Theresatown", null, "N5F 6V8", "NL" },
                    { 98, "4739 Konopelski Mountain", null, "South Stellatown", null, "A1F 1H7", "YT" },
                    { 174, "9122 Queen Underpass", null, "Joaquinhaven", null, "K2N 8W8", "AB" },
                    { 68, "2134 Isom Estate", null, "New Missouri", null, "M7A 7K8", "BC" },
                    { 146, "8111 Linnie Glen", null, "Roobburgh", null, "S2W 1X3", "NS" },
                    { 159, "58228 Bryon Knolls", null, "Nicholausmouth", null, "B9X 7E5", "SK" },
                    { 102, "425 Haley Meadows", null, "Herzogview", null, "B5A 4S5", "QC" },
                    { 189, "1742 Antwon Vista", null, "Lake Harley", null, "J8W 0Z0", "YT" },
                    { 29, "4434 Botsford Mews", null, "Zoeymouth", null, "A5B 7D2", "NT" },
                    { 30, "8376 Christiansen Ranch", null, "New Roderickborough", null, "G2S 3P6", "ON" },
                    { 157, "8715 Diamond Orchard", null, "Giannichester", null, "T3O 4O3", "AB" },
                    { 175, "970 Dane Viaduct", null, "Isobelfurt", null, "M7U 6C3", "YT" },
                    { 78, "09546 Scot Ramp", null, "Lynchshire", null, "S2V 0H7", "BC" },
                    { 142, "5564 Genesis Shore", null, "Hoegerfort", null, "E0J 5B1", "NB" },
                    { 145, "580 Fletcher Gateway", null, "New Ledaview", null, "L1X 7Y6", "NS" },
                    { 58, "18213 Alexie Roads", null, "Lake Anne", null, "A4E 0Z3", "MB" },
                    { 25, "46438 Damian Spur", null, "Delphaberg", null, "R6D 0I5", "NT" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 54, "174 Gloria Squares", null, "Ociestad", null, "H5M 4L9", "MB" },
                    { 177, "8576 Reinhold Estate", null, "Veronaton", null, "S1F 9A8", "NB" },
                    { 141, "053 Dickinson Fords", null, "Mckennaton", null, "M2Y 6K0", "NB" },
                    { 60, "2980 Wilfrid Meadow", null, "Lake Lupestad", null, "Y0J 3G0", "NL" },
                    { 101, "8534 Beier Parks", null, "Ondrickaport", null, "E1U 8Y2", "NL" },
                    { 150, "57985 Mabel Tunnel", null, "Port Donna", null, "L4M 2D8", "AB" },
                    { 156, "922 Cummerata Green", null, "Hirthefurt", null, "H2N 3F4", "YT" },
                    { 81, "4243 Hadley Village", null, "Namebury", null, "E5Y 7X4", "PE" },
                    { 178, "50124 Klocko Springs", null, "Juniusland", null, "P1T 2D6", "AB" },
                    { 165, "28840 Hayden Trace", null, "Lake Tracy", null, "V3M 7A1", "ON" },
                    { 84, "7923 Effie Rapids", null, "South Rogelio", null, "P0G 3T2", "BC" },
                    { 45, "96673 Mason Shores", null, "Port Patience", null, "B7Y 9Q3", "PE" },
                    { 135, "722 Troy Alley", null, "Quitzonport", null, "H9V 5O8", "NS" },
                    { 51, "7270 Turner Isle", null, "South Kielfurt", null, "E3Q 9M2", "NT" },
                    { 61, "62864 Kuvalis Route", null, "Aprilmouth", null, "M9P 5H8", "QC" },
                    { 151, "825 Dach Mews", null, "Port Arielle", null, "N4T 8L2", "SK" },
                    { 138, "6457 Milan Dale", null, "Pietroland", null, "T2R 7B8", "NL" },
                    { 66, "0465 Schoen Lights", null, "Mariahmouth", null, "A3R 3C9", "YT" },
                    { 127, "79712 Isaias Meadows", null, "North Brown", null, "Y6B 7L5", "BC" },
                    { 163, "253 Olson Path", null, "Pfannerstillberg", null, "H2M 0G7", "NU" },
                    { 36, "4026 Stamm Land", null, "North Russelshire", null, "L2W 0L0", "MB" },
                    { 166, "9623 Block Mount", null, "West Alene", null, "C7N 7V2", "NT" },
                    { 37, "34224 Einar Green", null, "Boganton", null, "K8D 8U5", "NB" },
                    { 64, "7946 Ernser Views", null, "South Tillman", null, "K8Z 7F4", "MB" },
                    { 124, "429 Runolfsson Course", null, "Lake Daisybury", null, "N9I 9L5", "NL" },
                    { 162, "49789 Prudence Mountain", null, "South Paulburgh", null, "T1L 6K7", "ON" },
                    { 182, "75782 Huel Island", null, "Lake Revaberg", null, "L7B 5S3", "NT" },
                    { 128, "299 Scotty Estate", null, "Port Marquiseland", null, "K0V 5B9", "NS" },
                    { 38, "677 Anibal Highway", null, "Frederiqueberg", null, "X2C 7B2", "MB" },
                    { 160, "78514 Sipes Knolls", null, "East Rebeka", null, "C1V 4Z9", "SK" },
                    { 63, "78680 Kyleigh Islands", null, "Lake Antonette", null, "Y7N 1O9", "NL" },
                    { 109, "932 Halvorson Trafficway", null, "Stiedemannburgh", null, "J3G 3X8", "NL" },
                    { 132, "1010 Marisa Walk", null, "North Donald", null, "Y1V 4X2", "MB" },
                    { 77, "280 Reichel Estates", null, "Concepcionland", null, "E1L 3W8", "NB" },
                    { 107, "2412 Dibbert Knoll", null, "Lake Adriennestad", null, "L0U 2L0", "ON" },
                    { 26, "06546 Karli Pass", null, "Marianetown", null, "A6R 4E8", "YT" },
                    { 41, "891 Saige Crossroad", null, "North Aniyastad", null, "C6H 8M2", "PE" },
                    { 168, "6228 Kris Cape", null, "Hettingerfurt", null, "L4O 9E9", "NU" },
                    { 158, "3319 Jaiden Ports", null, "Nikolashaven", null, "M6M 1T5", "PE" },
                    { 136, "9280 Myrna Highway", null, "Ratketon", null, "R4X 2P8", "BC" },
                    { 82, "7319 Deckow Cape", null, "Kennychester", null, "B5S 6S1", "NT" },
                    { 126, "2849 Adele Fords", null, "Loweburgh", null, "V1N 9Y4", "NB" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 191, "057 Karley Inlet", null, "O'Keefeburgh", null, "G9U 6F6", "QC" },
                    { 123, "940 Zemlak River", null, "Port Jackieview", null, "P2G 6R4", "NS" },
                    { 85, "1224 Lea Meadows", null, "West Maximilliaborough", null, "J4H 9H0", "MB" },
                    { 99, "631 Chanelle Corners", null, "Ivyfurt", null, "A3O 5Z0", "AB" },
                    { 35, "9023 Abbey Island", null, "Lake Zachery", null, "P0J 3H0", "SK" },
                    { 120, "9392 Dee Corners", null, "Hagenesville", null, "E5H 3T8", "AB" },
                    { 190, "2895 Glover Crossroad", null, "Hayliestad", null, "M3C 6F0", "QC" },
                    { 6, "8090 Schmeler Course", null, "Caseyborough", null, "L7Q 7Q7", "NS" },
                    { 185, "62138 Hamill Keys", null, "Chelseastad", null, "A0C 2L4", "MB" },
                    { 131, "885 Nitzsche Burg", null, "East Reidside", null, "T6N 3W5", "BC" },
                    { 119, "65126 Cordia Pass", null, "Paulachester", null, "T6Q 4W0", "PE" },
                    { 192, "18868 Cartwright Extension", null, "Ritchieberg", null, "P0K 0L9", "BC" },
                    { 95, "247 Anita Branch", null, "Collierborough", null, "N8T 4F8", "AB" },
                    { 34, "17670 Francesco Track", null, "East Tia", null, "E4K 3F3", "NT" },
                    { 117, "693 Peter Bypass", null, "Port Korychester", null, "J5E 1W0", "NT" },
                    { 139, "894 Ashtyn Locks", null, "Port Florencio", null, "B0D 2A7", "SK" },
                    { 2, "999 Daugherty Avenue", null, "East Gerardoview", null, "A2H 8P6", "NS" },
                    { 199, "2071 Yost Station", null, "Lake Darbyland", null, "G2Q 7E7", "SK" },
                    { 89, "7248 Frieda Mall", null, "South Keshawn", null, "L9L 8I9", "QC" },
                    { 194, "3122 Toy Coves", null, "Novaberg", null, "C0P 3D9", "MB" },
                    { 86, "1926 Danika Mission", null, "North Georgiannaton", null, "P7N 9T1", "AB" },
                    { 200, "5873 Brennan Estate", null, "Port Ofeliahaven", null, "K6T 3Y1", "NS" },
                    { 186, "7570 Alphonso Dale", null, "Port Xzavier", null, "J1C 0Z4", "PE" },
                    { 133, "42291 Maggio Keys", null, "New Salvatoretown", null, "G6G 1X4", "NL" },
                    { 170, "737 Ferry Lakes", null, "Adonishaven", null, "B6L 4A2", "PE" },
                    { 11, "16605 Bauch Lock", null, "Christon", null, "J1K 1O9", "MB" },
                    { 87, "5158 Boyer Bypass", null, "Lake Elveraland", null, "H3H 9C2", "NU" },
                    { 114, "79847 Cleta Summit", null, "South Palma", null, "H5T 7Q4", "NL" },
                    { 161, "90975 Dion Fields", null, "Reingerside", null, "P1M 5T6", "MB" },
                    { 100, "3671 Spencer Motorway", null, "Ullrichshire", null, "H6D 2A5", "NU" },
                    { 130, "157 Cormier Mountain", null, "East Bransonshire", null, "E2W 0Y1", "ON" },
                    { 42, "93283 Nathanael Springs", null, "Littelburgh", null, "M3S 5V4", "BC" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 109, "10811 Zulauf Walk", null, "East Dimitrifort", null, "S0H 7M8", "MB" },
                    { 122, "1353 Jerrell Squares", null, "North Destinyberg", null, "G3C 1D7", "NT" },
                    { 81, "0444 Jaylin Course", null, "New Vicenta", null, "M8T 3O3", "PE" },
                    { 115, "66032 Purdy Forges", null, "Domingomouth", null, "E4A 6Y0", "MB" },
                    { 78, "7225 Rippin Meadows", null, "Vickieville", null, "J0D 6K5", "NT" },
                    { 148, "627 Abigail Trafficway", null, "South Jacyntheberg", null, "A5R 5G2", "QC" },
                    { 100, "203 Fidel Drive", null, "Candelariostad", null, "E4M 7X0", "ON" },
                    { 96, "34829 Benton Lake", null, "Mohrside", null, "X6I 2G1", "YT" },
                    { 89, "218 Jaunita Trail", null, "West Emory", null, "A8F 3U7", "NS" },
                    { 124, "0071 Lynch Heights", null, "MacGyvermouth", null, "L8M 9I0", "BC" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 108, "2967 Humberto Bridge", null, "Lake Peter", null, "Y8P 0S5", "BC" },
                    { 113, "1537 Hudson Ridges", null, "North Bryana", null, "L4F 1K2", "ON" },
                    { 146, "82360 Huels Greens", null, "New Beverlytown", null, "G1E 6Z6", "SK" },
                    { 98, "831 Keely Drives", null, "Janessachester", null, "L1S 9G7", "PE" },
                    { 118, "59311 Eric Fall", null, "Port Shanelle", null, "J9O 3H1", "BC" },
                    { 95, "74483 Hand Islands", null, "Lebsackport", null, "K8L 9D8", "NU" },
                    { 121, "61072 Renner Mountains", null, "North Greggview", null, "C3P 9H7", "PE" },
                    { 116, "134 Sabina Isle", null, "Flaviohaven", null, "B3G 3F6", "NB" },
                    { 112, "2457 Bernhard Passage", null, "Schroederfort", null, "R4E 4O4", "NU" },
                    { 111, "715 Sarah Locks", null, "Weissnatberg", null, "H2F 7N1", "PE" },
                    { 102, "4572 Baumbach Ridge", null, "Faeland", null, "L0B 9X1", "YT" },
                    { 77, "5897 Parker Rapid", null, "Cartermouth", null, "K2P 7Y4", "PE" },
                    { 99, "335 Monahan Station", null, "South Jacintheville", null, "T9N 3G8", "PE" },
                    { 86, "87880 Denesik Vista", null, "Ratkemouth", null, "M0H 1F6", "MB" },
                    { 110, "056 Littel Forest", null, "Leliaborough", null, "L0O 0P1", "NB" },
                    { 101, "68736 Cummerata Pass", null, "Stantonshire", null, "L0E 9I4", "PE" },
                    { 104, "62885 Archibald Meadow", null, "Herminialand", null, "S9X 1O2", "MB" },
                    { 82, "4470 Selina Summit", null, "Carmelaton", null, "C1S 8D7", "SK" },
                    { 134, "39664 Lea Isle", null, "MacGyverfurt", null, "K7R 2N4", "NS" },
                    { 29, "02056 Labadie Station", null, "North Evangeline", null, "C0A 9N6", "SK" },
                    { 152, "04427 Roman Square", null, "Langoshchester", null, "S0L 6C8", "NT" },
                    { 197, "6972 Harris Landing", null, "Oberbrunnershire", null, "L7M 5H7", "NU" },
                    { 46, "7840 Samir Way", null, "East Gerson", null, "H6Q 5Z8", "MB" },
                    { 158, "5887 Boyle Fords", null, "Brianside", null, "C4R 1O2", "NT" },
                    { 161, "657 Eula Well", null, "Lake Agustin", null, "C1X 1K3", "PE" },
                    { 3, "404 Mallory Lock", null, "Rheaside", null, "E1M 6U0", "NS" },
                    { 44, "0933 Kshlerin River", null, "Port Bradfordborough", null, "K2I 5V1", "MB" },
                    { 42, "5522 Adams Spurs", null, "North Chrisview", null, "J7U 3M7", "ON" },
                    { 8, "613 Homenick Station", null, "South Bridgetland", null, "H0Z 4F4", "MB" },
                    { 39, "411 Roscoe Road", null, "Quigleyfurt", null, "B8C 9D3", "NT" },
                    { 12, "000 Sandra Locks", null, "Brandofurt", null, "L1C 3U6", "QC" },
                    { 170, "53989 Treutel Corners", null, "Sylviashire", null, "Y0V 9F2", "NS" },
                    { 30, "3591 Murray Union", null, "Lake Alan", null, "M3W 2D0", "QC" },
                    { 185, "201 Hickle Neck", null, "New Bradberg", null, "G9B 4C1", "PE" },
                    { 28, "1593 Grady Circles", null, "Patienceshire", null, "P0D 9S0", "MB" },
                    { 35, "373 Huel Avenue", null, "Port Mossie", null, "H2O 2T8", "NU" },
                    { 17, "4228 Earnestine Parks", null, "Wintheiserville", null, "B2I 4G5", "ON" },
                    { 14, "063 Deckow Park", null, "Port Santinostad", null, "A8R 4R7", "YT" },
                    { 190, "464 Della Knoll", null, "Harveyshire", null, "K6G 0V8", "BC" },
                    { 34, "639 Lorenzo Isle", null, "Dickiborough", null, "E2A 8P2", "AB" },
                    { 24, "9717 O'Reilly Gateway", null, "Rockyland", null, "N1W 6A5", "NT" },
                    { 5, "635 Wyman Causeway", null, "Aliceview", null, "T1F 2L0", "NB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 194, "44143 Helga Wells", null, "New Dasia", null, "E3O 7E5", "ON" },
                    { 27, "041 Coleman Plain", null, "Darrenfort", null, "X9P 5Q8", "NL" },
                    { 4, "866 Kutch Villages", null, "Lake Mavis", null, "R0D 9B9", "AB" },
                    { 199, "8457 Zulauf Street", null, "New Eleonore", null, "P0J 7U8", "NS" },
                    { 156, "980 Maci Land", null, "Deshaunfurt", null, "G0H 7W1", "BC" },
                    { 47, "63617 Mercedes Ports", null, "Greenholtville", null, "J3P 3R3", "PE" },
                    { 45, "4827 Rey Heights", null, "Toyberg", null, "P2C 0N1", "YT" },
                    { 49, "010 Mose Row", null, "Thadshire", null, "G8P 8R3", "YT" },
                    { 93, "1427 Velda Bypass", null, "North Reyes", null, "E3X 5Y3", "ON" },
                    { 167, "24078 Emory Circle", null, "Mitchellview", null, "P4O 2T0", "NU" },
                    { 127, "1247 Kuhic Shoal", null, "North Evieton", null, "M5U 7A7", "MB" },
                    { 64, "07384 Carmelo Land", null, "East Austin", null, "T3T 9J1", "ON" },
                    { 171, "4912 Reynolds Viaduct", null, "Lake Tierra", null, "V8H 0I8", "NT" },
                    { 80, "76372 Eldora Street", null, "Christyland", null, "L7R 5P3", "NU" },
                    { 128, "94111 Austen Mills", null, "Lizethbury", null, "G6S 0N3", "PE" },
                    { 76, "4800 Toni Parks", null, "East Imamouth", null, "E6S 5F2", "NL" },
                    { 63, "9455 Maiya Prairie", null, "New Juniorchester", null, "G1A 0E9", "QC" },
                    { 176, "59719 Tremblay Passage", null, "Maynardburgh", null, "M9Y 5F2", "QC" },
                    { 74, "773 Corkery Glen", null, "Lake Sim", null, "V1I 1W4", "NB" },
                    { 132, "47363 Timmy Divide", null, "Cummerataville", null, "B2T 2V0", "NT" },
                    { 66, "1854 Aliza Skyway", null, "Borerhaven", null, "A7A 9B5", "NB" },
                    { 181, "559 Jared Divide", null, "Lake Hattieburgh", null, "K5B 2O1", "NT" },
                    { 61, "00386 Elton Bypass", null, "Kilbackland", null, "B3H 3F0", "BC" },
                    { 183, "395 Rogers Mountains", null, "D'Amoreland", null, "G2A 3M0", "NB" },
                    { 71, "830 McLaughlin Burgs", null, "Hayesfurt", null, "N0Q 2R8", "NU" },
                    { 138, "848 Demetris Hollow", null, "Rempelside", null, "P1O 9M4", "NT" },
                    { 184, "307 Dibbert Garden", null, "New Mabelle", null, "G9Z 2S3", "AB" },
                    { 59, "3029 Bogan Dale", null, "Agustinaburgh", null, "R3I 6L9", "MB" },
                    { 54, "903 Kirk Fords", null, "Maurineview", null, "K1R 4N9", "PE" },
                    { 142, "8550 Dicki Gateway", null, "Bettieberg", null, "P7Z 7K7", "SK" },
                    { 187, "4517 Brandi Fork", null, "East Clara", null, "V1C 7Y1", "NT" },
                    { 50, "777 Declan Road", null, "East Wilhelminebury", null, "A8W 4S9", "NT" },
                    { 150, "952 Rogahn Point", null, "West Tremayne", null, "T0Q 7U7", "PE" },
                    { 193, "9768 Chesley Lock", null, "Waelchiberg", null, "N7A 2L8", "NU" },
                    { 72, "1001 Gutmann Divide", null, "Lake Arjunmouth", null, "G7D 2L5", "NB" },
                    { 125, "983 Dejuan Mall", null, "Koeppchester", null, "K7W 3P9", "AB" },
                    { 200, "739 Sipes Harbors", null, "New Eliasburgh", null, "V9B 0L2", "ON" },
                    { 106, "61800 Lina Camp", null, "Kshlerinmouth", null, "J2G 6W3", "NB" },
                    { 9, "722 Cindy Port", null, "North Laneshire", null, "B1X 9H0", "NB" },
                    { 53, "9266 Randall Mill", null, "Tierraville", null, "N4T 5U1", "SK" },
                    { 51, "76927 Predovic Island", null, "Luettgenborough", null, "M8X 2A9", "ON" },
                    { 43, "216 Keebler Mill", null, "Schroederburgh", null, "L7W 1U1", "PE" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 10, "973 Schmidt Radial", null, "Lake Arnulfo", null, "M4G 4G4", "YT" },
                    { 151, "015 Becker Trafficway", null, "Blicktown", null, "E2F 6J4", "NB" },
                    { 33, "7525 Toni Parkways", null, "Royceview", null, "M0O 6T5", "NU" },
                    { 41, "919 Fahey Spur", null, "Rheashire", null, "X1O 8A3", "MB" },
                    { 32, "9293 Jeanie Green", null, "Lake Lucindaburgh", null, "V8H 8W6", "ON" },
                    { 13, "2230 Hyman Bridge", null, "North Leo", null, "T2T 5I2", "PE" },
                    { 157, "85534 Stephon Parkways", null, "Doyleville", null, "J1W 9D1", "AB" },
                    { 31, "054 Adaline Ferry", null, "Cummingsstad", null, "E3A 1R3", "YT" },
                    { 15, "70938 Beer Bypass", null, "Nakiafurt", null, "C0S 9J4", "ON" },
                    { 145, "697 Wilderman Parks", null, "Smithville", null, "R3A 7O3", "NL" },
                    { 38, "116 Reichel Ville", null, "West Alexaneville", null, "B7G 0D2", "SK" },
                    { 160, "970 Nolan Garden", null, "Madysonshire", null, "S8C 1T3", "NB" },
                    { 22, "6554 Leila Junctions", null, "Wiltonfurt", null, "B3U 9C5", "QC" },
                    { 18, "469 Williamson Island", null, "Rosarioburgh", null, "Y8Z 9X3", "YT" },
                    { 37, "023 Walker Underpass", null, "East Savannaton", null, "X5E 6P2", "NS" },
                    { 20, "358 McDermott Mountain", null, "Harveymouth", null, "H0J 9Y3", "AB" },
                    { 162, "991 Demarcus Plain", null, "Lake Loymouth", null, "Y8F 1T5", "NS" },
                    { 19, "81573 Frami Valleys", null, "Rowlandview", null, "X5G 0L5", "SK" },
                    { 21, "22833 Runolfsson Route", null, "West Leilaniside", null, "H5G 4Z7", "NL" },
                    { 163, "580 Aracely Mill", null, "Lehnerfort", null, "N4U 0T1", "NL" },
                    { 16, "1705 Bode Locks", null, "Colemouth", null, "T4D 1W9", "YT" },
                    { 40, "001 Reinger Key", null, "Terryshire", null, "R4A 3N3", "QC" },
                    { 165, "340 Conn Plaza", null, "Lake Velva", null, "A4L 0E9", "AB" },
                    { 7, "11959 Chanel Pike", null, "New Bridgette", null, "Y9R 6C0", "AB" },
                    { 23, "678 Ebert Spring", null, "Zackeryview", null, "L9Q 4T5", "AB" },
                    { 48, "4359 Sawayn Station", null, "North Nicolette", null, "E3X 2U4", "AB" },
                    { 55, "4457 Khalil Inlet", null, "Lake Vito", null, "H1Y 8L5", "AB" },
                    { 179, "8549 Bailey Spurs", null, "Gottliebfort", null, "A5R 6O5", "MB" },
                    { 123, "688 Keon Shoal", null, "Katelynfort", null, "T5J 8Q2", "BC" },
                    { 120, "99565 Olson Summit", null, "Baumbachborough", null, "S8L 1C3", "ON" },
                    { 114, "37125 Stacey Camp", null, "East Oren", null, "E1P 8B0", "NU" },
                    { 131, "5692 Schuyler Orchard", null, "East Annabel", null, "P5U 4P2", "ON" },
                    { 119, "972 Orpha Skyway", null, "Kohlertown", null, "G6E 3O0", "MB" },
                    { 130, "92088 Lubowitz Locks", null, "Gleasonfurt", null, "N1A 3N7", "YT" },
                    { 117, "0013 Osinski Station", null, "Jaydenfort", null, "A8A 0A7", "AB" },
                    { 139, "92124 Schmitt Lakes", null, "Vandervortton", null, "H8C 5I3", "SK" },
                    { 87, "99339 Kim Fork", null, "Reillyhaven", null, "Y1N 2F9", "AB" },
                    { 133, "76594 Orion Keys", null, "Pricebury", null, "L6J 4Y3", "YT" },
                    { 107, "2558 Jayde Cliffs", null, "Port Maudiestad", null, "E3B 9U6", "NL" },
                    { 85, "1277 Rasheed Cape", null, "Runolfssonhaven", null, "L0V 7N5", "NB" },
                    { 147, "840 Coy Loop", null, "East Eveline", null, "M3J 8X6", "NT" },
                    { 58, "5070 Kertzmann Greens", null, "Arnoldoburgh", null, "T7P 0V8", "MB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 103, "4818 Rossie Lodge", null, "North Eileen", null, "J4M 9M8", "NS" },
                    { 135, "17193 Cielo Meadows", null, "Hartmannburgh", null, "G7H 7K0", "NL" },
                    { 164, "47162 Jakubowski Street", null, "Port Stellashire", null, "N8O 0X6", "AB" },
                    { 79, "11461 Streich Ford", null, "New Thadmouth", null, "V7N 7O0", "YT" },
                    { 169, "559 Nona Haven", null, "Joanneburgh", null, "G5S 9F5", "MB" },
                    { 84, "39326 Marley Garden", null, "Mrazfort", null, "P5J 6Z3", "YT" },
                    { 136, "20767 Metz Radial", null, "North Summerport", null, "M7V 1F5", "NS" },
                    { 75, "48879 Bergstrom Springs", null, "Ronshire", null, "N8A 5J4", "QC" },
                    { 172, "2757 Makenzie Parks", null, "East Maximus", null, "T9J 6N8", "ON" },
                    { 69, "4616 Jaden Groves", null, "Watsicaburgh", null, "C0D 1L6", "SK" },
                    { 173, "6174 Durgan Roads", null, "New Matttown", null, "E6W 8X9", "NT" },
                    { 60, "8529 Keeling Rapids", null, "Quitzonchester", null, "A8B 0H3", "BC" },
                    { 56, "791 Koch Plains", null, "Kundetown", null, "C8V 0I1", "MB" },
                    { 141, "9986 Ferry Pike", null, "Danielmouth", null, "Y6C 5K1", "AB" },
                    { 94, "03701 Moen Turnpike", null, "North Makenna", null, "L2K 2P8", "SK" },
                    { 1, "2322 Medhurst Overpass", null, "Bednarmouth", null, "B7W 4Q8", "AB" },
                    { 126, "4938 Kassandra Well", null, "West Estefania", null, "P0V 0M5", "MB" },
                    { 166, "0868 Tyrel Prairie", null, "North Leone", null, "Y8O 9P5", "MB" },
                    { 178, "542 Akeem Parkway", null, "Bayerview", null, "C1D 6P5", "PE" },
                    { 159, "13058 Murphy Lake", null, "East Fredmouth", null, "C6O 0R0", "NU" },
                    { 155, "51775 Kirlin Islands", null, "Bechtelarmouth", null, "P3H 4Z3", "NL" },
                    { 36, "860 Grimes Flats", null, "South Louvenia", null, "P7M 3D8", "BC" },
                    { 11, "02657 Mayer Island", null, "North Helenton", null, "K8M 6A6", "NU" },
                    { 73, "13927 Johns Fork", null, "Port Ferne", null, "P4V 2R5", "NS" },
                    { 154, "6335 Savanna Harbors", null, "Bertramfort", null, "N4O 3L3", "NS" },
                    { 182, "793 Marcelo Mission", null, "Port Ferneview", null, "P3E 6C9", "PE" },
                    { 83, "466 Breanne Valleys", null, "New Samantha", null, "K0E 2W2", "ON" },
                    { 153, "410 Brown Creek", null, "New Letaton", null, "E5S 3A0", "ON" },
                    { 88, "2167 Maximus Streets", null, "Lake Michael", null, "V3Y 9A9", "NS" },
                    { 90, "592 Renner Grove", null, "North Abigaylechester", null, "E5I 1D8", "YT" },
                    { 149, "287 Rhiannon Islands", null, "New Maestad", null, "E5V 2M8", "NB" },
                    { 91, "7348 Mallory Lights", null, "Rodrigobury", null, "N1N 2Y3", "NS" },
                    { 186, "9388 Presley Stravenue", null, "Dickiborough", null, "M6I 5F8", "SK" },
                    { 144, "7213 Effertz Orchard", null, "Lake Minamouth", null, "A0V 7K4", "MB" },
                    { 191, "2732 Johnson Motorway", null, "South Addisonfurt", null, "J5K 5N0", "AB" },
                    { 143, "78568 Kaitlyn Wall", null, "North Huldaborough", null, "R9U 3S4", "BC" },
                    { 92, "088 Ortiz Estate", null, "North Amara", null, "R0L 9G0", "ON" },
                    { 6, "89275 Howe Burgs", null, "Lake Gustberg", null, "N6B 1F6", "YT" },
                    { 140, "679 Jamel Light", null, "New Shanna", null, "G9S 3G3", "ON" },
                    { 97, "750 Powlowski Island", null, "New Orval", null, "C7F 0S8", "NT" },
                    { 2, "0035 Gerson Centers", null, "Luisaport", null, "V9J 6T4", "NB" },
                    { 137, "2236 Joesph Manor", null, "Port Shad", null, "R6L 8N2", "NL" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 105, "148 Napoleon Lodge", null, "Keeleyshire", null, "N0L 0I4", "BC" },
                    { 192, "3723 Yolanda Turnpike", null, "Ritchieborough", null, "J8U 2Q3", "NS" },
                    { 129, "92070 Carole Shoals", null, "North Angelachester", null, "A1O 9T6", "QC" },
                    { 68, "297 Klocko Valley", null, "Alishire", null, "T8B 6S5", "NB" },
                    { 174, "15015 Feil Throughway", null, "Connermouth", null, "J2A 1P0", "MB" },
                    { 70, "94149 Larissa Tunnel", null, "Shanelmouth", null, "G0L 8X6", "YT" },
                    { 175, "6115 Ila Bypass", null, "North Jewelchester", null, "K7Q 3J6", "NS" },
                    { 189, "4776 Petra Port", null, "Lake Henderson", null, "K3E 4H1", "SK" },
                    { 188, "2821 Favian Coves", null, "Brionnaside", null, "V5R 6L4", "NB" },
                    { 198, "65614 Olen Cliff", null, "South Maxime", null, "A1M 7S3", "PE" },
                    { 52, "114 Ruth Villages", null, "Ferrybury", null, "V8X 1S2", "NL" },
                    { 65, "893 Orlando Mountain", null, "Crookschester", null, "A2X 3L3", "ON" },
                    { 62, "2082 Bertha Key", null, "New Damion", null, "H7V 1F6", "YT" },
                    { 57, "2755 Bogan Roads", null, "Carolinefurt", null, "H2W 6D7", "NT" },
                    { 195, "45078 Stanton Lodge", null, "South Ernie", null, "C2R 1A6", "NL" },
                    { 67, "5665 Christiansen Key", null, "Lake Rayview", null, "L7T 8Y9", "SK" },
                    { 25, "8595 Okuneva Street", null, "Mellieberg", null, "N2V 7Y7", "NU" },
                    { 26, "09548 Nicolas Track", null, "Monahanburgh", null, "V6Z 1R8", "NU" },
                    { 180, "613 Willis Spur", null, "Kemmerstad", null, "J4U 2X2", "ON" },
                    { 196, "264 Ernie Pass", null, "East Cathrine", null, "C8V 4K6", "BC" },
                    { 177, "0418 Wuckert Keys", null, "Keaganchester", null, "A0I 8K8", "PE" },
                    { 168, "07592 Lehner Creek", null, "South Richard", null, "X7M 0H6", "NT" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 3, 135 },
                    { 3, 165 },
                    { 2, 99 },
                    { 2, 161 },
                    { 4, 138 },
                    { 2, 158 },
                    { 4, 133 },
                    { 3, 192 },
                    { 2, 124 },
                    { 1, 170 },
                    { 3, 166 },
                    { 2, 200 },
                    { 3, 130 },
                    { 4, 127 },
                    { 3, 95 },
                    { 3, 168 },
                    { 3, 185 },
                    { 3, 175 },
                    { 2, 136 },
                    { 2, 178 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 2, 157 },
                    { 1, 151 },
                    { 12, 101 },
                    { 3, 101 },
                    { 3, 177 },
                    { 1, 142 },
                    { 2, 182 },
                    { 4, 160 },
                    { 4, 132 },
                    { 4, 145 },
                    { 4, 150 },
                    { 3, 186 },
                    { 3, 109 },
                    { 4, 141 },
                    { 2, 162 },
                    { 4, 156 },
                    { 4, 100 },
                    { 1, 191 },
                    { 2, 128 },
                    { 3, 163 },
                    { 4, 30 },
                    { 3, 190 },
                    { 1, 188 },
                    { 1, 96 },
                    { 2, 189 },
                    { 4, 195 },
                    { 1, 93 },
                    { 3, 196 },
                    { 1, 80 },
                    { 4, 198 },
                    { 8, 76 },
                    { 1, 1 },
                    { 1, 76 },
                    { 4, 7 },
                    { 2, 74 },
                    { 4, 16 },
                    { 3, 19 },
                    { 1, 180 },
                    { 4, 98 },
                    { 3, 174 },
                    { 2, 102 },
                    { 11, 125 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 1, 137 },
                    { 2, 125 },
                    { 3, 122 },
                    { 1, 140 },
                    { 4, 143 },
                    { 4, 121 },
                    { 4, 72 },
                    { 3, 144 },
                    { 4, 149 },
                    { 4, 113 },
                    { 4, 154 },
                    { 2, 111 },
                    { 4, 155 },
                    { 3, 104 },
                    { 2, 159 },
                    { 2, 118 },
                    { 8, 19 },
                    { 2, 71 },
                    { 1, 22 },
                    { 3, 75 },
                    { 2, 28 },
                    { 1, 79 },
                    { 1, 14 },
                    { 2, 94 },
                    { 3, 5 },
                    { 4, 103 },
                    { 4, 129 },
                    { 12, 4 },
                    { 3, 4 },
                    { 1, 117 },
                    { 7, 117 },
                    { 1, 199 },
                    { 4, 119 },
                    { 3, 194 },
                    { 2, 120 },
                    { 3, 107 },
                    { 4, 126 },
                    { 4, 69 },
                    { 12, 56 },
                    { 11, 22 },
                    { 4, 59 },
                    { 3, 23 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 1, 50 },
                    { 4, 31 },
                    { 7, 31 },
                    { 3, 49 },
                    { 4, 39 },
                    { 2, 32 },
                    { 1, 47 },
                    { 2, 43 },
                    { 3, 46 },
                    { 4, 53 },
                    { 4, 55 },
                    { 2, 44 },
                    { 1, 56 },
                    { 4, 33 },
                    { 4, 153 },
                    { 2, 2 },
                    { 4, 73 },
                    { 1, 131 },
                    { 2, 197 },
                    { 3, 139 },
                    { 4, 187 },
                    { 3, 147 },
                    { 4, 184 },
                    { 1, 164 },
                    { 3, 183 },
                    { 1, 181 },
                    { 1, 169 },
                    { 1, 172 },
                    { 4, 176 },
                    { 4, 173 },
                    { 3, 171 },
                    { 2, 167 },
                    { 3, 3 },
                    { 1, 123 },
                    { 2, 8 },
                    { 3, 114 },
                    { 4, 38 },
                    { 3, 41 },
                    { 2, 35 },
                    { 2, 34 },
                    { 1, 51 },
                    { 1, 58 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 2, 29 },
                    { 2, 152 },
                    { 2, 60 },
                    { 3, 24 },
                    { 2, 84 },
                    { 3, 85 },
                    { 7, 85 },
                    { 4, 17 },
                    { 4, 12 },
                    { 3, 87 },
                    { 4, 27 },
                    { 3, 179 },
                    { 2, 148 },
                    { 1, 146 },
                    { 13, 88 },
                    { 3, 88 },
                    { 4, 21 },
                    { 2, 40 },
                    { 8, 40 },
                    { 3, 83 },
                    { 4, 48 },
                    { 3, 91 },
                    { 13, 48 },
                    { 11, 70 },
                    { 4, 70 },
                    { 3, 57 },
                    { 3, 68 },
                    { 3, 62 },
                    { 1, 67 },
                    { 10, 65 },
                    { 2, 52 },
                    { 4, 42 },
                    { 3, 92 },
                    { 14, 92 },
                    { 2, 9 },
                    { 2, 134 },
                    { 3, 116 },
                    { 4, 10 },
                    { 3, 115 },
                    { 2, 112 },
                    { 1, 13 },
                    { 2, 20 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 4, 110 },
                    { 2, 15 },
                    { 3, 108 },
                    { 2, 106 },
                    { 8, 105 },
                    { 3, 105 },
                    { 3, 18 },
                    { 4, 97 },
                    { 9, 108 },
                    { 2, 45 },
                    { 2, 193 },
                    { 4, 65 },
                    { 3, 89 },
                    { 4, 11 },
                    { 8, 11 },
                    { 2, 86 },
                    { 4, 61 },
                    { 1, 82 },
                    { 2, 54 },
                    { 2, 36 },
                    { 4, 63 },
                    { 1, 26 },
                    { 3, 64 },
                    { 3, 25 },
                    { 3, 77 },
                    { 14, 45 },
                    { 2, 78 },
                    { 3, 6 },
                    { 4, 81 },
                    { 3, 66 },
                    { 2, 90 },
                    { 3, 37 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 214, "Ullam illo tempore beatae velit asperiores.", 10, 4105m, "Liquid", "Kg" },
                    { 411, "Architecto odit neque sequi quisquam porro adipisci voluptatibus suscipit.", 53, 19015m, "Gas", "Kg" },
                    { 218, "Autem at et quo illum doloribus.", 10, 6128m, "Gas", "L" },
                    { 255, "Voluptatem ad natus voluptatem.", 10, 16692m, "Gas", "L" },
                    { 406, "Laudantium neque et deleniti ipsam aut amet.", 186, 4880m, "Gas", "L" },
                    { 467, "Vitae autem explicabo non sed modi.", 10, 17749m, "Gas", "L" },
                    { 371, "Dignissimos qui cumque itaque sit.", 43, 14517m, "Gas", "Kg" },
                    { 446, "Consequatur quis praesentium autem fuga harum perspiciatis.", 186, 4890m, "Gas", "L" },
                    { 222, "Quo alias voluptas nihil tenetur soluta dicta sit.", 43, 13556m, "Liquid", "Kg" },
                    { 481, "Repudiandae sed accusamus qui fugit mollitia voluptatibus accusantium architecto.", 186, 6326m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 115, "Voluptatibus dolor recusandae perferendis id dolor deleniti ab assumenda possimus.", 13, 19100m, "Gas", "Kg" },
                    { 354, "Fuga sed quis consequuntur deserunt et.", 196, 9356m, "Liquid", "Kg" },
                    { 165, "Nam dolorum quis hic dolores et.", 13, 19762m, "Solid", "L" },
                    { 201, "Doloremque voluptas officia tenetur repellendus cumque.", 11, 9792m, "Solid", "L" },
                    { 328, "Ipsam quia exercitationem voluptas sapiente.", 33, 6157m, "Solid", "Kg" },
                    { 235, "Enim sit impedit sit consequatur et iure.", 33, 19459m, "Gas", "L" },
                    { 85, "Laudantium rerum enim illum reprehenderit quasi praesentium quis aut.", 33, 17481m, "Gas", "Kg" },
                    { 169, "Autem possimus officiis quia ex sapiente omnis est.", 11, 16321m, "Solid", "L" },
                    { 221, "Fugit sit praesentium fugit sed architecto aut tempora aut est.", 13, 13462m, "Liquid", "L" },
                    { 486, "Asperiores harum sit officiis animi rerum doloribus.", 13, 16426m, "Liquid", "L" },
                    { 91, "Saepe qui delectus aliquam sit.", 11, 9454m, "Solid", "L" },
                    { 17, "Doloremque consequatur repellat quam.", 191, 7971m, "Gas", "Kg" },
                    { 339, "In et eveniet et quo in qui nihil.", 186, 12051m, "Gas", "Kg" },
                    { 404, "Animi itaque labore.", 9, 11885m, "Gas", "Kg" },
                    { 240, "Excepturi qui odit amet voluptatibus numquam eos nulla explicabo.", 55, 12741m, "Gas", "L" },
                    { 302, "Aut autem sequi aut molestias libero magni quibusdam tempora.", 186, 2167m, "Solid", "Kg" },
                    { 423, "Amet molestiae quia sit enim qui suscipit accusantium.", 75, 18263m, "Liquid", "Kg" },
                    { 3, "Quam ipsum itaque quam sunt deserunt aut earum provident quo.", 173, 12172m, "Gas", "Kg" },
                    { 402, "Autem rerum corporis.", 200, 7127m, "Solid", "L" },
                    { 215, "Eum similique iusto et.", 173, 10036m, "Gas", "Kg" },
                    { 355, "Voluptate explicabo quisquam dolores natus.", 173, 16340m, "Gas", "L" },
                    { 295, "Rerum ut id voluptatum natus eius.", 69, 3812m, "Solid", "L" },
                    { 31, "Velit et cum.", 25, 8200m, "Gas", "L" },
                    { 247, "Ut porro quam voluptatem quod reiciendis vel accusamus.", 69, 5123m, "Solid", "L" },
                    { 258, "Optio esse totam suscipit modi rem est at id amet.", 200, 17579m, "Liquid", "Kg" },
                    { 4, "Perspiciatis dolorum corporis et.", 179, 7202m, "Gas", "L" },
                    { 27, "Eaque non nulla quia voluptates autem voluptate qui.", 25, 19241m, "Liquid", "L" },
                    { 78, "Quia facere reprehenderit ut est iusto veritatis est natus.", 179, 16882m, "Gas", "L" },
                    { 415, "Ratione labore dolores eos eos beatae beatae eum quos fugit.", 56, 14284m, "Solid", "Kg" },
                    { 379, "Perferendis esse distinctio modi repellat.", 56, 12663m, "Solid", "L" },
                    { 112, "Non fugiat quo quo cupiditate a modi voluptas voluptas.", 62, 13927m, "Solid", "L" },
                    { 82, "Commodi consequatur quis quis consequatur aut.", 56, 12357m, "Gas", "Kg" },
                    { 71, "Vitae amet hic nam.", 56, 12929m, "Gas", "Kg" },
                    { 399, "Aliquid aperiam dicta vero deleniti nihil.", 179, 2676m, "Gas", "L" },
                    { 63, "Exercitationem voluptatem repellat distinctio consequatur ut repellendus.", 196, 6645m, "Liquid", "Kg" },
                    { 474, "Necessitatibus amet id.", 11, 12330m, "Solid", "Kg" },
                    { 1, "Incidunt alias recusandae cumque est.", 9, 3329m, "Solid", "L" },
                    { 195, "Corrupti quaerat qui sunt facilis saepe nemo.", 9, 13628m, "Gas", "L" },
                    { 452, "Dicta excepturi est incidunt ut consectetur.", 55, 16363m, "Liquid", "L" },
                    { 278, "Voluptatem pariatur qui rem aut et eligendi cumque.", 55, 15087m, "Gas", "Kg" },
                    { 338, "Dignissimos ipsa quia non vero ullam veniam.", 11, 5982m, "Gas", "L" },
                    { 439, "Possimus qui autem facilis assumenda aut inventore.", 32, 6856m, "Solid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 23, "Nemo officia et dignissimos itaque.", 191, 5121m, "Liquid", "Kg" },
                    { 380, "Labore sit vitae quisquam neque a nemo rerum.", 32, 6085m, "Gas", "Kg" },
                    { 35, "Qui aperiam minima qui fugiat et eligendi.", 62, 18947m, "Solid", "Kg" },
                    { 266, "Commodi repellendus expedita eos minima quas ea exercitationem eum sint.", 198, 3483m, "Solid", "L" },
                    { 129, "Doloremque est possimus hic voluptate.", 21, 208m, "Solid", "L" },
                    { 187, "Ut quia nihil quibusdam sequi ipsam rerum.", 21, 2941m, "Solid", "L" },
                    { 310, "Dolore quo et pariatur ut et adipisci.", 19, 5902m, "Liquid", "L" },
                    { 281, "Eos asperiores provident pariatur.", 19, 16892m, "Gas", "L" },
                    { 494, "Cum iusto voluptas.", 21, 2856m, "Liquid", "L" },
                    { 48, "Ea illum sit occaecati ut dolorem consequuntur exercitationem.", 57, 19996m, "Gas", "L" },
                    { 152, "Culpa officia reprehenderit a non sunt nulla.", 2, 6048m, "Liquid", "Kg" },
                    { 462, "Eum nemo aut.", 6, 14565m, "Gas", "Kg" },
                    { 72, "Perferendis reiciendis laborum repellendus laboriosam rerum.", 40, 14373m, "Solid", "L" },
                    { 363, "Quae et quisquam id molestias voluptatem.", 52, 718m, "Solid", "L" },
                    { 143, "Voluptatum fugit et.", 16, 12353m, "Liquid", "Kg" },
                    { 321, "Iure repellat odit et et praesentium nihil aut aut et.", 192, 9792m, "Solid", "Kg" },
                    { 382, "Nulla iusto provident illo est nulla error ducimus.", 192, 2338m, "Liquid", "L" },
                    { 292, "Quia voluptas amet expedita expedita ab qui voluptatem iste veniam.", 48, 2522m, "Solid", "L" },
                    { 483, "Id ut aut velit quo dolores itaque.", 7, 13283m, "Liquid", "L" },
                    { 409, "Aut magni accusamus sit ipsum quas facere aperiam voluptas quibusdam.", 7, 12944m, "Solid", "Kg" },
                    { 185, "Laudantium corrupti a necessitatibus quis ea error molestiae explicabo autem.", 7, 8961m, "Solid", "Kg" },
                    { 167, "Aperiam eos aut modi voluptatibus consectetur nobis.", 7, 4765m, "Gas", "L" },
                    { 459, "Et quia fugiat deserunt cupiditate ut.", 192, 17140m, "Solid", "Kg" },
                    { 203, "In et quo amet.", 52, 2871m, "Solid", "L" },
                    { 113, "Est nam accusantium reiciendis voluptatem ad et.", 1, 15254m, "Liquid", "Kg" },
                    { 466, "Amet quae maxime ipsam et ipsa sint ut reprehenderit eum.", 2, 12347m, "Solid", "Kg" },
                    { 438, "Iusto dicta enim harum quis et veniam dolor facere laboriosam.", 191, 15376m, "Solid", "Kg" },
                    { 333, "Voluptas est dicta qui impedit sequi.", 191, 4576m, "Gas", "L" },
                    { 166, "Exercitationem odio est dolorem rerum delectus quam enim dolorem.", 20, 12451m, "Liquid", "L" },
                    { 256, "Suscipit necessitatibus voluptatem quam veniam voluptates error voluptas beatae.", 200, 10213m, "Solid", "Kg" },
                    { 84, "Aut sunt recusandae sit aliquam ex qui.", 15, 13850m, "Solid", "Kg" },
                    { 162, "Non maiores odit dicta et officiis est sed labore.", 15, 11113m, "Gas", "L" },
                    { 414, "Blanditiis ex optio.", 15, 241m, "Gas", "Kg" },
                    { 67, "Voluptatem voluptatem nihil magni error voluptates sit at nemo omnis.", 191, 6507m, "Solid", "L" },
                    { 208, "Ad alias alias eos.", 31, 3072m, "Solid", "Kg" },
                    { 25, "Id veritatis quibusdam veritatis.", 31, 12100m, "Liquid", "Kg" },
                    { 77, "Molestiae aspernatur inventore possimus.", 25, 16842m, "Solid", "L" },
                    { 123, "Consequatur voluptatem in rerum dicta perferendis ut.", 18, 18694m, "Liquid", "Kg" },
                    { 176, "Error quos cumque dolorem provident vitae omnis voluptatibus iusto inventore.", 18, 11542m, "Liquid", "Kg" },
                    { 182, "Ad atque a est.", 18, 19953m, "Liquid", "L" },
                    { 264, "Neque rerum eaque asperiores dolor esse explicabo vero quam.", 23, 12178m, "Liquid", "Kg" },
                    { 145, "Aspernatur omnis quasi.", 1, 1317m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 216, "Id aut sapiente officiis nobis ut libero.", 23, 3480m, "Solid", "L" },
                    { 128, "Odit dolore dolor aliquam.", 23, 8721m, "Liquid", "Kg" },
                    { 263, "Vitae quis earum qui odio ex sequi ad mollitia quaerat.", 191, 11801m, "Solid", "Kg" },
                    { 74, "Tenetur sit quo consequuntur nostrum aperiam.", 23, 18930m, "Gas", "L" },
                    { 46, "Mollitia non non dicta nisi fugit est magni non ipsa.", 23, 6877m, "Solid", "Kg" },
                    { 329, "Autem qui delectus quidem in sed aliquam.", 18, 684m, "Solid", "Kg" },
                    { 334, "Dolorem et accusantium officiis voluptatum.", 18, 15870m, "Liquid", "Kg" },
                    { 190, "Debitis qui accusamus molestiae deleniti.", 198, 16425m, "Solid", "Kg" },
                    { 280, "Cupiditate eius blanditiis nemo eligendi quis temporibus nulla earum.", 191, 15499m, "Liquid", "L" },
                    { 417, "In asperiores id repudiandae quis maxime et pariatur.", 22, 3069m, "Gas", "L" },
                    { 331, "Vel voluptate cumque incidunt neque.", 191, 13086m, "Liquid", "Kg" },
                    { 307, "Laborum architecto omnis et ex.", 22, 11075m, "Solid", "Kg" },
                    { 75, "Fugiat molestias vitae culpa.", 57, 2221m, "Gas", "Kg" },
                    { 253, "Occaecati ducimus delectus debitis earum.", 52, 14892m, "Gas", "Kg" },
                    { 389, "Non pariatur laborum eius qui omnis.", 178, 5718m, "Liquid", "L" },
                    { 419, "Totam qui neque dolores nam sequi fuga veritatis qui.", 178, 13599m, "Gas", "Kg" },
                    { 244, "Temporibus aperiam et pariatur corrupti voluptatem laudantium eaque illo.", 36, 13356m, "Gas", "L" },
                    { 109, "Facilis porro ab.", 36, 18114m, "Gas", "L" },
                    { 130, "Consequuntur nesciunt et explicabo.", 60, 14703m, "Liquid", "Kg" },
                    { 305, "Molestiae vitae sit porro dolorem quia voluptatem mollitia odit quia.", 60, 18028m, "Solid", "Kg" },
                    { 497, "Dignissimos impedit quam sit officia dolorem sunt repudiandae accusamus.", 141, 9230m, "Solid", "L" },
                    { 12, "Molestias earum est sit magni natus sit sunt.", 168, 2121m, "Liquid", "Kg" },
                    { 251, "Asperiores minima illo vitae vero laboriosam sed exercitationem.", 141, 4470m, "Solid", "L" },
                    { 217, "Ad et ut voluptas dolor praesentium omnis ut.", 141, 17399m, "Liquid", "Kg" },
                    { 173, "Saepe autem autem illum aut.", 141, 2060m, "Gas", "L" },
                    { 61, "Minima perspiciatis doloribus velit.", 168, 19916m, "Gas", "Kg" },
                    { 210, "Eius assumenda nihil fuga.", 168, 19127m, "Solid", "L" },
                    { 198, "Dolores nesciunt sed dolores sapiente.", 84, 8717m, "Liquid", "Kg" },
                    { 116, "Et sit dolorem tempore fugiat repellat voluptatibus odit.", 58, 16378m, "Liquid", "Kg" },
                    { 352, "Maxime molestias ut.", 84, 14906m, "Solid", "Kg" },
                    { 192, "Corporis et laborum voluptas voluptates.", 136, 3548m, "Solid", "Kg" },
                    { 54, "Deleniti laboriosam sed unde dolorum at quam ut.", 136, 6318m, "Liquid", "L" },
                    { 287, "Dolores aliquam debitis.", 168, 17210m, "Gas", "L" },
                    { 386, "Quas sequi fugiat alias voluptate reprehenderit autem distinctio dignissimos saepe.", 85, 2339m, "Gas", "Kg" },
                    { 490, "Explicabo ipsa quae at.", 135, 2248m, "Gas", "L" },
                    { 442, "Nesciunt necessitatibus facere facere sed eveniet repellat vel maxime.", 135, 18186m, "Gas", "Kg" },
                    { 238, "Repellendus provident et omnis tempora saepe quidem.", 135, 2547m, "Gas", "Kg" },
                    { 441, "Enim repudiandae voluptas magni in neque esse dolorem.", 168, 17825m, "Gas", "Kg" },
                    { 421, "Aut aut quia.", 85, 8326m, "Solid", "Kg" },
                    { 42, "Voluptatem ut perspiciatis aut aliquid sit.", 36, 4231m, "Liquid", "Kg" },
                    { 471, "Perferendis ut omnis consequatur recusandae suscipit rerum ex maiores id.", 26, 15764m, "Solid", "L" },
                    { 433, "Consequatur incidunt aut.", 133, 10868m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 299, "Neque aut nulla error quae optio praesentium.", 136, 14941m, "Liquid", "L" },
                    { 270, "Rerum quas minima.", 133, 667m, "Solid", "Kg" },
                    { 430, "Consequuntur qui et aut praesentium iure et ut non expedita.", 51, 4474m, "Gas", "L" },
                    { 119, "Beatae distinctio qui rerum alias tempore fugit earum qui tempora.", 51, 18873m, "Gas", "L" },
                    { 188, "Officiis et et quisquam deleniti ut quo.", 37, 14924m, "Gas", "Kg" },
                    { 65, "Exercitationem et atque.", 165, 1848m, "Gas", "Kg" },
                    { 312, "Perferendis alias rem voluptas modi.", 37, 2349m, "Liquid", "Kg" },
                    { 345, "Quasi consequatur natus unde consequatur dolores et esse.", 37, 12106m, "Liquid", "L" },
                    { 403, "Aut ipsum modi.", 37, 19310m, "Gas", "L" },
                    { 40, "Tempore sint est doloremque consequatur.", 163, 19324m, "Solid", "Kg" },
                    { 475, "Molestias eligendi ea dolorum rem amet et cumque sunt debitis.", 37, 14965m, "Gas", "Kg" },
                    { 491, "Asperiores porro consectetur id.", 37, 17129m, "Gas", "L" },
                    { 168, "Voluptatem quo blanditiis fugiat quidem.", 166, 3601m, "Solid", "L" },
                    { 465, "Pariatur porro voluptas vel debitis vel.", 162, 18792m, "Solid", "Kg" },
                    { 28, "Aut ratione eius voluptas officiis praesentium.", 162, 176m, "Gas", "Kg" },
                    { 357, "Distinctio et sint et minima nesciunt odio et.", 38, 18932m, "Gas", "L" },
                    { 126, "Quaerat nostrum tenetur impedit velit.", 151, 18199m, "Solid", "Kg" },
                    { 455, "Voluptatem omnis aliquid aperiam eos deleniti provident quasi.", 38, 5356m, "Gas", "L" },
                    { 368, "Quo voluptas tempore vel et itaque voluptatem quaerat nihil.", 160, 18835m, "Gas", "L" },
                    { 202, "Id sit est ipsum et vel perferendis est.", 41, 5311m, "Solid", "L" },
                    { 224, "Rerum possimus optio commodi minus.", 41, 14317m, "Solid", "L" },
                    { 197, "Similique totam ut qui omnis et iusto exercitationem sit voluptatem.", 166, 2005m, "Liquid", "L" },
                    { 254, "Sint voluptatem reiciendis consequatur et consequatur sequi totam repellendus ut.", 41, 16811m, "Liquid", "L" },
                    { 317, "Est tenetur dolores.", 157, 7277m, "Liquid", "L" },
                    { 148, "Autem laboriosam quia omnis dignissimos quasi exercitationem et quo numquam.", 157, 3378m, "Solid", "L" },
                    { 105, "Ut maxime qui rerum modi vel earum.", 157, 16366m, "Solid", "Kg" },
                    { 69, "Ab aut at omnis ut vel neque doloremque molestiae.", 157, 1236m, "Solid", "L" },
                    { 482, "Explicabo explicabo dolor ut blanditiis rerum quasi.", 41, 10897m, "Liquid", "L" },
                    { 425, "Quae aperiam enim sunt odio laudantium odio et hic rerum.", 166, 7928m, "Solid", "L" },
                    { 315, "In provident est eveniet quo perspiciatis tempora pariatur debitis.", 36, 17010m, "Solid", "L" },
                    { 194, "Cum ducimus cumque debitis explicabo.", 166, 11696m, "Gas", "Kg" },
                    { 125, "Vitae at similique qui est iure est voluptate error nobis.", 175, 4381m, "Liquid", "Kg" },
                    { 236, "Voluptas deserunt repudiandae minima pariatur voluptatem non.", 133, 9025m, "Solid", "L" },
                    { 57, "Necessitatibus dolor quia iusto.", 114, 14554m, "Gas", "Kg" },
                    { 141, "Perferendis quis ut eligendi.", 147, 4492m, "Solid", "L" },
                    { 336, "Rem similique eveniet dolore autem et.", 107, 4618m, "Gas", "L" },
                    { 330, "Aut necessitatibus atque ad modi hic qui.", 107, 13769m, "Gas", "Kg" },
                    { 8, "Cupiditate odio ut.", 107, 9402m, "Liquid", "L" },
                    { 476, "Eos sit at eum consequatur et.", 25, 1723m, "Liquid", "L" },
                    { 5, "Nulla sint ut sint repudiandae consequatur in quis sapiente.", 107, 1829m, "Liquid", "L" },
                    { 343, "Voluptatem asperiores fuga.", 147, 5476m, "Gas", "L" },
                    { 108, "Possimus et repellat nisi rerum voluptatem.", 25, 1434m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 14, "Aut omnis sit.", 164, 13383m, "Liquid", "L" },
                    { 500, "Beatae voluptatem nam.", 103, 4268m, "Gas", "Kg" },
                    { 435, "Numquam sunt rerum sunt id voluptatem.", 103, 17497m, "Solid", "L" },
                    { 262, "Fuga autem asperiores sunt accusamus commodi error.", 103, 18742m, "Gas", "L" },
                    { 107, "Et vitae incidunt odio atque velit rerum non molestias.", 147, 13901m, "Gas", "L" },
                    { 49, "Est vel sint ratione consequatur cupiditate dolor maiores ex qui.", 103, 12146m, "Gas", "Kg" },
                    { 242, "Odio aut consequatur.", 164, 15102m, "Liquid", "Kg" },
                    { 62, "Temporibus ex libero atque voluptas.", 178, 12543m, "Solid", "L" },
                    { 293, "Soluta voluptatem harum qui dignissimos.", 164, 18014m, "Gas", "L" },
                    { 257, "Pariatur et nihil voluptatem dignissimos neque corrupti temporibus et libero.", 94, 12537m, "Liquid", "L" },
                    { 366, "Doloremque laborum qui tempora.", 164, 6705m, "Gas", "Kg" },
                    { 151, "Ea consequatur omnis hic culpa et doloremque.", 178, 13543m, "Liquid", "L" },
                    { 97, "Reprehenderit doloribus ea excepturi quasi et aperiam nemo.", 169, 19940m, "Solid", "L" },
                    { 372, "Qui quo non officia accusantium et.", 79, 988m, "Liquid", "L" },
                    { 88, "Nulla repudiandae fugit id unde labore est.", 79, 15378m, "Gas", "Kg" },
                    { 6, "Nihil qui eum impedit officiis aut nostrum animi.", 79, 11870m, "Solid", "L" },
                    { 381, "Voluptas rerum voluptatum et.", 178, 16858m, "Solid", "Kg" },
                    { 454, "Libero illo sint et consequatur possimus quaerat voluptatibus.", 172, 14377m, "Liquid", "Kg" },
                    { 223, "In enim quibusdam qui ex quas fugit corporis.", 164, 11396m, "Gas", "L" },
                    { 93, "Recusandae animi et ullam.", 147, 2494m, "Gas", "L" },
                    { 495, "Architecto consequatur enim adipisci ut ut nesciunt.", 25, 19822m, "Solid", "Kg" },
                    { 110, "Deserunt molestias id.", 117, 3091m, "Gas", "Kg" },
                    { 137, "Vero itaque ratione.", 114, 10323m, "Liquid", "L" },
                    { 347, "Et aliquam dolorem ipsa facilis ut incidunt aliquid ducimus.", 114, 11633m, "Gas", "L" },
                    { 499, "Est qui dolorum quia autem et expedita.", 130, 17083m, "Gas", "L" },
                    { 323, "Maxime totam voluptas sed accusantium.", 130, 543m, "Gas", "L" },
                    { 138, "Quae quibusdam omnis in deserunt ex doloremque ut nulla.", 130, 19027m, "Liquid", "L" },
                    { 100, "Voluptates non voluptatem et et ut rerum odio.", 130, 7114m, "Gas", "Kg" },
                    { 90, "Nihil voluptatum asperiores aut expedita.", 130, 8065m, "Gas", "L" },
                    { 51, "Et nam consequatur eveniet qui ipsum soluta eos ad.", 123, 3439m, "Solid", "Kg" },
                    { 99, "Minima odit vero et qui similique eos.", 123, 13954m, "Solid", "Kg" },
                    { 397, "Nam quia nihil deleniti totam consequatur accusantium doloremque dolore.", 175, 17406m, "Liquid", "L" },
                    { 464, "Aut dignissimos modi ipsam harum.", 126, 2502m, "Solid", "L" },
                    { 422, "In aut ut sit suscipit.", 126, 14335m, "Liquid", "Kg" },
                    { 239, "Qui enim qui.", 123, 12347m, "Solid", "L" },
                    { 458, "Tempora et quos molestiae eum ipsa.", 26, 12731m, "Solid", "Kg" },
                    { 133, "Aut incidunt consequatur nemo sequi dignissimos quia eos.", 131, 8727m, "Liquid", "Kg" },
                    { 144, "Dolor nobis esse ut minima ea suscipit eos.", 26, 12189m, "Gas", "Kg" },
                    { 134, "Dolorum neque ea voluptatem.", 120, 6973m, "Liquid", "Kg" },
                    { 18, "Quasi nihil eveniet.", 120, 17429m, "Solid", "Kg" },
                    { 325, "Maxime autem iusto quia id.", 131, 13838m, "Liquid", "Kg" },
                    { 453, "Est error in omnis ad.", 62, 10474m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 22, "Aut ipsa quam distinctio saepe illum ratione eaque.", 139, 15547m, "Liquid", "Kg" },
                    { 398, "Fuga quis numquam omnis reiciendis quia optio sint.", 119, 187m, "Liquid", "L" },
                    { 349, "Repellat doloremque accusamus nostrum quis inventore.", 119, 10312m, "Liquid", "Kg" },
                    { 170, "Distinctio perferendis et beatae ad consequuntur.", 139, 1172m, "Liquid", "L" },
                    { 241, "Ut in hic illo iusto.", 139, 2118m, "Solid", "Kg" },
                    { 472, "Mollitia molestiae illum officia laborum vel.", 139, 8265m, "Gas", "Kg" },
                    { 392, "Omnis et ratione.", 177, 1076m, "Liquid", "Kg" },
                    { 489, "Esse nostrum voluptatem quia.", 75, 7735m, "Gas", "Kg" },
                    { 140, "Vitae sed voluptas quia quod nobis officia fuga.", 37, 9694m, "Liquid", "L" },
                    { 436, "Qui harum voluptatem eius sed ea tempora in.", 90, 9976m, "Gas", "L" },
                    { 24, "In suscipit voluptatibus dignissimos id blanditiis illum accusantium sunt.", 67, 8455m, "Gas", "L" },
                    { 250, "Quia qui est odio est itaque nisi harum et similique.", 5, 16268m, "Liquid", "L" },
                    { 175, "Quibusdam minima eius dignissimos ea culpa molestiae voluptatum necessitatibus consectetur.", 5, 16164m, "Gas", "Kg" },
                    { 487, "Officiis sed vitae fugiat quaerat illum repellat laboriosam reprehenderit alias.", 27, 18312m, "Gas", "L" },
                    { 378, "Ad aperiam vel velit exercitationem omnis vel laborum ipsa.", 29, 10659m, "Gas", "L" },
                    { 461, "Possimus ab facilis consequatur velit totam cumque rerum ipsum.", 4, 17982m, "Solid", "Kg" },
                    { 420, "Atque omnis ut odio enim.", 4, 17540m, "Gas", "L" },
                    { 50, "Saepe accusantium voluptas qui fugiat cupiditate nobis non.", 4, 812m, "Solid", "L" },
                    { 45, "Voluptatem et velit nobis.", 4, 2919m, "Solid", "Kg" },
                    { 460, "Et nihil est.", 29, 972m, "Solid", "L" },
                    { 55, "Dolores et ea laboriosam laudantium est.", 34, 3029m, "Gas", "Kg" },
                    { 183, "Odit quo voluptatum natus sunt quibusdam.", 34, 14468m, "Solid", "L" },
                    { 324, "Velit vel nesciunt sunt.", 199, 14442m, "Gas", "Kg" },
                    { 271, "Voluptatem nisi quisquam eligendi qui quae ut.", 199, 18199m, "Liquid", "L" },
                    { 401, "Adipisci sequi aut ipsum eos necessitatibus.", 34, 5752m, "Liquid", "Kg" },
                    { 449, "Quia et reprehenderit sapiente iusto voluptas laudantium et.", 34, 8709m, "Solid", "L" },
                    { 64, "Aperiam dolore ex velit porro incidunt eaque.", 194, 1309m, "Liquid", "L" },
                    { 43, "Culpa enim unde voluptatibus eum.", 194, 7633m, "Gas", "L" },
                    { 19, "Nihil illo dolore.", 194, 8037m, "Gas", "L" },
                    { 15, "Non deleniti reiciendis aut quo ut est ipsa.", 35, 11885m, "Solid", "Kg" },
                    { 102, "Vitae quia laborum soluta alias cum.", 35, 8468m, "Solid", "Kg" },
                    { 246, "Deleniti adipisci quia aut harum quaerat nihil aliquid dignissimos.", 35, 13187m, "Solid", "Kg" },
                    { 361, "Voluptatem amet debitis illo beatae quia amet molestiae laudantium.", 190, 11722m, "Solid", "L" },
                    { 342, "Tempore eveniet et.", 190, 103m, "Liquid", "L" },
                    { 350, "Fugiat facere aliquid velit.", 35, 7784m, "Liquid", "Kg" },
                    { 76, "Aut et temporibus pariatur.", 42, 14729m, "Liquid", "Kg" },
                    { 316, "Vero illo eos assumenda odio et nostrum commodi sed praesentium.", 185, 1447m, "Gas", "Kg" },
                    { 120, "Placeat sint animi corrupti enim unde qui exercitationem.", 42, 6171m, "Liquid", "Kg" },
                    { 177, "Tempore commodi exercitationem ut voluptatem qui rerum modi corporis.", 42, 1895m, "Gas", "L" },
                    { 204, "Nemo quisquam quibusdam qui.", 42, 7658m, "Gas", "Kg" },
                    { 21, "Ipsa quia nulla quisquam voluptatem a ratione sint.", 27, 8124m, "Gas", "Kg" },
                    { 335, "Et dolores rerum ex quas earum quis perspiciatis libero.", 24, 6108m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 327, "Numquam ipsum sequi.", 24, 69m, "Gas", "Kg" },
                    { 34, "Quisquam eaque ex voluptas quas sint qui.", 24, 17763m, "Solid", "L" },
                    { 448, "Minima natus nihil sequi blanditiis blanditiis est consequatur voluptas in.", 197, 15775m, "Solid", "L" },
                    { 469, "Deleniti alias similique vitae et qui.", 47, 5831m, "Solid", "L" },
                    { 416, "Illo voluptatibus voluptas animi perferendis dolor perferendis.", 47, 11481m, "Gas", "Kg" },
                    { 391, "Sint voluptatem incidunt ut aspernatur quaerat magni cupiditate officia.", 47, 18095m, "Solid", "L" },
                    { 358, "Nihil est et est qui dignissimos.", 47, 16919m, "Liquid", "Kg" },
                    { 273, "Harum odit debitis exercitationem dolor sequi fuga.", 47, 9433m, "Liquid", "Kg" },
                    { 252, "Molestiae assumenda voluptatem omnis nihil laudantium quidem.", 47, 17161m, "Gas", "Kg" },
                    { 164, "Aspernatur culpa possimus.", 47, 1768m, "Gas", "L" },
                    { 36, "Consequatur adipisci possimus id vitae exercitationem.", 3, 19974m, "Solid", "Kg" },
                    { 156, "Et vero fugit rem recusandae.", 3, 8069m, "Liquid", "L" },
                    { 279, "Sint ratione dolores rerum omnis quaerat.", 3, 19619m, "Solid", "Kg" },
                    { 32, "Deleniti autem incidunt sed nihil labore.", 46, 16879m, "Liquid", "L" },
                    { 13, "Unde soluta repellat impedit excepturi dolore sequi.", 46, 11948m, "Liquid", "L" },
                    { 296, "Cupiditate nihil natus rerum.", 8, 12823m, "Solid", "Kg" },
                    { 434, "Et illum quibusdam eius et neque in quis quia eum.", 170, 19408m, "Solid", "L" },
                    { 367, "Et voluptas inventore quis nam voluptas.", 8, 7312m, "Solid", "Kg" },
                    { 172, "Ut eos fugiat quisquam.", 44, 9527m, "Solid", "L" },
                    { 249, "Possimus est dolorem nesciunt modi voluptates.", 12, 15943m, "Gas", "Kg" },
                    { 447, "Qui ipsa et quas ab nostrum odio qui nostrum.", 39, 18861m, "Liquid", "Kg" },
                    { 245, "Illum tempora vitae placeat aut ea eum.", 39, 7443m, "Gas", "Kg" },
                    { 207, "Error quo ut quis eos et.", 39, 14200m, "Liquid", "Kg" },
                    { 41, "Quam molestiae iure enim fugit ipsa.", 39, 8516m, "Liquid", "Kg" },
                    { 59, "Eius ut veritatis nesciunt aut.", 17, 4940m, "Liquid", "Kg" },
                    { 98, "Eum reiciendis autem.", 17, 18127m, "Gas", "Kg" },
                    { 205, "Et occaecati et in.", 17, 9791m, "Gas", "L" },
                    { 219, "Explicabo quibusdam qui tempora.", 17, 6436m, "Solid", "Kg" },
                    { 248, "Est quis quam omnis nemo dolor tempore tempore.", 17, 5330m, "Liquid", "L" },
                    { 314, "Quis qui aut.", 17, 17274m, "Liquid", "L" },
                    { 348, "Consequuntur vero maiores nulla nemo numquam temporibus dolorem molestias.", 28, 15867m, "Liquid", "Kg" },
                    { 47, "Ut nesciunt nam dolorum dolor fugiat dicta voluptate occaecati adipisci.", 28, 6394m, "Solid", "Kg" },
                    { 407, "Molestias non voluptatem voluptatibus facere omnis suscipit inventore.", 44, 5944m, "Solid", "Kg" },
                    { 146, "Et rem dolore a dolores eius aut.", 170, 13758m, "Solid", "Kg" },
                    { 424, "Qui illum sunt voluptatem.", 42, 11250m, "Gas", "L" },
                    { 149, "Quia dolores fuga dolore.", 161, 16070m, "Gas", "Kg" },
                    { 37, "Vel quia quae est voluptatem accusantium aliquid minima totam.", 77, 9148m, "Liquid", "L" },
                    { 171, "Cumque qui illum sit maiores libero sequi.", 77, 8096m, "Gas", "L" },
                    { 234, "Voluptatibus illo ea expedita reiciendis ut cum reprehenderit.", 77, 11631m, "Solid", "Kg" },
                    { 480, "Nulla quaerat ea non officia et eligendi odit non ad.", 124, 4893m, "Solid", "L" },
                    { 320, "Dolorem ut eveniet quo vel cumque consequuntur voluptatibus blanditiis.", 124, 19168m, "Liquid", "L" },
                    { 189, "Et pariatur voluptate suscipit corporis ipsa molestiae optio nulla.", 124, 6879m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 66, "Nisi ut est necessitatibus minima aut dolor recusandae.", 124, 4245m, "Gas", "Kg" },
                    { 20, "Nihil voluptatibus est dignissimos atque quidem.", 124, 5247m, "Gas", "L" },
                    { 282, "Eum deleniti rerum eius nam.", 77, 2822m, "Liquid", "Kg" },
                    { 294, "Commodi accusantium aut incidunt est ab atque.", 77, 18800m, "Liquid", "Kg" },
                    { 301, "Molestiae nihil veniam distinctio.", 77, 8147m, "Gas", "L" },
                    { 160, "Omnis repudiandae et facere quia neque natus.", 109, 12338m, "Gas", "Kg" },
                    { 209, "Itaque officia facere.", 78, 17864m, "Liquid", "Kg" },
                    { 374, "Omnis hic voluptatibus in praesentium accusantium hic.", 101, 2028m, "Liquid", "L" },
                    { 268, "Eos iure voluptates cupiditate ducimus iste.", 127, 2782m, "Liquid", "Kg" },
                    { 154, "Eius odio magnam aut modi molestiae voluptas assumenda assumenda eaque.", 82, 11450m, "Liquid", "Kg" },
                    { 274, "Recusandae ratione hic.", 100, 3463m, "Liquid", "L" },
                    { 181, "Animi debitis omnis.", 100, 16193m, "Liquid", "L" },
                    { 283, "Hic hic qui nisi iure aut.", 86, 7695m, "Gas", "Kg" },
                    { 479, "Debitis veniam dignissimos modi aut aut quam accusamus.", 86, 4747m, "Gas", "L" },
                    { 463, "Alias eveniet eligendi dolores nihil repellendus quod.", 99, 15590m, "Solid", "Kg" },
                    { 206, "Ratione quaerat qui iste dolorem non laboriosam omnis sequi doloribus.", 89, 6087m, "Solid", "Kg" },
                    { 319, "Et est quae est necessitatibus culpa aperiam sit.", 89, 5307m, "Liquid", "L" },
                    { 412, "Velit neque eius veniam sequi dolores facere eligendi et quae.", 89, 8840m, "Gas", "Kg" },
                    { 353, "Adipisci veniam nisi aut voluptatem.", 95, 8510m, "Solid", "L" },
                    { 158, "Veniam laboriosam quas cum vitae.", 95, 10738m, "Solid", "Kg" },
                    { 106, "Sed similique officiis ut nihil officia quo veritatis molestias ea.", 95, 16622m, "Gas", "Kg" },
                    { 60, "In fugit ducimus soluta.", 95, 11350m, "Liquid", "L" },
                    { 267, "Aut explicabo labore libero praesentium odio nisi.", 90, 8808m, "Liquid", "L" },
                    { 272, "Pariatur voluptatem necessitatibus voluptatem rerum ea est quae culpa magnam.", 90, 16156m, "Solid", "L" },
                    { 306, "Rerum laudantium eius saepe numquam repellat.", 82, 11487m, "Gas", "L" },
                    { 193, "Dolore reiciendis odit explicabo ipsam debitis ut nihil aut molestiae.", 197, 8902m, "Liquid", "L" },
                    { 289, "Exercitationem et laudantium ducimus eos.", 127, 12249m, "Gas", "Kg" },
                    { 39, "Occaecati enim omnis autem aut enim sed ad quos dolorem.", 66, 3892m, "Gas", "L" },
                    { 70, "Eum aperiam consequuntur ducimus saepe sit sint laborum voluptatem.", 45, 10421m, "Solid", "Kg" },
                    { 127, "Mollitia incidunt rerum ipsam dolorem est sint laboriosam dolorem non.", 45, 9891m, "Solid", "Kg" },
                    { 269, "Quo voluptatibus velit eos.", 45, 1804m, "Solid", "L" },
                    { 81, "Aut dolorum a temporibus repellendus quasi.", 158, 16525m, "Gas", "Kg" },
                    { 276, "Sed consequatur et ut voluptatum harum aut eaque optio.", 45, 18902m, "Solid", "L" },
                    { 291, "Quam rerum eum.", 45, 11650m, "Gas", "L" },
                    { 79, "Quae qui laudantium occaecati ut.", 54, 17226m, "Liquid", "Kg" },
                    { 180, "Ab sint dignissimos repudiandae quia quos.", 54, 4947m, "Solid", "L" },
                    { 259, "Quae magnam est vel quo harum magni deleniti.", 54, 12067m, "Liquid", "L" },
                    { 111, "Ex commodi ad id at.", 150, 1786m, "Liquid", "L" },
                    { 346, "Facilis ut doloribus quod necessitatibus ipsum qui expedita.", 54, 817m, "Solid", "Kg" },
                    { 396, "Placeat sit ea unde repellendus animi perspiciatis.", 54, 7105m, "Liquid", "L" },
                    { 340, "Ut accusantium est error.", 142, 1567m, "Gas", "L" },
                    { 300, "Non iure a.", 142, 59m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 313, "Beatae aspernatur ea ut quaerat.", 66, 16987m, "Liquid", "Kg" },
                    { 186, "Sunt molestiae et excepturi excepturi vitae illo sequi et.", 142, 16926m, "Solid", "Kg" },
                    { 159, "Hic ullam commodi ipsam quis quo commodi dolores natus.", 61, 10401m, "Solid", "L" },
                    { 443, "Repellendus veniam est ut repudiandae impedit accusantium.", 138, 6782m, "Gas", "L" },
                    { 284, "Ut adipisci dolorem est velit voluptatem qui totam.", 138, 3399m, "Solid", "L" },
                    { 53, "Ipsa at debitis iste doloribus aut.", 138, 153m, "Liquid", "Kg" },
                    { 89, "Quis et ut autem labore distinctio eum architecto.", 63, 7594m, "Solid", "L" },
                    { 231, "Debitis atque beatae aperiam quidem.", 63, 12669m, "Gas", "L" },
                    { 451, "Vel rem inventore et aut sed libero.", 63, 14332m, "Solid", "Kg" },
                    { 124, "Expedita quod itaque expedita eius voluptatibus quo harum nostrum.", 132, 19639m, "Liquid", "L" },
                    { 121, "Alias autem aut sapiente consequatur.", 132, 12398m, "Gas", "Kg" },
                    { 444, "Id iste ut.", 64, 9032m, "Gas", "L" },
                    { 484, "Nam laboriosam et ut quis.", 64, 17860m, "Gas", "Kg" },
                    { 163, "Dolorem aperiam optio aliquid distinctio numquam suscipit quaerat qui atque.", 128, 4805m, "Solid", "Kg" },
                    { 147, "Perferendis exercitationem veniam velit dolorum blanditiis beatae optio cumque.", 128, 1538m, "Solid", "Kg" },
                    { 117, "Sit sint enim ipsam iusto ratione asperiores.", 128, 4800m, "Liquid", "Kg" },
                    { 30, "Incidunt consequatur minima sequi quam.", 61, 13037m, "Gas", "Kg" },
                    { 7, "Incidunt aut voluptates et non laborum consequuntur.", 49, 11530m, "Solid", "Kg" },
                    { 431, "Dolorem et et omnis adipisci voluptatem qui exercitationem.", 49, 14863m, "Solid", "L" },
                    { 56, "Quis in et ex consequatur molestias culpa ipsam.", 197, 556m, "Solid", "L" },
                    { 432, "Qui id qui.", 149, 6977m, "Solid", "Kg" },
                    { 87, "Voluptatibus qui qui quis sequi.", 149, 4953m, "Solid", "Kg" },
                    { 153, "Ratione quisquam tenetur natus maxime.", 92, 5334m, "Gas", "Kg" },
                    { 365, "Dolor laboriosam dolore voluptas.", 92, 1883m, "Gas", "Kg" },
                    { 376, "Consequatur et itaque error id labore.", 92, 591m, "Liquid", "Kg" },
                    { 456, "Et molestiae reprehenderit adipisci quasi alias earum.", 92, 14920m, "Liquid", "Kg" },
                    { 394, "Doloribus optio ut dolorem dolores amet corrupti possimus.", 143, 16338m, "Solid", "L" },
                    { 94, "Maiores quis voluptatem atque autem autem qui ad voluptate.", 143, 7299m, "Solid", "L" },
                    { 16, "Eius qui aut enim alias quo enim modi.", 143, 881m, "Gas", "L" },
                    { 131, "Veritatis omnis saepe quasi deserunt perspiciatis sunt distinctio.", 97, 6108m, "Solid", "L" },
                    { 286, "Voluptas praesentium dolores nam.", 97, 10047m, "Liquid", "L" },
                    { 496, "Perspiciatis est quia voluptatem.", 97, 8379m, "Gas", "L" },
                    { 332, "Architecto et eos culpa mollitia hic maxime consequatur doloribus.", 140, 15477m, "Liquid", "Kg" },
                    { 311, "Eius accusamus quibusdam aspernatur unde non.", 140, 5137m, "Gas", "L" },
                    { 426, "Sunt fugiat aliquid vitae et molestias corporis maiores.", 91, 8484m, "Liquid", "L" },
                    { 52, "Consequatur quam in praesentium reprehenderit commodi iusto in.", 140, 19508m, "Liquid", "L" },
                    { 157, "Consequatur tenetur impedit eum aliquid quam praesentium suscipit.", 137, 4762m, "Solid", "Kg" },
                    { 10, "Quam dolorem in ab ipsum maiores sint impedit ipsum consequatur.", 137, 4171m, "Gas", "Kg" },
                    { 9, "Debitis aut blanditiis non minima sit tempore occaecati.", 137, 4869m, "Liquid", "L" },
                    { 174, "Soluta nam commodi nihil est ratione molestiae repellendus ratione.", 106, 7388m, "Solid", "L" },
                    { 418, "Odit quo et rem dolorem illum aut.", 129, 5174m, "Solid", "L" },
                    { 237, "Qui rerum optio sed doloribus ut accusantium molestiae iusto.", 129, 4090m, "Solid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 220, "Voluptatum aut assumenda totam aperiam quisquam dolor dicta nulla facilis.", 129, 10385m, "Solid", "Kg" },
                    { 179, "Unde vel et exercitationem dolor.", 108, 7676m, "Solid", "L" },
                    { 212, "Fugiat velit enim.", 108, 16449m, "Liquid", "Kg" },
                    { 477, "Voluptate nemo vero.", 108, 6212m, "Liquid", "L" },
                    { 101, "Sequi asperiores quae sint et vitae facilis quae consequuntur.", 110, 2311m, "Solid", "L" },
                    { 135, "Rerum est minima consequatur animi tempora.", 110, 6578m, "Gas", "L" },
                    { 161, "Et est laudantium voluptatum.", 110, 8412m, "Solid", "Kg" },
                    { 344, "Dolores totam deleniti repellendus.", 110, 802m, "Liquid", "Kg" },
                    { 356, "Dolor cum qui reiciendis voluptatem ut eos sed et illo.", 105, 9739m, "Gas", "L" },
                    { 377, "Ipsam officiis fuga dolor perspiciatis totam.", 112, 8745m, "Liquid", "Kg" },
                    { 142, "Rerum optio beatae delectus et occaecati minus deleniti doloremque error.", 153, 13726m, "Gas", "L" },
                    { 44, "Autem suscipit eum nisi qui alias.", 154, 7595m, "Liquid", "Kg" },
                    { 492, "Non sunt explicabo qui est pariatur et nulla cupiditate soluta.", 189, 280m, "Solid", "Kg" },
                    { 122, "Asperiores similique tempora eligendi in.", 189, 3027m, "Gas", "L" },
                    { 114, "Pariatur ea aliquam iste qui corporis reiciendis.", 67, 1583m, "Solid", "Kg" },
                    { 233, "Debitis vel quia voluptatem nemo quas autem ipsa qui aperiam.", 67, 18286m, "Liquid", "Kg" },
                    { 265, "Nesciunt sint voluptatem in quas ipsa ea accusantium aliquam.", 67, 2519m, "Liquid", "Kg" },
                    { 429, "Qui et consequuntur omnis totam quod ab necessitatibus dolorem doloribus.", 188, 5300m, "Liquid", "Kg" },
                    { 132, "Excepturi cupiditate veniam eos at ut.", 68, 18655m, "Solid", "Kg" },
                    { 199, "Voluptatem repellendus placeat.", 68, 2502m, "Liquid", "Kg" },
                    { 211, "Impedit at error iusto eos reprehenderit omnis.", 68, 13760m, "Solid", "Kg" },
                    { 428, "Dolor eum accusamus officia veniam vel qui possimus.", 68, 3912m, "Gas", "L" },
                    { 470, "Incidunt quos exercitationem ratione voluptatem animi corrupti id ullam.", 68, 9956m, "Liquid", "L" },
                    { 298, "Iure ad eos distinctio reiciendis ut laboriosam corporis fuga rerum.", 174, 4316m, "Gas", "L" },
                    { 200, "Error eligendi fugit laboriosam repudiandae dolores molestias dolore magnam vero.", 174, 16122m, "Gas", "Kg" },
                    { 136, "Quia inventore ea ut dolor molestias.", 70, 17199m, "Solid", "Kg" },
                    { 373, "Esse beatae dolore.", 83, 8769m, "Liquid", "L" },
                    { 351, "Sit et illo et a.", 159, 19279m, "Liquid", "L" },
                    { 297, "Expedita aspernatur exercitationem voluptatem quam aperiam eum.", 159, 4678m, "Solid", "L" },
                    { 243, "Blanditiis deleniti architecto inventore.", 159, 8503m, "Liquid", "Kg" },
                    { 139, "Sed sapiente natus aut et sed voluptas et ad illum.", 159, 1902m, "Solid", "L" },
                    { 360, "Ut velit qui a minus quo laboriosam dolor adipisci.", 70, 3745m, "Liquid", "Kg" },
                    { 488, "Consequatur reiciendis officia sed molestiae.", 70, 15966m, "Solid", "Kg" },
                    { 326, "Optio qui repellat iste quia sapiente quidem fugit.", 90, 7459m, "Gas", "Kg" },
                    { 387, "Sunt ipsa ipsam ipsam sit voluptas.", 155, 7758m, "Solid", "L" },
                    { 213, "Architecto aut placeat animi natus dolor nihil sunt excepturi voluptatem.", 73, 4586m, "Solid", "Kg" },
                    { 38, "Distinctio quis laborum modi.", 83, 18035m, "Liquid", "L" },
                    { 437, "Incidunt sed odit quia non assumenda facilis.", 154, 4094m, "Liquid", "Kg" },
                    { 318, "Dolor quaerat illum consequatur voluptate aut sed.", 154, 7129m, "Solid", "Kg" },
                    { 290, "Voluptatem deserunt corporis officia ut et et accusamus dolorem.", 154, 15450m, "Solid", "Kg" },
                    { 230, "Ut totam est voluptate ipsum repudiandae ut maiores.", 154, 16168m, "Liquid", "L" },
                    { 150, "Ducimus odio non ipsa sint doloribus quaerat laborum velit.", 154, 10341m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 309, "Pariatur ex vitae nobis rerum at.", 159, 8453m, "Liquid", "L" },
                    { 304, "Ipsam aspernatur quod illum sit sequi ut.", 195, 6299m, "Solid", "L" },
                    { 408, "Repudiandae aliquam quae hic dolor explicabo est culpa nisi est.", 112, 8669m, "Gas", "Kg" },
                    { 226, "Quod aut eius harum natus iusto nisi ut aperiam.", 118, 18917m, "Liquid", "L" },
                    { 375, "Aut eos voluptatem.", 76, 12647m, "Gas", "Kg" },
                    { 413, "Veniam delectus voluptas distinctio sit explicabo.", 176, 7956m, "Solid", "L" },
                    { 229, "Inventore sit quisquam qui aut sequi aut vero ut atque.", 181, 13760m, "Solid", "L" },
                    { 478, "Et quis sit illo est voluptatem reprehenderit temporibus sit et.", 181, 18353m, "Liquid", "L" },
                    { 468, "Quae et ea voluptas dolorem.", 74, 13645m, "Solid", "L" },
                    { 405, "Exercitationem autem eos rerum delectus adipisci quaerat delectus sint dolor.", 74, 8000m, "Gas", "Kg" },
                    { 498, "Veniam sit similique rerum quia optio voluptas sint saepe corporis.", 181, 6928m, "Gas", "Kg" },
                    { 228, "Et exercitationem vitae totam.", 183, 15723m, "Gas", "L" },
                    { 457, "Quia et natus molestiae omnis.", 72, 2364m, "Solid", "Kg" },
                    { 393, "Dolor ipsa aut est est vel.", 72, 6782m, "Gas", "Kg" },
                    { 275, "Et laborum aliquam voluptatem.", 72, 16483m, "Gas", "L" },
                    { 92, "Ipsam ullam sit aut ea.", 72, 201m, "Liquid", "L" },
                    { 33, "Ea molestiae fugit.", 184, 4118m, "Gas", "L" },
                    { 196, "Eum cum explicabo ut praesentium.", 184, 14955m, "Solid", "Kg" },
                    { 427, "Eligendi molestiae est enim.", 76, 16884m, "Gas", "Kg" },
                    { 493, "Sapiente et nostrum voluptas quia voluptatum at possimus.", 71, 12998m, "Liquid", "Kg" },
                    { 440, "Maxime qui rem.", 71, 13867m, "Solid", "L" },
                    { 260, "Atque autem animi odio voluptatibus nulla vel explicabo.", 71, 15681m, "Liquid", "L" },
                    { 104, "Molestiae in vel dolor voluptate non occaecati rerum dolor explicabo.", 71, 8647m, "Solid", "L" },
                    { 308, "Autem velit voluptas tempore ut velit voluptatum aut velit.", 184, 13424m, "Solid", "L" },
                    { 29, "Dicta et autem sit quis at.", 187, 11839m, "Solid", "L" },
                    { 410, "Sit earum qui natus in.", 59, 14323m, "Solid", "Kg" },
                    { 395, "Culpa odio molestias maxime aliquid alias voluptas perferendis et deleniti.", 59, 2776m, "Gas", "Kg" },
                    { 384, "Sit odit incidunt suscipit ad occaecati magni et.", 59, 16318m, "Solid", "Kg" },
                    { 184, "Nihil natus et.", 59, 12224m, "Liquid", "L" },
                    { 95, "Rerum doloribus consequuntur ratione necessitatibus est facilis id nemo facilis.", 59, 11565m, "Solid", "Kg" },
                    { 385, "Facilis amet aut amet praesentium.", 187, 7631m, "Liquid", "L" },
                    { 370, "Et sunt velit cum.", 193, 9646m, "Gas", "Kg" },
                    { 445, "Qui quas quisquam earum.", 50, 14958m, "Liquid", "Kg" },
                    { 383, "Aut rem explicabo ducimus.", 193, 1644m, "Solid", "Kg" },
                    { 450, "Ut veritatis quia voluptatem.", 71, 8040m, "Solid", "L" },
                    { 337, "Ducimus quisquam dolores sint voluptatibus quod.", 118, 12151m, "Gas", "Kg" },
                    { 400, "Tempore vel ut.", 176, 9197m, "Gas", "Kg" },
                    { 26, "Sint et iste vitae.", 176, 19266m, "Gas", "Kg" },
                    { 73, "Molestiae ratione consequatur.", 118, 515m, "Liquid", "L" },
                    { 83, "Praesentium illo molestiae vel ut quam.", 115, 4741m, "Liquid", "L" },
                    { 118, "Cupiditate nam est sunt ducimus quasi.", 115, 9853m, "Gas", "L" },
                    { 359, "Aspernatur voluptas distinctio ut nesciunt.", 115, 16913m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 58, "Velit quam ea ducimus libero expedita repellat labore.", 113, 10183m, "Liquid", "Kg" },
                    { 80, "Iste amet velit.", 134, 1604m, "Solid", "Kg" },
                    { 285, "Architecto dolorem placeat voluptatem quia nihil harum reprehenderit id error.", 111, 7235m, "Gas", "Kg" },
                    { 191, "Nostrum recusandae consequatur deleniti asperiores ut.", 111, 5003m, "Gas", "Kg" },
                    { 303, "Maiores qui sint vel sint.", 134, 13363m, "Liquid", "L" },
                    { 473, "Molestias harum quos.", 134, 18001m, "Solid", "L" },
                    { 485, "Et sit et ut neque consequuntur est.", 134, 7395m, "Gas", "Kg" },
                    { 362, "Laboriosam aut rerum.", 104, 12287m, "Liquid", "Kg" },
                    { 11, "Illo magni qui magni autem ut.", 104, 14219m, "Liquid", "Kg" },
                    { 96, "Magni quaerat quod voluptates minima vel accusantium exercitationem.", 146, 16255m, "Liquid", "L" },
                    { 178, "Et error consequuntur repudiandae.", 176, 16174m, "Solid", "L" },
                    { 288, "At nam enim natus quaerat.", 146, 4711m, "Liquid", "Kg" },
                    { 341, "Quia vero eaque neque assumenda non harum ut possimus autem.", 148, 4917m, "Gas", "Kg" },
                    { 261, "Est ut quo.", 98, 11322m, "Liquid", "L" },
                    { 364, "Eum voluptas aut delectus pariatur dolores ut.", 148, 13615m, "Solid", "Kg" },
                    { 227, "Corrupti ipsam consequatur dolores nobis.", 152, 9954m, "Solid", "L" },
                    { 390, "Et reiciendis sit fugit quos veritatis dolor.", 96, 9966m, "Liquid", "Kg" },
                    { 232, "Voluptatem laboriosam culpa rerum.", 96, 1070m, "Solid", "Kg" },
                    { 86, "Ea est voluptate sed aut excepturi similique aut quaerat.", 96, 3958m, "Solid", "Kg" },
                    { 369, "Et porro eum quod excepturi.", 152, 386m, "Liquid", "Kg" },
                    { 103, "Voluptas consectetur dignissimos voluptatum.", 93, 5070m, "Liquid", "Kg" },
                    { 68, "Dolor eligendi voluptatibus qui vero facere sit.", 93, 2655m, "Liquid", "Kg" },
                    { 225, "Harum eius corrupti non doloremque fugiat repellendus.", 171, 280m, "Solid", "L" },
                    { 2, "Ea quisquam eveniet doloremque blanditiis porro cupiditate occaecati.", 176, 4190m, "Solid", "L" },
                    { 277, "Autem consequatur ullam possimus eveniet et beatae.", 80, 3331m, "Liquid", "Kg" },
                    { 155, "Et officia ut et.", 80, 4239m, "Solid", "Kg" },
                    { 388, "Laboriosam eveniet assumenda qui reiciendis quibusdam voluptatem nesciunt est dolor.", 146, 8832m, "Solid", "L" },
                    { 322, "Sit aliquid illum velit non culpa nihil.", 127, 6097m, "Solid", "L" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsignorManifest_ConsignorId",
                table: "ConsignorManifest",
                column: "ConsignorId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ManifestId",
                table: "Items",
                column: "ManifestId");

            migrationBuilder.CreateIndex(
                name: "IX_Manifests_CarrierId",
                table: "Manifests",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_Manifests_ConsigneeId",
                table: "Manifests",
                column: "ConsigneeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsigneeAddresses");

            migrationBuilder.DropTable(
                name: "ConsignorAddresses");

            migrationBuilder.DropTable(
                name: "ConsignorManifest");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Consignors");

            migrationBuilder.DropTable(
                name: "Manifests");

            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropTable(
                name: "Consignees");
        }
    }
}
