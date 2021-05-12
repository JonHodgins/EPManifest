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
                    DateShipped = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateScheduledArrival = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsignorId = table.Column<int>(type: "int", nullable: true),
                    ConsigneeId = table.Column<int>(type: "int", nullable: true),
                    CarrierId = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Manifests_Consignors_ConsignorId",
                        column: x => x.ConsignorId,
                        principalTable: "Consignors",
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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A1 Delivery" },
                    { 2, "Pacific Northwest Freight" },
                    { 3, "AP Freight" },
                    { 4, "NM Shipping Inc" },
                    { 5, "Frank's Freight" }
                });

            migrationBuilder.InsertData(
                table: "Consignees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pete's Disposal" },
                    { 2, "ATI Environmental" },
                    { 3, "EQ Enviro" },
                    { 4, "Whitehorse Landfill" },
                    { 5, "YAE" }
                });

            migrationBuilder.InsertData(
                table: "Consignors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Carmacks Health Clinic" },
                    { 2, "Mayo Health Centre" },
                    { 3, "Whitehorse General Hospital" },
                    { 4, "Teslin Health Centre" },
                    { 5, "Whistle Bend Place" }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 4, 4, 1, 1, new DateTime(2021, 11, 7, 12, 23, 16, 131, DateTimeKind.Unspecified).AddTicks(1324), new DateTime(2021, 8, 14, 16, 56, 15, 104, DateTimeKind.Unspecified).AddTicks(5809) },
                    { 93, 4, 5, 4, new DateTime(2021, 10, 9, 4, 21, 38, 987, DateTimeKind.Unspecified).AddTicks(1948), new DateTime(2021, 7, 13, 7, 47, 1, 451, DateTimeKind.Unspecified).AddTicks(4431) },
                    { 86, 2, 4, 4, new DateTime(2021, 12, 30, 0, 34, 13, 409, DateTimeKind.Unspecified).AddTicks(4224), new DateTime(2021, 7, 20, 6, 22, 1, 138, DateTimeKind.Unspecified).AddTicks(1676) },
                    { 76, 2, 1, 4, new DateTime(2021, 12, 28, 11, 46, 26, 68, DateTimeKind.Unspecified).AddTicks(6872), new DateTime(2021, 7, 8, 17, 6, 39, 766, DateTimeKind.Unspecified).AddTicks(6124) },
                    { 72, 5, 2, 4, new DateTime(2021, 12, 15, 1, 5, 45, 395, DateTimeKind.Unspecified).AddTicks(3389), new DateTime(2021, 5, 22, 9, 4, 39, 769, DateTimeKind.Unspecified).AddTicks(9320) },
                    { 71, 4, 5, 4, new DateTime(2021, 10, 31, 1, 38, 31, 32, DateTimeKind.Unspecified).AddTicks(7167), new DateTime(2021, 7, 3, 15, 12, 52, 894, DateTimeKind.Unspecified).AddTicks(7671) },
                    { 69, 1, 4, 4, new DateTime(2021, 11, 8, 17, 18, 45, 824, DateTimeKind.Unspecified).AddTicks(7547), new DateTime(2021, 5, 17, 6, 46, 42, 832, DateTimeKind.Unspecified).AddTicks(5254) },
                    { 60, 5, 3, 4, new DateTime(2021, 9, 7, 11, 27, 30, 716, DateTimeKind.Unspecified).AddTicks(4864), new DateTime(2021, 6, 1, 17, 37, 20, 243, DateTimeKind.Unspecified).AddTicks(4138) },
                    { 55, 1, 2, 4, new DateTime(2021, 11, 22, 15, 24, 37, 372, DateTimeKind.Unspecified).AddTicks(4188), new DateTime(2021, 6, 22, 2, 58, 29, 215, DateTimeKind.Unspecified).AddTicks(9068) },
                    { 52, 3, 2, 4, new DateTime(2021, 12, 10, 14, 20, 58, 674, DateTimeKind.Unspecified).AddTicks(8036), new DateTime(2021, 8, 10, 22, 22, 20, 490, DateTimeKind.Unspecified).AddTicks(8421) },
                    { 41, 4, 3, 4, new DateTime(2021, 11, 20, 2, 15, 2, 117, DateTimeKind.Unspecified).AddTicks(7955), new DateTime(2021, 7, 31, 17, 34, 28, 854, DateTimeKind.Unspecified).AddTicks(2810) },
                    { 27, 3, 1, 4, new DateTime(2021, 11, 8, 10, 58, 40, 332, DateTimeKind.Unspecified).AddTicks(8719), new DateTime(2021, 6, 13, 17, 4, 23, 401, DateTimeKind.Unspecified).AddTicks(273) },
                    { 24, 2, 3, 4, new DateTime(2021, 9, 24, 7, 7, 40, 565, DateTimeKind.Unspecified).AddTicks(6356), new DateTime(2021, 6, 2, 10, 32, 41, 569, DateTimeKind.Unspecified).AddTicks(65) },
                    { 18, 4, 1, 4, new DateTime(2021, 12, 11, 22, 29, 38, 708, DateTimeKind.Unspecified).AddTicks(3809), new DateTime(2021, 6, 17, 17, 34, 19, 869, DateTimeKind.Unspecified).AddTicks(5379) },
                    { 10, 1, 1, 4, new DateTime(2021, 12, 27, 20, 21, 20, 152, DateTimeKind.Unspecified).AddTicks(4280), new DateTime(2021, 7, 1, 4, 11, 27, 462, DateTimeKind.Unspecified).AddTicks(2072) },
                    { 87, 5, 3, 3, new DateTime(2021, 9, 16, 11, 24, 9, 865, DateTimeKind.Unspecified).AddTicks(7552), new DateTime(2021, 6, 3, 7, 25, 27, 331, DateTimeKind.Unspecified).AddTicks(3244) },
                    { 84, 4, 4, 3, new DateTime(2021, 11, 10, 9, 46, 9, 957, DateTimeKind.Unspecified).AddTicks(5126), new DateTime(2021, 5, 25, 15, 2, 25, 526, DateTimeKind.Unspecified).AddTicks(5342) },
                    { 83, 3, 5, 3, new DateTime(2021, 12, 2, 4, 54, 23, 23, DateTimeKind.Unspecified).AddTicks(8168), new DateTime(2021, 5, 24, 18, 19, 2, 597, DateTimeKind.Unspecified).AddTicks(2128) },
                    { 70, 2, 3, 3, new DateTime(2021, 9, 16, 1, 14, 10, 580, DateTimeKind.Unspecified).AddTicks(1266), new DateTime(2021, 7, 15, 0, 2, 4, 672, DateTimeKind.Unspecified).AddTicks(3876) },
                    { 66, 4, 1, 3, new DateTime(2021, 9, 5, 7, 57, 49, 410, DateTimeKind.Unspecified).AddTicks(9946), new DateTime(2021, 8, 1, 9, 28, 29, 996, DateTimeKind.Unspecified).AddTicks(2527) },
                    { 65, 3, 2, 3, new DateTime(2021, 11, 9, 5, 56, 33, 717, DateTimeKind.Unspecified).AddTicks(2423), new DateTime(2021, 5, 20, 0, 38, 22, 823, DateTimeKind.Unspecified).AddTicks(1974) },
                    { 64, 4, 1, 3, new DateTime(2021, 11, 27, 10, 27, 49, 123, DateTimeKind.Unspecified).AddTicks(3587), new DateTime(2021, 6, 2, 17, 29, 46, 224, DateTimeKind.Unspecified).AddTicks(4721) },
                    { 95, 1, 4, 4, new DateTime(2021, 11, 24, 22, 48, 40, 987, DateTimeKind.Unspecified).AddTicks(4804), new DateTime(2021, 5, 17, 22, 14, 14, 595, DateTimeKind.Unspecified).AddTicks(6701) },
                    { 54, 1, 1, 3, new DateTime(2021, 11, 13, 3, 43, 56, 828, DateTimeKind.Unspecified).AddTicks(9146), new DateTime(2021, 8, 2, 2, 46, 6, 637, DateTimeKind.Unspecified).AddTicks(8783) },
                    { 97, 5, 1, 4, new DateTime(2021, 12, 10, 17, 54, 3, 809, DateTimeKind.Unspecified).AddTicks(6466), new DateTime(2021, 7, 1, 13, 54, 40, 673, DateTimeKind.Unspecified).AddTicks(5451) },
                    { 1, 4, 5, 5, new DateTime(2021, 9, 25, 22, 59, 44, 13, DateTimeKind.Unspecified).AddTicks(8985), new DateTime(2021, 6, 3, 6, 13, 27, 787, DateTimeKind.Unspecified).AddTicks(2604) },
                    { 90, 3, 1, 5, new DateTime(2021, 9, 20, 15, 51, 12, 141, DateTimeKind.Unspecified).AddTicks(376), new DateTime(2021, 7, 2, 7, 43, 6, 100, DateTimeKind.Unspecified).AddTicks(7581) },
                    { 89, 4, 5, 5, new DateTime(2021, 11, 12, 4, 37, 57, 166, DateTimeKind.Unspecified).AddTicks(1985), new DateTime(2021, 6, 24, 9, 8, 52, 334, DateTimeKind.Unspecified).AddTicks(4041) },
                    { 88, 1, 5, 5, new DateTime(2021, 9, 9, 2, 26, 41, 762, DateTimeKind.Unspecified).AddTicks(396), new DateTime(2021, 7, 18, 8, 20, 0, 573, DateTimeKind.Unspecified).AddTicks(2780) },
                    { 81, 5, 2, 5, new DateTime(2021, 12, 30, 17, 29, 42, 812, DateTimeKind.Unspecified).AddTicks(7424), new DateTime(2021, 5, 14, 8, 27, 9, 982, DateTimeKind.Unspecified).AddTicks(1340) },
                    { 80, 4, 2, 5, new DateTime(2021, 10, 8, 6, 1, 5, 779, DateTimeKind.Unspecified).AddTicks(7378), new DateTime(2021, 6, 26, 6, 36, 52, 512, DateTimeKind.Unspecified).AddTicks(8544) },
                    { 79, 4, 3, 5, new DateTime(2021, 11, 19, 12, 51, 31, 252, DateTimeKind.Unspecified).AddTicks(2144), new DateTime(2021, 6, 4, 22, 53, 37, 900, DateTimeKind.Unspecified).AddTicks(2535) },
                    { 67, 4, 5, 5, new DateTime(2021, 11, 29, 23, 19, 29, 229, DateTimeKind.Unspecified).AddTicks(757), new DateTime(2021, 7, 19, 10, 41, 13, 846, DateTimeKind.Unspecified).AddTicks(4937) },
                    { 53, 2, 3, 5, new DateTime(2021, 9, 9, 23, 3, 36, 669, DateTimeKind.Unspecified).AddTicks(3657), new DateTime(2021, 6, 26, 14, 36, 13, 905, DateTimeKind.Unspecified).AddTicks(4463) },
                    { 47, 1, 3, 5, new DateTime(2021, 10, 19, 22, 3, 33, 846, DateTimeKind.Unspecified).AddTicks(7413), new DateTime(2021, 7, 7, 13, 11, 0, 297, DateTimeKind.Unspecified).AddTicks(6141) },
                    { 46, 4, 2, 5, new DateTime(2021, 12, 6, 18, 5, 20, 242, DateTimeKind.Unspecified).AddTicks(1879), new DateTime(2021, 7, 27, 10, 54, 50, 928, DateTimeKind.Unspecified).AddTicks(5237) },
                    { 43, 3, 2, 5, new DateTime(2021, 12, 29, 15, 33, 37, 416, DateTimeKind.Unspecified).AddTicks(4422), new DateTime(2021, 5, 25, 14, 36, 36, 326, DateTimeKind.Unspecified).AddTicks(9300) },
                    { 37, 5, 3, 5, new DateTime(2021, 12, 14, 6, 29, 23, 162, DateTimeKind.Unspecified).AddTicks(3243), new DateTime(2021, 8, 17, 21, 52, 21, 277, DateTimeKind.Unspecified).AddTicks(3454) },
                    { 36, 2, 1, 5, new DateTime(2021, 9, 18, 18, 47, 16, 498, DateTimeKind.Unspecified).AddTicks(4261), new DateTime(2021, 7, 16, 11, 29, 19, 345, DateTimeKind.Unspecified).AddTicks(4688) },
                    { 34, 3, 3, 5, new DateTime(2021, 10, 11, 13, 52, 39, 816, DateTimeKind.Unspecified).AddTicks(4255), new DateTime(2021, 8, 3, 14, 55, 24, 37, DateTimeKind.Unspecified).AddTicks(7721) },
                    { 28, 2, 3, 5, new DateTime(2021, 12, 5, 4, 2, 16, 347, DateTimeKind.Unspecified).AddTicks(1918), new DateTime(2021, 6, 2, 0, 29, 7, 652, DateTimeKind.Unspecified).AddTicks(3601) },
                    { 23, 5, 1, 5, new DateTime(2021, 9, 30, 4, 56, 29, 856, DateTimeKind.Unspecified).AddTicks(9250), new DateTime(2021, 6, 14, 16, 25, 52, 453, DateTimeKind.Unspecified).AddTicks(3115) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 20, 3, 4, 5, new DateTime(2021, 9, 2, 14, 2, 9, 653, DateTimeKind.Unspecified).AddTicks(4073), new DateTime(2021, 6, 7, 1, 56, 49, 269, DateTimeKind.Unspecified).AddTicks(5686) },
                    { 17, 5, 2, 5, new DateTime(2021, 12, 12, 5, 4, 51, 196, DateTimeKind.Unspecified).AddTicks(3503), new DateTime(2021, 5, 29, 3, 17, 43, 268, DateTimeKind.Unspecified).AddTicks(5091) },
                    { 13, 3, 3, 5, new DateTime(2021, 12, 7, 9, 21, 46, 569, DateTimeKind.Unspecified).AddTicks(5934), new DateTime(2021, 5, 15, 13, 59, 7, 416, DateTimeKind.Unspecified).AddTicks(7775) },
                    { 11, 2, 3, 5, new DateTime(2021, 10, 11, 20, 6, 45, 489, DateTimeKind.Unspecified).AddTicks(2177), new DateTime(2021, 6, 23, 23, 55, 31, 257, DateTimeKind.Unspecified).AddTicks(9854) },
                    { 6, 3, 2, 5, new DateTime(2021, 11, 29, 15, 5, 45, 493, DateTimeKind.Unspecified).AddTicks(5446), new DateTime(2021, 5, 26, 3, 24, 6, 884, DateTimeKind.Unspecified).AddTicks(4530) },
                    { 99, 3, 2, 4, new DateTime(2021, 10, 10, 23, 0, 34, 662, DateTimeKind.Unspecified).AddTicks(5878), new DateTime(2021, 6, 11, 11, 39, 14, 624, DateTimeKind.Unspecified).AddTicks(749) },
                    { 51, 3, 4, 3, new DateTime(2021, 12, 21, 11, 25, 44, 685, DateTimeKind.Unspecified).AddTicks(7599), new DateTime(2021, 6, 10, 15, 24, 35, 537, DateTimeKind.Unspecified).AddTicks(9488) },
                    { 44, 2, 3, 3, new DateTime(2021, 12, 10, 8, 38, 10, 694, DateTimeKind.Unspecified).AddTicks(7042), new DateTime(2021, 5, 10, 8, 15, 46, 386, DateTimeKind.Unspecified).AddTicks(4852) },
                    { 39, 5, 2, 3, new DateTime(2021, 11, 28, 22, 42, 14, 500, DateTimeKind.Unspecified).AddTicks(6206), new DateTime(2021, 6, 10, 10, 27, 1, 221, DateTimeKind.Unspecified).AddTicks(9890) },
                    { 85, 1, 3, 1, new DateTime(2021, 11, 13, 1, 38, 14, 137, DateTimeKind.Unspecified).AddTicks(2944), new DateTime(2021, 6, 4, 19, 51, 11, 116, DateTimeKind.Unspecified).AddTicks(3332) },
                    { 78, 2, 1, 1, new DateTime(2021, 9, 12, 4, 55, 48, 979, DateTimeKind.Unspecified).AddTicks(7377), new DateTime(2021, 5, 23, 8, 31, 53, 774, DateTimeKind.Unspecified).AddTicks(770) },
                    { 77, 1, 4, 1, new DateTime(2021, 10, 21, 21, 2, 57, 837, DateTimeKind.Unspecified).AddTicks(2924), new DateTime(2021, 7, 18, 2, 9, 4, 568, DateTimeKind.Unspecified).AddTicks(8597) },
                    { 75, 4, 2, 1, new DateTime(2021, 12, 21, 18, 43, 35, 500, DateTimeKind.Unspecified).AddTicks(5098), new DateTime(2021, 6, 10, 20, 34, 17, 452, DateTimeKind.Unspecified).AddTicks(2557) },
                    { 63, 5, 3, 1, new DateTime(2021, 12, 6, 23, 41, 55, 809, DateTimeKind.Unspecified).AddTicks(1391), new DateTime(2021, 5, 16, 23, 41, 55, 694, DateTimeKind.Unspecified).AddTicks(9575) },
                    { 61, 1, 4, 1, new DateTime(2021, 10, 19, 13, 13, 44, 867, DateTimeKind.Unspecified).AddTicks(9949), new DateTime(2021, 7, 27, 4, 36, 36, 112, DateTimeKind.Unspecified).AddTicks(7656) },
                    { 59, 2, 2, 1, new DateTime(2021, 11, 18, 15, 4, 25, 265, DateTimeKind.Unspecified).AddTicks(8969), new DateTime(2021, 6, 22, 4, 18, 37, 383, DateTimeKind.Unspecified).AddTicks(5529) },
                    { 57, 3, 3, 1, new DateTime(2021, 9, 26, 3, 0, 32, 255, DateTimeKind.Unspecified).AddTicks(6337), new DateTime(2021, 7, 5, 22, 25, 33, 439, DateTimeKind.Unspecified).AddTicks(7856) },
                    { 50, 5, 5, 1, new DateTime(2021, 9, 23, 15, 26, 7, 444, DateTimeKind.Unspecified).AddTicks(6722), new DateTime(2021, 6, 11, 17, 16, 52, 933, DateTimeKind.Unspecified).AddTicks(6349) },
                    { 49, 2, 4, 1, new DateTime(2021, 11, 6, 9, 9, 13, 563, DateTimeKind.Unspecified).AddTicks(7398), new DateTime(2021, 6, 10, 6, 1, 6, 3, DateTimeKind.Unspecified).AddTicks(5547) },
                    { 45, 2, 5, 1, new DateTime(2021, 12, 20, 6, 25, 48, 973, DateTimeKind.Unspecified).AddTicks(7052), new DateTime(2021, 6, 3, 16, 35, 29, 154, DateTimeKind.Unspecified).AddTicks(1467) },
                    { 40, 3, 5, 1, new DateTime(2021, 9, 10, 9, 29, 11, 172, DateTimeKind.Unspecified).AddTicks(906), new DateTime(2021, 5, 22, 0, 36, 34, 793, DateTimeKind.Unspecified).AddTicks(2462) },
                    { 35, 1, 2, 1, new DateTime(2021, 12, 11, 9, 40, 28, 575, DateTimeKind.Unspecified).AddTicks(2965), new DateTime(2021, 6, 26, 23, 45, 54, 296, DateTimeKind.Unspecified).AddTicks(8821) },
                    { 33, 1, 2, 1, new DateTime(2021, 9, 30, 13, 38, 43, 263, DateTimeKind.Unspecified).AddTicks(7709), new DateTime(2021, 8, 17, 10, 39, 44, 102, DateTimeKind.Unspecified).AddTicks(7439) },
                    { 32, 1, 3, 1, new DateTime(2021, 12, 22, 3, 29, 52, 157, DateTimeKind.Unspecified).AddTicks(1731), new DateTime(2021, 6, 11, 12, 14, 5, 891, DateTimeKind.Unspecified).AddTicks(5498) },
                    { 26, 5, 1, 1, new DateTime(2021, 10, 8, 3, 21, 13, 304, DateTimeKind.Unspecified).AddTicks(2237), new DateTime(2021, 8, 1, 8, 31, 39, 948, DateTimeKind.Unspecified).AddTicks(9659) },
                    { 25, 3, 3, 1, new DateTime(2021, 10, 19, 15, 53, 48, 886, DateTimeKind.Unspecified).AddTicks(334), new DateTime(2021, 7, 8, 5, 26, 51, 719, DateTimeKind.Unspecified).AddTicks(9468) },
                    { 22, 5, 2, 1, new DateTime(2021, 12, 29, 12, 45, 31, 294, DateTimeKind.Unspecified).AddTicks(7621), new DateTime(2021, 5, 29, 17, 48, 59, 722, DateTimeKind.Unspecified).AddTicks(4606) },
                    { 15, 2, 5, 1, new DateTime(2021, 9, 27, 13, 43, 54, 572, DateTimeKind.Unspecified).AddTicks(1609), new DateTime(2021, 6, 14, 3, 17, 11, 262, DateTimeKind.Unspecified).AddTicks(5672) },
                    { 14, 5, 1, 1, new DateTime(2021, 12, 3, 0, 40, 58, 331, DateTimeKind.Unspecified).AddTicks(7887), new DateTime(2021, 6, 20, 2, 37, 40, 905, DateTimeKind.Unspecified).AddTicks(5980) },
                    { 7, 1, 2, 1, new DateTime(2021, 10, 20, 17, 8, 2, 18, DateTimeKind.Unspecified).AddTicks(5502), new DateTime(2021, 7, 26, 13, 5, 3, 103, DateTimeKind.Unspecified).AddTicks(919) },
                    { 91, 3, 3, 1, new DateTime(2021, 9, 27, 15, 27, 13, 623, DateTimeKind.Unspecified).AddTicks(3920), new DateTime(2021, 8, 13, 8, 38, 7, 346, DateTimeKind.Unspecified).AddTicks(6234) },
                    { 100, 1, 1, 1, new DateTime(2021, 11, 16, 10, 7, 4, 395, DateTimeKind.Unspecified).AddTicks(6899), new DateTime(2021, 5, 19, 2, 13, 35, 115, DateTimeKind.Unspecified).AddTicks(1694) },
                    { 2, 4, 5, 2, new DateTime(2021, 12, 22, 13, 47, 13, 846, DateTimeKind.Unspecified).AddTicks(1958), new DateTime(2021, 8, 8, 18, 24, 55, 613, DateTimeKind.Unspecified).AddTicks(1216) },
                    { 8, 2, 1, 2, new DateTime(2021, 11, 4, 18, 44, 45, 259, DateTimeKind.Unspecified).AddTicks(8579), new DateTime(2021, 7, 8, 1, 45, 57, 665, DateTimeKind.Unspecified).AddTicks(9009) },
                    { 38, 3, 4, 3, new DateTime(2021, 11, 4, 2, 37, 38, 964, DateTimeKind.Unspecified).AddTicks(5102), new DateTime(2021, 6, 16, 18, 31, 48, 684, DateTimeKind.Unspecified).AddTicks(1462) },
                    { 31, 2, 2, 3, new DateTime(2021, 12, 27, 18, 42, 37, 571, DateTimeKind.Unspecified).AddTicks(6750), new DateTime(2021, 5, 15, 22, 32, 39, 971, DateTimeKind.Unspecified).AddTicks(6505) },
                    { 21, 4, 1, 3, new DateTime(2021, 12, 26, 21, 56, 52, 83, DateTimeKind.Unspecified).AddTicks(785), new DateTime(2021, 7, 27, 18, 13, 10, 700, DateTimeKind.Unspecified).AddTicks(5899) },
                    { 12, 1, 5, 3, new DateTime(2021, 9, 27, 7, 44, 49, 858, DateTimeKind.Unspecified).AddTicks(8757), new DateTime(2021, 6, 27, 0, 0, 4, 940, DateTimeKind.Unspecified).AddTicks(6290) },
                    { 5, 5, 2, 3, new DateTime(2021, 12, 6, 0, 29, 43, 864, DateTimeKind.Unspecified).AddTicks(7165), new DateTime(2021, 6, 27, 12, 44, 38, 777, DateTimeKind.Unspecified).AddTicks(1230) },
                    { 3, 4, 1, 3, new DateTime(2021, 9, 14, 0, 3, 21, 911, DateTimeKind.Unspecified).AddTicks(1157), new DateTime(2021, 8, 6, 8, 35, 53, 733, DateTimeKind.Unspecified).AddTicks(1457) },
                    { 96, 4, 5, 2, new DateTime(2021, 11, 19, 4, 43, 55, 3, DateTimeKind.Unspecified).AddTicks(2036), new DateTime(2021, 7, 21, 5, 8, 10, 338, DateTimeKind.Unspecified).AddTicks(5412) },
                    { 92, 4, 1, 2, new DateTime(2021, 10, 9, 18, 50, 11, 824, DateTimeKind.Unspecified).AddTicks(8138), new DateTime(2021, 6, 28, 21, 46, 21, 835, DateTimeKind.Unspecified).AddTicks(1187) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 82, 2, 1, 2, new DateTime(2021, 11, 27, 7, 16, 55, 253, DateTimeKind.Unspecified).AddTicks(9167), new DateTime(2021, 7, 12, 9, 30, 57, 336, DateTimeKind.Unspecified).AddTicks(4313) },
                    { 74, 1, 4, 2, new DateTime(2021, 11, 4, 20, 46, 38, 761, DateTimeKind.Unspecified).AddTicks(495), new DateTime(2021, 6, 15, 11, 26, 52, 708, DateTimeKind.Unspecified).AddTicks(6459) },
                    { 94, 1, 1, 5, new DateTime(2021, 12, 17, 7, 55, 56, 406, DateTimeKind.Unspecified).AddTicks(4174), new DateTime(2021, 5, 10, 1, 19, 52, 724, DateTimeKind.Unspecified).AddTicks(8009) },
                    { 73, 3, 5, 2, new DateTime(2021, 11, 18, 22, 5, 8, 75, DateTimeKind.Unspecified).AddTicks(4799), new DateTime(2021, 7, 12, 23, 32, 30, 909, DateTimeKind.Unspecified).AddTicks(848) },
                    { 62, 1, 3, 2, new DateTime(2021, 11, 3, 11, 10, 14, 907, DateTimeKind.Unspecified).AddTicks(9421), new DateTime(2021, 7, 17, 2, 21, 1, 506, DateTimeKind.Unspecified).AddTicks(3111) },
                    { 58, 5, 5, 2, new DateTime(2021, 11, 17, 22, 54, 2, 796, DateTimeKind.Unspecified).AddTicks(3164), new DateTime(2021, 7, 16, 14, 25, 12, 868, DateTimeKind.Unspecified).AddTicks(9993) },
                    { 56, 5, 4, 2, new DateTime(2021, 11, 30, 10, 17, 28, 698, DateTimeKind.Unspecified).AddTicks(2786), new DateTime(2021, 7, 25, 14, 26, 13, 287, DateTimeKind.Unspecified).AddTicks(7824) },
                    { 48, 1, 4, 2, new DateTime(2021, 11, 15, 23, 43, 13, 892, DateTimeKind.Unspecified).AddTicks(5217), new DateTime(2021, 6, 2, 18, 56, 24, 719, DateTimeKind.Unspecified).AddTicks(1100) },
                    { 42, 5, 2, 2, new DateTime(2021, 9, 7, 20, 40, 39, 690, DateTimeKind.Unspecified).AddTicks(136), new DateTime(2021, 6, 3, 13, 32, 52, 482, DateTimeKind.Unspecified).AddTicks(7323) },
                    { 30, 3, 1, 2, new DateTime(2021, 12, 13, 13, 55, 26, 950, DateTimeKind.Unspecified).AddTicks(1398), new DateTime(2021, 5, 16, 7, 9, 39, 423, DateTimeKind.Unspecified).AddTicks(6109) },
                    { 29, 3, 1, 2, new DateTime(2021, 12, 22, 7, 37, 35, 107, DateTimeKind.Unspecified).AddTicks(594), new DateTime(2021, 6, 19, 3, 3, 57, 564, DateTimeKind.Unspecified).AddTicks(5987) },
                    { 19, 5, 5, 2, new DateTime(2021, 11, 10, 6, 22, 51, 208, DateTimeKind.Unspecified).AddTicks(2240), new DateTime(2021, 6, 13, 1, 20, 42, 510, DateTimeKind.Unspecified).AddTicks(7710) },
                    { 16, 5, 4, 2, new DateTime(2021, 9, 13, 22, 59, 28, 269, DateTimeKind.Unspecified).AddTicks(2645), new DateTime(2021, 6, 15, 5, 13, 23, 154, DateTimeKind.Unspecified).AddTicks(2657) },
                    { 9, 4, 1, 2, new DateTime(2021, 9, 13, 22, 56, 22, 177, DateTimeKind.Unspecified).AddTicks(933), new DateTime(2021, 5, 15, 15, 24, 27, 579, DateTimeKind.Unspecified).AddTicks(5128) },
                    { 68, 4, 2, 2, new DateTime(2021, 12, 22, 10, 44, 48, 534, DateTimeKind.Unspecified).AddTicks(2450), new DateTime(2021, 5, 20, 18, 58, 36, 416, DateTimeKind.Unspecified).AddTicks(4846) },
                    { 98, 1, 1, 5, new DateTime(2021, 12, 8, 9, 8, 9, 962, DateTimeKind.Unspecified).AddTicks(8375), new DateTime(2021, 5, 8, 23, 40, 44, 135, DateTimeKind.Unspecified).AddTicks(5387) }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Manifests_ConsignorId",
                table: "Manifests",
                column: "ConsignorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsigneeAddresses");

            migrationBuilder.DropTable(
                name: "ConsignorAddresses");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Manifests");

            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropTable(
                name: "Consignees");

            migrationBuilder.DropTable(
                name: "Consignors");
        }
    }
}
