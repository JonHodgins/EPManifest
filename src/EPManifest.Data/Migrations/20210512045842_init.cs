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
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    { 5, "Whistlebend Care Home" }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 13, 3, 1, 1, new DateTime(2021, 7, 20, 3, 20, 59, 831, DateTimeKind.Local).AddTicks(2925), new DateTime(2021, 8, 24, 2, 4, 24, 169, DateTimeKind.Local).AddTicks(5096) },
                    { 76, 3, 2, 4, new DateTime(2021, 11, 28, 2, 3, 17, 149, DateTimeKind.Local).AddTicks(2763), new DateTime(2021, 12, 11, 23, 53, 13, 984, DateTimeKind.Local).AddTicks(1036) },
                    { 75, 4, 4, 4, new DateTime(2021, 7, 10, 1, 55, 11, 422, DateTimeKind.Local).AddTicks(6097), new DateTime(2021, 8, 13, 3, 17, 0, 566, DateTimeKind.Local).AddTicks(7004) },
                    { 71, 3, 4, 4, new DateTime(2021, 10, 4, 10, 7, 29, 148, DateTimeKind.Local).AddTicks(592), new DateTime(2021, 7, 11, 17, 21, 51, 788, DateTimeKind.Local).AddTicks(4298) },
                    { 67, 3, 2, 4, new DateTime(2021, 10, 30, 11, 59, 37, 437, DateTimeKind.Local).AddTicks(1461), new DateTime(2021, 9, 10, 3, 26, 7, 782, DateTimeKind.Local).AddTicks(923) },
                    { 65, 4, 1, 4, new DateTime(2021, 12, 1, 3, 6, 2, 740, DateTimeKind.Local).AddTicks(2538), new DateTime(2021, 9, 21, 5, 43, 3, 217, DateTimeKind.Local).AddTicks(6435) },
                    { 63, 4, 2, 4, new DateTime(2021, 11, 28, 21, 5, 6, 251, DateTimeKind.Local).AddTicks(4429), new DateTime(2021, 11, 16, 3, 42, 0, 467, DateTimeKind.Local).AddTicks(9830) },
                    { 49, 3, 1, 4, new DateTime(2021, 7, 28, 11, 38, 8, 149, DateTimeKind.Local).AddTicks(7242), new DateTime(2021, 12, 11, 5, 26, 51, 671, DateTimeKind.Local).AddTicks(4708) },
                    { 48, 4, 1, 4, new DateTime(2021, 12, 5, 22, 28, 54, 841, DateTimeKind.Local).AddTicks(4401), new DateTime(2021, 8, 19, 1, 15, 19, 372, DateTimeKind.Local).AddTicks(1319) },
                    { 40, 2, 2, 4, new DateTime(2021, 9, 16, 9, 51, 43, 782, DateTimeKind.Local).AddTicks(4556), new DateTime(2021, 6, 24, 0, 28, 9, 643, DateTimeKind.Local).AddTicks(156) },
                    { 36, 5, 1, 4, new DateTime(2021, 8, 6, 10, 28, 41, 820, DateTimeKind.Local).AddTicks(1673), new DateTime(2021, 6, 28, 20, 0, 58, 307, DateTimeKind.Local).AddTicks(2087) },
                    { 34, 4, 5, 4, new DateTime(2021, 5, 15, 0, 9, 3, 127, DateTimeKind.Local).AddTicks(1997), new DateTime(2021, 8, 13, 20, 39, 11, 181, DateTimeKind.Local).AddTicks(9375) },
                    { 28, 3, 5, 4, new DateTime(2021, 12, 12, 5, 14, 5, 343, DateTimeKind.Local).AddTicks(7110), new DateTime(2021, 5, 14, 4, 9, 40, 467, DateTimeKind.Local).AddTicks(7302) },
                    { 25, 2, 1, 4, new DateTime(2021, 11, 14, 22, 40, 20, 194, DateTimeKind.Local).AddTicks(1599), new DateTime(2021, 8, 24, 19, 29, 47, 318, DateTimeKind.Local).AddTicks(5745) },
                    { 18, 2, 2, 4, new DateTime(2021, 7, 27, 18, 6, 0, 164, DateTimeKind.Local).AddTicks(9097), new DateTime(2021, 5, 19, 17, 19, 56, 934, DateTimeKind.Local).AddTicks(966) },
                    { 16, 5, 3, 4, new DateTime(2021, 10, 4, 2, 58, 28, 507, DateTimeKind.Local).AddTicks(500), new DateTime(2021, 10, 25, 1, 30, 13, 156, DateTimeKind.Local).AddTicks(6304) },
                    { 12, 5, 5, 4, new DateTime(2021, 10, 10, 12, 45, 12, 532, DateTimeKind.Local).AddTicks(402), new DateTime(2021, 8, 21, 11, 53, 46, 209, DateTimeKind.Local).AddTicks(5791) },
                    { 11, 2, 3, 4, new DateTime(2021, 8, 6, 17, 30, 34, 312, DateTimeKind.Local).AddTicks(3879), new DateTime(2021, 7, 26, 22, 35, 13, 448, DateTimeKind.Local).AddTicks(1438) },
                    { 1, 5, 1, 4, new DateTime(2021, 5, 14, 21, 40, 42, 29, DateTimeKind.Local).AddTicks(5585), new DateTime(2021, 10, 4, 14, 58, 16, 385, DateTimeKind.Local).AddTicks(3899) },
                    { 94, 2, 2, 3, new DateTime(2021, 6, 30, 11, 51, 9, 896, DateTimeKind.Local).AddTicks(5296), new DateTime(2021, 8, 13, 3, 23, 19, 135, DateTimeKind.Local).AddTicks(4817) },
                    { 91, 2, 1, 3, new DateTime(2021, 9, 4, 3, 37, 52, 264, DateTimeKind.Local).AddTicks(2474), new DateTime(2021, 12, 5, 22, 2, 28, 564, DateTimeKind.Local).AddTicks(3408) },
                    { 79, 4, 4, 3, new DateTime(2021, 6, 13, 9, 21, 36, 451, DateTimeKind.Local).AddTicks(7567), new DateTime(2021, 11, 26, 5, 35, 4, 452, DateTimeKind.Local).AddTicks(4920) },
                    { 80, 3, 5, 4, new DateTime(2021, 6, 16, 3, 38, 27, 868, DateTimeKind.Local).AddTicks(225), new DateTime(2021, 9, 4, 23, 43, 43, 460, DateTimeKind.Local).AddTicks(9688) },
                    { 74, 1, 4, 3, new DateTime(2021, 9, 20, 15, 51, 19, 153, DateTimeKind.Local).AddTicks(9641), new DateTime(2021, 5, 28, 13, 41, 4, 763, DateTimeKind.Local).AddTicks(9591) },
                    { 84, 5, 1, 4, new DateTime(2021, 9, 30, 1, 41, 14, 896, DateTimeKind.Local).AddTicks(6321), new DateTime(2021, 6, 6, 0, 36, 11, 940, DateTimeKind.Local).AddTicks(562) },
                    { 88, 5, 5, 4, new DateTime(2021, 7, 28, 18, 33, 50, 372, DateTimeKind.Local).AddTicks(5433), new DateTime(2021, 11, 3, 20, 14, 1, 814, DateTimeKind.Local).AddTicks(7193) },
                    { 96, 2, 1, 5, new DateTime(2021, 5, 30, 15, 56, 23, 234, DateTimeKind.Local).AddTicks(6981), new DateTime(2021, 5, 15, 21, 57, 20, 540, DateTimeKind.Local).AddTicks(6446) },
                    { 93, 4, 1, 5, new DateTime(2021, 5, 28, 13, 23, 38, 624, DateTimeKind.Local).AddTicks(2014), new DateTime(2021, 8, 18, 17, 53, 38, 302, DateTimeKind.Local).AddTicks(1222) },
                    { 92, 5, 3, 5, new DateTime(2021, 9, 1, 22, 10, 1, 974, DateTimeKind.Local).AddTicks(3565), new DateTime(2021, 6, 15, 20, 57, 15, 896, DateTimeKind.Local).AddTicks(7405) },
                    { 87, 1, 5, 5, new DateTime(2021, 9, 28, 14, 27, 12, 876, DateTimeKind.Local).AddTicks(4856), new DateTime(2021, 11, 6, 18, 13, 27, 849, DateTimeKind.Local).AddTicks(2171) },
                    { 86, 5, 1, 5, new DateTime(2021, 9, 24, 19, 31, 43, 796, DateTimeKind.Local).AddTicks(8495), new DateTime(2021, 7, 11, 15, 54, 5, 848, DateTimeKind.Local).AddTicks(874) },
                    { 82, 1, 5, 5, new DateTime(2021, 12, 12, 11, 51, 43, 128, DateTimeKind.Local).AddTicks(1264), new DateTime(2021, 5, 13, 13, 25, 22, 98, DateTimeKind.Local).AddTicks(9601) },
                    { 78, 2, 5, 5, new DateTime(2021, 6, 24, 20, 24, 36, 592, DateTimeKind.Local).AddTicks(4022), new DateTime(2021, 12, 6, 17, 18, 38, 634, DateTimeKind.Local).AddTicks(373) },
                    { 69, 5, 5, 5, new DateTime(2021, 10, 10, 5, 49, 49, 233, DateTimeKind.Local).AddTicks(5433), new DateTime(2021, 5, 28, 10, 39, 20, 34, DateTimeKind.Local).AddTicks(8718) },
                    { 62, 3, 2, 5, new DateTime(2021, 6, 30, 12, 47, 53, 358, DateTimeKind.Local).AddTicks(575), new DateTime(2021, 8, 18, 21, 8, 22, 834, DateTimeKind.Local).AddTicks(6274) },
                    { 57, 2, 1, 5, new DateTime(2021, 7, 17, 13, 4, 0, 733, DateTimeKind.Local).AddTicks(1597), new DateTime(2021, 10, 7, 20, 1, 32, 406, DateTimeKind.Local).AddTicks(4221) },
                    { 55, 4, 1, 5, new DateTime(2021, 5, 26, 4, 9, 34, 240, DateTimeKind.Local).AddTicks(757), new DateTime(2021, 12, 16, 11, 31, 38, 326, DateTimeKind.Local).AddTicks(5660) },
                    { 51, 3, 1, 5, new DateTime(2021, 8, 7, 6, 39, 24, 598, DateTimeKind.Local).AddTicks(401), new DateTime(2021, 9, 2, 3, 19, 15, 341, DateTimeKind.Local).AddTicks(6126) },
                    { 50, 3, 3, 5, new DateTime(2021, 8, 10, 7, 38, 15, 671, DateTimeKind.Local).AddTicks(2537), new DateTime(2021, 12, 21, 13, 22, 48, 222, DateTimeKind.Local).AddTicks(2296) },
                    { 44, 2, 5, 5, new DateTime(2021, 10, 21, 21, 8, 54, 301, DateTimeKind.Local).AddTicks(4140), new DateTime(2021, 11, 21, 10, 0, 33, 168, DateTimeKind.Local).AddTicks(43) },
                    { 43, 3, 5, 5, new DateTime(2021, 12, 25, 14, 13, 31, 363, DateTimeKind.Local).AddTicks(7562), new DateTime(2021, 12, 1, 13, 31, 32, 606, DateTimeKind.Local).AddTicks(4929) },
                    { 42, 3, 5, 5, new DateTime(2021, 11, 28, 4, 44, 39, 597, DateTimeKind.Local).AddTicks(383), new DateTime(2021, 8, 2, 1, 47, 36, 845, DateTimeKind.Local).AddTicks(7334) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 39, 2, 1, 5, new DateTime(2021, 7, 25, 15, 52, 51, 969, DateTimeKind.Local).AddTicks(3709), new DateTime(2021, 12, 16, 3, 36, 19, 585, DateTimeKind.Local).AddTicks(9850) },
                    { 31, 5, 1, 5, new DateTime(2021, 10, 1, 4, 39, 7, 49, DateTimeKind.Local).AddTicks(156), new DateTime(2021, 7, 18, 18, 38, 18, 753, DateTimeKind.Local).AddTicks(8848) },
                    { 17, 4, 1, 5, new DateTime(2021, 6, 22, 21, 15, 2, 244, DateTimeKind.Local).AddTicks(8409), new DateTime(2021, 7, 12, 7, 37, 51, 356, DateTimeKind.Local).AddTicks(9748) },
                    { 14, 2, 2, 5, new DateTime(2021, 7, 14, 9, 49, 28, 813, DateTimeKind.Local).AddTicks(8180), new DateTime(2021, 11, 9, 15, 37, 5, 750, DateTimeKind.Local).AddTicks(4726) },
                    { 95, 1, 2, 4, new DateTime(2021, 9, 22, 8, 12, 35, 3, DateTimeKind.Local).AddTicks(7638), new DateTime(2021, 11, 8, 6, 2, 21, 567, DateTimeKind.Local).AddTicks(5205) },
                    { 85, 2, 3, 4, new DateTime(2021, 6, 18, 5, 4, 27, 277, DateTimeKind.Local).AddTicks(4562), new DateTime(2021, 12, 3, 17, 16, 28, 171, DateTimeKind.Local).AddTicks(5657) },
                    { 72, 5, 5, 3, new DateTime(2021, 7, 11, 12, 51, 25, 40, DateTimeKind.Local).AddTicks(2864), new DateTime(2021, 11, 27, 21, 55, 7, 428, DateTimeKind.Local).AddTicks(939) },
                    { 61, 3, 3, 3, new DateTime(2021, 9, 11, 23, 33, 44, 646, DateTimeKind.Local).AddTicks(7761), new DateTime(2021, 10, 29, 1, 1, 10, 168, DateTimeKind.Local).AddTicks(3447) },
                    { 52, 3, 2, 3, new DateTime(2021, 10, 19, 6, 14, 34, 258, DateTimeKind.Local).AddTicks(8301), new DateTime(2021, 6, 10, 8, 59, 8, 443, DateTimeKind.Local).AddTicks(6575) },
                    { 35, 1, 5, 2, new DateTime(2021, 12, 16, 16, 50, 41, 908, DateTimeKind.Local).AddTicks(1619), new DateTime(2021, 7, 31, 21, 33, 58, 313, DateTimeKind.Local).AddTicks(9840) },
                    { 22, 2, 1, 2, new DateTime(2021, 10, 15, 12, 24, 9, 982, DateTimeKind.Local).AddTicks(4806), new DateTime(2021, 7, 26, 12, 14, 2, 613, DateTimeKind.Local).AddTicks(49) },
                    { 21, 2, 1, 2, new DateTime(2021, 7, 10, 1, 26, 52, 622, DateTimeKind.Local).AddTicks(2719), new DateTime(2021, 5, 22, 22, 40, 34, 620, DateTimeKind.Local).AddTicks(7925) },
                    { 20, 1, 2, 2, new DateTime(2021, 7, 27, 8, 38, 16, 572, DateTimeKind.Local).AddTicks(1297), new DateTime(2021, 11, 18, 5, 22, 44, 870, DateTimeKind.Local).AddTicks(6133) },
                    { 15, 2, 3, 2, new DateTime(2021, 5, 12, 8, 19, 52, 568, DateTimeKind.Local).AddTicks(1452), new DateTime(2021, 5, 21, 15, 51, 47, 127, DateTimeKind.Local).AddTicks(3125) },
                    { 7, 3, 3, 2, new DateTime(2021, 12, 15, 3, 14, 30, 382, DateTimeKind.Local).AddTicks(7575), new DateTime(2021, 8, 14, 12, 51, 49, 513, DateTimeKind.Local).AddTicks(4816) },
                    { 6, 5, 1, 2, new DateTime(2021, 12, 10, 8, 30, 38, 160, DateTimeKind.Local).AddTicks(8027), new DateTime(2021, 12, 7, 19, 27, 4, 7, DateTimeKind.Local).AddTicks(3144) },
                    { 5, 1, 1, 2, new DateTime(2021, 6, 25, 1, 3, 11, 909, DateTimeKind.Local).AddTicks(7247), new DateTime(2021, 12, 29, 13, 24, 39, 760, DateTimeKind.Local).AddTicks(1115) },
                    { 2, 2, 1, 2, new DateTime(2021, 10, 10, 17, 30, 45, 363, DateTimeKind.Local).AddTicks(8552), new DateTime(2021, 8, 3, 10, 35, 2, 330, DateTimeKind.Local).AddTicks(2739) },
                    { 90, 4, 4, 1, new DateTime(2021, 9, 8, 4, 17, 45, 736, DateTimeKind.Local).AddTicks(7981), new DateTime(2021, 12, 23, 16, 19, 53, 392, DateTimeKind.Local).AddTicks(2594) },
                    { 89, 2, 4, 1, new DateTime(2021, 11, 29, 17, 17, 49, 364, DateTimeKind.Local).AddTicks(772), new DateTime(2021, 12, 25, 5, 26, 55, 505, DateTimeKind.Local).AddTicks(9117) },
                    { 70, 4, 5, 1, new DateTime(2021, 6, 25, 17, 12, 16, 804, DateTimeKind.Local).AddTicks(7335), new DateTime(2021, 12, 1, 21, 55, 38, 861, DateTimeKind.Local).AddTicks(8770) },
                    { 60, 2, 3, 1, new DateTime(2021, 7, 11, 7, 1, 45, 481, DateTimeKind.Local).AddTicks(2895), new DateTime(2021, 8, 25, 15, 38, 38, 136, DateTimeKind.Local).AddTicks(16) },
                    { 56, 1, 4, 1, new DateTime(2021, 7, 25, 5, 17, 7, 975, DateTimeKind.Local).AddTicks(6876), new DateTime(2021, 11, 9, 12, 29, 11, 530, DateTimeKind.Local).AddTicks(2671) },
                    { 54, 5, 2, 1, new DateTime(2021, 7, 4, 10, 20, 19, 786, DateTimeKind.Local).AddTicks(9588), new DateTime(2021, 5, 14, 21, 15, 37, 114, DateTimeKind.Local).AddTicks(1298) },
                    { 45, 5, 1, 1, new DateTime(2021, 6, 20, 18, 45, 0, 187, DateTimeKind.Local).AddTicks(6077), new DateTime(2021, 6, 7, 0, 7, 19, 679, DateTimeKind.Local).AddTicks(9833) },
                    { 37, 1, 4, 1, new DateTime(2021, 11, 20, 23, 31, 14, 616, DateTimeKind.Local).AddTicks(9261), new DateTime(2021, 8, 10, 11, 34, 56, 430, DateTimeKind.Local).AddTicks(8461) },
                    { 32, 4, 5, 1, new DateTime(2021, 5, 29, 0, 33, 20, 881, DateTimeKind.Local).AddTicks(7517), new DateTime(2021, 7, 8, 0, 0, 14, 426, DateTimeKind.Local).AddTicks(6543) },
                    { 26, 2, 4, 1, new DateTime(2021, 10, 14, 2, 42, 14, 828, DateTimeKind.Local).AddTicks(917), new DateTime(2021, 10, 11, 20, 3, 1, 222, DateTimeKind.Local).AddTicks(3961) },
                    { 24, 1, 3, 1, new DateTime(2021, 9, 11, 8, 43, 7, 849, DateTimeKind.Local).AddTicks(7558), new DateTime(2021, 7, 13, 2, 48, 3, 657, DateTimeKind.Local).AddTicks(6843) },
                    { 23, 1, 1, 1, new DateTime(2021, 11, 2, 21, 45, 52, 25, DateTimeKind.Local).AddTicks(7051), new DateTime(2021, 11, 17, 8, 55, 17, 702, DateTimeKind.Local).AddTicks(5359) },
                    { 46, 2, 3, 2, new DateTime(2021, 6, 27, 16, 38, 54, 813, DateTimeKind.Local).AddTicks(5484), new DateTime(2021, 5, 18, 3, 39, 48, 77, DateTimeKind.Local).AddTicks(6657) },
                    { 47, 4, 5, 2, new DateTime(2021, 11, 28, 14, 14, 37, 225, DateTimeKind.Local).AddTicks(4261), new DateTime(2021, 10, 12, 10, 9, 14, 524, DateTimeKind.Local).AddTicks(7611) },
                    { 53, 3, 3, 2, new DateTime(2021, 8, 27, 11, 46, 55, 268, DateTimeKind.Local).AddTicks(5532), new DateTime(2021, 6, 16, 7, 7, 23, 765, DateTimeKind.Local).AddTicks(2481) },
                    { 58, 2, 3, 2, new DateTime(2021, 8, 23, 15, 32, 33, 896, DateTimeKind.Local).AddTicks(5265), new DateTime(2021, 7, 17, 1, 28, 31, 659, DateTimeKind.Local).AddTicks(7892) },
                    { 41, 3, 2, 3, new DateTime(2021, 12, 22, 10, 19, 37, 58, DateTimeKind.Local).AddTicks(7234), new DateTime(2021, 7, 20, 5, 45, 26, 898, DateTimeKind.Local).AddTicks(2029) },
                    { 38, 5, 3, 3, new DateTime(2021, 7, 18, 18, 30, 33, 235, DateTimeKind.Local).AddTicks(39), new DateTime(2021, 11, 8, 10, 11, 31, 268, DateTimeKind.Local).AddTicks(5069) },
                    { 33, 4, 5, 3, new DateTime(2021, 6, 22, 2, 26, 19, 41, DateTimeKind.Local).AddTicks(6606), new DateTime(2021, 10, 12, 9, 31, 47, 784, DateTimeKind.Local).AddTicks(9268) },
                    { 30, 5, 1, 3, new DateTime(2021, 7, 13, 6, 26, 46, 524, DateTimeKind.Local).AddTicks(5843), new DateTime(2021, 7, 23, 7, 55, 48, 292, DateTimeKind.Local).AddTicks(3598) },
                    { 29, 5, 5, 3, new DateTime(2021, 7, 7, 21, 27, 30, 744, DateTimeKind.Local).AddTicks(4016), new DateTime(2021, 8, 4, 4, 55, 46, 951, DateTimeKind.Local).AddTicks(6339) },
                    { 27, 1, 2, 3, new DateTime(2021, 8, 15, 10, 14, 48, 253, DateTimeKind.Local).AddTicks(6273), new DateTime(2021, 8, 9, 14, 50, 38, 317, DateTimeKind.Local).AddTicks(5167) },
                    { 19, 5, 2, 3, new DateTime(2021, 8, 9, 19, 48, 45, 904, DateTimeKind.Local).AddTicks(9286), new DateTime(2021, 5, 26, 5, 41, 40, 318, DateTimeKind.Local).AddTicks(439) },
                    { 10, 1, 3, 3, new DateTime(2021, 10, 7, 9, 47, 54, 383, DateTimeKind.Local).AddTicks(3357), new DateTime(2021, 7, 25, 10, 31, 21, 701, DateTimeKind.Local).AddTicks(6030) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 9, 3, 4, 3, new DateTime(2021, 7, 16, 9, 53, 8, 336, DateTimeKind.Local).AddTicks(4709), new DateTime(2021, 6, 7, 8, 43, 44, 701, DateTimeKind.Local).AddTicks(8986) },
                    { 8, 2, 1, 3, new DateTime(2021, 9, 17, 19, 5, 29, 232, DateTimeKind.Local).AddTicks(9544), new DateTime(2021, 10, 24, 20, 28, 11, 117, DateTimeKind.Local).AddTicks(820) },
                    { 98, 1, 3, 5, new DateTime(2021, 11, 5, 18, 56, 9, 839, DateTimeKind.Local).AddTicks(5909), new DateTime(2021, 7, 14, 12, 34, 17, 318, DateTimeKind.Local).AddTicks(1268) },
                    { 4, 1, 4, 3, new DateTime(2021, 8, 31, 21, 26, 34, 352, DateTimeKind.Local).AddTicks(897), new DateTime(2021, 9, 27, 12, 58, 34, 627, DateTimeKind.Local).AddTicks(2520) },
                    { 99, 4, 1, 2, new DateTime(2021, 8, 22, 14, 59, 46, 678, DateTimeKind.Local).AddTicks(2017), new DateTime(2021, 7, 13, 20, 2, 41, 573, DateTimeKind.Local).AddTicks(5216) },
                    { 97, 5, 2, 2, new DateTime(2021, 12, 29, 13, 46, 22, 567, DateTimeKind.Local).AddTicks(8130), new DateTime(2021, 11, 2, 11, 36, 20, 111, DateTimeKind.Local).AddTicks(2962) },
                    { 83, 5, 2, 2, new DateTime(2021, 12, 3, 13, 15, 11, 60, DateTimeKind.Local).AddTicks(2338), new DateTime(2021, 12, 30, 19, 51, 50, 278, DateTimeKind.Local).AddTicks(8185) },
                    { 81, 4, 4, 2, new DateTime(2021, 9, 1, 18, 45, 10, 338, DateTimeKind.Local).AddTicks(2667), new DateTime(2021, 7, 23, 4, 3, 1, 441, DateTimeKind.Local).AddTicks(441) },
                    { 77, 1, 4, 2, new DateTime(2021, 7, 19, 21, 42, 4, 371, DateTimeKind.Local).AddTicks(166), new DateTime(2021, 7, 6, 14, 59, 12, 152, DateTimeKind.Local).AddTicks(9773) },
                    { 73, 1, 2, 2, new DateTime(2021, 9, 22, 10, 55, 36, 573, DateTimeKind.Local).AddTicks(9147), new DateTime(2021, 8, 14, 0, 19, 34, 577, DateTimeKind.Local).AddTicks(9321) },
                    { 68, 3, 4, 2, new DateTime(2021, 8, 28, 12, 45, 4, 198, DateTimeKind.Local).AddTicks(5187), new DateTime(2021, 6, 6, 18, 26, 29, 492, DateTimeKind.Local).AddTicks(7713) },
                    { 66, 1, 3, 2, new DateTime(2021, 5, 16, 18, 47, 29, 989, DateTimeKind.Local).AddTicks(8153), new DateTime(2021, 8, 20, 10, 12, 47, 224, DateTimeKind.Local).AddTicks(5835) },
                    { 64, 5, 2, 2, new DateTime(2021, 6, 25, 20, 15, 28, 80, DateTimeKind.Local).AddTicks(6901), new DateTime(2021, 11, 29, 18, 3, 23, 32, DateTimeKind.Local).AddTicks(989) },
                    { 59, 4, 3, 2, new DateTime(2021, 9, 6, 23, 17, 32, 835, DateTimeKind.Local).AddTicks(908), new DateTime(2021, 10, 30, 19, 0, 45, 113, DateTimeKind.Local).AddTicks(3171) },
                    { 3, 4, 5, 3, new DateTime(2021, 10, 25, 16, 24, 2, 84, DateTimeKind.Local).AddTicks(1093), new DateTime(2021, 10, 24, 18, 51, 36, 133, DateTimeKind.Local).AddTicks(2135) },
                    { 100, 5, 5, 5, new DateTime(2021, 8, 4, 5, 39, 21, 185, DateTimeKind.Local).AddTicks(2374), new DateTime(2021, 12, 8, 14, 1, 58, 614, DateTimeKind.Local).AddTicks(8630) }
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
