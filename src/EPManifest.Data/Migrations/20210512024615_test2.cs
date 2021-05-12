using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 817, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.InsertData(
                table: "Manifests",
                columns: new[] { "Id", "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[,]
                {
                    { 2, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3517) },
                    { 3, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3602) },
                    { 4, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3619) },
                    { 5, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3635) },
                    { 6, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3655) },
                    { 7, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3671) },
                    { 8, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3686) },
                    { 9, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3701) },
                    { 10, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3718) },
                    { 11, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3733) },
                    { 12, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3749) },
                    { 13, null, null, null, null, new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3764) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 26, 12, 920, DateTimeKind.Local).AddTicks(756));
        }
    }
}
