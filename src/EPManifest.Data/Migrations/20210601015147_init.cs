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
                    { 14, 1, "YT50037-1", 1, new DateTime(2021, 10, 31, 11, 35, 46, 744, DateTimeKind.Unspecified).AddTicks(5747), new DateTime(2021, 8, 12, 18, 20, 49, 446, DateTimeKind.Unspecified).AddTicks(5629) },
                    { 13, 1, "YT77639-0", 4, new DateTime(2021, 10, 7, 15, 25, 35, 79, DateTimeKind.Unspecified).AddTicks(3680), new DateTime(2021, 5, 11, 16, 37, 21, 32, DateTimeKind.Unspecified).AddTicks(2766) },
                    { 7, 5, "YT21694-1", 4, new DateTime(2021, 12, 10, 1, 32, 16, 446, DateTimeKind.Unspecified).AddTicks(2953), new DateTime(2021, 7, 16, 9, 13, 40, 77, DateTimeKind.Unspecified).AddTicks(8043) },
                    { 2, 2, "YT91597-0", 4, new DateTime(2021, 9, 7, 11, 32, 15, 316, DateTimeKind.Unspecified).AddTicks(8741), new DateTime(2021, 5, 21, 0, 4, 59, 234, DateTimeKind.Unspecified).AddTicks(5066) },
                    { 1, 4, "YT52628-1", 4, new DateTime(2021, 11, 20, 7, 6, 1, 605, DateTimeKind.Unspecified).AddTicks(377), new DateTime(2021, 7, 30, 23, 22, 51, 478, DateTimeKind.Unspecified).AddTicks(8739) },
                    { 90, 5, "YT53614-1", 3, new DateTime(2021, 9, 16, 16, 10, 55, 553, DateTimeKind.Unspecified).AddTicks(7704), new DateTime(2021, 8, 15, 21, 3, 6, 256, DateTimeKind.Unspecified).AddTicks(9208) },
                    { 86, 5, "YT70351-0", 3, new DateTime(2021, 10, 9, 13, 4, 4, 725, DateTimeKind.Unspecified).AddTicks(2150), new DateTime(2021, 8, 25, 4, 0, 6, 574, DateTimeKind.Unspecified).AddTicks(3290) },
                    { 80, 4, "YT69018-0", 3, new DateTime(2021, 9, 22, 15, 50, 2, 601, DateTimeKind.Unspecified).AddTicks(2418), new DateTime(2021, 7, 26, 7, 28, 47, 812, DateTimeKind.Unspecified).AddTicks(3936) },
                    { 74, 2, "YT66150-1", 3, new DateTime(2021, 12, 25, 21, 9, 51, 519, DateTimeKind.Unspecified).AddTicks(1767), new DateTime(2021, 6, 6, 5, 21, 57, 986, DateTimeKind.Unspecified).AddTicks(8386) },
                    { 71, 2, "YT43668-1", 3, new DateTime(2021, 12, 9, 23, 20, 0, 870, DateTimeKind.Unspecified).AddTicks(7065), new DateTime(2021, 5, 20, 21, 40, 13, 919, DateTimeKind.Unspecified).AddTicks(9143) },
                    { 69, 2, "YT33212-0", 3, new DateTime(2021, 9, 22, 13, 10, 0, 369, DateTimeKind.Unspecified).AddTicks(8361), new DateTime(2021, 8, 9, 16, 27, 19, 963, DateTimeKind.Unspecified).AddTicks(7200) },
                    { 66, 5, "YT25034-0", 3, new DateTime(2021, 11, 28, 0, 15, 13, 282, DateTimeKind.Unspecified).AddTicks(2726), new DateTime(2021, 6, 5, 13, 35, 20, 116, DateTimeKind.Unspecified).AddTicks(4518) },
                    { 62, 2, "YT25196-1", 3, new DateTime(2021, 9, 9, 22, 43, 52, 978, DateTimeKind.Unspecified).AddTicks(8634), new DateTime(2021, 8, 22, 4, 13, 2, 2, DateTimeKind.Unspecified).AddTicks(4710) },
                    { 54, 4, "YT81262-0", 3, new DateTime(2021, 12, 9, 0, 27, 22, 933, DateTimeKind.Unspecified).AddTicks(9178), new DateTime(2021, 5, 26, 18, 43, 9, 527, DateTimeKind.Unspecified).AddTicks(2450) },
                    { 53, 3, "YT21554-1", 3, new DateTime(2021, 12, 22, 12, 18, 39, 553, DateTimeKind.Unspecified).AddTicks(710), new DateTime(2021, 5, 19, 11, 37, 35, 366, DateTimeKind.Unspecified).AddTicks(9588) },
                    { 50, 1, "YT77165-0", 3, new DateTime(2021, 10, 25, 4, 3, 47, 42, DateTimeKind.Unspecified).AddTicks(6967), new DateTime(2021, 7, 18, 0, 48, 1, 864, DateTimeKind.Unspecified).AddTicks(9976) },
                    { 21, 1, "YT51157-0", 3, new DateTime(2021, 11, 23, 13, 57, 8, 3, DateTimeKind.Unspecified).AddTicks(216), new DateTime(2021, 6, 16, 4, 51, 28, 266, DateTimeKind.Unspecified).AddTicks(3257) },
                    { 15, 1, "YT15015-0", 3, new DateTime(2021, 9, 24, 20, 23, 9, 84, DateTimeKind.Unspecified).AddTicks(1647), new DateTime(2021, 8, 15, 16, 23, 39, 671, DateTimeKind.Unspecified).AddTicks(7343) },
                    { 11, 1, "YT23078-0", 3, new DateTime(2021, 9, 2, 18, 26, 53, 924, DateTimeKind.Unspecified).AddTicks(4091), new DateTime(2021, 6, 12, 0, 15, 3, 113, DateTimeKind.Unspecified).AddTicks(9914) },
                    { 9, 4, "YT13101-0", 3, new DateTime(2021, 12, 5, 22, 48, 48, 946, DateTimeKind.Unspecified).AddTicks(5601), new DateTime(2021, 7, 9, 5, 32, 47, 952, DateTimeKind.Unspecified).AddTicks(6958) },
                    { 5, 5, "YT41745-1", 3, new DateTime(2021, 11, 12, 19, 53, 26, 321, DateTimeKind.Unspecified).AddTicks(3533), new DateTime(2021, 8, 14, 20, 44, 59, 959, DateTimeKind.Unspecified).AddTicks(7346) },
                    { 98, 2, "YT19089-1", 2, new DateTime(2021, 9, 19, 2, 49, 19, 718, DateTimeKind.Unspecified).AddTicks(1025), new DateTime(2021, 5, 13, 20, 51, 24, 28, DateTimeKind.Unspecified).AddTicks(7037) },
                    { 17, 5, "YT39526-0", 4, new DateTime(2021, 10, 21, 20, 1, 24, 784, DateTimeKind.Unspecified).AddTicks(4594), new DateTime(2021, 6, 29, 7, 12, 29, 564, DateTimeKind.Unspecified).AddTicks(7924) },
                    { 93, 5, "YT15417-1", 2, new DateTime(2021, 12, 13, 3, 55, 51, 248, DateTimeKind.Unspecified).AddTicks(533), new DateTime(2021, 8, 23, 5, 15, 14, 243, DateTimeKind.Unspecified).AddTicks(617) },
                    { 22, 1, "YT18964-1", 4, new DateTime(2021, 12, 2, 10, 45, 15, 731, DateTimeKind.Unspecified).AddTicks(5226), new DateTime(2021, 8, 3, 20, 8, 0, 100, DateTimeKind.Unspecified).AddTicks(6014) },
                    { 47, 4, "YT59162-0", 4, new DateTime(2021, 12, 16, 17, 46, 43, 906, DateTimeKind.Unspecified).AddTicks(5003), new DateTime(2021, 6, 10, 18, 8, 23, 637, DateTimeKind.Unspecified).AddTicks(7332) },
                    { 61, 3, "YT30305-1", 5, new DateTime(2021, 11, 15, 13, 8, 37, 786, DateTimeKind.Unspecified).AddTicks(9004), new DateTime(2021, 7, 23, 5, 33, 53, 728, DateTimeKind.Unspecified).AddTicks(3198) },
                    { 60, 3, "YT12867-0", 5, new DateTime(2021, 10, 22, 15, 0, 36, 712, DateTimeKind.Unspecified).AddTicks(5197), new DateTime(2021, 7, 13, 15, 0, 19, 314, DateTimeKind.Unspecified).AddTicks(8671) },
                    { 49, 2, "YT13545-0", 5, new DateTime(2021, 12, 22, 10, 58, 27, 79, DateTimeKind.Unspecified).AddTicks(8358), new DateTime(2021, 7, 14, 21, 21, 17, 212, DateTimeKind.Unspecified).AddTicks(5408) },
                    { 48, 5, "YT91491-1", 5, new DateTime(2021, 12, 29, 22, 36, 36, 633, DateTimeKind.Unspecified).AddTicks(2517), new DateTime(2021, 8, 13, 15, 13, 52, 115, DateTimeKind.Unspecified).AddTicks(2466) },
                    { 46, 5, "YT57478-1", 5, new DateTime(2021, 10, 21, 10, 55, 30, 357, DateTimeKind.Unspecified).AddTicks(364), new DateTime(2021, 8, 24, 15, 56, 31, 424, DateTimeKind.Unspecified).AddTicks(9628) },
                    { 41, 4, "YT53554-0", 5, new DateTime(2021, 10, 5, 19, 17, 14, 549, DateTimeKind.Unspecified).AddTicks(6277), new DateTime(2021, 7, 28, 22, 28, 56, 504, DateTimeKind.Unspecified).AddTicks(232) },
                    { 35, 1, "YT42627-1", 5, new DateTime(2021, 10, 14, 7, 8, 9, 474, DateTimeKind.Unspecified).AddTicks(4710), new DateTime(2021, 5, 23, 16, 13, 58, 997, DateTimeKind.Unspecified).AddTicks(724) },
                    { 33, 1, "YT49630-0", 5, new DateTime(2021, 9, 20, 15, 50, 25, 182, DateTimeKind.Unspecified).AddTicks(2901), new DateTime(2021, 8, 16, 7, 43, 54, 867, DateTimeKind.Unspecified).AddTicks(5425) },
                    { 28, 2, "YT56686-1", 5, new DateTime(2021, 10, 11, 2, 33, 53, 38, DateTimeKind.Unspecified).AddTicks(9602), new DateTime(2021, 6, 13, 13, 20, 16, 922, DateTimeKind.Unspecified).AddTicks(5574) },
                    { 25, 4, "YT21755-0", 5, new DateTime(2021, 11, 16, 17, 30, 32, 786, DateTimeKind.Unspecified).AddTicks(6818), new DateTime(2021, 6, 19, 4, 4, 27, 940, DateTimeKind.Unspecified).AddTicks(6041) },
                    { 18, 1, "YT30720-0", 5, new DateTime(2021, 9, 21, 2, 39, 44, 955, DateTimeKind.Unspecified).AddTicks(5388), new DateTime(2021, 8, 25, 6, 59, 3, 962, DateTimeKind.Unspecified).AddTicks(6841) },
                    { 8, 4, "YT40865-1", 5, new DateTime(2021, 10, 27, 10, 10, 6, 105, DateTimeKind.Unspecified).AddTicks(645), new DateTime(2021, 8, 12, 14, 44, 50, 46, DateTimeKind.Unspecified).AddTicks(3202) },
                    { 6, 3, "YT14452-0", 5, new DateTime(2021, 11, 11, 18, 48, 11, 233, DateTimeKind.Unspecified).AddTicks(719), new DateTime(2021, 6, 11, 0, 7, 55, 276, DateTimeKind.Unspecified).AddTicks(7222) },
                    { 4, 2, "YT32295-0", 5, new DateTime(2021, 10, 12, 5, 39, 58, 400, DateTimeKind.Unspecified).AddTicks(1299), new DateTime(2021, 6, 6, 21, 59, 21, 506, DateTimeKind.Unspecified).AddTicks(1667) },
                    { 94, 5, "YT26130-1", 4, new DateTime(2021, 11, 30, 10, 36, 34, 314, DateTimeKind.Unspecified).AddTicks(5155), new DateTime(2021, 8, 5, 16, 40, 15, 90, DateTimeKind.Unspecified).AddTicks(3951) },
                    { 91, 5, "YT20209-1", 4, new DateTime(2021, 9, 22, 2, 56, 50, 449, DateTimeKind.Unspecified).AddTicks(9971), new DateTime(2021, 8, 22, 15, 28, 7, 970, DateTimeKind.Unspecified).AddTicks(6731) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 89, 1, "YT60410-0", 4, new DateTime(2021, 10, 2, 14, 19, 8, 608, DateTimeKind.Unspecified).AddTicks(2511), new DateTime(2021, 8, 23, 16, 6, 10, 62, DateTimeKind.Unspecified).AddTicks(4199) },
                    { 84, 4, "YT72049-0", 4, new DateTime(2021, 10, 3, 21, 3, 2, 677, DateTimeKind.Unspecified).AddTicks(4592), new DateTime(2021, 8, 3, 13, 57, 38, 760, DateTimeKind.Unspecified).AddTicks(2477) },
                    { 73, 5, "YT99555-0", 4, new DateTime(2021, 9, 25, 8, 53, 38, 745, DateTimeKind.Unspecified).AddTicks(3136), new DateTime(2021, 7, 20, 15, 21, 33, 918, DateTimeKind.Unspecified).AddTicks(3344) },
                    { 67, 3, "YT73217-0", 4, new DateTime(2021, 10, 3, 8, 38, 0, 992, DateTimeKind.Unspecified).AddTicks(4434), new DateTime(2021, 7, 30, 23, 0, 56, 770, DateTimeKind.Unspecified).AddTicks(6554) },
                    { 56, 2, "YT96484-1", 4, new DateTime(2021, 9, 18, 23, 38, 10, 275, DateTimeKind.Unspecified).AddTicks(2587), new DateTime(2021, 5, 22, 11, 33, 45, 166, DateTimeKind.Unspecified).AddTicks(7991) },
                    { 45, 2, "YT24760-0", 4, new DateTime(2021, 9, 20, 10, 11, 46, 337, DateTimeKind.Unspecified).AddTicks(6732), new DateTime(2021, 5, 18, 21, 16, 29, 217, DateTimeKind.Unspecified).AddTicks(801) },
                    { 87, 5, "YT82955-0", 2, new DateTime(2021, 12, 2, 23, 5, 39, 816, DateTimeKind.Unspecified).AddTicks(6358), new DateTime(2021, 5, 14, 17, 29, 32, 908, DateTimeKind.Unspecified).AddTicks(6320) },
                    { 85, 2, "YT93812-1", 2, new DateTime(2021, 9, 12, 6, 9, 7, 241, DateTimeKind.Unspecified).AddTicks(3792), new DateTime(2021, 8, 15, 21, 51, 17, 273, DateTimeKind.Unspecified).AddTicks(2267) },
                    { 81, 4, "YT58944-0", 2, new DateTime(2021, 10, 15, 5, 1, 13, 941, DateTimeKind.Unspecified).AddTicks(1215), new DateTime(2021, 7, 31, 2, 35, 30, 237, DateTimeKind.Unspecified).AddTicks(1456) },
                    { 83, 3, "YT18220-0", 1, new DateTime(2021, 10, 6, 6, 25, 18, 314, DateTimeKind.Unspecified).AddTicks(5273), new DateTime(2021, 6, 28, 20, 57, 23, 88, DateTimeKind.Unspecified).AddTicks(6352) },
                    { 77, 3, "YT71562-0", 1, new DateTime(2021, 9, 5, 14, 12, 41, 974, DateTimeKind.Unspecified).AddTicks(3794), new DateTime(2021, 7, 24, 21, 43, 38, 504, DateTimeKind.Unspecified).AddTicks(4012) },
                    { 76, 3, "YT60750-1", 1, new DateTime(2021, 9, 9, 20, 45, 59, 344, DateTimeKind.Unspecified).AddTicks(836), new DateTime(2021, 5, 25, 9, 11, 17, 451, DateTimeKind.Unspecified).AddTicks(985) },
                    { 72, 2, "YT66463-1", 1, new DateTime(2021, 9, 22, 20, 59, 10, 702, DateTimeKind.Unspecified).AddTicks(8574), new DateTime(2021, 5, 11, 12, 26, 2, 43, DateTimeKind.Unspecified).AddTicks(8516) },
                    { 70, 1, "YT31806-1", 1, new DateTime(2021, 9, 28, 14, 30, 10, 192, DateTimeKind.Unspecified).AddTicks(7538), new DateTime(2021, 6, 28, 12, 51, 31, 748, DateTimeKind.Unspecified).AddTicks(4499) },
                    { 64, 2, "YT70185-0", 1, new DateTime(2021, 12, 24, 3, 4, 26, 716, DateTimeKind.Unspecified).AddTicks(801), new DateTime(2021, 6, 25, 17, 22, 5, 683, DateTimeKind.Unspecified).AddTicks(7793) },
                    { 63, 4, "YT69743-0", 1, new DateTime(2021, 11, 30, 11, 25, 50, 42, DateTimeKind.Unspecified).AddTicks(9628), new DateTime(2021, 7, 19, 22, 56, 35, 236, DateTimeKind.Unspecified).AddTicks(8495) },
                    { 58, 5, "YT99036-0", 1, new DateTime(2021, 9, 5, 6, 59, 24, 923, DateTimeKind.Unspecified).AddTicks(3831), new DateTime(2021, 5, 20, 8, 25, 32, 9, DateTimeKind.Unspecified).AddTicks(1389) },
                    { 52, 4, "YT56111-0", 1, new DateTime(2021, 12, 26, 7, 58, 36, 991, DateTimeKind.Unspecified).AddTicks(222), new DateTime(2021, 5, 22, 13, 43, 30, 575, DateTimeKind.Unspecified).AddTicks(9925) },
                    { 43, 4, "YT18843-1", 1, new DateTime(2021, 12, 14, 14, 28, 18, 508, DateTimeKind.Unspecified).AddTicks(649), new DateTime(2021, 6, 19, 17, 50, 52, 419, DateTimeKind.Unspecified).AddTicks(129) },
                    { 42, 2, "YT41282-0", 1, new DateTime(2021, 10, 15, 9, 38, 35, 900, DateTimeKind.Unspecified).AddTicks(2287), new DateTime(2021, 6, 20, 18, 28, 36, 891, DateTimeKind.Unspecified).AddTicks(8651) },
                    { 40, 5, "YT95435-0", 1, new DateTime(2021, 9, 16, 23, 44, 7, 472, DateTimeKind.Unspecified).AddTicks(6777), new DateTime(2021, 7, 21, 20, 13, 43, 770, DateTimeKind.Unspecified).AddTicks(6747) },
                    { 39, 5, "YT30737-0", 1, new DateTime(2021, 9, 10, 16, 54, 8, 544, DateTimeKind.Unspecified).AddTicks(2132), new DateTime(2021, 8, 23, 21, 13, 50, 78, DateTimeKind.Unspecified).AddTicks(7760) },
                    { 38, 4, "YT27275-0", 1, new DateTime(2021, 12, 24, 9, 49, 10, 254, DateTimeKind.Unspecified).AddTicks(7444), new DateTime(2021, 6, 9, 0, 46, 33, 196, DateTimeKind.Unspecified).AddTicks(3174) },
                    { 37, 3, "YT83485-1", 1, new DateTime(2021, 10, 15, 0, 46, 37, 850, DateTimeKind.Unspecified).AddTicks(6474), new DateTime(2021, 8, 6, 13, 5, 19, 901, DateTimeKind.Unspecified).AddTicks(7536) },
                    { 34, 3, "YT43814-1", 1, new DateTime(2021, 10, 24, 4, 59, 56, 665, DateTimeKind.Unspecified).AddTicks(167), new DateTime(2021, 6, 13, 0, 6, 28, 719, DateTimeKind.Unspecified).AddTicks(7988) },
                    { 32, 5, "YT56359-1", 1, new DateTime(2021, 11, 16, 6, 55, 34, 574, DateTimeKind.Unspecified).AddTicks(5218), new DateTime(2021, 8, 12, 16, 21, 39, 155, DateTimeKind.Unspecified).AddTicks(273) },
                    { 30, 2, "YT60370-0", 1, new DateTime(2021, 12, 29, 7, 46, 48, 899, DateTimeKind.Unspecified).AddTicks(2279), new DateTime(2021, 8, 20, 11, 4, 38, 4, DateTimeKind.Unspecified).AddTicks(8809) },
                    { 27, 1, "YT88022-0", 1, new DateTime(2021, 9, 25, 5, 3, 2, 865, DateTimeKind.Unspecified).AddTicks(8978), new DateTime(2021, 5, 12, 17, 38, 34, 591, DateTimeKind.Unspecified).AddTicks(291) },
                    { 20, 5, "YT67112-0", 1, new DateTime(2021, 12, 25, 18, 46, 29, 768, DateTimeKind.Unspecified).AddTicks(821), new DateTime(2021, 5, 10, 4, 50, 22, 548, DateTimeKind.Unspecified).AddTicks(742) },
                    { 19, 5, "YT13651-1", 1, new DateTime(2021, 11, 14, 23, 8, 52, 603, DateTimeKind.Unspecified).AddTicks(7616), new DateTime(2021, 8, 18, 22, 11, 32, 502, DateTimeKind.Unspecified).AddTicks(5641) },
                    { 88, 5, "YT71098-1", 1, new DateTime(2021, 10, 5, 4, 24, 9, 511, DateTimeKind.Unspecified).AddTicks(9467), new DateTime(2021, 8, 16, 3, 11, 42, 998, DateTimeKind.Unspecified).AddTicks(9684) },
                    { 92, 4, "YT83891-0", 1, new DateTime(2021, 10, 17, 16, 41, 54, 753, DateTimeKind.Unspecified).AddTicks(1014), new DateTime(2021, 7, 30, 5, 42, 15, 649, DateTimeKind.Unspecified).AddTicks(7979) },
                    { 95, 2, "YT53737-1", 1, new DateTime(2021, 9, 3, 0, 22, 36, 168, DateTimeKind.Unspecified).AddTicks(8668), new DateTime(2021, 6, 28, 8, 13, 56, 711, DateTimeKind.Unspecified).AddTicks(390) },
                    { 96, 1, "YT74911-1", 1, new DateTime(2021, 9, 28, 0, 25, 19, 690, DateTimeKind.Unspecified).AddTicks(1284), new DateTime(2021, 8, 6, 18, 55, 8, 335, DateTimeKind.Unspecified).AddTicks(8992) },
                    { 79, 5, "YT55621-0", 2, new DateTime(2021, 11, 20, 12, 20, 57, 472, DateTimeKind.Unspecified).AddTicks(575), new DateTime(2021, 6, 24, 12, 42, 6, 16, DateTimeKind.Unspecified).AddTicks(1732) },
                    { 78, 2, "YT87840-1", 2, new DateTime(2021, 11, 21, 5, 7, 22, 687, DateTimeKind.Unspecified).AddTicks(4619), new DateTime(2021, 6, 4, 11, 4, 23, 740, DateTimeKind.Unspecified).AddTicks(1826) },
                    { 75, 2, "YT69611-1", 2, new DateTime(2021, 10, 3, 15, 3, 51, 844, DateTimeKind.Unspecified).AddTicks(8349), new DateTime(2021, 7, 15, 15, 58, 9, 373, DateTimeKind.Unspecified).AddTicks(3352) },
                    { 68, 2, "YT64586-0", 2, new DateTime(2021, 12, 23, 1, 11, 10, 105, DateTimeKind.Unspecified).AddTicks(4667), new DateTime(2021, 8, 15, 4, 9, 13, 812, DateTimeKind.Unspecified).AddTicks(3588) },
                    { 65, 3, "YT17878-0", 2, new DateTime(2021, 9, 10, 7, 25, 42, 862, DateTimeKind.Unspecified).AddTicks(5216), new DateTime(2021, 6, 6, 12, 5, 59, 429, DateTimeKind.Unspecified).AddTicks(6941) },
                    { 59, 3, "YT55136-0", 2, new DateTime(2021, 10, 4, 22, 41, 50, 59, DateTimeKind.Unspecified).AddTicks(5542), new DateTime(2021, 6, 5, 23, 45, 48, 345, DateTimeKind.Unspecified).AddTicks(4760) },
                    { 57, 3, "YT62238-0", 2, new DateTime(2021, 11, 22, 14, 52, 48, 683, DateTimeKind.Unspecified).AddTicks(8370), new DateTime(2021, 6, 13, 4, 3, 10, 427, DateTimeKind.Unspecified).AddTicks(9285) },
                    { 55, 5, "YT37016-0", 2, new DateTime(2021, 10, 27, 10, 6, 15, 726, DateTimeKind.Unspecified).AddTicks(7928), new DateTime(2021, 5, 29, 8, 47, 4, 825, DateTimeKind.Unspecified).AddTicks(1809) }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 51, 5, "YT70541-0", 2, new DateTime(2021, 11, 1, 11, 2, 52, 487, DateTimeKind.Unspecified).AddTicks(3683), new DateTime(2021, 7, 29, 14, 49, 19, 173, DateTimeKind.Unspecified).AddTicks(1245) },
                    { 44, 1, "YT41814-1", 2, new DateTime(2021, 12, 3, 14, 59, 43, 771, DateTimeKind.Unspecified).AddTicks(2658), new DateTime(2021, 8, 21, 3, 31, 16, 47, DateTimeKind.Unspecified).AddTicks(1224) },
                    { 82, 3, "YT25776-0", 5, new DateTime(2021, 10, 17, 16, 30, 24, 621, DateTimeKind.Unspecified).AddTicks(1373), new DateTime(2021, 6, 3, 18, 46, 54, 914, DateTimeKind.Unspecified).AddTicks(2342) },
                    { 36, 1, "YT29086-1", 2, new DateTime(2021, 11, 15, 23, 11, 2, 522, DateTimeKind.Unspecified).AddTicks(9524), new DateTime(2021, 6, 22, 3, 29, 26, 658, DateTimeKind.Unspecified).AddTicks(2568) },
                    { 29, 4, "YT43584-1", 2, new DateTime(2021, 9, 13, 14, 34, 44, 24, DateTimeKind.Unspecified).AddTicks(8233), new DateTime(2021, 6, 20, 11, 45, 12, 773, DateTimeKind.Unspecified).AddTicks(4903) },
                    { 26, 4, "YT44494-0", 2, new DateTime(2021, 10, 9, 22, 32, 36, 511, DateTimeKind.Unspecified).AddTicks(6411), new DateTime(2021, 6, 25, 18, 17, 41, 100, DateTimeKind.Unspecified).AddTicks(6120) },
                    { 24, 2, "YT65878-1", 2, new DateTime(2021, 9, 29, 23, 5, 9, 604, DateTimeKind.Unspecified).AddTicks(8906), new DateTime(2021, 5, 10, 16, 7, 31, 691, DateTimeKind.Unspecified).AddTicks(2269) },
                    { 23, 4, "YT68496-1", 2, new DateTime(2021, 10, 27, 22, 9, 12, 781, DateTimeKind.Unspecified).AddTicks(7770), new DateTime(2021, 8, 10, 12, 0, 18, 716, DateTimeKind.Unspecified).AddTicks(7965) },
                    { 16, 1, "YT39032-1", 2, new DateTime(2021, 11, 9, 6, 48, 59, 675, DateTimeKind.Unspecified).AddTicks(8388), new DateTime(2021, 7, 30, 15, 49, 16, 838, DateTimeKind.Unspecified).AddTicks(3035) },
                    { 12, 4, "YT27709-0", 2, new DateTime(2021, 10, 20, 1, 14, 39, 584, DateTimeKind.Unspecified).AddTicks(8778), new DateTime(2021, 7, 2, 7, 7, 44, 88, DateTimeKind.Unspecified).AddTicks(1270) },
                    { 10, 2, "YT74740-0", 2, new DateTime(2021, 12, 2, 5, 49, 21, 45, DateTimeKind.Unspecified).AddTicks(8010), new DateTime(2021, 6, 13, 21, 8, 57, 335, DateTimeKind.Unspecified).AddTicks(3225) },
                    { 3, 4, "YT10554-1", 2, new DateTime(2021, 11, 2, 8, 2, 32, 401, DateTimeKind.Unspecified).AddTicks(6545), new DateTime(2021, 5, 11, 15, 59, 12, 338, DateTimeKind.Unspecified).AddTicks(7953) },
                    { 100, 5, "YT45858-0", 1, new DateTime(2021, 10, 15, 12, 39, 39, 567, DateTimeKind.Unspecified).AddTicks(4402), new DateTime(2021, 6, 24, 12, 45, 31, 525, DateTimeKind.Unspecified).AddTicks(2175) },
                    { 99, 4, "YT90199-1", 1, new DateTime(2021, 12, 17, 15, 59, 37, 905, DateTimeKind.Unspecified).AddTicks(5044), new DateTime(2021, 8, 5, 6, 51, 9, 56, DateTimeKind.Unspecified).AddTicks(9918) },
                    { 31, 1, "YT81609-0", 2, new DateTime(2021, 10, 23, 14, 38, 12, 80, DateTimeKind.Unspecified).AddTicks(3032), new DateTime(2021, 8, 7, 14, 26, 41, 30, DateTimeKind.Unspecified).AddTicks(2994) },
                    { 97, 5, "YT24990-1", 5, new DateTime(2021, 11, 25, 23, 9, 57, 769, DateTimeKind.Unspecified).AddTicks(1696), new DateTime(2021, 5, 23, 3, 2, 26, 382, DateTimeKind.Unspecified).AddTicks(9971) }
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
