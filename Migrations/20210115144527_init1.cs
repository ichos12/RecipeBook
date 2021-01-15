using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeBook.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Description", "RecipeImageURL", "RecipeRating", "RecipeTypeId", "Title", "TypeId", "UserId" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.", null, 3, 1, "First Dish", null, 1 },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.", null, 5, 2, "Second Dish", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "TypeId", "Title" },
                values: new object[,]
                {
                    { 1, "First Dish" },
                    { 2, "Second Dish" },
                    { 3, "Dessert" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "qwerty");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Country", "Email", "PasswordHash", "Type", "Username" },
                values: new object[,]
                {
                    { 2, "Russia", "mail@mail.ru", "12345", 0, "mail" },
                    { 3, "US", "fail@mail.ru", "12345678", 1, "fail" }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackId", "Body", "Rating", "RecipeId", "UserId" },
                values: new object[,]
                {
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.", 1, 1, 3 },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.", 3, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Description", "RecipeImageURL", "RecipeRating", "RecipeTypeId", "Title", "TypeId", "UserId" },
                values: new object[,]
                {
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.", null, 1, 2, "Second Dish", null, 2 },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.", null, 0, 3, "Dessert", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackId", "Body", "Rating", "RecipeId", "UserId" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.", 3, 3, 1 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackId", "Body", "Rating", "RecipeId", "UserId" },
                values: new object[] { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed felis magna, cursus eget bibendum et, sodales et enim. Integer nec magna id eros aliquet tincidunt quis sodales sem. Vivamus posuere sit amet eros sit amet bibendum. Integer vitae quam quis urna vestibulum accumsan. Aliquam mauris enim, dictum in dapibus sit amet, pulvinar vel ipsum.", 0, 4, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "2045195227");
        }
    }
}
