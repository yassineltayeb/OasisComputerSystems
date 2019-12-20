using Microsoft.EntityFrameworkCore.Migrations;

namespace OasisComputerSystems.API.Migrations
{
    public partial class AddTicketTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9ae53380-63cc-4b7b-9f68-76e7cdb34c43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "12ff3dc6-5ef3-4877-88b4-7c4055fcee0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "be505496-0fc0-4686-b139-a2869cb153aa");

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Technical Support" },
                    { 2, "System Bug" },
                    { 3, "Change Request" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketTypes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1a18a3e9-8c10-467e-af9a-8151569e2beb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "aa79aef4-2a46-4225-89d7-bc348890e564");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "28b76dc4-a2a0-4c36-b21a-653454471c30");
        }
    }
}
