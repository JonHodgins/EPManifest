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
                    { 4, 3, "YT83959-0", 1, new DateTime(2021, 10, 12, 23, 5, 2, 723, DateTimeKind.Unspecified).AddTicks(3749), new DateTime(2021, 8, 23, 17, 19, 28, 544, DateTimeKind.Unspecified).AddTicks(4988) },
                    { 40, 5, "YT97951-0", 4, new DateTime(2021, 11, 29, 3, 13, 35, 267, DateTimeKind.Unspecified).AddTicks(8022), new DateTime(2021, 7, 1, 2, 49, 18, 187, DateTimeKind.Unspecified).AddTicks(7949) },
                    { 39, 5, "YT46711-1", 4, new DateTime(2021, 12, 25, 14, 35, 5, 704, DateTimeKind.Unspecified).AddTicks(1264), new DateTime(2021, 6, 29, 20, 5, 24, 776, DateTimeKind.Unspecified).AddTicks(3583) },
                    { 36, 3, "YT89074-1", 4, new DateTime(2021, 9, 1, 6, 0, 54, 384, DateTimeKind.Unspecified).AddTicks(3057), new DateTime(2021, 6, 15, 14, 18, 29, 990, DateTimeKind.Unspecified).AddTicks(1544) },
                    { 24, 4, "YT29585-1", 4, new DateTime(2021, 11, 16, 5, 6, 31, 491, DateTimeKind.Unspecified).AddTicks(8032), new DateTime(2021, 6, 3, 15, 4, 50, 208, DateTimeKind.Unspecified).AddTicks(7911) },
                    { 22, 3, "YT56243-0", 4, new DateTime(2021, 10, 23, 9, 31, 54, 551, DateTimeKind.Unspecified).AddTicks(73), new DateTime(2021, 6, 16, 20, 18, 19, 688, DateTimeKind.Unspecified).AddTicks(3092) },
                    { 99, 4, "YT86194-0", 3, new DateTime(2021, 9, 20, 15, 9, 29, 564, DateTimeKind.Unspecified).AddTicks(9908), new DateTime(2021, 5, 20, 17, 13, 14, 319, DateTimeKind.Unspecified).AddTicks(4112) },
                    { 89, 3, "YT16650-0", 3, new DateTime(2021, 11, 23, 16, 34, 42, 162, DateTimeKind.Unspecified).AddTicks(9713), new DateTime(2021, 5, 20, 17, 38, 9, 787, DateTimeKind.Unspecified).AddTicks(8644) },
                    { 84, 2, "YT22280-0", 3, new DateTime(2021, 9, 1, 13, 2, 50, 479, DateTimeKind.Unspecified).AddTicks(9126), new DateTime(2021, 6, 17, 23, 55, 34, 367, DateTimeKind.Unspecified).AddTicks(4837) },
                    { 78, 2, "YT94095-1", 3, new DateTime(2021, 12, 19, 11, 12, 41, 359, DateTimeKind.Unspecified).AddTicks(890), new DateTime(2021, 6, 27, 8, 49, 45, 271, DateTimeKind.Unspecified).AddTicks(5849) },
                    { 74, 5, "YT95721-0", 3, new DateTime(2021, 11, 26, 0, 43, 0, 266, DateTimeKind.Unspecified).AddTicks(5529), new DateTime(2021, 7, 13, 10, 32, 35, 750, DateTimeKind.Unspecified).AddTicks(4101) },
                    { 73, 3, "YT30257-1", 3, new DateTime(2021, 11, 30, 16, 32, 11, 203, DateTimeKind.Unspecified).AddTicks(9429), new DateTime(2021, 7, 8, 15, 6, 38, 459, DateTimeKind.Unspecified).AddTicks(8637) },
                    { 56, 5, "YT77289-0", 3, new DateTime(2021, 11, 22, 20, 38, 46, 168, DateTimeKind.Unspecified).AddTicks(7223), new DateTime(2021, 6, 24, 14, 9, 55, 916, DateTimeKind.Unspecified).AddTicks(3784) },
                    { 52, 5, "YT54854-1", 3, new DateTime(2021, 11, 9, 1, 16, 38, 823, DateTimeKind.Unspecified).AddTicks(3379), new DateTime(2021, 5, 14, 23, 21, 41, 946, DateTimeKind.Unspecified).AddTicks(9236) },
                    { 51, 3, "YT95427-1", 3, new DateTime(2021, 11, 15, 10, 37, 29, 851, DateTimeKind.Unspecified).AddTicks(2089), new DateTime(2021, 7, 25, 12, 23, 18, 984, DateTimeKind.Unspecified).AddTicks(5871) },
                    { 47, 2, "YT78341-0", 3, new DateTime(2021, 11, 12, 0, 25, 45, 734, DateTimeKind.Unspecified).AddTicks(5657), new DateTime(2021, 6, 21, 16, 52, 6, 360, DateTimeKind.Unspecified).AddTicks(5266) },
                    { 46, 2, "YT36261-0", 3, new DateTime(2021, 12, 19, 16, 36, 14, 181, DateTimeKind.Unspecified).AddTicks(2612), new DateTime(2021, 8, 13, 16, 59, 39, 752, DateTimeKind.Unspecified).AddTicks(3143) },
                    { 42, 5, "YT58138-1", 3, new DateTime(2021, 12, 22, 15, 51, 48, 95, DateTimeKind.Unspecified).AddTicks(6606), new DateTime(2021, 8, 11, 0, 6, 35, 452, DateTimeKind.Unspecified).AddTicks(8945) },
                    { 38, 5, "YT93521-0", 3, new DateTime(2021, 12, 16, 6, 36, 7, 226, DateTimeKind.Unspecified).AddTicks(2764), new DateTime(2021, 7, 12, 22, 2, 47, 744, DateTimeKind.Unspecified).AddTicks(5573) },
                    { 34, 5, "YT24615-1", 3, new DateTime(2021, 9, 5, 13, 26, 38, 306, DateTimeKind.Unspecified).AddTicks(5279), new DateTime(2021, 5, 12, 17, 26, 4, 372, DateTimeKind.Unspecified).AddTicks(2052) },
                    { 30, 4, "YT73178-0", 3, new DateTime(2021, 10, 20, 7, 8, 52, 551, DateTimeKind.Unspecified).AddTicks(2440), new DateTime(2021, 8, 11, 20, 16, 10, 432, DateTimeKind.Unspecified).AddTicks(6433) },
                    { 28, 4, "YT90464-1", 3, new DateTime(2021, 9, 15, 7, 5, 46, 676, DateTimeKind.Unspecified).AddTicks(8950), new DateTime(2021, 7, 26, 11, 22, 21, 126, DateTimeKind.Unspecified).AddTicks(512) },
                    { 43, 5, "YT44376-0", 4, new DateTime(2021, 12, 10, 5, 11, 50, 25, DateTimeKind.Unspecified).AddTicks(2999), new DateTime(2021, 8, 16, 15, 29, 49, 547, DateTimeKind.Unspecified).AddTicks(9537) },
                    { 20, 1, "YT33820-0", 3, new DateTime(2021, 10, 23, 11, 57, 46, 447, DateTimeKind.Unspecified).AddTicks(4151), new DateTime(2021, 5, 21, 4, 15, 10, 167, DateTimeKind.Unspecified).AddTicks(1752) },
                    { 57, 3, "YT21907-1", 4, new DateTime(2021, 11, 13, 7, 8, 40, 635, DateTimeKind.Unspecified).AddTicks(5572), new DateTime(2021, 6, 2, 2, 45, 21, 662, DateTimeKind.Unspecified).AddTicks(7450) },
                    { 64, 5, "YT33513-0", 4, new DateTime(2021, 9, 21, 7, 42, 51, 777, DateTimeKind.Unspecified).AddTicks(6011), new DateTime(2021, 8, 18, 15, 28, 17, 869, DateTimeKind.Unspecified).AddTicks(1509) },
                    { 93, 1, "YT48016-0", 5, new DateTime(2021, 9, 28, 23, 21, 17, 797, DateTimeKind.Unspecified).AddTicks(9497), new DateTime(2021, 7, 16, 2, 0, 47, 9, DateTimeKind.Unspecified).AddTicks(4580) },
                    { 92, 1, "YT13371-0", 5, new DateTime(2021, 10, 30, 23, 7, 41, 401, DateTimeKind.Unspecified).AddTicks(4924), new DateTime(2021, 5, 20, 17, 6, 49, 165, DateTimeKind.Unspecified).AddTicks(1935) },
                    { 90, 2, "YT41876-0", 5, new DateTime(2021, 11, 5, 6, 15, 9, 705, DateTimeKind.Unspecified).AddTicks(2753), new DateTime(2021, 8, 9, 17, 44, 33, 996, DateTimeKind.Unspecified).AddTicks(7241) },
                    { 83, 1, "YT53664-0", 5, new DateTime(2021, 12, 2, 8, 58, 6, 39, DateTimeKind.Unspecified).AddTicks(1365), new DateTime(2021, 5, 14, 15, 15, 57, 412, DateTimeKind.Unspecified).AddTicks(7766) },
                    { 71, 1, "YT64872-1", 5, new DateTime(2021, 11, 3, 16, 52, 31, 897, DateTimeKind.Unspecified).AddTicks(206), new DateTime(2021, 8, 17, 1, 18, 46, 392, DateTimeKind.Unspecified).AddTicks(5112) },
                    { 63, 4, "YT85658-1", 5, new DateTime(2021, 10, 16, 15, 57, 25, 488, DateTimeKind.Unspecified).AddTicks(2785), new DateTime(2021, 7, 21, 0, 21, 43, 546, DateTimeKind.Unspecified).AddTicks(4203) },
                    { 55, 3, "YT92960-0", 5, new DateTime(2021, 12, 17, 8, 57, 38, 251, DateTimeKind.Unspecified).AddTicks(2365), new DateTime(2021, 8, 23, 18, 42, 26, 118, DateTimeKind.Unspecified).AddTicks(1865) },
                    { 41, 4, "YT91053-0", 5, new DateTime(2021, 9, 16, 2, 31, 31, 551, DateTimeKind.Unspecified).AddTicks(2142), new DateTime(2021, 7, 19, 10, 28, 57, 868, DateTimeKind.Unspecified).AddTicks(9927) },
                    { 35, 3, "YT56815-1", 5, new DateTime(2021, 11, 8, 13, 25, 42, 156, DateTimeKind.Unspecified).AddTicks(2390), new DateTime(2021, 6, 3, 10, 52, 44, 813, DateTimeKind.Unspecified).AddTicks(4563) },
                    { 33, 5, "YT52335-1", 5, new DateTime(2021, 11, 1, 20, 29, 25, 830, DateTimeKind.Unspecified).AddTicks(2606), new DateTime(2021, 8, 11, 22, 51, 40, 76, DateTimeKind.Unspecified).AddTicks(8732) },
                    { 31, 5, "YT95293-1", 5, new DateTime(2021, 11, 26, 18, 51, 11, 191, DateTimeKind.Unspecified).AddTicks(1383), new DateTime(2021, 7, 14, 23, 32, 34, 112, DateTimeKind.Unspecified).AddTicks(2861) },
                    { 27, 2, "YT33125-1", 5, new DateTime(2021, 12, 16, 17, 53, 16, 337, DateTimeKind.Unspecified).AddTicks(7254), new DateTime(2021, 8, 2, 15, 30, 13, 587, DateTimeKind.Unspecified).AddTicks(9762) },
                    { 26, 5, "YT90828-1", 5, new DateTime(2021, 10, 15, 9, 30, 2, 279, DateTimeKind.Unspecified).AddTicks(7997), new DateTime(2021, 5, 13, 14, 46, 37, 544, DateTimeKind.Unspecified).AddTicks(5101) },
                    { 25, 4, "YT62563-0", 5, new DateTime(2021, 12, 2, 13, 34, 39, 218, DateTimeKind.Unspecified).AddTicks(7859), new DateTime(2021, 6, 9, 19, 55, 10, 696, DateTimeKind.Unspecified).AddTicks(2046) },
                    { 23, 1, "YT11160-0", 5, new DateTime(2021, 10, 15, 19, 2, 4, 504, DateTimeKind.Unspecified).AddTicks(3120), new DateTime(2021, 8, 24, 5, 18, 29, 680, DateTimeKind.Unspecified).AddTicks(2637) },
                    { 13, 1, "YT72482-1", 5, new DateTime(2021, 10, 16, 19, 57, 37, 568, DateTimeKind.Unspecified).AddTicks(9546), new DateTime(2021, 6, 18, 22, 25, 53, 114, DateTimeKind.Unspecified).AddTicks(5531) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 8, 2, "YT13917-1", 5, new DateTime(2021, 9, 22, 12, 31, 5, 84, DateTimeKind.Unspecified).AddTicks(9358), new DateTime(2021, 5, 31, 11, 30, 13, 182, DateTimeKind.Unspecified).AddTicks(1110) },
                    { 96, 5, "YT92758-1", 4, new DateTime(2021, 12, 7, 11, 50, 0, 374, DateTimeKind.Unspecified).AddTicks(3042), new DateTime(2021, 6, 18, 1, 4, 43, 404, DateTimeKind.Unspecified).AddTicks(3253) },
                    { 88, 5, "YT71034-0", 4, new DateTime(2021, 11, 20, 20, 46, 30, 379, DateTimeKind.Unspecified).AddTicks(1195), new DateTime(2021, 8, 9, 10, 23, 17, 623, DateTimeKind.Unspecified).AddTicks(9259) },
                    { 85, 4, "YT60141-1", 4, new DateTime(2021, 9, 12, 11, 40, 10, 392, DateTimeKind.Unspecified).AddTicks(3904), new DateTime(2021, 7, 27, 6, 8, 14, 31, DateTimeKind.Unspecified).AddTicks(4485) },
                    { 76, 1, "YT30842-1", 4, new DateTime(2021, 12, 13, 6, 57, 55, 543, DateTimeKind.Unspecified).AddTicks(9443), new DateTime(2021, 7, 28, 22, 33, 41, 566, DateTimeKind.Unspecified).AddTicks(4482) },
                    { 62, 3, "YT97386-0", 4, new DateTime(2021, 12, 5, 4, 26, 54, 296, DateTimeKind.Unspecified).AddTicks(6092), new DateTime(2021, 7, 10, 16, 26, 51, 857, DateTimeKind.Unspecified).AddTicks(2541) },
                    { 14, 5, "YT54859-1", 3, new DateTime(2021, 10, 15, 18, 25, 52, 937, DateTimeKind.Unspecified).AddTicks(2927), new DateTime(2021, 8, 7, 20, 19, 3, 0, DateTimeKind.Unspecified).AddTicks(5265) },
                    { 11, 1, "YT24779-0", 3, new DateTime(2021, 11, 11, 6, 6, 4, 93, DateTimeKind.Unspecified).AddTicks(8310), new DateTime(2021, 5, 30, 2, 4, 16, 380, DateTimeKind.Unspecified).AddTicks(2396) },
                    { 6, 2, "YT53085-1", 3, new DateTime(2021, 12, 19, 20, 44, 25, 571, DateTimeKind.Unspecified).AddTicks(2267), new DateTime(2021, 6, 3, 2, 5, 11, 303, DateTimeKind.Unspecified).AddTicks(3777) },
                    { 97, 3, "YT17455-1", 1, new DateTime(2021, 11, 23, 23, 49, 15, 114, DateTimeKind.Unspecified).AddTicks(2198), new DateTime(2021, 8, 15, 16, 20, 57, 876, DateTimeKind.Unspecified).AddTicks(7961) },
                    { 94, 1, "YT34330-1", 1, new DateTime(2021, 10, 5, 15, 17, 33, 55, DateTimeKind.Unspecified).AddTicks(9111), new DateTime(2021, 7, 18, 7, 21, 12, 769, DateTimeKind.Unspecified).AddTicks(358) },
                    { 75, 1, "YT47419-1", 1, new DateTime(2021, 12, 14, 18, 45, 0, 840, DateTimeKind.Unspecified).AddTicks(9442), new DateTime(2021, 8, 28, 10, 12, 35, 552, DateTimeKind.Unspecified).AddTicks(512) },
                    { 70, 5, "YT55000-1", 1, new DateTime(2021, 12, 25, 9, 38, 49, 272, DateTimeKind.Unspecified).AddTicks(1135), new DateTime(2021, 5, 18, 12, 0, 22, 787, DateTimeKind.Unspecified).AddTicks(7058) },
                    { 69, 4, "YT56727-1", 1, new DateTime(2021, 10, 2, 18, 40, 40, 813, DateTimeKind.Unspecified).AddTicks(7888), new DateTime(2021, 8, 13, 0, 42, 25, 676, DateTimeKind.Unspecified).AddTicks(6379) },
                    { 67, 2, "YT59823-1", 1, new DateTime(2021, 9, 30, 18, 40, 4, 844, DateTimeKind.Unspecified).AddTicks(8831), new DateTime(2021, 7, 30, 16, 22, 27, 852, DateTimeKind.Unspecified).AddTicks(474) },
                    { 65, 1, "YT62545-0", 1, new DateTime(2021, 11, 11, 18, 3, 21, 673, DateTimeKind.Unspecified).AddTicks(9716), new DateTime(2021, 6, 26, 17, 42, 22, 68, DateTimeKind.Unspecified).AddTicks(3711) },
                    { 61, 4, "YT72277-1", 1, new DateTime(2021, 12, 3, 16, 51, 52, 882, DateTimeKind.Unspecified).AddTicks(8689), new DateTime(2021, 5, 23, 9, 10, 2, 222, DateTimeKind.Unspecified).AddTicks(3373) },
                    { 60, 1, "YT47986-1", 1, new DateTime(2021, 10, 4, 0, 45, 19, 755, DateTimeKind.Unspecified).AddTicks(2753), new DateTime(2021, 7, 2, 20, 45, 11, 722, DateTimeKind.Unspecified).AddTicks(3342) },
                    { 58, 4, "YT53627-0", 1, new DateTime(2021, 9, 11, 4, 48, 10, 427, DateTimeKind.Unspecified).AddTicks(2056), new DateTime(2021, 7, 20, 5, 30, 37, 595, DateTimeKind.Unspecified).AddTicks(6479) },
                    { 50, 3, "YT50982-1", 1, new DateTime(2021, 11, 28, 3, 16, 49, 104, DateTimeKind.Unspecified).AddTicks(70), new DateTime(2021, 7, 28, 1, 9, 57, 704, DateTimeKind.Unspecified).AddTicks(7731) },
                    { 48, 4, "YT35166-0", 1, new DateTime(2021, 9, 6, 17, 18, 43, 221, DateTimeKind.Unspecified).AddTicks(9122), new DateTime(2021, 7, 15, 10, 37, 33, 760, DateTimeKind.Unspecified).AddTicks(993) },
                    { 45, 5, "YT92687-1", 1, new DateTime(2021, 9, 24, 2, 59, 34, 803, DateTimeKind.Unspecified).AddTicks(3201), new DateTime(2021, 7, 6, 5, 46, 46, 435, DateTimeKind.Unspecified).AddTicks(121) },
                    { 37, 4, "YT12121-1", 1, new DateTime(2021, 11, 13, 20, 0, 41, 19, DateTimeKind.Unspecified).AddTicks(6595), new DateTime(2021, 5, 18, 8, 30, 29, 414, DateTimeKind.Unspecified).AddTicks(4460) },
                    { 32, 3, "YT65440-0", 1, new DateTime(2021, 10, 9, 20, 53, 42, 962, DateTimeKind.Unspecified).AddTicks(8123), new DateTime(2021, 8, 3, 9, 24, 53, 546, DateTimeKind.Unspecified).AddTicks(2499) },
                    { 19, 4, "YT28863-1", 1, new DateTime(2021, 11, 12, 4, 56, 40, 778, DateTimeKind.Unspecified).AddTicks(1290), new DateTime(2021, 6, 18, 1, 37, 15, 895, DateTimeKind.Unspecified).AddTicks(2445) },
                    { 18, 2, "YT13355-0", 1, new DateTime(2021, 11, 18, 15, 3, 54, 474, DateTimeKind.Unspecified).AddTicks(4726), new DateTime(2021, 5, 11, 0, 34, 20, 385, DateTimeKind.Unspecified).AddTicks(6871) },
                    { 12, 2, "YT24489-1", 1, new DateTime(2021, 12, 15, 15, 14, 4, 529, DateTimeKind.Unspecified).AddTicks(9449), new DateTime(2021, 5, 24, 23, 4, 55, 678, DateTimeKind.Unspecified).AddTicks(3920) },
                    { 10, 5, "YT83792-1", 1, new DateTime(2021, 12, 5, 14, 44, 20, 318, DateTimeKind.Unspecified).AddTicks(3382), new DateTime(2021, 7, 11, 6, 34, 28, 375, DateTimeKind.Unspecified).AddTicks(4346) },
                    { 9, 4, "YT80414-0", 1, new DateTime(2021, 9, 2, 7, 3, 57, 792, DateTimeKind.Unspecified).AddTicks(3920), new DateTime(2021, 6, 17, 23, 52, 18, 75, DateTimeKind.Unspecified).AddTicks(460) },
                    { 5, 3, "YT28893-1", 1, new DateTime(2021, 9, 17, 15, 36, 39, 646, DateTimeKind.Unspecified).AddTicks(9566), new DateTime(2021, 7, 24, 0, 45, 27, 653, DateTimeKind.Unspecified).AddTicks(1202) },
                    { 1, 4, "YT92071-0", 2, new DateTime(2021, 10, 9, 18, 29, 5, 379, DateTimeKind.Unspecified).AddTicks(6205), new DateTime(2021, 7, 6, 18, 55, 4, 880, DateTimeKind.Unspecified).AddTicks(3557) },
                    { 2, 4, "YT81414-0", 2, new DateTime(2021, 11, 14, 3, 41, 0, 133, DateTimeKind.Unspecified).AddTicks(6750), new DateTime(2021, 6, 14, 5, 6, 5, 438, DateTimeKind.Unspecified).AddTicks(7560) },
                    { 3, 2, "YT96331-0", 2, new DateTime(2021, 9, 5, 4, 27, 49, 638, DateTimeKind.Unspecified).AddTicks(914), new DateTime(2021, 8, 6, 23, 28, 6, 814, DateTimeKind.Unspecified).AddTicks(9629) },
                    { 7, 1, "YT22059-1", 2, new DateTime(2021, 9, 8, 5, 20, 9, 218, DateTimeKind.Unspecified).AddTicks(3277), new DateTime(2021, 7, 7, 7, 9, 47, 937, DateTimeKind.Unspecified).AddTicks(5861) },
                    { 98, 1, "YT77587-1", 2, new DateTime(2021, 9, 9, 14, 48, 36, 264, DateTimeKind.Unspecified).AddTicks(4053), new DateTime(2021, 5, 20, 16, 54, 49, 446, DateTimeKind.Unspecified).AddTicks(3048) },
                    { 91, 1, "YT76601-0", 2, new DateTime(2021, 9, 24, 23, 40, 41, 382, DateTimeKind.Unspecified).AddTicks(4657), new DateTime(2021, 5, 17, 17, 13, 34, 184, DateTimeKind.Unspecified).AddTicks(7631) },
                    { 87, 1, "YT98068-1", 2, new DateTime(2021, 10, 20, 18, 54, 58, 498, DateTimeKind.Unspecified).AddTicks(6160), new DateTime(2021, 6, 3, 3, 53, 37, 459, DateTimeKind.Unspecified).AddTicks(6017) },
                    { 86, 2, "YT60160-0", 2, new DateTime(2021, 12, 11, 14, 42, 7, 691, DateTimeKind.Unspecified).AddTicks(6989), new DateTime(2021, 6, 16, 19, 16, 45, 739, DateTimeKind.Unspecified).AddTicks(9268) },
                    { 82, 4, "YT20414-0", 2, new DateTime(2021, 10, 19, 22, 53, 26, 938, DateTimeKind.Unspecified).AddTicks(6955), new DateTime(2021, 6, 4, 11, 32, 50, 607, DateTimeKind.Unspecified).AddTicks(6100) },
                    { 81, 2, "YT40860-0", 2, new DateTime(2021, 10, 28, 18, 58, 57, 489, DateTimeKind.Unspecified).AddTicks(3134), new DateTime(2021, 7, 1, 10, 18, 39, 801, DateTimeKind.Unspecified).AddTicks(9767) },
                    { 80, 2, "YT55062-1", 2, new DateTime(2021, 12, 18, 14, 15, 5, 272, DateTimeKind.Unspecified).AddTicks(5763), new DateTime(2021, 8, 3, 21, 14, 2, 43, DateTimeKind.Unspecified).AddTicks(1046) },
                    { 79, 2, "YT79043-1", 2, new DateTime(2021, 9, 3, 22, 42, 6, 693, DateTimeKind.Unspecified).AddTicks(2600), new DateTime(2021, 8, 23, 3, 40, 24, 246, DateTimeKind.Unspecified).AddTicks(9655) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 77, 4, "YT35912-0", 2, new DateTime(2021, 10, 15, 0, 55, 14, 990, DateTimeKind.Unspecified).AddTicks(7917), new DateTime(2021, 5, 21, 9, 33, 13, 391, DateTimeKind.Unspecified).AddTicks(7787) },
                    { 72, 4, "YT46034-0", 2, new DateTime(2021, 12, 10, 21, 57, 51, 430, DateTimeKind.Unspecified).AddTicks(2923), new DateTime(2021, 5, 24, 21, 38, 31, 864, DateTimeKind.Unspecified).AddTicks(6239) },
                    { 95, 4, "YT58153-0", 5, new DateTime(2021, 10, 5, 3, 15, 28, 256, DateTimeKind.Unspecified).AddTicks(2862), new DateTime(2021, 5, 9, 10, 59, 8, 899, DateTimeKind.Unspecified).AddTicks(2831) },
                    { 68, 3, "YT38018-0", 2, new DateTime(2021, 9, 21, 21, 15, 38, 626, DateTimeKind.Unspecified).AddTicks(7691), new DateTime(2021, 7, 30, 14, 28, 50, 542, DateTimeKind.Unspecified).AddTicks(8137) },
                    { 59, 3, "YT69952-1", 2, new DateTime(2021, 10, 31, 20, 6, 5, 517, DateTimeKind.Unspecified).AddTicks(7587), new DateTime(2021, 5, 21, 23, 24, 50, 78, DateTimeKind.Unspecified).AddTicks(1100) },
                    { 54, 1, "YT41642-0", 2, new DateTime(2021, 10, 14, 7, 17, 12, 391, DateTimeKind.Unspecified).AddTicks(7839), new DateTime(2021, 7, 23, 7, 9, 26, 971, DateTimeKind.Unspecified).AddTicks(2142) },
                    { 53, 4, "YT32073-0", 2, new DateTime(2021, 11, 11, 12, 59, 58, 421, DateTimeKind.Unspecified).AddTicks(7027), new DateTime(2021, 7, 22, 18, 2, 54, 160, DateTimeKind.Unspecified).AddTicks(5823) },
                    { 49, 5, "YT25073-0", 2, new DateTime(2021, 12, 15, 18, 6, 2, 743, DateTimeKind.Unspecified).AddTicks(5064), new DateTime(2021, 6, 8, 4, 15, 15, 644, DateTimeKind.Unspecified).AddTicks(4740) },
                    { 44, 5, "YT59484-1", 2, new DateTime(2021, 10, 16, 16, 57, 48, 434, DateTimeKind.Unspecified).AddTicks(285), new DateTime(2021, 5, 10, 19, 54, 55, 82, DateTimeKind.Unspecified).AddTicks(1272) },
                    { 29, 1, "YT74921-0", 2, new DateTime(2021, 10, 17, 12, 39, 0, 882, DateTimeKind.Unspecified).AddTicks(3553), new DateTime(2021, 8, 9, 10, 47, 39, 436, DateTimeKind.Unspecified).AddTicks(9592) },
                    { 21, 3, "YT28957-1", 2, new DateTime(2021, 12, 15, 3, 42, 1, 177, DateTimeKind.Unspecified).AddTicks(1178), new DateTime(2021, 7, 7, 19, 8, 57, 794, DateTimeKind.Unspecified).AddTicks(8888) },
                    { 17, 2, "YT69353-1", 2, new DateTime(2021, 11, 1, 13, 7, 35, 392, DateTimeKind.Unspecified).AddTicks(5094), new DateTime(2021, 5, 17, 23, 28, 22, 695, DateTimeKind.Unspecified).AddTicks(6654) },
                    { 16, 3, "YT84270-0", 2, new DateTime(2021, 10, 8, 17, 41, 47, 966, DateTimeKind.Unspecified).AddTicks(8461), new DateTime(2021, 8, 25, 8, 27, 45, 655, DateTimeKind.Unspecified).AddTicks(4066) },
                    { 15, 3, "YT99759-1", 2, new DateTime(2021, 11, 27, 11, 55, 46, 593, DateTimeKind.Unspecified).AddTicks(3478), new DateTime(2021, 6, 28, 0, 54, 40, 366, DateTimeKind.Unspecified).AddTicks(9602) },
                    { 66, 3, "YT67990-0", 2, new DateTime(2021, 10, 4, 17, 21, 41, 302, DateTimeKind.Unspecified).AddTicks(9822), new DateTime(2021, 7, 28, 17, 31, 49, 759, DateTimeKind.Unspecified).AddTicks(2275) },
                    { 100, 1, "YT47606-1", 5, new DateTime(2021, 9, 8, 6, 22, 28, 241, DateTimeKind.Unspecified).AddTicks(6617), new DateTime(2021, 7, 15, 14, 30, 16, 845, DateTimeKind.Unspecified).AddTicks(1016) }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 47, "31004 Monte Knoll", null, "Sporerville", null, "I3J7T9", "YT" },
                    { 11, "8501 Jerde Ridges", null, "New Petra", null, "J8G0G5", "AB" },
                    { 19, "3815 Jones Wells", null, "West Christopher", null, "K8M1W2", "QC" },
                    { 32, "08972 Hope Mill", null, "Grimeston", null, "Y3F7A1", "PE" },
                    { 7, "236 Dare Brooks", null, "South Stevie", null, "L0E0G4", "YT" },
                    { 6, "2901 Cruickshank Grove", null, "East Ryleyshire", null, "Y5S4F9", "ON" },
                    { 40, "998 Ryan Court", null, "Bartolettishire", null, "Z7F6C6", "NL" },
                    { 39, "9187 Esteban Club", null, "Predovicton", null, "X0V1O7", "BC" },
                    { 49, "48525 Moore Divide", null, "Port German", null, "Z8S9G4", "NL" },
                    { 22, "757 Stephon Place", null, "Kubland", null, "U0I6P5", "NT" },
                    { 37, "6136 Aylin Mill", null, "Justinachester", null, "C6B7P1", "MB" },
                    { 3, "814 Jena Junctions", null, "West Garry", null, "J1B1D4", "SK" },
                    { 2, "245 Schamberger Stravenue", null, "New Abelardo", null, "Y9G5P1", "YT" },
                    { 45, "00274 Randall Summit", null, "Ziemeside", null, "W3H8T8", "MB" },
                    { 46, "7296 Guadalupe Streets", null, "South Jonathan", null, "F7F7W8", "NU" },
                    { 48, "033 Lester Islands", null, "Kathrynfurt", null, "L9A5D8", "NU" },
                    { 50, "5714 Schmeler Junction", null, "Port Omerville", null, "V6G5R5", "NT" },
                    { 36, "964 Lea Spurs", null, "Bogisichfort", null, "U8V0P9", "NU" },
                    { 8, "1518 Beth Forest", null, "Port Jaidamouth", null, "P8F4S5", "QC" },
                    { 41, "425 Kerluke Ridges", null, "Generalmouth", null, "K9R3L4", "PE" },
                    { 13, "6464 Murray Ports", null, "Port Axel", null, "B4W2K0", "NU" },
                    { 23, "59081 Brooke Square", null, "Destiniton", null, "X2O1B7", "ON" },
                    { 35, "60360 Seamus Pass", null, "Zboncakmouth", null, "S3D8T4", "NL" },
                    { 25, "5436 Hegmann Field", null, "Janetland", null, "W6M3U4", "NU" },
                    { 33, "07611 Welch Pass", null, "Marilyneside", null, "V0I6I2", "NT" },
                    { 21, "41571 Lakin Stravenue", null, "Lake Salvatore", null, "X7W0A1", "NU" },
                    { 24, "30708 Hodkiewicz River", null, "East Colton", null, "K7Y1Z5", "MB" },
                    { 31, "042 Kayla Skyway", null, "Ebertview", null, "Q3T2F3", "SK" },
                    { 26, "8308 Adriel Vista", null, "East Elnora", null, "F4T3F5", "NL" },
                    { 1, "5766 Lorine Extension", null, "North Amiyaville", null, "U4I6Z4", "ON" },
                    { 14, "553 Reilly Springs", null, "South Emmett", null, "W7W0B9", "PE" },
                    { 27, "53153 Pacocha Curve", null, "Tannerview", null, "S4A8N9", "AB" },
                    { 28, "420 McCullough Well", null, "Dooleyland", null, "H7Q3O8", "NB" },
                    { 17, "617 Lexie Mountains", null, "Wellingtonhaven", null, "R2A8F6", "NL" },
                    { 29, "7247 Pollich Spurs", null, "New Maymieview", null, "W2C2O3", "QC" },
                    { 9, "52149 Gutkowski Spurs", null, "Sabrynaberg", null, "H7S8P4", "MB" },
                    { 16, "11603 Domenica Cape", null, "Bauchview", null, "I1D8S4", "SK" },
                    { 43, "25016 Marquardt Passage", null, "Reillyfurt", null, "U5M2W7", "MB" },
                    { 20, "37572 Hermina Roads", null, "Pacochafort", null, "B9U9I8", "NL" },
                    { 30, "322 Elenora Falls", null, "Modestoport", null, "X1V0I7", "NL" },
                    { 38, "55122 Wintheiser Ports", null, "Lelandfurt", null, "F1G0A3", "PE" },
                    { 10, "890 Devyn Rest", null, "New Rachel", null, "J6I0N9", "ON" }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 18, "018 Barton Run", null, "South Cristal", null, "T9T8U9", "YT" },
                    { 15, "37849 Schumm Alley", null, "Robelbury", null, "D8V4I8", "NT" },
                    { 12, "6817 Mertz Fords", null, "Lenoreside", null, "G8N9O1", "BC" },
                    { 44, "83348 Ortiz Road", null, "North Adrienbury", null, "D1B7F5", "NB" },
                    { 42, "0177 Hillary Creek", null, "Maymieburgh", null, "H9E8R9", "YT" },
                    { 5, "2338 Mose Court", null, "Sengerfort", null, "Z2H8T1", "QC" },
                    { 4, "12900 Willms Brooks", null, "East Jamilburgh", null, "F8F1L4", "PE" },
                    { 34, "416 Brice Manors", null, "West Carrollshire", null, "C4Z4O8", "MB" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 103, "Occaecati vitae sit voluptatem.", 36, 3930m, "Gas", "Kg" },
                    { 139, "Qui cupiditate neque tempora cum quis.", 36, 9938m, "Solid", "L" },
                    { 286, "Harum aliquam dolor.", 57, 2978m, "Gas", "L" },
                    { 140, "Corrupti ea et magni enim.", 36, 12549m, "Solid", "L" },
                    { 339, "Totam ipsam autem quis aut quo est eum.", 36, 5247m, "Liquid", "L" },
                    { 104, "Quidem rem ab minima eligendi porro hic at.", 36, 7340m, "Gas", "Kg" },
                    { 479, "Quos expedita sapiente libero.", 24, 10811m, "Solid", "Kg" },
                    { 334, "Explicabo ut perspiciatis accusamus placeat sed.", 57, 15006m, "Solid", "Kg" },
                    { 370, "Ut repellendus quo facilis ea suscipit consectetur.", 57, 5410m, "Solid", "L" },
                    { 361, "Aliquam qui rerum possimus consequatur odio.", 36, 73m, "Liquid", "Kg" },
                    { 443, "Error vel veniam sit vel qui explicabo tempora suscipit quos.", 24, 4909m, "Gas", "Kg" },
                    { 372, "Quo nihil sit eos.", 24, 499m, "Gas", "L" },
                    { 298, "Voluptas assumenda fugit architecto hic.", 62, 4516m, "Gas", "L" },
                    { 333, "Consequatur optio aliquam accusamus.", 24, 3636m, "Gas", "Kg" },
                    { 243, "Consequatur cumque dolor impedit.", 24, 17922m, "Solid", "Kg" },
                    { 131, "Dolores delectus quis maiores.", 24, 14458m, "Liquid", "L" },
                    { 27, "Omnis officia consequatur cupiditate dolor omnis aspernatur exercitationem.", 24, 3406m, "Liquid", "Kg" },
                    { 59, "Consequatur nihil praesentium voluptas magnam omnis labore voluptatem consectetur minus.", 36, 1070m, "Gas", "Kg" },
                    { 175, "Doloremque adipisci quae dicta aut numquam alias quia nisi ut.", 43, 4125m, "Gas", "Kg" },
                    { 2, "Quia voluptates tempora et cumque eligendi magni.", 57, 1481m, "Liquid", "L" },
                    { 225, "Quia tempore aut facilis qui eum doloremque corrupti.", 57, 8931m, "Liquid", "L" },
                    { 142, "Eaque sit saepe porro nam laudantium et et consequatur exercitationem.", 43, 793m, "Solid", "Kg" },
                    { 129, "Et et fugiat explicabo dolores quaerat.", 43, 5052m, "Liquid", "L" },
                    { 83, "Libero magni ducimus laboriosam asperiores est facilis error a tempore.", 43, 15976m, "Gas", "L" },
                    { 214, "Illum omnis dolores.", 43, 5669m, "Solid", "Kg" },
                    { 8, "Consequatur fugit rerum tempore sapiente laudantium ex dolore est quibusdam.", 43, 14855m, "Gas", "L" },
                    { 271, "Quia modi et ut praesentium incidunt et.", 43, 16620m, "Solid", "L" },
                    { 417, "Sed quo quaerat non quo ipsum et.", 43, 12478m, "Liquid", "Kg" },
                    { 477, "Aut id quis.", 39, 381m, "Gas", "Kg" },
                    { 474, "Qui aut maxime.", 39, 2004m, "Solid", "Kg" },
                    { 411, "Quis qui sequi perferendis enim.", 39, 381m, "Gas", "Kg" },
                    { 410, "Ipsum tenetur eum veritatis aut.", 39, 4464m, "Liquid", "Kg" },
                    { 297, "Et ipsum ducimus quia quas.", 39, 2669m, "Liquid", "L" },
                    { 284, "Molestias voluptas ullam.", 39, 16284m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 480, "Consequatur autem possimus ut cumque vel.", 43, 7453m, "Gas", "L" },
                    { 184, "Dolorem explicabo explicabo enim laborum sit ut sint.", 39, 17024m, "Liquid", "L" },
                    { 77, "Pariatur molestiae porro commodi.", 39, 11470m, "Liquid", "Kg" },
                    { 481, "Provident sit eaque voluptas eos reprehenderit rem optio.", 36, 17982m, "Solid", "L" },
                    { 40, "Suscipit repellendus quia sint doloribus mollitia fugiat et numquam.", 57, 1221m, "Liquid", "L" },
                    { 448, "Ea ut recusandae velit error.", 36, 6288m, "Solid", "Kg" },
                    { 437, "Velit iure praesentium voluptas harum ullam.", 36, 4272m, "Solid", "L" },
                    { 88, "Ut omnis esse officiis corrupti eaque asperiores commodi totam quae.", 4, 19370m, "Liquid", "Kg" },
                    { 223, "Accusantium aliquid eum recusandae iste atque quod.", 89, 842m, "Solid", "L" },
                    { 305, "Ea debitis quidem dolorem est impedit et libero.", 22, 11598m, "Gas", "L" },
                    { 241, "Ipsa alias aspernatur.", 51, 17554m, "Gas", "Kg" },
                    { 118, "Repellat officiis aut voluptatem nostrum odio mollitia possimus id.", 51, 17229m, "Liquid", "Kg" },
                    { 453, "Totam aut ipsum delectus minus eligendi autem consequuntur qui.", 47, 14535m, "Gas", "Kg" },
                    { 402, "Molestiae et ipsam numquam fuga unde sapiente voluptates.", 47, 17872m, "Solid", "L" },
                    { 332, "Magni qui ut facere asperiores perferendis unde a.", 47, 12790m, "Gas", "Kg" },
                    { 326, "Et nesciunt officiis soluta cumque qui quos iusto.", 47, 17624m, "Liquid", "L" },
                    { 145, "Eos necessitatibus quas dolorem velit voluptas iusto voluptas molestiae aspernatur.", 47, 19342m, "Liquid", "L" },
                    { 91, "Id saepe sit debitis ut nisi omnis dicta accusamus explicabo.", 47, 1935m, "Liquid", "L" },
                    { 63, "Dolore dolorem praesentium nemo voluptatem.", 47, 11645m, "Solid", "Kg" },
                    { 20, "Sunt labore molestias sed consectetur sit.", 47, 5272m, "Gas", "L" },
                    { 13, "Iusto et similique.", 46, 17837m, "Liquid", "L" },
                    { 377, "Enim nemo labore doloremque facere cupiditate consequuntur architecto.", 42, 17250m, "Gas", "L" },
                    { 324, "Doloribus eos mollitia eligendi.", 42, 5548m, "Gas", "Kg" },
                    { 309, "Sit vel fugit et impedit quo.", 42, 12541m, "Gas", "Kg" },
                    { 154, "Sunt veniam sunt est voluptatem et eius qui.", 42, 1639m, "Gas", "Kg" },
                    { 133, "Et error voluptatem voluptatum rerum culpa laborum accusantium.", 42, 17413m, "Gas", "L" },
                    { 468, "Et nemo aliquid et aut velit fugiat.", 38, 11295m, "Gas", "Kg" },
                    { 442, "Rem aut cupiditate aut.", 38, 15878m, "Solid", "L" },
                    { 431, "Aperiam odit maiores voluptatibus vitae molestiae necessitatibus minus et ut.", 38, 2518m, "Solid", "Kg" },
                    { 395, "Voluptatem rerum nulla laudantium autem voluptatem rem quia dolores.", 38, 200m, "Solid", "Kg" },
                    { 354, "Et ut incidunt.", 38, 10075m, "Gas", "Kg" },
                    { 188, "Impedit et eum et fugit eius repudiandae consequatur aliquam.", 38, 3437m, "Liquid", "Kg" },
                    { 113, "Ipsa placeat veniam aliquam adipisci.", 38, 5612m, "Liquid", "Kg" },
                    { 100, "Et id eaque sequi sunt assumenda voluptates ab et fuga.", 38, 4750m, "Solid", "L" },
                    { 3, "Et nemo fuga amet veniam cum qui non facilis aperiam.", 38, 16097m, "Solid", "L" },
                    { 464, "Voluptatibus dolor earum et iste.", 34, 18014m, "Solid", "Kg" },
                    { 308, "Sit officiis illo.", 34, 2596m, "Solid", "Kg" },
                    { 255, "Aliquam qui dolore ea aliquid.", 34, 698m, "Solid", "L" },
                    { 111, "Dolore qui cumque aut.", 34, 132m, "Liquid", "L" },
                    { 260, "Autem impedit aut ab a nihil illum cupiditate qui.", 51, 6037m, "Solid", "L" },
                    { 302, "Mollitia nesciunt eaque dolorum suscipit molestiae.", 51, 1340m, "Liquid", "L" },
                    { 338, "Mollitia eaque quia dolores quisquam reiciendis eos rerum.", 51, 16572m, "Solid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 487, "Minus tempora voluptates alias voluptatem aliquid autem.", 51, 5543m, "Gas", "Kg" },
                    { 264, "Tenetur eum cumque eum et voluptas voluptatem eum minus.", 22, 1155m, "Gas", "Kg" },
                    { 126, "Explicabo temporibus suscipit similique.", 22, 19761m, "Solid", "Kg" },
                    { 390, "Optio eos dolores distinctio qui iste asperiores accusantium nihil.", 99, 18146m, "Liquid", "L" },
                    { 256, "Qui ut corporis quia illum enim molestiae.", 99, 10986m, "Gas", "L" },
                    { 246, "Ad quis ut vel ratione et et exercitationem praesentium.", 99, 10855m, "Gas", "Kg" },
                    { 240, "Sint non molestiae voluptatem enim voluptate a ducimus voluptas ut.", 99, 18127m, "Gas", "L" },
                    { 205, "Velit laboriosam sed et dolorem esse corporis.", 99, 13123m, "Solid", "L" },
                    { 187, "Voluptatibus beatae nemo magnam.", 99, 984m, "Solid", "L" },
                    { 120, "Iusto ea in et corrupti enim et aliquid voluptatibus eos.", 99, 4952m, "Liquid", "Kg" },
                    { 263, "Eum reprehenderit omnis.", 89, 12726m, "Solid", "Kg" },
                    { 394, "Alias aut eum odio unde quis quae quo ea.", 84, 1172m, "Solid", "Kg" },
                    { 229, "Voluptates vel ut facilis quam fugiat est repellendus ut.", 84, 18378m, "Gas", "Kg" },
                    { 46, "Tempora error accusamus hic eos dolor non fuga temporibus quia.", 84, 15775m, "Solid", "L" },
                    { 355, "Nihil vel fugiat culpa soluta possimus aspernatur.", 78, 14557m, "Solid", "Kg" },
                    { 469, "Ducimus voluptatum asperiores.", 22, 1736m, "Solid", "L" },
                    { 345, "Aperiam optio expedita amet.", 78, 5740m, "Liquid", "Kg" },
                    { 224, "Ullam accusamus corrupti aut libero eligendi.", 78, 9574m, "Solid", "Kg" },
                    { 160, "Quia alias similique qui facere veritatis labore magni.", 78, 18843m, "Solid", "L" },
                    { 495, "Repudiandae asperiores unde veritatis.", 74, 12335m, "Liquid", "L" },
                    { 490, "Vitae cupiditate quod molestiae numquam voluptatibus quidem iure.", 74, 5903m, "Liquid", "L" },
                    { 323, "Ea exercitationem repudiandae minima recusandae voluptate totam aliquam iure.", 74, 18707m, "Solid", "L" },
                    { 56, "Iusto modi dolores reprehenderit reprehenderit quia eaque tempora laudantium.", 74, 13401m, "Gas", "Kg" },
                    { 44, "Ut et voluptates vel ratione ipsum quam et illo facilis.", 74, 13512m, "Liquid", "L" },
                    { 41, "Molestiae rem cumque placeat voluptates iure.", 74, 8311m, "Liquid", "L" },
                    { 371, "Aut itaque ut placeat necessitatibus unde neque aut eos.", 73, 4262m, "Solid", "L" },
                    { 350, "Eius quo adipisci.", 56, 1467m, "Liquid", "Kg" },
                    { 269, "Dolor voluptas perferendis in iste a nostrum rem.", 56, 3603m, "Solid", "L" },
                    { 61, "Aut placeat omnis voluptas quidem est.", 56, 3521m, "Gas", "L" },
                    { 330, "Consequatur tempore est quas.", 52, 10797m, "Gas", "L" },
                    { 66, "Ipsam sit et odit et et aut architecto sapiente provident.", 52, 3678m, "Solid", "Kg" },
                    { 314, "Enim harum qui vitae sint voluptatibus et ut iste corrupti.", 78, 8523m, "Gas", "Kg" },
                    { 405, "Doloribus necessitatibus ullam eaque.", 62, 14934m, "Gas", "Kg" },
                    { 292, "Ipsa nesciunt aliquid dolorum quis quisquam deserunt dolor commodi atque.", 85, 18112m, "Liquid", "Kg" },
                    { 210, "Quo fugit illo sit.", 64, 79m, "Gas", "L" },
                    { 143, "Adipisci vel doloremque.", 83, 15746m, "Gas", "L" },
                    { 72, "Deserunt occaecati ut itaque iusto doloribus velit aut.", 83, 5391m, "Liquid", "Kg" },
                    { 38, "Occaecati quasi et laboriosam corrupti.", 83, 7548m, "Gas", "Kg" },
                    { 299, "Eum ut perferendis voluptate.", 71, 14044m, "Liquid", "Kg" },
                    { 218, "Asperiores iure dicta eaque maiores voluptates nam sint qui accusantium.", 71, 5204m, "Solid", "L" },
                    { 141, "Quia fuga voluptatum adipisci aliquid ratione accusantium voluptatem.", 71, 16838m, "Solid", "Kg" },
                    { 93, "Odio et recusandae accusamus eos deserunt voluptates velit vero.", 71, 1274m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 68, "Atque eos ut.", 71, 10352m, "Gas", "L" },
                    { 54, "Quas explicabo pariatur sunt.", 71, 5752m, "Liquid", "L" },
                    { 465, "Qui ea dolorem.", 63, 18947m, "Liquid", "Kg" },
                    { 14, "Debitis aut qui labore sequi cupiditate nostrum.", 63, 9874m, "Solid", "Kg" },
                    { 1, "Placeat aut asperiores vel dolorem modi facilis unde minima.", 63, 1544m, "Solid", "Kg" },
                    { 476, "Aliquam odio corrupti quo aut error cupiditate explicabo non deleniti.", 55, 9899m, "Solid", "L" },
                    { 177, "Pariatur dignissimos quisquam.", 83, 1780m, "Gas", "L" },
                    { 360, "Dolorem nihil mollitia impedit voluptatum.", 55, 3676m, "Liquid", "L" },
                    { 180, "Assumenda minima doloremque et.", 55, 14260m, "Solid", "Kg" },
                    { 173, "Corrupti totam debitis laborum inventore earum eius.", 55, 18204m, "Liquid", "Kg" },
                    { 159, "Saepe odit cupiditate quis cumque recusandae ipsum tempora sunt et.", 55, 13346m, "Liquid", "Kg" },
                    { 96, "Modi minima amet nobis reiciendis ea architecto dolores et temporibus.", 55, 17703m, "Liquid", "L" },
                    { 458, "Dolorem voluptatem quae adipisci neque aliquam animi cumque reiciendis architecto.", 41, 12260m, "Gas", "Kg" },
                    { 412, "Dolor rerum id voluptas omnis numquam.", 41, 3308m, "Gas", "Kg" },
                    { 247, "Velit harum reprehenderit voluptatibus libero consequatur explicabo.", 41, 7765m, "Liquid", "Kg" },
                    { 178, "A consectetur quo ratione praesentium ea quisquam ut et.", 41, 14131m, "Gas", "Kg" },
                    { 164, "Vel et non nihil ut sequi perspiciatis.", 41, 2907m, "Solid", "L" },
                    { 130, "Quidem veniam tempora blanditiis voluptates necessitatibus impedit qui.", 41, 15751m, "Solid", "Kg" },
                    { 407, "Deleniti rerum eius est dolorem quia illum.", 35, 10385m, "Liquid", "L" },
                    { 403, "Qui aut voluptatibus perspiciatis.", 35, 4611m, "Liquid", "L" },
                    { 123, "Odit dignissimos sed excepturi sit rerum ullam.", 35, 13383m, "Solid", "Kg" },
                    { 221, "Qui possimus architecto voluptatem aperiam pariatur.", 55, 6860m, "Solid", "L" },
                    { 185, "Earum omnis velit.", 83, 4510m, "Gas", "Kg" },
                    { 274, "Recusandae assumenda consequatur dolor non est eum et.", 83, 5177m, "Solid", "Kg" },
                    { 343, "Id accusantium similique eum iure deleniti quia non rerum.", 83, 6927m, "Gas", "L" },
                    { 250, "Omnis tempore et aut voluptatem quia aliquam.", 100, 13244m, "Solid", "L" },
                    { 249, "Culpa tempora omnis.", 100, 10368m, "Solid", "L" },
                    { 202, "Error nam impedit inventore molestiae id doloribus corrupti.", 100, 14635m, "Liquid", "L" },
                    { 191, "Totam rem repellendus illum magnam.", 100, 18493m, "Solid", "L" },
                    { 447, "Pariatur ex quod et odit inventore in illum quos velit.", 95, 502m, "Gas", "L" },
                    { 388, "Perferendis voluptatem quos.", 95, 12780m, "Gas", "L" },
                    { 270, "Qui dicta laborum porro nisi.", 95, 3330m, "Liquid", "L" },
                    { 230, "Quaerat ratione quod.", 95, 4368m, "Liquid", "Kg" },
                    { 211, "Aut fuga excepturi odio ut ut.", 95, 11546m, "Liquid", "L" },
                    { 400, "Aut aspernatur rerum sed excepturi nam exercitationem aut.", 93, 10385m, "Liquid", "Kg" },
                    { 208, "Provident molestias consectetur.", 93, 2549m, "Gas", "Kg" },
                    { 81, "Libero quia at iure et et temporibus.", 93, 18705m, "Gas", "Kg" },
                    { 475, "Possimus veniam ut pariatur nostrum et qui maxime voluptatum aliquam.", 92, 5792m, "Liquid", "L" },
                    { 383, "Commodi et iste est.", 92, 18871m, "Liquid", "Kg" },
                    { 170, "Et nihil voluptate non soluta repellendus fugit aut sit.", 92, 14914m, "Liquid", "L" },
                    { 122, "Nulla natus quaerat molestiae id nihil omnis provident.", 92, 18674m, "Solid", "L" },
                    { 116, "Placeat enim sunt et eos dignissimos est est.", 92, 13092m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 95, "Ab omnis aut ut molestiae cupiditate quaerat.", 92, 6232m, "Solid", "Kg" },
                    { 434, "Perferendis ut cum voluptatem.", 90, 11736m, "Solid", "L" },
                    { 419, "Beatae mollitia qui vero veniam quo.", 90, 16412m, "Solid", "L" },
                    { 315, "Eum omnis voluptas ipsum perspiciatis vel distinctio aut.", 90, 2794m, "Solid", "L" },
                    { 219, "Quos incidunt tempora at qui rerum veniam labore.", 90, 4079m, "Solid", "Kg" },
                    { 199, "Quos nostrum quisquam quos voluptates voluptatem.", 90, 19109m, "Solid", "Kg" },
                    { 147, "Voluptatem odit omnis.", 90, 9420m, "Liquid", "Kg" },
                    { 76, "Quo officiis distinctio suscipit eligendi sit et debitis aut quae.", 90, 7807m, "Gas", "Kg" },
                    { 31, "Et ipsum ipsa quasi velit ipsum id fugit.", 90, 5864m, "Solid", "Kg" },
                    { 499, "Molestiae sit non molestias nesciunt inventore aut id ut.", 83, 9348m, "Solid", "Kg" },
                    { 444, "Dolorum illo rerum enim enim voluptas maxime necessitatibus.", 83, 1670m, "Gas", "L" },
                    { 404, "Ipsa corrupti necessitatibus consequatur accusantium exercitationem error reiciendis.", 83, 16182m, "Solid", "Kg" },
                    { 94, "Natus veniam inventore sit sed nemo voluptatem.", 35, 1794m, "Gas", "Kg" },
                    { 84, "Numquam officiis explicabo commodi vero in voluptate impedit.", 64, 7711m, "Liquid", "L" },
                    { 32, "Et quam quia tempore suscipit distinctio ducimus quae.", 35, 3735m, "Gas", "Kg" },
                    { 362, "Suscipit qui rem sed eos adipisci sint.", 33, 9255m, "Liquid", "Kg" },
                    { 179, "Ducimus rerum veniam iure itaque magni similique id.", 96, 2663m, "Gas", "Kg" },
                    { 153, "Ut facilis ut veritatis eveniet distinctio officia.", 96, 1873m, "Solid", "Kg" },
                    { 144, "Nobis aperiam quia eos rem omnis excepturi impedit deserunt placeat.", 96, 7722m, "Gas", "Kg" },
                    { 78, "Quisquam qui incidunt magni atque.", 96, 3577m, "Gas", "Kg" },
                    { 60, "Ipsam molestias dolores ut sequi sit asperiores et.", 96, 14290m, "Gas", "Kg" },
                    { 29, "Ipsa minima sapiente sint est blanditiis rerum eum nemo.", 96, 14912m, "Liquid", "L" },
                    { 17, "Quas dolor assumenda quos eveniet exercitationem quia.", 96, 13930m, "Gas", "L" },
                    { 7, "Enim rerum dolore quibusdam distinctio eum ut cum vel.", 96, 9142m, "Gas", "Kg" },
                    { 500, "Optio et perspiciatis magnam qui.", 88, 9561m, "Gas", "Kg" },
                    { 456, "Et ut dolorem nesciunt.", 88, 18821m, "Solid", "Kg" },
                    { 415, "Ullam omnis inventore sed reiciendis voluptatibus id.", 88, 14666m, "Gas", "Kg" },
                    { 392, "Voluptatem recusandae nobis et reiciendis facere quisquam quasi.", 88, 15421m, "Liquid", "Kg" },
                    { 318, "Esse nam unde est expedita aliquam molestias.", 88, 12488m, "Liquid", "L" },
                    { 259, "Voluptates cupiditate magni molestiae enim non est quia ipsa.", 96, 5018m, "Gas", "Kg" },
                    { 190, "Nulla saepe debitis numquam minus sed fugit corrupti eos laborum.", 88, 3652m, "Gas", "L" },
                    { 433, "Et omnis odit voluptas incidunt.", 85, 729m, "Solid", "L" },
                    { 408, "Minima fuga ratione modi voluptatem explicabo dolore consectetur dolorem ullam.", 85, 4963m, "Solid", "Kg" },
                    { 296, "Quia suscipit consequatur et ea cumque.", 85, 13119m, "Liquid", "Kg" },
                    { 136, "Tempora similique est consequatur eaque qui voluptatem numquam cupiditate.", 85, 16997m, "Gas", "L" },
                    { 344, "Enim accusantium fugiat ipsa accusantium laborum quo sed.", 76, 4664m, "Gas", "L" },
                    { 310, "Rem quisquam quos ut sed.", 76, 17487m, "Gas", "Kg" },
                    { 108, "Eius fuga sunt necessitatibus soluta et voluptatem.", 76, 6438m, "Solid", "Kg" },
                    { 86, "Ipsum et autem voluptas maxime.", 76, 7161m, "Gas", "L" },
                    { 406, "Quam dolor nesciunt provident.", 64, 783m, "Gas", "L" },
                    { 389, "Cupiditate quia nam.", 64, 6937m, "Solid", "L" },
                    { 359, "Enim officia et corporis sint explicabo.", 64, 17490m, "Liquid", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 356, "Quod quia dignissimos.", 64, 7098m, "Gas", "Kg" },
                    { 268, "Provident est odit ipsum delectus officia est sed odit vitae.", 64, 8549m, "Gas", "Kg" },
                    { 435, "Rerum in molestias consequatur aut expedita explicabo aut in aperiam.", 85, 11937m, "Solid", "L" },
                    { 35, "Quia dolorum ut id molestiae ab eligendi sit repellendus illo.", 8, 17882m, "Liquid", "Kg" },
                    { 53, "Eveniet quia necessitatibus.", 8, 5951m, "Liquid", "L" },
                    { 156, "Ut aut veritatis impedit non atque.", 8, 6214m, "Gas", "L" },
                    { 306, "Nihil doloribus eos.", 33, 3834m, "Gas", "Kg" },
                    { 291, "Harum dolorem reiciendis et alias dolores doloremque omnis optio illum.", 33, 15917m, "Gas", "L" },
                    { 280, "Ab dolore similique rem minus qui.", 33, 2646m, "Liquid", "Kg" },
                    { 483, "Velit quibusdam aperiam pariatur aspernatur illum reprehenderit ducimus qui.", 31, 3954m, "Liquid", "L" },
                    { 290, "Sed unde fugiat repellendus explicabo nesciunt vel numquam.", 31, 3250m, "Gas", "L" },
                    { 278, "Fugit esse quibusdam at.", 31, 5662m, "Liquid", "Kg" },
                    { 257, "Aliquid asperiores quia qui consectetur eos sed enim qui ea.", 31, 5543m, "Liquid", "L" },
                    { 203, "Eum sed rerum ut hic consequatur.", 31, 16914m, "Liquid", "L" },
                    { 114, "Non facere assumenda.", 31, 12719m, "Liquid", "L" },
                    { 19, "Fugiat qui ea voluptatem excepturi.", 31, 1435m, "Gas", "Kg" },
                    { 4, "Et ut voluptates quos similique tenetur voluptas.", 31, 9933m, "Liquid", "Kg" },
                    { 422, "Repellendus fuga expedita numquam natus.", 27, 8074m, "Gas", "L" },
                    { 416, "Vel quis fugit.", 27, 5745m, "Gas", "Kg" },
                    { 152, "Error dolore et suscipit saepe sed.", 27, 5721m, "Solid", "L" },
                    { 128, "Id cumque ea corrupti.", 27, 10074m, "Liquid", "L" },
                    { 52, "Ab et eos perspiciatis autem rerum maiores debitis.", 27, 8323m, "Liquid", "L" },
                    { 466, "Libero repellendus voluptas molestias amet at explicabo.", 26, 6900m, "Liquid", "Kg" },
                    { 439, "Explicabo earum aperiam inventore.", 26, 11090m, "Liquid", "L" },
                    { 380, "Dolores omnis ut excepturi voluptate ab sequi aspernatur tempore mollitia.", 26, 12878m, "Gas", "Kg" },
                    { 253, "Qui error est optio.", 26, 10584m, "Liquid", "Kg" },
                    { 125, "Aut et vel iusto optio delectus illo vero autem.", 26, 14389m, "Liquid", "L" },
                    { 349, "Assumenda sunt at consectetur ex.", 25, 5925m, "Solid", "Kg" },
                    { 272, "Eos asperiores quis quidem alias et.", 25, 6032m, "Gas", "L" },
                    { 248, "Fugit commodi quia et expedita eum consequuntur laboriosam.", 25, 4933m, "Solid", "L" },
                    { 124, "Rerum fuga eos autem suscipit fuga.", 25, 8565m, "Solid", "L" },
                    { 105, "Omnis eos harum iusto quisquam cupiditate.", 25, 2995m, "Liquid", "L" },
                    { 79, "Placeat ea fugit eum fugit.", 25, 17652m, "Liquid", "Kg" },
                    { 200, "Ullam ad iste eos sit sed et ut.", 23, 15631m, "Liquid", "L" },
                    { 232, "Qui cumque reprehenderit accusantium ut quam dolor.", 13, 17713m, "Solid", "L" },
                    { 455, "Quidem voluptates et sed provident ut non.", 33, 2384m, "Solid", "L" },
                    { 110, "Consequatur consequuntur ipsa modi eum tempora.", 34, 14389m, "Gas", "L" },
                    { 82, "Necessitatibus culpa animi autem minus animi.", 28, 12018m, "Solid", "Kg" },
                    { 438, "Odit eos recusandae.", 30, 4927m, "Solid", "L" },
                    { 24, "Impedit labore quo magnam ducimus recusandae consequuntur nemo.", 97, 9024m, "Liquid", "Kg" },
                    { 6, "Et qui odit expedita labore eos sit ut ipsum et.", 97, 1556m, "Solid", "Kg" },
                    { 413, "Omnis expedita minima aut ut quidem aperiam.", 94, 5515m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 358, "Ducimus voluptatibus excepturi consequatur aliquid possimus.", 94, 5494m, "Liquid", "Kg" },
                    { 239, "Adipisci error nostrum quia.", 94, 7712m, "Gas", "Kg" },
                    { 112, "Asperiores error dolore ab quos animi.", 94, 11389m, "Gas", "Kg" },
                    { 482, "Ea iste odio.", 75, 18362m, "Gas", "L" },
                    { 376, "Qui eos illum quo.", 75, 13041m, "Gas", "L" },
                    { 234, "Asperiores voluptatum autem enim.", 75, 320m, "Gas", "Kg" },
                    { 228, "Reprehenderit laboriosam excepturi id debitis aut quidem quaerat.", 75, 8137m, "Liquid", "Kg" },
                    { 440, "Exercitationem non est accusamus.", 70, 15393m, "Gas", "L" },
                    { 421, "Commodi rerum mollitia autem quisquam voluptas expedita dolores vel in.", 70, 3595m, "Liquid", "L" },
                    { 374, "Debitis dolorum asperiores nulla.", 69, 14117m, "Gas", "L" },
                    { 43, "Tempora ad id repellendus.", 97, 10043m, "Solid", "Kg" },
                    { 368, "Rem nam aut nemo ipsam.", 69, 7520m, "Liquid", "L" },
                    { 294, "Perferendis vero quam minus eaque reiciendis est vel laudantium ipsum.", 69, 45m, "Liquid", "Kg" },
                    { 267, "Enim ut nesciunt consequatur adipisci nulla dolore.", 69, 3806m, "Liquid", "Kg" },
                    { 15, "Facere praesentium omnis.", 69, 8587m, "Solid", "L" },
                    { 492, "Sit voluptates recusandae.", 67, 13870m, "Liquid", "L" },
                    { 454, "Veniam eaque dicta.", 67, 19538m, "Liquid", "L" },
                    { 451, "Quasi asperiores quia.", 67, 13483m, "Solid", "L" },
                    { 429, "Numquam cumque consectetur ab blanditiis.", 67, 13212m, "Solid", "Kg" },
                    { 379, "Optio natus placeat ducimus nulla rerum at.", 67, 3682m, "Solid", "Kg" },
                    { 367, "Aliquam et vel consequatur quis similique est.", 67, 18190m, "Liquid", "Kg" },
                    { 346, "Labore laudantium ad.", 65, 18723m, "Solid", "L" },
                    { 341, "Nisi atque iusto animi nihil veritatis consequatur nulla nam esse.", 65, 19392m, "Liquid", "Kg" },
                    { 186, "Fugit exercitationem earum repellendus.", 65, 6180m, "Solid", "L" },
                    { 183, "Laudantium velit hic est.", 65, 11924m, "Liquid", "Kg" },
                    { 317, "Voluptas non et quisquam voluptatem maiores cupiditate.", 69, 19102m, "Gas", "L" },
                    { 55, "Totam officia incidunt sapiente voluptas.", 97, 2376m, "Solid", "Kg" },
                    { 106, "Dolorem voluptas consequuntur voluptas.", 97, 4299m, "Solid", "Kg" },
                    { 189, "Eum ea illo quibusdam sequi non corporis harum ut.", 97, 19129m, "Gas", "L" },
                    { 277, "Odit nihil reprehenderit esse.", 16, 1208m, "Gas", "L" },
                    { 132, "Maiores dicta ex fugit reprehenderit officiis.", 16, 562m, "Liquid", "Kg" },
                    { 446, "Ut voluptatem cum dolorum est repellat nobis.", 15, 17373m, "Solid", "L" },
                    { 436, "Sed non quia consequuntur et accusamus dignissimos minima.", 15, 6011m, "Gas", "Kg" },
                    { 236, "Animi maxime est et ea.", 15, 12063m, "Solid", "L" },
                    { 150, "Doloribus labore rerum architecto eos ab doloribus illum.", 15, 337m, "Solid", "Kg" },
                    { 80, "Qui ad fugit labore occaecati.", 15, 16763m, "Liquid", "L" },
                    { 37, "Dolores inventore impedit exercitationem laudantium autem eaque quaerat.", 15, 13555m, "Solid", "Kg" },
                    { 235, "Qui vel deleniti ut distinctio autem accusamus quia voluptas.", 7, 15958m, "Solid", "Kg" },
                    { 217, "Sit alias qui quo iste fugiat.", 7, 1445m, "Solid", "L" },
                    { 209, "Est similique nobis sit sed eaque magnam qui.", 7, 4916m, "Gas", "Kg" },
                    { 102, "Praesentium sit amet cupiditate quas.", 7, 1482m, "Gas", "L" },
                    { 385, "Dolorem eius incidunt aut quis sint debitis asperiores quia.", 3, 17726m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 426, "Qui repellat ex adipisci aut.", 2, 16227m, "Solid", "L" },
                    { 316, "Dolores id pariatur enim consequatur voluptatem ullam.", 2, 19015m, "Gas", "Kg" },
                    { 288, "Ut repellat dolores tempora.", 2, 8015m, "Solid", "Kg" },
                    { 261, "Officia maiores veritatis perferendis quia.", 2, 8408m, "Solid", "L" },
                    { 227, "Laborum et modi non animi minus animi laborum quia voluptatem.", 2, 10908m, "Gas", "L" },
                    { 212, "Nostrum non dolorum sint ullam.", 2, 15626m, "Gas", "Kg" },
                    { 494, "Expedita veniam doloribus iste molestias ut.", 1, 14724m, "Liquid", "L" },
                    { 485, "Ratione itaque blanditiis facere cum quaerat ut.", 1, 6686m, "Solid", "Kg" },
                    { 393, "Praesentium ut totam recusandae earum nisi repudiandae quasi.", 1, 18129m, "Liquid", "Kg" },
                    { 387, "Ut reprehenderit modi non.", 1, 9331m, "Liquid", "Kg" },
                    { 369, "Itaque iure fuga.", 1, 10211m, "Gas", "L" },
                    { 319, "Quidem sequi aliquam facere qui cumque occaecati omnis quae similique.", 1, 14058m, "Liquid", "L" },
                    { 254, "Ea molestiae iure qui sunt saepe est autem.", 1, 11206m, "Solid", "L" },
                    { 222, "Aliquam impedit voluptatem aut nam aspernatur eum porro.", 1, 18180m, "Gas", "L" },
                    { 65, "Illum et nihil odit voluptas ipsa dolorem sunt iure.", 1, 4864m, "Gas", "Kg" },
                    { 398, "Eveniet quia ea.", 97, 7574m, "Gas", "L" },
                    { 75, "Deserunt quisquam est.", 65, 870m, "Liquid", "L" },
                    { 423, "Consequatur dolores est quia sed eum.", 16, 6242m, "Gas", "L" },
                    { 459, "Non aperiam voluptas quibusdam.", 61, 10785m, "Gas", "L" },
                    { 275, "Sed modi et molestiae.", 61, 14167m, "Solid", "Kg" },
                    { 497, "Atque omnis sunt dolorem quam minus.", 19, 18363m, "Liquid", "Kg" },
                    { 432, "Quia natus aut suscipit.", 19, 4348m, "Gas", "Kg" },
                    { 295, "Eaque doloribus laborum nihil.", 19, 1940m, "Solid", "L" },
                    { 181, "Perspiciatis ut est facere officia.", 19, 13027m, "Liquid", "L" },
                    { 473, "Recusandae sapiente voluptas tempore quia magnam recusandae deleniti ipsum quo.", 18, 6099m, "Gas", "Kg" },
                    { 382, "Cum reprehenderit possimus inventore.", 18, 4650m, "Gas", "L" },
                    { 375, "Voluptate quia fuga assumenda dicta eos perspiciatis nesciunt in minima.", 18, 3509m, "Solid", "L" },
                    { 285, "In quia cum dolorum voluptatem quis veritatis et quaerat.", 18, 6861m, "Liquid", "L" },
                    { 489, "Numquam ut ea et quibusdam.", 12, 16752m, "Solid", "Kg" },
                    { 45, "Soluta saepe et est dolor earum officiis consectetur voluptas.", 12, 12057m, "Solid", "L" },
                    { 21, "Consequatur assumenda qui reprehenderit repellendus commodi eos totam temporibus.", 12, 1000m, "Gas", "Kg" },
                    { 460, "Nostrum consequatur qui at quibusdam enim quo minima.", 10, 2150m, "Liquid", "L" },
                    { 450, "Ad ut ut non.", 10, 4114m, "Liquid", "L" },
                    { 322, "Nulla a optio rerum voluptate enim repudiandae.", 32, 5103m, "Solid", "L" },
                    { 168, "Officiis ea exercitationem nulla.", 10, 1094m, "Solid", "Kg" },
                    { 237, "Laboriosam id modi mollitia quo rerum aliquid.", 9, 8726m, "Solid", "Kg" },
                    { 207, "Amet animi et maiores dolor voluptatem ut.", 9, 4448m, "Gas", "Kg" },
                    { 176, "Fugit ut aut nemo dolorum.", 9, 7613m, "Liquid", "L" },
                    { 169, "Veniam culpa deserunt ex eos.", 9, 6417m, "Solid", "Kg" },
                    { 92, "Saepe qui dignissimos molestiae.", 9, 11960m, "Solid", "Kg" },
                    { 36, "Accusantium vero excepturi eos commodi ea modi dicta atque sed.", 9, 15356m, "Solid", "L" },
                    { 493, "Odio dolor reprehenderit impedit illum rerum occaecati.", 5, 7856m, "Solid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 304, "Sint accusantium eligendi eveniet velit dolores.", 5, 9495m, "Solid", "L" },
                    { 148, "Doloribus sunt magnam.", 5, 3826m, "Liquid", "Kg" },
                    { 64, "Nostrum nam eos non odio a est.", 5, 15597m, "Solid", "L" },
                    { 28, "Explicabo illo rerum ea voluptatem consequatur eveniet provident molestias occaecati.", 5, 16210m, "Liquid", "Kg" },
                    { 18, "In libero fuga totam.", 5, 6462m, "Liquid", "L" },
                    { 293, "Dolores praesentium repellat aliquam maiores.", 4, 4281m, "Gas", "Kg" },
                    { 89, "Molestiae hic exercitationem animi.", 10, 9216m, "Gas", "Kg" },
                    { 498, "Nemo in voluptatibus recusandae voluptatum quo ut rerum ut qui.", 32, 3263m, "Gas", "Kg" },
                    { 69, "Et assumenda a maxime minima ipsum molestiae.", 37, 8109m, "Gas", "L" },
                    { 137, "Et nihil illo rerum laboriosam facere.", 37, 18575m, "Liquid", "L" },
                    { 215, "Tenetur officiis et dolores eos quisquam modi autem dolorum commodi.", 61, 10068m, "Gas", "L" },
                    { 51, "Quia tempore natus.", 61, 7622m, "Solid", "L" },
                    { 5, "Quasi optio cum ex nihil fugit magnam id laboriosam et.", 61, 1868m, "Gas", "L" },
                    { 384, "Sit accusantium aliquam quis.", 60, 3320m, "Liquid", "L" },
                    { 353, "Sit suscipit tenetur asperiores aperiam dicta.", 60, 9935m, "Gas", "Kg" },
                    { 325, "Eum omnis consequatur.", 60, 17748m, "Liquid", "L" },
                    { 282, "Ea occaecati harum ipsum.", 60, 19565m, "Solid", "Kg" },
                    { 12, "Totam itaque aperiam voluptatum quo rerum.", 60, 12940m, "Solid", "Kg" },
                    { 488, "Accusantium ipsa dolores quia quaerat et.", 58, 2651m, "Liquid", "Kg" },
                    { 457, "Doloremque perspiciatis sed dolore est porro tempore quia.", 58, 9590m, "Gas", "L" },
                    { 357, "Eligendi minima dolor consequuntur aut dolores quo.", 58, 11134m, "Solid", "Kg" },
                    { 281, "Adipisci culpa magnam nesciunt sed eos numquam qui quidem.", 58, 18103m, "Gas", "L" },
                    { 206, "Nisi cumque pariatur impedit non perspiciatis iusto voluptatum voluptas hic.", 58, 5222m, "Solid", "Kg" },
                    { 484, "Voluptatum dolorum quia consequatur voluptatem et ut nostrum.", 50, 15913m, "Gas", "Kg" },
                    { 352, "Et porro iusto sed beatae explicabo ut beatae dolor.", 50, 15871m, "Solid", "Kg" },
                    { 107, "Facilis quidem qui.", 50, 8162m, "Gas", "Kg" },
                    { 452, "Possimus earum libero tempore maxime alias impedit.", 48, 8174m, "Gas", "Kg" },
                    { 401, "Commodi molestiae ab atque.", 48, 3673m, "Solid", "L" },
                    { 273, "Exercitationem provident voluptatem rem.", 48, 14243m, "Liquid", "L" },
                    { 204, "Illo ut quam reprehenderit.", 48, 17210m, "Liquid", "L" },
                    { 428, "Rerum repellat accusamus voluptatibus omnis tenetur natus id.", 45, 5465m, "Solid", "L" },
                    { 301, "Sed repellat error eligendi asperiores voluptate voluptatum.", 45, 17636m, "Solid", "L" },
                    { 174, "Aut placeat ab ut laborum laborum inventore asperiores eveniet in.", 45, 12459m, "Liquid", "Kg" },
                    { 146, "Quibusdam ratione pariatur veniam quia nobis laboriosam quia a accusantium.", 45, 9872m, "Solid", "L" },
                    { 441, "Enim tenetur unde ipsa inventore voluptas repellendus.", 37, 4505m, "Gas", "Kg" },
                    { 430, "Atque autem voluptates cumque optio amet dolorem saepe numquam.", 37, 13232m, "Gas", "L" },
                    { 409, "Et dolores aliquam.", 37, 1228m, "Gas", "Kg" },
                    { 365, "Et doloribus consequatur beatae.", 37, 7401m, "Gas", "Kg" },
                    { 226, "Laudantium voluptate quis inventore rem id omnis eum.", 37, 7235m, "Solid", "Kg" },
                    { 364, "Perspiciatis odit expedita accusamus possimus ad a.", 61, 14838m, "Gas", "Kg" },
                    { 9, "Ut voluptatibus nostrum ipsam non est non unde.", 17, 16170m, "Liquid", "Kg" },
                    { 162, "Rerum aliquid qui.", 17, 13624m, "Gas", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 213, "Sapiente perferendis est itaque optio reprehenderit dolores aut nemo velit.", 17, 12148m, "Gas", "Kg" },
                    { 47, "Amet dignissimos atque praesentium aut odit est quis.", 6, 7253m, "Liquid", "Kg" },
                    { 39, "Alias error eveniet sed facere in distinctio sunt.", 6, 12287m, "Gas", "Kg" },
                    { 11, "Dolorem blanditiis accusantium.", 6, 4689m, "Liquid", "Kg" },
                    { 157, "Voluptatum voluptatem delectus ipsa consequatur et quod tempora quam.", 98, 6350m, "Gas", "L" },
                    { 121, "Iusto numquam ea sequi cum.", 98, 12092m, "Liquid", "L" },
                    { 196, "Quia quod dolorem earum eveniet.", 91, 172m, "Liquid", "L" },
                    { 172, "Mollitia magni rerum maiores.", 91, 13997m, "Liquid", "L" },
                    { 22, "Illo commodi totam iure tempora rerum reprehenderit quo.", 91, 9101m, "Gas", "Kg" },
                    { 311, "Officiis sit porro qui consectetur at.", 87, 3881m, "Solid", "L" },
                    { 307, "Qui alias molestias quam ut quaerat.", 87, 12598m, "Solid", "Kg" },
                    { 135, "Autem dolores quo.", 87, 7313m, "Gas", "L" },
                    { 449, "Et qui sit inventore.", 86, 429m, "Gas", "Kg" },
                    { 216, "Quia in dignissimos quo rerum quo qui.", 86, 398m, "Solid", "L" },
                    { 182, "Eveniet numquam asperiores vitae aut blanditiis saepe ipsa.", 6, 6018m, "Solid", "Kg" },
                    { 366, "Id quisquam doloremque ea numquam ut minima.", 82, 3536m, "Solid", "L" },
                    { 331, "Praesentium earum esse nostrum maiores molestias.", 81, 7228m, "Liquid", "Kg" },
                    { 194, "Qui illo ipsa repellat eveniet est eum voluptas nam aperiam.", 81, 17754m, "Liquid", "Kg" },
                    { 155, "Dolorem soluta rem earum sunt debitis eligendi ut.", 81, 8664m, "Liquid", "Kg" },
                    { 151, "A quos rerum veniam blanditiis architecto dignissimos accusamus.", 81, 15407m, "Solid", "L" },
                    { 149, "Ab porro cum tenetur labore dolor libero non modi occaecati.", 81, 11274m, "Liquid", "L" },
                    { 90, "Esse ea in sed molestiae voluptas aut aut odio.", 81, 8933m, "Liquid", "Kg" },
                    { 87, "Quia et consequatur iure qui iure voluptates quia ipsam voluptatem.", 81, 8381m, "Gas", "Kg" },
                    { 48, "Quasi omnis laudantium inventore quod impedit.", 81, 16544m, "Liquid", "Kg" },
                    { 486, "Sunt vitae dolore architecto ducimus et repellat non nihil.", 80, 1592m, "Solid", "L" },
                    { 396, "Libero et sunt soluta amet consequuntur facere dolorum.", 80, 13731m, "Liquid", "Kg" },
                    { 347, "Reprehenderit quas aut fugit illum eos laudantium fugit ipsum harum.", 80, 19685m, "Solid", "L" },
                    { 279, "Perferendis praesentium perferendis.", 80, 2593m, "Gas", "L" },
                    { 245, "Quis facere adipisci sunt accusamus quaerat.", 80, 7281m, "Solid", "Kg" },
                    { 71, "Voluptatem voluptas repudiandae quae quia aut asperiores.", 82, 16351m, "Liquid", "Kg" },
                    { 242, "Minus veritatis ea ratione.", 6, 11867m, "Liquid", "Kg" },
                    { 244, "A ipsum adipisci aspernatur occaecati quia sint sed neque.", 6, 7638m, "Liquid", "Kg" },
                    { 320, "Deserunt consequatur veritatis error ducimus consequuntur ut vero nisi rem.", 6, 12982m, "Gas", "Kg" },
                    { 251, "Dignissimos nobis quas ut a rerum.", 30, 19855m, "Solid", "L" },
                    { 192, "Delectus sed beatae animi molestiae aut voluptatem voluptates rerum.", 30, 10472m, "Gas", "Kg" },
                    { 161, "Voluptas itaque vitae occaecati sint qui architecto recusandae nulla.", 30, 1135m, "Liquid", "Kg" },
                    { 134, "Nobis sapiente ipsum aut ut illum omnis impedit.", 30, 6450m, "Gas", "Kg" },
                    { 119, "Ducimus dolor quia necessitatibus.", 30, 3217m, "Liquid", "L" },
                    { 348, "Minus ut quia eum tempora nesciunt laborum rerum.", 28, 7748m, "Solid", "L" },
                    { 300, "Excepturi officiis voluptatem veritatis laborum voluptatem et ut nostrum.", 28, 18324m, "Liquid", "L" },
                    { 283, "Dolorum et voluptatem quo eum fugiat libero.", 28, 8439m, "Gas", "L" },
                    { 266, "Sed consequuntur iure quo tenetur qui.", 28, 3499m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 265, "Vero dolor non dicta sint laborum.", 28, 3945m, "Solid", "L" },
                    { 373, "Optio similique dolorem nemo voluptas fugit quae autem ullam.", 100, 18584m, "Solid", "Kg" },
                    { 73, "Modi delectus id perspiciatis.", 28, 5886m, "Solid", "Kg" },
                    { 478, "Facilis at quisquam sunt eum adipisci.", 20, 17696m, "Gas", "Kg" },
                    { 472, "Eum perspiciatis nihil enim est blanditiis.", 20, 13218m, "Gas", "L" },
                    { 471, "Rerum debitis quas mollitia laudantium.", 20, 13873m, "Liquid", "Kg" },
                    { 342, "Sit enim voluptas consequuntur rerum.", 20, 5937m, "Gas", "Kg" },
                    { 335, "Qui doloremque velit assumenda eveniet.", 20, 10160m, "Gas", "L" },
                    { 167, "Atque aut nemo magni.", 20, 15802m, "Solid", "Kg" },
                    { 49, "Aperiam ut inventore odit molestias illum commodi aut autem unde.", 20, 13091m, "Solid", "Kg" },
                    { 16, "Ut commodi aperiam omnis recusandae.", 20, 2273m, "Solid", "Kg" },
                    { 10, "Est velit fugit dolor aut voluptas.", 20, 7242m, "Solid", "L" },
                    { 289, "Neque dolorum vel commodi.", 14, 18774m, "Solid", "L" },
                    { 138, "Voluptas temporibus fugit consectetur quas.", 14, 160m, "Gas", "L" },
                    { 386, "Quaerat et nam ut eveniet neque impedit molestias.", 11, 15333m, "Solid", "L" },
                    { 231, "Voluptatem molestiae et ut sunt reiciendis.", 11, 19658m, "Solid", "L" },
                    { 220, "Aut sed voluptatem iusto quam soluta ducimus voluptas iste tempore.", 11, 14830m, "Liquid", "Kg" },
                    { 33, "Fugit voluptas quasi numquam qui repellat.", 11, 5499m, "Gas", "L" },
                    { 461, "Maxime eos et.", 6, 11972m, "Liquid", "L" },
                    { 363, "Dolores sequi sunt voluptate facilis minima sunt enim reprehenderit.", 6, 14920m, "Solid", "Kg" },
                    { 427, "Perspiciatis qui cumque perspiciatis dolor id facilis laboriosam necessitatibus sunt.", 79, 4083m, "Solid", "L" },
                    { 171, "Est consequatur quam qui voluptatum commodi voluptas.", 79, 3382m, "Liquid", "Kg" },
                    { 34, "Ipsam aut sunt sapiente nulla quam nesciunt enim dolorem.", 79, 13589m, "Gas", "L" },
                    { 420, "Esse laudantium quas non consequatur aut aliquid aut.", 77, 5786m, "Solid", "Kg" },
                    { 399, "Quia tenetur nisi.", 49, 924m, "Liquid", "Kg" },
                    { 337, "Quia quia voluptatem molestiae quia id ut ipsam reiciendis temporibus.", 49, 6790m, "Gas", "Kg" },
                    { 329, "Odit aliquam qui.", 49, 11584m, "Gas", "L" },
                    { 328, "Non occaecati nobis distinctio voluptatibus sed dicta.", 49, 11414m, "Liquid", "Kg" },
                    { 303, "Nihil quas facere.", 49, 1684m, "Liquid", "L" },
                    { 195, "Molestiae esse recusandae quia adipisci ratione vero ut accusantium.", 49, 6140m, "Gas", "L" },
                    { 25, "Labore nesciunt odio ut.", 49, 6315m, "Solid", "Kg" },
                    { 418, "Ab sit minus sint voluptates minus.", 44, 18753m, "Gas", "Kg" },
                    { 252, "Eum sunt delectus dicta qui.", 44, 6622m, "Gas", "L" },
                    { 193, "Sapiente quo eveniet ut odio et et expedita.", 44, 7302m, "Gas", "Kg" },
                    { 85, "Perferendis perspiciatis et.", 44, 6256m, "Solid", "L" },
                    { 327, "Eius delectus suscipit labore minima illo expedita non aperiam soluta.", 29, 8292m, "Gas", "L" },
                    { 201, "Est dolores quisquam nisi necessitatibus fugiat quia ut voluptates velit.", 29, 16188m, "Liquid", "Kg" },
                    { 198, "Hic in quaerat nostrum omnis quis sint perferendis.", 29, 13824m, "Liquid", "Kg" },
                    { 158, "Placeat beatae natus consectetur.", 29, 2818m, "Gas", "L" },
                    { 101, "Non excepturi labore quis quia.", 29, 11369m, "Gas", "Kg" },
                    { 70, "Velit enim quidem eum repudiandae aspernatur.", 29, 8276m, "Gas", "L" },
                    { 42, "Quis vero sit qui sed dolorem ut sapiente ut.", 29, 9258m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 30, "Nesciunt totam in labore sed sunt.", 29, 11837m, "Solid", "Kg" },
                    { 491, "Fuga tenetur autem.", 21, 7624m, "Solid", "L" },
                    { 312, "Non hic est qui nihil aspernatur et culpa ad.", 21, 1376m, "Solid", "Kg" },
                    { 262, "Magni ut tempora.", 21, 19652m, "Gas", "Kg" },
                    { 233, "Et atque qui autem.", 21, 2263m, "Liquid", "L" },
                    { 58, "Magni dicta natus.", 21, 6684m, "Gas", "L" },
                    { 462, "Hic voluptatem optio praesentium reprehenderit dignissimos assumenda.", 17, 15586m, "Liquid", "Kg" },
                    { 340, "Soluta nihil odio culpa aut voluptas sint nesciunt dicta.", 17, 18521m, "Liquid", "L" },
                    { 321, "Harum sapiente quia cumque dicta repellat minus assumenda.", 17, 7408m, "Liquid", "Kg" },
                    { 258, "Consequuntur maiores tempora sed ut nisi.", 17, 7310m, "Gas", "L" },
                    { 238, "Optio quidem qui ex quas asperiores qui.", 17, 8090m, "Solid", "Kg" },
                    { 109, "Quia vitae reprehenderit assumenda repudiandae qui molestiae officia dolorum.", 53, 12777m, "Liquid", "Kg" },
                    { 98, "Dolorem ducimus delectus dolorem est debitis neque odit.", 34, 5162m, "Solid", "Kg" },
                    { 74, "Aut ut commodi quia.", 54, 12008m, "Solid", "Kg" },
                    { 276, "Enim autem ab sit vel iusto possimus non nulla aliquam.", 54, 10316m, "Liquid", "Kg" },
                    { 391, "Vel nam libero qui quidem ea voluptatum.", 77, 5142m, "Solid", "Kg" },
                    { 166, "Nemo quibusdam nobis dolorem sed quia quam a voluptatem.", 77, 4852m, "Gas", "Kg" },
                    { 117, "Vel voluptatum esse dolorem nostrum nisi.", 77, 8685m, "Gas", "Kg" },
                    { 378, "Nisi a labore possimus.", 72, 15390m, "Gas", "L" },
                    { 287, "Delectus exercitationem voluptate aspernatur at facere.", 72, 6626m, "Solid", "Kg" },
                    { 62, "Velit quae similique tenetur esse.", 72, 12458m, "Solid", "L" },
                    { 496, "Repellendus consequatur vero expedita ut.", 68, 19976m, "Liquid", "Kg" },
                    { 470, "Culpa non nisi qui eum tempore neque eveniet vitae.", 68, 2228m, "Solid", "L" },
                    { 445, "Saepe aut ratione.", 68, 6262m, "Gas", "L" },
                    { 424, "Labore dignissimos ab sunt modi excepturi aperiam et.", 68, 6455m, "Liquid", "L" },
                    { 381, "Animi eveniet accusantium fugiat qui rerum et est soluta.", 68, 5638m, "Liquid", "Kg" },
                    { 57, "Id perspiciatis ea aut blanditiis quas a veniam necessitatibus.", 68, 2854m, "Liquid", "Kg" },
                    { 23, "Et eos inventore velit culpa aperiam provident.", 68, 479m, "Gas", "L" },
                    { 463, "Voluptas et ex et maxime et impedit ea suscipit consectetur.", 66, 15183m, "Liquid", "L" },
                    { 397, "Tenetur illo non quia aspernatur.", 66, 204m, "Liquid", "Kg" },
                    { 336, "Autem asperiores nobis incidunt et nostrum magnam quos fugiat soluta.", 66, 19303m, "Liquid", "Kg" },
                    { 163, "Eos in optio.", 66, 16055m, "Solid", "L" },
                    { 115, "Et illum earum sed placeat voluptate dolore debitis doloribus.", 66, 14598m, "Gas", "L" },
                    { 99, "Ut in molestiae quaerat officiis labore molestiae corporis reiciendis molestiae.", 66, 9242m, "Gas", "Kg" },
                    { 67, "Voluptatibus quae accusamus commodi deleniti aut eius id repudiandae illum.", 66, 6687m, "Liquid", "L" },
                    { 50, "Vel dolorum consectetur molestias autem aut nihil aspernatur.", 66, 11047m, "Liquid", "Kg" },
                    { 26, "Impedit sit minus quidem culpa beatae nam facilis aspernatur.", 66, 13740m, "Solid", "L" },
                    { 425, "Voluptas nam in.", 59, 11030m, "Liquid", "Kg" },
                    { 313, "Ullam quo rerum sint.", 59, 5110m, "Liquid", "L" },
                    { 197, "Occaecati saepe officiis ullam cum aut.", 59, 2124m, "Liquid", "L" },
                    { 165, "Sit rerum non nostrum molestias aut animi dolor.", 59, 9791m, "Solid", "L" },
                    { 127, "Distinctio et esse quod mollitia hic corrupti aut quis totam.", 59, 13869m, "Liquid", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 414, "Ipsum natus et tenetur quidem amet labore expedita hic odit.", 54, 4558m, "Solid", "Kg" },
                    { 351, "Labore ut eum ut officia.", 54, 11742m, "Solid", "L" },
                    { 97, "Sit pariatur ut aliquam deserunt ut ipsam.", 54, 10820m, "Gas", "Kg" },
                    { 467, "Omnis consequatur in sequi repellendus animi ut.", 100, 7337m, "Solid", "Kg" }
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
