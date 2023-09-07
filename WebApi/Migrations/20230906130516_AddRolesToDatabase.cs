using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20766ab6-ea9c-46f4-8014-a8d38454821e", "094ab1f3-7cc9-4692-9e84-1ca35aafbad4", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27fe82ff-5c49-43f0-8d64-7c87aefb97d8", "cf637ce2-c3a7-4cfd-a7c4-4ee32305a6f2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62e1c8d3-242b-4eba-a57e-145910ae7e32", "2be6b355-74a3-4914-8488-b1cda3c78c3a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20766ab6-ea9c-46f4-8014-a8d38454821e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27fe82ff-5c49-43f0-8d64-7c87aefb97d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62e1c8d3-242b-4eba-a57e-145910ae7e32");
        }
    }
}
