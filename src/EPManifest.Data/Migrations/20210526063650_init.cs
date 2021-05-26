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
                    { 1, 2, "YT30178-1", 1, new DateTime(2021, 12, 9, 16, 57, 28, 441, DateTimeKind.Unspecified).AddTicks(6605), new DateTime(2021, 5, 27, 19, 53, 20, 540, DateTimeKind.Unspecified).AddTicks(9380) },
                    { 81, 1, "YT71499-1", 4, new DateTime(2021, 10, 9, 6, 7, 36, 761, DateTimeKind.Unspecified).AddTicks(5239), new DateTime(2021, 5, 10, 22, 50, 55, 929, DateTimeKind.Unspecified).AddTicks(8988) },
                    { 63, 5, "YT13451-1", 4, new DateTime(2021, 12, 2, 8, 14, 40, 724, DateTimeKind.Unspecified).AddTicks(3992), new DateTime(2021, 6, 14, 14, 17, 44, 558, DateTimeKind.Unspecified).AddTicks(7773) },
                    { 55, 1, "YT64430-1", 4, new DateTime(2021, 9, 11, 2, 26, 1, 314, DateTimeKind.Unspecified).AddTicks(6629), new DateTime(2021, 5, 18, 21, 53, 0, 900, DateTimeKind.Unspecified).AddTicks(2245) },
                    { 46, 5, "YT82667-1", 4, new DateTime(2021, 11, 11, 11, 22, 17, 676, DateTimeKind.Unspecified).AddTicks(9450), new DateTime(2021, 5, 21, 4, 27, 7, 276, DateTimeKind.Unspecified).AddTicks(5428) },
                    { 35, 1, "YT80529-0", 4, new DateTime(2021, 10, 30, 20, 42, 0, 244, DateTimeKind.Unspecified).AddTicks(3544), new DateTime(2021, 6, 4, 15, 11, 30, 905, DateTimeKind.Unspecified).AddTicks(1896) },
                    { 33, 3, "YT39773-1", 4, new DateTime(2021, 9, 1, 13, 40, 12, 105, DateTimeKind.Unspecified).AddTicks(3329), new DateTime(2021, 5, 20, 23, 41, 27, 918, DateTimeKind.Unspecified).AddTicks(4837) },
                    { 32, 4, "YT24505-0", 4, new DateTime(2021, 11, 26, 11, 17, 25, 968, DateTimeKind.Unspecified).AddTicks(8108), new DateTime(2021, 6, 18, 1, 56, 7, 552, DateTimeKind.Unspecified).AddTicks(9572) },
                    { 26, 4, "YT46999-0", 4, new DateTime(2021, 9, 13, 1, 38, 22, 544, DateTimeKind.Unspecified).AddTicks(482), new DateTime(2021, 8, 27, 0, 51, 29, 142, DateTimeKind.Unspecified).AddTicks(6905) },
                    { 24, 1, "YT19800-1", 4, new DateTime(2021, 11, 10, 11, 56, 9, 714, DateTimeKind.Unspecified).AddTicks(9283), new DateTime(2021, 6, 22, 20, 21, 51, 142, DateTimeKind.Unspecified).AddTicks(5235) },
                    { 22, 4, "YT56070-0", 4, new DateTime(2021, 12, 11, 13, 8, 58, 880, DateTimeKind.Unspecified).AddTicks(2481), new DateTime(2021, 5, 15, 22, 59, 48, 673, DateTimeKind.Unspecified).AddTicks(7404) },
                    { 19, 3, "YT24756-0", 4, new DateTime(2021, 12, 10, 10, 4, 37, 401, DateTimeKind.Unspecified).AddTicks(7980), new DateTime(2021, 8, 6, 5, 14, 11, 713, DateTimeKind.Unspecified).AddTicks(2862) },
                    { 6, 5, "YT13605-0", 4, new DateTime(2021, 10, 8, 22, 3, 52, 234, DateTimeKind.Unspecified).AddTicks(4107), new DateTime(2021, 6, 1, 10, 38, 10, 955, DateTimeKind.Unspecified).AddTicks(5524) },
                    { 3, 5, "YT18884-0", 4, new DateTime(2021, 11, 12, 22, 51, 36, 505, DateTimeKind.Unspecified).AddTicks(559), new DateTime(2021, 5, 31, 20, 25, 19, 495, DateTimeKind.Unspecified).AddTicks(44) },
                    { 100, 3, "YT56851-1", 3, new DateTime(2021, 9, 6, 15, 46, 22, 586, DateTimeKind.Unspecified).AddTicks(2612), new DateTime(2021, 6, 15, 2, 47, 19, 21, DateTimeKind.Unspecified).AddTicks(9556) },
                    { 95, 1, "YT49829-1", 3, new DateTime(2021, 11, 15, 19, 24, 19, 8, DateTimeKind.Unspecified).AddTicks(378), new DateTime(2021, 7, 22, 11, 16, 58, 430, DateTimeKind.Unspecified).AddTicks(8793) },
                    { 94, 2, "YT71622-0", 3, new DateTime(2021, 11, 6, 17, 45, 36, 454, DateTimeKind.Unspecified).AddTicks(6433), new DateTime(2021, 7, 30, 20, 42, 30, 470, DateTimeKind.Unspecified).AddTicks(5031) },
                    { 83, 3, "YT49743-0", 3, new DateTime(2021, 12, 13, 22, 47, 58, 249, DateTimeKind.Unspecified).AddTicks(5911), new DateTime(2021, 8, 17, 11, 21, 39, 537, DateTimeKind.Unspecified).AddTicks(7031) },
                    { 82, 4, "YT82810-1", 3, new DateTime(2021, 9, 26, 14, 39, 6, 545, DateTimeKind.Unspecified).AddTicks(1456), new DateTime(2021, 6, 17, 15, 2, 15, 68, DateTimeKind.Unspecified).AddTicks(916) },
                    { 80, 3, "YT57547-0", 3, new DateTime(2021, 11, 21, 20, 49, 0, 618, DateTimeKind.Unspecified).AddTicks(2161), new DateTime(2021, 6, 26, 16, 24, 31, 474, DateTimeKind.Unspecified).AddTicks(3100) },
                    { 79, 4, "YT26908-0", 3, new DateTime(2021, 10, 31, 7, 47, 56, 486, DateTimeKind.Unspecified).AddTicks(5097), new DateTime(2021, 5, 17, 9, 55, 21, 422, DateTimeKind.Unspecified).AddTicks(3149) },
                    { 75, 1, "YT28163-0", 3, new DateTime(2021, 9, 21, 5, 40, 22, 66, DateTimeKind.Unspecified).AddTicks(6682), new DateTime(2021, 7, 6, 17, 36, 51, 577, DateTimeKind.Unspecified).AddTicks(9084) },
                    { 88, 2, "YT78952-0", 4, new DateTime(2021, 12, 4, 9, 3, 54, 469, DateTimeKind.Unspecified).AddTicks(1920), new DateTime(2021, 6, 14, 13, 25, 13, 848, DateTimeKind.Unspecified).AddTicks(8488) },
                    { 66, 4, "YT56127-0", 3, new DateTime(2021, 12, 24, 13, 50, 20, 427, DateTimeKind.Unspecified).AddTicks(7628), new DateTime(2021, 7, 28, 23, 46, 50, 771, DateTimeKind.Unspecified).AddTicks(7719) },
                    { 90, 2, "YT74820-0", 4, new DateTime(2021, 9, 14, 6, 55, 19, 815, DateTimeKind.Unspecified).AddTicks(7605), new DateTime(2021, 6, 28, 0, 57, 20, 635, DateTimeKind.Unspecified).AddTicks(509) },
                    { 5, 3, "YT82508-0", 5, new DateTime(2021, 10, 17, 15, 22, 2, 127, DateTimeKind.Unspecified).AddTicks(5557), new DateTime(2021, 7, 9, 2, 8, 52, 259, DateTimeKind.Unspecified).AddTicks(6526) },
                    { 93, 2, "YT72473-1", 5, new DateTime(2021, 11, 2, 4, 16, 43, 118, DateTimeKind.Unspecified).AddTicks(5922), new DateTime(2021, 7, 8, 7, 1, 40, 952, DateTimeKind.Unspecified).AddTicks(6192) },
                    { 91, 4, "YT26656-0", 5, new DateTime(2021, 12, 26, 0, 39, 0, 351, DateTimeKind.Unspecified).AddTicks(1371), new DateTime(2021, 7, 16, 13, 33, 30, 809, DateTimeKind.Unspecified).AddTicks(9837) },
                    { 84, 2, "YT54053-0", 5, new DateTime(2021, 10, 22, 11, 26, 7, 279, DateTimeKind.Unspecified).AddTicks(7633), new DateTime(2021, 8, 29, 12, 58, 48, 679, DateTimeKind.Unspecified).AddTicks(9365) },
                    { 71, 4, "YT65416-0", 5, new DateTime(2021, 9, 27, 4, 11, 7, 121, DateTimeKind.Unspecified).AddTicks(9836), new DateTime(2021, 5, 8, 18, 56, 2, 742, DateTimeKind.Unspecified).AddTicks(1622) },
                    { 68, 5, "YT51061-0", 5, new DateTime(2021, 12, 14, 20, 6, 59, 241, DateTimeKind.Unspecified).AddTicks(5470), new DateTime(2021, 5, 18, 19, 20, 30, 637, DateTimeKind.Unspecified).AddTicks(4397) },
                    { 67, 3, "YT36165-0", 5, new DateTime(2021, 12, 5, 5, 50, 11, 756, DateTimeKind.Unspecified).AddTicks(9321), new DateTime(2021, 8, 28, 17, 6, 10, 899, DateTimeKind.Unspecified).AddTicks(8609) },
                    { 64, 3, "YT76428-0", 5, new DateTime(2021, 12, 19, 15, 50, 50, 257, DateTimeKind.Unspecified).AddTicks(4709), new DateTime(2021, 7, 10, 18, 44, 44, 335, DateTimeKind.Unspecified).AddTicks(4212) },
                    { 62, 3, "YT46916-0", 5, new DateTime(2021, 10, 21, 4, 24, 33, 625, DateTimeKind.Unspecified).AddTicks(3142), new DateTime(2021, 6, 8, 23, 56, 22, 17, DateTimeKind.Unspecified).AddTicks(1147) },
                    { 61, 5, "YT13240-1", 5, new DateTime(2021, 12, 26, 16, 27, 41, 387, DateTimeKind.Unspecified).AddTicks(7036), new DateTime(2021, 5, 22, 8, 52, 48, 129, DateTimeKind.Unspecified).AddTicks(4545) },
                    { 60, 2, "YT50405-0", 5, new DateTime(2021, 9, 22, 17, 51, 10, 940, DateTimeKind.Unspecified).AddTicks(551), new DateTime(2021, 7, 20, 5, 26, 15, 745, DateTimeKind.Unspecified).AddTicks(9314) },
                    { 57, 4, "YT39604-0", 5, new DateTime(2021, 10, 4, 5, 58, 16, 112, DateTimeKind.Unspecified).AddTicks(6234), new DateTime(2021, 8, 3, 21, 45, 9, 400, DateTimeKind.Unspecified).AddTicks(7097) },
                    { 53, 4, "YT88954-0", 5, new DateTime(2021, 12, 28, 16, 7, 39, 0, DateTimeKind.Unspecified).AddTicks(9840), new DateTime(2021, 7, 21, 15, 2, 48, 993, DateTimeKind.Unspecified).AddTicks(3552) },
                    { 45, 3, "YT22317-0", 5, new DateTime(2021, 12, 20, 9, 7, 16, 700, DateTimeKind.Unspecified).AddTicks(6038), new DateTime(2021, 7, 28, 20, 44, 14, 345, DateTimeKind.Unspecified).AddTicks(5784) },
                    { 41, 1, "YT24024-0", 5, new DateTime(2021, 12, 23, 14, 4, 18, 279, DateTimeKind.Unspecified).AddTicks(3844), new DateTime(2021, 8, 30, 1, 38, 35, 580, DateTimeKind.Unspecified).AddTicks(1473) },
                    { 40, 4, "YT54512-1", 5, new DateTime(2021, 9, 18, 11, 24, 1, 202, DateTimeKind.Unspecified).AddTicks(9174), new DateTime(2021, 8, 5, 17, 38, 22, 692, DateTimeKind.Unspecified).AddTicks(2805) },
                    { 23, 4, "YT83739-1", 5, new DateTime(2021, 11, 14, 9, 8, 5, 852, DateTimeKind.Unspecified).AddTicks(3790), new DateTime(2021, 8, 22, 7, 18, 33, 544, DateTimeKind.Unspecified).AddTicks(1903) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 20, 3, "YT52081-0", 5, new DateTime(2021, 9, 29, 18, 44, 25, 998, DateTimeKind.Unspecified).AddTicks(6870), new DateTime(2021, 6, 20, 17, 40, 14, 910, DateTimeKind.Unspecified).AddTicks(183) },
                    { 17, 3, "YT70586-0", 5, new DateTime(2021, 11, 27, 2, 59, 39, 885, DateTimeKind.Unspecified).AddTicks(3686), new DateTime(2021, 8, 11, 1, 3, 52, 192, DateTimeKind.Unspecified).AddTicks(2514) },
                    { 15, 3, "YT32493-0", 5, new DateTime(2021, 11, 9, 12, 38, 5, 297, DateTimeKind.Unspecified).AddTicks(5431), new DateTime(2021, 8, 11, 17, 7, 37, 288, DateTimeKind.Unspecified).AddTicks(6098) },
                    { 13, 4, "YT15300-1", 5, new DateTime(2021, 11, 30, 20, 19, 26, 659, DateTimeKind.Unspecified).AddTicks(1791), new DateTime(2021, 8, 19, 5, 26, 42, 755, DateTimeKind.Unspecified).AddTicks(8433) },
                    { 11, 4, "YT97863-0", 5, new DateTime(2021, 10, 22, 5, 56, 57, 499, DateTimeKind.Unspecified).AddTicks(6118), new DateTime(2021, 7, 18, 9, 8, 52, 735, DateTimeKind.Unspecified).AddTicks(8101) },
                    { 98, 5, "YT53994-1", 4, new DateTime(2021, 9, 25, 23, 45, 34, 308, DateTimeKind.Unspecified).AddTicks(7788), new DateTime(2021, 8, 14, 13, 53, 30, 438, DateTimeKind.Unspecified).AddTicks(379) },
                    { 58, 2, "YT37776-0", 3, new DateTime(2021, 10, 8, 3, 30, 33, 245, DateTimeKind.Unspecified).AddTicks(6648), new DateTime(2021, 8, 30, 15, 20, 19, 437, DateTimeKind.Unspecified).AddTicks(8693) },
                    { 56, 4, "YT52985-0", 3, new DateTime(2021, 10, 26, 9, 52, 23, 475, DateTimeKind.Unspecified).AddTicks(9052), new DateTime(2021, 7, 11, 6, 33, 27, 23, DateTimeKind.Unspecified).AddTicks(9266) },
                    { 51, 2, "YT97978-1", 3, new DateTime(2021, 12, 10, 19, 51, 36, 150, DateTimeKind.Unspecified).AddTicks(8786), new DateTime(2021, 5, 20, 23, 49, 38, 374, DateTimeKind.Unspecified).AddTicks(2827) },
                    { 10, 5, "YT99284-1", 2, new DateTime(2021, 12, 9, 13, 22, 55, 644, DateTimeKind.Unspecified).AddTicks(9715), new DateTime(2021, 7, 6, 18, 24, 30, 349, DateTimeKind.Unspecified).AddTicks(9715) },
                    { 4, 3, "YT20188-0", 2, new DateTime(2021, 9, 21, 4, 39, 50, 864, DateTimeKind.Unspecified).AddTicks(4352), new DateTime(2021, 6, 11, 20, 13, 51, 149, DateTimeKind.Unspecified).AddTicks(2305) },
                    { 96, 1, "YT86793-1", 1, new DateTime(2021, 9, 11, 19, 53, 13, 355, DateTimeKind.Unspecified).AddTicks(3806), new DateTime(2021, 7, 15, 20, 38, 10, 511, DateTimeKind.Unspecified).AddTicks(5429) },
                    { 87, 4, "YT15589-1", 1, new DateTime(2021, 11, 29, 15, 7, 30, 67, DateTimeKind.Unspecified).AddTicks(5500), new DateTime(2021, 6, 6, 5, 43, 30, 190, DateTimeKind.Unspecified).AddTicks(2506) },
                    { 85, 4, "YT69000-1", 1, new DateTime(2021, 11, 23, 22, 37, 39, 31, DateTimeKind.Unspecified).AddTicks(4246), new DateTime(2021, 7, 21, 9, 20, 53, 294, DateTimeKind.Unspecified).AddTicks(3242) },
                    { 78, 1, "YT63981-0", 1, new DateTime(2021, 9, 29, 7, 10, 54, 49, DateTimeKind.Unspecified).AddTicks(3177), new DateTime(2021, 6, 19, 23, 59, 38, 960, DateTimeKind.Unspecified).AddTicks(6452) },
                    { 77, 4, "YT81640-1", 1, new DateTime(2021, 12, 9, 0, 24, 50, 885, DateTimeKind.Unspecified).AddTicks(1347), new DateTime(2021, 5, 25, 6, 32, 32, 754, DateTimeKind.Unspecified).AddTicks(4161) },
                    { 76, 1, "YT71563-0", 1, new DateTime(2021, 11, 2, 21, 57, 55, 236, DateTimeKind.Unspecified).AddTicks(9906), new DateTime(2021, 8, 11, 3, 21, 57, 708, DateTimeKind.Unspecified).AddTicks(7706) },
                    { 69, 1, "YT91029-1", 1, new DateTime(2021, 10, 22, 2, 13, 49, 948, DateTimeKind.Unspecified).AddTicks(2010), new DateTime(2021, 7, 7, 19, 50, 19, 398, DateTimeKind.Unspecified).AddTicks(6093) },
                    { 54, 4, "YT75571-0", 1, new DateTime(2021, 9, 18, 14, 29, 45, 892, DateTimeKind.Unspecified).AddTicks(3827), new DateTime(2021, 8, 12, 22, 33, 11, 873, DateTimeKind.Unspecified).AddTicks(1874) },
                    { 52, 4, "YT95628-0", 1, new DateTime(2021, 12, 20, 23, 25, 52, 121, DateTimeKind.Unspecified).AddTicks(3060), new DateTime(2021, 5, 26, 6, 47, 18, 391, DateTimeKind.Unspecified).AddTicks(4555) },
                    { 50, 3, "YT81620-0", 1, new DateTime(2021, 11, 5, 18, 29, 31, 386, DateTimeKind.Unspecified).AddTicks(2789), new DateTime(2021, 8, 28, 11, 14, 6, 220, DateTimeKind.Unspecified).AddTicks(249) },
                    { 43, 5, "YT97265-0", 1, new DateTime(2021, 9, 11, 16, 39, 49, 949, DateTimeKind.Unspecified).AddTicks(1515), new DateTime(2021, 6, 23, 5, 51, 52, 452, DateTimeKind.Unspecified).AddTicks(1011) },
                    { 42, 5, "YT38232-0", 1, new DateTime(2021, 11, 17, 16, 27, 16, 796, DateTimeKind.Unspecified).AddTicks(8492), new DateTime(2021, 6, 16, 22, 17, 37, 942, DateTimeKind.Unspecified).AddTicks(5858) },
                    { 37, 2, "YT25899-0", 1, new DateTime(2021, 11, 19, 5, 6, 20, 11, DateTimeKind.Unspecified).AddTicks(5596), new DateTime(2021, 8, 1, 2, 10, 30, 401, DateTimeKind.Unspecified).AddTicks(7074) },
                    { 31, 3, "YT74036-0", 1, new DateTime(2021, 12, 20, 2, 35, 11, 15, DateTimeKind.Unspecified).AddTicks(5641), new DateTime(2021, 6, 18, 6, 31, 7, 920, DateTimeKind.Unspecified).AddTicks(7181) },
                    { 28, 5, "YT13138-0", 1, new DateTime(2021, 9, 26, 8, 5, 14, 280, DateTimeKind.Unspecified).AddTicks(3983), new DateTime(2021, 8, 5, 17, 47, 7, 872, DateTimeKind.Unspecified).AddTicks(2927) },
                    { 16, 4, "YT96661-1", 1, new DateTime(2021, 9, 27, 22, 2, 29, 621, DateTimeKind.Unspecified).AddTicks(3403), new DateTime(2021, 6, 6, 14, 14, 59, 47, DateTimeKind.Unspecified).AddTicks(3435) },
                    { 9, 4, "YT21532-0", 1, new DateTime(2021, 9, 19, 22, 14, 47, 938, DateTimeKind.Unspecified).AddTicks(2775), new DateTime(2021, 7, 8, 17, 25, 39, 660, DateTimeKind.Unspecified).AddTicks(479) },
                    { 8, 1, "YT71976-1", 1, new DateTime(2021, 9, 9, 12, 49, 0, 591, DateTimeKind.Unspecified).AddTicks(9573), new DateTime(2021, 8, 30, 8, 35, 20, 122, DateTimeKind.Unspecified).AddTicks(8673) },
                    { 2, 4, "YT65625-0", 1, new DateTime(2021, 9, 2, 0, 32, 31, 953, DateTimeKind.Unspecified).AddTicks(6460), new DateTime(2021, 8, 4, 0, 1, 17, 678, DateTimeKind.Unspecified).AddTicks(4763) },
                    { 12, 3, "YT36044-0", 2, new DateTime(2021, 11, 12, 13, 47, 10, 902, DateTimeKind.Unspecified).AddTicks(9810), new DateTime(2021, 8, 21, 15, 35, 13, 682, DateTimeKind.Unspecified).AddTicks(7879) },
                    { 14, 4, "YT24331-1", 2, new DateTime(2021, 10, 15, 4, 6, 53, 603, DateTimeKind.Unspecified).AddTicks(9460), new DateTime(2021, 6, 16, 0, 25, 12, 148, DateTimeKind.Unspecified).AddTicks(5881) },
                    { 18, 3, "YT86755-1", 2, new DateTime(2021, 11, 19, 12, 20, 6, 271, DateTimeKind.Unspecified).AddTicks(8121), new DateTime(2021, 7, 15, 19, 21, 47, 720, DateTimeKind.Unspecified).AddTicks(4656) },
                    { 25, 2, "YT85084-0", 2, new DateTime(2021, 9, 8, 1, 19, 11, 921, DateTimeKind.Unspecified).AddTicks(7230), new DateTime(2021, 6, 6, 4, 5, 56, 136, DateTimeKind.Unspecified).AddTicks(7059) },
                    { 48, 4, "YT52815-0", 3, new DateTime(2021, 10, 10, 9, 39, 23, 71, DateTimeKind.Unspecified).AddTicks(6083), new DateTime(2021, 6, 17, 16, 17, 30, 478, DateTimeKind.Unspecified).AddTicks(9268) },
                    { 38, 3, "YT63983-0", 3, new DateTime(2021, 11, 16, 4, 3, 17, 219, DateTimeKind.Unspecified).AddTicks(1610), new DateTime(2021, 8, 15, 13, 40, 39, 274, DateTimeKind.Unspecified).AddTicks(3668) },
                    { 36, 2, "YT79451-0", 3, new DateTime(2021, 12, 3, 3, 54, 11, 373, DateTimeKind.Unspecified).AddTicks(6001), new DateTime(2021, 7, 18, 12, 10, 42, 759, DateTimeKind.Unspecified).AddTicks(7205) },
                    { 34, 1, "YT46193-1", 3, new DateTime(2021, 10, 21, 23, 21, 4, 951, DateTimeKind.Unspecified).AddTicks(1475), new DateTime(2021, 6, 10, 12, 14, 0, 546, DateTimeKind.Unspecified).AddTicks(8594) },
                    { 21, 4, "YT65673-1", 3, new DateTime(2021, 12, 21, 15, 57, 7, 268, DateTimeKind.Unspecified).AddTicks(7837), new DateTime(2021, 6, 27, 16, 14, 54, 201, DateTimeKind.Unspecified).AddTicks(7619) },
                    { 7, 2, "YT94562-1", 3, new DateTime(2021, 11, 6, 19, 33, 23, 627, DateTimeKind.Unspecified).AddTicks(3733), new DateTime(2021, 6, 19, 21, 46, 48, 67, DateTimeKind.Unspecified).AddTicks(2436) },
                    { 92, 1, "YT83917-0", 2, new DateTime(2021, 10, 17, 5, 14, 20, 996, DateTimeKind.Unspecified).AddTicks(8407), new DateTime(2021, 6, 19, 15, 42, 3, 924, DateTimeKind.Unspecified).AddTicks(2161) },
                    { 89, 3, "YT92351-0", 2, new DateTime(2021, 10, 6, 12, 14, 17, 203, DateTimeKind.Unspecified).AddTicks(4981), new DateTime(2021, 8, 20, 21, 33, 18, 138, DateTimeKind.Unspecified).AddTicks(615) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 86, 2, "YT19856-0", 2, new DateTime(2021, 11, 1, 11, 26, 15, 690, DateTimeKind.Unspecified).AddTicks(2991), new DateTime(2021, 5, 9, 5, 35, 43, 842, DateTimeKind.Unspecified).AddTicks(9911) },
                    { 74, 3, "YT99632-1", 2, new DateTime(2021, 11, 11, 7, 52, 24, 339, DateTimeKind.Unspecified).AddTicks(8146), new DateTime(2021, 5, 13, 17, 10, 49, 226, DateTimeKind.Unspecified).AddTicks(8165) },
                    { 97, 4, "YT77900-1", 5, new DateTime(2021, 10, 2, 15, 23, 49, 646, DateTimeKind.Unspecified).AddTicks(9887), new DateTime(2021, 7, 2, 1, 15, 45, 117, DateTimeKind.Unspecified).AddTicks(7752) },
                    { 73, 1, "YT82750-0", 2, new DateTime(2021, 10, 30, 20, 32, 17, 451, DateTimeKind.Unspecified).AddTicks(5386), new DateTime(2021, 5, 11, 21, 57, 46, 397, DateTimeKind.Unspecified).AddTicks(1271) },
                    { 70, 1, "YT31895-1", 2, new DateTime(2021, 12, 4, 8, 6, 29, 500, DateTimeKind.Unspecified).AddTicks(3082), new DateTime(2021, 6, 3, 17, 7, 13, 156, DateTimeKind.Unspecified).AddTicks(914) },
                    { 65, 5, "YT73111-0", 2, new DateTime(2021, 9, 27, 5, 52, 38, 298, DateTimeKind.Unspecified).AddTicks(5634), new DateTime(2021, 6, 2, 3, 20, 44, 841, DateTimeKind.Unspecified).AddTicks(3324) },
                    { 59, 1, "YT62139-0", 2, new DateTime(2021, 11, 7, 9, 23, 30, 199, DateTimeKind.Unspecified).AddTicks(4881), new DateTime(2021, 8, 13, 7, 2, 18, 650, DateTimeKind.Unspecified).AddTicks(1818) },
                    { 49, 5, "YT71412-1", 2, new DateTime(2021, 11, 7, 8, 31, 23, 635, DateTimeKind.Unspecified).AddTicks(8377), new DateTime(2021, 7, 29, 9, 56, 16, 2, DateTimeKind.Unspecified).AddTicks(1436) },
                    { 47, 3, "YT79230-0", 2, new DateTime(2021, 11, 29, 17, 10, 55, 884, DateTimeKind.Unspecified).AddTicks(5957), new DateTime(2021, 6, 5, 7, 50, 52, 459, DateTimeKind.Unspecified).AddTicks(818) },
                    { 44, 1, "YT95148-0", 2, new DateTime(2021, 10, 8, 14, 37, 51, 546, DateTimeKind.Unspecified).AddTicks(3571), new DateTime(2021, 5, 12, 3, 46, 45, 60, DateTimeKind.Unspecified).AddTicks(6716) },
                    { 39, 2, "YT97821-1", 2, new DateTime(2021, 12, 15, 22, 49, 22, 194, DateTimeKind.Unspecified).AddTicks(7001), new DateTime(2021, 6, 29, 14, 10, 5, 511, DateTimeKind.Unspecified).AddTicks(3777) },
                    { 30, 5, "YT50799-0", 2, new DateTime(2021, 9, 10, 8, 54, 47, 387, DateTimeKind.Unspecified).AddTicks(2266), new DateTime(2021, 8, 9, 0, 19, 37, 743, DateTimeKind.Unspecified).AddTicks(3207) },
                    { 29, 1, "YT96993-1", 2, new DateTime(2021, 11, 20, 14, 26, 12, 93, DateTimeKind.Unspecified).AddTicks(5825), new DateTime(2021, 6, 23, 13, 59, 22, 98, DateTimeKind.Unspecified).AddTicks(1302) },
                    { 27, 2, "YT35015-0", 2, new DateTime(2021, 10, 2, 12, 57, 25, 703, DateTimeKind.Unspecified).AddTicks(1586), new DateTime(2021, 5, 10, 17, 49, 26, 757, DateTimeKind.Unspecified).AddTicks(353) },
                    { 72, 4, "YT83557-0", 2, new DateTime(2021, 12, 25, 4, 5, 5, 509, DateTimeKind.Unspecified).AddTicks(1390), new DateTime(2021, 7, 7, 20, 19, 58, 578, DateTimeKind.Unspecified).AddTicks(4588) },
                    { 99, 1, "YT46824-1", 5, new DateTime(2021, 9, 11, 16, 21, 39, 41, DateTimeKind.Unspecified).AddTicks(8515), new DateTime(2021, 7, 21, 7, 12, 23, 806, DateTimeKind.Unspecified).AddTicks(4651) }
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
