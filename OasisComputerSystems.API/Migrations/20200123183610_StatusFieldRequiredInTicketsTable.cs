using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OasisComputerSystems.API.Migrations
{
    public partial class StatusFieldRequiredInTicketsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Tickets",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
    }
}
