using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPManifest.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT35211-1", new DateTime(2021, 10, 19, 8, 58, 43, 891, DateTimeKind.Unspecified).AddTicks(2345), new DateTime(2021, 6, 1, 17, 15, 51, 181, DateTimeKind.Unspecified).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT66852-0", 5, new DateTime(2021, 11, 9, 18, 18, 55, 165, DateTimeKind.Unspecified).AddTicks(1469), new DateTime(2021, 8, 20, 1, 34, 46, 59, DateTimeKind.Unspecified).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT65346-0", 4, new DateTime(2021, 9, 6, 16, 25, 56, 875, DateTimeKind.Unspecified).AddTicks(2549), new DateTime(2021, 5, 27, 12, 39, 11, 768, DateTimeKind.Unspecified).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT10063-0", 4, new DateTime(2021, 11, 21, 6, 20, 37, 692, DateTimeKind.Unspecified).AddTicks(2714), new DateTime(2021, 8, 24, 13, 52, 7, 10, DateTimeKind.Unspecified).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT24620-1", 5, new DateTime(2021, 9, 4, 20, 9, 22, 957, DateTimeKind.Unspecified).AddTicks(3638), new DateTime(2021, 5, 25, 2, 29, 6, 589, DateTimeKind.Unspecified).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT55314-1", 3, new DateTime(2021, 11, 11, 7, 27, 53, 225, DateTimeKind.Unspecified).AddTicks(3632), new DateTime(2021, 6, 23, 18, 4, 25, 819, DateTimeKind.Unspecified).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT71835-1", 5, new DateTime(2021, 11, 6, 18, 59, 37, 259, DateTimeKind.Unspecified).AddTicks(5664), new DateTime(2021, 8, 28, 17, 31, 44, 849, DateTimeKind.Unspecified).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT83183-1", new DateTime(2021, 11, 24, 18, 35, 7, 536, DateTimeKind.Unspecified).AddTicks(2562), new DateTime(2021, 7, 10, 11, 10, 55, 629, DateTimeKind.Unspecified).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT97680-0", 5, new DateTime(2021, 9, 3, 3, 50, 42, 196, DateTimeKind.Unspecified).AddTicks(582), new DateTime(2021, 8, 3, 14, 5, 12, 469, DateTimeKind.Unspecified).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT48248-1", 4, new DateTime(2021, 10, 21, 3, 35, 31, 206, DateTimeKind.Unspecified).AddTicks(5513), new DateTime(2021, 5, 21, 22, 5, 55, 934, DateTimeKind.Unspecified).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT50562-1", 2, new DateTime(2021, 12, 21, 8, 24, 57, 945, DateTimeKind.Unspecified).AddTicks(3124), new DateTime(2021, 8, 30, 23, 33, 47, 273, DateTimeKind.Unspecified).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT98235-1", 1, new DateTime(2021, 11, 13, 2, 35, 25, 251, DateTimeKind.Unspecified).AddTicks(2543), new DateTime(2021, 6, 24, 0, 0, 2, 800, DateTimeKind.Unspecified).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT29360-1", 3, new DateTime(2021, 9, 11, 20, 58, 43, 636, DateTimeKind.Unspecified).AddTicks(559), new DateTime(2021, 7, 14, 12, 42, 1, 482, DateTimeKind.Unspecified).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT71871-1", 2, new DateTime(2021, 9, 7, 14, 25, 30, 87, DateTimeKind.Unspecified).AddTicks(8960), new DateTime(2021, 5, 18, 0, 43, 43, 811, DateTimeKind.Unspecified).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT13299-0", 2, new DateTime(2021, 11, 3, 17, 46, 14, 831, DateTimeKind.Unspecified).AddTicks(7435), new DateTime(2021, 6, 16, 1, 47, 26, 831, DateTimeKind.Unspecified).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT94377-1", 3, new DateTime(2021, 10, 20, 14, 42, 30, 797, DateTimeKind.Unspecified).AddTicks(4275), new DateTime(2021, 7, 10, 22, 51, 0, 59, DateTimeKind.Unspecified).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT28527-0", 5, new DateTime(2021, 11, 24, 21, 39, 30, 999, DateTimeKind.Unspecified).AddTicks(6482), new DateTime(2021, 7, 13, 15, 50, 40, 446, DateTimeKind.Unspecified).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT64768-1", 4, new DateTime(2021, 12, 2, 21, 28, 48, 722, DateTimeKind.Unspecified).AddTicks(7454), new DateTime(2021, 8, 14, 18, 39, 35, 845, DateTimeKind.Unspecified).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT58273-0", 2, new DateTime(2021, 11, 2, 18, 8, 25, 180, DateTimeKind.Unspecified).AddTicks(6337), new DateTime(2021, 6, 5, 2, 37, 44, 147, DateTimeKind.Unspecified).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT24926-0", 3, new DateTime(2021, 11, 9, 0, 26, 30, 654, DateTimeKind.Unspecified).AddTicks(5393), new DateTime(2021, 8, 4, 0, 8, 1, 793, DateTimeKind.Unspecified).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT72749-0", new DateTime(2021, 11, 19, 1, 51, 15, 916, DateTimeKind.Unspecified).AddTicks(1563), new DateTime(2021, 5, 29, 17, 2, 49, 169, DateTimeKind.Unspecified).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT24367-1", 3, new DateTime(2021, 11, 9, 16, 41, 5, 691, DateTimeKind.Unspecified).AddTicks(6898), new DateTime(2021, 8, 17, 22, 50, 48, 705, DateTimeKind.Unspecified).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT31188-1", 1, new DateTime(2021, 9, 29, 22, 56, 13, 761, DateTimeKind.Unspecified).AddTicks(859), new DateTime(2021, 7, 20, 14, 12, 35, 227, DateTimeKind.Unspecified).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT43216-1", 3, new DateTime(2021, 9, 1, 20, 54, 24, 89, DateTimeKind.Unspecified).AddTicks(2037), new DateTime(2021, 5, 12, 19, 45, 7, 899, DateTimeKind.Unspecified).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT31080-0", 3, new DateTime(2021, 10, 13, 19, 39, 59, 902, DateTimeKind.Unspecified).AddTicks(7940), new DateTime(2021, 6, 5, 22, 17, 10, 266, DateTimeKind.Unspecified).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT93430-1", new DateTime(2021, 9, 22, 11, 39, 15, 915, DateTimeKind.Unspecified).AddTicks(3976), new DateTime(2021, 6, 19, 4, 1, 54, 404, DateTimeKind.Unspecified).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT27212-0", 4, new DateTime(2021, 9, 8, 9, 45, 52, 10, DateTimeKind.Unspecified).AddTicks(742), new DateTime(2021, 6, 3, 14, 11, 9, 51, DateTimeKind.Unspecified).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT39694-0", 3, new DateTime(2021, 11, 15, 2, 58, 34, 981, DateTimeKind.Unspecified).AddTicks(5565), new DateTime(2021, 6, 14, 13, 12, 36, 958, DateTimeKind.Unspecified).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT54630-1", 3, new DateTime(2021, 9, 15, 10, 56, 35, 607, DateTimeKind.Unspecified).AddTicks(9801), new DateTime(2021, 8, 22, 2, 6, 37, 151, DateTimeKind.Unspecified).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT99990-0", 2, new DateTime(2021, 12, 8, 9, 32, 52, 59, DateTimeKind.Unspecified).AddTicks(9692), new DateTime(2021, 6, 15, 1, 45, 5, 750, DateTimeKind.Unspecified).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT22851-0", 3, new DateTime(2021, 12, 27, 15, 26, 38, 460, DateTimeKind.Unspecified).AddTicks(6376), new DateTime(2021, 5, 24, 14, 42, 9, 132, DateTimeKind.Unspecified).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT39703-1", 2, new DateTime(2021, 11, 12, 4, 45, 47, 878, DateTimeKind.Unspecified).AddTicks(2302), new DateTime(2021, 6, 17, 21, 42, 38, 204, DateTimeKind.Unspecified).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT62215-0", 3, new DateTime(2021, 11, 9, 19, 42, 3, 49, DateTimeKind.Unspecified).AddTicks(7020), new DateTime(2021, 5, 22, 10, 2, 50, 851, DateTimeKind.Unspecified).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT60504-1", new DateTime(2021, 11, 16, 13, 12, 16, 127, DateTimeKind.Unspecified).AddTicks(3778), new DateTime(2021, 6, 26, 10, 51, 20, 816, DateTimeKind.Unspecified).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT81242-1", new DateTime(2021, 9, 16, 2, 21, 32, 673, DateTimeKind.Unspecified).AddTicks(8346), new DateTime(2021, 6, 9, 16, 15, 29, 727, DateTimeKind.Unspecified).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT83567-1", 4, new DateTime(2021, 12, 30, 16, 43, 13, 387, DateTimeKind.Unspecified).AddTicks(1952), new DateTime(2021, 8, 18, 6, 2, 57, 59, DateTimeKind.Unspecified).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT56354-0", 2, new DateTime(2021, 10, 16, 9, 25, 29, 987, DateTimeKind.Unspecified).AddTicks(5328), new DateTime(2021, 6, 21, 10, 48, 0, 148, DateTimeKind.Unspecified).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT42757-1", 2, new DateTime(2021, 11, 10, 19, 55, 8, 186, DateTimeKind.Unspecified).AddTicks(593), new DateTime(2021, 7, 23, 7, 23, 4, 528, DateTimeKind.Unspecified).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT73441-0", new DateTime(2021, 12, 8, 10, 8, 40, 468, DateTimeKind.Unspecified).AddTicks(9166), new DateTime(2021, 8, 24, 8, 6, 27, 290, DateTimeKind.Unspecified).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT78773-0", 5, new DateTime(2021, 10, 26, 19, 14, 19, 379, DateTimeKind.Unspecified).AddTicks(5458), new DateTime(2021, 6, 10, 14, 49, 32, 370, DateTimeKind.Unspecified).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT98243-0", 4, new DateTime(2021, 11, 20, 18, 54, 53, 100, DateTimeKind.Unspecified).AddTicks(7375), new DateTime(2021, 5, 11, 4, 38, 11, 947, DateTimeKind.Unspecified).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT89605-1", 3, new DateTime(2021, 12, 16, 9, 39, 30, 70, DateTimeKind.Unspecified).AddTicks(7255), new DateTime(2021, 8, 30, 8, 7, 25, 198, DateTimeKind.Unspecified).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT33092-0", new DateTime(2021, 12, 4, 7, 8, 2, 690, DateTimeKind.Unspecified).AddTicks(5609), new DateTime(2021, 7, 7, 11, 30, 18, 983, DateTimeKind.Unspecified).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT43248-1", 1, new DateTime(2021, 12, 6, 0, 28, 25, 92, DateTimeKind.Unspecified).AddTicks(2208), new DateTime(2021, 6, 25, 11, 33, 15, 908, DateTimeKind.Unspecified).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT10743-0", new DateTime(2021, 11, 16, 23, 35, 56, 212, DateTimeKind.Unspecified).AddTicks(5780), new DateTime(2021, 5, 17, 9, 42, 8, 479, DateTimeKind.Unspecified).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT27440-1", new DateTime(2021, 9, 23, 3, 18, 51, 688, DateTimeKind.Unspecified).AddTicks(1742), new DateTime(2021, 7, 3, 17, 29, 41, 587, DateTimeKind.Unspecified).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT73712-0", new DateTime(2021, 12, 22, 10, 41, 20, 145, DateTimeKind.Unspecified).AddTicks(6750), new DateTime(2021, 5, 17, 7, 52, 1, 195, DateTimeKind.Unspecified).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT22364-0", 3, new DateTime(2021, 12, 13, 10, 1, 20, 652, DateTimeKind.Unspecified).AddTicks(1107), new DateTime(2021, 7, 7, 13, 13, 57, 78, DateTimeKind.Unspecified).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT71404-0", 4, new DateTime(2021, 10, 27, 10, 17, 46, 554, DateTimeKind.Unspecified).AddTicks(9108), new DateTime(2021, 7, 9, 13, 41, 21, 730, DateTimeKind.Unspecified).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT49728-1", 4, new DateTime(2021, 12, 30, 5, 1, 3, 134, DateTimeKind.Unspecified).AddTicks(1795), new DateTime(2021, 5, 22, 5, 50, 10, 689, DateTimeKind.Unspecified).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT92954-1", 4, new DateTime(2021, 10, 18, 12, 28, 15, 660, DateTimeKind.Unspecified).AddTicks(9101), new DateTime(2021, 6, 2, 16, 17, 40, 369, DateTimeKind.Unspecified).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT93309-0", 3, new DateTime(2021, 10, 6, 13, 56, 5, 292, DateTimeKind.Unspecified).AddTicks(2372), new DateTime(2021, 8, 27, 2, 7, 50, 578, DateTimeKind.Unspecified).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT24074-1", 4, new DateTime(2021, 9, 17, 4, 24, 38, 819, DateTimeKind.Unspecified).AddTicks(7338), new DateTime(2021, 6, 7, 22, 28, 58, 197, DateTimeKind.Unspecified).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT36747-1", new DateTime(2021, 12, 29, 23, 24, 50, 365, DateTimeKind.Unspecified).AddTicks(527), new DateTime(2021, 6, 1, 21, 31, 41, 791, DateTimeKind.Unspecified).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT91828-0", 1, new DateTime(2021, 12, 21, 5, 23, 36, 849, DateTimeKind.Unspecified).AddTicks(9113), new DateTime(2021, 6, 25, 1, 16, 7, 696, DateTimeKind.Unspecified).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT46087-1", 1, new DateTime(2021, 9, 12, 12, 58, 51, 878, DateTimeKind.Unspecified).AddTicks(7926), new DateTime(2021, 7, 24, 11, 45, 52, 278, DateTimeKind.Unspecified).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT34914-0", 1, new DateTime(2021, 9, 16, 15, 17, 10, 150, DateTimeKind.Unspecified).AddTicks(8653), new DateTime(2021, 6, 12, 19, 43, 23, 754, DateTimeKind.Unspecified).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT33454-1", new DateTime(2021, 12, 3, 4, 40, 9, 199, DateTimeKind.Unspecified).AddTicks(6003), new DateTime(2021, 8, 15, 19, 43, 48, 609, DateTimeKind.Unspecified).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT74934-0", new DateTime(2021, 10, 13, 16, 23, 53, 937, DateTimeKind.Unspecified).AddTicks(3178), new DateTime(2021, 7, 13, 7, 4, 33, 698, DateTimeKind.Unspecified).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT53712-0", 4, new DateTime(2021, 9, 7, 12, 33, 41, 125, DateTimeKind.Unspecified).AddTicks(8115), new DateTime(2021, 8, 19, 19, 1, 55, 897, DateTimeKind.Unspecified).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT40176-0", new DateTime(2021, 9, 16, 22, 35, 32, 161, DateTimeKind.Unspecified).AddTicks(1008), new DateTime(2021, 7, 9, 22, 16, 44, 996, DateTimeKind.Unspecified).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT26744-1", 1, new DateTime(2021, 12, 24, 3, 35, 38, 221, DateTimeKind.Unspecified).AddTicks(2789), new DateTime(2021, 8, 9, 13, 33, 39, 835, DateTimeKind.Unspecified).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT16229-0", 3, new DateTime(2021, 10, 29, 8, 53, 18, 318, DateTimeKind.Unspecified).AddTicks(2669), new DateTime(2021, 7, 19, 12, 36, 17, 182, DateTimeKind.Unspecified).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT88055-0", 2, new DateTime(2021, 9, 9, 2, 10, 22, 458, DateTimeKind.Unspecified).AddTicks(4392), new DateTime(2021, 8, 4, 1, 43, 35, 609, DateTimeKind.Unspecified).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT65273-1", new DateTime(2021, 11, 17, 20, 21, 32, 105, DateTimeKind.Unspecified).AddTicks(9339), new DateTime(2021, 5, 24, 12, 50, 3, 318, DateTimeKind.Unspecified).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT39352-1", new DateTime(2021, 12, 15, 15, 40, 10, 73, DateTimeKind.Unspecified).AddTicks(533), new DateTime(2021, 8, 4, 8, 36, 37, 677, DateTimeKind.Unspecified).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT23480-1", 1, new DateTime(2021, 10, 12, 6, 35, 31, 994, DateTimeKind.Unspecified).AddTicks(1199), new DateTime(2021, 6, 5, 9, 27, 27, 442, DateTimeKind.Unspecified).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT70312-0", 3, new DateTime(2021, 10, 17, 7, 57, 29, 700, DateTimeKind.Unspecified).AddTicks(1379), new DateTime(2021, 7, 13, 14, 5, 6, 250, DateTimeKind.Unspecified).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT90383-0", 2, new DateTime(2021, 10, 22, 13, 58, 6, 750, DateTimeKind.Unspecified).AddTicks(3192), new DateTime(2021, 8, 7, 6, 29, 5, 415, DateTimeKind.Unspecified).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT77729-0", 4, new DateTime(2021, 12, 6, 3, 7, 3, 424, DateTimeKind.Unspecified).AddTicks(9063), new DateTime(2021, 5, 14, 23, 35, 49, 189, DateTimeKind.Unspecified).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT88658-0", 2, new DateTime(2021, 9, 24, 22, 9, 14, 102, DateTimeKind.Unspecified).AddTicks(3894), new DateTime(2021, 6, 14, 4, 25, 0, 727, DateTimeKind.Unspecified).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT56827-0", 3, new DateTime(2021, 9, 6, 10, 25, 48, 315, DateTimeKind.Unspecified).AddTicks(4040), new DateTime(2021, 6, 3, 7, 22, 41, 751, DateTimeKind.Unspecified).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT36595-1", 2, new DateTime(2021, 11, 23, 22, 53, 9, 93, DateTimeKind.Unspecified).AddTicks(872), new DateTime(2021, 7, 17, 23, 9, 37, 425, DateTimeKind.Unspecified).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT57653-0", 1, new DateTime(2021, 9, 5, 10, 21, 48, 97, DateTimeKind.Unspecified).AddTicks(1936), new DateTime(2021, 8, 15, 3, 23, 9, 468, DateTimeKind.Unspecified).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT31921-0", 5, new DateTime(2021, 11, 27, 3, 40, 57, 541, DateTimeKind.Unspecified).AddTicks(517), new DateTime(2021, 6, 6, 16, 16, 45, 706, DateTimeKind.Unspecified).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT28061-0", 3, new DateTime(2021, 12, 8, 17, 56, 19, 294, DateTimeKind.Unspecified).AddTicks(2065), new DateTime(2021, 5, 21, 15, 7, 51, 413, DateTimeKind.Unspecified).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT96218-0", 4, new DateTime(2021, 11, 2, 23, 17, 41, 168, DateTimeKind.Unspecified).AddTicks(7484), new DateTime(2021, 8, 12, 18, 11, 48, 465, DateTimeKind.Unspecified).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT96190-0", 5, new DateTime(2021, 12, 21, 4, 25, 35, 939, DateTimeKind.Unspecified).AddTicks(378), new DateTime(2021, 8, 30, 0, 4, 21, 770, DateTimeKind.Unspecified).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT27725-1", 3, new DateTime(2021, 12, 7, 19, 10, 59, 510, DateTimeKind.Unspecified).AddTicks(8652), new DateTime(2021, 6, 21, 1, 21, 39, 759, DateTimeKind.Unspecified).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT65866-1", new DateTime(2021, 10, 5, 8, 49, 58, 77, DateTimeKind.Unspecified).AddTicks(3895), new DateTime(2021, 6, 1, 12, 11, 7, 900, DateTimeKind.Unspecified).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT43792-1", 5, new DateTime(2021, 12, 29, 23, 30, 58, 937, DateTimeKind.Unspecified).AddTicks(1837), new DateTime(2021, 6, 21, 8, 42, 24, 22, DateTimeKind.Unspecified).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT56790-1", 4, new DateTime(2021, 10, 19, 20, 8, 22, 868, DateTimeKind.Unspecified).AddTicks(5729), new DateTime(2021, 5, 8, 6, 14, 47, 71, DateTimeKind.Unspecified).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT95064-0", 3, new DateTime(2021, 11, 7, 4, 50, 56, 847, DateTimeKind.Unspecified).AddTicks(3048), new DateTime(2021, 8, 21, 11, 26, 24, 98, DateTimeKind.Unspecified).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT24240-1", 1, new DateTime(2021, 10, 27, 8, 36, 49, 640, DateTimeKind.Unspecified).AddTicks(7886), new DateTime(2021, 8, 7, 23, 32, 1, 959, DateTimeKind.Unspecified).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT36037-0", 5, new DateTime(2021, 9, 15, 10, 45, 9, 346, DateTimeKind.Unspecified).AddTicks(2424), new DateTime(2021, 8, 4, 17, 52, 30, 184, DateTimeKind.Unspecified).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT32264-1", 1, new DateTime(2021, 10, 9, 11, 2, 54, 419, DateTimeKind.Unspecified).AddTicks(6451), new DateTime(2021, 8, 26, 21, 11, 20, 560, DateTimeKind.Unspecified).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT74790-0", 5, new DateTime(2021, 9, 11, 16, 17, 45, 956, DateTimeKind.Unspecified).AddTicks(8553), new DateTime(2021, 8, 12, 0, 34, 1, 427, DateTimeKind.Unspecified).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT24636-1", 4, new DateTime(2021, 9, 24, 9, 17, 32, 27, DateTimeKind.Unspecified).AddTicks(6225), new DateTime(2021, 5, 11, 20, 27, 0, 419, DateTimeKind.Unspecified).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT45745-1", 1, new DateTime(2021, 10, 10, 6, 7, 12, 665, DateTimeKind.Unspecified).AddTicks(1750), new DateTime(2021, 5, 29, 15, 36, 45, 98, DateTimeKind.Unspecified).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT31245-0", 4, new DateTime(2021, 9, 20, 19, 30, 11, 623, DateTimeKind.Unspecified).AddTicks(1038), new DateTime(2021, 6, 24, 19, 12, 26, 130, DateTimeKind.Unspecified).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT22373-1", 1, new DateTime(2021, 10, 18, 6, 48, 16, 408, DateTimeKind.Unspecified).AddTicks(791), new DateTime(2021, 5, 27, 1, 48, 4, 835, DateTimeKind.Unspecified).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT46295-0", 2, new DateTime(2021, 11, 20, 9, 37, 59, 211, DateTimeKind.Unspecified).AddTicks(694), new DateTime(2021, 8, 23, 8, 13, 16, 7, DateTimeKind.Unspecified).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT67100-0", 1, new DateTime(2021, 9, 2, 22, 50, 22, 397, DateTimeKind.Unspecified).AddTicks(3910), new DateTime(2021, 8, 1, 4, 25, 21, 805, DateTimeKind.Unspecified).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT70816-0", 1, new DateTime(2021, 12, 7, 7, 34, 37, 850, DateTimeKind.Unspecified).AddTicks(8492), new DateTime(2021, 6, 13, 18, 3, 49, 149, DateTimeKind.Unspecified).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT13372-0", 3, new DateTime(2021, 10, 30, 13, 2, 41, 384, DateTimeKind.Unspecified).AddTicks(1663), new DateTime(2021, 6, 3, 6, 53, 1, 257, DateTimeKind.Unspecified).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT63474-0", 5, new DateTime(2021, 9, 4, 20, 29, 14, 558, DateTimeKind.Unspecified).AddTicks(7064), new DateTime(2021, 8, 2, 4, 11, 33, 935, DateTimeKind.Unspecified).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT96118-1", 4, new DateTime(2021, 11, 6, 21, 50, 37, 10, DateTimeKind.Unspecified).AddTicks(8017), new DateTime(2021, 7, 18, 18, 24, 39, 306, DateTimeKind.Unspecified).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT97089-0", 1, new DateTime(2021, 12, 20, 22, 33, 14, 824, DateTimeKind.Unspecified).AddTicks(6500), new DateTime(2021, 6, 20, 13, 42, 37, 707, DateTimeKind.Unspecified).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT34364-0", 4, new DateTime(2021, 9, 19, 14, 20, 2, 618, DateTimeKind.Unspecified).AddTicks(9016), new DateTime(2021, 7, 22, 18, 51, 28, 926, DateTimeKind.Unspecified).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT97769-0", 3, new DateTime(2021, 12, 22, 17, 59, 22, 614, DateTimeKind.Unspecified).AddTicks(9181), new DateTime(2021, 7, 15, 22, 15, 43, 487, DateTimeKind.Unspecified).AddTicks(408) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT52628-1", new DateTime(2021, 11, 20, 7, 6, 1, 605, DateTimeKind.Unspecified).AddTicks(377), new DateTime(2021, 7, 30, 23, 22, 51, 478, DateTimeKind.Unspecified).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT91597-0", 4, new DateTime(2021, 9, 7, 11, 32, 15, 316, DateTimeKind.Unspecified).AddTicks(8741), new DateTime(2021, 5, 21, 0, 4, 59, 234, DateTimeKind.Unspecified).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT10554-1", 2, new DateTime(2021, 11, 2, 8, 2, 32, 401, DateTimeKind.Unspecified).AddTicks(6545), new DateTime(2021, 5, 11, 15, 59, 12, 338, DateTimeKind.Unspecified).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT32295-0", 5, new DateTime(2021, 10, 12, 5, 39, 58, 400, DateTimeKind.Unspecified).AddTicks(1299), new DateTime(2021, 6, 6, 21, 59, 21, 506, DateTimeKind.Unspecified).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT41745-1", 3, new DateTime(2021, 11, 12, 19, 53, 26, 321, DateTimeKind.Unspecified).AddTicks(3533), new DateTime(2021, 8, 14, 20, 44, 59, 959, DateTimeKind.Unspecified).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT14452-0", 5, new DateTime(2021, 11, 11, 18, 48, 11, 233, DateTimeKind.Unspecified).AddTicks(719), new DateTime(2021, 6, 11, 0, 7, 55, 276, DateTimeKind.Unspecified).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT21694-1", 4, new DateTime(2021, 12, 10, 1, 32, 16, 446, DateTimeKind.Unspecified).AddTicks(2953), new DateTime(2021, 7, 16, 9, 13, 40, 77, DateTimeKind.Unspecified).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT40865-1", new DateTime(2021, 10, 27, 10, 10, 6, 105, DateTimeKind.Unspecified).AddTicks(645), new DateTime(2021, 8, 12, 14, 44, 50, 46, DateTimeKind.Unspecified).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT13101-0", 3, new DateTime(2021, 12, 5, 22, 48, 48, 946, DateTimeKind.Unspecified).AddTicks(5601), new DateTime(2021, 7, 9, 5, 32, 47, 952, DateTimeKind.Unspecified).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT74740-0", 2, new DateTime(2021, 12, 2, 5, 49, 21, 45, DateTimeKind.Unspecified).AddTicks(8010), new DateTime(2021, 6, 13, 21, 8, 57, 335, DateTimeKind.Unspecified).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT23078-0", 3, new DateTime(2021, 9, 2, 18, 26, 53, 924, DateTimeKind.Unspecified).AddTicks(4091), new DateTime(2021, 6, 12, 0, 15, 3, 113, DateTimeKind.Unspecified).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT27709-0", 2, new DateTime(2021, 10, 20, 1, 14, 39, 584, DateTimeKind.Unspecified).AddTicks(8778), new DateTime(2021, 7, 2, 7, 7, 44, 88, DateTimeKind.Unspecified).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT77639-0", 4, new DateTime(2021, 10, 7, 15, 25, 35, 79, DateTimeKind.Unspecified).AddTicks(3680), new DateTime(2021, 5, 11, 16, 37, 21, 32, DateTimeKind.Unspecified).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT50037-1", 1, new DateTime(2021, 10, 31, 11, 35, 46, 744, DateTimeKind.Unspecified).AddTicks(5747), new DateTime(2021, 8, 12, 18, 20, 49, 446, DateTimeKind.Unspecified).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT15015-0", 3, new DateTime(2021, 9, 24, 20, 23, 9, 84, DateTimeKind.Unspecified).AddTicks(1647), new DateTime(2021, 8, 15, 16, 23, 39, 671, DateTimeKind.Unspecified).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT39032-1", 2, new DateTime(2021, 11, 9, 6, 48, 59, 675, DateTimeKind.Unspecified).AddTicks(8388), new DateTime(2021, 7, 30, 15, 49, 16, 838, DateTimeKind.Unspecified).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT39526-0", 4, new DateTime(2021, 10, 21, 20, 1, 24, 784, DateTimeKind.Unspecified).AddTicks(4594), new DateTime(2021, 6, 29, 7, 12, 29, 564, DateTimeKind.Unspecified).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT30720-0", 5, new DateTime(2021, 9, 21, 2, 39, 44, 955, DateTimeKind.Unspecified).AddTicks(5388), new DateTime(2021, 8, 25, 6, 59, 3, 962, DateTimeKind.Unspecified).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT13651-1", 1, new DateTime(2021, 11, 14, 23, 8, 52, 603, DateTimeKind.Unspecified).AddTicks(7616), new DateTime(2021, 8, 18, 22, 11, 32, 502, DateTimeKind.Unspecified).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT67112-0", 1, new DateTime(2021, 12, 25, 18, 46, 29, 768, DateTimeKind.Unspecified).AddTicks(821), new DateTime(2021, 5, 10, 4, 50, 22, 548, DateTimeKind.Unspecified).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT51157-0", new DateTime(2021, 11, 23, 13, 57, 8, 3, DateTimeKind.Unspecified).AddTicks(216), new DateTime(2021, 6, 16, 4, 51, 28, 266, DateTimeKind.Unspecified).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT18964-1", 4, new DateTime(2021, 12, 2, 10, 45, 15, 731, DateTimeKind.Unspecified).AddTicks(5226), new DateTime(2021, 8, 3, 20, 8, 0, 100, DateTimeKind.Unspecified).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT68496-1", 2, new DateTime(2021, 10, 27, 22, 9, 12, 781, DateTimeKind.Unspecified).AddTicks(7770), new DateTime(2021, 8, 10, 12, 0, 18, 716, DateTimeKind.Unspecified).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT65878-1", 2, new DateTime(2021, 9, 29, 23, 5, 9, 604, DateTimeKind.Unspecified).AddTicks(8906), new DateTime(2021, 5, 10, 16, 7, 31, 691, DateTimeKind.Unspecified).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT21755-0", 5, new DateTime(2021, 11, 16, 17, 30, 32, 786, DateTimeKind.Unspecified).AddTicks(6818), new DateTime(2021, 6, 19, 4, 4, 27, 940, DateTimeKind.Unspecified).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT44494-0", new DateTime(2021, 10, 9, 22, 32, 36, 511, DateTimeKind.Unspecified).AddTicks(6411), new DateTime(2021, 6, 25, 18, 17, 41, 100, DateTimeKind.Unspecified).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT88022-0", 1, new DateTime(2021, 9, 25, 5, 3, 2, 865, DateTimeKind.Unspecified).AddTicks(8978), new DateTime(2021, 5, 12, 17, 38, 34, 591, DateTimeKind.Unspecified).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT56686-1", 5, new DateTime(2021, 10, 11, 2, 33, 53, 38, DateTimeKind.Unspecified).AddTicks(9602), new DateTime(2021, 6, 13, 13, 20, 16, 922, DateTimeKind.Unspecified).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT43584-1", 2, new DateTime(2021, 9, 13, 14, 34, 44, 24, DateTimeKind.Unspecified).AddTicks(8233), new DateTime(2021, 6, 20, 11, 45, 12, 773, DateTimeKind.Unspecified).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT60370-0", 1, new DateTime(2021, 12, 29, 7, 46, 48, 899, DateTimeKind.Unspecified).AddTicks(2279), new DateTime(2021, 8, 20, 11, 4, 38, 4, DateTimeKind.Unspecified).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT81609-0", 2, new DateTime(2021, 10, 23, 14, 38, 12, 80, DateTimeKind.Unspecified).AddTicks(3032), new DateTime(2021, 8, 7, 14, 26, 41, 30, DateTimeKind.Unspecified).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT56359-1", 1, new DateTime(2021, 11, 16, 6, 55, 34, 574, DateTimeKind.Unspecified).AddTicks(5218), new DateTime(2021, 8, 12, 16, 21, 39, 155, DateTimeKind.Unspecified).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT49630-0", 5, new DateTime(2021, 9, 20, 15, 50, 25, 182, DateTimeKind.Unspecified).AddTicks(2901), new DateTime(2021, 8, 16, 7, 43, 54, 867, DateTimeKind.Unspecified).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT43814-1", new DateTime(2021, 10, 24, 4, 59, 56, 665, DateTimeKind.Unspecified).AddTicks(167), new DateTime(2021, 6, 13, 0, 6, 28, 719, DateTimeKind.Unspecified).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT42627-1", new DateTime(2021, 10, 14, 7, 8, 9, 474, DateTimeKind.Unspecified).AddTicks(4710), new DateTime(2021, 5, 23, 16, 13, 58, 997, DateTimeKind.Unspecified).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT29086-1", 2, new DateTime(2021, 11, 15, 23, 11, 2, 522, DateTimeKind.Unspecified).AddTicks(9524), new DateTime(2021, 6, 22, 3, 29, 26, 658, DateTimeKind.Unspecified).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT83485-1", 1, new DateTime(2021, 10, 15, 0, 46, 37, 850, DateTimeKind.Unspecified).AddTicks(6474), new DateTime(2021, 8, 6, 13, 5, 19, 901, DateTimeKind.Unspecified).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT27275-0", 1, new DateTime(2021, 12, 24, 9, 49, 10, 254, DateTimeKind.Unspecified).AddTicks(7444), new DateTime(2021, 6, 9, 0, 46, 33, 196, DateTimeKind.Unspecified).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT30737-0", new DateTime(2021, 9, 10, 16, 54, 8, 544, DateTimeKind.Unspecified).AddTicks(2132), new DateTime(2021, 8, 23, 21, 13, 50, 78, DateTimeKind.Unspecified).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT95435-0", 1, new DateTime(2021, 9, 16, 23, 44, 7, 472, DateTimeKind.Unspecified).AddTicks(6777), new DateTime(2021, 7, 21, 20, 13, 43, 770, DateTimeKind.Unspecified).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT53554-0", 5, new DateTime(2021, 10, 5, 19, 17, 14, 549, DateTimeKind.Unspecified).AddTicks(6277), new DateTime(2021, 7, 28, 22, 28, 56, 504, DateTimeKind.Unspecified).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT41282-0", 1, new DateTime(2021, 10, 15, 9, 38, 35, 900, DateTimeKind.Unspecified).AddTicks(2287), new DateTime(2021, 6, 20, 18, 28, 36, 891, DateTimeKind.Unspecified).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT18843-1", new DateTime(2021, 12, 14, 14, 28, 18, 508, DateTimeKind.Unspecified).AddTicks(649), new DateTime(2021, 6, 19, 17, 50, 52, 419, DateTimeKind.Unspecified).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT41814-1", 2, new DateTime(2021, 12, 3, 14, 59, 43, 771, DateTimeKind.Unspecified).AddTicks(2658), new DateTime(2021, 8, 21, 3, 31, 16, 47, DateTimeKind.Unspecified).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT24760-0", new DateTime(2021, 9, 20, 10, 11, 46, 337, DateTimeKind.Unspecified).AddTicks(6732), new DateTime(2021, 5, 18, 21, 16, 29, 217, DateTimeKind.Unspecified).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT57478-1", new DateTime(2021, 10, 21, 10, 55, 30, 357, DateTimeKind.Unspecified).AddTicks(364), new DateTime(2021, 8, 24, 15, 56, 31, 424, DateTimeKind.Unspecified).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT59162-0", new DateTime(2021, 12, 16, 17, 46, 43, 906, DateTimeKind.Unspecified).AddTicks(5003), new DateTime(2021, 6, 10, 18, 8, 23, 637, DateTimeKind.Unspecified).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT91491-1", 5, new DateTime(2021, 12, 29, 22, 36, 36, 633, DateTimeKind.Unspecified).AddTicks(2517), new DateTime(2021, 8, 13, 15, 13, 52, 115, DateTimeKind.Unspecified).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT13545-0", 5, new DateTime(2021, 12, 22, 10, 58, 27, 79, DateTimeKind.Unspecified).AddTicks(8358), new DateTime(2021, 7, 14, 21, 21, 17, 212, DateTimeKind.Unspecified).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT77165-0", 3, new DateTime(2021, 10, 25, 4, 3, 47, 42, DateTimeKind.Unspecified).AddTicks(6967), new DateTime(2021, 7, 18, 0, 48, 1, 864, DateTimeKind.Unspecified).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT70541-0", 2, new DateTime(2021, 11, 1, 11, 2, 52, 487, DateTimeKind.Unspecified).AddTicks(3683), new DateTime(2021, 7, 29, 14, 49, 19, 173, DateTimeKind.Unspecified).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT56111-0", 1, new DateTime(2021, 12, 26, 7, 58, 36, 991, DateTimeKind.Unspecified).AddTicks(222), new DateTime(2021, 5, 22, 13, 43, 30, 575, DateTimeKind.Unspecified).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT21554-1", 3, new DateTime(2021, 12, 22, 12, 18, 39, 553, DateTimeKind.Unspecified).AddTicks(710), new DateTime(2021, 5, 19, 11, 37, 35, 366, DateTimeKind.Unspecified).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT81262-0", new DateTime(2021, 12, 9, 0, 27, 22, 933, DateTimeKind.Unspecified).AddTicks(9178), new DateTime(2021, 5, 26, 18, 43, 9, 527, DateTimeKind.Unspecified).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT37016-0", 2, new DateTime(2021, 10, 27, 10, 6, 15, 726, DateTimeKind.Unspecified).AddTicks(7928), new DateTime(2021, 5, 29, 8, 47, 4, 825, DateTimeKind.Unspecified).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT96484-1", 4, new DateTime(2021, 9, 18, 23, 38, 10, 275, DateTimeKind.Unspecified).AddTicks(2587), new DateTime(2021, 5, 22, 11, 33, 45, 166, DateTimeKind.Unspecified).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT62238-0", 2, new DateTime(2021, 11, 22, 14, 52, 48, 683, DateTimeKind.Unspecified).AddTicks(8370), new DateTime(2021, 6, 13, 4, 3, 10, 427, DateTimeKind.Unspecified).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT99036-0", new DateTime(2021, 9, 5, 6, 59, 24, 923, DateTimeKind.Unspecified).AddTicks(3831), new DateTime(2021, 5, 20, 8, 25, 32, 9, DateTimeKind.Unspecified).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT55136-0", new DateTime(2021, 10, 4, 22, 41, 50, 59, DateTimeKind.Unspecified).AddTicks(5542), new DateTime(2021, 6, 5, 23, 45, 48, 345, DateTimeKind.Unspecified).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT12867-0", 5, new DateTime(2021, 10, 22, 15, 0, 36, 712, DateTimeKind.Unspecified).AddTicks(5197), new DateTime(2021, 7, 13, 15, 0, 19, 314, DateTimeKind.Unspecified).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT30305-1", new DateTime(2021, 11, 15, 13, 8, 37, 786, DateTimeKind.Unspecified).AddTicks(9004), new DateTime(2021, 7, 23, 5, 33, 53, 728, DateTimeKind.Unspecified).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT25196-1", 3, new DateTime(2021, 9, 9, 22, 43, 52, 978, DateTimeKind.Unspecified).AddTicks(8634), new DateTime(2021, 8, 22, 4, 13, 2, 2, DateTimeKind.Unspecified).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT69743-0", 1, new DateTime(2021, 11, 30, 11, 25, 50, 42, DateTimeKind.Unspecified).AddTicks(9628), new DateTime(2021, 7, 19, 22, 56, 35, 236, DateTimeKind.Unspecified).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT70185-0", 1, new DateTime(2021, 12, 24, 3, 4, 26, 716, DateTimeKind.Unspecified).AddTicks(801), new DateTime(2021, 6, 25, 17, 22, 5, 683, DateTimeKind.Unspecified).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT17878-0", new DateTime(2021, 9, 10, 7, 25, 42, 862, DateTimeKind.Unspecified).AddTicks(5216), new DateTime(2021, 6, 6, 12, 5, 59, 429, DateTimeKind.Unspecified).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT25034-0", new DateTime(2021, 11, 28, 0, 15, 13, 282, DateTimeKind.Unspecified).AddTicks(2726), new DateTime(2021, 6, 5, 13, 35, 20, 116, DateTimeKind.Unspecified).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT73217-0", 4, new DateTime(2021, 10, 3, 8, 38, 0, 992, DateTimeKind.Unspecified).AddTicks(4434), new DateTime(2021, 7, 30, 23, 0, 56, 770, DateTimeKind.Unspecified).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT64586-0", 2, new DateTime(2021, 12, 23, 1, 11, 10, 105, DateTimeKind.Unspecified).AddTicks(4667), new DateTime(2021, 8, 15, 4, 9, 13, 812, DateTimeKind.Unspecified).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT33212-0", 3, new DateTime(2021, 9, 22, 13, 10, 0, 369, DateTimeKind.Unspecified).AddTicks(8361), new DateTime(2021, 8, 9, 16, 27, 19, 963, DateTimeKind.Unspecified).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT31806-1", 1, new DateTime(2021, 9, 28, 14, 30, 10, 192, DateTimeKind.Unspecified).AddTicks(7538), new DateTime(2021, 6, 28, 12, 51, 31, 748, DateTimeKind.Unspecified).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT43668-1", 3, new DateTime(2021, 12, 9, 23, 20, 0, 870, DateTimeKind.Unspecified).AddTicks(7065), new DateTime(2021, 5, 20, 21, 40, 13, 919, DateTimeKind.Unspecified).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT66463-1", 1, new DateTime(2021, 9, 22, 20, 59, 10, 702, DateTimeKind.Unspecified).AddTicks(8574), new DateTime(2021, 5, 11, 12, 26, 2, 43, DateTimeKind.Unspecified).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT99555-0", 4, new DateTime(2021, 9, 25, 8, 53, 38, 745, DateTimeKind.Unspecified).AddTicks(3136), new DateTime(2021, 7, 20, 15, 21, 33, 918, DateTimeKind.Unspecified).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT66150-1", 3, new DateTime(2021, 12, 25, 21, 9, 51, 519, DateTimeKind.Unspecified).AddTicks(1767), new DateTime(2021, 6, 6, 5, 21, 57, 986, DateTimeKind.Unspecified).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT69611-1", 2, new DateTime(2021, 10, 3, 15, 3, 51, 844, DateTimeKind.Unspecified).AddTicks(8349), new DateTime(2021, 7, 15, 15, 58, 9, 373, DateTimeKind.Unspecified).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT60750-1", 1, new DateTime(2021, 9, 9, 20, 45, 59, 344, DateTimeKind.Unspecified).AddTicks(836), new DateTime(2021, 5, 25, 9, 11, 17, 451, DateTimeKind.Unspecified).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT71562-0", 1, new DateTime(2021, 9, 5, 14, 12, 41, 974, DateTimeKind.Unspecified).AddTicks(3794), new DateTime(2021, 7, 24, 21, 43, 38, 504, DateTimeKind.Unspecified).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT87840-1", 2, new DateTime(2021, 11, 21, 5, 7, 22, 687, DateTimeKind.Unspecified).AddTicks(4619), new DateTime(2021, 6, 4, 11, 4, 23, 740, DateTimeKind.Unspecified).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT55621-0", 2, new DateTime(2021, 11, 20, 12, 20, 57, 472, DateTimeKind.Unspecified).AddTicks(575), new DateTime(2021, 6, 24, 12, 42, 6, 16, DateTimeKind.Unspecified).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CarrierId", "Code", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT69018-0", new DateTime(2021, 9, 22, 15, 50, 2, 601, DateTimeKind.Unspecified).AddTicks(2418), new DateTime(2021, 7, 26, 7, 28, 47, 812, DateTimeKind.Unspecified).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT58944-0", 2, new DateTime(2021, 10, 15, 5, 1, 13, 941, DateTimeKind.Unspecified).AddTicks(1215), new DateTime(2021, 7, 31, 2, 35, 30, 237, DateTimeKind.Unspecified).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT25776-0", 5, new DateTime(2021, 10, 17, 16, 30, 24, 621, DateTimeKind.Unspecified).AddTicks(1373), new DateTime(2021, 6, 3, 18, 46, 54, 914, DateTimeKind.Unspecified).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 3, "YT18220-0", 1, new DateTime(2021, 10, 6, 6, 25, 18, 314, DateTimeKind.Unspecified).AddTicks(5273), new DateTime(2021, 6, 28, 20, 57, 23, 88, DateTimeKind.Unspecified).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT72049-0", 4, new DateTime(2021, 10, 3, 21, 3, 2, 677, DateTimeKind.Unspecified).AddTicks(4592), new DateTime(2021, 8, 3, 13, 57, 38, 760, DateTimeKind.Unspecified).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT93812-1", 2, new DateTime(2021, 9, 12, 6, 9, 7, 241, DateTimeKind.Unspecified).AddTicks(3792), new DateTime(2021, 8, 15, 21, 51, 17, 273, DateTimeKind.Unspecified).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT70351-0", 3, new DateTime(2021, 10, 9, 13, 4, 4, 725, DateTimeKind.Unspecified).AddTicks(2150), new DateTime(2021, 8, 25, 4, 0, 6, 574, DateTimeKind.Unspecified).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT82955-0", 2, new DateTime(2021, 12, 2, 23, 5, 39, 816, DateTimeKind.Unspecified).AddTicks(6358), new DateTime(2021, 5, 14, 17, 29, 32, 908, DateTimeKind.Unspecified).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT71098-1", 1, new DateTime(2021, 10, 5, 4, 24, 9, 511, DateTimeKind.Unspecified).AddTicks(9467), new DateTime(2021, 8, 16, 3, 11, 42, 998, DateTimeKind.Unspecified).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT60410-0", 4, new DateTime(2021, 10, 2, 14, 19, 8, 608, DateTimeKind.Unspecified).AddTicks(2511), new DateTime(2021, 8, 23, 16, 6, 10, 62, DateTimeKind.Unspecified).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT53614-1", 3, new DateTime(2021, 9, 16, 16, 10, 55, 553, DateTimeKind.Unspecified).AddTicks(7704), new DateTime(2021, 8, 15, 21, 3, 6, 256, DateTimeKind.Unspecified).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT20209-1", 4, new DateTime(2021, 9, 22, 2, 56, 50, 449, DateTimeKind.Unspecified).AddTicks(9971), new DateTime(2021, 8, 22, 15, 28, 7, 970, DateTimeKind.Unspecified).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 4, "YT83891-0", 1, new DateTime(2021, 10, 17, 16, 41, 54, 753, DateTimeKind.Unspecified).AddTicks(1014), new DateTime(2021, 7, 30, 5, 42, 15, 649, DateTimeKind.Unspecified).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT15417-1", 2, new DateTime(2021, 12, 13, 3, 55, 51, 248, DateTimeKind.Unspecified).AddTicks(533), new DateTime(2021, 8, 23, 5, 15, 14, 243, DateTimeKind.Unspecified).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT26130-1", 4, new DateTime(2021, 11, 30, 10, 36, 34, 314, DateTimeKind.Unspecified).AddTicks(5155), new DateTime(2021, 8, 5, 16, 40, 15, 90, DateTimeKind.Unspecified).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT53737-1", 1, new DateTime(2021, 9, 3, 0, 22, 36, 168, DateTimeKind.Unspecified).AddTicks(8668), new DateTime(2021, 6, 28, 8, 13, 56, 711, DateTimeKind.Unspecified).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 1, "YT74911-1", 1, new DateTime(2021, 9, 28, 0, 25, 19, 690, DateTimeKind.Unspecified).AddTicks(1284), new DateTime(2021, 8, 6, 18, 55, 8, 335, DateTimeKind.Unspecified).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT24990-1", 5, new DateTime(2021, 11, 25, 23, 9, 57, 769, DateTimeKind.Unspecified).AddTicks(1696), new DateTime(2021, 5, 23, 3, 2, 26, 382, DateTimeKind.Unspecified).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 2, "YT19089-1", 2, new DateTime(2021, 9, 19, 2, 49, 19, 718, DateTimeKind.Unspecified).AddTicks(1025), new DateTime(2021, 5, 13, 20, 51, 24, 28, DateTimeKind.Unspecified).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { "YT90199-1", 1, new DateTime(2021, 12, 17, 15, 59, 37, 905, DateTimeKind.Unspecified).AddTicks(5044), new DateTime(2021, 8, 5, 6, 51, 9, 56, DateTimeKind.Unspecified).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Manifests",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CarrierId", "Code", "ConsigneeId", "DateScheduledArrival", "DateShipped" },
                values: new object[] { 5, "YT45858-0", 1, new DateTime(2021, 10, 15, 12, 39, 39, 567, DateTimeKind.Unspecified).AddTicks(4402), new DateTime(2021, 6, 24, 12, 45, 31, 525, DateTimeKind.Unspecified).AddTicks(2175) });
        }
    }
}
