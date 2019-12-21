using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OasisComputerSystems.API.Migrations
{
    public partial class UpdateTicketTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosedOn",
                table: "Tickets",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovedOn",
                table: "Tickets",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6a158eaf-6d9b-4511-985e-8a2b08a76f76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a2313849-5dfa-4d60-9aa8-a1389e5a5f42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "aaba3fc9-4340-4d42-82db-c48e44abf72e");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 18, 24, 52, 830, DateTimeKind.Local).AddTicks(4487));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosedOn",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovedOn",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 21, 12, 9, 21, 796, DateTimeKind.Local).AddTicks(1476));
        }
    }
}
