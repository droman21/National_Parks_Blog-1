using Microsoft.EntityFrameworkCore.Migrations;

namespace National_Park_Blog.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BlogContentText",
                table: "BlogContent",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BlogContentName",
                table: "BlogContent",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 1,
                column: "BlogContentName",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 4,
                column: "BlogContentName",
                value: "Dakota");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BlogContentText",
                table: "BlogContent",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BlogContentName",
                table: "BlogContent",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 1,
                column: "BlogContentName",
                value: "Ron");

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 4,
                column: "BlogContentName",
                value: "Tom");
        }
    }
}
