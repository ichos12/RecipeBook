using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeBook.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Username" },
                values: new object[] { "2045195227", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Username" },
                values: new object[] { "1277884380", null });
        }
    }
}
