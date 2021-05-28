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
                    { 2, 5, "YT63049-0", 1, new DateTime(2021, 10, 5, 4, 33, 55, 133, DateTimeKind.Unspecified).AddTicks(1921), new DateTime(2021, 6, 29, 23, 37, 32, 840, DateTimeKind.Unspecified).AddTicks(7001) },
                    { 401, 3, "YT32200-0", 4, new DateTime(2021, 9, 14, 10, 58, 8, 686, DateTimeKind.Unspecified).AddTicks(8556), new DateTime(2021, 8, 24, 10, 8, 26, 751, DateTimeKind.Unspecified).AddTicks(6706) },
                    { 404, 4, "YT31696-0", 4, new DateTime(2021, 12, 21, 23, 24, 49, 79, DateTimeKind.Unspecified).AddTicks(2822), new DateTime(2021, 6, 19, 1, 42, 18, 59, DateTimeKind.Unspecified).AddTicks(855) },
                    { 409, 2, "YT65692-1", 4, new DateTime(2021, 10, 11, 11, 21, 59, 790, DateTimeKind.Unspecified).AddTicks(1782), new DateTime(2021, 5, 20, 19, 41, 12, 447, DateTimeKind.Unspecified).AddTicks(796) },
                    { 414, 1, "YT70745-1", 4, new DateTime(2021, 9, 8, 21, 1, 56, 33, DateTimeKind.Unspecified).AddTicks(5640), new DateTime(2021, 7, 18, 3, 36, 0, 437, DateTimeKind.Unspecified).AddTicks(1712) },
                    { 415, 5, "YT68776-1", 4, new DateTime(2021, 9, 18, 2, 10, 8, 503, DateTimeKind.Unspecified).AddTicks(1337), new DateTime(2021, 5, 16, 11, 6, 42, 512, DateTimeKind.Unspecified).AddTicks(2322) },
                    { 417, 4, "YT40339-1", 4, new DateTime(2021, 11, 13, 15, 16, 29, 697, DateTimeKind.Unspecified).AddTicks(6951), new DateTime(2021, 6, 12, 7, 10, 14, 625, DateTimeKind.Unspecified).AddTicks(4317) },
                    { 419, 2, "YT94296-0", 4, new DateTime(2021, 11, 24, 20, 40, 29, 328, DateTimeKind.Unspecified).AddTicks(6536), new DateTime(2021, 5, 11, 23, 9, 54, 186, DateTimeKind.Unspecified).AddTicks(1675) },
                    { 422, 4, "YT97518-0", 4, new DateTime(2021, 9, 14, 16, 45, 45, 994, DateTimeKind.Unspecified).AddTicks(3739), new DateTime(2021, 5, 23, 8, 7, 44, 490, DateTimeKind.Unspecified).AddTicks(4467) },
                    { 427, 3, "YT35743-1", 4, new DateTime(2021, 9, 25, 20, 4, 13, 784, DateTimeKind.Unspecified).AddTicks(9509), new DateTime(2021, 5, 25, 8, 57, 8, 533, DateTimeKind.Unspecified).AddTicks(1519) },
                    { 436, 3, "YT90410-1", 4, new DateTime(2021, 9, 6, 21, 9, 58, 889, DateTimeKind.Unspecified).AddTicks(2031), new DateTime(2021, 6, 27, 9, 37, 55, 621, DateTimeKind.Unspecified).AddTicks(6300) },
                    { 440, 3, "YT10021-1", 4, new DateTime(2021, 11, 27, 17, 57, 8, 156, DateTimeKind.Unspecified).AddTicks(8664), new DateTime(2021, 8, 1, 23, 54, 38, 87, DateTimeKind.Unspecified).AddTicks(1613) },
                    { 442, 2, "YT51570-0", 4, new DateTime(2021, 11, 26, 11, 23, 7, 979, DateTimeKind.Unspecified).AddTicks(9914), new DateTime(2021, 7, 29, 7, 46, 26, 248, DateTimeKind.Unspecified).AddTicks(3751) },
                    { 444, 1, "YT69301-0", 4, new DateTime(2021, 10, 23, 18, 36, 5, 996, DateTimeKind.Unspecified).AddTicks(3294), new DateTime(2021, 8, 5, 10, 9, 56, 63, DateTimeKind.Unspecified).AddTicks(1154) },
                    { 445, 2, "YT47733-0", 4, new DateTime(2021, 10, 30, 14, 34, 36, 617, DateTimeKind.Unspecified).AddTicks(5008), new DateTime(2021, 6, 26, 15, 53, 59, 322, DateTimeKind.Unspecified).AddTicks(1064) },
                    { 450, 5, "YT95279-0", 4, new DateTime(2021, 12, 11, 19, 24, 12, 342, DateTimeKind.Unspecified).AddTicks(8557), new DateTime(2021, 6, 12, 2, 13, 27, 859, DateTimeKind.Unspecified).AddTicks(2040) },
                    { 458, 5, "YT94366-0", 4, new DateTime(2021, 9, 17, 8, 21, 11, 738, DateTimeKind.Unspecified).AddTicks(4925), new DateTime(2021, 8, 4, 0, 6, 12, 387, DateTimeKind.Unspecified).AddTicks(8013) },
                    { 459, 2, "YT14038-1", 4, new DateTime(2021, 10, 20, 12, 48, 19, 630, DateTimeKind.Unspecified).AddTicks(793), new DateTime(2021, 6, 20, 14, 6, 7, 196, DateTimeKind.Unspecified).AddTicks(3556) },
                    { 460, 3, "YT82391-0", 4, new DateTime(2021, 11, 29, 12, 18, 20, 902, DateTimeKind.Unspecified).AddTicks(5586), new DateTime(2021, 5, 31, 4, 29, 45, 451, DateTimeKind.Unspecified).AddTicks(3035) },
                    { 461, 2, "YT30488-1", 4, new DateTime(2021, 10, 23, 19, 6, 4, 230, DateTimeKind.Unspecified).AddTicks(1090), new DateTime(2021, 5, 12, 2, 49, 27, 146, DateTimeKind.Unspecified).AddTicks(1048) },
                    { 463, 2, "YT31478-1", 4, new DateTime(2021, 11, 5, 3, 42, 1, 359, DateTimeKind.Unspecified).AddTicks(2934), new DateTime(2021, 8, 15, 11, 51, 56, 433, DateTimeKind.Unspecified).AddTicks(8639) },
                    { 468, 2, "YT28943-1", 4, new DateTime(2021, 11, 6, 22, 38, 42, 456, DateTimeKind.Unspecified).AddTicks(9104), new DateTime(2021, 8, 26, 14, 55, 17, 960, DateTimeKind.Unspecified).AddTicks(9191) },
                    { 483, 1, "YT26603-0", 4, new DateTime(2021, 9, 18, 19, 7, 54, 693, DateTimeKind.Unspecified).AddTicks(4004), new DateTime(2021, 7, 20, 17, 40, 31, 754, DateTimeKind.Unspecified).AddTicks(8273) },
                    { 485, 2, "YT10636-0", 4, new DateTime(2021, 9, 19, 18, 6, 51, 863, DateTimeKind.Unspecified).AddTicks(6986), new DateTime(2021, 8, 24, 17, 48, 4, 666, DateTimeKind.Unspecified).AddTicks(2715) },
                    { 486, 5, "YT65295-0", 4, new DateTime(2021, 10, 26, 17, 44, 0, 147, DateTimeKind.Unspecified).AddTicks(3000), new DateTime(2021, 6, 11, 0, 59, 20, 572, DateTimeKind.Unspecified).AddTicks(8032) },
                    { 487, 3, "YT89321-0", 4, new DateTime(2021, 10, 18, 4, 27, 27, 192, DateTimeKind.Unspecified).AddTicks(5885), new DateTime(2021, 6, 3, 23, 1, 20, 215, DateTimeKind.Unspecified).AddTicks(665) },
                    { 492, 1, "YT39665-0", 4, new DateTime(2021, 11, 16, 17, 1, 7, 130, DateTimeKind.Unspecified).AddTicks(9593), new DateTime(2021, 5, 27, 17, 59, 27, 195, DateTimeKind.Unspecified).AddTicks(1789) },
                    { 496, 2, "YT20820-1", 4, new DateTime(2021, 10, 22, 6, 36, 35, 322, DateTimeKind.Unspecified).AddTicks(9255), new DateTime(2021, 8, 6, 12, 22, 44, 176, DateTimeKind.Unspecified).AddTicks(5280) },
                    { 396, 1, "YT88904-0", 4, new DateTime(2021, 9, 10, 17, 11, 41, 912, DateTimeKind.Unspecified).AddTicks(7508), new DateTime(2021, 6, 26, 13, 6, 11, 622, DateTimeKind.Unspecified).AddTicks(9375) },
                    { 500, 4, "YT84905-0", 4, new DateTime(2021, 10, 4, 23, 2, 0, 14, DateTimeKind.Unspecified).AddTicks(460), new DateTime(2021, 7, 15, 15, 34, 17, 347, DateTimeKind.Unspecified).AddTicks(7082) },
                    { 391, 1, "YT89313-0", 4, new DateTime(2021, 9, 15, 10, 17, 51, 768, DateTimeKind.Unspecified).AddTicks(2400), new DateTime(2021, 5, 19, 12, 11, 7, 113, DateTimeKind.Unspecified).AddTicks(4408) },
                    { 382, 2, "YT92328-0", 4, new DateTime(2021, 11, 14, 4, 5, 48, 106, DateTimeKind.Unspecified).AddTicks(7354), new DateTime(2021, 5, 18, 15, 6, 47, 435, DateTimeKind.Unspecified).AddTicks(9566) },
                    { 231, 1, "YT13925-0", 4, new DateTime(2021, 11, 24, 6, 2, 16, 774, DateTimeKind.Unspecified).AddTicks(9271), new DateTime(2021, 7, 12, 18, 32, 40, 893, DateTimeKind.Unspecified).AddTicks(3983) },
                    { 245, 1, "YT29717-1", 4, new DateTime(2021, 12, 4, 20, 32, 40, 898, DateTimeKind.Unspecified).AddTicks(821), new DateTime(2021, 8, 26, 14, 13, 30, 858, DateTimeKind.Unspecified).AddTicks(8457) },
                    { 248, 2, "YT38136-0", 4, new DateTime(2021, 12, 18, 19, 29, 19, 346, DateTimeKind.Unspecified).AddTicks(186), new DateTime(2021, 5, 31, 21, 39, 37, 426, DateTimeKind.Unspecified).AddTicks(9720) },
                    { 254, 5, "YT50220-1", 4, new DateTime(2021, 11, 1, 1, 29, 47, 701, DateTimeKind.Unspecified).AddTicks(4975), new DateTime(2021, 8, 9, 3, 4, 38, 743, DateTimeKind.Unspecified).AddTicks(1321) },
                    { 257, 4, "YT11939-1", 4, new DateTime(2021, 12, 30, 1, 10, 41, 158, DateTimeKind.Unspecified).AddTicks(3697), new DateTime(2021, 6, 19, 21, 53, 4, 546, DateTimeKind.Unspecified).AddTicks(1914) },
                    { 276, 4, "YT36945-1", 4, new DateTime(2021, 9, 9, 4, 42, 21, 539, DateTimeKind.Unspecified).AddTicks(5383), new DateTime(2021, 5, 23, 17, 56, 31, 512, DateTimeKind.Unspecified).AddTicks(2854) },
                    { 279, 4, "YT50791-0", 4, new DateTime(2021, 9, 26, 13, 41, 39, 672, DateTimeKind.Unspecified).AddTicks(7920), new DateTime(2021, 8, 26, 10, 47, 51, 576, DateTimeKind.Unspecified).AddTicks(1410) },
                    { 281, 2, "YT43028-0", 4, new DateTime(2021, 12, 30, 21, 24, 52, 353, DateTimeKind.Unspecified).AddTicks(6794), new DateTime(2021, 8, 26, 14, 54, 6, 175, DateTimeKind.Unspecified).AddTicks(9534) },
                    { 288, 2, "YT22702-1", 4, new DateTime(2021, 10, 6, 11, 46, 57, 916, DateTimeKind.Unspecified).AddTicks(7543), new DateTime(2021, 8, 25, 16, 14, 6, 643, DateTimeKind.Unspecified).AddTicks(8625) },
                    { 289, 4, "YT65578-0", 4, new DateTime(2021, 12, 6, 16, 17, 40, 766, DateTimeKind.Unspecified).AddTicks(969), new DateTime(2021, 5, 14, 17, 25, 10, 78, DateTimeKind.Unspecified).AddTicks(317) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 293, 5, "YT66211-1", 4, new DateTime(2021, 10, 23, 10, 45, 29, 680, DateTimeKind.Unspecified).AddTicks(9943), new DateTime(2021, 6, 23, 19, 49, 37, 497, DateTimeKind.Unspecified).AddTicks(3278) },
                    { 294, 3, "YT42706-1", 4, new DateTime(2021, 11, 26, 9, 51, 40, 860, DateTimeKind.Unspecified).AddTicks(5660), new DateTime(2021, 8, 25, 13, 29, 12, 894, DateTimeKind.Unspecified).AddTicks(2632) },
                    { 295, 1, "YT48611-0", 4, new DateTime(2021, 10, 4, 12, 58, 48, 426, DateTimeKind.Unspecified).AddTicks(3471), new DateTime(2021, 7, 6, 17, 2, 27, 839, DateTimeKind.Unspecified).AddTicks(9562) },
                    { 296, 3, "YT69287-0", 4, new DateTime(2021, 9, 21, 5, 9, 50, 183, DateTimeKind.Unspecified).AddTicks(8255), new DateTime(2021, 6, 14, 22, 28, 42, 203, DateTimeKind.Unspecified).AddTicks(748) },
                    { 297, 3, "YT33917-0", 4, new DateTime(2021, 9, 13, 14, 13, 14, 187, DateTimeKind.Unspecified).AddTicks(8840), new DateTime(2021, 8, 7, 10, 32, 22, 174, DateTimeKind.Unspecified).AddTicks(9456) },
                    { 298, 3, "YT74984-1", 4, new DateTime(2021, 11, 2, 10, 12, 1, 586, DateTimeKind.Unspecified).AddTicks(7154), new DateTime(2021, 5, 10, 4, 24, 58, 263, DateTimeKind.Unspecified).AddTicks(8448) },
                    { 305, 5, "YT87915-1", 4, new DateTime(2021, 12, 5, 9, 32, 55, 196, DateTimeKind.Unspecified).AddTicks(1019), new DateTime(2021, 8, 3, 6, 31, 30, 879, DateTimeKind.Unspecified).AddTicks(8774) },
                    { 307, 1, "YT79628-0", 4, new DateTime(2021, 12, 21, 18, 34, 23, 776, DateTimeKind.Unspecified).AddTicks(6062), new DateTime(2021, 5, 11, 5, 2, 18, 38, DateTimeKind.Unspecified).AddTicks(7823) },
                    { 309, 5, "YT82563-0", 4, new DateTime(2021, 12, 15, 11, 36, 33, 435, DateTimeKind.Unspecified).AddTicks(879), new DateTime(2021, 6, 10, 10, 31, 8, 770, DateTimeKind.Unspecified).AddTicks(2340) },
                    { 315, 3, "YT19634-0", 4, new DateTime(2021, 9, 15, 20, 53, 55, 467, DateTimeKind.Unspecified).AddTicks(5524), new DateTime(2021, 6, 15, 14, 40, 46, 125, DateTimeKind.Unspecified).AddTicks(1326) },
                    { 321, 2, "YT16520-1", 4, new DateTime(2021, 10, 11, 16, 13, 2, 266, DateTimeKind.Unspecified).AddTicks(5010), new DateTime(2021, 5, 14, 1, 57, 10, 535, DateTimeKind.Unspecified).AddTicks(5164) },
                    { 350, 1, "YT62198-0", 4, new DateTime(2021, 10, 23, 6, 21, 18, 732, DateTimeKind.Unspecified).AddTicks(8856), new DateTime(2021, 5, 9, 5, 11, 54, 130, DateTimeKind.Unspecified).AddTicks(7694) },
                    { 354, 5, "YT13802-0", 4, new DateTime(2021, 10, 18, 4, 35, 24, 218, DateTimeKind.Unspecified).AddTicks(6877), new DateTime(2021, 6, 27, 16, 41, 5, 822, DateTimeKind.Unspecified).AddTicks(8901) },
                    { 364, 3, "YT98902-1", 4, new DateTime(2021, 11, 19, 12, 52, 23, 819, DateTimeKind.Unspecified).AddTicks(1391), new DateTime(2021, 5, 30, 23, 44, 49, 168, DateTimeKind.Unspecified).AddTicks(8507) },
                    { 367, 3, "YT57148-0", 4, new DateTime(2021, 10, 23, 6, 38, 56, 400, DateTimeKind.Unspecified).AddTicks(521), new DateTime(2021, 7, 4, 12, 48, 49, 652, DateTimeKind.Unspecified).AddTicks(4874) },
                    { 378, 3, "YT10989-1", 4, new DateTime(2021, 10, 29, 11, 2, 43, 414, DateTimeKind.Unspecified).AddTicks(319), new DateTime(2021, 8, 11, 10, 43, 25, 10, DateTimeKind.Unspecified).AddTicks(953) },
                    { 379, 5, "YT72626-0", 4, new DateTime(2021, 12, 1, 11, 37, 35, 155, DateTimeKind.Unspecified).AddTicks(6946), new DateTime(2021, 6, 8, 0, 53, 53, 43, DateTimeKind.Unspecified).AddTicks(3384) },
                    { 389, 3, "YT24780-0", 4, new DateTime(2021, 12, 20, 21, 49, 14, 327, DateTimeKind.Unspecified).AddTicks(3636), new DateTime(2021, 5, 19, 13, 40, 31, 118, DateTimeKind.Unspecified).AddTicks(3458) },
                    { 504, 5, "YT55871-1", 4, new DateTime(2021, 9, 2, 3, 31, 48, 486, DateTimeKind.Unspecified).AddTicks(1740), new DateTime(2021, 7, 6, 20, 5, 45, 726, DateTimeKind.Unspecified).AddTicks(9991) },
                    { 508, 4, "YT22843-1", 4, new DateTime(2021, 12, 28, 17, 12, 55, 577, DateTimeKind.Unspecified).AddTicks(6500), new DateTime(2021, 8, 23, 13, 57, 32, 584, DateTimeKind.Unspecified).AddTicks(591) },
                    { 517, 3, "YT14135-0", 4, new DateTime(2021, 11, 25, 1, 28, 27, 533, DateTimeKind.Unspecified).AddTicks(5155), new DateTime(2021, 5, 14, 22, 52, 38, 273, DateTimeKind.Unspecified).AddTicks(2182) },
                    { 665, 5, "YT81515-1", 4, new DateTime(2021, 9, 10, 0, 28, 4, 898, DateTimeKind.Unspecified).AddTicks(8481), new DateTime(2021, 7, 6, 21, 47, 16, 765, DateTimeKind.Unspecified).AddTicks(7803) },
                    { 667, 5, "YT31425-0", 4, new DateTime(2021, 9, 8, 6, 52, 23, 345, DateTimeKind.Unspecified).AddTicks(1827), new DateTime(2021, 6, 7, 13, 53, 41, 719, DateTimeKind.Unspecified).AddTicks(8515) },
                    { 670, 1, "YT73239-1", 4, new DateTime(2021, 10, 4, 14, 25, 12, 894, DateTimeKind.Unspecified).AddTicks(645), new DateTime(2021, 8, 26, 23, 3, 31, 362, DateTimeKind.Unspecified).AddTicks(6956) },
                    { 675, 5, "YT80978-1", 4, new DateTime(2021, 12, 15, 5, 45, 9, 561, DateTimeKind.Unspecified).AddTicks(1058), new DateTime(2021, 6, 14, 4, 38, 30, 733, DateTimeKind.Unspecified).AddTicks(9907) },
                    { 679, 3, "YT44803-1", 4, new DateTime(2021, 9, 10, 11, 35, 50, 928, DateTimeKind.Unspecified).AddTicks(8610), new DateTime(2021, 8, 20, 0, 43, 14, 110, DateTimeKind.Unspecified).AddTicks(5333) },
                    { 688, 4, "YT41418-0", 4, new DateTime(2021, 12, 26, 15, 32, 43, 648, DateTimeKind.Unspecified).AddTicks(756), new DateTime(2021, 7, 23, 14, 35, 29, 970, DateTimeKind.Unspecified).AddTicks(2993) },
                    { 692, 1, "YT62033-1", 4, new DateTime(2021, 12, 9, 11, 34, 6, 422, DateTimeKind.Unspecified).AddTicks(450), new DateTime(2021, 5, 25, 4, 1, 56, 982, DateTimeKind.Unspecified).AddTicks(585) },
                    { 693, 4, "YT54618-1", 4, new DateTime(2021, 10, 15, 15, 39, 10, 509, DateTimeKind.Unspecified).AddTicks(8680), new DateTime(2021, 5, 11, 7, 33, 26, 189, DateTimeKind.Unspecified).AddTicks(5601) },
                    { 704, 4, "YT22583-0", 4, new DateTime(2021, 12, 14, 8, 12, 34, 195, DateTimeKind.Unspecified).AddTicks(6145), new DateTime(2021, 6, 26, 12, 25, 38, 721, DateTimeKind.Unspecified).AddTicks(250) },
                    { 707, 2, "YT68209-0", 4, new DateTime(2021, 12, 8, 4, 7, 16, 198, DateTimeKind.Unspecified).AddTicks(6736), new DateTime(2021, 6, 11, 3, 28, 43, 306, DateTimeKind.Unspecified).AddTicks(3294) },
                    { 708, 3, "YT78358-0", 4, new DateTime(2021, 10, 29, 16, 29, 41, 436, DateTimeKind.Unspecified).AddTicks(970), new DateTime(2021, 5, 23, 6, 26, 37, 598, DateTimeKind.Unspecified).AddTicks(9897) },
                    { 709, 5, "YT21880-0", 4, new DateTime(2021, 10, 18, 12, 3, 7, 630, DateTimeKind.Unspecified).AddTicks(8271), new DateTime(2021, 5, 16, 15, 31, 47, 67, DateTimeKind.Unspecified).AddTicks(910) },
                    { 712, 2, "YT82133-1", 4, new DateTime(2021, 12, 29, 23, 28, 8, 223, DateTimeKind.Unspecified).AddTicks(6859), new DateTime(2021, 5, 25, 14, 47, 15, 914, DateTimeKind.Unspecified).AddTicks(868) },
                    { 714, 1, "YT28294-1", 4, new DateTime(2021, 10, 24, 0, 33, 50, 802, DateTimeKind.Unspecified).AddTicks(8260), new DateTime(2021, 7, 15, 13, 25, 2, 133, DateTimeKind.Unspecified).AddTicks(805) },
                    { 715, 5, "YT38475-1", 4, new DateTime(2021, 12, 19, 1, 15, 21, 324, DateTimeKind.Unspecified).AddTicks(2611), new DateTime(2021, 8, 10, 18, 14, 22, 319, DateTimeKind.Unspecified).AddTicks(8755) },
                    { 725, 5, "YT94895-0", 4, new DateTime(2021, 12, 20, 6, 9, 37, 259, DateTimeKind.Unspecified).AddTicks(6433), new DateTime(2021, 7, 13, 17, 10, 0, 217, DateTimeKind.Unspecified).AddTicks(5470) },
                    { 732, 2, "YT42522-1", 4, new DateTime(2021, 10, 28, 10, 57, 7, 175, DateTimeKind.Unspecified).AddTicks(2601), new DateTime(2021, 8, 20, 11, 8, 35, 207, DateTimeKind.Unspecified).AddTicks(5776) },
                    { 735, 3, "YT15660-0", 4, new DateTime(2021, 9, 27, 21, 51, 10, 759, DateTimeKind.Unspecified).AddTicks(2809), new DateTime(2021, 8, 29, 10, 58, 27, 912, DateTimeKind.Unspecified).AddTicks(8226) },
                    { 741, 3, "YT88974-1", 4, new DateTime(2021, 10, 7, 5, 39, 2, 229, DateTimeKind.Unspecified).AddTicks(1612), new DateTime(2021, 5, 11, 5, 34, 51, 182, DateTimeKind.Unspecified).AddTicks(818) },
                    { 745, 3, "YT13312-0", 4, new DateTime(2021, 9, 12, 19, 2, 38, 115, DateTimeKind.Unspecified).AddTicks(7571), new DateTime(2021, 6, 11, 16, 52, 38, 269, DateTimeKind.Unspecified).AddTicks(239) },
                    { 748, 2, "YT98195-0", 4, new DateTime(2021, 11, 13, 12, 37, 42, 86, DateTimeKind.Unspecified).AddTicks(2025), new DateTime(2021, 6, 28, 17, 48, 52, 840, DateTimeKind.Unspecified).AddTicks(9851) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 759, 5, "YT36798-1", 4, new DateTime(2021, 11, 12, 22, 30, 16, 613, DateTimeKind.Unspecified).AddTicks(8684), new DateTime(2021, 7, 23, 12, 25, 52, 986, DateTimeKind.Unspecified).AddTicks(5280) },
                    { 764, 1, "YT15744-1", 4, new DateTime(2021, 12, 27, 0, 41, 49, 201, DateTimeKind.Unspecified).AddTicks(3982), new DateTime(2021, 8, 26, 17, 22, 19, 12, DateTimeKind.Unspecified).AddTicks(2526) },
                    { 776, 3, "YT26745-0", 4, new DateTime(2021, 10, 23, 3, 37, 22, 296, DateTimeKind.Unspecified).AddTicks(7957), new DateTime(2021, 8, 21, 9, 59, 44, 373, DateTimeKind.Unspecified).AddTicks(3329) },
                    { 779, 3, "YT96670-1", 4, new DateTime(2021, 10, 29, 10, 13, 29, 886, DateTimeKind.Unspecified).AddTicks(152), new DateTime(2021, 5, 21, 8, 27, 53, 604, DateTimeKind.Unspecified).AddTicks(1464) },
                    { 782, 3, "YT46181-0", 4, new DateTime(2021, 12, 16, 12, 48, 38, 689, DateTimeKind.Unspecified).AddTicks(4810), new DateTime(2021, 8, 16, 17, 37, 1, 458, DateTimeKind.Unspecified).AddTicks(801) },
                    { 788, 5, "YT62790-0", 4, new DateTime(2021, 9, 13, 11, 3, 48, 559, DateTimeKind.Unspecified).AddTicks(6050), new DateTime(2021, 8, 3, 11, 1, 18, 877, DateTimeKind.Unspecified).AddTicks(7775) },
                    { 662, 2, "YT23091-0", 4, new DateTime(2021, 12, 26, 15, 23, 52, 468, DateTimeKind.Unspecified).AddTicks(154), new DateTime(2021, 5, 19, 5, 22, 16, 402, DateTimeKind.Unspecified).AddTicks(3895) },
                    { 660, 1, "YT83748-0", 4, new DateTime(2021, 11, 7, 11, 3, 42, 812, DateTimeKind.Unspecified).AddTicks(9051), new DateTime(2021, 5, 21, 13, 29, 57, 556, DateTimeKind.Unspecified).AddTicks(7448) },
                    { 653, 4, "YT43543-0", 4, new DateTime(2021, 9, 14, 7, 43, 4, 635, DateTimeKind.Unspecified).AddTicks(2662), new DateTime(2021, 7, 24, 22, 20, 19, 825, DateTimeKind.Unspecified).AddTicks(1920) },
                    { 648, 3, "YT76738-0", 4, new DateTime(2021, 11, 14, 21, 30, 30, 226, DateTimeKind.Unspecified).AddTicks(774), new DateTime(2021, 8, 18, 3, 47, 11, 287, DateTimeKind.Unspecified).AddTicks(30) },
                    { 523, 4, "YT10725-1", 4, new DateTime(2021, 12, 14, 14, 19, 35, 165, DateTimeKind.Unspecified).AddTicks(8218), new DateTime(2021, 6, 2, 20, 8, 33, 720, DateTimeKind.Unspecified).AddTicks(3748) },
                    { 530, 5, "YT49390-0", 4, new DateTime(2021, 11, 10, 19, 5, 13, 726, DateTimeKind.Unspecified).AddTicks(1383), new DateTime(2021, 7, 16, 7, 32, 22, 544, DateTimeKind.Unspecified).AddTicks(6830) },
                    { 537, 3, "YT32288-0", 4, new DateTime(2021, 11, 2, 19, 28, 47, 151, DateTimeKind.Unspecified).AddTicks(7454), new DateTime(2021, 6, 1, 15, 31, 53, 61, DateTimeKind.Unspecified).AddTicks(1442) },
                    { 552, 2, "YT34244-0", 4, new DateTime(2021, 10, 22, 0, 53, 12, 759, DateTimeKind.Unspecified).AddTicks(668), new DateTime(2021, 8, 26, 16, 57, 14, 401, DateTimeKind.Unspecified).AddTicks(2217) },
                    { 557, 4, "YT56370-1", 4, new DateTime(2021, 12, 30, 5, 9, 29, 296, DateTimeKind.Unspecified).AddTicks(5117), new DateTime(2021, 7, 21, 14, 23, 11, 465, DateTimeKind.Unspecified).AddTicks(1114) },
                    { 562, 4, "YT45957-0", 4, new DateTime(2021, 12, 19, 19, 59, 38, 543, DateTimeKind.Unspecified).AddTicks(5952), new DateTime(2021, 8, 15, 22, 23, 15, 960, DateTimeKind.Unspecified).AddTicks(6680) },
                    { 564, 5, "YT34851-0", 4, new DateTime(2021, 10, 21, 5, 52, 14, 927, DateTimeKind.Unspecified).AddTicks(9800), new DateTime(2021, 6, 19, 16, 31, 24, 305, DateTimeKind.Unspecified).AddTicks(6658) },
                    { 565, 4, "YT75555-0", 4, new DateTime(2021, 12, 21, 20, 4, 54, 853, DateTimeKind.Unspecified).AddTicks(2054), new DateTime(2021, 8, 26, 19, 41, 1, 224, DateTimeKind.Unspecified).AddTicks(63) },
                    { 574, 1, "YT55918-1", 4, new DateTime(2021, 9, 3, 13, 41, 37, 759, DateTimeKind.Unspecified).AddTicks(1834), new DateTime(2021, 6, 12, 21, 29, 38, 282, DateTimeKind.Unspecified).AddTicks(2030) },
                    { 576, 4, "YT47051-1", 4, new DateTime(2021, 11, 16, 13, 4, 0, 738, DateTimeKind.Unspecified).AddTicks(3929), new DateTime(2021, 8, 5, 7, 47, 59, 7, DateTimeKind.Unspecified).AddTicks(1156) },
                    { 577, 4, "YT32636-1", 4, new DateTime(2021, 10, 13, 17, 30, 35, 999, DateTimeKind.Unspecified).AddTicks(7402), new DateTime(2021, 6, 12, 16, 55, 5, 420, DateTimeKind.Unspecified).AddTicks(8309) },
                    { 579, 2, "YT37843-1", 4, new DateTime(2021, 11, 25, 2, 35, 2, 950, DateTimeKind.Unspecified).AddTicks(8321), new DateTime(2021, 8, 27, 6, 49, 48, 43, DateTimeKind.Unspecified).AddTicks(5909) },
                    { 585, 5, "YT69504-0", 4, new DateTime(2021, 9, 14, 22, 56, 49, 878, DateTimeKind.Unspecified).AddTicks(4921), new DateTime(2021, 7, 19, 19, 10, 29, 81, DateTimeKind.Unspecified).AddTicks(2978) },
                    { 227, 3, "YT63690-1", 4, new DateTime(2021, 12, 15, 22, 41, 0, 978, DateTimeKind.Unspecified).AddTicks(4685), new DateTime(2021, 7, 10, 18, 51, 24, 175, DateTimeKind.Unspecified).AddTicks(1355) },
                    { 587, 4, "YT25864-1", 4, new DateTime(2021, 12, 10, 17, 42, 48, 447, DateTimeKind.Unspecified).AddTicks(8297), new DateTime(2021, 7, 28, 8, 45, 58, 853, DateTimeKind.Unspecified).AddTicks(2997) },
                    { 597, 5, "YT51469-0", 4, new DateTime(2021, 10, 18, 0, 1, 33, 9, DateTimeKind.Unspecified).AddTicks(2320), new DateTime(2021, 6, 16, 15, 32, 32, 469, DateTimeKind.Unspecified).AddTicks(2990) },
                    { 598, 5, "YT87047-0", 4, new DateTime(2021, 9, 3, 22, 38, 58, 975, DateTimeKind.Unspecified).AddTicks(1069), new DateTime(2021, 6, 3, 20, 51, 55, 617, DateTimeKind.Unspecified).AddTicks(2670) },
                    { 604, 5, "YT26148-1", 4, new DateTime(2021, 11, 10, 6, 14, 31, 681, DateTimeKind.Unspecified).AddTicks(2611), new DateTime(2021, 5, 25, 4, 18, 0, 797, DateTimeKind.Unspecified).AddTicks(5916) },
                    { 614, 3, "YT13944-0", 4, new DateTime(2021, 11, 28, 21, 7, 59, 462, DateTimeKind.Unspecified).AddTicks(496), new DateTime(2021, 6, 16, 6, 23, 43, 51, DateTimeKind.Unspecified).AddTicks(4350) },
                    { 615, 4, "YT66117-1", 4, new DateTime(2021, 11, 21, 23, 13, 1, 855, DateTimeKind.Unspecified).AddTicks(3569), new DateTime(2021, 8, 4, 19, 59, 16, 822, DateTimeKind.Unspecified).AddTicks(9325) },
                    { 618, 5, "YT11209-1", 4, new DateTime(2021, 9, 29, 1, 3, 30, 364, DateTimeKind.Unspecified).AddTicks(455), new DateTime(2021, 6, 5, 11, 31, 39, 869, DateTimeKind.Unspecified).AddTicks(277) },
                    { 625, 1, "YT40940-0", 4, new DateTime(2021, 10, 16, 7, 55, 39, 984, DateTimeKind.Unspecified).AddTicks(160), new DateTime(2021, 7, 30, 9, 38, 42, 815, DateTimeKind.Unspecified).AddTicks(8621) },
                    { 626, 1, "YT74095-0", 4, new DateTime(2021, 11, 21, 5, 35, 41, 595, DateTimeKind.Unspecified).AddTicks(1659), new DateTime(2021, 8, 29, 8, 4, 1, 933, DateTimeKind.Unspecified).AddTicks(1745) },
                    { 628, 3, "YT22790-1", 4, new DateTime(2021, 9, 27, 21, 48, 33, 82, DateTimeKind.Unspecified).AddTicks(8478), new DateTime(2021, 7, 20, 17, 51, 13, 424, DateTimeKind.Unspecified).AddTicks(488) },
                    { 631, 4, "YT43824-1", 4, new DateTime(2021, 10, 29, 9, 4, 14, 513, DateTimeKind.Unspecified).AddTicks(9435), new DateTime(2021, 5, 23, 10, 30, 8, 335, DateTimeKind.Unspecified).AddTicks(6795) },
                    { 636, 1, "YT18197-0", 4, new DateTime(2021, 11, 17, 12, 20, 22, 66, DateTimeKind.Unspecified).AddTicks(5766), new DateTime(2021, 5, 27, 1, 0, 52, 811, DateTimeKind.Unspecified).AddTicks(2890) },
                    { 641, 4, "YT97205-1", 4, new DateTime(2021, 10, 26, 17, 40, 3, 800, DateTimeKind.Unspecified).AddTicks(6036), new DateTime(2021, 5, 27, 7, 59, 11, 588, DateTimeKind.Unspecified).AddTicks(2596) },
                    { 644, 3, "YT27513-1", 4, new DateTime(2021, 10, 26, 22, 37, 0, 229, DateTimeKind.Unspecified).AddTicks(8245), new DateTime(2021, 5, 30, 20, 17, 57, 666, DateTimeKind.Unspecified).AddTicks(2601) },
                    { 588, 5, "YT14381-1", 4, new DateTime(2021, 9, 18, 13, 5, 7, 580, DateTimeKind.Unspecified).AddTicks(8387), new DateTime(2021, 8, 30, 21, 58, 4, 702, DateTimeKind.Unspecified).AddTicks(5196) },
                    { 789, 4, "YT55923-1", 4, new DateTime(2021, 11, 14, 15, 7, 1, 880, DateTimeKind.Unspecified).AddTicks(7787), new DateTime(2021, 8, 20, 5, 0, 18, 615, DateTimeKind.Unspecified).AddTicks(2900) },
                    { 213, 3, "YT26739-1", 4, new DateTime(2021, 9, 2, 10, 36, 13, 792, DateTimeKind.Unspecified).AddTicks(3979), new DateTime(2021, 7, 13, 5, 7, 57, 238, DateTimeKind.Unspecified).AddTicks(8738) },
                    { 193, 5, "YT99656-0", 4, new DateTime(2021, 9, 29, 7, 36, 45, 912, DateTimeKind.Unspecified).AddTicks(7578), new DateTime(2021, 6, 28, 1, 19, 34, 373, DateTimeKind.Unspecified).AddTicks(3413) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 768, 1, "YT61766-0", 3, new DateTime(2021, 12, 17, 22, 12, 53, 21, DateTimeKind.Unspecified).AddTicks(9424), new DateTime(2021, 7, 28, 12, 21, 7, 747, DateTimeKind.Unspecified).AddTicks(2784) },
                    { 769, 3, "YT55240-0", 3, new DateTime(2021, 12, 18, 22, 48, 10, 119, DateTimeKind.Unspecified).AddTicks(8546), new DateTime(2021, 8, 10, 9, 53, 46, 759, DateTimeKind.Unspecified).AddTicks(1791) },
                    { 771, 1, "YT61446-1", 3, new DateTime(2021, 9, 3, 9, 22, 21, 668, DateTimeKind.Unspecified).AddTicks(7795), new DateTime(2021, 8, 22, 12, 15, 23, 26, DateTimeKind.Unspecified).AddTicks(3558) },
                    { 772, 4, "YT35074-1", 3, new DateTime(2021, 9, 12, 12, 23, 57, 380, DateTimeKind.Unspecified).AddTicks(3958), new DateTime(2021, 7, 25, 21, 57, 2, 441, DateTimeKind.Unspecified).AddTicks(2198) },
                    { 774, 3, "YT53224-1", 3, new DateTime(2021, 10, 24, 10, 26, 26, 753, DateTimeKind.Unspecified).AddTicks(2965), new DateTime(2021, 6, 10, 23, 51, 25, 180, DateTimeKind.Unspecified).AddTicks(9052) },
                    { 781, 3, "YT69547-1", 3, new DateTime(2021, 11, 14, 3, 25, 17, 137, DateTimeKind.Unspecified).AddTicks(1800), new DateTime(2021, 6, 28, 3, 52, 51, 320, DateTimeKind.Unspecified).AddTicks(6446) },
                    { 786, 1, "YT29326-1", 3, new DateTime(2021, 12, 19, 1, 53, 25, 901, DateTimeKind.Unspecified).AddTicks(8927), new DateTime(2021, 8, 8, 15, 13, 5, 47, DateTimeKind.Unspecified).AddTicks(7086) },
                    { 787, 4, "YT37470-1", 3, new DateTime(2021, 12, 20, 15, 37, 55, 356, DateTimeKind.Unspecified).AddTicks(6646), new DateTime(2021, 5, 8, 15, 6, 37, 601, DateTimeKind.Unspecified).AddTicks(3690) },
                    { 790, 4, "YT31965-1", 3, new DateTime(2021, 11, 23, 8, 25, 5, 873, DateTimeKind.Unspecified).AddTicks(6540), new DateTime(2021, 5, 16, 22, 12, 28, 747, DateTimeKind.Unspecified).AddTicks(4009) },
                    { 793, 5, "YT99733-0", 3, new DateTime(2021, 12, 26, 19, 11, 21, 710, DateTimeKind.Unspecified).AddTicks(206), new DateTime(2021, 7, 7, 12, 7, 20, 541, DateTimeKind.Unspecified).AddTicks(6260) },
                    { 800, 1, "YT72399-1", 3, new DateTime(2021, 12, 15, 4, 30, 30, 53, DateTimeKind.Unspecified).AddTicks(9182), new DateTime(2021, 7, 15, 5, 23, 33, 40, DateTimeKind.Unspecified).AddTicks(5174) },
                    { 813, 1, "YT51692-1", 3, new DateTime(2021, 10, 1, 16, 31, 22, 610, DateTimeKind.Unspecified).AddTicks(1208), new DateTime(2021, 8, 16, 12, 31, 50, 688, DateTimeKind.Unspecified).AddTicks(7521) },
                    { 819, 4, "YT42336-0", 3, new DateTime(2021, 12, 10, 14, 3, 9, 177, DateTimeKind.Unspecified).AddTicks(8883), new DateTime(2021, 8, 17, 21, 34, 24, 484, DateTimeKind.Unspecified).AddTicks(3523) },
                    { 821, 5, "YT21662-0", 3, new DateTime(2021, 10, 10, 7, 22, 20, 997, DateTimeKind.Unspecified).AddTicks(303), new DateTime(2021, 6, 27, 6, 24, 14, 563, DateTimeKind.Unspecified).AddTicks(3543) },
                    { 822, 4, "YT80889-0", 3, new DateTime(2021, 11, 3, 10, 16, 2, 622, DateTimeKind.Unspecified).AddTicks(7849), new DateTime(2021, 8, 4, 9, 59, 30, 517, DateTimeKind.Unspecified).AddTicks(6044) },
                    { 833, 5, "YT11769-1", 3, new DateTime(2021, 10, 3, 9, 34, 32, 162, DateTimeKind.Unspecified).AddTicks(7456), new DateTime(2021, 7, 2, 21, 59, 2, 430, DateTimeKind.Unspecified).AddTicks(1486) },
                    { 841, 1, "YT46726-1", 3, new DateTime(2021, 9, 8, 21, 29, 1, 791, DateTimeKind.Unspecified).AddTicks(5540), new DateTime(2021, 6, 30, 1, 13, 32, 946, DateTimeKind.Unspecified).AddTicks(8566) },
                    { 844, 3, "YT88418-0", 3, new DateTime(2021, 12, 17, 2, 40, 2, 281, DateTimeKind.Unspecified).AddTicks(5362), new DateTime(2021, 7, 17, 5, 26, 6, 388, DateTimeKind.Unspecified).AddTicks(3479) },
                    { 851, 5, "YT90621-1", 3, new DateTime(2021, 10, 31, 11, 31, 37, 292, DateTimeKind.Unspecified).AddTicks(6586), new DateTime(2021, 5, 25, 20, 2, 30, 755, DateTimeKind.Unspecified).AddTicks(1738) },
                    { 854, 4, "YT32288-0", 3, new DateTime(2021, 9, 9, 18, 30, 44, 657, DateTimeKind.Unspecified).AddTicks(3359), new DateTime(2021, 7, 9, 19, 1, 12, 181, DateTimeKind.Unspecified).AddTicks(8840) },
                    { 862, 2, "YT84231-1", 3, new DateTime(2021, 12, 26, 20, 51, 11, 491, DateTimeKind.Unspecified).AddTicks(5357), new DateTime(2021, 8, 22, 3, 19, 19, 266, DateTimeKind.Unspecified).AddTicks(9826) },
                    { 866, 4, "YT44355-0", 3, new DateTime(2021, 11, 16, 3, 32, 47, 935, DateTimeKind.Unspecified).AddTicks(9421), new DateTime(2021, 7, 22, 15, 54, 29, 359, DateTimeKind.Unspecified).AddTicks(6823) },
                    { 867, 2, "YT98976-1", 3, new DateTime(2021, 11, 26, 16, 49, 51, 124, DateTimeKind.Unspecified).AddTicks(8087), new DateTime(2021, 8, 12, 8, 58, 48, 390, DateTimeKind.Unspecified).AddTicks(6670) },
                    { 871, 2, "YT89971-0", 3, new DateTime(2021, 12, 21, 0, 25, 30, 834, DateTimeKind.Unspecified).AddTicks(5057), new DateTime(2021, 8, 30, 8, 1, 37, 929, DateTimeKind.Unspecified).AddTicks(471) },
                    { 872, 3, "YT56327-0", 3, new DateTime(2021, 11, 9, 7, 40, 42, 278, DateTimeKind.Unspecified).AddTicks(1626), new DateTime(2021, 6, 25, 7, 25, 22, 456, DateTimeKind.Unspecified).AddTicks(7180) },
                    { 875, 1, "YT45408-1", 3, new DateTime(2021, 9, 9, 14, 52, 14, 885, DateTimeKind.Unspecified).AddTicks(9515), new DateTime(2021, 6, 18, 9, 6, 28, 774, DateTimeKind.Unspecified).AddTicks(79) },
                    { 884, 4, "YT51140-0", 3, new DateTime(2021, 10, 9, 15, 12, 10, 775, DateTimeKind.Unspecified).AddTicks(8646), new DateTime(2021, 8, 6, 12, 2, 35, 255, DateTimeKind.Unspecified).AddTicks(7059) },
                    { 767, 3, "YT70286-1", 3, new DateTime(2021, 9, 11, 1, 23, 9, 377, DateTimeKind.Unspecified).AddTicks(3653), new DateTime(2021, 8, 24, 10, 18, 18, 617, DateTimeKind.Unspecified).AddTicks(9033) },
                    { 885, 3, "YT73653-0", 3, new DateTime(2021, 9, 23, 14, 58, 19, 581, DateTimeKind.Unspecified).AddTicks(5394), new DateTime(2021, 7, 13, 6, 4, 55, 979, DateTimeKind.Unspecified).AddTicks(9377) },
                    { 765, 4, "YT85744-0", 3, new DateTime(2021, 10, 20, 7, 9, 54, 616, DateTimeKind.Unspecified).AddTicks(451), new DateTime(2021, 7, 2, 17, 53, 48, 922, DateTimeKind.Unspecified).AddTicks(7428) },
                    { 761, 1, "YT25597-0", 3, new DateTime(2021, 9, 6, 1, 40, 55, 401, DateTimeKind.Unspecified).AddTicks(6782), new DateTime(2021, 5, 25, 10, 33, 2, 198, DateTimeKind.Unspecified).AddTicks(7880) },
                    { 649, 3, "YT20613-0", 3, new DateTime(2021, 11, 28, 4, 57, 20, 688, DateTimeKind.Unspecified).AddTicks(8359), new DateTime(2021, 8, 21, 22, 17, 50, 482, DateTimeKind.Unspecified).AddTicks(7712) },
                    { 650, 1, "YT58265-1", 3, new DateTime(2021, 9, 7, 0, 2, 58, 787, DateTimeKind.Unspecified).AddTicks(8455), new DateTime(2021, 7, 11, 20, 27, 7, 750, DateTimeKind.Unspecified).AddTicks(4221) },
                    { 651, 1, "YT63292-1", 3, new DateTime(2021, 12, 25, 3, 46, 55, 687, DateTimeKind.Unspecified).AddTicks(4497), new DateTime(2021, 7, 5, 1, 39, 47, 805, DateTimeKind.Unspecified).AddTicks(7463) },
                    { 652, 2, "YT93888-1", 3, new DateTime(2021, 9, 1, 10, 29, 54, 435, DateTimeKind.Unspecified).AddTicks(8957), new DateTime(2021, 6, 22, 8, 40, 8, 392, DateTimeKind.Unspecified).AddTicks(5974) },
                    { 657, 4, "YT58027-1", 3, new DateTime(2021, 9, 19, 19, 48, 48, 208, DateTimeKind.Unspecified).AddTicks(9208), new DateTime(2021, 7, 9, 0, 42, 1, 605, DateTimeKind.Unspecified).AddTicks(7566) },
                    { 666, 1, "YT73863-0", 3, new DateTime(2021, 12, 4, 0, 6, 2, 189, DateTimeKind.Unspecified).AddTicks(2245), new DateTime(2021, 7, 28, 7, 47, 36, 251, DateTimeKind.Unspecified).AddTicks(2946) },
                    { 671, 4, "YT45858-0", 3, new DateTime(2021, 11, 18, 1, 54, 30, 794, DateTimeKind.Unspecified).AddTicks(1579), new DateTime(2021, 7, 10, 11, 49, 42, 716, DateTimeKind.Unspecified).AddTicks(1019) },
                    { 676, 3, "YT15315-0", 3, new DateTime(2021, 9, 9, 1, 26, 31, 751, DateTimeKind.Unspecified).AddTicks(1219), new DateTime(2021, 7, 2, 1, 29, 35, 588, DateTimeKind.Unspecified).AddTicks(6282) },
                    { 689, 2, "YT75857-0", 3, new DateTime(2021, 12, 4, 5, 23, 56, 870, DateTimeKind.Unspecified).AddTicks(4424), new DateTime(2021, 8, 15, 18, 14, 25, 455, DateTimeKind.Unspecified).AddTicks(8473) },
                    { 699, 3, "YT24391-0", 3, new DateTime(2021, 11, 15, 20, 33, 30, 675, DateTimeKind.Unspecified).AddTicks(4022), new DateTime(2021, 5, 8, 23, 3, 55, 305, DateTimeKind.Unspecified).AddTicks(4344) },
                    { 701, 1, "YT53763-1", 3, new DateTime(2021, 11, 18, 12, 32, 0, 139, DateTimeKind.Unspecified).AddTicks(8776), new DateTime(2021, 8, 14, 1, 37, 57, 189, DateTimeKind.Unspecified).AddTicks(1666) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 702, 5, "YT52037-0", 3, new DateTime(2021, 9, 18, 5, 23, 30, 531, DateTimeKind.Unspecified).AddTicks(6595), new DateTime(2021, 7, 25, 0, 40, 16, 269, DateTimeKind.Unspecified).AddTicks(4942) },
                    { 703, 4, "YT37034-1", 3, new DateTime(2021, 9, 16, 3, 24, 34, 347, DateTimeKind.Unspecified).AddTicks(5509), new DateTime(2021, 5, 22, 19, 51, 34, 944, DateTimeKind.Unspecified).AddTicks(2466) },
                    { 705, 4, "YT18046-1", 3, new DateTime(2021, 9, 13, 17, 13, 50, 924, DateTimeKind.Unspecified).AddTicks(1614), new DateTime(2021, 7, 8, 14, 37, 52, 307, DateTimeKind.Unspecified).AddTicks(8898) },
                    { 710, 3, "YT76334-1", 3, new DateTime(2021, 12, 23, 17, 59, 38, 286, DateTimeKind.Unspecified).AddTicks(9715), new DateTime(2021, 5, 8, 17, 31, 41, 816, DateTimeKind.Unspecified).AddTicks(4824) },
                    { 711, 3, "YT24126-1", 3, new DateTime(2021, 12, 12, 17, 2, 24, 418, DateTimeKind.Unspecified).AddTicks(476), new DateTime(2021, 6, 4, 16, 30, 57, 297, DateTimeKind.Unspecified).AddTicks(3633) },
                    { 730, 5, "YT52249-0", 3, new DateTime(2021, 11, 26, 0, 14, 51, 494, DateTimeKind.Unspecified).AddTicks(4608), new DateTime(2021, 8, 23, 13, 7, 4, 535, DateTimeKind.Unspecified).AddTicks(5051) },
                    { 733, 2, "YT96675-1", 3, new DateTime(2021, 9, 21, 23, 44, 18, 4, DateTimeKind.Unspecified).AddTicks(1836), new DateTime(2021, 6, 12, 9, 39, 27, 193, DateTimeKind.Unspecified).AddTicks(8551) },
                    { 740, 2, "YT89262-0", 3, new DateTime(2021, 12, 1, 5, 41, 12, 388, DateTimeKind.Unspecified).AddTicks(2621), new DateTime(2021, 8, 17, 22, 18, 41, 180, DateTimeKind.Unspecified).AddTicks(4645) },
                    { 743, 1, "YT83617-0", 3, new DateTime(2021, 11, 21, 12, 41, 2, 691, DateTimeKind.Unspecified).AddTicks(691), new DateTime(2021, 7, 7, 23, 31, 24, 991, DateTimeKind.Unspecified).AddTicks(9207) },
                    { 746, 4, "YT47039-0", 3, new DateTime(2021, 10, 3, 21, 59, 34, 100, DateTimeKind.Unspecified).AddTicks(9083), new DateTime(2021, 8, 1, 21, 36, 9, 769, DateTimeKind.Unspecified).AddTicks(7197) },
                    { 751, 5, "YT65506-0", 3, new DateTime(2021, 9, 23, 14, 15, 0, 69, DateTimeKind.Unspecified).AddTicks(7077), new DateTime(2021, 6, 9, 16, 28, 45, 603, DateTimeKind.Unspecified).AddTicks(4487) },
                    { 752, 2, "YT55585-0", 3, new DateTime(2021, 11, 26, 1, 18, 56, 737, DateTimeKind.Unspecified).AddTicks(2550), new DateTime(2021, 5, 28, 10, 2, 39, 603, DateTimeKind.Unspecified).AddTicks(1208) },
                    { 754, 1, "YT27493-1", 3, new DateTime(2021, 11, 11, 21, 2, 41, 881, DateTimeKind.Unspecified).AddTicks(9977), new DateTime(2021, 7, 19, 10, 21, 27, 708, DateTimeKind.Unspecified).AddTicks(867) },
                    { 756, 5, "YT18068-0", 3, new DateTime(2021, 11, 26, 1, 8, 5, 969, DateTimeKind.Unspecified).AddTicks(6318), new DateTime(2021, 8, 25, 3, 29, 41, 6, DateTimeKind.Unspecified).AddTicks(768) },
                    { 758, 2, "YT13246-1", 3, new DateTime(2021, 9, 1, 4, 5, 35, 324, DateTimeKind.Unspecified).AddTicks(9097), new DateTime(2021, 5, 8, 0, 55, 5, 587, DateTimeKind.Unspecified).AddTicks(7850) },
                    { 760, 5, "YT45927-1", 3, new DateTime(2021, 11, 21, 13, 47, 49, 276, DateTimeKind.Unspecified).AddTicks(580), new DateTime(2021, 8, 5, 18, 41, 28, 214, DateTimeKind.Unspecified).AddTicks(4973) },
                    { 762, 1, "YT37912-1", 3, new DateTime(2021, 11, 8, 5, 37, 2, 726, DateTimeKind.Unspecified).AddTicks(6108), new DateTime(2021, 5, 30, 20, 50, 16, 447, DateTimeKind.Unspecified).AddTicks(9396) },
                    { 889, 3, "YT63732-0", 3, new DateTime(2021, 11, 25, 2, 42, 11, 552, DateTimeKind.Unspecified).AddTicks(8528), new DateTime(2021, 5, 30, 14, 39, 40, 644, DateTimeKind.Unspecified).AddTicks(1761) },
                    { 895, 4, "YT80175-0", 3, new DateTime(2021, 10, 14, 7, 43, 49, 899, DateTimeKind.Unspecified).AddTicks(5550), new DateTime(2021, 7, 26, 9, 58, 10, 32, DateTimeKind.Unspecified).AddTicks(3439) },
                    { 899, 5, "YT99304-0", 3, new DateTime(2021, 10, 23, 6, 48, 25, 104, DateTimeKind.Unspecified).AddTicks(2701), new DateTime(2021, 6, 1, 16, 31, 0, 112, DateTimeKind.Unspecified).AddTicks(9183) },
                    { 73, 1, "YT80596-0", 4, new DateTime(2021, 9, 2, 23, 45, 37, 331, DateTimeKind.Unspecified).AddTicks(5345), new DateTime(2021, 8, 3, 3, 36, 35, 917, DateTimeKind.Unspecified).AddTicks(8881) },
                    { 78, 1, "YT74814-0", 4, new DateTime(2021, 12, 15, 18, 34, 40, 57, DateTimeKind.Unspecified).AddTicks(9099), new DateTime(2021, 8, 21, 10, 5, 48, 665, DateTimeKind.Unspecified).AddTicks(2618) },
                    { 79, 5, "YT40958-0", 4, new DateTime(2021, 12, 6, 7, 49, 11, 376, DateTimeKind.Unspecified).AddTicks(7090), new DateTime(2021, 6, 21, 14, 38, 49, 61, DateTimeKind.Unspecified).AddTicks(9172) },
                    { 93, 2, "YT43621-0", 4, new DateTime(2021, 12, 4, 1, 54, 39, 553, DateTimeKind.Unspecified).AddTicks(1931), new DateTime(2021, 8, 20, 10, 19, 0, 242, DateTimeKind.Unspecified).AddTicks(4210) },
                    { 97, 5, "YT25562-1", 4, new DateTime(2021, 10, 25, 20, 54, 51, 464, DateTimeKind.Unspecified).AddTicks(5128), new DateTime(2021, 8, 14, 7, 24, 3, 457, DateTimeKind.Unspecified).AddTicks(7500) },
                    { 99, 2, "YT39519-1", 4, new DateTime(2021, 11, 28, 7, 33, 46, 333, DateTimeKind.Unspecified).AddTicks(6070), new DateTime(2021, 6, 12, 12, 49, 25, 512, DateTimeKind.Unspecified).AddTicks(8441) },
                    { 108, 4, "YT55205-1", 4, new DateTime(2021, 10, 4, 23, 42, 5, 829, DateTimeKind.Unspecified).AddTicks(5635), new DateTime(2021, 5, 24, 3, 43, 20, 231, DateTimeKind.Unspecified).AddTicks(2052) },
                    { 111, 4, "YT22062-1", 4, new DateTime(2021, 11, 1, 16, 33, 54, 65, DateTimeKind.Unspecified).AddTicks(9479), new DateTime(2021, 5, 15, 9, 13, 27, 707, DateTimeKind.Unspecified).AddTicks(808) },
                    { 117, 2, "YT95887-1", 4, new DateTime(2021, 9, 16, 5, 8, 59, 289, DateTimeKind.Unspecified).AddTicks(9957), new DateTime(2021, 7, 31, 11, 25, 29, 963, DateTimeKind.Unspecified).AddTicks(6913) },
                    { 119, 3, "YT10270-1", 4, new DateTime(2021, 10, 11, 18, 40, 44, 194, DateTimeKind.Unspecified).AddTicks(1768), new DateTime(2021, 5, 17, 20, 37, 0, 20, DateTimeKind.Unspecified).AddTicks(9978) },
                    { 120, 2, "YT32824-0", 4, new DateTime(2021, 9, 1, 1, 29, 57, 81, DateTimeKind.Unspecified).AddTicks(8932), new DateTime(2021, 5, 23, 13, 39, 34, 216, DateTimeKind.Unspecified).AddTicks(996) },
                    { 126, 4, "YT89829-1", 4, new DateTime(2021, 12, 3, 18, 39, 40, 751, DateTimeKind.Unspecified).AddTicks(7528), new DateTime(2021, 7, 9, 5, 14, 46, 829, DateTimeKind.Unspecified).AddTicks(80) },
                    { 136, 3, "YT80122-0", 4, new DateTime(2021, 12, 11, 17, 34, 54, 514, DateTimeKind.Unspecified).AddTicks(3309), new DateTime(2021, 7, 7, 22, 56, 17, 49, DateTimeKind.Unspecified).AddTicks(4205) },
                    { 137, 1, "YT56492-0", 4, new DateTime(2021, 10, 27, 2, 23, 28, 663, DateTimeKind.Unspecified).AddTicks(265), new DateTime(2021, 5, 15, 21, 14, 12, 108, DateTimeKind.Unspecified).AddTicks(6304) },
                    { 142, 3, "YT86155-1", 4, new DateTime(2021, 10, 22, 11, 0, 28, 506, DateTimeKind.Unspecified).AddTicks(9382), new DateTime(2021, 5, 9, 3, 0, 38, 285, DateTimeKind.Unspecified).AddTicks(9370) },
                    { 143, 3, "YT75817-0", 4, new DateTime(2021, 11, 24, 22, 2, 9, 872, DateTimeKind.Unspecified).AddTicks(6645), new DateTime(2021, 5, 8, 14, 33, 4, 166, DateTimeKind.Unspecified).AddTicks(1012) },
                    { 149, 3, "YT30404-0", 4, new DateTime(2021, 12, 10, 0, 12, 40, 781, DateTimeKind.Unspecified).AddTicks(5910), new DateTime(2021, 7, 21, 3, 9, 10, 656, DateTimeKind.Unspecified).AddTicks(2822) },
                    { 153, 1, "YT55274-0", 4, new DateTime(2021, 11, 23, 7, 6, 42, 837, DateTimeKind.Unspecified).AddTicks(7652), new DateTime(2021, 8, 29, 22, 58, 10, 324, DateTimeKind.Unspecified).AddTicks(3644) },
                    { 155, 1, "YT93263-0", 4, new DateTime(2021, 9, 7, 6, 59, 16, 148, DateTimeKind.Unspecified).AddTicks(5765), new DateTime(2021, 5, 10, 4, 54, 17, 802, DateTimeKind.Unspecified).AddTicks(8836) },
                    { 156, 3, "YT33955-1", 4, new DateTime(2021, 11, 4, 6, 56, 9, 576, DateTimeKind.Unspecified).AddTicks(1022), new DateTime(2021, 6, 14, 19, 17, 37, 679, DateTimeKind.Unspecified).AddTicks(537) },
                    { 158, 5, "YT74993-0", 4, new DateTime(2021, 10, 9, 12, 59, 37, 601, DateTimeKind.Unspecified).AddTicks(6990), new DateTime(2021, 8, 22, 9, 55, 27, 720, DateTimeKind.Unspecified).AddTicks(2489) },
                    { 161, 5, "YT24161-0", 4, new DateTime(2021, 12, 24, 18, 42, 18, 630, DateTimeKind.Unspecified).AddTicks(4781), new DateTime(2021, 8, 2, 17, 2, 4, 669, DateTimeKind.Unspecified).AddTicks(9351) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 178, 3, "YT20905-1", 4, new DateTime(2021, 12, 28, 15, 34, 50, 603, DateTimeKind.Unspecified).AddTicks(8143), new DateTime(2021, 6, 12, 21, 38, 41, 645, DateTimeKind.Unspecified).AddTicks(5808) },
                    { 182, 4, "YT28658-1", 4, new DateTime(2021, 11, 24, 12, 42, 44, 250, DateTimeKind.Unspecified).AddTicks(6470), new DateTime(2021, 8, 15, 0, 12, 19, 163, DateTimeKind.Unspecified).AddTicks(400) },
                    { 186, 1, "YT12033-1", 4, new DateTime(2021, 10, 30, 3, 19, 50, 324, DateTimeKind.Unspecified).AddTicks(7099), new DateTime(2021, 8, 30, 15, 32, 31, 797, DateTimeKind.Unspecified).AddTicks(2044) },
                    { 187, 5, "YT13533-0", 4, new DateTime(2021, 11, 18, 1, 19, 19, 734, DateTimeKind.Unspecified).AddTicks(1128), new DateTime(2021, 6, 3, 16, 5, 30, 277, DateTimeKind.Unspecified).AddTicks(9646) },
                    { 191, 2, "YT81034-0", 4, new DateTime(2021, 9, 3, 3, 48, 13, 837, DateTimeKind.Unspecified).AddTicks(3778), new DateTime(2021, 8, 5, 8, 5, 53, 986, DateTimeKind.Unspecified).AddTicks(3990) },
                    { 57, 5, "YT17116-0", 4, new DateTime(2021, 9, 15, 13, 14, 39, 197, DateTimeKind.Unspecified).AddTicks(2516), new DateTime(2021, 8, 21, 20, 30, 39, 31, DateTimeKind.Unspecified).AddTicks(304) },
                    { 55, 5, "YT80276-1", 4, new DateTime(2021, 10, 17, 11, 15, 20, 955, DateTimeKind.Unspecified).AddTicks(2462), new DateTime(2021, 7, 9, 8, 14, 53, 563, DateTimeKind.Unspecified).AddTicks(9997) },
                    { 50, 5, "YT94123-1", 4, new DateTime(2021, 9, 1, 20, 59, 23, 698, DateTimeKind.Unspecified).AddTicks(2808), new DateTime(2021, 7, 23, 4, 43, 19, 988, DateTimeKind.Unspecified).AddTicks(7888) },
                    { 47, 2, "YT70089-1", 4, new DateTime(2021, 10, 24, 14, 36, 5, 216, DateTimeKind.Unspecified).AddTicks(547), new DateTime(2021, 5, 16, 17, 25, 1, 464, DateTimeKind.Unspecified).AddTicks(3589) },
                    { 918, 1, "YT42750-1", 3, new DateTime(2021, 12, 16, 16, 32, 24, 135, DateTimeKind.Unspecified).AddTicks(335), new DateTime(2021, 8, 4, 8, 14, 2, 919, DateTimeKind.Unspecified).AddTicks(2532) },
                    { 927, 5, "YT71172-0", 3, new DateTime(2021, 10, 27, 6, 30, 9, 363, DateTimeKind.Unspecified).AddTicks(1198), new DateTime(2021, 7, 18, 6, 16, 56, 465, DateTimeKind.Unspecified).AddTicks(8711) },
                    { 929, 1, "YT57862-0", 3, new DateTime(2021, 11, 23, 10, 3, 53, 960, DateTimeKind.Unspecified).AddTicks(3518), new DateTime(2021, 6, 13, 3, 21, 7, 553, DateTimeKind.Unspecified).AddTicks(579) },
                    { 934, 3, "YT29087-0", 3, new DateTime(2021, 12, 6, 17, 17, 40, 943, DateTimeKind.Unspecified).AddTicks(2317), new DateTime(2021, 8, 16, 23, 11, 32, 502, DateTimeKind.Unspecified).AddTicks(1098) },
                    { 943, 4, "YT16529-0", 3, new DateTime(2021, 10, 14, 23, 25, 41, 329, DateTimeKind.Unspecified).AddTicks(8538), new DateTime(2021, 5, 12, 5, 59, 42, 218, DateTimeKind.Unspecified).AddTicks(7748) },
                    { 944, 2, "YT91337-0", 3, new DateTime(2021, 9, 14, 11, 5, 49, 146, DateTimeKind.Unspecified).AddTicks(4384), new DateTime(2021, 6, 23, 9, 16, 52, 841, DateTimeKind.Unspecified).AddTicks(8363) },
                    { 960, 2, "YT95844-0", 3, new DateTime(2021, 10, 22, 15, 57, 3, 34, DateTimeKind.Unspecified).AddTicks(853), new DateTime(2021, 7, 7, 0, 54, 2, 174, DateTimeKind.Unspecified).AddTicks(5300) },
                    { 961, 3, "YT37984-0", 3, new DateTime(2021, 11, 26, 19, 32, 12, 523, DateTimeKind.Unspecified).AddTicks(7155), new DateTime(2021, 6, 17, 16, 38, 47, 945, DateTimeKind.Unspecified).AddTicks(9472) },
                    { 964, 5, "YT73040-1", 3, new DateTime(2021, 9, 17, 23, 31, 48, 275, DateTimeKind.Unspecified).AddTicks(3188), new DateTime(2021, 7, 8, 13, 11, 10, 500, DateTimeKind.Unspecified).AddTicks(4556) },
                    { 971, 4, "YT41348-1", 3, new DateTime(2021, 12, 9, 7, 51, 45, 391, DateTimeKind.Unspecified).AddTicks(2429), new DateTime(2021, 8, 10, 5, 8, 21, 202, DateTimeKind.Unspecified).AddTicks(8959) },
                    { 977, 1, "YT31745-0", 3, new DateTime(2021, 12, 26, 11, 38, 37, 856, DateTimeKind.Unspecified).AddTicks(3403), new DateTime(2021, 7, 2, 11, 53, 6, 248, DateTimeKind.Unspecified).AddTicks(3313) },
                    { 979, 3, "YT28531-0", 3, new DateTime(2021, 10, 15, 9, 49, 36, 827, DateTimeKind.Unspecified).AddTicks(8048), new DateTime(2021, 5, 20, 23, 17, 21, 882, DateTimeKind.Unspecified).AddTicks(8744) },
                    { 981, 5, "YT55556-1", 3, new DateTime(2021, 9, 22, 4, 41, 47, 775, DateTimeKind.Unspecified).AddTicks(7706), new DateTime(2021, 8, 21, 1, 30, 11, 843, DateTimeKind.Unspecified).AddTicks(5110) },
                    { 196, 4, "YT63266-1", 4, new DateTime(2021, 12, 12, 8, 10, 4, 539, DateTimeKind.Unspecified).AddTicks(4155), new DateTime(2021, 5, 10, 19, 13, 18, 737, DateTimeKind.Unspecified).AddTicks(3883) },
                    { 987, 4, "YT54689-0", 3, new DateTime(2021, 9, 5, 23, 33, 54, 273, DateTimeKind.Unspecified).AddTicks(4687), new DateTime(2021, 6, 22, 17, 5, 59, 844, DateTimeKind.Unspecified).AddTicks(1575) },
                    { 993, 5, "YT35913-0", 3, new DateTime(2021, 10, 12, 8, 16, 46, 935, DateTimeKind.Unspecified).AddTicks(2214), new DateTime(2021, 5, 23, 19, 5, 52, 453, DateTimeKind.Unspecified).AddTicks(9105) },
                    { 994, 1, "YT74950-1", 3, new DateTime(2021, 10, 9, 22, 38, 39, 738, DateTimeKind.Unspecified).AddTicks(4782), new DateTime(2021, 5, 11, 23, 22, 23, 132, DateTimeKind.Unspecified).AddTicks(6185) },
                    { 997, 4, "YT68041-0", 3, new DateTime(2021, 9, 3, 12, 25, 13, 171, DateTimeKind.Unspecified).AddTicks(6966), new DateTime(2021, 7, 6, 15, 18, 49, 961, DateTimeKind.Unspecified).AddTicks(7905) },
                    { 6, 2, "YT53121-0", 4, new DateTime(2021, 10, 12, 21, 41, 58, 762, DateTimeKind.Unspecified).AddTicks(5966), new DateTime(2021, 8, 24, 15, 3, 22, 104, DateTimeKind.Unspecified).AddTicks(3002) },
                    { 8, 1, "YT31707-0", 4, new DateTime(2021, 11, 11, 5, 14, 24, 285, DateTimeKind.Unspecified).AddTicks(8593), new DateTime(2021, 8, 11, 16, 43, 32, 830, DateTimeKind.Unspecified).AddTicks(7429) },
                    { 15, 2, "YT72161-1", 4, new DateTime(2021, 9, 11, 18, 7, 44, 322, DateTimeKind.Unspecified).AddTicks(9595), new DateTime(2021, 5, 28, 7, 4, 50, 955, DateTimeKind.Unspecified).AddTicks(2901) },
                    { 16, 5, "YT21595-0", 4, new DateTime(2021, 12, 30, 22, 0, 54, 812, DateTimeKind.Unspecified).AddTicks(2790), new DateTime(2021, 6, 26, 23, 22, 0, 92, DateTimeKind.Unspecified).AddTicks(273) },
                    { 17, 4, "YT95569-0", 4, new DateTime(2021, 12, 10, 13, 32, 0, 764, DateTimeKind.Unspecified).AddTicks(25), new DateTime(2021, 7, 11, 6, 44, 12, 468, DateTimeKind.Unspecified).AddTicks(6256) },
                    { 23, 4, "YT59244-0", 4, new DateTime(2021, 9, 25, 17, 52, 21, 902, DateTimeKind.Unspecified).AddTicks(9372), new DateTime(2021, 7, 15, 13, 29, 49, 869, DateTimeKind.Unspecified).AddTicks(8020) },
                    { 25, 2, "YT29785-0", 4, new DateTime(2021, 12, 12, 12, 9, 59, 873, DateTimeKind.Unspecified).AddTicks(4514), new DateTime(2021, 7, 4, 6, 39, 54, 389, DateTimeKind.Unspecified).AddTicks(3172) },
                    { 31, 3, "YT56683-1", 4, new DateTime(2021, 10, 13, 14, 0, 33, 753, DateTimeKind.Unspecified).AddTicks(7866), new DateTime(2021, 5, 15, 17, 37, 45, 178, DateTimeKind.Unspecified).AddTicks(8649) },
                    { 32, 2, "YT92046-0", 4, new DateTime(2021, 11, 18, 19, 25, 3, 852, DateTimeKind.Unspecified).AddTicks(9766), new DateTime(2021, 7, 26, 19, 39, 42, 952, DateTimeKind.Unspecified).AddTicks(9362) },
                    { 39, 1, "YT92934-0", 4, new DateTime(2021, 10, 22, 20, 46, 27, 60, DateTimeKind.Unspecified).AddTicks(6100), new DateTime(2021, 7, 3, 6, 41, 49, 952, DateTimeKind.Unspecified).AddTicks(4402) },
                    { 990, 1, "YT78052-0", 3, new DateTime(2021, 11, 6, 7, 59, 44, 770, DateTimeKind.Unspecified).AddTicks(149), new DateTime(2021, 6, 7, 13, 7, 39, 680, DateTimeKind.Unspecified).AddTicks(5167) },
                    { 638, 2, "YT19849-1", 3, new DateTime(2021, 9, 12, 9, 52, 18, 210, DateTimeKind.Unspecified).AddTicks(2729), new DateTime(2021, 6, 14, 13, 34, 30, 657, DateTimeKind.Unspecified).AddTicks(7380) },
                    { 795, 5, "YT22802-0", 4, new DateTime(2021, 10, 2, 1, 3, 57, 610, DateTimeKind.Unspecified).AddTicks(4075), new DateTime(2021, 8, 10, 14, 50, 56, 243, DateTimeKind.Unspecified).AddTicks(467) },
                    { 801, 5, "YT51625-1", 4, new DateTime(2021, 12, 3, 22, 36, 47, 251, DateTimeKind.Unspecified).AddTicks(4198), new DateTime(2021, 7, 20, 18, 28, 36, 298, DateTimeKind.Unspecified).AddTicks(2252) },
                    { 546, 2, "YT93211-1", 5, new DateTime(2021, 11, 8, 21, 19, 36, 890, DateTimeKind.Unspecified).AddTicks(514), new DateTime(2021, 6, 30, 21, 33, 19, 706, DateTimeKind.Unspecified).AddTicks(6308) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 547, 2, "YT10165-1", 5, new DateTime(2021, 12, 10, 8, 41, 29, 994, DateTimeKind.Unspecified).AddTicks(3274), new DateTime(2021, 5, 28, 11, 23, 30, 207, DateTimeKind.Unspecified).AddTicks(8733) },
                    { 554, 3, "YT91275-1", 5, new DateTime(2021, 10, 25, 12, 2, 57, 416, DateTimeKind.Unspecified).AddTicks(5996), new DateTime(2021, 5, 24, 15, 40, 22, 434, DateTimeKind.Unspecified).AddTicks(8048) },
                    { 559, 1, "YT18466-1", 5, new DateTime(2021, 10, 6, 21, 56, 41, 857, DateTimeKind.Unspecified).AddTicks(7869), new DateTime(2021, 7, 26, 14, 18, 37, 529, DateTimeKind.Unspecified).AddTicks(1599) },
                    { 561, 1, "YT24215-1", 5, new DateTime(2021, 11, 7, 6, 42, 29, 398, DateTimeKind.Unspecified).AddTicks(6555), new DateTime(2021, 8, 23, 0, 51, 41, 58, DateTimeKind.Unspecified).AddTicks(4577) },
                    { 563, 5, "YT47241-0", 5, new DateTime(2021, 12, 23, 4, 57, 11, 310, DateTimeKind.Unspecified).AddTicks(7737), new DateTime(2021, 7, 11, 7, 36, 7, 24, DateTimeKind.Unspecified).AddTicks(6565) },
                    { 568, 1, "YT48908-0", 5, new DateTime(2021, 11, 4, 15, 46, 34, 472, DateTimeKind.Unspecified).AddTicks(4973), new DateTime(2021, 7, 27, 5, 41, 5, 514, DateTimeKind.Unspecified).AddTicks(4310) },
                    { 582, 3, "YT98692-0", 5, new DateTime(2021, 12, 18, 5, 43, 55, 207, DateTimeKind.Unspecified).AddTicks(9383), new DateTime(2021, 8, 26, 5, 48, 50, 743, DateTimeKind.Unspecified).AddTicks(4507) },
                    { 584, 1, "YT97131-1", 5, new DateTime(2021, 10, 28, 15, 17, 2, 401, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(2021, 6, 30, 5, 16, 27, 219, DateTimeKind.Unspecified).AddTicks(6524) },
                    { 595, 1, "YT70315-1", 5, new DateTime(2021, 11, 2, 4, 42, 16, 195, DateTimeKind.Unspecified).AddTicks(6124), new DateTime(2021, 7, 23, 12, 42, 18, 201, DateTimeKind.Unspecified).AddTicks(598) },
                    { 599, 5, "YT12091-0", 5, new DateTime(2021, 11, 23, 18, 49, 16, 599, DateTimeKind.Unspecified).AddTicks(3639), new DateTime(2021, 8, 26, 1, 8, 17, 842, DateTimeKind.Unspecified).AddTicks(1886) },
                    { 601, 4, "YT10929-0", 5, new DateTime(2021, 11, 12, 19, 25, 0, 471, DateTimeKind.Unspecified).AddTicks(5828), new DateTime(2021, 6, 7, 17, 16, 36, 140, DateTimeKind.Unspecified).AddTicks(426) },
                    { 613, 3, "YT19181-0", 5, new DateTime(2021, 11, 27, 3, 43, 18, 816, DateTimeKind.Unspecified).AddTicks(4875), new DateTime(2021, 8, 11, 10, 41, 35, 373, DateTimeKind.Unspecified).AddTicks(1925) },
                    { 616, 3, "YT91018-0", 5, new DateTime(2021, 9, 9, 3, 35, 14, 79, DateTimeKind.Unspecified).AddTicks(6677), new DateTime(2021, 5, 8, 9, 26, 52, 433, DateTimeKind.Unspecified).AddTicks(9173) },
                    { 617, 5, "YT81873-0", 5, new DateTime(2021, 12, 7, 11, 11, 19, 411, DateTimeKind.Unspecified).AddTicks(6759), new DateTime(2021, 7, 6, 10, 50, 49, 93, DateTimeKind.Unspecified).AddTicks(620) },
                    { 623, 5, "YT80744-0", 5, new DateTime(2021, 11, 13, 5, 48, 41, 140, DateTimeKind.Unspecified).AddTicks(9681), new DateTime(2021, 6, 27, 16, 18, 39, 180, DateTimeKind.Unspecified).AddTicks(4250) },
                    { 634, 3, "YT84526-1", 5, new DateTime(2021, 11, 20, 9, 49, 0, 873, DateTimeKind.Unspecified).AddTicks(7451), new DateTime(2021, 6, 13, 21, 15, 43, 92, DateTimeKind.Unspecified).AddTicks(7275) },
                    { 645, 2, "YT21107-0", 5, new DateTime(2021, 10, 10, 7, 31, 12, 381, DateTimeKind.Unspecified).AddTicks(5552), new DateTime(2021, 8, 13, 22, 5, 46, 755, DateTimeKind.Unspecified).AddTicks(8978) },
                    { 646, 2, "YT47141-1", 5, new DateTime(2021, 12, 10, 13, 19, 8, 563, DateTimeKind.Unspecified).AddTicks(7650), new DateTime(2021, 6, 1, 21, 25, 54, 646, DateTimeKind.Unspecified).AddTicks(6024) },
                    { 655, 1, "YT91893-1", 5, new DateTime(2021, 11, 20, 16, 7, 19, 742, DateTimeKind.Unspecified).AddTicks(1064), new DateTime(2021, 8, 9, 18, 0, 35, 258, DateTimeKind.Unspecified).AddTicks(2578) },
                    { 656, 2, "YT32964-0", 5, new DateTime(2021, 10, 12, 10, 6, 38, 627, DateTimeKind.Unspecified).AddTicks(105), new DateTime(2021, 6, 24, 23, 23, 19, 903, DateTimeKind.Unspecified).AddTicks(610) },
                    { 659, 3, "YT21245-1", 5, new DateTime(2021, 12, 20, 8, 25, 56, 192, DateTimeKind.Unspecified).AddTicks(1499), new DateTime(2021, 6, 24, 9, 26, 49, 132, DateTimeKind.Unspecified).AddTicks(241) },
                    { 661, 4, "YT12398-1", 5, new DateTime(2021, 9, 24, 0, 51, 9, 523, DateTimeKind.Unspecified).AddTicks(2435), new DateTime(2021, 5, 15, 17, 8, 43, 240, DateTimeKind.Unspecified).AddTicks(2135) },
                    { 664, 1, "YT38964-0", 5, new DateTime(2021, 12, 20, 3, 9, 39, 274, DateTimeKind.Unspecified).AddTicks(3125), new DateTime(2021, 5, 13, 3, 15, 9, 401, DateTimeKind.Unspecified).AddTicks(5906) },
                    { 668, 5, "YT97094-1", 5, new DateTime(2021, 10, 15, 16, 0, 0, 685, DateTimeKind.Unspecified).AddTicks(5056), new DateTime(2021, 8, 24, 0, 26, 39, 737, DateTimeKind.Unspecified).AddTicks(8133) },
                    { 674, 3, "YT19246-1", 5, new DateTime(2021, 12, 3, 21, 49, 5, 528, DateTimeKind.Unspecified).AddTicks(953), new DateTime(2021, 5, 24, 20, 57, 19, 917, DateTimeKind.Unspecified).AddTicks(571) },
                    { 678, 4, "YT13001-0", 5, new DateTime(2021, 10, 9, 2, 27, 21, 646, DateTimeKind.Unspecified).AddTicks(9570), new DateTime(2021, 7, 5, 20, 40, 9, 908, DateTimeKind.Unspecified).AddTicks(4009) },
                    { 543, 5, "YT48692-0", 5, new DateTime(2021, 12, 14, 18, 36, 20, 541, DateTimeKind.Unspecified).AddTicks(3320), new DateTime(2021, 6, 8, 9, 38, 27, 5, DateTimeKind.Unspecified).AddTicks(4067) },
                    { 682, 1, "YT23953-0", 5, new DateTime(2021, 12, 24, 15, 9, 41, 341, DateTimeKind.Unspecified).AddTicks(7927), new DateTime(2021, 6, 5, 6, 29, 31, 886, DateTimeKind.Unspecified).AddTicks(4773) },
                    { 542, 4, "YT34816-1", 5, new DateTime(2021, 9, 27, 10, 37, 19, 530, DateTimeKind.Unspecified).AddTicks(8062), new DateTime(2021, 5, 17, 20, 1, 26, 237, DateTimeKind.Unspecified).AddTicks(7607) },
                    { 532, 3, "YT40014-1", 5, new DateTime(2021, 10, 25, 7, 27, 18, 770, DateTimeKind.Unspecified).AddTicks(6315), new DateTime(2021, 6, 17, 4, 45, 29, 578, DateTimeKind.Unspecified).AddTicks(1886) },
                    { 390, 3, "YT36517-0", 5, new DateTime(2021, 12, 2, 3, 9, 4, 594, DateTimeKind.Unspecified).AddTicks(3557), new DateTime(2021, 8, 20, 15, 14, 29, 338, DateTimeKind.Unspecified).AddTicks(3800) },
                    { 395, 2, "YT83256-1", 5, new DateTime(2021, 9, 3, 22, 31, 34, 312, DateTimeKind.Unspecified).AddTicks(8636), new DateTime(2021, 7, 18, 1, 33, 24, 516, DateTimeKind.Unspecified).AddTicks(2942) },
                    { 399, 2, "YT85463-1", 5, new DateTime(2021, 10, 30, 2, 22, 11, 666, DateTimeKind.Unspecified).AddTicks(4214), new DateTime(2021, 5, 26, 9, 5, 2, 148, DateTimeKind.Unspecified).AddTicks(847) },
                    { 403, 5, "YT32970-0", 5, new DateTime(2021, 12, 24, 14, 24, 56, 368, DateTimeKind.Unspecified).AddTicks(5456), new DateTime(2021, 6, 27, 23, 28, 14, 966, DateTimeKind.Unspecified).AddTicks(1961) },
                    { 405, 2, "YT18969-1", 5, new DateTime(2021, 10, 9, 18, 10, 38, 436, DateTimeKind.Unspecified).AddTicks(4388), new DateTime(2021, 7, 21, 16, 11, 10, 378, DateTimeKind.Unspecified).AddTicks(6749) },
                    { 410, 4, "YT80697-1", 5, new DateTime(2021, 10, 10, 10, 42, 17, 934, DateTimeKind.Unspecified).AddTicks(6997), new DateTime(2021, 6, 14, 17, 56, 49, 54, DateTimeKind.Unspecified).AddTicks(5761) },
                    { 411, 1, "YT29168-1", 5, new DateTime(2021, 11, 16, 18, 51, 37, 870, DateTimeKind.Unspecified).AddTicks(6557), new DateTime(2021, 5, 17, 16, 55, 26, 625, DateTimeKind.Unspecified).AddTicks(1818) },
                    { 437, 3, "YT18819-0", 5, new DateTime(2021, 9, 28, 3, 52, 52, 710, DateTimeKind.Unspecified).AddTicks(8603), new DateTime(2021, 8, 10, 9, 34, 46, 490, DateTimeKind.Unspecified).AddTicks(9720) },
                    { 438, 1, "YT63423-0", 5, new DateTime(2021, 9, 17, 2, 52, 13, 948, DateTimeKind.Unspecified).AddTicks(7407), new DateTime(2021, 8, 15, 1, 15, 21, 196, DateTimeKind.Unspecified).AddTicks(6416) },
                    { 443, 1, "YT95110-0", 5, new DateTime(2021, 10, 11, 11, 17, 50, 430, DateTimeKind.Unspecified).AddTicks(7582), new DateTime(2021, 6, 30, 9, 55, 57, 136, DateTimeKind.Unspecified).AddTicks(1425) },
                    { 447, 5, "YT83354-1", 5, new DateTime(2021, 10, 23, 23, 48, 12, 805, DateTimeKind.Unspecified).AddTicks(425), new DateTime(2021, 7, 24, 8, 5, 21, 511, DateTimeKind.Unspecified).AddTicks(3790) },
                    { 448, 3, "YT48477-0", 5, new DateTime(2021, 12, 22, 19, 45, 28, 660, DateTimeKind.Unspecified).AddTicks(3350), new DateTime(2021, 6, 29, 8, 48, 0, 623, DateTimeKind.Unspecified).AddTicks(8322) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 451, 2, "YT33439-0", 5, new DateTime(2021, 9, 9, 21, 14, 6, 227, DateTimeKind.Unspecified).AddTicks(3104), new DateTime(2021, 8, 18, 22, 34, 35, 664, DateTimeKind.Unspecified).AddTicks(4449) },
                    { 452, 3, "YT45584-1", 5, new DateTime(2021, 11, 12, 0, 43, 14, 385, DateTimeKind.Unspecified).AddTicks(8084), new DateTime(2021, 6, 8, 23, 34, 6, 904, DateTimeKind.Unspecified).AddTicks(6615) },
                    { 455, 4, "YT11029-0", 5, new DateTime(2021, 11, 19, 22, 19, 55, 546, DateTimeKind.Unspecified).AddTicks(4663), new DateTime(2021, 5, 28, 16, 18, 20, 447, DateTimeKind.Unspecified).AddTicks(8773) },
                    { 462, 1, "YT12813-1", 5, new DateTime(2021, 10, 22, 0, 17, 7, 199, DateTimeKind.Unspecified).AddTicks(4178), new DateTime(2021, 8, 18, 17, 25, 59, 770, DateTimeKind.Unspecified).AddTicks(978) },
                    { 470, 1, "YT41470-1", 5, new DateTime(2021, 11, 26, 13, 29, 24, 335, DateTimeKind.Unspecified).AddTicks(2794), new DateTime(2021, 6, 27, 5, 43, 41, 698, DateTimeKind.Unspecified).AddTicks(4562) },
                    { 488, 1, "YT44542-1", 5, new DateTime(2021, 9, 19, 11, 28, 3, 256, DateTimeKind.Unspecified).AddTicks(4427), new DateTime(2021, 8, 27, 1, 54, 24, 962, DateTimeKind.Unspecified).AddTicks(4856) },
                    { 497, 5, "YT20568-0", 5, new DateTime(2021, 11, 16, 5, 10, 18, 846, DateTimeKind.Unspecified).AddTicks(9169), new DateTime(2021, 8, 2, 11, 10, 6, 698, DateTimeKind.Unspecified).AddTicks(9743) },
                    { 499, 4, "YT53376-0", 5, new DateTime(2021, 10, 10, 17, 48, 11, 993, DateTimeKind.Unspecified).AddTicks(2485), new DateTime(2021, 6, 4, 7, 15, 32, 296, DateTimeKind.Unspecified).AddTicks(4507) },
                    { 509, 5, "YT23926-0", 5, new DateTime(2021, 11, 19, 2, 32, 44, 130, DateTimeKind.Unspecified).AddTicks(9855), new DateTime(2021, 5, 21, 22, 12, 54, 966, DateTimeKind.Unspecified).AddTicks(5305) },
                    { 510, 2, "YT65120-1", 5, new DateTime(2021, 11, 17, 20, 36, 9, 766, DateTimeKind.Unspecified).AddTicks(1909), new DateTime(2021, 8, 19, 22, 33, 45, 755, DateTimeKind.Unspecified).AddTicks(7636) },
                    { 512, 4, "YT67999-0", 5, new DateTime(2021, 9, 26, 21, 55, 15, 234, DateTimeKind.Unspecified).AddTicks(5995), new DateTime(2021, 6, 24, 5, 38, 27, 50, DateTimeKind.Unspecified).AddTicks(319) },
                    { 519, 1, "YT65689-1", 5, new DateTime(2021, 9, 11, 3, 57, 15, 372, DateTimeKind.Unspecified).AddTicks(6826), new DateTime(2021, 8, 8, 15, 36, 11, 786, DateTimeKind.Unspecified).AddTicks(1139) },
                    { 522, 3, "YT23881-0", 5, new DateTime(2021, 10, 21, 11, 8, 22, 60, DateTimeKind.Unspecified).AddTicks(7166), new DateTime(2021, 5, 8, 14, 50, 47, 527, DateTimeKind.Unspecified).AddTicks(4633) },
                    { 524, 2, "YT94219-1", 5, new DateTime(2021, 10, 16, 22, 7, 50, 236, DateTimeKind.Unspecified).AddTicks(8616), new DateTime(2021, 5, 29, 7, 20, 12, 140, DateTimeKind.Unspecified).AddTicks(1150) },
                    { 529, 2, "YT39218-0", 5, new DateTime(2021, 10, 18, 19, 14, 54, 137, DateTimeKind.Unspecified).AddTicks(9974), new DateTime(2021, 5, 19, 16, 44, 9, 728, DateTimeKind.Unspecified).AddTicks(8731) },
                    { 535, 4, "YT11946-1", 5, new DateTime(2021, 11, 11, 0, 14, 51, 660, DateTimeKind.Unspecified).AddTicks(1409), new DateTime(2021, 5, 11, 1, 18, 49, 148, DateTimeKind.Unspecified).AddTicks(5212) },
                    { 684, 2, "YT88103-0", 5, new DateTime(2021, 10, 21, 6, 19, 53, 930, DateTimeKind.Unspecified).AddTicks(9718), new DateTime(2021, 7, 14, 19, 30, 24, 150, DateTimeKind.Unspecified).AddTicks(4549) },
                    { 690, 4, "YT15466-1", 5, new DateTime(2021, 12, 1, 5, 30, 34, 711, DateTimeKind.Unspecified).AddTicks(2539), new DateTime(2021, 6, 1, 9, 42, 21, 385, DateTimeKind.Unspecified).AddTicks(3063) },
                    { 694, 2, "YT77789-1", 5, new DateTime(2021, 9, 1, 20, 5, 48, 426, DateTimeKind.Unspecified).AddTicks(1194), new DateTime(2021, 7, 22, 16, 52, 0, 617, DateTimeKind.Unspecified).AddTicks(9708) },
                    { 876, 2, "YT42642-1", 5, new DateTime(2021, 12, 10, 9, 1, 50, 795, DateTimeKind.Unspecified).AddTicks(1897), new DateTime(2021, 6, 29, 13, 24, 43, 63, DateTimeKind.Unspecified).AddTicks(6607) },
                    { 881, 2, "YT43963-0", 5, new DateTime(2021, 12, 13, 7, 58, 54, 144, DateTimeKind.Unspecified).AddTicks(4596), new DateTime(2021, 6, 2, 23, 22, 6, 945, DateTimeKind.Unspecified).AddTicks(4603) },
                    { 883, 4, "YT97859-0", 5, new DateTime(2021, 9, 24, 19, 52, 13, 999, DateTimeKind.Unspecified).AddTicks(4361), new DateTime(2021, 8, 15, 5, 21, 12, 28, DateTimeKind.Unspecified).AddTicks(5282) },
                    { 888, 3, "YT63044-1", 5, new DateTime(2021, 12, 20, 11, 14, 30, 437, DateTimeKind.Unspecified).AddTicks(4755), new DateTime(2021, 6, 6, 15, 45, 32, 278, DateTimeKind.Unspecified).AddTicks(5880) },
                    { 891, 1, "YT34292-0", 5, new DateTime(2021, 10, 19, 12, 37, 50, 364, DateTimeKind.Unspecified).AddTicks(494), new DateTime(2021, 6, 6, 20, 51, 43, 80, DateTimeKind.Unspecified).AddTicks(7830) },
                    { 894, 4, "YT39881-0", 5, new DateTime(2021, 10, 25, 0, 18, 30, 357, DateTimeKind.Unspecified).AddTicks(1644), new DateTime(2021, 8, 22, 10, 34, 12, 558, DateTimeKind.Unspecified).AddTicks(3742) },
                    { 902, 2, "YT80773-1", 5, new DateTime(2021, 11, 10, 18, 51, 44, 21, DateTimeKind.Unspecified).AddTicks(2158), new DateTime(2021, 5, 23, 1, 28, 29, 678, DateTimeKind.Unspecified).AddTicks(5049) },
                    { 908, 5, "YT41477-1", 5, new DateTime(2021, 10, 27, 17, 39, 23, 770, DateTimeKind.Unspecified).AddTicks(6054), new DateTime(2021, 8, 4, 10, 44, 0, 104, DateTimeKind.Unspecified).AddTicks(108) },
                    { 914, 4, "YT81131-1", 5, new DateTime(2021, 9, 27, 1, 34, 43, 925, DateTimeKind.Unspecified).AddTicks(9219), new DateTime(2021, 5, 23, 22, 26, 29, 814, DateTimeKind.Unspecified).AddTicks(926) },
                    { 921, 1, "YT65089-0", 5, new DateTime(2021, 11, 4, 5, 14, 32, 693, DateTimeKind.Unspecified).AddTicks(9811), new DateTime(2021, 6, 13, 5, 17, 36, 572, DateTimeKind.Unspecified).AddTicks(4849) },
                    { 935, 5, "YT98856-0", 5, new DateTime(2021, 9, 21, 3, 45, 39, 543, DateTimeKind.Unspecified).AddTicks(1835), new DateTime(2021, 7, 13, 8, 13, 59, 289, DateTimeKind.Unspecified).AddTicks(7818) },
                    { 938, 3, "YT48280-1", 5, new DateTime(2021, 11, 7, 17, 15, 15, 346, DateTimeKind.Unspecified).AddTicks(4353), new DateTime(2021, 7, 7, 8, 10, 25, 258, DateTimeKind.Unspecified).AddTicks(4341) },
                    { 939, 2, "YT59624-0", 5, new DateTime(2021, 11, 17, 16, 29, 54, 487, DateTimeKind.Unspecified).AddTicks(8870), new DateTime(2021, 5, 29, 10, 45, 58, 450, DateTimeKind.Unspecified).AddTicks(9449) },
                    { 946, 5, "YT50428-0", 5, new DateTime(2021, 11, 1, 15, 53, 59, 447, DateTimeKind.Unspecified).AddTicks(3119), new DateTime(2021, 7, 1, 0, 9, 46, 621, DateTimeKind.Unspecified).AddTicks(5217) },
                    { 948, 5, "YT33013-0", 5, new DateTime(2021, 12, 20, 0, 40, 6, 682, DateTimeKind.Unspecified).AddTicks(5014), new DateTime(2021, 6, 1, 23, 26, 51, 340, DateTimeKind.Unspecified).AddTicks(9003) },
                    { 950, 3, "YT30561-0", 5, new DateTime(2021, 11, 28, 18, 22, 45, 928, DateTimeKind.Unspecified).AddTicks(1279), new DateTime(2021, 8, 3, 18, 34, 50, 358, DateTimeKind.Unspecified).AddTicks(2363) },
                    { 952, 1, "YT20457-0", 5, new DateTime(2021, 11, 9, 10, 4, 58, 523, DateTimeKind.Unspecified).AddTicks(9928), new DateTime(2021, 6, 30, 17, 2, 16, 985, DateTimeKind.Unspecified).AddTicks(7403) },
                    { 955, 5, "YT44503-1", 5, new DateTime(2021, 10, 10, 4, 52, 6, 416, DateTimeKind.Unspecified).AddTicks(9134), new DateTime(2021, 7, 22, 2, 20, 12, 359, DateTimeKind.Unspecified).AddTicks(3235) },
                    { 957, 4, "YT15265-0", 5, new DateTime(2021, 9, 4, 3, 52, 59, 101, DateTimeKind.Unspecified).AddTicks(1294), new DateTime(2021, 8, 13, 2, 56, 42, 984, DateTimeKind.Unspecified).AddTicks(9802) },
                    { 958, 3, "YT19158-0", 5, new DateTime(2021, 12, 29, 9, 10, 24, 483, DateTimeKind.Unspecified).AddTicks(8943), new DateTime(2021, 5, 31, 9, 11, 10, 288, DateTimeKind.Unspecified).AddTicks(5141) },
                    { 962, 5, "YT88636-1", 5, new DateTime(2021, 11, 26, 8, 29, 21, 171, DateTimeKind.Unspecified).AddTicks(2836), new DateTime(2021, 7, 22, 14, 4, 19, 114, DateTimeKind.Unspecified).AddTicks(1013) },
                    { 966, 3, "YT25583-1", 5, new DateTime(2021, 11, 12, 4, 2, 58, 870, DateTimeKind.Unspecified).AddTicks(5983), new DateTime(2021, 6, 26, 20, 8, 5, 319, DateTimeKind.Unspecified).AddTicks(8851) },
                    { 968, 2, "YT12232-0", 5, new DateTime(2021, 12, 30, 20, 24, 4, 360, DateTimeKind.Unspecified).AddTicks(9922), new DateTime(2021, 8, 25, 15, 16, 46, 258, DateTimeKind.Unspecified).AddTicks(5789) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 969, 1, "YT21842-0", 5, new DateTime(2021, 11, 10, 4, 42, 50, 210, DateTimeKind.Unspecified).AddTicks(3545), new DateTime(2021, 7, 6, 23, 49, 22, 704, DateTimeKind.Unspecified).AddTicks(9249) },
                    { 972, 4, "YT89691-1", 5, new DateTime(2021, 10, 27, 7, 18, 40, 2, DateTimeKind.Unspecified).AddTicks(2120), new DateTime(2021, 6, 7, 12, 55, 59, 357, DateTimeKind.Unspecified).AddTicks(2178) },
                    { 978, 3, "YT14543-0", 5, new DateTime(2021, 12, 27, 0, 35, 7, 710, DateTimeKind.Unspecified).AddTicks(4355), new DateTime(2021, 6, 3, 17, 12, 49, 890, DateTimeKind.Unspecified).AddTicks(7366) },
                    { 984, 2, "YT96555-1", 5, new DateTime(2021, 10, 13, 6, 54, 13, 465, DateTimeKind.Unspecified).AddTicks(3258), new DateTime(2021, 5, 12, 20, 22, 7, 667, DateTimeKind.Unspecified).AddTicks(5596) },
                    { 865, 5, "YT60905-0", 5, new DateTime(2021, 9, 14, 9, 57, 25, 197, DateTimeKind.Unspecified).AddTicks(2622), new DateTime(2021, 7, 1, 19, 38, 42, 27, DateTimeKind.Unspecified).AddTicks(4971) },
                    { 853, 3, "YT54323-1", 5, new DateTime(2021, 9, 27, 16, 16, 20, 146, DateTimeKind.Unspecified).AddTicks(554), new DateTime(2021, 8, 4, 16, 19, 0, 259, DateTimeKind.Unspecified).AddTicks(9325) },
                    { 846, 3, "YT79827-1", 5, new DateTime(2021, 10, 22, 4, 10, 41, 211, DateTimeKind.Unspecified).AddTicks(4824), new DateTime(2021, 7, 4, 18, 28, 24, 219, DateTimeKind.Unspecified).AddTicks(9161) },
                    { 840, 4, "YT53806-0", 5, new DateTime(2021, 9, 7, 19, 10, 23, 958, DateTimeKind.Unspecified).AddTicks(103), new DateTime(2021, 8, 6, 1, 19, 1, 606, DateTimeKind.Unspecified).AddTicks(7518) },
                    { 695, 3, "YT92531-1", 5, new DateTime(2021, 11, 16, 20, 25, 45, 504, DateTimeKind.Unspecified).AddTicks(6802), new DateTime(2021, 5, 30, 23, 42, 37, 952, DateTimeKind.Unspecified).AddTicks(5034) },
                    { 698, 4, "YT30982-1", 5, new DateTime(2021, 10, 7, 13, 23, 31, 914, DateTimeKind.Unspecified).AddTicks(7808), new DateTime(2021, 8, 16, 11, 53, 10, 389, DateTimeKind.Unspecified).AddTicks(5279) },
                    { 713, 5, "YT50028-1", 5, new DateTime(2021, 9, 18, 19, 12, 27, 342, DateTimeKind.Unspecified).AddTicks(3341), new DateTime(2021, 8, 17, 16, 52, 17, 34, DateTimeKind.Unspecified).AddTicks(2165) },
                    { 718, 4, "YT73476-1", 5, new DateTime(2021, 9, 19, 13, 52, 17, 963, DateTimeKind.Unspecified).AddTicks(9188), new DateTime(2021, 7, 8, 17, 37, 43, 450, DateTimeKind.Unspecified).AddTicks(5299) },
                    { 719, 3, "YT58282-1", 5, new DateTime(2021, 10, 9, 18, 12, 25, 541, DateTimeKind.Unspecified).AddTicks(9130), new DateTime(2021, 6, 16, 13, 49, 39, 966, DateTimeKind.Unspecified).AddTicks(2643) },
                    { 721, 5, "YT18493-1", 5, new DateTime(2021, 9, 7, 12, 17, 32, 941, DateTimeKind.Unspecified).AddTicks(2014), new DateTime(2021, 8, 13, 8, 24, 58, 82, DateTimeKind.Unspecified).AddTicks(1453) },
                    { 722, 2, "YT87446-1", 5, new DateTime(2021, 11, 8, 0, 59, 21, 260, DateTimeKind.Unspecified).AddTicks(5886), new DateTime(2021, 7, 24, 14, 5, 23, 132, DateTimeKind.Unspecified).AddTicks(1005) },
                    { 727, 5, "YT53028-1", 5, new DateTime(2021, 12, 10, 17, 10, 0, 298, DateTimeKind.Unspecified).AddTicks(9386), new DateTime(2021, 8, 23, 17, 6, 49, 21, DateTimeKind.Unspecified).AddTicks(1589) },
                    { 729, 2, "YT31256-1", 5, new DateTime(2021, 11, 12, 19, 46, 17, 490, DateTimeKind.Unspecified).AddTicks(5268), new DateTime(2021, 7, 15, 9, 25, 28, 113, DateTimeKind.Unspecified).AddTicks(2722) },
                    { 734, 5, "YT94868-1", 5, new DateTime(2021, 12, 7, 13, 55, 48, 343, DateTimeKind.Unspecified).AddTicks(634), new DateTime(2021, 7, 13, 1, 42, 25, 632, DateTimeKind.Unspecified).AddTicks(478) },
                    { 736, 1, "YT37659-1", 5, new DateTime(2021, 12, 17, 7, 20, 31, 773, DateTimeKind.Unspecified).AddTicks(8045), new DateTime(2021, 7, 15, 1, 42, 51, 622, DateTimeKind.Unspecified).AddTicks(2911) },
                    { 738, 2, "YT34648-1", 5, new DateTime(2021, 12, 29, 22, 56, 27, 772, DateTimeKind.Unspecified).AddTicks(1143), new DateTime(2021, 6, 14, 4, 25, 18, 827, DateTimeKind.Unspecified).AddTicks(6037) },
                    { 744, 4, "YT94703-1", 5, new DateTime(2021, 12, 7, 1, 8, 7, 200, DateTimeKind.Unspecified).AddTicks(8462), new DateTime(2021, 7, 13, 16, 25, 39, 755, DateTimeKind.Unspecified).AddTicks(2110) },
                    { 387, 2, "YT61512-1", 5, new DateTime(2021, 12, 3, 9, 9, 17, 312, DateTimeKind.Unspecified).AddTicks(9450), new DateTime(2021, 7, 8, 23, 38, 31, 714, DateTimeKind.Unspecified).AddTicks(1286) },
                    { 747, 3, "YT99585-1", 5, new DateTime(2021, 11, 5, 16, 7, 9, 382, DateTimeKind.Unspecified).AddTicks(7178), new DateTime(2021, 8, 6, 21, 8, 1, 19, DateTimeKind.Unspecified).AddTicks(8766) },
                    { 753, 2, "YT82104-0", 5, new DateTime(2021, 10, 2, 0, 35, 9, 780, DateTimeKind.Unspecified).AddTicks(6717), new DateTime(2021, 7, 19, 10, 33, 9, 317, DateTimeKind.Unspecified).AddTicks(6390) },
                    { 773, 3, "YT56404-1", 5, new DateTime(2021, 12, 13, 5, 19, 52, 517, DateTimeKind.Unspecified).AddTicks(3923), new DateTime(2021, 6, 27, 5, 38, 1, 581, DateTimeKind.Unspecified).AddTicks(6124) },
                    { 783, 3, "YT70256-0", 5, new DateTime(2021, 10, 22, 6, 56, 47, 78, DateTimeKind.Unspecified).AddTicks(6548), new DateTime(2021, 6, 1, 9, 35, 55, 930, DateTimeKind.Unspecified).AddTicks(3460) },
                    { 784, 1, "YT17622-0", 5, new DateTime(2021, 12, 2, 7, 5, 35, 429, DateTimeKind.Unspecified).AddTicks(5209), new DateTime(2021, 6, 25, 12, 24, 16, 774, DateTimeKind.Unspecified).AddTicks(8591) },
                    { 785, 2, "YT42566-1", 5, new DateTime(2021, 12, 21, 17, 28, 4, 341, DateTimeKind.Unspecified).AddTicks(6209), new DateTime(2021, 8, 26, 9, 58, 50, 220, DateTimeKind.Unspecified).AddTicks(1364) },
                    { 794, 5, "YT19079-1", 5, new DateTime(2021, 9, 4, 0, 52, 9, 717, DateTimeKind.Unspecified).AddTicks(2442), new DateTime(2021, 7, 27, 12, 7, 25, 423, DateTimeKind.Unspecified).AddTicks(5146) },
                    { 796, 4, "YT48668-1", 5, new DateTime(2021, 12, 8, 11, 10, 19, 918, DateTimeKind.Unspecified).AddTicks(5767), new DateTime(2021, 5, 18, 5, 1, 35, 79, DateTimeKind.Unspecified).AddTicks(2889) },
                    { 805, 2, "YT31037-1", 5, new DateTime(2021, 10, 5, 19, 38, 38, 491, DateTimeKind.Unspecified).AddTicks(1655), new DateTime(2021, 5, 13, 3, 15, 19, 191, DateTimeKind.Unspecified).AddTicks(9217) },
                    { 809, 2, "YT50312-1", 5, new DateTime(2021, 12, 24, 13, 4, 40, 940, DateTimeKind.Unspecified).AddTicks(3072), new DateTime(2021, 7, 22, 5, 25, 55, 102, DateTimeKind.Unspecified).AddTicks(5511) },
                    { 810, 2, "YT31808-0", 5, new DateTime(2021, 11, 26, 22, 10, 4, 627, DateTimeKind.Unspecified).AddTicks(8848), new DateTime(2021, 7, 29, 11, 44, 48, 765, DateTimeKind.Unspecified).AddTicks(4531) },
                    { 823, 1, "YT24634-0", 5, new DateTime(2021, 11, 26, 3, 32, 8, 438, DateTimeKind.Unspecified).AddTicks(4295), new DateTime(2021, 6, 27, 0, 59, 59, 889, DateTimeKind.Unspecified).AddTicks(1460) },
                    { 826, 5, "YT64576-0", 5, new DateTime(2021, 12, 9, 17, 43, 38, 735, DateTimeKind.Unspecified).AddTicks(1449), new DateTime(2021, 8, 3, 8, 49, 12, 91, DateTimeKind.Unspecified).AddTicks(7608) },
                    { 831, 5, "YT16841-0", 5, new DateTime(2021, 10, 28, 3, 39, 22, 645, DateTimeKind.Unspecified).AddTicks(3684), new DateTime(2021, 5, 15, 21, 55, 25, 583, DateTimeKind.Unspecified).AddTicks(447) },
                    { 749, 5, "YT88681-1", 5, new DateTime(2021, 9, 24, 19, 51, 33, 82, DateTimeKind.Unspecified).AddTicks(1364), new DateTime(2021, 6, 20, 7, 46, 27, 807, DateTimeKind.Unspecified).AddTicks(1275) },
                    { 798, 3, "YT90583-0", 4, new DateTime(2021, 11, 8, 10, 37, 5, 394, DateTimeKind.Unspecified).AddTicks(492), new DateTime(2021, 8, 7, 11, 8, 31, 542, DateTimeKind.Unspecified).AddTicks(9827) },
                    { 381, 2, "YT91485-0", 5, new DateTime(2021, 10, 23, 5, 27, 13, 691, DateTimeKind.Unspecified).AddTicks(6240), new DateTime(2021, 7, 29, 22, 20, 24, 53, DateTimeKind.Unspecified).AddTicks(910) },
                    { 363, 4, "YT93571-1", 5, new DateTime(2021, 9, 6, 6, 31, 49, 368, DateTimeKind.Unspecified).AddTicks(3710), new DateTime(2021, 7, 1, 4, 5, 57, 380, DateTimeKind.Unspecified).AddTicks(9156) },
                    { 953, 4, "YT62153-0", 4, new DateTime(2021, 10, 18, 17, 47, 29, 801, DateTimeKind.Unspecified).AddTicks(412), new DateTime(2021, 5, 15, 8, 27, 42, 999, DateTimeKind.Unspecified).AddTicks(7783) },
                    { 954, 1, "YT21338-0", 4, new DateTime(2021, 11, 8, 5, 23, 7, 697, DateTimeKind.Unspecified).AddTicks(2631), new DateTime(2021, 7, 11, 5, 17, 57, 6, DateTimeKind.Unspecified).AddTicks(2506) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 956, 1, "YT71430-1", 4, new DateTime(2021, 11, 24, 9, 19, 35, 335, DateTimeKind.Unspecified).AddTicks(1413), new DateTime(2021, 6, 18, 12, 12, 24, 4, DateTimeKind.Unspecified).AddTicks(9972) },
                    { 967, 1, "YT53928-1", 4, new DateTime(2021, 11, 21, 13, 53, 38, 706, DateTimeKind.Unspecified).AddTicks(3897), new DateTime(2021, 7, 12, 6, 50, 55, 520, DateTimeKind.Unspecified).AddTicks(706) },
                    { 970, 2, "YT96752-0", 4, new DateTime(2021, 9, 13, 13, 22, 54, 510, DateTimeKind.Unspecified).AddTicks(6385), new DateTime(2021, 6, 4, 17, 56, 11, 630, DateTimeKind.Unspecified).AddTicks(3172) },
                    { 980, 3, "YT82636-1", 4, new DateTime(2021, 11, 21, 6, 8, 30, 333, DateTimeKind.Unspecified).AddTicks(1103), new DateTime(2021, 6, 6, 23, 34, 56, 113, DateTimeKind.Unspecified).AddTicks(9702) },
                    { 982, 3, "YT17958-0", 4, new DateTime(2021, 11, 4, 1, 25, 42, 873, DateTimeKind.Unspecified).AddTicks(3745), new DateTime(2021, 7, 9, 22, 23, 45, 749, DateTimeKind.Unspecified).AddTicks(399) },
                    { 988, 5, "YT28918-1", 4, new DateTime(2021, 12, 14, 8, 22, 58, 71, DateTimeKind.Unspecified).AddTicks(2492), new DateTime(2021, 8, 13, 3, 12, 24, 952, DateTimeKind.Unspecified).AddTicks(7139) },
                    { 989, 5, "YT97779-0", 4, new DateTime(2021, 10, 15, 23, 27, 49, 657, DateTimeKind.Unspecified).AddTicks(1401), new DateTime(2021, 7, 13, 1, 38, 23, 862, DateTimeKind.Unspecified).AddTicks(6892) },
                    { 992, 3, "YT46088-1", 4, new DateTime(2021, 9, 19, 9, 3, 50, 87, DateTimeKind.Unspecified).AddTicks(3208), new DateTime(2021, 8, 12, 7, 26, 10, 59, DateTimeKind.Unspecified).AddTicks(7187) },
                    { 998, 3, "YT22630-0", 4, new DateTime(2021, 10, 16, 0, 57, 26, 516, DateTimeKind.Unspecified).AddTicks(4916), new DateTime(2021, 7, 22, 18, 38, 34, 560, DateTimeKind.Unspecified).AddTicks(1585) },
                    { 5, 4, "YT36242-0", 5, new DateTime(2021, 12, 30, 9, 52, 37, 287, DateTimeKind.Unspecified).AddTicks(9406), new DateTime(2021, 7, 13, 4, 30, 19, 970, DateTimeKind.Unspecified).AddTicks(6898) },
                    { 7, 2, "YT31600-0", 5, new DateTime(2021, 11, 2, 12, 54, 15, 892, DateTimeKind.Unspecified).AddTicks(6411), new DateTime(2021, 8, 20, 13, 10, 15, 972, DateTimeKind.Unspecified).AddTicks(2460) },
                    { 12, 5, "YT57333-0", 5, new DateTime(2021, 11, 18, 8, 0, 33, 964, DateTimeKind.Unspecified).AddTicks(1154), new DateTime(2021, 7, 1, 1, 16, 54, 144, DateTimeKind.Unspecified).AddTicks(4377) },
                    { 18, 4, "YT75005-1", 5, new DateTime(2021, 11, 29, 23, 58, 14, 660, DateTimeKind.Unspecified).AddTicks(7202), new DateTime(2021, 7, 12, 14, 49, 40, 865, DateTimeKind.Unspecified).AddTicks(1815) },
                    { 19, 5, "YT48819-0", 5, new DateTime(2021, 10, 14, 18, 1, 53, 450, DateTimeKind.Unspecified).AddTicks(3101), new DateTime(2021, 6, 21, 15, 25, 8, 771, DateTimeKind.Unspecified).AddTicks(416) },
                    { 20, 2, "YT45083-1", 5, new DateTime(2021, 11, 6, 23, 47, 28, 926, DateTimeKind.Unspecified).AddTicks(4231), new DateTime(2021, 6, 16, 7, 55, 28, 627, DateTimeKind.Unspecified).AddTicks(4894) },
                    { 21, 4, "YT43498-0", 5, new DateTime(2021, 10, 7, 7, 59, 30, 428, DateTimeKind.Unspecified).AddTicks(5920), new DateTime(2021, 8, 13, 18, 28, 27, 177, DateTimeKind.Unspecified).AddTicks(6551) },
                    { 26, 2, "YT13787-1", 5, new DateTime(2021, 10, 1, 5, 4, 25, 199, DateTimeKind.Unspecified).AddTicks(9112), new DateTime(2021, 6, 7, 22, 56, 11, 623, DateTimeKind.Unspecified).AddTicks(5799) },
                    { 27, 4, "YT10589-1", 5, new DateTime(2021, 10, 16, 21, 46, 51, 186, DateTimeKind.Unspecified).AddTicks(4783), new DateTime(2021, 7, 21, 8, 57, 0, 870, DateTimeKind.Unspecified).AddTicks(7915) },
                    { 29, 4, "YT74247-1", 5, new DateTime(2021, 10, 8, 7, 33, 39, 467, DateTimeKind.Unspecified).AddTicks(580), new DateTime(2021, 5, 18, 4, 43, 5, 644, DateTimeKind.Unspecified).AddTicks(1473) },
                    { 34, 3, "YT52744-0", 5, new DateTime(2021, 12, 7, 20, 57, 47, 330, DateTimeKind.Unspecified).AddTicks(3866), new DateTime(2021, 7, 11, 14, 1, 5, 973, DateTimeKind.Unspecified).AddTicks(8090) },
                    { 38, 2, "YT61844-0", 5, new DateTime(2021, 10, 21, 9, 32, 58, 409, DateTimeKind.Unspecified).AddTicks(6029), new DateTime(2021, 6, 28, 7, 18, 34, 910, DateTimeKind.Unspecified).AddTicks(9099) },
                    { 43, 5, "YT28773-0", 5, new DateTime(2021, 9, 30, 17, 46, 5, 90, DateTimeKind.Unspecified).AddTicks(4968), new DateTime(2021, 8, 14, 16, 2, 3, 673, DateTimeKind.Unspecified).AddTicks(6134) },
                    { 44, 1, "YT83238-1", 5, new DateTime(2021, 11, 4, 13, 24, 45, 124, DateTimeKind.Unspecified).AddTicks(8847), new DateTime(2021, 7, 20, 5, 4, 51, 930, DateTimeKind.Unspecified).AddTicks(9269) },
                    { 54, 3, "YT38027-0", 5, new DateTime(2021, 12, 16, 18, 13, 35, 682, DateTimeKind.Unspecified).AddTicks(9931), new DateTime(2021, 7, 2, 3, 54, 2, 284, DateTimeKind.Unspecified).AddTicks(9348) },
                    { 60, 3, "YT27475-1", 5, new DateTime(2021, 12, 21, 23, 35, 40, 635, DateTimeKind.Unspecified).AddTicks(5553), new DateTime(2021, 8, 7, 0, 37, 19, 997, DateTimeKind.Unspecified).AddTicks(4267) },
                    { 951, 5, "YT29802-0", 4, new DateTime(2021, 9, 30, 3, 43, 21, 234, DateTimeKind.Unspecified).AddTicks(3380), new DateTime(2021, 5, 18, 17, 42, 59, 674, DateTimeKind.Unspecified).AddTicks(6044) },
                    { 69, 4, "YT75704-1", 5, new DateTime(2021, 9, 11, 7, 9, 16, 642, DateTimeKind.Unspecified).AddTicks(4832), new DateTime(2021, 5, 21, 8, 42, 42, 539, DateTimeKind.Unspecified).AddTicks(3775) },
                    { 947, 3, "YT33037-0", 4, new DateTime(2021, 12, 12, 4, 20, 15, 983, DateTimeKind.Unspecified).AddTicks(8630), new DateTime(2021, 8, 5, 17, 12, 10, 751, DateTimeKind.Unspecified).AddTicks(9024) },
                    { 937, 5, "YT50730-0", 4, new DateTime(2021, 12, 15, 17, 2, 47, 555, DateTimeKind.Unspecified).AddTicks(6409), new DateTime(2021, 8, 1, 2, 26, 20, 295, DateTimeKind.Unspecified).AddTicks(1675) },
                    { 804, 1, "YT44464-1", 4, new DateTime(2021, 11, 4, 23, 10, 14, 566, DateTimeKind.Unspecified).AddTicks(6645), new DateTime(2021, 7, 27, 13, 35, 31, 929, DateTimeKind.Unspecified).AddTicks(3429) },
                    { 807, 5, "YT44012-1", 4, new DateTime(2021, 11, 4, 21, 22, 19, 419, DateTimeKind.Unspecified).AddTicks(8076), new DateTime(2021, 5, 14, 19, 31, 47, 819, DateTimeKind.Unspecified).AddTicks(1623) },
                    { 812, 2, "YT47556-1", 4, new DateTime(2021, 9, 2, 18, 37, 50, 27, DateTimeKind.Unspecified).AddTicks(5897), new DateTime(2021, 6, 29, 20, 57, 21, 988, DateTimeKind.Unspecified).AddTicks(1785) },
                    { 827, 1, "YT77498-0", 4, new DateTime(2021, 10, 17, 9, 48, 24, 678, DateTimeKind.Unspecified).AddTicks(6488), new DateTime(2021, 5, 12, 13, 31, 20, 809, DateTimeKind.Unspecified).AddTicks(6829) },
                    { 829, 3, "YT88814-0", 4, new DateTime(2021, 12, 18, 21, 10, 32, 407, DateTimeKind.Unspecified).AddTicks(9913), new DateTime(2021, 6, 3, 16, 59, 12, 481, DateTimeKind.Unspecified).AddTicks(3698) },
                    { 832, 1, "YT72328-0", 4, new DateTime(2021, 9, 5, 12, 49, 38, 529, DateTimeKind.Unspecified).AddTicks(6312), new DateTime(2021, 6, 7, 12, 44, 45, 184, DateTimeKind.Unspecified).AddTicks(6521) },
                    { 834, 5, "YT56706-0", 4, new DateTime(2021, 9, 12, 2, 38, 55, 867, DateTimeKind.Unspecified).AddTicks(5331), new DateTime(2021, 7, 6, 19, 16, 6, 394, DateTimeKind.Unspecified).AddTicks(1334) },
                    { 836, 3, "YT70297-0", 4, new DateTime(2021, 11, 18, 9, 5, 58, 115, DateTimeKind.Unspecified).AddTicks(7151), new DateTime(2021, 8, 30, 10, 13, 0, 149, DateTimeKind.Unspecified).AddTicks(6245) },
                    { 837, 5, "YT61965-1", 4, new DateTime(2021, 9, 20, 7, 25, 58, 594, DateTimeKind.Unspecified).AddTicks(8443), new DateTime(2021, 5, 29, 2, 54, 21, 886, DateTimeKind.Unspecified).AddTicks(2484) },
                    { 839, 5, "YT38902-0", 4, new DateTime(2021, 9, 27, 22, 36, 39, 517, DateTimeKind.Unspecified).AddTicks(2030), new DateTime(2021, 5, 11, 12, 58, 24, 73, DateTimeKind.Unspecified).AddTicks(5522) },
                    { 842, 5, "YT36514-1", 4, new DateTime(2021, 12, 4, 12, 26, 7, 142, DateTimeKind.Unspecified).AddTicks(2750), new DateTime(2021, 6, 18, 17, 36, 6, 744, DateTimeKind.Unspecified).AddTicks(9591) },
                    { 848, 5, "YT80470-0", 4, new DateTime(2021, 10, 22, 2, 11, 59, 444, DateTimeKind.Unspecified).AddTicks(7167), new DateTime(2021, 6, 3, 22, 0, 33, 895, DateTimeKind.Unspecified).AddTicks(720) },
                    { 856, 4, "YT34557-0", 4, new DateTime(2021, 11, 13, 19, 46, 12, 584, DateTimeKind.Unspecified).AddTicks(6592), new DateTime(2021, 6, 6, 20, 6, 26, 967, DateTimeKind.Unspecified).AddTicks(1697) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 869, 5, "YT64357-1", 4, new DateTime(2021, 10, 18, 14, 29, 38, 54, DateTimeKind.Unspecified).AddTicks(2438), new DateTime(2021, 6, 30, 12, 14, 47, 5, DateTimeKind.Unspecified).AddTicks(2677) },
                    { 880, 4, "YT82934-0", 4, new DateTime(2021, 10, 24, 15, 50, 54, 21, DateTimeKind.Unspecified).AddTicks(5221), new DateTime(2021, 8, 25, 12, 20, 43, 819, DateTimeKind.Unspecified).AddTicks(1844) },
                    { 887, 3, "YT86718-0", 4, new DateTime(2021, 11, 14, 8, 39, 21, 600, DateTimeKind.Unspecified).AddTicks(7771), new DateTime(2021, 7, 8, 20, 10, 44, 490, DateTimeKind.Unspecified).AddTicks(8585) },
                    { 890, 3, "YT93003-1", 4, new DateTime(2021, 9, 12, 18, 26, 53, 732, DateTimeKind.Unspecified).AddTicks(8189), new DateTime(2021, 7, 24, 10, 49, 10, 980, DateTimeKind.Unspecified).AddTicks(6993) },
                    { 893, 5, "YT46662-0", 4, new DateTime(2021, 12, 7, 22, 31, 24, 31, DateTimeKind.Unspecified).AddTicks(8089), new DateTime(2021, 5, 25, 11, 18, 9, 401, DateTimeKind.Unspecified).AddTicks(1642) },
                    { 896, 4, "YT52752-0", 4, new DateTime(2021, 10, 25, 21, 5, 16, 231, DateTimeKind.Unspecified).AddTicks(298), new DateTime(2021, 5, 28, 5, 19, 41, 859, DateTimeKind.Unspecified).AddTicks(5543) },
                    { 897, 3, "YT79812-1", 4, new DateTime(2021, 12, 18, 5, 36, 16, 977, DateTimeKind.Unspecified).AddTicks(9955), new DateTime(2021, 8, 24, 2, 41, 34, 213, DateTimeKind.Unspecified).AddTicks(3248) },
                    { 901, 4, "YT95089-1", 4, new DateTime(2021, 11, 3, 5, 18, 37, 573, DateTimeKind.Unspecified).AddTicks(3611), new DateTime(2021, 6, 3, 0, 38, 12, 598, DateTimeKind.Unspecified).AddTicks(8312) },
                    { 907, 4, "YT29950-0", 4, new DateTime(2021, 10, 28, 16, 33, 44, 743, DateTimeKind.Unspecified).AddTicks(453), new DateTime(2021, 5, 23, 7, 9, 14, 286, DateTimeKind.Unspecified).AddTicks(5918) },
                    { 909, 1, "YT21773-0", 4, new DateTime(2021, 10, 17, 6, 33, 40, 567, DateTimeKind.Unspecified).AddTicks(2449), new DateTime(2021, 6, 5, 11, 20, 46, 729, DateTimeKind.Unspecified).AddTicks(9428) },
                    { 913, 4, "YT42448-0", 4, new DateTime(2021, 12, 23, 23, 31, 37, 758, DateTimeKind.Unspecified).AddTicks(2968), new DateTime(2021, 8, 21, 20, 51, 14, 444, DateTimeKind.Unspecified).AddTicks(9697) },
                    { 917, 1, "YT30471-0", 4, new DateTime(2021, 11, 8, 22, 47, 26, 527, DateTimeKind.Unspecified).AddTicks(916), new DateTime(2021, 7, 20, 9, 41, 8, 964, DateTimeKind.Unspecified).AddTicks(9387) },
                    { 919, 2, "YT68961-1", 4, new DateTime(2021, 12, 15, 1, 27, 46, 13, DateTimeKind.Unspecified).AddTicks(9660), new DateTime(2021, 5, 31, 20, 41, 33, 170, DateTimeKind.Unspecified).AddTicks(2707) },
                    { 926, 5, "YT31384-0", 4, new DateTime(2021, 10, 9, 14, 56, 7, 410, DateTimeKind.Unspecified).AddTicks(7817), new DateTime(2021, 7, 7, 8, 23, 21, 623, DateTimeKind.Unspecified).AddTicks(3644) },
                    { 941, 5, "YT51874-0", 4, new DateTime(2021, 10, 9, 1, 39, 31, 224, DateTimeKind.Unspecified).AddTicks(1424), new DateTime(2021, 7, 31, 0, 22, 17, 597, DateTimeKind.Unspecified).AddTicks(7344) },
                    { 70, 1, "YT49568-1", 5, new DateTime(2021, 10, 23, 8, 49, 23, 322, DateTimeKind.Unspecified).AddTicks(761), new DateTime(2021, 5, 14, 0, 4, 39, 389, DateTimeKind.Unspecified).AddTicks(6736) },
                    { 76, 5, "YT11189-1", 5, new DateTime(2021, 11, 20, 5, 58, 30, 792, DateTimeKind.Unspecified).AddTicks(3667), new DateTime(2021, 5, 15, 16, 26, 56, 767, DateTimeKind.Unspecified).AddTicks(3864) },
                    { 91, 5, "YT68771-1", 5, new DateTime(2021, 9, 5, 18, 27, 45, 935, DateTimeKind.Unspecified).AddTicks(3521), new DateTime(2021, 7, 20, 13, 46, 55, 965, DateTimeKind.Unspecified).AddTicks(8261) },
                    { 262, 1, "YT25872-0", 5, new DateTime(2021, 11, 6, 14, 26, 44, 551, DateTimeKind.Unspecified).AddTicks(3827), new DateTime(2021, 6, 14, 19, 46, 12, 981, DateTimeKind.Unspecified).AddTicks(1568) },
                    { 264, 1, "YT23029-1", 5, new DateTime(2021, 12, 28, 0, 43, 36, 69, DateTimeKind.Unspecified).AddTicks(6176), new DateTime(2021, 5, 11, 19, 14, 48, 81, DateTimeKind.Unspecified).AddTicks(8243) },
                    { 266, 4, "YT86200-1", 5, new DateTime(2021, 10, 9, 16, 31, 35, 34, DateTimeKind.Unspecified).AddTicks(3543), new DateTime(2021, 7, 19, 8, 32, 47, 190, DateTimeKind.Unspecified).AddTicks(2427) },
                    { 268, 4, "YT99991-1", 5, new DateTime(2021, 11, 4, 17, 54, 47, 479, DateTimeKind.Unspecified).AddTicks(8181), new DateTime(2021, 7, 31, 16, 19, 43, 767, DateTimeKind.Unspecified).AddTicks(5622) },
                    { 269, 2, "YT22771-0", 5, new DateTime(2021, 10, 17, 12, 4, 21, 957, DateTimeKind.Unspecified).AddTicks(3602), new DateTime(2021, 8, 23, 0, 17, 22, 868, DateTimeKind.Unspecified).AddTicks(514) },
                    { 273, 4, "YT81572-0", 5, new DateTime(2021, 10, 6, 12, 26, 39, 142, DateTimeKind.Unspecified).AddTicks(9463), new DateTime(2021, 5, 26, 16, 8, 4, 122, DateTimeKind.Unspecified).AddTicks(8756) },
                    { 274, 3, "YT21695-1", 5, new DateTime(2021, 10, 25, 7, 5, 0, 261, DateTimeKind.Unspecified).AddTicks(3350), new DateTime(2021, 6, 25, 17, 45, 24, 373, DateTimeKind.Unspecified).AddTicks(2363) },
                    { 285, 3, "YT98299-1", 5, new DateTime(2021, 9, 24, 1, 57, 49, 925, DateTimeKind.Unspecified).AddTicks(6066), new DateTime(2021, 5, 8, 8, 45, 42, 179, DateTimeKind.Unspecified).AddTicks(7631) },
                    { 286, 5, "YT89283-1", 5, new DateTime(2021, 12, 12, 15, 32, 12, 872, DateTimeKind.Unspecified).AddTicks(7044), new DateTime(2021, 5, 19, 0, 33, 29, 519, DateTimeKind.Unspecified).AddTicks(6987) },
                    { 287, 3, "YT79251-0", 5, new DateTime(2021, 10, 12, 20, 39, 29, 540, DateTimeKind.Unspecified).AddTicks(3639), new DateTime(2021, 5, 23, 2, 3, 56, 831, DateTimeKind.Unspecified).AddTicks(5225) },
                    { 303, 3, "YT84337-1", 5, new DateTime(2021, 9, 10, 18, 10, 27, 284, DateTimeKind.Unspecified).AddTicks(9805), new DateTime(2021, 8, 14, 21, 54, 58, 748, DateTimeKind.Unspecified).AddTicks(6700) },
                    { 308, 1, "YT37289-0", 5, new DateTime(2021, 11, 12, 13, 51, 32, 919, DateTimeKind.Unspecified).AddTicks(7454), new DateTime(2021, 8, 22, 23, 10, 55, 797, DateTimeKind.Unspecified).AddTicks(3401) },
                    { 313, 2, "YT36574-0", 5, new DateTime(2021, 12, 4, 5, 28, 26, 14, DateTimeKind.Unspecified).AddTicks(2654), new DateTime(2021, 8, 19, 8, 29, 16, 526, DateTimeKind.Unspecified).AddTicks(2475) },
                    { 314, 1, "YT98682-1", 5, new DateTime(2021, 10, 31, 21, 26, 8, 882, DateTimeKind.Unspecified).AddTicks(5743), new DateTime(2021, 5, 17, 8, 10, 6, 732, DateTimeKind.Unspecified).AddTicks(7651) },
                    { 316, 4, "YT42511-0", 5, new DateTime(2021, 10, 13, 5, 27, 36, 895, DateTimeKind.Unspecified).AddTicks(2399), new DateTime(2021, 5, 15, 20, 51, 12, 657, DateTimeKind.Unspecified).AddTicks(4517) },
                    { 317, 2, "YT62865-1", 5, new DateTime(2021, 12, 26, 22, 58, 46, 108, DateTimeKind.Unspecified).AddTicks(1574), new DateTime(2021, 8, 20, 9, 3, 54, 802, DateTimeKind.Unspecified).AddTicks(3626) },
                    { 322, 3, "YT48925-1", 5, new DateTime(2021, 9, 3, 9, 28, 27, 47, DateTimeKind.Unspecified).AddTicks(3651), new DateTime(2021, 7, 28, 7, 56, 35, 274, DateTimeKind.Unspecified).AddTicks(7240) },
                    { 323, 1, "YT86692-1", 5, new DateTime(2021, 11, 23, 9, 5, 43, 984, DateTimeKind.Unspecified).AddTicks(8724), new DateTime(2021, 8, 28, 12, 41, 12, 114, DateTimeKind.Unspecified).AddTicks(6349) },
                    { 329, 5, "YT66199-0", 5, new DateTime(2021, 10, 26, 14, 4, 17, 70, DateTimeKind.Unspecified).AddTicks(4189), new DateTime(2021, 8, 13, 2, 21, 14, 633, DateTimeKind.Unspecified).AddTicks(6187) },
                    { 335, 1, "YT33648-1", 5, new DateTime(2021, 11, 3, 0, 49, 48, 465, DateTimeKind.Unspecified).AddTicks(5057), new DateTime(2021, 5, 12, 4, 40, 13, 471, DateTimeKind.Unspecified).AddTicks(5546) },
                    { 337, 3, "YT67350-0", 5, new DateTime(2021, 10, 11, 14, 58, 37, 37, DateTimeKind.Unspecified).AddTicks(7714), new DateTime(2021, 8, 3, 0, 6, 23, 653, DateTimeKind.Unspecified).AddTicks(3608) },
                    { 342, 2, "YT19235-0", 5, new DateTime(2021, 11, 21, 4, 12, 51, 893, DateTimeKind.Unspecified).AddTicks(3727), new DateTime(2021, 5, 9, 5, 27, 47, 535, DateTimeKind.Unspecified).AddTicks(9788) },
                    { 343, 1, "YT86913-0", 5, new DateTime(2021, 12, 18, 2, 56, 45, 679, DateTimeKind.Unspecified).AddTicks(1921), new DateTime(2021, 5, 19, 21, 32, 34, 14, DateTimeKind.Unspecified).AddTicks(2212) },
                    { 345, 2, "YT94256-0", 5, new DateTime(2021, 12, 16, 6, 4, 42, 148, DateTimeKind.Unspecified).AddTicks(5100), new DateTime(2021, 8, 3, 0, 10, 23, 53, DateTimeKind.Unspecified).AddTicks(7924) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 346, 1, "YT64760-1", 5, new DateTime(2021, 10, 19, 11, 55, 21, 4, DateTimeKind.Unspecified).AddTicks(5105), new DateTime(2021, 7, 7, 19, 49, 13, 17, DateTimeKind.Unspecified).AddTicks(7583) },
                    { 348, 5, "YT17853-0", 5, new DateTime(2021, 12, 23, 12, 39, 35, 279, DateTimeKind.Unspecified).AddTicks(7548), new DateTime(2021, 7, 27, 19, 6, 38, 287, DateTimeKind.Unspecified).AddTicks(9005) },
                    { 349, 2, "YT92235-0", 5, new DateTime(2021, 12, 19, 20, 9, 51, 801, DateTimeKind.Unspecified).AddTicks(6653), new DateTime(2021, 7, 1, 14, 15, 40, 947, DateTimeKind.Unspecified).AddTicks(3375) },
                    { 252, 3, "YT90256-0", 5, new DateTime(2021, 10, 27, 6, 28, 36, 34, DateTimeKind.Unspecified).AddTicks(6781), new DateTime(2021, 5, 19, 4, 9, 18, 306, DateTimeKind.Unspecified).AddTicks(379) },
                    { 246, 4, "YT25046-0", 5, new DateTime(2021, 10, 19, 7, 18, 48, 428, DateTimeKind.Unspecified).AddTicks(5191), new DateTime(2021, 6, 24, 12, 42, 46, 5, DateTimeKind.Unspecified).AddTicks(6968) },
                    { 244, 4, "YT74686-1", 5, new DateTime(2021, 9, 30, 2, 43, 53, 464, DateTimeKind.Unspecified).AddTicks(8729), new DateTime(2021, 5, 10, 7, 28, 22, 336, DateTimeKind.Unspecified).AddTicks(9333) },
                    { 243, 2, "YT90138-0", 5, new DateTime(2021, 11, 14, 3, 24, 54, 743, DateTimeKind.Unspecified).AddTicks(4170), new DateTime(2021, 6, 26, 13, 14, 26, 608, DateTimeKind.Unspecified).AddTicks(3841) },
                    { 94, 2, "YT10922-0", 5, new DateTime(2021, 10, 7, 2, 47, 27, 660, DateTimeKind.Unspecified).AddTicks(4926), new DateTime(2021, 6, 26, 2, 21, 23, 875, DateTimeKind.Unspecified).AddTicks(6124) },
                    { 95, 5, "YT24054-0", 5, new DateTime(2021, 11, 14, 0, 50, 32, 454, DateTimeKind.Unspecified).AddTicks(2030), new DateTime(2021, 7, 30, 10, 1, 27, 67, DateTimeKind.Unspecified).AddTicks(9681) },
                    { 115, 5, "YT61428-0", 5, new DateTime(2021, 11, 13, 15, 11, 20, 619, DateTimeKind.Unspecified).AddTicks(9507), new DateTime(2021, 8, 17, 10, 28, 25, 483, DateTimeKind.Unspecified).AddTicks(8133) },
                    { 122, 3, "YT68422-1", 5, new DateTime(2021, 11, 20, 16, 32, 23, 84, DateTimeKind.Unspecified).AddTicks(1038), new DateTime(2021, 7, 19, 1, 30, 36, 531, DateTimeKind.Unspecified).AddTicks(4077) },
                    { 130, 5, "YT54427-1", 5, new DateTime(2021, 12, 1, 9, 34, 41, 337, DateTimeKind.Unspecified).AddTicks(3890), new DateTime(2021, 8, 1, 2, 53, 45, 181, DateTimeKind.Unspecified).AddTicks(8407) },
                    { 134, 5, "YT24552-1", 5, new DateTime(2021, 9, 24, 16, 50, 6, 996, DateTimeKind.Unspecified).AddTicks(8208), new DateTime(2021, 8, 12, 2, 5, 47, 202, DateTimeKind.Unspecified).AddTicks(5996) },
                    { 135, 4, "YT84181-1", 5, new DateTime(2021, 11, 13, 2, 0, 33, 420, DateTimeKind.Unspecified).AddTicks(6361), new DateTime(2021, 5, 24, 9, 35, 11, 636, DateTimeKind.Unspecified).AddTicks(7218) },
                    { 146, 1, "YT73951-0", 5, new DateTime(2021, 11, 24, 23, 24, 52, 174, DateTimeKind.Unspecified).AddTicks(7794), new DateTime(2021, 5, 12, 0, 33, 24, 642, DateTimeKind.Unspecified).AddTicks(5978) },
                    { 148, 5, "YT20364-0", 5, new DateTime(2021, 11, 27, 16, 47, 48, 198, DateTimeKind.Unspecified).AddTicks(9415), new DateTime(2021, 8, 2, 7, 2, 44, 6, DateTimeKind.Unspecified).AddTicks(3911) },
                    { 159, 4, "YT15718-1", 5, new DateTime(2021, 9, 18, 13, 59, 31, 593, DateTimeKind.Unspecified).AddTicks(5122), new DateTime(2021, 5, 22, 10, 24, 22, 739, DateTimeKind.Unspecified).AddTicks(9679) },
                    { 162, 2, "YT20651-1", 5, new DateTime(2021, 12, 2, 8, 31, 5, 699, DateTimeKind.Unspecified).AddTicks(4635), new DateTime(2021, 8, 1, 7, 30, 11, 76, DateTimeKind.Unspecified).AddTicks(1947) },
                    { 163, 3, "YT28411-0", 5, new DateTime(2021, 10, 11, 17, 42, 59, 820, DateTimeKind.Unspecified).AddTicks(6105), new DateTime(2021, 8, 14, 20, 25, 19, 424, DateTimeKind.Unspecified).AddTicks(3952) },
                    { 172, 4, "YT54814-0", 5, new DateTime(2021, 9, 11, 15, 47, 29, 847, DateTimeKind.Unspecified).AddTicks(109), new DateTime(2021, 8, 19, 16, 8, 29, 997, DateTimeKind.Unspecified).AddTicks(4083) },
                    { 366, 2, "YT52074-0", 5, new DateTime(2021, 10, 15, 10, 0, 31, 246, DateTimeKind.Unspecified).AddTicks(5850), new DateTime(2021, 5, 13, 8, 56, 11, 878, DateTimeKind.Unspecified).AddTicks(4199) },
                    { 174, 2, "YT81032-1", 5, new DateTime(2021, 12, 7, 0, 22, 2, 992, DateTimeKind.Unspecified).AddTicks(6235), new DateTime(2021, 6, 8, 22, 22, 47, 808, DateTimeKind.Unspecified).AddTicks(1754) },
                    { 176, 2, "YT89125-1", 5, new DateTime(2021, 10, 7, 5, 34, 21, 966, DateTimeKind.Unspecified).AddTicks(3481), new DateTime(2021, 6, 14, 23, 12, 20, 686, DateTimeKind.Unspecified).AddTicks(3587) },
                    { 179, 1, "YT91955-1", 5, new DateTime(2021, 9, 8, 5, 2, 8, 178, DateTimeKind.Unspecified).AddTicks(8881), new DateTime(2021, 8, 6, 1, 17, 18, 280, DateTimeKind.Unspecified).AddTicks(8185) },
                    { 188, 2, "YT44238-0", 5, new DateTime(2021, 9, 26, 15, 8, 56, 498, DateTimeKind.Unspecified).AddTicks(1011), new DateTime(2021, 6, 20, 4, 31, 56, 853, DateTimeKind.Unspecified).AddTicks(3267) },
                    { 189, 3, "YT96337-1", 5, new DateTime(2021, 11, 20, 13, 10, 32, 902, DateTimeKind.Unspecified).AddTicks(1481), new DateTime(2021, 7, 20, 0, 36, 14, 811, DateTimeKind.Unspecified).AddTicks(1377) },
                    { 190, 1, "YT94738-0", 5, new DateTime(2021, 12, 28, 19, 16, 15, 528, DateTimeKind.Unspecified).AddTicks(5035), new DateTime(2021, 7, 11, 0, 22, 44, 131, DateTimeKind.Unspecified).AddTicks(8894) },
                    { 199, 4, "YT93008-0", 5, new DateTime(2021, 11, 1, 7, 17, 56, 126, DateTimeKind.Unspecified).AddTicks(6101), new DateTime(2021, 8, 20, 1, 20, 56, 616, DateTimeKind.Unspecified).AddTicks(2668) },
                    { 203, 3, "YT90972-0", 5, new DateTime(2021, 11, 2, 4, 55, 31, 266, DateTimeKind.Unspecified).AddTicks(6976), new DateTime(2021, 6, 13, 6, 2, 25, 753, DateTimeKind.Unspecified).AddTicks(4340) },
                    { 204, 4, "YT35492-0", 5, new DateTime(2021, 9, 16, 14, 5, 13, 290, DateTimeKind.Unspecified).AddTicks(5526), new DateTime(2021, 5, 12, 5, 6, 31, 514, DateTimeKind.Unspecified).AddTicks(6958) },
                    { 205, 2, "YT68277-1", 5, new DateTime(2021, 9, 23, 17, 27, 55, 327, DateTimeKind.Unspecified).AddTicks(9502), new DateTime(2021, 6, 4, 19, 12, 40, 278, DateTimeKind.Unspecified).AddTicks(9366) },
                    { 218, 5, "YT25978-1", 5, new DateTime(2021, 9, 18, 17, 37, 19, 371, DateTimeKind.Unspecified).AddTicks(7227), new DateTime(2021, 8, 10, 18, 42, 57, 594, DateTimeKind.Unspecified).AddTicks(2177) },
                    { 226, 1, "YT50218-1", 5, new DateTime(2021, 9, 25, 4, 16, 27, 652, DateTimeKind.Unspecified).AddTicks(497), new DateTime(2021, 8, 21, 4, 38, 21, 571, DateTimeKind.Unspecified).AddTicks(2562) },
                    { 238, 4, "YT87587-0", 5, new DateTime(2021, 11, 7, 2, 16, 46, 446, DateTimeKind.Unspecified).AddTicks(2581), new DateTime(2021, 5, 24, 11, 6, 7, 340, DateTimeKind.Unspecified).AddTicks(3852) },
                    { 241, 5, "YT48164-0", 5, new DateTime(2021, 11, 14, 3, 8, 23, 936, DateTimeKind.Unspecified).AddTicks(2379), new DateTime(2021, 8, 3, 19, 53, 11, 752, DateTimeKind.Unspecified).AddTicks(9752) },
                    { 175, 2, "YT47307-1", 5, new DateTime(2021, 9, 21, 4, 42, 6, 273, DateTimeKind.Unspecified).AddTicks(6787), new DateTime(2021, 8, 18, 6, 1, 51, 67, DateTimeKind.Unspecified).AddTicks(7641) },
                    { 637, 1, "YT96571-0", 3, new DateTime(2021, 9, 6, 8, 26, 37, 436, DateTimeKind.Unspecified).AddTicks(7462), new DateTime(2021, 7, 16, 15, 21, 1, 791, DateTimeKind.Unspecified).AddTicks(4919) },
                    { 635, 2, "YT26787-1", 3, new DateTime(2021, 10, 22, 11, 54, 51, 935, DateTimeKind.Unspecified).AddTicks(4266), new DateTime(2021, 8, 24, 18, 20, 12, 177, DateTimeKind.Unspecified).AddTicks(406) },
                    { 633, 4, "YT48088-1", 3, new DateTime(2021, 11, 13, 12, 43, 9, 166, DateTimeKind.Unspecified).AddTicks(5851), new DateTime(2021, 6, 6, 15, 26, 55, 468, DateTimeKind.Unspecified).AddTicks(3104) },
                    { 861, 3, "YT53181-0", 1, new DateTime(2021, 11, 26, 11, 45, 6, 398, DateTimeKind.Unspecified).AddTicks(1879), new DateTime(2021, 7, 10, 13, 26, 52, 992, DateTimeKind.Unspecified).AddTicks(4672) },
                    { 864, 5, "YT11088-1", 1, new DateTime(2021, 11, 28, 6, 25, 18, 85, DateTimeKind.Unspecified).AddTicks(8019), new DateTime(2021, 5, 17, 13, 10, 16, 847, DateTimeKind.Unspecified).AddTicks(3166) },
                    { 873, 2, "YT82132-1", 1, new DateTime(2021, 9, 4, 22, 26, 11, 649, DateTimeKind.Unspecified).AddTicks(2344), new DateTime(2021, 6, 2, 14, 43, 48, 532, DateTimeKind.Unspecified).AddTicks(3509) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 877, 2, "YT37535-0", 1, new DateTime(2021, 11, 26, 22, 15, 17, 468, DateTimeKind.Unspecified).AddTicks(7550), new DateTime(2021, 7, 16, 6, 2, 57, 771, DateTimeKind.Unspecified).AddTicks(7275) },
                    { 892, 4, "YT57319-0", 1, new DateTime(2021, 10, 30, 0, 42, 49, 453, DateTimeKind.Unspecified).AddTicks(5759), new DateTime(2021, 8, 11, 5, 53, 27, 73, DateTimeKind.Unspecified).AddTicks(4749) },
                    { 900, 2, "YT30389-1", 1, new DateTime(2021, 12, 9, 21, 19, 52, 498, DateTimeKind.Unspecified).AddTicks(4962), new DateTime(2021, 6, 4, 21, 58, 55, 20, DateTimeKind.Unspecified).AddTicks(8547) },
                    { 905, 2, "YT88650-1", 1, new DateTime(2021, 11, 9, 19, 44, 5, 358, DateTimeKind.Unspecified).AddTicks(5941), new DateTime(2021, 6, 30, 13, 27, 52, 994, DateTimeKind.Unspecified).AddTicks(9581) },
                    { 910, 5, "YT62485-1", 1, new DateTime(2021, 11, 14, 1, 9, 30, 500, DateTimeKind.Unspecified).AddTicks(3743), new DateTime(2021, 8, 12, 22, 46, 9, 325, DateTimeKind.Unspecified).AddTicks(4182) },
                    { 912, 2, "YT33475-0", 1, new DateTime(2021, 11, 26, 3, 44, 41, 472, DateTimeKind.Unspecified).AddTicks(5268), new DateTime(2021, 8, 2, 18, 33, 46, 692, DateTimeKind.Unspecified).AddTicks(5989) },
                    { 915, 5, "YT83021-0", 1, new DateTime(2021, 12, 26, 20, 23, 45, 569, DateTimeKind.Unspecified).AddTicks(4225), new DateTime(2021, 6, 12, 13, 12, 42, 865, DateTimeKind.Unspecified).AddTicks(1528) },
                    { 922, 1, "YT49058-0", 1, new DateTime(2021, 12, 10, 8, 20, 43, 2, DateTimeKind.Unspecified).AddTicks(4987), new DateTime(2021, 7, 8, 21, 13, 21, 377, DateTimeKind.Unspecified).AddTicks(7448) },
                    { 925, 3, "YT29009-1", 1, new DateTime(2021, 11, 5, 3, 13, 58, 730, DateTimeKind.Unspecified).AddTicks(8816), new DateTime(2021, 6, 10, 10, 13, 18, 991, DateTimeKind.Unspecified).AddTicks(4857) },
                    { 930, 2, "YT45869-0", 1, new DateTime(2021, 11, 18, 15, 54, 35, 732, DateTimeKind.Unspecified).AddTicks(4903), new DateTime(2021, 8, 22, 17, 31, 16, 121, DateTimeKind.Unspecified).AddTicks(9125) },
                    { 931, 3, "YT56296-0", 1, new DateTime(2021, 10, 12, 16, 37, 36, 707, DateTimeKind.Unspecified).AddTicks(2268), new DateTime(2021, 8, 16, 11, 18, 40, 359, DateTimeKind.Unspecified).AddTicks(1134) },
                    { 932, 1, "YT26663-0", 1, new DateTime(2021, 9, 5, 1, 48, 35, 942, DateTimeKind.Unspecified).AddTicks(7330), new DateTime(2021, 7, 15, 12, 11, 6, 432, DateTimeKind.Unspecified).AddTicks(9375) },
                    { 933, 5, "YT66515-1", 1, new DateTime(2021, 11, 29, 20, 56, 27, 121, DateTimeKind.Unspecified).AddTicks(2059), new DateTime(2021, 6, 21, 21, 40, 22, 502, DateTimeKind.Unspecified).AddTicks(6881) },
                    { 940, 2, "YT14810-0", 1, new DateTime(2021, 12, 5, 10, 25, 36, 289, DateTimeKind.Unspecified).AddTicks(9612), new DateTime(2021, 7, 3, 15, 47, 35, 796, DateTimeKind.Unspecified).AddTicks(9686) },
                    { 945, 4, "YT27896-1", 1, new DateTime(2021, 10, 19, 5, 19, 7, 702, DateTimeKind.Unspecified).AddTicks(8697), new DateTime(2021, 8, 18, 20, 11, 4, 651, DateTimeKind.Unspecified).AddTicks(8032) },
                    { 949, 4, "YT18641-0", 1, new DateTime(2021, 9, 3, 17, 55, 59, 108, DateTimeKind.Unspecified).AddTicks(7195), new DateTime(2021, 6, 12, 13, 56, 45, 393, DateTimeKind.Unspecified).AddTicks(9710) },
                    { 959, 3, "YT39958-1", 1, new DateTime(2021, 11, 3, 13, 1, 23, 994, DateTimeKind.Unspecified).AddTicks(5237), new DateTime(2021, 6, 20, 17, 57, 35, 299, DateTimeKind.Unspecified).AddTicks(2660) },
                    { 986, 5, "YT29182-1", 1, new DateTime(2021, 12, 12, 6, 22, 27, 804, DateTimeKind.Unspecified).AddTicks(1264), new DateTime(2021, 7, 7, 18, 13, 41, 459, DateTimeKind.Unspecified).AddTicks(229) },
                    { 995, 4, "YT24548-0", 1, new DateTime(2021, 10, 15, 17, 41, 11, 138, DateTimeKind.Unspecified).AddTicks(1181), new DateTime(2021, 5, 18, 18, 10, 19, 615, DateTimeKind.Unspecified).AddTicks(2172) },
                    { 999, 2, "YT89219-1", 1, new DateTime(2021, 11, 8, 18, 31, 42, 28, DateTimeKind.Unspecified).AddTicks(5395), new DateTime(2021, 6, 22, 10, 7, 58, 38, DateTimeKind.Unspecified).AddTicks(3280) },
                    { 1000, 1, "YT12472-0", 1, new DateTime(2021, 9, 4, 3, 31, 29, 259, DateTimeKind.Unspecified).AddTicks(3219), new DateTime(2021, 8, 5, 4, 42, 47, 592, DateTimeKind.Unspecified).AddTicks(223) },
                    { 3, 4, "YT43793-1", 2, new DateTime(2021, 12, 17, 12, 15, 5, 452, DateTimeKind.Unspecified).AddTicks(5223), new DateTime(2021, 8, 14, 1, 25, 56, 841, DateTimeKind.Unspecified).AddTicks(316) },
                    { 4, 2, "YT27029-0", 2, new DateTime(2021, 10, 24, 16, 15, 55, 567, DateTimeKind.Unspecified).AddTicks(1503), new DateTime(2021, 7, 7, 8, 33, 24, 260, DateTimeKind.Unspecified).AddTicks(8121) },
                    { 9, 4, "YT75436-0", 2, new DateTime(2021, 11, 5, 8, 6, 4, 484, DateTimeKind.Unspecified).AddTicks(1896), new DateTime(2021, 7, 15, 3, 31, 55, 778, DateTimeKind.Unspecified).AddTicks(5102) },
                    { 859, 5, "YT48380-0", 1, new DateTime(2021, 12, 9, 10, 39, 23, 160, DateTimeKind.Unspecified).AddTicks(4716), new DateTime(2021, 6, 13, 12, 37, 30, 426, DateTimeKind.Unspecified).AddTicks(1169) },
                    { 10, 1, "YT27817-1", 2, new DateTime(2021, 12, 21, 12, 11, 16, 505, DateTimeKind.Unspecified).AddTicks(7858), new DateTime(2021, 7, 12, 8, 25, 13, 794, DateTimeKind.Unspecified).AddTicks(7537) },
                    { 858, 4, "YT38444-0", 1, new DateTime(2021, 9, 16, 8, 41, 11, 629, DateTimeKind.Unspecified).AddTicks(1081), new DateTime(2021, 7, 16, 10, 30, 45, 713, DateTimeKind.Unspecified).AddTicks(1473) },
                    { 852, 5, "YT87322-0", 1, new DateTime(2021, 10, 27, 0, 26, 53, 528, DateTimeKind.Unspecified).AddTicks(1228), new DateTime(2021, 8, 14, 17, 47, 40, 150, DateTimeKind.Unspecified).AddTicks(8141) },
                    { 700, 2, "YT90773-1", 1, new DateTime(2021, 11, 1, 10, 2, 57, 494, DateTimeKind.Unspecified).AddTicks(8765), new DateTime(2021, 7, 9, 17, 51, 44, 27, DateTimeKind.Unspecified).AddTicks(613) },
                    { 716, 4, "YT59109-0", 1, new DateTime(2021, 11, 7, 12, 25, 14, 925, DateTimeKind.Unspecified).AddTicks(1774), new DateTime(2021, 5, 15, 0, 55, 11, 839, DateTimeKind.Unspecified).AddTicks(486) },
                    { 717, 5, "YT35608-0", 1, new DateTime(2021, 10, 18, 14, 31, 48, 858, DateTimeKind.Unspecified).AddTicks(1612), new DateTime(2021, 7, 16, 5, 13, 25, 860, DateTimeKind.Unspecified).AddTicks(2659) },
                    { 720, 1, "YT24414-0", 1, new DateTime(2021, 11, 10, 23, 45, 1, 176, DateTimeKind.Unspecified).AddTicks(5506), new DateTime(2021, 5, 21, 22, 12, 33, 660, DateTimeKind.Unspecified).AddTicks(679) },
                    { 723, 2, "YT19395-0", 1, new DateTime(2021, 12, 13, 14, 50, 16, 978, DateTimeKind.Unspecified).AddTicks(5242), new DateTime(2021, 6, 11, 16, 37, 7, 40, DateTimeKind.Unspecified).AddTicks(1175) },
                    { 724, 4, "YT54448-1", 1, new DateTime(2021, 9, 6, 14, 2, 36, 219, DateTimeKind.Unspecified).AddTicks(5075), new DateTime(2021, 6, 24, 8, 37, 25, 331, DateTimeKind.Unspecified).AddTicks(3614) },
                    { 728, 2, "YT36377-0", 1, new DateTime(2021, 12, 25, 1, 57, 17, 22, DateTimeKind.Unspecified).AddTicks(9888), new DateTime(2021, 6, 12, 3, 21, 5, 201, DateTimeKind.Unspecified).AddTicks(9140) },
                    { 731, 5, "YT36873-0", 1, new DateTime(2021, 10, 28, 22, 12, 28, 207, DateTimeKind.Unspecified).AddTicks(5929), new DateTime(2021, 8, 17, 12, 42, 58, 532, DateTimeKind.Unspecified).AddTicks(5651) },
                    { 739, 2, "YT11731-0", 1, new DateTime(2021, 10, 17, 21, 29, 24, 761, DateTimeKind.Unspecified).AddTicks(2947), new DateTime(2021, 8, 22, 12, 17, 17, 984, DateTimeKind.Unspecified).AddTicks(908) },
                    { 742, 4, "YT62488-1", 1, new DateTime(2021, 12, 26, 15, 27, 38, 202, DateTimeKind.Unspecified).AddTicks(154), new DateTime(2021, 7, 13, 8, 9, 38, 249, DateTimeKind.Unspecified).AddTicks(7573) },
                    { 750, 5, "YT95366-0", 1, new DateTime(2021, 12, 29, 15, 9, 0, 401, DateTimeKind.Unspecified).AddTicks(7211), new DateTime(2021, 6, 25, 1, 41, 24, 924, DateTimeKind.Unspecified).AddTicks(5115) },
                    { 755, 2, "YT21994-1", 1, new DateTime(2021, 10, 28, 23, 57, 23, 576, DateTimeKind.Unspecified).AddTicks(3463), new DateTime(2021, 7, 22, 2, 7, 13, 574, DateTimeKind.Unspecified).AddTicks(5713) },
                    { 757, 3, "YT15751-0", 1, new DateTime(2021, 9, 29, 5, 51, 22, 634, DateTimeKind.Unspecified).AddTicks(5602), new DateTime(2021, 7, 29, 5, 39, 18, 21, DateTimeKind.Unspecified).AddTicks(1898) },
                    { 763, 2, "YT29545-1", 1, new DateTime(2021, 12, 30, 14, 59, 46, 984, DateTimeKind.Unspecified).AddTicks(9680), new DateTime(2021, 5, 12, 11, 38, 4, 478, DateTimeKind.Unspecified).AddTicks(4082) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 777, 3, "YT68559-1", 1, new DateTime(2021, 12, 13, 15, 54, 24, 183, DateTimeKind.Unspecified).AddTicks(2067), new DateTime(2021, 8, 7, 10, 44, 16, 332, DateTimeKind.Unspecified).AddTicks(4080) },
                    { 791, 4, "YT68985-0", 1, new DateTime(2021, 9, 27, 3, 41, 12, 500, DateTimeKind.Unspecified).AddTicks(4154), new DateTime(2021, 6, 10, 13, 0, 51, 329, DateTimeKind.Unspecified).AddTicks(6435) },
                    { 797, 3, "YT86707-1", 1, new DateTime(2021, 9, 20, 2, 20, 42, 516, DateTimeKind.Unspecified).AddTicks(9552), new DateTime(2021, 6, 23, 16, 21, 36, 310, DateTimeKind.Unspecified).AddTicks(3435) },
                    { 799, 3, "YT21248-0", 1, new DateTime(2021, 11, 7, 17, 39, 28, 901, DateTimeKind.Unspecified).AddTicks(2555), new DateTime(2021, 7, 26, 2, 26, 2, 782, DateTimeKind.Unspecified).AddTicks(9712) },
                    { 803, 5, "YT82032-1", 1, new DateTime(2021, 10, 2, 13, 40, 38, 297, DateTimeKind.Unspecified).AddTicks(2649), new DateTime(2021, 8, 26, 6, 50, 42, 981, DateTimeKind.Unspecified).AddTicks(6152) },
                    { 808, 2, "YT38250-0", 1, new DateTime(2021, 9, 4, 22, 58, 45, 753, DateTimeKind.Unspecified).AddTicks(3414), new DateTime(2021, 7, 28, 5, 4, 52, 38, DateTimeKind.Unspecified).AddTicks(5103) },
                    { 815, 2, "YT50116-0", 1, new DateTime(2021, 11, 25, 18, 10, 58, 476, DateTimeKind.Unspecified).AddTicks(807), new DateTime(2021, 5, 14, 3, 5, 45, 519, DateTimeKind.Unspecified).AddTicks(323) },
                    { 817, 5, "YT38969-0", 1, new DateTime(2021, 9, 25, 8, 58, 41, 810, DateTimeKind.Unspecified).AddTicks(8194), new DateTime(2021, 8, 23, 0, 1, 4, 29, DateTimeKind.Unspecified).AddTicks(2645) },
                    { 830, 3, "YT94667-0", 1, new DateTime(2021, 9, 26, 21, 35, 48, 461, DateTimeKind.Unspecified).AddTicks(1247), new DateTime(2021, 7, 22, 7, 15, 39, 400, DateTimeKind.Unspecified).AddTicks(9786) },
                    { 835, 5, "YT14473-0", 1, new DateTime(2021, 11, 19, 3, 53, 14, 937, DateTimeKind.Unspecified).AddTicks(8973), new DateTime(2021, 8, 17, 20, 28, 38, 476, DateTimeKind.Unspecified).AddTicks(5846) },
                    { 845, 3, "YT13147-1", 1, new DateTime(2021, 11, 30, 16, 10, 44, 307, DateTimeKind.Unspecified).AddTicks(4021), new DateTime(2021, 8, 30, 0, 34, 35, 993, DateTimeKind.Unspecified).AddTicks(6491) },
                    { 849, 1, "YT97676-1", 1, new DateTime(2021, 10, 20, 21, 55, 47, 906, DateTimeKind.Unspecified).AddTicks(8423), new DateTime(2021, 8, 12, 22, 43, 17, 642, DateTimeKind.Unspecified).AddTicks(9858) },
                    { 850, 3, "YT65591-1", 1, new DateTime(2021, 11, 22, 0, 36, 12, 81, DateTimeKind.Unspecified).AddTicks(5207), new DateTime(2021, 5, 10, 3, 37, 23, 803, DateTimeKind.Unspecified).AddTicks(9691) },
                    { 855, 3, "YT66121-1", 1, new DateTime(2021, 11, 18, 10, 59, 41, 534, DateTimeKind.Unspecified).AddTicks(2700), new DateTime(2021, 8, 24, 6, 14, 31, 516, DateTimeKind.Unspecified).AddTicks(1845) },
                    { 24, 1, "YT35478-0", 2, new DateTime(2021, 12, 14, 2, 7, 32, 447, DateTimeKind.Unspecified).AddTicks(8546), new DateTime(2021, 8, 6, 7, 29, 28, 688, DateTimeKind.Unspecified).AddTicks(9774) },
                    { 28, 1, "YT39659-0", 2, new DateTime(2021, 10, 13, 1, 13, 50, 90, DateTimeKind.Unspecified).AddTicks(5174), new DateTime(2021, 6, 14, 11, 22, 42, 45, DateTimeKind.Unspecified).AddTicks(8332) },
                    { 33, 5, "YT37594-1", 2, new DateTime(2021, 10, 27, 1, 30, 32, 803, DateTimeKind.Unspecified).AddTicks(8882), new DateTime(2021, 7, 24, 13, 58, 18, 178, DateTimeKind.Unspecified).AddTicks(584) },
                    { 180, 4, "YT33418-0", 2, new DateTime(2021, 10, 23, 4, 38, 20, 804, DateTimeKind.Unspecified).AddTicks(8150), new DateTime(2021, 7, 20, 17, 8, 32, 452, DateTimeKind.Unspecified).AddTicks(202) },
                    { 181, 5, "YT29896-0", 2, new DateTime(2021, 12, 25, 9, 58, 33, 167, DateTimeKind.Unspecified).AddTicks(806), new DateTime(2021, 8, 13, 1, 53, 29, 796, DateTimeKind.Unspecified).AddTicks(1383) },
                    { 195, 5, "YT44252-0", 2, new DateTime(2021, 11, 12, 15, 7, 43, 559, DateTimeKind.Unspecified).AddTicks(8123), new DateTime(2021, 6, 2, 22, 44, 8, 893, DateTimeKind.Unspecified).AddTicks(6433) },
                    { 197, 5, "YT94131-0", 2, new DateTime(2021, 12, 19, 1, 45, 18, 959, DateTimeKind.Unspecified).AddTicks(2510), new DateTime(2021, 5, 23, 13, 8, 53, 522, DateTimeKind.Unspecified).AddTicks(8038) },
                    { 201, 5, "YT82876-0", 2, new DateTime(2021, 11, 26, 9, 22, 28, 251, DateTimeKind.Unspecified).AddTicks(6446), new DateTime(2021, 5, 10, 6, 18, 47, 815, DateTimeKind.Unspecified).AddTicks(6193) },
                    { 207, 2, "YT68764-1", 2, new DateTime(2021, 10, 8, 1, 55, 46, 281, DateTimeKind.Unspecified).AddTicks(3767), new DateTime(2021, 7, 28, 6, 9, 44, 588, DateTimeKind.Unspecified).AddTicks(1089) },
                    { 212, 5, "YT47206-1", 2, new DateTime(2021, 11, 18, 20, 45, 31, 860, DateTimeKind.Unspecified).AddTicks(6680), new DateTime(2021, 8, 23, 5, 25, 21, 12, DateTimeKind.Unspecified).AddTicks(2512) },
                    { 216, 2, "YT94763-1", 2, new DateTime(2021, 11, 30, 22, 42, 14, 181, DateTimeKind.Unspecified).AddTicks(8937), new DateTime(2021, 7, 14, 5, 54, 38, 134, DateTimeKind.Unspecified).AddTicks(8879) },
                    { 220, 4, "YT93242-0", 2, new DateTime(2021, 10, 3, 0, 39, 21, 127, DateTimeKind.Unspecified).AddTicks(6086), new DateTime(2021, 6, 16, 7, 46, 21, 72, DateTimeKind.Unspecified).AddTicks(2213) },
                    { 221, 2, "YT92082-1", 2, new DateTime(2021, 10, 19, 7, 6, 26, 255, DateTimeKind.Unspecified).AddTicks(3969), new DateTime(2021, 8, 25, 13, 44, 31, 10, DateTimeKind.Unspecified).AddTicks(7885) },
                    { 222, 1, "YT38337-1", 2, new DateTime(2021, 10, 15, 7, 36, 15, 989, DateTimeKind.Unspecified).AddTicks(13), new DateTime(2021, 6, 11, 10, 37, 26, 337, DateTimeKind.Unspecified).AddTicks(2066) },
                    { 225, 1, "YT64081-1", 2, new DateTime(2021, 10, 7, 5, 23, 41, 597, DateTimeKind.Unspecified).AddTicks(2201), new DateTime(2021, 6, 12, 22, 26, 15, 235, DateTimeKind.Unspecified).AddTicks(6160) },
                    { 232, 5, "YT54881-0", 2, new DateTime(2021, 10, 19, 0, 39, 18, 645, DateTimeKind.Unspecified).AddTicks(9484), new DateTime(2021, 7, 26, 1, 56, 28, 35, DateTimeKind.Unspecified).AddTicks(6061) },
                    { 233, 4, "YT28773-1", 2, new DateTime(2021, 9, 6, 1, 52, 1, 285, DateTimeKind.Unspecified).AddTicks(915), new DateTime(2021, 7, 7, 10, 1, 40, 469, DateTimeKind.Unspecified).AddTicks(622) },
                    { 234, 2, "YT30683-1", 2, new DateTime(2021, 11, 21, 6, 50, 32, 693, DateTimeKind.Unspecified).AddTicks(5600), new DateTime(2021, 8, 26, 21, 15, 32, 615, DateTimeKind.Unspecified).AddTicks(6973) },
                    { 235, 2, "YT36499-0", 2, new DateTime(2021, 10, 7, 19, 26, 54, 180, DateTimeKind.Unspecified).AddTicks(6824), new DateTime(2021, 6, 23, 17, 52, 57, 762, DateTimeKind.Unspecified).AddTicks(2076) },
                    { 240, 5, "YT73475-1", 2, new DateTime(2021, 10, 28, 16, 41, 7, 618, DateTimeKind.Unspecified).AddTicks(6558), new DateTime(2021, 8, 5, 7, 24, 55, 123, DateTimeKind.Unspecified).AddTicks(4525) },
                    { 242, 5, "YT28588-1", 2, new DateTime(2021, 12, 9, 6, 0, 57, 447, DateTimeKind.Unspecified).AddTicks(2945), new DateTime(2021, 6, 19, 19, 8, 56, 268, DateTimeKind.Unspecified).AddTicks(8862) },
                    { 249, 3, "YT29297-0", 2, new DateTime(2021, 9, 11, 21, 54, 54, 569, DateTimeKind.Unspecified).AddTicks(2117), new DateTime(2021, 6, 5, 5, 51, 19, 709, DateTimeKind.Unspecified).AddTicks(77) },
                    { 253, 2, "YT12249-0", 2, new DateTime(2021, 11, 10, 7, 31, 34, 756, DateTimeKind.Unspecified).AddTicks(8111), new DateTime(2021, 6, 23, 14, 6, 53, 642, DateTimeKind.Unspecified).AddTicks(4525) },
                    { 256, 4, "YT31895-0", 2, new DateTime(2021, 9, 27, 12, 29, 1, 25, DateTimeKind.Unspecified).AddTicks(575), new DateTime(2021, 7, 5, 18, 22, 57, 701, DateTimeKind.Unspecified).AddTicks(9928) },
                    { 258, 5, "YT92809-1", 2, new DateTime(2021, 12, 14, 22, 29, 41, 871, DateTimeKind.Unspecified).AddTicks(7112), new DateTime(2021, 7, 12, 23, 54, 46, 784, DateTimeKind.Unspecified).AddTicks(9617) },
                    { 259, 3, "YT82474-0", 2, new DateTime(2021, 11, 27, 11, 28, 7, 351, DateTimeKind.Unspecified).AddTicks(8138), new DateTime(2021, 6, 9, 19, 26, 31, 951, DateTimeKind.Unspecified).AddTicks(7545) },
                    { 260, 1, "YT14406-1", 2, new DateTime(2021, 9, 16, 11, 52, 56, 449, DateTimeKind.Unspecified).AddTicks(2294), new DateTime(2021, 8, 30, 6, 48, 29, 852, DateTimeKind.Unspecified).AddTicks(6652) },
                    { 267, 4, "YT93366-1", 2, new DateTime(2021, 10, 11, 10, 33, 48, 599, DateTimeKind.Unspecified).AddTicks(5824), new DateTime(2021, 7, 25, 0, 17, 27, 853, DateTimeKind.Unspecified).AddTicks(2587) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 282, 5, "YT58092-0", 2, new DateTime(2021, 10, 27, 3, 57, 32, 718, DateTimeKind.Unspecified).AddTicks(9172), new DateTime(2021, 8, 11, 8, 51, 25, 113, DateTimeKind.Unspecified).AddTicks(7310) },
                    { 301, 2, "YT40159-0", 2, new DateTime(2021, 11, 14, 13, 24, 12, 501, DateTimeKind.Unspecified).AddTicks(2837), new DateTime(2021, 5, 17, 23, 19, 19, 882, DateTimeKind.Unspecified).AddTicks(8781) },
                    { 170, 3, "YT20702-1", 2, new DateTime(2021, 9, 29, 11, 59, 13, 927, DateTimeKind.Unspecified).AddTicks(4476), new DateTime(2021, 8, 18, 10, 23, 29, 109, DateTimeKind.Unspecified).AddTicks(5607) },
                    { 168, 2, "YT38904-1", 2, new DateTime(2021, 9, 13, 13, 43, 30, 349, DateTimeKind.Unspecified).AddTicks(3995), new DateTime(2021, 7, 9, 11, 3, 23, 612, DateTimeKind.Unspecified).AddTicks(3655) },
                    { 166, 1, "YT99848-1", 2, new DateTime(2021, 9, 17, 10, 26, 1, 162, DateTimeKind.Unspecified).AddTicks(1659), new DateTime(2021, 5, 12, 11, 18, 8, 850, DateTimeKind.Unspecified).AddTicks(4128) },
                    { 164, 2, "YT75963-1", 2, new DateTime(2021, 9, 5, 0, 39, 48, 66, DateTimeKind.Unspecified).AddTicks(3078), new DateTime(2021, 5, 16, 5, 49, 40, 227, DateTimeKind.Unspecified).AddTicks(3505) },
                    { 36, 2, "YT75315-0", 2, new DateTime(2021, 12, 20, 7, 57, 23, 288, DateTimeKind.Unspecified).AddTicks(3441), new DateTime(2021, 5, 18, 14, 32, 54, 147, DateTimeKind.Unspecified).AddTicks(447) },
                    { 37, 1, "YT71765-1", 2, new DateTime(2021, 9, 3, 16, 51, 11, 673, DateTimeKind.Unspecified).AddTicks(1548), new DateTime(2021, 5, 28, 14, 49, 6, 931, DateTimeKind.Unspecified).AddTicks(9517) },
                    { 41, 5, "YT87542-0", 2, new DateTime(2021, 11, 18, 21, 0, 20, 313, DateTimeKind.Unspecified).AddTicks(7452), new DateTime(2021, 7, 24, 7, 36, 23, 611, DateTimeKind.Unspecified).AddTicks(9332) },
                    { 48, 4, "YT85292-0", 2, new DateTime(2021, 9, 6, 18, 49, 2, 673, DateTimeKind.Unspecified).AddTicks(2274), new DateTime(2021, 8, 13, 23, 37, 8, 485, DateTimeKind.Unspecified).AddTicks(3705) },
                    { 49, 5, "YT53109-1", 2, new DateTime(2021, 9, 24, 14, 18, 47, 17, DateTimeKind.Unspecified).AddTicks(1793), new DateTime(2021, 5, 16, 2, 33, 43, 404, DateTimeKind.Unspecified).AddTicks(5727) },
                    { 51, 3, "YT18912-0", 2, new DateTime(2021, 10, 18, 7, 55, 17, 427, DateTimeKind.Unspecified).AddTicks(3087), new DateTime(2021, 7, 31, 16, 47, 41, 222, DateTimeKind.Unspecified).AddTicks(3549) },
                    { 52, 1, "YT87469-1", 2, new DateTime(2021, 9, 19, 10, 11, 17, 380, DateTimeKind.Unspecified).AddTicks(2764), new DateTime(2021, 6, 4, 14, 16, 22, 36, DateTimeKind.Unspecified).AddTicks(9960) },
                    { 62, 4, "YT19822-1", 2, new DateTime(2021, 12, 27, 17, 44, 14, 593, DateTimeKind.Unspecified).AddTicks(2084), new DateTime(2021, 6, 13, 22, 13, 27, 472, DateTimeKind.Unspecified).AddTicks(6507) },
                    { 65, 5, "YT85020-1", 2, new DateTime(2021, 11, 18, 16, 17, 10, 574, DateTimeKind.Unspecified).AddTicks(6292), new DateTime(2021, 6, 27, 20, 10, 38, 634, DateTimeKind.Unspecified).AddTicks(6038) },
                    { 67, 1, "YT93754-1", 2, new DateTime(2021, 10, 14, 11, 2, 18, 469, DateTimeKind.Unspecified).AddTicks(4881), new DateTime(2021, 8, 27, 0, 12, 42, 504, DateTimeKind.Unspecified).AddTicks(7359) },
                    { 68, 3, "YT43634-0", 2, new DateTime(2021, 9, 4, 12, 58, 18, 185, DateTimeKind.Unspecified).AddTicks(3524), new DateTime(2021, 5, 13, 8, 8, 2, 208, DateTimeKind.Unspecified).AddTicks(5159) },
                    { 72, 3, "YT55033-1", 2, new DateTime(2021, 12, 11, 0, 13, 8, 322, DateTimeKind.Unspecified).AddTicks(3388), new DateTime(2021, 8, 3, 15, 37, 48, 987, DateTimeKind.Unspecified).AddTicks(1558) },
                    { 77, 3, "YT85171-1", 2, new DateTime(2021, 10, 13, 10, 6, 42, 488, DateTimeKind.Unspecified).AddTicks(7880), new DateTime(2021, 5, 16, 20, 41, 11, 751, DateTimeKind.Unspecified).AddTicks(1554) },
                    { 697, 2, "YT14020-1", 1, new DateTime(2021, 9, 7, 20, 7, 47, 690, DateTimeKind.Unspecified).AddTicks(3690), new DateTime(2021, 5, 18, 9, 27, 54, 361, DateTimeKind.Unspecified).AddTicks(7649) },
                    { 80, 3, "YT90732-1", 2, new DateTime(2021, 10, 29, 4, 52, 15, 282, DateTimeKind.Unspecified).AddTicks(433), new DateTime(2021, 8, 7, 4, 1, 33, 688, DateTimeKind.Unspecified).AddTicks(7630) },
                    { 84, 4, "YT28137-1", 2, new DateTime(2021, 9, 4, 20, 21, 40, 422, DateTimeKind.Unspecified).AddTicks(9276), new DateTime(2021, 5, 13, 0, 17, 49, 241, DateTimeKind.Unspecified).AddTicks(325) },
                    { 85, 1, "YT88572-0", 2, new DateTime(2021, 10, 9, 10, 52, 32, 116, DateTimeKind.Unspecified).AddTicks(4421), new DateTime(2021, 5, 9, 4, 30, 20, 48, DateTimeKind.Unspecified).AddTicks(5409) },
                    { 96, 1, "YT90552-1", 2, new DateTime(2021, 9, 11, 11, 37, 47, 879, DateTimeKind.Unspecified).AddTicks(1420), new DateTime(2021, 5, 16, 8, 11, 39, 328, DateTimeKind.Unspecified).AddTicks(4005) },
                    { 103, 3, "YT23610-0", 2, new DateTime(2021, 9, 3, 23, 48, 37, 359, DateTimeKind.Unspecified).AddTicks(2043), new DateTime(2021, 6, 5, 19, 57, 1, 348, DateTimeKind.Unspecified).AddTicks(1090) },
                    { 104, 5, "YT79504-1", 2, new DateTime(2021, 12, 13, 22, 6, 41, 66, DateTimeKind.Unspecified).AddTicks(1243), new DateTime(2021, 7, 20, 1, 18, 55, 579, DateTimeKind.Unspecified).AddTicks(5867) },
                    { 105, 3, "YT89607-1", 2, new DateTime(2021, 11, 24, 7, 0, 34, 145, DateTimeKind.Unspecified).AddTicks(2165), new DateTime(2021, 7, 11, 9, 39, 7, 981, DateTimeKind.Unspecified).AddTicks(2054) },
                    { 110, 1, "YT32898-0", 2, new DateTime(2021, 11, 26, 16, 34, 33, 228, DateTimeKind.Unspecified).AddTicks(8013), new DateTime(2021, 7, 11, 11, 37, 5, 654, DateTimeKind.Unspecified).AddTicks(9494) },
                    { 112, 2, "YT93360-0", 2, new DateTime(2021, 11, 21, 0, 23, 49, 556, DateTimeKind.Unspecified).AddTicks(5999), new DateTime(2021, 5, 12, 17, 9, 20, 113, DateTimeKind.Unspecified).AddTicks(7210) },
                    { 127, 2, "YT99375-0", 2, new DateTime(2021, 12, 28, 15, 24, 6, 13, DateTimeKind.Unspecified).AddTicks(9488), new DateTime(2021, 8, 8, 17, 56, 20, 88, DateTimeKind.Unspecified).AddTicks(9316) },
                    { 132, 4, "YT10609-1", 2, new DateTime(2021, 11, 8, 9, 37, 1, 385, DateTimeKind.Unspecified).AddTicks(6337), new DateTime(2021, 6, 16, 13, 34, 33, 976, DateTimeKind.Unspecified).AddTicks(6095) },
                    { 133, 3, "YT54614-0", 2, new DateTime(2021, 11, 2, 5, 15, 28, 369, DateTimeKind.Unspecified).AddTicks(1167), new DateTime(2021, 7, 14, 3, 59, 2, 966, DateTimeKind.Unspecified).AddTicks(9089) },
                    { 139, 3, "YT73927-1", 2, new DateTime(2021, 12, 24, 20, 23, 2, 853, DateTimeKind.Unspecified).AddTicks(1786), new DateTime(2021, 8, 3, 16, 17, 24, 178, DateTimeKind.Unspecified).AddTicks(8604) },
                    { 145, 4, "YT32591-0", 2, new DateTime(2021, 11, 27, 17, 18, 0, 925, DateTimeKind.Unspecified).AddTicks(3804), new DateTime(2021, 8, 6, 8, 13, 23, 574, DateTimeKind.Unspecified).AddTicks(3047) },
                    { 81, 4, "YT31822-0", 2, new DateTime(2021, 9, 2, 15, 37, 0, 891, DateTimeKind.Unspecified).AddTicks(9832), new DateTime(2021, 7, 13, 7, 49, 19, 617, DateTimeKind.Unspecified).AddTicks(2598) },
                    { 302, 4, "YT60976-0", 2, new DateTime(2021, 10, 19, 14, 0, 58, 691, DateTimeKind.Unspecified).AddTicks(6115), new DateTime(2021, 7, 13, 19, 40, 27, 601, DateTimeKind.Unspecified).AddTicks(4971) },
                    { 687, 2, "YT33572-1", 1, new DateTime(2021, 10, 3, 6, 11, 46, 799, DateTimeKind.Unspecified).AddTicks(6367), new DateTime(2021, 7, 5, 8, 24, 47, 273, DateTimeKind.Unspecified).AddTicks(4330) },
                    { 680, 4, "YT48483-1", 1, new DateTime(2021, 9, 7, 2, 40, 8, 455, DateTimeKind.Unspecified).AddTicks(8338), new DateTime(2021, 8, 20, 1, 35, 55, 753, DateTimeKind.Unspecified).AddTicks(6152) },
                    { 202, 5, "YT27730-0", 1, new DateTime(2021, 10, 23, 11, 49, 47, 483, DateTimeKind.Unspecified).AddTicks(7686), new DateTime(2021, 8, 20, 15, 25, 14, 787, DateTimeKind.Unspecified).AddTicks(7058) },
                    { 206, 1, "YT38938-1", 1, new DateTime(2021, 9, 3, 10, 38, 10, 840, DateTimeKind.Unspecified).AddTicks(431), new DateTime(2021, 5, 14, 13, 27, 5, 438, DateTimeKind.Unspecified).AddTicks(9497) },
                    { 208, 3, "YT29620-0", 1, new DateTime(2021, 11, 2, 0, 46, 43, 87, DateTimeKind.Unspecified).AddTicks(6739), new DateTime(2021, 8, 3, 18, 23, 6, 273, DateTimeKind.Unspecified).AddTicks(3404) },
                    { 210, 1, "YT47932-0", 1, new DateTime(2021, 9, 11, 23, 24, 50, 896, DateTimeKind.Unspecified).AddTicks(5324), new DateTime(2021, 6, 14, 13, 14, 18, 738, DateTimeKind.Unspecified).AddTicks(7426) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 211, 1, "YT76900-1", 1, new DateTime(2021, 10, 14, 13, 47, 20, 826, DateTimeKind.Unspecified).AddTicks(10), new DateTime(2021, 7, 13, 5, 55, 39, 332, DateTimeKind.Unspecified).AddTicks(9869) },
                    { 214, 3, "YT94774-0", 1, new DateTime(2021, 10, 11, 4, 7, 53, 463, DateTimeKind.Unspecified).AddTicks(1667), new DateTime(2021, 7, 21, 18, 34, 32, 651, DateTimeKind.Unspecified).AddTicks(2714) },
                    { 223, 2, "YT60693-0", 1, new DateTime(2021, 12, 25, 7, 30, 52, 938, DateTimeKind.Unspecified).AddTicks(4098), new DateTime(2021, 6, 9, 5, 58, 42, 511, DateTimeKind.Unspecified).AddTicks(5548) },
                    { 229, 2, "YT25730-1", 1, new DateTime(2021, 11, 5, 22, 26, 53, 736, DateTimeKind.Unspecified).AddTicks(8355), new DateTime(2021, 6, 15, 1, 27, 16, 387, DateTimeKind.Unspecified).AddTicks(9750) },
                    { 230, 3, "YT79974-1", 1, new DateTime(2021, 9, 10, 8, 53, 55, 63, DateTimeKind.Unspecified).AddTicks(7123), new DateTime(2021, 7, 26, 17, 1, 52, 163, DateTimeKind.Unspecified).AddTicks(2236) },
                    { 236, 4, "YT15362-0", 1, new DateTime(2021, 10, 16, 20, 3, 59, 961, DateTimeKind.Unspecified).AddTicks(9320), new DateTime(2021, 7, 8, 11, 26, 40, 24, DateTimeKind.Unspecified).AddTicks(7074) },
                    { 237, 5, "YT31551-1", 1, new DateTime(2021, 9, 15, 23, 49, 42, 886, DateTimeKind.Unspecified).AddTicks(1472), new DateTime(2021, 7, 13, 3, 40, 39, 610, DateTimeKind.Unspecified).AddTicks(6722) },
                    { 239, 1, "YT37229-0", 1, new DateTime(2021, 9, 21, 2, 30, 1, 909, DateTimeKind.Unspecified).AddTicks(5761), new DateTime(2021, 6, 10, 13, 11, 38, 213, DateTimeKind.Unspecified).AddTicks(2805) },
                    { 250, 4, "YT57237-1", 1, new DateTime(2021, 12, 7, 2, 13, 51, 428, DateTimeKind.Unspecified).AddTicks(9414), new DateTime(2021, 7, 24, 20, 57, 45, 103, DateTimeKind.Unspecified).AddTicks(3216) },
                    { 255, 5, "YT51775-1", 1, new DateTime(2021, 11, 25, 13, 6, 46, 658, DateTimeKind.Unspecified).AddTicks(5552), new DateTime(2021, 5, 25, 5, 37, 15, 419, DateTimeKind.Unspecified).AddTicks(1591) },
                    { 261, 2, "YT16075-0", 1, new DateTime(2021, 11, 22, 1, 40, 27, 620, DateTimeKind.Unspecified).AddTicks(5776), new DateTime(2021, 6, 12, 13, 30, 10, 425, DateTimeKind.Unspecified).AddTicks(9568) },
                    { 265, 3, "YT46522-1", 1, new DateTime(2021, 11, 8, 10, 34, 45, 705, DateTimeKind.Unspecified).AddTicks(6497), new DateTime(2021, 7, 31, 16, 22, 19, 168, DateTimeKind.Unspecified).AddTicks(2482) },
                    { 270, 1, "YT22026-1", 1, new DateTime(2021, 11, 17, 12, 51, 31, 103, DateTimeKind.Unspecified).AddTicks(5932), new DateTime(2021, 8, 15, 15, 10, 6, 703, DateTimeKind.Unspecified).AddTicks(1116) },
                    { 272, 2, "YT72056-0", 1, new DateTime(2021, 10, 9, 5, 30, 8, 632, DateTimeKind.Unspecified).AddTicks(1759), new DateTime(2021, 8, 12, 0, 39, 14, 565, DateTimeKind.Unspecified).AddTicks(5038) },
                    { 275, 3, "YT62571-1", 1, new DateTime(2021, 11, 27, 14, 22, 31, 446, DateTimeKind.Unspecified).AddTicks(1371), new DateTime(2021, 7, 2, 7, 23, 12, 642, DateTimeKind.Unspecified).AddTicks(7369) },
                    { 280, 1, "YT73782-1", 1, new DateTime(2021, 11, 12, 5, 39, 6, 243, DateTimeKind.Unspecified).AddTicks(1004), new DateTime(2021, 7, 29, 12, 31, 37, 706, DateTimeKind.Unspecified).AddTicks(7666) },
                    { 284, 3, "YT99648-1", 1, new DateTime(2021, 9, 1, 21, 50, 30, 757, DateTimeKind.Unspecified).AddTicks(8080), new DateTime(2021, 5, 10, 16, 26, 56, 213, DateTimeKind.Unspecified).AddTicks(1749) },
                    { 290, 4, "YT46381-1", 1, new DateTime(2021, 10, 18, 2, 36, 56, 29, DateTimeKind.Unspecified).AddTicks(3578), new DateTime(2021, 6, 24, 20, 4, 18, 993, DateTimeKind.Unspecified).AddTicks(3717) },
                    { 291, 1, "YT21127-1", 1, new DateTime(2021, 9, 7, 9, 47, 16, 739, DateTimeKind.Unspecified).AddTicks(9708), new DateTime(2021, 8, 28, 23, 27, 55, 97, DateTimeKind.Unspecified).AddTicks(3037) },
                    { 300, 2, "YT79340-1", 1, new DateTime(2021, 11, 30, 3, 37, 29, 209, DateTimeKind.Unspecified).AddTicks(8944), new DateTime(2021, 7, 28, 5, 50, 14, 241, DateTimeKind.Unspecified).AddTicks(63) },
                    { 310, 2, "YT57400-0", 1, new DateTime(2021, 9, 23, 6, 33, 0, 738, DateTimeKind.Unspecified).AddTicks(7343), new DateTime(2021, 6, 26, 6, 14, 1, 454, DateTimeKind.Unspecified).AddTicks(7101) },
                    { 325, 3, "YT89962-0", 1, new DateTime(2021, 9, 22, 8, 5, 30, 345, DateTimeKind.Unspecified).AddTicks(2076), new DateTime(2021, 6, 21, 19, 36, 42, 116, DateTimeKind.Unspecified).AddTicks(4597) },
                    { 333, 4, "YT41484-1", 1, new DateTime(2021, 12, 1, 9, 17, 30, 893, DateTimeKind.Unspecified).AddTicks(2493), new DateTime(2021, 5, 21, 10, 37, 17, 919, DateTimeKind.Unspecified).AddTicks(7105) },
                    { 198, 5, "YT67376-0", 1, new DateTime(2021, 10, 21, 3, 12, 5, 374, DateTimeKind.Unspecified).AddTicks(7875), new DateTime(2021, 7, 12, 1, 38, 52, 335, DateTimeKind.Unspecified).AddTicks(3572) },
                    { 336, 2, "YT92827-1", 1, new DateTime(2021, 12, 8, 3, 56, 25, 75, DateTimeKind.Unspecified).AddTicks(6711), new DateTime(2021, 8, 15, 8, 14, 32, 455, DateTimeKind.Unspecified).AddTicks(5243) },
                    { 185, 5, "YT33324-1", 1, new DateTime(2021, 9, 28, 19, 29, 18, 905, DateTimeKind.Unspecified).AddTicks(8279), new DateTime(2021, 8, 26, 0, 48, 42, 798, DateTimeKind.Unspecified).AddTicks(8734) },
                    { 173, 2, "YT89571-1", 1, new DateTime(2021, 9, 30, 0, 24, 19, 83, DateTimeKind.Unspecified).AddTicks(4967), new DateTime(2021, 8, 26, 21, 15, 46, 917, DateTimeKind.Unspecified).AddTicks(1687) },
                    { 13, 5, "YT17116-1", 1, new DateTime(2021, 10, 12, 16, 17, 4, 339, DateTimeKind.Unspecified).AddTicks(4991), new DateTime(2021, 8, 29, 11, 9, 5, 482, DateTimeKind.Unspecified).AddTicks(6900) },
                    { 40, 5, "YT69797-0", 1, new DateTime(2021, 12, 4, 3, 4, 4, 96, DateTimeKind.Unspecified).AddTicks(9712), new DateTime(2021, 7, 28, 18, 38, 43, 906, DateTimeKind.Unspecified).AddTicks(342) },
                    { 46, 3, "YT76468-1", 1, new DateTime(2021, 12, 9, 22, 2, 49, 601, DateTimeKind.Unspecified).AddTicks(9602), new DateTime(2021, 5, 27, 18, 7, 2, 33, DateTimeKind.Unspecified).AddTicks(7903) },
                    { 56, 4, "YT19800-1", 1, new DateTime(2021, 12, 3, 5, 39, 20, 52, DateTimeKind.Unspecified).AddTicks(378), new DateTime(2021, 6, 5, 2, 4, 10, 129, DateTimeKind.Unspecified).AddTicks(1369) },
                    { 61, 5, "YT69365-0", 1, new DateTime(2021, 10, 18, 14, 29, 41, 48, DateTimeKind.Unspecified).AddTicks(1925), new DateTime(2021, 5, 9, 17, 21, 5, 214, DateTimeKind.Unspecified).AddTicks(3427) },
                    { 82, 1, "YT99526-1", 1, new DateTime(2021, 12, 26, 4, 16, 59, 297, DateTimeKind.Unspecified).AddTicks(199), new DateTime(2021, 6, 10, 12, 20, 21, 388, DateTimeKind.Unspecified).AddTicks(8897) },
                    { 83, 1, "YT69050-0", 1, new DateTime(2021, 12, 23, 8, 47, 34, 235, DateTimeKind.Unspecified).AddTicks(8844), new DateTime(2021, 7, 14, 13, 14, 17, 136, DateTimeKind.Unspecified).AddTicks(4580) },
                    { 86, 5, "YT49432-0", 1, new DateTime(2021, 12, 26, 16, 11, 20, 662, DateTimeKind.Unspecified).AddTicks(5861), new DateTime(2021, 6, 5, 10, 30, 5, 976, DateTimeKind.Unspecified).AddTicks(1670) },
                    { 88, 5, "YT72906-0", 1, new DateTime(2021, 9, 11, 2, 32, 6, 488, DateTimeKind.Unspecified).AddTicks(7837), new DateTime(2021, 6, 3, 11, 34, 55, 697, DateTimeKind.Unspecified).AddTicks(3359) },
                    { 89, 2, "YT65531-1", 1, new DateTime(2021, 9, 6, 0, 59, 13, 361, DateTimeKind.Unspecified).AddTicks(1344), new DateTime(2021, 6, 20, 21, 28, 57, 248, DateTimeKind.Unspecified).AddTicks(1870) },
                    { 90, 2, "YT23854-1", 1, new DateTime(2021, 10, 25, 10, 35, 37, 821, DateTimeKind.Unspecified).AddTicks(2793), new DateTime(2021, 8, 7, 4, 8, 53, 235, DateTimeKind.Unspecified).AddTicks(7655) },
                    { 92, 2, "YT95971-1", 1, new DateTime(2021, 11, 4, 12, 3, 38, 15, DateTimeKind.Unspecified).AddTicks(7357), new DateTime(2021, 5, 29, 8, 20, 58, 895, DateTimeKind.Unspecified).AddTicks(297) },
                    { 101, 3, "YT25219-1", 1, new DateTime(2021, 11, 1, 3, 29, 2, 309, DateTimeKind.Unspecified).AddTicks(2036), new DateTime(2021, 6, 13, 18, 35, 10, 670, DateTimeKind.Unspecified).AddTicks(151) },
                    { 106, 1, "YT60652-1", 1, new DateTime(2021, 12, 14, 9, 46, 14, 815, DateTimeKind.Unspecified).AddTicks(9453), new DateTime(2021, 8, 9, 11, 59, 41, 988, DateTimeKind.Unspecified).AddTicks(4501) },
                    { 107, 1, "YT46184-1", 1, new DateTime(2021, 11, 19, 4, 29, 29, 128, DateTimeKind.Unspecified).AddTicks(8815), new DateTime(2021, 6, 18, 1, 17, 46, 103, DateTimeKind.Unspecified).AddTicks(3592) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 109, 3, "YT56962-0", 1, new DateTime(2021, 9, 22, 0, 13, 28, 222, DateTimeKind.Unspecified).AddTicks(8143), new DateTime(2021, 8, 7, 12, 53, 44, 409, DateTimeKind.Unspecified).AddTicks(5691) },
                    { 113, 3, "YT94806-1", 1, new DateTime(2021, 12, 23, 1, 10, 7, 110, DateTimeKind.Unspecified).AddTicks(8376), new DateTime(2021, 6, 30, 3, 59, 40, 956, DateTimeKind.Unspecified).AddTicks(7653) },
                    { 116, 2, "YT55552-0", 1, new DateTime(2021, 11, 14, 15, 58, 56, 858, DateTimeKind.Unspecified).AddTicks(907), new DateTime(2021, 8, 17, 23, 43, 25, 133, DateTimeKind.Unspecified).AddTicks(7804) },
                    { 118, 3, "YT15924-0", 1, new DateTime(2021, 9, 6, 9, 28, 58, 645, DateTimeKind.Unspecified).AddTicks(9063), new DateTime(2021, 7, 11, 0, 49, 22, 694, DateTimeKind.Unspecified).AddTicks(9354) },
                    { 121, 4, "YT73102-1", 1, new DateTime(2021, 12, 10, 14, 44, 8, 558, DateTimeKind.Unspecified).AddTicks(3135), new DateTime(2021, 8, 12, 11, 49, 8, 566, DateTimeKind.Unspecified).AddTicks(3776) },
                    { 125, 4, "YT87971-0", 1, new DateTime(2021, 12, 12, 0, 48, 5, 674, DateTimeKind.Unspecified).AddTicks(7939), new DateTime(2021, 5, 20, 22, 9, 51, 410, DateTimeKind.Unspecified).AddTicks(9780) },
                    { 128, 1, "YT26204-0", 1, new DateTime(2021, 9, 27, 17, 57, 10, 142, DateTimeKind.Unspecified).AddTicks(4521), new DateTime(2021, 5, 22, 8, 45, 53, 460, DateTimeKind.Unspecified).AddTicks(8124) },
                    { 129, 5, "YT86307-1", 1, new DateTime(2021, 9, 3, 8, 54, 11, 932, DateTimeKind.Unspecified).AddTicks(7820), new DateTime(2021, 8, 16, 1, 33, 19, 591, DateTimeKind.Unspecified).AddTicks(2354) },
                    { 140, 2, "YT81692-1", 1, new DateTime(2021, 11, 21, 20, 14, 11, 791, DateTimeKind.Unspecified).AddTicks(2831), new DateTime(2021, 5, 30, 15, 50, 7, 624, DateTimeKind.Unspecified).AddTicks(2683) },
                    { 147, 2, "YT95046-0", 1, new DateTime(2021, 10, 29, 23, 55, 5, 734, DateTimeKind.Unspecified).AddTicks(2856), new DateTime(2021, 7, 16, 20, 48, 38, 541, DateTimeKind.Unspecified).AddTicks(6511) },
                    { 151, 5, "YT97174-0", 1, new DateTime(2021, 12, 2, 2, 41, 46, 120, DateTimeKind.Unspecified).AddTicks(6028), new DateTime(2021, 8, 3, 3, 56, 47, 346, DateTimeKind.Unspecified).AddTicks(4415) },
                    { 152, 1, "YT51719-1", 1, new DateTime(2021, 12, 10, 3, 3, 24, 122, DateTimeKind.Unspecified).AddTicks(925), new DateTime(2021, 7, 10, 6, 32, 33, 106, DateTimeKind.Unspecified).AddTicks(9791) },
                    { 183, 4, "YT67716-1", 1, new DateTime(2021, 11, 26, 11, 55, 2, 734, DateTimeKind.Unspecified).AddTicks(3622), new DateTime(2021, 6, 5, 20, 50, 28, 611, DateTimeKind.Unspecified).AddTicks(5430) },
                    { 341, 5, "YT13867-0", 1, new DateTime(2021, 12, 13, 3, 23, 49, 936, DateTimeKind.Unspecified).AddTicks(2046), new DateTime(2021, 8, 7, 10, 25, 33, 396, DateTimeKind.Unspecified).AddTicks(2332) },
                    { 347, 4, "YT28620-0", 1, new DateTime(2021, 10, 31, 21, 50, 50, 916, DateTimeKind.Unspecified).AddTicks(4193), new DateTime(2021, 7, 7, 2, 55, 45, 946, DateTimeKind.Unspecified).AddTicks(6253) },
                    { 353, 4, "YT80165-1", 1, new DateTime(2021, 10, 30, 23, 15, 14, 198, DateTimeKind.Unspecified).AddTicks(5136), new DateTime(2021, 8, 6, 17, 9, 42, 130, DateTimeKind.Unspecified).AddTicks(2180) },
                    { 538, 3, "YT21747-1", 1, new DateTime(2021, 11, 7, 14, 38, 6, 900, DateTimeKind.Unspecified).AddTicks(3675), new DateTime(2021, 7, 31, 1, 41, 37, 378, DateTimeKind.Unspecified).AddTicks(1957) },
                    { 539, 3, "YT27706-0", 1, new DateTime(2021, 10, 28, 3, 22, 28, 134, DateTimeKind.Unspecified).AddTicks(8780), new DateTime(2021, 5, 18, 4, 25, 47, 221, DateTimeKind.Unspecified).AddTicks(2940) },
                    { 548, 5, "YT64357-0", 1, new DateTime(2021, 12, 9, 15, 44, 57, 567, DateTimeKind.Unspecified).AddTicks(1689), new DateTime(2021, 5, 16, 17, 32, 12, 923, DateTimeKind.Unspecified).AddTicks(6965) },
                    { 549, 4, "YT60045-0", 1, new DateTime(2021, 10, 29, 13, 11, 31, 350, DateTimeKind.Unspecified).AddTicks(7549), new DateTime(2021, 7, 27, 1, 6, 20, 979, DateTimeKind.Unspecified).AddTicks(6158) },
                    { 550, 3, "YT24241-1", 1, new DateTime(2021, 12, 20, 17, 55, 0, 361, DateTimeKind.Unspecified).AddTicks(9047), new DateTime(2021, 8, 11, 8, 2, 26, 617, DateTimeKind.Unspecified).AddTicks(952) },
                    { 555, 3, "YT15321-0", 1, new DateTime(2021, 11, 27, 21, 50, 11, 348, DateTimeKind.Unspecified).AddTicks(2975), new DateTime(2021, 5, 29, 18, 23, 11, 588, DateTimeKind.Unspecified).AddTicks(169) },
                    { 556, 5, "YT47448-0", 1, new DateTime(2021, 11, 12, 23, 37, 9, 985, DateTimeKind.Unspecified).AddTicks(1411), new DateTime(2021, 8, 5, 11, 55, 51, 482, DateTimeKind.Unspecified).AddTicks(4784) },
                    { 558, 4, "YT12459-0", 1, new DateTime(2021, 9, 22, 4, 23, 34, 254, DateTimeKind.Unspecified).AddTicks(2421), new DateTime(2021, 7, 16, 17, 11, 56, 949, DateTimeKind.Unspecified).AddTicks(5230) },
                    { 566, 1, "YT25580-1", 1, new DateTime(2021, 12, 12, 4, 40, 12, 823, DateTimeKind.Unspecified).AddTicks(3988), new DateTime(2021, 7, 14, 13, 1, 17, 504, DateTimeKind.Unspecified).AddTicks(9994) },
                    { 571, 5, "YT85738-1", 1, new DateTime(2021, 9, 27, 7, 43, 14, 549, DateTimeKind.Unspecified).AddTicks(728), new DateTime(2021, 7, 17, 13, 18, 59, 734, DateTimeKind.Unspecified).AddTicks(9655) },
                    { 573, 2, "YT69140-1", 1, new DateTime(2021, 9, 8, 17, 12, 2, 712, DateTimeKind.Unspecified).AddTicks(345), new DateTime(2021, 7, 5, 11, 6, 21, 292, DateTimeKind.Unspecified).AddTicks(8744) },
                    { 575, 4, "YT66662-1", 1, new DateTime(2021, 10, 15, 18, 39, 4, 848, DateTimeKind.Unspecified).AddTicks(9099), new DateTime(2021, 5, 27, 6, 52, 32, 497, DateTimeKind.Unspecified).AddTicks(945) },
                    { 578, 4, "YT96751-0", 1, new DateTime(2021, 12, 22, 12, 8, 29, 566, DateTimeKind.Unspecified).AddTicks(4377), new DateTime(2021, 8, 12, 7, 5, 0, 467, DateTimeKind.Unspecified).AddTicks(5298) },
                    { 581, 2, "YT23836-0", 1, new DateTime(2021, 10, 3, 6, 49, 23, 443, DateTimeKind.Unspecified).AddTicks(4829), new DateTime(2021, 7, 19, 3, 9, 45, 966, DateTimeKind.Unspecified).AddTicks(6520) },
                    { 594, 3, "YT76923-1", 1, new DateTime(2021, 12, 14, 23, 12, 13, 154, DateTimeKind.Unspecified).AddTicks(1927), new DateTime(2021, 7, 8, 18, 6, 11, 844, DateTimeKind.Unspecified).AddTicks(8048) },
                    { 602, 3, "YT30561-0", 1, new DateTime(2021, 12, 7, 2, 8, 54, 312, DateTimeKind.Unspecified).AddTicks(3874), new DateTime(2021, 7, 10, 0, 25, 19, 596, DateTimeKind.Unspecified).AddTicks(6266) },
                    { 606, 3, "YT18937-1", 1, new DateTime(2021, 9, 6, 18, 47, 11, 551, DateTimeKind.Unspecified).AddTicks(4805), new DateTime(2021, 8, 12, 17, 10, 58, 74, DateTimeKind.Unspecified).AddTicks(4048) },
                    { 607, 1, "YT49877-0", 1, new DateTime(2021, 9, 25, 20, 59, 16, 709, DateTimeKind.Unspecified).AddTicks(2219), new DateTime(2021, 8, 3, 20, 34, 4, 124, DateTimeKind.Unspecified).AddTicks(5066) },
                    { 610, 2, "YT71536-0", 1, new DateTime(2021, 10, 29, 23, 23, 54, 73, DateTimeKind.Unspecified).AddTicks(3041), new DateTime(2021, 5, 30, 11, 7, 29, 720, DateTimeKind.Unspecified).AddTicks(4654) },
                    { 612, 3, "YT65357-0", 1, new DateTime(2021, 11, 9, 6, 38, 40, 717, DateTimeKind.Unspecified).AddTicks(955), new DateTime(2021, 6, 1, 8, 27, 52, 668, DateTimeKind.Unspecified).AddTicks(2432) },
                    { 622, 5, "YT71802-1", 1, new DateTime(2021, 11, 30, 14, 10, 39, 980, DateTimeKind.Unspecified).AddTicks(6737), new DateTime(2021, 7, 16, 23, 49, 24, 798, DateTimeKind.Unspecified).AddTicks(8585) },
                    { 627, 3, "YT29785-1", 1, new DateTime(2021, 11, 29, 19, 14, 37, 498, DateTimeKind.Unspecified).AddTicks(9808), new DateTime(2021, 5, 29, 18, 26, 23, 216, DateTimeKind.Unspecified).AddTicks(6295) },
                    { 629, 4, "YT83554-0", 1, new DateTime(2021, 11, 8, 7, 8, 31, 233, DateTimeKind.Unspecified).AddTicks(4759), new DateTime(2021, 7, 17, 10, 56, 29, 759, DateTimeKind.Unspecified).AddTicks(2087) },
                    { 632, 2, "YT98144-1", 1, new DateTime(2021, 12, 6, 22, 21, 17, 680, DateTimeKind.Unspecified).AddTicks(4405), new DateTime(2021, 7, 14, 22, 29, 15, 718, DateTimeKind.Unspecified).AddTicks(2823) },
                    { 643, 4, "YT17582-1", 1, new DateTime(2021, 12, 2, 6, 47, 30, 417, DateTimeKind.Unspecified).AddTicks(6224), new DateTime(2021, 6, 25, 22, 56, 56, 451, DateTimeKind.Unspecified).AddTicks(9024) },
                    { 658, 3, "YT27349-1", 1, new DateTime(2021, 11, 29, 0, 51, 54, 152, DateTimeKind.Unspecified).AddTicks(3316), new DateTime(2021, 5, 18, 15, 27, 35, 333, DateTimeKind.Unspecified).AddTicks(308) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 663, 1, "YT57383-0", 1, new DateTime(2021, 10, 22, 9, 28, 15, 538, DateTimeKind.Unspecified).AddTicks(7170), new DateTime(2021, 5, 14, 12, 35, 29, 459, DateTimeKind.Unspecified).AddTicks(5631) },
                    { 536, 4, "YT60843-0", 1, new DateTime(2021, 10, 25, 15, 32, 2, 27, DateTimeKind.Unspecified).AddTicks(8225), new DateTime(2021, 7, 14, 15, 21, 34, 372, DateTimeKind.Unspecified).AddTicks(434) },
                    { 533, 2, "YT63143-1", 1, new DateTime(2021, 9, 19, 1, 34, 2, 944, DateTimeKind.Unspecified).AddTicks(7722), new DateTime(2021, 6, 2, 5, 36, 27, 588, DateTimeKind.Unspecified).AddTicks(3584) },
                    { 526, 3, "YT33960-0", 1, new DateTime(2021, 9, 27, 15, 3, 58, 642, DateTimeKind.Unspecified).AddTicks(8668), new DateTime(2021, 8, 24, 10, 22, 30, 570, DateTimeKind.Unspecified).AddTicks(8719) },
                    { 520, 1, "YT26182-0", 1, new DateTime(2021, 10, 2, 21, 49, 34, 745, DateTimeKind.Unspecified).AddTicks(1567), new DateTime(2021, 6, 2, 16, 24, 22, 323, DateTimeKind.Unspecified).AddTicks(6052) },
                    { 355, 5, "YT99626-0", 1, new DateTime(2021, 10, 14, 19, 21, 29, 222, DateTimeKind.Unspecified).AddTicks(1149), new DateTime(2021, 6, 29, 12, 52, 3, 771, DateTimeKind.Unspecified).AddTicks(3299) },
                    { 365, 2, "YT98558-1", 1, new DateTime(2021, 11, 18, 20, 1, 20, 921, DateTimeKind.Unspecified).AddTicks(726), new DateTime(2021, 8, 20, 17, 23, 6, 664, DateTimeKind.Unspecified).AddTicks(561) },
                    { 371, 4, "YT81348-0", 1, new DateTime(2021, 10, 4, 21, 32, 12, 220, DateTimeKind.Unspecified).AddTicks(6963), new DateTime(2021, 8, 16, 7, 36, 5, 463, DateTimeKind.Unspecified).AddTicks(7315) },
                    { 380, 2, "YT93606-0", 1, new DateTime(2021, 11, 20, 21, 18, 30, 843, DateTimeKind.Unspecified).AddTicks(8998), new DateTime(2021, 7, 8, 9, 5, 8, 73, DateTimeKind.Unspecified).AddTicks(7818) },
                    { 386, 5, "YT20373-1", 1, new DateTime(2021, 12, 3, 10, 48, 24, 351, DateTimeKind.Unspecified).AddTicks(5819), new DateTime(2021, 5, 12, 9, 4, 25, 525, DateTimeKind.Unspecified).AddTicks(9940) },
                    { 388, 1, "YT82220-0", 1, new DateTime(2021, 12, 4, 8, 3, 30, 583, DateTimeKind.Unspecified).AddTicks(8777), new DateTime(2021, 7, 23, 11, 28, 37, 644, DateTimeKind.Unspecified).AddTicks(4678) },
                    { 393, 4, "YT72427-1", 1, new DateTime(2021, 11, 16, 22, 2, 25, 318, DateTimeKind.Unspecified).AddTicks(9295), new DateTime(2021, 5, 18, 6, 4, 22, 376, DateTimeKind.Unspecified).AddTicks(4989) },
                    { 398, 4, "YT39470-0", 1, new DateTime(2021, 9, 30, 5, 0, 48, 504, DateTimeKind.Unspecified).AddTicks(8885), new DateTime(2021, 8, 12, 22, 24, 43, 391, DateTimeKind.Unspecified).AddTicks(3344) },
                    { 400, 2, "YT52004-0", 1, new DateTime(2021, 11, 3, 1, 58, 57, 65, DateTimeKind.Unspecified).AddTicks(8982), new DateTime(2021, 6, 17, 9, 20, 13, 816, DateTimeKind.Unspecified).AddTicks(8879) },
                    { 424, 5, "YT62735-1", 1, new DateTime(2021, 12, 1, 18, 50, 34, 179, DateTimeKind.Unspecified).AddTicks(7116), new DateTime(2021, 5, 9, 17, 15, 58, 577, DateTimeKind.Unspecified).AddTicks(1001) },
                    { 425, 5, "YT40952-1", 1, new DateTime(2021, 11, 9, 0, 29, 11, 193, DateTimeKind.Unspecified).AddTicks(4795), new DateTime(2021, 6, 18, 15, 12, 9, 17, DateTimeKind.Unspecified).AddTicks(1133) },
                    { 428, 4, "YT22327-0", 1, new DateTime(2021, 12, 28, 0, 33, 18, 829, DateTimeKind.Unspecified).AddTicks(3523), new DateTime(2021, 7, 19, 4, 49, 2, 952, DateTimeKind.Unspecified).AddTicks(8511) },
                    { 430, 3, "YT43445-0", 1, new DateTime(2021, 10, 9, 11, 5, 8, 529, DateTimeKind.Unspecified).AddTicks(767), new DateTime(2021, 5, 20, 13, 24, 30, 412, DateTimeKind.Unspecified).AddTicks(7536) },
                    { 681, 3, "YT95722-0", 1, new DateTime(2021, 11, 13, 7, 18, 37, 161, DateTimeKind.Unspecified).AddTicks(5917), new DateTime(2021, 6, 8, 19, 24, 39, 362, DateTimeKind.Unspecified).AddTicks(2223) },
                    { 431, 1, "YT10333-0", 1, new DateTime(2021, 11, 19, 18, 54, 55, 387, DateTimeKind.Unspecified).AddTicks(5084), new DateTime(2021, 6, 18, 21, 4, 28, 974, DateTimeKind.Unspecified).AddTicks(6778) },
                    { 454, 5, "YT63482-1", 1, new DateTime(2021, 11, 3, 11, 54, 24, 791, DateTimeKind.Unspecified).AddTicks(1361), new DateTime(2021, 7, 15, 2, 18, 23, 883, DateTimeKind.Unspecified).AddTicks(3076) },
                    { 466, 3, "YT77147-1", 1, new DateTime(2021, 10, 30, 12, 31, 4, 14, DateTimeKind.Unspecified).AddTicks(1712), new DateTime(2021, 7, 9, 4, 41, 35, 33, DateTimeKind.Unspecified).AddTicks(3331) },
                    { 467, 1, "YT99870-1", 1, new DateTime(2021, 9, 28, 20, 5, 44, 658, DateTimeKind.Unspecified).AddTicks(8093), new DateTime(2021, 8, 14, 6, 46, 17, 893, DateTimeKind.Unspecified).AddTicks(6947) },
                    { 476, 2, "YT61305-1", 1, new DateTime(2021, 12, 28, 8, 10, 9, 822, DateTimeKind.Unspecified).AddTicks(5492), new DateTime(2021, 6, 2, 4, 38, 50, 717, DateTimeKind.Unspecified).AddTicks(7487) },
                    { 478, 2, "YT34148-0", 1, new DateTime(2021, 12, 15, 0, 15, 55, 560, DateTimeKind.Unspecified).AddTicks(2168), new DateTime(2021, 7, 16, 22, 17, 46, 977, DateTimeKind.Unspecified).AddTicks(3386) },
                    { 479, 1, "YT82464-0", 1, new DateTime(2021, 12, 16, 13, 34, 5, 568, DateTimeKind.Unspecified).AddTicks(2744), new DateTime(2021, 6, 1, 1, 12, 33, 693, DateTimeKind.Unspecified).AddTicks(4262) },
                    { 484, 3, "YT79056-0", 1, new DateTime(2021, 9, 6, 4, 24, 27, 491, DateTimeKind.Unspecified).AddTicks(8532), new DateTime(2021, 5, 23, 3, 11, 26, 290, DateTimeKind.Unspecified).AddTicks(1473) },
                    { 493, 4, "YT53821-0", 1, new DateTime(2021, 11, 14, 22, 33, 10, 985, DateTimeKind.Unspecified).AddTicks(9663), new DateTime(2021, 5, 26, 1, 19, 3, 553, DateTimeKind.Unspecified).AddTicks(3918) },
                    { 498, 4, "YT45306-0", 1, new DateTime(2021, 11, 11, 7, 27, 32, 589, DateTimeKind.Unspecified).AddTicks(237), new DateTime(2021, 7, 30, 21, 48, 34, 717, DateTimeKind.Unspecified).AddTicks(1580) },
                    { 503, 5, "YT80703-0", 1, new DateTime(2021, 12, 22, 23, 48, 27, 82, DateTimeKind.Unspecified).AddTicks(8569), new DateTime(2021, 5, 28, 11, 1, 26, 657, DateTimeKind.Unspecified).AddTicks(8198) },
                    { 507, 3, "YT47182-1", 1, new DateTime(2021, 11, 14, 15, 24, 16, 828, DateTimeKind.Unspecified).AddTicks(121), new DateTime(2021, 8, 20, 10, 34, 33, 95, DateTimeKind.Unspecified).AddTicks(3379) },
                    { 513, 1, "YT89384-0", 1, new DateTime(2021, 11, 29, 1, 23, 7, 59, DateTimeKind.Unspecified).AddTicks(5747), new DateTime(2021, 7, 30, 6, 7, 0, 583, DateTimeKind.Unspecified).AddTicks(36) },
                    { 516, 3, "YT65578-0", 1, new DateTime(2021, 10, 25, 17, 10, 0, 819, DateTimeKind.Unspecified).AddTicks(324), new DateTime(2021, 5, 13, 22, 21, 12, 440, DateTimeKind.Unspecified).AddTicks(344) },
                    { 435, 2, "YT38989-1", 1, new DateTime(2021, 11, 19, 13, 4, 32, 297, DateTimeKind.Unspecified).AddTicks(9884), new DateTime(2021, 8, 30, 7, 14, 4, 251, DateTimeKind.Unspecified).AddTicks(1024) },
                    { 304, 2, "YT16777-1", 2, new DateTime(2021, 12, 26, 8, 58, 29, 700, DateTimeKind.Unspecified).AddTicks(3238), new DateTime(2021, 5, 27, 13, 14, 3, 762, DateTimeKind.Unspecified).AddTicks(6017) },
                    { 306, 5, "YT24009-1", 2, new DateTime(2021, 10, 30, 16, 10, 41, 215, DateTimeKind.Unspecified).AddTicks(1235), new DateTime(2021, 6, 6, 10, 43, 19, 817, DateTimeKind.Unspecified).AddTicks(2850) },
                    { 311, 3, "YT95880-1", 2, new DateTime(2021, 11, 22, 10, 40, 11, 41, DateTimeKind.Unspecified).AddTicks(7649), new DateTime(2021, 6, 30, 10, 28, 58, 188, DateTimeKind.Unspecified).AddTicks(3633) },
                    { 160, 4, "YT18141-0", 3, new DateTime(2021, 10, 28, 13, 37, 50, 474, DateTimeKind.Unspecified).AddTicks(8799), new DateTime(2021, 8, 26, 16, 3, 30, 245, DateTimeKind.Unspecified).AddTicks(3024) },
                    { 165, 3, "YT15393-1", 3, new DateTime(2021, 12, 23, 23, 6, 46, 226, DateTimeKind.Unspecified).AddTicks(5754), new DateTime(2021, 7, 1, 3, 17, 11, 950, DateTimeKind.Unspecified).AddTicks(3929) },
                    { 167, 5, "YT56798-1", 3, new DateTime(2021, 12, 29, 0, 4, 4, 868, DateTimeKind.Unspecified).AddTicks(3561), new DateTime(2021, 8, 14, 4, 55, 51, 796, DateTimeKind.Unspecified).AddTicks(6606) },
                    { 169, 1, "YT35754-1", 3, new DateTime(2021, 9, 2, 3, 35, 15, 862, DateTimeKind.Unspecified).AddTicks(1565), new DateTime(2021, 8, 20, 17, 59, 4, 793, DateTimeKind.Unspecified).AddTicks(5704) },
                    { 171, 1, "YT52524-1", 3, new DateTime(2021, 9, 4, 3, 35, 2, 258, DateTimeKind.Unspecified).AddTicks(863), new DateTime(2021, 6, 3, 20, 2, 52, 304, DateTimeKind.Unspecified).AddTicks(1215) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 177, 2, "YT56116-0", 3, new DateTime(2021, 10, 12, 22, 36, 22, 979, DateTimeKind.Unspecified).AddTicks(7349), new DateTime(2021, 7, 31, 1, 10, 22, 303, DateTimeKind.Unspecified).AddTicks(706) },
                    { 184, 5, "YT13087-1", 3, new DateTime(2021, 9, 18, 8, 56, 42, 43, DateTimeKind.Unspecified).AddTicks(8568), new DateTime(2021, 6, 16, 16, 46, 15, 487, DateTimeKind.Unspecified).AddTicks(3542) },
                    { 192, 4, "YT16655-0", 3, new DateTime(2021, 12, 24, 10, 16, 12, 619, DateTimeKind.Unspecified).AddTicks(5925), new DateTime(2021, 7, 14, 18, 51, 26, 84, DateTimeKind.Unspecified).AddTicks(2782) },
                    { 194, 5, "YT33305-0", 3, new DateTime(2021, 10, 10, 8, 42, 34, 843, DateTimeKind.Unspecified).AddTicks(1006), new DateTime(2021, 8, 15, 2, 46, 31, 715, DateTimeKind.Unspecified).AddTicks(3524) },
                    { 200, 2, "YT54556-1", 3, new DateTime(2021, 10, 9, 6, 24, 4, 910, DateTimeKind.Unspecified).AddTicks(6607), new DateTime(2021, 8, 29, 19, 35, 42, 281, DateTimeKind.Unspecified).AddTicks(6203) },
                    { 209, 1, "YT63264-1", 3, new DateTime(2021, 11, 2, 0, 53, 30, 994, DateTimeKind.Unspecified).AddTicks(9365), new DateTime(2021, 5, 19, 16, 45, 49, 691, DateTimeKind.Unspecified).AddTicks(1151) },
                    { 215, 3, "YT69988-0", 3, new DateTime(2021, 9, 5, 23, 19, 37, 906, DateTimeKind.Unspecified).AddTicks(7594), new DateTime(2021, 7, 15, 14, 37, 39, 894, DateTimeKind.Unspecified).AddTicks(5997) },
                    { 217, 5, "YT35994-0", 3, new DateTime(2021, 12, 16, 16, 4, 35, 979, DateTimeKind.Unspecified).AddTicks(8081), new DateTime(2021, 5, 20, 3, 10, 39, 339, DateTimeKind.Unspecified).AddTicks(7280) },
                    { 219, 1, "YT76805-1", 3, new DateTime(2021, 9, 24, 22, 43, 57, 871, DateTimeKind.Unspecified).AddTicks(2529), new DateTime(2021, 5, 28, 10, 33, 2, 515, DateTimeKind.Unspecified).AddTicks(5837) },
                    { 224, 2, "YT41919-1", 3, new DateTime(2021, 12, 2, 9, 5, 0, 610, DateTimeKind.Unspecified).AddTicks(9777), new DateTime(2021, 8, 4, 0, 37, 1, 571, DateTimeKind.Unspecified).AddTicks(2945) },
                    { 228, 1, "YT79853-1", 3, new DateTime(2021, 9, 8, 13, 38, 39, 632, DateTimeKind.Unspecified).AddTicks(9718), new DateTime(2021, 7, 4, 20, 49, 40, 925, DateTimeKind.Unspecified).AddTicks(5010) },
                    { 247, 2, "YT23598-1", 3, new DateTime(2021, 11, 12, 18, 47, 35, 209, DateTimeKind.Unspecified).AddTicks(6101), new DateTime(2021, 6, 23, 4, 5, 55, 917, DateTimeKind.Unspecified).AddTicks(6767) },
                    { 251, 3, "YT84644-0", 3, new DateTime(2021, 9, 12, 17, 46, 16, 191, DateTimeKind.Unspecified).AddTicks(1809), new DateTime(2021, 7, 27, 1, 58, 48, 71, DateTimeKind.Unspecified).AddTicks(3785) },
                    { 263, 4, "YT85463-1", 3, new DateTime(2021, 9, 18, 21, 31, 55, 283, DateTimeKind.Unspecified).AddTicks(693), new DateTime(2021, 8, 26, 20, 19, 47, 922, DateTimeKind.Unspecified).AddTicks(1095) },
                    { 271, 2, "YT59020-1", 3, new DateTime(2021, 10, 17, 7, 16, 31, 10, DateTimeKind.Unspecified).AddTicks(9985), new DateTime(2021, 6, 2, 4, 38, 34, 486, DateTimeKind.Unspecified).AddTicks(8973) },
                    { 277, 3, "YT84782-1", 3, new DateTime(2021, 11, 2, 0, 7, 18, 481, DateTimeKind.Unspecified).AddTicks(5486), new DateTime(2021, 5, 15, 1, 2, 49, 78, DateTimeKind.Unspecified).AddTicks(9747) },
                    { 278, 4, "YT47265-1", 3, new DateTime(2021, 10, 27, 13, 14, 41, 490, DateTimeKind.Unspecified).AddTicks(7013), new DateTime(2021, 6, 26, 8, 58, 29, 206, DateTimeKind.Unspecified).AddTicks(2609) },
                    { 283, 3, "YT79578-1", 3, new DateTime(2021, 11, 5, 17, 34, 0, 684, DateTimeKind.Unspecified).AddTicks(53), new DateTime(2021, 5, 29, 5, 1, 30, 645, DateTimeKind.Unspecified).AddTicks(5169) },
                    { 292, 4, "YT53520-1", 3, new DateTime(2021, 9, 21, 6, 13, 21, 422, DateTimeKind.Unspecified).AddTicks(1773), new DateTime(2021, 7, 21, 18, 32, 22, 138, DateTimeKind.Unspecified).AddTicks(1993) },
                    { 299, 4, "YT11044-1", 3, new DateTime(2021, 11, 26, 8, 9, 10, 686, DateTimeKind.Unspecified).AddTicks(1570), new DateTime(2021, 6, 19, 18, 51, 53, 225, DateTimeKind.Unspecified).AddTicks(5513) },
                    { 312, 3, "YT19208-1", 3, new DateTime(2021, 10, 23, 6, 55, 20, 138, DateTimeKind.Unspecified).AddTicks(5912), new DateTime(2021, 8, 1, 5, 36, 19, 12, DateTimeKind.Unspecified).AddTicks(621) },
                    { 318, 2, "YT17527-0", 3, new DateTime(2021, 9, 29, 19, 30, 16, 493, DateTimeKind.Unspecified).AddTicks(1639), new DateTime(2021, 7, 20, 1, 57, 1, 705, DateTimeKind.Unspecified).AddTicks(1881) },
                    { 157, 1, "YT42365-0", 3, new DateTime(2021, 9, 16, 4, 43, 45, 997, DateTimeKind.Unspecified).AddTicks(3784), new DateTime(2021, 6, 30, 9, 4, 25, 334, DateTimeKind.Unspecified).AddTicks(7659) },
                    { 320, 5, "YT29041-1", 3, new DateTime(2021, 9, 30, 0, 17, 10, 281, DateTimeKind.Unspecified).AddTicks(8795), new DateTime(2021, 6, 13, 11, 32, 29, 964, DateTimeKind.Unspecified).AddTicks(6723) },
                    { 154, 3, "YT29605-0", 3, new DateTime(2021, 10, 29, 14, 0, 20, 786, DateTimeKind.Unspecified).AddTicks(34), new DateTime(2021, 7, 9, 11, 18, 52, 893, DateTimeKind.Unspecified).AddTicks(3846) },
                    { 144, 1, "YT66108-0", 3, new DateTime(2021, 9, 22, 5, 9, 14, 53, DateTimeKind.Unspecified).AddTicks(2631), new DateTime(2021, 8, 22, 23, 17, 52, 177, DateTimeKind.Unspecified).AddTicks(9022) },
                    { 1, 5, "YT17518-1", 3, new DateTime(2021, 12, 8, 8, 45, 24, 469, DateTimeKind.Unspecified).AddTicks(565), new DateTime(2021, 6, 9, 19, 47, 23, 13, DateTimeKind.Unspecified).AddTicks(5671) },
                    { 11, 1, "YT91528-1", 3, new DateTime(2021, 9, 15, 12, 59, 55, 870, DateTimeKind.Unspecified).AddTicks(3989), new DateTime(2021, 6, 21, 1, 22, 7, 159, DateTimeKind.Unspecified).AddTicks(4369) },
                    { 14, 2, "YT71384-0", 3, new DateTime(2021, 9, 24, 12, 15, 37, 265, DateTimeKind.Unspecified).AddTicks(2244), new DateTime(2021, 8, 25, 13, 4, 44, 511, DateTimeKind.Unspecified).AddTicks(1589) },
                    { 22, 1, "YT10931-0", 3, new DateTime(2021, 12, 4, 3, 42, 47, 289, DateTimeKind.Unspecified).AddTicks(2394), new DateTime(2021, 8, 23, 1, 25, 9, 635, DateTimeKind.Unspecified).AddTicks(5745) },
                    { 30, 5, "YT36530-0", 3, new DateTime(2021, 11, 11, 22, 1, 51, 848, DateTimeKind.Unspecified).AddTicks(4211), new DateTime(2021, 7, 11, 2, 53, 21, 977, DateTimeKind.Unspecified).AddTicks(581) },
                    { 35, 3, "YT87037-0", 3, new DateTime(2021, 12, 19, 0, 56, 44, 123, DateTimeKind.Unspecified).AddTicks(7623), new DateTime(2021, 8, 25, 2, 50, 47, 538, DateTimeKind.Unspecified).AddTicks(9499) },
                    { 42, 3, "YT33760-0", 3, new DateTime(2021, 12, 20, 8, 52, 59, 63, DateTimeKind.Unspecified).AddTicks(2918), new DateTime(2021, 5, 30, 5, 11, 45, 614, DateTimeKind.Unspecified).AddTicks(1389) },
                    { 45, 5, "YT28697-1", 3, new DateTime(2021, 9, 1, 21, 55, 0, 120, DateTimeKind.Unspecified).AddTicks(7004), new DateTime(2021, 7, 20, 11, 56, 52, 493, DateTimeKind.Unspecified).AddTicks(8957) },
                    { 53, 3, "YT64206-0", 3, new DateTime(2021, 9, 24, 0, 18, 18, 317, DateTimeKind.Unspecified).AddTicks(1170), new DateTime(2021, 6, 4, 6, 49, 26, 620, DateTimeKind.Unspecified).AddTicks(7741) },
                    { 58, 1, "YT80020-0", 3, new DateTime(2021, 11, 12, 14, 22, 21, 169, DateTimeKind.Unspecified).AddTicks(5081), new DateTime(2021, 6, 14, 9, 34, 1, 106, DateTimeKind.Unspecified).AddTicks(9494) },
                    { 59, 3, "YT77931-1", 3, new DateTime(2021, 9, 29, 13, 34, 29, 195, DateTimeKind.Unspecified).AddTicks(5049), new DateTime(2021, 7, 5, 14, 47, 54, 526, DateTimeKind.Unspecified).AddTicks(7520) },
                    { 63, 4, "YT53224-0", 3, new DateTime(2021, 9, 16, 1, 41, 32, 150, DateTimeKind.Unspecified).AddTicks(607), new DateTime(2021, 7, 30, 14, 36, 19, 445, DateTimeKind.Unspecified).AddTicks(2271) },
                    { 64, 1, "YT42891-1", 3, new DateTime(2021, 9, 1, 22, 1, 58, 893, DateTimeKind.Unspecified).AddTicks(8063), new DateTime(2021, 5, 19, 16, 19, 36, 769, DateTimeKind.Unspecified).AddTicks(8532) },
                    { 66, 4, "YT95039-1", 3, new DateTime(2021, 12, 20, 20, 14, 39, 241, DateTimeKind.Unspecified).AddTicks(5064), new DateTime(2021, 5, 27, 16, 55, 4, 284, DateTimeKind.Unspecified).AddTicks(9288) },
                    { 71, 3, "YT15093-0", 3, new DateTime(2021, 11, 27, 13, 34, 30, 313, DateTimeKind.Unspecified).AddTicks(2619), new DateTime(2021, 7, 30, 8, 25, 16, 125, DateTimeKind.Unspecified).AddTicks(8213) },
                    { 74, 2, "YT81473-0", 3, new DateTime(2021, 12, 23, 19, 50, 31, 581, DateTimeKind.Unspecified).AddTicks(819), new DateTime(2021, 5, 16, 20, 31, 26, 533, DateTimeKind.Unspecified).AddTicks(6494) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 75, 2, "YT80494-0", 3, new DateTime(2021, 11, 17, 20, 3, 30, 141, DateTimeKind.Unspecified).AddTicks(5345), new DateTime(2021, 6, 16, 15, 37, 10, 776, DateTimeKind.Unspecified).AddTicks(5805) },
                    { 87, 4, "YT99958-0", 3, new DateTime(2021, 9, 5, 19, 7, 53, 615, DateTimeKind.Unspecified).AddTicks(3938), new DateTime(2021, 5, 12, 7, 18, 37, 125, DateTimeKind.Unspecified).AddTicks(5026) },
                    { 98, 4, "YT12376-0", 3, new DateTime(2021, 12, 19, 14, 12, 41, 423, DateTimeKind.Unspecified).AddTicks(1452), new DateTime(2021, 8, 21, 4, 17, 5, 594, DateTimeKind.Unspecified).AddTicks(688) },
                    { 100, 3, "YT59805-0", 3, new DateTime(2021, 10, 30, 6, 23, 43, 98, DateTimeKind.Unspecified).AddTicks(9101), new DateTime(2021, 7, 27, 15, 26, 10, 801, DateTimeKind.Unspecified).AddTicks(8) },
                    { 102, 4, "YT34440-0", 3, new DateTime(2021, 9, 9, 1, 12, 58, 545, DateTimeKind.Unspecified).AddTicks(9569), new DateTime(2021, 5, 21, 4, 2, 35, 955, DateTimeKind.Unspecified).AddTicks(4138) },
                    { 114, 1, "YT19616-0", 3, new DateTime(2021, 10, 25, 9, 51, 38, 326, DateTimeKind.Unspecified).AddTicks(8441), new DateTime(2021, 5, 9, 3, 9, 29, 406, DateTimeKind.Unspecified).AddTicks(7740) },
                    { 123, 2, "YT36777-1", 3, new DateTime(2021, 12, 10, 19, 44, 24, 657, DateTimeKind.Unspecified).AddTicks(1416), new DateTime(2021, 5, 10, 19, 52, 39, 743, DateTimeKind.Unspecified).AddTicks(2917) },
                    { 124, 4, "YT44229-0", 3, new DateTime(2021, 9, 26, 5, 39, 32, 300, DateTimeKind.Unspecified).AddTicks(5330), new DateTime(2021, 8, 26, 19, 43, 13, 398, DateTimeKind.Unspecified).AddTicks(1034) },
                    { 131, 1, "YT73699-1", 3, new DateTime(2021, 12, 21, 15, 47, 38, 657, DateTimeKind.Unspecified).AddTicks(617), new DateTime(2021, 7, 23, 15, 41, 6, 173, DateTimeKind.Unspecified).AddTicks(8554) },
                    { 138, 3, "YT90767-0", 3, new DateTime(2021, 11, 28, 1, 0, 27, 21, DateTimeKind.Unspecified).AddTicks(7689), new DateTime(2021, 6, 23, 3, 5, 38, 649, DateTimeKind.Unspecified).AddTicks(4256) },
                    { 141, 4, "YT18017-0", 3, new DateTime(2021, 10, 4, 6, 56, 1, 829, DateTimeKind.Unspecified).AddTicks(8155), new DateTime(2021, 8, 23, 12, 34, 24, 970, DateTimeKind.Unspecified).AddTicks(1925) },
                    { 150, 2, "YT17861-1", 3, new DateTime(2021, 11, 17, 3, 24, 3, 377, DateTimeKind.Unspecified).AddTicks(9341), new DateTime(2021, 6, 30, 21, 24, 40, 388, DateTimeKind.Unspecified).AddTicks(7875) },
                    { 324, 2, "YT98989-1", 3, new DateTime(2021, 9, 13, 13, 8, 40, 548, DateTimeKind.Unspecified).AddTicks(8246), new DateTime(2021, 6, 18, 16, 21, 59, 750, DateTimeKind.Unspecified).AddTicks(7715) },
                    { 326, 4, "YT77615-1", 3, new DateTime(2021, 9, 29, 3, 53, 35, 873, DateTimeKind.Unspecified).AddTicks(6920), new DateTime(2021, 6, 2, 14, 22, 48, 119, DateTimeKind.Unspecified).AddTicks(7542) },
                    { 328, 2, "YT32851-1", 3, new DateTime(2021, 11, 23, 20, 24, 47, 888, DateTimeKind.Unspecified).AddTicks(6982), new DateTime(2021, 7, 4, 14, 53, 29, 650, DateTimeKind.Unspecified).AddTicks(5430) },
                    { 495, 1, "YT75889-0", 3, new DateTime(2021, 10, 11, 3, 44, 21, 263, DateTimeKind.Unspecified).AddTicks(7851), new DateTime(2021, 5, 21, 17, 13, 59, 186, DateTimeKind.Unspecified).AddTicks(3173) },
                    { 502, 4, "YT89267-0", 3, new DateTime(2021, 9, 13, 8, 55, 11, 576, DateTimeKind.Unspecified).AddTicks(3531), new DateTime(2021, 7, 4, 17, 20, 22, 142, DateTimeKind.Unspecified).AddTicks(2769) },
                    { 506, 3, "YT67716-0", 3, new DateTime(2021, 10, 22, 8, 52, 1, 449, DateTimeKind.Unspecified).AddTicks(9652), new DateTime(2021, 6, 15, 4, 24, 35, 965, DateTimeKind.Unspecified).AddTicks(5550) },
                    { 511, 5, "YT46800-0", 3, new DateTime(2021, 9, 2, 20, 21, 31, 813, DateTimeKind.Unspecified).AddTicks(3585), new DateTime(2021, 5, 14, 11, 33, 2, 150, DateTimeKind.Unspecified).AddTicks(1747) },
                    { 514, 2, "YT46144-1", 3, new DateTime(2021, 11, 4, 13, 6, 3, 406, DateTimeKind.Unspecified).AddTicks(6876), new DateTime(2021, 6, 8, 1, 15, 23, 752, DateTimeKind.Unspecified).AddTicks(2906) },
                    { 518, 4, "YT15120-0", 3, new DateTime(2021, 9, 9, 16, 45, 28, 861, DateTimeKind.Unspecified).AddTicks(5761), new DateTime(2021, 8, 27, 3, 49, 43, 529, DateTimeKind.Unspecified).AddTicks(4683) },
                    { 525, 5, "YT71048-1", 3, new DateTime(2021, 12, 21, 20, 3, 8, 750, DateTimeKind.Unspecified).AddTicks(5823), new DateTime(2021, 6, 3, 6, 41, 24, 969, DateTimeKind.Unspecified).AddTicks(713) },
                    { 528, 3, "YT16683-0", 3, new DateTime(2021, 12, 30, 14, 15, 10, 647, DateTimeKind.Unspecified).AddTicks(9243), new DateTime(2021, 5, 15, 5, 41, 13, 290, DateTimeKind.Unspecified).AddTicks(1281) },
                    { 534, 3, "YT84140-0", 3, new DateTime(2021, 12, 7, 22, 25, 44, 406, DateTimeKind.Unspecified).AddTicks(508), new DateTime(2021, 7, 21, 21, 29, 34, 206, DateTimeKind.Unspecified).AddTicks(4658) },
                    { 540, 3, "YT19132-0", 3, new DateTime(2021, 10, 15, 23, 56, 49, 754, DateTimeKind.Unspecified).AddTicks(7635), new DateTime(2021, 5, 13, 22, 47, 21, 923, DateTimeKind.Unspecified).AddTicks(5761) },
                    { 541, 2, "YT18113-1", 3, new DateTime(2021, 12, 12, 22, 39, 44, 728, DateTimeKind.Unspecified).AddTicks(7111), new DateTime(2021, 8, 28, 1, 14, 14, 940, DateTimeKind.Unspecified).AddTicks(8755) },
                    { 545, 4, "YT50523-0", 3, new DateTime(2021, 9, 23, 15, 23, 44, 260, DateTimeKind.Unspecified).AddTicks(8984), new DateTime(2021, 7, 14, 13, 13, 2, 862, DateTimeKind.Unspecified).AddTicks(2682) },
                    { 560, 5, "YT93887-1", 3, new DateTime(2021, 11, 7, 14, 28, 11, 776, DateTimeKind.Unspecified).AddTicks(3774), new DateTime(2021, 7, 28, 11, 34, 12, 115, DateTimeKind.Unspecified).AddTicks(5969) },
                    { 570, 3, "YT91136-0", 3, new DateTime(2021, 11, 15, 18, 21, 42, 225, DateTimeKind.Unspecified).AddTicks(4760), new DateTime(2021, 6, 16, 6, 7, 37, 616, DateTimeKind.Unspecified).AddTicks(5183) },
                    { 572, 1, "YT80194-0", 3, new DateTime(2021, 11, 12, 19, 19, 40, 372, DateTimeKind.Unspecified).AddTicks(2124), new DateTime(2021, 8, 18, 6, 27, 15, 675, DateTimeKind.Unspecified).AddTicks(8703) },
                    { 586, 4, "YT34359-0", 3, new DateTime(2021, 10, 7, 15, 0, 47, 378, DateTimeKind.Unspecified).AddTicks(9273), new DateTime(2021, 7, 8, 9, 11, 54, 742, DateTimeKind.Unspecified).AddTicks(6685) },
                    { 589, 3, "YT43827-1", 3, new DateTime(2021, 10, 1, 12, 42, 21, 709, DateTimeKind.Unspecified).AddTicks(4697), new DateTime(2021, 5, 31, 16, 59, 37, 871, DateTimeKind.Unspecified).AddTicks(1336) },
                    { 590, 4, "YT18421-0", 3, new DateTime(2021, 11, 10, 17, 54, 54, 770, DateTimeKind.Unspecified).AddTicks(3841), new DateTime(2021, 7, 9, 0, 17, 14, 275, DateTimeKind.Unspecified).AddTicks(8631) },
                    { 600, 3, "YT58725-0", 3, new DateTime(2021, 10, 6, 21, 9, 2, 72, DateTimeKind.Unspecified).AddTicks(97), new DateTime(2021, 5, 18, 23, 51, 13, 911, DateTimeKind.Unspecified).AddTicks(8454) },
                    { 603, 4, "YT83288-1", 3, new DateTime(2021, 9, 23, 11, 58, 26, 590, DateTimeKind.Unspecified).AddTicks(9914), new DateTime(2021, 7, 22, 4, 14, 17, 202, DateTimeKind.Unspecified).AddTicks(7069) },
                    { 605, 3, "YT62161-1", 3, new DateTime(2021, 9, 9, 17, 13, 26, 884, DateTimeKind.Unspecified).AddTicks(6619), new DateTime(2021, 7, 18, 10, 13, 20, 198, DateTimeKind.Unspecified).AddTicks(8418) },
                    { 608, 1, "YT11510-0", 3, new DateTime(2021, 9, 8, 19, 49, 55, 356, DateTimeKind.Unspecified).AddTicks(5751), new DateTime(2021, 5, 26, 19, 37, 10, 737, DateTimeKind.Unspecified).AddTicks(5879) },
                    { 609, 2, "YT27135-1", 3, new DateTime(2021, 10, 21, 13, 27, 42, 504, DateTimeKind.Unspecified).AddTicks(4095), new DateTime(2021, 6, 14, 8, 35, 14, 436, DateTimeKind.Unspecified).AddTicks(2758) },
                    { 611, 5, "YT17462-1", 3, new DateTime(2021, 11, 11, 13, 38, 49, 734, DateTimeKind.Unspecified).AddTicks(1441), new DateTime(2021, 7, 3, 21, 47, 1, 27, DateTimeKind.Unspecified).AddTicks(8250) },
                    { 621, 2, "YT96384-1", 3, new DateTime(2021, 9, 17, 3, 17, 47, 84, DateTimeKind.Unspecified).AddTicks(1794), new DateTime(2021, 7, 10, 17, 9, 44, 104, DateTimeKind.Unspecified).AddTicks(8201) },
                    { 624, 2, "YT15379-1", 3, new DateTime(2021, 10, 31, 0, 14, 35, 610, DateTimeKind.Unspecified).AddTicks(972), new DateTime(2021, 6, 7, 12, 23, 58, 254, DateTimeKind.Unspecified).AddTicks(5813) },
                    { 630, 1, "YT31892-1", 3, new DateTime(2021, 9, 10, 19, 36, 58, 18, DateTimeKind.Unspecified).AddTicks(834), new DateTime(2021, 5, 11, 10, 55, 9, 856, DateTimeKind.Unspecified).AddTicks(5642) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 494, 3, "YT22942-1", 3, new DateTime(2021, 11, 17, 15, 40, 34, 421, DateTimeKind.Unspecified).AddTicks(8651), new DateTime(2021, 5, 11, 5, 49, 16, 428, DateTimeKind.Unspecified).AddTicks(429) },
                    { 489, 2, "YT33149-0", 3, new DateTime(2021, 11, 13, 0, 13, 19, 614, DateTimeKind.Unspecified).AddTicks(6131), new DateTime(2021, 8, 10, 15, 41, 51, 548, DateTimeKind.Unspecified).AddTicks(1416) },
                    { 482, 2, "YT18646-0", 3, new DateTime(2021, 12, 23, 4, 5, 18, 957, DateTimeKind.Unspecified).AddTicks(4265), new DateTime(2021, 6, 10, 10, 1, 29, 979, DateTimeKind.Unspecified).AddTicks(366) },
                    { 481, 2, "YT55445-0", 3, new DateTime(2021, 10, 27, 19, 4, 21, 735, DateTimeKind.Unspecified).AddTicks(1107), new DateTime(2021, 7, 28, 3, 46, 19, 715, DateTimeKind.Unspecified).AddTicks(2448) },
                    { 332, 4, "YT51227-0", 3, new DateTime(2021, 10, 5, 20, 48, 26, 387, DateTimeKind.Unspecified).AddTicks(7440), new DateTime(2021, 7, 23, 17, 13, 40, 433, DateTimeKind.Unspecified).AddTicks(2104) },
                    { 334, 2, "YT62098-1", 3, new DateTime(2021, 9, 23, 6, 28, 24, 239, DateTimeKind.Unspecified).AddTicks(470), new DateTime(2021, 8, 8, 7, 14, 2, 935, DateTimeKind.Unspecified).AddTicks(363) },
                    { 338, 4, "YT30274-1", 3, new DateTime(2021, 9, 5, 2, 21, 27, 630, DateTimeKind.Unspecified).AddTicks(8123), new DateTime(2021, 7, 11, 6, 16, 34, 960, DateTimeKind.Unspecified).AddTicks(131) },
                    { 339, 3, "YT47644-0", 3, new DateTime(2021, 12, 10, 13, 11, 23, 201, DateTimeKind.Unspecified).AddTicks(8954), new DateTime(2021, 8, 24, 16, 48, 47, 532, DateTimeKind.Unspecified).AddTicks(6772) },
                    { 352, 3, "YT79297-1", 3, new DateTime(2021, 12, 9, 19, 39, 37, 455, DateTimeKind.Unspecified).AddTicks(8427), new DateTime(2021, 8, 26, 21, 38, 38, 900, DateTimeKind.Unspecified).AddTicks(6751) },
                    { 357, 3, "YT28411-0", 3, new DateTime(2021, 12, 17, 1, 28, 25, 405, DateTimeKind.Unspecified).AddTicks(2229), new DateTime(2021, 5, 24, 13, 13, 8, 729, DateTimeKind.Unspecified).AddTicks(1444) },
                    { 358, 1, "YT51416-0", 3, new DateTime(2021, 11, 2, 8, 40, 57, 537, DateTimeKind.Unspecified).AddTicks(7342), new DateTime(2021, 7, 7, 21, 47, 14, 638, DateTimeKind.Unspecified).AddTicks(1717) },
                    { 369, 2, "YT19891-1", 3, new DateTime(2021, 9, 17, 5, 24, 9, 480, DateTimeKind.Unspecified).AddTicks(9152), new DateTime(2021, 8, 21, 21, 59, 14, 482, DateTimeKind.Unspecified).AddTicks(1854) },
                    { 370, 4, "YT59735-1", 3, new DateTime(2021, 9, 29, 8, 42, 26, 36, DateTimeKind.Unspecified).AddTicks(9524), new DateTime(2021, 5, 23, 4, 25, 29, 379, DateTimeKind.Unspecified).AddTicks(3067) },
                    { 372, 3, "YT84149-1", 3, new DateTime(2021, 9, 16, 8, 28, 25, 596, DateTimeKind.Unspecified).AddTicks(8918), new DateTime(2021, 6, 5, 23, 13, 1, 368, DateTimeKind.Unspecified).AddTicks(129) },
                    { 373, 2, "YT49032-0", 3, new DateTime(2021, 11, 30, 7, 49, 33, 874, DateTimeKind.Unspecified).AddTicks(7162), new DateTime(2021, 6, 7, 18, 39, 47, 584, DateTimeKind.Unspecified).AddTicks(9083) },
                    { 377, 5, "YT32058-1", 3, new DateTime(2021, 11, 8, 5, 21, 8, 153, DateTimeKind.Unspecified).AddTicks(5140), new DateTime(2021, 8, 6, 4, 12, 9, 115, DateTimeKind.Unspecified).AddTicks(6929) },
                    { 383, 4, "YT24886-0", 3, new DateTime(2021, 11, 9, 2, 30, 57, 100, DateTimeKind.Unspecified).AddTicks(2645), new DateTime(2021, 7, 9, 2, 40, 29, 367, DateTimeKind.Unspecified).AddTicks(6496) },
                    { 991, 5, "YT27781-0", 2, new DateTime(2021, 12, 11, 20, 46, 39, 933, DateTimeKind.Unspecified).AddTicks(2419), new DateTime(2021, 6, 10, 14, 43, 48, 561, DateTimeKind.Unspecified).AddTicks(2785) },
                    { 385, 3, "YT51880-1", 3, new DateTime(2021, 11, 2, 9, 4, 8, 331, DateTimeKind.Unspecified).AddTicks(5992), new DateTime(2021, 6, 28, 8, 21, 57, 626, DateTimeKind.Unspecified).AddTicks(3547) },
                    { 402, 5, "YT26055-1", 3, new DateTime(2021, 10, 25, 16, 14, 56, 930, DateTimeKind.Unspecified).AddTicks(8559), new DateTime(2021, 6, 27, 20, 7, 14, 448, DateTimeKind.Unspecified).AddTicks(8273) },
                    { 407, 5, "YT79963-1", 3, new DateTime(2021, 10, 3, 2, 31, 42, 141, DateTimeKind.Unspecified).AddTicks(9836), new DateTime(2021, 7, 18, 4, 1, 43, 182, DateTimeKind.Unspecified).AddTicks(3747) },
                    { 412, 4, "YT24922-0", 3, new DateTime(2021, 11, 5, 19, 0, 55, 66, DateTimeKind.Unspecified).AddTicks(8692), new DateTime(2021, 5, 20, 2, 4, 57, 704, DateTimeKind.Unspecified).AddTicks(2963) },
                    { 416, 1, "YT40797-0", 3, new DateTime(2021, 11, 22, 0, 46, 46, 774, DateTimeKind.Unspecified).AddTicks(3165), new DateTime(2021, 7, 26, 19, 7, 56, 767, DateTimeKind.Unspecified).AddTicks(1369) },
                    { 418, 1, "YT29291-0", 3, new DateTime(2021, 12, 4, 1, 13, 41, 701, DateTimeKind.Unspecified).AddTicks(3856), new DateTime(2021, 7, 24, 13, 46, 32, 11, DateTimeKind.Unspecified).AddTicks(978) },
                    { 441, 4, "YT51635-1", 3, new DateTime(2021, 12, 30, 10, 46, 10, 904, DateTimeKind.Unspecified).AddTicks(9107), new DateTime(2021, 6, 15, 9, 16, 51, 757, DateTimeKind.Unspecified).AddTicks(9958) },
                    { 449, 2, "YT64942-1", 3, new DateTime(2021, 11, 7, 18, 29, 5, 373, DateTimeKind.Unspecified).AddTicks(1430), new DateTime(2021, 8, 7, 14, 45, 43, 945, DateTimeKind.Unspecified).AddTicks(422) },
                    { 453, 2, "YT56272-1", 3, new DateTime(2021, 11, 7, 19, 51, 11, 631, DateTimeKind.Unspecified).AddTicks(357), new DateTime(2021, 7, 20, 3, 28, 31, 332, DateTimeKind.Unspecified).AddTicks(6265) },
                    { 456, 5, "YT56889-1", 3, new DateTime(2021, 10, 20, 23, 59, 15, 695, DateTimeKind.Unspecified).AddTicks(5129), new DateTime(2021, 7, 31, 17, 53, 21, 520, DateTimeKind.Unspecified).AddTicks(6384) },
                    { 465, 1, "YT90781-0", 3, new DateTime(2021, 10, 4, 18, 21, 33, 243, DateTimeKind.Unspecified).AddTicks(1067), new DateTime(2021, 5, 28, 1, 52, 20, 139, DateTimeKind.Unspecified).AddTicks(2640) },
                    { 469, 1, "YT67750-0", 3, new DateTime(2021, 9, 10, 4, 56, 2, 832, DateTimeKind.Unspecified).AddTicks(866), new DateTime(2021, 7, 12, 15, 55, 28, 626, DateTimeKind.Unspecified).AddTicks(5104) },
                    { 475, 5, "YT71771-1", 3, new DateTime(2021, 9, 3, 21, 16, 9, 896, DateTimeKind.Unspecified).AddTicks(4446), new DateTime(2021, 6, 3, 17, 35, 38, 973, DateTimeKind.Unspecified).AddTicks(2328) },
                    { 477, 5, "YT88251-1", 3, new DateTime(2021, 10, 7, 22, 54, 0, 810, DateTimeKind.Unspecified).AddTicks(8514), new DateTime(2021, 8, 23, 6, 9, 1, 17, DateTimeKind.Unspecified).AddTicks(7557) },
                    { 392, 5, "YT54285-0", 3, new DateTime(2021, 12, 19, 10, 7, 19, 685, DateTimeKind.Unspecified).AddTicks(4079), new DateTime(2021, 5, 27, 11, 9, 5, 354, DateTimeKind.Unspecified).AddTicks(4670) },
                    { 983, 2, "YT70616-0", 2, new DateTime(2021, 11, 25, 18, 20, 34, 565, DateTimeKind.Unspecified).AddTicks(3722), new DateTime(2021, 6, 13, 18, 56, 35, 923, DateTimeKind.Unspecified).AddTicks(9577) },
                    { 976, 4, "YT89518-0", 2, new DateTime(2021, 12, 15, 2, 58, 47, 808, DateTimeKind.Unspecified).AddTicks(9663), new DateTime(2021, 8, 7, 17, 22, 9, 138, DateTimeKind.Unspecified).AddTicks(7596) },
                    { 975, 2, "YT43743-0", 2, new DateTime(2021, 9, 8, 23, 8, 21, 541, DateTimeKind.Unspecified).AddTicks(856), new DateTime(2021, 7, 7, 7, 43, 21, 446, DateTimeKind.Unspecified).AddTicks(8829) },
                    { 457, 4, "YT50177-0", 2, new DateTime(2021, 11, 17, 2, 0, 14, 235, DateTimeKind.Unspecified).AddTicks(3047), new DateTime(2021, 5, 22, 17, 32, 11, 859, DateTimeKind.Unspecified).AddTicks(2485) },
                    { 464, 4, "YT90620-0", 2, new DateTime(2021, 11, 9, 4, 59, 35, 41, DateTimeKind.Unspecified).AddTicks(5573), new DateTime(2021, 7, 29, 3, 32, 57, 380, DateTimeKind.Unspecified).AddTicks(7511) },
                    { 471, 4, "YT97621-1", 2, new DateTime(2021, 12, 20, 13, 8, 54, 583, DateTimeKind.Unspecified).AddTicks(4699), new DateTime(2021, 6, 17, 22, 19, 7, 485, DateTimeKind.Unspecified).AddTicks(9746) },
                    { 472, 2, "YT46788-1", 2, new DateTime(2021, 10, 2, 17, 24, 36, 317, DateTimeKind.Unspecified).AddTicks(4021), new DateTime(2021, 6, 23, 3, 55, 39, 982, DateTimeKind.Unspecified).AddTicks(7755) },
                    { 473, 1, "YT56853-1", 2, new DateTime(2021, 12, 3, 8, 17, 55, 614, DateTimeKind.Unspecified).AddTicks(7121), new DateTime(2021, 7, 4, 12, 31, 48, 149, DateTimeKind.Unspecified).AddTicks(8803) },
                    { 474, 5, "YT87164-1", 2, new DateTime(2021, 12, 3, 4, 45, 0, 834, DateTimeKind.Unspecified).AddTicks(5505), new DateTime(2021, 7, 5, 23, 49, 39, 601, DateTimeKind.Unspecified).AddTicks(3129) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 480, 3, "YT42121-0", 2, new DateTime(2021, 11, 29, 8, 36, 52, 526, DateTimeKind.Unspecified).AddTicks(3090), new DateTime(2021, 8, 26, 7, 28, 13, 471, DateTimeKind.Unspecified).AddTicks(5217) },
                    { 490, 2, "YT75625-1", 2, new DateTime(2021, 10, 5, 14, 40, 53, 467, DateTimeKind.Unspecified).AddTicks(4786), new DateTime(2021, 6, 6, 5, 5, 29, 320, DateTimeKind.Unspecified).AddTicks(7060) },
                    { 491, 2, "YT77181-1", 2, new DateTime(2021, 9, 2, 9, 24, 20, 768, DateTimeKind.Unspecified).AddTicks(2341), new DateTime(2021, 7, 25, 0, 41, 9, 366, DateTimeKind.Unspecified).AddTicks(7721) },
                    { 501, 3, "YT59994-0", 2, new DateTime(2021, 11, 21, 6, 21, 13, 950, DateTimeKind.Unspecified).AddTicks(6947), new DateTime(2021, 5, 12, 21, 35, 33, 1, DateTimeKind.Unspecified).AddTicks(9449) },
                    { 505, 3, "YT57224-0", 2, new DateTime(2021, 11, 13, 21, 51, 3, 254, DateTimeKind.Unspecified).AddTicks(5942), new DateTime(2021, 7, 9, 7, 29, 48, 721, DateTimeKind.Unspecified).AddTicks(2968) },
                    { 515, 5, "YT65122-1", 2, new DateTime(2021, 11, 17, 19, 50, 37, 907, DateTimeKind.Unspecified).AddTicks(2194), new DateTime(2021, 8, 24, 4, 9, 25, 223, DateTimeKind.Unspecified).AddTicks(9646) },
                    { 521, 2, "YT68473-1", 2, new DateTime(2021, 9, 25, 18, 54, 57, 502, DateTimeKind.Unspecified).AddTicks(5241), new DateTime(2021, 5, 23, 3, 17, 19, 135, DateTimeKind.Unspecified).AddTicks(3469) },
                    { 527, 2, "YT47000-1", 2, new DateTime(2021, 10, 30, 15, 18, 7, 38, DateTimeKind.Unspecified).AddTicks(9897), new DateTime(2021, 7, 19, 10, 40, 45, 609, DateTimeKind.Unspecified).AddTicks(689) },
                    { 531, 1, "YT82417-0", 2, new DateTime(2021, 12, 30, 15, 0, 59, 516, DateTimeKind.Unspecified).AddTicks(4193), new DateTime(2021, 6, 13, 9, 45, 30, 639, DateTimeKind.Unspecified).AddTicks(8019) },
                    { 544, 2, "YT76581-1", 2, new DateTime(2021, 12, 21, 13, 39, 2, 579, DateTimeKind.Unspecified).AddTicks(2968), new DateTime(2021, 7, 3, 13, 16, 28, 76, DateTimeKind.Unspecified).AddTicks(4841) },
                    { 551, 4, "YT49651-1", 2, new DateTime(2021, 10, 4, 2, 51, 4, 793, DateTimeKind.Unspecified).AddTicks(3725), new DateTime(2021, 8, 10, 13, 3, 21, 129, DateTimeKind.Unspecified).AddTicks(7966) },
                    { 553, 2, "YT14942-1", 2, new DateTime(2021, 9, 6, 1, 9, 24, 272, DateTimeKind.Unspecified).AddTicks(7275), new DateTime(2021, 8, 1, 13, 30, 10, 799, DateTimeKind.Unspecified).AddTicks(9238) },
                    { 567, 4, "YT19033-1", 2, new DateTime(2021, 10, 25, 2, 13, 18, 128, DateTimeKind.Unspecified).AddTicks(5788), new DateTime(2021, 6, 12, 6, 25, 20, 549, DateTimeKind.Unspecified).AddTicks(3170) },
                    { 569, 3, "YT47198-1", 2, new DateTime(2021, 10, 14, 0, 43, 0, 99, DateTimeKind.Unspecified).AddTicks(2233), new DateTime(2021, 7, 14, 13, 55, 31, 92, DateTimeKind.Unspecified).AddTicks(606) },
                    { 580, 1, "YT11735-1", 2, new DateTime(2021, 12, 23, 2, 51, 37, 420, DateTimeKind.Unspecified).AddTicks(8761), new DateTime(2021, 5, 29, 17, 21, 35, 247, DateTimeKind.Unspecified).AddTicks(5734) },
                    { 583, 2, "YT43287-1", 2, new DateTime(2021, 12, 23, 11, 10, 26, 115, DateTimeKind.Unspecified).AddTicks(6463), new DateTime(2021, 6, 1, 20, 48, 23, 393, DateTimeKind.Unspecified).AddTicks(2722) },
                    { 591, 4, "YT65081-0", 2, new DateTime(2021, 12, 16, 15, 35, 27, 903, DateTimeKind.Unspecified).AddTicks(1896), new DateTime(2021, 5, 24, 10, 39, 1, 881, DateTimeKind.Unspecified).AddTicks(6894) },
                    { 592, 1, "YT52263-1", 2, new DateTime(2021, 10, 25, 18, 43, 43, 6, DateTimeKind.Unspecified).AddTicks(9266), new DateTime(2021, 5, 16, 21, 48, 57, 190, DateTimeKind.Unspecified).AddTicks(7838) },
                    { 593, 1, "YT27150-0", 2, new DateTime(2021, 11, 8, 14, 43, 48, 464, DateTimeKind.Unspecified).AddTicks(9604), new DateTime(2021, 5, 17, 19, 26, 29, 899, DateTimeKind.Unspecified).AddTicks(3013) },
                    { 596, 1, "YT78191-0", 2, new DateTime(2021, 11, 16, 19, 47, 39, 393, DateTimeKind.Unspecified).AddTicks(5628), new DateTime(2021, 5, 28, 1, 0, 44, 830, DateTimeKind.Unspecified).AddTicks(7650) },
                    { 619, 3, "YT55368-0", 2, new DateTime(2021, 11, 30, 11, 39, 44, 303, DateTimeKind.Unspecified).AddTicks(1334), new DateTime(2021, 6, 13, 21, 34, 29, 22, DateTimeKind.Unspecified).AddTicks(4488) },
                    { 446, 1, "YT49127-1", 2, new DateTime(2021, 10, 5, 3, 18, 30, 643, DateTimeKind.Unspecified).AddTicks(7500), new DateTime(2021, 5, 14, 20, 35, 7, 226, DateTimeKind.Unspecified).AddTicks(4376) },
                    { 439, 3, "YT59223-1", 2, new DateTime(2021, 10, 25, 9, 5, 19, 995, DateTimeKind.Unspecified).AddTicks(9460), new DateTime(2021, 8, 29, 12, 19, 1, 787, DateTimeKind.Unspecified).AddTicks(281) },
                    { 434, 1, "YT61920-1", 2, new DateTime(2021, 11, 18, 20, 33, 53, 988, DateTimeKind.Unspecified).AddTicks(2510), new DateTime(2021, 7, 3, 4, 32, 6, 199, DateTimeKind.Unspecified).AddTicks(6450) },
                    { 433, 5, "YT86991-0", 2, new DateTime(2021, 12, 6, 14, 4, 33, 519, DateTimeKind.Unspecified).AddTicks(3340), new DateTime(2021, 8, 5, 21, 36, 37, 829, DateTimeKind.Unspecified).AddTicks(5957) },
                    { 319, 2, "YT15848-0", 2, new DateTime(2021, 11, 9, 6, 45, 29, 641, DateTimeKind.Unspecified).AddTicks(8139), new DateTime(2021, 6, 21, 1, 53, 7, 817, DateTimeKind.Unspecified).AddTicks(4202) },
                    { 327, 1, "YT40491-1", 2, new DateTime(2021, 12, 23, 22, 7, 33, 363, DateTimeKind.Unspecified).AddTicks(5674), new DateTime(2021, 8, 9, 22, 8, 35, 497, DateTimeKind.Unspecified).AddTicks(4087) },
                    { 330, 3, "YT68532-1", 2, new DateTime(2021, 9, 6, 10, 12, 6, 84, DateTimeKind.Unspecified).AddTicks(5787), new DateTime(2021, 7, 5, 1, 17, 13, 376, DateTimeKind.Unspecified).AddTicks(3591) },
                    { 331, 5, "YT38301-0", 2, new DateTime(2021, 12, 25, 7, 19, 12, 962, DateTimeKind.Unspecified).AddTicks(9264), new DateTime(2021, 7, 28, 5, 58, 32, 682, DateTimeKind.Unspecified).AddTicks(6804) },
                    { 340, 1, "YT58405-1", 2, new DateTime(2021, 12, 14, 12, 37, 27, 161, DateTimeKind.Unspecified).AddTicks(2382), new DateTime(2021, 7, 9, 16, 31, 15, 450, DateTimeKind.Unspecified).AddTicks(5539) },
                    { 344, 5, "YT68094-1", 2, new DateTime(2021, 9, 5, 2, 48, 22, 912, DateTimeKind.Unspecified).AddTicks(4158), new DateTime(2021, 7, 25, 15, 57, 47, 477, DateTimeKind.Unspecified).AddTicks(2560) },
                    { 351, 1, "YT98463-1", 2, new DateTime(2021, 10, 30, 17, 36, 35, 777, DateTimeKind.Unspecified).AddTicks(4308), new DateTime(2021, 7, 18, 11, 2, 16, 664, DateTimeKind.Unspecified).AddTicks(3077) },
                    { 356, 4, "YT75617-0", 2, new DateTime(2021, 12, 3, 17, 49, 28, 367, DateTimeKind.Unspecified).AddTicks(849), new DateTime(2021, 7, 27, 20, 52, 37, 926, DateTimeKind.Unspecified).AddTicks(9148) },
                    { 359, 1, "YT81390-1", 2, new DateTime(2021, 12, 29, 13, 58, 41, 129, DateTimeKind.Unspecified).AddTicks(5332), new DateTime(2021, 5, 14, 1, 4, 36, 295, DateTimeKind.Unspecified).AddTicks(3314) },
                    { 360, 5, "YT79423-0", 2, new DateTime(2021, 10, 9, 23, 37, 46, 19, DateTimeKind.Unspecified).AddTicks(6671), new DateTime(2021, 5, 16, 8, 26, 46, 414, DateTimeKind.Unspecified).AddTicks(6094) },
                    { 361, 1, "YT50625-1", 2, new DateTime(2021, 12, 13, 3, 0, 52, 602, DateTimeKind.Unspecified).AddTicks(9384), new DateTime(2021, 8, 6, 13, 10, 27, 760, DateTimeKind.Unspecified).AddTicks(4741) },
                    { 362, 2, "YT60132-0", 2, new DateTime(2021, 12, 3, 4, 12, 5, 957, DateTimeKind.Unspecified).AddTicks(7941), new DateTime(2021, 7, 13, 5, 29, 43, 928, DateTimeKind.Unspecified).AddTicks(8297) },
                    { 368, 4, "YT33333-0", 2, new DateTime(2021, 11, 1, 12, 27, 41, 990, DateTimeKind.Unspecified).AddTicks(9257), new DateTime(2021, 6, 5, 11, 12, 11, 997, DateTimeKind.Unspecified).AddTicks(2688) },
                    { 620, 4, "YT88416-1", 2, new DateTime(2021, 11, 30, 4, 7, 25, 666, DateTimeKind.Unspecified).AddTicks(7776), new DateTime(2021, 6, 12, 21, 3, 40, 194, DateTimeKind.Unspecified).AddTicks(4958) },
                    { 374, 3, "YT49034-0", 2, new DateTime(2021, 12, 20, 17, 15, 4, 331, DateTimeKind.Unspecified).AddTicks(4880), new DateTime(2021, 5, 27, 12, 27, 39, 523, DateTimeKind.Unspecified).AddTicks(8298) },
                    { 376, 2, "YT81113-1", 2, new DateTime(2021, 9, 27, 23, 20, 5, 109, DateTimeKind.Unspecified).AddTicks(4282), new DateTime(2021, 8, 3, 1, 48, 28, 467, DateTimeKind.Unspecified).AddTicks(8591) },
                    { 384, 5, "YT25417-1", 2, new DateTime(2021, 10, 28, 17, 39, 31, 229, DateTimeKind.Unspecified).AddTicks(9896), new DateTime(2021, 5, 21, 8, 45, 7, 386, DateTimeKind.Unspecified).AddTicks(3087) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 394, 4, "YT41905-0", 2, new DateTime(2021, 10, 2, 8, 36, 24, 235, DateTimeKind.Unspecified).AddTicks(4949), new DateTime(2021, 6, 10, 13, 26, 13, 948, DateTimeKind.Unspecified).AddTicks(2211) },
                    { 397, 1, "YT24402-1", 2, new DateTime(2021, 10, 20, 21, 5, 27, 285, DateTimeKind.Unspecified).AddTicks(1642), new DateTime(2021, 7, 10, 11, 3, 39, 436, DateTimeKind.Unspecified).AddTicks(7818) },
                    { 406, 5, "YT92208-1", 2, new DateTime(2021, 10, 2, 22, 56, 3, 35, DateTimeKind.Unspecified).AddTicks(4148), new DateTime(2021, 8, 3, 0, 35, 4, 521, DateTimeKind.Unspecified).AddTicks(5169) },
                    { 408, 3, "YT83171-1", 2, new DateTime(2021, 12, 7, 20, 30, 50, 91, DateTimeKind.Unspecified).AddTicks(7630), new DateTime(2021, 5, 8, 12, 55, 13, 775, DateTimeKind.Unspecified).AddTicks(2884) },
                    { 413, 3, "YT59068-0", 2, new DateTime(2021, 11, 3, 13, 5, 46, 619, DateTimeKind.Unspecified).AddTicks(8142), new DateTime(2021, 8, 10, 2, 7, 35, 750, DateTimeKind.Unspecified).AddTicks(7536) },
                    { 420, 5, "YT74248-0", 2, new DateTime(2021, 10, 18, 6, 40, 21, 32, DateTimeKind.Unspecified).AddTicks(3028), new DateTime(2021, 6, 29, 7, 47, 36, 494, DateTimeKind.Unspecified).AddTicks(211) },
                    { 421, 3, "YT94473-0", 2, new DateTime(2021, 9, 5, 11, 55, 42, 971, DateTimeKind.Unspecified).AddTicks(6415), new DateTime(2021, 6, 7, 6, 47, 8, 892, DateTimeKind.Unspecified).AddTicks(501) },
                    { 423, 1, "YT79200-0", 2, new DateTime(2021, 11, 13, 6, 7, 26, 218, DateTimeKind.Unspecified).AddTicks(2297), new DateTime(2021, 8, 16, 15, 26, 12, 397, DateTimeKind.Unspecified).AddTicks(8540) },
                    { 426, 2, "YT42017-0", 2, new DateTime(2021, 9, 12, 5, 15, 26, 122, DateTimeKind.Unspecified).AddTicks(4984), new DateTime(2021, 7, 24, 21, 16, 46, 370, DateTimeKind.Unspecified).AddTicks(9199) },
                    { 429, 4, "YT44323-1", 2, new DateTime(2021, 12, 21, 23, 26, 39, 943, DateTimeKind.Unspecified).AddTicks(140), new DateTime(2021, 6, 8, 21, 1, 58, 101, DateTimeKind.Unspecified).AddTicks(241) },
                    { 432, 2, "YT87693-0", 2, new DateTime(2021, 9, 14, 18, 50, 3, 706, DateTimeKind.Unspecified).AddTicks(5315), new DateTime(2021, 7, 29, 12, 20, 37, 229, DateTimeKind.Unspecified).AddTicks(5601) },
                    { 375, 5, "YT16379-0", 2, new DateTime(2021, 9, 15, 18, 54, 23, 232, DateTimeKind.Unspecified).AddTicks(602), new DateTime(2021, 7, 26, 14, 35, 9, 619, DateTimeKind.Unspecified).AddTicks(1323) },
                    { 985, 1, "YT65514-0", 5, new DateTime(2021, 12, 9, 4, 18, 55, 406, DateTimeKind.Unspecified).AddTicks(2674), new DateTime(2021, 8, 7, 9, 53, 33, 894, DateTimeKind.Unspecified).AddTicks(4732) },
                    { 639, 5, "YT10557-0", 2, new DateTime(2021, 10, 3, 19, 34, 37, 638, DateTimeKind.Unspecified).AddTicks(8005), new DateTime(2021, 6, 7, 2, 7, 17, 692, DateTimeKind.Unspecified).AddTicks(2315) },
                    { 642, 5, "YT27237-0", 2, new DateTime(2021, 12, 10, 12, 18, 52, 891, DateTimeKind.Unspecified).AddTicks(1198), new DateTime(2021, 8, 7, 18, 12, 36, 155, DateTimeKind.Unspecified).AddTicks(5348) },
                    { 847, 1, "YT73818-1", 2, new DateTime(2021, 9, 4, 23, 1, 34, 996, DateTimeKind.Unspecified).AddTicks(6399), new DateTime(2021, 6, 21, 5, 16, 34, 597, DateTimeKind.Unspecified).AddTicks(5243) },
                    { 857, 1, "YT53455-1", 2, new DateTime(2021, 9, 18, 0, 26, 41, 468, DateTimeKind.Unspecified).AddTicks(393), new DateTime(2021, 8, 28, 13, 58, 19, 63, DateTimeKind.Unspecified).AddTicks(9921) },
                    { 860, 3, "YT21568-0", 2, new DateTime(2021, 10, 28, 12, 54, 18, 96, DateTimeKind.Unspecified).AddTicks(3709), new DateTime(2021, 6, 17, 17, 29, 31, 563, DateTimeKind.Unspecified).AddTicks(7187) },
                    { 863, 3, "YT98684-0", 2, new DateTime(2021, 10, 19, 2, 2, 6, 259, DateTimeKind.Unspecified).AddTicks(2797), new DateTime(2021, 6, 26, 13, 59, 41, 671, DateTimeKind.Unspecified).AddTicks(7114) },
                    { 868, 1, "YT70332-0", 2, new DateTime(2021, 9, 26, 3, 8, 42, 128, DateTimeKind.Unspecified).AddTicks(9375), new DateTime(2021, 8, 24, 14, 1, 4, 108, DateTimeKind.Unspecified).AddTicks(6813) },
                    { 870, 3, "YT45978-1", 2, new DateTime(2021, 9, 26, 8, 11, 42, 154, DateTimeKind.Unspecified).AddTicks(9794), new DateTime(2021, 8, 18, 14, 23, 25, 421, DateTimeKind.Unspecified).AddTicks(3422) },
                    { 874, 4, "YT49646-0", 2, new DateTime(2021, 12, 1, 13, 54, 50, 77, DateTimeKind.Unspecified).AddTicks(4772), new DateTime(2021, 6, 1, 10, 3, 52, 940, DateTimeKind.Unspecified).AddTicks(9649) },
                    { 878, 1, "YT78013-0", 2, new DateTime(2021, 12, 6, 15, 47, 55, 817, DateTimeKind.Unspecified).AddTicks(6606), new DateTime(2021, 5, 11, 9, 29, 1, 880, DateTimeKind.Unspecified).AddTicks(3687) },
                    { 879, 2, "YT34364-0", 2, new DateTime(2021, 10, 24, 15, 55, 43, 334, DateTimeKind.Unspecified).AddTicks(3365), new DateTime(2021, 8, 28, 22, 22, 4, 971, DateTimeKind.Unspecified).AddTicks(6746) },
                    { 882, 2, "YT64611-0", 2, new DateTime(2021, 12, 18, 16, 4, 42, 836, DateTimeKind.Unspecified).AddTicks(8218), new DateTime(2021, 5, 14, 3, 1, 8, 238, DateTimeKind.Unspecified).AddTicks(9027) },
                    { 886, 4, "YT13007-1", 2, new DateTime(2021, 9, 18, 13, 26, 48, 643, DateTimeKind.Unspecified).AddTicks(8688), new DateTime(2021, 8, 30, 7, 42, 17, 256, DateTimeKind.Unspecified).AddTicks(6054) },
                    { 898, 5, "YT85420-1", 2, new DateTime(2021, 9, 23, 9, 59, 46, 528, DateTimeKind.Unspecified).AddTicks(989), new DateTime(2021, 5, 30, 1, 29, 48, 459, DateTimeKind.Unspecified).AddTicks(6507) },
                    { 903, 5, "YT18242-1", 2, new DateTime(2021, 9, 4, 14, 48, 53, 968, DateTimeKind.Unspecified).AddTicks(5137), new DateTime(2021, 8, 11, 19, 23, 5, 798, DateTimeKind.Unspecified).AddTicks(9398) },
                    { 904, 2, "YT23039-1", 2, new DateTime(2021, 11, 21, 16, 7, 39, 445, DateTimeKind.Unspecified).AddTicks(372), new DateTime(2021, 7, 24, 19, 33, 44, 438, DateTimeKind.Unspecified).AddTicks(4453) },
                    { 906, 5, "YT36541-0", 2, new DateTime(2021, 9, 11, 1, 46, 55, 592, DateTimeKind.Unspecified).AddTicks(3218), new DateTime(2021, 7, 20, 16, 34, 46, 519, DateTimeKind.Unspecified).AddTicks(7370) },
                    { 911, 2, "YT48829-1", 2, new DateTime(2021, 11, 30, 11, 26, 32, 484, DateTimeKind.Unspecified).AddTicks(121), new DateTime(2021, 8, 26, 17, 1, 48, 382, DateTimeKind.Unspecified).AddTicks(4354) },
                    { 916, 1, "YT91275-0", 2, new DateTime(2021, 11, 14, 12, 57, 14, 902, DateTimeKind.Unspecified).AddTicks(4126), new DateTime(2021, 6, 16, 23, 19, 16, 82, DateTimeKind.Unspecified).AddTicks(8585) },
                    { 920, 1, "YT79005-1", 2, new DateTime(2021, 12, 6, 9, 6, 14, 398, DateTimeKind.Unspecified).AddTicks(7087), new DateTime(2021, 6, 28, 10, 2, 9, 560, DateTimeKind.Unspecified).AddTicks(5560) },
                    { 923, 2, "YT25300-1", 2, new DateTime(2021, 9, 28, 7, 39, 32, 618, DateTimeKind.Unspecified).AddTicks(4318), new DateTime(2021, 6, 6, 16, 49, 48, 142, DateTimeKind.Unspecified).AddTicks(2057) },
                    { 924, 2, "YT74767-1", 2, new DateTime(2021, 10, 30, 11, 27, 9, 457, DateTimeKind.Unspecified).AddTicks(966), new DateTime(2021, 6, 9, 23, 3, 4, 220, DateTimeKind.Unspecified).AddTicks(8593) },
                    { 928, 5, "YT87710-1", 2, new DateTime(2021, 11, 7, 0, 54, 2, 391, DateTimeKind.Unspecified).AddTicks(5878), new DateTime(2021, 5, 15, 20, 13, 34, 593, DateTimeKind.Unspecified).AddTicks(4563) },
                    { 936, 5, "YT35803-0", 2, new DateTime(2021, 11, 12, 1, 11, 27, 646, DateTimeKind.Unspecified).AddTicks(3895), new DateTime(2021, 6, 28, 19, 45, 44, 32, DateTimeKind.Unspecified).AddTicks(883) },
                    { 942, 3, "YT76346-1", 2, new DateTime(2021, 9, 1, 20, 17, 57, 206, DateTimeKind.Unspecified).AddTicks(7977), new DateTime(2021, 7, 2, 5, 47, 49, 9, DateTimeKind.Unspecified).AddTicks(7280) },
                    { 963, 4, "YT53121-0", 2, new DateTime(2021, 10, 31, 8, 38, 56, 287, DateTimeKind.Unspecified).AddTicks(5368), new DateTime(2021, 5, 17, 14, 29, 24, 140, DateTimeKind.Unspecified).AddTicks(163) },
                    { 965, 1, "YT31806-0", 2, new DateTime(2021, 10, 10, 11, 13, 41, 873, DateTimeKind.Unspecified).AddTicks(3052), new DateTime(2021, 5, 19, 2, 25, 46, 465, DateTimeKind.Unspecified).AddTicks(8599) },
                    { 973, 4, "YT81379-1", 2, new DateTime(2021, 9, 24, 13, 31, 15, 960, DateTimeKind.Unspecified).AddTicks(1015), new DateTime(2021, 8, 21, 15, 16, 6, 418, DateTimeKind.Unspecified).AddTicks(8432) },
                    { 974, 2, "YT35642-1", 2, new DateTime(2021, 12, 18, 11, 0, 35, 84, DateTimeKind.Unspecified).AddTicks(2511), new DateTime(2021, 5, 12, 23, 22, 31, 891, DateTimeKind.Unspecified).AddTicks(8951) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 843, 3, "YT68724-1", 2, new DateTime(2021, 12, 3, 20, 20, 25, 208, DateTimeKind.Unspecified).AddTicks(1273), new DateTime(2021, 5, 21, 18, 44, 51, 63, DateTimeKind.Unspecified).AddTicks(6084) },
                    { 838, 4, "YT73949-1", 2, new DateTime(2021, 11, 1, 17, 23, 49, 445, DateTimeKind.Unspecified).AddTicks(9605), new DateTime(2021, 7, 13, 0, 34, 35, 514, DateTimeKind.Unspecified).AddTicks(7139) },
                    { 828, 5, "YT58408-1", 2, new DateTime(2021, 10, 21, 15, 11, 20, 127, DateTimeKind.Unspecified).AddTicks(8592), new DateTime(2021, 7, 4, 0, 16, 6, 142, DateTimeKind.Unspecified).AddTicks(4567) },
                    { 825, 2, "YT37750-0", 2, new DateTime(2021, 12, 2, 17, 22, 0, 296, DateTimeKind.Unspecified).AddTicks(8039), new DateTime(2021, 7, 13, 10, 46, 16, 518, DateTimeKind.Unspecified).AddTicks(8413) },
                    { 647, 1, "YT45368-0", 2, new DateTime(2021, 9, 1, 12, 48, 6, 164, DateTimeKind.Unspecified).AddTicks(8133), new DateTime(2021, 5, 30, 11, 33, 7, 718, DateTimeKind.Unspecified).AddTicks(5613) },
                    { 654, 2, "YT79911-1", 2, new DateTime(2021, 10, 18, 2, 55, 9, 745, DateTimeKind.Unspecified).AddTicks(6147), new DateTime(2021, 6, 2, 8, 23, 26, 821, DateTimeKind.Unspecified).AddTicks(6867) },
                    { 669, 2, "YT81949-1", 2, new DateTime(2021, 11, 14, 22, 38, 22, 361, DateTimeKind.Unspecified).AddTicks(5054), new DateTime(2021, 8, 3, 8, 13, 1, 511, DateTimeKind.Unspecified).AddTicks(4994) },
                    { 672, 2, "YT43141-1", 2, new DateTime(2021, 11, 15, 10, 30, 17, 72, DateTimeKind.Unspecified).AddTicks(2646), new DateTime(2021, 8, 12, 4, 50, 30, 440, DateTimeKind.Unspecified).AddTicks(853) },
                    { 673, 4, "YT72653-0", 2, new DateTime(2021, 9, 22, 22, 48, 24, 427, DateTimeKind.Unspecified).AddTicks(4817), new DateTime(2021, 6, 2, 11, 22, 18, 181, DateTimeKind.Unspecified).AddTicks(3076) },
                    { 677, 1, "YT59393-0", 2, new DateTime(2021, 10, 24, 2, 32, 48, 624, DateTimeKind.Unspecified).AddTicks(9463), new DateTime(2021, 7, 9, 2, 3, 43, 438, DateTimeKind.Unspecified).AddTicks(5555) },
                    { 683, 3, "YT88324-1", 2, new DateTime(2021, 11, 22, 15, 15, 33, 729, DateTimeKind.Unspecified).AddTicks(7427), new DateTime(2021, 6, 21, 18, 54, 27, 582, DateTimeKind.Unspecified).AddTicks(265) },
                    { 685, 2, "YT32845-1", 2, new DateTime(2021, 10, 31, 21, 14, 12, 199, DateTimeKind.Unspecified).AddTicks(3963), new DateTime(2021, 5, 10, 16, 20, 30, 758, DateTimeKind.Unspecified).AddTicks(2146) },
                    { 686, 2, "YT11263-1", 2, new DateTime(2021, 9, 18, 21, 51, 3, 60, DateTimeKind.Unspecified).AddTicks(7912), new DateTime(2021, 6, 1, 2, 44, 6, 800, DateTimeKind.Unspecified).AddTicks(2261) },
                    { 691, 3, "YT35174-1", 2, new DateTime(2021, 10, 23, 7, 25, 27, 841, DateTimeKind.Unspecified).AddTicks(380), new DateTime(2021, 5, 25, 11, 32, 34, 947, DateTimeKind.Unspecified).AddTicks(8680) },
                    { 696, 3, "YT41125-1", 2, new DateTime(2021, 11, 29, 19, 53, 15, 589, DateTimeKind.Unspecified).AddTicks(3656), new DateTime(2021, 5, 10, 14, 47, 36, 238, DateTimeKind.Unspecified).AddTicks(562) },
                    { 706, 3, "YT67209-1", 2, new DateTime(2021, 9, 13, 10, 19, 9, 63, DateTimeKind.Unspecified).AddTicks(934), new DateTime(2021, 8, 1, 12, 22, 19, 433, DateTimeKind.Unspecified).AddTicks(3510) },
                    { 726, 3, "YT47372-0", 2, new DateTime(2021, 11, 30, 14, 13, 37, 577, DateTimeKind.Unspecified).AddTicks(8195), new DateTime(2021, 7, 29, 7, 43, 36, 532, DateTimeKind.Unspecified).AddTicks(3372) },
                    { 640, 1, "YT32452-1", 2, new DateTime(2021, 9, 21, 19, 17, 32, 344, DateTimeKind.Unspecified).AddTicks(3814), new DateTime(2021, 7, 7, 18, 38, 59, 996, DateTimeKind.Unspecified).AddTicks(7536) },
                    { 737, 4, "YT73722-0", 2, new DateTime(2021, 11, 19, 12, 28, 16, 743, DateTimeKind.Unspecified).AddTicks(9056), new DateTime(2021, 5, 11, 22, 38, 39, 763, DateTimeKind.Unspecified).AddTicks(4227) },
                    { 770, 3, "YT15800-0", 2, new DateTime(2021, 12, 29, 13, 7, 54, 73, DateTimeKind.Unspecified).AddTicks(4782), new DateTime(2021, 6, 5, 19, 48, 28, 387, DateTimeKind.Unspecified).AddTicks(5035) },
                    { 775, 2, "YT91428-1", 2, new DateTime(2021, 9, 11, 10, 42, 12, 11, DateTimeKind.Unspecified).AddTicks(6982), new DateTime(2021, 6, 11, 13, 41, 47, 514, DateTimeKind.Unspecified).AddTicks(3910) },
                    { 778, 3, "YT42954-1", 2, new DateTime(2021, 9, 30, 16, 44, 23, 430, DateTimeKind.Unspecified).AddTicks(6697), new DateTime(2021, 8, 23, 17, 31, 22, 322, DateTimeKind.Unspecified).AddTicks(5628) },
                    { 780, 5, "YT57984-1", 2, new DateTime(2021, 9, 15, 2, 58, 46, 129, DateTimeKind.Unspecified).AddTicks(1122), new DateTime(2021, 5, 21, 2, 45, 43, 784, DateTimeKind.Unspecified).AddTicks(895) },
                    { 792, 1, "YT49429-1", 2, new DateTime(2021, 10, 5, 13, 1, 37, 870, DateTimeKind.Unspecified).AddTicks(5297), new DateTime(2021, 6, 10, 16, 22, 30, 207, DateTimeKind.Unspecified).AddTicks(8986) },
                    { 802, 4, "YT49275-0", 2, new DateTime(2021, 11, 21, 16, 26, 27, 652, DateTimeKind.Unspecified).AddTicks(5573), new DateTime(2021, 5, 20, 4, 15, 42, 369, DateTimeKind.Unspecified).AddTicks(525) },
                    { 806, 2, "YT38988-1", 2, new DateTime(2021, 12, 5, 23, 58, 4, 664, DateTimeKind.Unspecified).AddTicks(2747), new DateTime(2021, 8, 29, 1, 45, 7, 188, DateTimeKind.Unspecified).AddTicks(415) },
                    { 811, 5, "YT95294-0", 2, new DateTime(2021, 10, 6, 4, 6, 11, 477, DateTimeKind.Unspecified).AddTicks(4797), new DateTime(2021, 6, 17, 22, 21, 59, 945, DateTimeKind.Unspecified).AddTicks(7111) },
                    { 814, 4, "YT42123-1", 2, new DateTime(2021, 9, 23, 20, 54, 8, 500, DateTimeKind.Unspecified).AddTicks(3121), new DateTime(2021, 8, 12, 18, 10, 47, 8, DateTimeKind.Unspecified).AddTicks(680) },
                    { 816, 1, "YT89326-0", 2, new DateTime(2021, 12, 20, 8, 51, 28, 655, DateTimeKind.Unspecified).AddTicks(7757), new DateTime(2021, 8, 21, 13, 50, 53, 228, DateTimeKind.Unspecified).AddTicks(7115) },
                    { 818, 5, "YT42473-0", 2, new DateTime(2021, 9, 17, 13, 47, 9, 78, DateTimeKind.Unspecified).AddTicks(3279), new DateTime(2021, 8, 4, 6, 19, 26, 400, DateTimeKind.Unspecified).AddTicks(7248) },
                    { 820, 1, "YT55131-0", 2, new DateTime(2021, 10, 3, 0, 21, 50, 125, DateTimeKind.Unspecified).AddTicks(208), new DateTime(2021, 7, 6, 14, 22, 20, 924, DateTimeKind.Unspecified).AddTicks(8504) },
                    { 824, 1, "YT81382-1", 2, new DateTime(2021, 12, 19, 2, 33, 39, 428, DateTimeKind.Unspecified).AddTicks(6538), new DateTime(2021, 8, 25, 11, 4, 58, 801, DateTimeKind.Unspecified).AddTicks(3885) },
                    { 766, 2, "YT33565-0", 2, new DateTime(2021, 10, 27, 18, 28, 19, 753, DateTimeKind.Unspecified).AddTicks(5956), new DateTime(2021, 6, 5, 11, 28, 27, 278, DateTimeKind.Unspecified).AddTicks(384) },
                    { 996, 5, "YT32494-0", 5, new DateTime(2021, 10, 9, 14, 14, 55, 587, DateTimeKind.Unspecified).AddTicks(2134), new DateTime(2021, 7, 11, 14, 47, 21, 629, DateTimeKind.Unspecified).AddTicks(8473) }
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
