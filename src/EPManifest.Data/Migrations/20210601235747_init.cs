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
                    { 15, "9O-VVW", "Dickinson LLC" },
                    { 16, "WX-LRV", "Berge - Johns" },
                    { 17, "A6-YKG", "Hauck - Hickle" },
                    { 18, "P7-23A", "Bashirian, Hirthe and Windler" },
                    { 23, "Z1-6P4", "Fadel Group" },
                    { 20, "WY-FZC", "Windler - Towne" },
                    { 21, "0J-8Y0", "Harris - Larson" },
                    { 22, "5O-X3A", "Thompson, Fay and Schmitt" },
                    { 14, "R0-AAQ", "Little and Sons" },
                    { 19, "VA-VP6", "Ritchie, Quigley and Miller" },
                    { 13, "VQ-W6S", "Barton, Roberts and Ebert" },
                    { 8, "W0-4OW", "Harber and Sons" },
                    { 11, "8E-GFU", "Mertz Inc" },
                    { 10, "WM-0C2", "Kub, O'Reilly and Jerde" },
                    { 9, "UB-64O", "Goldner Inc" },
                    { 24, "VP-DXQ", "Murphy, Connelly and Jacobson" },
                    { 7, "70-FOM", "Nitzsche Group" },
                    { 6, "VD-7K8", "Weber - McCullough" },
                    { 5, "A840", "Whistle Bend Place" },
                    { 4, "A1-102", "Teslin Health Centre" },
                    { 3, "B-5010", "Whitehorse General Hospital" },
                    { 2, "A-000", "Mayo Health Centre" },
                    { 1, "OXP-4", "Carmacks Health Clinic" },
                    { 12, "RK-ICK", "Medhurst - Bayer" },
                    { 25, "WH-40V", "Lueilwitz - Donnelly" }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 2, 2, "YT18113-0", 1, new DateTime(2021, 12, 4, 22, 21, 40, 607, DateTimeKind.Unspecified).AddTicks(1317), new DateTime(2021, 6, 23, 10, 55, 10, 378, DateTimeKind.Unspecified).AddTicks(1466) },
                    { 19, 2, "YT90900-1", 4, new DateTime(2021, 9, 9, 17, 55, 8, 784, DateTimeKind.Unspecified).AddTicks(276), new DateTime(2021, 6, 25, 14, 26, 41, 998, DateTimeKind.Unspecified).AddTicks(5501) },
                    { 21, 2, "YT40295-0", 4, new DateTime(2021, 11, 23, 8, 58, 0, 93, DateTimeKind.Unspecified).AddTicks(2021), new DateTime(2021, 5, 25, 11, 19, 27, 654, DateTimeKind.Unspecified).AddTicks(4111) },
                    { 26, 2, "YT25565-1", 4, new DateTime(2021, 9, 10, 8, 31, 54, 522, DateTimeKind.Unspecified).AddTicks(9766), new DateTime(2021, 8, 16, 6, 34, 46, 344, DateTimeKind.Unspecified).AddTicks(2770) },
                    { 52, 2, "YT27793-0", 4, new DateTime(2021, 9, 21, 14, 28, 26, 904, DateTimeKind.Unspecified).AddTicks(6800), new DateTime(2021, 5, 16, 17, 40, 57, 118, DateTimeKind.Unspecified).AddTicks(1981) },
                    { 58, 4, "YT81717-1", 4, new DateTime(2021, 9, 8, 7, 34, 1, 48, DateTimeKind.Unspecified).AddTicks(1520), new DateTime(2021, 5, 12, 1, 41, 34, 525, DateTimeKind.Unspecified).AddTicks(6664) },
                    { 59, 1, "YT37765-1", 4, new DateTime(2021, 12, 9, 13, 37, 15, 93, DateTimeKind.Unspecified).AddTicks(2573), new DateTime(2021, 5, 29, 9, 26, 41, 631, DateTimeKind.Unspecified).AddTicks(6423) },
                    { 62, 1, "YT16714-1", 4, new DateTime(2021, 12, 23, 16, 55, 55, 876, DateTimeKind.Unspecified).AddTicks(793), new DateTime(2021, 7, 26, 13, 43, 40, 84, DateTimeKind.Unspecified).AddTicks(8929) },
                    { 70, 3, "YT97138-1", 4, new DateTime(2021, 10, 6, 7, 47, 24, 416, DateTimeKind.Unspecified).AddTicks(6374), new DateTime(2021, 8, 4, 1, 5, 12, 198, DateTimeKind.Unspecified).AddTicks(6169) },
                    { 76, 5, "YT42944-0", 4, new DateTime(2021, 12, 9, 7, 27, 4, 38, DateTimeKind.Unspecified).AddTicks(9472), new DateTime(2021, 8, 26, 7, 56, 55, 450, DateTimeKind.Unspecified).AddTicks(1124) },
                    { 80, 2, "YT74016-1", 4, new DateTime(2021, 12, 19, 2, 38, 18, 790, DateTimeKind.Unspecified).AddTicks(8482), new DateTime(2021, 6, 1, 6, 35, 9, 904, DateTimeKind.Unspecified).AddTicks(4791) },
                    { 86, 4, "YT13685-1", 4, new DateTime(2021, 10, 13, 13, 22, 34, 297, DateTimeKind.Unspecified).AddTicks(5114), new DateTime(2021, 6, 11, 21, 0, 4, 741, DateTimeKind.Unspecified).AddTicks(7114) },
                    { 95, 4, "YT27012-1", 4, new DateTime(2021, 12, 15, 3, 3, 2, 572, DateTimeKind.Unspecified).AddTicks(987), new DateTime(2021, 7, 23, 9, 55, 5, 522, DateTimeKind.Unspecified).AddTicks(2201) },
                    { 98, 4, "YT94194-0", 4, new DateTime(2021, 10, 13, 11, 24, 9, 452, DateTimeKind.Unspecified).AddTicks(6414), new DateTime(2021, 6, 30, 20, 17, 34, 415, DateTimeKind.Unspecified).AddTicks(8531) },
                    { 99, 4, "YT11208-1", 4, new DateTime(2021, 10, 24, 0, 59, 7, 629, DateTimeKind.Unspecified).AddTicks(7633), new DateTime(2021, 5, 24, 7, 35, 46, 544, DateTimeKind.Unspecified).AddTicks(192) },
                    { 105, 1, "YT16840-1", 4, new DateTime(2021, 9, 8, 23, 31, 1, 12, DateTimeKind.Unspecified).AddTicks(8916), new DateTime(2021, 8, 16, 2, 18, 45, 333, DateTimeKind.Unspecified).AddTicks(2415) },
                    { 107, 4, "YT44074-1", 4, new DateTime(2021, 10, 23, 11, 9, 27, 827, DateTimeKind.Unspecified).AddTicks(9319), new DateTime(2021, 8, 11, 21, 59, 0, 312, DateTimeKind.Unspecified).AddTicks(2764) },
                    { 108, 3, "YT41770-1", 4, new DateTime(2021, 11, 10, 20, 43, 53, 595, DateTimeKind.Unspecified).AddTicks(2987), new DateTime(2021, 8, 7, 1, 22, 4, 694, DateTimeKind.Unspecified).AddTicks(9964) },
                    { 112, 4, "YT78527-1", 4, new DateTime(2021, 12, 20, 19, 42, 3, 219, DateTimeKind.Unspecified).AddTicks(3249), new DateTime(2021, 7, 18, 7, 34, 2, 374, DateTimeKind.Unspecified).AddTicks(1959) },
                    { 113, 4, "YT81153-1", 4, new DateTime(2021, 9, 16, 13, 29, 54, 188, DateTimeKind.Unspecified).AddTicks(2255), new DateTime(2021, 8, 29, 0, 40, 56, 316, DateTimeKind.Unspecified).AddTicks(7524) },
                    { 114, 1, "YT25786-1", 4, new DateTime(2021, 12, 10, 11, 13, 40, 613, DateTimeKind.Unspecified).AddTicks(827), new DateTime(2021, 7, 27, 17, 59, 57, 660, DateTimeKind.Unspecified).AddTicks(6343) },
                    { 117, 3, "YT34243-0", 4, new DateTime(2021, 12, 5, 20, 29, 3, 309, DateTimeKind.Unspecified).AddTicks(8838), new DateTime(2021, 7, 26, 13, 48, 42, 692, DateTimeKind.Unspecified).AddTicks(1835) },
                    { 15, 1, "YT90057-0", 4, new DateTime(2021, 10, 30, 21, 42, 34, 240, DateTimeKind.Unspecified).AddTicks(9397), new DateTime(2021, 8, 18, 1, 36, 32, 831, DateTimeKind.Unspecified).AddTicks(4266) },
                    { 121, 5, "YT54824-0", 4, new DateTime(2021, 11, 2, 9, 29, 56, 616, DateTimeKind.Unspecified).AddTicks(9055), new DateTime(2021, 8, 11, 9, 42, 11, 965, DateTimeKind.Unspecified).AddTicks(6430) },
                    { 14, 1, "YT17032-1", 4, new DateTime(2021, 12, 30, 3, 17, 50, 104, DateTimeKind.Unspecified).AddTicks(9234), new DateTime(2021, 6, 9, 3, 0, 14, 225, DateTimeKind.Unspecified).AddTicks(8382) },
                    { 6, 3, "YT18749-0", 4, new DateTime(2021, 12, 15, 2, 39, 30, 533, DateTimeKind.Unspecified).AddTicks(3680), new DateTime(2021, 5, 19, 0, 39, 16, 498, DateTimeKind.Unspecified).AddTicks(1025) },
                    { 97, 2, "YT95636-0", 3, new DateTime(2021, 10, 28, 17, 24, 16, 990, DateTimeKind.Unspecified).AddTicks(74), new DateTime(2021, 7, 18, 19, 22, 48, 546, DateTimeKind.Unspecified).AddTicks(6898) },
                    { 106, 5, "YT53103-0", 3, new DateTime(2021, 10, 17, 18, 55, 11, 483, DateTimeKind.Unspecified).AddTicks(1362), new DateTime(2021, 8, 15, 11, 55, 45, 164, DateTimeKind.Unspecified).AddTicks(8704) },
                    { 110, 2, "YT57216-0", 3, new DateTime(2021, 12, 15, 3, 48, 46, 411, DateTimeKind.Unspecified).AddTicks(7335), new DateTime(2021, 5, 27, 14, 5, 49, 944, DateTimeKind.Unspecified).AddTicks(1055) },
                    { 115, 3, "YT20192-0", 3, new DateTime(2021, 12, 2, 11, 34, 39, 307, DateTimeKind.Unspecified).AddTicks(5234), new DateTime(2021, 6, 17, 15, 32, 55, 289, DateTimeKind.Unspecified).AddTicks(4528) },
                    { 116, 5, "YT87504-0", 3, new DateTime(2021, 9, 13, 19, 27, 41, 147, DateTimeKind.Unspecified).AddTicks(4766), new DateTime(2021, 7, 23, 22, 4, 2, 609, DateTimeKind.Unspecified).AddTicks(6914) },
                    { 118, 1, "YT90515-1", 3, new DateTime(2021, 12, 21, 19, 32, 7, 794, DateTimeKind.Unspecified).AddTicks(7932), new DateTime(2021, 7, 21, 0, 44, 25, 915, DateTimeKind.Unspecified).AddTicks(4144) },
                    { 124, 4, "YT46931-0", 3, new DateTime(2021, 11, 7, 6, 17, 12, 94, DateTimeKind.Unspecified).AddTicks(6337), new DateTime(2021, 8, 29, 11, 32, 49, 96, DateTimeKind.Unspecified).AddTicks(7753) },
                    { 132, 3, "YT96383-1", 3, new DateTime(2021, 9, 29, 20, 58, 23, 942, DateTimeKind.Unspecified).AddTicks(9822), new DateTime(2021, 8, 12, 18, 57, 1, 516, DateTimeKind.Unspecified).AddTicks(6574) },
                    { 133, 4, "YT27234-1", 3, new DateTime(2021, 9, 22, 18, 8, 42, 765, DateTimeKind.Unspecified).AddTicks(3703), new DateTime(2021, 7, 22, 1, 26, 18, 926, DateTimeKind.Unspecified).AddTicks(6491) },
                    { 134, 3, "YT29438-0", 3, new DateTime(2021, 11, 28, 22, 48, 21, 140, DateTimeKind.Unspecified).AddTicks(724), new DateTime(2021, 6, 17, 17, 18, 53, 993, DateTimeKind.Unspecified).AddTicks(8514) },
                    { 141, 2, "YT55928-0", 3, new DateTime(2021, 12, 5, 2, 17, 20, 233, DateTimeKind.Unspecified).AddTicks(6025), new DateTime(2021, 7, 15, 0, 29, 22, 151, DateTimeKind.Unspecified).AddTicks(5372) },
                    { 143, 3, "YT92505-0", 3, new DateTime(2021, 10, 9, 16, 7, 37, 651, DateTimeKind.Unspecified).AddTicks(7256), new DateTime(2021, 7, 19, 0, 58, 56, 735, DateTimeKind.Unspecified).AddTicks(2338) },
                    { 147, 3, "YT62462-1", 3, new DateTime(2021, 9, 11, 10, 17, 45, 181, DateTimeKind.Unspecified).AddTicks(2711), new DateTime(2021, 5, 11, 1, 21, 53, 207, DateTimeKind.Unspecified).AddTicks(6718) },
                    { 150, 2, "YT25714-1", 3, new DateTime(2021, 12, 4, 2, 20, 58, 211, DateTimeKind.Unspecified).AddTicks(2575), new DateTime(2021, 6, 9, 2, 26, 0, 236, DateTimeKind.Unspecified).AddTicks(5758) },
                    { 154, 4, "YT39171-1", 3, new DateTime(2021, 10, 7, 15, 26, 50, 711, DateTimeKind.Unspecified).AddTicks(8687), new DateTime(2021, 8, 8, 2, 37, 47, 261, DateTimeKind.Unspecified).AddTicks(3069) },
                    { 158, 2, "YT44651-1", 3, new DateTime(2021, 12, 8, 18, 57, 5, 37, DateTimeKind.Unspecified).AddTicks(7809), new DateTime(2021, 8, 16, 16, 39, 3, 868, DateTimeKind.Unspecified).AddTicks(6128) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 161, 4, "YT79444-0", 3, new DateTime(2021, 10, 28, 18, 1, 41, 930, DateTimeKind.Unspecified).AddTicks(6783), new DateTime(2021, 5, 13, 11, 31, 26, 749, DateTimeKind.Unspecified).AddTicks(2437) },
                    { 164, 5, "YT80327-1", 3, new DateTime(2021, 11, 19, 0, 32, 41, 639, DateTimeKind.Unspecified).AddTicks(5721), new DateTime(2021, 6, 2, 2, 32, 8, 886, DateTimeKind.Unspecified).AddTicks(5177) },
                    { 165, 4, "YT78774-1", 3, new DateTime(2021, 12, 27, 10, 28, 10, 22, DateTimeKind.Unspecified).AddTicks(2596), new DateTime(2021, 6, 27, 17, 4, 48, 826, DateTimeKind.Unspecified).AddTicks(2364) },
                    { 169, 1, "YT52007-1", 3, new DateTime(2021, 12, 14, 7, 10, 10, 274, DateTimeKind.Unspecified).AddTicks(8619), new DateTime(2021, 8, 26, 6, 35, 8, 569, DateTimeKind.Unspecified).AddTicks(4632) },
                    { 183, 5, "YT42302-1", 3, new DateTime(2021, 11, 3, 6, 14, 10, 261, DateTimeKind.Unspecified).AddTicks(8641), new DateTime(2021, 5, 13, 19, 52, 56, 258, DateTimeKind.Unspecified).AddTicks(5511) },
                    { 13, 5, "YT59668-0", 4, new DateTime(2021, 10, 5, 7, 7, 50, 384, DateTimeKind.Unspecified).AddTicks(3713), new DateTime(2021, 8, 14, 11, 0, 9, 552, DateTimeKind.Unspecified).AddTicks(9875) },
                    { 96, 5, "YT31703-1", 3, new DateTime(2021, 10, 31, 8, 47, 0, 937, DateTimeKind.Unspecified).AddTicks(2519), new DateTime(2021, 7, 18, 17, 22, 49, 770, DateTimeKind.Unspecified).AddTicks(8064) },
                    { 126, 4, "YT17188-1", 4, new DateTime(2021, 10, 13, 2, 55, 43, 704, DateTimeKind.Unspecified).AddTicks(6741), new DateTime(2021, 5, 14, 3, 33, 38, 624, DateTimeKind.Unspecified).AddTicks(6231) },
                    { 155, 1, "YT15639-0", 4, new DateTime(2021, 10, 18, 8, 44, 56, 284, DateTimeKind.Unspecified).AddTicks(6187), new DateTime(2021, 7, 19, 12, 2, 52, 570, DateTimeKind.Unspecified).AddTicks(759) },
                    { 55, 3, "YT54601-1", 5, new DateTime(2021, 10, 4, 10, 5, 29, 950, DateTimeKind.Unspecified).AddTicks(6178), new DateTime(2021, 7, 23, 4, 44, 33, 555, DateTimeKind.Unspecified).AddTicks(766) },
                    { 60, 1, "YT50788-1", 5, new DateTime(2021, 12, 3, 19, 9, 11, 670, DateTimeKind.Unspecified).AddTicks(97), new DateTime(2021, 5, 31, 18, 43, 8, 475, DateTimeKind.Unspecified).AddTicks(9531) },
                    { 64, 4, "YT81754-1", 5, new DateTime(2021, 12, 30, 0, 26, 12, 605, DateTimeKind.Unspecified).AddTicks(5927), new DateTime(2021, 5, 24, 1, 53, 44, 348, DateTimeKind.Unspecified).AddTicks(9461) },
                    { 66, 3, "YT54691-0", 5, new DateTime(2021, 12, 28, 1, 11, 21, 527, DateTimeKind.Unspecified).AddTicks(8550), new DateTime(2021, 6, 4, 7, 43, 55, 258, DateTimeKind.Unspecified).AddTicks(8500) },
                    { 68, 4, "YT35147-0", 5, new DateTime(2021, 9, 2, 4, 59, 22, 209, DateTimeKind.Unspecified).AddTicks(379), new DateTime(2021, 8, 18, 5, 10, 13, 214, DateTimeKind.Unspecified).AddTicks(5193) },
                    { 72, 3, "YT98219-1", 5, new DateTime(2021, 10, 3, 17, 31, 23, 627, DateTimeKind.Unspecified).AddTicks(1624), new DateTime(2021, 8, 2, 5, 8, 47, 852, DateTimeKind.Unspecified).AddTicks(1579) },
                    { 84, 5, "YT40931-0", 5, new DateTime(2021, 10, 5, 7, 56, 49, 98, DateTimeKind.Unspecified).AddTicks(4269), new DateTime(2021, 6, 13, 15, 10, 52, 296, DateTimeKind.Unspecified).AddTicks(3465) },
                    { 89, 3, "YT92585-0", 5, new DateTime(2021, 12, 23, 23, 59, 19, 502, DateTimeKind.Unspecified).AddTicks(905), new DateTime(2021, 8, 27, 20, 47, 7, 470, DateTimeKind.Unspecified).AddTicks(1676) },
                    { 91, 5, "YT18845-1", 5, new DateTime(2021, 9, 15, 23, 2, 25, 610, DateTimeKind.Unspecified).AddTicks(9701), new DateTime(2021, 6, 13, 3, 0, 25, 462, DateTimeKind.Unspecified).AddTicks(6310) },
                    { 93, 1, "YT94947-1", 5, new DateTime(2021, 10, 24, 8, 50, 4, 532, DateTimeKind.Unspecified).AddTicks(7558), new DateTime(2021, 7, 20, 18, 52, 58, 731, DateTimeKind.Unspecified).AddTicks(2511) },
                    { 102, 3, "YT81213-0", 5, new DateTime(2021, 10, 12, 1, 43, 49, 272, DateTimeKind.Unspecified).AddTicks(3104), new DateTime(2021, 5, 29, 23, 45, 4, 709, DateTimeKind.Unspecified).AddTicks(5831) },
                    { 109, 3, "YT42481-0", 5, new DateTime(2021, 9, 20, 9, 56, 17, 454, DateTimeKind.Unspecified).AddTicks(1172), new DateTime(2021, 7, 3, 20, 41, 33, 684, DateTimeKind.Unspecified).AddTicks(6111) },
                    { 122, 4, "YT45732-1", 5, new DateTime(2021, 11, 7, 23, 49, 39, 999, DateTimeKind.Unspecified).AddTicks(3795), new DateTime(2021, 6, 29, 15, 11, 41, 467, DateTimeKind.Unspecified).AddTicks(7958) },
                    { 123, 5, "YT54631-1", 5, new DateTime(2021, 9, 4, 21, 1, 4, 396, DateTimeKind.Unspecified).AddTicks(1856), new DateTime(2021, 5, 31, 17, 59, 9, 838, DateTimeKind.Unspecified).AddTicks(2825) },
                    { 127, 5, "YT23141-1", 5, new DateTime(2021, 12, 4, 6, 29, 8, 705, DateTimeKind.Unspecified).AddTicks(4725), new DateTime(2021, 7, 20, 13, 49, 6, 48, DateTimeKind.Unspecified).AddTicks(6048) },
                    { 129, 5, "YT65533-0", 5, new DateTime(2021, 11, 29, 19, 53, 27, 24, DateTimeKind.Unspecified).AddTicks(7894), new DateTime(2021, 8, 22, 5, 0, 59, 878, DateTimeKind.Unspecified).AddTicks(6349) },
                    { 166, 2, "YT74773-0", 5, new DateTime(2021, 10, 14, 20, 38, 57, 261, DateTimeKind.Unspecified).AddTicks(8425), new DateTime(2021, 8, 11, 8, 36, 14, 839, DateTimeKind.Unspecified).AddTicks(6496) },
                    { 168, 5, "YT71632-1", 5, new DateTime(2021, 9, 20, 19, 57, 36, 892, DateTimeKind.Unspecified).AddTicks(8770), new DateTime(2021, 7, 16, 17, 55, 33, 364, DateTimeKind.Unspecified).AddTicks(6225) },
                    { 172, 4, "YT73333-0", 5, new DateTime(2021, 11, 16, 19, 52, 22, 324, DateTimeKind.Unspecified).AddTicks(1546), new DateTime(2021, 7, 31, 17, 39, 55, 581, DateTimeKind.Unspecified).AddTicks(1350) },
                    { 179, 4, "YT64437-0", 5, new DateTime(2021, 9, 15, 10, 5, 2, 143, DateTimeKind.Unspecified).AddTicks(2852), new DateTime(2021, 8, 30, 19, 7, 53, 252, DateTimeKind.Unspecified).AddTicks(9737) },
                    { 184, 1, "YT58416-0", 5, new DateTime(2021, 12, 7, 20, 54, 54, 85, DateTimeKind.Unspecified).AddTicks(4200), new DateTime(2021, 7, 5, 12, 9, 11, 51, DateTimeKind.Unspecified).AddTicks(5476) },
                    { 49, 2, "YT39840-1", 5, new DateTime(2021, 12, 15, 4, 26, 2, 302, DateTimeKind.Unspecified).AddTicks(4031), new DateTime(2021, 5, 24, 0, 29, 36, 216, DateTimeKind.Unspecified).AddTicks(3975) },
                    { 136, 3, "YT99195-0", 4, new DateTime(2021, 9, 26, 21, 9, 59, 596, DateTimeKind.Unspecified).AddTicks(5016), new DateTime(2021, 6, 22, 8, 24, 22, 654, DateTimeKind.Unspecified).AddTicks(131) },
                    { 45, 3, "YT29782-0", 5, new DateTime(2021, 10, 14, 22, 11, 58, 800, DateTimeKind.Unspecified).AddTicks(1886), new DateTime(2021, 6, 6, 12, 27, 32, 854, DateTimeKind.Unspecified).AddTicks(5842) },
                    { 40, 5, "YT24728-0", 5, new DateTime(2021, 11, 2, 14, 2, 48, 69, DateTimeKind.Unspecified).AddTicks(911), new DateTime(2021, 8, 24, 10, 56, 57, 529, DateTimeKind.Unspecified).AddTicks(843) },
                    { 159, 1, "YT95389-1", 4, new DateTime(2021, 10, 31, 20, 40, 25, 8, DateTimeKind.Unspecified).AddTicks(8621), new DateTime(2021, 8, 18, 0, 42, 35, 40, DateTimeKind.Unspecified).AddTicks(2966) },
                    { 167, 1, "YT70085-1", 4, new DateTime(2021, 11, 20, 9, 17, 28, 780, DateTimeKind.Unspecified).AddTicks(8890), new DateTime(2021, 7, 6, 4, 30, 20, 233, DateTimeKind.Unspecified).AddTicks(9755) },
                    { 171, 1, "YT99362-1", 4, new DateTime(2021, 12, 13, 0, 44, 50, 509, DateTimeKind.Unspecified).AddTicks(5679), new DateTime(2021, 7, 8, 6, 49, 59, 491, DateTimeKind.Unspecified).AddTicks(1249) },
                    { 176, 3, "YT28301-1", 4, new DateTime(2021, 11, 3, 1, 6, 44, 718, DateTimeKind.Unspecified).AddTicks(8152), new DateTime(2021, 5, 13, 21, 23, 13, 976, DateTimeKind.Unspecified).AddTicks(999) },
                    { 180, 1, "YT91380-1", 4, new DateTime(2021, 12, 26, 14, 47, 32, 342, DateTimeKind.Unspecified).AddTicks(6840), new DateTime(2021, 8, 4, 10, 42, 12, 391, DateTimeKind.Unspecified).AddTicks(8611) },
                    { 182, 4, "YT89631-1", 4, new DateTime(2021, 11, 14, 12, 2, 42, 628, DateTimeKind.Unspecified).AddTicks(3877), new DateTime(2021, 8, 25, 22, 14, 24, 430, DateTimeKind.Unspecified).AddTicks(6600) },
                    { 186, 1, "YT85890-1", 4, new DateTime(2021, 11, 19, 3, 44, 52, 178, DateTimeKind.Unspecified).AddTicks(4434), new DateTime(2021, 6, 30, 8, 33, 55, 782, DateTimeKind.Unspecified).AddTicks(8299) },
                    { 189, 1, "YT59255-0", 4, new DateTime(2021, 10, 9, 19, 21, 18, 632, DateTimeKind.Unspecified).AddTicks(1905), new DateTime(2021, 7, 17, 7, 5, 26, 530, DateTimeKind.Unspecified).AddTicks(318) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 198, 5, "YT77116-1", 4, new DateTime(2021, 10, 2, 8, 13, 21, 849, DateTimeKind.Unspecified).AddTicks(274), new DateTime(2021, 8, 25, 19, 16, 10, 275, DateTimeKind.Unspecified).AddTicks(2228) },
                    { 199, 3, "YT93804-1", 4, new DateTime(2021, 9, 7, 20, 26, 54, 299, DateTimeKind.Unspecified).AddTicks(7205), new DateTime(2021, 8, 5, 1, 41, 27, 64, DateTimeKind.Unspecified).AddTicks(291) },
                    { 1, 4, "YT11773-0", 5, new DateTime(2021, 12, 21, 7, 57, 59, 431, DateTimeKind.Unspecified).AddTicks(2179), new DateTime(2021, 6, 10, 21, 26, 18, 434, DateTimeKind.Unspecified).AddTicks(9264) },
                    { 9, 4, "YT20784-0", 5, new DateTime(2021, 11, 11, 3, 26, 30, 969, DateTimeKind.Unspecified).AddTicks(4491), new DateTime(2021, 7, 28, 5, 4, 12, 155, DateTimeKind.Unspecified).AddTicks(4034) },
                    { 12, 3, "YT24241-1", 5, new DateTime(2021, 12, 10, 14, 3, 48, 824, DateTimeKind.Unspecified).AddTicks(5854), new DateTime(2021, 7, 16, 16, 37, 57, 104, DateTimeKind.Unspecified).AddTicks(4205) },
                    { 29, 4, "YT70725-1", 5, new DateTime(2021, 11, 21, 15, 3, 55, 193, DateTimeKind.Unspecified).AddTicks(9618), new DateTime(2021, 7, 17, 19, 25, 38, 761, DateTimeKind.Unspecified).AddTicks(6990) },
                    { 30, 4, "YT80662-0", 5, new DateTime(2021, 9, 7, 13, 7, 17, 689, DateTimeKind.Unspecified).AddTicks(447), new DateTime(2021, 7, 10, 18, 39, 34, 653, DateTimeKind.Unspecified).AddTicks(7372) },
                    { 31, 1, "YT27520-1", 5, new DateTime(2021, 11, 23, 11, 44, 56, 755, DateTimeKind.Unspecified).AddTicks(2710), new DateTime(2021, 8, 23, 3, 4, 32, 599, DateTimeKind.Unspecified).AddTicks(6129) },
                    { 32, 2, "YT96265-1", 5, new DateTime(2021, 12, 20, 15, 17, 35, 8, DateTimeKind.Unspecified).AddTicks(5458), new DateTime(2021, 6, 26, 8, 59, 19, 203, DateTimeKind.Unspecified).AddTicks(5757) },
                    { 33, 2, "YT26068-1", 5, new DateTime(2021, 10, 12, 18, 7, 8, 824, DateTimeKind.Unspecified).AddTicks(9424), new DateTime(2021, 8, 5, 5, 54, 11, 495, DateTimeKind.Unspecified).AddTicks(7646) },
                    { 34, 5, "YT60808-1", 5, new DateTime(2021, 12, 22, 21, 54, 47, 57, DateTimeKind.Unspecified).AddTicks(4439), new DateTime(2021, 8, 12, 22, 17, 6, 882, DateTimeKind.Unspecified).AddTicks(4444) },
                    { 35, 1, "YT22838-0", 5, new DateTime(2021, 11, 19, 14, 24, 19, 738, DateTimeKind.Unspecified).AddTicks(8911), new DateTime(2021, 7, 8, 21, 49, 15, 916, DateTimeKind.Unspecified).AddTicks(8541) },
                    { 37, 5, "YT95109-0", 5, new DateTime(2021, 10, 30, 20, 2, 19, 57, DateTimeKind.Unspecified).AddTicks(1081), new DateTime(2021, 5, 21, 19, 57, 8, 735, DateTimeKind.Unspecified).AddTicks(5161) },
                    { 44, 5, "YT83542-0", 5, new DateTime(2021, 9, 7, 19, 51, 31, 112, DateTimeKind.Unspecified).AddTicks(9659), new DateTime(2021, 6, 14, 13, 35, 13, 895, DateTimeKind.Unspecified).AddTicks(2826) },
                    { 94, 3, "YT87234-1", 3, new DateTime(2021, 12, 26, 23, 57, 7, 222, DateTimeKind.Unspecified).AddTicks(998), new DateTime(2021, 8, 10, 10, 58, 7, 564, DateTimeKind.Unspecified).AddTicks(2305) },
                    { 88, 3, "YT29384-1", 3, new DateTime(2021, 9, 7, 3, 3, 43, 322, DateTimeKind.Unspecified).AddTicks(9942), new DateTime(2021, 6, 4, 14, 23, 6, 512, DateTimeKind.Unspecified).AddTicks(7745) },
                    { 87, 4, "YT84583-1", 3, new DateTime(2021, 12, 3, 21, 55, 12, 795, DateTimeKind.Unspecified).AddTicks(5461), new DateTime(2021, 6, 16, 3, 0, 14, 203, DateTimeKind.Unspecified).AddTicks(1467) },
                    { 125, 5, "YT68166-0", 1, new DateTime(2021, 11, 18, 3, 55, 19, 168, DateTimeKind.Unspecified).AddTicks(4446), new DateTime(2021, 8, 12, 5, 17, 50, 366, DateTimeKind.Unspecified).AddTicks(8177) },
                    { 131, 2, "YT55894-0", 1, new DateTime(2021, 11, 3, 4, 31, 55, 169, DateTimeKind.Unspecified).AddTicks(1677), new DateTime(2021, 7, 9, 13, 12, 56, 968, DateTimeKind.Unspecified).AddTicks(7174) },
                    { 135, 5, "YT84664-0", 1, new DateTime(2021, 9, 28, 21, 54, 4, 356, DateTimeKind.Unspecified).AddTicks(461), new DateTime(2021, 6, 2, 9, 47, 39, 187, DateTimeKind.Unspecified).AddTicks(7669) },
                    { 139, 1, "YT37516-1", 1, new DateTime(2021, 9, 24, 0, 23, 43, 766, DateTimeKind.Unspecified).AddTicks(6494), new DateTime(2021, 8, 16, 13, 2, 39, 150, DateTimeKind.Unspecified).AddTicks(4629) },
                    { 140, 2, "YT82186-1", 1, new DateTime(2021, 10, 26, 10, 5, 13, 334, DateTimeKind.Unspecified).AddTicks(5341), new DateTime(2021, 6, 25, 23, 32, 8, 891, DateTimeKind.Unspecified).AddTicks(6625) },
                    { 142, 2, "YT59604-1", 1, new DateTime(2021, 12, 17, 3, 55, 6, 232, DateTimeKind.Unspecified).AddTicks(30), new DateTime(2021, 8, 16, 2, 52, 49, 749, DateTimeKind.Unspecified).AddTicks(6328) },
                    { 145, 3, "YT15453-1", 1, new DateTime(2021, 10, 21, 5, 59, 25, 233, DateTimeKind.Unspecified).AddTicks(8739), new DateTime(2021, 7, 24, 9, 50, 3, 544, DateTimeKind.Unspecified).AddTicks(8999) },
                    { 148, 2, "YT37519-0", 1, new DateTime(2021, 10, 28, 14, 14, 33, 86, DateTimeKind.Unspecified).AddTicks(4704), new DateTime(2021, 6, 6, 23, 2, 5, 226, DateTimeKind.Unspecified).AddTicks(8522) },
                    { 151, 4, "YT64402-0", 1, new DateTime(2021, 10, 20, 21, 18, 1, 112, DateTimeKind.Unspecified).AddTicks(7796), new DateTime(2021, 5, 17, 6, 33, 3, 669, DateTimeKind.Unspecified).AddTicks(5975) },
                    { 152, 5, "YT59006-0", 1, new DateTime(2021, 9, 8, 11, 19, 4, 180, DateTimeKind.Unspecified).AddTicks(5895), new DateTime(2021, 8, 13, 14, 51, 46, 57, DateTimeKind.Unspecified).AddTicks(4617) },
                    { 157, 4, "YT13872-1", 1, new DateTime(2021, 9, 19, 0, 14, 12, 694, DateTimeKind.Unspecified).AddTicks(9127), new DateTime(2021, 8, 1, 2, 11, 10, 303, DateTimeKind.Unspecified).AddTicks(3216) },
                    { 162, 2, "YT79857-0", 1, new DateTime(2021, 11, 22, 4, 39, 9, 433, DateTimeKind.Unspecified).AddTicks(365), new DateTime(2021, 5, 25, 17, 35, 44, 324, DateTimeKind.Unspecified).AddTicks(5616) },
                    { 163, 3, "YT52176-1", 1, new DateTime(2021, 9, 13, 9, 20, 59, 993, DateTimeKind.Unspecified).AddTicks(1009), new DateTime(2021, 6, 13, 20, 25, 53, 895, DateTimeKind.Unspecified).AddTicks(5018) },
                    { 170, 5, "YT25874-1", 1, new DateTime(2021, 9, 21, 21, 30, 6, 803, DateTimeKind.Unspecified).AddTicks(7543), new DateTime(2021, 8, 23, 13, 34, 7, 759, DateTimeKind.Unspecified).AddTicks(4514) },
                    { 177, 5, "YT90467-1", 1, new DateTime(2021, 10, 25, 9, 24, 22, 146, DateTimeKind.Unspecified).AddTicks(178), new DateTime(2021, 6, 5, 2, 13, 6, 922, DateTimeKind.Unspecified).AddTicks(4437) },
                    { 178, 5, "YT34280-1", 1, new DateTime(2021, 9, 27, 19, 37, 45, 315, DateTimeKind.Unspecified).AddTicks(1513), new DateTime(2021, 7, 27, 9, 27, 42, 183, DateTimeKind.Unspecified).AddTicks(7983) },
                    { 181, 1, "YT55693-1", 1, new DateTime(2021, 12, 18, 13, 56, 50, 782, DateTimeKind.Unspecified).AddTicks(2741), new DateTime(2021, 7, 1, 2, 17, 55, 719, DateTimeKind.Unspecified).AddTicks(266) },
                    { 190, 2, "YT18434-0", 1, new DateTime(2021, 12, 19, 9, 15, 37, 29, DateTimeKind.Unspecified).AddTicks(5337), new DateTime(2021, 8, 23, 21, 49, 57, 855, DateTimeKind.Unspecified).AddTicks(1903) },
                    { 195, 3, "YT78131-1", 1, new DateTime(2021, 9, 10, 11, 46, 14, 307, DateTimeKind.Unspecified).AddTicks(9383), new DateTime(2021, 5, 20, 3, 53, 2, 988, DateTimeKind.Unspecified).AddTicks(9780) },
                    { 200, 5, "YT65411-0", 1, new DateTime(2021, 9, 25, 18, 15, 41, 620, DateTimeKind.Unspecified).AddTicks(2300), new DateTime(2021, 7, 10, 6, 40, 59, 280, DateTimeKind.Unspecified).AddTicks(536) },
                    { 3, 1, "YT26984-1", 2, new DateTime(2021, 9, 16, 14, 4, 50, 166, DateTimeKind.Unspecified).AddTicks(5581), new DateTime(2021, 5, 18, 3, 25, 6, 647, DateTimeKind.Unspecified).AddTicks(7982) },
                    { 120, 2, "YT18031-0", 1, new DateTime(2021, 12, 19, 15, 54, 32, 866, DateTimeKind.Unspecified).AddTicks(805), new DateTime(2021, 8, 10, 3, 56, 52, 445, DateTimeKind.Unspecified).AddTicks(6293) },
                    { 8, 2, "YT60646-1", 2, new DateTime(2021, 9, 3, 4, 55, 25, 693, DateTimeKind.Unspecified).AddTicks(2416), new DateTime(2021, 6, 1, 13, 13, 0, 216, DateTimeKind.Unspecified).AddTicks(9798) },
                    { 119, 2, "YT48770-1", 1, new DateTime(2021, 11, 6, 6, 31, 46, 818, DateTimeKind.Unspecified).AddTicks(730), new DateTime(2021, 5, 19, 8, 30, 52, 734, DateTimeKind.Unspecified).AddTicks(2954) },
                    { 104, 2, "YT42692-1", 1, new DateTime(2021, 12, 9, 17, 50, 24, 821, DateTimeKind.Unspecified).AddTicks(6973), new DateTime(2021, 7, 28, 21, 42, 58, 577, DateTimeKind.Unspecified).AddTicks(9229) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 5, 2, "YT95515-1", 1, new DateTime(2021, 12, 7, 1, 6, 37, 966, DateTimeKind.Unspecified).AddTicks(5685), new DateTime(2021, 5, 19, 9, 11, 30, 665, DateTimeKind.Unspecified).AddTicks(5510) },
                    { 11, 2, "YT87064-1", 1, new DateTime(2021, 9, 3, 1, 55, 34, 805, DateTimeKind.Unspecified).AddTicks(7600), new DateTime(2021, 6, 7, 12, 55, 19, 437, DateTimeKind.Unspecified).AddTicks(963) },
                    { 24, 1, "YT54350-1", 1, new DateTime(2021, 9, 15, 9, 10, 51, 805, DateTimeKind.Unspecified).AddTicks(4118), new DateTime(2021, 5, 24, 0, 56, 28, 525, DateTimeKind.Unspecified).AddTicks(6977) },
                    { 38, 1, "YT59987-0", 1, new DateTime(2021, 12, 23, 0, 19, 29, 348, DateTimeKind.Unspecified).AddTicks(1942), new DateTime(2021, 7, 13, 17, 4, 34, 485, DateTimeKind.Unspecified).AddTicks(4573) },
                    { 41, 2, "YT80323-1", 1, new DateTime(2021, 10, 16, 16, 57, 51, 958, DateTimeKind.Unspecified).AddTicks(6120), new DateTime(2021, 6, 2, 16, 22, 29, 521, DateTimeKind.Unspecified).AddTicks(9639) },
                    { 42, 5, "YT60024-1", 1, new DateTime(2021, 11, 2, 8, 31, 32, 805, DateTimeKind.Unspecified).AddTicks(9751), new DateTime(2021, 6, 18, 2, 51, 25, 295, DateTimeKind.Unspecified).AddTicks(3735) },
                    { 47, 4, "YT38798-0", 1, new DateTime(2021, 12, 9, 10, 47, 40, 959, DateTimeKind.Unspecified).AddTicks(2201), new DateTime(2021, 7, 5, 23, 55, 24, 113, DateTimeKind.Unspecified).AddTicks(6266) },
                    { 48, 5, "YT88176-1", 1, new DateTime(2021, 10, 21, 2, 35, 54, 859, DateTimeKind.Unspecified).AddTicks(3013), new DateTime(2021, 5, 25, 14, 29, 24, 520, DateTimeKind.Unspecified).AddTicks(5815) },
                    { 56, 2, "YT63589-0", 1, new DateTime(2021, 10, 23, 8, 47, 2, 119, DateTimeKind.Unspecified).AddTicks(6635), new DateTime(2021, 6, 11, 5, 57, 46, 621, DateTimeKind.Unspecified).AddTicks(1318) },
                    { 65, 2, "YT61790-0", 1, new DateTime(2021, 10, 17, 0, 56, 53, 175, DateTimeKind.Unspecified).AddTicks(4131), new DateTime(2021, 8, 21, 8, 48, 5, 858, DateTimeKind.Unspecified).AddTicks(1229) },
                    { 69, 4, "YT32569-0", 1, new DateTime(2021, 10, 20, 9, 57, 54, 326, DateTimeKind.Unspecified).AddTicks(2935), new DateTime(2021, 6, 1, 18, 5, 12, 668, DateTimeKind.Unspecified).AddTicks(8635) },
                    { 71, 3, "YT87241-1", 1, new DateTime(2021, 10, 17, 11, 19, 17, 808, DateTimeKind.Unspecified).AddTicks(2364), new DateTime(2021, 7, 19, 14, 45, 52, 486, DateTimeKind.Unspecified).AddTicks(2552) },
                    { 73, 4, "YT96043-1", 1, new DateTime(2021, 12, 26, 1, 51, 32, 301, DateTimeKind.Unspecified).AddTicks(5030), new DateTime(2021, 7, 5, 15, 41, 23, 455, DateTimeKind.Unspecified).AddTicks(8377) },
                    { 75, 3, "YT27051-1", 1, new DateTime(2021, 11, 1, 12, 58, 27, 334, DateTimeKind.Unspecified).AddTicks(3673), new DateTime(2021, 7, 3, 15, 30, 54, 305, DateTimeKind.Unspecified).AddTicks(3172) },
                    { 82, 2, "YT62227-0", 1, new DateTime(2021, 11, 16, 8, 53, 50, 812, DateTimeKind.Unspecified).AddTicks(3976), new DateTime(2021, 8, 6, 1, 51, 38, 867, DateTimeKind.Unspecified).AddTicks(9127) },
                    { 83, 3, "YT46922-0", 1, new DateTime(2021, 10, 15, 11, 51, 46, 900, DateTimeKind.Unspecified).AddTicks(3811), new DateTime(2021, 8, 23, 10, 48, 47, 840, DateTimeKind.Unspecified).AddTicks(6116) },
                    { 90, 1, "YT98457-0", 1, new DateTime(2021, 11, 2, 6, 29, 32, 338, DateTimeKind.Unspecified).AddTicks(3759), new DateTime(2021, 5, 24, 2, 59, 43, 594, DateTimeKind.Unspecified).AddTicks(188) },
                    { 92, 4, "YT96703-1", 1, new DateTime(2021, 10, 6, 9, 59, 44, 568, DateTimeKind.Unspecified).AddTicks(3429), new DateTime(2021, 7, 20, 12, 54, 6, 128, DateTimeKind.Unspecified).AddTicks(6627) },
                    { 100, 5, "YT13494-1", 1, new DateTime(2021, 11, 22, 22, 1, 3, 803, DateTimeKind.Unspecified).AddTicks(6203), new DateTime(2021, 7, 30, 6, 41, 42, 754, DateTimeKind.Unspecified).AddTicks(1690) },
                    { 101, 2, "YT49306-0", 1, new DateTime(2021, 12, 8, 2, 32, 51, 267, DateTimeKind.Unspecified).AddTicks(9012), new DateTime(2021, 6, 27, 16, 23, 46, 386, DateTimeKind.Unspecified).AddTicks(7653) },
                    { 103, 5, "YT88993-1", 1, new DateTime(2021, 11, 10, 20, 38, 13, 745, DateTimeKind.Unspecified).AddTicks(6030), new DateTime(2021, 7, 16, 13, 55, 22, 987, DateTimeKind.Unspecified).AddTicks(3369) },
                    { 111, 5, "YT21161-1", 1, new DateTime(2021, 9, 12, 18, 52, 8, 476, DateTimeKind.Unspecified).AddTicks(1626), new DateTime(2021, 8, 25, 8, 28, 5, 430, DateTimeKind.Unspecified).AddTicks(3949) },
                    { 17, 2, "YT66958-0", 2, new DateTime(2021, 11, 3, 21, 55, 7, 182, DateTimeKind.Unspecified).AddTicks(8226), new DateTime(2021, 5, 30, 16, 14, 44, 349, DateTimeKind.Unspecified).AddTicks(5120) },
                    { 22, 1, "YT31727-0", 2, new DateTime(2021, 11, 20, 13, 41, 36, 326, DateTimeKind.Unspecified).AddTicks(1193), new DateTime(2021, 6, 1, 15, 36, 42, 380, DateTimeKind.Unspecified).AddTicks(2348) },
                    { 23, 1, "YT13270-1", 2, new DateTime(2021, 11, 19, 0, 15, 0, 691, DateTimeKind.Unspecified).AddTicks(2325), new DateTime(2021, 8, 11, 3, 49, 8, 650, DateTimeKind.Unspecified).AddTicks(2369) },
                    { 196, 3, "YT61555-0", 2, new DateTime(2021, 12, 7, 9, 45, 2, 163, DateTimeKind.Unspecified).AddTicks(5130), new DateTime(2021, 5, 22, 21, 40, 39, 863, DateTimeKind.Unspecified).AddTicks(8895) },
                    { 4, 3, "YT94682-1", 3, new DateTime(2021, 10, 7, 18, 31, 4, 735, DateTimeKind.Unspecified).AddTicks(8028), new DateTime(2021, 8, 7, 13, 15, 10, 755, DateTimeKind.Unspecified).AddTicks(4390) },
                    { 7, 4, "YT47598-0", 3, new DateTime(2021, 11, 28, 20, 18, 43, 217, DateTimeKind.Unspecified).AddTicks(5720), new DateTime(2021, 6, 8, 16, 28, 28, 650, DateTimeKind.Unspecified).AddTicks(906) },
                    { 10, 3, "YT65431-1", 3, new DateTime(2021, 10, 18, 13, 53, 37, 533, DateTimeKind.Unspecified).AddTicks(1915), new DateTime(2021, 7, 23, 17, 1, 12, 102, DateTimeKind.Unspecified).AddTicks(1252) },
                    { 16, 1, "YT40737-1", 3, new DateTime(2021, 11, 10, 17, 35, 17, 471, DateTimeKind.Unspecified).AddTicks(8407), new DateTime(2021, 8, 23, 16, 48, 35, 233, DateTimeKind.Unspecified).AddTicks(8906) },
                    { 18, 1, "YT29631-1", 3, new DateTime(2021, 11, 7, 12, 36, 46, 605, DateTimeKind.Unspecified).AddTicks(2320), new DateTime(2021, 5, 31, 9, 27, 14, 178, DateTimeKind.Unspecified).AddTicks(761) },
                    { 20, 1, "YT73466-1", 3, new DateTime(2021, 12, 21, 18, 13, 26, 683, DateTimeKind.Unspecified).AddTicks(2431), new DateTime(2021, 7, 2, 12, 51, 38, 256, DateTimeKind.Unspecified).AddTicks(6423) },
                    { 25, 3, "YT77538-0", 3, new DateTime(2021, 9, 16, 5, 28, 20, 995, DateTimeKind.Unspecified).AddTicks(6645), new DateTime(2021, 7, 2, 0, 45, 47, 254, DateTimeKind.Unspecified).AddTicks(8647) },
                    { 27, 5, "YT75742-1", 3, new DateTime(2021, 12, 11, 1, 38, 23, 607, DateTimeKind.Unspecified).AddTicks(9330), new DateTime(2021, 8, 12, 13, 50, 34, 340, DateTimeKind.Unspecified).AddTicks(1798) },
                    { 28, 1, "YT41181-1", 3, new DateTime(2021, 11, 6, 22, 2, 23, 616, DateTimeKind.Unspecified).AddTicks(7863), new DateTime(2021, 5, 31, 20, 19, 56, 229, DateTimeKind.Unspecified).AddTicks(47) },
                    { 39, 4, "YT73548-0", 3, new DateTime(2021, 12, 16, 20, 2, 38, 288, DateTimeKind.Unspecified).AddTicks(6272), new DateTime(2021, 5, 21, 3, 33, 16, 27, DateTimeKind.Unspecified).AddTicks(7230) },
                    { 43, 2, "YT53401-1", 3, new DateTime(2021, 10, 30, 2, 13, 54, 680, DateTimeKind.Unspecified).AddTicks(6638), new DateTime(2021, 6, 21, 9, 6, 11, 268, DateTimeKind.Unspecified).AddTicks(3294) },
                    { 50, 1, "YT71471-1", 3, new DateTime(2021, 12, 2, 4, 3, 3, 97, DateTimeKind.Unspecified).AddTicks(6122), new DateTime(2021, 5, 21, 19, 6, 58, 884, DateTimeKind.Unspecified).AddTicks(2081) },
                    { 51, 4, "YT49642-0", 3, new DateTime(2021, 10, 15, 13, 39, 42, 607, DateTimeKind.Unspecified).AddTicks(821), new DateTime(2021, 7, 18, 0, 29, 7, 167, DateTimeKind.Unspecified).AddTicks(4704) },
                    { 53, 1, "YT42148-0", 3, new DateTime(2021, 10, 28, 5, 55, 49, 970, DateTimeKind.Unspecified).AddTicks(6681), new DateTime(2021, 5, 20, 4, 32, 47, 781, DateTimeKind.Unspecified).AddTicks(3144) },
                    { 61, 2, "YT56659-1", 3, new DateTime(2021, 12, 15, 18, 20, 59, 253, DateTimeKind.Unspecified).AddTicks(4701), new DateTime(2021, 8, 3, 13, 29, 48, 65, DateTimeKind.Unspecified).AddTicks(2252) },
                    { 63, 2, "YT31342-0", 3, new DateTime(2021, 9, 21, 11, 44, 23, 877, DateTimeKind.Unspecified).AddTicks(345), new DateTime(2021, 7, 30, 12, 34, 27, 418, DateTimeKind.Unspecified).AddTicks(9018) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 74, 1, "YT11180-1", 3, new DateTime(2021, 12, 1, 8, 50, 44, 364, DateTimeKind.Unspecified).AddTicks(6862), new DateTime(2021, 5, 10, 12, 45, 52, 757, DateTimeKind.Unspecified).AddTicks(4500) },
                    { 77, 3, "YT97846-1", 3, new DateTime(2021, 9, 14, 14, 38, 24, 44, DateTimeKind.Unspecified).AddTicks(8330), new DateTime(2021, 8, 5, 19, 4, 15, 182, DateTimeKind.Unspecified).AddTicks(5411) },
                    { 78, 5, "YT16436-1", 3, new DateTime(2021, 9, 29, 12, 13, 17, 641, DateTimeKind.Unspecified).AddTicks(6808), new DateTime(2021, 8, 9, 5, 53, 38, 847, DateTimeKind.Unspecified).AddTicks(2593) },
                    { 85, 4, "YT36068-1", 3, new DateTime(2021, 9, 13, 22, 50, 31, 310, DateTimeKind.Unspecified).AddTicks(6398), new DateTime(2021, 6, 1, 3, 45, 28, 145, DateTimeKind.Unspecified).AddTicks(1765) },
                    { 194, 4, "YT49449-1", 2, new DateTime(2021, 10, 30, 3, 11, 18, 86, DateTimeKind.Unspecified).AddTicks(8524), new DateTime(2021, 5, 17, 15, 0, 13, 198, DateTimeKind.Unspecified).AddTicks(5856) },
                    { 193, 1, "YT28018-0", 2, new DateTime(2021, 11, 17, 10, 27, 39, 865, DateTimeKind.Unspecified).AddTicks(7545), new DateTime(2021, 7, 14, 10, 56, 7, 354, DateTimeKind.Unspecified).AddTicks(194) },
                    { 192, 5, "YT87498-0", 2, new DateTime(2021, 12, 5, 23, 20, 30, 362, DateTimeKind.Unspecified).AddTicks(372), new DateTime(2021, 6, 21, 23, 31, 26, 979, DateTimeKind.Unspecified).AddTicks(1157) },
                    { 191, 2, "YT15051-0", 2, new DateTime(2021, 9, 26, 12, 48, 23, 878, DateTimeKind.Unspecified).AddTicks(3363), new DateTime(2021, 8, 18, 16, 15, 36, 5, DateTimeKind.Unspecified).AddTicks(6390) },
                    { 36, 3, "YT18722-0", 2, new DateTime(2021, 9, 15, 0, 45, 17, 48, DateTimeKind.Unspecified).AddTicks(4302), new DateTime(2021, 7, 17, 21, 11, 14, 665, DateTimeKind.Unspecified).AddTicks(1751) },
                    { 46, 2, "YT31148-1", 2, new DateTime(2021, 9, 24, 12, 54, 11, 573, DateTimeKind.Unspecified).AddTicks(106), new DateTime(2021, 5, 17, 12, 56, 53, 258, DateTimeKind.Unspecified).AddTicks(2330) },
                    { 54, 3, "YT93885-0", 2, new DateTime(2021, 10, 30, 4, 2, 12, 922, DateTimeKind.Unspecified).AddTicks(3060), new DateTime(2021, 5, 24, 13, 32, 13, 670, DateTimeKind.Unspecified).AddTicks(4302) },
                    { 57, 4, "YT38834-0", 2, new DateTime(2021, 9, 2, 23, 44, 30, 335, DateTimeKind.Unspecified).AddTicks(2372), new DateTime(2021, 7, 30, 9, 0, 6, 930, DateTimeKind.Unspecified).AddTicks(6152) },
                    { 67, 5, "YT58815-0", 2, new DateTime(2021, 9, 6, 18, 17, 22, 937, DateTimeKind.Unspecified).AddTicks(2826), new DateTime(2021, 7, 18, 14, 16, 53, 267, DateTimeKind.Unspecified).AddTicks(4442) },
                    { 79, 4, "YT30930-0", 2, new DateTime(2021, 12, 25, 2, 17, 39, 328, DateTimeKind.Unspecified).AddTicks(1278), new DateTime(2021, 6, 30, 22, 34, 19, 828, DateTimeKind.Unspecified).AddTicks(4012) },
                    { 81, 3, "YT36230-0", 2, new DateTime(2021, 11, 23, 10, 11, 44, 73, DateTimeKind.Unspecified).AddTicks(5937), new DateTime(2021, 6, 3, 11, 59, 30, 49, DateTimeKind.Unspecified).AddTicks(258) },
                    { 128, 3, "YT12031-1", 2, new DateTime(2021, 10, 28, 10, 58, 21, 210, DateTimeKind.Unspecified).AddTicks(9881), new DateTime(2021, 8, 19, 14, 44, 26, 459, DateTimeKind.Unspecified).AddTicks(2826) },
                    { 130, 1, "YT55491-1", 2, new DateTime(2021, 10, 15, 4, 56, 55, 190, DateTimeKind.Unspecified).AddTicks(9255), new DateTime(2021, 6, 9, 5, 58, 6, 718, DateTimeKind.Unspecified).AddTicks(5484) },
                    { 137, 5, "YT77602-1", 2, new DateTime(2021, 9, 16, 21, 50, 10, 510, DateTimeKind.Unspecified).AddTicks(7644), new DateTime(2021, 7, 15, 13, 43, 59, 990, DateTimeKind.Unspecified).AddTicks(7193) },
                    { 185, 4, "YT16652-1", 5, new DateTime(2021, 10, 16, 19, 58, 47, 899, DateTimeKind.Unspecified).AddTicks(9753), new DateTime(2021, 7, 13, 0, 11, 47, 66, DateTimeKind.Unspecified).AddTicks(907) },
                    { 138, 3, "YT91398-0", 2, new DateTime(2021, 10, 21, 12, 23, 39, 121, DateTimeKind.Unspecified).AddTicks(2713), new DateTime(2021, 8, 8, 6, 50, 54, 225, DateTimeKind.Unspecified).AddTicks(6098) },
                    { 146, 5, "YT22789-0", 2, new DateTime(2021, 10, 31, 0, 56, 3, 26, DateTimeKind.Unspecified).AddTicks(5401), new DateTime(2021, 6, 12, 8, 17, 47, 276, DateTimeKind.Unspecified).AddTicks(5558) },
                    { 149, 4, "YT72666-0", 2, new DateTime(2021, 9, 22, 1, 26, 52, 0, DateTimeKind.Unspecified).AddTicks(1370), new DateTime(2021, 8, 10, 0, 39, 1, 965, DateTimeKind.Unspecified).AddTicks(2503) },
                    { 153, 1, "YT88892-0", 2, new DateTime(2021, 10, 27, 23, 44, 47, 912, DateTimeKind.Unspecified).AddTicks(1284), new DateTime(2021, 6, 10, 4, 37, 48, 224, DateTimeKind.Unspecified).AddTicks(5854) },
                    { 156, 4, "YT95507-0", 2, new DateTime(2021, 12, 27, 16, 37, 37, 214, DateTimeKind.Unspecified).AddTicks(34), new DateTime(2021, 8, 15, 23, 57, 9, 301, DateTimeKind.Unspecified).AddTicks(4689) },
                    { 160, 4, "YT30193-1", 2, new DateTime(2021, 11, 23, 13, 49, 15, 222, DateTimeKind.Unspecified).AddTicks(10), new DateTime(2021, 7, 19, 21, 11, 28, 394, DateTimeKind.Unspecified).AddTicks(3704) },
                    { 173, 5, "YT50633-1", 2, new DateTime(2021, 11, 3, 4, 21, 11, 922, DateTimeKind.Unspecified).AddTicks(9279), new DateTime(2021, 5, 24, 0, 50, 49, 820, DateTimeKind.Unspecified).AddTicks(312) },
                    { 174, 2, "YT84691-1", 2, new DateTime(2021, 11, 15, 3, 31, 16, 8, DateTimeKind.Unspecified).AddTicks(2572), new DateTime(2021, 6, 13, 7, 38, 22, 722, DateTimeKind.Unspecified).AddTicks(6129) },
                    { 175, 1, "YT45279-1", 2, new DateTime(2021, 12, 16, 16, 52, 33, 184, DateTimeKind.Unspecified).AddTicks(384), new DateTime(2021, 5, 23, 13, 20, 24, 375, DateTimeKind.Unspecified).AddTicks(215) },
                    { 187, 1, "YT48503-0", 2, new DateTime(2021, 11, 27, 19, 44, 20, 244, DateTimeKind.Unspecified).AddTicks(4115), new DateTime(2021, 5, 14, 18, 20, 58, 778, DateTimeKind.Unspecified).AddTicks(4374) },
                    { 188, 1, "YT58203-1", 2, new DateTime(2021, 9, 17, 22, 33, 36, 737, DateTimeKind.Unspecified).AddTicks(1443), new DateTime(2021, 6, 8, 23, 24, 52, 312, DateTimeKind.Unspecified).AddTicks(146) },
                    { 144, 3, "YT52767-0", 2, new DateTime(2021, 10, 11, 19, 18, 36, 907, DateTimeKind.Unspecified).AddTicks(9821), new DateTime(2021, 7, 10, 16, 59, 30, 404, DateTimeKind.Unspecified).AddTicks(6683) },
                    { 197, 1, "YT39386-0", 5, new DateTime(2021, 9, 15, 8, 24, 5, 657, DateTimeKind.Unspecified).AddTicks(5654), new DateTime(2021, 6, 15, 1, 51, 54, 158, DateTimeKind.Unspecified).AddTicks(8779) }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 142, "98482 Rhett Haven", null, "Port Millieshire", null, "B9O 7K3", "NU" },
                    { 55, "5565 Bernard Circles", null, "Herzogland", null, "S3M 5G3", "NB" },
                    { 61, "70299 Runolfsson Meadow", null, "Rathmouth", null, "K1V 5Y9", "NT" },
                    { 126, "4989 Dock Valleys", null, "Adamsberg", null, "X6M 1R6", "PE" },
                    { 152, "2494 Rowe Landing", null, "Port Icie", null, "A6P 8M4", "NL" },
                    { 157, "503 Lambert Road", null, "West Neil", null, "L4G 0A7", "YT" },
                    { 53, "51434 Nickolas Manors", null, "North Damionbury", null, "H1S 7S7", "SK" },
                    { 49, "1851 Lindgren Well", null, "Nicholasport", null, "Y6I 5B7", "QC" },
                    { 162, "1943 Ana Junctions", null, "Lindgrenmouth", null, "L2V 8R5", "PE" },
                    { 51, "2090 Noe Rapids", null, "Alanisville", null, "R3W 8M1", "YT" },
                    { 136, "4654 Smith Road", null, "South Lilianabury", null, "K0G 3V6", "NS" },
                    { 50, "742 Haley Club", null, "New Harrisonville", null, "X1W 0E9", "NT" },
                    { 43, "784 West Views", null, "Port Sid", null, "K9K 8T6", "NU" },
                    { 63, "41357 Valerie Rue", null, "Willshire", null, "H9W 8W7", "SK" },
                    { 163, "2942 Yasmeen Harbor", null, "West Lowellmouth", null, "L5E 4J2", "PE" },
                    { 170, "136 Myrna Curve", null, "Dietrichshire", null, "L6Z 7M2", "NS" },
                    { 155, "76275 Bobby Lodge", null, "South Howard", null, "B6W 7V5", "NL" },
                    { 28, "4690 Dickinson Canyon", null, "Lake Gusview", null, "X2L 6L6", "NL" },
                    { 177, "172 Jenkins Groves", null, "Balistreritown", null, "G3S 7E1", "ON" },
                    { 159, "84188 Murphy Mission", null, "East Donhaven", null, "C6O 9W4", "NB" },
                    { 45, "50257 America Turnpike", null, "Binstown", null, "E6R 0X0", "NU" },
                    { 27, "561 Bartoletti Ports", null, "Port Cedrickfort", null, "G2S 1O2", "NU" },
                    { 178, "129 Bradly Mountain", null, "Gutkowskiburgh", null, "S5M 1B4", "AB" },
                    { 25, "9090 Theo Port", null, "West Estelle", null, "M7O 0K1", "MB" },
                    { 167, "07598 Edison Locks", null, "Cummeratafort", null, "R6L 3H3", "QC" },
                    { 44, "5382 Gibson Terrace", null, "West Wallacetown", null, "V0X 7D5", "YT" },
                    { 181, "1774 Jenkins Camp", null, "Beckerville", null, "R7K 1O8", "NL" },
                    { 39, "5257 Ritchie Run", null, "Marilynetown", null, "E4B 8F2", "SK" },
                    { 40, "872 Thurman Fields", null, "Dooleyberg", null, "S0E 8N2", "NU" },
                    { 151, "83884 Mathilde Dale", null, "East Darenmouth", null, "J1R 5D0", "NT" },
                    { 60, "91163 Veum Haven", null, "North Emeliaburgh", null, "E7O 2W8", "YT" },
                    { 106, "36207 Gaylord Spurs", null, "Bergeview", null, "V3O 4H7", "NB" },
                    { 120, "48812 Gina Rapid", null, "Kutchland", null, "S7Q 6V4", "MB" },
                    { 97, "49944 Heller Squares", null, "Port Kiel", null, "S4X 0R6", "SK" },
                    { 125, "7078 Simonis Center", null, "North Myriam", null, "P0U 3R9", "AB" },
                    { 113, "985 Muhammad Passage", null, "North Jaeden", null, "B7O 8C5", "NU" },
                    { 72, "51096 Ethelyn Wells", null, "West Macyfurt", null, "E5S 9D1", "NB" },
                    { 96, "3381 Summer Mountain", null, "Stephaniefort", null, "L3U 3P5", "NU" },
                    { 131, "0455 Kuhlman Stravenue", null, "Blandaborough", null, "P5N 4G6", "YT" },
                    { 68, "6933 Alphonso Fort", null, "Dickiberg", null, "L4C 4J9", "MB" },
                    { 94, "7329 Schumm Mission", null, "South Shirley", null, "V7Q 4C3", "BC" },
                    { 135, "433 Marcelino Greens", null, "Lillymouth", null, "T2Z 0C5", "AB" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 88, "76377 Kelley Fork", null, "Port Tyson", null, "X9J 8B8", "SK" },
                    { 148, "13739 Schamberger Isle", null, "Considineland", null, "T6L 2J6", "MB" },
                    { 87, "7120 Abelardo Terrace", null, "Jenkinsport", null, "Y5E 2B8", "NL" },
                    { 114, "87956 Itzel Trafficway", null, "New Florence", null, "T3C 1N6", "QC" },
                    { 140, "572 Boyer Pines", null, "VonRuedenfurt", null, "X2P 6R9", "NB" },
                    { 197, "320 Emmerich Union", null, "South Julianaland", null, "E6F 2Z1", "NT" },
                    { 85, "02644 Hilll Circle", null, "Lake Rosalee", null, "S1B 1F1", "NT" },
                    { 66, "6604 Waelchi Junction", null, "West Cordiastad", null, "T6C 1I8", "AB" },
                    { 78, "91786 Pfannerstill Lake", null, "Johathanland", null, "L7Z 5G2", "YT" },
                    { 117, "380 Rodger Street", null, "Dawsonmouth", null, "H4L 3E7", "QC" },
                    { 64, "747 Quitzon Lane", null, "Tamiamouth", null, "V6T 7W0", "BC" },
                    { 145, "3445 Bartoletti Drive", null, "West Alfredo", null, "Y5L 4Z9", "BC" },
                    { 77, "983 Earlene Lake", null, "Bradtkefort", null, "L1F 7Q2", "NL" },
                    { 121, "658 Sigmund Shores", null, "West Elveraland", null, "H0L 1D4", "ON" },
                    { 74, "8921 Mraz Flat", null, "Hardyside", null, "S5V 8P6", "SK" },
                    { 139, "635 Andy Fields", null, "Alvaville", null, "N3A 6G5", "NB" },
                    { 112, "2874 Ezra Motorway", null, "Michaelborough", null, "N4D 0Q2", "BC" },
                    { 20, "7400 Bogan Wells", null, "West Hollisfort", null, "C0Z 9B5", "BC" },
                    { 190, "82902 Kihn Streets", null, "Jedfurt", null, "H8S 9U1", "NL" },
                    { 46, "49873 Spencer Course", null, "New Modestaville", null, "J1V 3G4", "NU" },
                    { 187, "76317 Auer Park", null, "New Pierreville", null, "M0Z 7H8", "NB" },
                    { 29, "767 Violette Trail", null, "North Juneburgh", null, "B2R 5O9", "NS" },
                    { 54, "6505 Hickle Fort", null, "Grantbury", null, "C9V 0A2", "ON" },
                    { 175, "0463 Silas Dale", null, "West Cristalfort", null, "J4G 1U8", "NL" },
                    { 189, "18107 Erich Station", null, "Osbornehaven", null, "P1N 4E3", "QC" },
                    { 57, "921 Ritchie View", null, "Tarynstad", null, "P4P 6U3", "NB" },
                    { 174, "5947 Prohaska Forest", null, "New Morgan", null, "M2X 0D0", "MB" },
                    { 67, "869 Lebsack Ville", null, "Schaeferburgh", null, "T4N 5F8", "QC" },
                    { 173, "8768 Sam Mill", null, "Leannfurt", null, "R4N 5L7", "NB" },
                    { 198, "27522 Federico Well", null, "Moriahton", null, "L4G 2S9", "ON" },
                    { 12, "58873 Rowe Station", null, "Tamiaville", null, "L8Z 8T5", "BC" },
                    { 186, "9414 Rhiannon Parkway", null, "Port Abbigail", null, "N8M 4F7", "NT" },
                    { 79, "414 Nader Cape", null, "Rowlandchester", null, "V2R 8Q8", "MB" },
                    { 9, "47436 William Extension", null, "Betsytown", null, "C3D 5P5", "NS" },
                    { 156, "178 Maybell Summit", null, "Hackettport", null, "J9B 2L8", "NT" },
                    { 81, "992 Powlowski Extensions", null, "Rosannabury", null, "C1A 1C5", "NS" },
                    { 128, "81374 Batz Unions", null, "Port Bonitafurt", null, "V2D 0E1", "NB" },
                    { 153, "694 Dolly Bypass", null, "Marinafurt", null, "N9Z 6O9", "ON" },
                    { 130, "854 Darren Run", null, "McCulloughstad", null, "M8Z 5Y3", "MB" },
                    { 199, "37006 Tatyana Ridge", null, "North Augustus", null, "Y4U 6V9", "NS" },
                    { 137, "3524 Kiel Stream", null, "West Bridgette", null, "V5F 7R0", "AB" },
                    { 149, "276 Paula Drive", null, "Ikestad", null, "G6B 5M6", "SK" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 1, "1472 Emery Hollow", null, "Rebaborough", null, "H5E 9L7", "NU" },
                    { 138, "70297 Ziemann Hills", null, "Willyfurt", null, "K5Q 9D0", "BC" },
                    { 146, "9350 Mohammad Plaza", null, "East Joesph", null, "A3U 4E6", "AB" },
                    { 160, "89984 Hansen Forge", null, "Hageneshaven", null, "M5D 7M6", "NT" },
                    { 18, "67231 Erdman Branch", null, "Langville", null, "B9A 5V9", "NL" },
                    { 188, "40252 Kristofer Junction", null, "New Laury", null, "H3L 4B9", "MB" },
                    { 30, "247 Nitzsche Courts", null, "Lake Alycia", null, "A7X 5C2", "PE" },
                    { 16, "867 Elaina Hill", null, "North Forrestchester", null, "A0W 0G1", "NT" },
                    { 37, "917 Barrows Hollow", null, "Oletaport", null, "K6B 5F4", "SK" },
                    { 10, "4698 Doyle Squares", null, "Narcisofort", null, "K6Y 1R7", "ON" },
                    { 171, "386 Raphaelle Islands", null, "New Alford", null, "N3X 0X4", "YT" },
                    { 195, "358 Landen Forest", null, "West Myrtlestad", null, "A7U 9A4", "ON" },
                    { 7, "6536 Alexandra Corners", null, "Coleton", null, "K3G 7H0", "NT" },
                    { 35, "631 Turner Knoll", null, "Jakobton", null, "H8H 4B0", "BC" },
                    { 176, "2831 Weston Heights", null, "Lake Jasonborough", null, "C2T 7R6", "NS" },
                    { 200, "843 Reagan Motorway", null, "Lake Gonzaloshire", null, "B1B 9I6", "NT" },
                    { 3, "03147 Hermann Drive", null, "South Isabel", null, "R1Q 4F9", "NL" },
                    { 4, "94946 Mya Ferry", null, "Donnellyfurt", null, "M1H 5O8", "AB" },
                    { 180, "2497 Carleton Islands", null, "South Edna", null, "G2T 1N3", "AB" },
                    { 36, "437 Terrence Locks", null, "Chloeville", null, "N1Q 5B1", "ON" },
                    { 8, "3403 Armstrong Mill", null, "Coryburgh", null, "E9R 5N3", "BC" },
                    { 196, "41128 Senger Islands", null, "Millsville", null, "L3B 7E5", "MB" },
                    { 17, "3382 Connelly Meadow", null, "Corbinstad", null, "K8S 9B8", "NL" },
                    { 194, "321 Larissa Ranch", null, "Reynoldsburgh", null, "H0N 6W2", "NB" },
                    { 33, "632 Luettgen Square", null, "Garthhaven", null, "V2L 0D9", "MB" },
                    { 22, "45881 Aufderhar Walk", null, "Robertsberg", null, "A9I 5K8", "NB" },
                    { 193, "284 Bertram Mews", null, "Christopside", null, "T1T 4W1", "AB" },
                    { 192, "810 Tillman Courts", null, "South Kiaramouth", null, "M6Z 6T8", "NL" },
                    { 182, "867 Moen Plaza", null, "Lake Karlfurt", null, "A7G 7Y9", "QC" },
                    { 32, "902 Anita Extensions", null, "New Mallory", null, "E4V 2R7", "NT" },
                    { 23, "09392 Mills Knoll", null, "Lake Rigobertoland", null, "S6C 0R3", "YT" },
                    { 191, "577 Osborne Route", null, "Ceasarfort", null, "H7H 4R9", "YT" },
                    { 31, "79548 Rossie Via", null, "North Dakota", null, "X7W 6C0", "NU" },
                    { 34, "70818 Windler Roads", null, "Schmidtfort", null, "B1Q 2K5", "ON" },
                    { 84, "2941 Dina Islands", null, "Velvamouth", null, "X4R 6B4", "PE" },
                    { 144, "746 Orrin Place", null, "Port Milesburgh", null, "Y1W 5V0", "NB" },
                    { 119, "0559 Efrain Mountains", null, "Joyburgh", null, "B1R 6R8", "BC" },
                    { 71, "8591 Stroman Path", null, "Port Rhoda", null, "N5S 6Q9", "YT" },
                    { 172, "596 Jones Trace", null, "West Milesfort", null, "R4W 1K8", "QC" },
                    { 59, "01658 Veum Village", null, "Port Buddy", null, "Y9B 5X7", "NL" },
                    { 122, "0130 Halle Forks", null, "West Jonatan", null, "V2J 2B4", "YT" },
                    { 143, "9478 Zieme Harbor", null, "Lake Jamirberg", null, "J6W 3V8", "NB" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 95, "5635 Remington Place", null, "Ziemannview", null, "L7Z 2Q6", "AB" },
                    { 183, "070 Kling Wall", null, "South Genovevafort", null, "E3F 3N0", "BC" },
                    { 73, "742 Eldridge Station", null, "Ziemeburgh", null, "R8O 6A6", "NT" },
                    { 38, "61199 Deangelo Neck", null, "Wilkinsonmouth", null, "T1Z 3N0", "ON" },
                    { 147, "4685 Darlene Stravenue", null, "Lake Joshua", null, "V6L 3N7", "NU" },
                    { 179, "541 Fadel Locks", null, "North Davonteton", null, "K0O 1T4", "PE" },
                    { 141, "569 Rempel Knoll", null, "Henribury", null, "E8G 0U3", "NB" },
                    { 82, "448 Mertz Manors", null, "Allyfort", null, "H4V 3F5", "NT" },
                    { 134, "88591 Elsa Burgs", null, "East Jolie", null, "E2J 7R4", "NL" },
                    { 166, "31930 Carmel Key", null, "New Murray", null, "N6T 1V0", "ON" },
                    { 6, "838 Torp Greens", null, "Rogerstown", null, "J7W 1W7", "QC" },
                    { 24, "779 Wisoky Village", null, "Delphiabury", null, "J7R 4J6", "QC" },
                    { 109, "55127 Boehm Grove", null, "West Ryley", null, "J2P 1Z9", "NU" },
                    { 133, "5365 Feeney Gateway", null, "Lake Zitabury", null, "V7J 0M7", "ON" },
                    { 184, "9921 Hillary Park", null, "New Jaidaside", null, "E1W 6N0", "NL" },
                    { 75, "96999 Ritchie Street", null, "Russelmouth", null, "A6S 3K4", "NS" },
                    { 132, "376 Balistreri Terrace", null, "South Nathanieltown", null, "J9F 2A0", "NS" },
                    { 169, "2880 MacGyver Extension", null, "Cruickshankbury", null, "L9C 3E9", "QC" },
                    { 123, "89778 Block Shores", null, "West Lauraport", null, "Y7G 5Y8", "MB" },
                    { 129, "333 Little Greens", null, "Port Lawson", null, "A3H 2T6", "SK" },
                    { 48, "3897 Myrna Forge", null, "Port Loy", null, "M5T 0S8", "NU" },
                    { 164, "1970 Easter Fields", null, "Veumbury", null, "M4V 7L8", "MB" },
                    { 47, "93823 Bessie Gardens", null, "Shanahanland", null, "X6Q 9K6", "SK" },
                    { 161, "8606 Wuckert Meadow", null, "Julesport", null, "S2X 0H2", "AB" },
                    { 76, "80059 Metz Route", null, "Aufderharshire", null, "Y5M 6Y6", "QC" },
                    { 80, "18497 Manuela Crossing", null, "Rathland", null, "L3A 2C3", "NU" },
                    { 42, "359 Heidenreich Mission", null, "Zulaufmouth", null, "X7H 7G5", "NB" },
                    { 158, "734 Eldred Brooks", null, "Lake Assuntamouth", null, "T2B 4Y2", "NB" },
                    { 62, "683 Noble Keys", null, "Douglasport", null, "A8T 2J1", "MB" },
                    { 56, "686 Hammes Trail", null, "East Vivienne", null, "C7L 2F5", "NL" },
                    { 127, "07020 Legros Lane", null, "South Lizeth", null, "L5Q 8D6", "QC" },
                    { 65, "078 Bauch Causeway", null, "South Terrenceton", null, "X3P 7Y3", "SK" },
                    { 41, "4428 Hirthe Plain", null, "West Eladiomouth", null, "S1P 1L6", "MB" },
                    { 154, "413 Wolf Trace", null, "Schmelerchester", null, "S3F 0Q0", "PE" },
                    { 110, "51287 Jerde Freeway", null, "Jamirstad", null, "B6X 3O5", "NB" },
                    { 168, "62378 Williamson Highway", null, "Jodyport", null, "R6C 0S3", "SK" },
                    { 69, "168 Armstrong Roads", null, "West Cielo", null, "H4G 8Y4", "NS" },
                    { 150, "87272 Nicolas Island", null, "Dietrichberg", null, "A8K 1C0", "BC" },
                    { 86, "4671 Maye Oval", null, "New Lewview", null, "T2G 1F2", "AB" },
                    { 165, "0197 Renner Heights", null, "Port Arvel", null, "K4R 2A9", "NB" },
                    { 58, "90463 Kozey Fields", null, "West Terranceport", null, "Y0N 5M0", "BC" },
                    { 83, "5813 Chyna Forest", null, "New Alessandra", null, "J2M 5I5", "NU" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 70, "567 Marquardt Points", null, "Jeromefort", null, "R9E 6U8", "NL" },
                    { 101, "029 Camryn Mall", null, "Kubstad", null, "T3K 5A9", "PE" },
                    { 115, "6096 O'Reilly Meadow", null, "Lloydmouth", null, "P0O 8Q8", "NB" },
                    { 15, "5927 Diamond Via", null, "Port Shawnland", null, "J2S 2K6", "QC" },
                    { 118, "841 Kuhn Roads", null, "Ziemannville", null, "Y8J 1F6", "NL" },
                    { 105, "797 Gottlieb Drive", null, "New Ebbafurt", null, "G7O 2W5", "NT" },
                    { 93, "1468 Carroll Stream", null, "Ellisstad", null, "K0N 7G8", "NU" },
                    { 185, "793 Mohr Fall", null, "South Rhianna", null, "S7W 3A5", "NL" },
                    { 5, "73392 Hermann Village", null, "West Shanashire", null, "K0U 1F5", "BC" },
                    { 103, "026 Olen Dale", null, "Ikebury", null, "C1M 1N0", "PE" },
                    { 104, "653 Wiza Squares", null, "Laviniabury", null, "R5T 7U6", "NT" },
                    { 107, "00017 Fletcher Via", null, "East Taniaville", null, "M0S 7Y5", "NU" },
                    { 116, "177 Keebler Crossing", null, "Prestonmouth", null, "K3K 7Q3", "NU" },
                    { 52, "975 Stracke Prairie", null, "New Nedton", null, "C5V 1M1", "NT" },
                    { 91, "0466 Sabina Course", null, "North Elenora", null, "N8Q 3X8", "NB" },
                    { 90, "8454 Kaycee Orchard", null, "Cummingsborough", null, "G0I 9S2", "AB" },
                    { 108, "826 Gregg Mount", null, "Dietrichton", null, "B4D 0L3", "YT" },
                    { 111, "5336 Lubowitz Haven", null, "Toyshire", null, "L9M 5E8", "AB" },
                    { 92, "5429 Mark Rapids", null, "Gleasonberg", null, "Y8S 6T5", "YT" },
                    { 98, "69397 Kuphal Prairie", null, "Ivahbury", null, "N3S 0Q4", "NU" },
                    { 21, "788 Sage Vista", null, "Wadeland", null, "L5Z 3G8", "YT" },
                    { 11, "832 Buckridge Junctions", null, "Ardenfort", null, "C9Y 7Z5", "PE" },
                    { 102, "43526 Rippin Grove", null, "South Quinn", null, "J2P 8T3", "YT" },
                    { 26, "4979 Clinton Isle", null, "West Garland", null, "G4D 2D1", "MB" },
                    { 13, "8066 Deontae Via", null, "Schambergerchester", null, "K0M 9W9", "NU" },
                    { 124, "83359 Johns Squares", null, "Hilpertchester", null, "J9O 4O2", "NT" },
                    { 2, "214 Kuvalis Dam", null, "Lake Onie", null, "K6U 0X0", "NU" },
                    { 19, "059 Genoveva Court", null, "New Elizabeth", null, "T1I 0M4", "YT" },
                    { 89, "72146 Myrna Island", null, "Anitaville", null, "M9R 0G2", "MB" },
                    { 99, "8388 Kertzmann River", null, "Kozeymouth", null, "X0U 5K6", "NU" },
                    { 14, "58863 Bosco Brook", null, "Port Brent", null, "L2S 7M8", "SK" },
                    { 100, "7958 Volkman Ramp", null, "West Noemy", null, "J1C 0K2", "PE" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 62, "5827 Klein Villages", null, "Auerburgh", null, "L5I 0V6", "SK" },
                    { 199, "316 Kling Curve", null, "Port Kodystad", null, "N2T 2R6", "ON" },
                    { 194, "134 Rau Vista", null, "New Preston", null, "L8L 0U2", "BC" },
                    { 149, "012 Hayley Motorway", null, "Haagtown", null, "L5B 7I1", "BC" },
                    { 146, "235 Powlowski Terrace", null, "New Damien", null, "J7K 2B2", "NS" },
                    { 192, "5508 Cormier Plaza", null, "Cassinfurt", null, "Y8K 2S2", "NL" },
                    { 26, "86924 Bessie Roads", null, "Madalynside", null, "R8F 8G6", "SK" },
                    { 193, "78052 Considine Fort", null, "Reingerborough", null, "Y2V 9D3", "BC" },
                    { 165, "4682 Stanton Run", null, "New Julian", null, "V2J 0K9", "NB" },
                    { 180, "451 Callie Divide", null, "Lake Thurmanhaven", null, "R1U 9X2", "NT" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 164, "94814 Melyssa Rue", null, "Mannshire", null, "N8T 2E9", "NB" },
                    { 59, "3627 Rigoberto Branch", null, "Sawaynburgh", null, "E2G 4P3", "NL" },
                    { 182, "2037 Kole Unions", null, "Veronicafort", null, "P4Y 7T4", "ON" },
                    { 174, "218 Romaguera Haven", null, "Bruenton", null, "A2R 0T1", "NT" },
                    { 6, "72823 McClure Station", null, "Port Eloisa", null, "H4C 7F4", "MB" },
                    { 189, "2849 Vena Fork", null, "Judgeborough", null, "L1Q 8A0", "ON" },
                    { 58, "03630 Dahlia Spur", null, "East Luzchester", null, "E5N 2D2", "ON" },
                    { 183, "2520 Herbert Centers", null, "Stoltenbergmouth", null, "T3Y 4P4", "SK" },
                    { 13, "50778 Cara Bridge", null, "New Minabury", null, "K8I 9Z8", "PE" },
                    { 175, "09291 Boyer Forges", null, "Gibsonmouth", null, "X3R 4O6", "BC" },
                    { 187, "902 Cruickshank Dale", null, "East Ryleigh", null, "N6T 4V1", "NB" },
                    { 160, "21824 Sonny Plain", null, "Lake Lorenz", null, "X4Z 2T3", "NU" },
                    { 14, "110 Kuvalis Plaza", null, "North Rachelle", null, "A8N 4K4", "AB" },
                    { 186, "647 Audrey Forge", null, "Keaganville", null, "T5P 1X6", "MB" },
                    { 198, "836 Felton Coves", null, "Eldonbury", null, "K6W 5W2", "SK" },
                    { 156, "6679 Dickens View", null, "Wademouth", null, "H8H 3C3", "NU" },
                    { 52, "256 Kerluke Forks", null, "South Hallieshire", null, "H1E 3S3", "NB" },
                    { 169, "3685 Mayer Mission", null, "North Dina", null, "P9P 4Y3", "MB" },
                    { 188, "14481 Kerluke Tunnel", null, "Kosschester", null, "N1N 2A9", "AB" },
                    { 153, "321 Marquardt Skyway", null, "East Lillian", null, "X2E 2T6", "PE" },
                    { 191, "42657 Goldner Brook", null, "Port Tannerborough", null, "E4E 0I2", "NT" },
                    { 15, "5975 Hills Parks", null, "East Domenicview", null, "P5Y 4P6", "YT" },
                    { 19, "602 Champlin Court", null, "Elwyntown", null, "T8F 0P4", "ON" },
                    { 173, "7304 Koepp Rapids", null, "Port Josiah", null, "J0H 1V6", "NU" },
                    { 20, "64034 Maggio Junction", null, "South Octaviaborough", null, "M9N 3X6", "NS" },
                    { 70, "2868 Reichert Avenue", null, "Loweport", null, "E2L 8Y2", "ON" },
                    { 132, "2472 Coy Overpass", null, "South Shanel", null, "R1C 4K8", "SK" },
                    { 61, "502 O'Kon Knoll", null, "Framimouth", null, "X1X 8W3", "NL" },
                    { 63, "4813 Annette Crest", null, "Lake Bertside", null, "A0G 0Y8", "BC" },
                    { 121, "09479 Royal Causeway", null, "Greenfelderside", null, "V6U 9B7", "BC" },
                    { 98, "77042 Elvie Route", null, "Schmitthaven", null, "A3P 2U9", "AB" },
                    { 74, "53678 Gail Gardens", null, "North Jermey", null, "X3L 0O4", "NS" },
                    { 124, "4587 Ollie Turnpike", null, "Emmetberg", null, "G0I 3S0", "YT" },
                    { 77, "5914 Armstrong Point", null, "East Chanelborough", null, "N4J 6O2", "BC" },
                    { 117, "77754 Swift Shoals", null, "Purdyburgh", null, "H0X 6P3", "SK" },
                    { 99, "0122 Brown Road", null, "Filibertotown", null, "X5N 8C9", "NB" },
                    { 78, "31205 Bryana Freeway", null, "South Sheila", null, "R2C 6G3", "QC" },
                    { 118, "274 Schiller Skyway", null, "Wintheiserland", null, "S6H 3S1", "ON" },
                    { 144, "982 Hilll Creek", null, "Padbergfort", null, "V6H 9H9", "ON" },
                    { 85, "2330 Pauline Crescent", null, "Ortizburgh", null, "T8U 0S7", "NB" },
                    { 114, "066 Forrest Turnpike", null, "New Hope", null, "Y3V 6A3", "AB" },
                    { 105, "48568 Tremblay Islands", null, "Julienland", null, "R0X 7V0", "BC" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 87, "5532 Kylie Parks", null, "West Tiaraland", null, "K8I 4I8", "ON" },
                    { 88, "35804 Hamill Shores", null, "West Dorrismouth", null, "G9A 7O8", "NU" },
                    { 107, "38868 Cremin Trail", null, "North Ayla", null, "A9F 0K4", "NB" },
                    { 94, "7895 Ayla Lodge", null, "Rodriguezbury", null, "B7X 0W9", "NL" },
                    { 116, "16135 Zoe Ramp", null, "New Devin", null, "Y9M 3Y9", "AB" },
                    { 113, "63425 Carson Corners", null, "South Ozella", null, "X1I 9C6", "NL" },
                    { 115, "9031 Juana Springs", null, "Wuckertmouth", null, "X6D 6O7", "QC" },
                    { 96, "057 Wallace Meadows", null, "South Abnermouth", null, "P2Z 0M8", "NL" },
                    { 97, "04696 Mark Fort", null, "West Stella", null, "E9W 9R5", "NS" },
                    { 112, "9045 Deanna Plains", null, "Wildermanburgh", null, "R1W 7U1", "QC" },
                    { 108, "88906 Blanche Cliffs", null, "Gaylordstad", null, "V8C 9T0", "AB" },
                    { 106, "83625 Lura Meadows", null, "Padbergchester", null, "E0D 6E6", "BC" },
                    { 110, "9049 Schimmel View", null, "North Reagan", null, "G3L 6F8", "MB" },
                    { 133, "60514 Leta Forges", null, "Haagburgh", null, "P4N 7Y2", "AB" },
                    { 196, "79472 Hassie Lake", null, "Lake Vance", null, "P5S 6L7", "NL" },
                    { 126, "2471 Dayana Knolls", null, "New Edwardberg", null, "E7Y 9L5", "YT" },
                    { 51, "95169 Reynolds Throughway", null, "Wizafurt", null, "P8M 2J1", "NS" },
                    { 4, "0618 Eric Plains", null, "Clarabellestad", null, "H3T 7K5", "BC" },
                    { 176, "93892 Welch Parkway", null, "West Ettieland", null, "S8H 7O8", "NB" },
                    { 161, "7787 Ledner Islands", null, "Nicolaside", null, "A6F 1N1", "NB" },
                    { 171, "3115 Harris Street", null, "Stephanieville", null, "C4H 0H1", "AB" },
                    { 76, "773 Rau Rue", null, "McGlynnstad", null, "N8R 4L3", "NT" },
                    { 7, "789 Emard Street", null, "Gillianmouth", null, "L5Q 1R1", "QC" },
                    { 158, "0859 Leora Corners", null, "East Kane", null, "C2H 4J3", "PE" },
                    { 10, "52160 Brown Mount", null, "West Mozelle", null, "J1E 6C4", "YT" },
                    { 80, "724 Tatyana Street", null, "Eugeniabury", null, "K2L 4B6", "NU" },
                    { 16, "7457 O'Kon Heights", null, "Estebanside", null, "V6P 1Q2", "NT" },
                    { 18, "062 Jaylen Burgs", null, "Marquardtbury", null, "K3G 5D5", "YT" },
                    { 154, "99213 Nigel Coves", null, "New Kane", null, "C9S 4X9", "NU" },
                    { 167, "687 Elyse Port", null, "East Bernita", null, "E8J 3L0", "AB" },
                    { 150, "9809 Lucius Shore", null, "Port Barrettmouth", null, "A9O 3J8", "SK" },
                    { 25, "6336 Lafayette Via", null, "South Arjun", null, "S4B 1X5", "NB" },
                    { 159, "135 Dashawn Rest", null, "Noreneberg", null, "L8A 2W2", "NT" },
                    { 147, "60631 Volkman Mountain", null, "Port Lottieton", null, "K3J 0P7", "NB" },
                    { 27, "69782 Jimmy Dale", null, "West Mateochester", null, "H4I 6R2", "QC" },
                    { 86, "3050 Archibald Grove", null, "Marleyburgh", null, "G9O 4M3", "PE" },
                    { 155, "8570 Nikki Glen", null, "East Donna", null, "L8X 5S5", "BC" },
                    { 143, "791 Kutch View", null, "West Eleonore", null, "L6R 7X3", "NT" },
                    { 28, "50682 Borer Station", null, "Port Ellsworthbury", null, "V9Y 1X8", "ON" },
                    { 39, "7556 Lenora Isle", null, "Celestineborough", null, "G1H 5V9", "AB" },
                    { 95, "51317 Bode Key", null, "Jeradton", null, "T8I 9N6", "NL" },
                    { 43, "812 Karianne Meadow", null, "New Zaneberg", null, "C5Y 0Q4", "NL" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 136, "8057 Keeling Ridge", null, "Ciarafurt", null, "R6I 7T7", "YT" },
                    { 141, "4666 Jerrell Unions", null, "Wintheiserfurt", null, "E1O 4N5", "BC" },
                    { 50, "9524 Jaylin Grove", null, "Lake Jacey", null, "C4P 5B8", "ON" },
                    { 134, "67682 Lakin Way", null, "West Khalil", null, "X9L 8D6", "PE" },
                    { 53, "531 Vandervort Forks", null, "Corwinburgh", null, "J2W 4K4", "SK" },
                    { 197, "956 Gulgowski Union", null, "North Camron", null, "E3S 0H9", "NS" },
                    { 130, "3260 Weimann Ways", null, "Sydneechester", null, "Y9X 1Y1", "MB" },
                    { 40, "14785 Swift Garden", null, "Port Rebecca", null, "G5C 8L5", "YT" },
                    { 162, "27155 Stehr Trail", null, "Port Noahview", null, "V2K 6N8", "NT" },
                    { 83, "59449 Kshlerin Flats", null, "Gretaburgh", null, "X7A 4X3", "NB" },
                    { 109, "7531 Hulda Curve", null, "Lake Bettie", null, "S5X 0V0", "MB" },
                    { 82, "8678 Junior Skyway", null, "Maureenchester", null, "P6T 2D6", "SK" },
                    { 163, "34597 Louie Roads", null, "South Arden", null, "G5Q 8G6", "NU" },
                    { 75, "297 Summer Mountain", null, "Millsview", null, "X3G 7U9", "YT" },
                    { 73, "469 Dasia Junction", null, "South Clemmie", null, "V0Y 2Z4", "NS" },
                    { 170, "415 Hahn Parks", null, "Koelpinberg", null, "R0V 8P2", "SK" },
                    { 177, "38665 Sasha Mission", null, "South Aprilmouth", null, "M9N 3R0", "NU" },
                    { 71, "307 Mariam Inlet", null, "Edythebury", null, "N9F 9R5", "MB" },
                    { 122, "67668 Berge Manors", null, "Fredyview", null, "N5K 7S0", "BC" },
                    { 45, "2030 Khalil Spur", null, "South Karlee", null, "B6B 0N2", "NL" },
                    { 49, "895 Gladys Lane", null, "North Haydenville", null, "A5K 1K3", "SK" },
                    { 123, "0187 Waters Port", null, "Connellybury", null, "N6T 2D3", "NU" },
                    { 178, "6815 Lonzo Valleys", null, "Lake Wilburn", null, "M8P 0B5", "QC" },
                    { 44, "302 Isadore Lights", null, "Tarynburgh", null, "H1M 9W4", "SK" },
                    { 181, "6620 Cleve Vista", null, "Lake Dalefurt", null, "L8P 8E5", "PE" },
                    { 65, "98119 Jo Cliffs", null, "West Ellen", null, "A5V 2K9", "AB" },
                    { 56, "847 O'Keefe Ridges", null, "Coralieview", null, "L7M 0J5", "NL" },
                    { 127, "27096 Paul Way", null, "Haagville", null, "B5H 1C6", "NS" },
                    { 190, "394 Breitenberg Summit", null, "Orlobury", null, "L4X 3N1", "YT" },
                    { 37, "72158 Legros Avenue", null, "Bethanyburgh", null, "N8F 8N1", "SK" },
                    { 195, "8808 Kunze Walk", null, "South Ned", null, "L1I 2F6", "YT" },
                    { 35, "87201 McClure Station", null, "New Columbus", null, "G4Z 4U8", "NL" },
                    { 48, "899 McGlynn Gateway", null, "New Vinnie", null, "J8Z 9W9", "NT" },
                    { 129, "1306 Orion Lock", null, "Parkerview", null, "T7D 2P2", "PE" },
                    { 69, "50054 Alexandra Forks", null, "Jadenborough", null, "B4H 5O4", "NS" },
                    { 90, "806 Goyette Trace", null, "North Colby", null, "H6U 0N2", "QC" },
                    { 102, "32786 Herzog River", null, "New Bailey", null, "L3Y 8M3", "NS" },
                    { 157, "71240 Dee Fall", null, "Gibsonview", null, "X1I 7K0", "YT" },
                    { 125, "6617 Sydni Summit", null, "Lindhaven", null, "H3H 7C8", "MB" },
                    { 72, "26807 Michelle Inlet", null, "West Lilliefurt", null, "H8S 3T2", "NB" },
                    { 68, "74178 Littel Gardens", null, "North Cleora", null, "T5D 5S7", "NB" },
                    { 131, "731 Kuhic Plains", null, "Katlynport", null, "L7Z 6V2", "NT" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 135, "017 Emmie Isle", null, "East Madelynn", null, "M1J 9L6", "NB" },
                    { 119, "876 Seth Pines", null, "West Nona", null, "B8U 5U6", "QC" },
                    { 84, "8954 Cesar Rue", null, "New Lucyhaven", null, "R2L 1G9", "MB" },
                    { 111, "7879 Hobart Run", null, "Metzshire", null, "H8S 5B7", "PE" },
                    { 139, "212 Grady Circles", null, "Ambermouth", null, "R2G 3O8", "ON" },
                    { 140, "5187 Parker Inlet", null, "Ellieview", null, "V9A 2H9", "NT" },
                    { 89, "553 Malcolm Road", null, "New Ashton", null, "P8Z 8C8", "AB" },
                    { 104, "8503 Brekke Well", null, "Zulaufshire", null, "T2W 9I1", "MB" },
                    { 66, "560 Brekke Mount", null, "Tessieland", null, "V2X 6T2", "NS" },
                    { 142, "59057 Daphne Locks", null, "O'Reillytown", null, "J4H 9E5", "SK" },
                    { 91, "4671 Pascale Camp", null, "New Shaynafurt", null, "V1O 6D6", "NL" },
                    { 103, "048 Lance Court", null, "Port Asha", null, "R5A 3D2", "ON" },
                    { 64, "272 Preston Course", null, "Lake Kristianville", null, "E2Y 4J7", "YT" },
                    { 145, "7824 Mackenzie Pike", null, "East Evansburgh", null, "N9Z 2P8", "NU" },
                    { 93, "0538 Maurice Station", null, "Connland", null, "X8H 5A9", "BC" },
                    { 60, "307 Cartwright Lakes", null, "Barrowstown", null, "S0L 7R9", "YT" },
                    { 148, "0696 Novella Rue", null, "West Sunnychester", null, "K3Q 4A6", "QC" },
                    { 101, "8849 Santos Stream", null, "Jeremyview", null, "H2Q 7F8", "NT" },
                    { 151, "321 Jast Ways", null, "East Retta", null, "Y4Q 4E6", "NU" },
                    { 100, "84575 Charlotte Springs", null, "Howestad", null, "S5Y 4I5", "BC" },
                    { 92, "4153 Beer Crossroad", null, "West Lisa", null, "S6L 7L8", "NB" },
                    { 55, "7475 West Cliffs", null, "Lake Jaynehaven", null, "S0G 7F8", "ON" },
                    { 152, "92851 Kuphal Common", null, "South Verniefurt", null, "L9C 7A6", "NB" },
                    { 200, "422 Velma Forks", null, "New Jacynthe", null, "R4M 7L4", "ON" },
                    { 47, "04232 Kevon Row", null, "Port Makaylastad", null, "R0K 0L5", "NL" },
                    { 120, "285 Jamal Well", null, "North Wilbert", null, "P9J 7K6", "NU" },
                    { 34, "151 Lura Street", null, "Port Ethelyntown", null, "E0U 7J6", "AB" },
                    { 23, "7797 Quentin Plains", null, "Port Kylee", null, "G2R 1W6", "YT" },
                    { 38, "189 Verda Isle", null, "Breitenbergland", null, "N8A 7U9", "PE" },
                    { 30, "214 Jones Junctions", null, "Fosterport", null, "L5D 4W8", "PE" },
                    { 36, "7962 Bryana Lodge", null, "Wilsonstad", null, "G3C 6K5", "ON" },
                    { 179, "82562 Nels Stravenue", null, "Sanfordview", null, "S7R 9G5", "QC" },
                    { 46, "53776 Hellen Prairie", null, "Port Craigfurt", null, "B2K 0A9", "NT" },
                    { 24, "616 Stamm Mission", null, "North Bertmouth", null, "B4P 2R4", "NU" },
                    { 3, "9590 Trantow Estates", null, "McDermottmouth", null, "A9S 9U7", "MB" },
                    { 54, "1159 Hartmann Trail", null, "Evanbury", null, "M7X 8K6", "NL" },
                    { 11, "231 Elijah Dam", null, "North Walkerstad", null, "V8T 3U7", "NU" },
                    { 57, "4114 Giles Plain", null, "Melanyview", null, "E6N 0E6", "NT" },
                    { 184, "3194 Greenholt Mountains", null, "West Katlynnland", null, "J6A 1X9", "PE" },
                    { 67, "364 Burley Pines", null, "North Alessandra", null, "K6B 4X3", "NU" },
                    { 12, "4147 Sharon Lakes", null, "Janiyashire", null, "M1T 9Q3", "QC" },
                    { 79, "8239 Joanie Ferry", null, "South Aidanside", null, "J6J 6T2", "BC" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 5, "478 Daugherty Flat", null, "Hilllshire", null, "M2L 4W1", "ON" },
                    { 9, "85547 Hackett Fords", null, "Chayamouth", null, "N1M 6P5", "SK" },
                    { 81, "8035 Nash Freeway", null, "Juliatown", null, "K9Z 9D4", "QC" },
                    { 128, "527 Altenwerth Cove", null, "South Heloisebury", null, "N6K 2I2", "MB" },
                    { 21, "2075 Hansen Junction", null, "Heathcotemouth", null, "N1R 3M0", "PE" },
                    { 137, "36607 Larson Villages", null, "South Wendy", null, "T1O 7B0", "NT" },
                    { 185, "8100 Angelo Haven", null, "Lake Abraham", null, "G4U 0G6", "NB" },
                    { 1, "9665 Kuhn Place", null, "Boganfurt", null, "K7U 1C2", "NS" },
                    { 2, "323 Kemmer Corner", null, "Alexzanderbury", null, "K4Z 1M4", "SK" },
                    { 138, "66197 Heller Port", null, "West Laurenceberg", null, "M7B 9D0", "QC" },
                    { 31, "939 Jerald Inlet", null, "Rolfsonbury", null, "P0A 6F0", "NS" },
                    { 172, "64343 Emmanuelle Springs", null, "South Percyborough", null, "A4T 0C4", "NB" },
                    { 29, "21338 Cydney Vista", null, "South Enriqueview", null, "L4I 0X1", "SK" },
                    { 168, "99785 Vita Burg", null, "Lake Agustinaport", null, "S6L 6K2", "AB" },
                    { 33, "4240 Wehner Circles", null, "Rodriguezport", null, "S3D 8C2", "ON" },
                    { 41, "7698 Kertzmann Drives", null, "Eliseobury", null, "T8V 4O9", "BC" },
                    { 17, "9267 Mante Cliff", null, "South Shad", null, "V7B 8K0", "YT" },
                    { 42, "273 Rippin Bridge", null, "Port Maia", null, "J0G 5Q3", "YT" },
                    { 22, "15612 Lauryn Drive", null, "Parisianchester", null, "S4P 0G9", "NU" },
                    { 32, "885 Will Wall", null, "Paigehaven", null, "T0O 4V9", "PE" },
                    { 8, "33807 Harber Forks", null, "North Bert", null, "E4G 2K6", "NU" },
                    { 166, "874 Jacobs Neck", null, "Astridbury", null, "K7I 3C6", "PE" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 141, "Exercitationem architecto optio voluptatem voluptatem nesciunt nobis.", 185, 13231m, "Liquid", "Kg" },
                    { 72, "Provident quod ut iure.", 107, 5981m, "Gas", "Kg" },
                    { 211, "Rem est rem.", 129, 15422m, "Gas", "L" },
                    { 356, "Corporis placeat non molestiae corrupti blanditiis architecto sit et ut.", 129, 14319m, "Solid", "Kg" },
                    { 406, "Sint delectus perferendis et ea.", 108, 1259m, "Gas", "L" },
                    { 5, "Eaque occaecati et.", 108, 968m, "Solid", "L" },
                    { 487, "Consequatur placeat minus necessitatibus delectus.", 91, 10544m, "Solid", "L" },
                    { 400, "Dolores laborum eaque sed nobis.", 185, 4880m, "Liquid", "L" },
                    { 410, "Accusamus molestiae id beatae cum suscipit at.", 185, 2160m, "Liquid", "L" },
                    { 482, "Dolores similique rerum nihil nostrum.", 91, 4429m, "Gas", "Kg" },
                    { 190, "Qui officiis itaque.", 58, 6424m, "Solid", "L" },
                    { 465, "Et saepe quo soluta.", 93, 8274m, "Liquid", "L" },
                    { 385, "Aperiam suscipit alias magnam nam fugit voluptatem sequi.", 172, 19157m, "Solid", "Kg" },
                    { 417, "Temporibus et ea minus velit.", 129, 2106m, "Gas", "Kg" },
                    { 212, "Magnam magnam quis.", 76, 2319m, "Gas", "Kg" },
                    { 446, "Laudantium rerum veritatis laudantium suscipit cum molestias ad sint ab.", 197, 15143m, "Solid", "Kg" },
                    { 367, "Fugit omnis cumque nulla ut et voluptatibus.", 197, 16313m, "Liquid", "L" },
                    { 225, "Sunt vitae nihil sed.", 166, 14416m, "Gas", "L" },
                    { 213, "Vitae modi explicabo inventore et perspiciatis.", 84, 5507m, "Liquid", "L" },
                    { 280, "Ut cum aliquid quia consequatur dolore labore aut sunt.", 84, 5716m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 435, "Et excepturi porro et inventore neque laudantium enim itaque.", 84, 11653m, "Gas", "L" },
                    { 170, "Praesentium non et consequatur error et.", 52, 9523m, "Solid", "L" },
                    { 490, "Voluptatem aut quisquam laudantium ut.", 84, 2720m, "Gas", "L" },
                    { 33, "Consequuntur possimus fugit adipisci facilis vero minus.", 112, 19471m, "Solid", "Kg" },
                    { 127, "Et quos aut fugit dolorum accusamus non voluptas.", 197, 10293m, "Gas", "L" },
                    { 335, "Corrupti quibusdam repellat tempore suscipit reprehenderit aut ut.", 89, 1886m, "Solid", "Kg" },
                    { 486, "Voluptatibus necessitatibus aut doloremque quasi sit provident molestiae.", 70, 4573m, "Gas", "Kg" },
                    { 135, "Ut et eligendi.", 105, 305m, "Solid", "L" },
                    { 96, "Ut perspiciatis sit qui ea asperiores non enim.", 70, 878m, "Liquid", "L" },
                    { 217, "Et non dolores.", 112, 16593m, "Solid", "Kg" },
                    { 86, "Deserunt quos occaecati pariatur quidem quae qui quis.", 105, 18263m, "Gas", "L" },
                    { 22, "Maxime explicabo molestiae aut iste et.", 185, 18711m, "Solid", "Kg" },
                    { 57, "Voluptatem rem qui.", 185, 11641m, "Gas", "Kg" },
                    { 110, "Sint magnam et qui ut consequatur dolores enim tenetur expedita.", 59, 4508m, "Solid", "L" },
                    { 122, "Perferendis praesentium eaque.", 98, 11661m, "Gas", "L" },
                    { 243, "Minus quam sunt rerum.", 59, 16165m, "Solid", "L" },
                    { 387, "Ut rem delectus ea et quis quod quisquam cum.", 127, 10566m, "Liquid", "Kg" },
                    { 21, "Unde cupiditate porro.", 113, 6099m, "Liquid", "Kg" },
                    { 326, "Repellendus exercitationem ad doloribus perferendis aut.", 122, 16290m, "Gas", "L" },
                    { 194, "Rerum similique consequatur et beatae veritatis at.", 184, 4390m, "Solid", "Kg" },
                    { 361, "Beatae optio reiciendis iure dicta odio hic laboriosam.", 122, 1965m, "Gas", "L" },
                    { 111, "Qui beatae ea.", 172, 15395m, "Gas", "Kg" },
                    { 403, "Laborum sit optio enim iusto tempore et possimus dolorem dolor.", 86, 8581m, "Liquid", "Kg" },
                    { 189, "Ducimus nostrum iure necessitatibus assumenda temporibus dignissimos iure.", 95, 12741m, "Solid", "L" },
                    { 154, "Exercitationem placeat ut doloribus debitis laudantium voluptatum recusandae ab.", 127, 4172m, "Gas", "L" },
                    { 48, "Et et dolorem pariatur maiores iure debitis autem voluptas.", 123, 11003m, "Liquid", "L" },
                    { 365, "Dolores ut nihil doloremque porro rerum sed vitae consectetur.", 123, 8577m, "Solid", "Kg" },
                    { 437, "Facere rerum quis.", 122, 5722m, "Solid", "L" },
                    { 492, "A illo rerum minima quibusdam iusto inventore.", 109, 18845m, "Gas", "Kg" },
                    { 346, "Ducimus ipsum velit praesentium laudantium tempore deleniti omnis.", 98, 11749m, "Solid", "Kg" },
                    { 351, "Quos iusto ipsa aliquid earum.", 109, 4919m, "Gas", "Kg" },
                    { 182, "Voluptas voluptates quis et illo in neque est.", 172, 9691m, "Liquid", "Kg" },
                    { 234, "Exercitationem modi velit asperiores incidunt sit fugit.", 58, 1921m, "Gas", "L" },
                    { 128, "Error minus voluptatem ipsam necessitatibus voluptatem ut aut quisquam id.", 102, 12387m, "Gas", "L" },
                    { 10, "Repellat iure vero assumenda cum optio qui ipsum.", 185, 5516m, "Solid", "L" },
                    { 11, "Laudantium qui veritatis voluptas et quidem porro.", 168, 6757m, "Liquid", "L" },
                    { 270, "Officiis eum nihil.", 80, 8402m, "Liquid", "Kg" },
                    { 55, "Sapiente nemo et consequatur id qui.", 99, 3653m, "Liquid", "Kg" },
                    { 54, "Omnis ea quo velit.", 99, 1184m, "Gas", "Kg" },
                    { 276, "Omnis reprehenderit voluptatibus ducimus minus aut est quia aperiam voluptas.", 102, 7144m, "Liquid", "L" },
                    { 208, "Autem corporis distinctio praesentium quos enim minima accusantium quos odit.", 129, 11500m, "Gas", "Kg" },
                    { 394, "Quam velit illum rerum laudantium adipisci ut consectetur odit.", 102, 4103m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 149, "Nihil dolores consequuntur reiciendis officiis aut aliquam quo.", 129, 13741m, "Liquid", "L" },
                    { 304, "Autem cum illum rerum aliquam non maiores velit alias.", 184, 2136m, "Solid", "L" },
                    { 290, "Est officiis dolor qui ut occaecati eum at.", 109, 8322m, "Liquid", "L" },
                    { 297, "Eaque doloribus nulla hic.", 86, 7474m, "Solid", "L" },
                    { 50, "Sit velit delectus corrupti dolorum magni.", 80, 5512m, "Solid", "Kg" },
                    { 256, "Veritatis dolorum quo quia quibusdam et et quisquam repudiandae.", 1, 4832m, "Solid", "L" },
                    { 343, "Vitae aliquid dolores.", 66, 10805m, "Gas", "Kg" },
                    { 28, "Ut veritatis suscipit.", 84, 18394m, "Liquid", "L" },
                    { 307, "Aut rerum iure delectus reprehenderit qui ratione nulla.", 33, 12826m, "Gas", "Kg" },
                    { 375, "Quaerat vitae ut itaque autem voluptas sed veritatis id.", 33, 14318m, "Solid", "L" },
                    { 463, "Repellat nemo est itaque sed ratione fuga officia esse aut.", 182, 8718m, "Solid", "L" },
                    { 459, "Voluptatem molestias quos officiis debitis assumenda quia eum tempora debitis.", 182, 13923m, "Gas", "Kg" },
                    { 151, "In ea aliquid est.", 34, 16191m, "Solid", "Kg" },
                    { 264, "Deleniti culpa quibusdam itaque illo dolorum voluptatem nemo.", 34, 12739m, "Liquid", "L" },
                    { 266, "Et deserunt sequi accusantium officia eveniet dolor.", 34, 2121m, "Liquid", "Kg" },
                    { 278, "Soluta id placeat sunt earum cum itaque ut esse.", 35, 5010m, "Liquid", "L" },
                    { 378, "Esse ipsa omnis ut.", 35, 16479m, "Liquid", "Kg" },
                    { 431, "Animi quo molestiae saepe qui similique sapiente.", 176, 10245m, "Solid", "L" },
                    { 232, "Eum atque deserunt dolore laudantium harum vel.", 176, 4210m, "Gas", "L" },
                    { 16, "Vel sunt rem sit dolorum.", 37, 9219m, "Solid", "Kg" },
                    { 36, "Ipsum odio illum dolores ea inventore quia.", 37, 3716m, "Liquid", "Kg" },
                    { 488, "Quibusdam nihil fugit consequuntur qui.", 171, 2903m, "Solid", "Kg" },
                    { 260, "At voluptas magnam sit aperiam ullam.", 37, 18209m, "Solid", "Kg" },
                    { 476, "Consectetur est ipsum maiores quaerat sed error.", 171, 6393m, "Liquid", "Kg" },
                    { 60, "Iste ullam quo fuga voluptates autem.", 40, 19970m, "Liquid", "Kg" },
                    { 295, "Nostrum temporibus officia ipsa odit voluptatem fugit.", 171, 7068m, "Liquid", "Kg" },
                    { 147, "Fuga dolorum et eius sint dolorem.", 40, 16312m, "Gas", "L" },
                    { 224, "Sed dolore consequatur.", 40, 6049m, "Liquid", "L" },
                    { 90, "Officia ducimus voluptatem in quis dignissimos occaecati eius adipisci.", 171, 17849m, "Gas", "L" },
                    { 24, "Ut et ut aut consequatur facere.", 171, 16624m, "Gas", "Kg" },
                    { 2, "Consectetur accusamus qui provident quia et.", 171, 4934m, "Liquid", "Kg" },
                    { 138, "Dolor ullam aperiam.", 33, 16146m, "Liquid", "Kg" },
                    { 196, "Dolore quis ea similique nulla similique sunt non sunt earum.", 186, 19815m, "Liquid", "Kg" },
                    { 201, "Ut facilis voluptatem consequuntur amet.", 186, 13273m, "Gas", "L" },
                    { 233, "Optio exercitationem dolor rerum.", 186, 6968m, "Liquid", "Kg" },
                    { 254, "Facere ratione dolor eius.", 1, 8815m, "Solid", "Kg" },
                    { 341, "Impedit quia quod.", 1, 14719m, "Solid", "Kg" },
                    { 150, "Hic rem consequuntur non sint ab provident.", 1, 15631m, "Solid", "L" },
                    { 98, "Aut dolor id fugit praesentium reiciendis expedita.", 1, 18792m, "Solid", "L" },
                    { 206, "Natus ipsum dolorem non.", 9, 14283m, "Solid", "Kg" },
                    { 192, "Animi et est in dicta vel aut similique eos hic.", 199, 1155m, "Liquid", "Kg" },
                    { 169, "Architecto necessitatibus in at id.", 199, 13121m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 442, "Praesentium placeat ipsam sint nobis voluptatem minus tenetur blanditiis eos.", 9, 3399m, "Gas", "L" },
                    { 130, "Velit dolorum qui non voluptatum sed nisi aspernatur rerum.", 199, 1932m, "Gas", "Kg" },
                    { 3, "Ut facilis consectetur et vitae incidunt at est.", 12, 5457m, "Gas", "Kg" },
                    { 113, "Totam qui dolores.", 12, 8432m, "Gas", "Kg" },
                    { 313, "Repellat rerum quibusdam consequatur cupiditate sit molestias consectetur voluptatem.", 40, 1999m, "Gas", "Kg" },
                    { 475, "Aliquam possimus exercitationem.", 198, 16518m, "Liquid", "Kg" },
                    { 134, "Neque rerum molestias sequi voluptates nobis velit.", 29, 5970m, "Liquid", "Kg" },
                    { 238, "Deserunt autem commodi quo fuga illo rerum saepe aut voluptatem.", 29, 3642m, "Gas", "Kg" },
                    { 268, "Qui laboriosam ea ut nihil.", 29, 17496m, "Solid", "Kg" },
                    { 283, "Beatae expedita magni exercitationem pariatur exercitationem eos recusandae sed officia.", 29, 3629m, "Gas", "Kg" },
                    { 464, "Nostrum ad est iste.", 189, 17617m, "Liquid", "L" },
                    { 14, "Tempore sapiente id quia vel repellat ipsam deleniti perspiciatis.", 30, 4201m, "Gas", "Kg" },
                    { 288, "Qui sunt voluptate asperiores ipsum voluptates aperiam laboriosam quas.", 189, 4317m, "Liquid", "L" },
                    { 302, "Quia corrupti ea voluptas temporibus fugiat facilis quia.", 30, 7595m, "Solid", "Kg" },
                    { 318, "Voluptatem qui adipisci dolor dolor rem itaque id provident.", 30, 15004m, "Gas", "L" },
                    { 366, "Iure quia consequatur nihil odio fuga provident.", 186, 16042m, "Liquid", "L" },
                    { 282, "Voluptatibus itaque itaque provident in qui nostrum saepe tempore.", 186, 17248m, "Solid", "Kg" },
                    { 125, "Hic doloremque corrupti.", 198, 13147m, "Gas", "Kg" },
                    { 30, "Nesciunt qui iste quia.", 45, 3263m, "Liquid", "L" },
                    { 364, "Sit minus quo qui voluptas quidem vitae est.", 167, 956m, "Solid", "L" },
                    { 99, "Dignissimos rerum enim molestiae ipsam.", 167, 8269m, "Liquid", "Kg" },
                    { 42, "Ea voluptates recusandae dolor adipisci voluptatem recusandae.", 126, 12556m, "Liquid", "Kg" },
                    { 202, "Repellendus possimus eveniet asperiores aut.", 64, 412m, "Liquid", "Kg" },
                    { 291, "Facere officia libero atque voluptas aut qui nulla dolores quis.", 64, 14700m, "Gas", "Kg" },
                    { 156, "Voluptatem fuga omnis enim repudiandae.", 121, 19898m, "Solid", "L" },
                    { 412, "Ut cupiditate est illo.", 64, 12530m, "Solid", "Kg" },
                    { 197, "Qui dolores laborum ut voluptas hic.", 66, 8034m, "Liquid", "Kg" },
                    { 324, "Molestiae quod qui iste quam est quia sed unde expedita.", 1, 16483m, "Gas", "L" },
                    { 438, "Repellat enim earum laboriosam a odit consectetur.", 66, 3853m, "Gas", "L" },
                    { 491, "Dolor perspiciatis voluptas.", 117, 5916m, "Solid", "Kg" },
                    { 388, "Asperiores totam excepturi omnis accusantium voluptas.", 117, 4913m, "Solid", "L" },
                    { 316, "Dolor eligendi id.", 117, 1623m, "Liquid", "L" },
                    { 320, "Molestiae est in et omnis dolores eum voluptatem.", 60, 2967m, "Solid", "Kg" },
                    { 114, "Cumque ut dignissimos suscipit incidunt aut qui at eos excepturi.", 117, 8052m, "Solid", "Kg" },
                    { 53, "Totam voluptate aliquid.", 68, 18631m, "Liquid", "L" },
                    { 161, "Error enim sequi iusto distinctio.", 68, 6158m, "Liquid", "L" },
                    { 168, "Omnis sed commodi quas perspiciatis consequatur.", 68, 19649m, "Solid", "L" },
                    { 409, "Nobis ut iusto.", 114, 5169m, "Solid", "Kg" },
                    { 251, "Modi laboriosam recusandae expedita quae consequatur possimus aut officiis porro.", 68, 9943m, "Liquid", "Kg" },
                    { 301, "Unde voluptates illo esse molestias nemo enim fuga nulla ut.", 114, 3338m, "Liquid", "Kg" },
                    { 253, "Aspernatur dolor consequatur sed voluptas maiores a dolorem ad.", 114, 4773m, "Gas", "L" },
                    { 391, "Minus ipsam earum dolorem.", 68, 3424m, "Solid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 493, "Voluptatem id nisi similique consectetur.", 68, 1086m, "Solid", "L" },
                    { 68, "Sapiente est nulla eum doloribus quia dicta ea.", 114, 10827m, "Solid", "Kg" },
                    { 40, "Qui exercitationem dignissimos deleniti consequuntur amet quia fugit quasi earum.", 114, 14993m, "Liquid", "Kg" },
                    { 7, "Laboriosam tenetur a eum eaque dolores rerum minima veniam voluptas.", 117, 7864m, "Gas", "Kg" },
                    { 344, "Voluptas inventore doloribus nemo.", 113, 1083m, "Liquid", "L" },
                    { 306, "Enim numquam aut modi.", 126, 6220m, "Liquid", "Kg" },
                    { 112, "Eum modi et voluptas.", 55, 14243m, "Gas", "L" },
                    { 97, "Occaecati ullam qui sit cumque ut facere.", 45, 5516m, "Solid", "Kg" },
                    { 289, "Ducimus iure ipsum.", 45, 14459m, "Liquid", "L" },
                    { 294, "Quibusdam et labore odit non ipsum officiis iste.", 45, 11708m, "Gas", "Kg" },
                    { 386, "Laudantium qui nulla voluptatem iusto sunt maiores nam repellendus aut.", 159, 15444m, "Solid", "Kg" },
                    { 345, "Laudantium rerum eos ea enim.", 159, 18477m, "Liquid", "Kg" },
                    { 41, "Nam quam cupiditate non.", 159, 3358m, "Gas", "Kg" },
                    { 85, "Illum nesciunt exercitationem.", 49, 9746m, "Liquid", "L" },
                    { 115, "Facere accusantium dolore.", 49, 18389m, "Gas", "Kg" },
                    { 258, "Qui dolores sed dignissimos unde.", 155, 12978m, "Gas", "Kg" },
                    { 203, "Nesciunt quidem et.", 155, 13438m, "Solid", "Kg" },
                    { 126, "Quis recusandae distinctio amet aliquam.", 49, 18676m, "Gas", "Kg" },
                    { 423, "Consequatur rerum fuga aut magni eum qui et.", 126, 4646m, "Gas", "L" },
                    { 193, "Reprehenderit illo enim qui voluptatem doloremque ex consequatur.", 49, 6591m, "Liquid", "L" },
                    { 368, "Fugiat dolorem et sunt doloribus corporis.", 49, 12564m, "Liquid", "L" },
                    { 381, "Ad dignissimos aut.", 49, 8016m, "Liquid", "L" },
                    { 455, "Laboriosam dolorum aut.", 49, 11811m, "Solid", "L" },
                    { 467, "Consequatur pariatur adipisci illo tenetur ducimus.", 49, 19387m, "Gas", "Kg" },
                    { 430, "Reprehenderit possimus sapiente similique quae eos fugiat.", 136, 1153m, "Gas", "Kg" },
                    { 380, "Accusantium autem aperiam est sint ratione.", 136, 4570m, "Solid", "Kg" },
                    { 286, "Natus nulla repellat.", 136, 13290m, "Gas", "L" },
                    { 61, "Consequatur labore sint in fugiat quod aliquid.", 136, 13961m, "Solid", "Kg" },
                    { 15, "Dolores enim ut.", 55, 13314m, "Gas", "Kg" },
                    { 37, "Exercitationem minima architecto laudantium et.", 55, 6515m, "Solid", "Kg" },
                    { 499, "Eveniet ut delectus et tempora labore dolores excepturi.", 126, 8536m, "Solid", "Kg" },
                    { 328, "Molestiae ratione sit sunt facilis omnis molestiae.", 49, 9142m, "Gas", "Kg" },
                    { 441, "Sunt nulla itaque est.", 26, 14437m, "Liquid", "Kg" },
                    { 317, "Adipisci necessitatibus ut placeat.", 87, 1763m, "Solid", "Kg" },
                    { 325, "Ut nisi sint asperiores asperiores nihil repellendus.", 21, 3780m, "Liquid", "Kg" },
                    { 354, "Illum vero beatae recusandae iste.", 152, 5123m, "Solid", "Kg" },
                    { 399, "Ex fugit quaerat quis amet reiciendis assumenda adipisci facere.", 152, 13509m, "Solid", "Kg" },
                    { 415, "Nisi sed omnis qui velit perferendis tenetur consectetur.", 157, 1153m, "Gas", "Kg" },
                    { 25, "Earum autem quo nihil est ducimus eos et recusandae similique.", 162, 19394m, "Gas", "Kg" },
                    { 51, "Voluptatem sed unde nulla earum ex culpa tempora excepturi.", 162, 10396m, "Liquid", "L" },
                    { 120, "Explicabo et fugit sit.", 163, 11437m, "Gas", "L" },
                    { 158, "Autem quae totam nisi laborum est et.", 163, 4795m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 247, "Ut sunt eius voluptas dolores.", 152, 8095m, "Solid", "Kg" },
                    { 244, "Voluptates eaque et aliquam est consequatur.", 163, 4864m, "Liquid", "L" },
                    { 427, "Ea est necessitatibus ut quam assumenda repellat quia et vitae.", 163, 2311m, "Liquid", "Kg" },
                    { 461, "Recusandae animi aut minus.", 163, 491m, "Solid", "L" },
                    { 176, "Nihil molestiae consequatur minus qui.", 170, 8616m, "Solid", "L" },
                    { 199, "Laboriosam pariatur ratione vel doloremque aut minima est veritatis.", 177, 14078m, "Liquid", "Kg" },
                    { 230, "Vel aspernatur deserunt illo est saepe nihil natus ut ea.", 177, 10339m, "Solid", "L" },
                    { 82, "Quis doloribus sint enim explicabo et aperiam non vel repudiandae.", 178, 11826m, "Solid", "L" },
                    { 198, "Eius laboriosam veniam omnis illum aut nobis eos.", 178, 12111m, "Gas", "L" },
                    { 321, "Quibusdam nisi ut fugiat.", 163, 3046m, "Liquid", "L" },
                    { 284, "Nostrum eum fugiat autem omnis ut corporis.", 178, 1431m, "Liquid", "Kg" },
                    { 160, "Doloribus nostrum error.", 152, 8664m, "Solid", "Kg" },
                    { 450, "Ducimus expedita error cum accusamus necessitatibus.", 148, 19187m, "Liquid", "L" },
                    { 183, "Ut nam laboriosam ea laboriosam maiores id necessitatibus debitis.", 135, 5533m, "Liquid", "Kg" },
                    { 35, "Ut ipsam aut sed voluptatem rerum alias repudiandae.", 139, 10796m, "Liquid", "L" },
                    { 259, "Eaque itaque voluptatibus temporibus occaecati laborum dicta.", 139, 8398m, "Liquid", "L" },
                    { 414, "Nihil quo cum repudiandae dolorem quas.", 139, 15894m, "Solid", "L" },
                    { 355, "Nam atque sed voluptate delectus voluptatem rerum maxime eius.", 142, 3525m, "Liquid", "L" },
                    { 473, "Optio quas inventore dolor est.", 142, 16026m, "Solid", "Kg" },
                    { 81, "Voluptate placeat fugiat est.", 145, 2658m, "Gas", "L" },
                    { 93, "Nesciunt necessitatibus placeat voluptatem in corporis excepturi.", 152, 16381m, "Solid", "L" },
                    { 102, "Quo nihil sint est rem rerum facere expedita.", 145, 6473m, "Solid", "L" },
                    { 382, "Ipsa modi ipsam dolorem enim id culpa.", 145, 2887m, "Liquid", "L" },
                    { 390, "Sint atque laboriosam blanditiis.", 145, 2582m, "Solid", "L" },
                    { 395, "Adipisci praesentium eum.", 145, 4586m, "Liquid", "L" },
                    { 452, "Consequatur odit eaque qui dicta ut est.", 145, 15959m, "Gas", "Kg" },
                    { 67, "Enim consequuntur et assumenda ut cum quidem culpa ad porro.", 148, 10601m, "Gas", "Kg" },
                    { 246, "Atque quidem inventore ut nihil.", 148, 19875m, "Liquid", "Kg" },
                    { 350, "Quibusdam beatae earum inventore officiis cumque distinctio sunt debitis quod.", 148, 3196m, "Solid", "Kg" },
                    { 103, "Nesciunt autem molestias quia sed et debitis cupiditate ratione commodi.", 145, 4789m, "Solid", "Kg" },
                    { 179, "Dignissimos exercitationem ab.", 135, 12362m, "Liquid", "Kg" },
                    { 334, "Molestiae ducimus delectus voluptate perspiciatis dolorem consectetur magnam dolor sed.", 178, 14388m, "Liquid", "Kg" },
                    { 216, "Qui quos sint.", 181, 12505m, "Liquid", "Kg" },
                    { 92, "Consequatur nihil dolores dolores tempora.", 22, 1008m, "Gas", "Kg" },
                    { 184, "Nemo id recusandae.", 22, 9205m, "Solid", "Kg" },
                    { 228, "Aliquid repellendus quo ab nam.", 22, 9280m, "Gas", "L" },
                    { 245, "Quisquam aspernatur voluptatibus qui officia qui a sit est molestiae.", 22, 7554m, "Solid", "L" },
                    { 29, "Est ut et qui aut aspernatur natus.", 23, 15680m, "Liquid", "Kg" },
                    { 71, "Est nobis voluptatem temporibus sit quisquam quia qui omnis.", 23, 16547m, "Solid", "Kg" },
                    { 131, "Explicabo incidunt omnis beatae necessitatibus.", 23, 7782m, "Liquid", "Kg" },
                    { 421, "Qui aut adipisci repellendus error vitae iusto consequatur eum odit.", 17, 6436m, "Solid", "L" },
                    { 136, "Debitis natus inventore delectus.", 23, 16701m, "Solid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 404, "Hic nemo voluptas amet sit voluptatibus commodi libero sed tempora.", 23, 10641m, "Solid", "Kg" },
                    { 88, "Qui quia quia ratione cumque aliquid.", 36, 18312m, "Solid", "L" },
                    { 338, "Eveniet sed ratione libero minima tempora.", 36, 10420m, "Gas", "L" },
                    { 429, "Possimus ut necessitatibus sapiente sed minus velit odio aut eligendi.", 36, 10224m, "Gas", "Kg" },
                    { 418, "Voluptatem nihil ratione quis minima.", 46, 14775m, "Liquid", "Kg" },
                    { 470, "Unde dolorum sit quae voluptas aut.", 46, 4676m, "Liquid", "Kg" },
                    { 279, "Cumque culpa cupiditate impedit voluptatem molestias molestiae quod.", 54, 1467m, "Gas", "Kg" },
                    { 363, "Nemo saepe perferendis id qui sunt explicabo eius sint.", 23, 9100m, "Solid", "L" },
                    { 360, "Deleniti et ullam eligendi minus molestias alias eum sed.", 178, 18917m, "Gas", "Kg" },
                    { 31, "A repellat velit ipsum eos et ad qui sequi.", 17, 14579m, "Solid", "Kg" },
                    { 405, "Deleniti et ut laboriosam aut praesentium fugit ut voluptatem ad.", 3, 18795m, "Gas", "Kg" },
                    { 218, "Similique sit eum laudantium quos ducimus.", 181, 18508m, "Liquid", "Kg" },
                    { 444, "Et saepe officia asperiores illo repudiandae corporis sequi amet.", 181, 16793m, "Liquid", "Kg" },
                    { 32, "Autem nostrum cum sed debitis totam est quam cum.", 190, 11150m, "Solid", "Kg" },
                    { 123, "Animi accusantium nisi voluptatem et quidem natus ea.", 190, 14163m, "Gas", "L" },
                    { 240, "Vero voluptates quia eos quis omnis consectetur.", 190, 5110m, "Solid", "Kg" },
                    { 241, "Ut in impedit autem excepturi accusantium.", 190, 18124m, "Solid", "L" },
                    { 252, "Soluta id sint necessitatibus dolorem aut sed nulla dolor minima.", 190, 6457m, "Gas", "L" },
                    { 65, "Ex illum similique eligendi nulla iusto.", 8, 17957m, "Gas", "L" },
                    { 333, "Nam nam hic exercitationem amet quasi explicabo est id.", 190, 18917m, "Liquid", "L" },
                    { 231, "Quo saepe aut exercitationem.", 195, 692m, "Liquid", "L" },
                    { 329, "Enim libero vel fuga.", 195, 3798m, "Liquid", "L" },
                    { 457, "Voluptatem animi nesciunt officiis.", 195, 14664m, "Solid", "Kg" },
                    { 166, "Tenetur labore eius.", 200, 7490m, "Liquid", "L" },
                    { 178, "Aut accusamus vero modi non.", 200, 16749m, "Gas", "Kg" },
                    { 372, "Aut modi excepturi eos officia.", 200, 18148m, "Gas", "L" },
                    { 440, "Voluptatem nobis officiis sint nam et quasi officiis aut sint.", 200, 17046m, "Liquid", "Kg" },
                    { 18, "Neque ducimus totam.", 195, 1886m, "Solid", "L" },
                    { 359, "Dolor et consequatur.", 54, 14528m, "Gas", "Kg" },
                    { 163, "Quam sequi iure dolores.", 135, 12334m, "Gas", "L" },
                    { 167, "Eligendi voluptatem distinctio necessitatibus.", 131, 16542m, "Gas", "L" },
                    { 272, "Asperiores voluptas quam ex qui eum aliquid autem.", 41, 7476m, "Gas", "L" },
                    { 377, "Quia accusantium delectus et corrupti recusandae iste doloremque.", 41, 2181m, "Liquid", "Kg" },
                    { 396, "Dicta natus mollitia.", 41, 5550m, "Gas", "Kg" },
                    { 407, "Magnam aliquid nesciunt.", 41, 885m, "Liquid", "L" },
                    { 447, "Vel quia et eum alias.", 42, 19197m, "Gas", "L" },
                    { 497, "Omnis delectus eum commodi ipsam eius nesciunt quia nihil tempora.", 42, 7179m, "Solid", "Kg" },
                    { 171, "Facere nostrum nihil veniam ipsa natus.", 48, 8193m, "Gas", "L" },
                    { 108, "Corrupti placeat praesentium iusto quis non ab.", 41, 13490m, "Solid", "L" },
                    { 219, "Unde voluptatem dolore.", 48, 4610m, "Liquid", "Kg" },
                    { 401, "Provident ea velit laboriosam consequatur voluptas porro.", 48, 9593m, "Liquid", "L" },
                    { 174, "Optio aspernatur itaque quia natus optio rerum.", 56, 6366m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 265, "Ab minima dolor rerum minima.", 56, 6472m, "Liquid", "Kg" },
                    { 299, "Cum modi odit odit eum nostrum ex asperiores.", 56, 4598m, "Solid", "Kg" },
                    { 312, "Sapiente magnam cupiditate similique autem.", 56, 2123m, "Solid", "L" },
                    { 462, "Asperiores sapiente enim officia quaerat.", 56, 11418m, "Gas", "L" },
                    { 468, "Sit illo soluta molestias optio rerum enim earum quia.", 56, 17914m, "Solid", "L" },
                    { 271, "Officia qui voluptas aut ut quos ipsa porro.", 48, 14081m, "Liquid", "L" },
                    { 303, "Aspernatur iure illo vero sint.", 65, 9176m, "Solid", "Kg" },
                    { 27, "Ut est voluptate vitae aut accusantium et.", 41, 14464m, "Gas", "L" },
                    { 392, "Voluptas sunt error voluptate saepe incidunt quaerat libero.", 38, 4595m, "Gas", "Kg" },
                    { 352, "Quisquam illum repudiandae.", 2, 7110m, "Liquid", "L" },
                    { 425, "Vel est eum quibusdam perferendis eum rerum sint inventore.", 2, 1368m, "Solid", "L" },
                    { 64, "Voluptas sit blanditiis.", 5, 7691m, "Solid", "L" },
                    { 133, "Quia qui dolore et ad mollitia natus.", 5, 7749m, "Liquid", "L" },
                    { 137, "Repellat optio est et dicta error voluptas.", 5, 8460m, "Solid", "Kg" },
                    { 448, "Consequuntur ad fugiat nihil at.", 5, 13250m, "Gas", "L" },
                    { 474, "Nihil fugiat sint ex est earum corporis est.", 5, 7665m, "Solid", "L" },
                    { 19, "Officiis molestiae ut quis ratione dolorem at autem.", 41, 7542m, "Solid", "L" },
                    { 215, "Labore perspiciatis rerum dolores unde id.", 11, 12331m, "Solid", "Kg" },
                    { 275, "Quis et veritatis perferendis consectetur enim numquam.", 11, 19618m, "Solid", "L" },
                    { 357, "Aspernatur incidunt magnam qui iste.", 11, 3508m, "Solid", "Kg" },
                    { 376, "Assumenda dolorem voluptatum reiciendis fugit illum rerum autem.", 11, 12238m, "Solid", "Kg" },
                    { 46, "Harum eveniet rerum vel necessitatibus consectetur accusantium.", 24, 10410m, "Liquid", "L" },
                    { 87, "Velit quaerat in reprehenderit natus consequatur qui tempora enim explicabo.", 24, 4684m, "Liquid", "Kg" },
                    { 49, "Autem sequi aut minus id velit iusto.", 38, 16273m, "Liquid", "L" },
                    { 209, "Itaque molestias qui unde tempore autem sit et perferendis perferendis.", 38, 8231m, "Liquid", "Kg" },
                    { 273, "Omnis quos voluptas est.", 11, 2841m, "Solid", "L" },
                    { 416, "Odit enim incidunt est quis quia.", 131, 3129m, "Gas", "L" },
                    { 106, "Distinctio sequi qui.", 69, 3362m, "Solid", "L" },
                    { 109, "Quo unde qui doloribus praesentium tempore quod ut debitis sapiente.", 71, 9596m, "Solid", "Kg" },
                    { 331, "Veritatis et a labore consequuntur inventore est eius.", 103, 7753m, "Gas", "L" },
                    { 8, "Accusantium recusandae id libero aut aperiam enim ipsam.", 104, 4796m, "Gas", "Kg" },
                    { 281, "Est voluptatem saepe sapiente consequuntur dicta numquam.", 104, 19478m, "Gas", "Kg" },
                    { 309, "Voluptatibus necessitatibus aut reprehenderit expedita mollitia et unde.", 104, 12217m, "Solid", "Kg" },
                    { 483, "Qui saepe aut eos quae voluptatem.", 104, 12145m, "Gas", "L" },
                    { 76, "Occaecati sunt quasi voluptatem illo blanditiis voluptatem placeat occaecati.", 111, 12099m, "Gas", "L" },
                    { 140, "Dignissimos ab incidunt vel.", 119, 1117m, "Solid", "L" },
                    { 223, "Saepe velit possimus unde ipsam tempora reiciendis dolor in nam.", 103, 3804m, "Gas", "Kg" },
                    { 436, "Labore aut quibusdam sit.", 119, 9798m, "Solid", "Kg" },
                    { 173, "Voluptatem voluptas placeat dolores voluptatibus quas molestias recusandae vitae sit.", 120, 17787m, "Solid", "Kg" },
                    { 186, "Accusamus vel officia eius ut vel quos.", 120, 1470m, "Gas", "Kg" },
                    { 315, "Est aut unde neque iusto nam repudiandae maiores minima.", 120, 4375m, "Gas", "L" },
                    { 348, "Consequatur molestiae eius placeat molestias nam ut.", 120, 1315m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 500, "Et sunt odit repudiandae odit omnis minima laboriosam.", 120, 19433m, "Gas", "L" },
                    { 214, "Est odio et.", 125, 8393m, "Liquid", "L" },
                    { 84, "Ab optio eaque voluptatum voluptas vitae est.", 131, 6415m, "Gas", "L" },
                    { 481, "Qui delectus illo necessitatibus accusantium non.", 119, 14194m, "Solid", "L" },
                    { 397, "Non sit placeat quae consequatur.", 69, 1206m, "Solid", "L" },
                    { 26, "Repellendus in sint ut eaque laboriosam nesciunt architecto.", 103, 14558m, "Gas", "L" },
                    { 471, "Cupiditate nobis voluptas quaerat quod delectus.", 92, 16629m, "Gas", "Kg" },
                    { 274, "Qui expedita repellat nisi debitis sunt consequatur incidunt fugit.", 71, 18082m, "Solid", "Kg" },
                    { 298, "Eos non voluptas quis enim repudiandae laboriosam maxime.", 71, 13014m, "Solid", "L" },
                    { 330, "Aliquid beatae inventore consequatur at rerum voluptas quas.", 71, 17711m, "Solid", "Kg" },
                    { 478, "Sit commodi blanditiis.", 71, 16059m, "Liquid", "Kg" },
                    { 157, "Minus ab expedita libero fugit.", 73, 2595m, "Liquid", "Kg" },
                    { 200, "Omnis aut nulla.", 73, 17860m, "Liquid", "Kg" },
                    { 362, "Aliquam omnis quis amet maiores est.", 73, 15335m, "Gas", "L" },
                    { 495, "Voluptatibus vitae quis ea quia quasi.", 101, 8563m, "Gas", "Kg" },
                    { 489, "Sed ut vel.", 73, 8104m, "Gas", "L" },
                    { 9, "Dolorum possimus exercitationem aliquam voluptatem.", 90, 11577m, "Gas", "Kg" },
                    { 77, "Nisi maxime accusantium culpa.", 90, 12740m, "Gas", "Kg" },
                    { 227, "Rerum deserunt dolorem dignissimos provident perspiciatis ullam animi.", 90, 15171m, "Solid", "L" },
                    { 496, "Sed possimus odit doloribus.", 90, 19873m, "Solid", "L" },
                    { 91, "Est dolores nihil modi velit quisquam similique incidunt.", 92, 16443m, "Liquid", "L" },
                    { 185, "Et quas illum perferendis.", 92, 12236m, "Gas", "L" },
                    { 374, "Fugit consequuntur ut aut.", 92, 14042m, "Liquid", "Kg" },
                    { 43, "Architecto temporibus fuga culpa temporibus sed animi quidem accusantium.", 83, 7897m, "Liquid", "L" },
                    { 443, "Quis numquam ut et ea omnis quia eos qui blanditiis.", 54, 14804m, "Solid", "Kg" },
                    { 12, "Non perspiciatis dolores aperiam consequatur minus aliquam enim.", 57, 5612m, "Liquid", "L" },
                    { 293, "Illum omnis aut sint tenetur et et.", 67, 16155m, "Liquid", "Kg" },
                    { 300, "Consequuntur molestias aut voluptatum sequi sit sunt omnis suscipit quia.", 106, 14304m, "Solid", "Kg" },
                    { 305, "Sed qui veritatis et id tempore qui commodi.", 106, 7118m, "Gas", "L" },
                    { 69, "Laudantium dolore error repellat.", 110, 8419m, "Solid", "Kg" },
                    { 314, "Et animi numquam corrupti provident recusandae et error.", 110, 14814m, "Liquid", "L" },
                    { 336, "Doloremque quidem corporis.", 110, 4341m, "Gas", "Kg" },
                    { 358, "Ea perferendis quia.", 115, 16910m, "Liquid", "L" },
                    { 426, "Dolores consequatur consequuntur aliquam minima accusamus ut pariatur et.", 115, 12982m, "Gas", "L" },
                    { 248, "Quidem iusto enim ullam tempora omnis.", 106, 5518m, "Solid", "L" },
                    { 249, "Voluptas saepe deleniti.", 116, 6470m, "Liquid", "L" },
                    { 101, "Voluptas quia dolorum rerum mollitia non.", 118, 6459m, "Solid", "Kg" },
                    { 139, "Perspiciatis dolorum consequatur eius quis libero animi qui ut voluptatem.", 118, 1688m, "Liquid", "L" },
                    { 146, "Ea omnis enim vero hic illo.", 118, 6931m, "Gas", "Kg" },
                    { 222, "Aut quisquam cumque vel quia autem asperiores.", 118, 13961m, "Liquid", "Kg" },
                    { 255, "Optio consectetur sit quos possimus.", 118, 7614m, "Liquid", "L" },
                    { 296, "Dolores dignissimos adipisci suscipit deleniti laboriosam quo nostrum ut.", 118, 5903m, "Solid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 319, "Necessitatibus sapiente at voluptatem accusamus alias aut dolor.", 118, 9820m, "Liquid", "L" },
                    { 80, "Accusamus et minus totam reprehenderit sint libero.", 118, 8989m, "Liquid", "Kg" },
                    { 78, "Vel sit beatae qui nihil.", 124, 16761m, "Solid", "Kg" },
                    { 267, "Facere nulla itaque eos placeat aliquid ea modi quo ut.", 97, 7725m, "Solid", "L" },
                    { 132, "Placeat vel quidem est ea non sit.", 96, 18630m, "Liquid", "Kg" },
                    { 484, "Impedit laboriosam mollitia ea ullam tenetur dolore nihil molestias.", 74, 12000m, "Solid", "Kg" },
                    { 162, "Voluptatem aut eligendi voluptatem sunt placeat doloremque.", 77, 666m, "Gas", "L" },
                    { 393, "Dolore at est in excepturi consequuntur inventore est.", 77, 8249m, "Liquid", "Kg" },
                    { 56, "Culpa cumque illum incidunt doloribus corrupti vel provident alias est.", 78, 10859m, "Solid", "Kg" },
                    { 439, "Quis velit possimus ad ea corrupti vero alias deserunt ipsam.", 78, 941m, "Liquid", "Kg" },
                    { 413, "Ut id suscipit maxime molestiae distinctio voluptates cumque id voluptatum.", 85, 15065m, "Solid", "Kg" },
                    { 453, "Fuga eum eum assumenda quis voluptatibus.", 85, 18581m, "Solid", "Kg" },
                    { 257, "Rerum molestiae magni perspiciatis iste molestias rerum.", 96, 16225m, "Gas", "Kg" },
                    { 45, "Ut et placeat consequatur quia.", 87, 4547m, "Gas", "L" },
                    { 188, "Non neque aut quo qui voluptas.", 87, 7513m, "Solid", "Kg" },
                    { 226, "Et deserunt magni.", 87, 1720m, "Liquid", "Kg" },
                    { 327, "Similique repudiandae recusandae quam recusandae corporis qui mollitia.", 87, 7121m, "Gas", "Kg" },
                    { 432, "Molestias rerum cum.", 88, 11281m, "Gas", "Kg" },
                    { 70, "Beatae sunt eius inventore blanditiis ab quod tempore facere.", 94, 10756m, "Liquid", "L" },
                    { 119, "Quod officiis ut quia eum optio.", 94, 15733m, "Gas", "L" },
                    { 58, "Sit est fuga magnam et a dolorem.", 96, 18173m, "Liquid", "Kg" },
                    { 181, "Sit qui rerum nihil error sed sequi.", 87, 17892m, "Gas", "Kg" },
                    { 262, "Doloribus ad est sit qui et in sit facilis.", 74, 17489m, "Liquid", "Kg" },
                    { 204, "Omnis eaque vero maiores.", 124, 14279m, "Gas", "L" },
                    { 480, "Eius enim voluptatem praesentium ipsum qui cum saepe sint unde.", 124, 12535m, "Gas", "L" },
                    { 408, "Quo corporis vel sequi dicta at non.", 165, 16646m, "Liquid", "Kg" },
                    { 428, "Impedit ab asperiores eos.", 165, 11569m, "Solid", "Kg" },
                    { 454, "Aut in ex placeat cum enim et.", 165, 1965m, "Gas", "Kg" },
                    { 433, "Quod voluptate rem qui explicabo magnam beatae.", 169, 15785m, "Solid", "L" },
                    { 479, "Est non quia incidunt ratione maxime quis excepturi id quod.", 169, 6543m, "Solid", "Kg" },
                    { 34, "Veniam sapiente ratione eum minima sunt corrupti.", 183, 14308m, "Gas", "Kg" },
                    { 39, "Tempore culpa omnis vero commodi dolores et dolores.", 6, 8494m, "Gas", "Kg" },
                    { 165, "Ab architecto nihil.", 164, 14536m, "Liquid", "Kg" },
                    { 456, "Perferendis consequatur cumque qui sunt nostrum vitae.", 6, 15524m, "Gas", "Kg" },
                    { 353, "Voluptas impedit qui sapiente consequatur iste.", 13, 17930m, "Liquid", "L" },
                    { 419, "Sint excepturi velit consequatur.", 14, 17966m, "Solid", "Kg" },
                    { 66, "Sed repudiandae ad atque quia et.", 15, 7562m, "Gas", "Kg" },
                    { 485, "Aut aut consequatur quaerat ea dolor dolorem error.", 15, 18163m, "Solid", "L" },
                    { 13, "Mollitia dolorum aspernatur debitis et.", 19, 13174m, "Gas", "Kg" },
                    { 62, "Et consectetur aut explicabo sapiente eveniet quod.", 19, 11955m, "Solid", "L" },
                    { 175, "Libero non dicta voluptatum voluptas.", 21, 17580m, "Solid", "Kg" },
                    { 472, "Consequatur sunt facere perferendis esse dolore.", 6, 18535m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 221, "In accusantium veniam quae voluptatibus.", 124, 4401m, "Solid", "L" },
                    { 75, "Sit officia eos aut consectetur.", 164, 3128m, "Solid", "Kg" },
                    { 347, "Reprehenderit et rem rerum totam aut rerum officia molestias aut.", 161, 10800m, "Liquid", "L" },
                    { 172, "Saepe id sunt et sunt consequatur sequi.", 132, 3422m, "Solid", "L" },
                    { 310, "In numquam excepturi quia nisi.", 132, 5851m, "Solid", "L" },
                    { 285, "Tempora ut eos.", 133, 1694m, "Solid", "L" },
                    { 398, "Voluptatum quas qui est a et sint perferendis eos amet.", 141, 557m, "Gas", "L" },
                    { 118, "Qui sit eos cum minus minima.", 143, 8972m, "Liquid", "L" },
                    { 384, "Est tenetur est quis iste molestiae tempora eum tempore.", 143, 16861m, "Solid", "Kg" },
                    { 1, "Minus magnam praesentium quo dignissimos quasi sapiente.", 147, 11388m, "Solid", "L" },
                    { 434, "Quia dolores mollitia qui a.", 161, 16014m, "Solid", "L" },
                    { 242, "Quis eos consectetur omnis consequatur libero eum asperiores est id.", 147, 850m, "Gas", "Kg" },
                    { 38, "Voluptas maxime adipisci et mollitia omnis aut inventore sint.", 154, 5342m, "Liquid", "L" },
                    { 116, "Soluta dolorum qui in impedit voluptatibus mollitia amet sit.", 158, 7359m, "Liquid", "L" },
                    { 383, "Voluptates ipsam eos fugit dolorum consequatur omnis illo.", 158, 13563m, "Liquid", "L" },
                    { 105, "Aut qui ut rem rem rem eaque commodi.", 161, 14891m, "Solid", "L" },
                    { 129, "Sit dolores et quaerat accusamus.", 161, 1179m, "Liquid", "Kg" },
                    { 180, "Eum officiis sint dignissimos doloremque excepturi natus officiis iusto.", 161, 1375m, "Liquid", "Kg" },
                    { 308, "Sit qui ut qui ad laudantium perferendis voluptatem.", 161, 16999m, "Liquid", "Kg" },
                    { 287, "Aliquid aliquid perferendis cum qui voluptas vel deleniti.", 150, 4651m, "Gas", "L" },
                    { 177, "Quam ut praesentium architecto.", 63, 13495m, "Solid", "L" },
                    { 159, "Ea reprehenderit culpa consequatur aspernatur consectetur natus itaque rem.", 63, 12079m, "Gas", "L" },
                    { 422, "Animi mollitia fugiat eos eaque.", 61, 18728m, "Liquid", "Kg" },
                    { 20, "Sed qui iusto ut veritatis consequatur quos eius et enim.", 156, 14675m, "Liquid", "L" },
                    { 420, "Qui sunt eligendi saepe sed distinctio in.", 156, 12194m, "Gas", "Kg" },
                    { 207, "Culpa ut necessitatibus velit non et dolorem.", 160, 10382m, "Gas", "Kg" },
                    { 337, "Est distinctio velit maxime animi velit atque.", 160, 8338m, "Liquid", "L" },
                    { 63, "Expedita blanditiis veniam veniam nobis.", 173, 4239m, "Solid", "Kg" },
                    { 144, "Et ullam ut laboriosam natus eum quidem nihil aut.", 173, 13263m, "Gas", "L" },
                    { 292, "Veritatis dolorem officiis.", 173, 8734m, "Solid", "Kg" },
                    { 411, "In assumenda dolor.", 153, 18598m, "Gas", "Kg" },
                    { 460, "Id praesentium labore vero ratione ut tempore sunt iure.", 173, 8759m, "Solid", "Kg" },
                    { 449, "Et omnis quisquam error ratione aliquid neque porro.", 175, 9686m, "Liquid", "Kg" },
                    { 94, "Et adipisci cum eveniet aliquid corporis ex.", 188, 12545m, "Liquid", "Kg" },
                    { 142, "Sit molestias quos quam sapiente sit.", 188, 17636m, "Gas", "L" },
                    { 155, "Facilis sapiente soluta error.", 188, 6364m, "Solid", "Kg" },
                    { 340, "Minus voluptatibus fuga pariatur occaecati nobis quaerat nobis voluptatem repudiandae.", 188, 9789m, "Liquid", "L" },
                    { 143, "Iusto veritatis officia possimus et ut.", 191, 12013m, "Solid", "L" },
                    { 121, "Quaerat numquam animi velit ipsum aut eligendi et.", 192, 10149m, "Liquid", "Kg" },
                    { 389, "Voluptatibus inventore magnam provident.", 175, 4587m, "Solid", "L" },
                    { 187, "Harum ab rerum beatae nostrum at.", 192, 3412m, "Solid", "L" },
                    { 210, "Error ullam omnis modi sit accusamus neque quasi.", 153, 4424m, "Solid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 220, "Fuga aliquam vel dolor sint labore excepturi.", 149, 13368m, "Gas", "L" },
                    { 74, "Molestias voluptatum tenetur enim in animi commodi quisquam et.", 79, 9832m, "Gas", "Kg" },
                    { 107, "Placeat quia ea iste eius.", 79, 16841m, "Gas", "L" },
                    { 229, "In velit et.", 79, 18217m, "Gas", "L" },
                    { 458, "Fuga similique dolorum quisquam facere quae.", 79, 2970m, "Liquid", "Kg" },
                    { 4, "Dolore commodi excepturi amet.", 81, 9103m, "Solid", "L" },
                    { 191, "Explicabo et inventore inventore non reiciendis et placeat.", 81, 1391m, "Liquid", "L" },
                    { 370, "Eum ut neque nemo et.", 81, 14173m, "Solid", "L" },
                    { 235, "Maiores tempore quia corporis blanditiis explicabo et accusantium nemo.", 149, 3041m, "Solid", "Kg" },
                    { 466, "Et qui itaque dolore nam.", 81, 9455m, "Gas", "L" },
                    { 342, "Earum amet quasi sint.", 138, 16951m, "Liquid", "Kg" },
                    { 373, "Suscipit quis consectetur facilis eos quia et sed.", 138, 2013m, "Solid", "Kg" },
                    { 498, "Ut ullam non fugiat.", 138, 18158m, "Gas", "L" },
                    { 239, "Sapiente explicabo nihil atque maxime tempora.", 144, 15311m, "Gas", "L" },
                    { 311, "Nobis qui voluptatibus dolorem sit sit quia qui.", 144, 11730m, "Solid", "L" },
                    { 263, "Eos consequatur in et eaque provident dolor sunt.", 146, 1888m, "Liquid", "L" },
                    { 402, "Deserunt inventore voluptas perferendis impedit nemo reprehenderit ut corrupti nemo.", 146, 7403m, "Liquid", "L" },
                    { 494, "Nesciunt ipsum ipsam esse quasi maxime est voluptates eius incidunt.", 81, 2033m, "Gas", "L" },
                    { 322, "Temporibus ut maiores natus qui.", 192, 19142m, "Gas", "Kg" },
                    { 332, "Quidem qui ut dolorem nam laudantium ducimus hic.", 192, 11493m, "Gas", "Kg" },
                    { 451, "Quia in cum pariatur.", 192, 1279m, "Solid", "Kg" },
                    { 117, "Saepe voluptatem quam sed voluptates pariatur sit accusamus.", 28, 19446m, "Liquid", "Kg" },
                    { 164, "Corporis incidunt sit dolorem enim non nam provident.", 28, 5071m, "Gas", "Kg" },
                    { 269, "Deserunt cum velit blanditiis quam aut et consequatur magni cupiditate.", 28, 18710m, "Liquid", "L" },
                    { 323, "Ea vel perferendis ab.", 28, 19136m, "Gas", "L" },
                    { 339, "Aut quod qui modi perspiciatis incidunt quas veniam suscipit quia.", 28, 4186m, "Solid", "L" },
                    { 250, "Et dolore ea fugit quos aliquid aut.", 39, 14772m, "Liquid", "Kg" },
                    { 261, "Ducimus est molestiae sint rem eligendi alias doloribus totam voluptates.", 39, 1099m, "Gas", "Kg" },
                    { 153, "Aliquam rerum alias aperiam aspernatur aperiam dolor magnam doloremque.", 27, 18378m, "Solid", "Kg" },
                    { 379, "Quo tempora eius nisi a fugiat.", 39, 9339m, "Liquid", "Kg" },
                    { 6, "Vero omnis et omnis.", 51, 9787m, "Liquid", "Kg" },
                    { 445, "Iusto harum provident aperiam hic corrupti molestias quibusdam rem.", 51, 14759m, "Solid", "Kg" },
                    { 145, "Id qui explicabo placeat impedit id error.", 53, 7191m, "Gas", "L" },
                    { 195, "Nihil beatae tenetur aut alias et sed deserunt adipisci ex.", 53, 303m, "Solid", "Kg" },
                    { 237, "Voluptatem reprehenderit magnam.", 53, 4661m, "Gas", "L" },
                    { 104, "Aspernatur odit sed eum error.", 61, 2789m, "Liquid", "L" },
                    { 148, "Amet tenetur quas tempora.", 61, 4865m, "Liquid", "Kg" },
                    { 47, "Est ipsam adipisci magni eaque quia doloribus magni dolor libero.", 50, 8169m, "Liquid", "Kg" },
                    { 100, "Ad in in.", 27, 578m, "Liquid", "Kg" },
                    { 59, "Inventore perspiciatis id quia sunt ut sapiente blanditiis.", 27, 15254m, "Gas", "Kg" },
                    { 369, "In ipsa ipsa reprehenderit sed tempora eligendi voluptatem.", 25, 9936m, "Gas", "Kg" },
                    { 23, "Et fuga aperiam.", 194, 11084m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 469, "Sed velit ipsa.", 194, 12282m, "Liquid", "Kg" },
                    { 349, "Sunt quae reiciendis sit illum rerum necessitatibus maxime.", 196, 18080m, "Liquid", "L" },
                    { 83, "Facilis unde est vel.", 4, 15095m, "Solid", "Kg" },
                    { 52, "Mollitia rerum esse esse illum.", 7, 18289m, "Liquid", "L" },
                    { 73, "Non quisquam aperiam nam.", 7, 17391m, "Solid", "Kg" },
                    { 124, "Ratione non enim quasi sequi et.", 7, 59m, "Gas", "L" },
                    { 424, "Sit consectetur harum.", 7, 4973m, "Gas", "Kg" },
                    { 477, "Eum earum id quo expedita facilis.", 7, 6152m, "Solid", "L" },
                    { 79, "Aut temporibus nemo provident.", 10, 4288m, "Solid", "L" },
                    { 371, "Accusamus ad asperiores a vel et ullam.", 10, 389m, "Solid", "Kg" },
                    { 277, "Qui harum exercitationem voluptate aut tempore officiis.", 16, 799m, "Gas", "L" },
                    { 236, "Mollitia et aliquid nobis.", 18, 10413m, "Gas", "Kg" },
                    { 89, "Quibusdam dolores ea voluptate harum magni qui fugit ea.", 20, 17936m, "Gas", "L" },
                    { 95, "Excepturi autem cumque qui.", 20, 7206m, "Gas", "L" },
                    { 205, "Ut dolorem et illum dolores.", 20, 2899m, "Liquid", "L" },
                    { 44, "Consequatur quod dolores adipisci et distinctio.", 25, 12659m, "Solid", "L" },
                    { 17, "Voluptas porro laudantium quasi ut velit dignissimos.", 26, 6252m, "Gas", "L" },
                    { 152, "Quod corrupti dolores occaecati ut ea.", 2, 11449m, "Gas", "Kg" }
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
