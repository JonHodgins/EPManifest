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
                    { 3, 4, 1, new DateTime(2021, 12, 17, 21, 21, 8, 535, DateTimeKind.Unspecified).AddTicks(6215), new DateTime(2021, 8, 29, 14, 49, 30, 401, DateTimeKind.Unspecified).AddTicks(7098) },
                    { 56, 4, 4, new DateTime(2021, 12, 6, 9, 22, 16, 254, DateTimeKind.Unspecified).AddTicks(6467), new DateTime(2021, 5, 31, 2, 1, 31, 597, DateTimeKind.Unspecified).AddTicks(1060) },
                    { 51, 4, 4, new DateTime(2021, 10, 27, 0, 40, 42, 910, DateTimeKind.Unspecified).AddTicks(3475), new DateTime(2021, 7, 28, 20, 17, 57, 79, DateTimeKind.Unspecified).AddTicks(7414) },
                    { 49, 5, 4, new DateTime(2021, 9, 15, 13, 39, 10, 165, DateTimeKind.Unspecified).AddTicks(6567), new DateTime(2021, 8, 2, 21, 23, 1, 875, DateTimeKind.Unspecified).AddTicks(5017) },
                    { 47, 3, 4, new DateTime(2021, 11, 9, 0, 29, 7, 430, DateTimeKind.Unspecified).AddTicks(3537), new DateTime(2021, 6, 23, 14, 33, 44, 498, DateTimeKind.Unspecified).AddTicks(9341) },
                    { 44, 4, 4, new DateTime(2021, 11, 24, 3, 13, 12, 20, DateTimeKind.Unspecified).AddTicks(5334), new DateTime(2021, 5, 20, 16, 6, 15, 231, DateTimeKind.Unspecified).AddTicks(1708) },
                    { 39, 1, 4, new DateTime(2021, 12, 5, 2, 2, 18, 509, DateTimeKind.Unspecified).AddTicks(7866), new DateTime(2021, 7, 20, 19, 46, 26, 591, DateTimeKind.Unspecified).AddTicks(5436) },
                    { 34, 4, 4, new DateTime(2021, 10, 20, 19, 7, 50, 952, DateTimeKind.Unspecified).AddTicks(5), new DateTime(2021, 6, 26, 14, 28, 28, 27, DateTimeKind.Unspecified).AddTicks(2649) },
                    { 31, 5, 4, new DateTime(2021, 12, 9, 15, 51, 18, 519, DateTimeKind.Unspecified).AddTicks(1563), new DateTime(2021, 6, 10, 4, 32, 39, 79, DateTimeKind.Unspecified).AddTicks(6115) },
                    { 28, 4, 4, new DateTime(2021, 9, 4, 22, 30, 56, 322, DateTimeKind.Unspecified).AddTicks(6451), new DateTime(2021, 6, 2, 21, 21, 35, 666, DateTimeKind.Unspecified).AddTicks(2327) },
                    { 26, 4, 4, new DateTime(2021, 10, 15, 17, 57, 47, 52, DateTimeKind.Unspecified).AddTicks(488), new DateTime(2021, 6, 25, 22, 16, 58, 227, DateTimeKind.Unspecified).AddTicks(9349) },
                    { 19, 4, 4, new DateTime(2021, 9, 20, 4, 44, 23, 239, DateTimeKind.Unspecified).AddTicks(4617), new DateTime(2021, 8, 16, 8, 13, 5, 462, DateTimeKind.Unspecified).AddTicks(9565) },
                    { 17, 1, 4, new DateTime(2021, 10, 22, 16, 56, 13, 336, DateTimeKind.Unspecified).AddTicks(4151), new DateTime(2021, 7, 14, 5, 1, 40, 626, DateTimeKind.Unspecified).AddTicks(4726) },
                    { 10, 1, 4, new DateTime(2021, 11, 5, 20, 40, 9, 597, DateTimeKind.Unspecified).AddTicks(6804), new DateTime(2021, 6, 28, 2, 3, 23, 63, DateTimeKind.Unspecified).AddTicks(3693) },
                    { 91, 4, 3, new DateTime(2021, 12, 29, 4, 33, 52, 935, DateTimeKind.Unspecified).AddTicks(950), new DateTime(2021, 5, 14, 5, 54, 10, 838, DateTimeKind.Unspecified).AddTicks(7977) },
                    { 90, 1, 3, new DateTime(2021, 12, 24, 4, 3, 7, 74, DateTimeKind.Unspecified).AddTicks(541), new DateTime(2021, 5, 17, 14, 27, 31, 19, DateTimeKind.Unspecified).AddTicks(1251) },
                    { 87, 5, 3, new DateTime(2021, 9, 8, 23, 0, 4, 837, DateTimeKind.Unspecified).AddTicks(6841), new DateTime(2021, 6, 7, 11, 6, 25, 598, DateTimeKind.Unspecified).AddTicks(6647) },
                    { 81, 3, 3, new DateTime(2021, 10, 14, 8, 19, 4, 688, DateTimeKind.Unspecified).AddTicks(6485), new DateTime(2021, 6, 26, 16, 20, 8, 782, DateTimeKind.Unspecified).AddTicks(5140) },
                    { 80, 3, 3, new DateTime(2021, 12, 24, 2, 41, 56, 265, DateTimeKind.Unspecified).AddTicks(660), new DateTime(2021, 6, 10, 18, 17, 18, 936, DateTimeKind.Unspecified).AddTicks(5801) },
                    { 78, 2, 3, new DateTime(2021, 10, 15, 7, 39, 34, 193, DateTimeKind.Unspecified).AddTicks(2774), new DateTime(2021, 7, 30, 3, 15, 4, 983, DateTimeKind.Unspecified).AddTicks(9521) },
                    { 74, 3, 3, new DateTime(2021, 9, 16, 22, 11, 56, 252, DateTimeKind.Unspecified).AddTicks(1436), new DateTime(2021, 8, 2, 7, 51, 6, 839, DateTimeKind.Unspecified).AddTicks(5710) },
                    { 73, 1, 3, new DateTime(2021, 9, 30, 4, 41, 45, 897, DateTimeKind.Unspecified).AddTicks(2050), new DateTime(2021, 6, 17, 19, 12, 20, 865, DateTimeKind.Unspecified).AddTicks(5) },
                    { 67, 5, 4, new DateTime(2021, 9, 4, 16, 42, 39, 538, DateTimeKind.Unspecified).AddTicks(8171), new DateTime(2021, 7, 4, 10, 28, 2, 373, DateTimeKind.Unspecified).AddTicks(4176) },
                    { 71, 4, 3, new DateTime(2021, 11, 15, 20, 54, 56, 870, DateTimeKind.Unspecified).AddTicks(9209), new DateTime(2021, 8, 9, 5, 25, 22, 801, DateTimeKind.Unspecified).AddTicks(9418) },
                    { 72, 4, 4, new DateTime(2021, 12, 26, 23, 43, 34, 221, DateTimeKind.Unspecified).AddTicks(3996), new DateTime(2021, 7, 5, 16, 55, 59, 173, DateTimeKind.Unspecified).AddTicks(2652) },
                    { 84, 1, 4, new DateTime(2021, 10, 31, 9, 21, 26, 455, DateTimeKind.Unspecified).AddTicks(1984), new DateTime(2021, 7, 5, 22, 42, 37, 723, DateTimeKind.Unspecified).AddTicks(1058) },
                    { 94, 4, 5, new DateTime(2021, 10, 3, 0, 26, 9, 483, DateTimeKind.Unspecified).AddTicks(7428), new DateTime(2021, 7, 27, 2, 0, 57, 349, DateTimeKind.Unspecified).AddTicks(922) },
                    { 79, 3, 5, new DateTime(2021, 10, 26, 8, 16, 56, 811, DateTimeKind.Unspecified).AddTicks(3698), new DateTime(2021, 6, 18, 4, 54, 32, 400, DateTimeKind.Unspecified).AddTicks(9537) },
                    { 63, 2, 5, new DateTime(2021, 11, 20, 3, 2, 20, 478, DateTimeKind.Unspecified).AddTicks(5833), new DateTime(2021, 6, 6, 1, 0, 52, 957, DateTimeKind.Unspecified).AddTicks(3353) },
                    { 62, 4, 5, new DateTime(2021, 12, 29, 11, 0, 47, 561, DateTimeKind.Unspecified).AddTicks(292), new DateTime(2021, 5, 12, 2, 27, 11, 760, DateTimeKind.Unspecified).AddTicks(6699) },
                    { 59, 1, 5, new DateTime(2021, 12, 8, 16, 36, 19, 629, DateTimeKind.Unspecified).AddTicks(2300), new DateTime(2021, 5, 23, 5, 15, 27, 922, DateTimeKind.Unspecified).AddTicks(6898) },
                    { 58, 5, 5, new DateTime(2021, 12, 6, 10, 58, 52, 198, DateTimeKind.Unspecified).AddTicks(6695), new DateTime(2021, 6, 15, 6, 43, 59, 999, DateTimeKind.Unspecified).AddTicks(493) },
                    { 55, 4, 5, new DateTime(2021, 12, 27, 10, 53, 48, 113, DateTimeKind.Unspecified).AddTicks(5354), new DateTime(2021, 8, 21, 3, 42, 7, 48, DateTimeKind.Unspecified).AddTicks(6208) },
                    { 45, 5, 5, new DateTime(2021, 12, 10, 2, 30, 36, 401, DateTimeKind.Unspecified).AddTicks(6039), new DateTime(2021, 6, 25, 13, 28, 43, 233, DateTimeKind.Unspecified).AddTicks(8729) },
                    { 38, 1, 5, new DateTime(2021, 12, 6, 17, 39, 31, 728, DateTimeKind.Unspecified).AddTicks(758), new DateTime(2021, 6, 6, 0, 45, 32, 744, DateTimeKind.Unspecified).AddTicks(8649) },
                    { 35, 1, 5, new DateTime(2021, 9, 10, 13, 25, 47, 391, DateTimeKind.Unspecified).AddTicks(4953), new DateTime(2021, 6, 17, 7, 15, 15, 418, DateTimeKind.Unspecified).AddTicks(67) },
                    { 32, 2, 5, new DateTime(2021, 9, 7, 7, 38, 46, 606, DateTimeKind.Unspecified).AddTicks(2894), new DateTime(2021, 5, 10, 12, 26, 35, 874, DateTimeKind.Unspecified).AddTicks(3662) },
                    { 29, 5, 5, new DateTime(2021, 11, 9, 5, 31, 3, 239, DateTimeKind.Unspecified).AddTicks(8459), new DateTime(2021, 8, 6, 14, 0, 14, 399, DateTimeKind.Unspecified).AddTicks(737) },
                    { 27, 2, 5, new DateTime(2021, 11, 10, 23, 26, 12, 954, DateTimeKind.Unspecified).AddTicks(4258), new DateTime(2021, 5, 23, 7, 25, 1, 348, DateTimeKind.Unspecified).AddTicks(4438) },
                    { 25, 3, 5, new DateTime(2021, 10, 2, 23, 46, 0, 489, DateTimeKind.Unspecified).AddTicks(2846), new DateTime(2021, 6, 27, 20, 39, 59, 584, DateTimeKind.Unspecified).AddTicks(8197) },
                    { 16, 1, 5, new DateTime(2021, 9, 23, 12, 38, 20, 148, DateTimeKind.Unspecified).AddTicks(3578), new DateTime(2021, 6, 4, 13, 31, 20, 160, DateTimeKind.Unspecified).AddTicks(787) },
                    { 11, 1, 5, new DateTime(2021, 9, 11, 16, 5, 49, 224, DateTimeKind.Unspecified).AddTicks(9952), new DateTime(2021, 7, 20, 13, 45, 28, 320, DateTimeKind.Unspecified).AddTicks(1538) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 2, 5, 5, new DateTime(2021, 10, 28, 4, 55, 25, 184, DateTimeKind.Unspecified).AddTicks(7350), new DateTime(2021, 8, 28, 8, 58, 50, 627, DateTimeKind.Unspecified).AddTicks(7500) },
                    { 1, 3, 5, new DateTime(2021, 10, 20, 15, 56, 29, 504, DateTimeKind.Unspecified).AddTicks(1524), new DateTime(2021, 6, 7, 16, 50, 59, 21, DateTimeKind.Unspecified).AddTicks(407) },
                    { 98, 5, 4, new DateTime(2021, 9, 26, 14, 26, 13, 225, DateTimeKind.Unspecified).AddTicks(2199), new DateTime(2021, 8, 22, 11, 40, 58, 751, DateTimeKind.Unspecified).AddTicks(6936) },
                    { 97, 1, 4, new DateTime(2021, 9, 7, 9, 26, 40, 487, DateTimeKind.Unspecified).AddTicks(4120), new DateTime(2021, 6, 30, 16, 7, 5, 45, DateTimeKind.Unspecified).AddTicks(3444) },
                    { 96, 3, 4, new DateTime(2021, 12, 24, 15, 46, 0, 848, DateTimeKind.Unspecified).AddTicks(8615), new DateTime(2021, 6, 22, 17, 9, 32, 626, DateTimeKind.Unspecified).AddTicks(5480) },
                    { 82, 1, 4, new DateTime(2021, 11, 17, 6, 51, 22, 733, DateTimeKind.Unspecified).AddTicks(6024), new DateTime(2021, 7, 8, 17, 33, 8, 405, DateTimeKind.Unspecified).AddTicks(1498) },
                    { 68, 1, 3, new DateTime(2021, 9, 15, 6, 16, 56, 988, DateTimeKind.Unspecified).AddTicks(4996), new DateTime(2021, 6, 11, 9, 11, 13, 928, DateTimeKind.Unspecified).AddTicks(5265) },
                    { 65, 5, 3, new DateTime(2021, 12, 14, 8, 44, 26, 77, DateTimeKind.Unspecified).AddTicks(7417), new DateTime(2021, 5, 27, 10, 13, 57, 610, DateTimeKind.Unspecified).AddTicks(5882) },
                    { 61, 2, 3, new DateTime(2021, 9, 13, 20, 16, 47, 850, DateTimeKind.Unspecified).AddTicks(2637), new DateTime(2021, 7, 10, 5, 29, 33, 414, DateTimeKind.Unspecified).AddTicks(5435) },
                    { 36, 5, 2, new DateTime(2021, 10, 19, 11, 20, 10, 903, DateTimeKind.Unspecified).AddTicks(5026), new DateTime(2021, 8, 20, 22, 41, 5, 701, DateTimeKind.Unspecified).AddTicks(3960) },
                    { 14, 4, 2, new DateTime(2021, 12, 3, 20, 49, 22, 53, DateTimeKind.Unspecified).AddTicks(7869), new DateTime(2021, 8, 19, 3, 6, 6, 146, DateTimeKind.Unspecified).AddTicks(1986) },
                    { 13, 1, 2, new DateTime(2021, 12, 8, 6, 38, 28, 544, DateTimeKind.Unspecified).AddTicks(9628), new DateTime(2021, 6, 22, 8, 50, 11, 293, DateTimeKind.Unspecified).AddTicks(7733) },
                    { 9, 1, 2, new DateTime(2021, 9, 29, 10, 5, 45, 118, DateTimeKind.Unspecified).AddTicks(3891), new DateTime(2021, 6, 23, 6, 14, 40, 414, DateTimeKind.Unspecified).AddTicks(9092) },
                    { 8, 5, 2, new DateTime(2021, 12, 13, 1, 46, 21, 337, DateTimeKind.Unspecified).AddTicks(6292), new DateTime(2021, 5, 24, 20, 42, 21, 473, DateTimeKind.Unspecified).AddTicks(7303) },
                    { 6, 1, 2, new DateTime(2021, 10, 14, 12, 20, 38, 720, DateTimeKind.Unspecified).AddTicks(7611), new DateTime(2021, 6, 3, 15, 22, 2, 639, DateTimeKind.Unspecified).AddTicks(9247) },
                    { 100, 3, 1, new DateTime(2021, 10, 24, 19, 5, 44, 554, DateTimeKind.Unspecified).AddTicks(942), new DateTime(2021, 5, 26, 16, 8, 34, 396, DateTimeKind.Unspecified).AddTicks(970) },
                    { 93, 5, 1, new DateTime(2021, 11, 2, 4, 20, 4, 735, DateTimeKind.Unspecified).AddTicks(4830), new DateTime(2021, 5, 27, 22, 23, 0, 51, DateTimeKind.Unspecified).AddTicks(2793) },
                    { 77, 1, 1, new DateTime(2021, 10, 6, 17, 9, 25, 246, DateTimeKind.Unspecified).AddTicks(9058), new DateTime(2021, 6, 25, 18, 10, 18, 624, DateTimeKind.Unspecified).AddTicks(8384) },
                    { 76, 1, 1, new DateTime(2021, 12, 13, 16, 48, 22, 355, DateTimeKind.Unspecified).AddTicks(4249), new DateTime(2021, 6, 26, 12, 47, 48, 309, DateTimeKind.Unspecified).AddTicks(663) },
                    { 66, 2, 1, new DateTime(2021, 9, 4, 17, 30, 5, 542, DateTimeKind.Unspecified).AddTicks(6936), new DateTime(2021, 5, 17, 9, 25, 25, 183, DateTimeKind.Unspecified).AddTicks(4148) },
                    { 60, 4, 1, new DateTime(2021, 12, 21, 15, 59, 30, 725, DateTimeKind.Unspecified).AddTicks(1772), new DateTime(2021, 6, 30, 3, 10, 6, 495, DateTimeKind.Unspecified).AddTicks(9311) },
                    { 54, 4, 1, new DateTime(2021, 10, 26, 2, 20, 58, 964, DateTimeKind.Unspecified).AddTicks(3011), new DateTime(2021, 8, 24, 13, 17, 43, 632, DateTimeKind.Unspecified).AddTicks(9442) },
                    { 53, 5, 1, new DateTime(2021, 10, 24, 10, 11, 7, 528, DateTimeKind.Unspecified).AddTicks(2679), new DateTime(2021, 8, 6, 13, 43, 59, 752, DateTimeKind.Unspecified).AddTicks(1771) },
                    { 48, 4, 1, new DateTime(2021, 9, 27, 0, 59, 53, 979, DateTimeKind.Unspecified).AddTicks(3007), new DateTime(2021, 5, 17, 10, 22, 5, 611, DateTimeKind.Unspecified).AddTicks(5625) },
                    { 33, 1, 1, new DateTime(2021, 9, 12, 17, 47, 55, 225, DateTimeKind.Unspecified).AddTicks(1640), new DateTime(2021, 6, 9, 14, 18, 48, 705, DateTimeKind.Unspecified).AddTicks(8847) },
                    { 24, 4, 1, new DateTime(2021, 12, 9, 13, 56, 35, 805, DateTimeKind.Unspecified).AddTicks(8114), new DateTime(2021, 7, 30, 21, 50, 21, 8, DateTimeKind.Unspecified).AddTicks(8768) },
                    { 23, 4, 1, new DateTime(2021, 12, 14, 11, 8, 29, 860, DateTimeKind.Unspecified).AddTicks(9560), new DateTime(2021, 5, 14, 18, 28, 28, 536, DateTimeKind.Unspecified).AddTicks(8109) },
                    { 21, 2, 1, new DateTime(2021, 9, 20, 20, 5, 7, 382, DateTimeKind.Unspecified).AddTicks(3669), new DateTime(2021, 7, 11, 15, 32, 59, 605, DateTimeKind.Unspecified).AddTicks(1405) },
                    { 15, 5, 1, new DateTime(2021, 12, 8, 21, 36, 58, 355, DateTimeKind.Unspecified).AddTicks(4952), new DateTime(2021, 5, 8, 3, 54, 47, 203, DateTimeKind.Unspecified).AddTicks(8221) },
                    { 5, 1, 1, new DateTime(2021, 12, 10, 5, 8, 22, 143, DateTimeKind.Unspecified).AddTicks(236), new DateTime(2021, 6, 11, 0, 37, 44, 311, DateTimeKind.Unspecified).AddTicks(6783) },
                    { 40, 4, 2, new DateTime(2021, 10, 21, 23, 4, 16, 112, DateTimeKind.Unspecified).AddTicks(1210), new DateTime(2021, 7, 6, 8, 41, 8, 338, DateTimeKind.Unspecified).AddTicks(4400) },
                    { 41, 1, 2, new DateTime(2021, 11, 26, 2, 10, 57, 687, DateTimeKind.Unspecified).AddTicks(8599), new DateTime(2021, 7, 11, 22, 28, 5, 569, DateTimeKind.Unspecified).AddTicks(349) },
                    { 50, 2, 2, new DateTime(2021, 10, 4, 1, 35, 19, 945, DateTimeKind.Unspecified).AddTicks(788), new DateTime(2021, 8, 24, 18, 45, 18, 976, DateTimeKind.Unspecified).AddTicks(5529) },
                    { 57, 3, 2, new DateTime(2021, 12, 6, 7, 34, 58, 18, DateTimeKind.Unspecified).AddTicks(5532), new DateTime(2021, 7, 27, 17, 40, 40, 347, DateTimeKind.Unspecified).AddTicks(2571) },
                    { 52, 5, 3, new DateTime(2021, 9, 2, 1, 56, 14, 899, DateTimeKind.Unspecified).AddTicks(449), new DateTime(2021, 5, 16, 12, 44, 42, 346, DateTimeKind.Unspecified).AddTicks(3654) },
                    { 46, 5, 3, new DateTime(2021, 12, 14, 14, 15, 57, 99, DateTimeKind.Unspecified).AddTicks(2515), new DateTime(2021, 6, 1, 11, 59, 25, 638, DateTimeKind.Unspecified).AddTicks(2270) },
                    { 43, 2, 3, new DateTime(2021, 10, 16, 18, 17, 39, 428, DateTimeKind.Unspecified).AddTicks(7240), new DateTime(2021, 8, 2, 20, 5, 22, 223, DateTimeKind.Unspecified).AddTicks(8475) },
                    { 42, 1, 3, new DateTime(2021, 10, 1, 16, 12, 19, 836, DateTimeKind.Unspecified).AddTicks(9182), new DateTime(2021, 6, 15, 2, 31, 33, 787, DateTimeKind.Unspecified).AddTicks(6937) },
                    { 37, 1, 3, new DateTime(2021, 9, 19, 14, 42, 11, 640, DateTimeKind.Unspecified).AddTicks(581), new DateTime(2021, 8, 21, 5, 40, 22, 951, DateTimeKind.Unspecified).AddTicks(9984) },
                    { 30, 1, 3, new DateTime(2021, 10, 8, 16, 33, 49, 351, DateTimeKind.Unspecified).AddTicks(8314), new DateTime(2021, 8, 3, 14, 39, 52, 753, DateTimeKind.Unspecified).AddTicks(3440) },
                    { 22, 2, 3, new DateTime(2021, 11, 21, 12, 11, 53, 976, DateTimeKind.Unspecified).AddTicks(7151), new DateTime(2021, 7, 6, 1, 47, 50, 132, DateTimeKind.Unspecified).AddTicks(9634) },
                    { 20, 1, 3, new DateTime(2021, 9, 16, 11, 36, 44, 73, DateTimeKind.Unspecified).AddTicks(909), new DateTime(2021, 8, 26, 7, 8, 37, 618, DateTimeKind.Unspecified).AddTicks(5147) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 18, 5, 3, new DateTime(2021, 9, 6, 22, 48, 18, 457, DateTimeKind.Unspecified).AddTicks(9305), new DateTime(2021, 6, 6, 9, 37, 16, 70, DateTimeKind.Unspecified).AddTicks(3257) },
                    { 12, 2, 3, new DateTime(2021, 12, 15, 22, 45, 8, 950, DateTimeKind.Unspecified).AddTicks(4489), new DateTime(2021, 5, 13, 5, 26, 49, 444, DateTimeKind.Unspecified).AddTicks(6423) },
                    { 95, 1, 5, new DateTime(2021, 12, 4, 23, 41, 18, 131, DateTimeKind.Unspecified).AddTicks(4919), new DateTime(2021, 8, 17, 12, 39, 53, 201, DateTimeKind.Unspecified).AddTicks(416) },
                    { 7, 1, 3, new DateTime(2021, 12, 12, 4, 21, 39, 288, DateTimeKind.Unspecified).AddTicks(6616), new DateTime(2021, 5, 21, 13, 59, 13, 870, DateTimeKind.Unspecified).AddTicks(8966) },
                    { 92, 1, 2, new DateTime(2021, 12, 19, 12, 42, 47, 909, DateTimeKind.Unspecified).AddTicks(6495), new DateTime(2021, 8, 3, 20, 55, 47, 927, DateTimeKind.Unspecified).AddTicks(3327) },
                    { 89, 3, 2, new DateTime(2021, 11, 13, 14, 56, 41, 168, DateTimeKind.Unspecified).AddTicks(1926), new DateTime(2021, 6, 21, 13, 42, 20, 316, DateTimeKind.Unspecified).AddTicks(4661) },
                    { 88, 2, 2, new DateTime(2021, 12, 14, 1, 31, 50, 406, DateTimeKind.Unspecified).AddTicks(5250), new DateTime(2021, 7, 23, 8, 53, 1, 291, DateTimeKind.Unspecified).AddTicks(3626) },
                    { 86, 2, 2, new DateTime(2021, 10, 16, 7, 42, 30, 959, DateTimeKind.Unspecified).AddTicks(2469), new DateTime(2021, 7, 10, 12, 56, 42, 21, DateTimeKind.Unspecified).AddTicks(8023) },
                    { 85, 5, 2, new DateTime(2021, 11, 12, 21, 50, 19, 755, DateTimeKind.Unspecified).AddTicks(8560), new DateTime(2021, 7, 18, 23, 12, 16, 28, DateTimeKind.Unspecified).AddTicks(6491) },
                    { 83, 3, 2, new DateTime(2021, 11, 23, 17, 55, 27, 520, DateTimeKind.Unspecified).AddTicks(9608), new DateTime(2021, 5, 9, 8, 34, 26, 161, DateTimeKind.Unspecified).AddTicks(8242) },
                    { 75, 3, 2, new DateTime(2021, 12, 14, 23, 14, 16, 743, DateTimeKind.Unspecified).AddTicks(4239), new DateTime(2021, 7, 3, 15, 2, 45, 681, DateTimeKind.Unspecified).AddTicks(4038) },
                    { 70, 1, 2, new DateTime(2021, 11, 19, 2, 7, 38, 700, DateTimeKind.Unspecified).AddTicks(5263), new DateTime(2021, 8, 23, 22, 47, 48, 897, DateTimeKind.Unspecified).AddTicks(7206) },
                    { 69, 5, 2, new DateTime(2021, 10, 10, 12, 4, 23, 559, DateTimeKind.Unspecified).AddTicks(7253), new DateTime(2021, 7, 11, 12, 5, 0, 597, DateTimeKind.Unspecified).AddTicks(3840) },
                    { 64, 5, 2, new DateTime(2021, 12, 23, 0, 26, 25, 336, DateTimeKind.Unspecified).AddTicks(6844), new DateTime(2021, 7, 10, 7, 15, 53, 994, DateTimeKind.Unspecified).AddTicks(5024) },
                    { 4, 5, 3, new DateTime(2021, 9, 4, 4, 31, 39, 888, DateTimeKind.Unspecified).AddTicks(5022), new DateTime(2021, 5, 24, 22, 46, 14, 79, DateTimeKind.Unspecified).AddTicks(3655) },
                    { 99, 4, 5, new DateTime(2021, 10, 26, 20, 2, 9, 495, DateTimeKind.Unspecified).AddTicks(6633), new DateTime(2021, 5, 8, 12, 55, 2, 601, DateTimeKind.Unspecified).AddTicks(5409) }
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
