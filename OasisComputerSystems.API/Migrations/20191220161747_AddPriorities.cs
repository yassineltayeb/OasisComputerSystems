using Microsoft.EntityFrameworkCore.Migrations;

namespace OasisComputerSystems.API.Migrations
{
    public partial class AddPriorities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Low" },
                    { 2, "Normal" },
                    { 3, "High" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "178e024c-c940-480e-a5e0-89418998a80f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "04ae0d91-f8e5-47b8-9aae-f4be35c5601b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f6ee9aad-4deb-46b7-837e-a29211d249d9");
        }
    }
}
