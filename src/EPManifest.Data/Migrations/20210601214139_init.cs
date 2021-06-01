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
                    { 1, "OXP-4", "Carmacks Health Clinic" },
                    { 2, "A-000", "Mayo Health Centre" },
                    { 3, "B-5010", "Whitehorse General Hospital" },
                    { 4, "A1-102", "Teslin Health Centre" },
                    { 5, "A840", "Whistle Bend Place" }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 4, 4, "YT21399-0", 1, new DateTime(2021, 12, 30, 17, 46, 45, 496, DateTimeKind.Unspecified).AddTicks(9564), new DateTime(2021, 8, 15, 8, 17, 44, 19, DateTimeKind.Unspecified).AddTicks(3616) },
                    { 45, 4, "YT65825-0", 4, new DateTime(2021, 10, 12, 16, 16, 12, 483, DateTimeKind.Unspecified).AddTicks(3329), new DateTime(2021, 8, 26, 7, 39, 25, 427, DateTimeKind.Unspecified).AddTicks(8451) },
                    { 46, 1, "YT15850-0", 4, new DateTime(2021, 12, 10, 3, 0, 44, 629, DateTimeKind.Unspecified).AddTicks(8173), new DateTime(2021, 6, 10, 6, 33, 1, 433, DateTimeKind.Unspecified).AddTicks(7214) },
                    { 47, 5, "YT66768-0", 4, new DateTime(2021, 9, 1, 20, 4, 37, 403, DateTimeKind.Unspecified).AddTicks(8130), new DateTime(2021, 7, 15, 7, 20, 42, 414, DateTimeKind.Unspecified).AddTicks(9860) },
                    { 59, 2, "YT67705-1", 4, new DateTime(2021, 9, 14, 12, 58, 26, 639, DateTimeKind.Unspecified).AddTicks(7020), new DateTime(2021, 8, 19, 14, 11, 5, 525, DateTimeKind.Unspecified).AddTicks(6569) },
                    { 61, 1, "YT87455-1", 4, new DateTime(2021, 9, 16, 2, 42, 5, 625, DateTimeKind.Unspecified).AddTicks(7475), new DateTime(2021, 8, 8, 13, 51, 20, 869, DateTimeKind.Unspecified).AddTicks(1168) },
                    { 62, 3, "YT65215-1", 4, new DateTime(2021, 9, 5, 19, 11, 34, 106, DateTimeKind.Unspecified).AddTicks(3323), new DateTime(2021, 8, 30, 0, 20, 15, 161, DateTimeKind.Unspecified).AddTicks(6654) },
                    { 64, 3, "YT49830-0", 4, new DateTime(2021, 12, 28, 2, 43, 3, 758, DateTimeKind.Unspecified).AddTicks(2023), new DateTime(2021, 6, 3, 13, 43, 48, 768, DateTimeKind.Unspecified).AddTicks(484) },
                    { 65, 3, "YT42895-0", 4, new DateTime(2021, 10, 31, 4, 28, 11, 305, DateTimeKind.Unspecified).AddTicks(5659), new DateTime(2021, 7, 20, 17, 42, 3, 199, DateTimeKind.Unspecified).AddTicks(1111) },
                    { 66, 4, "YT16483-1", 4, new DateTime(2021, 12, 28, 11, 11, 25, 718, DateTimeKind.Unspecified).AddTicks(7027), new DateTime(2021, 5, 30, 0, 49, 40, 995, DateTimeKind.Unspecified).AddTicks(9426) },
                    { 77, 1, "YT37157-0", 4, new DateTime(2021, 11, 28, 20, 34, 14, 574, DateTimeKind.Unspecified).AddTicks(1784), new DateTime(2021, 6, 12, 8, 30, 46, 223, DateTimeKind.Unspecified).AddTicks(2464) },
                    { 89, 2, "YT64972-0", 4, new DateTime(2021, 10, 15, 2, 6, 43, 868, DateTimeKind.Unspecified).AddTicks(6370), new DateTime(2021, 7, 30, 1, 6, 18, 520, DateTimeKind.Unspecified).AddTicks(3252) },
                    { 103, 2, "YT43187-1", 4, new DateTime(2021, 12, 13, 0, 37, 29, 128, DateTimeKind.Unspecified).AddTicks(4977), new DateTime(2021, 7, 22, 3, 39, 41, 698, DateTimeKind.Unspecified).AddTicks(7755) },
                    { 105, 3, "YT89913-1", 4, new DateTime(2021, 12, 29, 23, 58, 31, 616, DateTimeKind.Unspecified).AddTicks(3715), new DateTime(2021, 6, 28, 5, 6, 1, 553, DateTimeKind.Unspecified).AddTicks(1202) },
                    { 113, 3, "YT92040-0", 4, new DateTime(2021, 12, 26, 14, 58, 44, 291, DateTimeKind.Unspecified).AddTicks(8862), new DateTime(2021, 7, 30, 4, 37, 39, 765, DateTimeKind.Unspecified).AddTicks(9710) },
                    { 114, 3, "YT41387-1", 4, new DateTime(2021, 9, 16, 17, 54, 38, 283, DateTimeKind.Unspecified).AddTicks(9718), new DateTime(2021, 6, 21, 11, 14, 19, 570, DateTimeKind.Unspecified).AddTicks(229) },
                    { 115, 3, "YT81543-0", 4, new DateTime(2021, 11, 21, 14, 10, 4, 538, DateTimeKind.Unspecified).AddTicks(2588), new DateTime(2021, 8, 21, 20, 33, 29, 589, DateTimeKind.Unspecified).AddTicks(1478) },
                    { 119, 5, "YT37775-0", 4, new DateTime(2021, 10, 23, 6, 13, 20, 333, DateTimeKind.Unspecified).AddTicks(9514), new DateTime(2021, 6, 23, 8, 40, 42, 668, DateTimeKind.Unspecified).AddTicks(7341) },
                    { 122, 4, "YT38192-1", 4, new DateTime(2021, 11, 3, 16, 54, 13, 107, DateTimeKind.Unspecified).AddTicks(933), new DateTime(2021, 5, 9, 8, 47, 1, 275, DateTimeKind.Unspecified).AddTicks(8137) },
                    { 123, 3, "YT48653-0", 4, new DateTime(2021, 10, 18, 9, 32, 24, 493, DateTimeKind.Unspecified).AddTicks(7940), new DateTime(2021, 7, 27, 3, 28, 28, 89, DateTimeKind.Unspecified).AddTicks(6749) },
                    { 126, 5, "YT54507-1", 4, new DateTime(2021, 9, 12, 13, 26, 40, 184, DateTimeKind.Unspecified).AddTicks(9325), new DateTime(2021, 6, 8, 14, 57, 5, 837, DateTimeKind.Unspecified).AddTicks(9442) },
                    { 129, 5, "YT73592-1", 4, new DateTime(2021, 11, 6, 11, 32, 42, 860, DateTimeKind.Unspecified).AddTicks(5589), new DateTime(2021, 7, 19, 7, 6, 47, 213, DateTimeKind.Unspecified).AddTicks(8026) },
                    { 40, 3, "YT18541-0", 4, new DateTime(2021, 12, 2, 18, 37, 27, 64, DateTimeKind.Unspecified).AddTicks(5680), new DateTime(2021, 6, 28, 22, 31, 33, 909, DateTimeKind.Unspecified).AddTicks(5264) },
                    { 131, 4, "YT30490-1", 4, new DateTime(2021, 10, 6, 4, 58, 11, 21, DateTimeKind.Unspecified).AddTicks(1721), new DateTime(2021, 6, 5, 7, 11, 41, 761, DateTimeKind.Unspecified).AddTicks(7123) },
                    { 31, 3, "YT99917-1", 4, new DateTime(2021, 9, 16, 2, 31, 43, 687, DateTimeKind.Unspecified).AddTicks(6602), new DateTime(2021, 7, 31, 21, 27, 7, 835, DateTimeKind.Unspecified).AddTicks(3023) },
                    { 21, 3, "YT33577-1", 4, new DateTime(2021, 9, 5, 11, 48, 14, 911, DateTimeKind.Unspecified).AddTicks(3880), new DateTime(2021, 7, 31, 3, 57, 34, 639, DateTimeKind.Unspecified).AddTicks(5264) },
                    { 143, 5, "YT43798-1", 3, new DateTime(2021, 12, 2, 5, 30, 2, 645, DateTimeKind.Unspecified).AddTicks(6463), new DateTime(2021, 5, 17, 1, 59, 32, 742, DateTimeKind.Unspecified).AddTicks(7114) },
                    { 144, 4, "YT64925-0", 3, new DateTime(2021, 10, 7, 11, 18, 16, 772, DateTimeKind.Unspecified).AddTicks(3574), new DateTime(2021, 8, 25, 22, 9, 32, 895, DateTimeKind.Unspecified).AddTicks(3271) },
                    { 149, 1, "YT42974-0", 3, new DateTime(2021, 10, 4, 5, 59, 4, 351, DateTimeKind.Unspecified).AddTicks(7100), new DateTime(2021, 7, 22, 16, 27, 40, 280, DateTimeKind.Unspecified).AddTicks(8900) },
                    { 156, 2, "YT27340-0", 3, new DateTime(2021, 12, 24, 21, 26, 16, 906, DateTimeKind.Unspecified).AddTicks(7513), new DateTime(2021, 7, 6, 9, 57, 10, 91, DateTimeKind.Unspecified).AddTicks(4097) },
                    { 160, 1, "YT16973-1", 3, new DateTime(2021, 12, 12, 3, 46, 49, 989, DateTimeKind.Unspecified).AddTicks(5123), new DateTime(2021, 6, 11, 9, 57, 26, 933, DateTimeKind.Unspecified).AddTicks(4024) },
                    { 161, 3, "YT54065-1", 3, new DateTime(2021, 10, 30, 14, 15, 25, 37, DateTimeKind.Unspecified).AddTicks(7074), new DateTime(2021, 7, 11, 13, 32, 44, 644, DateTimeKind.Unspecified).AddTicks(6738) },
                    { 163, 2, "YT96895-1", 3, new DateTime(2021, 9, 28, 14, 42, 15, 765, DateTimeKind.Unspecified).AddTicks(2821), new DateTime(2021, 7, 8, 12, 4, 11, 555, DateTimeKind.Unspecified).AddTicks(6463) },
                    { 170, 1, "YT27444-1", 3, new DateTime(2021, 12, 6, 13, 41, 36, 468, DateTimeKind.Unspecified).AddTicks(4239), new DateTime(2021, 6, 18, 11, 23, 3, 609, DateTimeKind.Unspecified).AddTicks(6671) },
                    { 171, 3, "YT33891-1", 3, new DateTime(2021, 9, 8, 18, 36, 4, 755, DateTimeKind.Unspecified).AddTicks(4188), new DateTime(2021, 7, 4, 10, 49, 57, 58, DateTimeKind.Unspecified).AddTicks(5021) },
                    { 172, 3, "YT46567-1", 3, new DateTime(2021, 12, 27, 23, 1, 58, 350, DateTimeKind.Unspecified).AddTicks(1645), new DateTime(2021, 7, 28, 13, 2, 10, 917, DateTimeKind.Unspecified).AddTicks(7856) },
                    { 181, 1, "YT86202-0", 3, new DateTime(2021, 10, 7, 21, 54, 22, 34, DateTimeKind.Unspecified).AddTicks(3650), new DateTime(2021, 5, 27, 4, 31, 55, 656, DateTimeKind.Unspecified).AddTicks(1093) },
                    { 185, 4, "YT82313-0", 3, new DateTime(2021, 12, 17, 20, 47, 26, 812, DateTimeKind.Unspecified).AddTicks(864), new DateTime(2021, 8, 2, 17, 23, 29, 280, DateTimeKind.Unspecified).AddTicks(7510) },
                    { 189, 4, "YT46332-0", 3, new DateTime(2021, 11, 2, 19, 20, 27, 814, DateTimeKind.Unspecified).AddTicks(6427), new DateTime(2021, 7, 28, 20, 38, 26, 94, DateTimeKind.Unspecified).AddTicks(8018) },
                    { 192, 3, "YT58217-1", 3, new DateTime(2021, 9, 7, 7, 42, 17, 949, DateTimeKind.Unspecified).AddTicks(8626), new DateTime(2021, 5, 8, 20, 26, 20, 667, DateTimeKind.Unspecified).AddTicks(9174) },
                    { 194, 2, "YT93396-0", 3, new DateTime(2021, 11, 23, 20, 23, 27, 300, DateTimeKind.Unspecified).AddTicks(3604), new DateTime(2021, 6, 15, 11, 42, 15, 410, DateTimeKind.Unspecified).AddTicks(3404) },
                    { 196, 3, "YT89443-0", 3, new DateTime(2021, 10, 20, 22, 4, 3, 617, DateTimeKind.Unspecified).AddTicks(1291), new DateTime(2021, 5, 17, 7, 2, 46, 9, DateTimeKind.Unspecified).AddTicks(5586) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 5, 3, "YT67657-1", 4, new DateTime(2021, 12, 18, 4, 25, 50, 325, DateTimeKind.Unspecified).AddTicks(6023), new DateTime(2021, 7, 7, 20, 24, 40, 217, DateTimeKind.Unspecified).AddTicks(440) },
                    { 8, 2, "YT42610-1", 4, new DateTime(2021, 9, 23, 17, 24, 16, 224, DateTimeKind.Unspecified).AddTicks(4513), new DateTime(2021, 7, 18, 12, 59, 32, 969, DateTimeKind.Unspecified).AddTicks(7386) },
                    { 15, 5, "YT39679-1", 4, new DateTime(2021, 11, 25, 22, 57, 37, 299, DateTimeKind.Unspecified).AddTicks(9207), new DateTime(2021, 6, 6, 3, 1, 45, 593, DateTimeKind.Unspecified).AddTicks(9204) },
                    { 18, 2, "YT14066-0", 4, new DateTime(2021, 12, 19, 10, 58, 29, 539, DateTimeKind.Unspecified).AddTicks(2873), new DateTime(2021, 8, 1, 4, 14, 36, 152, DateTimeKind.Unspecified).AddTicks(1113) },
                    { 19, 3, "YT17326-1", 4, new DateTime(2021, 11, 2, 0, 58, 54, 750, DateTimeKind.Unspecified).AddTicks(3321), new DateTime(2021, 5, 13, 10, 45, 46, 890, DateTimeKind.Unspecified).AddTicks(8386) },
                    { 28, 5, "YT53977-1", 4, new DateTime(2021, 10, 23, 9, 2, 39, 220, DateTimeKind.Unspecified).AddTicks(7569), new DateTime(2021, 8, 4, 11, 26, 6, 88, DateTimeKind.Unspecified).AddTicks(981) },
                    { 128, 1, "YT92542-1", 3, new DateTime(2021, 10, 7, 18, 1, 30, 327, DateTimeKind.Unspecified).AddTicks(398), new DateTime(2021, 7, 11, 21, 14, 19, 122, DateTimeKind.Unspecified).AddTicks(5131) },
                    { 139, 1, "YT32800-0", 4, new DateTime(2021, 12, 20, 20, 0, 2, 92, DateTimeKind.Unspecified).AddTicks(4114), new DateTime(2021, 5, 9, 2, 58, 18, 547, DateTimeKind.Unspecified).AddTicks(47) },
                    { 145, 2, "YT78831-0", 4, new DateTime(2021, 12, 27, 19, 22, 23, 656, DateTimeKind.Unspecified).AddTicks(3399), new DateTime(2021, 6, 15, 20, 50, 41, 208, DateTimeKind.Unspecified).AddTicks(3364) },
                    { 95, 5, "YT30252-1", 5, new DateTime(2021, 9, 4, 11, 7, 3, 748, DateTimeKind.Unspecified).AddTicks(6087), new DateTime(2021, 8, 21, 0, 43, 21, 666, DateTimeKind.Unspecified).AddTicks(8391) },
                    { 97, 3, "YT21528-1", 5, new DateTime(2021, 12, 29, 16, 11, 3, 992, DateTimeKind.Unspecified).AddTicks(8314), new DateTime(2021, 5, 19, 13, 29, 45, 636, DateTimeKind.Unspecified).AddTicks(6324) },
                    { 100, 5, "YT71835-1", 5, new DateTime(2021, 12, 24, 3, 38, 45, 686, DateTimeKind.Unspecified).AddTicks(2851), new DateTime(2021, 5, 29, 11, 57, 39, 187, DateTimeKind.Unspecified).AddTicks(240) },
                    { 101, 2, "YT57296-1", 5, new DateTime(2021, 11, 28, 22, 1, 46, 242, DateTimeKind.Unspecified).AddTicks(6579), new DateTime(2021, 6, 27, 22, 44, 25, 410, DateTimeKind.Unspecified).AddTicks(9546) },
                    { 104, 1, "YT43846-0", 5, new DateTime(2021, 9, 27, 15, 10, 35, 499, DateTimeKind.Unspecified).AddTicks(2942), new DateTime(2021, 7, 18, 6, 10, 8, 478, DateTimeKind.Unspecified).AddTicks(3434) },
                    { 107, 2, "YT11534-0", 5, new DateTime(2021, 10, 25, 4, 44, 14, 935, DateTimeKind.Unspecified).AddTicks(5437), new DateTime(2021, 7, 21, 3, 9, 0, 97, DateTimeKind.Unspecified).AddTicks(9005) },
                    { 108, 5, "YT48715-1", 5, new DateTime(2021, 10, 8, 6, 15, 54, 675, DateTimeKind.Unspecified).AddTicks(8220), new DateTime(2021, 8, 9, 6, 6, 33, 347, DateTimeKind.Unspecified).AddTicks(5850) },
                    { 110, 4, "YT96784-0", 5, new DateTime(2021, 12, 11, 8, 59, 46, 593, DateTimeKind.Unspecified).AddTicks(8516), new DateTime(2021, 6, 21, 7, 15, 17, 891, DateTimeKind.Unspecified).AddTicks(6203) },
                    { 111, 2, "YT94770-1", 5, new DateTime(2021, 11, 15, 6, 19, 39, 981, DateTimeKind.Unspecified).AddTicks(6610), new DateTime(2021, 5, 21, 23, 10, 11, 201, DateTimeKind.Unspecified).AddTicks(5651) },
                    { 116, 1, "YT60925-0", 5, new DateTime(2021, 12, 16, 0, 35, 15, 714, DateTimeKind.Unspecified).AddTicks(2142), new DateTime(2021, 6, 24, 6, 39, 26, 79, DateTimeKind.Unspecified).AddTicks(8751) },
                    { 118, 5, "YT80930-1", 5, new DateTime(2021, 11, 4, 0, 31, 36, 400, DateTimeKind.Unspecified).AddTicks(8593), new DateTime(2021, 5, 23, 11, 14, 49, 308, DateTimeKind.Unspecified).AddTicks(6667) },
                    { 125, 3, "YT12321-1", 5, new DateTime(2021, 12, 25, 11, 6, 46, 260, DateTimeKind.Unspecified).AddTicks(1499), new DateTime(2021, 5, 14, 17, 41, 34, 695, DateTimeKind.Unspecified).AddTicks(7050) },
                    { 130, 1, "YT37236-1", 5, new DateTime(2021, 9, 4, 17, 47, 35, 800, DateTimeKind.Unspecified).AddTicks(4454), new DateTime(2021, 8, 10, 6, 28, 50, 746, DateTimeKind.Unspecified).AddTicks(4068) },
                    { 132, 4, "YT79107-1", 5, new DateTime(2021, 12, 1, 6, 33, 56, 938, DateTimeKind.Unspecified).AddTicks(5502), new DateTime(2021, 7, 27, 22, 54, 4, 279, DateTimeKind.Unspecified).AddTicks(684) },
                    { 138, 1, "YT53136-0", 5, new DateTime(2021, 10, 10, 21, 6, 15, 48, DateTimeKind.Unspecified).AddTicks(8963), new DateTime(2021, 8, 29, 20, 53, 2, 972, DateTimeKind.Unspecified).AddTicks(6048) },
                    { 140, 2, "YT12069-1", 5, new DateTime(2021, 11, 29, 17, 26, 12, 719, DateTimeKind.Unspecified).AddTicks(3335), new DateTime(2021, 6, 30, 7, 5, 56, 814, DateTimeKind.Unspecified).AddTicks(760) },
                    { 141, 3, "YT27884-1", 5, new DateTime(2021, 9, 3, 0, 6, 42, 559, DateTimeKind.Unspecified).AddTicks(6755), new DateTime(2021, 6, 23, 3, 30, 49, 99, DateTimeKind.Unspecified).AddTicks(4915) },
                    { 148, 4, "YT70615-1", 5, new DateTime(2021, 9, 9, 22, 1, 8, 216, DateTimeKind.Unspecified).AddTicks(3101), new DateTime(2021, 8, 7, 7, 34, 2, 189, DateTimeKind.Unspecified).AddTicks(7270) },
                    { 153, 1, "YT17802-1", 5, new DateTime(2021, 9, 21, 23, 45, 36, 294, DateTimeKind.Unspecified).AddTicks(7266), new DateTime(2021, 5, 18, 6, 4, 1, 162, DateTimeKind.Unspecified).AddTicks(5725) },
                    { 168, 2, "YT69888-1", 5, new DateTime(2021, 10, 24, 3, 34, 36, 443, DateTimeKind.Unspecified).AddTicks(583), new DateTime(2021, 6, 30, 8, 12, 2, 971, DateTimeKind.Unspecified).AddTicks(6036) },
                    { 180, 1, "YT54875-0", 5, new DateTime(2021, 10, 30, 7, 16, 14, 149, DateTimeKind.Unspecified).AddTicks(6536), new DateTime(2021, 8, 16, 15, 9, 44, 661, DateTimeKind.Unspecified).AddTicks(7103) },
                    { 88, 3, "YT18861-1", 5, new DateTime(2021, 12, 23, 11, 5, 4, 229, DateTimeKind.Unspecified).AddTicks(6432), new DateTime(2021, 8, 16, 13, 12, 7, 984, DateTimeKind.Unspecified).AddTicks(4327) },
                    { 142, 3, "YT66833-1", 4, new DateTime(2021, 12, 23, 23, 33, 3, 424, DateTimeKind.Unspecified).AddTicks(1770), new DateTime(2021, 6, 27, 22, 32, 19, 617, DateTimeKind.Unspecified).AddTicks(636) },
                    { 76, 3, "YT59623-1", 5, new DateTime(2021, 9, 18, 9, 31, 39, 185, DateTimeKind.Unspecified).AddTicks(6914), new DateTime(2021, 6, 21, 6, 4, 19, 722, DateTimeKind.Unspecified).AddTicks(1983) },
                    { 72, 5, "YT42517-1", 5, new DateTime(2021, 12, 9, 12, 16, 8, 193, DateTimeKind.Unspecified).AddTicks(4413), new DateTime(2021, 8, 18, 23, 6, 9, 343, DateTimeKind.Unspecified).AddTicks(9752) },
                    { 146, 3, "YT90687-0", 4, new DateTime(2021, 12, 6, 6, 6, 34, 601, DateTimeKind.Unspecified).AddTicks(81), new DateTime(2021, 8, 23, 2, 53, 9, 178, DateTimeKind.Unspecified).AddTicks(529) },
                    { 147, 5, "YT16420-0", 4, new DateTime(2021, 10, 13, 12, 18, 6, 772, DateTimeKind.Unspecified).AddTicks(9229), new DateTime(2021, 6, 20, 0, 38, 45, 715, DateTimeKind.Unspecified).AddTicks(9721) },
                    { 150, 4, "YT30445-0", 4, new DateTime(2021, 10, 12, 10, 11, 46, 59, DateTimeKind.Unspecified).AddTicks(3001), new DateTime(2021, 7, 20, 15, 39, 53, 100, DateTimeKind.Unspecified).AddTicks(4638) },
                    { 155, 3, "YT44487-1", 4, new DateTime(2021, 10, 30, 22, 42, 44, 874, DateTimeKind.Unspecified).AddTicks(9881), new DateTime(2021, 6, 17, 14, 49, 57, 660, DateTimeKind.Unspecified).AddTicks(9061) },
                    { 164, 4, "YT25437-1", 4, new DateTime(2021, 10, 5, 23, 24, 16, 494, DateTimeKind.Unspecified).AddTicks(5867), new DateTime(2021, 5, 15, 0, 5, 59, 984, DateTimeKind.Unspecified).AddTicks(8108) },
                    { 166, 2, "YT42885-0", 4, new DateTime(2021, 12, 23, 22, 14, 43, 372, DateTimeKind.Unspecified).AddTicks(5006), new DateTime(2021, 6, 1, 19, 27, 4, 819, DateTimeKind.Unspecified).AddTicks(4499) },
                    { 173, 2, "YT25961-1", 4, new DateTime(2021, 10, 27, 8, 6, 6, 419, DateTimeKind.Unspecified).AddTicks(8862), new DateTime(2021, 5, 17, 1, 13, 37, 643, DateTimeKind.Unspecified).AddTicks(5923) },
                    { 179, 1, "YT74613-1", 4, new DateTime(2021, 10, 26, 18, 31, 11, 385, DateTimeKind.Unspecified).AddTicks(8974), new DateTime(2021, 8, 9, 18, 44, 15, 851, DateTimeKind.Unspecified).AddTicks(3672) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 190, 1, "YT69329-1", 4, new DateTime(2021, 12, 17, 9, 29, 33, 511, DateTimeKind.Unspecified).AddTicks(9010), new DateTime(2021, 6, 7, 8, 36, 17, 786, DateTimeKind.Unspecified).AddTicks(1233) },
                    { 200, 3, "YT40305-0", 4, new DateTime(2021, 11, 22, 6, 20, 13, 362, DateTimeKind.Unspecified).AddTicks(2484), new DateTime(2021, 8, 28, 6, 35, 1, 690, DateTimeKind.Unspecified).AddTicks(8443) },
                    { 2, 3, "YT52946-0", 5, new DateTime(2021, 9, 14, 4, 18, 53, 377, DateTimeKind.Unspecified).AddTicks(4713), new DateTime(2021, 6, 5, 9, 19, 7, 746, DateTimeKind.Unspecified).AddTicks(5965) },
                    { 14, 3, "YT42904-0", 5, new DateTime(2021, 11, 16, 11, 25, 15, 290, DateTimeKind.Unspecified).AddTicks(2646), new DateTime(2021, 8, 6, 16, 7, 55, 680, DateTimeKind.Unspecified).AddTicks(1935) },
                    { 23, 2, "YT70588-1", 5, new DateTime(2021, 10, 28, 7, 32, 31, 902, DateTimeKind.Unspecified).AddTicks(5884), new DateTime(2021, 6, 21, 15, 54, 50, 833, DateTimeKind.Unspecified).AddTicks(3941) },
                    { 26, 5, "YT73512-1", 5, new DateTime(2021, 12, 10, 5, 51, 20, 994, DateTimeKind.Unspecified).AddTicks(1748), new DateTime(2021, 7, 3, 5, 57, 7, 360, DateTimeKind.Unspecified).AddTicks(693) },
                    { 30, 1, "YT55114-1", 5, new DateTime(2021, 11, 3, 23, 22, 10, 362, DateTimeKind.Unspecified).AddTicks(5409), new DateTime(2021, 7, 5, 1, 50, 51, 743, DateTimeKind.Unspecified).AddTicks(8070) },
                    { 35, 1, "YT96733-1", 5, new DateTime(2021, 12, 23, 22, 46, 3, 635, DateTimeKind.Unspecified).AddTicks(6080), new DateTime(2021, 6, 23, 4, 50, 43, 835, DateTimeKind.Unspecified).AddTicks(5065) },
                    { 37, 3, "YT90692-0", 5, new DateTime(2021, 12, 30, 21, 37, 52, 610, DateTimeKind.Unspecified).AddTicks(8034), new DateTime(2021, 8, 5, 7, 28, 17, 638, DateTimeKind.Unspecified).AddTicks(9504) },
                    { 51, 1, "YT71697-0", 5, new DateTime(2021, 10, 8, 22, 1, 52, 320, DateTimeKind.Unspecified).AddTicks(6776), new DateTime(2021, 7, 3, 10, 54, 31, 432, DateTimeKind.Unspecified).AddTicks(2705) },
                    { 58, 5, "YT64416-1", 5, new DateTime(2021, 9, 2, 21, 27, 19, 142, DateTimeKind.Unspecified).AddTicks(5030), new DateTime(2021, 6, 9, 2, 52, 59, 874, DateTimeKind.Unspecified).AddTicks(7439) },
                    { 63, 1, "YT66107-1", 5, new DateTime(2021, 12, 4, 5, 33, 27, 556, DateTimeKind.Unspecified).AddTicks(216), new DateTime(2021, 6, 18, 22, 23, 30, 197, DateTimeKind.Unspecified).AddTicks(20) },
                    { 67, 4, "YT35181-1", 5, new DateTime(2021, 10, 27, 20, 40, 34, 822, DateTimeKind.Unspecified).AddTicks(8906), new DateTime(2021, 6, 12, 12, 15, 18, 838, DateTimeKind.Unspecified).AddTicks(5692) },
                    { 74, 5, "YT50491-1", 5, new DateTime(2021, 10, 19, 1, 46, 4, 836, DateTimeKind.Unspecified).AddTicks(6123), new DateTime(2021, 5, 25, 6, 44, 13, 466, DateTimeKind.Unspecified).AddTicks(3671) },
                    { 121, 5, "YT97691-0", 3, new DateTime(2021, 9, 11, 20, 25, 34, 631, DateTimeKind.Unspecified).AddTicks(7559), new DateTime(2021, 7, 16, 8, 27, 23, 427, DateTimeKind.Unspecified).AddTicks(17) },
                    { 117, 2, "YT56740-0", 3, new DateTime(2021, 10, 10, 13, 23, 12, 285, DateTimeKind.Unspecified).AddTicks(1548), new DateTime(2021, 6, 3, 5, 21, 29, 6, DateTimeKind.Unspecified).AddTicks(9515) },
                    { 112, 1, "YT73590-0", 3, new DateTime(2021, 10, 6, 4, 21, 44, 781, DateTimeKind.Unspecified).AddTicks(3697), new DateTime(2021, 6, 17, 19, 19, 17, 634, DateTimeKind.Unspecified).AddTicks(2147) },
                    { 152, 4, "YT23141-1", 1, new DateTime(2021, 9, 1, 14, 20, 57, 655, DateTimeKind.Unspecified).AddTicks(1752), new DateTime(2021, 8, 20, 21, 54, 49, 582, DateTimeKind.Unspecified).AddTicks(6767) },
                    { 158, 3, "YT16219-1", 1, new DateTime(2021, 12, 19, 7, 38, 48, 442, DateTimeKind.Unspecified).AddTicks(7711), new DateTime(2021, 5, 17, 3, 57, 40, 271, DateTimeKind.Unspecified).AddTicks(5618) },
                    { 167, 4, "YT60122-1", 1, new DateTime(2021, 10, 10, 11, 13, 46, 108, DateTimeKind.Unspecified).AddTicks(6473), new DateTime(2021, 5, 9, 14, 57, 42, 460, DateTimeKind.Unspecified).AddTicks(5579) },
                    { 176, 2, "YT43985-0", 1, new DateTime(2021, 10, 5, 21, 10, 21, 661, DateTimeKind.Unspecified).AddTicks(772), new DateTime(2021, 6, 19, 10, 45, 2, 555, DateTimeKind.Unspecified).AddTicks(7743) },
                    { 177, 5, "YT84552-0", 1, new DateTime(2021, 12, 14, 7, 18, 35, 536, DateTimeKind.Unspecified).AddTicks(5754), new DateTime(2021, 8, 12, 21, 16, 25, 249, DateTimeKind.Unspecified).AddTicks(4090) },
                    { 178, 2, "YT91136-1", 1, new DateTime(2021, 10, 6, 13, 2, 11, 559, DateTimeKind.Unspecified).AddTicks(8259), new DateTime(2021, 5, 28, 12, 51, 56, 581, DateTimeKind.Unspecified).AddTicks(2261) },
                    { 182, 3, "YT79802-1", 1, new DateTime(2021, 12, 15, 5, 36, 29, 110, DateTimeKind.Unspecified).AddTicks(5791), new DateTime(2021, 7, 4, 0, 41, 30, 283, DateTimeKind.Unspecified).AddTicks(2549) },
                    { 183, 3, "YT43288-0", 1, new DateTime(2021, 9, 23, 11, 56, 23, 69, DateTimeKind.Unspecified).AddTicks(9152), new DateTime(2021, 8, 17, 22, 9, 7, 802, DateTimeKind.Unspecified).AddTicks(9667) },
                    { 191, 2, "YT74488-0", 1, new DateTime(2021, 11, 27, 6, 13, 40, 840, DateTimeKind.Unspecified).AddTicks(965), new DateTime(2021, 5, 29, 18, 42, 35, 522, DateTimeKind.Unspecified).AddTicks(3600) },
                    { 195, 5, "YT37007-1", 1, new DateTime(2021, 9, 15, 6, 7, 13, 562, DateTimeKind.Unspecified).AddTicks(8165), new DateTime(2021, 8, 24, 20, 5, 35, 800, DateTimeKind.Unspecified).AddTicks(9616) },
                    { 197, 4, "YT17513-1", 1, new DateTime(2021, 12, 26, 16, 3, 18, 505, DateTimeKind.Unspecified).AddTicks(3943), new DateTime(2021, 6, 7, 1, 15, 22, 308, DateTimeKind.Unspecified).AddTicks(15) },
                    { 198, 3, "YT96043-1", 1, new DateTime(2021, 9, 21, 6, 7, 0, 100, DateTimeKind.Unspecified).AddTicks(2060), new DateTime(2021, 5, 8, 3, 16, 19, 447, DateTimeKind.Unspecified).AddTicks(8814) },
                    { 199, 3, "YT65154-0", 1, new DateTime(2021, 10, 2, 4, 1, 3, 51, DateTimeKind.Unspecified).AddTicks(7938), new DateTime(2021, 5, 31, 13, 55, 17, 864, DateTimeKind.Unspecified).AddTicks(5323) },
                    { 13, 4, "YT68196-1", 2, new DateTime(2021, 9, 14, 14, 48, 4, 661, DateTimeKind.Unspecified).AddTicks(5592), new DateTime(2021, 6, 16, 0, 27, 15, 244, DateTimeKind.Unspecified).AddTicks(8829) },
                    { 16, 3, "YT68115-0", 2, new DateTime(2021, 12, 20, 13, 3, 48, 27, DateTimeKind.Unspecified).AddTicks(4580), new DateTime(2021, 6, 25, 23, 32, 46, 456, DateTimeKind.Unspecified).AddTicks(7374) },
                    { 20, 5, "YT84288-0", 2, new DateTime(2021, 11, 4, 21, 25, 53, 309, DateTimeKind.Unspecified).AddTicks(4542), new DateTime(2021, 7, 16, 17, 42, 22, 883, DateTimeKind.Unspecified).AddTicks(2932) },
                    { 33, 3, "YT90168-0", 2, new DateTime(2021, 10, 1, 15, 0, 47, 93, DateTimeKind.Unspecified).AddTicks(7146), new DateTime(2021, 6, 2, 23, 36, 43, 462, DateTimeKind.Unspecified).AddTicks(3318) },
                    { 38, 2, "YT37672-1", 2, new DateTime(2021, 12, 17, 5, 39, 20, 6, DateTimeKind.Unspecified).AddTicks(7755), new DateTime(2021, 8, 12, 23, 58, 20, 889, DateTimeKind.Unspecified).AddTicks(9360) },
                    { 39, 3, "YT43707-1", 2, new DateTime(2021, 10, 25, 4, 26, 13, 535, DateTimeKind.Unspecified).AddTicks(8566), new DateTime(2021, 5, 27, 3, 47, 25, 287, DateTimeKind.Unspecified).AddTicks(7719) },
                    { 41, 1, "YT30430-1", 2, new DateTime(2021, 10, 18, 21, 14, 54, 896, DateTimeKind.Unspecified).AddTicks(3283), new DateTime(2021, 5, 9, 9, 36, 20, 852, DateTimeKind.Unspecified).AddTicks(1983) },
                    { 42, 3, "YT70076-1", 2, new DateTime(2021, 9, 19, 11, 17, 4, 831, DateTimeKind.Unspecified).AddTicks(1262), new DateTime(2021, 7, 18, 5, 57, 17, 693, DateTimeKind.Unspecified).AddTicks(3466) },
                    { 136, 2, "YT30565-1", 1, new DateTime(2021, 12, 9, 20, 13, 17, 134, DateTimeKind.Unspecified).AddTicks(7298), new DateTime(2021, 7, 20, 22, 42, 46, 399, DateTimeKind.Unspecified).AddTicks(9849) },
                    { 43, 3, "YT41842-0", 2, new DateTime(2021, 11, 4, 6, 28, 7, 176, DateTimeKind.Unspecified).AddTicks(4962), new DateTime(2021, 6, 11, 5, 39, 51, 715, DateTimeKind.Unspecified).AddTicks(8773) },
                    { 135, 2, "YT27485-1", 1, new DateTime(2021, 10, 21, 17, 18, 20, 710, DateTimeKind.Unspecified).AddTicks(8293), new DateTime(2021, 7, 14, 11, 57, 10, 89, DateTimeKind.Unspecified).AddTicks(9378) },
                    { 109, 1, "YT24748-0", 1, new DateTime(2021, 12, 21, 23, 33, 55, 818, DateTimeKind.Unspecified).AddTicks(1395), new DateTime(2021, 7, 10, 12, 0, 57, 18, DateTimeKind.Unspecified).AddTicks(2182) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 7, 2, "YT54855-0", 1, new DateTime(2021, 10, 2, 21, 33, 39, 471, DateTimeKind.Unspecified).AddTicks(378), new DateTime(2021, 8, 20, 15, 26, 20, 567, DateTimeKind.Unspecified).AddTicks(714) },
                    { 12, 2, "YT72820-1", 1, new DateTime(2021, 9, 21, 0, 34, 33, 430, DateTimeKind.Unspecified).AddTicks(1949), new DateTime(2021, 5, 22, 2, 12, 33, 340, DateTimeKind.Unspecified).AddTicks(1675) },
                    { 24, 4, "YT87172-1", 1, new DateTime(2021, 11, 10, 13, 28, 50, 996, DateTimeKind.Unspecified).AddTicks(6552), new DateTime(2021, 8, 18, 10, 5, 32, 321, DateTimeKind.Unspecified).AddTicks(1943) },
                    { 25, 5, "YT93450-0", 1, new DateTime(2021, 9, 1, 1, 48, 46, 623, DateTimeKind.Unspecified).AddTicks(3028), new DateTime(2021, 7, 15, 22, 25, 48, 877, DateTimeKind.Unspecified).AddTicks(4407) },
                    { 29, 4, "YT71110-1", 1, new DateTime(2021, 11, 21, 17, 35, 16, 770, DateTimeKind.Unspecified).AddTicks(3759), new DateTime(2021, 5, 8, 17, 18, 57, 78, DateTimeKind.Unspecified).AddTicks(7270) },
                    { 32, 1, "YT18405-1", 1, new DateTime(2021, 12, 3, 19, 52, 23, 728, DateTimeKind.Unspecified).AddTicks(6129), new DateTime(2021, 6, 8, 8, 14, 32, 993, DateTimeKind.Unspecified).AddTicks(8839) },
                    { 36, 1, "YT99377-1", 1, new DateTime(2021, 11, 30, 3, 36, 23, 751, DateTimeKind.Unspecified).AddTicks(9512), new DateTime(2021, 7, 31, 21, 51, 51, 815, DateTimeKind.Unspecified).AddTicks(3849) },
                    { 44, 1, "YT76327-1", 1, new DateTime(2021, 10, 21, 9, 50, 27, 411, DateTimeKind.Unspecified).AddTicks(3567), new DateTime(2021, 8, 4, 12, 28, 30, 98, DateTimeKind.Unspecified).AddTicks(5706) },
                    { 49, 1, "YT25049-1", 1, new DateTime(2021, 11, 30, 16, 19, 41, 304, DateTimeKind.Unspecified).AddTicks(9724), new DateTime(2021, 8, 14, 3, 27, 5, 625, DateTimeKind.Unspecified).AddTicks(1855) },
                    { 50, 5, "YT67487-0", 1, new DateTime(2021, 11, 12, 18, 20, 53, 593, DateTimeKind.Unspecified).AddTicks(703), new DateTime(2021, 7, 11, 18, 57, 41, 75, DateTimeKind.Unspecified).AddTicks(8473) },
                    { 52, 3, "YT57788-0", 1, new DateTime(2021, 9, 22, 1, 2, 8, 476, DateTimeKind.Unspecified).AddTicks(6200), new DateTime(2021, 8, 8, 10, 37, 56, 569, DateTimeKind.Unspecified).AddTicks(1488) },
                    { 53, 1, "YT88262-1", 1, new DateTime(2021, 12, 25, 2, 3, 24, 971, DateTimeKind.Unspecified).AddTicks(9890), new DateTime(2021, 7, 5, 7, 21, 23, 854, DateTimeKind.Unspecified).AddTicks(7130) },
                    { 54, 5, "YT14591-0", 1, new DateTime(2021, 10, 7, 4, 18, 27, 138, DateTimeKind.Unspecified).AddTicks(2252), new DateTime(2021, 7, 3, 16, 22, 28, 577, DateTimeKind.Unspecified).AddTicks(4106) },
                    { 71, 1, "YT41206-0", 1, new DateTime(2021, 10, 24, 5, 50, 12, 97, DateTimeKind.Unspecified).AddTicks(1837), new DateTime(2021, 6, 28, 17, 3, 19, 904, DateTimeKind.Unspecified).AddTicks(2886) },
                    { 73, 1, "YT88270-1", 1, new DateTime(2021, 9, 14, 12, 1, 54, 291, DateTimeKind.Unspecified).AddTicks(2932), new DateTime(2021, 5, 13, 5, 42, 36, 154, DateTimeKind.Unspecified).AddTicks(8567) },
                    { 80, 4, "YT61324-0", 1, new DateTime(2021, 9, 14, 17, 13, 20, 708, DateTimeKind.Unspecified).AddTicks(4733), new DateTime(2021, 8, 28, 19, 19, 44, 8, DateTimeKind.Unspecified).AddTicks(2820) },
                    { 81, 1, "YT12188-0", 1, new DateTime(2021, 10, 15, 9, 15, 37, 218, DateTimeKind.Unspecified).AddTicks(4685), new DateTime(2021, 6, 9, 13, 45, 14, 650, DateTimeKind.Unspecified).AddTicks(6242) },
                    { 87, 5, "YT71088-0", 1, new DateTime(2021, 11, 2, 22, 52, 35, 382, DateTimeKind.Unspecified).AddTicks(9100), new DateTime(2021, 7, 10, 11, 54, 50, 352, DateTimeKind.Unspecified).AddTicks(7355) },
                    { 93, 5, "YT55565-0", 1, new DateTime(2021, 9, 24, 19, 50, 6, 598, DateTimeKind.Unspecified).AddTicks(3971), new DateTime(2021, 8, 18, 15, 32, 6, 433, DateTimeKind.Unspecified).AddTicks(5923) },
                    { 98, 5, "YT67231-0", 1, new DateTime(2021, 11, 19, 6, 32, 8, 566, DateTimeKind.Unspecified).AddTicks(4966), new DateTime(2021, 8, 10, 12, 11, 11, 670, DateTimeKind.Unspecified).AddTicks(8090) },
                    { 99, 1, "YT36995-1", 1, new DateTime(2021, 12, 13, 14, 17, 25, 120, DateTimeKind.Unspecified).AddTicks(576), new DateTime(2021, 8, 16, 12, 14, 9, 631, DateTimeKind.Unspecified).AddTicks(5416) },
                    { 134, 3, "YT15964-1", 1, new DateTime(2021, 10, 29, 9, 3, 51, 389, DateTimeKind.Unspecified).AddTicks(9490), new DateTime(2021, 8, 12, 11, 43, 18, 765, DateTimeKind.Unspecified).AddTicks(6194) },
                    { 48, 1, "YT55411-1", 2, new DateTime(2021, 11, 29, 15, 42, 34, 5, DateTimeKind.Unspecified).AddTicks(4048), new DateTime(2021, 6, 3, 6, 34, 36, 37, DateTimeKind.Unspecified).AddTicks(6742) },
                    { 57, 1, "YT21668-0", 2, new DateTime(2021, 9, 1, 20, 59, 9, 794, DateTimeKind.Unspecified).AddTicks(6748), new DateTime(2021, 7, 20, 8, 21, 20, 683, DateTimeKind.Unspecified).AddTicks(3243) },
                    { 69, 4, "YT36840-0", 2, new DateTime(2021, 10, 27, 0, 40, 52, 729, DateTimeKind.Unspecified).AddTicks(5258), new DateTime(2021, 5, 23, 14, 30, 20, 485, DateTimeKind.Unspecified).AddTicks(336) },
                    { 187, 4, "YT48705-1", 2, new DateTime(2021, 10, 1, 17, 31, 10, 641, DateTimeKind.Unspecified).AddTicks(732), new DateTime(2021, 6, 28, 17, 23, 18, 456, DateTimeKind.Unspecified).AddTicks(4283) },
                    { 188, 4, "YT21331-0", 2, new DateTime(2021, 10, 15, 5, 11, 31, 298, DateTimeKind.Unspecified).AddTicks(2238), new DateTime(2021, 7, 30, 18, 32, 9, 272, DateTimeKind.Unspecified).AddTicks(9301) },
                    { 1, 3, "YT84167-0", 3, new DateTime(2021, 10, 29, 2, 33, 42, 308, DateTimeKind.Unspecified).AddTicks(2600), new DateTime(2021, 6, 13, 12, 32, 32, 547, DateTimeKind.Unspecified).AddTicks(4267) },
                    { 3, 4, "YT69865-1", 3, new DateTime(2021, 12, 10, 15, 57, 58, 273, DateTimeKind.Unspecified).AddTicks(4557), new DateTime(2021, 6, 30, 5, 59, 30, 960, DateTimeKind.Unspecified).AddTicks(2158) },
                    { 6, 4, "YT24669-0", 3, new DateTime(2021, 9, 25, 7, 11, 16, 530, DateTimeKind.Unspecified).AddTicks(4269), new DateTime(2021, 8, 11, 18, 38, 10, 61, DateTimeKind.Unspecified).AddTicks(8001) },
                    { 9, 2, "YT72313-1", 3, new DateTime(2021, 10, 24, 2, 32, 59, 690, DateTimeKind.Unspecified).AddTicks(3862), new DateTime(2021, 8, 1, 20, 19, 15, 669, DateTimeKind.Unspecified).AddTicks(154) },
                    { 10, 3, "YT52021-0", 3, new DateTime(2021, 12, 2, 0, 22, 32, 83, DateTimeKind.Unspecified).AddTicks(4735), new DateTime(2021, 8, 19, 14, 31, 3, 911, DateTimeKind.Unspecified).AddTicks(2314) },
                    { 11, 5, "YT87296-1", 3, new DateTime(2021, 12, 16, 14, 54, 49, 791, DateTimeKind.Unspecified).AddTicks(9711), new DateTime(2021, 6, 12, 21, 8, 33, 224, DateTimeKind.Unspecified).AddTicks(2885) },
                    { 17, 4, "YT79106-0", 3, new DateTime(2021, 11, 21, 22, 18, 10, 897, DateTimeKind.Unspecified).AddTicks(1445), new DateTime(2021, 7, 10, 18, 17, 4, 217, DateTimeKind.Unspecified).AddTicks(2876) },
                    { 22, 3, "YT79196-0", 3, new DateTime(2021, 12, 20, 11, 45, 23, 492, DateTimeKind.Unspecified).AddTicks(1608), new DateTime(2021, 5, 11, 7, 52, 55, 227, DateTimeKind.Unspecified).AddTicks(2753) },
                    { 27, 4, "YT98683-1", 3, new DateTime(2021, 11, 2, 18, 54, 26, 360, DateTimeKind.Unspecified).AddTicks(8302), new DateTime(2021, 7, 19, 10, 45, 26, 77, DateTimeKind.Unspecified).AddTicks(710) },
                    { 34, 4, "YT94778-0", 3, new DateTime(2021, 9, 4, 20, 43, 9, 130, DateTimeKind.Unspecified).AddTicks(4423), new DateTime(2021, 5, 31, 13, 31, 2, 996, DateTimeKind.Unspecified).AddTicks(3416) },
                    { 55, 5, "YT32341-1", 3, new DateTime(2021, 9, 9, 22, 37, 58, 368, DateTimeKind.Unspecified).AddTicks(7569), new DateTime(2021, 7, 3, 18, 54, 52, 149, DateTimeKind.Unspecified).AddTicks(8273) },
                    { 56, 1, "YT68327-1", 3, new DateTime(2021, 11, 10, 23, 21, 32, 599, DateTimeKind.Unspecified).AddTicks(1167), new DateTime(2021, 6, 1, 13, 44, 6, 653, DateTimeKind.Unspecified).AddTicks(8496) },
                    { 60, 3, "YT47711-1", 3, new DateTime(2021, 11, 9, 13, 12, 56, 427, DateTimeKind.Unspecified).AddTicks(1391), new DateTime(2021, 8, 6, 17, 36, 19, 184, DateTimeKind.Unspecified).AddTicks(9238) },
                    { 68, 4, "YT45239-0", 3, new DateTime(2021, 12, 19, 3, 24, 5, 575, DateTimeKind.Unspecified).AddTicks(7496), new DateTime(2021, 7, 16, 13, 25, 18, 373, DateTimeKind.Unspecified).AddTicks(9097) },
                    { 70, 4, "YT94419-0", 3, new DateTime(2021, 10, 17, 14, 39, 35, 659, DateTimeKind.Unspecified).AddTicks(7333), new DateTime(2021, 7, 27, 3, 27, 3, 21, DateTimeKind.Unspecified).AddTicks(1360) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 75, 2, "YT23119-0", 3, new DateTime(2021, 12, 2, 22, 31, 14, 512, DateTimeKind.Unspecified).AddTicks(8905), new DateTime(2021, 8, 9, 17, 9, 44, 445, DateTimeKind.Unspecified).AddTicks(7959) },
                    { 84, 5, "YT14386-1", 3, new DateTime(2021, 9, 6, 7, 10, 45, 242, DateTimeKind.Unspecified).AddTicks(3246), new DateTime(2021, 8, 4, 11, 36, 42, 917, DateTimeKind.Unspecified).AddTicks(6758) },
                    { 96, 1, "YT80638-1", 3, new DateTime(2021, 10, 21, 20, 23, 46, 628, DateTimeKind.Unspecified).AddTicks(4793), new DateTime(2021, 8, 12, 19, 59, 52, 293, DateTimeKind.Unspecified).AddTicks(2290) },
                    { 106, 5, "YT57045-0", 3, new DateTime(2021, 11, 3, 7, 53, 39, 757, DateTimeKind.Unspecified).AddTicks(5508), new DateTime(2021, 5, 13, 7, 35, 7, 259, DateTimeKind.Unspecified).AddTicks(583) },
                    { 186, 4, "YT37534-1", 2, new DateTime(2021, 11, 15, 19, 10, 28, 92, DateTimeKind.Unspecified).AddTicks(3271), new DateTime(2021, 5, 12, 16, 16, 12, 819, DateTimeKind.Unspecified).AddTicks(6015) },
                    { 175, 1, "YT62322-0", 2, new DateTime(2021, 10, 27, 21, 38, 10, 579, DateTimeKind.Unspecified).AddTicks(7263), new DateTime(2021, 5, 27, 12, 48, 13, 447, DateTimeKind.Unspecified).AddTicks(9362) },
                    { 174, 4, "YT40368-1", 2, new DateTime(2021, 10, 24, 17, 58, 26, 121, DateTimeKind.Unspecified).AddTicks(2796), new DateTime(2021, 8, 1, 12, 1, 32, 854, DateTimeKind.Unspecified).AddTicks(9178) },
                    { 169, 2, "YT19183-1", 2, new DateTime(2021, 10, 31, 16, 27, 47, 410, DateTimeKind.Unspecified).AddTicks(6039), new DateTime(2021, 8, 11, 12, 44, 10, 151, DateTimeKind.Unspecified).AddTicks(2473) },
                    { 78, 3, "YT18532-0", 2, new DateTime(2021, 10, 22, 9, 14, 17, 155, DateTimeKind.Unspecified).AddTicks(1731), new DateTime(2021, 8, 15, 14, 21, 5, 217, DateTimeKind.Unspecified).AddTicks(5563) },
                    { 79, 2, "YT50130-1", 2, new DateTime(2021, 9, 1, 0, 24, 29, 45, DateTimeKind.Unspecified).AddTicks(4624), new DateTime(2021, 6, 11, 15, 50, 2, 834, DateTimeKind.Unspecified).AddTicks(9561) },
                    { 82, 5, "YT97937-0", 2, new DateTime(2021, 12, 4, 11, 6, 52, 186, DateTimeKind.Unspecified).AddTicks(9333), new DateTime(2021, 8, 15, 11, 44, 37, 960, DateTimeKind.Unspecified).AddTicks(2814) },
                    { 83, 1, "YT49758-0", 2, new DateTime(2021, 11, 23, 2, 2, 30, 226, DateTimeKind.Unspecified).AddTicks(7216), new DateTime(2021, 8, 5, 20, 32, 46, 890, DateTimeKind.Unspecified).AddTicks(6065) },
                    { 85, 5, "YT45110-0", 2, new DateTime(2021, 12, 20, 14, 57, 17, 537, DateTimeKind.Unspecified).AddTicks(5387), new DateTime(2021, 8, 25, 15, 58, 15, 727, DateTimeKind.Unspecified).AddTicks(8773) },
                    { 86, 3, "YT21612-1", 2, new DateTime(2021, 9, 20, 12, 49, 2, 543, DateTimeKind.Unspecified).AddTicks(6667), new DateTime(2021, 5, 15, 2, 50, 12, 939, DateTimeKind.Unspecified).AddTicks(8215) },
                    { 90, 1, "YT67883-0", 2, new DateTime(2021, 9, 6, 19, 19, 57, 563, DateTimeKind.Unspecified).AddTicks(2276), new DateTime(2021, 7, 21, 15, 12, 42, 691, DateTimeKind.Unspecified).AddTicks(8049) },
                    { 91, 3, "YT22574-0", 2, new DateTime(2021, 10, 11, 10, 39, 54, 596, DateTimeKind.Unspecified).AddTicks(4307), new DateTime(2021, 8, 1, 14, 23, 39, 247, DateTimeKind.Unspecified).AddTicks(8213) },
                    { 92, 2, "YT54706-1", 2, new DateTime(2021, 11, 27, 19, 17, 45, 715, DateTimeKind.Unspecified).AddTicks(9846), new DateTime(2021, 6, 23, 5, 2, 2, 630, DateTimeKind.Unspecified).AddTicks(2559) },
                    { 94, 2, "YT22401-1", 2, new DateTime(2021, 10, 27, 3, 15, 15, 28, DateTimeKind.Unspecified).AddTicks(4762), new DateTime(2021, 6, 3, 22, 52, 22, 792, DateTimeKind.Unspecified).AddTicks(5136) },
                    { 184, 5, "YT40760-0", 5, new DateTime(2021, 10, 7, 8, 2, 41, 179, DateTimeKind.Unspecified).AddTicks(6395), new DateTime(2021, 7, 1, 7, 37, 6, 619, DateTimeKind.Unspecified).AddTicks(9880) },
                    { 102, 4, "YT38704-0", 2, new DateTime(2021, 9, 25, 22, 31, 9, 284, DateTimeKind.Unspecified).AddTicks(5141), new DateTime(2021, 8, 10, 12, 18, 58, 155, DateTimeKind.Unspecified).AddTicks(1025) },
                    { 124, 1, "YT25279-1", 2, new DateTime(2021, 10, 29, 23, 32, 24, 300, DateTimeKind.Unspecified).AddTicks(5912), new DateTime(2021, 6, 7, 12, 39, 3, 980, DateTimeKind.Unspecified).AddTicks(5079) },
                    { 127, 5, "YT78708-1", 2, new DateTime(2021, 10, 10, 7, 55, 14, 130, DateTimeKind.Unspecified).AddTicks(9677), new DateTime(2021, 7, 15, 4, 5, 47, 249, DateTimeKind.Unspecified).AddTicks(856) },
                    { 133, 1, "YT99983-0", 2, new DateTime(2021, 11, 24, 9, 24, 10, 233, DateTimeKind.Unspecified).AddTicks(1876), new DateTime(2021, 5, 31, 3, 53, 42, 24, DateTimeKind.Unspecified).AddTicks(912) },
                    { 137, 1, "YT61674-0", 2, new DateTime(2021, 9, 3, 22, 34, 59, 6, DateTimeKind.Unspecified).AddTicks(4627), new DateTime(2021, 6, 17, 17, 29, 51, 833, DateTimeKind.Unspecified).AddTicks(7758) },
                    { 151, 4, "YT40506-0", 2, new DateTime(2021, 9, 17, 14, 28, 19, 173, DateTimeKind.Unspecified).AddTicks(6819), new DateTime(2021, 7, 13, 1, 23, 50, 839, DateTimeKind.Unspecified).AddTicks(596) },
                    { 154, 4, "YT51295-0", 2, new DateTime(2021, 10, 7, 3, 10, 32, 617, DateTimeKind.Unspecified).AddTicks(3746), new DateTime(2021, 8, 12, 15, 44, 5, 430, DateTimeKind.Unspecified).AddTicks(9802) },
                    { 157, 4, "YT14544-1", 2, new DateTime(2021, 12, 30, 20, 45, 17, 641, DateTimeKind.Unspecified).AddTicks(1515), new DateTime(2021, 7, 12, 3, 11, 51, 477, DateTimeKind.Unspecified).AddTicks(6993) },
                    { 159, 3, "YT51425-0", 2, new DateTime(2021, 11, 11, 3, 43, 27, 383, DateTimeKind.Unspecified).AddTicks(4094), new DateTime(2021, 5, 30, 3, 54, 48, 330, DateTimeKind.Unspecified).AddTicks(1890) },
                    { 162, 5, "YT61422-1", 2, new DateTime(2021, 9, 12, 20, 53, 16, 45, DateTimeKind.Unspecified).AddTicks(7988), new DateTime(2021, 5, 20, 22, 34, 12, 294, DateTimeKind.Unspecified).AddTicks(224) },
                    { 165, 5, "YT23367-1", 2, new DateTime(2021, 12, 4, 13, 46, 39, 828, DateTimeKind.Unspecified).AddTicks(3155), new DateTime(2021, 6, 6, 9, 43, 22, 74, DateTimeKind.Unspecified).AddTicks(1745) },
                    { 120, 4, "YT13915-0", 2, new DateTime(2021, 11, 18, 0, 26, 33, 290, DateTimeKind.Unspecified).AddTicks(913), new DateTime(2021, 6, 27, 9, 44, 53, 575, DateTimeKind.Unspecified).AddTicks(3077) },
                    { 193, 3, "YT81570-1", 5, new DateTime(2021, 10, 1, 5, 11, 1, 876, DateTimeKind.Unspecified).AddTicks(2148), new DateTime(2021, 8, 7, 18, 15, 33, 746, DateTimeKind.Unspecified).AddTicks(4043) }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 120, "58702 McKenzie Trace", null, "East Tyler", null, "L6Q 5I0", "BC" },
                    { 105, "3923 Sporer Courts", null, "North Terryfort", null, "K5E 9N0", "NL" },
                    { 162, "88685 Beer Cliffs", null, "Jenningsfort", null, "H1Q 9A6", "NU" },
                    { 70, "063 Mathilde Landing", null, "Angelicaville", null, "A0G 0I4", "NB" },
                    { 167, "80149 Parisian Burg", null, "East Nigelstad", null, "E4W 5A7", "NB" },
                    { 113, "374 Bernadette Crest", null, "Kiehnfurt", null, "K2C 0P6", "NU" },
                    { 97, "74635 Doyle Canyon", null, "East Ruthhaven", null, "E4D 6W9", "ON" },
                    { 176, "1610 McCullough Orchard", null, "Port Greysonview", null, "S0B 2G8", "QC" },
                    { 146, "0933 Chanelle Drives", null, "East Luther", null, "N0T 9M4", "NL" },
                    { 173, "20342 Mitchell Run", null, "East Shemarborough", null, "A9F 5E6", "QC" },
                    { 95, "708 Kunde Run", null, "Rooseveltberg", null, "P7X 7J7", "BC" },
                    { 158, "62957 Gerard Station", null, "Abbottbury", null, "A1B 3I9", "NS" },
                    { 68, "6119 Koss Passage", null, "East Alba", null, "A4X 6G0", "ON" },
                    { 114, "019 O'Conner Keys", null, "Tobyborough", null, "R5K 7E5", "QC" },
                    { 78, "9827 Schamberger View", null, "West Monica", null, "V0S 0S4", "SK" },
                    { 60, "41559 Nadia Hills", null, "O'Keefeton", null, "P3D 1Y2", "ON" },
                    { 115, "0525 Mitchell Drive", null, "South Alycefort", null, "N0S 4C0", "QC" },
                    { 178, "9057 Willard Mission", null, "Stellashire", null, "B7L 2I7", "SK" },
                    { 23, "7893 Rolfson Forks", null, "New Callie", null, "K1A 8X1", "YT" },
                    { 88, "1584 Satterfield Manors", null, "Port Gregoria", null, "M3X 0L0", "YT" },
                    { 165, "00474 Lang Stravenue", null, "Port Staceystad", null, "K1C 4U7", "AB" },
                    { 56, "09101 Anne Expressway", null, "Creminshire", null, "M8Z 8Y8", "NT" },
                    { 182, "8729 Lowe Trail", null, "Deronton", null, "A7O 2J8", "NS" },
                    { 177, "5491 Timmothy Fords", null, "Ratkechester", null, "A6J 4J5", "BC" },
                    { 75, "926 Streich Village", null, "Goyettestad", null, "H1P 9U4", "NL" },
                    { 79, "233 Maximillia Springs", null, "Xzavierton", null, "R8X 8C6", "BC" },
                    { 84, "41126 Herminio Wall", null, "New Filibertohaven", null, "H5D 0G2", "PE" },
                    { 89, "9214 Torrey River", null, "Bernhardmouth", null, "V6P 4M3", "BC" },
                    { 109, "521 Lamont Estate", null, "South Conner", null, "L4K 2X5", "SK" },
                    { 110, "9926 Terry Mill", null, "Robbfort", null, "M0D 4N1", "NL" },
                    { 139, "016 Lehner Isle", null, "North Amparo", null, "E3R 3G0", "NT" },
                    { 14, "950 Rau Harbors", null, "Gusikowskitown", null, "J4H 1S1", "MB" },
                    { 108, "057 Kutch Plains", null, "Lake Felipaberg", null, "J2I 2B4", "NU" },
                    { 134, "8885 Bernhard Shoals", null, "West Larue", null, "S8M 6M7", "MB" },
                    { 117, "1426 Joey Mountains", null, "Wardstad", null, "E8K 3W3", "AB" },
                    { 107, "965 Johnston Garden", null, "Howellville", null, "S7D 6T4", "YT" },
                    { 147, "60698 MacGyver Stream", null, "Jeradland", null, "C8W 6A8", "NL" },
                    { 112, "5261 Weimann Vista", null, "Rosannaburgh", null, "X1Q 1L9", "QC" },
                    { 82, "548 Lilian Crest", null, "East Benjamin", null, "N3U 3T3", "NS" },
                    { 135, "18877 Lonny Gateway", null, "Port Clara", null, "P2F 6E0", "YT" },
                    { 106, "27463 Durgan Heights", null, "Edwardside", null, "B1W 8T1", "YT" },
                    { 104, "943 Schinner Flat", null, "Kuhlmantown", null, "X3A 2T1", "MB" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 103, "15177 Gorczany Corners", null, "Juvenalchester", null, "M6H 8P4", "NT" },
                    { 159, "13325 Corwin Pike", null, "Reillybury", null, "J3S 0V8", "MB" },
                    { 136, "172 Okuneva Ville", null, "Runtehaven", null, "P8S 8A7", "SK" },
                    { 193, "07287 Wilkinson Extension", null, "Lake Casimer", null, "N8O 7U4", "MB" },
                    { 96, "732 Kreiger Ville", null, "North Josephview", null, "J0J 6W3", "QC" },
                    { 101, "490 Rempel Rest", null, "Port Helmermouth", null, "G9G 8I6", "MB" },
                    { 100, "1145 Gutmann Freeway", null, "North Weldon", null, "Y4W 2T6", "NT" },
                    { 152, "031 Julien Junctions", null, "East Brookport", null, "J5Q 0N9", "YT" },
                    { 119, "230 Miller Canyon", null, "Hayestown", null, "S0M 8M6", "PE" },
                    { 128, "3690 Freeman Meadow", null, "Brownside", null, "C6S 3O0", "QC" },
                    { 69, "58943 Anderson Light", null, "Port Alta", null, "X6X 0H0", "NU" },
                    { 76, "3000 Julia Knoll", null, "West Brody", null, "E6J 2O2", "QC" },
                    { 43, "0001 Orlando Springs", null, "East Cristalville", null, "R4A 1X1", "MB" },
                    { 9, "5676 Hahn Valleys", null, "North Gertrudechester", null, "R1F 6C7", "SK" },
                    { 30, "43138 Ledner Inlet", null, "Schinnerchester", null, "K8L 2S3", "AB" },
                    { 16, "66081 Nolan Isle", null, "Justenborough", null, "B2A 4K0", "NL" },
                    { 6, "83714 Torphy Passage", null, "Eloiseburgh", null, "K5N 3O4", "NU" },
                    { 58, "97308 Kuhic Greens", null, "Huelland", null, "X3Y 3W5", "NB" },
                    { 20, "191 Melvin Lights", null, "North Pinkie", null, "K0R 3Z6", "ON" },
                    { 3, "7151 Anais Road", null, "Port Jon", null, "G3V 2E7", "ON" },
                    { 129, "20118 Tremaine Isle", null, "Judeville", null, "J1H 7W0", "NL" },
                    { 175, "25058 Berge Brook", null, "North Macie", null, "Y0G 3Q0", "MB" },
                    { 13, "8297 Crystal Ports", null, "East Ladarius", null, "P0N 3H6", "SK" },
                    { 51, "221 Schimmel Prairie", null, "Cruzshire", null, "B4M 2S2", "NT" },
                    { 1, "742 Greenfelder Orchard", null, "South Jerel", null, "E2T 5G3", "SK" },
                    { 42, "9398 Larkin Land", null, "Isaistad", null, "B0D 7L5", "NB" },
                    { 38, "844 Judd Spring", null, "Wizahaven", null, "A6L 7Y8", "ON" },
                    { 188, "77427 Steuber Glens", null, "East Jerod", null, "L4T 1R0", "NL" },
                    { 131, "03294 Damien Mission", null, "Alizaborough", null, "M4R 8F8", "SK" },
                    { 37, "8796 Champlin Way", null, "East Aidatown", null, "M0M 7L8", "YT" },
                    { 39, "8996 Keeling Expressway", null, "Margarettchester", null, "N2C 5V1", "AB" },
                    { 41, "8828 Senger Ferry", null, "South Stone", null, "N5X 4Q2", "AB" },
                    { 187, "1986 Broderick Street", null, "Zechariahmouth", null, "R5U 8D4", "NB" },
                    { 35, "6367 Jones Fork", null, "Cameronfurt", null, "N1J 0D1", "ON" },
                    { 33, "2390 Runolfsdottir Stream", null, "South Mohammadshire", null, "T8J 0S4", "PE" },
                    { 63, "9305 Schamberger Corners", null, "South Amparotown", null, "K4T 3N9", "NS" },
                    { 174, "14876 Diego Club", null, "Brettville", null, "T9B 8D3", "BC" },
                    { 126, "807 Streich Track", null, "Ryanbury", null, "G2H 4T7", "YT" },
                    { 183, "88554 Joan Oval", null, "Stokesport", null, "K6F 5F9", "NB" },
                    { 145, "571 Kautzer Freeway", null, "Lilymouth", null, "M3N 5Z0", "QC" },
                    { 34, "859 Mose Forest", null, "New Cindy", null, "N0E 1P5", "NB" },
                    { 26, "7026 Carey Hill", null, "Port Mike", null, "G7B 7H9", "NU" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 191, "322 Alexzander Street", null, "West Fredrickstad", null, "B3I 9S6", "NB" },
                    { 27, "351 Price Camp", null, "New Hiltonbury", null, "G0C 6Q0", "NT" },
                    { 122, "73830 Augusta Road", null, "Port Kayleigh", null, "E9T 0P9", "NL" },
                    { 74, "0091 Raynor Fork", null, "North Rollin", null, "J8E 6M6", "NB" },
                    { 195, "618 Kunde Lodge", null, "Hahnville", null, "V2W 8L1", "NL" },
                    { 57, "036 Lenore Inlet", null, "Loraview", null, "X8H 5R4", "NT" },
                    { 197, "514 Davis Harbors", null, "Naderton", null, "Y3D 8Y1", "AB" },
                    { 22, "62701 Kemmer Orchard", null, "Piperberg", null, "T2G 0J9", "AB" },
                    { 123, "98357 Ernser Villages", null, "Aiyanachester", null, "H1Z 4A2", "MB" },
                    { 169, "8168 Kunde Place", null, "South Bethel", null, "R1M 4M4", "NT" },
                    { 72, "2419 Summer Meadows", null, "Williamsonbury", null, "J4P 3I9", "PE" },
                    { 198, "7252 Torphy Ford", null, "New Jalenburgh", null, "H2M 5V4", "NB" },
                    { 17, "0654 Reta Haven", null, "East Vickie", null, "V9Z 9V2", "NL" },
                    { 48, "73664 Barton Spur", null, "Lonburgh", null, "B0F 9H0", "NU" },
                    { 67, "91683 Nolan Glen", null, "Bethanymouth", null, "B0H 0O3", "NS" },
                    { 11, "303 Vinnie Union", null, "East Ivyfurt", null, "X4D 8I6", "NL" },
                    { 142, "819 Dashawn Turnpike", null, "Derrickside", null, "J5Z 7X3", "AB" },
                    { 199, "68731 Domenico Springs", null, "Lake Annebury", null, "A6B 4Y9", "ON" },
                    { 10, "482 Mitchell Spur", null, "Howellstad", null, "J4H 2I0", "ON" },
                    { 55, "316 Jarred Place", null, "North Eriberto", null, "H1D 8F2", "NL" },
                    { 83, "14268 Renner Street", null, "Lockmanchester", null, "M8R 1K2", "AB" },
                    { 121, "98618 Rau Wall", null, "West Hannah", null, "P6Y 6W0", "NS" },
                    { 111, "0278 Huels Valley", null, "Skilesberg", null, "J7W 6W3", "AB" },
                    { 179, "23124 Roob Well", null, "West Madisenchester", null, "J3I 4T9", "ON" },
                    { 192, "8319 Zackary Plain", null, "Andersonton", null, "A0P 0I0", "QC" },
                    { 36, "5380 Rolfson Junction", null, "Port Marcellefurt", null, "T5G 6Z4", "BC" },
                    { 46, "21537 Estevan Streets", null, "South Toneyberg", null, "J3U 0T8", "NB" },
                    { 153, "805 Janae Keys", null, "East Oda", null, "E5H 5P9", "MB" },
                    { 92, "23161 Amparo Coves", null, "Hilllberg", null, "J8O 5U9", "NT" },
                    { 189, "47769 Olen Shoal", null, "Burdetteton", null, "B9D 6V3", "YT" },
                    { 44, "461 Windler Pass", null, "Bodeview", null, "L9T 7F6", "PE" },
                    { 133, "144 Rita Pass", null, "South May", null, "J5C 5S1", "NU" },
                    { 47, "20401 Fermin Mountains", null, "New Chyna", null, "L4E 5P0", "ON" },
                    { 45, "9642 Rosetta Crest", null, "New Lonny", null, "A8H 6A5", "YT" },
                    { 148, "9929 Daugherty Loaf", null, "Runolfsdottirborough", null, "C5B 2V6", "YT" },
                    { 164, "036 Enos Crossing", null, "Romaguerafurt", null, "T1H 7N3", "NB" },
                    { 185, "187 Dell Spur", null, "Brakusbury", null, "A9L 4H3", "NT" },
                    { 59, "37421 Hickle Junction", null, "North Dawnport", null, "T3V 5F8", "YT" },
                    { 50, "456 Ondricka Port", null, "East Chaim", null, "M9J 8B0", "MB" },
                    { 91, "848 Tomas Drive", null, "MacGyverbury", null, "X4S 4E2", "SK" },
                    { 99, "651 Willms Square", null, "New Dejashire", null, "L8V 9F7", "SK" },
                    { 190, "341 Beatty Fords", null, "Fadelmouth", null, "E0A 1X1", "NS" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 141, "48890 Connie Camp", null, "Nolanport", null, "K3Q 9Z4", "SK" },
                    { 172, "352 Hessel Keys", null, "East Billhaven", null, "N8R 5V9", "SK" },
                    { 137, "015 Beier Expressway", null, "South Leliaport", null, "T4L 4B5", "NU" },
                    { 49, "87489 Lea Vista", null, "East Irwinchester", null, "C5D 5V8", "NL" },
                    { 32, "3267 Michele Extensions", null, "Lake Fern", null, "L1P 8V4", "SK" },
                    { 194, "1345 Erling Grove", null, "South Elsie", null, "V8H 2P1", "YT" },
                    { 29, "520 Padberg Streets", null, "South Karina", null, "E4S 8Y3", "AB" },
                    { 28, "950 Coleman Way", null, "Lake Alfordbury", null, "N7N 9Q7", "NS" },
                    { 4, "118 Carmine Plains", null, "Torphyton", null, "H2L 6Y2", "QC" },
                    { 19, "960 Kaden Pine", null, "West Barry", null, "E1T 8T5", "NB" },
                    { 102, "816 Denesik Wells", null, "Bauchstad", null, "N0G 0A8", "NS" },
                    { 184, "969 Friesen Points", null, "East Abigalemouth", null, "E8C 6Z0", "PE" },
                    { 7, "7541 Jabari Islands", null, "New Amalia", null, "G2R 5V2", "BC" },
                    { 18, "02324 Wehner Pass", null, "Austinfort", null, "P1P 9H4", "SK" },
                    { 31, "565 Wintheiser Camp", null, "Wildermanhaven", null, "T2K 4Z6", "ON" },
                    { 12, "8253 Marley Lake", null, "East Martinabury", null, "C8C 7K0", "PE" },
                    { 124, "38937 Blake Lane", null, "Veumtown", null, "K5T 9D7", "SK" },
                    { 180, "876 Jerde Greens", null, "New Gunner", null, "P0N 2U3", "YT" },
                    { 15, "80767 Nitzsche Gateway", null, "Nataliafurt", null, "T1H 3R8", "NT" },
                    { 24, "514 Phyllis Falls", null, "Port Bettymouth", null, "C3T 9F8", "MB" },
                    { 40, "9635 Evalyn Flat", null, "Harrisstad", null, "C6Y 8B4", "PE" },
                    { 94, "29438 Beier Forest", null, "Billiefort", null, "P2L 8D8", "AB" },
                    { 25, "645 Grady Land", null, "Reganshire", null, "K3X 6D6", "PE" },
                    { 8, "541 Rau Ridge", null, "Virgilberg", null, "T6P 5W2", "AB" },
                    { 166, "02569 Mabel Flats", null, "Hickleview", null, "T3G 0D2", "NT" },
                    { 21, "1883 Makayla Junction", null, "Port Litzyville", null, "K0I 5I5", "PE" },
                    { 5, "811 Arnoldo Garden", null, "Johnsborough", null, "S6E 2A1", "NB" },
                    { 168, "41319 Demetris Mountain", null, "West Johanland", null, "B7Q 3A1", "NS" },
                    { 127, "37586 Kaleb Square", null, "Piperstad", null, "E5S 1B4", "NB" },
                    { 196, "6629 Mose Gardens", null, "Gutkowskiport", null, "M9O 8P6", "MB" },
                    { 61, "16209 Mueller Summit", null, "Lake Margretchester", null, "B2Q 0X6", "NU" },
                    { 52, "847 Hattie Flats", null, "Port Theresiamouth", null, "H4B 6W9", "AB" },
                    { 181, "51221 Schroeder Dale", null, "Kozeyton", null, "N7E 0Y3", "QC" },
                    { 171, "255 Zieme Road", null, "North Gilbertobury", null, "J1Z 1H8", "NU" },
                    { 155, "48997 Rolando Way", null, "Zemlakfurt", null, "H9P 9O9", "BC" },
                    { 125, "31310 Kale Heights", null, "Hermantown", null, "K6X 4U5", "NB" },
                    { 160, "453 Botsford Valleys", null, "West Martin", null, "V8O 8N0", "AB" },
                    { 65, "2765 Parisian Trace", null, "East Kaia", null, "M3F 9A8", "NB" },
                    { 118, "7929 Kassulke Station", null, "Port Ricardo", null, "H9G 7Y6", "ON" },
                    { 80, "431 Cummerata Bypass", null, "Lake Selinamouth", null, "X0C 2O0", "NU" },
                    { 154, "95593 Jacobi Streets", null, "Port Erlingchester", null, "X9N 2K0", "BC" },
                    { 156, "800 Kihn Pike", null, "New Okey", null, "E9F 9L5", "MB" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 81, "236 Mraz Plains", null, "Lake Shanetown", null, "X1F 9O4", "SK" },
                    { 66, "3587 Grant Fork", null, "Port Oletown", null, "J1D 1F9", "NL" },
                    { 200, "37878 Nova Islands", null, "Abelview", null, "A4Q 1Q8", "NL" },
                    { 85, "490 Armstrong Spurs", null, "Pfannerstillfurt", null, "M9D 0M7", "SK" },
                    { 149, "78022 Zella Mission", null, "Cummerataland", null, "P6B 0N1", "SK" },
                    { 2, "893 Tremblay Fall", null, "West Cassiestad", null, "N8J 9O1", "ON" },
                    { 116, "81870 Chance Shoals", null, "New Austynport", null, "E0W 7V1", "SK" },
                    { 144, "916 Cristina Hills", null, "Lake Eltonside", null, "P4G 7G0", "YT" },
                    { 93, "258 Mitchell Trail", null, "Port Casper", null, "R3H 2F8", "AB" },
                    { 77, "175 Balistreri Hill", null, "Pollichchester", null, "J0T 5V4", "PE" },
                    { 150, "024 Ortiz Crossing", null, "Waelchiland", null, "A9M 6I4", "NS" },
                    { 157, "6286 Lubowitz Bridge", null, "Port Stefanie", null, "M7L 1U6", "NB" },
                    { 98, "2980 Zieme Hills", null, "North Aliciabury", null, "K1M 6T4", "MB" },
                    { 143, "286 Felton Stravenue", null, "West Ova", null, "P3G 8F4", "YT" },
                    { 87, "56896 Johnnie Wall", null, "North Garnett", null, "E9Z 8V7", "NU" },
                    { 73, "25343 Stanley Trafficway", null, "Port Montychester", null, "B8E 0F4", "SK" },
                    { 186, "434 Dooley Ville", null, "North Eloise", null, "H9F 5O9", "NT" },
                    { 71, "765 O'Keefe Points", null, "West Rickeyborough", null, "V3E 3N1", "NS" },
                    { 138, "898 Gabriel Ports", null, "East Ezra", null, "T2M 4F1", "MB" },
                    { 151, "9166 Welch Ridges", null, "West Izaiah", null, "Y7S 7W3", "NL" },
                    { 54, "2816 Conroy Hill", null, "Balistrerimouth", null, "J1C 4O8", "NS" },
                    { 90, "568 Schneider Hill", null, "Lake Eliasborough", null, "M8Q 1F6", "QC" },
                    { 132, "435 Block River", null, "North Vivien", null, "S7T 7P1", "YT" },
                    { 163, "597 Johnston Dam", null, "Ginomouth", null, "L8U 6A2", "MB" },
                    { 62, "1744 Edgardo Inlet", null, "Lake Leonardoshire", null, "Y0W 8E8", "NS" },
                    { 86, "72183 Turner Branch", null, "West Kennediton", null, "A5D 6K1", "BC" },
                    { 170, "924 Arnulfo Crossing", null, "Blockfurt", null, "E9Q 7O6", "MB" },
                    { 53, "83691 Gail Lodge", null, "Schambergerburgh", null, "B9C 7N7", "MB" },
                    { 140, "1737 Claudie Forges", null, "Lake Eloise", null, "K2H 2I7", "BC" },
                    { 130, "569 Kuhic Course", null, "New Janessa", null, "C0L 3J5", "BC" },
                    { 161, "0905 Roxane Road", null, "East Micahview", null, "L4C 3K6", "SK" },
                    { 64, "261 Reichel Knolls", null, "Wilfredborough", null, "V0U 3Z3", "ON" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 166, "925 Brandon Valley", null, "North Carolyne", null, "H6C 8A4", "PE" },
                    { 139, "321 Schultz Pines", null, "Maxwellmouth", null, "S4E 7G2", "PE" },
                    { 155, "151 Tremaine Brook", null, "Daynaborough", null, "L3I 3Z5", "YT" },
                    { 120, "294 Carter Stravenue", null, "East Martyhaven", null, "A6D 7M9", "ON" },
                    { 145, "34827 Litzy Flats", null, "Powlowskishire", null, "K6R 0G1", "SK" },
                    { 175, "7577 Hilbert Street", null, "Columbusmouth", null, "A8A 7M8", "MB" },
                    { 165, "281 Rempel Via", null, "Wunschtown", null, "T4L 5C5", "AB" },
                    { 157, "898 Wolf Center", null, "Port Bethel", null, "N3X 5W7", "NT" },
                    { 169, "2096 Kreiger Turnpike", null, "Donavonmouth", null, "H3V 6P6", "AB" },
                    { 124, "35990 Maxie Valley", null, "New Katheryn", null, "P7W 0U4", "QC" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 164, "49134 Strosin Burg", null, "North Ethylchester", null, "E6D 4P7", "SK" },
                    { 174, "21180 Abelardo Lake", null, "West Gregorio", null, "K8S 8L8", "PE" },
                    { 151, "231 Hammes Inlet", null, "Bednarfort", null, "B3D 6A9", "MB" },
                    { 154, "521 Leannon Fords", null, "South Jessy", null, "Y3M 2G9", "PE" },
                    { 133, "184 Kuphal Station", null, "South Greysonhaven", null, "J7R 4U9", "PE" },
                    { 142, "72267 Considine Light", null, "Pagacmouth", null, "S1A 3Y0", "SK" },
                    { 159, "959 Coy Square", null, "Port Dameonview", null, "L1N 5B8", "ON" },
                    { 150, "82697 Zemlak Street", null, "North Joanaport", null, "K6N 1Y5", "NL" },
                    { 162, "080 Emmalee Skyway", null, "Friesenside", null, "L4D 7J7", "NT" },
                    { 137, "36871 Erick Forks", null, "Unastad", null, "T1Z 6I0", "AB" },
                    { 146, "95128 Jessica Village", null, "Dollymouth", null, "V8C 7Q6", "NU" },
                    { 147, "918 Effertz Extension", null, "Dietrichside", null, "P1R 0Q7", "BC" },
                    { 127, "50668 Sidney Street", null, "New Frankieport", null, "M8H 2J8", "YT" },
                    { 68, "262 Zboncak Vista", null, "Lake Estevanmouth", null, "A8L 3Y4", "NS" },
                    { 187, "82242 Wisoky Camp", null, "Hillsshire", null, "S1R 1M4", "NS" },
                    { 59, "50744 Kub Hills", null, "New Jettshire", null, "J2E 4C9", "YT" },
                    { 171, "98265 Cheyanne Meadow", null, "Harleyborough", null, "S5M 3R7", "NB" },
                    { 61, "75405 Funk Run", null, "West Rubyside", null, "A5U 7S2", "AB" },
                    { 170, "76058 Adriel Curve", null, "New Lee", null, "X0B 3H0", "YT" },
                    { 62, "101 Funk Union", null, "East Zoila", null, "B7X 1Y9", "YT" },
                    { 163, "75439 Moore Haven", null, "Port Wilfredo", null, "J4L 1R5", "YT" },
                    { 172, "86722 Brandyn Crescent", null, "South Elvis", null, "H4E 0N2", "NT" },
                    { 161, "39868 Brekke Curve", null, "Odellfort", null, "V6M 4H5", "BC" },
                    { 160, "406 Klocko Track", null, "East Charleyland", null, "P4N 6B1", "BC" },
                    { 65, "81522 Gleichner Inlet", null, "Littleberg", null, "B3U 0T6", "SK" },
                    { 156, "0296 Katherine Lodge", null, "Lake Ethyl", null, "A5E 5A9", "AB" },
                    { 66, "88253 Dayne Pike", null, "Bruenborough", null, "E7U 2Z9", "AB" },
                    { 149, "946 Heaney Circle", null, "Vidafort", null, "J0I 8U1", "MB" },
                    { 144, "890 Lang Mountains", null, "Bellefort", null, "T5F 8H5", "BC" },
                    { 64, "3237 Erna Road", null, "East Trevorfurt", null, "V4W 8A7", "QC" },
                    { 77, "9431 Lilla Ridge", null, "Tyrelshire", null, "T8S 4W0", "NT" },
                    { 181, "3813 Jodie Run", null, "Lake Tremaine", null, "Y7C 5Q5", "BC" },
                    { 47, "28823 Reyes Creek", null, "Delbertfurt", null, "C6A 9G6", "AB" },
                    { 19, "0001 Amie Hollow", null, "Joanyside", null, "Y4O 5M1", "NL" },
                    { 28, "9926 Adaline Ferry", null, "Josuehaven", null, "H2P 4L2", "BC" },
                    { 18, "0930 Lee Square", null, "West Myratown", null, "J7U 4I0", "QC" },
                    { 15, "372 Hahn Villages", null, "East Reece", null, "R8I 4V4", "BC" },
                    { 31, "1537 Brendon Vista", null, "North Maeganfurt", null, "C6W 3Q0", "NU" },
                    { 8, "34987 Elizabeth Camp", null, "Lake Taya", null, "B1Z 7G0", "NL" },
                    { 185, "338 Webster Vista", null, "Billieview", null, "S5V 8T8", "SK" },
                    { 40, "610 Waldo Radial", null, "Ankundingbury", null, "R0T 2M2", "NL" },
                    { 196, "5174 Aditya Manor", null, "Vandervortberg", null, "Y5I 0U6", "NS" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 194, "302 Jeromy Locks", null, "Yolandahaven", null, "T4X 5G6", "MB" },
                    { 192, "5752 Parker Flat", null, "Serenitystad", null, "R1M 6Q4", "AB" },
                    { 45, "553 Hickle Walk", null, "Raeborough", null, "N4U 9D7", "NL" },
                    { 189, "5716 Coby Extensions", null, "New Samir", null, "H1F 7R5", "NU" },
                    { 46, "5437 Matt Haven", null, "Nikolausshire", null, "Y4N 0Y7", "NU" },
                    { 5, "7440 Wyman Passage", null, "Fisherview", null, "S9E 8R1", "NB" },
                    { 143, "35503 Jacobs Ville", null, "North Ivy", null, "C0E 0X3", "PE" },
                    { 128, "34721 Dora Vista", null, "Port Percival", null, "C9R 3B0", "ON" },
                    { 121, "28634 Fadel Ridges", null, "Rathport", null, "A3L 5P8", "PE" },
                    { 122, "6017 Thora Trafficway", null, "Volkmanside", null, "L2I 7P8", "ON" },
                    { 22, "5605 Raynor Turnpike", null, "New Herminiostad", null, "C4F 4H6", "NS" },
                    { 123, "151 Nolan Vista", null, "Lake Melanyville", null, "C6H 3R8", "NU" },
                    { 17, "544 Jewell Throughway", null, "East Ethan", null, "V7S 5A6", "ON" },
                    { 11, "643 Morissette Underpass", null, "Marianneton", null, "H9W 5N2", "ON" },
                    { 10, "07649 Twila Rapid", null, "West Catharineberg", null, "X2G 7Q1", "QC" },
                    { 27, "343 Veronica Gardens", null, "Kuhlmanberg", null, "A5Y 2D1", "PE" },
                    { 126, "01394 Crona Plaza", null, "Faymouth", null, "C9Q 3G8", "MB" },
                    { 6, "23614 Monahan Brook", null, "Jaysonburgh", null, "R2E 2K6", "NS" },
                    { 3, "145 Bell Overpass", null, "Port Josefaville", null, "C7J 7Q6", "NT" },
                    { 1, "38625 Sylvan Unions", null, "North Sammy", null, "X8Z 5K2", "NS" },
                    { 129, "801 Earlene Ferry", null, "Clairborough", null, "X0D 9W6", "YT" },
                    { 188, "10606 Cory Locks", null, "Klockotown", null, "E5E 6E4", "PE" },
                    { 131, "07217 Davonte Crossing", null, "Breanneland", null, "L8M 5J3", "YT" },
                    { 9, "8740 Ferry Ports", null, "Lake Pasquale", null, "M7J 0F4", "MB" },
                    { 34, "5202 Alanis Locks", null, "Morarbury", null, "V5A 5R6", "PE" },
                    { 119, "38013 Murazik Valley", null, "Turnermouth", null, "A7F 4C4", "NS" },
                    { 55, "6947 Clovis Village", null, "Jewellland", null, "Y6M 6L0", "NS" },
                    { 89, "26514 Abigale Spur", null, "Stokeschester", null, "C8W 0T7", "MB" },
                    { 117, "34152 Edward Highway", null, "Magnoliahaven", null, "S1P 7E9", "SK" },
                    { 112, "70963 Carter Extensions", null, "New Valliemouth", null, "J0F 7P8", "SK" },
                    { 106, "40186 Strosin Knoll", null, "Port Gretchenton", null, "B5I 2T8", "SK" },
                    { 103, "5562 Jaylin Lane", null, "New Kendrick", null, "K6N 6G5", "ON" },
                    { 96, "8840 Pouros Road", null, "New Garettborough", null, "V7M 2A4", "BC" },
                    { 84, "270 Kara Hills", null, "Hicklemouth", null, "C2B 3D3", "YT" },
                    { 75, "9153 Alivia Manors", null, "Lake Pattie", null, "E2W 8T4", "MB" },
                    { 105, "20136 Carmine Junctions", null, "South Quincyfort", null, "J3R 7U3", "NS" },
                    { 70, "94908 Kessler Plaza", null, "Port Janiyahaven", null, "P7I 8I9", "NT" },
                    { 113, "90940 Ledner Stream", null, "East Ludieborough", null, "N4Q 7S0", "NT" },
                    { 114, "771 Marty Place", null, "Lake Josianeville", null, "S2U 5J8", "NL" },
                    { 60, "88454 Mariana Plain", null, "Powlowskiburgh", null, "V0Y 1L0", "QC" },
                    { 115, "434 Danny Summit", null, "Lake Maegan", null, "Y8V 0J7", "NS" },
                    { 56, "35194 Gottlieb Island", null, "Novellaville", null, "G7E 9G6", "PE" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 186, "5641 Emmett Locks", null, "Pacochachester", null, "K3A 0U0", "NL" },
                    { 193, "6643 Rick Points", null, "South Tomas", null, "L4H 6Q3", "NU" },
                    { 21, "454 Veum Extensions", null, "North Gavin", null, "G3G 0M7", "PE" },
                    { 97, "12588 Waelchi Prairie", null, "New Finn", null, "C6W 3S5", "AB" },
                    { 132, "0038 Emelie Forges", null, "Manuelview", null, "S5U 9J7", "PE" },
                    { 191, "798 Samanta Branch", null, "Quitzonfurt", null, "S4C 3O7", "SK" },
                    { 138, "27628 Schroeder Rest", null, "East Aditya", null, "E5A 1T2", "AB" },
                    { 74, "238 Herzog Run", null, "Port Tateland", null, "J6P 2J6", "BC" },
                    { 195, "41771 Mertz Court", null, "New Gabrielport", null, "J9N 9A0", "QC" },
                    { 53, "86819 Gregg Stravenue", null, "North Aliberg", null, "L0W 0V6", "BC" },
                    { 197, "063 Schultz Cove", null, "South Josie", null, "P2R 1K5", "NB" },
                    { 140, "984 Bashirian Port", null, "Kuhicshire", null, "B8W 0X1", "MB" },
                    { 52, "410 Schaefer Glen", null, "Agustinamouth", null, "A5A 6U3", "QC" },
                    { 72, "8525 Rocky Wells", null, "Danielton", null, "R8C 0D8", "YT" },
                    { 198, "2423 Zemlak Canyon", null, "Labadieburgh", null, "X7H 6I9", "YT" },
                    { 67, "6777 Keagan Island", null, "Lexiehaven", null, "J8U 0O6", "YT" },
                    { 141, "51524 Enrique Canyon", null, "South Wilhelmine", null, "G7N 7Q1", "NB" },
                    { 50, "43234 Noemie Ridges", null, "Marilyneview", null, "K8V 2H7", "NS" },
                    { 199, "72942 Stokes Drive", null, "Port Sharonville", null, "L1T 3Q3", "PE" },
                    { 63, "24848 Jasen Village", null, "Kulasland", null, "S8Y 3X9", "NL" },
                    { 109, "2605 Annalise Keys", null, "Lake Gianniberg", null, "K6W 8R6", "NB" },
                    { 13, "27205 Hauck Fords", null, "Gislasontown", null, "R9O 7Y2", "NB" },
                    { 49, "9069 Maxime Extension", null, "Labadieburgh", null, "P7G 8T3", "NL" },
                    { 58, "0723 Aufderhar Club", null, "East Justina", null, "K7J 8Y8", "NT" },
                    { 16, "4713 Corene Mountain", null, "Windlerbury", null, "L4R 9Z6", "BC" },
                    { 148, "31593 Greenholt Pass", null, "South Kamrenside", null, "P1E 5F3", "NL" },
                    { 20, "0614 Lind Lock", null, "North Abdiel", null, "G0I 8K0", "MB" },
                    { 51, "6044 Quigley Ports", null, "Koryborough", null, "H6K 5Q7", "NU" },
                    { 33, "87881 Ebert Fork", null, "Lake Kaitlyn", null, "G9D 1L5", "YT" },
                    { 44, "34861 Alison Ramp", null, "Valentinland", null, "P2X 8M0", "YT" },
                    { 38, "96889 Lionel Well", null, "New Cartermouth", null, "M6F 3O1", "QC" },
                    { 37, "997 Hirthe Passage", null, "West Kellie", null, "M0P 0Q9", "PE" },
                    { 39, "0146 Hammes Pike", null, "Douglasfurt", null, "M5O 5T6", "NS" },
                    { 54, "6758 Hessel Lodge", null, "Linwoodfort", null, "V5S 8B8", "YT" },
                    { 35, "685 Sharon Mission", null, "West William", null, "A5G 7Z9", "NU" },
                    { 130, "78657 Upton Isle", null, "Lockmanland", null, "G3J 6E0", "SK" },
                    { 76, "811 Kreiger Spurs", null, "Port Braxton", null, "A5Z 9G1", "AB" },
                    { 108, "95475 Kuvalis Branch", null, "Lake Eunice", null, "A4K 4E7", "NT" },
                    { 99, "8802 Lincoln Estates", null, "East Rhettville", null, "L1I 2T4", "NT" },
                    { 134, "50133 Granville Lights", null, "New Santina", null, "T0M 8C4", "AB" },
                    { 107, "990 Collier Lights", null, "West Jose", null, "T8E 6H9", "SK" },
                    { 98, "3906 Sauer Locks", null, "Omerberg", null, "A8P 9W0", "PE" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 111, "9591 Legros Shoals", null, "South Joesph", null, "M1Y 2U2", "ON" },
                    { 104, "737 Rhianna Burg", null, "Dayanafort", null, "L7B 2S1", "NL" },
                    { 135, "4781 Weber Trail", null, "North Benedictshire", null, "J6I 5E9", "YT" },
                    { 93, "97023 Richmond Cove", null, "Murazikland", null, "B1I 2A3", "YT" },
                    { 116, "33602 D'angelo Squares", null, "Deshaunfort", null, "G9S 0R4", "PE" },
                    { 136, "85793 Alessia Plains", null, "Lake Ethyl", null, "T5K 0N0", "NB" },
                    { 101, "8673 Wunsch Isle", null, "Marvinburgh", null, "J7L 4I4", "MB" },
                    { 100, "01832 Wilburn Divide", null, "Marquisetown", null, "C8Z 9U9", "MB" },
                    { 152, "56438 Willy Rest", null, "Hintzfort", null, "V5V 3S6", "NU" },
                    { 87, "435 Naomie Green", null, "West Hassan", null, "T6U 2U8", "AB" },
                    { 158, "4033 Maxine Cape", null, "West Henriborough", null, "H4F 7Y3", "QC" },
                    { 81, "518 Simonis Loop", null, "West Aydenville", null, "S9H 3I5", "MB" },
                    { 80, "159 Block Shore", null, "Lake Zelda", null, "T4R 0T0", "PE" },
                    { 118, "29830 Audra Trace", null, "Lake Gunnarside", null, "P9Y 8L8", "NT" },
                    { 167, "03400 Chesley Causeway", null, "Dorisport", null, "M5P 7K1", "NU" },
                    { 176, "00193 Lockman Gardens", null, "Daughertyberg", null, "A9F 8S1", "NL" },
                    { 95, "1009 Heidi Keys", null, "Lake Finnberg", null, "J2L 8M8", "NT" },
                    { 177, "870 Gladyce Falls", null, "Port Gilbert", null, "G9S 6D9", "YT" },
                    { 125, "0727 Tatum Lights", null, "East Tessiefurt", null, "G7P 2R3", "QC" },
                    { 88, "39690 Nova Turnpike", null, "Port Jeanneside", null, "J9J 9P2", "NS" },
                    { 178, "3949 Murazik Plaza", null, "East Angelitafurt", null, "A3G 0U5", "BC" },
                    { 73, "387 Armstrong Greens", null, "West Ivaberg", null, "R2X 6Y8", "PE" },
                    { 182, "9405 Reichel Roads", null, "Lake Beau", null, "N1L 5H2", "AB" },
                    { 71, "35305 Greenholt Spurs", null, "Bogisichfurt", null, "E2M 5E0", "PE" },
                    { 183, "7205 Bradtke View", null, "Brandonview", null, "Y6P 3X7", "YT" },
                    { 153, "7164 Kreiger Circles", null, "East Noemiefurt", null, "H8C 4A3", "NS" },
                    { 110, "60093 Everette Spurs", null, "Lake Jaylin", null, "A3Z 9C7", "NS" },
                    { 91, "20764 Norene Parkway", null, "North Emmet", null, "V6Y 8W6", "BC" },
                    { 168, "701 Heidenreich Alley", null, "Eratown", null, "K0Y 9M6", "SK" },
                    { 179, "0979 Zena Spring", null, "Lake Giovannyhaven", null, "S2J 0B0", "MB" },
                    { 4, "9754 Otho Village", null, "Lake Cleta", null, "S7Q 4V0", "NL" },
                    { 23, "00586 Mosciski Haven", null, "Dooleymouth", null, "T7C 5W4", "NS" },
                    { 69, "070 Billy Mills", null, "Port Elvabury", null, "G5N 9J6", "ON" },
                    { 78, "8623 Estrella Roads", null, "Darronburgh", null, "Y7Z 4B3", "BC" },
                    { 25, "80834 Gerhold Lodge", null, "Kadinhaven", null, "E2Q 8L5", "NB" },
                    { 190, "553 Durgan Springs", null, "West Chadrickshire", null, "Y0F 4C2", "YT" },
                    { 79, "523 Jean Ports", null, "West Dexter", null, "C1Y 2U7", "NB" },
                    { 90, "8554 Estell Groves", null, "Jaskolskiborough", null, "N5A 8T1", "BC" },
                    { 24, "84767 Grant Squares", null, "Lake Natashahaven", null, "Y6J 3W4", "NL" },
                    { 82, "15365 Trantow Roads", null, "Osinskitown", null, "V2X 1E2", "NB" },
                    { 184, "8636 Doug Inlet", null, "North Julianne", null, "T2O 2G3", "BC" },
                    { 14, "072 Goodwin Crescent", null, "Rosalynville", null, "H6E 2N8", "YT" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 86, "7217 Stroman Motorway", null, "Hirthehaven", null, "G6N 2I9", "MB" },
                    { 200, "146 Stokes Summit", null, "Felicitystad", null, "E5F 5U7", "NB" },
                    { 83, "814 Bode Fields", null, "Lake Johantown", null, "M7W 0Z8", "NB" },
                    { 7, "2834 Lew Pines", null, "South Theodora", null, "G3W 4W7", "SK" },
                    { 12, "996 Enrico Parks", null, "Ikefurt", null, "C2O 2R2", "NT" },
                    { 2, "769 Durgan Mountain", null, "Kennyton", null, "T0J 5D2", "SK" },
                    { 85, "070 Batz Brook", null, "Hartmannport", null, "A1X 3N3", "NS" },
                    { 92, "066 Aylin Junctions", null, "New Carrollshire", null, "X6K 5T7", "AB" },
                    { 57, "3508 Albin Way", null, "West Shaniya", null, "T7R 2E9", "MB" },
                    { 180, "222 Parker Squares", null, "Port Nashfurt", null, "M5Q 1U8", "QC" },
                    { 26, "460 Kiana Crossing", null, "Buckridgechester", null, "A9E 8Y0", "AB" },
                    { 29, "518 Cartwright Stravenue", null, "North Christianville", null, "T0R 6X3", "ON" },
                    { 42, "24245 Klocko Wells", null, "Peytonborough", null, "J2J 7F2", "AB" },
                    { 94, "2493 Linnie Well", null, "South Audrey", null, "C8M 8Y0", "BC" },
                    { 30, "9703 Balistreri Radial", null, "Kutchview", null, "L0U 4O2", "YT" },
                    { 43, "060 Morar Motorway", null, "Port Vincenza", null, "G5U 9P9", "MB" },
                    { 41, "2180 Kuhn Manor", null, "Adelineburgh", null, "C4T 8M6", "SK" },
                    { 32, "56166 Tillman Views", null, "New Billybury", null, "V7G 0V1", "NS" },
                    { 102, "457 Margarette Burg", null, "Hilpertstad", null, "J5U 9Z3", "BC" },
                    { 173, "0323 Zola Green", null, "South Natalie", null, "N9C 8W0", "ON" },
                    { 48, "651 Reichert Pines", null, "Port Annabel", null, "V1L 6A6", "NL" },
                    { 36, "685 Maggio Rapid", null, "Wisozkchester", null, "G3L 5S7", "NL" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 416, "Explicabo quaerat voluptates corrupti voluptatem.", 65, 3464m, "Solid", "L" },
                    { 145, "Consequatur atque quaerat aut provident inventore neque.", 89, 7889m, "Liquid", "Kg" },
                    { 49, "Et eius officia excepturi voluptas.", 28, 7797m, "Gas", "L" },
                    { 354, "Eos minima ullam quibusdam animi voluptatem eius dignissimos.", 111, 16934m, "Solid", "L" },
                    { 221, "Laudantium omnis soluta consequatur odio tempora voluptatem nihil est aperiam.", 89, 15906m, "Liquid", "Kg" },
                    { 15, "Quia sit consequuntur quo necessitatibus deleniti harum aut.", 125, 8723m, "Liquid", "Kg" },
                    { 447, "Consectetur facere dicta aut minima et nostrum sit.", 65, 4219m, "Liquid", "Kg" },
                    { 439, "Voluptas in provident qui molestiae quae perferendis blanditiis tempore nam.", 31, 1391m, "Liquid", "L" },
                    { 456, "Veritatis totam neque repudiandae et et nam.", 118, 11768m, "Solid", "L" },
                    { 377, "Qui maiores quo ipsa illum culpa.", 116, 13976m, "Gas", "Kg" },
                    { 141, "Voluptatem et odit maxime ea quibusdam commodi ut cum.", 193, 7589m, "Solid", "L" },
                    { 246, "Ea doloribus aperiam laborum repudiandae.", 193, 299m, "Gas", "Kg" },
                    { 495, "Commodi non sit velit et libero provident autem.", 77, 4934m, "Solid", "L" },
                    { 469, "Nihil provident iste voluptas sunt quia.", 28, 14684m, "Liquid", "Kg" },
                    { 477, "Omnis velit corporis.", 125, 7065m, "Liquid", "Kg" },
                    { 376, "Debitis molestiae nihil ea laborum ipsum quia pariatur eius.", 116, 17867m, "Solid", "Kg" },
                    { 213, "Ratione ratione odio tenetur ut nulla amet.", 28, 6791m, "Liquid", "Kg" },
                    { 9, "Iure dolore aut aut amet consequatur ex vel corporis.", 193, 2798m, "Solid", "Kg" },
                    { 22, "A et nesciunt aut.", 31, 12614m, "Gas", "L" },
                    { 121, "Aut ratione adipisci voluptatem eos accusamus eius reprehenderit omnis eaque.", 118, 2456m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 353, "Ea ratione consequatur nesciunt quia quaerat eligendi reprehenderit dolor.", 118, 18062m, "Liquid", "L" },
                    { 422, "Accusantium dolorem et quas animi.", 28, 18331m, "Gas", "Kg" },
                    { 350, "Sed et quia reprehenderit consequatur optio facilis quia.", 31, 8719m, "Liquid", "Kg" },
                    { 198, "Quia quia sunt quis omnis dolorem magnam delectus.", 66, 14403m, "Liquid", "Kg" },
                    { 89, "Ducimus possimus esse velit.", 89, 9996m, "Solid", "L" },
                    { 401, "Et fugiat porro necessitatibus est nihil accusamus tempore.", 153, 6658m, "Solid", "Kg" },
                    { 214, "Id facere illo vel debitis qui veniam qui facere sit.", 64, 10599m, "Gas", "Kg" },
                    { 365, "Magni eum architecto ipsam hic.", 65, 9303m, "Gas", "Kg" },
                    { 413, "Eligendi odio tempore eos id sunt maxime qui nihil.", 141, 18902m, "Liquid", "Kg" },
                    { 93, "Minus ea dolore eos facere voluptas qui.", 148, 18805m, "Solid", "L" },
                    { 247, "Dolor sed dolores optio nisi provident eum illo quas.", 148, 19375m, "Liquid", "Kg" },
                    { 368, "Vel earum facilis.", 59, 12872m, "Gas", "L" },
                    { 319, "Sed qui quia sit.", 59, 10582m, "Gas", "Kg" },
                    { 389, "Velit omnis quia facere.", 45, 18033m, "Solid", "Kg" },
                    { 491, "Esse minima ratione.", 45, 12104m, "Solid", "L" },
                    { 250, "Quidem dolor nisi cumque fugit consequuntur laudantium ipsa beatae libero.", 148, 19804m, "Liquid", "L" },
                    { 498, "Eos qui aut aut voluptatem dolorum nostrum.", 168, 17516m, "Solid", "L" },
                    { 484, "Voluptatem possimus aperiam cupiditate officiis aut hic.", 168, 2110m, "Gas", "L" },
                    { 159, "Repellat et repellat atque quo voluptatem suscipit.", 153, 17129m, "Gas", "L" },
                    { 154, "Sed reiciendis iure.", 47, 6402m, "Gas", "L" },
                    { 392, "Illum blanditiis debitis commodi itaque ut ut.", 168, 16689m, "Liquid", "L" },
                    { 1, "Sit repellat non corporis qui dolorum odit numquam in.", 47, 11815m, "Gas", "L" },
                    { 164, "Fugiat consequuntur ut.", 168, 12056m, "Solid", "Kg" },
                    { 98, "Molestiae aperiam magnam repellat quis in reiciendis.", 168, 11316m, "Solid", "L" },
                    { 387, "Quia quaerat aspernatur eos ratione.", 153, 2942m, "Liquid", "Kg" },
                    { 71, "Qui aspernatur voluptatum eveniet dignissimos sapiente.", 180, 869m, "Solid", "Kg" },
                    { 405, "Eos rerum assumenda ut omnis explicabo.", 65, 5047m, "Liquid", "L" },
                    { 360, "Atque consectetur dolores.", 141, 12988m, "Solid", "L" },
                    { 205, "Non sunt laboriosam aliquid cum et sit.", 141, 18794m, "Gas", "L" },
                    { 184, "Dignissimos ratione quod quibusdam enim omnis a id eum excepturi.", 65, 13782m, "Solid", "Kg" },
                    { 4, "Ipsa incidunt sit dolore incidunt ab.", 130, 16828m, "Solid", "Kg" },
                    { 432, "Et qui et magnam.", 64, 19298m, "Liquid", "L" },
                    { 135, "Incidunt vitae enim ut nihil ipsum eius totam alias et.", 130, 19164m, "Gas", "Kg" },
                    { 385, "Provident eveniet mollitia molestiae ipsa et cupiditate occaecati cum.", 180, 8024m, "Liquid", "Kg" },
                    { 47, "Aut magni totam nam mollitia.", 46, 3474m, "Liquid", "L" },
                    { 57, "Doloribus vel quia.", 64, 15911m, "Solid", "Kg" },
                    { 110, "Minus velit architecto in et quaerat repellendus enim accusamus iste.", 40, 10447m, "Solid", "Kg" },
                    { 24, "Natus omnis velit laborum odit sit dicta recusandae.", 64, 14609m, "Solid", "Kg" },
                    { 111, "Placeat ut tempore aut.", 40, 6394m, "Gas", "L" },
                    { 313, "Qui et quos nihil qui.", 40, 8428m, "Solid", "Kg" },
                    { 210, "Itaque autem qui voluptas sunt quos harum voluptas.", 140, 18180m, "Solid", "L" },
                    { 364, "Fugit sit quae consequuntur vel illo ut illum error optio.", 180, 2683m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 139, "Qui voluptates eos voluptatum aut adipisci laboriosam.", 180, 7370m, "Solid", "Kg" },
                    { 431, "Non molestias corporis voluptas.", 140, 3738m, "Liquid", "Kg" },
                    { 338, "Ab aut veniam.", 62, 7632m, "Solid", "Kg" },
                    { 118, "Omnis voluptatem eos totam sit omnis libero quia.", 180, 1896m, "Solid", "L" },
                    { 321, "Officia explicabo et voluptates odio voluptas.", 45, 16237m, "Liquid", "L" },
                    { 211, "Quia inventore sunt est.", 59, 11021m, "Gas", "L" },
                    { 359, "Aperiam porro sapiente.", 173, 11171m, "Solid", "Kg" },
                    { 280, "Doloribus corrupti et dolor incidunt sit nemo.", 103, 11374m, "Gas", "Kg" },
                    { 152, "Accusantium est quo voluptas consequatur laudantium id.", 30, 3072m, "Gas", "L" },
                    { 437, "Porro rerum temporibus nihil similique omnis.", 142, 7439m, "Liquid", "L" },
                    { 299, "Omnis occaecati voluptas quo.", 142, 13357m, "Liquid", "L" },
                    { 274, "Asperiores labore aspernatur similique beatae modi ullam aut et et.", 142, 17339m, "Liquid", "Kg" },
                    { 215, "Possimus sit ea natus.", 142, 12025m, "Liquid", "L" },
                    { 52, "Qui ad tenetur aperiam molestiae et quia.", 35, 18586m, "Liquid", "L" },
                    { 80, "Qui ipsa dolores dicta voluptas error commodi error.", 142, 6072m, "Gas", "L" },
                    { 142, "Architecto voluptatem qui doloremque unde eum.", 35, 9158m, "Liquid", "L" },
                    { 344, "Autem dolorem est voluptatem fugit aliquam sint.", 35, 7339m, "Gas", "L" },
                    { 426, "Laborum error sapiente ut.", 35, 7012m, "Liquid", "L" },
                    { 129, "Vero at facilis sunt eaque rerum vel dicta voluptatum.", 145, 3359m, "Gas", "Kg" },
                    { 452, "Aspernatur quis quam qui.", 139, 11176m, "Liquid", "L" },
                    { 72, "Necessitatibus id in et rerum iure adipisci quae rerum.", 139, 1416m, "Liquid", "L" },
                    { 39, "Similique sit nobis consequatur perferendis similique et.", 37, 19965m, "Solid", "L" },
                    { 23, "Dolor iste minima ab voluptas non rerum.", 51, 15364m, "Gas", "Kg" },
                    { 395, "Nostrum odio ex consectetur sed dolorem occaecati quam illum sit.", 51, 2704m, "Gas", "L" },
                    { 200, "Est reiciendis iste ex perspiciatis.", 58, 7078m, "Solid", "L" },
                    { 218, "In id ratione saepe dolor qui soluta amet.", 58, 4855m, "Gas", "Kg" },
                    { 476, "Ad sunt fuga sed sequi.", 129, 15442m, "Liquid", "Kg" },
                    { 104, "Et sed aut ad similique nobis.", 129, 15625m, "Solid", "L" },
                    { 275, "Facilis vel in.", 63, 17440m, "Liquid", "L" },
                    { 31, "Porro quas aspernatur.", 129, 13396m, "Solid", "L" },
                    { 374, "Minima dolorum qui amet.", 139, 8632m, "Solid", "Kg" },
                    { 430, "Maiores eos nemo distinctio sit.", 145, 3181m, "Gas", "Kg" },
                    { 131, "Suscipit voluptas qui velit nostrum minus corporis quia suscipit dolore.", 26, 14256m, "Liquid", "Kg" },
                    { 243, "Dolores velit aut dolorum.", 146, 6414m, "Gas", "L" },
                    { 34, "Ratione non repudiandae eveniet quo.", 179, 1589m, "Gas", "L" },
                    { 77, "Eveniet tempora aut.", 179, 13475m, "Solid", "L" },
                    { 294, "Corrupti consequatur occaecati culpa natus.", 179, 942m, "Liquid", "Kg" },
                    { 324, "Minus at porro omnis quasi excepturi in quisquam pariatur.", 179, 8751m, "Liquid", "Kg" },
                    { 378, "Est expedita enim tempore dolores quasi est et iure ea.", 166, 13914m, "Solid", "Kg" },
                    { 189, "Qui a nihil est praesentium reiciendis perspiciatis et.", 166, 12509m, "Solid", "L" },
                    { 388, "Aliquid iusto vel expedita maiores.", 190, 756m, "Solid", "L" },
                    { 475, "Eligendi laboriosam quos necessitatibus.", 164, 11734m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 177, "Omnis omnis et aut.", 164, 5516m, "Liquid", "Kg" },
                    { 73, "Adipisci a tempora ut totam labore nihil praesentium officiis.", 200, 338m, "Liquid", "L" },
                    { 150, "Sint neque molestiae quae tempora qui cupiditate.", 164, 11133m, "Liquid", "Kg" },
                    { 291, "Sapiente molestias neque id et ut.", 200, 19261m, "Liquid", "L" },
                    { 48, "Facere perspiciatis consectetur esse.", 2, 8401m, "Solid", "Kg" },
                    { 265, "Soluta illum optio ratione saepe rerum velit.", 2, 187m, "Gas", "L" },
                    { 411, "Repellendus cumque culpa.", 150, 6982m, "Liquid", "L" },
                    { 349, "Voluptatibus sit nemo.", 14, 13881m, "Solid", "Kg" },
                    { 53, "Eum similique quia quo.", 23, 8229m, "Solid", "L" },
                    { 127, "Odit similique quibusdam eius.", 23, 8583m, "Gas", "L" },
                    { 92, "Quibusdam est optio aut magnam dolorum magni repellendus quos.", 147, 2568m, "Liquid", "Kg" },
                    { 258, "Maxime consequatur dolorem ut et et quos consectetur iusto aut.", 23, 13908m, "Solid", "L" },
                    { 367, "Temporibus sunt modi sed.", 23, 7180m, "Liquid", "Kg" },
                    { 424, "Sapiente libero quo modi eaque ea alias sed deleniti.", 23, 941m, "Gas", "L" },
                    { 318, "Expedita rerum consequatur libero maxime enim facere id voluptas debitis.", 146, 15259m, "Gas", "L" },
                    { 17, "Nostrum laboriosam optio.", 67, 17006m, "Liquid", "Kg" },
                    { 436, "Dolores rerum sit aut perspiciatis dolor ad in nam hic.", 110, 5418m, "Liquid", "L" },
                    { 481, "Voluptatem praesentium sint officia fuga sapiente est minima.", 126, 15983m, "Gas", "Kg" },
                    { 433, "Et iste aliquam est eos voluptate impedit ullam ab illum.", 126, 16496m, "Gas", "Kg" },
                    { 343, "Delectus deleniti dignissimos autem molestiae ut quam.", 95, 6777m, "Solid", "Kg" },
                    { 206, "Quia culpa voluptate non explicabo delectus.", 114, 2201m, "Gas", "L" },
                    { 366, "Non et optio libero pariatur ducimus id voluptas id.", 95, 18097m, "Liquid", "Kg" },
                    { 29, "Repellat molestias deserunt quam nostrum maxime.", 173, 21m, "Solid", "L" },
                    { 74, "Ratione quisquam aspernatur veritatis.", 100, 15707m, "Liquid", "L" },
                    { 133, "Est culpa officia quia.", 113, 2871m, "Liquid", "L" },
                    { 113, "Animi architecto quis officiis atque architecto quas mollitia velit et.", 113, 2417m, "Solid", "Kg" },
                    { 105, "Consequatur in cupiditate unde quidem consectetur id perferendis sequi aut.", 113, 10586m, "Liquid", "Kg" },
                    { 88, "Esse sed reiciendis aperiam dolorem.", 100, 67m, "Solid", "L" },
                    { 399, "Et alias libero corporis.", 100, 2466m, "Liquid", "L" },
                    { 167, "Qui minus minus rerum non fugit fugiat est.", 95, 16838m, "Liquid", "L" },
                    { 423, "Doloremque debitis porro pariatur.", 100, 14782m, "Solid", "Kg" },
                    { 41, "In nulla maxime impedit magnam aliquam aut.", 104, 9853m, "Gas", "Kg" },
                    { 14, "Ut deserunt sint aut ea quis repudiandae non cum.", 105, 10357m, "Solid", "Kg" },
                    { 191, "Vitae voluptatem quisquam rerum cum eveniet repellat accusantium earum veniam.", 104, 985m, "Liquid", "L" },
                    { 331, "Enim et quod ut repudiandae.", 104, 19828m, "Solid", "L" },
                    { 446, "Ex nemo et sit quo.", 103, 17737m, "Gas", "Kg" },
                    { 400, "Numquam praesentium quis eius vel ipsam quam nobis officiis.", 103, 12641m, "Liquid", "L" },
                    { 380, "Non blanditiis sed quod reprehenderit esse beatae eligendi aliquid similique.", 103, 8922m, "Liquid", "L" },
                    { 138, "Et labore minima reprehenderit in quia amet.", 107, 7366m, "Liquid", "L" },
                    { 281, "Optio et eum tenetur et.", 107, 12870m, "Solid", "Kg" },
                    { 314, "Aliquam eos consequatur et provident quia laudantium corporis ea.", 103, 16427m, "Solid", "Kg" },
                    { 462, "Hic dolor repellendus enim et ipsum qui perferendis laudantium sapiente.", 105, 8984m, "Solid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 122, "Repellendus natus laudantium distinctio eligendi vel ipsum est aut.", 95, 9260m, "Liquid", "Kg" },
                    { 60, "Praesentium dolorem ut.", 115, 11381m, "Solid", "L" },
                    { 225, "Quia dolores doloremque.", 115, 12976m, "Gas", "L" },
                    { 315, "Optio sequi cum et ducimus nisi odio.", 126, 7542m, "Solid", "Kg" },
                    { 97, "Aut blanditiis ullam vero quia magnam.", 126, 9356m, "Gas", "L" },
                    { 327, "Quia vel et ut vitae.", 67, 17176m, "Gas", "L" },
                    { 79, "Qui ut voluptas harum quos occaecati et facilis omnis laborum.", 126, 19693m, "Liquid", "Kg" },
                    { 99, "Ut aut facere voluptatem rerum consequuntur voluptas culpa.", 74, 9373m, "Gas", "Kg" },
                    { 175, "Sed eos reiciendis pariatur ratione quasi optio atque.", 74, 3631m, "Liquid", "L" },
                    { 500, "Blanditiis repellendus et aut nostrum cumque et soluta quo explicabo.", 123, 2500m, "Solid", "L" },
                    { 251, "Autem asperiores sit sit molestiae et distinctio odit.", 74, 4701m, "Liquid", "Kg" },
                    { 224, "Nulla magnam porro suscipit et rem eaque aliquid consequuntur.", 123, 9992m, "Gas", "L" },
                    { 69, "Aspernatur distinctio voluptas dicta quibusdam ex quis totam facilis.", 123, 9444m, "Liquid", "L" },
                    { 340, "Pariatur hic cum esse minus eos doloribus.", 122, 5633m, "Liquid", "L" },
                    { 279, "Nobis ipsam in.", 122, 4656m, "Liquid", "L" },
                    { 282, "Debitis omnis voluptatem dolor architecto voluptatem velit.", 76, 1818m, "Gas", "L" },
                    { 203, "Accusamus excepturi deserunt minus voluptate dolorum eveniet perferendis et nobis.", 122, 18044m, "Gas", "L" },
                    { 140, "Eius natus voluptate.", 122, 11145m, "Liquid", "L" },
                    { 467, "Nisi iste aliquam facere porro aspernatur voluptas saepe.", 76, 4611m, "Liquid", "Kg" },
                    { 7, "Sunt error perspiciatis quasi quisquam dicta ab hic aut voluptate.", 122, 15341m, "Solid", "L" },
                    { 6, "Debitis eius et sint est quas non blanditiis magni voluptas.", 88, 11642m, "Gas", "L" },
                    { 153, "Numquam quisquam quo ullam non soluta voluptas.", 88, 2269m, "Solid", "L" },
                    { 276, "Repellendus ipsum nulla qui est et ad.", 119, 18599m, "Solid", "Kg" },
                    { 223, "Nulla et magni voluptatem quis laborum at.", 119, 17548m, "Solid", "L" },
                    { 228, "Ut consequatur qui quos ut enim occaecati.", 88, 18205m, "Liquid", "Kg" },
                    { 248, "Officiis ut ut ducimus.", 88, 19333m, "Solid", "L" },
                    { 36, "Voluptas molestias qui ut aut.", 67, 7090m, "Gas", "L" },
                    { 186, "Doloribus omnis ut.", 179, 8711m, "Gas", "L" },
                    { 61, "Fugiat est animi minus quia dolorem hic.", 106, 6323m, "Gas", "Kg" },
                    { 418, "Necessitatibus qui et facilis velit voluptas numquam harum.", 21, 7393m, "Gas", "L" },
                    { 108, "Hic itaque maxime vero.", 195, 15477m, "Solid", "Kg" },
                    { 245, "Nesciunt occaecati est officiis nobis incidunt.", 195, 9964m, "Liquid", "Kg" },
                    { 21, "Mollitia quis assumenda velit fugit sint sunt nesciunt.", 197, 10021m, "Gas", "Kg" },
                    { 85, "Placeat et eos quam alias error itaque iste.", 198, 15164m, "Gas", "L" },
                    { 124, "Fugit ducimus non.", 198, 513m, "Liquid", "L" },
                    { 283, "Quos repudiandae animi harum in eius dicta.", 198, 12446m, "Solid", "Kg" },
                    { 478, "Unde id maiores illum sunt eaque dolores.", 198, 3823m, "Gas", "Kg" },
                    { 449, "Repudiandae ut veniam consequatur odit sapiente occaecati expedita aut tempore.", 191, 1832m, "Solid", "L" },
                    { 20, "Ullam fugit maiores aspernatur qui repellendus.", 199, 342m, "Gas", "Kg" },
                    { 134, "Amet iusto placeat unde perspiciatis quia impedit rerum.", 199, 16940m, "Solid", "Kg" },
                    { 201, "Et deserunt veritatis molestiae et enim.", 199, 16317m, "Liquid", "L" },
                    { 287, "Architecto temporibus blanditiis sunt delectus nostrum laudantium voluptates.", 13, 2217m, "Solid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 444, "Eos laborum et corrupti aut quae eum quo tempora beatae.", 13, 10465m, "Solid", "Kg" },
                    { 496, "Consequatur ut tenetur ut quo qui ipsum nihil eaque accusantium.", 13, 6573m, "Solid", "Kg" },
                    { 166, "Aspernatur natus nostrum ullam doloribus nesciunt et.", 16, 15085m, "Solid", "Kg" },
                    { 234, "Dolorem repellendus minus iure explicabo.", 16, 2385m, "Liquid", "L" },
                    { 32, "Modi omnis in atque nam eos cum aut ab.", 199, 12896m, "Liquid", "Kg" },
                    { 241, "Nesciunt quis nesciunt.", 20, 14741m, "Gas", "Kg" },
                    { 382, "Modi quo perferendis.", 191, 16215m, "Liquid", "L" },
                    { 209, "Nam sapiente doloribus ut alias vel debitis aut iure.", 183, 10508m, "Liquid", "Kg" },
                    { 266, "Corporis et perferendis et et assumenda voluptatibus earum.", 167, 7075m, "Gas", "L" },
                    { 278, "Numquam velit consequatur unde reprehenderit consectetur.", 167, 7355m, "Liquid", "L" },
                    { 300, "Tempora earum voluptatum quia minima labore eos.", 167, 17755m, "Solid", "L" },
                    { 361, "Quas culpa autem possimus asperiores expedita distinctio.", 176, 8426m, "Gas", "L" },
                    { 91, "Quas molestiae soluta sunt perspiciatis vel animi fugit.", 177, 1327m, "Solid", "Kg" },
                    { 296, "Ipsa quisquam ex modi similique quaerat sed officiis suscipit.", 177, 7604m, "Gas", "L" },
                    { 435, "Quisquam cumque fugiat odio nostrum.", 177, 65m, "Liquid", "L" },
                    { 415, "Vitae non perspiciatis quasi.", 183, 4197m, "Solid", "Kg" },
                    { 76, "Sed magnam alias illum sit molestiae exercitationem dicta et eos.", 178, 11222m, "Liquid", "Kg" },
                    { 237, "Aut velit qui eum recusandae quia.", 178, 13035m, "Liquid", "Kg" },
                    { 381, "Quisquam qui facilis omnis.", 178, 15383m, "Solid", "Kg" },
                    { 38, "Libero et atque omnis nobis quisquam fuga et quam rerum.", 182, 16486m, "Gas", "Kg" },
                    { 292, "Necessitatibus nihil rem velit harum accusamus exercitationem ea consequatur.", 182, 18072m, "Solid", "Kg" },
                    { 305, "Maiores quasi sed enim velit neque aut.", 182, 16903m, "Liquid", "Kg" },
                    { 102, "Dolorem deserunt et.", 183, 7935m, "Liquid", "Kg" },
                    { 149, "Dignissimos facilis vel nulla voluptatem dolorem.", 183, 12458m, "Liquid", "Kg" },
                    { 148, "Consequuntur vel est rerum cupiditate.", 178, 13299m, "Liquid", "Kg" },
                    { 372, "Voluptatum sunt enim.", 20, 8703m, "Solid", "L" },
                    { 178, "Et molestias tenetur voluptatem.", 33, 10823m, "Liquid", "Kg" },
                    { 256, "Qui cupiditate sit perspiciatis ut enim sit fugit.", 33, 3765m, "Liquid", "Kg" },
                    { 358, "Quam eius quisquam ut esse sit illum.", 79, 9698m, "Gas", "L" },
                    { 419, "Quo porro eaque consequatur tenetur doloremque omnis.", 79, 1387m, "Gas", "L" },
                    { 193, "Aspernatur dolor possimus vitae cum.", 82, 15934m, "Liquid", "Kg" },
                    { 222, "Et autem officiis.", 82, 9686m, "Gas", "L" },
                    { 3, "Cumque officia similique eveniet vel illo aut.", 83, 16949m, "Liquid", "Kg" },
                    { 55, "Est non eveniet qui vero.", 83, 12812m, "Liquid", "L" },
                    { 339, "Et doloremque et aut omnis voluptas velit voluptatem.", 83, 6073m, "Liquid", "Kg" },
                    { 242, "Eligendi dignissimos nam perferendis adipisci et dolores aut nostrum.", 79, 8043m, "Gas", "Kg" },
                    { 351, "Beatae aliquid quisquam debitis est.", 85, 4088m, "Liquid", "Kg" },
                    { 18, "Sit at reprehenderit aperiam et expedita molestiae repellendus et.", 86, 4840m, "Gas", "Kg" },
                    { 298, "Perspiciatis aliquam qui totam.", 86, 18668m, "Solid", "L" },
                    { 442, "Accusantium rerum neque ut porro labore dolores molestiae.", 86, 6620m, "Gas", "Kg" },
                    { 465, "Numquam quidem eos beatae qui reprehenderit.", 86, 18559m, "Gas", "Kg" },
                    { 489, "Dicta commodi corporis magnam quia voluptatem deleniti veritatis odio.", 90, 3651m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 10, "Dolorem ut consequatur aut aut necessitatibus animi autem qui alias.", 91, 12116m, "Liquid", "L" },
                    { 162, "Ad rem labore id natus vero.", 91, 12701m, "Liquid", "Kg" },
                    { 391, "Aliquam quod vero omnis quasi sunt est voluptas soluta.", 85, 13035m, "Gas", "Kg" },
                    { 13, "Libero architecto cum.", 78, 11046m, "Liquid", "Kg" },
                    { 453, "Dolores sed laboriosam laborum in ut nisi.", 69, 15709m, "Solid", "L" },
                    { 120, "Similique nulla pariatur modi.", 69, 7182m, "Solid", "Kg" },
                    { 309, "Soluta explicabo cumque ut soluta.", 33, 17059m, "Solid", "L" },
                    { 352, "Sequi ipsum commodi at quibusdam expedita provident modi sit necessitatibus.", 38, 19234m, "Liquid", "Kg" },
                    { 471, "Ut et quisquam aliquam rerum laudantium ipsa illum eaque nesciunt.", 38, 14956m, "Solid", "Kg" },
                    { 182, "Et aut amet illum suscipit in commodi.", 39, 17609m, "Solid", "L" },
                    { 306, "Dolor possimus velit nemo laboriosam sit ab saepe voluptas.", 39, 7217m, "Solid", "L" },
                    { 180, "Non velit at officia.", 41, 3763m, "Gas", "L" },
                    { 233, "Ea consequatur est et voluptatem accusantium non eos ut quis.", 41, 17184m, "Liquid", "Kg" },
                    { 307, "Qui consectetur ipsa ab dicta.", 41, 15823m, "Gas", "L" },
                    { 342, "Qui praesentium quas temporibus hic nihil.", 41, 7249m, "Gas", "L" },
                    { 371, "Placeat corporis quis.", 41, 6392m, "Solid", "L" },
                    { 396, "Aspernatur unde iste iste praesentium ut dolorum dolores incidunt.", 41, 13458m, "Liquid", "L" },
                    { 375, "Occaecati unde magnam occaecati quam excepturi odio.", 42, 7467m, "Solid", "L" },
                    { 81, "Esse quaerat numquam officiis ut aut possimus voluptas quia ipsa.", 43, 8360m, "Liquid", "Kg" },
                    { 277, "Omnis suscipit vel quia ea.", 43, 19698m, "Solid", "L" },
                    { 35, "Sit quis ea et hic necessitatibus modi saepe suscipit.", 48, 8235m, "Solid", "L" },
                    { 407, "Voluptas optio assumenda commodi modi cum excepturi temporibus repudiandae.", 57, 16831m, "Liquid", "L" },
                    { 43, "Est cumque dolores alias id fugit cum.", 69, 15966m, "Liquid", "L" },
                    { 406, "Sint inventore et possimus perferendis earum.", 158, 11057m, "Solid", "Kg" },
                    { 100, "Quis alias quod et aliquid qui.", 158, 10036m, "Liquid", "L" },
                    { 499, "Libero dolores culpa officiis sunt distinctio quaerat voluptas.", 152, 10039m, "Gas", "Kg" },
                    { 420, "Aperiam ullam suscipit repudiandae occaecati sunt nulla vel.", 152, 11778m, "Liquid", "Kg" },
                    { 192, "Quam enim quis modi ullam.", 44, 10989m, "Solid", "L" },
                    { 487, "Iure eos dolorem id corrupti.", 44, 11992m, "Liquid", "Kg" },
                    { 66, "Et tempora optio itaque doloribus et ut earum nihil sed.", 49, 5992m, "Liquid", "L" },
                    { 86, "Quidem veniam quasi vel vel.", 49, 4811m, "Solid", "L" },
                    { 267, "Sit ut culpa.", 49, 13374m, "Gas", "Kg" },
                    { 170, "Maxime quia sunt ab consequatur et voluptates soluta non eaque.", 50, 3367m, "Liquid", "L" },
                    { 347, "Repellat itaque totam fugiat magni delectus.", 50, 4495m, "Gas", "L" },
                    { 33, "Magni assumenda neque sed libero sint.", 44, 9364m, "Solid", "Kg" },
                    { 12, "Eius in quaerat.", 52, 15911m, "Gas", "Kg" },
                    { 236, "Voluptatum et nesciunt veniam qui delectus qui dolor.", 52, 17342m, "Gas", "L" },
                    { 239, "Molestias quidem ipsum enim eveniet a.", 52, 5839m, "Solid", "L" },
                    { 332, "Et aut voluptatum iure et magni molestiae ullam et.", 52, 6144m, "Solid", "Kg" },
                    { 369, "Optio est ut pariatur fuga voluptas ratione porro.", 52, 4925m, "Liquid", "Kg" },
                    { 458, "Ab numquam ab earum magnam totam.", 53, 10499m, "Solid", "Kg" },
                    { 486, "Neque libero tempore modi fuga dolor quibusdam fuga natus in.", 53, 5334m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 26, "Neque sint minus porro qui qui voluptatum qui.", 54, 9653m, "Gas", "L" },
                    { 172, "Voluptatem beatae esse sed maxime iure quas.", 52, 17051m, "Gas", "Kg" },
                    { 27, "Veritatis explicabo debitis iste ut laudantium veniam et ducimus aut.", 44, 12680m, "Liquid", "Kg" },
                    { 317, "Odio officia minima vel voluptatem quos.", 36, 1601m, "Liquid", "Kg" },
                    { 264, "Dicta est consequatur vitae perferendis temporibus rerum vel voluptas odio.", 36, 15811m, "Solid", "L" },
                    { 257, "Quas ut veritatis at.", 4, 15512m, "Gas", "L" },
                    { 304, "Dolores dignissimos maxime cupiditate iste est doloribus.", 4, 8671m, "Solid", "Kg" },
                    { 5, "Et veniam est qui.", 7, 14080m, "Liquid", "Kg" },
                    { 44, "Officia aut iste possimus blanditiis autem unde molestiae.", 7, 8968m, "Solid", "Kg" },
                    { 51, "Tempora aut quasi ad officiis et eveniet voluptas.", 7, 11873m, "Solid", "L" },
                    { 231, "Nam corrupti harum temporibus nostrum distinctio expedita reprehenderit nemo quasi.", 12, 14406m, "Gas", "L" },
                    { 302, "Dolorem cumque debitis.", 24, 612m, "Liquid", "Kg" },
                    { 337, "A fugiat laborum dolorum magnam dolorem repudiandae expedita non.", 24, 1846m, "Liquid", "Kg" },
                    { 106, "Consequatur saepe exercitationem laborum unde dolor odio nam voluptas.", 25, 9529m, "Gas", "Kg" },
                    { 473, "Cumque rerum eum deleniti minus voluptas.", 25, 12539m, "Liquid", "L" },
                    { 59, "Delectus nobis ex.", 29, 3514m, "Gas", "L" },
                    { 64, "Et iure hic necessitatibus quibusdam repellendus et.", 29, 10449m, "Gas", "L" },
                    { 190, "Dolorem delectus pariatur consequatur at sed.", 29, 4609m, "Liquid", "L" },
                    { 259, "Ea aut nihil necessitatibus doloribus.", 29, 1617m, "Liquid", "L" },
                    { 390, "Deserunt et aut saepe.", 29, 4628m, "Liquid", "L" },
                    { 490, "At occaecati itaque earum libero voluptatem voluptatibus ducimus excepturi necessitatibus.", 29, 14198m, "Liquid", "L" },
                    { 289, "Repellat inventore perspiciatis.", 32, 4146m, "Liquid", "Kg" },
                    { 28, "In quaerat adipisci.", 54, 13850m, "Solid", "Kg" },
                    { 404, "Ea et omnis velit asperiores perspiciatis.", 91, 2572m, "Liquid", "Kg" },
                    { 37, "Occaecati molestiae voluptas voluptatibus.", 54, 4255m, "Liquid", "L" },
                    { 254, "Quo voluptates corporis hic sed reiciendis.", 54, 1472m, "Liquid", "Kg" },
                    { 208, "Velit dicta occaecati.", 109, 16714m, "Gas", "Kg" },
                    { 107, "Rerum odit ut sunt.", 134, 8941m, "Liquid", "L" },
                    { 181, "Eius quam voluptatem.", 134, 15883m, "Gas", "Kg" },
                    { 207, "Aut omnis amet maiores.", 134, 13870m, "Solid", "Kg" },
                    { 402, "Minima quibusdam aut in eos quam tempore inventore sint perferendis.", 134, 5886m, "Liquid", "L" },
                    { 115, "Sequi molestias incidunt ad aut laborum maxime odio magnam.", 135, 4802m, "Liquid", "L" },
                    { 268, "Ut dignissimos error repudiandae consequuntur temporibus accusantium.", 135, 17763m, "Gas", "L" },
                    { 147, "Repellat totam nostrum eius est reprehenderit et.", 109, 7209m, "Solid", "L" },
                    { 334, "Aut occaecati iste.", 135, 16382m, "Gas", "L" },
                    { 494, "Iure consequatur cum illo voluptatem ut sunt.", 135, 16895m, "Liquid", "L" },
                    { 62, "Voluptatem vero libero.", 136, 12357m, "Liquid", "L" },
                    { 112, "Qui repudiandae placeat omnis repellat assumenda.", 136, 18875m, "Liquid", "L" },
                    { 485, "Quo alias sed labore.", 136, 13142m, "Liquid", "L" },
                    { 45, "Et necessitatibus est mollitia aut quibusdam est nemo dolorem.", 152, 18757m, "Solid", "L" },
                    { 341, "Quis non sunt est deleniti molestias voluptatem nihil dolore.", 152, 6647m, "Liquid", "L" },
                    { 386, "Sed cupiditate eum et a omnis quos enim iure laudantium.", 152, 6669m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 379, "Similique necessitatibus eum.", 135, 12520m, "Solid", "Kg" },
                    { 197, "Et et voluptatibus totam voluptatem neque.", 99, 13428m, "Gas", "Kg" },
                    { 202, "Exercitationem rem nisi dolor quia alias ad.", 98, 13433m, "Solid", "Kg" },
                    { 165, "Mollitia ex eum cupiditate veniam unde dignissimos laboriosam odit.", 98, 18830m, "Solid", "Kg" },
                    { 293, "Repellendus voluptatem nesciunt est ad laborum id.", 71, 6478m, "Liquid", "Kg" },
                    { 497, "Consequatur dolorum impedit.", 71, 1796m, "Solid", "Kg" },
                    { 261, "Omnis aut quisquam ut et sed dolorum repellat.", 73, 12988m, "Solid", "Kg" },
                    { 322, "Nulla unde sunt molestiae a aliquid quis repellat.", 73, 14557m, "Liquid", "L" },
                    { 472, "Provident eos quo vel nulla ex quisquam et.", 73, 6413m, "Solid", "L" },
                    { 58, "Laborum sit provident sapiente labore excepturi.", 80, 12562m, "Solid", "L" },
                    { 126, "Itaque quis iure.", 80, 11166m, "Solid", "L" },
                    { 157, "Ab at officia in possimus nemo reprehenderit architecto.", 80, 8350m, "Liquid", "Kg" },
                    { 163, "Excepturi odio minima corporis voluptas numquam voluptatum optio sunt.", 80, 12971m, "Solid", "Kg" },
                    { 232, "Ullam sint tenetur dolorem molestiae maiores cupiditate tenetur nihil.", 80, 2826m, "Liquid", "Kg" },
                    { 311, "Aut minus maxime.", 80, 9478m, "Gas", "L" },
                    { 301, "Aperiam asperiores assumenda ratione cum enim cum et earum.", 81, 12219m, "Gas", "L" },
                    { 217, "Totam vel asperiores placeat vel et ipsam quidem.", 87, 7199m, "Liquid", "L" },
                    { 429, "Modi distinctio architecto qui et rerum.", 87, 6110m, "Liquid", "L" },
                    { 199, "Quaerat voluptatem rerum repellat.", 93, 12213m, "Gas", "Kg" },
                    { 290, "Iure voluptatem et adipisci.", 93, 3828m, "Solid", "L" },
                    { 417, "Consequatur quod similique sed excepturi assumenda officiis in.", 93, 7868m, "Liquid", "L" },
                    { 130, "Quam aperiam reiciendis unde maxime accusamus.", 54, 2432m, "Solid", "Kg" },
                    { 425, "Omnis dolores voluptatem velit.", 21, 6115m, "Liquid", "L" },
                    { 30, "Dicta error odit.", 92, 18908m, "Solid", "L" },
                    { 96, "Vero vero sapiente eos exercitationem.", 94, 7196m, "Liquid", "Kg" },
                    { 394, "Velit voluptatem est est incidunt qui in harum.", 143, 11397m, "Gas", "Kg" },
                    { 75, "Ut officiis maiores et ab.", 144, 19014m, "Liquid", "Kg" },
                    { 336, "Omnis facilis consequatur illo temporibus facilis nam quis quaerat blanditiis.", 144, 18689m, "Solid", "L" },
                    { 428, "Explicabo vitae illo distinctio optio neque ex voluptatum nulla.", 144, 3802m, "Liquid", "Kg" },
                    { 90, "Nihil aut soluta sit praesentium ullam aut.", 149, 15106m, "Liquid", "L" },
                    { 56, "Veritatis quos ullam omnis corrupti sit.", 156, 349m, "Solid", "L" },
                    { 116, "Voluptatem dolore neque id rerum tenetur cumque ut consectetur.", 156, 1665m, "Solid", "L" },
                    { 384, "Impedit ut eum vel recusandae.", 143, 11788m, "Liquid", "L" },
                    { 194, "Adipisci quaerat animi consectetur qui nihil et.", 156, 12048m, "Liquid", "Kg" },
                    { 137, "Velit dolores commodi hic expedita veritatis dignissimos quas.", 160, 7041m, "Solid", "Kg" },
                    { 204, "Dicta est autem blanditiis.", 160, 9396m, "Gas", "L" },
                    { 244, "Dolores harum qui.", 160, 2250m, "Solid", "L" },
                    { 42, "Maiores modi velit aut aut praesentium dicta.", 161, 7917m, "Solid", "L" },
                    { 143, "Eius ipsum perferendis et et aut sit ut ipsa.", 161, 4429m, "Solid", "L" },
                    { 179, "Voluptas dolorum nihil.", 161, 18673m, "Gas", "Kg" },
                    { 270, "Quasi quo dolorum dolorum laboriosam iste voluptas sunt.", 161, 1618m, "Solid", "L" },
                    { 117, "Tempora nobis qui omnis qui et quisquam reiciendis voluptas.", 160, 4599m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 459, "Ut quia quasi ad.", 161, 17565m, "Liquid", "L" },
                    { 260, "Ut tenetur error velit.", 128, 1378m, "Gas", "Kg" },
                    { 427, "Sint fugit adipisci eligendi consectetur id.", 121, 7874m, "Gas", "Kg" },
                    { 434, "Corporis eligendi sequi est reiciendis laudantium quo est totam tempora.", 68, 5809m, "Solid", "L" },
                    { 160, "Corporis quibusdam enim alias harum ullam omnis voluptatem aut.", 70, 6065m, "Liquid", "L" },
                    { 308, "Fugiat nihil recusandae odio eaque alias et officia.", 70, 9088m, "Gas", "L" },
                    { 169, "Ex voluptas ipsum facere quia est qui quo id.", 75, 9294m, "Solid", "L" },
                    { 240, "Error magni eveniet excepturi autem officia molestias incidunt.", 75, 13950m, "Solid", "Kg" },
                    { 273, "Nihil sed nemo rerum eaque.", 75, 11448m, "Liquid", "L" },
                    { 403, "Expedita reprehenderit harum.", 75, 12778m, "Liquid", "L" },
                    { 479, "Dignissimos consequuntur est provident.", 121, 4120m, "Solid", "Kg" },
                    { 466, "Id autem aut inventore magni maiores pariatur et.", 75, 16047m, "Gas", "L" },
                    { 155, "Aliquid est ut in iure est.", 106, 3067m, "Gas", "Kg" },
                    { 158, "Quaerat similique qui odio.", 106, 18199m, "Solid", "L" },
                    { 445, "Dolorum ducimus voluptatem pariatur natus possimus adipisci aspernatur at.", 106, 2593m, "Gas", "Kg" },
                    { 136, "Aut maiores nobis.", 112, 3800m, "Solid", "L" },
                    { 441, "Cupiditate blanditiis minima libero molestias et amet eius.", 112, 17269m, "Solid", "Kg" },
                    { 468, "Fugit fugit corrupti eveniet numquam et nostrum aspernatur aut sint.", 112, 8695m, "Gas", "L" },
                    { 356, "Inventore sequi voluptatem vitae rerum.", 117, 9243m, "Gas", "L" },
                    { 94, "Quaerat nulla voluptatem quos cumque eius ad sunt distinctio laborum.", 84, 2184m, "Solid", "L" },
                    { 474, "Enim tempora voluptatem eos aliquam qui.", 161, 19309m, "Solid", "L" },
                    { 325, "Molestiae rerum et tempora voluptas ipsum consequatur explicabo.", 163, 10884m, "Gas", "Kg" },
                    { 438, "Velit consectetur nihil.", 163, 19645m, "Gas", "Kg" },
                    { 398, "Rerum ipsa sed ad vel corporis excepturi repellendus voluptatibus omnis.", 5, 15834m, "Gas", "L" },
                    { 460, "Recusandae magnam eligendi facilis excepturi aspernatur dignissimos sapiente natus libero.", 8, 13025m, "Liquid", "Kg" },
                    { 461, "Qui sed vero sit.", 8, 13045m, "Gas", "Kg" },
                    { 151, "Ullam nemo ipsa omnis corporis qui.", 15, 13603m, "Gas", "Kg" },
                    { 227, "Libero incidunt voluptatem.", 15, 3865m, "Gas", "Kg" },
                    { 235, "Tenetur eos provident non est quia ut voluptatem qui.", 15, 19000m, "Liquid", "Kg" },
                    { 272, "Repellat iusto eum in culpa.", 15, 5658m, "Solid", "Kg" },
                    { 119, "Aliquam voluptatem voluptatem.", 5, 8330m, "Solid", "Kg" },
                    { 409, "Quo quisquam magni ut provident amet unde voluptas omnis qui.", 15, 5726m, "Liquid", "L" },
                    { 19, "Dolor vel eius.", 19, 10673m, "Gas", "Kg" },
                    { 70, "Sit a voluptatem in iure et eveniet officiis omnis.", 19, 7492m, "Gas", "L" },
                    { 128, "Aliquid non voluptas temporibus laborum repellendus reiciendis.", 19, 5342m, "Gas", "Kg" },
                    { 212, "Nulla ad aut sapiente enim debitis nemo.", 19, 10108m, "Solid", "Kg" },
                    { 50, "Repellendus enim earum quis occaecati velit eaque rem rerum neque.", 21, 18705m, "Liquid", "L" },
                    { 355, "Ut corrupti commodi.", 21, 14376m, "Solid", "Kg" },
                    { 397, "Ex minus sint sunt.", 21, 18697m, "Liquid", "L" },
                    { 440, "Sunt inventore sunt blanditiis beatae nisi omnis adipisci voluptatum repellendus.", 18, 8357m, "Liquid", "L" },
                    { 492, "In esse suscipit sed sed dolor reiciendis explicabo laudantium.", 194, 8406m, "Gas", "L" },
                    { 238, "Qui adipisci deserunt dolores facere impedit voluptatem explicabo dolorum asperiores.", 192, 18191m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 219, "Qui illo consectetur magnam fuga recusandae non omnis sunt.", 192, 15774m, "Gas", "L" },
                    { 183, "Eum eum et et dolores ad et rerum.", 170, 11127m, "Solid", "Kg" },
                    { 295, "Temporibus reprehenderit natus quia in inventore quasi culpa necessitatibus id.", 170, 11482m, "Gas", "Kg" },
                    { 410, "Officiis in veritatis provident et qui.", 170, 5741m, "Liquid", "L" },
                    { 161, "Quaerat incidunt accusantium vel et inventore.", 171, 10224m, "Liquid", "Kg" },
                    { 493, "Quae adipisci laboriosam.", 171, 17524m, "Gas", "L" },
                    { 255, "Inventore commodi id vero fuga.", 172, 1074m, "Solid", "L" },
                    { 488, "Repudiandae nulla et qui omnis.", 172, 19700m, "Gas", "L" },
                    { 25, "Eos atque et dolores velit aperiam voluptatem distinctio maiores.", 185, 10056m, "Solid", "Kg" },
                    { 84, "In dolore repellat beatae quo et.", 185, 10385m, "Liquid", "Kg" },
                    { 285, "Molestiae est at praesentium ab aliquam veniam.", 185, 3128m, "Liquid", "L" },
                    { 320, "Similique in non exercitationem pariatur.", 185, 7180m, "Gas", "L" },
                    { 46, "Sit quo itaque reiciendis facilis quaerat est exercitationem et.", 189, 18045m, "Gas", "Kg" },
                    { 168, "Molestiae magnam facere perspiciatis ratione voluptates in eum dolore accusantium.", 189, 6770m, "Gas", "Kg" },
                    { 196, "Quis animi culpa.", 189, 14387m, "Gas", "Kg" },
                    { 370, "Numquam distinctio voluptatem qui non.", 189, 17186m, "Gas", "Kg" },
                    { 450, "Ipsam repudiandae tenetur exercitationem quas omnis.", 189, 2599m, "Solid", "Kg" },
                    { 176, "Voluptas debitis omnis cupiditate.", 192, 18833m, "Liquid", "L" },
                    { 383, "Ea nobis eum eius.", 68, 19211m, "Solid", "Kg" },
                    { 195, "Aut quas fugit a id.", 68, 18427m, "Gas", "Kg" },
                    { 357, "Quasi porro ut voluptatem laborum distinctio natus officia mollitia.", 60, 10788m, "Solid", "L" },
                    { 335, "Et a dolorem hic voluptatibus sit blanditiis.", 60, 13641m, "Gas", "L" },
                    { 82, "Rerum ipsa dolore sapiente molestias repellendus asperiores quaerat est recusandae.", 157, 13544m, "Gas", "Kg" },
                    { 329, "In quae culpa omnis.", 157, 9520m, "Solid", "Kg" },
                    { 109, "Quia minus cum necessitatibus.", 159, 6719m, "Gas", "Kg" },
                    { 346, "Sint doloremque illum.", 159, 983m, "Liquid", "L" },
                    { 11, "Repellendus veritatis earum nisi.", 162, 17631m, "Liquid", "L" },
                    { 187, "Vitae est rerum pariatur aut dignissimos accusamus.", 162, 18807m, "Gas", "L" },
                    { 216, "Dolores eligendi culpa temporibus odit est omnis impedit et consequuntur.", 165, 7180m, "Solid", "L" },
                    { 414, "Pariatur maxime sed veritatis ut rerum.", 154, 7061m, "Liquid", "Kg" },
                    { 310, "Aut sit illum.", 165, 16094m, "Liquid", "Kg" },
                    { 455, "Et id adipisci numquam magni minus.", 165, 18478m, "Solid", "Kg" },
                    { 114, "Doloribus ex maiores qui.", 169, 5188m, "Liquid", "L" },
                    { 348, "Error est autem voluptatem dolorem nulla et consequatur.", 169, 15192m, "Gas", "L" },
                    { 457, "Voluptatem delectus iusto sunt velit doloribus vel et ab.", 169, 7865m, "Gas", "L" },
                    { 482, "Assumenda ratione non voluptatem quo mollitia et nihil.", 169, 13248m, "Liquid", "L" },
                    { 328, "Quis voluptatum et dignissimos perferendis rerum enim ea.", 174, 19296m, "Solid", "L" },
                    { 393, "Voluptas labore ut culpa.", 174, 2097m, "Liquid", "L" },
                    { 312, "Omnis fugit voluptatem quod corporis a nisi voluptates ea.", 165, 19101m, "Liquid", "Kg" },
                    { 326, "Quo rem enim reprehenderit autem nisi provident omnis.", 154, 2841m, "Gas", "Kg" },
                    { 226, "Fugiat rerum enim sed.", 151, 18974m, "Liquid", "Kg" },
                    { 123, "Expedita rem voluptas et.", 151, 3203m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 146, "Amet fuga ut unde ab sunt iusto nihil nihil amet.", 94, 2161m, "Gas", "Kg" },
                    { 156, "Magnam mollitia optio eum illo.", 94, 9274m, "Liquid", "Kg" },
                    { 284, "Reprehenderit dolorum non ducimus.", 94, 15991m, "Gas", "Kg" },
                    { 454, "Fugiat quia voluptatibus corporis ratione eos.", 94, 6237m, "Gas", "L" },
                    { 16, "Vel placeat qui quis.", 102, 13493m, "Liquid", "Kg" },
                    { 8, "Voluptas reiciendis dolor voluptatibus quas qui.", 120, 6171m, "Liquid", "L" },
                    { 65, "A enim est.", 120, 15166m, "Solid", "L" },
                    { 229, "Eaque rerum quidem quaerat est esse est accusantium nam.", 120, 10428m, "Liquid", "L" },
                    { 480, "Atque ipsam quia quia minus animi autem reprehenderit maiores vel.", 120, 5316m, "Gas", "L" },
                    { 188, "Sequi pariatur alias autem ex animi quia enim hic.", 124, 3704m, "Liquid", "L" },
                    { 249, "Rem officia aut aspernatur sit tempora aspernatur nostrum.", 127, 16689m, "Liquid", "L" },
                    { 132, "Minus tempora quae sit nesciunt ipsa voluptates sequi consequatur.", 133, 18881m, "Liquid", "Kg" },
                    { 253, "Enim rerum et reprehenderit et sed.", 133, 4865m, "Gas", "Kg" },
                    { 483, "Et inventore est in fuga nulla vero veritatis.", 133, 4222m, "Liquid", "L" },
                    { 40, "Consequuntur et soluta.", 137, 15366m, "Solid", "Kg" },
                    { 54, "Aut quis in eos harum sed necessitatibus rerum ut.", 137, 11166m, "Solid", "Kg" },
                    { 125, "Reiciendis eum voluptatibus iusto.", 137, 16008m, "Solid", "L" },
                    { 103, "Laborum repudiandae qui labore et quia optio officia.", 175, 2573m, "Liquid", "Kg" },
                    { 173, "Accusamus cum harum magni qui tempora in laboriosam aut.", 92, 4150m, "Liquid", "Kg" },
                    { 448, "Beatae sed incidunt rerum excepturi quibusdam ex perspiciatis occaecati.", 175, 5008m, "Gas", "L" },
                    { 2, "Voluptate quam nemo repellat voluptatem culpa temporibus.", 186, 5973m, "Solid", "L" },
                    { 408, "Necessitatibus nesciunt at perspiciatis.", 22, 8742m, "Gas", "L" },
                    { 95, "Recusandae perferendis quibusdam corrupti voluptas tempore eos et facere.", 27, 16367m, "Gas", "L" },
                    { 174, "Et maxime nihil consequatur maiores sunt sapiente.", 27, 7519m, "Gas", "L" },
                    { 220, "Illum illo eius quia cum.", 27, 5760m, "Gas", "L" },
                    { 271, "Quis voluptatibus a illo deserunt delectus omnis sit sapiente pariatur.", 27, 13963m, "Liquid", "L" },
                    { 323, "Aut ut repellendus blanditiis facere ut sapiente voluptas quis.", 27, 5549m, "Solid", "L" },
                    { 464, "Laboriosam vitae totam est et saepe unde assumenda eligendi.", 27, 6676m, "Solid", "Kg" },
                    { 252, "Soluta nisi consequatur commodi et saepe.", 22, 14183m, "Solid", "Kg" },
                    { 68, "Ea molestiae aut voluptatem impedit ea eligendi.", 34, 256m, "Gas", "L" },
                    { 263, "Vitae quam aut non doloribus consequatur nobis illo quia.", 55, 7565m, "Solid", "L" },
                    { 286, "Architecto sunt totam aliquid et et et.", 55, 8938m, "Liquid", "Kg" },
                    { 144, "Consequatur eum doloribus.", 56, 13841m, "Gas", "L" },
                    { 171, "Qui sit enim ut ab consequatur repellat facere.", 56, 14418m, "Liquid", "Kg" },
                    { 330, "Recusandae quasi repellat molestiae.", 56, 11855m, "Liquid", "Kg" },
                    { 63, "Harum sed autem expedita nemo.", 60, 4107m, "Solid", "L" },
                    { 230, "Necessitatibus vel autem necessitatibus non quam.", 60, 9794m, "Solid", "Kg" },
                    { 316, "Voluptatibus non in amet.", 34, 12786m, "Liquid", "L" },
                    { 67, "Qui aut autem veritatis aut illum qui eveniet id et.", 22, 11808m, "Liquid", "Kg" },
                    { 262, "Sint est qui saepe doloremque consequuntur.", 17, 148m, "Liquid", "L" },
                    { 362, "Consequatur qui voluptatem voluptatem sint quos et nulla et.", 11, 791m, "Gas", "Kg" },
                    { 443, "Eum illo earum.", 186, 10149m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 451, "Consequuntur velit tempore quas cupiditate incidunt molestias aut.", 186, 7477m, "Liquid", "L" },
                    { 373, "Dolore architecto qui fugit.", 187, 17411m, "Liquid", "L" },
                    { 412, "Inventore facilis sunt dignissimos reiciendis id commodi sint.", 187, 1545m, "Solid", "Kg" },
                    { 421, "Qui asperiores esse et odio repudiandae totam.", 187, 17893m, "Liquid", "L" },
                    { 185, "Corrupti impedit enim totam qui ex enim quo autem.", 188, 12246m, "Solid", "L" },
                    { 463, "Sequi accusantium error nam deserunt et.", 188, 16356m, "Liquid", "Kg" },
                    { 83, "Soluta repellendus sunt qui incidunt et.", 1, 8015m, "Liquid", "Kg" },
                    { 345, "Provident omnis quia distinctio illum.", 3, 8013m, "Gas", "L" },
                    { 363, "Consequuntur incidunt est quasi.", 6, 573m, "Liquid", "L" },
                    { 269, "Sed suscipit similique dolorem sed nostrum reiciendis adipisci.", 9, 3061m, "Gas", "Kg" },
                    { 288, "Ipsum non sapiente et totam corporis et omnis.", 10, 13008m, "Gas", "Kg" },
                    { 297, "Accusantium porro optio incidunt qui.", 10, 9535m, "Solid", "L" },
                    { 303, "Illum aut id quis aut.", 10, 6906m, "Solid", "L" },
                    { 333, "Ut ut minus.", 10, 8918m, "Gas", "L" },
                    { 87, "Eum placeat quaerat.", 11, 11422m, "Liquid", "Kg" },
                    { 101, "Impedit qui aut sapiente nemo ut voluptas officia aut.", 11, 14843m, "Solid", "Kg" },
                    { 470, "Sit laboriosam minus quas aspernatur id.", 175, 16593m, "Gas", "Kg" },
                    { 78, "Quidem aliquam accusantium deleniti qui expedita molestias ducimus.", 4, 6015m, "Gas", "Kg" }
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
