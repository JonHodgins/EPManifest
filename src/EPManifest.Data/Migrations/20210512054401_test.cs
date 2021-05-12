using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Whistle Bend Place");

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, new DateTime(2021, 11, 22, 12, 14, 20, 744, DateTimeKind.Unspecified).AddTicks(7785), new DateTime(2021, 6, 13, 18, 11, 53, 780, DateTimeKind.Unspecified).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, new DateTime(2021, 10, 12, 12, 26, 21, 518, DateTimeKind.Unspecified).AddTicks(167), new DateTime(2021, 8, 9, 9, 49, 0, 298, DateTimeKind.Unspecified).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 11, 11, 10, 10, 16, 805, DateTimeKind.Unspecified).AddTicks(2278), new DateTime(2021, 7, 17, 10, 11, 56, 110, DateTimeKind.Unspecified).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, new DateTime(2021, 9, 12, 0, 34, 17, 484, DateTimeKind.Unspecified).AddTicks(9585), new DateTime(2021, 8, 19, 11, 17, 2, 254, DateTimeKind.Unspecified).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, 1, new DateTime(2021, 11, 22, 8, 13, 11, 637, DateTimeKind.Unspecified).AddTicks(8979), new DateTime(2021, 6, 4, 1, 8, 29, 742, DateTimeKind.Unspecified).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, new DateTime(2021, 9, 20, 23, 55, 23, 526, DateTimeKind.Unspecified).AddTicks(619), new DateTime(2021, 5, 11, 22, 14, 27, 759, DateTimeKind.Unspecified).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 5, new DateTime(2021, 10, 13, 10, 31, 17, 327, DateTimeKind.Unspecified).AddTicks(4196), new DateTime(2021, 6, 11, 6, 11, 15, 410, DateTimeKind.Unspecified).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, new DateTime(2021, 10, 13, 12, 12, 31, 319, DateTimeKind.Unspecified).AddTicks(2203), new DateTime(2021, 7, 24, 20, 43, 23, 160, DateTimeKind.Unspecified).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, new DateTime(2021, 9, 23, 22, 23, 11, 428, DateTimeKind.Unspecified).AddTicks(2444), new DateTime(2021, 8, 22, 19, 39, 8, 951, DateTimeKind.Unspecified).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 5, new DateTime(2021, 11, 5, 18, 35, 52, 761, DateTimeKind.Unspecified).AddTicks(8005), new DateTime(2021, 6, 25, 18, 42, 32, 506, DateTimeKind.Unspecified).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 3, new DateTime(2021, 12, 12, 13, 17, 47, 242, DateTimeKind.Unspecified).AddTicks(9025), new DateTime(2021, 5, 31, 2, 43, 38, 154, DateTimeKind.Unspecified).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, new DateTime(2021, 11, 12, 14, 33, 19, 268, DateTimeKind.Unspecified).AddTicks(6545), new DateTime(2021, 7, 20, 11, 58, 21, 893, DateTimeKind.Unspecified).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 4, 4, new DateTime(2021, 11, 2, 9, 22, 26, 375, DateTimeKind.Unspecified).AddTicks(6942), new DateTime(2021, 7, 21, 9, 41, 29, 13, DateTimeKind.Unspecified).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 12, 29, 0, 26, 4, 425, DateTimeKind.Unspecified).AddTicks(7136), new DateTime(2021, 6, 7, 2, 10, 57, 493, DateTimeKind.Unspecified).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 5, new DateTime(2021, 11, 25, 8, 46, 6, 581, DateTimeKind.Unspecified).AddTicks(8034), new DateTime(2021, 7, 10, 1, 39, 50, 835, DateTimeKind.Unspecified).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 5, new DateTime(2021, 12, 1, 22, 54, 22, 330, DateTimeKind.Unspecified).AddTicks(9922), new DateTime(2021, 5, 13, 6, 2, 49, 128, DateTimeKind.Unspecified).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, new DateTime(2021, 11, 13, 16, 50, 34, 848, DateTimeKind.Unspecified).AddTicks(9328), new DateTime(2021, 7, 3, 9, 55, 14, 307, DateTimeKind.Unspecified).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, new DateTime(2021, 10, 11, 16, 13, 1, 137, DateTimeKind.Unspecified).AddTicks(764), new DateTime(2021, 6, 28, 18, 56, 20, 97, DateTimeKind.Unspecified).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 4, new DateTime(2021, 11, 8, 11, 3, 27, 11, DateTimeKind.Unspecified).AddTicks(9849), new DateTime(2021, 5, 16, 20, 34, 31, 624, DateTimeKind.Unspecified).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, 4, new DateTime(2021, 10, 1, 22, 3, 35, 395, DateTimeKind.Unspecified).AddTicks(9987), new DateTime(2021, 6, 24, 12, 31, 42, 396, DateTimeKind.Unspecified).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, 4, new DateTime(2021, 11, 26, 10, 23, 22, 889, DateTimeKind.Unspecified).AddTicks(4375), new DateTime(2021, 6, 27, 15, 54, 57, 60, DateTimeKind.Unspecified).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, 3, new DateTime(2021, 12, 26, 22, 9, 32, 998, DateTimeKind.Unspecified).AddTicks(8067), new DateTime(2021, 7, 3, 23, 33, 2, 147, DateTimeKind.Unspecified).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 4, new DateTime(2021, 11, 16, 3, 50, 53, 663, DateTimeKind.Unspecified).AddTicks(4674), new DateTime(2021, 8, 17, 2, 29, 59, 677, DateTimeKind.Unspecified).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, 3, new DateTime(2021, 12, 3, 13, 49, 41, 167, DateTimeKind.Unspecified).AddTicks(8269), new DateTime(2021, 5, 12, 8, 33, 34, 570, DateTimeKind.Unspecified).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 1, new DateTime(2021, 9, 30, 0, 10, 26, 634, DateTimeKind.Unspecified).AddTicks(3000), new DateTime(2021, 8, 22, 10, 22, 23, 189, DateTimeKind.Unspecified).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, 4, new DateTime(2021, 9, 11, 7, 17, 14, 208, DateTimeKind.Unspecified).AddTicks(9537), new DateTime(2021, 8, 29, 0, 4, 49, 956, DateTimeKind.Unspecified).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, 1, new DateTime(2021, 9, 16, 3, 49, 24, 345, DateTimeKind.Unspecified).AddTicks(7864), new DateTime(2021, 8, 6, 20, 47, 0, 611, DateTimeKind.Unspecified).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 2, new DateTime(2021, 9, 6, 16, 5, 28, 606, DateTimeKind.Unspecified).AddTicks(5595), new DateTime(2021, 8, 5, 6, 23, 35, 694, DateTimeKind.Unspecified).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, 1, new DateTime(2021, 11, 13, 2, 48, 26, 68, DateTimeKind.Unspecified).AddTicks(2225), new DateTime(2021, 7, 2, 15, 55, 41, 296, DateTimeKind.Unspecified).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, new DateTime(2021, 9, 2, 11, 56, 5, 147, DateTimeKind.Unspecified).AddTicks(3409), new DateTime(2021, 6, 28, 11, 21, 51, 531, DateTimeKind.Unspecified).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, 2, new DateTime(2021, 9, 24, 15, 14, 23, 683, DateTimeKind.Unspecified).AddTicks(94), new DateTime(2021, 7, 20, 14, 3, 49, 385, DateTimeKind.Unspecified).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, 2, new DateTime(2021, 9, 7, 11, 50, 19, 832, DateTimeKind.Unspecified).AddTicks(2152), new DateTime(2021, 5, 31, 2, 15, 46, 127, DateTimeKind.Unspecified).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 2, new DateTime(2021, 12, 17, 22, 50, 52, 400, DateTimeKind.Unspecified).AddTicks(3263), new DateTime(2021, 6, 24, 4, 31, 31, 783, DateTimeKind.Unspecified).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, new DateTime(2021, 10, 4, 6, 33, 50, 744, DateTimeKind.Unspecified).AddTicks(5383), new DateTime(2021, 8, 2, 16, 43, 2, 324, DateTimeKind.Unspecified).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, new DateTime(2021, 11, 10, 18, 40, 43, 653, DateTimeKind.Unspecified).AddTicks(4837), new DateTime(2021, 8, 29, 23, 12, 59, 944, DateTimeKind.Unspecified).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 2, new DateTime(2021, 10, 11, 10, 15, 22, 445, DateTimeKind.Unspecified).AddTicks(507), new DateTime(2021, 6, 13, 22, 34, 51, 967, DateTimeKind.Unspecified).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, new DateTime(2021, 12, 1, 12, 51, 42, 464, DateTimeKind.Unspecified).AddTicks(5455), new DateTime(2021, 8, 27, 13, 55, 39, 609, DateTimeKind.Unspecified).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, new DateTime(2021, 12, 9, 7, 16, 54, 271, DateTimeKind.Unspecified).AddTicks(3833), new DateTime(2021, 7, 15, 9, 40, 16, 285, DateTimeKind.Unspecified).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, 4, new DateTime(2021, 11, 28, 4, 13, 16, 851, DateTimeKind.Unspecified).AddTicks(9580), new DateTime(2021, 7, 30, 2, 16, 55, 27, DateTimeKind.Unspecified).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, 1, new DateTime(2021, 10, 15, 17, 5, 3, 231, DateTimeKind.Unspecified).AddTicks(9922), new DateTime(2021, 7, 15, 1, 33, 7, 362, DateTimeKind.Unspecified).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 4, new DateTime(2021, 12, 10, 22, 25, 11, 72, DateTimeKind.Unspecified).AddTicks(4154), new DateTime(2021, 5, 27, 20, 23, 54, 377, DateTimeKind.Unspecified).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, new DateTime(2021, 12, 14, 5, 29, 4, 111, DateTimeKind.Unspecified).AddTicks(1418), new DateTime(2021, 5, 14, 7, 37, 0, 954, DateTimeKind.Unspecified).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 3, new DateTime(2021, 9, 16, 19, 21, 18, 57, DateTimeKind.Unspecified).AddTicks(3395), new DateTime(2021, 8, 15, 16, 7, 6, 448, DateTimeKind.Unspecified).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, new DateTime(2021, 12, 3, 12, 59, 35, 530, DateTimeKind.Unspecified).AddTicks(4972), new DateTime(2021, 7, 22, 4, 35, 56, 383, DateTimeKind.Unspecified).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 3, new DateTime(2021, 10, 30, 12, 56, 13, 777, DateTimeKind.Unspecified).AddTicks(3367), new DateTime(2021, 8, 23, 7, 36, 53, 388, DateTimeKind.Unspecified).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 10, 31, 0, 28, 10, 431, DateTimeKind.Unspecified).AddTicks(5077), new DateTime(2021, 6, 7, 3, 55, 54, 837, DateTimeKind.Unspecified).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, new DateTime(2021, 11, 19, 7, 34, 54, 262, DateTimeKind.Unspecified).AddTicks(7497), new DateTime(2021, 8, 25, 10, 42, 27, 573, DateTimeKind.Unspecified).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, 5, new DateTime(2021, 11, 23, 1, 34, 51, 223, DateTimeKind.Unspecified).AddTicks(7298), new DateTime(2021, 5, 23, 15, 37, 40, 491, DateTimeKind.Unspecified).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 2, new DateTime(2021, 10, 17, 16, 29, 32, 521, DateTimeKind.Unspecified).AddTicks(5607), new DateTime(2021, 7, 31, 8, 13, 38, 162, DateTimeKind.Unspecified).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 4, new DateTime(2021, 12, 4, 20, 53, 11, 299, DateTimeKind.Unspecified).AddTicks(533), new DateTime(2021, 7, 15, 1, 44, 16, 542, DateTimeKind.Unspecified).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, new DateTime(2021, 12, 16, 23, 51, 17, 331, DateTimeKind.Unspecified).AddTicks(182), new DateTime(2021, 8, 10, 3, 52, 50, 949, DateTimeKind.Unspecified).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, new DateTime(2021, 9, 13, 1, 44, 11, 229, DateTimeKind.Unspecified).AddTicks(5439), new DateTime(2021, 7, 25, 6, 19, 3, 597, DateTimeKind.Unspecified).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 9, 11, 17, 55, 53, 934, DateTimeKind.Unspecified).AddTicks(3762), new DateTime(2021, 7, 11, 6, 34, 32, 197, DateTimeKind.Unspecified).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 4, new DateTime(2021, 10, 7, 19, 54, 40, 675, DateTimeKind.Unspecified).AddTicks(8484), new DateTime(2021, 6, 1, 6, 55, 45, 124, DateTimeKind.Unspecified).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 4, new DateTime(2021, 11, 4, 12, 23, 45, 506, DateTimeKind.Unspecified).AddTicks(9136), new DateTime(2021, 8, 27, 5, 52, 24, 63, DateTimeKind.Unspecified).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, 3, new DateTime(2021, 11, 27, 2, 49, 49, 478, DateTimeKind.Unspecified).AddTicks(6733), new DateTime(2021, 7, 9, 22, 41, 2, 645, DateTimeKind.Unspecified).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 10, 31, 11, 33, 43, 277, DateTimeKind.Unspecified).AddTicks(488), new DateTime(2021, 7, 1, 23, 56, 55, 999, DateTimeKind.Unspecified).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, new DateTime(2021, 9, 29, 3, 15, 26, 715, DateTimeKind.Unspecified).AddTicks(755), new DateTime(2021, 5, 15, 18, 11, 4, 159, DateTimeKind.Unspecified).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 4, new DateTime(2021, 9, 6, 4, 42, 51, 504, DateTimeKind.Unspecified).AddTicks(3728), new DateTime(2021, 5, 12, 4, 15, 30, 810, DateTimeKind.Unspecified).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 12, 3, 6, 16, 49, 125, DateTimeKind.Unspecified).AddTicks(8184), new DateTime(2021, 7, 21, 3, 5, 8, 225, DateTimeKind.Unspecified).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 4, new DateTime(2021, 9, 12, 15, 0, 58, 976, DateTimeKind.Unspecified).AddTicks(8930), new DateTime(2021, 6, 10, 1, 39, 24, 991, DateTimeKind.Unspecified).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 10, 18, 9, 50, 58, 52, DateTimeKind.Unspecified).AddTicks(8722), new DateTime(2021, 6, 9, 20, 15, 53, 318, DateTimeKind.Unspecified).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, new DateTime(2021, 9, 25, 1, 56, 47, 88, DateTimeKind.Unspecified).AddTicks(475), new DateTime(2021, 8, 26, 11, 9, 53, 266, DateTimeKind.Unspecified).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, 1, new DateTime(2021, 11, 22, 15, 21, 54, 691, DateTimeKind.Unspecified).AddTicks(4665), new DateTime(2021, 5, 14, 18, 59, 30, 735, DateTimeKind.Unspecified).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 1, new DateTime(2021, 11, 3, 23, 48, 15, 759, DateTimeKind.Unspecified).AddTicks(6031), new DateTime(2021, 8, 28, 13, 9, 20, 229, DateTimeKind.Unspecified).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, new DateTime(2021, 12, 9, 3, 11, 18, 649, DateTimeKind.Unspecified).AddTicks(5128), new DateTime(2021, 8, 22, 7, 20, 35, 608, DateTimeKind.Unspecified).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, 5, new DateTime(2021, 12, 29, 18, 53, 15, 616, DateTimeKind.Unspecified).AddTicks(3738), new DateTime(2021, 8, 5, 7, 23, 34, 302, DateTimeKind.Unspecified).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 12, 2, 5, 34, 18, 397, DateTimeKind.Unspecified).AddTicks(253), new DateTime(2021, 6, 20, 22, 46, 4, 905, DateTimeKind.Unspecified).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 9, 18, 23, 55, 2, 999, DateTimeKind.Unspecified).AddTicks(1163), new DateTime(2021, 7, 24, 16, 45, 26, 341, DateTimeKind.Unspecified).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, new DateTime(2021, 12, 14, 2, 27, 23, 22, DateTimeKind.Unspecified).AddTicks(49), new DateTime(2021, 8, 12, 6, 58, 14, 321, DateTimeKind.Unspecified).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, 5, new DateTime(2021, 11, 10, 2, 13, 21, 264, DateTimeKind.Unspecified).AddTicks(8322), new DateTime(2021, 8, 26, 14, 4, 8, 807, DateTimeKind.Unspecified).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, 5, new DateTime(2021, 10, 29, 5, 32, 7, 958, DateTimeKind.Unspecified).AddTicks(2638), new DateTime(2021, 8, 3, 6, 0, 29, 352, DateTimeKind.Unspecified).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, new DateTime(2021, 10, 19, 3, 30, 3, 218, DateTimeKind.Unspecified).AddTicks(1068), new DateTime(2021, 6, 30, 15, 3, 9, 312, DateTimeKind.Unspecified).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, 1, new DateTime(2021, 10, 28, 6, 51, 51, 912, DateTimeKind.Unspecified).AddTicks(2412), new DateTime(2021, 8, 27, 14, 50, 0, 738, DateTimeKind.Unspecified).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, new DateTime(2021, 11, 10, 19, 47, 41, 133, DateTimeKind.Unspecified).AddTicks(5252), new DateTime(2021, 6, 11, 3, 11, 2, 341, DateTimeKind.Unspecified).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, 1, new DateTime(2021, 10, 30, 11, 10, 12, 230, DateTimeKind.Unspecified).AddTicks(1453), new DateTime(2021, 8, 11, 10, 39, 19, 858, DateTimeKind.Unspecified).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, new DateTime(2021, 12, 15, 6, 28, 46, 423, DateTimeKind.Unspecified).AddTicks(2357), new DateTime(2021, 5, 15, 8, 46, 38, 25, DateTimeKind.Unspecified).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, 3, new DateTime(2021, 9, 19, 9, 32, 25, 478, DateTimeKind.Unspecified).AddTicks(7817), new DateTime(2021, 5, 30, 16, 35, 10, 620, DateTimeKind.Unspecified).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, new DateTime(2021, 9, 16, 16, 25, 52, 652, DateTimeKind.Unspecified).AddTicks(7874), new DateTime(2021, 8, 19, 14, 31, 54, 366, DateTimeKind.Unspecified).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, 5, new DateTime(2021, 9, 6, 15, 15, 14, 449, DateTimeKind.Unspecified).AddTicks(8634), new DateTime(2021, 6, 8, 22, 33, 14, 356, DateTimeKind.Unspecified).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, 5, new DateTime(2021, 10, 17, 12, 20, 39, 927, DateTimeKind.Unspecified).AddTicks(712), new DateTime(2021, 6, 18, 20, 16, 52, 751, DateTimeKind.Unspecified).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 10, 17, 7, 4, 2, 46, DateTimeKind.Unspecified).AddTicks(7242), new DateTime(2021, 6, 20, 6, 33, 42, 110, DateTimeKind.Unspecified).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, new DateTime(2021, 10, 7, 16, 52, 14, 838, DateTimeKind.Unspecified).AddTicks(1310), new DateTime(2021, 6, 7, 17, 36, 24, 670, DateTimeKind.Unspecified).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, new DateTime(2021, 12, 17, 6, 3, 27, 481, DateTimeKind.Unspecified).AddTicks(2022), new DateTime(2021, 7, 15, 13, 51, 10, 811, DateTimeKind.Unspecified).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 2, 3, new DateTime(2021, 10, 11, 4, 12, 13, 430, DateTimeKind.Unspecified).AddTicks(4150), new DateTime(2021, 8, 10, 3, 11, 15, 696, DateTimeKind.Unspecified).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, 3, new DateTime(2021, 12, 3, 14, 43, 9, 994, DateTimeKind.Unspecified).AddTicks(4791), new DateTime(2021, 5, 27, 5, 25, 7, 341, DateTimeKind.Unspecified).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, 4, new DateTime(2021, 11, 3, 10, 3, 5, 924, DateTimeKind.Unspecified).AddTicks(3219), new DateTime(2021, 8, 6, 2, 6, 29, 926, DateTimeKind.Unspecified).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 9, 26, 14, 26, 34, 762, DateTimeKind.Unspecified).AddTicks(1781), new DateTime(2021, 7, 25, 3, 47, 19, 417, DateTimeKind.Unspecified).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, new DateTime(2021, 10, 12, 8, 36, 42, 367, DateTimeKind.Unspecified).AddTicks(8447), new DateTime(2021, 8, 9, 16, 36, 47, 849, DateTimeKind.Unspecified).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 3, new DateTime(2021, 10, 20, 11, 33, 34, 81, DateTimeKind.Unspecified).AddTicks(4439), new DateTime(2021, 7, 15, 17, 20, 25, 884, DateTimeKind.Unspecified).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, new DateTime(2021, 11, 15, 22, 27, 17, 263, DateTimeKind.Unspecified).AddTicks(1613), new DateTime(2021, 6, 22, 0, 8, 8, 73, DateTimeKind.Unspecified).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 4, new DateTime(2021, 12, 11, 14, 0, 4, 89, DateTimeKind.Unspecified).AddTicks(8558), new DateTime(2021, 5, 11, 15, 53, 21, 640, DateTimeKind.Unspecified).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, new DateTime(2021, 11, 21, 20, 1, 9, 2, DateTimeKind.Unspecified).AddTicks(6902), new DateTime(2021, 7, 16, 7, 14, 59, 388, DateTimeKind.Unspecified).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 1, new DateTime(2021, 11, 25, 0, 40, 15, 607, DateTimeKind.Unspecified).AddTicks(8201), new DateTime(2021, 8, 1, 11, 1, 43, 833, DateTimeKind.Unspecified).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, new DateTime(2021, 9, 28, 0, 34, 3, 353, DateTimeKind.Unspecified).AddTicks(6733), new DateTime(2021, 6, 21, 5, 52, 41, 740, DateTimeKind.Unspecified).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, new DateTime(2021, 12, 13, 23, 43, 35, 781, DateTimeKind.Unspecified).AddTicks(9624), new DateTime(2021, 7, 1, 19, 47, 46, 834, DateTimeKind.Unspecified).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 3, new DateTime(2021, 9, 8, 15, 10, 52, 903, DateTimeKind.Unspecified).AddTicks(220), new DateTime(2021, 8, 3, 4, 44, 47, 346, DateTimeKind.Unspecified).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, 4, new DateTime(2021, 12, 21, 9, 2, 4, 902, DateTimeKind.Unspecified).AddTicks(8179), new DateTime(2021, 5, 25, 22, 1, 23, 437, DateTimeKind.Unspecified).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 4, new DateTime(2021, 9, 16, 14, 30, 48, 309, DateTimeKind.Unspecified).AddTicks(9883), new DateTime(2021, 8, 12, 14, 40, 48, 753, DateTimeKind.Unspecified).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 9, 20, 12, 7, 40, 949, DateTimeKind.Unspecified).AddTicks(6022), new DateTime(2021, 5, 23, 21, 59, 0, 615, DateTimeKind.Unspecified).AddTicks(2319) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consignors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Whistlebend Care Home");

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, new DateTime(2021, 5, 14, 21, 40, 42, 29, DateTimeKind.Local).AddTicks(5585), new DateTime(2021, 10, 4, 14, 58, 16, 385, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, new DateTime(2021, 10, 10, 17, 30, 45, 363, DateTimeKind.Local).AddTicks(8552), new DateTime(2021, 8, 3, 10, 35, 2, 330, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 10, 25, 16, 24, 2, 84, DateTimeKind.Local).AddTicks(1093), new DateTime(2021, 10, 24, 18, 51, 36, 133, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, new DateTime(2021, 8, 31, 21, 26, 34, 352, DateTimeKind.Local).AddTicks(897), new DateTime(2021, 9, 27, 12, 58, 34, 627, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 2, new DateTime(2021, 6, 25, 1, 3, 11, 909, DateTimeKind.Local).AddTicks(7247), new DateTime(2021, 12, 29, 13, 24, 39, 760, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, new DateTime(2021, 12, 10, 8, 30, 38, 160, DateTimeKind.Local).AddTicks(8027), new DateTime(2021, 12, 7, 19, 27, 4, 7, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, new DateTime(2021, 12, 15, 3, 14, 30, 382, DateTimeKind.Local).AddTicks(7575), new DateTime(2021, 8, 14, 12, 51, 49, 513, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, new DateTime(2021, 9, 17, 19, 5, 29, 232, DateTimeKind.Local).AddTicks(9544), new DateTime(2021, 10, 24, 20, 28, 11, 117, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 7, 16, 9, 53, 8, 336, DateTimeKind.Local).AddTicks(4709), new DateTime(2021, 6, 7, 8, 43, 44, 701, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 3, new DateTime(2021, 10, 7, 9, 47, 54, 383, DateTimeKind.Local).AddTicks(3357), new DateTime(2021, 7, 25, 10, 31, 21, 701, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, 4, new DateTime(2021, 8, 6, 17, 30, 34, 312, DateTimeKind.Local).AddTicks(3879), new DateTime(2021, 7, 26, 22, 35, 13, 448, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, new DateTime(2021, 10, 10, 12, 45, 12, 532, DateTimeKind.Local).AddTicks(402), new DateTime(2021, 8, 21, 11, 53, 46, 209, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, 1, new DateTime(2021, 7, 20, 3, 20, 59, 831, DateTimeKind.Local).AddTicks(2925), new DateTime(2021, 8, 24, 2, 4, 24, 169, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 7, 14, 9, 49, 28, 813, DateTimeKind.Local).AddTicks(8180), new DateTime(2021, 11, 9, 15, 37, 5, 750, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, 2, new DateTime(2021, 5, 12, 8, 19, 52, 568, DateTimeKind.Local).AddTicks(1452), new DateTime(2021, 5, 21, 15, 51, 47, 127, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, 4, new DateTime(2021, 10, 4, 2, 58, 28, 507, DateTimeKind.Local).AddTicks(500), new DateTime(2021, 10, 25, 1, 30, 13, 156, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, new DateTime(2021, 6, 22, 21, 15, 2, 244, DateTimeKind.Local).AddTicks(8409), new DateTime(2021, 7, 12, 7, 37, 51, 356, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, new DateTime(2021, 7, 27, 18, 6, 0, 164, DateTimeKind.Local).AddTicks(9097), new DateTime(2021, 5, 19, 17, 19, 56, 934, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, 3, new DateTime(2021, 8, 9, 19, 48, 45, 904, DateTimeKind.Local).AddTicks(9286), new DateTime(2021, 5, 26, 5, 41, 40, 318, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 2, new DateTime(2021, 7, 27, 8, 38, 16, 572, DateTimeKind.Local).AddTicks(1297), new DateTime(2021, 11, 18, 5, 22, 44, 870, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, 2, new DateTime(2021, 7, 10, 1, 26, 52, 622, DateTimeKind.Local).AddTicks(2719), new DateTime(2021, 5, 22, 22, 40, 34, 620, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, 2, new DateTime(2021, 10, 15, 12, 24, 9, 982, DateTimeKind.Local).AddTicks(4806), new DateTime(2021, 7, 26, 12, 14, 2, 613, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 1, 1, new DateTime(2021, 11, 2, 21, 45, 52, 25, DateTimeKind.Local).AddTicks(7051), new DateTime(2021, 11, 17, 8, 55, 17, 702, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, 1, new DateTime(2021, 9, 11, 8, 43, 7, 849, DateTimeKind.Local).AddTicks(7558), new DateTime(2021, 7, 13, 2, 48, 3, 657, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, 4, new DateTime(2021, 11, 14, 22, 40, 20, 194, DateTimeKind.Local).AddTicks(1599), new DateTime(2021, 8, 24, 19, 29, 47, 318, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 4, 1, new DateTime(2021, 10, 14, 2, 42, 14, 828, DateTimeKind.Local).AddTicks(917), new DateTime(2021, 10, 11, 20, 3, 1, 222, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, 3, new DateTime(2021, 8, 15, 10, 14, 48, 253, DateTimeKind.Local).AddTicks(6273), new DateTime(2021, 8, 9, 14, 50, 38, 317, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 4, new DateTime(2021, 12, 12, 5, 14, 5, 343, DateTimeKind.Local).AddTicks(7110), new DateTime(2021, 5, 14, 4, 9, 40, 467, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 3, new DateTime(2021, 7, 7, 21, 27, 30, 744, DateTimeKind.Local).AddTicks(4016), new DateTime(2021, 8, 4, 4, 55, 46, 951, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, new DateTime(2021, 7, 13, 6, 26, 46, 524, DateTimeKind.Local).AddTicks(5843), new DateTime(2021, 7, 23, 7, 55, 48, 292, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, 5, new DateTime(2021, 10, 1, 4, 39, 7, 49, DateTimeKind.Local).AddTicks(156), new DateTime(2021, 7, 18, 18, 38, 18, 753, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, 1, new DateTime(2021, 5, 29, 0, 33, 20, 881, DateTimeKind.Local).AddTicks(7517), new DateTime(2021, 7, 8, 0, 0, 14, 426, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, 3, new DateTime(2021, 6, 22, 2, 26, 19, 41, DateTimeKind.Local).AddTicks(6606), new DateTime(2021, 10, 12, 9, 31, 47, 784, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 4, new DateTime(2021, 5, 15, 0, 9, 3, 127, DateTimeKind.Local).AddTicks(1997), new DateTime(2021, 8, 13, 20, 39, 11, 181, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, new DateTime(2021, 12, 16, 16, 50, 41, 908, DateTimeKind.Local).AddTicks(1619), new DateTime(2021, 7, 31, 21, 33, 58, 313, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, 4, new DateTime(2021, 8, 6, 10, 28, 41, 820, DateTimeKind.Local).AddTicks(1673), new DateTime(2021, 6, 28, 20, 0, 58, 307, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, new DateTime(2021, 11, 20, 23, 31, 14, 616, DateTimeKind.Local).AddTicks(9261), new DateTime(2021, 8, 10, 11, 34, 56, 430, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 3, new DateTime(2021, 7, 18, 18, 30, 33, 235, DateTimeKind.Local).AddTicks(39), new DateTime(2021, 11, 8, 10, 11, 31, 268, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, 5, new DateTime(2021, 7, 25, 15, 52, 51, 969, DateTimeKind.Local).AddTicks(3709), new DateTime(2021, 12, 16, 3, 36, 19, 585, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, 4, new DateTime(2021, 9, 16, 9, 51, 43, 782, DateTimeKind.Local).AddTicks(4556), new DateTime(2021, 6, 24, 0, 28, 9, 643, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, 3, new DateTime(2021, 12, 22, 10, 19, 37, 58, DateTimeKind.Local).AddTicks(7234), new DateTime(2021, 7, 20, 5, 45, 26, 898, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, new DateTime(2021, 11, 28, 4, 44, 39, 597, DateTimeKind.Local).AddTicks(383), new DateTime(2021, 8, 2, 1, 47, 36, 845, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 5, new DateTime(2021, 12, 25, 14, 13, 31, 363, DateTimeKind.Local).AddTicks(7562), new DateTime(2021, 12, 1, 13, 31, 32, 606, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, new DateTime(2021, 10, 21, 21, 8, 54, 301, DateTimeKind.Local).AddTicks(4140), new DateTime(2021, 11, 21, 10, 0, 33, 168, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, 1, new DateTime(2021, 6, 20, 18, 45, 0, 187, DateTimeKind.Local).AddTicks(6077), new DateTime(2021, 6, 7, 0, 7, 19, 679, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 6, 27, 16, 38, 54, 813, DateTimeKind.Local).AddTicks(5484), new DateTime(2021, 5, 18, 3, 39, 48, 77, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 2, new DateTime(2021, 11, 28, 14, 14, 37, 225, DateTimeKind.Local).AddTicks(4261), new DateTime(2021, 10, 12, 10, 9, 14, 524, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 4, new DateTime(2021, 12, 5, 22, 28, 54, 841, DateTimeKind.Local).AddTicks(4401), new DateTime(2021, 8, 19, 1, 15, 19, 372, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, 4, new DateTime(2021, 7, 28, 11, 38, 8, 149, DateTimeKind.Local).AddTicks(7242), new DateTime(2021, 12, 11, 5, 26, 51, 671, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 3, 5, new DateTime(2021, 8, 10, 7, 38, 15, 671, DateTimeKind.Local).AddTicks(2537), new DateTime(2021, 12, 21, 13, 22, 48, 222, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 1, new DateTime(2021, 8, 7, 6, 39, 24, 598, DateTimeKind.Local).AddTicks(401), new DateTime(2021, 9, 2, 3, 19, 15, 341, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, new DateTime(2021, 10, 19, 6, 14, 34, 258, DateTimeKind.Local).AddTicks(8301), new DateTime(2021, 6, 10, 8, 59, 8, 443, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 8, 27, 11, 46, 55, 268, DateTimeKind.Local).AddTicks(5532), new DateTime(2021, 6, 16, 7, 7, 23, 765, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, 1, new DateTime(2021, 7, 4, 10, 20, 19, 786, DateTimeKind.Local).AddTicks(9588), new DateTime(2021, 5, 14, 21, 15, 37, 114, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 5, new DateTime(2021, 5, 26, 4, 9, 34, 240, DateTimeKind.Local).AddTicks(757), new DateTime(2021, 12, 16, 11, 31, 38, 326, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, 1, new DateTime(2021, 7, 25, 5, 17, 7, 975, DateTimeKind.Local).AddTicks(6876), new DateTime(2021, 11, 9, 12, 29, 11, 530, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 1, new DateTime(2021, 7, 17, 13, 4, 0, 733, DateTimeKind.Local).AddTicks(1597), new DateTime(2021, 10, 7, 20, 1, 32, 406, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, new DateTime(2021, 8, 23, 15, 32, 33, 896, DateTimeKind.Local).AddTicks(5265), new DateTime(2021, 7, 17, 1, 28, 31, 659, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, 2, new DateTime(2021, 9, 6, 23, 17, 32, 835, DateTimeKind.Local).AddTicks(908), new DateTime(2021, 10, 30, 19, 0, 45, 113, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 7, 11, 7, 1, 45, 481, DateTimeKind.Local).AddTicks(2895), new DateTime(2021, 8, 25, 15, 38, 38, 136, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 3, 3, new DateTime(2021, 9, 11, 23, 33, 44, 646, DateTimeKind.Local).AddTicks(7761), new DateTime(2021, 10, 29, 1, 1, 10, 168, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 6, 30, 12, 47, 53, 358, DateTimeKind.Local).AddTicks(575), new DateTime(2021, 8, 18, 21, 8, 22, 834, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 4, new DateTime(2021, 11, 28, 21, 5, 6, 251, DateTimeKind.Local).AddTicks(4429), new DateTime(2021, 11, 16, 3, 42, 0, 467, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, 2, new DateTime(2021, 6, 25, 20, 15, 28, 80, DateTimeKind.Local).AddTicks(6901), new DateTime(2021, 11, 29, 18, 3, 23, 32, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 1, 4, new DateTime(2021, 12, 1, 3, 6, 2, 740, DateTimeKind.Local).AddTicks(2538), new DateTime(2021, 9, 21, 5, 43, 3, 217, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, new DateTime(2021, 5, 16, 18, 47, 29, 989, DateTimeKind.Local).AddTicks(8153), new DateTime(2021, 8, 20, 10, 12, 47, 224, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, 4, new DateTime(2021, 10, 30, 11, 59, 37, 437, DateTimeKind.Local).AddTicks(1461), new DateTime(2021, 9, 10, 3, 26, 7, 782, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, new DateTime(2021, 8, 28, 12, 45, 4, 198, DateTimeKind.Local).AddTicks(5187), new DateTime(2021, 6, 6, 18, 26, 29, 492, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 10, 10, 5, 49, 49, 233, DateTimeKind.Local).AddTicks(5433), new DateTime(2021, 5, 28, 10, 39, 20, 34, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CarrierId", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, new DateTime(2021, 6, 25, 17, 12, 16, 804, DateTimeKind.Local).AddTicks(7335), new DateTime(2021, 12, 1, 21, 55, 38, 861, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 4, 4, new DateTime(2021, 10, 4, 10, 7, 29, 148, DateTimeKind.Local).AddTicks(592), new DateTime(2021, 7, 11, 17, 21, 51, 788, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, 3, new DateTime(2021, 7, 11, 12, 51, 25, 40, DateTimeKind.Local).AddTicks(2864), new DateTime(2021, 11, 27, 21, 55, 7, 428, DateTimeKind.Local).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, new DateTime(2021, 9, 22, 10, 55, 36, 573, DateTimeKind.Local).AddTicks(9147), new DateTime(2021, 8, 14, 0, 19, 34, 577, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, 3, new DateTime(2021, 9, 20, 15, 51, 19, 153, DateTimeKind.Local).AddTicks(9641), new DateTime(2021, 5, 28, 13, 41, 4, 763, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, new DateTime(2021, 7, 10, 1, 55, 11, 422, DateTimeKind.Local).AddTicks(6097), new DateTime(2021, 8, 13, 3, 17, 0, 566, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 2, 4, new DateTime(2021, 11, 28, 2, 3, 17, 149, DateTimeKind.Local).AddTicks(2763), new DateTime(2021, 12, 11, 23, 53, 13, 984, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 2, new DateTime(2021, 7, 19, 21, 42, 4, 371, DateTimeKind.Local).AddTicks(166), new DateTime(2021, 7, 6, 14, 59, 12, 152, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, 5, new DateTime(2021, 6, 24, 20, 24, 36, 592, DateTimeKind.Local).AddTicks(4022), new DateTime(2021, 12, 6, 17, 18, 38, 634, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 3, new DateTime(2021, 6, 13, 9, 21, 36, 451, DateTimeKind.Local).AddTicks(7567), new DateTime(2021, 11, 26, 5, 35, 4, 452, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, 5, 4, new DateTime(2021, 6, 16, 3, 38, 27, 868, DateTimeKind.Local).AddTicks(225), new DateTime(2021, 9, 4, 23, 43, 43, 460, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, 2, new DateTime(2021, 9, 1, 18, 45, 10, 338, DateTimeKind.Local).AddTicks(2667), new DateTime(2021, 7, 23, 4, 3, 1, 441, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 12, 12, 11, 51, 43, 128, DateTimeKind.Local).AddTicks(1264), new DateTime(2021, 5, 13, 13, 25, 22, 98, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, new DateTime(2021, 12, 3, 13, 15, 11, 60, DateTimeKind.Local).AddTicks(2338), new DateTime(2021, 12, 30, 19, 51, 50, 278, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 9, 30, 1, 41, 14, 896, DateTimeKind.Local).AddTicks(6321), new DateTime(2021, 6, 6, 0, 36, 11, 940, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, 4, new DateTime(2021, 6, 18, 5, 4, 27, 277, DateTimeKind.Local).AddTicks(4562), new DateTime(2021, 12, 3, 17, 16, 28, 171, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 1, 5, new DateTime(2021, 9, 24, 19, 31, 43, 796, DateTimeKind.Local).AddTicks(8495), new DateTime(2021, 7, 11, 15, 54, 5, 848, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 5, 5, new DateTime(2021, 9, 28, 14, 27, 12, 876, DateTimeKind.Local).AddTicks(4856), new DateTime(2021, 11, 6, 18, 13, 27, 849, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, new DateTime(2021, 7, 28, 18, 33, 50, 372, DateTimeKind.Local).AddTicks(5433), new DateTime(2021, 11, 3, 20, 14, 1, 814, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, new DateTime(2021, 11, 29, 17, 17, 49, 364, DateTimeKind.Local).AddTicks(772), new DateTime(2021, 12, 25, 5, 26, 55, 505, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 4, 1, new DateTime(2021, 9, 8, 4, 17, 45, 736, DateTimeKind.Local).AddTicks(7981), new DateTime(2021, 12, 23, 16, 19, 53, 392, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 3, new DateTime(2021, 9, 4, 3, 37, 52, 264, DateTimeKind.Local).AddTicks(2474), new DateTime(2021, 12, 5, 22, 2, 28, 564, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 3, 5, new DateTime(2021, 9, 1, 22, 10, 1, 974, DateTimeKind.Local).AddTicks(3565), new DateTime(2021, 6, 15, 20, 57, 15, 896, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, 5, new DateTime(2021, 5, 28, 13, 23, 38, 624, DateTimeKind.Local).AddTicks(2014), new DateTime(2021, 8, 18, 17, 53, 38, 302, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 2, 3, new DateTime(2021, 6, 30, 11, 51, 9, 896, DateTimeKind.Local).AddTicks(5296), new DateTime(2021, 8, 13, 3, 23, 19, 135, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 4, new DateTime(2021, 9, 22, 8, 12, 35, 3, DateTimeKind.Local).AddTicks(7638), new DateTime(2021, 11, 8, 6, 2, 21, 567, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, 5, new DateTime(2021, 5, 30, 15, 56, 23, 234, DateTimeKind.Local).AddTicks(6981), new DateTime(2021, 5, 15, 21, 57, 20, 540, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 2, 2, new DateTime(2021, 12, 29, 13, 46, 22, 567, DateTimeKind.Local).AddTicks(8130), new DateTime(2021, 11, 2, 11, 36, 20, 111, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CarrierId", "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 3, 5, new DateTime(2021, 11, 5, 18, 56, 9, 839, DateTimeKind.Local).AddTicks(5909), new DateTime(2021, 7, 14, 12, 34, 17, 318, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ConsigneeId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, 2, new DateTime(2021, 8, 22, 14, 59, 46, 678, DateTimeKind.Local).AddTicks(2017), new DateTime(2021, 7, 13, 20, 2, 41, 573, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CarrierId", "ConsignorId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, 5, new DateTime(2021, 8, 4, 5, 39, 21, 185, DateTimeKind.Local).AddTicks(2374), new DateTime(2021, 12, 8, 14, 1, 58, 614, DateTimeKind.Local).AddTicks(8630) });
        }
    }
}
