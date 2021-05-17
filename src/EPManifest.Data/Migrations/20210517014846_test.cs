using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ConsignorId",
                table: "Manifests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConsigneeId",
                table: "Manifests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarrierId",
                table: "Manifests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 11, 20, 7, 37, 19, 546, DateTimeKind.Unspecified).AddTicks(93), new DateTime(2021, 7, 28, 21, 6, 35, 778, DateTimeKind.Unspecified).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, 2, new DateTime(2021, 12, 30, 23, 5, 38, 489, DateTimeKind.Unspecified).AddTicks(5861), new DateTime(2021, 6, 13, 17, 26, 56, 756, DateTimeKind.Unspecified).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 2, 4, new DateTime(2021, 10, 18, 2, 53, 10, 50, DateTimeKind.Unspecified).AddTicks(9510), new DateTime(2021, 8, 1, 9, 51, 50, 337, DateTimeKind.Unspecified).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, new DateTime(2021, 9, 8, 10, 15, 35, 425, DateTimeKind.Unspecified).AddTicks(245), new DateTime(2021, 5, 8, 13, 29, 50, 426, DateTimeKind.Unspecified).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, new DateTime(2021, 12, 4, 6, 40, 57, 833, DateTimeKind.Unspecified).AddTicks(1895), new DateTime(2021, 5, 22, 9, 55, 46, 230, DateTimeKind.Unspecified).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 5, new DateTime(2021, 12, 30, 23, 58, 20, 123, DateTimeKind.Unspecified).AddTicks(8167), new DateTime(2021, 7, 12, 17, 25, 49, 897, DateTimeKind.Unspecified).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 4, new DateTime(2021, 11, 22, 5, 14, 52, 258, DateTimeKind.Unspecified).AddTicks(1478), new DateTime(2021, 6, 15, 6, 14, 31, 21, DateTimeKind.Unspecified).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, new DateTime(2021, 11, 28, 13, 46, 4, 555, DateTimeKind.Unspecified).AddTicks(2821), new DateTime(2021, 7, 3, 14, 15, 41, 665, DateTimeKind.Unspecified).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, new DateTime(2021, 11, 21, 4, 20, 48, 534, DateTimeKind.Unspecified).AddTicks(8834), new DateTime(2021, 8, 18, 7, 6, 20, 247, DateTimeKind.Unspecified).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, 1, new DateTime(2021, 10, 22, 10, 50, 52, 758, DateTimeKind.Unspecified).AddTicks(4213), new DateTime(2021, 8, 5, 15, 5, 24, 978, DateTimeKind.Unspecified).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 3, 2, new DateTime(2021, 10, 31, 23, 13, 18, 102, DateTimeKind.Unspecified).AddTicks(7441), new DateTime(2021, 7, 8, 3, 42, 55, 672, DateTimeKind.Unspecified).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 1, new DateTime(2021, 12, 6, 7, 28, 39, 972, DateTimeKind.Unspecified).AddTicks(8868), new DateTime(2021, 8, 23, 6, 37, 34, 862, DateTimeKind.Unspecified).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, new DateTime(2021, 9, 26, 8, 29, 59, 230, DateTimeKind.Unspecified).AddTicks(3007), new DateTime(2021, 6, 13, 17, 28, 31, 680, DateTimeKind.Unspecified).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 4, new DateTime(2021, 9, 7, 15, 7, 6, 603, DateTimeKind.Unspecified).AddTicks(222), new DateTime(2021, 5, 15, 6, 27, 47, 282, DateTimeKind.Unspecified).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 4, 4, new DateTime(2021, 11, 3, 1, 0, 2, 838, DateTimeKind.Unspecified).AddTicks(3957), new DateTime(2021, 6, 8, 9, 8, 21, 799, DateTimeKind.Unspecified).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, new DateTime(2021, 12, 1, 8, 42, 45, 65, DateTimeKind.Unspecified).AddTicks(1333), new DateTime(2021, 6, 29, 6, 11, 41, 754, DateTimeKind.Unspecified).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 1, new DateTime(2021, 12, 4, 9, 52, 55, 154, DateTimeKind.Unspecified).AddTicks(8724), new DateTime(2021, 5, 24, 19, 48, 52, 812, DateTimeKind.Unspecified).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, new DateTime(2021, 11, 5, 22, 21, 47, 443, DateTimeKind.Unspecified).AddTicks(7069), new DateTime(2021, 8, 11, 7, 34, 36, 130, DateTimeKind.Unspecified).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 2, new DateTime(2021, 10, 8, 6, 11, 48, 821, DateTimeKind.Unspecified).AddTicks(5127), new DateTime(2021, 7, 27, 1, 24, 9, 129, DateTimeKind.Unspecified).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, new DateTime(2021, 12, 25, 22, 20, 35, 220, DateTimeKind.Unspecified).AddTicks(391), new DateTime(2021, 7, 25, 4, 46, 45, 772, DateTimeKind.Unspecified).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, 3, new DateTime(2021, 11, 27, 18, 32, 43, 110, DateTimeKind.Unspecified).AddTicks(831), new DateTime(2021, 7, 30, 7, 51, 43, 0, DateTimeKind.Unspecified).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 3, new DateTime(2021, 9, 6, 11, 0, 52, 82, DateTimeKind.Unspecified).AddTicks(8715), new DateTime(2021, 5, 9, 5, 44, 22, 230, DateTimeKind.Unspecified).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, new DateTime(2021, 11, 22, 11, 58, 36, 297, DateTimeKind.Unspecified).AddTicks(5572), new DateTime(2021, 5, 28, 10, 38, 36, 164, DateTimeKind.Unspecified).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, new DateTime(2021, 12, 19, 13, 25, 15, 477, DateTimeKind.Unspecified).AddTicks(6873), new DateTime(2021, 7, 8, 23, 57, 4, 549, DateTimeKind.Unspecified).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, new DateTime(2021, 11, 29, 14, 0, 12, 603, DateTimeKind.Unspecified).AddTicks(5091), new DateTime(2021, 7, 6, 14, 33, 51, 281, DateTimeKind.Unspecified).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, new DateTime(2021, 12, 11, 14, 12, 54, 649, DateTimeKind.Unspecified).AddTicks(5068), new DateTime(2021, 8, 26, 23, 16, 58, 209, DateTimeKind.Unspecified).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, new DateTime(2021, 10, 5, 21, 31, 53, 41, DateTimeKind.Unspecified).AddTicks(2388), new DateTime(2021, 7, 4, 1, 49, 9, 273, DateTimeKind.Unspecified).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 4, 4, new DateTime(2021, 9, 28, 17, 6, 29, 104, DateTimeKind.Unspecified).AddTicks(7914), new DateTime(2021, 6, 25, 9, 43, 34, 154, DateTimeKind.Unspecified).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, 1, new DateTime(2021, 12, 1, 3, 31, 44, 274, DateTimeKind.Unspecified).AddTicks(2073), new DateTime(2021, 8, 6, 3, 3, 31, 753, DateTimeKind.Unspecified).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, 5, new DateTime(2021, 9, 22, 16, 59, 52, 269, DateTimeKind.Unspecified).AddTicks(8485), new DateTime(2021, 5, 9, 15, 36, 23, 227, DateTimeKind.Unspecified).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 12, 2, 8, 26, 48, 789, DateTimeKind.Unspecified).AddTicks(4507), new DateTime(2021, 8, 5, 1, 44, 34, 533, DateTimeKind.Unspecified).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 2, new DateTime(2021, 11, 22, 6, 50, 18, 766, DateTimeKind.Unspecified).AddTicks(9004), new DateTime(2021, 8, 29, 4, 28, 12, 674, DateTimeKind.Unspecified).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, new DateTime(2021, 9, 11, 17, 53, 57, 871, DateTimeKind.Unspecified).AddTicks(3967), new DateTime(2021, 5, 27, 16, 25, 39, 216, DateTimeKind.Unspecified).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 9, 6, 4, 22, 26, 59, DateTimeKind.Unspecified).AddTicks(2388), new DateTime(2021, 8, 18, 6, 38, 32, 860, DateTimeKind.Unspecified).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, 3, new DateTime(2021, 12, 16, 1, 55, 11, 484, DateTimeKind.Unspecified).AddTicks(6232), new DateTime(2021, 6, 12, 15, 49, 25, 483, DateTimeKind.Unspecified).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, new DateTime(2021, 12, 15, 18, 11, 47, 505, DateTimeKind.Unspecified).AddTicks(2253), new DateTime(2021, 8, 3, 23, 30, 28, 46, DateTimeKind.Unspecified).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, 3, new DateTime(2021, 12, 27, 16, 48, 12, 929, DateTimeKind.Unspecified).AddTicks(1232), new DateTime(2021, 8, 6, 8, 7, 10, 514, DateTimeKind.Unspecified).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 9, 10, 13, 30, 47, 132, DateTimeKind.Unspecified).AddTicks(140), new DateTime(2021, 7, 31, 7, 16, 43, 729, DateTimeKind.Unspecified).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, new DateTime(2021, 10, 8, 22, 39, 21, 564, DateTimeKind.Unspecified).AddTicks(8456), new DateTime(2021, 8, 1, 4, 48, 48, 549, DateTimeKind.Unspecified).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, new DateTime(2021, 12, 16, 16, 1, 21, 519, DateTimeKind.Unspecified).AddTicks(1850), new DateTime(2021, 7, 26, 21, 56, 52, 124, DateTimeKind.Unspecified).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, new DateTime(2021, 11, 28, 6, 43, 58, 708, DateTimeKind.Unspecified).AddTicks(6519), new DateTime(2021, 8, 27, 17, 23, 59, 451, DateTimeKind.Unspecified).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, 2, new DateTime(2021, 12, 21, 15, 45, 42, 204, DateTimeKind.Unspecified).AddTicks(6255), new DateTime(2021, 8, 19, 6, 4, 1, 303, DateTimeKind.Unspecified).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, new DateTime(2021, 9, 17, 0, 0, 11, 56, DateTimeKind.Unspecified).AddTicks(8300), new DateTime(2021, 5, 20, 16, 8, 4, 715, DateTimeKind.Unspecified).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, 1, new DateTime(2021, 10, 6, 17, 53, 25, 369, DateTimeKind.Unspecified).AddTicks(3401), new DateTime(2021, 5, 30, 19, 41, 48, 747, DateTimeKind.Unspecified).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, new DateTime(2021, 10, 22, 22, 51, 9, 508, DateTimeKind.Unspecified).AddTicks(1394), new DateTime(2021, 8, 9, 4, 30, 36, 660, DateTimeKind.Unspecified).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 5, new DateTime(2021, 11, 13, 15, 42, 30, 153, DateTimeKind.Unspecified).AddTicks(5247), new DateTime(2021, 8, 30, 14, 19, 27, 301, DateTimeKind.Unspecified).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 4, new DateTime(2021, 11, 8, 5, 3, 4, 660, DateTimeKind.Unspecified).AddTicks(4968), new DateTime(2021, 8, 17, 14, 25, 42, 304, DateTimeKind.Unspecified).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 4, new DateTime(2021, 11, 12, 15, 52, 8, 992, DateTimeKind.Unspecified).AddTicks(671), new DateTime(2021, 5, 14, 10, 26, 51, 907, DateTimeKind.Unspecified).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, 3, new DateTime(2021, 12, 11, 8, 19, 20, 794, DateTimeKind.Unspecified).AddTicks(3347), new DateTime(2021, 8, 9, 4, 23, 52, 212, DateTimeKind.Unspecified).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, 2, new DateTime(2021, 9, 22, 15, 46, 23, 916, DateTimeKind.Unspecified).AddTicks(4089), new DateTime(2021, 7, 16, 23, 51, 6, 801, DateTimeKind.Unspecified).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, 1, new DateTime(2021, 9, 6, 12, 42, 18, 561, DateTimeKind.Unspecified).AddTicks(6292), new DateTime(2021, 6, 22, 22, 35, 50, 822, DateTimeKind.Unspecified).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 5, 5, new DateTime(2021, 12, 14, 1, 10, 0, 512, DateTimeKind.Unspecified).AddTicks(5632), new DateTime(2021, 7, 9, 8, 22, 28, 596, DateTimeKind.Unspecified).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, 2, new DateTime(2021, 9, 29, 19, 37, 40, 629, DateTimeKind.Unspecified).AddTicks(6406), new DateTime(2021, 6, 10, 6, 0, 49, 9, DateTimeKind.Unspecified).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, new DateTime(2021, 10, 21, 23, 36, 8, 369, DateTimeKind.Unspecified).AddTicks(1003), new DateTime(2021, 7, 9, 20, 15, 34, 4, DateTimeKind.Unspecified).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 2, new DateTime(2021, 11, 30, 7, 20, 21, 110, DateTimeKind.Unspecified).AddTicks(120), new DateTime(2021, 7, 15, 18, 18, 2, 19, DateTimeKind.Unspecified).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 2, new DateTime(2021, 9, 22, 5, 30, 37, 522, DateTimeKind.Unspecified).AddTicks(5845), new DateTime(2021, 8, 27, 20, 47, 55, 575, DateTimeKind.Unspecified).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 4, new DateTime(2021, 11, 12, 18, 10, 16, 738, DateTimeKind.Unspecified).AddTicks(7894), new DateTime(2021, 8, 10, 0, 19, 29, 364, DateTimeKind.Unspecified).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, new DateTime(2021, 11, 23, 17, 11, 55, 843, DateTimeKind.Unspecified).AddTicks(4739), new DateTime(2021, 8, 12, 8, 18, 13, 258, DateTimeKind.Unspecified).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 10, 17, 20, 42, 50, 793, DateTimeKind.Unspecified).AddTicks(7081), new DateTime(2021, 5, 30, 13, 6, 26, 626, DateTimeKind.Unspecified).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 3, new DateTime(2021, 10, 24, 22, 42, 0, 921, DateTimeKind.Unspecified).AddTicks(9374), new DateTime(2021, 7, 12, 19, 3, 55, 746, DateTimeKind.Unspecified).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, 5, new DateTime(2021, 12, 14, 0, 25, 6, 289, DateTimeKind.Unspecified).AddTicks(7183), new DateTime(2021, 5, 29, 12, 55, 26, 616, DateTimeKind.Unspecified).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, new DateTime(2021, 11, 21, 6, 54, 46, 293, DateTimeKind.Unspecified).AddTicks(1904), new DateTime(2021, 7, 22, 2, 43, 46, 627, DateTimeKind.Unspecified).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, 4, new DateTime(2021, 9, 29, 15, 44, 14, 348, DateTimeKind.Unspecified).AddTicks(2925), new DateTime(2021, 6, 19, 4, 7, 45, 1, DateTimeKind.Unspecified).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 10, 6, 20, 37, 29, 161, DateTimeKind.Unspecified).AddTicks(2944), new DateTime(2021, 7, 26, 2, 25, 45, 497, DateTimeKind.Unspecified).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, new DateTime(2021, 11, 15, 0, 2, 27, 364, DateTimeKind.Unspecified).AddTicks(7610), new DateTime(2021, 8, 14, 6, 41, 25, 62, DateTimeKind.Unspecified).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, new DateTime(2021, 10, 2, 22, 5, 49, 492, DateTimeKind.Unspecified).AddTicks(1131), new DateTime(2021, 6, 1, 5, 21, 26, 636, DateTimeKind.Unspecified).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, new DateTime(2021, 10, 8, 12, 27, 33, 737, DateTimeKind.Unspecified).AddTicks(6210), new DateTime(2021, 7, 7, 14, 17, 54, 698, DateTimeKind.Unspecified).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, new DateTime(2021, 10, 10, 9, 59, 32, 787, DateTimeKind.Unspecified).AddTicks(5579), new DateTime(2021, 8, 26, 3, 41, 44, 709, DateTimeKind.Unspecified).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 9, 5, 16, 37, 39, 765, DateTimeKind.Unspecified).AddTicks(5083), new DateTime(2021, 5, 27, 2, 7, 49, 95, DateTimeKind.Unspecified).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 9, 14, 0, 38, 35, 424, DateTimeKind.Unspecified).AddTicks(7384), new DateTime(2021, 8, 26, 7, 28, 21, 915, DateTimeKind.Unspecified).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, 5, new DateTime(2021, 12, 29, 1, 39, 34, 916, DateTimeKind.Unspecified).AddTicks(2970), new DateTime(2021, 6, 8, 17, 6, 58, 774, DateTimeKind.Unspecified).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, 1, new DateTime(2021, 9, 25, 5, 44, 50, 431, DateTimeKind.Unspecified).AddTicks(8593), new DateTime(2021, 7, 12, 6, 8, 28, 872, DateTimeKind.Unspecified).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 3, new DateTime(2021, 9, 23, 1, 48, 5, 549, DateTimeKind.Unspecified).AddTicks(3352), new DateTime(2021, 6, 21, 18, 37, 14, 961, DateTimeKind.Unspecified).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 10, 20, 15, 31, 59, 655, DateTimeKind.Unspecified).AddTicks(4355), new DateTime(2021, 5, 14, 12, 19, 14, 424, DateTimeKind.Unspecified).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, 1, new DateTime(2021, 11, 29, 13, 50, 14, 120, DateTimeKind.Unspecified).AddTicks(4544), new DateTime(2021, 6, 18, 15, 20, 44, 87, DateTimeKind.Unspecified).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 11, 13, 20, 48, 10, 772, DateTimeKind.Unspecified).AddTicks(572), new DateTime(2021, 8, 9, 19, 38, 50, 740, DateTimeKind.Unspecified).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, 1, new DateTime(2021, 10, 4, 17, 30, 41, 722, DateTimeKind.Unspecified).AddTicks(9037), new DateTime(2021, 5, 19, 20, 13, 1, 894, DateTimeKind.Unspecified).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, 2, new DateTime(2021, 10, 2, 15, 56, 9, 175, DateTimeKind.Unspecified).AddTicks(6769), new DateTime(2021, 7, 9, 10, 20, 27, 464, DateTimeKind.Unspecified).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, 4, new DateTime(2021, 12, 6, 6, 18, 6, 631, DateTimeKind.Unspecified).AddTicks(5739), new DateTime(2021, 8, 3, 2, 47, 43, 389, DateTimeKind.Unspecified).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 11, 21, 12, 58, 31, 921, DateTimeKind.Unspecified).AddTicks(6287), new DateTime(2021, 8, 29, 2, 35, 59, 689, DateTimeKind.Unspecified).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateScheduledArrival", "DateShipped" },
                values: new object[] { new DateTime(2021, 9, 10, 23, 54, 44, 450, DateTimeKind.Unspecified).AddTicks(6754), new DateTime(2021, 7, 10, 3, 1, 25, 714, DateTimeKind.Unspecified).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, new DateTime(2021, 9, 16, 18, 37, 1, 694, DateTimeKind.Unspecified).AddTicks(5588), new DateTime(2021, 7, 8, 13, 52, 57, 255, DateTimeKind.Unspecified).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, 1, new DateTime(2021, 9, 3, 5, 47, 28, 912, DateTimeKind.Unspecified).AddTicks(4321), new DateTime(2021, 8, 26, 1, 14, 45, 411, DateTimeKind.Unspecified).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 3, new DateTime(2021, 12, 8, 22, 34, 23, 192, DateTimeKind.Unspecified).AddTicks(9374), new DateTime(2021, 5, 20, 17, 15, 1, 92, DateTimeKind.Unspecified).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 5, 2, new DateTime(2021, 12, 2, 22, 35, 20, 84, DateTimeKind.Unspecified).AddTicks(8437), new DateTime(2021, 8, 7, 10, 4, 3, 223, DateTimeKind.Unspecified).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 3, new DateTime(2021, 10, 20, 11, 41, 22, 539, DateTimeKind.Unspecified).AddTicks(4946), new DateTime(2021, 7, 12, 3, 36, 14, 974, DateTimeKind.Unspecified).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, new DateTime(2021, 12, 12, 14, 49, 26, 756, DateTimeKind.Unspecified).AddTicks(7889), new DateTime(2021, 5, 24, 7, 42, 43, 211, DateTimeKind.Unspecified).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, 2, new DateTime(2021, 10, 20, 12, 49, 27, 449, DateTimeKind.Unspecified).AddTicks(1039), new DateTime(2021, 5, 10, 8, 12, 4, 771, DateTimeKind.Unspecified).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 1, new DateTime(2021, 9, 14, 12, 57, 41, 136, DateTimeKind.Unspecified).AddTicks(5491), new DateTime(2021, 6, 24, 10, 29, 53, 622, DateTimeKind.Unspecified).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 10, 18, 7, 9, 55, 864, DateTimeKind.Unspecified).AddTicks(6000), new DateTime(2021, 7, 31, 23, 40, 16, 902, DateTimeKind.Unspecified).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 3, 2, new DateTime(2021, 10, 13, 21, 21, 27, 851, DateTimeKind.Unspecified).AddTicks(7509), new DateTime(2021, 5, 27, 1, 46, 27, 233, DateTimeKind.Unspecified).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, new DateTime(2021, 10, 30, 0, 31, 48, 68, DateTimeKind.Unspecified).AddTicks(3881), new DateTime(2021, 8, 5, 19, 2, 33, 401, DateTimeKind.Unspecified).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, 3, new DateTime(2021, 12, 3, 14, 40, 40, 895, DateTimeKind.Unspecified).AddTicks(8309), new DateTime(2021, 5, 22, 13, 5, 12, 32, DateTimeKind.Unspecified).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, 4, new DateTime(2021, 11, 19, 16, 45, 24, 201, DateTimeKind.Unspecified).AddTicks(6134), new DateTime(2021, 5, 20, 12, 32, 43, 287, DateTimeKind.Unspecified).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, new DateTime(2021, 12, 3, 20, 3, 25, 824, DateTimeKind.Unspecified).AddTicks(5593), new DateTime(2021, 7, 27, 15, 22, 33, 516, DateTimeKind.Unspecified).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, new DateTime(2021, 12, 14, 12, 58, 17, 205, DateTimeKind.Unspecified).AddTicks(4341), new DateTime(2021, 7, 25, 13, 13, 11, 730, DateTimeKind.Unspecified).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, 1, new DateTime(2021, 9, 13, 4, 12, 27, 814, DateTimeKind.Unspecified).AddTicks(22), new DateTime(2021, 5, 28, 4, 43, 40, 227, DateTimeKind.Unspecified).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, new DateTime(2021, 9, 8, 15, 51, 59, 761, DateTimeKind.Unspecified).AddTicks(167), new DateTime(2021, 8, 6, 13, 23, 48, 476, DateTimeKind.Unspecified).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, 4, new DateTime(2021, 12, 11, 19, 7, 47, 392, DateTimeKind.Unspecified).AddTicks(1325), new DateTime(2021, 7, 8, 5, 54, 44, 871, DateTimeKind.Unspecified).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, 4, new DateTime(2021, 10, 11, 3, 14, 43, 705, DateTimeKind.Unspecified).AddTicks(2906), new DateTime(2021, 7, 20, 11, 13, 32, 605, DateTimeKind.Unspecified).AddTicks(7634) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ConsignorId",
                table: "Manifests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ConsigneeId",
                table: "Manifests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarrierId",
                table: "Manifests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, new DateTime(2021, 11, 19, 9, 5, 12, 969, DateTimeKind.Unspecified).AddTicks(2290), new DateTime(2021, 8, 18, 4, 32, 10, 633, DateTimeKind.Unspecified).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, 5, new DateTime(2021, 10, 22, 6, 43, 36, 608, DateTimeKind.Unspecified).AddTicks(275), new DateTime(2021, 6, 10, 18, 13, 50, 285, DateTimeKind.Unspecified).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 5, 3, new DateTime(2021, 11, 25, 15, 12, 12, 438, DateTimeKind.Unspecified).AddTicks(161), new DateTime(2021, 6, 15, 14, 0, 18, 886, DateTimeKind.Unspecified).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 3, new DateTime(2021, 11, 2, 10, 8, 52, 865, DateTimeKind.Unspecified).AddTicks(7112), new DateTime(2021, 8, 4, 6, 3, 16, 140, DateTimeKind.Unspecified).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 2, new DateTime(2021, 10, 26, 1, 35, 27, 139, DateTimeKind.Unspecified).AddTicks(4071), new DateTime(2021, 6, 25, 21, 20, 42, 414, DateTimeKind.Unspecified).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, 1, new DateTime(2021, 9, 8, 7, 40, 15, 418, DateTimeKind.Unspecified).AddTicks(3203), new DateTime(2021, 7, 19, 12, 5, 50, 114, DateTimeKind.Unspecified).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, 5, new DateTime(2021, 11, 20, 10, 13, 38, 5, DateTimeKind.Unspecified).AddTicks(3033), new DateTime(2021, 8, 22, 10, 11, 29, 203, DateTimeKind.Unspecified).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 11, 24, 0, 58, 26, 148, DateTimeKind.Unspecified).AddTicks(7170), new DateTime(2021, 7, 21, 3, 11, 25, 97, DateTimeKind.Unspecified).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, new DateTime(2021, 9, 1, 2, 58, 53, 598, DateTimeKind.Unspecified).AddTicks(3937), new DateTime(2021, 8, 17, 5, 13, 58, 409, DateTimeKind.Unspecified).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 5, new DateTime(2021, 12, 14, 10, 12, 26, 93, DateTimeKind.Unspecified).AddTicks(8044), new DateTime(2021, 8, 5, 10, 38, 42, 862, DateTimeKind.Unspecified).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, 3, new DateTime(2021, 9, 14, 0, 12, 30, 329, DateTimeKind.Unspecified).AddTicks(5053), new DateTime(2021, 6, 11, 16, 45, 4, 263, DateTimeKind.Unspecified).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, 3, new DateTime(2021, 11, 2, 5, 51, 11, 213, DateTimeKind.Unspecified).AddTicks(7007), new DateTime(2021, 6, 26, 20, 28, 43, 847, DateTimeKind.Unspecified).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 11, 1, 1, 1, 2, 203, DateTimeKind.Unspecified).AddTicks(6340), new DateTime(2021, 6, 3, 19, 16, 14, 309, DateTimeKind.Unspecified).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, new DateTime(2021, 10, 23, 21, 53, 40, 850, DateTimeKind.Unspecified).AddTicks(4403), new DateTime(2021, 7, 24, 3, 29, 30, 368, DateTimeKind.Unspecified).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 3, new DateTime(2021, 12, 4, 10, 44, 14, 521, DateTimeKind.Unspecified).AddTicks(2330), new DateTime(2021, 5, 16, 9, 5, 44, 841, DateTimeKind.Unspecified).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, new DateTime(2021, 11, 16, 4, 38, 36, 48, DateTimeKind.Unspecified).AddTicks(8683), new DateTime(2021, 6, 25, 18, 30, 41, 60, DateTimeKind.Unspecified).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 3, 2, new DateTime(2021, 10, 30, 12, 26, 50, 482, DateTimeKind.Unspecified).AddTicks(6957), new DateTime(2021, 8, 4, 6, 9, 53, 83, DateTimeKind.Unspecified).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, new DateTime(2021, 9, 14, 0, 25, 21, 974, DateTimeKind.Unspecified).AddTicks(7670), new DateTime(2021, 8, 10, 1, 27, 51, 948, DateTimeKind.Unspecified).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, new DateTime(2021, 9, 20, 4, 11, 40, 966, DateTimeKind.Unspecified).AddTicks(4993), new DateTime(2021, 5, 22, 23, 24, 45, 183, DateTimeKind.Unspecified).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, new DateTime(2021, 11, 5, 0, 55, 56, 660, DateTimeKind.Unspecified).AddTicks(4913), new DateTime(2021, 6, 20, 4, 51, 39, 951, DateTimeKind.Unspecified).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, 2, new DateTime(2021, 10, 16, 16, 0, 40, 766, DateTimeKind.Unspecified).AddTicks(7607), new DateTime(2021, 6, 16, 3, 43, 13, 955, DateTimeKind.Unspecified).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, 4, new DateTime(2021, 10, 8, 19, 52, 25, 228, DateTimeKind.Unspecified).AddTicks(9467), new DateTime(2021, 7, 6, 22, 24, 50, 462, DateTimeKind.Unspecified).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 10, 4, 13, 23, 56, 923, DateTimeKind.Unspecified).AddTicks(7782), new DateTime(2021, 8, 8, 10, 30, 43, 305, DateTimeKind.Unspecified).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, new DateTime(2021, 9, 26, 2, 22, 38, 801, DateTimeKind.Unspecified).AddTicks(8606), new DateTime(2021, 8, 1, 5, 39, 19, 388, DateTimeKind.Unspecified).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, new DateTime(2021, 10, 30, 21, 52, 38, 225, DateTimeKind.Unspecified).AddTicks(709), new DateTime(2021, 7, 11, 18, 33, 39, 731, DateTimeKind.Unspecified).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 11, 17, 13, 36, 53, 800, DateTimeKind.Unspecified).AddTicks(5947), new DateTime(2021, 8, 21, 3, 43, 14, 336, DateTimeKind.Unspecified).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, new DateTime(2021, 9, 29, 10, 29, 47, 598, DateTimeKind.Unspecified).AddTicks(330), new DateTime(2021, 8, 17, 22, 58, 50, 184, DateTimeKind.Unspecified).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 3, new DateTime(2021, 11, 29, 18, 41, 13, 252, DateTimeKind.Unspecified).AddTicks(3173), new DateTime(2021, 6, 21, 20, 30, 3, 924, DateTimeKind.Unspecified).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, 3, new DateTime(2021, 11, 11, 10, 38, 13, 139, DateTimeKind.Unspecified).AddTicks(449), new DateTime(2021, 7, 5, 2, 36, 33, 425, DateTimeKind.Unspecified).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, 1, new DateTime(2021, 9, 6, 17, 5, 59, 63, DateTimeKind.Unspecified).AddTicks(9565), new DateTime(2021, 8, 14, 1, 57, 1, 991, DateTimeKind.Unspecified).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 9, 11, 20, 9, 12, 616, DateTimeKind.Unspecified).AddTicks(5630), new DateTime(2021, 5, 27, 8, 21, 12, 991, DateTimeKind.Unspecified).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, 1, new DateTime(2021, 12, 5, 10, 44, 40, 104, DateTimeKind.Unspecified).AddTicks(9606), new DateTime(2021, 8, 13, 5, 8, 34, 650, DateTimeKind.Unspecified).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, new DateTime(2021, 10, 28, 8, 36, 38, 498, DateTimeKind.Unspecified).AddTicks(7448), new DateTime(2021, 8, 17, 5, 6, 38, 6, DateTimeKind.Unspecified).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 12, 13, 17, 8, 1, 469, DateTimeKind.Unspecified).AddTicks(8104), new DateTime(2021, 7, 12, 9, 51, 29, 803, DateTimeKind.Unspecified).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, 5, new DateTime(2021, 11, 19, 17, 40, 57, 172, DateTimeKind.Unspecified).AddTicks(4726), new DateTime(2021, 8, 30, 21, 48, 44, 479, DateTimeKind.Unspecified).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 2, new DateTime(2021, 10, 7, 12, 39, 11, 530, DateTimeKind.Unspecified).AddTicks(8592), new DateTime(2021, 8, 27, 20, 56, 50, 550, DateTimeKind.Unspecified).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, 4, new DateTime(2021, 11, 20, 22, 26, 45, 845, DateTimeKind.Unspecified).AddTicks(3072), new DateTime(2021, 8, 15, 17, 25, 9, 275, DateTimeKind.Unspecified).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 9, 23, 6, 33, 51, 251, DateTimeKind.Unspecified).AddTicks(2746), new DateTime(2021, 8, 7, 15, 43, 38, 193, DateTimeKind.Unspecified).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, new DateTime(2021, 11, 14, 19, 21, 4, 487, DateTimeKind.Unspecified).AddTicks(7088), new DateTime(2021, 7, 16, 3, 20, 50, 106, DateTimeKind.Unspecified).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 11, 14, 11, 48, 11, 165, DateTimeKind.Unspecified).AddTicks(3612), new DateTime(2021, 5, 11, 14, 15, 37, 0, DateTimeKind.Unspecified).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, new DateTime(2021, 9, 8, 11, 51, 46, 20, DateTimeKind.Unspecified).AddTicks(2812), new DateTime(2021, 8, 30, 12, 14, 41, 751, DateTimeKind.Unspecified).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, 5, new DateTime(2021, 11, 26, 13, 45, 1, 348, DateTimeKind.Unspecified).AddTicks(7450), new DateTime(2021, 7, 5, 13, 33, 51, 877, DateTimeKind.Unspecified).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, new DateTime(2021, 9, 3, 1, 31, 15, 569, DateTimeKind.Unspecified).AddTicks(7395), new DateTime(2021, 7, 9, 11, 57, 36, 584, DateTimeKind.Unspecified).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 5, new DateTime(2021, 11, 29, 14, 20, 19, 28, DateTimeKind.Unspecified).AddTicks(5491), new DateTime(2021, 6, 1, 6, 59, 2, 864, DateTimeKind.Unspecified).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, new DateTime(2021, 12, 29, 1, 42, 38, 881, DateTimeKind.Unspecified).AddTicks(607), new DateTime(2021, 6, 21, 5, 48, 4, 894, DateTimeKind.Unspecified).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 3, new DateTime(2021, 9, 14, 23, 58, 20, 321, DateTimeKind.Unspecified).AddTicks(9649), new DateTime(2021, 6, 20, 19, 29, 12, 445, DateTimeKind.Unspecified).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 2, new DateTime(2021, 11, 19, 2, 40, 57, 251, DateTimeKind.Unspecified).AddTicks(3849), new DateTime(2021, 6, 18, 1, 47, 44, 401, DateTimeKind.Unspecified).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, 1, new DateTime(2021, 12, 3, 21, 38, 43, 784, DateTimeKind.Unspecified).AddTicks(7363), new DateTime(2021, 8, 8, 14, 28, 30, 991, DateTimeKind.Unspecified).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, 1, new DateTime(2021, 12, 20, 5, 43, 18, 611, DateTimeKind.Unspecified).AddTicks(3152), new DateTime(2021, 5, 17, 9, 0, 21, 44, DateTimeKind.Unspecified).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, 1, new DateTime(2021, 11, 28, 13, 39, 42, 688, DateTimeKind.Unspecified).AddTicks(714), new DateTime(2021, 7, 14, 4, 16, 54, 647, DateTimeKind.Unspecified).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 3, new DateTime(2021, 10, 22, 15, 14, 22, 555, DateTimeKind.Unspecified).AddTicks(5562), new DateTime(2021, 6, 10, 10, 33, 0, 72, DateTimeKind.Unspecified).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, 1, new DateTime(2021, 10, 27, 12, 19, 34, 262, DateTimeKind.Unspecified).AddTicks(9332), new DateTime(2021, 5, 9, 8, 14, 19, 674, DateTimeKind.Unspecified).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 4, 1, new DateTime(2021, 10, 17, 22, 13, 17, 649, DateTimeKind.Unspecified).AddTicks(5698), new DateTime(2021, 6, 22, 6, 15, 6, 777, DateTimeKind.Unspecified).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, new DateTime(2021, 12, 15, 2, 6, 15, 599, DateTimeKind.Unspecified).AddTicks(5890), new DateTime(2021, 8, 18, 7, 25, 37, 708, DateTimeKind.Unspecified).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, new DateTime(2021, 11, 18, 17, 38, 34, 620, DateTimeKind.Unspecified).AddTicks(2785), new DateTime(2021, 6, 27, 1, 5, 22, 738, DateTimeKind.Unspecified).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, 1, new DateTime(2021, 12, 18, 3, 9, 20, 616, DateTimeKind.Unspecified).AddTicks(7593), new DateTime(2021, 7, 1, 11, 16, 20, 429, DateTimeKind.Unspecified).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, 5, new DateTime(2021, 11, 23, 3, 3, 6, 569, DateTimeKind.Unspecified).AddTicks(7837), new DateTime(2021, 7, 21, 15, 13, 46, 749, DateTimeKind.Unspecified).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 11, 2, 9, 0, 22, 582, DateTimeKind.Unspecified).AddTicks(9946), new DateTime(2021, 8, 23, 0, 0, 21, 476, DateTimeKind.Unspecified).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 11, 27, 2, 30, 0, 511, DateTimeKind.Unspecified).AddTicks(321), new DateTime(2021, 6, 15, 21, 24, 17, 766, DateTimeKind.Unspecified).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, 2, new DateTime(2021, 11, 28, 8, 41, 29, 618, DateTimeKind.Unspecified).AddTicks(6304), new DateTime(2021, 7, 26, 18, 37, 47, 906, DateTimeKind.Unspecified).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, 1, new DateTime(2021, 10, 2, 20, 36, 16, 493, DateTimeKind.Unspecified).AddTicks(2516), new DateTime(2021, 7, 29, 7, 14, 25, 936, DateTimeKind.Unspecified).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, new DateTime(2021, 10, 3, 5, 57, 47, 393, DateTimeKind.Unspecified).AddTicks(7689), new DateTime(2021, 7, 20, 14, 36, 30, 144, DateTimeKind.Unspecified).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 1, new DateTime(2021, 10, 31, 11, 21, 49, 928, DateTimeKind.Unspecified).AddTicks(5942), new DateTime(2021, 5, 21, 13, 46, 6, 526, DateTimeKind.Unspecified).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 12, 24, 12, 21, 32, 158, DateTimeKind.Unspecified).AddTicks(90), new DateTime(2021, 7, 28, 6, 7, 41, 690, DateTimeKind.Unspecified).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, new DateTime(2021, 12, 24, 12, 45, 12, 993, DateTimeKind.Unspecified).AddTicks(5940), new DateTime(2021, 6, 20, 0, 39, 9, 303, DateTimeKind.Unspecified).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, new DateTime(2021, 10, 12, 17, 1, 51, 883, DateTimeKind.Unspecified).AddTicks(1607), new DateTime(2021, 7, 29, 6, 15, 2, 418, DateTimeKind.Unspecified).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, new DateTime(2021, 12, 13, 4, 15, 17, 67, DateTimeKind.Unspecified).AddTicks(3591), new DateTime(2021, 8, 1, 11, 44, 20, 544, DateTimeKind.Unspecified).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, new DateTime(2021, 10, 28, 20, 21, 28, 78, DateTimeKind.Unspecified).AddTicks(5166), new DateTime(2021, 6, 21, 8, 32, 21, 653, DateTimeKind.Unspecified).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, new DateTime(2021, 10, 14, 15, 33, 48, 262, DateTimeKind.Unspecified).AddTicks(3299), new DateTime(2021, 7, 23, 8, 25, 16, 102, DateTimeKind.Unspecified).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 12, 6, 22, 30, 57, 148, DateTimeKind.Unspecified).AddTicks(2693), new DateTime(2021, 8, 12, 10, 0, 34, 280, DateTimeKind.Unspecified).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 4, new DateTime(2021, 9, 21, 5, 35, 46, 706, DateTimeKind.Unspecified).AddTicks(1420), new DateTime(2021, 8, 1, 22, 33, 11, 888, DateTimeKind.Unspecified).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, 3, new DateTime(2021, 12, 4, 0, 21, 53, 432, DateTimeKind.Unspecified).AddTicks(4661), new DateTime(2021, 8, 4, 10, 47, 19, 538, DateTimeKind.Unspecified).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, 5, new DateTime(2021, 12, 1, 19, 20, 14, 858, DateTimeKind.Unspecified).AddTicks(7283), new DateTime(2021, 6, 10, 23, 12, 54, 718, DateTimeKind.Unspecified).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 12, 1, 7, 4, 41, 697, DateTimeKind.Unspecified).AddTicks(8067), new DateTime(2021, 6, 7, 12, 18, 11, 627, DateTimeKind.Unspecified).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, 3, new DateTime(2021, 9, 5, 9, 23, 5, 339, DateTimeKind.Unspecified).AddTicks(1924), new DateTime(2021, 6, 3, 6, 36, 52, 690, DateTimeKind.Unspecified).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 12, 23, 6, 28, 23, 562, DateTimeKind.Unspecified).AddTicks(6878), new DateTime(2021, 5, 9, 13, 2, 4, 95, DateTimeKind.Unspecified).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, 3, new DateTime(2021, 11, 6, 3, 24, 40, 663, DateTimeKind.Unspecified).AddTicks(9922), new DateTime(2021, 8, 21, 3, 5, 57, 194, DateTimeKind.Unspecified).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, 3, new DateTime(2021, 10, 21, 16, 12, 58, 525, DateTimeKind.Unspecified).AddTicks(9861), new DateTime(2021, 7, 13, 6, 13, 18, 798, DateTimeKind.Unspecified).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, 5, new DateTime(2021, 11, 13, 7, 14, 51, 972, DateTimeKind.Unspecified).AddTicks(8311), new DateTime(2021, 7, 17, 0, 3, 37, 316, DateTimeKind.Unspecified).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 9, 7, 21, 13, 8, 244, DateTimeKind.Unspecified).AddTicks(3620), new DateTime(2021, 8, 20, 2, 20, 24, 294, DateTimeKind.Unspecified).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateScheduledArrival", "DateShipped" },
                values: new object[] { new DateTime(2021, 9, 26, 10, 44, 5, 801, DateTimeKind.Unspecified).AddTicks(630), new DateTime(2021, 5, 17, 15, 34, 47, 212, DateTimeKind.Unspecified).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, new DateTime(2021, 9, 23, 2, 18, 51, 14, DateTimeKind.Unspecified).AddTicks(4821), new DateTime(2021, 7, 28, 18, 23, 39, 45, DateTimeKind.Unspecified).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 4, new DateTime(2021, 10, 8, 16, 36, 21, 312, DateTimeKind.Unspecified).AddTicks(9867), new DateTime(2021, 8, 11, 19, 6, 57, 143, DateTimeKind.Unspecified).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, 2, new DateTime(2021, 9, 22, 7, 24, 40, 535, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2021, 8, 2, 2, 31, 6, 649, DateTimeKind.Unspecified).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, 5, new DateTime(2021, 12, 1, 11, 33, 38, 239, DateTimeKind.Unspecified).AddTicks(4177), new DateTime(2021, 8, 13, 8, 23, 42, 780, DateTimeKind.Unspecified).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 4, new DateTime(2021, 11, 17, 12, 37, 33, 221, DateTimeKind.Unspecified).AddTicks(4749), new DateTime(2021, 7, 18, 14, 36, 8, 253, DateTimeKind.Unspecified).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, new DateTime(2021, 9, 27, 2, 47, 28, 480, DateTimeKind.Unspecified).AddTicks(818), new DateTime(2021, 8, 26, 0, 0, 29, 483, DateTimeKind.Unspecified).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 4, new DateTime(2021, 11, 24, 5, 59, 18, 447, DateTimeKind.Unspecified).AddTicks(5498), new DateTime(2021, 7, 27, 22, 38, 55, 152, DateTimeKind.Unspecified).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 5, new DateTime(2021, 12, 5, 13, 1, 40, 568, DateTimeKind.Unspecified).AddTicks(1614), new DateTime(2021, 6, 22, 6, 12, 15, 437, DateTimeKind.Unspecified).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 10, 7, 21, 50, 39, 722, DateTimeKind.Unspecified).AddTicks(7162), new DateTime(2021, 6, 11, 4, 18, 39, 374, DateTimeKind.Unspecified).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, 1, new DateTime(2021, 9, 22, 12, 42, 43, 132, DateTimeKind.Unspecified).AddTicks(6084), new DateTime(2021, 7, 30, 20, 17, 17, 8, DateTimeKind.Unspecified).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, new DateTime(2021, 11, 1, 22, 43, 46, 971, DateTimeKind.Unspecified).AddTicks(5735), new DateTime(2021, 6, 14, 16, 53, 23, 761, DateTimeKind.Unspecified).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 4, new DateTime(2021, 10, 25, 17, 58, 41, 880, DateTimeKind.Unspecified).AddTicks(9608), new DateTime(2021, 5, 16, 2, 1, 50, 611, DateTimeKind.Unspecified).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, 2, new DateTime(2021, 11, 18, 11, 46, 38, 601, DateTimeKind.Unspecified).AddTicks(5100), new DateTime(2021, 7, 17, 23, 24, 18, 670, DateTimeKind.Unspecified).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 2, new DateTime(2021, 9, 22, 10, 18, 49, 923, DateTimeKind.Unspecified).AddTicks(1449), new DateTime(2021, 5, 14, 0, 47, 38, 207, DateTimeKind.Unspecified).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 4, new DateTime(2021, 11, 23, 20, 55, 40, 816, DateTimeKind.Unspecified).AddTicks(8100), new DateTime(2021, 5, 14, 13, 4, 16, 125, DateTimeKind.Unspecified).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, 2, new DateTime(2021, 11, 10, 8, 8, 57, 467, DateTimeKind.Unspecified).AddTicks(8421), new DateTime(2021, 6, 13, 12, 41, 2, 731, DateTimeKind.Unspecified).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, new DateTime(2021, 12, 20, 7, 24, 2, 123, DateTimeKind.Unspecified).AddTicks(2571), new DateTime(2021, 8, 5, 12, 55, 5, 844, DateTimeKind.Unspecified).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, 3, new DateTime(2021, 9, 1, 7, 30, 37, 362, DateTimeKind.Unspecified).AddTicks(9964), new DateTime(2021, 5, 30, 1, 38, 27, 865, DateTimeKind.Unspecified).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, 1, new DateTime(2021, 10, 26, 10, 25, 32, 168, DateTimeKind.Unspecified).AddTicks(6398), new DateTime(2021, 8, 24, 5, 22, 54, 972, DateTimeKind.Unspecified).AddTicks(3271) });
        }
    }
}
