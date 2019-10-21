using Microsoft.EntityFrameworkCore.Migrations;

namespace MasteryBlog2.Migrations
{
    public partial class AddedGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Genre",
                value: "Adult");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Genre" },
                values: new object[,]
                {
                    { 3, "Horror" },
                    { 4, "Sci-Fi" },
                    { 5, "Non-Fiction" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Genre",
                value: "Erotica");
        }
    }
}
