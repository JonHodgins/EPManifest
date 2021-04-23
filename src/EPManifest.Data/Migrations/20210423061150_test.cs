using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyManifest");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.AddColumn<int>(
                name: "CarrierId",
                table: "Manifests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConsigneeId",
                table: "Manifests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConsignorId",
                table: "Manifests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Carriers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consignors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetNumber = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsignorId = table.Column<int>(type: "int", nullable: true),
                    ConsigneeId = table.Column<int>(type: "int", nullable: true),
                    CarrierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Carriers_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Consignees_ConsigneeId",
                        column: x => x.ConsigneeId,
                        principalTable: "Consignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Consignors_ConsignorId",
                        column: x => x.ConsignorId,
                        principalTable: "Consignors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CarrierId",
                table: "Addresses",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ConsigneeId",
                table: "Addresses",
                column: "ConsigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ConsignorId",
                table: "Addresses",
                column: "ConsignorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Manifests_Carriers_CarrierId",
                table: "Manifests",
                column: "CarrierId",
                principalTable: "Carriers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manifests_Consignees_ConsigneeId",
                table: "Manifests",
                column: "ConsigneeId",
                principalTable: "Consignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manifests_Consignors_ConsignorId",
                table: "Manifests",
                column: "ConsignorId",
                principalTable: "Consignors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manifests_Carriers_CarrierId",
                table: "Manifests");

            migrationBuilder.DropForeignKey(
                name: "FK_Manifests_Consignees_ConsigneeId",
                table: "Manifests");

            migrationBuilder.DropForeignKey(
                name: "FK_Manifests_Consignors_ConsignorId",
                table: "Manifests");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropTable(
                name: "Consignees");

            migrationBuilder.DropTable(
                name: "Consignors");

            migrationBuilder.DropIndex(
                name: "IX_Manifests_CarrierId",
                table: "Manifests");

            migrationBuilder.DropIndex(
                name: "IX_Manifests_ConsigneeId",
                table: "Manifests");

            migrationBuilder.DropIndex(
                name: "IX_Manifests_ConsignorId",
                table: "Manifests");

            migrationBuilder.DropColumn(
                name: "CarrierId",
                table: "Manifests");

            migrationBuilder.DropColumn(
                name: "ConsigneeId",
                table: "Manifests");

            migrationBuilder.DropColumn(
                name: "ConsignorId",
                table: "Manifests");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyManifest",
                columns: table => new
                {
                    CompaniesId = table.Column<int>(type: "int", nullable: false),
                    ManifestsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyManifest", x => new { x.CompaniesId, x.ManifestsId });
                    table.ForeignKey(
                        name: "FK_CompanyManifest_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyManifest_Manifests_ManifestsId",
                        column: x => x.ManifestsId,
                        principalTable: "Manifests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyManifest_ManifestsId",
                table: "CompanyManifest",
                column: "ManifestsId");
        }
    }
}
