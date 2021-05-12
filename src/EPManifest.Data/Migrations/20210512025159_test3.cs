using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Consignors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A1 Delivery" },
                    { 2, "Frank's Shipping" },
                    { 3, "Whitehorse General Hospital" }
                });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(1249) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 46, 14, 817, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 46, 14, 819, DateTimeKind.Local).AddTicks(3764));
        }
    }
}
