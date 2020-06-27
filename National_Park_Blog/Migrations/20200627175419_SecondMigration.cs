using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace National_Park_Blog.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogContentDate",
                table: "BlogContent",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 1,
                column: "BlogContentDate",
                value: new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 2,
                column: "BlogContentDate",
                value: new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 3,
                column: "BlogContentDate",
                value: new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 4,
                column: "BlogContentDate",
                value: new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/Images/Black_River_Reservation.jpg");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/Images/Gallatin_Sign.jpg");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/Images/Glacier_Park_Sign.jpg");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/Images/Rocky_River_Park.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BlogContentDate",
                table: "BlogContent",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 1,
                column: "BlogContentDate",
                value: "06-18-2020");

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 2,
                column: "BlogContentDate",
                value: "06-18-2020");

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 3,
                column: "BlogContentDate",
                value: "06-18-2020");

            migrationBuilder.UpdateData(
                table: "BlogContent",
                keyColumn: "Id",
                keyValue: 4,
                column: "BlogContentDate",
                value: "06-18-2020");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/images/Black_River_Reservation.jpg");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/images/Gallatin_Sign.jpg");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "Glacier_Park_Sign.jpg");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "Rocky_River_Park.jpg");
        }
    }
}
