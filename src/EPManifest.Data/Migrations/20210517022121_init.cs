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
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 4, 2, 1, new DateTime(2021, 9, 6, 7, 59, 13, 160, DateTimeKind.Unspecified).AddTicks(877), new DateTime(2021, 7, 25, 19, 13, 7, 169, DateTimeKind.Unspecified).AddTicks(8791) },
                    { 75, 3, 4, new DateTime(2021, 12, 24, 3, 46, 38, 832, DateTimeKind.Unspecified).AddTicks(4214), new DateTime(2021, 7, 13, 6, 2, 9, 322, DateTimeKind.Unspecified).AddTicks(2216) },
                    { 64, 2, 4, new DateTime(2021, 11, 3, 7, 4, 28, 527, DateTimeKind.Unspecified).AddTicks(3289), new DateTime(2021, 6, 25, 16, 35, 11, 907, DateTimeKind.Unspecified).AddTicks(4489) },
                    { 56, 4, 4, new DateTime(2021, 11, 2, 9, 35, 5, 52, DateTimeKind.Unspecified).AddTicks(462), new DateTime(2021, 5, 30, 19, 55, 12, 21, DateTimeKind.Unspecified).AddTicks(4841) },
                    { 52, 3, 4, new DateTime(2021, 9, 27, 6, 44, 46, 30, DateTimeKind.Unspecified).AddTicks(5840), new DateTime(2021, 8, 7, 20, 43, 35, 584, DateTimeKind.Unspecified).AddTicks(7748) },
                    { 50, 1, 4, new DateTime(2021, 9, 22, 12, 59, 49, 287, DateTimeKind.Unspecified).AddTicks(8557), new DateTime(2021, 7, 25, 10, 6, 39, 355, DateTimeKind.Unspecified).AddTicks(5522) },
                    { 49, 2, 4, new DateTime(2021, 9, 27, 5, 1, 22, 573, DateTimeKind.Unspecified).AddTicks(6234), new DateTime(2021, 7, 4, 6, 38, 17, 453, DateTimeKind.Unspecified).AddTicks(93) },
                    { 41, 5, 4, new DateTime(2021, 12, 25, 12, 29, 47, 626, DateTimeKind.Unspecified).AddTicks(1727), new DateTime(2021, 7, 20, 22, 40, 4, 748, DateTimeKind.Unspecified).AddTicks(4778) },
                    { 31, 3, 4, new DateTime(2021, 9, 16, 3, 19, 30, 804, DateTimeKind.Unspecified).AddTicks(9606), new DateTime(2021, 8, 18, 17, 27, 38, 223, DateTimeKind.Unspecified).AddTicks(9995) },
                    { 14, 1, 4, new DateTime(2021, 11, 24, 13, 47, 49, 411, DateTimeKind.Unspecified).AddTicks(3620), new DateTime(2021, 6, 13, 18, 9, 41, 356, DateTimeKind.Unspecified).AddTicks(4426) },
                    { 6, 4, 4, new DateTime(2021, 11, 4, 22, 21, 40, 544, DateTimeKind.Unspecified).AddTicks(1668), new DateTime(2021, 8, 2, 10, 27, 32, 445, DateTimeKind.Unspecified).AddTicks(746) },
                    { 3, 5, 4, new DateTime(2021, 12, 20, 16, 17, 2, 135, DateTimeKind.Unspecified).AddTicks(4072), new DateTime(2021, 5, 23, 8, 57, 42, 409, DateTimeKind.Unspecified).AddTicks(2103) },
                    { 99, 2, 3, new DateTime(2021, 11, 5, 9, 9, 58, 130, DateTimeKind.Unspecified).AddTicks(9091), new DateTime(2021, 7, 15, 18, 57, 57, 87, DateTimeKind.Unspecified).AddTicks(5086) },
                    { 97, 5, 3, new DateTime(2021, 10, 21, 4, 34, 32, 716, DateTimeKind.Unspecified).AddTicks(8950), new DateTime(2021, 7, 16, 13, 17, 14, 219, DateTimeKind.Unspecified).AddTicks(8267) },
                    { 92, 4, 3, new DateTime(2021, 9, 2, 1, 18, 46, 234, DateTimeKind.Unspecified).AddTicks(1939), new DateTime(2021, 5, 27, 22, 56, 7, 150, DateTimeKind.Unspecified).AddTicks(7415) },
                    { 58, 5, 3, new DateTime(2021, 9, 28, 17, 23, 0, 515, DateTimeKind.Unspecified).AddTicks(6284), new DateTime(2021, 8, 3, 7, 38, 42, 923, DateTimeKind.Unspecified).AddTicks(1873) },
                    { 47, 1, 3, new DateTime(2021, 11, 24, 11, 14, 21, 95, DateTimeKind.Unspecified).AddTicks(9852), new DateTime(2021, 7, 15, 9, 12, 10, 330, DateTimeKind.Unspecified).AddTicks(8358) },
                    { 42, 2, 3, new DateTime(2021, 9, 1, 17, 0, 10, 260, DateTimeKind.Unspecified).AddTicks(547), new DateTime(2021, 7, 1, 20, 39, 12, 829, DateTimeKind.Unspecified).AddTicks(1691) },
                    { 37, 4, 3, new DateTime(2021, 10, 21, 1, 28, 49, 293, DateTimeKind.Unspecified).AddTicks(1641), new DateTime(2021, 7, 13, 2, 11, 19, 515, DateTimeKind.Unspecified).AddTicks(4221) },
                    { 33, 1, 3, new DateTime(2021, 12, 18, 3, 0, 0, 324, DateTimeKind.Unspecified).AddTicks(8071), new DateTime(2021, 8, 10, 10, 54, 54, 293, DateTimeKind.Unspecified).AddTicks(1001) },
                    { 23, 4, 3, new DateTime(2021, 12, 6, 6, 19, 27, 112, DateTimeKind.Unspecified).AddTicks(8111), new DateTime(2021, 6, 3, 12, 17, 13, 789, DateTimeKind.Unspecified).AddTicks(7864) },
                    { 21, 1, 3, new DateTime(2021, 12, 19, 3, 33, 54, 853, DateTimeKind.Unspecified).AddTicks(203), new DateTime(2021, 7, 27, 19, 27, 37, 701, DateTimeKind.Unspecified).AddTicks(1062) },
                    { 80, 5, 4, new DateTime(2021, 9, 22, 20, 18, 38, 292, DateTimeKind.Unspecified).AddTicks(3121), new DateTime(2021, 6, 13, 14, 1, 41, 205, DateTimeKind.Unspecified).AddTicks(2011) },
                    { 20, 3, 3, new DateTime(2021, 12, 13, 14, 42, 58, 956, DateTimeKind.Unspecified).AddTicks(5184), new DateTime(2021, 6, 15, 2, 6, 40, 336, DateTimeKind.Unspecified).AddTicks(5299) },
                    { 81, 2, 4, new DateTime(2021, 10, 3, 4, 35, 28, 692, DateTimeKind.Unspecified).AddTicks(7330), new DateTime(2021, 7, 26, 3, 12, 14, 904, DateTimeKind.Unspecified).AddTicks(1262) },
                    { 88, 4, 4, new DateTime(2021, 12, 9, 1, 23, 49, 995, DateTimeKind.Unspecified).AddTicks(4512), new DateTime(2021, 6, 25, 9, 4, 15, 110, DateTimeKind.Unspecified).AddTicks(5204) },
                    { 84, 2, 5, new DateTime(2021, 9, 22, 10, 26, 9, 395, DateTimeKind.Unspecified).AddTicks(8770), new DateTime(2021, 5, 25, 20, 57, 24, 678, DateTimeKind.Unspecified).AddTicks(7694) },
                    { 82, 4, 5, new DateTime(2021, 9, 8, 4, 23, 49, 483, DateTimeKind.Unspecified).AddTicks(4494), new DateTime(2021, 7, 29, 15, 31, 50, 928, DateTimeKind.Unspecified).AddTicks(5466) },
                    { 76, 5, 5, new DateTime(2021, 12, 22, 13, 36, 40, 842, DateTimeKind.Unspecified).AddTicks(6686), new DateTime(2021, 8, 26, 7, 11, 4, 538, DateTimeKind.Unspecified).AddTicks(2569) },
                    { 74, 5, 5, new DateTime(2021, 9, 20, 20, 15, 20, 236, DateTimeKind.Unspecified).AddTicks(3756), new DateTime(2021, 5, 25, 15, 20, 39, 952, DateTimeKind.Unspecified).AddTicks(3024) },
                    { 73, 3, 5, new DateTime(2021, 9, 14, 13, 20, 57, 319, DateTimeKind.Unspecified).AddTicks(5219), new DateTime(2021, 6, 21, 12, 6, 11, 821, DateTimeKind.Unspecified).AddTicks(9021) },
                    { 72, 1, 5, new DateTime(2021, 11, 27, 8, 58, 44, 608, DateTimeKind.Unspecified).AddTicks(3902), new DateTime(2021, 6, 29, 15, 4, 38, 822, DateTimeKind.Unspecified).AddTicks(5322) },
                    { 71, 3, 5, new DateTime(2021, 11, 25, 16, 40, 31, 269, DateTimeKind.Unspecified).AddTicks(7079), new DateTime(2021, 6, 25, 5, 11, 46, 424, DateTimeKind.Unspecified).AddTicks(1526) },
                    { 69, 2, 5, new DateTime(2021, 10, 16, 15, 21, 21, 311, DateTimeKind.Unspecified).AddTicks(2010), new DateTime(2021, 5, 8, 2, 17, 12, 76, DateTimeKind.Unspecified).AddTicks(8573) },
                    { 68, 2, 5, new DateTime(2021, 11, 19, 3, 6, 19, 944, DateTimeKind.Unspecified).AddTicks(5145), new DateTime(2021, 8, 7, 6, 58, 20, 948, DateTimeKind.Unspecified).AddTicks(712) },
                    { 60, 3, 5, new DateTime(2021, 9, 22, 5, 16, 58, 144, DateTimeKind.Unspecified).AddTicks(5300), new DateTime(2021, 5, 11, 17, 58, 44, 529, DateTimeKind.Unspecified).AddTicks(253) },
                    { 57, 3, 5, new DateTime(2021, 11, 16, 23, 34, 36, 953, DateTimeKind.Unspecified).AddTicks(2614), new DateTime(2021, 6, 20, 15, 29, 21, 616, DateTimeKind.Unspecified).AddTicks(2604) },
                    { 48, 4, 5, new DateTime(2021, 11, 12, 16, 57, 25, 184, DateTimeKind.Unspecified).AddTicks(1445), new DateTime(2021, 8, 23, 3, 58, 44, 553, DateTimeKind.Unspecified).AddTicks(4099) },
                    { 44, 1, 5, new DateTime(2021, 10, 20, 21, 38, 12, 746, DateTimeKind.Unspecified).AddTicks(8037), new DateTime(2021, 5, 27, 22, 9, 19, 315, DateTimeKind.Unspecified).AddTicks(2358) },
                    { 40, 4, 5, new DateTime(2021, 10, 15, 18, 52, 16, 273, DateTimeKind.Unspecified).AddTicks(7063), new DateTime(2021, 6, 19, 15, 50, 33, 974, DateTimeKind.Unspecified).AddTicks(5579) },
                    { 34, 2, 5, new DateTime(2021, 11, 30, 14, 16, 23, 856, DateTimeKind.Unspecified).AddTicks(3786), new DateTime(2021, 7, 6, 18, 26, 14, 143, DateTimeKind.Unspecified).AddTicks(2126) },
                    { 18, 3, 5, new DateTime(2021, 11, 11, 8, 24, 12, 770, DateTimeKind.Unspecified).AddTicks(3814), new DateTime(2021, 7, 27, 2, 11, 33, 868, DateTimeKind.Unspecified).AddTicks(6735) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 13, 5, 5, new DateTime(2021, 9, 9, 10, 5, 55, 72, DateTimeKind.Unspecified).AddTicks(4691), new DateTime(2021, 8, 2, 1, 18, 31, 455, DateTimeKind.Unspecified).AddTicks(5575) },
                    { 11, 4, 5, new DateTime(2021, 9, 21, 9, 57, 32, 109, DateTimeKind.Unspecified).AddTicks(3953), new DateTime(2021, 5, 27, 3, 30, 3, 635, DateTimeKind.Unspecified).AddTicks(4049) },
                    { 8, 1, 5, new DateTime(2021, 9, 6, 9, 5, 1, 336, DateTimeKind.Unspecified).AddTicks(3007), new DateTime(2021, 6, 11, 5, 18, 46, 977, DateTimeKind.Unspecified).AddTicks(2127) },
                    { 7, 3, 5, new DateTime(2021, 11, 22, 17, 52, 4, 495, DateTimeKind.Unspecified).AddTicks(8700), new DateTime(2021, 8, 14, 1, 25, 25, 267, DateTimeKind.Unspecified).AddTicks(6764) },
                    { 91, 4, 4, new DateTime(2021, 11, 2, 12, 54, 40, 365, DateTimeKind.Unspecified).AddTicks(1296), new DateTime(2021, 7, 6, 19, 5, 9, 623, DateTimeKind.Unspecified).AddTicks(22) },
                    { 85, 3, 4, new DateTime(2021, 10, 13, 19, 42, 50, 139, DateTimeKind.Unspecified).AddTicks(2072), new DateTime(2021, 7, 19, 1, 20, 36, 568, DateTimeKind.Unspecified).AddTicks(2565) },
                    { 17, 1, 3, new DateTime(2021, 10, 7, 13, 39, 5, 773, DateTimeKind.Unspecified).AddTicks(6468), new DateTime(2021, 7, 24, 1, 33, 31, 183, DateTimeKind.Unspecified).AddTicks(2466) },
                    { 16, 5, 3, new DateTime(2021, 11, 13, 1, 56, 58, 518, DateTimeKind.Unspecified).AddTicks(4020), new DateTime(2021, 6, 26, 11, 23, 39, 662, DateTimeKind.Unspecified).AddTicks(9417) },
                    { 2, 2, 3, new DateTime(2021, 10, 7, 6, 25, 10, 930, DateTimeKind.Unspecified).AddTicks(7412), new DateTime(2021, 7, 25, 1, 55, 58, 261, DateTimeKind.Unspecified).AddTicks(3560) },
                    { 9, 4, 2, new DateTime(2021, 10, 3, 1, 10, 11, 227, DateTimeKind.Unspecified).AddTicks(2908), new DateTime(2021, 6, 30, 22, 46, 59, 689, DateTimeKind.Unspecified).AddTicks(4983) },
                    { 5, 5, 2, new DateTime(2021, 12, 8, 8, 33, 19, 962, DateTimeKind.Unspecified).AddTicks(6661), new DateTime(2021, 6, 4, 4, 58, 51, 408, DateTimeKind.Unspecified).AddTicks(9233) },
                    { 1, 4, 2, new DateTime(2021, 10, 21, 20, 45, 58, 969, DateTimeKind.Unspecified).AddTicks(7545), new DateTime(2021, 5, 18, 4, 46, 20, 164, DateTimeKind.Unspecified).AddTicks(5165) },
                    { 90, 4, 1, new DateTime(2021, 10, 19, 9, 10, 13, 463, DateTimeKind.Unspecified).AddTicks(3546), new DateTime(2021, 5, 11, 12, 37, 56, 131, DateTimeKind.Unspecified).AddTicks(9119) },
                    { 89, 2, 1, new DateTime(2021, 11, 16, 11, 59, 36, 402, DateTimeKind.Unspecified).AddTicks(4816), new DateTime(2021, 5, 25, 18, 35, 26, 132, DateTimeKind.Unspecified).AddTicks(9366) },
                    { 83, 5, 1, new DateTime(2021, 11, 28, 23, 20, 13, 864, DateTimeKind.Unspecified).AddTicks(3999), new DateTime(2021, 7, 19, 19, 45, 53, 601, DateTimeKind.Unspecified).AddTicks(6602) },
                    { 77, 3, 1, new DateTime(2021, 11, 8, 20, 28, 1, 964, DateTimeKind.Unspecified).AddTicks(8937), new DateTime(2021, 8, 6, 12, 43, 47, 494, DateTimeKind.Unspecified).AddTicks(7618) },
                    { 70, 2, 1, new DateTime(2021, 9, 6, 17, 15, 15, 636, DateTimeKind.Unspecified).AddTicks(5967), new DateTime(2021, 6, 14, 10, 59, 45, 736, DateTimeKind.Unspecified).AddTicks(2589) },
                    { 66, 1, 1, new DateTime(2021, 9, 18, 17, 10, 56, 283, DateTimeKind.Unspecified).AddTicks(5877), new DateTime(2021, 7, 19, 20, 27, 27, 202, DateTimeKind.Unspecified).AddTicks(7004) },
                    { 62, 5, 1, new DateTime(2021, 12, 8, 2, 20, 7, 41, DateTimeKind.Unspecified).AddTicks(7905), new DateTime(2021, 7, 4, 2, 35, 30, 541, DateTimeKind.Unspecified).AddTicks(4690) },
                    { 59, 3, 1, new DateTime(2021, 12, 1, 15, 16, 0, 672, DateTimeKind.Unspecified).AddTicks(2641), new DateTime(2021, 5, 20, 11, 52, 27, 782, DateTimeKind.Unspecified).AddTicks(2756) },
                    { 55, 5, 1, new DateTime(2021, 10, 10, 14, 50, 25, 605, DateTimeKind.Unspecified).AddTicks(3533), new DateTime(2021, 6, 20, 10, 48, 51, 259, DateTimeKind.Unspecified).AddTicks(7441) },
                    { 54, 5, 1, new DateTime(2021, 11, 15, 7, 58, 8, 746, DateTimeKind.Unspecified).AddTicks(4359), new DateTime(2021, 5, 13, 1, 19, 49, 691, DateTimeKind.Unspecified).AddTicks(7857) },
                    { 53, 5, 1, new DateTime(2021, 9, 8, 1, 20, 57, 766, DateTimeKind.Unspecified).AddTicks(3310), new DateTime(2021, 7, 1, 16, 47, 48, 598, DateTimeKind.Unspecified).AddTicks(8991) },
                    { 43, 5, 1, new DateTime(2021, 9, 19, 5, 1, 58, 675, DateTimeKind.Unspecified).AddTicks(7008), new DateTime(2021, 5, 17, 23, 18, 45, 422, DateTimeKind.Unspecified).AddTicks(3931) },
                    { 36, 2, 1, new DateTime(2021, 9, 17, 7, 20, 19, 267, DateTimeKind.Unspecified).AddTicks(528), new DateTime(2021, 5, 19, 23, 8, 36, 373, DateTimeKind.Unspecified).AddTicks(6344) },
                    { 32, 5, 1, new DateTime(2021, 9, 16, 7, 45, 53, 481, DateTimeKind.Unspecified).AddTicks(9465), new DateTime(2021, 7, 1, 14, 42, 5, 125, DateTimeKind.Unspecified).AddTicks(6295) },
                    { 28, 2, 1, new DateTime(2021, 10, 25, 14, 57, 8, 254, DateTimeKind.Unspecified).AddTicks(7888), new DateTime(2021, 6, 4, 22, 17, 57, 972, DateTimeKind.Unspecified).AddTicks(6119) },
                    { 24, 5, 1, new DateTime(2021, 12, 12, 4, 12, 37, 447, DateTimeKind.Unspecified).AddTicks(2230), new DateTime(2021, 5, 23, 19, 37, 37, 570, DateTimeKind.Unspecified).AddTicks(9165) },
                    { 19, 3, 1, new DateTime(2021, 9, 6, 11, 58, 3, 834, DateTimeKind.Unspecified).AddTicks(5669), new DateTime(2021, 8, 27, 22, 21, 8, 236, DateTimeKind.Unspecified).AddTicks(9994) },
                    { 15, 3, 1, new DateTime(2021, 9, 8, 6, 59, 14, 796, DateTimeKind.Unspecified).AddTicks(5018), new DateTime(2021, 7, 11, 2, 17, 41, 484, DateTimeKind.Unspecified).AddTicks(9457) },
                    { 10, 4, 2, new DateTime(2021, 11, 19, 13, 12, 34, 873, DateTimeKind.Unspecified).AddTicks(8463), new DateTime(2021, 8, 23, 10, 23, 33, 568, DateTimeKind.Unspecified).AddTicks(8002) },
                    { 12, 1, 2, new DateTime(2021, 11, 27, 10, 6, 11, 852, DateTimeKind.Unspecified).AddTicks(6637), new DateTime(2021, 5, 9, 10, 4, 16, 872, DateTimeKind.Unspecified).AddTicks(6798) },
                    { 22, 2, 2, new DateTime(2021, 9, 23, 16, 55, 14, 856, DateTimeKind.Unspecified).AddTicks(2253), new DateTime(2021, 6, 20, 18, 45, 22, 853, DateTimeKind.Unspecified).AddTicks(155) },
                    { 25, 3, 2, new DateTime(2021, 9, 15, 1, 25, 44, 556, DateTimeKind.Unspecified).AddTicks(6887), new DateTime(2021, 7, 16, 23, 30, 9, 886, DateTimeKind.Unspecified).AddTicks(7959) },
                    { 100, 5, 2, new DateTime(2021, 11, 17, 17, 53, 51, 497, DateTimeKind.Unspecified).AddTicks(5428), new DateTime(2021, 7, 8, 18, 41, 48, 876, DateTimeKind.Unspecified).AddTicks(630) },
                    { 98, 3, 2, new DateTime(2021, 12, 20, 21, 47, 59, 366, DateTimeKind.Unspecified).AddTicks(6758), new DateTime(2021, 5, 14, 2, 46, 1, 157, DateTimeKind.Unspecified).AddTicks(3206) },
                    { 94, 5, 2, new DateTime(2021, 12, 18, 22, 25, 12, 105, DateTimeKind.Unspecified).AddTicks(391), new DateTime(2021, 8, 20, 22, 4, 26, 795, DateTimeKind.Unspecified).AddTicks(8004) },
                    { 93, 1, 2, new DateTime(2021, 10, 1, 18, 38, 48, 507, DateTimeKind.Unspecified).AddTicks(7795), new DateTime(2021, 8, 13, 0, 4, 24, 214, DateTimeKind.Unspecified).AddTicks(8615) },
                    { 87, 3, 2, new DateTime(2021, 10, 29, 12, 14, 41, 676, DateTimeKind.Unspecified).AddTicks(3889), new DateTime(2021, 7, 29, 22, 4, 59, 722, DateTimeKind.Unspecified).AddTicks(7592) },
                    { 86, 5, 2, new DateTime(2021, 12, 24, 23, 18, 10, 245, DateTimeKind.Unspecified).AddTicks(3560), new DateTime(2021, 6, 19, 8, 51, 49, 370, DateTimeKind.Unspecified).AddTicks(7308) },
                    { 79, 3, 2, new DateTime(2021, 10, 25, 20, 2, 42, 666, DateTimeKind.Unspecified).AddTicks(3544), new DateTime(2021, 5, 29, 9, 35, 20, 459, DateTimeKind.Unspecified).AddTicks(437) },
                    { 78, 1, 2, new DateTime(2021, 12, 29, 1, 10, 57, 670, DateTimeKind.Unspecified).AddTicks(484), new DateTime(2021, 6, 16, 0, 6, 8, 484, DateTimeKind.Unspecified).AddTicks(3020) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 67, 2, 2, new DateTime(2021, 11, 22, 19, 47, 46, 883, DateTimeKind.Unspecified).AddTicks(7253), new DateTime(2021, 8, 28, 21, 32, 8, 394, DateTimeKind.Unspecified).AddTicks(6860) },
                    { 65, 4, 2, new DateTime(2021, 9, 22, 5, 7, 31, 825, DateTimeKind.Unspecified).AddTicks(7346), new DateTime(2021, 7, 4, 9, 14, 22, 617, DateTimeKind.Unspecified).AddTicks(2638) },
                    { 95, 4, 5, new DateTime(2021, 10, 31, 1, 54, 56, 752, DateTimeKind.Unspecified).AddTicks(6170), new DateTime(2021, 5, 10, 6, 15, 27, 150, DateTimeKind.Unspecified).AddTicks(8456) },
                    { 63, 5, 2, new DateTime(2021, 11, 25, 4, 2, 5, 439, DateTimeKind.Unspecified).AddTicks(2647), new DateTime(2021, 5, 22, 18, 15, 10, 366, DateTimeKind.Unspecified).AddTicks(8891) },
                    { 51, 3, 2, new DateTime(2021, 10, 21, 19, 10, 11, 328, DateTimeKind.Unspecified).AddTicks(1050), new DateTime(2021, 6, 3, 17, 27, 12, 69, DateTimeKind.Unspecified).AddTicks(1222) },
                    { 46, 1, 2, new DateTime(2021, 11, 23, 22, 38, 26, 155, DateTimeKind.Unspecified).AddTicks(6913), new DateTime(2021, 8, 14, 5, 21, 32, 154, DateTimeKind.Unspecified).AddTicks(4299) },
                    { 45, 4, 2, new DateTime(2021, 10, 20, 16, 42, 14, 161, DateTimeKind.Unspecified).AddTicks(6464), new DateTime(2021, 7, 15, 17, 58, 16, 505, DateTimeKind.Unspecified).AddTicks(2384) },
                    { 39, 2, 2, new DateTime(2021, 12, 13, 8, 18, 8, 382, DateTimeKind.Unspecified).AddTicks(2953), new DateTime(2021, 6, 23, 21, 10, 28, 28, DateTimeKind.Unspecified).AddTicks(513) },
                    { 38, 4, 2, new DateTime(2021, 11, 24, 4, 59, 55, 307, DateTimeKind.Unspecified).AddTicks(7519), new DateTime(2021, 7, 10, 11, 32, 9, 385, DateTimeKind.Unspecified).AddTicks(6650) },
                    { 35, 1, 2, new DateTime(2021, 9, 22, 23, 55, 58, 862, DateTimeKind.Unspecified).AddTicks(1004), new DateTime(2021, 7, 19, 13, 40, 3, 276, DateTimeKind.Unspecified).AddTicks(7346) },
                    { 30, 3, 2, new DateTime(2021, 10, 11, 4, 45, 51, 872, DateTimeKind.Unspecified).AddTicks(7770), new DateTime(2021, 6, 7, 7, 24, 16, 553, DateTimeKind.Unspecified).AddTicks(2734) },
                    { 29, 4, 2, new DateTime(2021, 10, 18, 3, 40, 5, 652, DateTimeKind.Unspecified).AddTicks(8600), new DateTime(2021, 7, 16, 3, 54, 45, 458, DateTimeKind.Unspecified).AddTicks(5892) },
                    { 27, 1, 2, new DateTime(2021, 9, 11, 5, 39, 55, 638, DateTimeKind.Unspecified).AddTicks(8896), new DateTime(2021, 5, 15, 22, 27, 58, 865, DateTimeKind.Unspecified).AddTicks(1485) },
                    { 26, 4, 2, new DateTime(2021, 11, 7, 20, 29, 49, 380, DateTimeKind.Unspecified).AddTicks(6458), new DateTime(2021, 8, 11, 3, 7, 7, 441, DateTimeKind.Unspecified).AddTicks(181) },
                    { 61, 2, 2, new DateTime(2021, 12, 8, 6, 15, 12, 172, DateTimeKind.Unspecified).AddTicks(1298), new DateTime(2021, 7, 15, 10, 17, 32, 663, DateTimeKind.Unspecified).AddTicks(2139) },
                    { 96, 2, 5, new DateTime(2021, 10, 13, 5, 7, 13, 338, DateTimeKind.Unspecified).AddTicks(9711), new DateTime(2021, 6, 21, 15, 20, 17, 8, DateTimeKind.Unspecified).AddTicks(9949) }
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
