using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "80d74367-3b5b-4eda-9cc4-bffc3629c5a0", "45da007e-cefc-4591-afad-bc7577deed53", "Manager", "MANAGER" },
                    { "ebc1a5d5-0d6a-4ece-a43f-5847b7cbd918", "ed148686-9f71-4b0f-8517-9de6475b3f66", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d74367-3b5b-4eda-9cc4-bffc3629c5a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebc1a5d5-0d6a-4ece-a43f-5847b7cbd918");
        }
    }
}
