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
                    { 6, 2, 2, 1, new DateTime(2021, 9, 8, 7, 40, 15, 418, DateTimeKind.Unspecified).AddTicks(3203), new DateTime(2021, 7, 19, 12, 5, 50, 114, DateTimeKind.Unspecified).AddTicks(6773) },
                    { 86, 4, 1, 4, new DateTime(2021, 11, 17, 12, 37, 33, 221, DateTimeKind.Unspecified).AddTicks(4749), new DateTime(2021, 7, 18, 14, 36, 8, 253, DateTimeKind.Unspecified).AddTicks(5357) },
                    { 83, 3, 5, 4, new DateTime(2021, 10, 8, 16, 36, 21, 312, DateTimeKind.Unspecified).AddTicks(9867), new DateTime(2021, 8, 11, 19, 6, 57, 143, DateTimeKind.Unspecified).AddTicks(7629) },
                    { 81, 3, 5, 4, new DateTime(2021, 9, 26, 10, 44, 5, 801, DateTimeKind.Unspecified).AddTicks(630), new DateTime(2021, 5, 17, 15, 34, 47, 212, DateTimeKind.Unspecified).AddTicks(6840) },
                    { 71, 3, 5, 4, new DateTime(2021, 9, 21, 5, 35, 46, 706, DateTimeKind.Unspecified).AddTicks(1420), new DateTime(2021, 8, 1, 22, 33, 11, 888, DateTimeKind.Unspecified).AddTicks(3553) },
                    { 68, 3, 2, 4, new DateTime(2021, 10, 28, 20, 21, 28, 78, DateTimeKind.Unspecified).AddTicks(5166), new DateTime(2021, 6, 21, 8, 32, 21, 653, DateTimeKind.Unspecified).AddTicks(1050) },
                    { 41, 5, 4, 4, new DateTime(2021, 9, 8, 11, 51, 46, 20, DateTimeKind.Unspecified).AddTicks(2812), new DateTime(2021, 8, 30, 12, 14, 41, 751, DateTimeKind.Unspecified).AddTicks(7456) },
                    { 38, 1, 4, 4, new DateTime(2021, 9, 23, 6, 33, 51, 251, DateTimeKind.Unspecified).AddTicks(2746), new DateTime(2021, 8, 7, 15, 43, 38, 193, DateTimeKind.Unspecified).AddTicks(9523) },
                    { 37, 5, 2, 4, new DateTime(2021, 11, 20, 22, 26, 45, 845, DateTimeKind.Unspecified).AddTicks(3072), new DateTime(2021, 8, 15, 17, 25, 9, 275, DateTimeKind.Unspecified).AddTicks(5416) },
                    { 22, 5, 4, 4, new DateTime(2021, 10, 8, 19, 52, 25, 228, DateTimeKind.Unspecified).AddTicks(9467), new DateTime(2021, 7, 6, 22, 24, 50, 462, DateTimeKind.Unspecified).AddTicks(666) },
                    { 16, 3, 1, 4, new DateTime(2021, 11, 16, 4, 38, 36, 48, DateTimeKind.Unspecified).AddTicks(8683), new DateTime(2021, 6, 25, 18, 30, 41, 60, DateTimeKind.Unspecified).AddTicks(5741) },
                    { 9, 4, 3, 4, new DateTime(2021, 9, 1, 2, 58, 53, 598, DateTimeKind.Unspecified).AddTicks(3937), new DateTime(2021, 8, 17, 5, 13, 58, 409, DateTimeKind.Unspecified).AddTicks(9184) },
                    { 99, 4, 3, 3, new DateTime(2021, 9, 1, 7, 30, 37, 362, DateTimeKind.Unspecified).AddTicks(9964), new DateTime(2021, 5, 30, 1, 38, 27, 865, DateTimeKind.Unspecified).AddTicks(4034) },
                    { 78, 5, 3, 3, new DateTime(2021, 10, 21, 16, 12, 58, 525, DateTimeKind.Unspecified).AddTicks(9861), new DateTime(2021, 7, 13, 6, 13, 18, 798, DateTimeKind.Unspecified).AddTicks(5745) },
                    { 77, 1, 3, 3, new DateTime(2021, 11, 6, 3, 24, 40, 663, DateTimeKind.Unspecified).AddTicks(9922), new DateTime(2021, 8, 21, 3, 5, 57, 194, DateTimeKind.Unspecified).AddTicks(7686) },
                    { 75, 2, 5, 3, new DateTime(2021, 9, 5, 9, 23, 5, 339, DateTimeKind.Unspecified).AddTicks(1924), new DateTime(2021, 6, 3, 6, 36, 52, 690, DateTimeKind.Unspecified).AddTicks(5239) },
                    { 72, 3, 4, 3, new DateTime(2021, 12, 4, 0, 21, 53, 432, DateTimeKind.Unspecified).AddTicks(4661), new DateTime(2021, 8, 4, 10, 47, 19, 538, DateTimeKind.Unspecified).AddTicks(529) },
                    { 67, 4, 5, 3, new DateTime(2021, 12, 13, 4, 15, 17, 67, DateTimeKind.Unspecified).AddTicks(3591), new DateTime(2021, 8, 1, 11, 44, 20, 544, DateTimeKind.Unspecified).AddTicks(813) },
                    { 66, 1, 2, 3, new DateTime(2021, 10, 12, 17, 1, 51, 883, DateTimeKind.Unspecified).AddTicks(1607), new DateTime(2021, 7, 29, 6, 15, 2, 418, DateTimeKind.Unspecified).AddTicks(3304) },
                    { 65, 3, 4, 3, new DateTime(2021, 12, 24, 12, 45, 12, 993, DateTimeKind.Unspecified).AddTicks(5940), new DateTime(2021, 6, 20, 0, 39, 9, 303, DateTimeKind.Unspecified).AddTicks(4523) },
                    { 58, 3, 4, 3, new DateTime(2021, 11, 2, 9, 0, 22, 582, DateTimeKind.Unspecified).AddTicks(9946), new DateTime(2021, 8, 23, 0, 0, 21, 476, DateTimeKind.Unspecified).AddTicks(4878) },
                    { 55, 2, 2, 3, new DateTime(2021, 11, 18, 17, 38, 34, 620, DateTimeKind.Unspecified).AddTicks(2785), new DateTime(2021, 6, 27, 1, 5, 22, 738, DateTimeKind.Unspecified).AddTicks(7327) },
                    { 87, 5, 2, 4, new DateTime(2021, 9, 27, 2, 47, 28, 480, DateTimeKind.Unspecified).AddTicks(818), new DateTime(2021, 8, 26, 0, 0, 29, 483, DateTimeKind.Unspecified).AddTicks(427) },
                    { 51, 3, 5, 3, new DateTime(2021, 10, 22, 15, 14, 22, 555, DateTimeKind.Unspecified).AddTicks(5562), new DateTime(2021, 6, 10, 10, 33, 0, 72, DateTimeKind.Unspecified).AddTicks(7887) },
                    { 88, 1, 1, 4, new DateTime(2021, 11, 24, 5, 59, 18, 447, DateTimeKind.Unspecified).AddTicks(5498), new DateTime(2021, 7, 27, 22, 38, 55, 152, DateTimeKind.Unspecified).AddTicks(4360) },
                    { 96, 2, 2, 4, new DateTime(2021, 11, 23, 20, 55, 40, 816, DateTimeKind.Unspecified).AddTicks(8100), new DateTime(2021, 5, 14, 13, 4, 16, 125, DateTimeKind.Unspecified).AddTicks(1129) },
                    { 85, 4, 3, 5, new DateTime(2021, 12, 1, 11, 33, 38, 239, DateTimeKind.Unspecified).AddTicks(4177), new DateTime(2021, 8, 13, 8, 23, 42, 780, DateTimeKind.Unspecified).AddTicks(8035) },
                    { 82, 1, 3, 5, new DateTime(2021, 9, 23, 2, 18, 51, 14, DateTimeKind.Unspecified).AddTicks(4821), new DateTime(2021, 7, 28, 18, 23, 39, 45, DateTimeKind.Unspecified).AddTicks(3212) },
                    { 79, 4, 5, 5, new DateTime(2021, 11, 13, 7, 14, 51, 972, DateTimeKind.Unspecified).AddTicks(8311), new DateTime(2021, 7, 17, 0, 3, 37, 316, DateTimeKind.Unspecified).AddTicks(4637) },
                    { 76, 5, 5, 5, new DateTime(2021, 12, 23, 6, 28, 23, 562, DateTimeKind.Unspecified).AddTicks(6878), new DateTime(2021, 5, 9, 13, 2, 4, 95, DateTimeKind.Unspecified).AddTicks(4528) },
                    { 73, 2, 3, 5, new DateTime(2021, 12, 1, 19, 20, 14, 858, DateTimeKind.Unspecified).AddTicks(7283), new DateTime(2021, 6, 10, 23, 12, 54, 718, DateTimeKind.Unspecified).AddTicks(2803) },
                    { 69, 5, 3, 5, new DateTime(2021, 10, 14, 15, 33, 48, 262, DateTimeKind.Unspecified).AddTicks(3299), new DateTime(2021, 7, 23, 8, 25, 16, 102, DateTimeKind.Unspecified).AddTicks(2447) },
                    { 64, 4, 3, 5, new DateTime(2021, 12, 24, 12, 21, 32, 158, DateTimeKind.Unspecified).AddTicks(90), new DateTime(2021, 7, 28, 6, 7, 41, 690, DateTimeKind.Unspecified).AddTicks(7670) },
                    { 59, 5, 5, 5, new DateTime(2021, 11, 27, 2, 30, 0, 511, DateTimeKind.Unspecified).AddTicks(321), new DateTime(2021, 6, 15, 21, 24, 17, 766, DateTimeKind.Unspecified).AddTicks(7014) },
                    { 57, 2, 1, 5, new DateTime(2021, 11, 23, 3, 3, 6, 569, DateTimeKind.Unspecified).AddTicks(7837), new DateTime(2021, 7, 21, 15, 13, 46, 749, DateTimeKind.Unspecified).AddTicks(9970) },
                    { 44, 1, 1, 5, new DateTime(2021, 11, 29, 14, 20, 19, 28, DateTimeKind.Unspecified).AddTicks(5491), new DateTime(2021, 6, 1, 6, 59, 2, 864, DateTimeKind.Unspecified).AddTicks(7218) },
                    { 42, 4, 4, 5, new DateTime(2021, 11, 26, 13, 45, 1, 348, DateTimeKind.Unspecified).AddTicks(7450), new DateTime(2021, 7, 5, 13, 33, 51, 877, DateTimeKind.Unspecified).AddTicks(1396) },
                    { 39, 2, 2, 5, new DateTime(2021, 11, 14, 19, 21, 4, 487, DateTimeKind.Unspecified).AddTicks(7088), new DateTime(2021, 7, 16, 3, 20, 50, 106, DateTimeKind.Unspecified).AddTicks(1198) },
                    { 35, 3, 1, 5, new DateTime(2021, 11, 19, 17, 40, 57, 172, DateTimeKind.Unspecified).AddTicks(4726), new DateTime(2021, 8, 30, 21, 48, 44, 479, DateTimeKind.Unspecified).AddTicks(443) },
                    { 34, 1, 3, 5, new DateTime(2021, 12, 13, 17, 8, 1, 469, DateTimeKind.Unspecified).AddTicks(8104), new DateTime(2021, 7, 12, 9, 51, 29, 803, DateTimeKind.Unspecified).AddTicks(923) },
                    { 31, 4, 1, 5, new DateTime(2021, 9, 11, 20, 9, 12, 616, DateTimeKind.Unspecified).AddTicks(5630), new DateTime(2021, 5, 27, 8, 21, 12, 991, DateTimeKind.Unspecified).AddTicks(4731) },
                    { 27, 2, 3, 5, new DateTime(2021, 9, 29, 10, 29, 47, 598, DateTimeKind.Unspecified).AddTicks(330), new DateTime(2021, 8, 17, 22, 58, 50, 184, DateTimeKind.Unspecified).AddTicks(9005) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 19, 1, 5, 5, new DateTime(2021, 9, 20, 4, 11, 40, 966, DateTimeKind.Unspecified).AddTicks(4993), new DateTime(2021, 5, 22, 23, 24, 45, 183, DateTimeKind.Unspecified).AddTicks(6686) },
                    { 10, 5, 5, 5, new DateTime(2021, 12, 14, 10, 12, 26, 93, DateTimeKind.Unspecified).AddTicks(8044), new DateTime(2021, 8, 5, 10, 38, 42, 862, DateTimeKind.Unspecified).AddTicks(8426) },
                    { 7, 2, 1, 5, new DateTime(2021, 11, 20, 10, 13, 38, 5, DateTimeKind.Unspecified).AddTicks(3033), new DateTime(2021, 8, 22, 10, 11, 29, 203, DateTimeKind.Unspecified).AddTicks(8695) },
                    { 4, 3, 3, 5, new DateTime(2021, 11, 2, 10, 8, 52, 865, DateTimeKind.Unspecified).AddTicks(7112), new DateTime(2021, 8, 4, 6, 3, 16, 140, DateTimeKind.Unspecified).AddTicks(446) },
                    { 2, 2, 5, 5, new DateTime(2021, 10, 22, 6, 43, 36, 608, DateTimeKind.Unspecified).AddTicks(275), new DateTime(2021, 6, 10, 18, 13, 50, 285, DateTimeKind.Unspecified).AddTicks(9314) },
                    { 93, 3, 5, 4, new DateTime(2021, 10, 25, 17, 58, 41, 880, DateTimeKind.Unspecified).AddTicks(9608), new DateTime(2021, 5, 16, 2, 1, 50, 611, DateTimeKind.Unspecified).AddTicks(6880) },
                    { 46, 5, 5, 3, new DateTime(2021, 9, 14, 23, 58, 20, 321, DateTimeKind.Unspecified).AddTicks(9649), new DateTime(2021, 6, 20, 19, 29, 12, 445, DateTimeKind.Unspecified).AddTicks(2715) },
                    { 40, 4, 1, 3, new DateTime(2021, 11, 14, 11, 48, 11, 165, DateTimeKind.Unspecified).AddTicks(3612), new DateTime(2021, 5, 11, 14, 15, 37, 0, DateTimeKind.Unspecified).AddTicks(7486) },
                    { 29, 3, 1, 3, new DateTime(2021, 11, 11, 10, 38, 13, 139, DateTimeKind.Unspecified).AddTicks(449), new DateTime(2021, 7, 5, 2, 36, 33, 425, DateTimeKind.Unspecified).AddTicks(1755) },
                    { 5, 3, 4, 2, new DateTime(2021, 10, 26, 1, 35, 27, 139, DateTimeKind.Unspecified).AddTicks(4071), new DateTime(2021, 6, 25, 21, 20, 42, 414, DateTimeKind.Unspecified).AddTicks(4194) },
                    { 1, 5, 4, 2, new DateTime(2021, 11, 19, 9, 5, 12, 969, DateTimeKind.Unspecified).AddTicks(2290), new DateTime(2021, 8, 18, 4, 32, 10, 633, DateTimeKind.Unspecified).AddTicks(548) },
                    { 100, 1, 4, 1, new DateTime(2021, 10, 26, 10, 25, 32, 168, DateTimeKind.Unspecified).AddTicks(6398), new DateTime(2021, 8, 24, 5, 22, 54, 972, DateTimeKind.Unspecified).AddTicks(3271) },
                    { 91, 4, 5, 1, new DateTime(2021, 9, 22, 12, 42, 43, 132, DateTimeKind.Unspecified).AddTicks(6084), new DateTime(2021, 7, 30, 20, 17, 17, 8, DateTimeKind.Unspecified).AddTicks(3836) },
                    { 90, 5, 3, 1, new DateTime(2021, 10, 7, 21, 50, 39, 722, DateTimeKind.Unspecified).AddTicks(7162), new DateTime(2021, 6, 11, 4, 18, 39, 374, DateTimeKind.Unspecified).AddTicks(3689) },
                    { 70, 4, 1, 1, new DateTime(2021, 12, 6, 22, 30, 57, 148, DateTimeKind.Unspecified).AddTicks(2693), new DateTime(2021, 8, 12, 10, 0, 34, 280, DateTimeKind.Unspecified).AddTicks(8474) },
                    { 63, 5, 5, 1, new DateTime(2021, 10, 31, 11, 21, 49, 928, DateTimeKind.Unspecified).AddTicks(5942), new DateTime(2021, 5, 21, 13, 46, 6, 526, DateTimeKind.Unspecified).AddTicks(5448) },
                    { 61, 5, 2, 1, new DateTime(2021, 10, 2, 20, 36, 16, 493, DateTimeKind.Unspecified).AddTicks(2516), new DateTime(2021, 7, 29, 7, 14, 25, 936, DateTimeKind.Unspecified).AddTicks(9232) },
                    { 56, 2, 5, 1, new DateTime(2021, 12, 18, 3, 9, 20, 616, DateTimeKind.Unspecified).AddTicks(7593), new DateTime(2021, 7, 1, 11, 16, 20, 429, DateTimeKind.Unspecified).AddTicks(5565) },
                    { 54, 3, 1, 1, new DateTime(2021, 12, 15, 2, 6, 15, 599, DateTimeKind.Unspecified).AddTicks(5890), new DateTime(2021, 8, 18, 7, 25, 37, 708, DateTimeKind.Unspecified).AddTicks(7777) },
                    { 53, 2, 4, 1, new DateTime(2021, 10, 17, 22, 13, 17, 649, DateTimeKind.Unspecified).AddTicks(5698), new DateTime(2021, 6, 22, 6, 15, 6, 777, DateTimeKind.Unspecified).AddTicks(7515) },
                    { 52, 3, 2, 1, new DateTime(2021, 10, 27, 12, 19, 34, 262, DateTimeKind.Unspecified).AddTicks(9332), new DateTime(2021, 5, 9, 8, 14, 19, 674, DateTimeKind.Unspecified).AddTicks(7045) },
                    { 50, 4, 4, 1, new DateTime(2021, 11, 28, 13, 39, 42, 688, DateTimeKind.Unspecified).AddTicks(714), new DateTime(2021, 7, 14, 4, 16, 54, 647, DateTimeKind.Unspecified).AddTicks(2764) },
                    { 49, 3, 1, 1, new DateTime(2021, 12, 20, 5, 43, 18, 611, DateTimeKind.Unspecified).AddTicks(3152), new DateTime(2021, 5, 17, 9, 0, 21, 44, DateTimeKind.Unspecified).AddTicks(3186) },
                    { 48, 5, 3, 1, new DateTime(2021, 12, 3, 21, 38, 43, 784, DateTimeKind.Unspecified).AddTicks(7363), new DateTime(2021, 8, 8, 14, 28, 30, 991, DateTimeKind.Unspecified).AddTicks(8032) },
                    { 45, 2, 3, 1, new DateTime(2021, 12, 29, 1, 42, 38, 881, DateTimeKind.Unspecified).AddTicks(607), new DateTime(2021, 6, 21, 5, 48, 4, 894, DateTimeKind.Unspecified).AddTicks(8561) },
                    { 33, 1, 1, 1, new DateTime(2021, 10, 28, 8, 36, 38, 498, DateTimeKind.Unspecified).AddTicks(7448), new DateTime(2021, 8, 17, 5, 6, 38, 6, DateTimeKind.Unspecified).AddTicks(9559) },
                    { 32, 4, 3, 1, new DateTime(2021, 12, 5, 10, 44, 40, 104, DateTimeKind.Unspecified).AddTicks(9606), new DateTime(2021, 8, 13, 5, 8, 34, 650, DateTimeKind.Unspecified).AddTicks(5800) },
                    { 30, 2, 5, 1, new DateTime(2021, 9, 6, 17, 5, 59, 63, DateTimeKind.Unspecified).AddTicks(9565), new DateTime(2021, 8, 14, 1, 57, 1, 991, DateTimeKind.Unspecified).AddTicks(6481) },
                    { 24, 5, 1, 1, new DateTime(2021, 9, 26, 2, 22, 38, 801, DateTimeKind.Unspecified).AddTicks(8606), new DateTime(2021, 8, 1, 5, 39, 19, 388, DateTimeKind.Unspecified).AddTicks(2715) },
                    { 20, 3, 5, 1, new DateTime(2021, 11, 5, 0, 55, 56, 660, DateTimeKind.Unspecified).AddTicks(4913), new DateTime(2021, 6, 20, 4, 51, 39, 951, DateTimeKind.Unspecified).AddTicks(9191) },
                    { 8, 4, 3, 2, new DateTime(2021, 11, 24, 0, 58, 26, 148, DateTimeKind.Unspecified).AddTicks(7170), new DateTime(2021, 7, 21, 3, 11, 25, 97, DateTimeKind.Unspecified).AddTicks(5165) },
                    { 17, 3, 3, 2, new DateTime(2021, 10, 30, 12, 26, 50, 482, DateTimeKind.Unspecified).AddTicks(6957), new DateTime(2021, 8, 4, 6, 9, 53, 83, DateTimeKind.Unspecified).AddTicks(3756) },
                    { 18, 1, 1, 2, new DateTime(2021, 9, 14, 0, 25, 21, 974, DateTimeKind.Unspecified).AddTicks(7670), new DateTime(2021, 8, 10, 1, 27, 51, 948, DateTimeKind.Unspecified).AddTicks(5546) },
                    { 21, 2, 5, 2, new DateTime(2021, 10, 16, 16, 0, 40, 766, DateTimeKind.Unspecified).AddTicks(7607), new DateTime(2021, 6, 16, 3, 43, 13, 955, DateTimeKind.Unspecified).AddTicks(3994) },
                    { 28, 1, 1, 3, new DateTime(2021, 11, 29, 18, 41, 13, 252, DateTimeKind.Unspecified).AddTicks(3173), new DateTime(2021, 6, 21, 20, 30, 3, 924, DateTimeKind.Unspecified).AddTicks(8840) },
                    { 26, 4, 4, 3, new DateTime(2021, 11, 17, 13, 36, 53, 800, DateTimeKind.Unspecified).AddTicks(5947), new DateTime(2021, 8, 21, 3, 43, 14, 336, DateTimeKind.Unspecified).AddTicks(3267) },
                    { 25, 2, 2, 3, new DateTime(2021, 10, 30, 21, 52, 38, 225, DateTimeKind.Unspecified).AddTicks(709), new DateTime(2021, 7, 11, 18, 33, 39, 731, DateTimeKind.Unspecified).AddTicks(8239) },
                    { 23, 1, 4, 3, new DateTime(2021, 10, 4, 13, 23, 56, 923, DateTimeKind.Unspecified).AddTicks(7782), new DateTime(2021, 8, 8, 10, 30, 43, 305, DateTimeKind.Unspecified).AddTicks(3551) },
                    { 15, 5, 5, 3, new DateTime(2021, 12, 4, 10, 44, 14, 521, DateTimeKind.Unspecified).AddTicks(2330), new DateTime(2021, 5, 16, 9, 5, 44, 841, DateTimeKind.Unspecified).AddTicks(6773) },
                    { 14, 1, 3, 3, new DateTime(2021, 10, 23, 21, 53, 40, 850, DateTimeKind.Unspecified).AddTicks(4403), new DateTime(2021, 7, 24, 3, 29, 30, 368, DateTimeKind.Unspecified).AddTicks(9991) },
                    { 13, 4, 3, 3, new DateTime(2021, 11, 1, 1, 1, 2, 203, DateTimeKind.Unspecified).AddTicks(6340), new DateTime(2021, 6, 3, 19, 16, 14, 309, DateTimeKind.Unspecified).AddTicks(8418) },
                    { 12, 3, 2, 3, new DateTime(2021, 11, 2, 5, 51, 11, 213, DateTimeKind.Unspecified).AddTicks(7007), new DateTime(2021, 6, 26, 20, 28, 43, 847, DateTimeKind.Unspecified).AddTicks(6679) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 11, 1, 4, 3, new DateTime(2021, 9, 14, 0, 12, 30, 329, DateTimeKind.Unspecified).AddTicks(5053), new DateTime(2021, 6, 11, 16, 45, 4, 263, DateTimeKind.Unspecified).AddTicks(2384) },
                    { 3, 1, 5, 3, new DateTime(2021, 11, 25, 15, 12, 12, 438, DateTimeKind.Unspecified).AddTicks(161), new DateTime(2021, 6, 15, 14, 0, 18, 886, DateTimeKind.Unspecified).AddTicks(4362) },
                    { 89, 1, 2, 5, new DateTime(2021, 12, 5, 13, 1, 40, 568, DateTimeKind.Unspecified).AddTicks(1614), new DateTime(2021, 6, 22, 6, 12, 15, 437, DateTimeKind.Unspecified).AddTicks(7031) },
                    { 97, 3, 1, 2, new DateTime(2021, 11, 10, 8, 8, 57, 467, DateTimeKind.Unspecified).AddTicks(8421), new DateTime(2021, 6, 13, 12, 41, 2, 731, DateTimeKind.Unspecified).AddTicks(9459) },
                    { 94, 3, 1, 2, new DateTime(2021, 11, 18, 11, 46, 38, 601, DateTimeKind.Unspecified).AddTicks(5100), new DateTime(2021, 7, 17, 23, 24, 18, 670, DateTimeKind.Unspecified).AddTicks(9579) },
                    { 92, 4, 1, 2, new DateTime(2021, 11, 1, 22, 43, 46, 971, DateTimeKind.Unspecified).AddTicks(5735), new DateTime(2021, 6, 14, 16, 53, 23, 761, DateTimeKind.Unspecified).AddTicks(9978) },
                    { 84, 3, 2, 2, new DateTime(2021, 9, 22, 7, 24, 40, 535, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2021, 8, 2, 2, 31, 6, 649, DateTimeKind.Unspecified).AddTicks(1968) },
                    { 80, 3, 2, 2, new DateTime(2021, 9, 7, 21, 13, 8, 244, DateTimeKind.Unspecified).AddTicks(3620), new DateTime(2021, 8, 20, 2, 20, 24, 294, DateTimeKind.Unspecified).AddTicks(3624) },
                    { 74, 2, 2, 2, new DateTime(2021, 12, 1, 7, 4, 41, 697, DateTimeKind.Unspecified).AddTicks(8067), new DateTime(2021, 6, 7, 12, 18, 11, 627, DateTimeKind.Unspecified).AddTicks(8151) },
                    { 62, 1, 3, 2, new DateTime(2021, 10, 3, 5, 57, 47, 393, DateTimeKind.Unspecified).AddTicks(7689), new DateTime(2021, 7, 20, 14, 36, 30, 144, DateTimeKind.Unspecified).AddTicks(4248) },
                    { 60, 1, 4, 2, new DateTime(2021, 11, 28, 8, 41, 29, 618, DateTimeKind.Unspecified).AddTicks(6304), new DateTime(2021, 7, 26, 18, 37, 47, 906, DateTimeKind.Unspecified).AddTicks(2977) },
                    { 47, 4, 1, 2, new DateTime(2021, 11, 19, 2, 40, 57, 251, DateTimeKind.Unspecified).AddTicks(3849), new DateTime(2021, 6, 18, 1, 47, 44, 401, DateTimeKind.Unspecified).AddTicks(1900) },
                    { 43, 4, 4, 2, new DateTime(2021, 9, 3, 1, 31, 15, 569, DateTimeKind.Unspecified).AddTicks(7395), new DateTime(2021, 7, 9, 11, 57, 36, 584, DateTimeKind.Unspecified).AddTicks(609) },
                    { 36, 4, 4, 2, new DateTime(2021, 10, 7, 12, 39, 11, 530, DateTimeKind.Unspecified).AddTicks(8592), new DateTime(2021, 8, 27, 20, 56, 50, 550, DateTimeKind.Unspecified).AddTicks(870) },
                    { 95, 4, 2, 2, new DateTime(2021, 9, 22, 10, 18, 49, 923, DateTimeKind.Unspecified).AddTicks(1449), new DateTime(2021, 5, 14, 0, 47, 38, 207, DateTimeKind.Unspecified).AddTicks(3106) },
                    { 98, 1, 3, 5, new DateTime(2021, 12, 20, 7, 24, 2, 123, DateTimeKind.Unspecified).AddTicks(2571), new DateTime(2021, 8, 5, 12, 55, 5, 844, DateTimeKind.Unspecified).AddTicks(6132) }
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
