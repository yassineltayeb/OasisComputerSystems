using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OasisComputerSystems.API.Migrations
{
    public partial class SeedClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "74d3b12f-c59d-479d-89b3-496b1ba2c2f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e44b64f5-124d-41f1-8be7-f23e99e40398");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f01619e5-3873-4488-a04f-7b80e4122e75");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CountryId", "CreatedById", "CreatedOn", "DeletedById", "DeletedOn", "IsDeleted", "NameAr", "NameEn", "TechnicalDetails", "TelephoneNumber", "UpdatedById", "UpdatedOn", "VATNo" },
                values: new object[,]
                {
                    { 15, "Sudan - Khartoum", 1, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1476), null, null, false, "سويسس", "Swiss", "Details 15", "1515", null, null, "15" },
                    { 14, "Sudan - Khartoum", 1, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1471), null, null, false, "النيلين للتأمين", "Elnilein Insurance Company", "Details 14", "1414", null, null, "14" },
                    { 13, "Saudi Arabia - Jeddah", 2, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1465), null, null, false, "حازم", "Hazim", "Details 13", "1313", null, null, "13" },
                    { 12, "Saudi Arabia - Jeddah", 2, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1458), null, null, false, "رؤية الوسيط", "Broker Vision", "Details 12", "1212", null, null, "12" },
                    { 11, "Saudi Arabia - Riyadh", 2, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1453), null, null, false, "بروكر كير", "Broker Care", "Details 11", "1111", null, null, "11" },
                    { 10, "Saudi Arabia - Jeddah", 2, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1410), null, null, false, "كونكورد", "Concord", "Details 10", "1010", null, null, "10" },
                    { 9, "Saudi Arabia - Riyadh", 2, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1404), null, null, false, "افق", "Ofooq", "Details 99", "99", null, null, "9" },
                    { 7, "UAE - Dubai", 4, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1393), null, null, false, "المنارة", "Al Manarah", "Details 7", "77", null, null, "7" },
                    { 6, "UAE - Dubai", 4, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1387), null, null, false, "الحماية", "Alhimaya", "Details 6", "66", null, null, "6" },
                    { 5, "Saudi Arabia - Jeddah", 2, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1381), null, null, false, "قروب ميد", "GMIB", "Details 5", "55", null, null, "5" },
                    { 4, "Lebanon - Beirut", 3, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1352), null, null, false, "قروب ميد", "GMRB", "Details 4", "44", null, null, "4" },
                    { 3, "Lebanon - Beirut", 3, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1345), null, null, false, "بلاتينيوم", "Platinum", "Details 3", "33", null, null, "3" },
                    { 2, "Saudi Arabia - Jeddah", 2, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1337), null, null, false, "مسارات", "Masarat", "Details 2", "22", null, null, "2" },
                    { 8, "Saudi Arabia - Jeddah", 2, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1399), null, null, false, "اب بلس", "APPlus", "Details 8", "88", null, null, "8" },
                    { 1, "Mauritius - Port Louis", 6, 1, new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1178), null, null, false, "وسيط المدينة", "City Brokers", "Details 1", "11", null, null, "1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5b598fa4-da72-4e1b-9aa4-617f9b63df95");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b182b802-5af3-43b3-b39f-dcb4e7df35e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c1826220-34b4-4f37-8cd9-cc3950afe00b");
        }
    }
}
