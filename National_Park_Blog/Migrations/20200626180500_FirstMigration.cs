using Microsoft.EntityFrameworkCore.Migrations;

namespace National_Park_Blog.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalParks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalParks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogContentName = table.Column<string>(nullable: false),
                    BlogContentText = table.Column<string>(nullable: false),
                    BlogContentDate = table.Column<string>(nullable: true),
                    NationalParkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogContent_NationalParks_NationalParkId",
                        column: x => x.NationalParkId,
                        principalTable: "NationalParks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "Id", "Description", "Image", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Impressive park, a natural beauty", "/images/Black_River_Reservation.jpg", "Ohio", "Black River Reservation" },
                    { 2, "Gateway to Yellowstone National Park", "/images/Gallatin_Sign.jpg", "Montana", "Gallatin National Park" },
                    { 3, "The Crown of the Continent", "Glacier_Park_Sign.jpg", "Montana", "Glacier National Park" },
                    { 4, "Totally Safe", "Rocky_River_Park.jpg", "Ohio", "Rocky River Reservation" }
                });

            migrationBuilder.InsertData(
                table: "BlogContent",
                columns: new[] { "Id", "BlogContentDate", "BlogContentName", "BlogContentText", "NationalParkId" },
                values: new object[,]
                {
                    { 1, "06-18-2020", "Ron", "Not too far away, very relaxing, great park.", 1 },
                    { 2, "06-18-2020", "Dan", "Totally awesome, once in a lifetime experience", 2 },
                    { 3, "06-18-2020", "Chuck", "Ran into many blockers during the trip, a bear raided my campsite", 3 },
                    { 4, "06-18-2020", "Tom", "I became one with Nature, 10/10 would recommend", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogContent_NationalParkId",
                table: "BlogContent",
                column: "NationalParkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogContent");

            migrationBuilder.DropTable(
                name: "NationalParks");
        }
    }
}
