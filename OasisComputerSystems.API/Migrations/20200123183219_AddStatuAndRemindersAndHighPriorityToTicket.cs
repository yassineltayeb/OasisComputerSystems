using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OasisComputerSystems.API.Migrations
{
    public partial class AddStatuAndRemindersAndHighPriorityToTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HighPriority",
                table: "Tickets",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Reminders",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Tickets",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "474466a1-69c3-4475-b075-423c021fcb68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c3ecf0b4-0bb4-4b63-8a1c-5fe3df2c8f48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "368d6970-3283-4e1c-93a6-c622b3f290e5");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 23, 20, 32, 18, 963, DateTimeKind.Local).AddTicks(5847));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HighPriority",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Reminders",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tickets");

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
    }
}
