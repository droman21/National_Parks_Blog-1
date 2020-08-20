using Microsoft.EntityFrameworkCore.Migrations;

namespace National_Park_Blog.Migrations
{
    public partial class AuthorSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogAuthor",
                table: "BlogContent",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 1,
                column: "BlogAuthor",
                value: "Bob Smith");

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 2,
                column: "BlogAuthor",
                value: "Daniel Roman");

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 3,
                column: "BlogAuthor",
                value: "Chuck Robinson");

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 4,
                column: "BlogAuthor",
                value: "Dakota Whittle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogAuthor",
                table: "BlogContent");
        }
    }
}
