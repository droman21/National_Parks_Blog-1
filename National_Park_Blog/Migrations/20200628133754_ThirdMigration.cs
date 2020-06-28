using Microsoft.EntityFrameworkCore.Migrations;

namespace National_Park_Blog.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "Black_River_Reservation.jpg");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "Gallatin_Sign.jpg");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
