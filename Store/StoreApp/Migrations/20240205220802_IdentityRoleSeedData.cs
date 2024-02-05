using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.Migrations
{
    /// <inheritdoc />
    public partial class IdentityRoleSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01b47ab9-71ca-45d6-8470-1f9d5451e1dd", "f50fed1c-7790-4ad4-9d7f-fa99b29ea6d1", "Admin", "ADMIN" },
                    { "6e5995cf-e3b5-4761-b6f1-709d2fab05fb", "581aacce-8432-4801-899f-17dabf7edf25", "Editor", "EDITOR" },
                    { "9f1c6c94-a432-482d-bfd5-70b2ae964a5b", "77019ee2-ac20-4259-8dc6-9a6c457e58bf", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01b47ab9-71ca-45d6-8470-1f9d5451e1dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e5995cf-e3b5-4761-b6f1-709d2fab05fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f1c6c94-a432-482d-bfd5-70b2ae964a5b");
        }
    }
}
