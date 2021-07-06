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
                    ConsignorId = table.Column<int>(type: "int", nullable: false),
                    ManifestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsignorManifest", x => new { x.ManifestId, x.ConsignorId });
                    table.ForeignKey(
                        name: "FK_ConsignorManifest_Consignors_ConsignorId",
                        column: x => x.ConsignorId,
                        principalTable: "Consignors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsignorManifest_Manifests_ManifestId",
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
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "YG80-899", "A1 Delivery" },
                    { 2, "YG81-671", "Pacific Northwest Freight" },
                    { 3, "YG80-909", "AP Freight" },
                    { 4, "YG42-554", "NM Shipping Inc" },
                    { 5, "YG81-241", "Frank's Freight" }
                });

            migrationBuilder.InsertData(
                table: "Consignees",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "YG80-120", "Pete's Disposal" },
                    { 2, "YG81-301", "ATI Environmental" },
                    { 3, "YG42-757", "EQ Enviro" },
                    { 4, "YG81-486", "Whitehorse Landfill" },
                    { 5, "YG41-309", "YAE" }
                });

            migrationBuilder.InsertData(
                table: "Consignors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 13, "44-948", "Jenkins LLC" },
                    { 12, "44-741", "Smitham LLC" },
                    { 11, "44-173", "Sporer Inc" },
                    { 10, "44-378", "Huels - Fritsch" },
                    { 9, "44-848", "Rippin, DuBuque and Goyette" },
                    { 8, "44-697", "Hammes - Collier" },
                    { 3, "YG42-890", "Whitehorse General Hospital" },
                    { 6, "44-452", "Rowe - Botsford" },
                    { 5, "44-041", "Whistle Bend Place" },
                    { 4, "YG81-153", "Teslin Health Centre" },
                    { 14, "44-695", "Reichert - Cummerata" },
                    { 2, "YG42-501", "Mayo Health Centre" },
                    { 1, "YG41-235", "Carmacks Health Clinic" },
                    { 7, "44-767", "Johnston Inc" },
                    { 15, "44-480", "Kassulke and Sons" }
                });

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 12, 4, "YT85921-0", 1, new DateTime(2021, 11, 15, 0, 1, 24, 657, DateTimeKind.Unspecified).AddTicks(3562), new DateTime(2021, 5, 11, 9, 34, 16, 156, DateTimeKind.Unspecified).AddTicks(4755) },
                    { 5, 3, "YT85624-8", 5, new DateTime(2021, 9, 13, 6, 52, 53, 729, DateTimeKind.Unspecified).AddTicks(2465), new DateTime(2021, 5, 26, 15, 51, 58, 655, DateTimeKind.Unspecified).AddTicks(5711) },
                    { 3, 1, "YT33847-5", 5, new DateTime(2021, 12, 30, 5, 51, 3, 878, DateTimeKind.Unspecified).AddTicks(9588), new DateTime(2021, 7, 22, 10, 48, 16, 63, DateTimeKind.Unspecified).AddTicks(6365) },
                    { 17, 2, "YT63536-8", 4, new DateTime(2021, 10, 27, 16, 34, 44, 260, DateTimeKind.Unspecified).AddTicks(4855), new DateTime(2021, 6, 28, 14, 56, 58, 560, DateTimeKind.Unspecified).AddTicks(5747) },
                    { 13, 2, "YT40039-6", 4, new DateTime(2021, 11, 11, 0, 26, 16, 62, DateTimeKind.Unspecified).AddTicks(2226), new DateTime(2021, 6, 9, 19, 49, 16, 796, DateTimeKind.Unspecified).AddTicks(922) },
                    { 11, 5, "YT00580-4", 4, new DateTime(2021, 9, 22, 5, 27, 28, 392, DateTimeKind.Unspecified).AddTicks(6507), new DateTime(2021, 8, 20, 9, 0, 18, 355, DateTimeKind.Unspecified).AddTicks(5381) },
                    { 8, 4, "YT06603-8", 4, new DateTime(2021, 12, 19, 7, 46, 21, 439, DateTimeKind.Unspecified).AddTicks(3889), new DateTime(2021, 8, 29, 12, 59, 51, 7, DateTimeKind.Unspecified).AddTicks(7015) },
                    { 7, 5, "YT51293-0", 4, new DateTime(2021, 10, 11, 10, 46, 7, 900, DateTimeKind.Unspecified).AddTicks(4611), new DateTime(2021, 8, 29, 4, 18, 53, 288, DateTimeKind.Unspecified).AddTicks(8780) },
                    { 2, 4, "YT57620-3", 4, new DateTime(2021, 9, 23, 4, 15, 58, 411, DateTimeKind.Unspecified).AddTicks(93), new DateTime(2021, 6, 24, 8, 17, 13, 611, DateTimeKind.Unspecified).AddTicks(3190) },
                    { 15, 4, "YT07867-8", 3, new DateTime(2021, 11, 29, 13, 56, 0, 761, DateTimeKind.Unspecified).AddTicks(3022), new DateTime(2021, 6, 6, 21, 46, 15, 887, DateTimeKind.Unspecified).AddTicks(6152) },
                    { 9, 4, "YT64058-7", 3, new DateTime(2021, 11, 18, 22, 18, 31, 563, DateTimeKind.Unspecified).AddTicks(6991), new DateTime(2021, 8, 8, 2, 0, 38, 364, DateTimeKind.Unspecified).AddTicks(7252) },
                    { 20, 3, "YT78307-6", 2, new DateTime(2021, 12, 21, 1, 15, 16, 760, DateTimeKind.Unspecified).AddTicks(4557), new DateTime(2021, 8, 30, 15, 43, 54, 746, DateTimeKind.Unspecified).AddTicks(8297) },
                    { 19, 4, "YT21059-9", 2, new DateTime(2021, 12, 3, 5, 22, 59, 385, DateTimeKind.Unspecified).AddTicks(3388), new DateTime(2021, 7, 19, 0, 41, 46, 450, DateTimeKind.Unspecified).AddTicks(9403) },
                    { 10, 4, "YT43837-7", 2, new DateTime(2021, 10, 19, 10, 32, 59, 995, DateTimeKind.Unspecified).AddTicks(9434), new DateTime(2021, 8, 13, 15, 41, 51, 527, DateTimeKind.Unspecified).AddTicks(1802) },
                    { 6, 5, "YT12820-6", 2, new DateTime(2021, 12, 2, 8, 42, 48, 230, DateTimeKind.Unspecified).AddTicks(7568), new DateTime(2021, 5, 29, 18, 28, 13, 496, DateTimeKind.Unspecified).AddTicks(6591) },
                    { 4, 1, "YT04982-6", 2, new DateTime(2021, 10, 11, 19, 0, 6, 128, DateTimeKind.Unspecified).AddTicks(6515), new DateTime(2021, 5, 23, 12, 6, 53, 548, DateTimeKind.Unspecified).AddTicks(6120) },
                    { 1, 5, "YT91393-5", 2, new DateTime(2021, 10, 18, 14, 58, 20, 446, DateTimeKind.Unspecified).AddTicks(1897), new DateTime(2021, 8, 21, 0, 5, 41, 812, DateTimeKind.Unspecified).AddTicks(2681) },
                    { 18, 3, "YT08255-6", 1, new DateTime(2021, 9, 14, 23, 19, 38, 15, DateTimeKind.Unspecified).AddTicks(7108), new DateTime(2021, 7, 11, 10, 0, 51, 964, DateTimeKind.Unspecified).AddTicks(4771) },
                    { 14, 2, "YT50858-6", 5, new DateTime(2021, 10, 24, 17, 9, 23, 220, DateTimeKind.Unspecified).AddTicks(5640), new DateTime(2021, 6, 30, 11, 48, 42, 32, DateTimeKind.Unspecified).AddTicks(8663) },
                    { 16, 1, "YT65629-0", 5, new DateTime(2021, 10, 24, 6, 20, 12, 716, DateTimeKind.Unspecified).AddTicks(3859), new DateTime(2021, 8, 18, 21, 0, 0, 631, DateTimeKind.Unspecified).AddTicks(4540) }
                });

            migrationBuilder.InsertData(
                table: "ConsigneeAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 15, "08798 Emard Inlet", null, "West Alexanne", null, "R5E 4I7", "AB" },
                    { 19, "144 Marcel Islands", null, "Hirthetown", null, "V0X 8Y6", "PE" },
                    { 3, "22582 Hand Track", null, "East Bernadette", null, "K9H 4A4", "NB" },
                    { 8, "9408 Rippin Valley", null, "Tevinstad", null, "K7R 9I5", "NS" },
                    { 1, "83063 Pauline Rest", null, "Krajcikstad", null, "E5K 9K6", "PE" },
                    { 13, "280 Wilderman Plaza", null, "Jaclynbury", null, "M1D 9O0", "NS" },
                    { 7, "007 Murazik Corner", null, "New Ceasar", null, "Y1H 7F5", "BC" },
                    { 5, "15121 Leonie Mountain", null, "Kuphalville", null, "V3A 0K6", "NL" },
                    { 17, "8501 Gillian Shore", null, "Leonieburgh", null, "C4S 9B6", "PE" },
                    { 16, "570 Zemlak Rest", null, "Kiaraport", null, "M7C 5L4", "NL" },
                    { 20, "6295 Federico Locks", null, "East Anika", null, "N3N 9X0", "AB" },
                    { 10, "238 Fadel Circles", null, "Christiansenmouth", null, "J2Y 2B8", "NT" },
                    { 14, "11768 Stanton Place", null, "East Miracle", null, "T9P 7M7", "NB" },
                    { 6, "11822 Shields Prairie", null, "Shanafurt", null, "L2V 6I7", "NT" },
                    { 2, "25188 Pagac Shore", null, "New Jada", null, "A2Z 2W1", "NU" },
                    { 12, "205 Larkin Junction", null, "West Jaronshire", null, "J6E 5O8", "NT" },
                    { 11, "98134 Hoppe Knoll", null, "New Elissachester", null, "V9J 7Y6", "PE" },
                    { 9, "350 Brakus Key", null, "Shaniaport", null, "R0H 6X7", "MB" },
                    { 18, "9439 Hegmann Spur", null, "Fishertown", null, "B7Z 7K4", "AB" },
                    { 4, "20979 Samir Turnpike", null, "Christopheland", null, "B2F 4V5", "MB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorAddresses",
                columns: new[] { "ManifestId", "AddressLine1", "AddressLine2", "City", "PhoneNumber", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 10, "37966 Jayme Squares", null, "Jeffreyburgh", null, "R8J 9X1", "ON" },
                    { 7, "88709 Kaitlin Extensions", null, "Lake Keenanville", null, "X6N 4T6", "AB" },
                    { 19, "3254 Marcus Ridge", null, "North Claude", null, "M7T 9H0", "ON" },
                    { 20, "147 Sipes Street", null, "South Octavia", null, "S7S 7T8", "NT" },
                    { 2, "927 Jaiden Plain", null, "West Jayceeborough", null, "Y8B 1Z2", "AB" },
                    { 15, "418 Laura Motorway", null, "Yadirabury", null, "Y0C 4W9", "ON" },
                    { 8, "965 Caleigh Pass", null, "Briaside", null, "P4L 1D2", "AB" },
                    { 11, "58139 Erick Camp", null, "Collinschester", null, "V8N 0Y7", "NU" },
                    { 6, "96563 Kertzmann Point", null, "Grantton", null, "B1B 4S9", "ON" },
                    { 9, "10786 Legros Shoals", null, "South Kaiatown", null, "H5O 0K6", "SK" },
                    { 12, "023 Suzanne Locks", null, "South Cale", null, "B2T 8E9", "NS" },
                    { 14, "98204 Kacey Tunnel", null, "Bayerchester", null, "N7I 7G4", "NS" },
                    { 5, "24449 Bosco Road", null, "Baileybury", null, "R1K 7Q8", "NS" },
                    { 18, "122 Hirthe Isle", null, "Port Lelandside", null, "R1X 2W9", "YT" },
                    { 3, "552 Mohammed Extension", null, "Gottliebfort", null, "L4C 5F3", "SK" },
                    { 1, "6980 Finn Mountain", null, "North Dedric", null, "T3Q 8B7", "BC" },
                    { 16, "2870 Lindgren Parkway", null, "Miltonburgh", null, "C7J 0A7", "PE" },
                    { 17, "70010 Orville Well", null, "Jermeyville", null, "K0P 5N2", "QC" },
                    { 4, "7450 Demetrius Trace", null, "Gloverbury", null, "C6Q 1B8", "ON" },
                    { 13, "78576 Keyshawn Park", null, "Schneiderborough", null, "A1W 0W1", "NB" }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 1, 8 },
                    { 3, 13 }
                });

            migrationBuilder.InsertData(
                table: "ConsignorManifest",
                columns: new[] { "ConsignorId", "ManifestId" },
                values: new object[,]
                {
                    { 14, 7 },
                    { 4, 11 },
                    { 1, 14 },
                    { 1, 17 },
                    { 4, 2 },
                    { 1, 16 },
                    { 6, 16 },
                    { 3, 3 },
                    { 2, 5 },
                    { 3, 7 },
                    { 4, 12 },
                    { 4, 6 },
                    { 1, 4 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 1 },
                    { 4, 18 },
                    { 1, 10 },
                    { 4, 15 },
                    { 4, 9 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 23, "Et ullam hic a excepturi autem.", 12, 13878m, "Gas", "L" },
                    { 17, "Velit velit amet animi cum.", 17, 11547m, "Liquid", "Kg" },
                    { 21, "Ea voluptas delectus qui omnis.", 17, 15940m, "Liquid", "L" },
                    { 32, "Maiores alias sit illum autem.", 17, 7810m, "Liquid", "Kg" },
                    { 54, "Ducimus dolores commodi possimus.", 17, 5561m, "Solid", "Kg" },
                    { 55, "Qui dolorum aut consequatur sed porro.", 4, 1074m, "Gas", "Kg" },
                    { 26, "Ea quo voluptate tempore.", 4, 8183m, "Solid", "L" },
                    { 4, "Eos autem rem quasi temporibus asperiores.", 4, 19041m, "Gas", "L" },
                    { 3, "Cumque aliquid rem tempora.", 3, 12118m, "Gas", "L" },
                    { 27, "Minus fugit sit in.", 3, 9081m, "Solid", "Kg" },
                    { 57, "Nam perferendis qui perferendis.", 16, 6420m, "Solid", "Kg" },
                    { 44, "Odio maiores voluptatem praesentium sit sit nisi.", 16, 3410m, "Gas", "L" },
                    { 30, "Sequi illo necessitatibus vero.", 1, 3268m, "Gas", "L" },
                    { 1, "Voluptatibus magni natus.", 1, 15773m, "Gas", "L" },
                    { 5, "Ut voluptas omnis.", 5, 19815m, "Gas", "L" },
                    { 6, "Velit consequuntur sunt dolorum accusamus sint.", 6, 4824m, "Liquid", "L" },
                    { 29, "Asperiores sint impedit.", 5, 8966m, "Gas", "L" },
                    { 34, "Accusamus ut aut quis necessitatibus.", 5, 16794m, "Solid", "Kg" },
                    { 12, "Harum aut aut sit eos eum aut.", 12, 12016m, "Solid", "Kg" },
                    { 47, "Dolores omnis est aliquid tempore voluptatem occaecati.", 18, 4048m, "Solid", "L" },
                    { 40, "Delectus tenetur voluptatum rerum ea inventore.", 18, 4969m, "Solid", "Kg" },
                    { 14, "Quidem doloremque dicta.", 14, 19767m, "Gas", "L" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ManifestId", "Quantity", "State", "Unit" },
                values: new object[,]
                {
                    { 36, "Eos labore aspernatur laudantium.", 14, 19509m, "Gas", "Kg" },
                    { 38, "Dolor blanditiis officia.", 14, 13715m, "Liquid", "Kg" },
                    { 18, "Repellendus perspiciatis voluptatem dicta.", 18, 2803m, "Liquid", "Kg" },
                    { 16, "Fugiat optio expedita voluptas minus commodi debitis.", 16, 17555m, "Gas", "L" },
                    { 25, "Nam eum vel accusantium rerum delectus.", 5, 11865m, "Gas", "Kg" },
                    { 28, "Est molestias aut quam quo.", 13, 7812m, "Solid", "L" },
                    { 15, "Sit vel rem odit.", 15, 19871m, "Gas", "L" },
                    { 56, "Pariatur maiores aliquam culpa voluptate.", 9, 18098m, "Liquid", "L" },
                    { 42, "Ipsam atque molestiae voluptatem sed at consequatur.", 9, 13843m, "Solid", "Kg" },
                    { 2, "Voluptas quis enim et voluptatem quidem.", 2, 4694m, "Gas", "Kg" },
                    { 49, "Dolor inventore molestiae placeat.", 2, 10169m, "Liquid", "L" },
                    { 9, "Corporis ea dolor non eligendi laudantium impedit.", 9, 12627m, "Gas", "Kg" },
                    { 60, "Aliquid quis molestias et ab ut.", 20, 1289m, "Solid", "L" },
                    { 53, "Libero dolorem ducimus.", 20, 17054m, "Liquid", "Kg" },
                    { 7, "Qui facilis illum.", 7, 7537m, "Liquid", "Kg" },
                    { 48, "Saepe impedit odit quam.", 7, 722m, "Liquid", "L" },
                    { 51, "Ipsum tempora velit consequuntur omnis consequatur voluptatibus.", 7, 6362m, "Solid", "L" },
                    { 58, "Nemo aut magnam voluptatibus.", 7, 8690m, "Liquid", "L" },
                    { 50, "Aperiam ipsum blanditiis dolor quo ut fugit.", 20, 11804m, "Gas", "Kg" },
                    { 33, "Nam et sequi.", 20, 4489m, "Liquid", "L" },
                    { 20, "Repellendus quos qui.", 20, 15154m, "Liquid", "Kg" },
                    { 8, "Reiciendis maxime enim.", 8, 15409m, "Liquid", "L" },
                    { 39, "Id ut voluptate reiciendis ea dolorem omnis.", 8, 8239m, "Gas", "Kg" },
                    { 45, "Molestiae expedita non ipsa aut earum.", 8, 1819m, "Solid", "L" },
                    { 52, "Dolorum ipsam porro voluptatem.", 8, 12072m, "Gas", "Kg" },
                    { 19, "Consequuntur non rem quo assumenda.", 19, 2227m, "Liquid", "Kg" },
                    { 11, "Aliquam earum et velit.", 11, 8230m, "Gas", "L" },
                    { 22, "Dicta quis cum sunt cumque dolore et.", 11, 9065m, "Gas", "L" },
                    { 31, "Et velit similique pariatur at.", 11, 14984m, "Solid", "L" },
                    { 37, "Aut quaerat ut aspernatur necessitatibus a quia.", 11, 13002m, "Solid", "Kg" },
                    { 41, "Modi harum ut.", 11, 19194m, "Gas", "L" },
                    { 59, "Odit qui voluptas tenetur animi.", 10, 5771m, "Gas", "Kg" },
                    { 46, "Sunt aperiam et tempore porro dicta id.", 10, 16060m, "Gas", "L" },
                    { 10, "Nobis deleniti ipsa.", 10, 19824m, "Liquid", "L" },
                    { 13, "Doloremque maiores et laboriosam.", 13, 16448m, "Liquid", "L" },
                    { 24, "Natus est ullam.", 13, 10425m, "Liquid", "Kg" },
                    { 43, "Minus omnis sint ratione.", 13, 4465m, "Solid", "L" },
                    { 35, "Eos ipsum accusantium.", 15, 18566m, "Solid", "Kg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsignorManifest_ConsignorId",
                table: "ConsignorManifest",
                column: "ConsignorId");

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
