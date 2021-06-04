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
                    ConsignorsId = table.Column<int>(type: "int", nullable: false),
                    ManifestsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsignorManifest", x => new { x.ConsignorsId, x.ManifestsId });
                    table.ForeignKey(
                        name: "FK_ConsignorManifest_Consignors_ConsignorsId",
                        column: x => x.ConsignorsId,
                        principalTable: "Consignors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsignorManifest_Manifests_ManifestsId",
                        column: x => x.ManifestsId,
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
                    { 13, "XL-C6W", "Mertz Group" },
                    { 12, "VQ-8PL", "Ullrich - Harris" },
                    { 11, "GP-2FQ", "Bayer Group" },
                    { 10, "TH-3JQ", "Windler, Osinski and Prohaska" },
                    { 9, "DO-KKY", "McLaughlin, Boyle and Lehner" },
                    { 8, "YY-JCN", "Balistreri, Barton and Cole" },
                    { 3, "B-5010", "Whitehorse General Hospital" },
                    { 6, "CA-KXG", "Gleason Group" },
                    { 5, "A840", "Whistle Bend Place" },
                    { 4, "A1-102", "Teslin Health Centre" },
                    { 14, "FT-UIE", "Runte and Sons" },
                    { 2, "A-000", "Mayo Health Centre" },
                    { 1, "OXP-4", "Carmacks Health Clinic" },
                    { 7, "RV-U6V", "Murray, Hegmann and Morar" },
                    { 15, "ZZ-KB2", "Weber, Lesch and Leffler" }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 10, 5, "YT99546-0", 1, new DateTime(2021, 9, 14, 20, 45, 51, 420, DateTimeKind.Unspecified).AddTicks(2079), new DateTime(2021, 5, 8, 19, 12, 8, 302, DateTimeKind.Unspecified).AddTicks(29) },
                    { 7, 3, "YT77243-1", 4, new DateTime(2021, 10, 9, 22, 43, 4, 418, DateTimeKind.Unspecified).AddTicks(1531), new DateTime(2021, 8, 18, 6, 5, 19, 348, DateTimeKind.Unspecified).AddTicks(2680) },
                    { 9, 5, "YT32514-0", 4, new DateTime(2021, 10, 12, 2, 43, 18, 122, DateTimeKind.Unspecified).AddTicks(5179), new DateTime(2021, 5, 8, 8, 27, 20, 961, DateTimeKind.Unspecified).AddTicks(8370) },
                    { 11, 5, "YT63339-1", 4, new DateTime(2021, 11, 6, 4, 4, 52, 233, DateTimeKind.Unspecified).AddTicks(7332), new DateTime(2021, 8, 8, 16, 13, 37, 686, DateTimeKind.Unspecified).AddTicks(2244) },
                    { 15, 3, "YT55056-0", 4, new DateTime(2021, 10, 27, 16, 42, 18, 245, DateTimeKind.Unspecified).AddTicks(3498), new DateTime(2021, 7, 22, 15, 26, 48, 103, DateTimeKind.Unspecified).AddTicks(3533) },
                    { 17, 1, "YT74738-0", 4, new DateTime(2021, 11, 19, 8, 30, 19, 181, DateTimeKind.Unspecified).AddTicks(5906), new DateTime(2021, 8, 30, 17, 30, 32, 43, DateTimeKind.Unspecified).AddTicks(4551) },
                    { 26, 5, "YT65172-1", 4, new DateTime(2021, 11, 24, 23, 24, 9, 694, DateTimeKind.Unspecified).AddTicks(7845), new DateTime(2021, 5, 22, 9, 48, 21, 214, DateTimeKind.Unspecified).AddTicks(3746) },
                    { 56, 2, "YT25401-0", 4, new DateTime(2021, 12, 23, 12, 26, 12, 492, DateTimeKind.Unspecified).AddTicks(5578), new DateTime(2021, 8, 11, 5, 5, 23, 857, DateTimeKind.Unspecified).AddTicks(9716) },
                    { 75, 1, "YT27332-0", 4, new DateTime(2021, 10, 21, 15, 16, 50, 95, DateTimeKind.Unspecified).AddTicks(900), new DateTime(2021, 5, 15, 18, 43, 2, 93, DateTimeKind.Unspecified).AddTicks(2479) },
                    { 76, 1, "YT74056-0", 4, new DateTime(2021, 11, 18, 0, 44, 53, 286, DateTimeKind.Unspecified).AddTicks(3382), new DateTime(2021, 5, 22, 4, 30, 0, 657, DateTimeKind.Unspecified).AddTicks(7388) },
                    { 77, 4, "YT70912-1", 4, new DateTime(2021, 11, 1, 16, 20, 22, 793, DateTimeKind.Unspecified).AddTicks(4620), new DateTime(2021, 8, 20, 3, 33, 15, 885, DateTimeKind.Unspecified).AddTicks(4184) },
                    { 78, 5, "YT48854-1", 4, new DateTime(2021, 12, 6, 4, 30, 8, 18, DateTimeKind.Unspecified).AddTicks(5519), new DateTime(2021, 8, 3, 18, 29, 46, 224, DateTimeKind.Unspecified).AddTicks(982) },
                    { 79, 2, "YT28507-1", 4, new DateTime(2021, 11, 9, 7, 5, 14, 563, DateTimeKind.Unspecified).AddTicks(9732), new DateTime(2021, 7, 9, 13, 7, 8, 125, DateTimeKind.Unspecified).AddTicks(7089) },
                    { 84, 5, "YT86404-0", 4, new DateTime(2021, 10, 17, 21, 46, 22, 966, DateTimeKind.Unspecified).AddTicks(7561), new DateTime(2021, 8, 12, 22, 50, 23, 938, DateTimeKind.Unspecified).AddTicks(8029) },
                    { 85, 1, "YT75372-0", 4, new DateTime(2021, 11, 7, 10, 0, 56, 254, DateTimeKind.Unspecified).AddTicks(9789), new DateTime(2021, 5, 30, 11, 18, 58, 930, DateTimeKind.Unspecified).AddTicks(1654) },
                    { 90, 5, "YT71095-1", 4, new DateTime(2021, 10, 13, 0, 43, 24, 614, DateTimeKind.Unspecified).AddTicks(2382), new DateTime(2021, 5, 24, 10, 32, 33, 76, DateTimeKind.Unspecified).AddTicks(9182) },
                    { 98, 4, "YT58083-1", 4, new DateTime(2021, 10, 24, 6, 53, 54, 405, DateTimeKind.Unspecified).AddTicks(8436), new DateTime(2021, 8, 4, 6, 12, 24, 898, DateTimeKind.Unspecified).AddTicks(2835) },
                    { 116, 1, "YT25878-0", 4, new DateTime(2021, 9, 9, 15, 4, 26, 183, DateTimeKind.Unspecified).AddTicks(4940), new DateTime(2021, 7, 22, 3, 53, 6, 0, DateTimeKind.Unspecified).AddTicks(3879) },
                    { 124, 5, "YT71795-0", 4, new DateTime(2021, 10, 15, 0, 10, 8, 188, DateTimeKind.Unspecified).AddTicks(4938), new DateTime(2021, 8, 12, 3, 8, 50, 193, DateTimeKind.Unspecified).AddTicks(9510) },
                    { 137, 2, "YT43661-1", 4, new DateTime(2021, 11, 26, 13, 27, 51, 576, DateTimeKind.Unspecified).AddTicks(4182), new DateTime(2021, 5, 11, 4, 53, 34, 269, DateTimeKind.Unspecified).AddTicks(9473) },
                    { 142, 3, "YT68142-0", 4, new DateTime(2021, 10, 15, 4, 1, 5, 49, DateTimeKind.Unspecified).AddTicks(8919), new DateTime(2021, 7, 4, 12, 48, 31, 640, DateTimeKind.Unspecified).AddTicks(3139) },
                    { 148, 5, "YT49347-0", 4, new DateTime(2021, 10, 24, 9, 23, 18, 814, DateTimeKind.Unspecified).AddTicks(1947), new DateTime(2021, 8, 4, 18, 38, 17, 246, DateTimeKind.Unspecified).AddTicks(7944) },
                    { 5, 5, "YT86876-1", 4, new DateTime(2021, 10, 2, 22, 47, 43, 673, DateTimeKind.Unspecified).AddTicks(9711), new DateTime(2021, 7, 14, 21, 59, 8, 680, DateTimeKind.Unspecified).AddTicks(4064) },
                    { 150, 3, "YT28515-0", 4, new DateTime(2021, 11, 20, 10, 45, 39, 847, DateTimeKind.Unspecified).AddTicks(7869), new DateTime(2021, 8, 4, 19, 55, 40, 352, DateTimeKind.Unspecified).AddTicks(9740) },
                    { 195, 4, "YT42732-1", 3, new DateTime(2021, 12, 29, 11, 34, 32, 526, DateTimeKind.Unspecified).AddTicks(7917), new DateTime(2021, 6, 6, 13, 25, 16, 258, DateTimeKind.Unspecified).AddTicks(2503) },
                    { 191, 2, "YT29530-1", 3, new DateTime(2021, 10, 9, 17, 5, 3, 341, DateTimeKind.Unspecified).AddTicks(1044), new DateTime(2021, 6, 11, 15, 17, 41, 267, DateTimeKind.Unspecified).AddTicks(9365) },
                    { 103, 3, "YT54047-1", 3, new DateTime(2021, 9, 6, 19, 52, 55, 925, DateTimeKind.Unspecified).AddTicks(6219), new DateTime(2021, 7, 31, 20, 8, 30, 922, DateTimeKind.Unspecified).AddTicks(2407) },
                    { 107, 4, "YT63533-0", 3, new DateTime(2021, 9, 30, 23, 56, 41, 328, DateTimeKind.Unspecified).AddTicks(540), new DateTime(2021, 8, 25, 21, 41, 30, 934, DateTimeKind.Unspecified).AddTicks(209) },
                    { 114, 1, "YT23730-1", 3, new DateTime(2021, 10, 2, 1, 2, 32, 134, DateTimeKind.Unspecified).AddTicks(3875), new DateTime(2021, 8, 2, 18, 8, 33, 508, DateTimeKind.Unspecified).AddTicks(880) },
                    { 118, 4, "YT52595-0", 3, new DateTime(2021, 12, 22, 3, 42, 36, 982, DateTimeKind.Unspecified).AddTicks(734), new DateTime(2021, 6, 8, 14, 46, 3, 611, DateTimeKind.Unspecified).AddTicks(8034) },
                    { 119, 4, "YT76350-1", 3, new DateTime(2021, 11, 20, 11, 39, 51, 884, DateTimeKind.Unspecified).AddTicks(6654), new DateTime(2021, 5, 16, 3, 29, 9, 345, DateTimeKind.Unspecified).AddTicks(6973) },
                    { 128, 5, "YT91072-1", 3, new DateTime(2021, 11, 27, 3, 43, 30, 899, DateTimeKind.Unspecified).AddTicks(3831), new DateTime(2021, 6, 23, 4, 10, 39, 920, DateTimeKind.Unspecified).AddTicks(5621) },
                    { 133, 5, "YT44324-1", 3, new DateTime(2021, 9, 11, 18, 0, 35, 316, DateTimeKind.Unspecified).AddTicks(8775), new DateTime(2021, 5, 12, 21, 18, 44, 542, DateTimeKind.Unspecified).AddTicks(3168) },
                    { 136, 5, "YT45732-0", 3, new DateTime(2021, 9, 6, 6, 54, 43, 264, DateTimeKind.Unspecified).AddTicks(6814), new DateTime(2021, 8, 12, 12, 4, 4, 340, DateTimeKind.Unspecified).AddTicks(347) },
                    { 147, 2, "YT69771-0", 3, new DateTime(2021, 11, 14, 18, 46, 59, 440, DateTimeKind.Unspecified).AddTicks(5826), new DateTime(2021, 6, 16, 15, 41, 13, 128, DateTimeKind.Unspecified).AddTicks(9173) },
                    { 152, 1, "YT31348-0", 3, new DateTime(2021, 10, 26, 6, 57, 2, 126, DateTimeKind.Unspecified).AddTicks(5716), new DateTime(2021, 7, 24, 13, 7, 3, 195, DateTimeKind.Unspecified).AddTicks(1382) },
                    { 154, 4, "YT89796-1", 3, new DateTime(2021, 11, 14, 17, 43, 51, 657, DateTimeKind.Unspecified).AddTicks(2636), new DateTime(2021, 6, 5, 1, 53, 22, 135, DateTimeKind.Unspecified).AddTicks(654) },
                    { 156, 5, "YT25514-0", 3, new DateTime(2021, 9, 11, 13, 17, 55, 49, DateTimeKind.Unspecified).AddTicks(9010), new DateTime(2021, 6, 10, 9, 33, 42, 939, DateTimeKind.Unspecified).AddTicks(1944) },
                    { 162, 2, "YT99494-1", 3, new DateTime(2021, 11, 2, 4, 25, 34, 113, DateTimeKind.Unspecified).AddTicks(6604), new DateTime(2021, 5, 10, 8, 12, 42, 873, DateTimeKind.Unspecified).AddTicks(2983) },
                    { 165, 4, "YT64654-1", 3, new DateTime(2021, 9, 7, 11, 51, 22, 203, DateTimeKind.Unspecified).AddTicks(7136), new DateTime(2021, 7, 22, 14, 41, 26, 354, DateTimeKind.Unspecified).AddTicks(2848) },
                    { 166, 1, "YT16641-0", 3, new DateTime(2021, 11, 27, 0, 17, 50, 202, DateTimeKind.Unspecified).AddTicks(8458), new DateTime(2021, 6, 12, 8, 9, 35, 807, DateTimeKind.Unspecified).AddTicks(4853) },
                    { 168, 3, "YT43288-0", 3, new DateTime(2021, 10, 16, 22, 6, 57, 299, DateTimeKind.Unspecified).AddTicks(9529), new DateTime(2021, 5, 11, 4, 43, 47, 363, DateTimeKind.Unspecified).AddTicks(6554) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 169, 4, "YT61393-0", 3, new DateTime(2021, 11, 6, 18, 14, 29, 985, DateTimeKind.Unspecified).AddTicks(522), new DateTime(2021, 8, 24, 21, 22, 59, 156, DateTimeKind.Unspecified).AddTicks(9889) },
                    { 175, 5, "YT61740-0", 3, new DateTime(2021, 12, 4, 6, 23, 37, 151, DateTimeKind.Unspecified).AddTicks(2055), new DateTime(2021, 8, 10, 22, 6, 48, 896, DateTimeKind.Unspecified).AddTicks(4177) },
                    { 178, 5, "YT47108-0", 3, new DateTime(2021, 10, 17, 1, 44, 44, 503, DateTimeKind.Unspecified).AddTicks(7147), new DateTime(2021, 6, 30, 19, 4, 43, 370, DateTimeKind.Unspecified).AddTicks(7608) },
                    { 181, 1, "YT11792-0", 3, new DateTime(2021, 11, 11, 10, 15, 9, 82, DateTimeKind.Unspecified).AddTicks(7816), new DateTime(2021, 5, 14, 18, 42, 10, 332, DateTimeKind.Unspecified).AddTicks(3940) },
                    { 183, 5, "YT41761-0", 3, new DateTime(2021, 9, 4, 16, 4, 42, 467, DateTimeKind.Unspecified).AddTicks(9644), new DateTime(2021, 7, 24, 22, 13, 56, 31, DateTimeKind.Unspecified).AddTicks(2566) },
                    { 193, 5, "YT14693-0", 3, new DateTime(2021, 11, 10, 11, 7, 35, 814, DateTimeKind.Unspecified).AddTicks(1358), new DateTime(2021, 7, 23, 4, 11, 52, 180, DateTimeKind.Unspecified).AddTicks(6811) },
                    { 99, 5, "YT16128-1", 3, new DateTime(2021, 11, 8, 15, 49, 56, 581, DateTimeKind.Unspecified).AddTicks(3589), new DateTime(2021, 7, 5, 12, 29, 53, 91, DateTimeKind.Unspecified).AddTicks(797) },
                    { 155, 2, "YT33535-0", 4, new DateTime(2021, 11, 19, 18, 7, 31, 19, DateTimeKind.Unspecified).AddTicks(3503), new DateTime(2021, 8, 20, 19, 24, 49, 284, DateTimeKind.Unspecified).AddTicks(756) },
                    { 174, 1, "YT13154-0", 4, new DateTime(2021, 10, 21, 17, 8, 16, 751, DateTimeKind.Unspecified).AddTicks(391), new DateTime(2021, 5, 15, 18, 11, 13, 52, DateTimeKind.Unspecified).AddTicks(7065) },
                    { 100, 5, "YT94510-0", 5, new DateTime(2021, 9, 9, 12, 26, 7, 382, DateTimeKind.Unspecified).AddTicks(644), new DateTime(2021, 8, 9, 19, 40, 57, 352, DateTimeKind.Unspecified).AddTicks(9350) },
                    { 102, 2, "YT76275-1", 5, new DateTime(2021, 9, 4, 21, 51, 4, 600, DateTimeKind.Unspecified).AddTicks(5937), new DateTime(2021, 7, 19, 11, 53, 4, 988, DateTimeKind.Unspecified).AddTicks(2698) },
                    { 104, 5, "YT44115-0", 5, new DateTime(2021, 9, 14, 2, 13, 22, 749, DateTimeKind.Unspecified).AddTicks(2739), new DateTime(2021, 6, 16, 6, 50, 51, 864, DateTimeKind.Unspecified).AddTicks(5684) },
                    { 105, 5, "YT16911-1", 5, new DateTime(2021, 10, 2, 8, 37, 20, 682, DateTimeKind.Unspecified).AddTicks(3824), new DateTime(2021, 7, 29, 1, 35, 55, 918, DateTimeKind.Unspecified).AddTicks(1285) },
                    { 108, 2, "YT51501-1", 5, new DateTime(2021, 11, 30, 11, 40, 19, 719, DateTimeKind.Unspecified).AddTicks(3565), new DateTime(2021, 6, 20, 5, 28, 50, 329, DateTimeKind.Unspecified).AddTicks(802) },
                    { 111, 4, "YT14122-1", 5, new DateTime(2021, 9, 19, 14, 5, 48, 253, DateTimeKind.Unspecified).AddTicks(264), new DateTime(2021, 7, 6, 7, 25, 37, 99, DateTimeKind.Unspecified).AddTicks(2860) },
                    { 115, 3, "YT97340-1", 5, new DateTime(2021, 10, 17, 13, 7, 57, 947, DateTimeKind.Unspecified).AddTicks(843), new DateTime(2021, 5, 11, 11, 0, 14, 666, DateTimeKind.Unspecified).AddTicks(2166) },
                    { 123, 2, "YT38762-0", 5, new DateTime(2021, 11, 19, 9, 59, 18, 336, DateTimeKind.Unspecified).AddTicks(6606), new DateTime(2021, 7, 29, 23, 54, 40, 555, DateTimeKind.Unspecified).AddTicks(7056) },
                    { 126, 4, "YT94719-1", 5, new DateTime(2021, 11, 18, 11, 2, 52, 217, DateTimeKind.Unspecified).AddTicks(1626), new DateTime(2021, 7, 6, 15, 23, 49, 316, DateTimeKind.Unspecified).AddTicks(4333) },
                    { 132, 2, "YT80506-1", 5, new DateTime(2021, 9, 17, 17, 32, 0, 614, DateTimeKind.Unspecified).AddTicks(6907), new DateTime(2021, 6, 9, 18, 27, 16, 442, DateTimeKind.Unspecified).AddTicks(1707) },
                    { 143, 2, "YT45153-1", 5, new DateTime(2021, 12, 25, 17, 24, 42, 311, DateTimeKind.Unspecified).AddTicks(2139), new DateTime(2021, 7, 26, 13, 43, 51, 786, DateTimeKind.Unspecified).AddTicks(968) },
                    { 149, 3, "YT22984-1", 5, new DateTime(2021, 12, 14, 21, 21, 16, 58, DateTimeKind.Unspecified).AddTicks(108), new DateTime(2021, 8, 5, 20, 44, 15, 272, DateTimeKind.Unspecified).AddTicks(1073) },
                    { 151, 3, "YT96645-0", 5, new DateTime(2021, 9, 2, 10, 24, 3, 293, DateTimeKind.Unspecified).AddTicks(2417), new DateTime(2021, 8, 7, 13, 21, 56, 332, DateTimeKind.Unspecified).AddTicks(3984) },
                    { 167, 4, "YT22274-0", 5, new DateTime(2021, 10, 21, 15, 59, 58, 921, DateTimeKind.Unspecified).AddTicks(2021), new DateTime(2021, 7, 3, 12, 37, 57, 544, DateTimeKind.Unspecified).AddTicks(4570) },
                    { 171, 3, "YT17324-0", 5, new DateTime(2021, 11, 6, 3, 37, 41, 422, DateTimeKind.Unspecified).AddTicks(5419), new DateTime(2021, 5, 28, 8, 27, 31, 520, DateTimeKind.Unspecified).AddTicks(8222) },
                    { 172, 3, "YT99361-0", 5, new DateTime(2021, 11, 13, 2, 16, 31, 289, DateTimeKind.Unspecified).AddTicks(5107), new DateTime(2021, 8, 11, 4, 13, 56, 868, DateTimeKind.Unspecified).AddTicks(4780) },
                    { 176, 4, "YT52746-0", 5, new DateTime(2021, 9, 17, 9, 55, 5, 945, DateTimeKind.Unspecified).AddTicks(9957), new DateTime(2021, 7, 23, 22, 21, 55, 11, DateTimeKind.Unspecified).AddTicks(8413) },
                    { 182, 1, "YT69134-1", 5, new DateTime(2021, 11, 5, 19, 1, 27, 771, DateTimeKind.Unspecified).AddTicks(4998), new DateTime(2021, 6, 14, 20, 31, 25, 596, DateTimeKind.Unspecified).AddTicks(9013) },
                    { 184, 1, "YT10753-1", 5, new DateTime(2021, 10, 14, 7, 48, 26, 496, DateTimeKind.Unspecified).AddTicks(6064), new DateTime(2021, 7, 27, 16, 26, 11, 967, DateTimeKind.Unspecified).AddTicks(9512) },
                    { 186, 2, "YT86249-0", 5, new DateTime(2021, 11, 3, 2, 13, 16, 470, DateTimeKind.Unspecified).AddTicks(3701), new DateTime(2021, 8, 15, 1, 20, 52, 809, DateTimeKind.Unspecified).AddTicks(4076) },
                    { 187, 5, "YT27262-0", 5, new DateTime(2021, 12, 14, 22, 44, 52, 246, DateTimeKind.Unspecified).AddTicks(3351), new DateTime(2021, 6, 2, 0, 40, 56, 646, DateTimeKind.Unspecified).AddTicks(3020) },
                    { 92, 5, "YT14063-0", 5, new DateTime(2021, 9, 19, 20, 36, 14, 159, DateTimeKind.Unspecified).AddTicks(2470), new DateTime(2021, 6, 27, 15, 15, 51, 850, DateTimeKind.Unspecified).AddTicks(8273) },
                    { 157, 4, "YT76331-1", 4, new DateTime(2021, 10, 31, 7, 36, 5, 504, DateTimeKind.Unspecified).AddTicks(49), new DateTime(2021, 7, 26, 23, 11, 37, 400, DateTimeKind.Unspecified).AddTicks(5745) },
                    { 89, 5, "YT45755-0", 5, new DateTime(2021, 9, 11, 10, 56, 24, 454, DateTimeKind.Unspecified).AddTicks(6308), new DateTime(2021, 7, 28, 2, 33, 46, 525, DateTimeKind.Unspecified).AddTicks(145) },
                    { 73, 2, "YT36914-0", 5, new DateTime(2021, 9, 8, 2, 31, 41, 106, DateTimeKind.Unspecified).AddTicks(9459), new DateTime(2021, 6, 26, 10, 17, 25, 829, DateTimeKind.Unspecified).AddTicks(5354) },
                    { 196, 4, "YT27947-0", 4, new DateTime(2021, 10, 15, 18, 48, 26, 791, DateTimeKind.Unspecified).AddTicks(1851), new DateTime(2021, 7, 16, 9, 28, 39, 807, DateTimeKind.Unspecified).AddTicks(3844) },
                    { 200, 2, "YT21388-1", 4, new DateTime(2021, 11, 26, 3, 51, 29, 262, DateTimeKind.Unspecified).AddTicks(9524), new DateTime(2021, 8, 14, 10, 19, 32, 963, DateTimeKind.Unspecified).AddTicks(5069) },
                    { 1, 5, "YT99547-1", 5, new DateTime(2021, 9, 26, 18, 25, 57, 308, DateTimeKind.Unspecified).AddTicks(8240), new DateTime(2021, 8, 11, 5, 23, 15, 66, DateTimeKind.Unspecified).AddTicks(4044) },
                    { 6, 4, "YT99264-1", 5, new DateTime(2021, 10, 8, 9, 13, 50, 605, DateTimeKind.Unspecified).AddTicks(4076), new DateTime(2021, 8, 19, 9, 52, 4, 901, DateTimeKind.Unspecified).AddTicks(8358) },
                    { 12, 1, "YT80224-1", 5, new DateTime(2021, 10, 19, 9, 43, 39, 19, DateTimeKind.Unspecified).AddTicks(5664), new DateTime(2021, 6, 20, 11, 51, 57, 13, DateTimeKind.Unspecified).AddTicks(3015) },
                    { 16, 3, "YT21763-1", 5, new DateTime(2021, 12, 18, 0, 59, 55, 671, DateTimeKind.Unspecified).AddTicks(9087), new DateTime(2021, 5, 8, 11, 13, 0, 456, DateTimeKind.Unspecified).AddTicks(7123) },
                    { 18, 2, "YT34834-0", 5, new DateTime(2021, 11, 20, 15, 1, 42, 665, DateTimeKind.Unspecified).AddTicks(4108), new DateTime(2021, 7, 9, 11, 7, 45, 670, DateTimeKind.Unspecified).AddTicks(2884) },
                    { 29, 5, "YT86686-0", 5, new DateTime(2021, 10, 9, 9, 20, 54, 184, DateTimeKind.Unspecified).AddTicks(7237), new DateTime(2021, 7, 17, 10, 43, 12, 411, DateTimeKind.Unspecified).AddTicks(6925) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 30, 2, "YT32398-1", 5, new DateTime(2021, 11, 22, 7, 49, 57, 411, DateTimeKind.Unspecified).AddTicks(9452), new DateTime(2021, 5, 10, 19, 13, 50, 847, DateTimeKind.Unspecified).AddTicks(4535) },
                    { 34, 2, "YT61796-1", 5, new DateTime(2021, 10, 2, 15, 44, 18, 168, DateTimeKind.Unspecified).AddTicks(8310), new DateTime(2021, 5, 20, 22, 49, 44, 503, DateTimeKind.Unspecified).AddTicks(8126) },
                    { 35, 3, "YT87109-1", 5, new DateTime(2021, 9, 25, 16, 37, 52, 580, DateTimeKind.Unspecified).AddTicks(435), new DateTime(2021, 7, 16, 17, 46, 51, 960, DateTimeKind.Unspecified).AddTicks(877) },
                    { 36, 4, "YT87039-0", 5, new DateTime(2021, 10, 9, 13, 39, 2, 154, DateTimeKind.Unspecified).AddTicks(2739), new DateTime(2021, 6, 1, 8, 18, 52, 557, DateTimeKind.Unspecified).AddTicks(5133) },
                    { 37, 2, "YT39312-1", 5, new DateTime(2021, 11, 3, 22, 45, 29, 717, DateTimeKind.Unspecified).AddTicks(7070), new DateTime(2021, 7, 10, 6, 43, 23, 275, DateTimeKind.Unspecified).AddTicks(6516) },
                    { 43, 2, "YT99790-0", 5, new DateTime(2021, 11, 17, 1, 31, 20, 704, DateTimeKind.Unspecified).AddTicks(8957), new DateTime(2021, 7, 1, 4, 25, 27, 242, DateTimeKind.Unspecified).AddTicks(2030) },
                    { 47, 2, "YT42303-1", 5, new DateTime(2021, 10, 6, 1, 52, 50, 78, DateTimeKind.Unspecified).AddTicks(8321), new DateTime(2021, 5, 26, 5, 42, 14, 371, DateTimeKind.Unspecified).AddTicks(9936) },
                    { 48, 3, "YT33688-0", 5, new DateTime(2021, 10, 29, 10, 28, 27, 909, DateTimeKind.Unspecified).AddTicks(9920), new DateTime(2021, 5, 10, 18, 54, 31, 706, DateTimeKind.Unspecified).AddTicks(4862) },
                    { 52, 2, "YT61454-0", 5, new DateTime(2021, 11, 21, 20, 2, 26, 825, DateTimeKind.Unspecified).AddTicks(8851), new DateTime(2021, 5, 8, 8, 5, 9, 102, DateTimeKind.Unspecified).AddTicks(317) },
                    { 54, 5, "YT45454-0", 5, new DateTime(2021, 10, 27, 21, 59, 54, 763, DateTimeKind.Unspecified).AddTicks(2786), new DateTime(2021, 7, 29, 7, 13, 52, 27, DateTimeKind.Unspecified).AddTicks(287) },
                    { 62, 1, "YT99967-0", 5, new DateTime(2021, 11, 23, 4, 37, 0, 908, DateTimeKind.Unspecified).AddTicks(7285), new DateTime(2021, 5, 12, 6, 14, 12, 794, DateTimeKind.Unspecified).AddTicks(8216) },
                    { 64, 5, "YT14063-0", 5, new DateTime(2021, 12, 14, 4, 9, 8, 783, DateTimeKind.Unspecified).AddTicks(7399), new DateTime(2021, 6, 20, 6, 56, 5, 620, DateTimeKind.Unspecified).AddTicks(7424) },
                    { 65, 1, "YT62026-0", 5, new DateTime(2021, 10, 5, 0, 0, 22, 690, DateTimeKind.Unspecified).AddTicks(6836), new DateTime(2021, 6, 22, 3, 44, 18, 975, DateTimeKind.Unspecified).AddTicks(6864) },
                    { 87, 3, "YT35820-1", 5, new DateTime(2021, 11, 2, 7, 53, 19, 285, DateTimeKind.Unspecified).AddTicks(4429), new DateTime(2021, 6, 10, 2, 2, 39, 928, DateTimeKind.Unspecified).AddTicks(4594) },
                    { 96, 4, "YT69696-0", 3, new DateTime(2021, 11, 27, 0, 15, 20, 471, DateTimeKind.Unspecified).AddTicks(3304), new DateTime(2021, 6, 9, 20, 17, 57, 807, DateTimeKind.Unspecified).AddTicks(6795) },
                    { 95, 3, "YT73830-1", 3, new DateTime(2021, 11, 1, 3, 33, 25, 36, DateTimeKind.Unspecified).AddTicks(7266), new DateTime(2021, 7, 26, 20, 5, 38, 625, DateTimeKind.Unspecified).AddTicks(4484) },
                    { 94, 2, "YT39369-1", 3, new DateTime(2021, 9, 9, 2, 47, 23, 705, DateTimeKind.Unspecified).AddTicks(5351), new DateTime(2021, 7, 19, 19, 2, 43, 730, DateTimeKind.Unspecified).AddTicks(5728) },
                    { 134, 3, "YT85004-1", 1, new DateTime(2021, 10, 29, 22, 56, 56, 357, DateTimeKind.Unspecified).AddTicks(5959), new DateTime(2021, 6, 20, 18, 4, 48, 669, DateTimeKind.Unspecified).AddTicks(4764) },
                    { 135, 3, "YT70628-0", 1, new DateTime(2021, 9, 22, 14, 27, 21, 637, DateTimeKind.Unspecified).AddTicks(8845), new DateTime(2021, 7, 20, 0, 15, 34, 62, DateTimeKind.Unspecified).AddTicks(4858) },
                    { 141, 4, "YT29223-0", 1, new DateTime(2021, 9, 16, 17, 23, 13, 863, DateTimeKind.Unspecified).AddTicks(4136), new DateTime(2021, 8, 19, 10, 7, 33, 271, DateTimeKind.Unspecified).AddTicks(3732) },
                    { 145, 2, "YT89285-0", 1, new DateTime(2021, 9, 25, 17, 28, 55, 355, DateTimeKind.Unspecified).AddTicks(5466), new DateTime(2021, 7, 15, 5, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(1120) },
                    { 146, 1, "YT69857-0", 1, new DateTime(2021, 12, 6, 1, 29, 8, 211, DateTimeKind.Unspecified).AddTicks(8304), new DateTime(2021, 5, 16, 10, 13, 19, 70, DateTimeKind.Unspecified).AddTicks(5438) },
                    { 159, 3, "YT57597-0", 1, new DateTime(2021, 12, 9, 17, 3, 50, 367, DateTimeKind.Unspecified).AddTicks(2898), new DateTime(2021, 7, 22, 5, 5, 21, 622, DateTimeKind.Unspecified).AddTicks(6186) },
                    { 160, 2, "YT28213-0", 1, new DateTime(2021, 11, 6, 22, 42, 59, 498, DateTimeKind.Unspecified).AddTicks(3649), new DateTime(2021, 6, 14, 15, 25, 44, 235, DateTimeKind.Unspecified).AddTicks(1019) },
                    { 177, 5, "YT55398-1", 1, new DateTime(2021, 11, 24, 8, 22, 56, 843, DateTimeKind.Unspecified).AddTicks(523), new DateTime(2021, 7, 9, 16, 19, 6, 269, DateTimeKind.Unspecified).AddTicks(8376) },
                    { 179, 4, "YT34090-0", 1, new DateTime(2021, 9, 17, 15, 21, 20, 918, DateTimeKind.Unspecified).AddTicks(4853), new DateTime(2021, 8, 15, 8, 41, 2, 745, DateTimeKind.Unspecified).AddTicks(8331) },
                    { 188, 3, "YT53526-0", 1, new DateTime(2021, 11, 25, 22, 32, 12, 922, DateTimeKind.Unspecified).AddTicks(3906), new DateTime(2021, 6, 27, 6, 45, 34, 658, DateTimeKind.Unspecified).AddTicks(4031) },
                    { 2, 4, "YT96651-0", 2, new DateTime(2021, 11, 13, 4, 46, 4, 509, DateTimeKind.Unspecified).AddTicks(3208), new DateTime(2021, 5, 30, 12, 42, 48, 759, DateTimeKind.Unspecified).AddTicks(514) },
                    { 3, 1, "YT54295-1", 2, new DateTime(2021, 9, 1, 15, 5, 10, 863, DateTimeKind.Unspecified).AddTicks(3563), new DateTime(2021, 6, 11, 18, 35, 20, 768, DateTimeKind.Unspecified).AddTicks(8941) },
                    { 13, 2, "YT45872-0", 2, new DateTime(2021, 9, 30, 8, 0, 49, 956, DateTimeKind.Unspecified).AddTicks(3843), new DateTime(2021, 6, 20, 4, 30, 56, 565, DateTimeKind.Unspecified).AddTicks(9852) },
                    { 14, 3, "YT46228-0", 2, new DateTime(2021, 10, 19, 11, 51, 59, 966, DateTimeKind.Unspecified).AddTicks(9366), new DateTime(2021, 7, 29, 9, 11, 56, 992, DateTimeKind.Unspecified).AddTicks(6261) },
                    { 20, 2, "YT90675-0", 2, new DateTime(2021, 12, 1, 10, 49, 22, 675, DateTimeKind.Unspecified).AddTicks(233), new DateTime(2021, 6, 29, 6, 30, 3, 144, DateTimeKind.Unspecified).AddTicks(829) },
                    { 22, 3, "YT55419-1", 2, new DateTime(2021, 9, 18, 4, 14, 45, 327, DateTimeKind.Unspecified).AddTicks(8812), new DateTime(2021, 7, 3, 7, 31, 55, 163, DateTimeKind.Unspecified).AddTicks(573) },
                    { 27, 2, "YT52674-1", 2, new DateTime(2021, 11, 17, 0, 43, 11, 724, DateTimeKind.Unspecified).AddTicks(4670), new DateTime(2021, 8, 14, 18, 3, 1, 876, DateTimeKind.Unspecified).AddTicks(2516) },
                    { 28, 5, "YT40029-1", 2, new DateTime(2021, 9, 12, 5, 54, 29, 50, DateTimeKind.Unspecified).AddTicks(4873), new DateTime(2021, 6, 12, 0, 26, 53, 371, DateTimeKind.Unspecified).AddTicks(526) },
                    { 31, 3, "YT18725-1", 2, new DateTime(2021, 12, 27, 15, 7, 30, 502, DateTimeKind.Unspecified).AddTicks(7920), new DateTime(2021, 8, 7, 18, 36, 21, 523, DateTimeKind.Unspecified).AddTicks(1814) },
                    { 32, 2, "YT42660-1", 2, new DateTime(2021, 10, 10, 4, 37, 43, 590, DateTimeKind.Unspecified).AddTicks(903), new DateTime(2021, 5, 18, 3, 28, 33, 979, DateTimeKind.Unspecified).AddTicks(8059) },
                    { 33, 5, "YT19287-0", 2, new DateTime(2021, 12, 9, 17, 56, 51, 946, DateTimeKind.Unspecified).AddTicks(5741), new DateTime(2021, 7, 21, 6, 55, 59, 984, DateTimeKind.Unspecified).AddTicks(6032) },
                    { 129, 3, "YT74835-1", 1, new DateTime(2021, 10, 24, 11, 22, 4, 37, DateTimeKind.Unspecified).AddTicks(3891), new DateTime(2021, 8, 15, 5, 12, 50, 482, DateTimeKind.Unspecified).AddTicks(2643) },
                    { 38, 4, "YT85767-0", 2, new DateTime(2021, 10, 11, 4, 14, 52, 727, DateTimeKind.Unspecified).AddTicks(9618), new DateTime(2021, 7, 28, 0, 28, 29, 882, DateTimeKind.Unspecified).AddTicks(6193) },
                    { 122, 5, "YT87395-1", 1, new DateTime(2021, 12, 3, 17, 56, 41, 253, DateTimeKind.Unspecified).AddTicks(1298), new DateTime(2021, 5, 23, 15, 32, 27, 47, DateTimeKind.Unspecified).AddTicks(8035) },
                    { 120, 3, "YT93622-1", 1, new DateTime(2021, 11, 14, 23, 35, 51, 955, DateTimeKind.Unspecified).AddTicks(1881), new DateTime(2021, 8, 2, 5, 1, 55, 668, DateTimeKind.Unspecified).AddTicks(1130) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 19, 5, "YT13222-1", 1, new DateTime(2021, 12, 22, 14, 43, 46, 734, DateTimeKind.Unspecified).AddTicks(9758), new DateTime(2021, 6, 30, 23, 19, 39, 139, DateTimeKind.Unspecified).AddTicks(1406) },
                    { 21, 3, "YT91078-0", 1, new DateTime(2021, 10, 31, 20, 29, 1, 677, DateTimeKind.Unspecified).AddTicks(7865), new DateTime(2021, 8, 16, 15, 41, 16, 888, DateTimeKind.Unspecified).AddTicks(4221) },
                    { 23, 3, "YT66819-0", 1, new DateTime(2021, 10, 28, 3, 9, 35, 477, DateTimeKind.Unspecified).AddTicks(287), new DateTime(2021, 5, 26, 15, 14, 44, 891, DateTimeKind.Unspecified).AddTicks(5847) },
                    { 41, 1, "YT16047-1", 1, new DateTime(2021, 12, 21, 19, 3, 12, 589, DateTimeKind.Unspecified).AddTicks(7202), new DateTime(2021, 7, 6, 20, 10, 5, 101, DateTimeKind.Unspecified).AddTicks(3718) },
                    { 42, 5, "YT55911-0", 1, new DateTime(2021, 12, 6, 6, 25, 25, 875, DateTimeKind.Unspecified).AddTicks(5002), new DateTime(2021, 7, 9, 15, 8, 26, 727, DateTimeKind.Unspecified).AddTicks(9548) },
                    { 44, 3, "YT11423-0", 1, new DateTime(2021, 9, 28, 13, 46, 40, 555, DateTimeKind.Unspecified).AddTicks(466), new DateTime(2021, 6, 25, 15, 40, 34, 140, DateTimeKind.Unspecified).AddTicks(6757) },
                    { 53, 5, "YT71335-1", 1, new DateTime(2021, 10, 12, 15, 23, 53, 359, DateTimeKind.Unspecified).AddTicks(7024), new DateTime(2021, 6, 12, 14, 46, 47, 407, DateTimeKind.Unspecified).AddTicks(4620) },
                    { 57, 3, "YT79645-1", 1, new DateTime(2021, 12, 14, 2, 55, 59, 606, DateTimeKind.Unspecified).AddTicks(1771), new DateTime(2021, 8, 20, 9, 49, 39, 426, DateTimeKind.Unspecified).AddTicks(3826) },
                    { 59, 1, "YT46809-0", 1, new DateTime(2021, 11, 20, 22, 37, 6, 74, DateTimeKind.Unspecified).AddTicks(6530), new DateTime(2021, 7, 9, 23, 45, 55, 328, DateTimeKind.Unspecified).AddTicks(8217) },
                    { 66, 1, "YT49006-1", 1, new DateTime(2021, 9, 15, 17, 9, 56, 639, DateTimeKind.Unspecified).AddTicks(2924), new DateTime(2021, 7, 9, 3, 33, 43, 717, DateTimeKind.Unspecified).AddTicks(6553) },
                    { 67, 5, "YT67490-0", 1, new DateTime(2021, 11, 24, 6, 46, 9, 512, DateTimeKind.Unspecified).AddTicks(2877), new DateTime(2021, 7, 20, 5, 32, 59, 27, DateTimeKind.Unspecified).AddTicks(9928) },
                    { 68, 3, "YT52619-0", 1, new DateTime(2021, 11, 27, 1, 29, 13, 428, DateTimeKind.Unspecified).AddTicks(7001), new DateTime(2021, 8, 8, 0, 45, 42, 571, DateTimeKind.Unspecified).AddTicks(5668) },
                    { 69, 1, "YT21487-1", 1, new DateTime(2021, 9, 6, 17, 45, 26, 182, DateTimeKind.Unspecified).AddTicks(778), new DateTime(2021, 5, 8, 1, 27, 55, 554, DateTimeKind.Unspecified).AddTicks(1677) },
                    { 71, 3, "YT74456-1", 1, new DateTime(2021, 10, 8, 8, 58, 41, 759, DateTimeKind.Unspecified).AddTicks(4014), new DateTime(2021, 7, 22, 15, 45, 44, 762, DateTimeKind.Unspecified).AddTicks(6482) },
                    { 80, 3, "YT86998-1", 1, new DateTime(2021, 10, 5, 16, 42, 57, 118, DateTimeKind.Unspecified).AddTicks(8867), new DateTime(2021, 6, 22, 3, 5, 12, 192, DateTimeKind.Unspecified).AddTicks(5987) },
                    { 82, 1, "YT63898-0", 1, new DateTime(2021, 11, 5, 11, 51, 3, 317, DateTimeKind.Unspecified).AddTicks(9982), new DateTime(2021, 7, 18, 3, 28, 50, 102, DateTimeKind.Unspecified).AddTicks(1485) },
                    { 83, 4, "YT45901-0", 1, new DateTime(2021, 9, 21, 19, 57, 37, 809, DateTimeKind.Unspecified).AddTicks(3878), new DateTime(2021, 7, 29, 14, 24, 5, 225, DateTimeKind.Unspecified).AddTicks(1899) },
                    { 88, 1, "YT74144-0", 1, new DateTime(2021, 10, 26, 21, 59, 25, 606, DateTimeKind.Unspecified).AddTicks(2852), new DateTime(2021, 8, 25, 12, 11, 43, 296, DateTimeKind.Unspecified).AddTicks(6684) },
                    { 91, 3, "YT36859-1", 1, new DateTime(2021, 10, 31, 0, 34, 11, 779, DateTimeKind.Unspecified).AddTicks(2160), new DateTime(2021, 7, 23, 8, 10, 22, 859, DateTimeKind.Unspecified).AddTicks(4530) },
                    { 93, 1, "YT25496-0", 1, new DateTime(2021, 12, 10, 22, 52, 38, 630, DateTimeKind.Unspecified).AddTicks(2470), new DateTime(2021, 6, 2, 7, 8, 36, 858, DateTimeKind.Unspecified).AddTicks(3096) },
                    { 113, 3, "YT65127-1", 1, new DateTime(2021, 11, 9, 7, 12, 33, 325, DateTimeKind.Unspecified).AddTicks(9468), new DateTime(2021, 7, 6, 7, 35, 54, 570, DateTimeKind.Unspecified).AddTicks(2883) },
                    { 121, 5, "YT35506-0", 1, new DateTime(2021, 11, 2, 9, 34, 32, 274, DateTimeKind.Unspecified).AddTicks(3925), new DateTime(2021, 8, 10, 15, 48, 46, 642, DateTimeKind.Unspecified).AddTicks(4504) },
                    { 39, 1, "YT13484-0", 2, new DateTime(2021, 11, 3, 9, 54, 4, 891, DateTimeKind.Unspecified).AddTicks(60), new DateTime(2021, 7, 31, 10, 46, 12, 344, DateTimeKind.Unspecified).AddTicks(6132) },
                    { 46, 5, "YT90226-0", 2, new DateTime(2021, 11, 18, 13, 9, 29, 174, DateTimeKind.Unspecified).AddTicks(7126), new DateTime(2021, 6, 6, 13, 8, 32, 115, DateTimeKind.Unspecified).AddTicks(4365) },
                    { 49, 4, "YT61664-0", 2, new DateTime(2021, 10, 24, 1, 17, 1, 400, DateTimeKind.Unspecified).AddTicks(9664), new DateTime(2021, 5, 11, 20, 24, 33, 41, DateTimeKind.Unspecified).AddTicks(2229) },
                    { 173, 5, "YT35211-1", 2, new DateTime(2021, 10, 25, 22, 27, 16, 476, DateTimeKind.Unspecified).AddTicks(6840), new DateTime(2021, 6, 23, 18, 31, 37, 11, DateTimeKind.Unspecified).AddTicks(1457) },
                    { 180, 3, "YT68138-1", 2, new DateTime(2021, 12, 12, 23, 33, 39, 566, DateTimeKind.Unspecified).AddTicks(2059), new DateTime(2021, 8, 23, 4, 19, 59, 54, DateTimeKind.Unspecified).AddTicks(6448) },
                    { 185, 5, "YT69177-1", 2, new DateTime(2021, 11, 21, 23, 32, 0, 787, DateTimeKind.Unspecified).AddTicks(5423), new DateTime(2021, 5, 11, 21, 0, 56, 335, DateTimeKind.Unspecified).AddTicks(9598) },
                    { 189, 2, "YT65191-1", 2, new DateTime(2021, 9, 29, 1, 8, 24, 389, DateTimeKind.Unspecified).AddTicks(2865), new DateTime(2021, 7, 2, 23, 35, 39, 448, DateTimeKind.Unspecified).AddTicks(9997) },
                    { 190, 1, "YT99368-1", 2, new DateTime(2021, 10, 16, 6, 28, 25, 441, DateTimeKind.Unspecified).AddTicks(8970), new DateTime(2021, 7, 8, 0, 28, 13, 151, DateTimeKind.Unspecified).AddTicks(4688) },
                    { 192, 1, "YT65149-0", 2, new DateTime(2021, 10, 25, 20, 46, 49, 618, DateTimeKind.Unspecified).AddTicks(8864), new DateTime(2021, 8, 4, 15, 29, 1, 101, DateTimeKind.Unspecified).AddTicks(1836) },
                    { 194, 4, "YT29790-0", 2, new DateTime(2021, 10, 13, 9, 25, 51, 530, DateTimeKind.Unspecified).AddTicks(3651), new DateTime(2021, 5, 30, 13, 44, 56, 57, DateTimeKind.Unspecified).AddTicks(4843) },
                    { 199, 4, "YT77430-0", 2, new DateTime(2021, 10, 25, 13, 18, 30, 688, DateTimeKind.Unspecified).AddTicks(2914), new DateTime(2021, 8, 22, 15, 27, 58, 309, DateTimeKind.Unspecified).AddTicks(8927) },
                    { 4, 3, "YT94010-0", 3, new DateTime(2021, 12, 28, 1, 2, 53, 359, DateTimeKind.Unspecified).AddTicks(8205), new DateTime(2021, 7, 22, 19, 58, 51, 83, DateTimeKind.Unspecified).AddTicks(8245) },
                    { 8, 4, "YT26987-0", 3, new DateTime(2021, 9, 23, 1, 25, 47, 633, DateTimeKind.Unspecified).AddTicks(9603), new DateTime(2021, 7, 3, 22, 54, 10, 595, DateTimeKind.Unspecified).AddTicks(7913) },
                    { 24, 5, "YT63027-0", 3, new DateTime(2021, 12, 15, 11, 43, 3, 558, DateTimeKind.Unspecified).AddTicks(7817), new DateTime(2021, 6, 28, 15, 29, 54, 116, DateTimeKind.Unspecified).AddTicks(1445) },
                    { 25, 5, "YT47210-0", 3, new DateTime(2021, 12, 12, 18, 38, 11, 348, DateTimeKind.Unspecified).AddTicks(9386), new DateTime(2021, 7, 15, 11, 57, 14, 490, DateTimeKind.Unspecified).AddTicks(7588) },
                    { 40, 1, "YT81102-1", 3, new DateTime(2021, 12, 30, 2, 54, 35, 197, DateTimeKind.Unspecified).AddTicks(4214), new DateTime(2021, 7, 19, 1, 9, 41, 509, DateTimeKind.Unspecified).AddTicks(452) },
                    { 45, 2, "YT93596-1", 3, new DateTime(2021, 10, 22, 18, 16, 41, 611, DateTimeKind.Unspecified).AddTicks(8580), new DateTime(2021, 8, 19, 8, 0, 36, 787, DateTimeKind.Unspecified).AddTicks(331) },
                    { 50, 5, "YT90275-0", 3, new DateTime(2021, 11, 23, 0, 56, 51, 105, DateTimeKind.Unspecified).AddTicks(3781), new DateTime(2021, 5, 21, 14, 8, 10, 386, DateTimeKind.Unspecified).AddTicks(5947) },
                    { 51, 4, "YT54455-0", 3, new DateTime(2021, 10, 3, 10, 54, 21, 88, DateTimeKind.Unspecified).AddTicks(4521), new DateTime(2021, 5, 15, 20, 45, 30, 421, DateTimeKind.Unspecified).AddTicks(5287) },
                    { 58, 4, "YT53964-0", 3, new DateTime(2021, 10, 12, 2, 3, 16, 396, DateTimeKind.Unspecified).AddTicks(2962), new DateTime(2021, 5, 20, 12, 42, 0, 651, DateTimeKind.Unspecified).AddTicks(4869) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 60, 1, "YT88880-1", 3, new DateTime(2021, 12, 27, 1, 27, 2, 789, DateTimeKind.Unspecified).AddTicks(9799), new DateTime(2021, 7, 7, 11, 49, 44, 14, DateTimeKind.Unspecified).AddTicks(630) },
                    { 63, 5, "YT40024-1", 3, new DateTime(2021, 10, 24, 12, 58, 47, 1, DateTimeKind.Unspecified).AddTicks(3699), new DateTime(2021, 6, 29, 17, 32, 1, 64, DateTimeKind.Unspecified).AddTicks(6581) },
                    { 70, 2, "YT97789-0", 3, new DateTime(2021, 9, 12, 4, 37, 0, 893, DateTimeKind.Unspecified).AddTicks(9227), new DateTime(2021, 7, 22, 4, 16, 59, 784, DateTimeKind.Unspecified).AddTicks(2029) },
                    { 86, 2, "YT57977-0", 3, new DateTime(2021, 10, 14, 21, 57, 32, 512, DateTimeKind.Unspecified).AddTicks(686), new DateTime(2021, 5, 25, 16, 46, 25, 257, DateTimeKind.Unspecified).AddTicks(1262) },
                    { 170, 5, "YT37084-1", 2, new DateTime(2021, 10, 7, 23, 47, 33, 502, DateTimeKind.Unspecified).AddTicks(8618), new DateTime(2021, 5, 31, 18, 53, 32, 174, DateTimeKind.Unspecified).AddTicks(6425) },
                    { 164, 4, "YT38482-1", 2, new DateTime(2021, 10, 27, 0, 39, 3, 866, DateTimeKind.Unspecified).AddTicks(6280), new DateTime(2021, 7, 31, 4, 35, 21, 489, DateTimeKind.Unspecified).AddTicks(8350) },
                    { 163, 5, "YT51134-0", 2, new DateTime(2021, 10, 3, 3, 4, 9, 323, DateTimeKind.Unspecified).AddTicks(4969), new DateTime(2021, 8, 3, 4, 0, 46, 584, DateTimeKind.Unspecified).AddTicks(9348) },
                    { 161, 5, "YT37434-1", 2, new DateTime(2021, 11, 6, 15, 39, 0, 918, DateTimeKind.Unspecified).AddTicks(6104), new DateTime(2021, 8, 30, 5, 21, 59, 945, DateTimeKind.Unspecified).AddTicks(3876) },
                    { 55, 4, "YT20352-0", 2, new DateTime(2021, 12, 2, 6, 44, 52, 40, DateTimeKind.Unspecified).AddTicks(1671), new DateTime(2021, 8, 24, 7, 55, 1, 448, DateTimeKind.Unspecified).AddTicks(6788) },
                    { 61, 2, "YT12277-1", 2, new DateTime(2021, 11, 10, 20, 49, 57, 620, DateTimeKind.Unspecified).AddTicks(5221), new DateTime(2021, 5, 22, 22, 4, 54, 824, DateTimeKind.Unspecified).AddTicks(6164) },
                    { 72, 3, "YT63226-0", 2, new DateTime(2021, 9, 25, 10, 8, 15, 745, DateTimeKind.Unspecified).AddTicks(3734), new DateTime(2021, 6, 12, 17, 4, 11, 245, DateTimeKind.Unspecified).AddTicks(6718) },
                    { 74, 1, "YT83522-0", 2, new DateTime(2021, 10, 27, 7, 54, 12, 448, DateTimeKind.Unspecified).AddTicks(3009), new DateTime(2021, 8, 17, 5, 4, 32, 768, DateTimeKind.Unspecified).AddTicks(4479) },
                    { 81, 5, "YT62311-1", 2, new DateTime(2021, 9, 4, 22, 30, 14, 163, DateTimeKind.Unspecified).AddTicks(9520), new DateTime(2021, 7, 28, 9, 57, 3, 615, DateTimeKind.Unspecified).AddTicks(9268) },
                    { 97, 3, "YT51616-0", 2, new DateTime(2021, 12, 22, 2, 18, 11, 269, DateTimeKind.Unspecified).AddTicks(4552), new DateTime(2021, 5, 20, 3, 43, 58, 751, DateTimeKind.Unspecified).AddTicks(1331) },
                    { 101, 3, "YT17087-1", 2, new DateTime(2021, 12, 29, 14, 57, 45, 258, DateTimeKind.Unspecified).AddTicks(9736), new DateTime(2021, 5, 25, 3, 43, 59, 717, DateTimeKind.Unspecified).AddTicks(1307) },
                    { 106, 2, "YT80513-0", 2, new DateTime(2021, 10, 27, 21, 38, 15, 408, DateTimeKind.Unspecified).AddTicks(9900), new DateTime(2021, 7, 2, 22, 47, 40, 485, DateTimeKind.Unspecified).AddTicks(5353) },
                    { 109, 5, "YT18785-0", 2, new DateTime(2021, 12, 6, 15, 22, 46, 244, DateTimeKind.Unspecified).AddTicks(3553), new DateTime(2021, 7, 16, 18, 7, 35, 891, DateTimeKind.Unspecified).AddTicks(9853) },
                    { 110, 2, "YT31998-0", 2, new DateTime(2021, 10, 13, 11, 54, 42, 240, DateTimeKind.Unspecified).AddTicks(9710), new DateTime(2021, 6, 16, 18, 10, 23, 809, DateTimeKind.Unspecified).AddTicks(6020) },
                    { 197, 5, "YT37053-0", 5, new DateTime(2021, 10, 11, 10, 55, 54, 709, DateTimeKind.Unspecified).AddTicks(5497), new DateTime(2021, 8, 26, 23, 26, 27, 880, DateTimeKind.Unspecified).AddTicks(4764) },
                    { 112, 5, "YT69443-0", 2, new DateTime(2021, 11, 15, 17, 51, 6, 803, DateTimeKind.Unspecified).AddTicks(4450), new DateTime(2021, 8, 18, 0, 27, 13, 597, DateTimeKind.Unspecified).AddTicks(946) },
                    { 125, 1, "YT81878-0", 2, new DateTime(2021, 12, 7, 3, 13, 38, 642, DateTimeKind.Unspecified).AddTicks(346), new DateTime(2021, 5, 25, 20, 36, 22, 123, DateTimeKind.Unspecified).AddTicks(9593) },
                    { 127, 1, "YT97852-1", 2, new DateTime(2021, 11, 30, 8, 45, 30, 923, DateTimeKind.Unspecified).AddTicks(7389), new DateTime(2021, 8, 8, 7, 41, 32, 628, DateTimeKind.Unspecified).AddTicks(9658) },
                    { 130, 5, "YT99871-0", 2, new DateTime(2021, 10, 15, 12, 2, 53, 927, DateTimeKind.Unspecified).AddTicks(8235), new DateTime(2021, 5, 18, 11, 42, 1, 500, DateTimeKind.Unspecified).AddTicks(3776) },
                    { 131, 2, "YT29358-1", 2, new DateTime(2021, 9, 30, 10, 58, 50, 194, DateTimeKind.Unspecified).AddTicks(3352), new DateTime(2021, 5, 13, 14, 45, 12, 841, DateTimeKind.Unspecified).AddTicks(4893) },
                    { 138, 5, "YT89953-0", 2, new DateTime(2021, 9, 28, 21, 4, 17, 670, DateTimeKind.Unspecified).AddTicks(6554), new DateTime(2021, 5, 18, 14, 38, 36, 49, DateTimeKind.Unspecified).AddTicks(8373) },
                    { 139, 1, "YT94329-0", 2, new DateTime(2021, 9, 13, 13, 26, 59, 975, DateTimeKind.Unspecified).AddTicks(4911), new DateTime(2021, 8, 29, 14, 14, 12, 44, DateTimeKind.Unspecified).AddTicks(2590) },
                    { 140, 5, "YT38256-1", 2, new DateTime(2021, 11, 10, 7, 38, 34, 338, DateTimeKind.Unspecified).AddTicks(398), new DateTime(2021, 7, 10, 5, 5, 25, 51, DateTimeKind.Unspecified).AddTicks(6485) },
                    { 144, 4, "YT19372-1", 2, new DateTime(2021, 11, 1, 18, 48, 14, 997, DateTimeKind.Unspecified).AddTicks(9278), new DateTime(2021, 7, 17, 10, 20, 22, 792, DateTimeKind.Unspecified).AddTicks(4863) },
                    { 153, 4, "YT48850-1", 2, new DateTime(2021, 9, 17, 12, 53, 30, 130, DateTimeKind.Unspecified).AddTicks(6684), new DateTime(2021, 6, 18, 15, 51, 57, 15, DateTimeKind.Unspecified).AddTicks(8295) },
                    { 158, 3, "YT97120-1", 2, new DateTime(2021, 12, 22, 13, 59, 28, 741, DateTimeKind.Unspecified).AddTicks(3450), new DateTime(2021, 8, 29, 21, 52, 51, 813, DateTimeKind.Unspecified).AddTicks(7318) },
                    { 117, 5, "YT49778-1", 2, new DateTime(2021, 9, 20, 11, 29, 37, 866, DateTimeKind.Unspecified).AddTicks(5109), new DateTime(2021, 7, 31, 14, 42, 47, 24, DateTimeKind.Unspecified).AddTicks(6177) },
                    { 198, 5, "YT47603-1", 5, new DateTime(2021, 10, 7, 3, 56, 56, 741, DateTimeKind.Unspecified).AddTicks(4418), new DateTime(2021, 5, 31, 16, 24, 42, 458, DateTimeKind.Unspecified).AddTicks(363) }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 38, "440 Clement Hills", null, "East Wilma", null, "H2R 1B2", "NT" },
                    { 62, "0376 Veum Via", null, "Lubowitzport", null, "K5T 5M7", "NB" },
                    { 54, "1075 Mueller Via", null, "Lake Pat", null, "A9N 6F5", "MB" },
                    { 147, "422 Alexa Summit", null, "East Kristoferside", null, "B3F 2T7", "BC" },
                    { 39, "316 Ferry Square", null, "Dayneland", null, "S3N 5H5", "BC" },
                    { 46, "1984 Scotty Lakes", null, "Sylvestertown", null, "V3H 1P8", "ON" },
                    { 52, "82673 Caterina Plaza", null, "West Thomasmouth", null, "G7H 3A6", "QC" },
                    { 136, "86924 Jalen Expressway", null, "Tamiaport", null, "T8H 5E6", "MB" },
                    { 49, "129 Ed Mountain", null, "Bergetown", null, "K6V 0M8", "SK" },
                    { 55, "788 Reinger Gardens", null, "North Conorfurt", null, "H2N 0E9", "MB" },
                    { 77, "7752 Cassin Vista", null, "Raventown", null, "B6V 8A3", "PE" },
                    { 48, "160 Aryanna Burg", null, "South Gunnershire", null, "M0Z 9U3", "MB" },
                    { 61, "905 Belle Place", null, "Howellborough", null, "K0P 9Y0", "NS" },
                    { 72, "98716 Jamal Plains", null, "Wolfchester", null, "E5O 3Y6", "MB" },
                    { 47, "45063 Olaf Streets", null, "West Telly", null, "R8K 8N7", "BC" },
                    { 33, "968 Mossie Crossroad", null, "Cielomouth", null, "T3F 7D6", "PE" },
                    { 74, "2898 Conn Ferry", null, "Leschfort", null, "J1C 1Z9", "AB" },
                    { 133, "460 Cindy Knolls", null, "North Kallie", null, "B3M 3H4", "AB" },
                    { 43, "097 Darrin Well", null, "South Rhodafort", null, "G7L 0I2", "PE" },
                    { 97, "2028 Wendell Ford", null, "Padbergberg", null, "X6Q 4H6", "ON" },
                    { 128, "7013 Bednar Mount", null, "East Haskell", null, "E7I 5W5", "NL" },
                    { 101, "412 Domingo Mountains", null, "Greenfeldertown", null, "V1T 3M0", "PE" },
                    { 119, "908 Lockman Grove", null, "Jaymetown", null, "G2O 3B6", "MB" },
                    { 106, "74376 Eula Coves", null, "Derrickstad", null, "X8S 9X3", "SK" },
                    { 37, "9563 Gleichner Underpass", null, "Kimtown", null, "S9P 7J1", "NS" },
                    { 109, "8694 Dennis Trail", null, "New Joey", null, "X2P 3D6", "NT" },
                    { 78, "89802 Nicklaus Ways", null, "North Darbyside", null, "L8F 0J9", "BC" },
                    { 110, "238 Selena Squares", null, "Arneberg", null, "G5B 9Q2", "AB" },
                    { 112, "9182 Vladimir Mission", null, "West Tristin", null, "A5K 3I8", "NL" },
                    { 36, "74761 Schaden Squares", null, "Revahaven", null, "H1X 7W2", "BC" },
                    { 195, "92945 McCullough Mountain", null, "West Kianna", null, "M6K 0Q5", "SK" },
                    { 81, "1695 Mayer Plaza", null, "East Darioshire", null, "S2B 2A5", "MB" },
                    { 118, "69129 Goldner Fords", null, "East Johannamouth", null, "M3H 1H6", "BC" },
                    { 76, "88972 Emiliano Prairie", null, "Port Garrick", null, "Y2C 0J1", "AB" },
                    { 75, "521 Casandra Field", null, "Feestton", null, "H1H 3I0", "MB" },
                    { 160, "588 McClure Locks", null, "North Graciefort", null, "A4T 9I0", "YT" },
                    { 162, "499 Zack Keys", null, "Lake Judah", null, "X3E 1E5", "MB" },
                    { 15, "20569 Leora Light", null, "Rosenbaumton", null, "L8K 1M0", "PE" },
                    { 177, "89944 Towne Mount", null, "Port Nyahfort", null, "B4P 1W4", "QC" },
                    { 179, "9016 Abbott Ports", null, "Janelleport", null, "T5J 8A9", "NL" },
                    { 104, "96141 Ortiz Wells", null, "East Ahmad", null, "J1R 9J4", "AB" },
                    { 188, "220 Reuben Wall", null, "Jacobsonside", null, "B4D 6Z1", "SK" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 156, "613 Reinger Gardens", null, "Dickinsonbury", null, "C6W 9Q4", "PE" },
                    { 102, "00971 Billie Ferry", null, "North Bertha", null, "P5Z 7G1", "NT" },
                    { 2, "2741 Damon Village", null, "South Amarachester", null, "K1A 0M1", "AB" },
                    { 17, "82043 Kertzmann Common", null, "Baumbachmouth", null, "G3Q 6D9", "ON" },
                    { 154, "1776 Anne Passage", null, "Emmerichburgh", null, "H3C 8V2", "NL" },
                    { 100, "8476 Trudie Mission", null, "East Chaya", null, "T5V 4N0", "MB" },
                    { 3, "63895 Niko Road", null, "East Elroy", null, "T3I 5Z5", "YT" },
                    { 64, "10009 Towne Harbor", null, "New Jimmieland", null, "B1H 2K0", "BC" },
                    { 13, "497 Ullrich Rapid", null, "Lake Syblemouth", null, "Y1C 5P2", "NL" },
                    { 26, "14605 Watsica Valley", null, "East Mckenziemouth", null, "Y0S 1P6", "NL" },
                    { 14, "88249 Mason Corners", null, "Flaviefort", null, "C2F 0T0", "QC" },
                    { 89, "8844 Delphine Ferry", null, "Strackeborough", null, "Y7F 7U5", "BC" },
                    { 20, "195 Crist Canyon", null, "Pollymouth", null, "N7C 5I1", "QC" },
                    { 152, "94076 Annabel Spurs", null, "Woodrowmouth", null, "T0Z 6L7", "ON" },
                    { 22, "542 Moen Pike", null, "McCulloughfurt", null, "P4K 0D4", "BC" },
                    { 87, "060 Lydia Avenue", null, "North Eduardo", null, "J9L 9K5", "NT" },
                    { 56, "6780 Deckow Camp", null, "Tannerside", null, "K9H 2W7", "SK" },
                    { 27, "8409 Legros Plaza", null, "Emilieside", null, "N9S 5P4", "MB" },
                    { 73, "6674 Hettie Creek", null, "Giachester", null, "L2Y 2L0", "AB" },
                    { 28, "483 Jakubowski Corner", null, "Catharineborough", null, "M3B 1M8", "MB" },
                    { 31, "1188 Elbert Landing", null, "Lake Vickybury", null, "G2J 5V0", "PE" },
                    { 65, "2342 Deondre Walks", null, "North Germanside", null, "M0Z 9G5", "NS" },
                    { 32, "2794 Collins Pines", null, "Lake Leonardo", null, "H6U 4T3", "AB" },
                    { 92, "885 Goodwin Road", null, "North Willardport", null, "H3P 8R2", "NT" },
                    { 117, "72496 Tremaine Springs", null, "Homenickside", null, "M0Q 5G4", "NT" },
                    { 114, "83174 Jenkins Court", null, "Fadelstad", null, "X4C 7W4", "NS" },
                    { 35, "1785 Viva Inlet", null, "East Tamaramouth", null, "B3B 1X5", "NT" },
                    { 196, "200 Frankie Prairie", null, "Wittingfort", null, "P3R 9K1", "MB" },
                    { 192, "08076 Anderson Landing", null, "North Bettyeport", null, "L6X 6I6", "NB" },
                    { 194, "92148 Lindgren Island", null, "East Zion", null, "N9D 9Y7", "PE" },
                    { 174, "443 Althea Station", null, "Aronside", null, "E1Y 9E0", "NL" },
                    { 95, "14731 Alessia Fork", null, "Carmelafurt", null, "L4P 5B3", "YT" },
                    { 199, "0369 Bartoletti Summit", null, "Lake Tanya", null, "C2T 5M1", "AB" },
                    { 90, "455 Wisoky Port", null, "South Koreyburgh", null, "H1M 2Y4", "PE" },
                    { 4, "5369 Larson Walk", null, "Geoffreyton", null, "C7G 4Q5", "NL" },
                    { 157, "28237 Nienow Mountains", null, "New Taylor", null, "E6H 0N8", "NS" },
                    { 155, "408 Koch Parks", null, "Langworthburgh", null, "V7N 7D4", "YT" },
                    { 8, "46453 Brook Drive", null, "Braunton", null, "K2A 6O9", "NB" },
                    { 150, "65166 Koepp Key", null, "Nathanmouth", null, "K2G 8X2", "ON" },
                    { 24, "85011 Fisher Flat", null, "Koeppberg", null, "L0X 9T0", "NB" },
                    { 25, "5893 Lehner Port", null, "Kaydenland", null, "C4Y 7Y6", "SK" },
                    { 190, "450 Langworth Crescent", null, "Rettafurt", null, "K4G 7C6", "MB" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 94, "02619 Schmidt Ridge", null, "New Duncan", null, "J2U 7H5", "MB" },
                    { 148, "130 Hartmann Crest", null, "Mayshire", null, "Y3L 5Q7", "NS" },
                    { 45, "99460 Chanel Bridge", null, "Osvaldoside", null, "R1W 4N0", "QC" },
                    { 198, "46262 Dicki Club", null, "New Edmond", null, "Y2X 9G4", "BC" },
                    { 50, "919 Senger Overpass", null, "North Gilbert", null, "R9P 5B9", "AB" },
                    { 142, "9127 Eleazar Manor", null, "Gibsonshire", null, "Y2Q 7Y2", "MB" },
                    { 98, "573 Ryder Valleys", null, "Estellbury", null, "Y9M 7K8", "BC" },
                    { 137, "7174 Ullrich Valleys", null, "Balistreriberg", null, "S8O 1O5", "NT" },
                    { 51, "179 Will Rue", null, "South Wainoborough", null, "M5C 6B6", "NL" },
                    { 58, "8211 Kaya Trafficway", null, "East Eriktown", null, "P2N 0X0", "SK" },
                    { 124, "373 Torp Estate", null, "New Rossie", null, "H7Z 8R6", "PE" },
                    { 60, "32409 Kris Dam", null, "Rylanfurt", null, "E9E 8C3", "MB" },
                    { 86, "13591 Boehm Meadows", null, "Rowemouth", null, "H5M 4O4", "MB" },
                    { 63, "965 Garrett Place", null, "South Loycechester", null, "A1J 5J5", "MB" },
                    { 116, "855 Shanny Brook", null, "Ryderport", null, "R1O 4S2", "NB" },
                    { 40, "9143 Stark Locks", null, "East Oscarside", null, "X3E 5H3", "NU" },
                    { 189, "0584 Johnson Vista", null, "Konopelskiview", null, "E4D 9X7", "NB" },
                    { 96, "81383 Reichel Knolls", null, "Vidafort", null, "S0F 6O5", "AB" },
                    { 85, "09498 Dietrich Lodge", null, "Shieldsborough", null, "K0O 5G8", "SK" },
                    { 125, "820 Laron Valley", null, "South Elisabethland", null, "B6B 8J2", "QC" },
                    { 127, "22027 Metz Common", null, "Creminburgh", null, "N5F 9F1", "SK" },
                    { 79, "21231 Becker Manors", null, "North Michael", null, "X2W 9H0", "SK" },
                    { 34, "453 Gisselle Estates", null, "Lake Anyaville", null, "V6E 5I5", "NT" },
                    { 130, "8537 Blanca Route", null, "East Dillanshire", null, "J0R 9J2", "NB" },
                    { 131, "883 Berge Haven", null, "Greenview", null, "Y9U 2Z3", "AB" },
                    { 107, "7690 Gislason River", null, "Lake Priscilla", null, "R5N 1F4", "NS" },
                    { 138, "877 Jarrell Summit", null, "West Halliechester", null, "Y4L 4M5", "MB" },
                    { 139, "4333 Schumm Motorway", null, "Heidenreichberg", null, "S0V 9C9", "ON" },
                    { 30, "527 Sigrid Viaduct", null, "Dameonview", null, "V1H 1G3", "NT" },
                    { 140, "40172 Velda Brook", null, "East Herminiotown", null, "A0P 9V9", "NT" },
                    { 144, "285 Johnson Drives", null, "South Leannhaven", null, "N4X 1F0", "NU" },
                    { 153, "0295 Reymundo Loop", null, "New Mekhi", null, "G4S 1G1", "AB" },
                    { 158, "84036 Destin Lights", null, "Port Anissaton", null, "X5X 2L8", "ON" },
                    { 161, "3421 Roma Harbor", null, "Anissaside", null, "M6Y 0P7", "ON" },
                    { 29, "19924 Ulises Oval", null, "South Earnestineport", null, "S3R 2F5", "AB" },
                    { 18, "79507 Wendell Well", null, "Lake Sunnystad", null, "N5C 7O2", "BC" },
                    { 185, "865 Valerie Run", null, "Bretstad", null, "P0A 6L8", "AB" },
                    { 200, "75631 Gerard Loop", null, "South Maiyaport", null, "G3S 8I0", "NB" },
                    { 1, "774 Haag Squares", null, "Bertramchester", null, "S4C 9G5", "NL" },
                    { 180, "9391 Retta Grove", null, "Port Kirsten", null, "A6K 4Z3", "QC" },
                    { 6, "831 Dedric River", null, "Lake Charles", null, "M9S 0Q6", "MB" },
                    { 173, "9953 Sanford Turnpike", null, "Elvaton", null, "M6O 8B6", "QC" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 105, "6803 McDermott Shoals", null, "South Keaganport", null, "B8J 8J7", "YT" },
                    { 99, "5973 Rickie Valleys", null, "Port Haileyton", null, "X9E 6O6", "NU" },
                    { 164, "156 Gaylord Key", null, "East Leann", null, "K4L 0F5", "NT" },
                    { 84, "4348 Juanita Extensions", null, "Altenwerthtown", null, "C8A 5V0", "ON" },
                    { 12, "90272 Okuneva Shores", null, "Lake Adrianstad", null, "Y3Q 0H9", "BC" },
                    { 163, "6111 Verlie Ford", null, "Dustybury", null, "J1F 8D1", "AB" },
                    { 103, "4644 Madalyn Port", null, "Lakinview", null, "S2F 0L7", "YT" },
                    { 16, "40926 Stanton Loop", null, "Blandafort", null, "R6R 5G8", "NT" },
                    { 170, "8701 Granville View", null, "Hammesfurt", null, "E0W 6F3", "YT" },
                    { 159, "28653 Trinity Lakes", null, "Johnstonmouth", null, "Y8Q 1R7", "SK" },
                    { 70, "1825 Kris View", null, "Gutkowskifort", null, "N9U 9Z3", "PE" },
                    { 146, "746 Dora Brook", null, "Port Abigayleborough", null, "E4U 3J9", "ON" },
                    { 120, "678 Christa Alley", null, "West Winfieldchester", null, "L9V 4G8", "NB" },
                    { 59, "3999 Zieme Extensions", null, "Dudleyville", null, "L5H 6C0", "ON" },
                    { 57, "636 Frida Burgs", null, "Javiertown", null, "X3S 2F8", "NT" },
                    { 5, "927 Kuhic Pike", null, "Elmoton", null, "L0X 5M5", "PE" },
                    { 126, "227 Michale Fords", null, "Hartmanntown", null, "Y7T 6G8", "NL" },
                    { 191, "835 Einar Cove", null, "North Marjolaine", null, "Y4G 8I3", "NT" },
                    { 176, "4401 Leonor Highway", null, "VonRuedenmouth", null, "M0A 8L8", "NT" },
                    { 121, "649 Von Freeway", null, "Gibsonmouth", null, "E3O 0N5", "NU" },
                    { 53, "9685 Marquardt View", null, "Edmondmouth", null, "L6Q 5Z1", "QC" },
                    { 9, "4222 Jakubowski Tunnel", null, "Walkerhaven", null, "V7P 4L6", "AB" },
                    { 169, "0707 Maxie Knoll", null, "Mertzport", null, "P5N 0V1", "NU" },
                    { 122, "878 Norval Light", null, "Braunmouth", null, "K7I 4I7", "MB" },
                    { 44, "848 Hilpert Bridge", null, "West Vernmouth", null, "K1I 6S1", "SK" },
                    { 182, "86705 Dino Vista", null, "Ramirobury", null, "K4S 0S7", "AB" },
                    { 42, "138 Felicia Vista", null, "South Douglas", null, "G0G 9R6", "NL" },
                    { 123, "686 Kunde Parks", null, "Mablemouth", null, "T4K 3D2", "NB" },
                    { 129, "9600 Viviane Meadow", null, "Kirlinmouth", null, "L1S 6I6", "ON" },
                    { 184, "7905 Lee Manors", null, "Katrineville", null, "R8F 0E4", "NL" },
                    { 168, "09800 Bergnaum Trace", null, "New Madisenfort", null, "L8D 6U6", "PE" },
                    { 175, "80958 Dickinson Village", null, "New Candace", null, "A0F 1D3", "NT" },
                    { 41, "291 Murray Stream", null, "New Vicky", null, "Y0U 6P7", "PE" },
                    { 132, "98542 Nolan Summit", null, "South Hazle", null, "H1O 1Q1", "ON" },
                    { 113, "648 Colt Ferry", null, "Boyleburgh", null, "Y4M 9A7", "PE" },
                    { 151, "726 Botsford Oval", null, "Keatonborough", null, "E2C 7C0", "NU" },
                    { 181, "519 Schuster Estate", null, "Frankieville", null, "B2E 1K6", "SK" },
                    { 149, "2450 Schinner Parkway", null, "Gloverborough", null, "E0Q 6F2", "YT" },
                    { 80, "506 Chadrick River", null, "Sandystad", null, "P3K 9N6", "PE" },
                    { 83, "04383 Runolfsdottir Circle", null, "West Estelleton", null, "X3P 3I8", "SK" },
                    { 167, "84341 Marlon Divide", null, "South Sidney", null, "J1U 7Z6", "QC" },
                    { 71, "52428 Tromp Ports", null, "Lake Margueriteland", null, "B3K 2W8", "YT" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 88, "7900 Johns Meadows", null, "New Reubenmouth", null, "X7R 6R2", "AB" },
                    { 143, "5992 Kelsi Crossing", null, "Mooremouth", null, "P3Q 8I0", "PE" },
                    { 7, "773 Leonel River", null, "Thompsonside", null, "M5I 6V8", "SK" },
                    { 69, "939 Karl Park", null, "Prosaccoborough", null, "L8Z 0F5", "AB" },
                    { 183, "69583 Tia Square", null, "Rocioberg", null, "Y7I 0Y7", "ON" },
                    { 178, "816 Medhurst Walks", null, "Albinaville", null, "H9H 1M9", "ON" },
                    { 171, "25101 Ottilie Green", null, "Port Paytonburgh", null, "V9Z 1N8", "NS" },
                    { 91, "2126 Kuphal Point", null, "Irwinchester", null, "V1B 5C5", "YT" },
                    { 68, "5397 Okuneva Gardens", null, "West Winston", null, "R3O 3V3", "ON" },
                    { 93, "968 Christina Track", null, "Helgafurt", null, "P3S 1R5", "MB" },
                    { 67, "925 Schamberger Trail", null, "Maratown", null, "J9V 1T7", "BC" },
                    { 172, "152 Collins Loop", null, "Odieside", null, "R3C 6W0", "NB" },
                    { 66, "1509 Ziemann Station", null, "Boehmburgh", null, "N5T 3Q3", "SK" },
                    { 115, "7954 Aurelie Heights", null, "Port Amari", null, "P2B 9P7", "NS" },
                    { 82, "555 Ines Rapid", null, "West Kaylah", null, "S1L 7H2", "QC" },
                    { 108, "61951 Gutmann Rest", null, "East Gonzaloside", null, "N2L 9Q3", "YT" },
                    { 23, "010 Mac Oval", null, "Turnerbury", null, "G0R 5M2", "SK" },
                    { 145, "213 Zemlak Vista", null, "West Stephon", null, "J3R 3K5", "NB" },
                    { 141, "0692 Aglae Springs", null, "South Frederikport", null, "M3N 7I5", "PE" },
                    { 11, "29399 Feil Hill", null, "New Rustyfort", null, "X9Z 8E1", "NS" },
                    { 10, "588 Darby Islands", null, "Kaleighburgh", null, "R1W 7Y5", "NT" },
                    { 193, "31810 Armstrong Mews", null, "Ashlynnhaven", null, "Y9G 5B4", "NT" },
                    { 165, "2279 Smitham Ferry", null, "Carrieton", null, "L0Z 5N6", "ON" },
                    { 21, "70358 Gutkowski Spring", null, "New Tamia", null, "L6M 0W8", "NU" },
                    { 19, "5123 Sanford Village", null, "North Hortenseborough", null, "T9Q 4I9", "PE" },
                    { 134, "695 Ova Islands", null, "Purdyfort", null, "J6Q 8O6", "QC" },
                    { 166, "605 Pfeffer Cliffs", null, "Lake Theafurt", null, "Y6H 4I7", "NB" },
                    { 187, "299 Schoen Expressway", null, "Staceyton", null, "B4J 5S4", "NL" },
                    { 186, "9175 Marcel Union", null, "South Sabina", null, "R1P 6W9", "ON" },
                    { 197, "9306 Effertz Run", null, "East Sigmundstad", null, "J3P 7U2", "AB" },
                    { 111, "065 Langosh Walks", null, "Simonetown", null, "Y9H 2C6", "PE" },
                    { 135, "724 Garry Grove", null, "Dominiqueborough", null, "G9V 1C8", "AB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 158, "292 Schultz Lock", null, "Pfefferview", null, "M4W 0W0", "BC" },
                    { 124, "072 Grady Well", null, "Robelhaven", null, "S8V 0K3", "NL" },
                    { 58, "9148 VonRueden Isle", null, "Londonstad", null, "B9F 9R5", "NS" },
                    { 68, "5999 Champlin Dam", null, "Aracelistad", null, "H6J 2B8", "BC" },
                    { 18, "787 Koelpin Forks", null, "Denaburgh", null, "X0B 3L6", "NB" },
                    { 86, "9467 Toy Glen", null, "South Dante", null, "J4O 2X9", "AB" },
                    { 29, "7137 Medhurst Park", null, "Gerhardburgh", null, "S7T 2W4", "ON" },
                    { 16, "876 Tania Overpass", null, "Krystelfurt", null, "T6Z 3H6", "SK" },
                    { 51, "64598 Toy Ranch", null, "Port Joe", null, "K6D 1Z4", "NL" },
                    { 19, "5927 Hoppe Fords", null, "South Ezraton", null, "V3S 8W5", "BC" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 171, "252 Herzog Estates", null, "West Jacynthe", null, "K6F 4H1", "ON" },
                    { 67, "443 Hilpert Glens", null, "Port Leonardo", null, "E4I 3V6", "BC" },
                    { 163, "8478 Dietrich River", null, "New Logan", null, "C4C 3Z1", "SK" },
                    { 12, "8696 Garland Crest", null, "North Grady", null, "A1X 7E3", "NB" },
                    { 161, "87159 Eddie Extensions", null, "East Friedrich", null, "X7J 4T6", "NL" },
                    { 103, "4633 Shania Squares", null, "South Alta", null, "P3G 1L7", "NL" },
                    { 94, "40672 Madyson Cape", null, "Rodriguezshire", null, "H1Y 4K9", "MB" },
                    { 197, "087 Tromp Freeway", null, "Port Maci", null, "J7Z 4L0", "NB" },
                    { 193, "20481 Anahi Summit", null, "Torpside", null, "X3P 6I0", "YT" },
                    { 127, "677 Ashleigh Stream", null, "Herzogland", null, "E2C 5M3", "MB" },
                    { 151, "20526 Toney Station", null, "New Felicitafort", null, "R2E 3D7", "NT" },
                    { 116, "8580 Langworth Drive", null, "West Bettiebury", null, "E0V 8D5", "BC" },
                    { 34, "6636 Katrina Stravenue", null, "South Turnerside", null, "N3N 0U9", "SK" },
                    { 80, "06084 Keebler Meadows", null, "West Josephborough", null, "N5L 3M1", "NL" },
                    { 130, "6073 Richie Causeway", null, "North Kevenview", null, "N9B 4J5", "NS" },
                    { 107, "69321 Freda Island", null, "Hellerstad", null, "C4R 5M1", "PE" },
                    { 63, "363 Rowe Loaf", null, "New Rorybury", null, "G6G 8N2", "QC" },
                    { 131, "861 Kuphal Trafficway", null, "Erlinghaven", null, "H1A 0O5", "PE" },
                    { 10, "798 Jazlyn Camp", null, "North Angus", null, "R3S 0I8", "PE" },
                    { 138, "416 Lowe Skyway", null, "Adityaview", null, "R5H 0X3", "NU" },
                    { 167, "6001 Nelson Islands", null, "Lemkestad", null, "V0U 1K5", "NL" },
                    { 139, "1012 Connelly Camp", null, "Sebastianville", null, "P1O 0B9", "ON" },
                    { 30, "6274 Mireille Trail", null, "East Maialand", null, "K1M 3H7", "NT" },
                    { 71, "78729 Labadie View", null, "Schinnerfort", null, "J5R 2R9", "YT" },
                    { 60, "4294 Murazik Courts", null, "West Sallyton", null, "N5A 4E7", "AB" },
                    { 140, "63212 Hickle Oval", null, "Kozeyview", null, "P4L 0U7", "MB" },
                    { 79, "176 Stark Burgs", null, "Dietrichhaven", null, "C7U 6O1", "BC" },
                    { 5, "0427 Klocko Fall", null, "South Micaela", null, "H1J 6P6", "NT" },
                    { 144, "3425 Rippin Crest", null, "Littleville", null, "R6H 9H7", "QC" },
                    { 172, "5475 Waldo Springs", null, "Rueckermouth", null, "E7K 0L2", "BC" },
                    { 69, "2894 Rodrigo Mountain", null, "East Morganborough", null, "E3W 5G6", "NL" },
                    { 153, "3370 Gutkowski Cliff", null, "East Stella", null, "A0Q 3W9", "SK" },
                    { 164, "76175 Freida Stravenue", null, "Lake Rosalynhaven", null, "S1Y 1E1", "SK" },
                    { 99, "69310 Schuster Haven", null, "South Rhettchester", null, "Y4K 4T9", "ON" },
                    { 84, "27457 Crystal Ranch", null, "Ziemannstad", null, "N7X 8V0", "SK" },
                    { 85, "26870 Elnora Gardens", null, "Jacobsville", null, "A2B 1T4", "NS" },
                    { 44, "867 Gunner River", null, "Port Coltenchester", null, "R3L 2U4", "SK" },
                    { 192, "19412 Osinski Extensions", null, "North Vanville", null, "E2A 5Z7", "NL" },
                    { 95, "653 Frami Rapid", null, "Lonzomouth", null, "E9C 8U6", "NU" },
                    { 174, "664 Stephon Lodge", null, "Donnellyberg", null, "A5T 2P3", "QC" },
                    { 148, "964 Isabel Freeway", null, "North Greggfurt", null, "V9H 6C2", "AB" },
                    { 194, "945 Beier Track", null, "Gerardomouth", null, "N6I 0K6", "YT" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 23, "41510 Treutel Streets", null, "Port Lincoln", null, "P5W 1Z8", "ON" },
                    { 182, "88340 Feil Lakes", null, "East Jenningstown", null, "C2V 9H7", "NU" },
                    { 191, "08101 Ronaldo Locks", null, "Thompsonstad", null, "X6T 6O3", "YT" },
                    { 176, "819 O'Connell Route", null, "West Jayson", null, "C0K 7E3", "AB" },
                    { 199, "9692 Runte Alley", null, "Port Katelynhaven", null, "T1Y 8H8", "NL" },
                    { 157, "709 Ayden Lakes", null, "Port Jasminstad", null, "M2I 8L0", "NS" },
                    { 25, "1762 Stokes Falls", null, "New Bulah", null, "P1T 7J1", "BC" },
                    { 4, "37790 Cyrus Trail", null, "North Robinville", null, "N6I 8G8", "SK" },
                    { 186, "06325 Mabelle Fall", null, "Bartolettimouth", null, "P4I 6P4", "YT" },
                    { 24, "719 Walsh Station", null, "Tillmanshire", null, "N3M 7W7", "NT" },
                    { 155, "63087 Carley Bypass", null, "New Brittany", null, "K9V 2V7", "ON" },
                    { 184, "16631 Carroll Field", null, "Towneport", null, "C7G 5J8", "QC" },
                    { 150, "8633 Pfeffer Springs", null, "Nakialand", null, "S7I 2B8", "MB" },
                    { 41, "699 Billy Bypass", null, "South Eldredport", null, "R5Q 3E1", "NL" },
                    { 8, "17781 Welch Mall", null, "Lucybury", null, "J1X 9L7", "YT" },
                    { 42, "11452 Heaney Locks", null, "Lake Katlynn", null, "M5V 6R8", "NB" },
                    { 137, "2237 Ernestina Mills", null, "Torphybury", null, "M1Y 8B0", "ON" },
                    { 190, "169 Macey Cliffs", null, "Simoneton", null, "M8L 4H3", "NB" },
                    { 196, "64373 Sipes Mountain", null, "New Reuben", null, "Y2L 1L7", "SK" },
                    { 66, "8585 Moen Harbors", null, "Donnellstad", null, "S2V 9L3", "YT" },
                    { 170, "948 Cassin Glens", null, "Ramonamouth", null, "V0N 0K2", "NL" },
                    { 90, "15475 Tromp Key", null, "Americatown", null, "H1I 2S4", "BC" },
                    { 98, "69733 Magdalena Mountain", null, "Abshirechester", null, "V1S 6L6", "NT" },
                    { 6, "578 Gloria Trafficway", null, "Huberthaven", null, "R0B 2V1", "BC" },
                    { 195, "121 Bahringer Forks", null, "East Kaitlynfort", null, "J2X 2Z3", "NU" },
                    { 59, "6295 Hammes Estates", null, "Hayleyshire", null, "B5S 0K5", "AB" },
                    { 173, "503 Kody Common", null, "Jenkinshaven", null, "K7K 5U1", "MB" },
                    { 50, "69587 Runolfsson Street", null, "Lake Roxannehaven", null, "P1I 1H2", "NU" },
                    { 57, "909 Charley Burgs", null, "Adolphland", null, "B0U 1E4", "BC" },
                    { 40, "597 Emilie Gateway", null, "Champlinmouth", null, "G0E 6K0", "NB" },
                    { 180, "357 Johns Route", null, "Port Mariela", null, "X7C 7A3", "NB" },
                    { 21, "21045 O'Hara Extension", null, "East Jon", null, "T6E 8V8", "QC" },
                    { 200, "318 Amy Well", null, "North Abbigail", null, "X4M 8N0", "NL" },
                    { 183, "59103 Wilson Tunnel", null, "South Rickieland", null, "N2H 4N6", "ON" },
                    { 185, "6985 Beer Ports", null, "Leschport", null, "C0V 3W6", "PE" },
                    { 142, "424 Walsh Via", null, "Beerville", null, "N3I 3K6", "NU" },
                    { 96, "3519 Adam Shoals", null, "Leifborough", null, "A6N 4F6", "MB" },
                    { 45, "76570 Kub Plaza", null, "Katharinaberg", null, "Y7Z 5Z6", "MB" },
                    { 53, "968 Bartell Trail", null, "South Davin", null, "A2F 8D3", "SK" },
                    { 187, "64138 Carter Locks", null, "West Geovany", null, "A5S 7M0", "QC" },
                    { 125, "84898 Corkery Union", null, "Corytown", null, "A6O 6T3", "AB" },
                    { 1, "35192 Gerhard Lights", null, "Idellafort", null, "C8F 1G2", "SK" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 189, "4690 Grant Fort", null, "Lake Lisaville", null, "L2N 4L5", "NS" },
                    { 149, "50976 Sonya Point", null, "Altenwerthhaven", null, "M8J 9V6", "NL" },
                    { 35, "24336 Pedro Heights", null, "O'Haramouth", null, "S6F 7A5", "YT" },
                    { 152, "6716 Bergstrom Trafficway", null, "South Eliland", null, "J6N 0K7", "QC" },
                    { 87, "9580 Ondricka Loaf", null, "Greenfurt", null, "B4H 0K2", "ON" },
                    { 168, "93738 Mosciski Viaduct", null, "Wisozkton", null, "X0M 3G3", "PE" },
                    { 22, "4311 Wuckert Stream", null, "Shaynaville", null, "P0W 1O5", "NB" },
                    { 129, "575 White Street", null, "Port Genevieve", null, "K1L 2J5", "NT" },
                    { 27, "27733 Isaias Prairie", null, "Mayertland", null, "Y6V 1L1", "NS" },
                    { 56, "122 Quinton Junction", null, "Lake Manuelport", null, "G2Y 0M3", "PE" },
                    { 73, "37019 Kling Stravenue", null, "North Sigridmouth", null, "A2G 0O7", "PE" },
                    { 123, "7532 Kuvalis Lodge", null, "Javonteport", null, "P9K 6V2", "SK" },
                    { 28, "27494 Goldner Villages", null, "Lawsonfort", null, "H7Y 6R9", "NU" },
                    { 65, "162 Paucek Avenue", null, "Laurelfort", null, "A2B 7Q8", "PE" },
                    { 122, "72192 Juliet Motorway", null, "Port Danyka", null, "K6W 8O4", "BC" },
                    { 31, "04808 Nicolette Loaf", null, "Jermaineton", null, "G5U 7W9", "BC" },
                    { 32, "827 Bogan Mission", null, "New Edward", null, "Y1H 2Z4", "NL" },
                    { 169, "23951 Hilpert Trail", null, "New Lenna", null, "H2Q 8D7", "ON" },
                    { 75, "51122 Lueilwitz Ridges", null, "North Lethaborough", null, "A7O 8X3", "NU" },
                    { 64, "00500 Angelo Street", null, "North Zachariahhaven", null, "Y0F 1H4", "MB" },
                    { 9, "39818 Bradtke Curve", null, "New Vallie", null, "A7F 8F0", "YT" },
                    { 62, "738 Terry Gateway", null, "Justinaport", null, "V6I 2J3", "MB" },
                    { 121, "01224 Osborne Rue", null, "Jazmynland", null, "N2Q 3H7", "AB" },
                    { 33, "567 Ferne Ridge", null, "Vincenzoberg", null, "H6L 3K2", "QC" },
                    { 147, "782 Carter Harbor", null, "South Charlotte", null, "A7I 0M3", "NU" },
                    { 82, "65752 Jermain Motorway", null, "East Bell", null, "M9I 5S8", "SK" },
                    { 70, "2683 Jared View", null, "Robertoland", null, "N7D 4T2", "MB" },
                    { 38, "13036 Idell Mountains", null, "Kutchview", null, "L2Z 3H4", "NB" },
                    { 126, "5317 Leannon Prairie", null, "Breannestad", null, "A6T 5W8", "NS" },
                    { 76, "2080 Taryn Falls", null, "North Alba", null, "J5S 8H0", "PE" },
                    { 20, "38347 Maureen Parkways", null, "North Alexandra", null, "A1L 5N1", "QC" },
                    { 115, "953 Lemke Radial", null, "Korbinhaven", null, "C5P 8Q3", "MB" },
                    { 89, "88160 Nina Lakes", null, "East Zola", null, "P6N 8J9", "QC" },
                    { 14, "19260 Daija Circle", null, "Jasperview", null, "M4D 4W3", "NL" },
                    { 159, "75101 Marquise Creek", null, "New Brigitte", null, "T3A 4C1", "NL" },
                    { 105, "0802 Daniel Well", null, "Lake Mohamed", null, "K5O 6K6", "PE" },
                    { 165, "6971 Champlin Islands", null, "Agnesfurt", null, "H3I 2Y4", "SK" },
                    { 160, "278 Kaelyn Green", null, "Dooleychester", null, "J2O 2U7", "NT" },
                    { 162, "849 Rice Ford", null, "Port Schuyler", null, "N3Q 0W4", "NS" },
                    { 11, "97164 Sally Parkway", null, "New Vinceton", null, "J1P 8G0", "NU" },
                    { 145, "100 Dorcas Stream", null, "Hardyborough", null, "A9H 6W9", "NT" },
                    { 177, "900 Burley Vista", null, "New Stacey", null, "G2B 8B4", "PE" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 15, "41835 Kovacek Pines", null, "Harleyhaven", null, "S1R 6Y4", "MB" },
                    { 179, "50602 Pfeffer Lodge", null, "West Xavierside", null, "V6M 7O2", "NS" },
                    { 104, "684 Wintheiser Parkway", null, "Citlallichester", null, "K9A 4Q9", "ON" },
                    { 108, "0505 Verla Expressway", null, "New Flavieshire", null, "V4A 8P3", "NL" },
                    { 156, "0956 Balistreri Skyway", null, "Nicholaustown", null, "L3G 3L4", "QC" },
                    { 39, "42193 Theo Junction", null, "Lake Judsonborough", null, "E7O 6T8", "SK" },
                    { 188, "97416 Hagenes Ridge", null, "Conradmouth", null, "C1M 3F5", "NL" },
                    { 102, "83436 Hayes Walks", null, "Port Hyman", null, "B5Z 2K3", "YT" },
                    { 141, "8337 Durgan Knoll", null, "Bernadineport", null, "B0Z 5G4", "BC" },
                    { 2, "14789 Schamberger Street", null, "Lake Brayanton", null, "G8Z 0K0", "MB" },
                    { 154, "42291 Kurtis Locks", null, "Lake Arnoldoshire", null, "K4W 3Z4", "NL" },
                    { 100, "8533 Ritchie Fork", null, "Kylaland", null, "K7O 4I9", "BC" },
                    { 166, "577 Doyle Square", null, "Jacobsonbury", null, "C7A 2P4", "AB" },
                    { 135, "1547 Dawson Greens", null, "New Ardellashire", null, "X8G 5D7", "NU" },
                    { 3, "8523 Koss Branch", null, "New Keltonton", null, "A5N 5I9", "NU" },
                    { 17, "0415 Cartwright Trail", null, "New Flaviofort", null, "L4O 8O9", "NL" },
                    { 13, "809 Kallie Squares", null, "West Camrenland", null, "B8J 6A4", "BC" },
                    { 92, "44175 Hayden Curve", null, "Edgardoberg", null, "V1T 6F2", "BC" },
                    { 134, "02885 Randy Groves", null, "West Cieloshire", null, "P1Z 9G5", "NU" },
                    { 26, "72084 Erik Fords", null, "East Sister", null, "E2M 1X7", "NU" },
                    { 111, "7636 Darien Mount", null, "Donnymouth", null, "L6H 3E9", "NT" },
                    { 120, "88190 Gutkowski Locks", null, "New Iliana", null, "T1X 2J9", "QC" },
                    { 54, "1247 Elwyn Drive", null, "South Destinee", null, "N5G 9Z8", "NU" },
                    { 198, "87578 Sauer Mews", null, "Aniyamouth", null, "V2T 5M0", "ON" },
                    { 83, "50362 Ila Radial", null, "Boyerstad", null, "E4B 9J1", "MB" },
                    { 93, "26455 Steve Avenue", null, "Vonmouth", null, "L2K 0L2", "QC" },
                    { 112, "373 Hettinger Pike", null, "Greenfelderstad", null, "C2G 8S0", "MB" },
                    { 74, "0646 McKenzie Viaduct", null, "Stehrfort", null, "Y7S 1F2", "QC" },
                    { 91, "3025 Runte Plaza", null, "Esmeraldahaven", null, "L7K 1O3", "NS" },
                    { 81, "2074 Shany Spur", null, "South Stefanieview", null, "S3O 3T1", "YT" },
                    { 43, "4278 Hailey Mall", null, "Nicolasfurt", null, "M7Y 2O7", "SK" },
                    { 178, "7932 Schaden Circle", null, "New Mellieburgh", null, "A9H 3N1", "MB" },
                    { 97, "904 Trey Shoals", null, "South Alexandria", null, "L3H 5V7", "BC" },
                    { 128, "0279 Jed Island", null, "Zoeview", null, "B7T 6M6", "MB" },
                    { 7, "167 Ethyl Mill", null, "West Shaylee", null, "G9T 1D0", "PE" },
                    { 46, "606 Cremin Square", null, "Murphyland", null, "C8R 7A3", "NS" },
                    { 119, "82357 Rippin Pine", null, "New Yasmin", null, "K3D 5E9", "PE" },
                    { 101, "219 Hammes Green", null, "Strosinchester", null, "G6R 3J9", "MB" },
                    { 36, "60230 Leannon Estate", null, "West Johnathonbury", null, "K9L 2O1", "SK" },
                    { 88, "35638 Bashirian Courts", null, "South Augustineland", null, "J8T 9J9", "MB" },
                    { 106, "9167 Ubaldo Burgs", null, "North Hassanville", null, "G2X 1Q9", "NU" },
                    { 37, "18290 Dare Trail", null, "Armstrongburgh", null, "Y1X 6S2", "MB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 110, "05531 Shaylee Stream", null, "Rosenbaumport", null, "A0D 9B6", "PE" },
                    { 143, "560 Gutmann Avenue", null, "East Felipa", null, "P8E 5I0", "BC" },
                    { 109, "773 Justyn Forge", null, "Parkermouth", null, "R4E 3X5", "MB" },
                    { 47, "7539 Dewitt Underpass", null, "Port Titus", null, "X2E 9B3", "NL" },
                    { 118, "495 Stark Trail", null, "New Berneiceton", null, "R7C 2C3", "ON" },
                    { 78, "91189 Emile Flat", null, "West Victorburgh", null, "C4Q 3B0", "PE" },
                    { 72, "2047 Letitia Village", null, "Anikaside", null, "H4J 6X3", "AB" },
                    { 181, "127 Elmer Village", null, "New Cydney", null, "T6Z 9E2", "NB" },
                    { 114, "800 Rosenbaum Loaf", null, "North Emanuel", null, "P9H 5U9", "MB" },
                    { 52, "343 Thompson Mall", null, "South Angelita", null, "J2U 8C8", "YT" },
                    { 136, "3389 Christiansen Fords", null, "New Jessybury", null, "P4E 5A8", "NL" },
                    { 49, "666 Marquardt Lakes", null, "East Dahliaborough", null, "X6K 2R5", "SK" },
                    { 146, "985 Roma Shoal", null, "West Lydastad", null, "X8W 1I3", "NB" },
                    { 55, "090 Claire Port", null, "South Ruthe", null, "M1K 5L4", "PE" },
                    { 175, "16376 Kautzer Ranch", null, "Lake Norberto", null, "A2I 5F7", "NU" },
                    { 48, "618 Rempel Villages", null, "Huelview", null, "G7P 0I5", "NS" },
                    { 132, "65847 Botsford Fork", null, "Lefflerton", null, "X8B 7W5", "YT" },
                    { 77, "824 D'angelo Light", null, "Port Ahmedland", null, "H8E 6M6", "MB" },
                    { 113, "8894 Gussie Field", null, "North Assunta", null, "S9A 7R9", "ON" },
                    { 61, "36550 Mills Station", null, "Port Raphael", null, "H1Q 7T9", "NL" },
                    { 133, "01222 Stan Estates", null, "Kendallborough", null, "M1R 4Q9", "NT" },
                    { 117, "419 Brown Fields", null, "Schmidtstad", null, "J9O 1H4", "PE" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 315, "Consequatur dolorum atque iste quia.", 116, 258m, "Solid", "Kg" },
                    { 164, "Repudiandae voluptatem voluptatem.", 7, 19912m, "Gas", "Kg" },
                    { 165, "Quo qui est quidem molestiae mollitia magnam.", 17, 2123m, "Gas", "Kg" },
                    { 112, "Est dolor et.", 79, 4635m, "Gas", "L" },
                    { 59, "Recusandae quas praesentium autem et.", 7, 14139m, "Gas", "L" },
                    { 343, "Ut quis iure ea velit perspiciatis.", 79, 14881m, "Solid", "Kg" },
                    { 64, "Voluptas omnis eveniet et et.", 79, 19284m, "Solid", "L" },
                    { 328, "Id et ipsam ratione.", 15, 2108m, "Liquid", "Kg" },
                    { 132, "Nostrum rerum vero inventore a.", 116, 10427m, "Liquid", "L" },
                    { 105, "Ut sit perspiciatis quaerat.", 17, 7622m, "Solid", "Kg" },
                    { 194, "Tenetur porro cupiditate dicta voluptatum repellendus debitis voluptatem.", 116, 2247m, "Liquid", "L" },
                    { 350, "Dolorem tenetur adipisci omnis perspiciatis et.", 7, 4874m, "Solid", "L" },
                    { 376, "Saepe ipsum eveniet cum dolores dolorum iure qui.", 7, 8072m, "Gas", "L" },
                    { 36, "Aut omnis voluptatibus voluptatibus molestias aut.", 56, 9019m, "Gas", "L" },
                    { 254, "Nisi illum et est atque voluptates illo at.", 78, 16166m, "Solid", "L" },
                    { 191, "Est illo aut.", 77, 3508m, "Liquid", "Kg" },
                    { 347, "Sunt dolore minima commodi doloribus iusto aut velit eos architecto.", 85, 3057m, "Solid", "Kg" },
                    { 480, "Et ipsam debitis libero et possimus.", 9, 10826m, "Gas", "Kg" },
                    { 204, "Aut officia perspiciatis.", 85, 2393m, "Solid", "L" },
                    { 444, "Et suscipit velit et et exercitationem quia quia est.", 77, 15945m, "Solid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 113, "Cum magnam vero accusamus sunt perspiciatis corrupti qui recusandae.", 85, 3969m, "Gas", "Kg" },
                    { 35, "Ut voluptas quia impedit libero aspernatur.", 76, 10292m, "Liquid", "L" },
                    { 87, "Fugit rerum ea nam.", 85, 16196m, "Solid", "L" },
                    { 62, "Ratione cum odit labore ea voluptatem doloremque voluptas.", 78, 7726m, "Gas", "Kg" },
                    { 440, "Sed blanditiis odit.", 9, 10393m, "Solid", "L" },
                    { 374, "Architecto aut enim consequuntur dolore quisquam.", 78, 3285m, "Solid", "Kg" },
                    { 172, "Similique impedit aliquid aliquid sunt nulla qui corporis.", 11, 6141m, "Liquid", "Kg" },
                    { 173, "Occaecati mollitia numquam illum consequuntur quia.", 90, 5205m, "Liquid", "L" },
                    { 57, "Et sapiente ut nulla mollitia blanditiis sed error.", 75, 19245m, "Liquid", "Kg" },
                    { 131, "Ratione ut aut.", 78, 2145m, "Liquid", "Kg" },
                    { 168, "Dolor cumque doloremque nesciunt mollitia.", 78, 14864m, "Liquid", "L" },
                    { 182, "Optio maiores velit ea in corrupti.", 78, 17973m, "Solid", "L" },
                    { 282, "Illum magnam eius quasi aliquam eligendi qui ad facilis rerum.", 11, 12776m, "Gas", "L" },
                    { 40, "Voluptatum sapiente voluptas reprehenderit rerum omnis aut cumque.", 84, 15790m, "Gas", "Kg" },
                    { 243, "Est facere vero sed qui.", 78, 12762m, "Gas", "Kg" },
                    { 446, "Itaque dignissimos placeat doloremque.", 98, 14790m, "Solid", "L" },
                    { 366, "Qui vitae incidunt non natus qui.", 5, 9294m, "Gas", "L" },
                    { 92, "Ut labore dolorum enim sed aut consectetur enim in labore.", 75, 10291m, "Solid", "Kg" },
                    { 201, "Laborum velit occaecati eum.", 77, 12991m, "Liquid", "Kg" },
                    { 224, "Officiis dignissimos fuga doloremque modi.", 36, 131m, "Liquid", "Kg" },
                    { 377, "Aliquam blanditiis tenetur nisi tempore saepe atque accusamus.", 116, 8596m, "Gas", "L" },
                    { 199, "Sed quisquam sequi voluptatem quis consequatur tempore excepturi consequatur magni.", 115, 17084m, "Solid", "L" },
                    { 348, "Animi autem numquam atque deleniti non tempore.", 108, 2807m, "Liquid", "L" },
                    { 248, "Tenetur voluptate non inventore.", 108, 16197m, "Solid", "L" },
                    { 3, "Dignissimos hic tenetur officia molestiae accusantium porro.", 108, 12878m, "Liquid", "Kg" },
                    { 443, "Et architecto esse neque aut maxime nihil.", 105, 19747m, "Solid", "L" },
                    { 367, "Dolore commodi itaque quam delectus asperiores ut nihil consectetur quas.", 105, 18896m, "Solid", "Kg" },
                    { 205, "Voluptatibus doloremque aut cupiditate.", 105, 1051m, "Gas", "L" },
                    { 181, "Exercitationem excepturi vel.", 105, 7969m, "Liquid", "L" },
                    { 34, "Corrupti nam qui totam.", 105, 13254m, "Gas", "L" },
                    { 300, "Iusto facilis recusandae voluptatem ut.", 104, 5298m, "Liquid", "Kg" },
                    { 297, "Non eum sit.", 104, 18983m, "Liquid", "Kg" },
                    { 183, "Impedit quibusdam quod.", 104, 496m, "Solid", "Kg" },
                    { 14, "Adipisci doloremque qui ut ut amet consequatur.", 104, 3205m, "Solid", "L" },
                    { 466, "Neque expedita magnam porro.", 102, 15541m, "Solid", "Kg" },
                    { 257, "Quibusdam enim sed illo et voluptate voluptatibus aliquid.", 115, 14708m, "Gas", "L" },
                    { 400, "Expedita sit fuga beatae fugiat ea facilis et.", 102, 19239m, "Liquid", "Kg" },
                    { 318, "Id nobis culpa.", 100, 10915m, "Solid", "L" },
                    { 331, "Incidunt odio suscipit.", 92, 14408m, "Solid", "Kg" },
                    { 250, "Cum saepe voluptatem id.", 92, 3569m, "Gas", "L" },
                    { 246, "Quod alias dignissimos vel non consequatur.", 92, 7338m, "Gas", "Kg" },
                    { 483, "Expedita et sunt itaque non ducimus quod est harum ea.", 89, 2157m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 196, "Aut sit aut non nesciunt velit quasi deleniti.", 89, 12027m, "Gas", "Kg" },
                    { 450, "Accusantium voluptas possimus rerum voluptatum quia omnis sint.", 87, 14771m, "Gas", "Kg" },
                    { 418, "Corrupti omnis temporibus atque natus tempore.", 87, 17321m, "Gas", "Kg" },
                    { 5, "Culpa libero libero assumenda dolore.", 87, 1778m, "Gas", "L" },
                    { 464, "Totam pariatur pariatur consequatur perspiciatis.", 73, 999m, "Solid", "Kg" },
                    { 175, "Quo voluptatem odit dolorem ratione deleniti soluta ipsam nostrum.", 65, 16867m, "Gas", "L" },
                    { 19, "Dolor numquam doloremque est nihil dolores.", 65, 12029m, "Solid", "Kg" },
                    { 234, "Quis itaque laudantium sequi quas omnis.", 64, 6629m, "Solid", "L" },
                    { 135, "Fugit consectetur delectus.", 64, 3978m, "Solid", "Kg" },
                    { 270, "Est ipsam et reprehenderit.", 102, 8053m, "Solid", "L" },
                    { 395, "Ipsum consequatur esse voluptate natus aut vel.", 62, 766m, "Gas", "L" },
                    { 384, "Nam alias sit reprehenderit nostrum rerum et.", 115, 2987m, "Solid", "Kg" },
                    { 279, "Sed a eum non totam ab.", 123, 17399m, "Liquid", "Kg" },
                    { 451, "Praesentium non facere qui dolores temporibus.", 198, 17080m, "Liquid", "L" },
                    { 335, "In autem placeat sit.", 198, 12693m, "Gas", "L" },
                    { 455, "Cumque molestiae repellendus sint sunt nihil at non adipisci est.", 197, 11397m, "Liquid", "Kg" },
                    { 393, "Et amet accusamus ullam et doloremque maiores id ut.", 197, 12379m, "Gas", "Kg" },
                    { 309, "Molestiae quo quidem consequatur nam cumque qui facilis.", 184, 16662m, "Liquid", "L" },
                    { 264, "Aut et tenetur placeat voluptas hic.", 176, 9267m, "Solid", "L" },
                    { 206, "Atque omnis eius atque enim officia ratione eaque.", 176, 4000m, "Solid", "L" },
                    { 12, "Voluptatibus est temporibus aut autem vel qui distinctio.", 176, 4485m, "Liquid", "L" },
                    { 385, "Molestiae laudantium odit quas.", 171, 19723m, "Solid", "L" },
                    { 263, "Vel facilis sint.", 171, 3110m, "Solid", "Kg" },
                    { 413, "Sed rerum id accusantium et quas aut.", 167, 19260m, "Gas", "L" },
                    { 169, "Tempora accusamus sit quidem dolorem.", 167, 7770m, "Solid", "Kg" },
                    { 345, "Suscipit reprehenderit iusto repellendus doloribus velit.", 151, 4663m, "Solid", "L" },
                    { 230, "Dolores voluptates dolor minus nulla modi debitis tempore reiciendis.", 151, 11004m, "Solid", "L" },
                    { 396, "Cumque eveniet quisquam illo sunt omnis nihil et.", 115, 3433m, "Solid", "L" },
                    { 1, "Velit est eius harum nulla nesciunt sed.", 151, 6774m, "Solid", "L" },
                    { 499, "Magni quasi porro optio neque.", 143, 14535m, "Liquid", "Kg" },
                    { 368, "Harum sed quo repellat pariatur tempore ipsam.", 143, 12106m, "Liquid", "L" },
                    { 360, "Quam nihil porro.", 143, 14932m, "Gas", "Kg" },
                    { 281, "Libero iure ipsam sed nam nobis labore.", 143, 7664m, "Liquid", "Kg" },
                    { 96, "Doloremque velit ex voluptatem laudantium.", 143, 18422m, "Gas", "L" },
                    { 11, "Maxime laborum ut est ut omnis magnam.", 143, 17969m, "Gas", "Kg" },
                    { 349, "Quaerat ut libero.", 132, 13281m, "Solid", "Kg" },
                    { 100, "Corrupti molestias vel unde.", 132, 490m, "Solid", "L" },
                    { 493, "Reiciendis nihil est molestiae.", 126, 12805m, "Liquid", "L" },
                    { 488, "Quaerat dolorum ut magnam excepturi.", 126, 6590m, "Liquid", "L" },
                    { 283, "Non voluptas placeat praesentium officiis voluptatem aut consequatur.", 126, 2975m, "Liquid", "L" },
                    { 229, "Numquam ipsa quia veniam quia voluptatibus.", 126, 9805m, "Liquid", "Kg" },
                    { 215, "Quisquam quae cupiditate voluptas omnis accusamus dolores sit.", 126, 11043m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 463, "Non sit voluptates ipsa perspiciatis occaecati quia qui.", 123, 11411m, "Liquid", "L" },
                    { 375, "Consequatur officia fugiat temporibus.", 149, 2997m, "Liquid", "Kg" },
                    { 327, "Quis numquam adipisci.", 116, 11221m, "Liquid", "Kg" },
                    { 389, "Labore sed libero modi quaerat labore sint ipsum omnis.", 54, 1347m, "Gas", "Kg" },
                    { 284, "Consequatur corrupti quasi ut sint veniam incidunt voluptatem suscipit.", 54, 9167m, "Solid", "L" },
                    { 2, "Ullam rerum quo et amet placeat omnis est et voluptas.", 16, 10787m, "Gas", "Kg" },
                    { 394, "Autem sint incidunt error qui aliquam.", 12, 2006m, "Liquid", "L" },
                    { 383, "Laborum et maxime vitae nisi quisquam dolores atque quia nobis.", 12, 16565m, "Solid", "Kg" },
                    { 290, "Harum qui nulla perferendis ullam autem ab esse occaecati.", 12, 3770m, "Liquid", "Kg" },
                    { 138, "Omnis occaecati possimus tempora et.", 12, 14256m, "Solid", "L" },
                    { 27, "Est incidunt voluptate.", 12, 10955m, "Gas", "L" },
                    { 4, "Fugiat aut assumenda earum.", 12, 13986m, "Solid", "L" },
                    { 472, "Aperiam omnis modi dolor quibusdam similique.", 6, 12128m, "Gas", "Kg" },
                    { 357, "Qui praesentium nemo veritatis incidunt.", 6, 16844m, "Solid", "L" },
                    { 408, "Soluta et ad quos et porro.", 200, 992m, "Gas", "L" },
                    { 147, "Provident quidem impedit qui quis impedit.", 200, 6724m, "Liquid", "Kg" },
                    { 6, "Iste aliquam omnis.", 200, 15221m, "Gas", "Kg" },
                    { 333, "Dolore et ut et expedita libero.", 196, 2593m, "Solid", "Kg" },
                    { 82, "Nisi maxime dolorum iste vel perspiciatis consequuntur voluptatibus rem.", 196, 18017m, "Liquid", "L" },
                    { 75, "In dolorem similique quidem facere cupiditate aspernatur quo rerum nulla.", 30, 6583m, "Gas", "Kg" },
                    { 287, "Nesciunt debitis id ab assumenda consectetur.", 174, 12479m, "Solid", "Kg" },
                    { 107, "Excepturi ullam dolorum optio eveniet tenetur enim dolorum.", 174, 13718m, "Solid", "L" },
                    { 401, "Ratione velit asperiores tempora officiis qui doloremque quo quis voluptatem.", 150, 1831m, "Liquid", "L" },
                    { 140, "Commodi explicabo illum cum dicta voluptas quam.", 150, 374m, "Gas", "L" },
                    { 120, "Omnis dolore dignissimos voluptas reiciendis qui nihil.", 150, 14486m, "Gas", "Kg" },
                    { 312, "Harum fugiat id ut consequatur aliquid enim vel praesentium facilis.", 148, 1150m, "Solid", "L" },
                    { 258, "Ut reiciendis nihil ipsam ut modi voluptatum dolorum sequi est.", 148, 12327m, "Solid", "Kg" },
                    { 55, "Perspiciatis doloremque at rerum molestiae.", 142, 16871m, "Solid", "L" },
                    { 33, "Cupiditate reiciendis facilis sed.", 142, 16627m, "Liquid", "L" },
                    { 441, "Illum quibusdam quaerat ea doloremque.", 137, 17171m, "Liquid", "Kg" },
                    { 332, "Illo maxime laboriosam ad voluptas accusamus.", 137, 19729m, "Solid", "Kg" },
                    { 249, "Ea dolore nisi et totam incidunt quos inventore.", 137, 1243m, "Liquid", "Kg" },
                    { 445, "Distinctio perferendis tempora ut et aliquid explicabo et.", 124, 6733m, "Solid", "Kg" },
                    { 460, "Et dolorem reprehenderit nostrum quas doloribus totam nesciunt inventore expedita.", 116, 9149m, "Liquid", "L" },
                    { 454, "Voluptas et nemo autem eum molestiae aperiam esse ullam.", 116, 9328m, "Liquid", "L" },
                    { 267, "Omnis alias ducimus quo autem reprehenderit cum rem.", 174, 8983m, "Liquid", "L" },
                    { 294, "Aut quis eaque eius deserunt necessitatibus consequatur.", 54, 4645m, "Liquid", "L" },
                    { 108, "Est tenetur doloribus.", 30, 18547m, "Solid", "L" },
                    { 228, "Iure atque neque laboriosam magni similique autem omnis.", 34, 19243m, "Liquid", "Kg" },
                    { 130, "Architecto quo omnis est.", 54, 17990m, "Liquid", "Kg" },
                    { 431, "Mollitia ex provident iusto est in voluptates totam sit qui.", 52, 4474m, "Solid", "Kg" },
                    { 189, "Eaque consequatur in amet.", 52, 13039m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 177, "Saepe sed repudiandae dicta recusandae.", 52, 16620m, "Solid", "L" },
                    { 126, "Ex explicabo voluptatum laboriosam sit sunt nesciunt atque non.", 52, 1025m, "Solid", "Kg" },
                    { 494, "Ducimus enim quaerat voluptate ut quas quia cum voluptatum.", 48, 18248m, "Gas", "Kg" },
                    { 399, "Nam aspernatur sed aut aut aliquid deleniti.", 48, 7774m, "Solid", "Kg" },
                    { 193, "Aut totam dolore ipsum sit ut enim eos.", 48, 19254m, "Liquid", "L" },
                    { 495, "Quo dignissimos qui voluptate harum quae sequi ducimus.", 47, 19170m, "Solid", "Kg" },
                    { 436, "Et modi id sed.", 47, 7402m, "Liquid", "L" },
                    { 129, "Cupiditate tempora provident error qui id aut aperiam soluta consequuntur.", 47, 7589m, "Solid", "Kg" },
                    { 474, "Velit voluptas veniam odit sequi et.", 43, 2337m, "Liquid", "L" },
                    { 469, "Quis dicta ut et.", 43, 9732m, "Liquid", "Kg" },
                    { 176, "Voluptas quasi totam ut neque officiis nisi quasi quia.", 43, 6475m, "Liquid", "Kg" },
                    { 241, "Eos error eum pariatur nisi possimus.", 30, 2044m, "Gas", "Kg" },
                    { 119, "Voluptate ea eius.", 43, 12745m, "Liquid", "L" },
                    { 427, "Sit voluptatem totam repellat in reiciendis esse fugiat.", 37, 5182m, "Solid", "L" },
                    { 265, "Itaque et ut repellat quia voluptatem sint aut.", 37, 3938m, "Solid", "Kg" },
                    { 239, "Vero atque quia consequatur cum.", 37, 5849m, "Liquid", "L" },
                    { 46, "Ducimus doloremque porro dignissimos dolorem quia ut nihil.", 37, 11522m, "Gas", "Kg" },
                    { 295, "Non doloremque ut beatae quis mollitia ut repudiandae nemo.", 36, 9541m, "Gas", "L" },
                    { 273, "Earum fugiat omnis sint in quam occaecati animi ea aut.", 36, 11335m, "Solid", "Kg" },
                    { 192, "Nemo soluta commodi sapiente blanditiis reprehenderit omnis.", 36, 786m, "Liquid", "Kg" },
                    { 161, "Fuga a vel id porro doloribus.", 36, 2448m, "Solid", "L" },
                    { 133, "Voluptate dolores dicta quia consequuntur numquam officiis laboriosam.", 36, 2252m, "Solid", "L" },
                    { 91, "Suscipit et vel et eum tenetur adipisci itaque.", 36, 2935m, "Liquid", "L" },
                    { 344, "Aliquid delectus laudantium et qui laboriosam magnam nesciunt molestias.", 35, 8753m, "Solid", "L" },
                    { 262, "Tempore molestias placeat omnis nam quaerat perferendis.", 35, 11036m, "Liquid", "Kg" },
                    { 38, "Molestiae vel nemo.", 35, 10946m, "Gas", "L" },
                    { 453, "Ea qui reprehenderit est eius provident est voluptatem quam.", 34, 16926m, "Solid", "Kg" },
                    { 25, "Id doloribus incidunt eveniet quia officiis consequatur a in laboriosam.", 43, 12634m, "Solid", "L" },
                    { 329, "Facilis dolores cumque.", 195, 10922m, "Solid", "Kg" },
                    { 365, "Ipsam omnis veniam est error cumque molestiae dolores nemo.", 94, 7138m, "Liquid", "Kg" },
                    { 21, "Reiciendis dolore vel officia nihil ex suscipit corporis.", 195, 7540m, "Solid", "L" },
                    { 373, "Quos quidem asperiores voluptates.", 20, 8546m, "Gas", "L" },
                    { 103, "Sit est voluptas dolorum accusamus suscipit doloremque.", 22, 186m, "Solid", "L" },
                    { 323, "Eos alias consequatur deserunt numquam voluptatibus eveniet tempore dolorem.", 22, 7531m, "Solid", "Kg" },
                    { 351, "Ipsum et eum fugiat aperiam blanditiis qui ullam.", 22, 716m, "Gas", "L" },
                    { 158, "Facilis omnis fugiat sint corporis beatae quasi qui itaque.", 27, 6770m, "Solid", "Kg" },
                    { 489, "Ullam tempora ducimus fugit.", 27, 10454m, "Liquid", "Kg" },
                    { 29, "Quas modi quasi voluptas sapiente.", 28, 784m, "Liquid", "L" },
                    { 80, "Blanditiis et cumque eaque et ducimus enim aut.", 20, 6705m, "Liquid", "L" },
                    { 58, "Consectetur facere sint autem.", 28, 8335m, "Gas", "L" },
                    { 218, "Accusantium aliquam dolores autem rerum eius occaecati qui accusamus optio.", 28, 3961m, "Liquid", "Kg" },
                    { 266, "Eos voluptas ea consequatur pariatur doloribus in.", 28, 4322m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 121, "Veritatis dolor dolorem.", 31, 6227m, "Gas", "L" },
                    { 83, "Temporibus ipsum voluptatem voluptas expedita reiciendis.", 32, 2823m, "Gas", "L" },
                    { 51, "Laudantium ab atque magni tempora quas praesentium in.", 33, 8972m, "Liquid", "Kg" },
                    { 54, "Debitis facere sed molestiae quasi nihil omnis.", 33, 4263m, "Solid", "L" },
                    { 61, "Molestias nihil qui libero distinctio.", 33, 13930m, "Gas", "Kg" },
                    { 145, "Tempore aut rerum expedita est sed tenetur occaecati.", 28, 16313m, "Solid", "L" },
                    { 361, "Nesciunt optio dignissimos eaque.", 33, 15303m, "Gas", "L" },
                    { 78, "Autem harum illum ut natus est molestiae omnis tempore sit.", 20, 13651m, "Liquid", "L" },
                    { 313, "Cumque natus a beatae.", 14, 12848m, "Gas", "Kg" },
                    { 154, "Tempora dolores totam.", 188, 2295m, "Solid", "Kg" },
                    { 346, "Expedita nam aut magnam aut mollitia ut sint iusto.", 188, 16526m, "Solid", "L" },
                    { 411, "Nulla sint et deserunt rerum tempore ex.", 188, 6227m, "Gas", "Kg" },
                    { 459, "In voluptatibus voluptates voluptate ut optio non incidunt.", 188, 2326m, "Liquid", "L" },
                    { 95, "Quaerat eos dolor blanditiis vel ad optio corrupti atque.", 2, 10969m, "Liquid", "Kg" },
                    { 434, "Reprehenderit rerum sit.", 2, 12875m, "Liquid", "L" },
                    { 442, "Laborum voluptatem libero labore temporibus dignissimos molestias iste.", 2, 2807m, "Gas", "Kg" },
                    { 432, "Quaerat harum vitae reiciendis id voluptatum autem.", 14, 14948m, "Gas", "L" },
                    { 500, "Voluptate sunt et adipisci nostrum eos sit in.", 2, 4185m, "Gas", "Kg" },
                    { 388, "Possimus culpa excepturi et atque.", 3, 11355m, "Gas", "Kg" },
                    { 392, "Quia illo sequi non alias quo amet.", 3, 2740m, "Solid", "Kg" },
                    { 429, "Aperiam in dolor qui molestiae architecto quod ipsa consequatur.", 3, 9506m, "Solid", "Kg" },
                    { 497, "Mollitia optio dolores suscipit maxime debitis voluptas veniam.", 3, 18818m, "Solid", "Kg" },
                    { 235, "Dolores expedita sit qui illo.", 13, 17124m, "Gas", "L" },
                    { 101, "Omnis ullam ullam ab maxime perferendis tempora autem tempore.", 14, 16527m, "Liquid", "Kg" },
                    { 180, "Mollitia recusandae fuga quia nihil quia non voluptas reprehenderit.", 14, 15964m, "Gas", "Kg" },
                    { 74, "Aperiam occaecati et.", 3, 1070m, "Gas", "L" },
                    { 372, "Facere non et laborum et qui sed doloremque.", 33, 16376m, "Gas", "Kg" },
                    { 380, "Illum pariatur laudantium laboriosam voluptatem optio vel porro qui.", 33, 18800m, "Liquid", "L" },
                    { 449, "Sunt distinctio alias repellat vitae.", 33, 9009m, "Solid", "L" },
                    { 84, "Tempora et corrupti dolorum aut sunt amet iste et.", 97, 2072m, "Gas", "L" },
                    { 240, "Incidunt aut deserunt omnis ut doloribus a cumque.", 97, 302m, "Gas", "Kg" },
                    { 288, "Et et dolorem dicta.", 97, 7972m, "Gas", "Kg" },
                    { 299, "Saepe maxime veniam voluptate nam et aspernatur nemo maxime voluptas.", 97, 11893m, "Solid", "Kg" },
                    { 498, "Voluptates natus asperiores et laborum alias ex dolor quia illum.", 97, 3147m, "Solid", "L" },
                    { 187, "Quam odit quos possimus ex tempora illum nisi dolorem quas.", 101, 15766m, "Gas", "L" },
                    { 212, "Eveniet ut tempore.", 101, 15536m, "Liquid", "L" },
                    { 256, "Ut maxime aliquam pariatur neque.", 74, 6610m, "Gas", "L" },
                    { 233, "Repellendus veritatis sint id.", 101, 4725m, "Solid", "Kg" },
                    { 115, "Alias eum distinctio.", 106, 18060m, "Gas", "Kg" },
                    { 202, "Ad occaecati eos sed et quis sit aut voluptates.", 109, 9773m, "Gas", "Kg" },
                    { 302, "Et minus accusantium sed et.", 109, 18480m, "Solid", "L" },
                    { 330, "Ea voluptates sint vero omnis aut.", 109, 17024m, "Solid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 155, "Quis sit et qui consectetur.", 110, 37m, "Liquid", "Kg" },
                    { 220, "Sint mollitia in consectetur rerum aut repellat et eveniet.", 110, 5202m, "Gas", "L" },
                    { 307, "Aut eum vitae aspernatur blanditiis quo iure reprehenderit.", 110, 9379m, "Solid", "Kg" },
                    { 338, "Voluptatem quidem doloremque vel suscipit velit ut.", 101, 5887m, "Liquid", "L" },
                    { 152, "Adipisci beatae inventore et esse nostrum possimus eveniet est.", 74, 6995m, "Gas", "L" },
                    { 324, "Autem sit cum iusto numquam eum.", 72, 16052m, "Solid", "Kg" },
                    { 170, "Dolores ab non assumenda.", 72, 11939m, "Solid", "Kg" },
                    { 255, "Vel eos dolorem est architecto voluptatum.", 38, 5483m, "Liquid", "Kg" },
                    { 355, "Laborum dolorum ea aut similique.", 38, 10337m, "Solid", "Kg" },
                    { 475, "Aut laboriosam laboriosam facere sit ipsum.", 38, 2835m, "Gas", "L" },
                    { 16, "Labore officia omnis enim.", 39, 11176m, "Gas", "Kg" },
                    { 251, "Occaecati incidunt non molestiae aut autem enim quia minus et.", 39, 5390m, "Gas", "L" },
                    { 422, "Eum doloremque dolorem molestiae blanditiis id facilis vitae at at.", 39, 2772m, "Liquid", "L" },
                    { 10, "Minima aliquid vel rerum provident quos qui excepturi corporis velit.", 46, 8128m, "Gas", "Kg" },
                    { 339, "Autem exercitationem harum ea.", 46, 15406m, "Solid", "L" },
                    { 186, "Rerum officiis minima iste corrupti numquam debitis.", 49, 14107m, "Liquid", "L" },
                    { 285, "Reiciendis quisquam placeat.", 49, 6978m, "Liquid", "Kg" },
                    { 293, "Eum asperiores aut sunt.", 49, 6426m, "Gas", "L" },
                    { 316, "Et ut quisquam illum veritatis ut voluptas quaerat asperiores.", 49, 17533m, "Solid", "Kg" },
                    { 492, "Doloribus aut consequatur recusandae alias praesentium.", 49, 8462m, "Solid", "Kg" },
                    { 8, "Qui voluptas exercitationem.", 61, 353m, "Liquid", "Kg" },
                    { 136, "Et voluptatem nulla deserunt incidunt qui ad repudiandae dicta incidunt.", 61, 19735m, "Solid", "L" },
                    { 188, "Dolores quia tempora.", 61, 13581m, "Liquid", "L" },
                    { 79, "Nostrum facere rem illum enim et ipsum.", 72, 1544m, "Gas", "Kg" },
                    { 195, "Architecto fuga enim.", 179, 13541m, "Solid", "L" },
                    { 274, "Nam quasi quis aut id.", 112, 14883m, "Gas", "Kg" },
                    { 386, "Voluptate voluptas aut modi provident.", 177, 11453m, "Gas", "Kg" },
                    { 118, "Eaque maxime cum quibusdam repudiandae minima impedit tempora repellendus.", 177, 17330m, "Liquid", "Kg" },
                    { 67, "Voluptas alias fuga voluptas atque aut ut.", 67, 817m, "Solid", "L" },
                    { 340, "Aperiam dolore tempore ut.", 67, 15852m, "Gas", "Kg" },
                    { 148, "Eum animi corrupti expedita omnis qui id autem.", 68, 4779m, "Gas", "L" },
                    { 44, "Quo nemo deleniti optio illo.", 69, 6054m, "Gas", "Kg" },
                    { 369, "Ipsum sunt reprehenderit commodi quod ullam.", 69, 14052m, "Gas", "Kg" },
                    { 478, "Omnis sit velit voluptatibus ut.", 71, 16370m, "Solid", "Kg" },
                    { 23, "Et in possimus delectus maxime aut possimus perferendis.", 80, 11064m, "Solid", "Kg" },
                    { 491, "Doloremque fuga placeat.", 57, 10738m, "Liquid", "L" },
                    { 278, "Rem sint dicta vero deserunt.", 80, 8417m, "Solid", "Kg" },
                    { 291, "Sit ea tempore eos ratione quia et consequatur qui explicabo.", 82, 1695m, "Solid", "Kg" },
                    { 417, "Aliquid quibusdam eum culpa.", 82, 19482m, "Liquid", "Kg" },
                    { 439, "Ea iusto vero.", 82, 5388m, "Solid", "L" },
                    { 142, "Sunt voluptatem unde explicabo laboriosam.", 83, 18841m, "Solid", "L" },
                    { 167, "Sed sit soluta quia corrupti quasi eius consequatur.", 83, 17246m, "Solid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 322, "Eius odit velit dolores dolore aut non.", 83, 19282m, "Gas", "L" },
                    { 481, "Excepturi facilis quod.", 83, 6451m, "Gas", "L" },
                    { 415, "Labore voluptatem earum magni.", 80, 1939m, "Liquid", "L" },
                    { 490, "Minus laboriosam harum molestias culpa et.", 83, 3998m, "Solid", "Kg" },
                    { 310, "Ad quia laborum perspiciatis eligendi natus fugit.", 57, 7793m, "Gas", "L" },
                    { 39, "Maxime enim impedit soluta nesciunt a dolor.", 57, 9001m, "Liquid", "L" },
                    { 184, "Dolorum velit quo similique sunt voluptates facilis magni.", 10, 13473m, "Gas", "L" },
                    { 28, "Ut qui consequatur voluptate natus dolorem et corrupti.", 19, 667m, "Liquid", "Kg" },
                    { 227, "Eligendi laborum sed nisi facere odio.", 19, 9103m, "Solid", "Kg" },
                    { 269, "Assumenda rerum voluptatum.", 21, 10122m, "Liquid", "L" },
                    { 337, "Laboriosam officia quo est sapiente dolor adipisci voluptatem sit ut.", 21, 5349m, "Gas", "Kg" },
                    { 160, "Incidunt perspiciatis omnis quas et.", 23, 4660m, "Solid", "Kg" },
                    { 231, "Ipsum deleniti itaque a voluptas quis cupiditate dolores omnis.", 23, 2550m, "Liquid", "L" },
                    { 76, "Cumque et delectus asperiores quia et ullam saepe delectus nisi.", 57, 19972m, "Liquid", "Kg" },
                    { 319, "Ducimus velit sit ipsum illo nesciunt deserunt illo.", 23, 12597m, "Solid", "L" },
                    { 363, "Illum nihil et.", 41, 4219m, "Gas", "Kg" },
                    { 156, "Temporibus exercitationem et quibusdam inventore sunt.", 42, 14127m, "Gas", "L" },
                    { 301, "Nobis ut et eum sit voluptates ratione autem et.", 42, 11852m, "Solid", "L" },
                    { 280, "Quae enim iste provident.", 44, 16852m, "Solid", "L" },
                    { 304, "Deserunt voluptatibus mollitia totam voluptatum error.", 44, 17106m, "Gas", "Kg" },
                    { 397, "Et molestiae consectetur sapiente possimus et dolores est.", 44, 14773m, "Gas", "L" },
                    { 104, "Accusantium officiis rerum sint ipsum.", 53, 16691m, "Solid", "L" },
                    { 356, "Sint rem aliquid accusantium alias similique a voluptatum repudiandae voluptatibus.", 41, 3275m, "Liquid", "L" },
                    { 342, "Quidem in voluptatem omnis.", 88, 18192m, "Gas", "Kg" },
                    { 461, "Aut est quibusdam.", 88, 1802m, "Gas", "L" },
                    { 69, "Et tenetur aut qui ipsa et.", 91, 9780m, "Liquid", "Kg" },
                    { 98, "Qui optio voluptatem ipsa similique.", 134, 9960m, "Gas", "Kg" },
                    { 334, "Doloremque error ipsam maiores tempore libero.", 134, 6225m, "Gas", "Kg" },
                    { 457, "Architecto rerum sunt et quia doloribus inventore eos deserunt quo.", 135, 18702m, "Liquid", "Kg" },
                    { 50, "Non repellat repellat ex eos occaecati illo quos qui iste.", 141, 11369m, "Solid", "L" },
                    { 144, "Quam et autem tenetur saepe corporis voluptas vel.", 141, 280m, "Solid", "L" },
                    { 185, "Sint ipsum labore quidem consequuntur voluptatem est.", 141, 8875m, "Solid", "L" },
                    { 18, "Porro sed atque sunt quaerat laboriosam rerum est dolores aut.", 145, 17145m, "Gas", "L" },
                    { 77, "Tempore magnam saepe temporibus ipsa veniam dolore pariatur.", 134, 5363m, "Liquid", "L" },
                    { 72, "Ab dicta aut consectetur eligendi ipsam.", 145, 5314m, "Solid", "L" },
                    { 93, "Et distinctio velit et libero rerum aut aut deserunt eveniet.", 146, 15254m, "Gas", "Kg" },
                    { 116, "Repellendus et ipsa.", 146, 2493m, "Solid", "Kg" },
                    { 211, "Voluptate voluptatem sunt sit consectetur ipsa beatae temporibus.", 146, 8070m, "Liquid", "L" },
                    { 222, "Ipsam eveniet ut.", 146, 2403m, "Solid", "L" },
                    { 68, "Facere repellat ipsum sit ratione nemo dolorum qui explicabo tempore.", 160, 9620m, "Solid", "Kg" },
                    { 424, "Cumque tempore tenetur et laboriosam iste molestias laboriosam.", 160, 10149m, "Liquid", "L" },
                    { 49, "Omnis quia dicta et assumenda ipsum enim.", 177, 12427m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 110, "Quam eum vitae.", 145, 150m, "Solid", "L" },
                    { 52, "Tempora ad non porro.", 134, 17685m, "Liquid", "Kg" },
                    { 261, "Praesentium repellendus et officiis id perferendis consequatur ratione.", 129, 11655m, "Gas", "Kg" },
                    { 236, "A beatae reiciendis hic eligendi officiis eaque accusantium dolores doloremque.", 129, 12655m, "Gas", "L" },
                    { 86, "Nesciunt quo eum quibusdam vero quas quo.", 91, 14213m, "Gas", "L" },
                    { 166, "Totam placeat harum.", 91, 15848m, "Gas", "Kg" },
                    { 260, "Libero fugiat quasi.", 91, 5856m, "Solid", "L" },
                    { 477, "Velit numquam quibusdam aperiam impedit ut fugit.", 91, 12572m, "Liquid", "Kg" },
                    { 268, "Consectetur quo libero placeat quas voluptas cumque vel.", 113, 6843m, "Solid", "L" },
                    { 124, "Voluptas illum debitis quia consequatur ut voluptatum quia ipsum sint.", 120, 17857m, "Gas", "Kg" },
                    { 387, "Eveniet consectetur unde enim reprehenderit.", 120, 2513m, "Liquid", "Kg" },
                    { 447, "Explicabo corrupti rerum.", 120, 16220m, "Liquid", "L" },
                    { 452, "Ipsum dolorem perspiciatis aut perferendis eaque.", 120, 16683m, "Liquid", "L" },
                    { 47, "Deleniti provident ipsa ex dolorum tempora dicta consequuntur qui sed.", 121, 17952m, "Liquid", "L" },
                    { 275, "Ipsam natus molestiae dolor ut nihil eos quisquam rerum eius.", 121, 9504m, "Gas", "Kg" },
                    { 433, "Assumenda excepturi autem ut.", 121, 3714m, "Gas", "Kg" },
                    { 32, "Laboriosam eius eligendi.", 122, 378m, "Gas", "Kg" },
                    { 66, "Aspernatur aliquid incidunt ipsa recusandae.", 122, 10166m, "Liquid", "L" },
                    { 122, "Sed vero est ut tempore praesentium quo et consequuntur sit.", 122, 13313m, "Liquid", "Kg" },
                    { 159, "Saepe doloribus et consectetur molestiae odio.", 122, 17883m, "Solid", "Kg" },
                    { 17, "Autem iure et.", 129, 15430m, "Gas", "Kg" },
                    { 370, "Nisi commodi at.", 177, 15270m, "Liquid", "L" },
                    { 45, "Voluptatum maxime cupiditate aut et pariatur et praesentium sunt.", 117, 7048m, "Gas", "L" },
                    { 60, "Rerum voluptas vel.", 117, 17815m, "Gas", "Kg" },
                    { 197, "Et tempore aliquam tenetur est.", 117, 7811m, "Solid", "L" },
                    { 71, "Sint doloribus maiores voluptatum sunt.", 107, 10381m, "Solid", "Kg" },
                    { 425, "Sapiente earum consectetur qui.", 107, 6899m, "Liquid", "L" },
                    { 382, "Accusantium inventore dolores similique quam consequatur tenetur molestiae magni reiciendis.", 114, 7902m, "Liquid", "Kg" },
                    { 430, "Optio fuga voluptatum corrupti.", 114, 8742m, "Liquid", "L" },
                    { 467, "Non in esse impedit tempora aut.", 114, 11448m, "Solid", "Kg" },
                    { 416, "Dicta enim similique optio similique qui dolorem omnis ut.", 118, 7873m, "Liquid", "Kg" },
                    { 63, "Non beatae ullam eum vel vel eos fuga non ipsum.", 119, 5692m, "Liquid", "L" },
                    { 353, "Itaque dolorem nobis officiis odit aut.", 103, 17430m, "Liquid", "L" },
                    { 65, "Iusto inventore eos qui adipisci voluptatem reiciendis perferendis.", 119, 15441m, "Solid", "L" },
                    { 378, "Et et sed omnis laboriosam reiciendis quibusdam et est.", 119, 18073m, "Solid", "Kg" },
                    { 438, "At modi est dolorum debitis veniam.", 119, 11384m, "Liquid", "Kg" },
                    { 325, "Voluptatem nam facere similique quasi corporis molestiae alias ut.", 128, 5967m, "Liquid", "L" },
                    { 20, "Doloribus aliquam perferendis sint cumque aspernatur sint.", 133, 19542m, "Solid", "L" },
                    { 26, "Corporis mollitia dicta.", 133, 11826m, "Solid", "L" },
                    { 111, "Amet quisquam autem sit mollitia provident optio maxime rerum.", 136, 3522m, "Liquid", "L" },
                    { 213, "Ipsum excepturi est quod pariatur mollitia id adipisci non.", 136, 14544m, "Solid", "Kg" },
                    { 216, "Aut ea officia laboriosam.", 119, 8940m, "Solid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 421, "Omnis distinctio est debitis.", 136, 9647m, "Gas", "L" },
                    { 178, "Tempore est quos rerum enim id.", 103, 9207m, "Liquid", "L" },
                    { 410, "Sit esse debitis non rem non.", 99, 16196m, "Liquid", "L" },
                    { 407, "Ea totam unde hic et molestias.", 70, 6315m, "Liquid", "L" },
                    { 419, "Quia quia aut et quia quis provident quia.", 70, 3028m, "Solid", "L" },
                    { 476, "Amet tenetur sed aut.", 70, 4979m, "Gas", "Kg" },
                    { 244, "Quod odio nulla voluptas doloribus ut et nulla.", 86, 8838m, "Solid", "Kg" },
                    { 9, "Quis illum cum itaque recusandae.", 94, 4181m, "Solid", "Kg" },
                    { 53, "Omnis itaque enim velit sed omnis modi id natus.", 94, 4458m, "Solid", "Kg" },
                    { 99, "Nemo mollitia at dolor quos.", 94, 16341m, "Solid", "L" },
                    { 81, "Quidem dicta alias incidunt non molestiae rerum aut.", 103, 12937m, "Liquid", "L" },
                    { 217, "Ducimus rerum eos necessitatibus.", 94, 17241m, "Solid", "Kg" },
                    { 41, "Non qui et qui dolore qui sunt quam aliquam et.", 95, 1368m, "Gas", "L" },
                    { 88, "Eius est atque dolorum odit.", 95, 12231m, "Gas", "Kg" },
                    { 237, "Nihil et est commodi.", 95, 2037m, "Liquid", "L" },
                    { 24, "Quia quae maiores mollitia eos sed veniam neque sapiente nisi.", 96, 2101m, "Liquid", "Kg" },
                    { 296, "Qui ipsa quidem maxime repellendus.", 99, 9715m, "Gas", "Kg" },
                    { 298, "Voluptates corrupti blanditiis.", 99, 19242m, "Liquid", "Kg" },
                    { 303, "Sit voluptatem velit nisi.", 99, 8239m, "Gas", "L" },
                    { 437, "Consequatur eum eaque quia expedita et ut et doloribus et.", 94, 6645m, "Gas", "L" },
                    { 471, "Numquam culpa vel nostrum natus necessitatibus sunt eos.", 136, 8389m, "Solid", "Kg" },
                    { 37, "At commodi vel ad voluptatem delectus perspiciatis cum voluptatem.", 147, 3417m, "Gas", "Kg" },
                    { 271, "Nemo eveniet occaecati quisquam.", 147, 13183m, "Liquid", "Kg" },
                    { 141, "Soluta quasi quasi voluptatum quas ex sed odit quia voluptate.", 168, 4068m, "Gas", "L" },
                    { 157, "Quod sunt esse.", 169, 3359m, "Gas", "L" },
                    { 70, "Dolores magni et laborum et accusantium in nesciunt.", 175, 11897m, "Liquid", "Kg" },
                    { 404, "Provident voluptatem sunt rem eos et laborum illo cupiditate minima.", 175, 8712m, "Gas", "Kg" },
                    { 412, "Natus maiores nisi et.", 175, 5355m, "Gas", "Kg" },
                    { 482, "Asperiores minima dolores.", 178, 18643m, "Solid", "L" },
                    { 403, "Similique in deserunt quisquam sed eum voluptatem corrupti neque omnis.", 181, 15695m, "Liquid", "Kg" },
                    { 486, "Rem consequuntur nulla et ut sunt est.", 166, 10003m, "Solid", "Kg" },
                    { 458, "Inventore earum et atque nobis aliquid doloribus in fugit.", 181, 4376m, "Liquid", "L" },
                    { 484, "Est aliquid exercitationem sit nihil provident qui voluptas.", 181, 14482m, "Liquid", "L" },
                    { 42, "Eveniet accusamus dignissimos quia qui nisi in.", 183, 19273m, "Solid", "Kg" },
                    { 320, "Sint qui in id.", 183, 1111m, "Liquid", "Kg" },
                    { 465, "Voluptatem mollitia voluptas.", 183, 4634m, "Gas", "Kg" },
                    { 128, "Ea voluptas ab velit.", 191, 16513m, "Liquid", "Kg" },
                    { 73, "Vel corrupti voluptatem deleniti assumenda qui.", 193, 17454m, "Liquid", "L" },
                    { 137, "Rerum omnis doloribus.", 193, 15691m, "Liquid", "Kg" },
                    { 479, "Enim qui incidunt.", 181, 2742m, "Solid", "Kg" },
                    { 286, "Inventore quis magnam eos sint aut dignissimos quasi.", 166, 8605m, "Gas", "L" },
                    { 109, "Fugiat eius qui aut quisquam quae vitae id nostrum nulla.", 165, 2301m, "Solid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 379, "Sit voluptatem maiores rerum unde molestiae fuga suscipit.", 162, 7590m, "Solid", "L" },
                    { 364, "Qui ex itaque eos qui asperiores illo autem.", 147, 8865m, "Gas", "Kg" },
                    { 30, "Veniam et sint dolorum libero quo voluptas nesciunt eveniet et.", 152, 11855m, "Solid", "Kg" },
                    { 56, "Illum doloremque delectus optio ex nulla qui.", 152, 18835m, "Gas", "Kg" },
                    { 238, "Dicta magni quae amet nobis vel.", 152, 18572m, "Solid", "Kg" },
                    { 276, "Et magni odit suscipit.", 152, 4903m, "Gas", "L" },
                    { 371, "Quo reprehenderit inventore illum voluptatem fugit voluptatem dolores.", 152, 6272m, "Liquid", "L" },
                    { 448, "In doloremque velit nisi.", 152, 1677m, "Solid", "L" },
                    { 468, "Dolorem officiis explicabo commodi.", 152, 12566m, "Solid", "L" },
                    { 470, "Architecto libero et et omnis repellendus temporibus rerum qui.", 152, 18471m, "Gas", "L" },
                    { 43, "Veritatis cumque consequatur qui.", 154, 17862m, "Liquid", "L" },
                    { 162, "Consequuntur ut soluta.", 154, 8535m, "Gas", "L" },
                    { 179, "Corrupti porro molestiae amet.", 154, 4962m, "Solid", "Kg" },
                    { 317, "Id unde minima magnam exercitationem quo et.", 154, 16785m, "Liquid", "L" },
                    { 15, "Repellendus facilis facilis nostrum sunt id eaque.", 156, 19436m, "Gas", "L" },
                    { 153, "Possimus non architecto nesciunt provident.", 156, 8769m, "Liquid", "Kg" },
                    { 242, "Voluptatem modi expedita.", 162, 15975m, "Gas", "L" },
                    { 305, "Quidem incidunt nam.", 162, 11268m, "Solid", "Kg" },
                    { 174, "Qui quisquam corrupti natus.", 70, 3717m, "Liquid", "Kg" },
                    { 134, "Aliquam possimus cupiditate quam ipsum quibusdam ut delectus exercitationem sed.", 70, 2298m, "Gas", "L" },
                    { 22, "Ea asperiores optio et fugit quo neque.", 70, 13438m, "Solid", "L" },
                    { 232, "Aut repudiandae et.", 63, 15203m, "Gas", "L" },
                    { 326, "Consequatur necessitatibus dignissimos quis voluptas est.", 163, 1865m, "Liquid", "Kg" },
                    { 409, "Aperiam veniam praesentium.", 163, 7405m, "Liquid", "Kg" },
                    { 420, "Dolorem officia sit ut sapiente nihil odio.", 163, 9234m, "Liquid", "Kg" },
                    { 428, "Sit perspiciatis tenetur similique possimus commodi quis repudiandae repellendus.", 163, 4890m, "Solid", "L" },
                    { 485, "Corporis eum necessitatibus.", 163, 15568m, "Gas", "Kg" },
                    { 31, "Odio deleniti aspernatur mollitia iste sunt.", 164, 11480m, "Liquid", "L" },
                    { 203, "Voluptatem id est error.", 164, 1445m, "Liquid", "L" },
                    { 306, "Necessitatibus et neque qui.", 163, 19265m, "Gas", "Kg" },
                    { 359, "Rerum et dolores inventore sit velit.", 164, 2727m, "Gas", "Kg" },
                    { 487, "Et est culpa est impedit nihil esse.", 170, 16703m, "Liquid", "Kg" },
                    { 341, "Libero et dolor voluptas ab quae voluptatem occaecati quibusdam porro.", 173, 16004m, "Solid", "Kg" },
                    { 406, "Harum aut amet.", 173, 13140m, "Liquid", "Kg" },
                    { 435, "Qui voluptas odio ut saepe.", 173, 4547m, "Gas", "L" },
                    { 473, "Voluptatem enim sunt maxime.", 173, 10458m, "Liquid", "L" },
                    { 221, "Omnis consequatur illum.", 180, 12554m, "Solid", "Kg" },
                    { 336, "Ipsum dolor veritatis provident voluptas aut quis.", 180, 13603m, "Solid", "Kg" },
                    { 381, "Quas est omnis maxime placeat soluta.", 170, 5346m, "Gas", "Kg" },
                    { 321, "Aperiam tenetur voluptas rerum neque nesciunt soluta ducimus tempora.", 158, 13558m, "Solid", "Kg" },
                    { 106, "Architecto nisi consectetur et illo perspiciatis ducimus temporibus unde cupiditate.", 158, 12472m, "Solid", "Kg" },
                    { 402, "Nostrum aliquid non reiciendis sed praesentium placeat quia repellat.", 144, 17356m, "Solid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 219, "Assumenda ut assumenda quisquam.", 117, 19878m, "Gas", "Kg" },
                    { 259, "Est voluptatum maiores voluptatem.", 117, 9204m, "Liquid", "L" },
                    { 123, "Et ex quasi corporis reiciendis aut veritatis occaecati odio optio.", 125, 10275m, "Liquid", "L" },
                    { 127, "Quis quos vitae a dolor ut.", 125, 15680m, "Solid", "Kg" },
                    { 139, "Repellendus animi qui voluptas quia tempore.", 125, 4690m, "Liquid", "Kg" },
                    { 272, "Vel et recusandae non iure rerum.", 125, 2438m, "Liquid", "L" },
                    { 314, "Doloribus fugit inventore.", 125, 8693m, "Gas", "Kg" },
                    { 117, "Quaerat et et animi.", 127, 6940m, "Solid", "L" },
                    { 150, "Et dignissimos voluptas et.", 130, 5994m, "Solid", "L" },
                    { 151, "Praesentium rerum laudantium ipsa.", 130, 5692m, "Liquid", "Kg" },
                    { 210, "Dignissimos tempore est dolorem.", 130, 2150m, "Solid", "L" },
                    { 352, "Ratione molestiae at officiis consectetur velit optio et id.", 130, 19652m, "Liquid", "Kg" },
                    { 209, "Ea voluptatem rerum cupiditate nam repellat.", 131, 7882m, "Liquid", "Kg" },
                    { 190, "Nesciunt aliquam eius voluptatem non perferendis sunt porro.", 138, 17724m, "Solid", "Kg" },
                    { 223, "Impedit dignissimos et eligendi minima quae rerum sit.", 140, 18680m, "Solid", "L" },
                    { 253, "Cumque sapiente voluptas ducimus qui fugit deserunt.", 140, 795m, "Gas", "Kg" },
                    { 226, "Enim sed labore omnis nesciunt ullam.", 144, 957m, "Solid", "L" },
                    { 426, "Tempore qui est qui cupiditate non.", 180, 3280m, "Solid", "Kg" },
                    { 200, "Quisquam doloremque et.", 195, 8638m, "Solid", "Kg" },
                    { 13, "Debitis voluptatibus repellat distinctio officiis quia officia quis nihil.", 185, 3811m, "Gas", "L" },
                    { 423, "Nisi animi corrupti consequatur et quia et molestias saepe omnis.", 185, 6883m, "Gas", "L" },
                    { 143, "Unde fugiat eum natus eaque quae est est est porro.", 40, 5111m, "Liquid", "Kg" },
                    { 358, "Atque ea eos aut asperiores.", 40, 17079m, "Gas", "L" },
                    { 225, "Fugit consequuntur atque.", 45, 5658m, "Liquid", "L" },
                    { 247, "Magnam omnis incidunt enim omnis quo consequatur natus.", 45, 17328m, "Liquid", "Kg" },
                    { 94, "Non sed in sequi qui sequi ea quisquam.", 50, 19051m, "Liquid", "L" },
                    { 198, "Tempore voluptatem a saepe nobis eum quis.", 50, 2034m, "Solid", "Kg" },
                    { 48, "Adipisci debitis facere dolores.", 51, 1570m, "Liquid", "L" },
                    { 354, "Quidem non alias ea dolor occaecati inventore qui.", 24, 7346m, "Solid", "L" },
                    { 85, "Omnis consequatur eligendi neque.", 51, 3747m, "Solid", "Kg" },
                    { 208, "Necessitatibus exercitationem ut excepturi ea quidem.", 51, 5348m, "Gas", "L" },
                    { 277, "Eius ab voluptas.", 51, 10280m, "Gas", "Kg" },
                    { 311, "Voluptatem non beatae perspiciatis dolor id et sed vitae sapiente.", 51, 11023m, "Solid", "L" },
                    { 390, "Autem ab vel voluptatem quo.", 51, 7574m, "Liquid", "L" },
                    { 292, "Molestiae voluptas quia.", 58, 15017m, "Solid", "Kg" },
                    { 89, "Deserunt ipsa et voluptas.", 60, 15662m, "Solid", "Kg" },
                    { 308, "Voluptatum iusto eos quis provident temporibus et quidem quaerat.", 60, 12073m, "Liquid", "Kg" },
                    { 207, "Quaerat recusandae esse excepturi dolorem.", 51, 18913m, "Solid", "Kg" },
                    { 149, "Iure a esse culpa neque modi placeat doloribus.", 24, 9318m, "Liquid", "Kg" },
                    { 97, "Eius quia voluptas aut itaque praesentium placeat nihil voluptatum ex.", 24, 14302m, "Liquid", "L" },
                    { 414, "Voluptate harum perspiciatis animi est excepturi cumque.", 8, 17482m, "Liquid", "Kg" },
                    { 462, "Accusantium maiores ea quo officiis eum dolorem esse perspiciatis.", 185, 2638m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 7, "Sint qui repellat vel voluptatem.", 189, 10092m, "Gas", "L" },
                    { 102, "Omnis harum et saepe rerum maiores sed ipsum voluptatem numquam.", 189, 1383m, "Liquid", "L" },
                    { 456, "Laborum sed distinctio alias quia nobis quia non ad numquam.", 189, 19949m, "Solid", "L" },
                    { 163, "Non ut ipsum aspernatur rerum quasi.", 190, 10697m, "Liquid", "Kg" },
                    { 125, "Non laudantium error.", 192, 15945m, "Gas", "L" },
                    { 289, "Aspernatur et repellendus et dolor commodi modi in.", 192, 5323m, "Liquid", "Kg" },
                    { 114, "Ut et atque quia mollitia.", 194, 1983m, "Liquid", "Kg" },
                    { 362, "Et consequuntur facilis ex doloribus non.", 194, 8160m, "Gas", "Kg" },
                    { 90, "Dicta reprehenderit reiciendis.", 199, 621m, "Gas", "Kg" },
                    { 496, "Eum adipisci aut similique dolor.", 199, 3417m, "Liquid", "L" },
                    { 146, "Maxime consectetur asperiores inventore iusto quia qui.", 4, 8579m, "Liquid", "L" },
                    { 245, "Dicta aut et incidunt consequuntur sit nesciunt.", 4, 321m, "Gas", "Kg" },
                    { 398, "Voluptate molestias dolorum rerum.", 4, 17448m, "Liquid", "Kg" },
                    { 252, "Facere quis eos et aut et qui sunt ipsa nihil.", 8, 14584m, "Solid", "Kg" },
                    { 391, "Id dolorem aliquam qui quod delectus omnis repellat.", 8, 14036m, "Liquid", "L" },
                    { 405, "Fugiat id expedita et aut.", 8, 17234m, "Solid", "Kg" },
                    { 214, "Eaque quia enim.", 185, 6672m, "Solid", "L" },
                    { 171, "Et pariatur libero nobis.", 10, 15732m, "Liquid", "Kg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsignorManifest_ManifestsId",
                table: "ConsignorManifest",
                column: "ManifestsId");

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
