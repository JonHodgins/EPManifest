using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 53, 36, 442, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 5, 11, 19, 53, 36, 443, DateTimeKind.Local).AddTicks(4583) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateShipped",
                value: new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConsignorId", "DateShipped" },
                values: new object[] { null, new DateTime(2021, 5, 11, 19, 51, 58, 529, DateTimeKind.Local).AddTicks(9931) });
        }
    }
}
