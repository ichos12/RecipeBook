using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeBook.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTypes_Recipes_RecipeId",
                table: "RecipeTypes");

            migrationBuilder.DropIndex(
                name: "IX_RecipeTypes_RecipeId",
                table: "RecipeTypes");

            migrationBuilder.AddColumn<int>(
                name: "RecipeId1",
                table: "RecipeTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecipeTypeId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Country", "Email", "PasswordHash", "Type", "Username" },
                values: new object[] { 1, null, "admin@mail.ru", "1277884380", 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTypes_RecipeId1",
                table: "RecipeTypes",
                column: "RecipeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_TypeId",
                table: "Recipes",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Types_TypeId",
                table: "Recipes",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTypes_Recipes_RecipeId1",
                table: "RecipeTypes",
                column: "RecipeId1",
                principalTable: "Recipes",
                principalColumn: "RecipeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Types_TypeId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTypes_Recipes_RecipeId1",
                table: "RecipeTypes");

            migrationBuilder.DropIndex(
                name: "IX_RecipeTypes_RecipeId1",
                table: "RecipeTypes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_TypeId",
                table: "Recipes");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "RecipeId1",
                table: "RecipeTypes");

            migrationBuilder.DropColumn(
                name: "RecipeTypeId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Recipes");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTypes_RecipeId",
                table: "RecipeTypes",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTypes_Recipes_RecipeId",
                table: "RecipeTypes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "RecipeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
