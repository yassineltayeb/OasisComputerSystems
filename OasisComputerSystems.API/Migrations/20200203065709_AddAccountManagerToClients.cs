using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OasisComputerSystems.API.Migrations
{
    public partial class AddAccountManagerToClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountManagerId",
                table: "Clients",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2df95287-cc3f-4d08-b572-3f0cc406c0d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "256db3e4-bb6c-405b-a78b-f03794c2728b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6a53e542-310b-43d8-9fa2-346457379901");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 3, 8, 57, 8, 556, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AccountManagerId",
                table: "Clients",
                column: "AccountManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_AccountManagerId",
                table: "Clients",
                column: "AccountManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_AccountManagerId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AccountManagerId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AccountManagerId",
                table: "Clients");

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
    }
}
