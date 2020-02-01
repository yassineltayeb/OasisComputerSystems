using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OasisComputerSystems.API.Migrations
{
    public partial class AmendClientsModulesToClientModulesInClientsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fd0ecd64-bd3e-47ec-9dce-38afd465cdf4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "53b26590-d65b-4c59-9ca9-54a98ba4f3c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0a5559d2-2b4d-44c9-ab0b-698c52a941a9");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 29, 21, 9, 37, 915, DateTimeKind.Local).AddTicks(6190));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4a1941cc-8fcc-459e-a4f3-2b3850b26119");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "88c5ad32-f292-44d2-b0ca-61c2d5f85ee2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d0cf974b-f350-4573-a5cb-b9be1c134d56");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 36, 9, 962, DateTimeKind.Local).AddTicks(4314));
        }
    }
}
